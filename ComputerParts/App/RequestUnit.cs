using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ComputerParts.App
{
    public partial class RequestUnit : UserControl
    {
        SQLConfig config = new SQLConfig();
        string sql;
        private MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=dbmonitoring;sslMode=none");
        private MySqlCommand cmd;
        public DataTable dt;
        public RequestUnit()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            var @minusQty = nudQuantity.ToString();
            sql = "INSERT INTO `tblrequests`(`FullName`, `Email`, `ContactNo`, `ItemToRequest`, `Quantity`, `DateRequested`) " + "VALUES ('" + tbxFullName.Text + "','" + tbxEmail.Text + "','" + tbxContactNo.Text + "','" + tbxItemToReq.Text + "', '" + nudQuantity.Text + "', Now())";
            config.Execute_CUD(sql, "error to execute the query.", "Item requested!");

            
            int qty_s = (int)nudQuantity.Value;
            string desc = tbxItemToReq.Text;
            sql = "UPDATE tblitems SET Quantity=Quantity-@quantity WHERE Description=@description";
            cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@quantity", qty_s);
            cmd.Parameters.AddWithValue("@description", desc);

            ClearTextBoxes(this.Controls);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            FillDataGridView();
        }



        private void btnItemToReq_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestUnit_Load(object sender, EventArgs e)
        {
            sql = "select Description from tblitems";
            config.autocomplete(sql, tbxItemToReq);
            FillDataGridView();
        }

        protected void FillDataGridView()
        {
            config.Load_DTG("SELECT * FROM tblrequests", dtgReq);
        }
        private void ClearTextBoxes(ControlCollection controls)
        {
            foreach (TextBox tb in controls.OfType<TextBox>())
                tb.Text = string.Empty;
            foreach (Control c in controls)
                ClearTextBoxes(c.Controls);
        }
    }
}
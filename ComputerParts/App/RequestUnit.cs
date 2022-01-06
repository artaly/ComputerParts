using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerParts.App
{
    public partial class RequestUnit : UserControl
    {
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int maxrow;

        public RequestUnit()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO `tblrequests`(`FullName`, `Email`, `ContactNo`, `ItemToRequest`, `Quantity`, `DateRequested`) " + "VALUES ('" + tbxFullName.Text + "','" + tbxEmail.Text + "','" + tbxContactNo.Text + "','" + tbxItemToReq.Text + "', '" + nudQuantity.Text + "', Now())";
            config.Execute_CUD(sql, "error to execute the query.", "Item requested!");
            ClearTextBoxes(this.Controls);
        }

        private void btnItemToReq_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestUnit_Load(object sender, EventArgs e)
        {
            sql = "select Description from tblitems";
            config.autocomplete(sql, tbxItemToReq);

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
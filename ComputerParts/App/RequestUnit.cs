﻿using System;
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
        private MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter da = new MySqlDataAdapter();
        public DataTable dt;
        public RequestUnit()
        {
            InitializeComponent();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {

            cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT Quantity FROM tblitems WHERE Description='" + tbxItemToReq.Text + "'";

            var obj = cmd.ExecuteScalar();
            int quantityNo = obj != null ? (int)obj : 0;

            if (nudQuantity.Value <= quantityNo)
            {
                sql = "INSERT INTO `tblrequests`(`FullName`, `Email`, `ContactNo`, `ItemToRequest`, `Quantity`, `DateRequested`, `RequestedBy`) " + "VALUES ('" + tbxFullName.Text + "','" + tbxEmail.Text + "','" + tbxContactNo.Text + "','" + tbxItemToReq.Text + "', '" + nudQuantity.Text + "',Now(),'" + Login.GetUserAccountName.ToString() + "')";
                config.Execute_CUD(sql, "error to execute the query.", "Item requested!");


                int qty_s = (int)nudQuantity.Value;

                string desc = tbxItemToReq.Text;
                sql = "UPDATE tblitems SET Quantity=Quantity-@quantity WHERE Description=@description";
                cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@quantity", qty_s);
                cmd.Parameters.AddWithValue("@description", desc);

                ClearTextBoxes(this.Controls);

                cmd.ExecuteNonQuery();
                FillDataGridView();
            }
            else if (quantityNo != 0 && nudQuantity.Value > quantityNo)
            {
                MessageBox.Show("Insufficient stocks!");
                ClearTextBoxes(this.Controls);
            }
            else if (quantityNo == 0 && nudQuantity.Value > quantityNo)
            {
                MessageBox.Show("No stocks left for this item!");
                ClearTextBoxes(this.Controls);
            }


            con.Close();
        }



        private void btnItemToReq_TextChanged(object sender, EventArgs e)
        {

        }

        private void RequestUnit_Load(object sender, EventArgs e)
        {
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Format = DateTimePickerFormat.Custom;

            dtpFromDate.CustomFormat = "yyyy-MM-dd";
            dtpToDate.CustomFormat = "yyyy-MM-dd";
            sql = "select Description from tblitems";
            config.autocomplete(sql, tbxItemToReq);
            FillDataGridView();
        }

        protected void FillDataGridView()
        {
            config.Load_DTG("SELECT * FROM tblrequests ORDER BY DateRequested DESC", dtgReq);
        }
        private void ClearTextBoxes(ControlCollection controls)
        {
            foreach (TextBox tb in controls.OfType<TextBox>())
                tb.Text = string.Empty;
            foreach (Control c in controls)
                ClearTextBoxes(c.Controls);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            sql = "SELECT * FROM tblrequests WHERE DateRequested>='" + dtpFromDate.Text + "' AND DateRequested<='" + dtpToDate.Text + "' ORDER BY DateRequested DESC";
            cmd = new MySqlCommand(sql, con);

            da = new MySqlDataAdapter(cmd);
            con.Close();

            dt = new DataTable();
            da.Fill(dt);

            dtgReq.DataSource = dt;
            dtgReq.Refresh();
        }

        private void btnClearS_Click(object sender, EventArgs e)
        {
            config.Load_DTG("SELECT * FROM tblrequests ORDER BY DateRequested ASC", dtgReq);
        }
    }
}
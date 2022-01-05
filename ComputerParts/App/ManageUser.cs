using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerParts.App
{
    public partial class ManageUser : UserControl
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        int CompSetID, maxrow;

        private void dtg_listUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_id.Text = dtg_listUser.CurrentRow.Cells[0].Value.ToString();
            txt_name.Text = dtg_listUser.CurrentRow.Cells[1].Value.ToString();
            txt_username.Text = dtg_listUser.CurrentRow.Cells[2].Value.ToString();
            cbo_type.Text = dtg_listUser.CurrentRow.Cells[3].Value.ToString();

            if (lbl_id.Text == "id")
            {
                btnUpdate.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_pass.Text == "" || txt_username.Text == "")
            {
                funct.messagerequired();
            }


            sql = "insert into tbluseraccounts (`Fullname`, `Username`, `Pass`, `Role`,`Status`) "
             + "values('" + txt_name.Text + "','" + txt_username.Text
             + "',sha1('" + txt_pass.Text + "'),'" + cbo_type.Text
             + "','Active')";
            config.Execute_CUD(sql, "error to execute the query.", "New User has been saved in the database.");
            FillDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_pass.Text == "" || txt_username.Text == "")
            {
                funct.messagerequired();
            }

            sql = "update tbluseraccounts set Fullname = '" + txt_name.Text + "',Username= '" + txt_username.Text
                + "',Pass= sha1('" + txt_pass.Text + "'),Role= '" + cbo_type.Text
                + "' where UserID = " + lbl_id.Text;
            config.Execute_CUD(sql, "error to execute the query.", "User has been updated in the database.");
            FillDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sql = "DELETE FROM tbluseraccounts  where UserID = " + lbl_id.Text;
            config.Execute_CUD(sql, "error to execute the query.", "User has been deleted in the database.");
            btnNew_Click(sender, e);
            FillDataGridView();
        }

        private void ClearTextBoxes(ControlCollection controls)
        {
            foreach (TextBox tb in controls.OfType<TextBox>())
                tb.Text = string.Empty;
            foreach (Control c in controls)
                ClearTextBoxes(c.Controls);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
            lbl_id.Text = "id";
            funct.clearTxt(this);
            cbo_type.Text = "Administrator";
            config.Load_DTG("Select UserID as 'ID' ,Fullname as 'Name',Username as 'Username',Role as 'Type' From tbluseraccounts WHERE Status='Active'", dtg_listUser);
            dtg_listUser.Columns[0].Visible = false;
            if (lbl_id.Text == "id")
            {
                btnUpdate.Enabled = false;
                btnUpdate.Enabled = false;
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private void cbHide_OnChange(object sender, EventArgs e)
        {
            if (cbHide.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        protected void FillDataGridView()
        {
            config.Load_DTG("Select UserID as 'ID' ,Fullname as 'Name',Username as 'Username',Role as 'Type' From tbluseraccounts WHERE Status='Active'", dtg_listUser);

        }

    }
}

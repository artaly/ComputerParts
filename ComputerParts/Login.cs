using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerParts
{
    public partial class Login : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;
        int maxrow;

        public Login()
        {
            InitializeComponent();
        }
        // comment lang
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("h:mm:ss tt");

            DateTime date = DateTime.Now;
            lblDate.Text = string.Format("{0:D}", date);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact administrator");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `tbluseraccounts` WHERE Username= '" + txtUsername.Text + "' and Pass = sha1('" + txtPassword.Text + "')";
            maxrow = config.maxrow(sql);
            if (maxrow > 0)
            {
                this.Close();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Account does not exist.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

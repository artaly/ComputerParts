using ComputerParts.Forms;
using MySql.Data.MySqlClient;
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
        private MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=dbmonitoring;sslMode=none");
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
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
                sql = "Select Role from tbluseraccounts WHERE Username=@user";
                using (MySqlCommand  cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    con.Open();
                    string role = cmd.ExecuteScalar()?.ToString();
                    if (role == "Administrator")
                    {
                        //lblForgot.Text = role;
                        this.Close();
                        Dashboard adminDB = new Dashboard();
                        adminDB.ShowDialog();
                    }
                    else if (role == "Staff")
                    {
                        //lblForgot.Text = role;
                        this.Close();
                        UserDashboard userDB = new UserDashboard();
                        userDB.ShowDialog(); 
                    }
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Account does not exist.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        }
    
}

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
        private MySqlDataReader reader;
        public static string GetUserAccountName;
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
            sql = "SELECT * FROM tbluseraccounts WHERE Username='" + txtUsername.Text + "' AND Pass = sha1('" + txtPassword.Text + "')";
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=dbmonitoring;sslMode=none");
            con.Close();
            con.Open();
            cmd = new MySqlCommand(sql, con);

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                GetUserAccountName = reader["Fullname"].ToString();
            }
            con.Close();



            cmd = new MySqlCommand("SELECT * FROM `tbluseraccounts` WHERE Username = '" + txtUsername.Text + "' and Pass = sha1('" + txtPassword.Text + "')", con);
            con.Open();
            MySqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            int count = 0;
            string role = string.Empty;

            while (myReader.Read())
            {
                count = count + 1;
                role = myReader["Role"].ToString();
            }
            if (count == 1)
            {
                this.Hide();
                if (role == "Staff") {
                    UserDashboard userDB = new UserDashboard();
                    userDB.ShowDialog();
                }
                else
                {
                    Dashboard adminDB = new Dashboard();
                    adminDB.ShowDialog();
                }
                           
            }
            con.Close();
        }
    }
}


         

            
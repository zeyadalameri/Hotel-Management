using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using zeyadhotel.all_user_control;

namespace zeyadhotel
{
    public partial class Login : Form
    {
        Function function = new Function();
        String query;

        public Login()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String usr = txtusername.Text.Trim();
            String pwd = txtpassword.Text;

            if (string.IsNullOrWhiteSpace(usr) || string.IsNullOrWhiteSpace(pwd))
            {
                lableerror.Text = "Please enter username and password";
                lableerror.Visible = true;
                return;
            }

            query = "SELECT username, pass FROM Employee WHERE username = @username AND pass = @password";

            using (SqlDataReader rs = function.Login(query,
                new SqlParameter("@username", usr),
                new SqlParameter("@password", pwd)))
            {
                if (rs.HasRows)
                {
                    log a = new log();
                    a.add_log(usr, "User logged in successfully");
                    lableerror.Visible = false;

                    Dashboard ds = new Dashboard(usr);
                    ds.Show();
                    this.Hide();
                }
                else
                {
                    lableerror.Text = "Wrong Username or Password";
                    lableerror.Visible = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

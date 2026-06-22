using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using zeyadhotel.all_user_control;
namespace zeyadhotel
{
    public partial class Login : Form
    {
        Function function = new Function();
        SqlCommand cmd = new SqlCommand();
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

            String usr = txtusername.Text;
            String pwd = txtpassword.Text;
            query = $"SELECT username,pass FROM Employee where username ='{usr}' and pass = '{pwd}'";
         
            SqlDataReader rs = function.Login(query);

           
           
            if (rs.HasRows)
            {
                log a = new log();
                a.add_log(usr, query);
                lableerror.Visible = false;
                Dashboard ds = new Dashboard(usr);
                zeyadhotel.all_user_control.UC_Addroom s = new zeyadhotel.all_user_control.UC_Addroom(usr);   
                ds.Show();
                this.Hide();
                
            
            }
            else
            {
                lableerror.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;


namespace zeyadhotel.all_user_control
{
    public partial class UC_Employees : UserControl
    {
    
        public UC_Employees()
        {
            InitializeComponent();
        }
        Function function = new Function();
        String query;
        

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employees_Load(object sender, EventArgs e)
        {

            GetMaxID();
            clearAll();
        }
        public void GetMaxID()
        {
            query = "select max(eid)+1 from employee";
            DataSet ds = function.GetData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                lblID.Text = num.ToString();

            }
        }
        void lg(string q)
        {
            log a = new log();
            a.add_log(Dashboard.name, query);
        }
        private void btnEmpreg_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUser.Text != "" && txtPass.Text != "" &&txtAdmin.Text!="")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String email = txtEmail.Text;
                String user = txtUser.Text;
                String pass = txtPass.Text;
                String admin = txtAdmin.Text;

               string squery = $"insert into employee(ename,mobile,gender,emailid,username,pass,admin) values ('{name}',{mobile},'{gender}','{email}','{user}','{pass}','{admin}')";
                function.setData(squery, " Employee Added successfully");
                lg(squery);
                UC_Employees_Load(this,null);

            }
            else
            {
                MessageBox.Show("Fill all feileds", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2TabControl1.SelectedIndex == 1)
            {
                setEmpGrid(DataGridView2);
            }
            else if (guna2TabControl1.SelectedIndex == 2)
            {
                setEmpGrid(DataGridView1);

            }
        }
        public void setEmpGrid(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = function.GetData(query);
            dgv.DataSource = ds.Tables[0];

        }
        public void clearAll()
        {
            txtEmail.Clear();
            txtGender.SelectedIndex = -1;
            txtId.Clear();
            txtMobile.Clear();
            txtName.Clear();
            txtPass.Clear();
            txtUser.Clear();
            txtAdmin.SelectedIndex = -1;
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void bLog_Click(object sender, EventArgs e)
        {
            log x = new log();
            x.Show();   
        }
    }
}

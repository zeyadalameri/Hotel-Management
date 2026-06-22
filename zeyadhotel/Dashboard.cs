using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zeyadhotel
{
    public partial class Dashboard : Form
    {
        public Dashboard(string name)
        {
            InitializeComponent();
            Dashboard.name = name;
        }
        Function fn = new Function();
        String query;
        //Form1 form1 = new Form1();


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
         static public string name;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Addroom1.Visible = false;
            uC_CustomerRegisteration1.Visible = false;
            uC_checkout1.Visible = false;
            uC_CustomerDetails1.Visible = false;
            uC_Employees1.Visible = false;
            query = $"select admin,ename from employee where  username = '{name}' ";
           DataSet ds = fn.GetData(query);
            lableUser.Text = ds.Tables[0].Rows[0][1].ToString().ToUpper();
            if (ds.Tables[0].Rows[0][0].ToString() =="user")
            {
                uC_Addroom1.Enabled = false;
                uC_Employees1.Enabled = false;
                btnCustomerRegistration.PerformClick();

            }
            else if (ds.Tables[0].Rows[0][0].ToString() == "admin")
            {
            btnAddRoom.PerformClick();
                uC_Addroom1.Enabled = true;
                uC_Employees1.Enabled = true;
            }




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnAddRoom.Left;
            uC_Addroom1.Visible = true;
            uC_Addroom1.BringToFront();
            uC_Addroom1.Refresh();

        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnCustomerRegistration.Left;
            uC_CustomerRegisteration1.Visible = true;
            uC_checkout1.Visible = false;
            uC_CustomerRegisteration1.BringToFront();

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnCheckOut.Left;
            uC_checkout1.Visible = true;
            uC_checkout1.BringToFront();
        }

        private void btnCustomerDetailes_Click(object sender, EventArgs e)
        {
            movingPanel.Left = btnCustomerDetailes.Left;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
          
            movingPanel.Left = btnEmployee.Left;
            uC_Employees1.Visible = true;
            uC_Employees1.BringToFront();


        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            Dashboard_Load(this, null);
        }

        private void lableUser_Click(object sender, EventArgs e)
        {

        }

        private void uC_Employees1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void movingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

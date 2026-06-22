using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace zeyadhotel.all_user_control
{
    public partial class UC_Addroom : UserControl
    {
       
        
        public UC_Addroom(string name)
        {
            InitializeComponent();
           

        }

        public UC_Addroom()
        {
            InitializeComponent();
            this.name = name;
        }

        public string name{ get; set; }
        Function fun = new Function();
        String query;
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void UC_Addroom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fun.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];

           

        }

        private void AddRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoomForm_Click(object sender, EventArgs e)
        {

            if (txtroomno.Text != "" && txtroomtype.Text != "" && txtprice.Text != "" && txtbed.Text != "")
            {
                String roomnum = txtroomno.Text;
                String roomtype = txtroomtype.Text;
                String bed = txtbed.Text;
                Int64 price = Convert.ToInt64(txtprice.Text);
                log a = new log();
             string   squery = "insert into rooms(roomnum,roomtype,bed,price) values ('" + roomnum + "','" + roomtype + "','" + bed + "'," + price + ")";
                
                fun.setData(squery, "Room Added");
                UC_Addroom_Load(this, null);
                a.add_log(Dashboard.name, squery);


            }
            else
            {
                MessageBox.Show("One or more fieldes are empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            clearAll();

        }
        public void clearAll()
        {
            txtbed.SelectedIndex = -1;
            txtprice.Clear();
            txtroomno.Clear();
            txtroomtype.SelectedIndex = -1;
        }

        private void UC_Addroom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_Addroom_Enter(object sender, EventArgs e)
        {
            UC_Addroom_Load(this, null);
        }

        private void txtbed_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtbed.Text != "" && txtroomtype.Text != "")
            {
                if (txtroomtype.Text == "AC")
                {
                    if (txtbed.Text == "Single")
                    {
                        txtprice.Text = "3000";

                    }
                    else if (txtbed.Text == "Double")
                    {
                        txtprice.Text = "5000";
                    }
                    else if (txtbed.Text == "King")
                    {
                        txtprice.Text = "7000";
                    }

                }
                else if (txtroomtype.Text == "NoN-AC")
                {
                    if (txtbed.Text == "Single")
                    {
                        txtprice.Text = "2000";

                    }
                    else if (txtbed.Text == "Double")
                    {
                        txtprice.Text = "4000";
                    }
                    else if (txtbed.Text == "King")
                    {
                        txtprice.Text = "6000";
                    }

                }

            }
        }

        private void txtroomno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

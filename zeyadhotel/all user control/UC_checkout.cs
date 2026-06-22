using System;
using System.Data;
using System.Windows.Forms;

namespace zeyadhotel.all_user_control
{
    public partial class UC_checkout : UserControl
    {
        public UC_checkout()
        {
            InitializeComponent();
        }
        Function fun = new Function();
        String query;
        private void UC_checkout_Load(object sender, EventArgs e)
        {

            query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomnum, rooms.roomtype, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where chekout= 'NO'";
            DataSet ds = fun.GetData(query);
            dataGrid.DataSource = ds.Tables[0];
            clearAll();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT customer.*, rooms.* FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where cname like'" + txtName.Text + "%' AND chekout= 'NO'";
            DataSet ds = fun.GetData(query);
            dataGrid.DataSource = ds.Tables[0];
        }
        int id;
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (dataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    id = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtCname.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtRoomno.Text = dataGrid.Rows[e.RowIndex].Cells[9].Value.ToString();



                }
            }
            catch 
            {

                MessageBox.Show("Something went wrong try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        void lg(string q)
        {
            log a = new log();
            a.add_log(Dashboard.name, query);
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (txtCname.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var cdate = txtCheckoutDate.Text;
                  string  squery = "update customer set chekout = 'YES',checkout = '" + cdate + "' where cid =" + id + " ; UPDATE rooms set booked ='NO' where roomnum = " + txtRoomno.Text + ";";
                    fun.setData(squery, "Customer Checked out");
                    UC_checkout_Load(this, null);

                    lg(squery);


                }

            }
            else
            {
                MessageBox.Show("No customer selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void clearAll()
        {
            txtRoomno.Clear();
            txtCname.Clear();
            txtCheckoutDate.ResetText();

        }

        private void UC_checkout_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace zeyadhotel.all_user_control
{
    public partial class UC_CustomerDetails : UserControl
    {
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }
        Function fun = new Function();
        String query;

        private void UC_CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearch.SelectedIndex == 0)
            {
                query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomnum, rooms.roomtype, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid";
                DataSet ds = fun.GetData(query);
                dataGrid.DataSource = ds.Tables[0];

            }
            else if (txtSearch.SelectedIndex == 1)
            {
                query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomnum, rooms.roomtype, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where checkout is null";
                DataSet ds = fun.GetData(query);

                dataGrid.DataSource = ds.Tables[0];
            }
            else if (txtSearch.SelectedIndex == 2)
            {
                query = "SELECT customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, customer.checkin, rooms.roomnum, rooms.roomtype, rooms.bed, rooms.price FROM customer INNER JOIN rooms ON customer.roomid = rooms.roomid where checkout is not null";
                DataSet ds = fun.GetData(query);

                dataGrid.DataSource = ds.Tables[0];
            }
        }
    }
}

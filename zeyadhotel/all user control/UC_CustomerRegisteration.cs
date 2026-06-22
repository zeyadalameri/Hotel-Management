using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zeyadhotel.all_user_control
{
   
    public partial class UC_CustomerRegisteration : UserControl
    {
        Function fn = new Function();
        String query;
        public UC_CustomerRegisteration()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetValue((i)));
                }
            }
            sdr.Close();

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRoomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Clear();
            query = "select roomnum from rooms where bed ='" + txtBed.Text + "' and roomtype = '" + txtRoomtype.Text + "' and booked ='NO'";
            setComboBox(query, txtRoomNo);
            txtRoomNo.Select();
            query = "select price from rooms where bed ='" + txtBed.Text + "' and roomtype = '" + txtRoomtype.Text + "' and booked ='NO'";
            settxtbox(query, txtPrice);

        }

        private void settxtbox(string query, Guna2TextBox txtPrice)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    txtPrice.Text = sdr.GetValue((i)).ToString();
                }
            }
            sdr.Close();
        }
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select roomid from rooms where roomnum ='" + txtRoomNo.Text + "'";
            DataSet ds = fn.GetData(query);
            rid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

        }

        private void txtRoomNo_Leave(object sender, EventArgs e)
        {
            //txtRoomNo.Items.Clear();
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomtype.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }
        void lg(string q)
        {
            log a = new log();
            a.add_log(Dashboard.name, query);
        }
        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtName.Text != "" && txtMobile.Text != "" && txtNatio.Text != "" && txtGender.Text != "" && txtBday.Text != "" && txtBday.Text != "" && txtAddress.Text != "" && txtId.Text != "" && txtCheckin.Text != "" && txtRoomtype.Text != "" && txtPrice.Text != "" && txtBed.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                String nat = txtNatio.Text;
                String gender = txtGender.Text;
                String dob = txtBday.Text;
                String idProof = txtId.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckin.Text;


               string squery = " insert into customer(cname,mobile,nationality,gender,dob,idproof,address,checkin,roomid) values ('" + name + "'," + mobile + ",'" + nat + "','" + gender + "','" + dob + "','" + idProof + "','" + address + "','" + checkin + "'," + rid + ") update rooms set booked = 'YES' where roomnum = '" + txtRoomNo.Text + "'";
                fn.setData(squery, "Room No '" + txtRoomNo.Text + "' Bookd Successfully.");
                lg(squery);
            }
            else
            {
                MessageBox.Show("One or more fieldes are empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtNatio.Clear();
            txtGender.SelectedIndex = -1;
            txtBday.ResetText();
            txtId.Clear();
            txtAddress.Clear();
            txtCheckin.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoomNo.SelectedIndex = -1;
            txtRoomtype.SelectedIndex = -1;
            txtPrice.Clear();

        }

        private void UC_CustomerRegisteration_Leave(object sender, EventArgs e)
        {
            //clearAll();
        }

        private void txtCheckin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            //isDigit

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}

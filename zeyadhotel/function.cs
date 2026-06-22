using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zeyadhotel
{
    class Function
    {
        protected SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source = DESKTOP-HSIEPUP;database = Hotel; integrated security = True";
            return conn;
        }
        public DataSet GetData(String query)
        {
            DataSet ds = new DataSet(), dss = new DataSet();
            try
            {
                SqlConnection conn = GetSqlConnection();
                SqlCommand cmd = new SqlCommand
                {
                    Connection = conn,
                    CommandText = query,
                };
                
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
                return dss;

            }
        }
        public void setData(String query, String message)
        {
            try
            {
                SqlConnection con = GetSqlConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
        public SqlDataReader Login(String query)
        {
            SqlConnection conn = GetSqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd=new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            return rdr;

        }
    }
}

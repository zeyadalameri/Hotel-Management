using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace zeyadhotel
{
    class Function
    {
        protected SqlConnection GetSqlConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HotelDb"]?.ConnectionString;

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                connectionString = "Data Source=.;Initial Catalog=Hotel;Integrated Security=True;TrustServerCertificate=True";
            }

            return new SqlConnection(connectionString);
        }

        public DataSet GetData(String query, params SqlParameter[] parameters)
        {
            DataSet ds = new DataSet(), dss = new DataSet();
            try
            {
                using (SqlConnection conn = GetSqlConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return dss;
            }
        }

        public void setData(String query, String message, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection con = GetSqlConnection())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("'" + message + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("'" + ex.Message + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public SqlDataReader getForCombo(String query, params SqlParameter[] parameters)
        {
            SqlConnection con = GetSqlConnection();
            SqlCommand cmd = new SqlCommand(query, con);

            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }

            con.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public SqlDataReader Login(String query, params SqlParameter[] parameters)
        {
            SqlConnection conn = GetSqlConnection();
            SqlCommand cmd = new SqlCommand(query, conn);

            if (parameters != null && parameters.Length > 0)
            {
                cmd.Parameters.AddRange(parameters);
            }

            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

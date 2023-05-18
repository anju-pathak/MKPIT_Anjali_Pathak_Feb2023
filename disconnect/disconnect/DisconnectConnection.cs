using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace disconnect
{
    internal class DisconnectConnection
    {
        private static string ConnectionString = "server=MANISH\\SQLEXPRESSs;integrated security=true;database=movieticket;";

        // Creating a static method
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (SqlException ee)
            {
                return null;
            }
        }

        public static DataSet GetCity()
        {
            SqlConnection conn = GetConnection();
            string query = "select * from City";

            // Corrected "form" to "from"
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(ds, "City");
                return ds;
            }
            catch (SqlException ee)
            {
                return null;
            }
        }
    }
}


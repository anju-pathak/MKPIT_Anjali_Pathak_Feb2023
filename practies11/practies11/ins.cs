using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practies11
{
    public static class ins
    {
        private static string connection = "server=MANISH\\SQLEXPRESS;integrated security=true;database=institute1;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connection);
            try
            {
                conn.Open();
                return conn;
            }
            catch
            {
                return null;
            }

        }

        public static DataSet getNation()
        {
        SqlConnection conn=GetConnection();
        string query = "select * from nation";
        DataSet ds=new DataSet();
        SqlDataAdapter da=new SqlDataAdapter(query, conn);
        da.Fill(ds,"nation");
            return ds;
        }
    }
}


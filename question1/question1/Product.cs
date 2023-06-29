using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    public   class Product
    {

        private static string connectiondata= "server:MANISH\\SQLEXPRESS;integrated security=true;database:fendhal";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectiondata);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {

                return con;
            }
        }

        public static DataSet getcat()
        {
            SqlConnection con = GetConnection();
         String query = "select * from TableProductCategory";
        DataSet ds=new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
         da.Fill(ds,"cat");
            return ds;
            //public static DataSet Getprdcategory()
            //{
            //    SqlConnection conn = GetConnection();
            //    string query = "select * from TableProductCategory";
            //    DataSet ds = new DataSet();
            //    SqlDataAdapter da = new SqlDataAdapter(query, conn);
            //    da.Fill(ds, "tableproductcategory");
            //    return ds;
            }
        }
       
    }
}

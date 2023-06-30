using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace computer
{
    public static class Computer
    {
        private static string Connectionstrnig = "server=MANISH\\SQLEXPRESS;integrated security=true;database=computer;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(Connectionstrnig);
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

        public static DataSet Getcategory()
        {
            SqlConnection conn = GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "TableProductCategory");
            return ds;
        }
        public static DataSet GetProduct(string Product_Type_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "Select p.ProductTypelD,Product_Name from TableProduct p inner join TableProductCategory s on p.ProductTypelD=s.Product_Category_Id where Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
             da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name",Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        public static DataSet Getquantity(string Product_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select Avaiable_Quantity from TableProduct where Product_Name=@Product_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        public static DataSet Gettotal(string Product_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select Total_Quantity from TableProduct where Product_Name=@Product_Name";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            da.Fill(ds1, "TableProduct");
            return ds1;
        }

        public static DataSet Getprice(string Product_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select price from TableProduct where Product_Name=@Product_Name";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
            da.Fill(ds2,"TableProduct");
            return ds2;
        }
        public static DataSet Getgst(string Product_Type_Name)
        {
            SqlConnection conn = GetConnection();
            string query = " select a.cgst,a.sgst from TableProductGSTDetails a inner join  TableProductCategory b on a.Product_Gst_ID=b.Product_Gst_ID where Product_Type_Name=@Product_Type_Name";
            DataSet ds3 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name",Product_Type_Name);
            da.Fill(ds3, "TableProduct");
            return ds3;
        }
    }

}
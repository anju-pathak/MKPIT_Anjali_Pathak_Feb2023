using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fendhalll
{
    public static class Prodstore
    {
        private static string ConnectionString = "server=MANISH\\SQLEXPRESS;integrated security=true;database=fendhal;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch(Exception ex) 
            {
                return null;
            }
        }
        public static DataSet Getprdcategory()
        {
            SqlConnection conn = GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, "tableproductcategory");
            return ds;
        }
        public static DataSet Getprd(string Product_Type_Name)
        {
            SqlConnection conn= GetConnection();
            string query = "select ProductlD, p.Product_Name from TableProduct p inner join TableProductCategory s on p.ProductTypelD=s.Product_Category_ID where Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet(); 
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "tableprd");
            return ds;
        }
        public static DataSet Getgst(string Product_Type_Name)
        {
            SqlConnection conn = GetConnection();
            string query = " select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join TableProductCategory b on\r\n  a.Product_Gst_ID=a.Product_Gst_ID where Product_Type_Name =@Product_Type_Name;";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds1, "tablegst");
            return ds1;
        }
        public static DataSet Getprice(string Product_Type_Name)
        {
            SqlConnection conn = GetConnection();
            string query = "select price from TableProduct";
            DataSet ds1 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds1,"tableprice");
            return ds1;
        }
        public static string saveinvoicedetails(string Customer_Name,
      string Customer_Contact
      , int Product_Category_ID
      ,int ProductID
      ,int Residential_Type_ID
      ,DateTime Invoice_Date
      ,decimal Quantity
      ,decimal price
      ,decimal CGST
      ,decimal SGST
      , decimal IGST
      , decimal CGST_Value
      ,decimal SGST_Value
      , decimal IGST_Value
      , decimal Total_Amount)
        {
            string result=null;
            string Query = "insert into TablelnvoiceDetailss values(@Customer_Name,@Customer_Contact,@Product_Category_ID,@ProductID,@Residential_Type_ID,@Invoice_Date ,@Quantity,@price ,@CGST ,@SGST,@IGST,@CGST_Value,@SGST_value,@IGST_Value,@Total_Amount)";
            SqlConnection conn = GetConnection();
           
                SqlCommand command=new SqlCommand(Query, conn);
            command.Parameters.AddWithValue("@Customer_Name",Customer_Name);
            command.Parameters.AddWithValue("@Customer_Contact", Customer_Contact); ;
            command.Parameters.AddWithValue("@Product_Category_ID",Product_Category_ID);
            command.Parameters.AddWithValue("@ProductID" ,ProductID);
            command.Parameters.AddWithValue("@Residential_Type_ID",Residential_Type_ID);
            command.Parameters.AddWithValue("@Invoice_Date" ,Invoice_Date);
            command.Parameters.AddWithValue("@Quantity",Quantity);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@CGST",CGST);
            command.Parameters.AddWithValue("@SGST", SGST);
            command.Parameters.AddWithValue("@IGST", IGST);
            command.Parameters.AddWithValue("@CGST_Value",CGST_Value);
            command.Parameters.AddWithValue("@SGST_Value", SGST_Value);
            command.Parameters.AddWithValue("@IGST_Value",IGST_Value);
            command.Parameters.AddWithValue("@Total_Amount",Total_Amount);
            try
            {
                command.ExecuteNonQuery();
                result = "record save";

            }
            catch (Exception ex) 
            { 
                result=ex.ToString();


            }
            finally
            { conn.Close();
            }
            return result;

            


        }



    }
}


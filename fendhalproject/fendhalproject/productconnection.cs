using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace fendhalproject
{
    public static class productconnection
    {
        private static string connectionString = "server=MANISH\\sqlexpress;integrated security=true;database=fendhal";
        //method to creeate connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ee)

            {
                return null;
            }
        }

        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "Product_Type_Name");
            return ds;

        }

        public static DataSet GetTableProductName(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = " select p.ProductlD,p.product_name from TableProduct p inner join TableProductCategory t on p.ProductTypelD = t.Product_Category_ID where t.Product_Type_Name =@product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        public static DataSet GetGstDetails(string product_type_name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join tableproductcategory b on a.product_gst_id = b.product_gst_id where b.Product_Type_Name = @product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds, "tableproductgstdetails");
            return ds;

        }
        public static DataSet GetProductPrice(string product_name)
        {
            SqlConnection con = GetConnection();
            string query = "select price from tableproduct where product_name=@product_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_name", product_name);
            da.Fill(ds, "tableproduct");
            return ds;
        }

        public static string saveinvoicetable(string customer_name, string customer_Contact, int Product_catregory_id, int ProductID, int Residential_Type_id, DateTime invoice_date, decimal quantity, decimal price, decimal CGST, decimal SGST, decimal IGST, decimal CGST_Value, decimal SGST_value, decimal IGST_value, decimal Total_Amount)
        {
             string result = null;
          String query = "insert into TablelnvoiceDetailss values(@customer_name, @customer_Contact, @Product_catregory_id, @ProductID, @Residential_Type_id, @invoice_date,@quantity, @price, @CGST, @SGST, @IGST,@CGST_Value,@SGST_value,@IGST_value,@Total_Amount)";
           SqlConnection con = GetConnection();
          SqlCommand command = new SqlCommand(query, con);
                 
            command.Parameters.AddWithValue("@customer_name", customer_name);
            command.Parameters.AddWithValue("@customer_Contact", customer_Contact);          
            command.Parameters.AddWithValue("@Product_catregory_id", Product_catregory_id);
            command.Parameters.AddWithValue("@ProductID", ProductID);
            command.Parameters.AddWithValue("@Residential_Type_id", Residential_Type_id);
            command.Parameters.AddWithValue("@invoice_date", invoice_date);
            command.Parameters.AddWithValue("@quantity", quantity);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@CGST", CGST);
            command.Parameters.AddWithValue("@SGST", SGST);

            command.Parameters.AddWithValue("@IGST", IGST);
            command.Parameters.AddWithValue("@CGST_Value", CGST_Value);
            command.Parameters.AddWithValue("@SGST_value", SGST_value);
            command.Parameters.AddWithValue("@IGST_value", IGST_value);
            command.Parameters.AddWithValue("@Total_Amount", Total_Amount);
            try
            {
                command.ExecuteNonQuery();
                
                result ="record save";
            }
            catch (Exception ex)
            {
               result= ex.ToString();
            }
            finally 
            { 
                con.Close(); 
            }
            return result;

        }
    }
}





using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace doctorconnection
{
    public static class DoctorConnection
    {
        private static string connectionString = "server=MANISH\\SQLEXPRESS;integrated security=true;database=cakelink;";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }

        }
    


        public static DataSet GetEd()
        {
            SqlConnection con = GetConnection();
            string query = "select * from Ed";
            try
            {
                DataSet ds = new DataSet();//dataset class
                SqlDataAdapter da = new SqlDataAdapter(query, con);//sqladapter class
                da.Fill(ds, "Education");//fill method to open and closed connection
                return ds;
            }
            catch (Exception ee)
            {
                return null;
            }

        }




        public static string InsertRecord(string name,string Education,int Id)
        {
            SqlConnection con = GetConnection();
            string query ="insert into doctor values(@name,@education,@Id)";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@education", Education);
                command.Parameters.AddWithValue("@Id", Id);
                command.ExecuteNonQuery();
                return "inserted successfully";
            }
            catch(Exception ee)
            {
                return ee.ToString();
            }
        }
    }
}



            


    

        
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace sqlconnection
{
    internal class DatabaseConnection
    {
        private static string connectionstring = "server=MANISH\\SQLEXPRESS;database=school;integrated security=true;";
        public static  SqlConnection getconnection()
        {
            SqlConnection conn = new SqlConnection(connectionstring);
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
        public static string InsertRecord(string username,string password)
        {
            SqlConnection conn=getconnection();
            string query="insert into users values(@username,@password)";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                return "successfully inserted";
            }
            catch(Exception ex)
            {
                return ex .ToString ();
            }
            finally
            {
                conn.Close();
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace students_details
{
    internal class DatabaseConnection
    {
        private static string connectdata = "server=MANISH\\SQLEXPRESS;integrated security=true;database=school;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectdata);
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
        public static string InsertRecord(string Firstname, string lastname, string mobileno,  string course)
        {
            SqlConnection conn = GetConnection();
            string query = "insert into user1 values(@Firstname,@lastname,@mobileNo,@course)";
            try
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@FirstName", Firstname);
                command.Parameters.AddWithValue("@LastName", lastname);
                command.Parameters.AddWithValue("@mobileno", mobileno);
                command.Parameters.AddWithValue("@Course", course);
                command.ExecuteNonQuery();
                return "successfully added";
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
    }
}



    
   


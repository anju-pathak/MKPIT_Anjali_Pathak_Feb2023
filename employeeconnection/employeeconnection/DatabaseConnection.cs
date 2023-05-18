using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace employeeconnection
{
    internal class DatabaseConnection
    {
        private static string connectionString = "server=.\\sqlexpress;integrated security=true;database=cakelink";
        //creating a static method
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

        public static string InsertRecord(int employeeId, string EmployeeName,string EmployeeGender, string EmployeeEmail,int EmployeeNumber,string EmployeeCity,DateTime DateofBirth)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into emp values(@EmployeeId,@EmployeeName,@EmployeeGender,@EmployeeEmail,@EmployeeNumber,@EmployeeCity,@DateofBirth)";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@EmployeeId", employeeId);
                command.Parameters.AddWithValue("@EmployeeName", EmployeeName);
                command.Parameters.AddWithValue("@EmployeeGender", EmployeeGender);
                command.Parameters.AddWithValue("@EmployeeEmail", EmployeeEmail);
                command.Parameters.AddWithValue("@EmployeeNumber", EmployeeNumber);
                command.Parameters.AddWithValue("@EmployeeCity", EmployeeCity);
                command.Parameters.AddWithValue("@DateofBirth", DateofBirth);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }

            finally
            {
                con.Close();
            }

        }
        public static SqlDataReader Getcity()
        {
            SqlConnection con = GetConnection();
            string query = "select * from city";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                SqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch(Exception e) 
            {
                return null;
            }
            
        }
        public static string UpdateUsers(string EmployeeId, string EmployeeName)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "update emp set EmployeeId=@EmployeeId where EmployeeName=@EmployeeName";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters

                command.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                command.Parameters.AddWithValue("@EmployeeName", EmployeeName);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record updated successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }
        //creating a static method to delete record from users table
        public static string DeleteUsers(string EmployeeId)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "delete from emp where EmployeeId=@EmployeeId";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters


                command.Parameters.AddWithValue("@EmployeeId",EmployeeId);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "record deleted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }

        }
     
        

        }
    }





    

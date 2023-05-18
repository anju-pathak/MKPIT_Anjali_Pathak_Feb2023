using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.Sockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Drawing;

namespace employee_details
{
    internal class employee
    {
        private static string Dataconnection = "server=MANISH\\SQLEXPRESS ;integrated security=true;database=school ;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(Dataconnection);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string InsertRecord(string name, string address, string mobile, string salary)
        {
            SqlConnection conn = GetConnection();
            string query = "insert into user2 values(@name,@address,@mobile,@salary)";
            try
            {
                SqlCommand Command = new SqlCommand(query, conn);
                Command.Parameters.AddWithValue("@name", name);
                Command.Parameters.AddWithValue("@address", address);
                Command.Parameters.AddWithValue("@mobile", mobile);
                Command.Parameters.AddWithValue("@salary", salary);
                Command.ExecuteNonQuery();
                return "inserted succssufully";
            }
            catch { return null; }
            finally { conn.Close(); }
        }
        public static string UpadateRecord(string name, string address)
        {
            SqlConnection conn = GetConnection();
            string query = "Update user2  set EmpAddress=@address where EmpName=@name";
            try
            {
                SqlCommand Command = new SqlCommand(query, conn);
              
                Command.Parameters.AddWithValue("@address", address);
                Command.Parameters.AddWithValue("@name", name);

                Command.ExecuteNonQuery();
                return "updated succssufully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            { 
                conn.Close(); 
            }
        }

        public static string DeleteRecord(string name)
        {
            SqlConnection conn = GetConnection();
            string query = "Delete from user2 where EmpName=@Name";
            try
            {
                SqlCommand Command = new SqlCommand(query, conn);
                Command.Parameters.AddWithValue("@Name", name);
                Command.ExecuteNonQuery();
                return "record deleted succssufully";
            }
            catch (Exception e) 
            {
                return e.ToString(); 
            }
            finally
            { 
                conn.Close();
            }
        }
    }
}
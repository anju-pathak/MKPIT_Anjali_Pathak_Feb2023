using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_desgin
{
    public static class Deatils
    {
        private static string Conncetiondata = "server=MANISH\\SQLEXPRESS;integrated security=true;database=Details";
        public  static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(Conncetiondata);
            try
            {
                conn.Open();
            }
            catch
            {
                return null;
            }
            return conn;
        }

        



            public static string GetDetails( string name,int age)
        {
            string result = null;
            string query = "insert into Details values(@name,@age)";
            SqlConnection Conn = GetConnection();
                SqlCommand command=new SqlCommand(query,Conn);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@age", age);
            try
            {
                command.ExecuteNonQuery();
                result = "Record saved";
            }
            catch (Exception ex)
            {
               result= ex.ToString();
            }
            finally { Conn.Close(); }
            return result;
        }
    }
}




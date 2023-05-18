using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace empcity
{
    public static class Employeecity
    {
       private static string connectionString = "server=MANISH\\SQLEXPRESS;integrated security=true;database=school";
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

        public static string InsertRecord(string name)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "insert into names values(@name)";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@name",name);
                
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
        public static DataSet GetCity()
        {
            SqlConnection s = GetConnection();
            string query = "select * from City";
            try
            {
                DataSet ds = new DataSet();//dataset class
                SqlDataAdapter da = new SqlDataAdapter(query, s);//sqladapter class
                da.Fill(ds, "City");//fill method to open and closed connection
                return ds;
            }
            catch (Exception ee)
            {
                return null;
            }

        }
        public static DataSet searchemployee(string name)
        {
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            string qr = "select * from names where name=@name";

            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            da.SelectCommand.Parameters.AddWithValue("@name", name);
            da.Fill(ds, "name");
            return ds;
        }


    }

    }



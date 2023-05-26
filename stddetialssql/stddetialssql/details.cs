using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stddetialssql
{
    public static class details
    {
        private static string connectionstring = "server=MANISH\\SQLEXPRESS;integrated security=true;database=school;";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionstring);
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
        public static DataSet getcountry()

        {
            SqlConnection con = GetConnection();
            String query = "select * from country";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "cpuntry");
            return ds;


        }
        public static DataSet getstate(string countryname)

        {
            SqlConnection con = GetConnection();
            String query = "select s.stateid, s.statename from state s inner join country c on\r\ns.countryid=c.countryid where countryname=@countryname";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@countryname", countryname);
            da.Fill(ds, "state");
            return ds;


        }

        public static DataSet getcity(string statename)

        {
            SqlConnection con = GetConnection();
            String query = "select s.cityid, s.cityname from citys s inner join state c on s.stateid=c.stateid where statename=@statename";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@statename", statename);
            da.Fill(ds, "city");
            return ds;

        }
        public static DataSet getcourse()

        {
            SqlConnection con = GetConnection();
            String query = "select courseid,  coursename from course";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "course");
            return ds;
        }
        public static DataSet getfee(string coursename)

        {
            SqlConnection con = GetConnection();
            String query = "select fees from course where coursename=@coursename";
            DataSet ds2 = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@coursename", coursename);
            da.Fill(ds2, "fees");
            return ds2;

        }
        public static string savetable(int courseid
      , int fees
      , int countryid
      , int stateid
      , int cityid
      , string name,
      DateTime date,
      int Amount,
        int Balance)

        {
            string result = null;
            SqlConnection con = GetConnection();
            string query = "insert into addres values(@courseid,@fees,@countryid,@stateid,@cityid,@name,@date,@Amount,@Balance)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@courseid", courseid);
            command.Parameters.AddWithValue("@fees", fees);
            command.Parameters.AddWithValue("@countryid", countryid);
            command.Parameters.AddWithValue("@stateid", stateid);
            command.Parameters.AddWithValue("@cityid", cityid);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@Balance", Balance);
            try
            {
                command.ExecuteNonQuery();
                result = "record inserted";
            }
            catch (Exception ex) 
            { 
                result=ex.ToString();
            }
            finally { con.Close(); }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace institutedetails
{
    public static class Institute
    {
        private static string Connectiontring = "server=MANISH\\SQLEXPRESS;integrated security=true;database=institute1;";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(Connectiontring);
            try
            {
                //con.Open();
                return con;
            }
            catch (Exception ee)
            {
                return null;
            }
        }
        public static DataSet Getnation()
        {
            SqlConnection con = GetConnection();
            string query = "select * from nation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "tablenation");
            return ds;

        }
        public static DataSet Getstate(string nationnane)
        {
            SqlConnection con = GetConnection();
            string query = "select s.stateid,s.statename from state s inner join nation n on\r\ns.nationid=n.nationid where nationname=@nationname";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@nationname", nationnane);
            da.Fill(ds, "tablestate");
            return ds;


        }

        public static DataSet Getcity(string statenane)
        {
            SqlConnection con = GetConnection();
            string query = "select s.cityid, s.cityname from city s inner join state n on s.stateid = n.stateid where statename = @statename";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@statename", statenane);
            da.Fill(ds, "tablestate");
            return ds;

        }

        public static string insertrecord(int categoryid, string fullname, int gender)
        {
            string result = null;

            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into courseid values(@Categoryid,@fullname,@gender)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Categoryid", categoryid);
            command.Parameters.AddWithValue("@fullname", fullname);
            command.Parameters.AddWithValue("@gender", gender);
            command.ExecuteNonQuery();
            con.Close();
            return "recorved saved";

        }
        static int courseregid = 0;
        public static string savetableregaddress(int nationid, int stateid, int cityid)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "SELECT top 1 courseregid FROM  courseid ORDER BY  courseregid  DESC ";
            SqlCommand command = new SqlCommand(query, con);
            courseregid = Convert.ToInt32(command.ExecuteScalar());
            query = "insert into addres values(@courseregid,@nationid,@stateid,@cityid)";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@courseregid", courseregid);
            command.Parameters.AddWithValue("@nationid", nationid);
            command.Parameters.AddWithValue("@stateid", stateid);
            command.Parameters.AddWithValue("@cityid", cityid);

            command.ExecuteNonQuery();
            con.Close();
            return "record saved in tablecoursedetail";
        }
        public static string savetablefeedetail(double totalamount, double minper, double paidamount, double balamount, DateTime paiddate)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into fee values(@courseregid,@totalamount,@minper,@paidamount,@balamount,@paiddate)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@courseregid", courseregid);
            command.Parameters.AddWithValue("@totalamount", totalamount);
            command.Parameters.AddWithValue("@minper", minper);
            command.Parameters.AddWithValue("@paidamount", paidamount);
            command.Parameters.AddWithValue("@balamount", balamount);
            command.Parameters.AddWithValue("@paiddate", paiddate);

            command.ExecuteNonQuery();
            con.Close();
            return "record saved in tablefeedetail";
        }
    }
}
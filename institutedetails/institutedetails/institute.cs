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
        private static string Connectiontring = "server=MANISH\\SQLEXPRESS;integrated security=true;database=institute;";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(Connectiontring);
            try
            {
                con.Open();
                return con;
            }
            catch(Exception ee)
            {
                return null;
            }
        }
        public static DataSet Getnation()
        {
            SqlConnection con = GetConnection();
            string query = "select * from nation";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            da.Fill(ds, "tablenation");
            return ds;

        }
        public static DataSet Getstate(string nationnane)
        {
            SqlConnection con = GetConnection();
            string query = "select s.statename from state s inner join nation n on\r\ns.nationid=n.nationid where nationname=@nationname";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@nationname",nationnane);
            da.Fill(ds, "tablestate");
            return ds;

        }

        public static DataSet Getcity(string statenane)
        {
            SqlConnection con = GetConnection();
            string query = "select s.cityname from city s inner join state n on s.stateid = n.stateid where statename = @statename";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@statename", statenane);
            da.Fill(ds, "tablestate");
            return ds;

        }

       // public static insertrecord(@)
    }
}

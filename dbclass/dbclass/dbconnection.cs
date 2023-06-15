using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Runtime.Remoting.Messaging;

namespace dbclass
{
    public static class dbconnection
    {


        static SqlConnection con = Class1.getConnection();
        static string query = null;
        static SqlCommand cmd = null;
        public static string insertvendor_mast(string vendor_name)
        {
            string res = null;
            query = "insert into vendor_mast values(@vendor_name)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
            con.Open();
            cmd.ExecuteNonQuery();
            res = "record added";
            con.Close();
            return res;
        }

      
        public static string maxvalue()
        {
            string res = null;
            query = "select max(vendor_id) from vendor_mast";
            cmd = new SqlCommand(query, con);
            con.Open();
             int vid=Convert.ToInt32(cmd.ExecuteScalar());
            res=vid.ToString();
            con.Close();
            return res;
        }
      
        public static string updatevendor(string vendor_name,int vendor_id)
        {
            string res = null;
            query = "select count(*) from vendor_mast where vendor_id=@vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
            con.Open();
            int cnt=Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (cnt > 0)
            {
                query = "update vendor_mast set vendor_name=@vendor_name where vendor_id=@vendor_id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@vendor_name", vendor_name);
                cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record updated";
                con.Close();
                
            }
            else
            {
                res = "no record exist";
            }
            return res;
        }


        public static string deletevendor(int vendor_id)
        {
            string res = null;

            query = "select count(*) from vendor_mast where vendor_id=@vendor_id";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
            con.Open();
            int cnt = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (cnt > 0)
            {
                query = "delete from vendor_mast where vendor_id=@vendor_id";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@vendor_id", vendor_id);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record deleted";
                con.Close();    
            }
            else
            {
                res = "no record exist";
            }
            return res;


        }

        public static DataSet searchvendor(int vendor_id)
        {
            
                query = "select * from vendor_mast where vendor_id=@vendor_id";
           
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@vendor_id",vendor_id);
            da.Fill(ds, "searchvendor");
            return ds;
        }
             
        }

    }




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using dbclass;

namespace dbclass
{
    public static class item
    {


        static SqlConnection con = Class1.getConnection();
        static string query = null;
        static SqlCommand cmd = null;

        public static string insertitem(string item_name, string category, int rate, int balance_quantity)
        {
            string res = null;
            query = "insert into Item_master values(@item_name,@category,@rate,@balance_quantity)";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@item_name", item_name);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@rate", rate);
            cmd.Parameters.AddWithValue("@balance_quantity", balance_quantity);

            con.Open();
            cmd.ExecuteNonQuery();
            res = "record inserted";
            con.Close();
            return res;
        }
        public static string updateitem(string item_name, string category, int rate, int balance_quantity, int item_id)
        {
            string res = null;
            query = "update item_master set  item_name =@item_name ,category=@category,rate=@rate,balance_quantity=@balance_quantity where item_id=@item_id";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@item_name", item_name);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@rate", rate);
            cmd.Parameters.AddWithValue("@balance_quantity", balance_quantity);
            cmd.Parameters.AddWithValue("@item_id", item_id);
            con.Open();
            cmd.ExecuteNonQuery();
            res = "record inserted";
            con.Close();
            return res;
        }

       
        public static string deletedepartment(string item_name)
        {
            string res = null;

            query = "delete from  item_master where item_name=@item_name";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@item_name", item_name);
            con.Open();
            cmd.ExecuteNonQuery();
            res = "record delete";
            //con.Close();
            return res;
        }
        public static DataSet searchdepartment(int item_id)
        {
            query = "select * from item_master where item_id=@item_id";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@item_id",item_id);
            da.Fill(ds, "item_master");
            return ds;

        }
    }
}




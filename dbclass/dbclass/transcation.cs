using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace dbclass
{
    public static class transcation
    {
        //    static SqlConnection con = Class1.getConnection();
        //    static string query = null;
        //    static SqlCommand cmd = null;
        //public static string inserttran(int item_id, DateTime transaction_date, int department_id, int quantity)
        //{
        //    string res = null;
        //    query = "insert into tranaction values(@item_id,@transaction_date,@department_id,@quantity)";
        //    cmd = new SqlCommand(query, con);

        //    cmd.Parameters.AddWithValue("@item_id", item_id);
        //    cmd.Parameters.AddWithValue("@transaction_date", transaction_date);
        //    cmd.Parameters.AddWithValue("@department_id", department_id);
        //    cmd.Parameters.AddWithValue("@quantity", quantity);
        //    con.Open();
        //    cmd.ExecuteNonQuery();
        //    res = "record inserted";
        //    con.Close();
        //    return res;
        //}


        static SqlConnection conn = Class1.getConnection();
        static SqlCommand cmd = null;
        static string query = null;
        public static string inserted(int itemid, DateTime transactiondate, int departmentid, int quantity)
        {
            string res = null;


            query = "insert into tranaction (item_id,transaction_date,department_id,quantity) values(@item_id,@transaction_date,@department_id,@quantity)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@item_id", itemid);
            cmd.Parameters.AddWithValue("@transaction_date", transactiondate);
            cmd.Parameters.AddWithValue("@department_id", departmentid);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            int bal_qty = 0;
            query = "select Balance_Quantity from item_master where Item_Id=@Item_Id ";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Item_Id", itemid);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//dr open
            {
                bal_qty = Convert.ToInt32(dr[0].ToString());

            }
            dr.Close();//datareader closed
            conn.Close();//connection close
            int qty = bal_qty - quantity;
            query = "update item_master set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Balance_Quantity", qty);
            cmd.Parameters.AddWithValue("@Item_Id", itemid);
            conn.Open();
            cmd.ExecuteNonQuery();
            res = "item issued to department successfully";
            //conn.Close();
            return res;
        }
        public static string insertvendor(int itemid, DateTime transactiondate, int vendorid, int quantity)
        {
            string res = null;


            query = "insert into tranaction (item_id,transaction_date,department_id,quantity) values(@item_id,@transaction_date,@department_id,@quantity)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@item_id", itemid);
            cmd.Parameters.AddWithValue("@transaction_date", transactiondate);
            cmd.Parameters.AddWithValue("@department_id", vendorid);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            int bal_qty = 0;
            query = "select Balance_Quantity from item_master where Item_Id=@Item_Id ";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Item_Id", itemid);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())//dr open
            {
                bal_qty = Convert.ToInt32(dr[0].ToString());

            }
            dr.Close();//datareader closed
            conn.Close();//connection close
            int qty = bal_qty +quantity;
            query = "update item_master set Balance_Quantity=@Balance_Quantity where Item_Id=@Item_Id";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Balance_Quantity", qty);
            cmd.Parameters.AddWithValue("@Item_Id", itemid);
            conn.Open();
            cmd.ExecuteNonQuery();
            res = "item issued to department successfully";
            //conn.Close();
            return res;
        }
    }
}





















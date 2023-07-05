using databaseinsert.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Reflection.Metadata;
using System.Collections;

namespace databaseinsert.Controllers
{
    public class ItemDBHandler
    {
        private SqlConnection con;
        public void connection()
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=mvc";

            con = new SqlConnection(constr);

        }

        // insert itemmethod to insert record into itemlist table
        public bool InsertItem(Insert ilist)
        {
            connection();
            string query = "insert into itemlist values('" + ilist.Name + "','" + ilist.Category + "','" + ilist.Price + "')";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            int i = command.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

       
        public bool UpadteItem(Insert ilist)
        {
            connection();
            string query = "update Itemlist set  Name='" + ilist.Name + "',Category='" + ilist.Category + "',Price=" + ilist.Price + " where id=" + ilist.ID;
            SqlCommand c = new SqlCommand(query, con);
            con.Open();
            int i = c.ExecuteNonQuery();    
            if (i >= 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public List<Insert> GetItemList()
        {
            connection();

            List<Insert> iList = new List<Insert>();

            string query = "SELECT * FROM Persons";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new Insert
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                });
            }
            return iList;
        }
        public bool DeleteItem(Insert itm)
        {
            connection();
            string query = "DELETE FROM ItemList WHERE ID ='"+ itm.ID+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }


    }
}




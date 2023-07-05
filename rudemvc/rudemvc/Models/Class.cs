using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace rudemvc.Models
{
    public class Class
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = "server=MANISH\\SQLEXPRESS;integrated security=true;database=mvc;";
            con = new SqlConnection(constr);
        }

        public List<Crud> GetItemList()
        {
            connection();
            List<Crud> iList = new List<Crud>();

            string query = "SELECT * FROM Persons";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            adapter.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                iList.Add(new Crud

                {
                    Id = Convert.ToInt32(dr["ID"]),
                    name = Convert.ToString(dr["name"]),
                    lastname = Convert.ToString(dr["lastname"]),
                    address = Convert.ToString(dr["address"]),
                    city = Convert.ToString(dr["city"]),
                });
            }
            return iList;
        }
        public bool InsertList(Crud list)

        {
            connection();
            string query = "insert into Persons values('" + list.Id + "','" + list.name + "','" + list.lastname + "','" + list.address + "','" + list.city + "')";
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

        public bool updatelist(Crud list)
        {
            connection();
            string query = "update Persons set  name='" + list.name + "',lastname='" + list.lastname + "',address=" + list.address + "',city=" + list.city + " where Id=" + list.Id;
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
        public bool DeleteList(Crud imt)
        {
            connection();
            string query = "Delete from Persons where Id =" + imt.Id;

            SqlCommand Command = new SqlCommand(query, con);
            con.Open();
            int i = Command.ExecuteNonQuery();
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



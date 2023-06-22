using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Emit;
using Microsoft.Ajax.Utilities;
using System.Web.Services.Description;

namespace shopping
{
    public partial class check : System.Web.UI.Page
    {
        string prodid;
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=meesho");
        SqlCommand command;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            prodid = Convert.ToString(Session["prodid"]);
            Response.Write("prodid " + prodid);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = TextBox1.Text;
            string prodname = null;
            int prodrice = 0;
            int prdqty = 0;
            string sessionid = null;
            if (res == "123456")
            {
                query = "select * from meesho where prodid=@prodid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@prodid", prodid);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    prodname = dr["prodname"].ToString();
                    prodrice = Convert.ToInt32(dr["prodrice"].ToString());

                    prdqty = 1;
                    sessionid = Session.SessionID;

                }
                con.Close();
                Response.Write("prodname " + prodname + "<br>");
                Response.Write("prodrice " + prodrice + "<br>");
                Response.Write("prdqty " + prdqty + "<br>");
                Response.Write("sessionid " + sessionid + "<br>");
                //save the product data into carttable

                // Response.Redirect("cart1.aspx");
                
            }
          
            else
            {
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('" + message + "');", true);
                // MessageBox.show = "hello";
                Label1.Text = "enter valid emailid";
            }
        }
    }
    }

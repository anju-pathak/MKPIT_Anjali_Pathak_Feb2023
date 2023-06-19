using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace drivenit
{
    public partial class item : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=drivenit");
        SqlCommand command = null;
        string query = null;
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            query = "insert into ItemMaster  values(@itemdescr,@balqty,@createdon)";
            command= new SqlCommand(query,con);
            command.Parameters.AddWithValue("@itemdescr", TextBox1.Text);
            command.Parameters.AddWithValue("@balqty", TextBox2.Text);
            command.Parameters.AddWithValue("@createdon", TextBox3.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "RECORD SAVDE";
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "update ItemMaster set  itemdescr=@itemdescr,balqty=@balqty,createdon=@createdon where itemid=@itemid";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@itemdescr", TextBox1.Text);
            command.Parameters.AddWithValue("@balqty", TextBox2.Text);
            command.Parameters.AddWithValue("@createdon", TextBox3.Text);
            command.Parameters.AddWithValue("@itemid", TextBox4.Text);

            con.Open();
            command.ExecuteNonQuery();
            Label1.Text = "RECORD SAVDE";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "delete  ItemMaster where itemid=@itemid";
            command = new SqlCommand(query, con);
            //command.Parameters.AddWithValue("@itemdescr", TextBox1.Text);
            //command.Parameters.AddWithValue("@balqty", TextBox2.Text);
            //command.Parameters.AddWithValue("@createdon", TextBox3.Text);
            command.Parameters.AddWithValue("@itemid", TextBox4.Text);

            con.Open();
            command.ExecuteNonQuery();
            Label1.Text = "RECORD SAVDE";
        }
    }
}
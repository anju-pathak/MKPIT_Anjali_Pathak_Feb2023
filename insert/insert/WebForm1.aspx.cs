using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace insert
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=MANISH\\SQLEXPRESS;integrated security=true;database=fendhal");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            str= "select * from TableProduct";
            da=new SqlDataAdapter(str,con);
            da.Fill(ds, "tableproduct");
            GridView1.DataSource = ds.Tables["tableProduct"].DefaultView;
            GridView1.DataBind();


        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            str="insert into TableProduct Values(@Productld,@ProductTypeld,@Product_Name,@price)";
            SqlCommand Command=new SqlCommand(str,con);
            Command.Parameters.AddWithValue("@ProductId", Convert.ToInt32(TextBox1.Text));
            Command.Parameters.AddWithValue("@ProductTypeld", Convert.ToInt32(TextBox2.Text));
            Command.Parameters.AddWithValue("@Product_Name",TextBox3.Text);
            Command.Parameters.AddWithValue("@price", Convert.ToInt32(TextBox4.Text));
            con.Open();
            Command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record save";
            TextBox1.Text = "";
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "update TableProduct set ProductTypeld=@ProductTypeld,Product_Name=@Product_Name,price=@price where ProductlD=@ProductlD";
            SqlCommand command=new SqlCommand(str,con);
            command.Parameters.AddWithValue("@ProductTypeld",Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@Product_Name", TextBox3.Text);
            command.Parameters.AddWithValue("@price", Convert.ToInt32(TextBox4.Text));
            command.Parameters.AddWithValue("@Productld", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close() ;
            Label1.Text = "record update";
            loaddata() ;
        }
  

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "delete from TableProduct where Productld=@Productld";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Productld", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
            loaddata() ;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str = "select * from Tableproduct where Productld=@Productld";
           SqlCommand command = new SqlCommand(str,con);

            da.SelectCommand.Parameters.AddWithValue("@Productld", Convert.ToInt32(TextBox1.Text));
            da.Fill(ds, "tableproduct");
            TextBox2.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[2].ToString();
            TextBox4.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[3].ToString();

            GridView1.DataSource = ds.Tables["tableproduct"].DefaultView;
            GridView1.DataBind();

            
        }
    }
}
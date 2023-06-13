using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trustProject
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Trust1");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {
         

        }
      

        protected void Button5_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            str = "select * from item_master";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tableitem");
            GridView1.DataSource = ds.Tables["tableitem"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Item_Master values(@item_name,@category,@rate,@balance_quantity)";
            SqlCommand command = new SqlCommand(str, con);
            //command.Parameters.AddWithValue("@Item_id", Convert.ToInt32(TextBox5.Text));
            command.Parameters.AddWithValue("@item_name", TextBox1.Text);
            command.Parameters.AddWithValue("@category", (DropDownList1.Text));
            command.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@balance_quantity", Convert.ToInt32(TextBox3.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved ";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Item_Master set item_name = @item_name,category = @category, @balance_quantity= @balance_quantity where rate = @rate";
SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@item_name", TextBox1.Text);
            command.Parameters.AddWithValue("@category", (DropDownList1.Text));
         
            command.Parameters.AddWithValue("@balance_quantity", Convert.ToInt32(TextBox3.Text));
            command.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox2.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated ";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Item_Master where item_name=@item_name";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@item_name", (TextBox1.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Item_Master where item_name=@item_name";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@item_name",(TextBox1.Text));
            da.Fill(ds, "tableproduct");

            TextBox1.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[2].ToString();
            TextBox2.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[3].ToString();

            GridView1.DataSource = ds.Tables["tableproduct"].DefaultView;

            GridView1.DataBind();

        }
    }
}
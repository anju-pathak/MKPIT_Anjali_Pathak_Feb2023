using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace trustProject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Trust1");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            str = "select * from vendor_mast";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tablevendor");
            GridView1.DataSource = ds.Tables["tablevendor"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            
            
                str = "insert into vendor_mast values(@vender_Name)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@vender_Name", TextBox5.Text);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            Label1.Text = "record saved ";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update vendor_Mast set vender_name = @vender_name where vendor_id=@vendor_id";
            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@vender_name", TextBox5.Text);


            command.Parameters.AddWithValue("@vendor_id", TextBox6.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated ";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from vendor_Mast where vender_name=@vender_name";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@vender_name", (TextBox5.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from vendor_Mast where vender_name=@vender_name";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@vender_name", (TextBox5.Text));
            da.Fill(ds, "tableproduct");

            TextBox5.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[1].ToString();

            GridView1.DataSource = ds.Tables["tableproduct"].DefaultView;

            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
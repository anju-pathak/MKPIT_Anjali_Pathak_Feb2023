using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace trustProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Trust1");
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
            str = "select * from department_mast";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "tablestranaction");
            GridView2.DataSource = ds.Tables["tablestranaction"].DefaultView;
            GridView2.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update department_mast set department_Name = @department_Name where department_id=@department_id";
            SqlCommand command = new SqlCommand(str, con);

            command.Parameters.AddWithValue("@department_Name", TextBox4.Text);
            command.Parameters.AddWithValue("@department_id", TextBox5.Text);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated ";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str = "insert into department_mast values(@department_Name)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@department_Name", TextBox4.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved ";

            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete department_mast where department_Name = @department_Name";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@department_Name", (TextBox4.Text));

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from  department_mast where department_Name = @department_Name" ;
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@department_Name", (TextBox4.Text));
           da.SelectCommand.Parameters.AddWithValue("@department_id", TextBox5.Text);

            da.Fill(ds, "tableproduct");

            TextBox4.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[1].ToString();
            TextBox5.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[2].ToString();
            GridView2.DataSource = ds.Tables["tableproduct"].DefaultView;

            GridView2.DataBind();
        }
    }
}

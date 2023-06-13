using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trustProject
{
    public partial class WebForm3 : System.Web.UI.Page
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
            str = "insert into vendor_mast values(@vendor_Name)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@vendor_Name", TextBox6.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record saved ";
        }

        protected void Button5_Click(object sender, EventArgs e)
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

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
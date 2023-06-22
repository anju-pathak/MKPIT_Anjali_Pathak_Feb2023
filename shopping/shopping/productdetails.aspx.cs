using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace shopping
{
    public partial class productdetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=meesho");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["prodid"].ToString();
            // Response.Write(prodid);

            da = new SqlDataAdapter("select * from meesho where prodid=@prodid", con);

            da.SelectCommand.Parameters.AddWithValue("@prodid", prodid);
            ds = new DataSet();
            da.Fill(ds, "productdetails");
            DataList1.DataSource = ds.Tables["productdetails"].DefaultView;
            DataList1.DataBind();
        }
    }
}
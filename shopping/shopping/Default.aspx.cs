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
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=meesho");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                da = new SqlDataAdapter("select * from meesho", con);
                ds = new DataSet();
                da.Fill(ds, "products");
                DataList1.DataSource = ds.Tables["products"].DefaultView;
                DataList1.DataBind();
            }
        }
    }
}
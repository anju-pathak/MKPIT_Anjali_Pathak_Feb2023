using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace session
{
    public partial class regsitration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int uc = (int)Session["usercount"];
            uc = uc + 1;
            Session["usercount"] = uc;
            Response.Write("user session count " + uc);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           Session ["username"]= TextBox1.Text;
            Session["email"]= TextBox2.Text;
            Label1.Text = "values added";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Permanent_cookies
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie1 = Request.Cookies["cook1"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["username"].ToString();
                string password = cookie1.Values["password"].ToString();
                Label1.Text = "username" + uname;
                Label2.Text = "password" + password;
            }
            else
            {
                Label1.Text = "no data";

            }
        }
    }
}
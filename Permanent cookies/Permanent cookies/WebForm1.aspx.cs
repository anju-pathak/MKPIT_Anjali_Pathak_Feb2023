using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Permanent_cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = new HttpCookie("cook1");
            cookie1.Values.Add("username",TextBox3.Text);
            cookie1.Values.Add("password", TextBox2.Text);
            DateTime dt= DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 1, 0);
            cookie1.Expires=dt.Add(ts);
            Label1.Text = "cookies added";
            Response.Cookies.Add(cookie1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = Request.Cookies["cook1"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["username"].ToString();
                string password = cookie1.Values["password"].ToString();
                Label1.Text = "username" + uname;
                    Label2.Text="password"+password;
            }
            else
            {
                Label1.Text = "no data";

            }
        }
    }
}
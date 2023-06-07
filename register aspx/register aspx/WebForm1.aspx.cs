using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace register_aspx
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cook1");
            cookie.Values.Add("username", TextBox1.Text);
            cookie.Values.Add("email", TextBox2.Text);
            cookie.Values.Add("mobileno",TextBox3.Text);
            Response.Cookies.Add(cookie);
            Label1.Text = "cookies added";
        }
    }
}
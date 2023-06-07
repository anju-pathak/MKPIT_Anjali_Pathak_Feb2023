using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 = new HttpCookie("cook");
            cookie1.Values.Add("username",TextBox1.Text);
            cookie1.Values.Add("email",TextBox3.Text);
            Response.Cookies.Add(cookie1);
            Label1.Text = "temp cookie";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cookie1 =  Request.Cookies["cook"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["username"].ToString();
                string email= cookie1.Values["email"].ToString();   
                Label1.Text = "username" + uname;
                Label2.Text = email;
            }
            else
            {
                Label1.Text = "no cookies exist";
            }
        }
    }
}
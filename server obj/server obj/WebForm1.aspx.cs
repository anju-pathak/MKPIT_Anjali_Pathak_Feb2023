using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace server_obj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hello fromo webfrom1 page");
            Server.Execute("webform2.aspx");
            Response.Write("welcome back to webfrom1 page");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("hello fromo webfrom1 page");
            Server.Transfer("webform2.aspx");
            Response.Write("welcome back to webfrom1 page");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Server.HtmlEncode("< h1 > hello anjali </ h1 >"));
            Response.Write("<h1> hello anjali </h1>");

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write(Server.UrlEncode("http://localhost/code/map"));


        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Write(Server.MapPath("/encode.aspx"));
        }
    }
}
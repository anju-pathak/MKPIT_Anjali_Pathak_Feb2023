using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace age
{
    public partial class age : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int age;
            age = Convert.ToInt32(TextBox1.Text);
            if (age <= 18)
            {

                Label1.Text = " not valid age to vote";
                Response.Write("<script>alert('please enter valid age');</script>");

            }

            else if (age >= 18)
            {
                Label1.Text = "valid age to vote";
            }
            
            
            
        }
    }
}
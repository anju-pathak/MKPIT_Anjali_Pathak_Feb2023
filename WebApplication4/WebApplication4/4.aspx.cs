using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class _4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text == "+")

            {
                int n1, n2, res = 0;
                n1 = Convert.ToInt32(TextBox1.Text);
                n2 = Convert.ToInt32(TextBox2.Text);
                res = n1 + n2;
                Label1.Text = res.ToString();
            }
            else if (TextBox3.Text == "-")
            {
                int n1, n2, res = 0;
                n1 = Convert.ToInt32(TextBox1.Text);
                n2 = Convert.ToInt32(TextBox2.Text);
                res = n1 - n2;
                Label1.Text = res.ToString();
            }

            else if (TextBox3.Text == "*")
            {
                int n1, n2, res = 0;
                n1 = Convert.ToInt32(TextBox1.Text);
                n2 = Convert.ToInt32(TextBox2.Text);
                res = n1 * n2;
                Label1.Text = res.ToString();
            }
            else if(TextBox3.Text == "/")
            {
                int n1, n2, res = 0;
             
                n1 = Convert.ToInt32(TextBox1.Text);
                n2 = Convert.ToInt32(TextBox2.Text);
                res = n1 / n2;
                Label1.Text = res.ToString();

            }
                    
        }

    } 
}



    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            int n1, n2, es = 0;
            n1 = Convert.ToInt32(TextBox3.Text);
            n2 = Convert.ToInt32(TextBox5.Text);
            es = n1 + n2;
            Label1.Text = es.ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            int n1, n2, es = 0;
            n1 = Convert.ToInt32(TextBox3.Text);
            n2 = Convert.ToInt32(TextBox5.Text);
            es = n1 - n2;
            Label1.Text = es.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            int n1, n2, es = 0;
            n1 = Convert.ToInt32(TextBox3.Text);
            n2 = Convert.ToInt32(TextBox5.Text);
            es = n1 * n2;
            Label1.Text = es.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            int n1, n2, es = 0;
            n1 = Convert.ToInt32(TextBox3.Text);
            n2 = Convert.ToInt32(TextBox5.Text);
            es = n1 / n2;
            Label1.Text = es.ToString();
        }
    }
}
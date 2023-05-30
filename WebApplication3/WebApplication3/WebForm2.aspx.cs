using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, res,per,grade;
            n1=Convert.ToInt32(TextBox1.Text);
            n2=Convert.ToInt32(TextBox2.Text);
            n3=Convert.ToInt32(TextBox3.Text);
            res = n1 + n2 + n3;
            Label1.Text=res.ToString();
            per = (res / 300) * 100;
            Label2.Text=per.ToString();
            if(per<=75)
            {
                Label3.Text = "A+";
            }
            else if (per <=60)
            {
                Label3.Text = "A";
            }
            else
            {
                Label3.Text = "B";
            }


        }
        
    }
}
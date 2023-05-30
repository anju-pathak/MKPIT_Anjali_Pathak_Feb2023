using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace order_detials
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n1, n2, res = 0;
            n1=Convert.ToInt32(TextBox3.Text);
            n2 = Convert.ToInt32(TextBox4.Text);
            res = n1 * n2;
            Label1.Text = res.ToString();

            System.Text.StringBuilder sa = new System.Text.StringBuilder();
            sa.Append("customer name" + TextBox1.Text + "<br>");
            sa.Append("product name" + TextBox2.Text + "<br>");
            sa.Append("rate" + TextBox3.Text + "<br>");
            sa.Append("quantity" + TextBox4.Text + "<br>");
            if (RadioButton1.Checked)
            {

                sa.Append("payment" + RadioButton1.Text + "<br>");

            }
            else if(RadioButton2.Checked)
            {
                sa.Append("payment" + RadioButton2.Text + "<br>");
            }
            Label1.Text += sa.ToString();

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton2.Checked)
            {
                int n1, n2, res = 0;
                n1 = Convert.ToInt32(TextBox3.Text);
                n2 = Convert.ToInt32(TextBox4.Text);
                res = n1 * n2;
                Label1.Text = res.ToString();
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int n1, n2, res = 0,emi;
            n1 = Convert.ToInt32(TextBox3.Text);
            n2 = Convert.ToInt32(TextBox4.Text);
            res = n1 * n2;
            emi = res / 3;
            Label1.Text = res.ToString();
        }
       
    }
}
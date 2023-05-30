using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace all_details
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("name" + TextBox1.Text + "<br>");
            sb.Append("address" + TextBox2.Text + "<br>");
            sb.Append("password" + TextBox3.Text + "<br>");
            sb.Append("city" + DropDownList1.Text + "<br>");
            sb.Append("Dob" + TextBox4.Text + "<br>");
            sb.Append("hobbies" + CheckBox1.Text + "<br>");
            if (RadioButton2.Checked)
            {
                sb.Append("gender" + RadioButton2.Text + "<br>");
            }
            if (RadioButton3.Checked)
            {
                sb.Append("gender" + RadioButton3.Text + "<br>");
            }
            sb.Append("email" + TextBox5.Text + "<br>");
            sb.Append("mobile" + TextBox6.Text + "<br>");
            Label1.Text= sb.ToString();


        }
    }
}
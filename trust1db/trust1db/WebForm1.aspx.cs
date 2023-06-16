using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trust1db
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Panel2.Visible = false;
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if(RadioButton1.Checked)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            Panel1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           if (RadioButton1.Checked)
            {
              string res = dbclass.transcation.inserted(Convert.ToInt32(DropDownList3.Text),DateTime.Now,Convert.ToInt32(DropDownList1.Text),Convert.ToInt32(TextBox3.Text));
            Label1.Text = "successfully";
           }
          if(RadioButton2.Checked)
            {
                string res = dbclass.transcation.insertvendor(Convert.ToInt32(DropDownList3.Text), DateTime.Now, Convert.ToInt32(DropDownList2.Text), Convert.ToInt32(TextBox3.Text));
                Label1.Text = "successfully";
            }
        }
    }
}
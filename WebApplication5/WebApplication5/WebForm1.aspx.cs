using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int amount = 1000, res = 0;
            amount = Convert.ToInt32(TextBox2.Text);
            string type=Convert.ToString(TextBox3.Text);    
            
            if(type=="deposite")
            {
                res= 1000 + amount;
                Label1.Text = res.ToString();
            }
            if (type == "withdraw")
            {
                res = 1000 - amount;
                Label1.Text = res.ToString();
            }
        }
    }
}
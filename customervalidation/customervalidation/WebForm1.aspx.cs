using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace customervalidation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string val = args.Value;
            int len = args.Value.Length;

            if (len == 10)
            {
                string d = val.Substring(0, 2);
                // Response.Write(&quot;dd &quot; + d);
                int dd = Convert.ToInt32(d);
                if (dd > 31)

                {
                    args.IsValid = false;
                }
                else
                {
                    string m = val.Substring(3, 2);
                    int mm = Convert.ToInt32(m);
                    if (mm > 31)
                    {
                        args.IsValid = false;
                    }
                    else
                    {
                        string y = val.Substring(6, 4);
                        int yl = y.Length;
                        if (yl == 4)
                        {
                            args.IsValid = true;
                        }

                        else
                        {
                            args.IsValid = false;
                        }
                    }
                }
            }
            else
            {
                args.IsValid = false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Label1.Text = TextBox1.Text;
            }
            else
            {
                Label1.Text = "page is not valid";
            }
        }
    }
    

}
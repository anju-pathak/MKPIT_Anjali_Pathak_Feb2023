using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Details1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("country " + DropDownList1.Text + "<br>");
            sb.Append("city " + DropDownList2.Text + "<br>");
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    sb.Append("course " + li.Value + "<br>");
                }
            }
            Label3.Text = sb.ToString();
        }


        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();
            switch (DropDownList1.Text)
            {
                case "India":
                    DropDownList2.Items.Add("Nagpur");
                    DropDownList2.Items.Add("mumbai");
                    break;
                case "Nepal":
                    DropDownList2.Items.Add("bharatpur");
                    DropDownList2.Items.Add("kathmandu");
                    break;

            }
        }
    }
}

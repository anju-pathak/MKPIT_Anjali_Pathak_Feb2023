using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using dbclass;

namespace trust1db
{
    public partial class item : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = dbclass.item.insertitem(TextBox1.Text, DropDownList1.SelectedValue, Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text));
            
            Label1.Text = "record inserted";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = dbclass.item.updateitem(TextBox1.Text, DropDownList1.SelectedValue, Convert.ToInt32(TextBox2.Text), Convert.ToInt32(TextBox3.Text), Convert.ToInt32(TextBox4.Text));
            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = dbclass.item.deletedepartment(TextBox1.Text);
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = department1.searchdepartment(Convert.ToInt32(TextBox4.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["item_master"].Rows[0].ItemArray[3].ToString();
            }
            else
            {
                Label1.Text = "no record exi";
            }
        }
    }
}
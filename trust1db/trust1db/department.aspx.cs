using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dbclass;
using System.Data;
namespace trust1db
{
    public partial class department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = department1.insertdepartment(TextBox1.Text);
            Label1.Text = res;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = department1.updatedepartment(TextBox1.Text,Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = department1.deletedepartment(Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = dbconnection.searchdepartment(Convert.ToInt32(TextBox2.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }
        }
    }
    }
}
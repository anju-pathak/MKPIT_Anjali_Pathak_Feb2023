using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using trust1db;
using System.Data;
using dbclass;

namespace trust1db
{
    public partial class vendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res=dbconnection.insertvendor_mast(TextBox1.Text);
            Label1.Text = res;
            vendorid();
        }

        public void vendorid()
        {
            int res = Convert.ToInt32(dbconnection.maxvalue());
             res=   res + 1;
            TextBox2.Text = res.ToString();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = dbconnection.updatevendor(TextBox1.Text, Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = dbconnection.deletevendor(Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = dbconnection.searchvendor(Convert.ToInt32(TextBox2.Text));
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

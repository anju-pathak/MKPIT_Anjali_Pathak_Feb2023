using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gridview
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            int tamount = Convert.ToInt32(TextBox1.Text);
            int pamount = Convert.ToInt32(TextBox2.Text);
            int ramount = tamount - pamount;
            double eamount = 0;
            if (RadioButton1.Checked)
            {
                if (ramount > 0)
                {


                    Label1.Text = "please pay amount";
                }
            }
            else
            {

                if (ramount > 0)
                {
                    eamount = ramount / 3.0;
                }
                string pname = "mouse";


                DataSet ds = new DataSet();
                DataTable dt = new DataTable("emitable");
                DataRow dr;
               
                dt.Columns.Add(new DataColumn("srno", typeof(int)));
                dt.Columns.Add(new DataColumn("Name", typeof(string)));
                dt.Columns.Add(new DataColumn("emi", typeof(decimal)));
                for (int i = 1; i <= 3; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = i;
                    dr[1] = pname;

                    dr[2] = eamount;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
                GridView1.DataSource = ds.Tables["emitable"].DefaultView;
                GridView1.DataBind();
            }
        }
    }
}

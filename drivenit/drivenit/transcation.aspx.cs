using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace drivenit
{
    public partial class transcation : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("server=.\\sqlexpress;integrated security=true;database=drivenit");
        SqlCommand command = null;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into Transactions values(@itemid,@trantype,@tranqty,@date)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                string tran = null;
                if (RadioButton1.Checked)
                {
                    tran = "I";
                }
                else if (RadioButton2.Checked) 
                {
                    tran = "R";
                }
                command.Parameters.AddWithValue("@trantype", tran);
                command.Parameters.AddWithValue("@tranqty",Convert.ToInt32( TextBox2.Text));
                command.Parameters.AddWithValue("@date", TextBox3.Text);
                con.Open();
                command.ExecuteNonQuery();

                query = "select max(balqty) from ItemMaster where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (tran == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox2.Text);
                }
                if (tran == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox2.Text);
                }

                query = "update ItemMaster set balqty=@balqty where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@balqty", bq);
                command.Parameters.AddWithValue("itemid", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "RECORD SAVDE";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }
            finally { con.Close(); }

        }
      
        protected void Button2_Click(object sender, EventArgs e)
        {
            int updateqty = 0;
            Response.Write("transcation id" + tranid.ToString());
            updateqty = Convert.ToInt32(TextBox2.Text) - oldtranqty;
            Response.Write("updateqty"+updateqty.ToString());

            try
            {
                query = "update Transactions set itemid=@itemid,transtype=@transtype,transqty=@transqty,transdate=@transdate where TransID=@TransID";
                command = new SqlCommand(query, con);

                string tran = null;
                if (RadioButton1.Checked)
                {
                    tran = "I";
                }
                else if (RadioButton2.Checked)
                {
                    tran = "R";
                }
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                command.Parameters.AddWithValue("@transtype", tran);
                command.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox2.Text));
                command.Parameters.AddWithValue("@transdate", TextBox3.Text);
                command.Parameters.AddWithValue("@TransID", tranid);


                con.Open();
                command.ExecuteNonQuery();

                query = "select max(balqty) from ItemMaster where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                Response.Write("bq"+bq.ToString());
                Response.Write("updateqty" + updateqty.ToString());

                if (RadioButton1.Checked)
                
                   bq = bq - updateqty;
                
                if (RadioButton2.Checked)
                
                    bq = bq + updateqty;
                
                Response.Write("<br>newupdateqty" + bq.ToString());
                if (bq < 0)
                {
                    Label1.Text = "stock not available";
                }
                else
                {
                    query = "update ItemMaster set balqty=@balqty where itemid=@itemid";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@balqty", bq);
                    command.Parameters.AddWithValue("itemid", DropDownList1.Text);
                    command.ExecuteNonQuery();
                    Label1.Text = "RECORD SAVDE";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }

            finally { con.Close(); }
           // con.Close();
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                query = "delete  Transactions where transid=@transid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@transid", TextBox4.Text);
                con.Open();
                command.ExecuteNonQuery();
                Label1.Text = "RECORD SAVDE";
            }
            catch (Exception ex)
            {
                Label1.Text = ex.ToString();
            }

            finally {
                con.Close();
            }
        }
        static int tranid = 0;
        static int oldtranqty = 0;
        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox2.Text = GridView1.SelectedRow.Cells[4].Text;
            oldtranqty=Convert.ToInt32(TextBox2.Text);
            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox3.Text = dd.ToString("yyyy-MM-dd");
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[1].Text;
            string res = GridView1.SelectedRow.Cells[3].Text;
            if (res == "I")
            {
                RadioButton1.Checked = true;
                RadioButton2.Checked = false;
            }
            if (res == "R")
            {
                RadioButton2.Checked = true;
                RadioButton1.Checked = false;

            }
            tranid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        }
    }
}
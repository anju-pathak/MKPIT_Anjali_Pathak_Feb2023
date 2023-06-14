using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace trustProject
{
    public partial class WebForm3 : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Trust1");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
               Panel1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            loaddata();

        }
        public void loaddata()
        {
           // SqlCommand command();
            if (RadioButton1.Checked)
            {
                str = "insert into  tranaction (item_id, transaction_date ,department_id,quantity) values(@item_id, @transaction_date ,@department_id,@quantity)";


                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                command.Parameters.AddWithValue("@transaction_date", TextBox6.Text);
                command.Parameters.AddWithValue("@department_id", DropDownList1.SelectedValue);
                command.Parameters.AddWithValue("@quantity", TextBox7.Text);

                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                Label1.Text = "record saved";


                int bal = 0;
                str = "select  balance_quantity from item_master where item_id=@item_id";
                 command = new SqlCommand(str, con); 
                command.Parameters.AddWithValue("@item_id",DropDownList1.SelectedValue);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    bal = Convert.ToInt32(reader[0].ToString());
                }
                reader.Close();
                con.Close();
                int qty=bal-Convert.ToInt32(TextBox7.Text);
                Response.Write(qty);
                str = "update item_master set balance_quantity=@balance_quantity where item_id=@item_id)";
                SqlCommand command2 = new SqlCommand();
                command.Parameters.AddWithValue("@balance_quantity", qty);
                command.Parameters.AddWithValue("item_id", DropDownList1.SelectedValue);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                Label1.Text = "record saved";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
              Panel1.Visible = false;
                Label2.Visible = true;
                DropDownList1.Visible = true;
            }

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
            Label2.Visible = false;
             DropDownList1.Visible = false;
                Panel1.Visible=true;
            }
        }
    }
}
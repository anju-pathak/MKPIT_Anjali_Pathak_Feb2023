using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace computer
{



    public partial class Form1 : Form
    {
        enum Gender { male, female, other }
        Gender gender;
        enum Pay { cash, emi }
        Pay pay;

        public Form1()
        {
            InitializeComponent();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Computer.Getcategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox2.Text;

            DataSet ds = Computer.Getquantity(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox2.Text = dr["Avaiable_Quantity"].ToString();
            }

            DataSet ds1 = Computer.Gettotal(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox3.Text = dr["Total_Quantity"].ToString();
            }
            DataSet ds2 = Computer.Getprice(comboBox2.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                textBox4.Text = dr["price"].ToString();
            }


        }
        int tgst = 0;
        int cgst = 0;
        int sgst = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Computer.GetProduct(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";

            DataSet ds3 = Computer.Getgst(comboBox1.Text);
            foreach (DataRow dr in ds3.Tables[0].Rows)
            {
                textBox10.Text = dr["cgst"].ToString();
                textBox12.Text = dr["sgst"].ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (textBox7.Text == "")
            {

            }
            else
            {
                calculate_total();
            }
        }
        public void calculate_total()
        {
            double total = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox7.Text);
            textBox9.Text = total.ToString();
            double cgst = Convert.ToDouble(textBox4.Text) * ((Convert.ToDouble(textBox10.Text) / 100.0));
            textBox11.Text = cgst.ToString();
            double sgst = Convert.ToDouble(textBox4.Text) * ((Convert.ToDouble(textBox12.Text) / 100.0));
            textBox13.Text = sgst.ToString();
            double netamount = Convert.ToDouble(textBox9.Text) + Convert.ToDouble(textBox13.Text) + Convert.ToDouble(textBox11.Text);
            textBox14.Text = netamount.ToString();
            //calculate_total();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            gender = Gender.male;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gender = Gender.other;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = Gender.female;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            pay = Pay.cash;
            if (radioButton4.Checked)
            {

                textBox16.Text = textBox14.Text;
            }


        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

            pay = Pay.emi;


            // double balamount =Convert.ToDouble(textBox9.Text) - Convert.ToDouble(textBox16.Text);
            //textBox14.Text = balamount.ToString();


        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_Leave(object sender, EventArgs e)
        {

        }

        private void radioButton4_Leave(object sender, EventArgs e)
        {
            textBox16.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int tamount = Convert.ToInt32(textBox14.Text);
            int pamount = Convert.ToInt32(textBox16.Text);

            int ramount = tamount - pamount;
            double eamount = 0;

            

            if (radioButton5.Checked)
            {

                if (ramount > 0)
                {
                    eamount = ramount / 3.0;
                }
                string pname = textBox1.Text;

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("emitable");
                DataRow dr;
                dt.Columns.Add(new DataColumn("srno", typeof(int)));
                dt.Columns.Add(new DataColumn("productname", typeof(string)));
                dt.Columns.Add(new DataColumn("emi amount", typeof(decimal)));
                for (int i = 1; i <= 3; i++)
                {
                    dr = dt.NewRow();
                    dr[0] = i;
                    dr[1] = pname;
                    dr[2] = eamount;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);

                dataGridView1.DataSource = ds.Tables["emitable"].DefaultView;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


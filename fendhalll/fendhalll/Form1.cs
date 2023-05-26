using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fendhalll
{
    enum Nationality { Indian, NRI };

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataSet ds = Prodstore.Getprdcategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "product_type_name";
            comboBox1.ValueMember = "Product_Category_ID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = Prodstore.Getprice(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox9.Text = dr["price"].ToString();
            }


        }
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Prodstore.Getprd(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "ProductlD";
            DataSet ds1 = Prodstore.Getgst(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());


                if (nationality == 0)
                {
                    tgst = cgst + sgst;
                }
                else
                {
                    tgst = igst;
                }
                textBox3.Text = dr["cgst"].ToString();
                textBox4.Text = dr["sgst"].ToString();
                textBox5.Text = dr["igst"].ToString();
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {
                e.Handled = true;
            }
        }
        Nationality nationality;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));
            calculate_total();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = igst.ToString();
            calculate_total();

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                calculate_total();
            }
        }
        public void calculate_total()
        {
            double totalamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
            textBox12.Text = totalamount.ToString();
            double cgstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100.0);
            textBox6.Text = cgstamount.ToString();
            double sgstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
            textBox7.Text = sgstamount.ToString();
            double igstamount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
            textBox8.Text = igstamount.ToString();
            double netamount = Convert.ToDouble(textBox12.Text) + Convert.ToDouble(textBox8.Text);
            textBox11.Text = netamount.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkuserdetails();
        }
        public void checkuserdetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please fill the details");
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("quantity cannot be zero");
            }
            else
            {
                string result = Prodstore.saveinvoicedetails(textBox1.Text, textBox2.Text, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32
                 (nationality), dateTimePicker1.Value, Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox12.Text));
                MessageBox.Show(result);
            }
        }
    }
}



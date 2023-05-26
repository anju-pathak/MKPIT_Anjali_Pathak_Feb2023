using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.CodeDom;

namespace fendhalpractices
   
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian, NRI };
        Nationality nationality;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && ! char.IsDigit(e.KeyChar)) { e.Handled = true; return; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = prdstore.Getprdcategory();
                comboBox1. DataSource =ds.Tables[0];
               comboBox1.DisplayMember ="Product_Type_Name";
            comboBox1.ValueMember="Product_Category_ID";

        }
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = prdstore.Getprd(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "ProductlD";

            DataSet ds1 = prdstore.Getgst(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                cgst =Convert.ToInt32(dr["CGST"].ToString());
                sgst= Convert.ToInt32(dr["SGST"].ToString());
                igst = Convert.ToInt32(dr["SGST"].ToString());

            }
            if (nationality == 0)
            { 
                tgst = cgst + sgst;
            }
            else
            {
                tgst = cgst;

              
            }
      
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = igst.ToString();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = prdstore.Getprice(comboBox1.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox9.Text = dr["price"].ToString();
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text=cgst.ToString();
            textBox4.Text=cgst.ToString();
            textBox5.Text=Convert.ToString(Convert.ToInt32(textBox3.Text)+Convert.ToInt32(textBox4.Text));
            calculate_total();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
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
                double cgstamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox3.Text);
                textBox6.Text = cgstamount.ToString();
                double sgstamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox4.Text);
                textBox7.Text = sgstamount.ToString();
                double igstamount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox5.Text);
                textBox8.Text = igstamount.ToString();
                double netamount = Convert.ToDouble(textBox12.Text) * Convert.ToDouble(textBox8.Text);
                textBox11.Text = netamount.ToString();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            checkuesrdetails();
        }
        public void checkuesrdetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("fill all detials");
            }
            else if (textBox10.Text == "")
            {
                MessageBox.Show("quantity cannot be zero");
            }
            else
            {
                string result = prdstore.saveinvoicetable(textBox1.Text,textBox2.Text,Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue),Convert.ToInt32(nationality),
                     dateTimePicker1.Value, Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox9.Text), Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text), Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), Convert.ToDecimal(textBox8.Text), Convert.ToDecimal(textBox12.Text));
                MessageBox.Show(result);



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();



        }
     
        
         
        }
    }
   


    


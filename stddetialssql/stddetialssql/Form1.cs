using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stddetialssql
{
    public partial class Form1 : Form
    {
        enum gender { Male, Female };

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = details.getcountry();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "countryname";
            comboBox1.ValueMember = "countryid";


            DataSet ds1 = details.getcourse();
            comboBox4.DataSource = ds1.Tables[0];
            comboBox4.DisplayMember = "coursename";
            comboBox4.ValueMember = "courseid";




        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = details.getcity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "cityname";
            comboBox3.ValueMember = "cityid";



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = details.getstate(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "statename";
            comboBox2.ValueMember = "stateid";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds2 = details.getfee(comboBox4.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)

            {
                textBox3.Text = dr["fees"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }
        gender genders;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            genders = gender.Male;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            genders = gender.Female;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                calculate_total();
            }


            else
            {
                calculate_total();
            }
        }
            public void calculate_total()
            { 
            double balance = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox4.Text);
        textBox5.Text = balance.ToString();
            }

        private void button1_Click(object sender, EventArgs e)
        {
            checkuserdetails();
        }
        public void checkuserdetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("please enter all details");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Amount cannot be zero");

            }
            else
            {
                string result = details.savetable(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue), textBox1.Text, dateTimePicker1.Value, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text));
                MessageBox.Show(result);
            }
        }

    }
}

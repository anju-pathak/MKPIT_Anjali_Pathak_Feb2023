using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace institutedetails
{
    public partial class Form1 : Form


    {
        enum gender { male, female, other }
        gender genders;
        enum profession { student,ITprofessinol};
        profession professions;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Institute.Getnation();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "nationname";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Institute.Getstate(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "statename";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Institute.Getcity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "cityname";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            genders = gender.male;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            genders = gender.female;

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            genders = gender.other;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            radioButton1.Text = "";
            radioButton2.Text = "";
            radioButton3.Text = "";
            radioButton4.Text = "";
            radioButton5.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
           // checkuserdetails();
        }
        public void checkuserdetials()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "" || groupBox2.Text == "")
            {
                MessageBox.Show("please enter details");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("amount cannot be zero");

            }
            else
            {
                //string result = Institute.insertrecord()

                //MessageBox.Show(result);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //professions = profession.student;
            //textBox2.Text = ("1000".ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            professions = profession.student;
            textBox2.Text = ("1000".ToString());
            //textBox4.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text));
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            professions = profession.ITprofessinol;
            textBox2.Text = ("3000".ToString());
           // textBox4.Text = Convert.ToString(Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text));


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            if (professions == profession.student)//textBox3.Text =="")
            {
                double balanceamount = Convert.ToDouble(textBox2.Text) - (Convert.ToDouble(textBox3.Text) / 2);
                textBox4.Text = balanceamount.ToString();
                calculate_total();
            }
            else if (professions == profession.ITprofessinol)//textBox3.Text =="")
            {
                double balanceamount = Convert.ToDouble(textBox2.Text) -Convert.ToDouble(textBox3.Text) / 500.0;
                textBox4.Text = balanceamount.ToString();
                calculate_total();
            }
        }
                public void calculate_total()
                {
            //double balanceamount = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text) / 50.0;
            //textBox4.Text = balanceamount.ToString();
            //double balanceamount = Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(textBox3.Text) / 800.0);
            //textBox4.Text = balanceamount.ToString();
        }

    }
    }

  

  

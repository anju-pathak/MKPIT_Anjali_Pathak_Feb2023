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
using System.Data.SqlClient;

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
            comboBox1.ValueMember = "nationid";
            textBox2.Text = "1000";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Institute.Getstate(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "statename";
            comboBox2.ValueMember = "stateid";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Institute.Getcity(comboBox2.Text);
            comboBox3.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "cityname";
            comboBox3.ValueMember = "cityid";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            { 
            genders = gender.male;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {

                genders = gender.female;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                genders = gender.other;
            }
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

           

           checkuserdetials();

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
                string result = Institute.insertrecord(Convert.ToInt32(professions),textBox1.Text,Convert.ToInt32(genders));
                MessageBox.Show(result);    
                result=Institute.savetableregaddress(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));
                MessageBox.Show(result);
                result = Institute.savetablefeedetail(Convert.ToDouble(textBox2.Text), fp, Convert.ToInt32(textBox3.Text), Convert.ToDouble(textBox4.Text),dateTimePicker1.Value);
                MessageBox.Show(result);


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //professions = profession.student;
            //textBox2.Text = ("1000".ToString());
        }
        double total = 0;
        double fp = 0;
        double balanceamount = 0;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox3.Text = "";
            professions = profession.student;
            textBox2.Text = "1000";
            total = Convert.ToDouble(textBox2.Text);
            fp = 0;  
            total = fp * 0.5;
            calculate_total();
            //if (Convert.ToDouble(textBox3.Text) < fp)
            //{
            //    MessageBox.Show("paid amount should be atlest 50% for student" );
            //}

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
 
             fp = 0;
            professions = profession.ITprofessinol;
            textBox2.Text = "3000";
             total = Convert.ToDouble(textBox2.Text);
            total = fp * 0.8;
            calculate_total();

          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

           
        }
        public void calculate_total()
                {
            //double balanceamount = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text) / 50.0;
            //textBox4.Text = balanceamount.ToString();
            //double balanceamount = Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(textBox3.Text) / 800.0);
            //textBox4.Text = balanceamount.ToString();
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {

            double fp = 0;
            double total = Convert.ToDouble(textBox2.Text);
           
            if (professions == profession.student)
            {
                fp = total * 0.5;
            }
            else
            {
                fp = total * 0.8;
            }
            if (Convert.ToDouble(textBox3.Text) < fp)
            {
                    MessageBox.Show("paid amount should be atlest 50% for student  and 80% for It professional");
            }

            if (professions == profession.student || textBox3.Text == "")
            {
                balanceamount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = balanceamount.ToString();
                

            }
            else if (professions == profession.ITprofessinol)//textBox3.Text =="")
            {
                balanceamount = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                textBox4.Text = balanceamount.ToString();

            }

        }

    }
}

  

  

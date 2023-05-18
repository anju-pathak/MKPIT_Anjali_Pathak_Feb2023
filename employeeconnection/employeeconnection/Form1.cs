using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace employeeconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            SqlDataReader dr = DatabaseConnection.Getcity();
            // reading the records from sqldatareader
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["City"].ToString());



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label8.Text = DatabaseConnection.InsertRecord(Convert.ToInt32(textBox1.Text), textBox2.Text,  radioButton2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), comboBox1.Text, Convert.ToDateTime(dateTimePicker1.Text));
            }
            else if(radioButton2.Checked)
                    {
                label8.Text = DatabaseConnection.InsertRecord(Convert.ToInt32(textBox1.Text), textBox2.Text,  radioButton2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), comboBox1.Text, Convert.ToDateTime(dateTimePicker1.Text));
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                label8.Text = DatabaseConnection.DeleteUsers(textBox1.Text);
                
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = DatabaseConnection.UpdateUsers(textBox1.Text,textBox2.Text);
        }

       }
    }


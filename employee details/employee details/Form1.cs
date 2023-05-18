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

namespace employee_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           label1.Text=employee.InsertRecord(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = employee.UpadateRecord(textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = employee.DeleteRecord(textBox1.Text);
        }
        // public void clearall();
        //label1.Text();
        //  textBox1.Text();



    }
}

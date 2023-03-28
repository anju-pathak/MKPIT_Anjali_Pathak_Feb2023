using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (radioButton1.Checked)
            {
                total = total + 10;
            }
            if (radioButton5.Checked)
            {
                total = total + 10;
            }
            if (radioButton7.Checked)
            {
                total = total + 10;
            }
            int counter = 0;
            if (checkBox1.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total + 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            if (checkBox2.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total - 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            if (checkBox3.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total + 5;
                }
                else

                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            label4.Text = "total out of 50" + total;
        }
    }
}


        
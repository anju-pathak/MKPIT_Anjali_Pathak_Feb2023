using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace small
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int num1 = Convert.ToInt32(textBox1.Text);
                int num2 = Convert.ToInt32(textBox2.Text);
                if (num1 > num2)
                {
                    label3.Text = "greater number is:" + num1;
                }
                else
                {
                    label3.Text = "greater number is:" + num2;
                }
            }
                

        private void button2_Click_1(object sender, EventArgs e)
        {
    int num1 = Convert.ToInt32(textBox1.Text);
    int num2 = Convert.ToInt32(textBox2.Text);
    if (num1 < num2)
    {
        label3.Text = "smaller number is" + num1;
    }
    else
    {
        label3.Text = "smaller number is:" + num2;
    }
}

        }
    }
    


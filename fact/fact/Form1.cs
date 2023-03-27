using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num, i, fact = 1;
            num = Convert.ToInt32(textBox1.Text);
            for (i = 1; i <= num; i++)
            {
                fact = fact * i;
                
                    label2.Text = ("fact" + fact);

                
            }
        }
    }
}
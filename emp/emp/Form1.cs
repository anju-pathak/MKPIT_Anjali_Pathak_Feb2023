using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int empno, sal, total, hra, da;
            empno=Convert.ToInt32(textBox1.Text);
            sal=Convert.ToInt32(textBox2.Text);
            hra = (sal * 32) / 100;
            da = (sal * 45) / 100;
            total = sal + hra + da;
            label3.Text = ("hra" + hra);
            label4.Text = ("da" + da);
            label5.Text = ("total sal" + total);
        }
    }
}

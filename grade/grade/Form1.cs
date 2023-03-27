using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sub1,sub2,sub3,total;
            sub1=Convert.ToInt32(textBox1.Text);
            sub2= Convert.ToInt32(textBox2.Text);   
            sub3 = Convert.ToInt32(textBox3.Text);
            total = sub1 + sub2 + sub3;
            label4.Text = ("total" + total); ;
            float per = (total / 300.0f) * 100.0f;
            label5.Text = ("per" + per);
            if(per>=75)
            {
                label6.Text = ("grade: pass");
            }
            else
            {
                label6.Text = ("grade fail");
            }
        }
    }
}

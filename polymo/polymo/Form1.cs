using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polymo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }

        

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount;
            label2.Text=Convert.ToString( textBox2.Text);
            account act = null;
            string acttype;
            acttype=Convert.ToString( textBox3.Text);
            if(acttype=="saving")
            {
                act = new saving();
                int result=act.deposite(Convert.ToInt32(textBox2.Text));
                label6.Text= Convert.ToString(result);
            }
            else if(acttype=="current")
            {
                act = new current();
                int result = act.deposite(Convert.ToInt32(textBox2.Text));
                label6.Text= Convert.ToString(result);
            }
          
        }
    }
}

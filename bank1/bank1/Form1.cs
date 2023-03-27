using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bal=1000;
        private void button1_Click(object sender, EventArgs e)
        {
            int amt = Convert.ToInt32(textBox2.Text);
            if (amt > 0)
            {
                bal = bal + amt;
                label3.Text = ("amt desp is" + bal);
            }
            else
            {
                label3.Text = ("enter amt greater than zero");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int amt=Convert.ToInt32(textBox2.Text);

            if (amt <= bal)
            {
                bal = bal -amt;
                label3.Text = ("amt with bal is" + bal);
            }
            else
            {
                label3.Text = ("insufficient bal");
            }
        }
    }
}

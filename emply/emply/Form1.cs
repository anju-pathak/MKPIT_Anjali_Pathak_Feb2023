using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emply
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emp em = null;
            string emptype;
            emptype= Convert.ToString(textBox1.Text);
            
            if (emptype == "manager")
            {
                em = new manager();
                int result = em.calsalary(Convert.ToInt32(textBox2.Text));
                    label2.Text = Convert.ToString(result);

            }
            else if(emptype == "engg")
            {
                em=new manager();
                int result = em.calsalary(Convert.ToInt32(textBox2.Text));
                label2.Text = Convert.ToString(result);
            }
            else if(emptype =="sale")
            {
                em=new sale();
                int result = em.calsalary(Convert.ToInt32(textBox2.Text));
                label2.Text = Convert.ToString(result);
            }
        }
    }
}

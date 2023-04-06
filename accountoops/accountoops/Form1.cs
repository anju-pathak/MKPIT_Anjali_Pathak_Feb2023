using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accountoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            accountt act = new accountt();
            int result = act.dep( Convert.ToInt32(textBox2.Text));
            label3.Text = result.ToString();
            accountt act1= new accountt();
            int result1 = act1.width(Convert.ToInt32(textBox2.Text));
            label4.Text = result1.ToString();
        }
    }
}
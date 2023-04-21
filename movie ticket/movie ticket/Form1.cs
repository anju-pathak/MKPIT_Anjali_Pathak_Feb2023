using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movie_ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moviename obj= new moviename();
            label1.Text = obj.Name;
            string result = obj.moviename(Convert.ToString(textBox1.Text));
            label1.Text = Convert.ToString(result);
            label1.Text=Convert.ToString(obj);

        }
    }
}
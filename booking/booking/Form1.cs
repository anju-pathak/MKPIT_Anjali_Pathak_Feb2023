using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace booking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            textBox1.Text = "0";
            switch (comboBox2.Text)
            {
                case "Cinemax":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("4.00 PM");
                    textBox1.Text = "120";
                    break;
                case "Panchasheel":
                    comboBox3.Items.Add("3.00 PM");
                    comboBox3.Items.Add("10.00AM");
                    textBox1.Text = "220";
                    break;
                case "Alankar":
                    comboBox3.Items.Add("12.30 PM");
                    comboBox3.Items.Add("3.30 PM");
                    textBox1.Text = "320";
                    break;
                case "Goyal":
                    comboBox3.Items.Add("11.00 AM");
                    comboBox3.Items.Add("9.30 AM");
                    textBox1.Text = "620";
                    break;
                case "INOX":
                    comboBox3.Items.Add("8.00 PM");
                    comboBox3.Items.Add("10.00 PM");
                    textBox1.Text = "100";
                    break;
                case "Carnival":
                    comboBox3.Items.Add("5.30 PM");
                    comboBox3.Items.Add("8.00 PM");
                    textBox1.Text = "80";
                    break;

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            switch (comboBox1.Text)
            {
                case "Bholaa":
                    comboBox2.Items.Add("Cinemax");
                    comboBox2.Items.Add("Panchasheel");
                    break;
                case "PK":
                    comboBox2.Items.Add("Alankar");
                    comboBox2.Items.Add("Goyal");
                    break;
                case "Pushpa":
                    comboBox2.Items.Add("INOX");
                    comboBox2.Items.Add("Carnival");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Movie_Ticket movie = null;
            if (radioButton1.Checked)
            {
                movie = new Online_booking(comboBox1.Text,comboBox2.Text,comboBox3.Text,Convert.ToInt32(numericUpDown1.Value),Convert.ToInt32(textBox1.Text));
            }
            else if (radioButton2.Checked)
            {
                movie = new Box_Office(comboBox1.Text,comboBox2.Text,comboBox3.Text,Convert.ToInt32( numericUpDown1.Value), Convert.ToInt32(textBox1.Text));

            }
            string Total_price=movie.Calculate_Ticket_Price();
            label7.Text =  movie.Calculate_Ticket_Price();

        }
    }
}
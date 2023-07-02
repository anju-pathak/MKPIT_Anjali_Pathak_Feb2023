using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_desgin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxAge_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled= true;
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            this.TextBoxName.Clear();
            this.TextBoxAge.Clear();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "")
            {
                MessageBox.Show("Please Enter Your Name");
            }
            else 
                {
                string result = Deatils.GetDetails(TextBoxName.Text, Convert.ToInt32(TextBoxAge.Text));
              
                MessageBox.Show(result);
                MessageBox.Show("Data Saved");
            }

           
        }
        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
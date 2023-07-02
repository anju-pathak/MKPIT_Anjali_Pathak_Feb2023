using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Form1 : Form
    {
        #region ==== CONSTRUCTOR ==
        public Form1()
        {
            InitializeComponent();

        }
        #endregion

        #region ===== EVENT =====
        /// <summary>
        /// This method is used for button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
#endregion
        private void button2_Click(object sender, EventArgs e)
        {


            string name = textBox1.Text;
            int age = Convert.ToInt32(textBox2.Text);
            string mobilenumber = textBox3.Text;

            using (Form2 frm = new Form2(name, age, mobilenumber))
                frm.ShowDialog();

        }

        private void button1Reset_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();

            this.textBox3.Text = null;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!char. IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            { e.Handled = true;}
        }
    }
}
   




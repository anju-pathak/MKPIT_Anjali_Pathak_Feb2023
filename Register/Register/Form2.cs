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

namespace Register
{
    public partial class Form2 : Form
    {
        public Form2(string name, int age, string mobilenumber)
        {
           this.InitializeComponent() ;
          this.label1.Text = name;
            this.label2.Text = age.ToString();
            this.label3.Text = mobilenumber;
        }
    }

   
    
}

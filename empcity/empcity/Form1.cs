using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace empcity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                DataSet ds = Employeecity.GetCity();
                foreach (DataRow dr in ds.Tables["City"].Rows)
                {
                    comboBox1.Items.Add(dr["cityname"].ToString());
                }
                DataSet dss = Employeecity.GetCity();
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = null;
            result = Employeecity.InsertRecord(textBox1.Text);
            label1.Text = result;
            textBox1.Clear();

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                DataSet ds = Employeecity.searchemployee(textBox1.Text);
                dataGridView1.DataSource = ds.Tables[0];
           

            }
        }
    }
}

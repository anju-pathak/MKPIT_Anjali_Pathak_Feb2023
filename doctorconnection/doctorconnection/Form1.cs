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


namespace doctorconnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            DataSet ds=DoctorConnection.GetEd();
            foreach(DataRow dr in ds.Tables["Ed"].Rows)
            {
                comboBox1.Items.Add(dr["Ed"].ToString());
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

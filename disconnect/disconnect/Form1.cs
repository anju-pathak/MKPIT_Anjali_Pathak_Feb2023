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
using System.Data;

namespace disconnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = DisconnectConnection.GetCity();
            foreach (DataRow dr in ds.Tables["City"].Rows)
            {
                comboBox1.Items.Add(dr["Cityname"].ToString());
            }
        }

        }
    }


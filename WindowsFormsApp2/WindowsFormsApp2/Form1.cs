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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server=MANISH\\SQLEXPRESS;integrated security=true ;database=Railway_ticket;";
            SqlConnection conn = new SqlConnection(constr);
            
            try
            {
                conn.Open();
                label1.Text = "conncetion successfull";
            }
            catch (Exception ee)
            {
                label1.Text = ToString();
            }
            finally
            {
                conn.Close();

            }
        }
    }
}
    


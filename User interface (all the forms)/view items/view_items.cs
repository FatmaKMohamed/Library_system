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

namespace library_system
{
    public partial class view_items : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");
        int x = 0;

        public view_items()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            literature f2 = new literature();
            f2.Show();

        }

        private void view_items_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            biography f3 = new biography();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            poetry f4 = new poetry();
            f4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            science f5 = new science();
            f5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fantasy f6 = new fantasy();
            f6.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            history f7 = new history();
            f7.Show();
        }
    }
}

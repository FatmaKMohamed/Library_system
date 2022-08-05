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
    public partial class comment : Form
    {
        public comment()
        {
            InitializeComponent();
        }

        private void comment_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "INSERT INTO comment values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Thanks for your opinion!");
        }
    }
}

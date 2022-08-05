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
    public partial class admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");
        int u = 0;

        public admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Authentication_system where user_name ='" + textBox2.Text + "'and user_password ='" + textBox1.Text + "' ";

            DataTable a = new DataTable();
            SqlDataAdapter b = new SqlDataAdapter(cmd);
            b.Fill(a);
            u = Convert.ToInt32(a.Rows.Count.ToString());
            if (u == 0)
            {
                MessageBox.Show("You don't have the permission to log-in");
            }
            else
            {
                this.Hide();
                Form1 g = new Form1();
                g.Show();
            }
           

        }

        private void admin_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

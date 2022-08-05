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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "UPDATE _User set user_name ='"+textBox5.Text+ "',user_password ='" + textBox2.Text + "',email ='" + textBox4.Text + "', phone_number ='" + textBox1.Text + "',address ='" + textBox3.Text + "' where user_id = '" + textBox6.Text + "' ";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Updated successfully");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

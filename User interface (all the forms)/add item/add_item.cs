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
    public partial class add_item : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");
        int i = 0;
        public add_item()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from _User where user_type ='author' and user_id ='" + textBox6.Text + "' ";

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 0)
            {
                MessageBox.Show("You don't have the permission to do that");
            }
            else
            {
                this.Hide();
                con.Open();
                SqlCommand a = con.CreateCommand();
                a.CommandType = CommandType.Text;
                a.CommandText = "INSERT INTO Item values('" + textBox4.Text + "','" + textBox1.Text + "','" + textBox5.Text + "','" + textBox9.Text + "','" + textBox6.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox8.Text + "','" + textBox11.Text + "','" + textBox7.Text + "','" + textBox10.Text + "')";
                a.ExecuteNonQuery();  
             
                con.Close();
                MessageBox.Show("Item added successfully");

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
     }

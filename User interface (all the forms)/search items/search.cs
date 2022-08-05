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
    public partial class search : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");

        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Item where item_name like('%"+textBox1.Text+"%')";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
              DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
              textBox8.Text = row.Cells["publisher_name"].Value.ToString();
              textBox3.Text = row.Cells["author_name"].Value.ToString();
              textBox7.Text = row.Cells["author_id"].Value.ToString();
              textBox9.Text = row.Cells["available"].Value.ToString();
              textBox4.Text = row.Cells["item_name"].Value.ToString();
              textBox12.Text = row.Cells["price"].Value.ToString();
              textBox2.Text = row.Cells["category"].Value.ToString();
              textBox11.Text = row.Cells["_language"].Value.ToString();
              textBox5.Text = row.Cells["item_type"].Value.ToString();
              textBox6.Text = row.Cells["item_id"].Value.ToString();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");
            SqlCommand k = new SqlCommand();
            k.Connection = con;
            con.Open();
            k.CommandText = "INSERT INTO Purchase values('" + textBox10.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            k.ExecuteNonQuery();
            con.Close();
            


            MessageBox.Show("You will recieve your order soon");
        }
    }
}

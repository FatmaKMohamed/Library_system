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
    public partial class fantasy : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F66NTNQ;Initial Catalog=Library_management;Integrated Security=True;Pooling=False");

        public fantasy()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fantasy_Load(object sender, EventArgs e)
        {
           con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from Item where category = 'fantasy'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           con.Close();
        }
    }
}

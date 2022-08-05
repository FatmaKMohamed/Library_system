using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_system
{
    public partial class user_interface : Form
    {
        private int childFormNumber = 0;

        public user_interface()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_item it = new add_item();
            it.Show();
        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void viewAvailableItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_items vi = new view_items();
            vi.Show();
        }

        private void searchForItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search se = new search();
            se.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin adm = new admin();
            adm.Show ();
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {
            update up = new update();
            up.Show();
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {
            student st = new student();
            st.Show();
        }

        private void user_interface_Load(object sender, EventArgs e)
        {

        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {
            comment com = new comment();
            com.Show();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }
    }
}

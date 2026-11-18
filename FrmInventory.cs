using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGOT_WEEK07_WORK08
{
    public partial class FrmInventory : Form
    {   
        public FrmInventory()
        {
            InitializeComponent();
        }

        public void ShowPage(UserControl page)
        {
            pnl_main.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnl_main.Controls.Add(page);
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(new UserControl1());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("Are you about to exit?",
               "Exit Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userResponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

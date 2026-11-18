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
    public partial class UserControl1 : UserControl
    {
        private DataTable table = new DataTable("Product");
        private BindingSource bs = new BindingSource();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void lbl_description_Click(object sender, EventArgs e)
        {

        }

        private void pnl_usercontrol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Product ID");
            table.Columns.Add("Product Name");
            table.Columns.Add("Category");
            table.Columns.Add("Status");

            table.Rows.Add("1", "Sofa", "Furniture", "Available");
            table.Rows.Add("2", "Speaker", "Peripherals", "Available"); 

            bs.DataSource = table;
            dataGridView1.DataSource = bs;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_amount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }
    }
}

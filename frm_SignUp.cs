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
    public partial class frm_SignUp : Form
    {
        public frm_SignUp()
        {
            InitializeComponent();
        }

        public Users user;
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) ||
                string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show(
                    "Please enter both a username and password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            var newUser = new Users
            {
                username = txt_username.Text.Trim(),
                password = txt_password.Text.Trim()
            };

            MessageBox.Show(
                "Registration successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            var loginform = new frm_Login();
            loginform.user = newUser;
            loginform.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_Login log = new frm_Login();
            log.Show();
            this.Hide();
        }

        private void frm_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGOT_WEEK07_WORK08
{
    public partial class frm_Login : Form 
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        public Users user;
        private void showPage(UserControl page)
        {
            
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            frm_SignUp frmSignUp = new frm_SignUp();
            frmSignUp.Show();
            this.Hide();
        }

        
        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text))
            {
                txt_username.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_password.Text))
            {
                txt_password.Focus();
                return;
            }

            if (user == null)
            {
                MessageBox.Show(
                    "No user is registered yet, Please sign up first.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (txt_username.Text.Trim() == user.username
                &&
                txt_password.Text == user.password)
            {
                MessageBox.Show(
                    "Login Success!",
                    "Please sign up first",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                FrmInventory inv = new FrmInventory();
                inv.Show();
                this.Hide();
            }

        }
    }
}

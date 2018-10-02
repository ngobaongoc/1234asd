using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adminapp
{
    public partial class LoginForm : Form
    {
        public Staff currentUser = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Are you want to exit?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
            string user = txtUser.Text;
            string pass = txtPass.Text;
            AdminModel model = new AdminModel();
            currentUser = model.CheckLogin(user, pass);
            if (currentUser == null)
            {
                MessageBox.Show("login sai");
                txtPass.Text = "";
                txtUser.Text = "";
                txtUser.Focus();
            }
            else
            {
                MessageBox.Show("Login sucess");
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          //  if (CkbShowpassword.Checked)
           // {

              //  txtPass.UseSystemPasswordChar = false;
           // }
           // else
           // {
              //  txtPass.UseSystemPasswordChar = true;
           // }
        }
    }
}

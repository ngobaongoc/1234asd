using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        public string studenCurrent = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            ClientModel cm = new ClientModel();
            if(cm.checkLogin(user,pass)==true)
            {
                if (cm.checkExam(txtExamcode.Text))
                {
                    this.Hide();
                }
                else
                    MessageBox.Show("Exam not started!!!");
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Form2 : Form
    {
        List<Question> list = null;  
        public Staff user = null;
        private bool addFlag = false;
        private bool addCheck = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string id = TxtId.Text;
            //AdminModel ad = new AdminModel();
            //if(ad.CheckExist(id)==false)
            //{
            //    MessageBox.Show(" ID question Da ton tai Existed");
            //}
            //else
            //{
            //    addCheck = true;
            //    MessageBox.Show("ID nay co the dung");
            //}
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            //if(!addFlag)
            //{
            //    ResetControl();
            //    btnADD.Text = "Save";
            //}
            //else
            //{
            //    if (addCheck)
            //    {
            //        string id = TxtId.Text;
            //        string A = txtA.Text;
            //        string B = txtB.Text;
            //        string C = txtC.Text;
            //        string D = txtD.Text;
            //        string sid = cb1.SelectedItem.ToString();
            //        string content = rtContent.Text;
            //        string correct = "";
            //        if (sid.Equals("Top Notch 1"))
            //            sid = "TN1";
            //        if (sid.Equals("Top Notch 2"))
            //            sid = "TN2";
            //        if (sid.Equals("Top Notch 3"))
            //            sid = "TN3";
            //        if (sid.Equals("SumMit1"))
            //            sid = "SM1";
            //        if (radioButtonA.Checked)
            //            correct = "_a";
            //        if (radioButtonB.Checked)
            //            correct = "_b";
            //        if (radioButtonC.Checked)
            //            correct = "_c";
            //        if (radioButtonD.Checked)
            //            correct = "_d";
            //        AdminModel ad = new AdminModel();
            //        if (ad.AddnewQuestion(id, content, A, B, C, D, correct, sid))
            //            MessageBox.Show("Add thanh cong");
            //        else
            //            MessageBox.Show("add That bai roi ");
            //        btnADD.Text = "Add New";
            //        ResetControl();
            //    }
            //}
            //addFlag = !addFlag;
        }
        private void ResetControl()
        {
            TxtId.Text = "";
            TxtId.ReadOnly = false;
            rtContent.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            cb1.Text = "";
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
            user = lg.currentUser;
            this.Text = "Welcome to: " + user.Username;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminModel ad = new AdminModel();
            dataGridView1.DataSource = ad.GetQuestions();

        }
        private void ResetGUI()

        {
            TxtIdQofList.Text = "";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            cb1.Text = "";
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;

        }

       

        //private void button1_click_1(object sender, eventargs e)
        //{
        //    string id = txtidqoflist.text;
        //    adminmodel ad = new adminmodel();
        //    if (ad.deletequetion(id) == true)
        //    {
        //        datagridview1.datasource = ad.getquestions();
        //        resetgui();
        //        messagebox.show("delete question thanh cong");
        //    }
        //    else

        //        messagebox.show("that bai");

        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string id = TxtIdQofList.Text;
            //AdminModel ad = new AdminModel();
            //if (ad.DeleteQuetion(id) == true)
            //{
            //    dataGridView1.DataSource = ad.GetQuestions();
            //    ResetGUI();
            //    MessageBox.Show("xoa roi");
            //}
            //else
            //    MessageBox.Show("khong xoa duoc, xem lai");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //TxtId.ReadOnly = true;
            //cb1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            //rtContent.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            //txtA.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtC.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txtD.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            //string Asw = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //if (Asw.Equals("_a"))
            //{
            //    radioButtonA.Checked = true;
            //}
            //if (Asw.Equals("_b"))
            //{
            //    radioButtonB.Checked = true;
            //}
            //if (Asw.Equals("_c"))
            //{
            //    radioButtonC.Checked = true;
            //}
            //if (Asw.Equals("_d"))
            //{
            //    radioButtonD.Checked = true;
            //}
            //btnDelete.Enabled = true;

        }

       

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //string id = TxtId.Text;
            //string subject = cb1.Text;
            //string content = rtContent.Text;
            //string a = radioButtonA.Text;
            //string b = radioButtonB.Text;
            //string c = radioButtonC.Text;
            //string d = radioButtonD.Text;
            //string correct = "";
            //if (radioButtonA.Checked)
            //    correct = "_a";
            //if (radioButtonB.Checked)
            //    correct = "_b";
            //if (radioButtonC.Checked)
            //    correct = "_c";
            //if (radioButtonD.Checked)
            //    correct = "_d";
            //AdminModel ad = new AdminModel();
            //if (ad.updatequestion(id, subject, content, correct, a, b, c, d))
            //{
            //    dataGridView1.DataSource = ad.GetQuestions();
            //    ResetGUI();
            //    MessageBox.Show("Chuc mung may UPADTE thanh cong", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            //}
            //else
            //    MessageBox.Show("that bai");
        }

        

        private void button4_Click_1(object sender, EventArgs e)
        {
            string id = TxtId.Text;
            AdminModel ad = new AdminModel();
            if (ad.CheckExist(id) == false)
            {
                MessageBox.Show(" ID question Da ton tai Existed");
            }
            else
            {
                addCheck = true;
                MessageBox.Show("ID nay co the dung");
            }
        }

        private void btnADD_Click_1(object sender, EventArgs e)
        {

            if (!addFlag)
            {
                ResetControl();
                btnADD.Text = "Save";
            }
            else
            {
                if (addCheck)
                {
                    string id = TxtId.Text;
                    string A = txtA.Text;
                    string B = txtB.Text;
                    string C = txtC.Text;
                    string D = txtD.Text;
                    string sid = cb1.SelectedItem.ToString();
                    string content = rtContent.Text;
                    string correct = "";
                    if (sid.Equals("Top Notch 1"))
                        sid = "TN1";
                    if (sid.Equals("Top Notch 2"))
                        sid = "TN2";
                    if (sid.Equals("Top Notch 3"))
                        sid = "TN3";
                    if (sid.Equals("SumMit1"))
                        sid = "SM1";
                    if (radioButtonA.Checked)
                        correct = "_a";
                    if (radioButtonB.Checked)
                        correct = "_b";
                    if (radioButtonC.Checked)
                        correct = "_c";
                    if (radioButtonD.Checked)
                        correct = "_d";
                    AdminModel ad = new AdminModel();
                    if (ad.AddnewQuestion(id, content, A, B, C, D, correct, sid))
                        MessageBox.Show("Add thanh cong");
                    else
                        MessageBox.Show("add That bai roi ");
                    btnADD.Text = "Add New";
                    ResetControl();
                }
            }
            addFlag = !addFlag;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            string id = TxtId.Text;
            AdminModel ad = new AdminModel();
            if (ad.DeleteQuetion(id) == true)
            {
                dataGridView1.DataSource = ad.GetQuestions();
                ResetGUI();
                MessageBox.Show("xoa roi");
            }
            else
                MessageBox.Show("khong xoa duoc, xem lai");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = TxtId.Text;
            string subject = cb1.Text;
            string content = rtContent.Text;
            string a = radioButtonA.Text;
            string b = radioButtonB.Text;
            string c = radioButtonC.Text;
            string d = radioButtonD.Text;
            string correct = "";
            if (radioButtonA.Checked)
                correct = "_a";
            if (radioButtonB.Checked)
                correct = "_b";
            if (radioButtonC.Checked)
                correct = "_c";
            if (radioButtonD.Checked)
                correct = "_d";
            AdminModel ad = new AdminModel();
            if (ad.updatequestion(id, subject, content, correct, a, b, c, d))
            {
                dataGridView1.DataSource = ad.GetQuestions();
                ResetGUI();
                MessageBox.Show("Chuc mung may UPADTE thanh cong", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
                MessageBox.Show("that bai");
        }

        private void btnViewall_Click(object sender, EventArgs e)
        {
            AdminModel ad = new AdminModel();
            dataGridView1.DataSource = ad.GetQuestions();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string id = TxtIdQofList.Text;
            AdminModel ad = new AdminModel();
            dataGridView1.DataSource = ad.SearchbyID(id);
        }
        

        private void dataGridView1_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtId.ReadOnly = true;
            cb1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            rtContent.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtA.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtC.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtD.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            string Asw = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (Asw.Equals("_a"))
            {
                radioButtonA.Checked = true;
            }
            if (Asw.Equals("_b"))
            {
                radioButtonB.Checked = true;
            }
            if (Asw.Equals("_c"))
            {
                radioButtonC.Checked = true;
            }
            if (Asw.Equals("_d"))
            {
                radioButtonD.Checked = true;
            }
            btnDelete.Enabled = true;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ManageExam md = new ManageExam();
            string type = cb2.SelectedItem.ToString();

            if (type.Equals("Top Notch 1"))
                type = "TN1";
            if (type.Equals("Top Notch 2"))
                type = "TN2";
            if (type.Equals("Top Notch 3"))
                type = "TN3";
            if (type.Equals("SumMit1"))
                type = "SM1";
            list = md.GetrandomQuestion(type);
            MessageBox.Show("Load Cau  hoi thanh cong");
            btnCreate.Enabled = true;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string examcode = txtExamcode.Text;
            string date = dtpdate.Text;
            ManageExam model = new ManageExam();
            if (model.AddNewExam(examcode, date))
            {
                foreach (var item in list)
                {
                    model.AddExamDetail(examcode, item.ID);
                }
                MessageBox.Show("Add thanh cong");
            }
            else
                MessageBox.Show("Add that bai, xem lai");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string id = txtExamcode.Text;
            ManageExam mn = new ManageExam();
           if(mn.CheckID(id)==false)
            {
                MessageBox.Show(" Examcode naay da ton tai");
            }
            else
            {
                MessageBox.Show("Examcode nay dung dc");
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            string idExam = txtExamCode2.Text;
            string date = dateTimePicker2.Text;
            string status = cb3.Text;
            ManageExam mn = new ManageExam();
            if(mn.UpdateExam(idExam,date,status))
            {
                dataGridView2.DataSource = mn.getExam();
                ResetGUI();
                MessageBox.Show("Update Exam thanh cong ", "Notification", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Update failed", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

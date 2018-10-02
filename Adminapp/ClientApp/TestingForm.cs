﻿using System;
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
    public partial class TestingForm : Form
    {
        public string examcode = null;
        List<Question> listQuetion = null;
        List<string> qID = null;
        Question currentQuestion = null;
        public TestingForm()
        {
            InitializeComponent();
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {
            Form1 lg = new Form1();
            lg.ShowDialog();
            examcode = lg.codeExam;
            this.Text = "welcome to:" + lg.username;
            LoadQuestionId(examcode);
            loadQuestion();
        }
    }
}

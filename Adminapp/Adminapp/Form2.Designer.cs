namespace Adminapp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtIdQofList = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtContent = new System.Windows.Forms.RichTextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnViewall = new System.Windows.Forms.Button();
            this.btnCheckID = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.txtIDunder = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtExamCode2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExamcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Location = new System.Drawing.Point(1, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(813, 568);
            this.tab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cb1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rtContent);
            this.tabPage1.Controls.Add(this.TxtId);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(805, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ManageQuestion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.BtnSearch);
            this.groupBox2.Controls.Add(this.TxtIdQofList);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 185);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QuestionList";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 127);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_2);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(278, 17);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TxtIdQofList
            // 
            this.TxtIdQofList.Location = new System.Drawing.Point(113, 19);
            this.TxtIdQofList.Name = "TxtIdQofList";
            this.TxtIdQofList.Size = new System.Drawing.Size(122, 20);
            this.TxtIdQofList.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(27, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Question ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "SubJect";
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Top Notch 1",
            "Top Notch 2",
            "Top Notch 3",
            "SumMit1"});
            this.cb1.Location = new System.Drawing.Point(74, 81);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(142, 21);
            this.cb1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-276, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // rtContent
            // 
            this.rtContent.Location = new System.Drawing.Point(19, 122);
            this.rtContent.Name = "rtContent";
            this.rtContent.Size = new System.Drawing.Size(357, 136);
            this.rtContent.TabIndex = 15;
            this.rtContent.Text = "";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(74, 38);
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.btnViewall);
            this.groupBox1.Controls.Add(this.btnCheckID);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnADD);
            this.groupBox1.Controls.Add(this.radioButtonA);
            this.groupBox1.Controls.Add(this.radioButtonB);
            this.groupBox1.Controls.Add(this.radioButtonC);
            this.groupBox1.Controls.Add(this.radioButtonD);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 345);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QuetionDetail";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(298, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 37);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(463, 218);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(315, 37);
            this.txtD.TabIndex = 11;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(463, 145);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(315, 37);
            this.txtC.TabIndex = 11;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(463, 83);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(315, 37);
            this.txtB.TabIndex = 11;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(463, 19);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(315, 37);
            this.txtA.TabIndex = 11;
            // 
            // btnViewall
            // 
            this.btnViewall.Location = new System.Drawing.Point(601, 288);
            this.btnViewall.Name = "btnViewall";
            this.btnViewall.Size = new System.Drawing.Size(91, 37);
            this.btnViewall.TabIndex = 10;
            this.btnViewall.Text = "View all";
            this.btnViewall.UseVisualStyleBackColor = true;
            this.btnViewall.Click += new System.EventHandler(this.btnViewall_Click);
            // 
            // btnCheckID
            // 
            this.btnCheckID.Location = new System.Drawing.Point(225, 33);
            this.btnCheckID.Name = "btnCheckID";
            this.btnCheckID.Size = new System.Drawing.Size(75, 23);
            this.btnCheckID.TabIndex = 8;
            this.btnCheckID.Text = "Check";
            this.btnCheckID.UseVisualStyleBackColor = true;
            this.btnCheckID.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(453, 288);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Fuchsia;
            this.btnADD.Location = new System.Drawing.Point(132, 288);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(81, 37);
            this.btnADD.TabIndex = 7;
            this.btnADD.Text = "Add New";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click_1);
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(401, 33);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 0;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(401, 93);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 1;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(401, 156);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(32, 17);
            this.radioButtonC.TabIndex = 2;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(401, 226);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(33, 17);
            this.radioButtonD.TabIndex = 2;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "D";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSearch1);
            this.tabPage2.Controls.Add(this.txtIDunder);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnUpdate1);
            this.tabPage2.Controls.Add(this.btnCreate);
            this.tabPage2.Controls.Add(this.cb3);
            this.tabPage2.Controls.Add(this.dateTimePicker3);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.txtExamCode2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtExamcode);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(805, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Exam";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(220, 232);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 26);
            this.btnSearch1.TabIndex = 9;
            this.btnSearch1.Text = "Search";
            this.btnSearch1.UseVisualStyleBackColor = true;
            // 
            // txtIDunder
            // 
            this.txtIDunder.Location = new System.Drawing.Point(16, 232);
            this.txtIDunder.Multiline = true;
            this.txtIDunder.Name = "txtIDunder";
            this.txtIDunder.Size = new System.Drawing.Size(158, 26);
            this.txtIDunder.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(780, 258);
            this.dataGridView2.TabIndex = 7;
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.Location = new System.Drawing.Point(577, 171);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate1.TabIndex = 4;
            this.btnUpdate1.Text = "Update";
            this.btnUpdate1.UseVisualStyleBackColor = true;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(145, 171);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Items.AddRange(new object[] {
            "D",
            "W",
            "C"});
            this.cb3.Location = new System.Drawing.Point(577, 120);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(154, 21);
            this.cb3.TabIndex = 3;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "dd/YY/mm";
            this.dateTimePicker3.Location = new System.Drawing.Point(1037, 78);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker3.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/YY/mm";
            this.dateTimePicker2.Location = new System.Drawing.Point(577, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // txtExamCode2
            // 
            this.txtExamCode2.Location = new System.Drawing.Point(577, 32);
            this.txtExamCode2.Name = "txtExamCode2";
            this.txtExamCode2.Size = new System.Drawing.Size(154, 20);
            this.txtExamCode2.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Status";
            // 
            // txtExamcode
            // 
            this.txtExamcode.Location = new System.Drawing.Point(117, 32);
            this.txtExamcode.Name = "txtExamcode";
            this.txtExamcode.Size = new System.Drawing.Size(154, 20);
            this.txtExamcode.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Subject";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Exam code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(486, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Exam code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpdate);
            this.panel1.Controls.Add(this.cb2);
            this.panel1.Controls.Add(this.btnRandom);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 197);
            this.panel1.TabIndex = 5;
            // 
            // dtpdate
            // 
            this.dtpdate.CustomFormat = "dd/YY/mm";
            this.dtpdate.Location = new System.Drawing.Point(101, 55);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(197, 20);
            this.dtpdate.TabIndex = 2;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "Top Notch 1",
            "Top Notch 2",
            "Top Notch 3",
            "SumMit1"});
            this.cb2.Location = new System.Drawing.Point(101, 96);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(154, 21);
            this.cb2.TabIndex = 3;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(307, 137);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(316, 16);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(469, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 197);
            this.panel2.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 567);
            this.Controls.Add(this.tab);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtIdQofList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtContent;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnViewall;
        private System.Windows.Forms.Button btnCheckID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.TextBox txtIDunder;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.TextBox txtExamCode2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExamcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
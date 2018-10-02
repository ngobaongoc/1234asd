namespace ClientApp
{
    partial class TestingForm
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
            this.listQuestion = new System.Windows.Forms.ListBox();
            this.rttest = new System.Windows.Forms.RichTextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listQuestion
            // 
            this.listQuestion.FormattingEnabled = true;
            this.listQuestion.Location = new System.Drawing.Point(12, 31);
            this.listQuestion.Name = "listQuestion";
            this.listQuestion.Size = new System.Drawing.Size(157, 355);
            this.listQuestion.TabIndex = 0;
            // 
            // rttest
            // 
            this.rttest.Location = new System.Drawing.Point(239, 44);
            this.rttest.Name = "rttest";
            this.rttest.Size = new System.Drawing.Size(517, 96);
            this.rttest.TabIndex = 1;
            this.rttest.Text = "";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(239, 188);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(239, 264);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "B";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(239, 335);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(239, 382);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(33, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "D";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(380, 175);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(376, 39);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(380, 248);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(376, 42);
            this.txtB.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(380, 317);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(376, 35);
            this.txtC.TabIndex = 3;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(380, 375);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(376, 40);
            this.txtD.TabIndex = 3;
            // 
            // TestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rttest);
            this.Controls.Add(this.listQuestion);
            this.Name = "TestingForm";
            this.Text = "TestingForm";
            this.Load += new System.EventHandler(this.TestingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listQuestion;
        private System.Windows.Forms.RichTextBox rttest;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
    }
}
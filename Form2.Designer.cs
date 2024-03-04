using System.Drawing;
using System.Reflection.Emit;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentLoanCalculatorCsharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtboxSalary = new System.Windows.Forms.TextBox();
            this.txtboxLoanAmount = new System.Windows.Forms.TextBox();
            this.txtboxInterestRate = new System.Windows.Forms.TextBox();
            this.txtboxThreshold = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtboxMaxTerms = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtboxRepaymentPercent = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.Quitbtn = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.lblCalculationConfirm = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxSalary
            // 
            this.txtboxSalary.BackColor = System.Drawing.Color.White;
            this.txtboxSalary.ForeColor = System.Drawing.Color.Black;
            this.txtboxSalary.Location = new System.Drawing.Point(20, 93);
            this.txtboxSalary.Name = "txtboxSalary";
            this.txtboxSalary.Size = new System.Drawing.Size(141, 31);
            this.txtboxSalary.TabIndex = 0;
            this.txtboxSalary.Text = "80000";
            // 
            // txtboxLoanAmount
            // 
            this.txtboxLoanAmount.BackColor = System.Drawing.Color.White;
            this.txtboxLoanAmount.Location = new System.Drawing.Point(20, 186);
            this.txtboxLoanAmount.Name = "txtboxLoanAmount";
            this.txtboxLoanAmount.Size = new System.Drawing.Size(141, 31);
            this.txtboxLoanAmount.TabIndex = 1;
            this.txtboxLoanAmount.Text = "35000";
            // 
            // txtboxInterestRate
            // 
            this.txtboxInterestRate.BackColor = System.Drawing.Color.White;
            this.txtboxInterestRate.Location = new System.Drawing.Point(39, 72);
            this.txtboxInterestRate.Name = "txtboxInterestRate";
            this.txtboxInterestRate.Size = new System.Drawing.Size(116, 31);
            this.txtboxInterestRate.TabIndex = 2;
            this.txtboxInterestRate.Text = " 6.3";
            // 
            // txtboxThreshold
            // 
            this.txtboxThreshold.BackColor = System.Drawing.Color.White;
            this.txtboxThreshold.Location = new System.Drawing.Point(37, 147);
            this.txtboxThreshold.Name = "txtboxThreshold";
            this.txtboxThreshold.Size = new System.Drawing.Size(118, 31);
            this.txtboxThreshold.TabIndex = 3;
            this.txtboxThreshold.Text = "  25000";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Forte", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(282, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(551, 51);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Student Loan Calculator ";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtboxSalary);
            this.GroupBox1.Controls.Add(this.txtboxLoanAmount);
            this.GroupBox1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.Color.White;
            this.GroupBox1.Location = new System.Drawing.Point(40, 324);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(274, 250);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Personal Information";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(17, 163);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(234, 22);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Student Loan Amount (£)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(17, 68);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(169, 22);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Annual Salary (£)";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.txtboxMaxTerms);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.txtboxRepaymentPercent);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.txtboxInterestRate);
            this.GroupBox2.Controls.Add(this.txtboxThreshold);
            this.GroupBox2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.White;
            this.GroupBox2.Location = new System.Drawing.Point(894, 197);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(320, 377);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Loan Data";
            // 
            // txtboxMaxTerms
            // 
            this.txtboxMaxTerms.BackColor = System.Drawing.Color.White;
            this.txtboxMaxTerms.Location = new System.Drawing.Point(37, 311);
            this.txtboxMaxTerms.Name = "txtboxMaxTerms";
            this.txtboxMaxTerms.Size = new System.Drawing.Size(117, 31);
            this.txtboxMaxTerms.TabIndex = 11;
            this.txtboxMaxTerms.Text = "30";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(33, 345);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(287, 22);
            this.Label9.TabIndex = 10;
            this.Label9.Text = "(Standard:30 yrs[360  Months])";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(33, 290);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(231, 22);
            this.Label7.TabIndex = 9;
            this.Label7.Text = "Maximum Terms (Years)";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(35, 211);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(259, 22);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Repayment Percentage (%)";
            // 
            // txtboxRepaymentPercent
            // 
            this.txtboxRepaymentPercent.BackColor = System.Drawing.Color.White;
            this.txtboxRepaymentPercent.Location = new System.Drawing.Point(38, 234);
            this.txtboxRepaymentPercent.Name = "txtboxRepaymentPercent";
            this.txtboxRepaymentPercent.Size = new System.Drawing.Size(117, 31);
            this.txtboxRepaymentPercent.TabIndex = 6;
            this.txtboxRepaymentPercent.Text = "  9";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(35, 39);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(231, 22);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Annual Interest Rate (%)";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(34, 127);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(236, 22);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Repayment Threshold (£)";
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Calculatebtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculatebtn.ForeColor = System.Drawing.Color.Black;
            this.Calculatebtn.Location = new System.Drawing.Point(532, 446);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(190, 42);
            this.Calculatebtn.TabIndex = 8;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.UseVisualStyleBackColor = false;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click_1);
            // 
            // Quitbtn
            // 
            this.Quitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Quitbtn.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbtn.Location = new System.Drawing.Point(532, 534);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(190, 41);
            this.Quitbtn.TabIndex = 9;
            this.Quitbtn.Text = "Quit";
            this.Quitbtn.UseVisualStyleBackColor = false;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // Button3
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.Location = new System.Drawing.Point(1147, 608);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(67, 41);
            this.Button3.TabIndex = 11;
            this.Button3.Text = "=>";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lblCalculationConfirm
            // 
            this.lblCalculationConfirm.AutoSize = true;
            this.lblCalculationConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblCalculationConfirm.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculationConfirm.Location = new System.Drawing.Point(528, 167);
            this.lblCalculationConfirm.Name = "lblCalculationConfirm";
            this.lblCalculationConfirm.Size = new System.Drawing.Size(0, 22);
            this.lblCalculationConfirm.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(536, 125);
            this.label8.TabIndex = 12;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.lblCalculationConfirm);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.Calculatebtn);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Student Loan Calculator";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button Calculatebtn;
        private System.Windows.Forms.Button Quitbtn;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.ErrorProvider ErrorProvider1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCalculationConfirm;
        public TextBox txtboxSalary;
        public TextBox txtboxLoanAmount;
        public TextBox txtboxInterestRate;
        public TextBox txtboxThreshold;
        public TextBox txtboxRepaymentPercent;
        public TextBox txtboxMaxTerms;
    }
}
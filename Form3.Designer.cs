using System.Drawing;
using System.Windows.Forms;
using System;

namespace StudentLoanCalculatorCsharp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtboxMonths = new System.Windows.Forms.RichTextBox();
            this.txtboxYears = new System.Windows.Forms.RichTextBox();
            this.txtboxTotalPayment = new System.Windows.Forms.RichTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtboxLoanConfirm = new System.Windows.Forms.RichTextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblRepaymentData = new System.Windows.Forms.Label();
            this.lstBoxInfo = new System.Windows.Forms.ListBox();
            this.txtboxAnnualRepayment = new System.Windows.Forms.TextBox();
            this.txtboxMonthlyRepayment = new System.Windows.Forms.TextBox();
            this.lblAnnualRepayment = new System.Windows.Forms.Label();
            this.lblMonthlyRepayment = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtboxTotalInterestPaid = new System.Windows.Forms.RichTextBox();
            this.Quitbtn = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.txtBoxBack = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblRefund = new System.Windows.Forms.Label();
            this.lblRefundPrice = new System.Windows.Forms.Label();
            this.txtboxSalaryConfirm = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxMonths
            // 
            this.txtboxMonths.Enabled = false;
            this.txtboxMonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMonths.Location = new System.Drawing.Point(50, 341);
            this.txtboxMonths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxMonths.Name = "txtboxMonths";
            this.txtboxMonths.Size = new System.Drawing.Size(119, 40);
            this.txtboxMonths.TabIndex = 0;
            this.txtboxMonths.Text = "";
            // 
            // txtboxYears
            // 
            this.txtboxYears.Enabled = false;
            this.txtboxYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxYears.Location = new System.Drawing.Point(50, 260);
            this.txtboxYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxYears.Name = "txtboxYears";
            this.txtboxYears.Size = new System.Drawing.Size(119, 37);
            this.txtboxYears.TabIndex = 1;
            this.txtboxYears.Text = "";
            // 
            // txtboxTotalPayment
            // 
            this.txtboxTotalPayment.Enabled = false;
            this.txtboxTotalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTotalPayment.Location = new System.Drawing.Point(979, 549);
            this.txtboxTotalPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxTotalPayment.Name = "txtboxTotalPayment";
            this.txtboxTotalPayment.Size = new System.Drawing.Size(223, 51);
            this.txtboxTotalPayment.TabIndex = 2;
            this.txtboxTotalPayment.Text = "";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(63, 148);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(158, 26);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Your loan of £";
            // 
            // txtboxLoanConfirm
            // 
            this.txtboxLoanConfirm.Enabled = false;
            this.txtboxLoanConfirm.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxLoanConfirm.Location = new System.Drawing.Point(234, 140);
            this.txtboxLoanConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxLoanConfirm.Name = "txtboxLoanConfirm";
            this.txtboxLoanConfirm.Size = new System.Drawing.Size(141, 34);
            this.txtboxLoanConfirm.TabIndex = 4;
            this.txtboxLoanConfirm.Text = "";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(174, 354);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 26);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Months";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(174, 269);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 26);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Years";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label5.Location = new System.Drawing.Point(563, 572);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(358, 28);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "The Total Amount payed is :   £";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(376, 148);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(238, 26);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Will be repayed in ...";
            // 
            // lblRepaymentData
            // 
            this.lblRepaymentData.AutoSize = true;
            this.lblRepaymentData.BackColor = System.Drawing.Color.Transparent;
            this.lblRepaymentData.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepaymentData.ForeColor = System.Drawing.Color.White;
            this.lblRepaymentData.Location = new System.Drawing.Point(822, 93);
            this.lblRepaymentData.Name = "lblRepaymentData";
            this.lblRepaymentData.Size = new System.Drawing.Size(287, 26);
            this.lblRepaymentData.TabIndex = 10;
            this.lblRepaymentData.Text = "Detailed repayment data :";
            // 
            // lstBoxInfo
            // 
            this.lstBoxInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxInfo.FormattingEnabled = true;
            this.lstBoxInfo.ItemHeight = 22;
            this.lstBoxInfo.Location = new System.Drawing.Point(713, 149);
            this.lstBoxInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBoxInfo.Name = "lstBoxInfo";
            this.lstBoxInfo.Size = new System.Drawing.Size(489, 356);
            this.lstBoxInfo.TabIndex = 11;
            // 
            // txtboxAnnualRepayment
            // 
            this.txtboxAnnualRepayment.Enabled = false;
            this.txtboxAnnualRepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxAnnualRepayment.Location = new System.Drawing.Point(49, 417);
            this.txtboxAnnualRepayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxAnnualRepayment.Name = "txtboxAnnualRepayment";
            this.txtboxAnnualRepayment.Size = new System.Drawing.Size(149, 30);
            this.txtboxAnnualRepayment.TabIndex = 12;
            // 
            // txtboxMonthlyRepayment
            // 
            this.txtboxMonthlyRepayment.Enabled = false;
            this.txtboxMonthlyRepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMonthlyRepayment.Location = new System.Drawing.Point(49, 475);
            this.txtboxMonthlyRepayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxMonthlyRepayment.Name = "txtboxMonthlyRepayment";
            this.txtboxMonthlyRepayment.Size = new System.Drawing.Size(149, 30);
            this.txtboxMonthlyRepayment.TabIndex = 13;
            // 
            // lblAnnualRepayment
            // 
            this.lblAnnualRepayment.AutoSize = true;
            this.lblAnnualRepayment.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnualRepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnnualRepayment.ForeColor = System.Drawing.Color.White;
            this.lblAnnualRepayment.Location = new System.Drawing.Point(50, 393);
            this.lblAnnualRepayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnualRepayment.Name = "lblAnnualRepayment";
            this.lblAnnualRepayment.Size = new System.Drawing.Size(171, 20);
            this.lblAnnualRepayment.TabIndex = 14;
            this.lblAnnualRepayment.Text = "Annual Repayment ";
            // 
            // lblMonthlyRepayment
            // 
            this.lblMonthlyRepayment.AutoSize = true;
            this.lblMonthlyRepayment.BackColor = System.Drawing.Color.Transparent;
            this.lblMonthlyRepayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyRepayment.ForeColor = System.Drawing.Color.White;
            this.lblMonthlyRepayment.Location = new System.Drawing.Point(45, 451);
            this.lblMonthlyRepayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonthlyRepayment.Name = "lblMonthlyRepayment";
            this.lblMonthlyRepayment.Size = new System.Drawing.Size(179, 20);
            this.lblMonthlyRepayment.TabIndex = 15;
            this.lblMonthlyRepayment.Text = "Monthly Repayment ";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label7.Location = new System.Drawing.Point(574, 616);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(347, 28);
            this.Label7.TabIndex = 16;
            this.Label7.Text = "With Total Interest payed :    £\r\n";
            // 
            // txtboxTotalInterestPaid
            // 
            this.txtboxTotalInterestPaid.DetectUrls = false;
            this.txtboxTotalInterestPaid.Enabled = false;
            this.txtboxTotalInterestPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTotalInterestPaid.Location = new System.Drawing.Point(979, 604);
            this.txtboxTotalInterestPaid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxTotalInterestPaid.Name = "txtboxTotalInterestPaid";
            this.txtboxTotalInterestPaid.Size = new System.Drawing.Size(223, 51);
            this.txtboxTotalInterestPaid.TabIndex = 17;
            this.txtboxTotalInterestPaid.Text = "";
            // 
            // Quitbtn
            // 
            this.Quitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Quitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbtn.Location = new System.Drawing.Point(201, 583);
            this.Quitbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(163, 60);
            this.Quitbtn.TabIndex = 20;
            this.Quitbtn.Text = "Quit";
            this.Quitbtn.UseVisualStyleBackColor = false;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetButton.Location = new System.Drawing.Point(426, 583);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(91, 60);
            this.ResetButton.TabIndex = 21;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // txtBoxBack
            // 
            this.txtBoxBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBack.ForeColor = System.Drawing.Color.Black;
            this.txtBoxBack.Location = new System.Drawing.Point(50, 583);
            this.txtBoxBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxBack.Name = "txtBoxBack";
            this.txtBoxBack.Size = new System.Drawing.Size(91, 60);
            this.txtBoxBack.TabIndex = 22;
            this.txtBoxBack.Text = "Back";
            this.txtBoxBack.UseVisualStyleBackColor = false;
            this.txtBoxBack.Click += new System.EventHandler(this.txtBoxBack_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(91, 306);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(36, 25);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Or";
            // 
            // lblRefund
            // 
            this.lblRefund.AutoSize = true;
            this.lblRefund.BackColor = System.Drawing.Color.Transparent;
            this.lblRefund.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRefund.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefund.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRefund.Location = new System.Drawing.Point(564, 417);
            this.lblRefund.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefund.Name = "lblRefund";
            this.lblRefund.Size = new System.Drawing.Size(3, 30);
            this.lblRefund.TabIndex = 24;
            // 
            // lblRefundPrice
            // 
            this.lblRefundPrice.AutoSize = true;
            this.lblRefundPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblRefundPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRefundPrice.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefundPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRefundPrice.Location = new System.Drawing.Point(564, 483);
            this.lblRefundPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefundPrice.Name = "lblRefundPrice";
            this.lblRefundPrice.Size = new System.Drawing.Size(3, 30);
            this.lblRefundPrice.TabIndex = 25;
            // 
            // txtboxSalaryConfirm
            // 
            this.txtboxSalaryConfirm.Enabled = false;
            this.txtboxSalaryConfirm.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxSalaryConfirm.Location = new System.Drawing.Point(201, 66);
            this.txtboxSalaryConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxSalaryConfirm.Name = "txtboxSalaryConfirm";
            this.txtboxSalaryConfirm.Size = new System.Drawing.Size(141, 34);
            this.txtboxSalaryConfirm.TabIndex = 27;
            this.txtboxSalaryConfirm.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "With salary £";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(343, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 26);
            this.label8.TabIndex = 28;
            this.label8.Text = "per year";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtboxSalaryConfirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblRefundPrice);
            this.Controls.Add(this.lblRefund);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtBoxBack);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Quitbtn);
            this.Controls.Add(this.txtboxTotalInterestPaid);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lblMonthlyRepayment);
            this.Controls.Add(this.lblAnnualRepayment);
            this.Controls.Add(this.txtboxMonthlyRepayment);
            this.Controls.Add(this.txtboxAnnualRepayment);
            this.Controls.Add(this.lstBoxInfo);
            this.Controls.Add(this.lblRepaymentData);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtboxLoanConfirm);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtboxTotalPayment);
            this.Controls.Add(this.txtboxYears);
            this.Controls.Add(this.txtboxMonths);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal RichTextBox txtboxMonths;
        internal RichTextBox txtboxYears;
        internal RichTextBox txtboxTotalPayment;
        internal Label Label1;
        internal RichTextBox txtboxLoanConfirm;
        internal Label Label2;
        internal Label Label3;
        internal Label Label5;
        internal Label Label6;
        internal Label lblRepaymentData;
        internal ListBox lstBoxInfo;
        internal TextBox txtboxAnnualRepayment;
        internal TextBox txtboxMonthlyRepayment;
        internal Label lblAnnualRepayment;
        internal Label lblMonthlyRepayment;
        internal Label Label7;
        internal RichTextBox txtboxTotalInterestPaid;
        internal Button Quitbtn;
        internal Button ResetButton;
        internal Button txtBoxBack;
        internal Label Label4;
        internal Label lblRefund;
        internal Label lblRefundPrice;

        #endregion

        internal RichTextBox txtboxSalaryConfirm;
        internal Label label9;
        internal Label label8;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLoanCalculatorCsharp
{
    public partial class Form3 : Form
    {
        private Form2 form2Instance; // Add a private instance of Form2

        public Form3(Form2 form2) // Modify the constructor to accept a Form2 instance
        {
            InitializeComponent();
            this.form2Instance = form2; // Assign the passed Form2 instance to the private instance
        }

        // ===============================================
        // Clicking the exit button will close the App
        // ===============================================

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            DialogResult Response;
            Response = MessageBox.Show("Would you like to exit ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ================================================================================================
        // Clicking the "Reset" button will close form 3 , show form 3 and let the user re-do the process
        // ================================================================================================

        private void ResetButton_Click(object sender, EventArgs e)
        {
            form2Instance.txtboxSalary.Clear(); // Use the instance to access the TextBox
            form2Instance.txtboxLoanAmount.Clear(); // Use the instance to access the TextBox
            form2Instance.txtboxMaxTerms.Clear(); // Use the instance to access the TextBox
            this.txtboxLoanConfirm.Clear();
            this.txtboxSalaryConfirm.Clear();
            this.txtboxAnnualRepayment.Clear();
            this.txtboxMonthlyRepayment.Clear();
            this.txtboxMonths.Clear();
            this.txtboxYears.Clear();
            this.txtboxTotalInterestPaid.Clear();
            this.txtboxTotalPayment.Clear();
            this.lstBoxInfo.Items.Clear();
            this.Hide();
            form2Instance.Show(); // Use the instance to show the Form2
        }

        // ===============================================================================================================================
        // The use of "Back" button is to give freedome to the user to view both the inputs and the outputs after a successful calculation
        // ===============================================================================================================================
        private void txtBoxBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2Instance.Show(); // Use the instance to show the Form2
        }


    }
}

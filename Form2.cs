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
    public partial class Form2 : Form
    {
        // Declaring variables globally so that all methods can access them
        private decimal decAnnualSalary;    // This is the annual salary
        private decimal decLoanAmount;      // This is the loan amount
        private int intMaxTermYrs;          // This is the maximum term of the loan in years
        private int intMaxTermMonths;       // This is the maximum term of the loan in months
        private decimal decInterestRate;    // This is the interest rate of the loan during the term period
        private int intThreshold;           // This is the repayment threshold of the loan
        private decimal decRepPercent;      // This is the repayment percentage the user will have to pay
        private decimal decRefund;          // The refund the user will get (if needed)

        private Form3 form3; // Declare Form3 instance here

        public Form2()
        {
            InitializeComponent();
            form3 = new Form3(this); // Initialize Form3 instance here
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //=========================================================================================================================================================
        //# All the actions taking place after clicking the "Calculate" button 
        //=========================================================================================================================================================

        private void Calculatebtn_Click_1(object sender, EventArgs e)
        {
            //==============================================================================
            //# Validating all the input text Boxes to make sure we have the wanted inputs
            //==============================================================================

            //=> Ceate individual Lock booleans for the validations to ensure Form3 wont appear and the error messages will show , if there is an input error 
            //---------------------------------------------------------------------------------------------------------------------------------------------

            bool Lock1 = false;
            bool Lock2 = false;
            bool Lock3 = false;
            bool Lock4 = false;
            bool Lock5 = false;
            bool Lock6 = false;



            // Validating term for numeric values, non-negative values, and non-blank boxes
            if (decimal.TryParse(txtboxMaxTerms.Text, out var termValue) && termValue > 0)
            {
                intMaxTermYrs = (int)termValue;
                intMaxTermMonths = intMaxTermYrs * 12;
                Lock1 = true;
            }
            else
            {
                MessageBox.Show("The *Term* value is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Lock1 = false;
            }

            // Validating loan amount for numeric value, non-negative values, and non-blank boxes
            if (decimal.TryParse(txtboxLoanAmount.Text, out var loanAmount) && loanAmount > 0)
            {
                decLoanAmount = loanAmount;
                Lock2 = true;
            }
            else
            {
                MessageBox.Show("The *Loan Amount* value is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Lock2 = false;
            }

            // Validating annual salary amount for numeric value, non-negative values, and non-blank boxes
            if (decimal.TryParse(txtboxSalary.Text, out var salary) && salary > 0)
            {
                decAnnualSalary = salary;
                Lock3 = true;
            }
            else
            {
                MessageBox.Show("The *Salary* value is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Lock3 = false;
            }

            // Validating interest rate for numeric values, non-negative values, and non-blank boxes
            if (decimal.TryParse(txtboxInterestRate.Text, out var interestRate) && interestRate > 0)
            {
                decInterestRate = interestRate;
                Lock4 = true;
            }
            else
            {
                MessageBox.Show("The *Interest Rate* value is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Lock4 = false;
            }

            // Validating repayment threshold for numeric values, non-negative values, and non-blank boxes
            if (decimal.TryParse(txtboxThreshold.Text, out var threshold) && threshold > 0)
            {
                intThreshold = (int)threshold;
                Lock5 = true;
            }
            else
            {
                MessageBox.Show("The *Repayment Threshold* value is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Lock5 = false;
            }

            // Validating repayment percentage for numeric values, non-negative values, and non-blank boxes
            if (decimal.TryParse(txtboxRepaymentPercent.Text, out var repPercent) && repPercent > 0)
            {
                decRepPercent = repPercent;
                Lock6 = true;
            }
            else
            {
                MessageBox.Show("The *Repayment Percentage* value is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Lock6 = false;
            }

            if (Lock1 && Lock2 && Lock3 && Lock4 && Lock5 && Lock6)
            {
                form3.Show();
                this.Hide();
            }
            else
            {
                // We erase all the previous results (if this was the second+ attempt) in order to not affect further calculations
                form3.txtboxLoanConfirm.Clear();
                form3.txtboxSalaryConfirm.Clear();
                form3.txtboxAnnualRepayment.Clear();
                form3.txtboxMonthlyRepayment.Clear();
                form3.txtboxMonths.Clear();
                form3.txtboxYears.Clear();
                form3.txtboxTotalInterestPaid.Clear();
                form3.txtboxTotalPayment.Clear();
                form3.lstBoxInfo.Items.Clear();

                // Program skips ahead to the location of "exitpoint", which is at the "End Sub", thus ending the "Calculation Button" actions.
                return;
            }


            //================================================================================
            //# Calculation Section                                                          
            //================================================================================

            // Local variable declaration for our calculations
            decimal decBalanceNow = 0;
            decimal decClosingBalance = 0;
            decimal decAnnualRepayment = 0;
            decimal decMonthlyRepayment = 0;
            decimal decAnnualInterest = 0;
            decimal decMonthlyInterest = 0;
            decimal decTotalInterest = 0;

            //## IMPORTANT: decAnnualInterest/decMonthlyInterest refers to the amount of money (£) of that interest. decInterestRate refers to the percentage (%) of interest, NOT money.

            //---------------------------------------------------------------------
            //Find and dislay annual and monlthly repayment  ( step 1 )
            //---------------------------------------------------------------------
            if (decAnnualSalary < intThreshold)
            {
                lblCalculationConfirm.Text = "The *Annual Salary* can't be lower than the *Repayment Threshold*";
                form3.Hide();
                this.Show();
                return;

            //We clarify that if the above "if" statement is correct, the program will skip all the below calculations and go straight to "end sub".
            //---------------------------------------------------------------------------------------------------------------------------------------


            }
            else
            {
                lblCalculationConfirm.Text = " ";

                decAnnualRepayment = (decAnnualSalary - intThreshold) * (decRepPercent / 100);
                decMonthlyRepayment = decAnnualRepayment / 12;

                // Rounding up the results
                decMonthlyRepayment = Math.Round(decMonthlyRepayment, 2);
                decAnnualRepayment = Math.Round(decAnnualRepayment, 2);

                // Displaying the results
                form3.txtboxAnnualRepayment.Text = decAnnualRepayment.ToString();
                form3.txtboxMonthlyRepayment.Text = decMonthlyRepayment.ToString();
            }

            //-------------------------------------------------------------------------------------
            //Find and show the opening/closing  balance and interest for each month ( step 2 ) 
            //-------------------------------------------------------------------------------------
            int intCounter = 0;
            bool balanceRepaid = false;
            decimal decRepaymentMade = 0;
            decimal decBalance = decLoanAmount;
            decTotalInterest = 0;

            //FORM 3 LIST BOX 
            //------------------------------
            form3.lstBoxInfo.Items.Clear();

            //The "Try" statement protects the programe from errors. The statement catches the errors and improuves the user experience.

            try
            {
                do
                {
                    // Inserting counter 
                    intCounter++;
                    //Calculations part which will be desplayed in the listbox.

                    decAnnualInterest = decBalance * (decInterestRate / 100);
                    decMonthlyInterest = decAnnualInterest / 12;
                    decMonthlyInterest = Math.Round(decMonthlyInterest, 2);
                    decTotalInterest += decMonthlyInterest; //  total interest paid

                    decBalanceNow = decBalance + decMonthlyInterest;
                    decClosingBalance = decBalanceNow - decMonthlyRepayment;

                    //Ensuring there are no extra charges at the end of the repayment period, and the closing balance does not reach negative value.
                    //Essentially tis the money that the user paid extra and we need to give it back to him.
                    if (decClosingBalance < 0)
                    {
                        // Correctly updating the total repayment made to account for the actual repayment
                        // needed to reach a zero balance, not including the overpaid amount.
                        decRepaymentMade += decMonthlyRepayment + decClosingBalance; // Adjust the total repayment

                        // Calculate the refund amount, which is the absolute value of the negative closing balance
                        decRefund = -decClosingBalance; // This correctly calculates the refund amount

                        // Reset the closing balance to zero since the loan is fully repaid
                        decClosingBalance = 0;

                        // Displaying to the user the amount of refund they will receive due to overpayment
                        form3.lblRefund.Text = $"You got a refund of: £{decRefund.ToString("N2")}"; // Formatted for clarity
                    }


                    //LIST BOX results from FORM 3  
                    //--------------------------------------------------------
                    form3.lstBoxInfo.Items.Add($"Repayment for month: {intCounter}");
                    form3.lstBoxInfo.Items.Add($"Closing balance is: £{decClosingBalance}");
                    form3.lstBoxInfo.Items.Add($"Interest paid is: £{decMonthlyInterest}");
                    form3.lstBoxInfo.Items.Add(""); // Leaving an empty space between months to make it easier for the user to read.

                    //================================================================================================
                    //Showing the core results of the application  (Step 3)
                    //================================================================================================
                    if (intCounter == intMaxTermMonths || decClosingBalance <= 0)
                    {
                        balanceRepaid = true;
                        //TEXT BOXES FROM FORM 3 // Total Repayment and Interest payed through the period 
                        //---------------------------------------------------------------------------------
                        form3.txtboxTotalPayment.Text = decRepaymentMade.ToString();
                        form3.txtboxTotalInterestPaid.Text = decTotalInterest.ToString();
                    }
                } while (intCounter != intMaxTermMonths && !balanceRepaid);
            }
            catch (Exception ex)
            {
                // Exception handling logic here
            }

            form3.txtboxSalaryConfirm.Text = decAnnualSalary.ToString();
            decimal decCounterYrs; //creating a variable to show the total years taken to repay the loan 
            form3.txtboxLoanConfirm.Text = decLoanAmount.ToString();
            form3.txtboxMonths.Text = intCounter.ToString();
            decCounterYrs = intCounter / 12m;
            decCounterYrs = Math.Round(decCounterYrs, 1); //round-up the yearly counter up to 1 decimal number since we reffer to years so anything more than that is insignifficant 
            form3.txtboxYears.Text = decCounterYrs.ToString();
        }


        //===================================================================================================================================
        //Actions after clicking the "Exit" and "=>" ( Arrow ) buttons 
        //===================================================================================================================================


        //This is the "Quit"  button.When clicked , form 2 closes and there should be no program forms shown.
        //---------------------------------------------------------------------------------------------------

        private void Quitbtn_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Would you like to exit ?", "",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //===============================================================================================================================
        //The use of "Arrow" button is to give freedome to the user to view both the inputs and the outputs after a successful calculation process
        //===============================================================================================================================
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            form3.Show();
        }
    }
}

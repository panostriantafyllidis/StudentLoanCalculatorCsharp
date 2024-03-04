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
    public partial class Form1 : Form
    {
        private Timer timer1; // Declare a Timer object

        public Form1()
        {
            InitializeComponent();

            timer1 = new Timer(); // Initialize the Timer object
            timer1.Interval = 80; // Set the timer interval 
            timer1.Tick += new EventHandler(Timer1_Tick); // Attach the Tick event handler
            timer1.Start(); // Start the timer
        }

        // ==========================================================================================
        // #  Close the splash screen and open the new form once the progress bar timer expires ' 
        // ==========================================================================================

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.ProgressBar1.Increment(2);

            // The bar is being filled by two values at a time. When it reaches 80 the cover page hides and form 2 is shown
            if (this.ProgressBar1.Value >= 80)
            {
                timer1.Stop(); // Stop the timer

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }
    }
}

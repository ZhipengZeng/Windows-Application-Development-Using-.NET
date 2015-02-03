using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment =
                        Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate =
                        Convert.ToDecimal(txtInterestRate.Text);
                    int years =
                        Convert.ToInt32(cboNumberOfYears.Text);

                    // Clear the list box each time the Calculate button is clicked
                    lstFutureValue.Items.Clear();
                    
                    // Add the future value to list box
                    for (int i = 1; i <= years; i++)
                    {
                        int months = i * 12;
                        decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
                        decimal futureValue = CalculateFutureValue(
                            monthlyInvestment, monthlyInterestRate, months);
                        string msg = null;
                        msg += "Year" + i + ": " + futureValue.ToString("c") + "\n";
                        if (months % 12 == 0)
                        {
                            lstFutureValue.Items.Add(msg);
                        }
                    }
                    txtMonthlyInvestment.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
            
            
        }

        public bool IsValidData()
        {
            return
                // Validate the Monthly Investment text box
                IsPresent(txtMonthlyInvestment, "Monthly Investment") &&
                IsDecimal(txtMonthlyInvestment, "Monthly Investment") &&
                IsWithinRange(txtMonthlyInvestment, "Monthly Investment", 1, 1000) &&

                // Validate the Yearly Interest Rate text box
                IsPresent(txtInterestRate, "Yearly Interest Rate") &&
                IsDecimal(txtInterestRate, "Yearly Interest Rate") &&
                IsWithinRange(txtInterestRate, "Yearly Interest Rate", 1, 20);

        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsInt32(TextBox textBox, string name)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be an integer.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            string s = textBox.Text;
            decimal number = Convert.ToDecimal(s);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment,
            decimal interestRateMonthly, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + interestRateMonthly);
            }
            return futureValue;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmFutureValue_Load(object sender, EventArgs e)
        {
            string[] numbers = {"1", "2", "3", "4", "5", "6", "7", "8", "9", 
				"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"};
            foreach (string number in numbers)
            {
                cboNumberOfYears.Items.Add(number);
            }
            cboNumberOfYears.SelectedIndex = 2;
        }

        

    }
}
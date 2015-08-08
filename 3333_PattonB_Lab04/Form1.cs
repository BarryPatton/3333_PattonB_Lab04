/*
 * Barry Patton
 * 000543539
 * 3-1-2015
 * 3-2-2015
 * The purpose of this program is to demonstrate the use of the appropriate selection structure and to prevent data
 * conversion exceptions using the TryParse method as well as input validation using if statements. The program will display 
 * amount of the discount formatted as currency, the total amount of the purchase after the discount formatted as currency, 
 * the discount percent formatted as a percent, and the total amount before the discount formatted as currency.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_PattonB_Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            const decimal RETAIL_PACKAGE = 99m; // cost per package
            int quanity; // the number of packages
            decimal total, percentage;

            if (int.TryParse(textBoxNumberOfPackages.Text, out quanity))
            {
                if (quanity > 0)
                {
                    // select if quanity is between 10-19, gets 20% discount
                    if (quanity >= 10 && quanity <= 19)
                    {
                        percentage = 0.20m; // set to 20%
                        // perform calculations
                        total = quanity * RETAIL_PACKAGE;
                        labelTotalBeforeDiscount.Text = total.ToString("c"); // display total before discount
                        labelDiscountPercentage.Text = percentage.ToString("p"); // display discount percentage
                        decimal savingsFromDiscount = total * percentage;
                        labelSavingsFromDiscount.Text = savingsFromDiscount.ToString("c"); // display savimgs from discount
                        decimal totalAfterDiscount = total - savingsFromDiscount;
                        labelTotalAfterDiscount.Text = totalAfterDiscount.ToString("c");
                    }
                    // select if quanity is between 20-49, gets 30% discount
                    else if (quanity >= 20 && quanity <= 49)
                    {
                        percentage = 0.30m; // set to 30%
                        // perform calculations
                        total = quanity * RETAIL_PACKAGE;
                        labelTotalBeforeDiscount.Text = total.ToString("c"); // display total before discount
                        labelDiscountPercentage.Text = percentage.ToString("p"); // display discount percentage
                        decimal savingsFromDiscount = total * percentage;
                        labelSavingsFromDiscount.Text = savingsFromDiscount.ToString("c"); // display savimgs from discount
                        decimal totalAfterDiscount = total - savingsFromDiscount;
                        labelTotalAfterDiscount.Text = totalAfterDiscount.ToString("c");
                    }
                    // select if quanity is between 50-99, gets 40% discount
                    else if (quanity >= 50 && quanity <= 99)
                    {
                        percentage = 0.40m; // set to 40%
                        // perform calculations
                        total = quanity * RETAIL_PACKAGE;
                        labelTotalBeforeDiscount.Text = total.ToString("c"); // display total before discount
                        labelDiscountPercentage.Text = percentage.ToString("p"); // display discount percentage
                        decimal savingsFromDiscount = total * percentage;
                        labelSavingsFromDiscount.Text = savingsFromDiscount.ToString("c"); // display savimgs from discount
                        decimal totalAfterDiscount = total - savingsFromDiscount;
                        labelTotalAfterDiscount.Text = totalAfterDiscount.ToString("c");
                    }
                    // select if quanity is between 100-or more, gets 50% discount
                    else if (quanity >= 100)
                    {
                        percentage = 0.50m; // set to 50%
                        // perform calculations
                        total = quanity * RETAIL_PACKAGE;
                        labelTotalBeforeDiscount.Text = total.ToString("c"); // display total before discount
                        labelDiscountPercentage.Text = percentage.ToString("p"); // display discount percentage
                        decimal savingsFromDiscount = total * percentage;
                        labelSavingsFromDiscount.Text = savingsFromDiscount.ToString("c"); // display savimgs from discount
                        decimal totalAfterDiscount = total - savingsFromDiscount;
                        labelTotalAfterDiscount.Text = totalAfterDiscount.ToString("c");
                    }
                }
                else
                {
                    // number must be greater than zero
                    MessageBox.Show("Integer must be greater than zero.");
                    textBoxNumberOfPackages.Focus();
                    textBoxNumberOfPackages.Clear();
                }
            }
            else
            {
                MessageBox.Show("Enter a valid integer.");
                textBoxNumberOfPackages.Focus();
                textBoxNumberOfPackages.Clear();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumberOfPackages.Clear();
            labelTotalBeforeDiscount.Text = "";
            labelDiscountPercentage.Text = "";
            labelSavingsFromDiscount.Text = "";
            labelTotalAfterDiscount.Text = "";

            // set focus back to textBoxNumberOfPackages
            textBoxNumberOfPackages.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

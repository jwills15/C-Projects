using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Joshua Williams
 * Period: 0
 * Date: 1/8/15
 * Project Description: This project takes a number inputted by
 * the user and adds up and multiplies all the numbers before it
 * and adds up all the even and odd numbers before it and performs
 * the fibonnaci sequence to that number of terms. */

namespace N__Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int startingNumber = 0;
            int totalSum = 0;
            int totalProduct = 1;
            string adding = "";
            string multiply = "";
            int evenSum = 0;
            string evens = "";
            int oddSum = 0;
            string odds = "";
            int fibonacciNum = 0;
            string fibonacciSequence = "";
            int fibFirstNum = 0;
            int fibSecondNum = 1;

            try
            {
                int howMany = int.Parse(txtHowMany.Text);

                for (int theCounter = 0; theCounter < howMany; theCounter++)
                {
                    startingNumber++;

                    //finding the sum of the numbers
                    totalSum += startingNumber;
                    adding += startingNumber + "\n";

                    //finding the product of the numbers
                    totalProduct = totalProduct * startingNumber;
                    multiply += startingNumber + "\n";

                    //finding the even numbers and finding their sum
                    if (startingNumber % 2 == 0)
                    {
                        evenSum += startingNumber;
                        evens += startingNumber + "\n";
                    }

                    //finding the odd numbers and finding their sum
                    else
                    {
                        oddSum += startingNumber;
                        odds += startingNumber + "\n";
                    }

                    //displaying the fibonacci sequence
                    if (theCounter <= 0)
                    {
                        fibonacciNum = theCounter + 1;
                    }
                    else
                    {
                        fibonacciNum = fibFirstNum + fibSecondNum;
                        fibFirstNum = fibSecondNum;
                        fibSecondNum = fibonacciNum;
                    }
                    fibonacciSequence += fibonacciNum + "\n";
                }
                lblSum.Text = adding + "\n" + "Sum: " + totalSum;
                lblProduct.Text = multiply + "\n" + "Product: " + totalProduct;
                lblEvens.Text = evens + "\n" + "Sum: " + evenSum;
                lblOdds.Text = odds + "\n" + "Sum: " + oddSum;
                lblFibonacci.Text = fibonacciSequence + "\n" + "Total: " + howMany;

                txtHowMany.Focus();
            }
            catch
            {
                MessageBox.Show("You need to enter data.", "Data Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

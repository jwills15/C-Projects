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
 * Date: 11/12/14
 * Project Description: This is a program for a tshirt selling company.
 * A user selects the type and amount of tshirts, and the program allows
 * multiple shirts to be sold and then put together into one order. The
 * program also keeps track of total customers, total sales, total number
 * of shirts sold, and average sales. */

namespace tshirtProgram
{
    public partial class Form1 : Form
    {

        const decimal SMALL_PRICE = 10m;
        const decimal MEDIUM_PRICE = 10m;
        const decimal LARGE_PRICE = 10m;
        const decimal XLARGE_PRICE = 11m;
        const decimal XXL_PRICE = 12m;
        const decimal MONOGRAM = 2m;
        const decimal POCKET = 1m;

        private decimal totalSales = 0;
        private int totalCustomers = 0;
        private decimal orderTotal = 0;
        private decimal averageSale = 0;
        private decimal totalShirts;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            //declare variables
            decimal itemPrice = 0;
            decimal extendedPrice = 0;
            int quantity = 0;

            //extract info from user
            try
            {
                quantity = Int16.Parse(txtQuantity.Text);
                
                if (txtCustomerName.Text == "")
                {
                    MessageBox.Show("You need to enter data.", "Data Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCustomerName.Focus();
                }
                else if (txtOrderNumber.Text == "")
                {
                    MessageBox.Show("You need to enter data.", "Data Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOrderNumber.Focus();
                }
                else if (quantity <= 0)
                {
                    MessageBox.Show("You need to enter data.", "Data Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Focus();
                }

                else
                {
                    if (radSmall.Checked)
                    {
                        itemPrice = SMALL_PRICE;
                    }
                    else if (radMedium.Checked)
                    {
                        itemPrice = MEDIUM_PRICE;
                    }
                    else if (radLarge.Checked)
                    {
                        itemPrice = LARGE_PRICE;
                    }
                    else if (radXLarge.Checked)
                    {
                        itemPrice = XLARGE_PRICE;
                    }
                    else if (radXXL.Checked)
                    {
                        itemPrice = XXL_PRICE;
                    }
                    if (chkMonogram.Checked)
                    {
                        itemPrice += MONOGRAM;
                    }
                    if (chkPocket.Checked)
                    {
                        itemPrice += POCKET;
                    }

                    //math calculations
                    extendedPrice = itemPrice * quantity;
                    totalShirts += quantity;
                    orderTotal += extendedPrice;

                    //output answers
                    lblExtendedPrice.Text = extendedPrice.ToString("C");
                    lblOrderTotal.Text = orderTotal.ToString("C");
                    lblItemPrice.Text = itemPrice.ToString("C");

                    //disable user changing name or order number
                    txtCustomerName.Enabled = false;
                    txtOrderNumber.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("You need to enter data.", "Data Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult resultAnswer = DialogResult;


            resultAnswer = MessageBox.Show("Are you sure you're finished?",
                "Complete Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultAnswer == DialogResult.Yes)
            {
                totalSales += orderTotal;
                totalCustomers++;
                averageSale = totalSales / totalCustomers;
                MessageBox.Show("Your order was completed." + "\n" + "\n" + "Customer Name: " +
                    txtCustomerName.Text + "\n" + "Order number: " + txtOrderNumber.Text + 
                    "\n" + "Your final order was: " + orderTotal.ToString("C"), "Thank You!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSummary.Enabled = true;
                btnClearItem_Click(sender, e);
                lblOrderTotal.Text = "";
                orderTotal = 0;
                txtOrderNumber.Text = "";
                txtCustomerName.Text = "";
                txtCustomerName.Enabled = true;
                txtOrderNumber.Enabled = true;
                txtCustomerName.Focus();
            }
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            txtQuantity.Clear();
            chkMonogram.Checked = false;
            chkPocket.Checked = false;
            radSmall.Checked = true;
            txtQuantity.Focus();
            lblExtendedPrice.Text = "";
            lblItemPrice.Text = "";
            txtQuantity.Focus();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Store Total Sales: " + totalSales.ToString("C") + "\n" + 
                "Total Customers: " + totalCustomers + "\n" + "Total Shirts Sold: "
                + totalShirts + "\n" + "Average Sale: " + averageSale.ToString("C") + "\n", "Store Stats", 
                MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radMedium_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radXLarge_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radXXL_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkMonogram_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

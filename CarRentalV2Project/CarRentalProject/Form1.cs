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
 * Date: 10/2/14
 * Project Description: This is a car rental program. It takes customer
 * information and formats it for a receipt. It gives the customer three
 * options for renting cars with optional upgrades. It calculates how many 
 * miles a customer drove and finds how much they owe for renting the car.
 * It also keeps track of all previous sales. */

namespace CarRentalProject
{
    public partial class Form1 : Form
    {
        //Declare global variables that keep track of info over time
        private decimal totalCarsReturned;
        private decimal totalAmountReceived;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Displays customer information
            lblCustomer.Text = txtFN.Text + " " + txtLN.Text +
                "\n" + txtStreet.Text + "\n" + txtCity.Text +
                ", " + txtState.Text + " " + txtZip.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clears all user inputs and calculations
            lblCustomer.Text = "";
            txtFN.Text = "";
            txtLN.Text = "";
            txtCity.Text = "";
            txtStreet.Text = "";
            txtState.Text = "";
            txtZip.Text = "";
            txtBegin.Text = "";
            txtEnd.Text = "";
            txtDays.Text = "";
            lblMiles.Text = "";
            lblCharge.Text = "";
            radCarOne.Checked = false;
            radCarTwo.Checked = false;
            radCarThree.Checked = false;
            chkSeats.Checked = false;
            chkSound.Checked = false;
            picBlank.Image = picReset.Image;
            txtFN.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declares variable for info storage
            decimal beginDecimal;
            decimal endDecimal;
            decimal daysDecimal;
            decimal milesDrivenDecimal = 0;
            decimal totalChargeDecimal;
            decimal averageAmountDecimal;
            decimal milesChargeDecimal = 0;
            decimal daysChargeDecimal = 0;
            

            //prevents errors
            try
            {
                //extracting info from user
                beginDecimal = Decimal.Parse(txtBegin.Text);
                endDecimal = Decimal.Parse(txtEnd.Text);
                daysDecimal = Decimal.Parse(txtDays.Text);
                if (radCarOne.Checked)
                {
                    //sets prices for renting car one
                    daysChargeDecimal = 15;
                    milesChargeDecimal = (Decimal)0.12;
                }
                else if (radCarTwo.Checked)
                {
                    //sets prices for renting car two
                    daysChargeDecimal = 20;
                    milesChargeDecimal = (Decimal)0.15;
                }
                else if (radCarThree.Checked)
                {
                    //sets prices for renting car three
                    daysChargeDecimal = 25;
                    milesChargeDecimal = (Decimal)0.20;
                }
                if (chkSeats.Checked)
                {
                    //increases price for having leather seats
                    daysChargeDecimal += 3;
                }
                if (chkSound.Checked)
                {
                    //increases price for having bose sound
                    daysChargeDecimal += 2;
                }
                
                //math calculations
                milesDrivenDecimal = endDecimal - beginDecimal;
                if (milesDrivenDecimal <= 100)
                {
                    //only customers who drive over 100 miles are charged for miles driven
                    milesChargeDecimal = 0;
                }
                totalChargeDecimal = daysChargeDecimal * daysDecimal + 
                    milesChargeDecimal * milesDrivenDecimal;

                totalCarsReturned += 1;
                totalAmountReceived += totalChargeDecimal;
                averageAmountDecimal = totalAmountReceived / totalCarsReturned;

                //output answers
                lblMiles.Text = milesDrivenDecimal.ToString();
                lblCharge.Text = totalChargeDecimal.ToString("C");

                lblTotalCarsReturned.Text = totalCarsReturned.ToString();
                lblTotalAmountReceived.Text = totalAmountReceived.ToString("C");
                lblAverageAmountSpent.Text = averageAmountDecimal.ToString("C");
            }
            catch
            {
                MessageBox.Show("You need to enter data", "Data Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radCarOne_CheckedChanged(object sender, EventArgs e)
        {
            //shows car one when selected
            picBlank.Image = picCar1.Image;
        }

        private void radCarTwo_CheckedChanged(object sender, EventArgs e)
        {
            //shows car two when selected
            picBlank.Image = picCar2.Image;
        }

        private void radCarThree_CheckedChanged(object sender, EventArgs e)
        {
            //shows car three when selected
            picBlank.Image = picCar3.Image;
        }
    }
}

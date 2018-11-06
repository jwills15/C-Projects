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
 * information and formats it for a receipt. It calculates how many miles
 * a customer drove and finds how much they owe for renting the car. It
 * also keeps track of all previous sales. */

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
            //Clears all text boxes and calculations
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
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declares variable for info storage
            decimal beginDecimal;
            decimal endDecimal;
            decimal daysDecimal;
            decimal milesDrivenDecimal;
            decimal totalChargeDecimal;
            decimal averageAmountDecimal;

            //extracting info from user's text boxes
            beginDecimal = Decimal.Parse(txtBegin.Text);
            endDecimal = Decimal.Parse(txtEnd.Text);
            daysDecimal = Decimal.Parse(txtDays.Text);

            //math calculations
            milesDrivenDecimal = endDecimal - beginDecimal;
            totalChargeDecimal = milesDrivenDecimal * (Decimal)0.12 +
                daysDecimal * 15;

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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

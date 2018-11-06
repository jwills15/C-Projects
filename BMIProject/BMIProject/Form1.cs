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
 * Date: 10/7/14
 * Period: 0
 * Project Description: This is a body mass index calculator.
 * It takes the height and weight of the user and converts it
 * into BMI. It also keeps track of the average BMI of all of
 * the people that use the program. */

namespace BMIProject
{
    public partial class Form1 : Form
    {
        //declare global variables that keep track of info over time
        private decimal TotalPeopleDecimal;
        private decimal TotalBMIDecimal;

        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //this clears the text boxes and labels
            txtHeightFt.Text = "";
            txtHeightIn.Text = "";
            txtWeight.Text = "";
            lblBMI.Text = "";
            txtHeightFt.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables for info storage
            decimal HeightFtDecimal;
            decimal HeightInDecimal;
            decimal WeightLbsDecimal;
            decimal UserBMIDecimal;
            decimal AverageBMIDecimal;
            decimal HeightMetersDecimal;
            decimal WeightKgDecimal;

            try
            {
                //get info from text boxes
                HeightFtDecimal = Decimal.Parse(txtHeightFt.Text);
                HeightInDecimal = Decimal.Parse(txtHeightIn.Text);
                WeightLbsDecimal = Decimal.Parse(txtWeight.Text);

                //doing the math calculations
                HeightMetersDecimal = (HeightFtDecimal * 12 + HeightInDecimal) * (Decimal)0.0254;
                WeightKgDecimal = WeightLbsDecimal * (Decimal)0.454;
                UserBMIDecimal = WeightKgDecimal / (HeightMetersDecimal * HeightMetersDecimal);
                TotalPeopleDecimal += 1;
                TotalBMIDecimal += UserBMIDecimal;
                AverageBMIDecimal = TotalBMIDecimal / TotalPeopleDecimal;

                //output answers to user
                lblBMI.Text = UserBMIDecimal.ToString("n2");
                lblTotalPeople.Text = TotalPeopleDecimal.ToString();
                lblAverageBMI.Text = AverageBMIDecimal.ToString("n2");
            }
            catch
            {
                MessageBox.Show("You need to enter data", "Data Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

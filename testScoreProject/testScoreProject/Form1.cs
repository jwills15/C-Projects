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
 * Date: 10/22/14
 * Project Description: This program takes two test
 * scores inputted by the user and determines what
 * grade the test got, the averages of the two test
 * scores, and which test score is higher. */

namespace testScoreProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            decimal testScore1;
            decimal testScore2;
            decimal testTotal1;
            decimal testTotal2;
            decimal grade1;
            decimal grade2;
            decimal average;

            try
            {
                //extracting data from text boxes
                testScore1 = Decimal.Parse(txtScore1.Text);
                testScore2 = Decimal.Parse(txtScore2.Text);
                testTotal1 = Decimal.Parse(txtTotal1.Text);
                testTotal2 = Decimal.Parse(txtTotal2.Text);

                //math calculations
                grade1 = testScore1 / testTotal1;
                grade2 = testScore2 / testTotal2;
                average = (grade1 + grade2) / 2;

                //output answers
                if (grade1 >= (Decimal).9)
                {
                    lblGrade1.Text = "A";
                }
                else if (grade1 >= (Decimal).8)
                {
                    lblGrade1.Text = "B";
                }
                else if (grade1 >= (Decimal).7)
                {
                    lblGrade1.Text = "C";
                }
                else if (grade1 >= (Decimal).6)
                {
                    lblGrade1.Text = "D";
                }
                else if (grade1 < (Decimal).6)
                {
                    lblGrade1.Text = "F";
                }
                if (grade2 >= (Decimal).9)
                {
                    lblGrade2.Text = "A";
                }
                else if (grade2 >= (Decimal).8)
                {
                    lblGrade2.Text = "B";
                }
                else if (grade2 >= (Decimal).7)
                {
                    lblGrade2.Text = "C";
                }
                else if (grade2 >= (Decimal).6)
                {
                    lblGrade2.Text = "D";
                }
                else if (grade2 < (Decimal).6)
                {
                    lblGrade2.Text = "F";
                }
                if (grade1 > grade2)
                {
                    lblHigher.Text = "The score of Test 1 is better.";
                }
                else if (grade1 < grade2)
                {
                    lblHigher.Text = "The score of Test 2 is better.";
                }
                else if (grade1 == grade2)
                {
                    lblHigher.Text = "The score of the two tests are equal.";
                }
                lblAverage.Text = average.ToString("p2");
            }
            catch
            {
                MessageBox.Show("You need to enter data", "Data Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //resets the program
            txtScore1.Text = "";
            txtScore2.Text = "";
            txtTotal1.Text = "";
            txtTotal2.Text = "";
            lblAverage.Text = "";
            lblGrade1.Text = "";
            lblGrade2.Text = "";
            lblHigher.Text = "";
            txtScore1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }
    }
}

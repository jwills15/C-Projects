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
 * Date: 12/5/14
 * Project Description: This is a slot machine program. The
 * user inputs money and plays the slots, and wins money. */

namespace slotMachineProject
{
    public partial class Form1 : Form
    {

        private decimal currentBalance = 0;
        private decimal jackpot = 1000;
        private decimal plays = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            decimal bet = 0;

            if (rad1.Checked == true)
            {
                bet = 1;
            }
            else if (rad2.Checked == true)
            {
                bet = 2;
            }
            else if (rad5.Checked == true)
            {
                bet = 5;
            }

            if (currentBalance >= bet)
            {
                System.Random spin = new System.Random((int)System.DateTime.Now.Ticks);
                int firstNum = spin.Next(1, 6);
                int secondNum = spin.Next(1, 6);
                int thirdNum = spin.Next(1, 6);


                picReel1.Image = reel(firstNum);
                picReel2.Image = reel(secondNum);
                picReel3.Image = reel(thirdNum);

                if (picReel1.Image == picReel2.Image & picReel2.Image == picReel3.Image)
                {
                    MessageBox.Show("You Win!");
                    currentBalance += jackpot;
                    jackpot = 1000;
                    plays = 0;
                    lblAmount.Text = currentBalance.ToString("C");
                    lblJackpot.Text = jackpot.ToString("C");
                    lblPlays.Text = plays.ToString();
                }
                else
                {
                    currentBalance -= bet;
                    jackpot += bet;
                    plays += 1;

                    lblAmount.Text = currentBalance.ToString("C");
                    lblJackpot.Text = jackpot.ToString("C");
                    lblPlays.Text = plays.ToString();
                }
            }
            else
            {
                MessageBox.Show("You need to enter more money!");
            }
        
        }

        public Image reel(decimal theNum)
        {

            Image thepic = null;
            if (theNum == 1)
            {
                thepic= picBar.Image;
            }
            else if (theNum == 2)
            {
                thepic = picBell.Image;
            }
            else if (theNum == 3)
            {
                thepic = picCherry.Image;
            }
            else if (theNum == 4)
            {
                thepic = picMelon.Image;
            }
            else if (theNum == 5)
            {
                thepic = PicNum7.Image;
            }
            return thepic;

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            try
            {
                decimal input = decimal.Parse(txtUserInput.Text);
                if (input > 0)
                {

                    currentBalance += input;
                    lblAmount.Text = currentBalance.ToString("C");

                }
                else
                {
                    MessageBox.Show("Input money!");
                    txtUserInput.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Input money!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

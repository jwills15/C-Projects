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
 * Date: 11/3/14
 * Project Description: This is a project that plays the casino game "craps." */

namespace crapsGameProject
{
    public partial class frmMain : Form
    {

        private decimal point;
        private decimal totalRolls;

        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            //generates a random number
            System.Random roll1 = new System.Random((int)System.DateTime.Now.Ticks);
            int dice1 = roll1.Next(1, 7);

            //outputs the result of first dice roll
            if (dice1 == 1)
            {
                picRollDice1.Image = picDice1.Image;
            }
            else if (dice1 == 2)
            {
                picRollDice1.Image = picDice2.Image;
            }
            else if (dice1 == 3)
            {
                picRollDice1.Image = picDice3.Image;
            }
            else if (dice1 == 4)
            {
                picRollDice1.Image = picDice4.Image;
            }
            else if (dice1 == 5)
            {
                picRollDice1.Image = picDice5.Image;
            }
            else if (dice1 == 6)
            {
                picRollDice1.Image = picDice6.Image;
            }

            //generates second random number
            int dice2 = roll1.Next(1, 7);

            //outputs the result of second dice roll
            if (dice2 == 1)
            {
                picRollDice2.Image = picDice1.Image;
            }
            else if (dice2 == 2)
            {
                picRollDice2.Image = picDice2.Image;
            }
            else if (dice2 == 3)
            {
                picRollDice2.Image = picDice3.Image;
            }
            else if (dice2 == 4)
            {
                picRollDice2.Image = picDice4.Image;
            }
            else if (dice2 == 5)
            {
                picRollDice2.Image = picDice5.Image;
            }
            else if (dice2 == 6)
            {
                picRollDice2.Image = picDice6.Image;
            }

            int score = dice1 + dice2;
            if (totalRolls == 0)
            {
                if (score == 7)
                {
                    MessageBox.Show("You rolled a 7 and won!", "You Win",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    picRollDice1.Image = null;
                    picRollDice2.Image = null;
                }
                else if (score == 11)
                {
                    MessageBox.Show("You rolled an 11 and won!", "You Win",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    picRollDice1.Image = null;
                    picRollDice2.Image = null;
                }
                else if (score == 2)
                {
                    MessageBox.Show("You rolled a 2 and lost!", "You Lose",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (score == 3)
                {
                    MessageBox.Show("You rolled a 3 and lost!", "You Lose",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    picRollDice1.Image = null;
                    picRollDice2.Image = null;
                }
                else if (score == 12)
                {
                    MessageBox.Show("You rolled a 12 and lost!", "You Lose",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    picRollDice1.Image = null;
                    picRollDice2.Image = null;
                }
                else
                {
                    totalRolls += 1;
                    point = score;
                    if (point == 4)
                    {
                        picPoint4.Image = picStar.Image;
                    }
                    else if (point == 5)
                    {
                        picPoint5.Image = picStar.Image;
                    }
                    else if (point == 6)
                    {
                        picPoint6.Image = picStar.Image;
                    }
                    else if (point == 8)
                    {
                        picPoint8.Image = picStar.Image;
                    }
                    else if (point == 9)
                    {
                        picPoint9.Image = picStar.Image;
                    }
                    else if (point == 10)
                    {
                        picPoint10.Image = picStar.Image;
                    }
                }
            }
            else if (totalRolls > 0)
            {
                if (score == point)
                {
                    MessageBox.Show("You rolled your point and won!", "You Win",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    totalRolls = 0;
                    picPoint4.Image = null;
                    picPoint5.Image = null;
                    picPoint6.Image = null;
                    picPoint8.Image = null;
                    picPoint9.Image = null;
                    picPoint10.Image = null;
                    picRollDice1.Image = null;
                    picRollDice2.Image = null;
                }
                else if (score == 7)
                {
                    MessageBox.Show("You rolled a 7 and lost!", "You Lose",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    totalRolls = 0;
                    picPoint4.Image = null;
                    picPoint5.Image = null;
                    picPoint6.Image = null;
                    picPoint8.Image = null;
                    picPoint9.Image = null;
                    picPoint10.Image = null;
                    picRollDice1.Image = null;
                    picRollDice2.Image = null;
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
 * Date: 10/17/14
 * Project Discription: This is a dice game. You click a button
 * to roll the two dice. The program makes the dice roll randomly,
 * and the result is displayed to the user. The program also keeps
 * track of how many of each number is rolled and the averages. */

namespace diceGameProject
{
    public partial class frmMain : Form
    {
        //declare global variables
        private decimal total2;
        private decimal total3;
        private decimal total4;
        private decimal total5;
        private decimal total6;
        private decimal total7;
        private decimal total8;
        private decimal total9;
        private decimal total10;
        private decimal total11;
        private decimal total12;
        private decimal totalRolls;
        private decimal average2;
        private decimal average3;
        private decimal average4;
        private decimal average5;
        private decimal average6;
        private decimal average7;
        private decimal average8;
        private decimal average9;
        private decimal average10;
        private decimal average11;
        private decimal average12;

        public frmMain()
        {
            InitializeComponent();
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
            
            //keep averages
            if (dice1 + dice2 == 2)
            {
                total2 += 1;
            }
            else if (dice1 + dice2 == 3)
            {
                total3 += 1;
            }
            else if (dice1 + dice2 == 4)
            {
                total4 += 1;
            }
            else if (dice1 + dice2 == 5)
            {
                total5 += 1;
            }
            else if (dice1 + dice2 == 6)
            {
                total6 += 1;
            }
            else if (dice1 + dice2 == 7)
            {
                total7 += 1;
            }
            else if (dice1 + dice2 == 8)
            {
                total8 += 1;
            }
            else if (dice1 + dice2 == 9)
            {
                total9 += 1;
            }
            else if (dice1 + dice2 == 10)
            {
                total10 += 1;
            }
            else if (dice1 + dice2 == 11)
            {
                total11 += 1;
            }
            else if (dice1 + dice2 == 12)
            {
                total12 += 1;
            }
            totalRolls += 1;
            
            //mathematical calculations
            int sum = dice1 + dice2;
            average2 = total2 / totalRolls;
            average3 = total3 / totalRolls;
            average4 = total4 / totalRolls;
            average5 = total5 / totalRolls;
            average6 = total6 / totalRolls;
            average7 = total7 / totalRolls;
            average8 = total8 / totalRolls;
            average9 = total9 / totalRolls;
            average10 = total10 / totalRolls;
            average11 = total11 / totalRolls;
            average12 = total12 / totalRolls;
            
            //output data into text boxes
            lblTotal2.Text = total2.ToString();
            lblTotal3.Text = total3.ToString();
            lblTotal4.Text = total4.ToString();
            lblTotal5.Text = total5.ToString();
            lblTotal6.Text = total6.ToString();
            lblTotal7.Text = total7.ToString();
            lblTotal8.Text = total8.ToString();
            lblTotal9.Text = total9.ToString();
            lblTotal10.Text = total10.ToString();
            lblTotal11.Text = total11.ToString();
            lblTotal12.Text = total12.ToString();
            lblAverage2.Text = average2.ToString("p2");
            lblAverage3.Text = average3.ToString("p2");
            lblAverage4.Text = average4.ToString("p2");
            lblAverage5.Text = average5.ToString("p2");
            lblAverage6.Text = average6.ToString("p2");
            lblAverage7.Text = average7.ToString("p2");
            lblAverage8.Text = average8.ToString("p2");
            lblAverage9.Text = average9.ToString("p2");
            lblAverage10.Text = average10.ToString("p2");
            lblAverage11.Text = average11.ToString("p2");
            lblAverage12.Text = average12.ToString("p2");
            lblTotalRolls.Text = totalRolls.ToString();
            lblSumofRoll.Text = sum.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //resets the game
            total2 = 0;
            total3 = 0;
            total4 = 0;
            total5 = 0;
            total6 = 0;
            total7 = 0;
            total8 = 0;
            total9 = 0;
            total10 = 0;
            total11 = 0;
            total12 = 0;
            totalRolls = 0;
            average2 = 0;
            average3 = 0;
            average4 = 0;
            average5 = 0;
            average6 = 0;
            average7 = 0;
            average8 = 0;
            average9 = 0;
            average10 = 0;
            average11 = 0;
            average12 = 0;
            picRollDice1.Image = picBlank.Image;
            picRollDice2.Image = picBlank.Image;
            lblTotal2.Text = total2.ToString();
            lblTotal3.Text = total3.ToString();
            lblTotal4.Text = total4.ToString();
            lblTotal5.Text = total5.ToString();
            lblTotal6.Text = total6.ToString();
            lblTotal7.Text = total7.ToString();
            lblTotal8.Text = total8.ToString();
            lblTotal9.Text = total9.ToString();
            lblTotal10.Text = total10.ToString();
            lblTotal11.Text = total11.ToString();
            lblTotal12.Text = total12.ToString();
            lblAverage2.Text = average2.ToString("p2");
            lblAverage3.Text = average3.ToString("p2");
            lblAverage4.Text = average4.ToString("p2");
            lblAverage5.Text = average5.ToString("p2");
            lblAverage6.Text = average6.ToString("p2");
            lblAverage7.Text = average7.ToString("p2");
            lblAverage8.Text = average8.ToString("p2");
            lblAverage9.Text = average9.ToString("p2");
            lblAverage10.Text = average10.ToString("p2");
            lblAverage11.Text = average11.ToString("p2");
            lblAverage12.Text = average12.ToString("p2");
            lblTotalRolls.Text = totalRolls.ToString();
            lblSumofRoll.Text = 0.ToString();
            btnRoll.Focus();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}

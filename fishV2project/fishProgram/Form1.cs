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
 * Date: 2/3/15
 * Project Description: This is the second version of the fish project.
 * It includes a fish that swims around the tank by going left, right, up, or down
 * one. The program has counters to count how many times the fish moves,
 * and also how many times it hits the left, right, top, or bottom side of the bowl. It
 * also contains a timer so the fish can move automatically, or a button
 * that the user can press to manually move the fish. The program also includes a shark
 * that moves the same way as the fish, and when they occupy the same space the shark
 * eats the fish and ends the program. */

namespace fishProgram
{
    public partial class frmMain : Form
    {

        PictureBox[,] theTank = new PictureBox[3, 8];
        int fishRow = 0;
        int fishCol = 0;
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        Boolean onOff = false;
        int move = 0;
        int left = 0;
        int right = 0;
        int top = 0;
        int bottom = 0;
        int total = 0;
        int sharkRow = 0;
        int sharkCol = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            theTank[0, 0] = picBox1;
            theTank[0, 1] = picBox2;
            theTank[0, 2] = picBox3;
            theTank[0, 3] = picBox4;
            theTank[0, 4] = picBox5;
            theTank[0, 5] = picBox6;
            theTank[0, 6] = picBox7;
            theTank[0, 7] = picBox8;
            theTank[1, 0] = picBox9;
            theTank[1, 1] = picBox10;
            theTank[1, 2] = picBox11;
            theTank[1, 3] = picBox12;
            theTank[1, 4] = picBox13;
            theTank[1, 5] = picBox14;
            theTank[1, 6] = picBox15;
            theTank[1, 7] = picBox16;
            theTank[2, 0] = picBox17;
            theTank[2, 1] = picBox18;
            theTank[2, 2] = picBox19;
            theTank[2, 3] = picBox20;
            theTank[2, 4] = picBox21;
            theTank[2, 5] = picBox22;
            theTank[2, 6] = picBox23;
            theTank[2, 7] = picBox24;
            int randomIntegerRow = r.Next(0, 3);
            int randomIntegerCol = r.Next(0, 8);
            theTank[randomIntegerRow, randomIntegerCol].Image = picManateeLeft.Image;
            theTank[randomIntegerRow, randomIntegerCol].Visible = true;
            fishRow = randomIntegerRow;
            fishCol = randomIntegerCol;
            int randomIntRow2 = r.Next(0, 3);
            int randomIntCol2 = r.Next(0, 3);
            theTank[randomIntRow2, randomIntCol2].Image = picSharkRight.Image;
            theTank[randomIntRow2, randomIntCol2].Visible = true;
            sharkRow = randomIntRow2;
            sharkCol = randomIntCol2;
            
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Boolean picLeft = false;

            if (theTank[fishRow, fishCol].Image == picManateeLeft.Image)
            {
                picLeft = true;
            }
            else
            {
                picLeft = false;
            }

            theTank[fishRow, fishCol].Image = null;
            theTank[fishRow, fishCol].Visible = false;
            theTank[sharkRow, sharkCol].Image = null;
            theTank[sharkRow, sharkCol].Visible = false;

            move = r.Next(0, 4);

            if (move == 0)
            {
                if (fishCol == 0)
                {
                    fishCol = 0;
                    picLeft = true;
                }
                else
                {
                    fishCol -= 1;
                    picLeft = true;
                }
            }
            else if (move == 1)
            {
                if (fishCol == 7)
                {
                    fishCol = 7;
                    picLeft = false;
                }
                else
                {
                    fishCol += 1;
                    picLeft = false;
                }
            }
            else if (move == 2)
            {
                if (fishRow == 0)
                {
                    fishRow = 0;
                }
                else
                {
                    fishRow -= 1;
                }
            }
            else if (move == 3)
            {
                if (fishRow == 2)
                {
                    fishRow = 2;
                }
                else
                {
                    fishRow += 1;
                }
            }

            if (picLeft == true)
            {
                theTank[fishRow, fishCol].Image = picManateeLeft.Image;
            }
            else
            {
                theTank[fishRow, fishCol].Image = picManateeRight.Image;
            }

            theTank[fishRow, fishCol].Visible = true;
            
            total += 1;
            lblTotal.Text = total.ToString();
            if (fishCol == 0)
            {
                left += 1;
            }
            else if (fishCol == 7)
            {
                right += 1;
            }
            if (fishRow == 0)
            {
                top += 1;
            }
            else if (fishRow == 2)
            {
                bottom += 1;
            }
            lblLeft.Text = left.ToString();
            lblRight.Text = right.ToString();
            lblTop.Text = top.ToString();
            lblBottom.Text = bottom.ToString();

            //move the shark
            Boolean sharkLeft = false;
            if (theTank[sharkRow, sharkCol].Image == picSharkLeft.Image)
            {
                sharkLeft = true;
            }
            else
            {
                sharkLeft = false;
            }

            sharkmove = r.Next(0, 4);

            if (sharkmove == 0)
            {
                if (sharkCol == 0)
                {
                    sharkCol = 0;
                    sharkLeft = true;
                }
                else
                {
                    sharkCol -= 1;
                    sharkLeft = true;
                }
            }
            else if (sharkmove == 1)
            {
                if (sharkCol == 7)
                {
                    sharkCol = 7;
                    sharkLeft = false;
                }
                else
                {
                    sharkCol += 1;
                    sharkLeft = false;
                }
            }
            else if (sharkmove == 2)
            {
                if (sharkRow == 0)
                {
                    sharkRow = 0;
                }
                else
                {
                    sharkRow -= 1;
                }
            }
            else if (sharkmove == 3)
            {
                if (sharkRow == 2)
                {
                    sharkRow = 2;
                }
                else
                {
                    sharkRow += 1;
                }
            }

            if (sharkLeft == true)
            {
                theTank[sharkRow, sharkCol].Image = picSharkLeft.Image;
            }
            else
            {
                theTank[sharkRow, sharkCol].Image = picSharkRight.Image;
            }

            theTank[sharkRow, sharkCol].Visible = true;

            if (fishCol == sharkCol && fishRow == sharkRow)
            {
                timer1.Enabled = false;
                MessageBox.Show("The shark ate the fish!", "Oh no!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                this.Close();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnMove_Click(sender, e);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (onOff == false)
            {
                timer1.Enabled = true;
                onOff = true;
            }
            else if (onOff == true)
            {
                timer1.Enabled = false;
                onOff = false;
            }
        }

        public int sharkmove { get; set; }
    }
}

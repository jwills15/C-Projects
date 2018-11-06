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
 * Date: 1/13/15
 * Project Description: This is the first version of the fish project.
 * It includes a fish that swims around the tank by going left or right
 * one. The program has counters to count how many times the fish moves,
 * and also how many times it hits the left or right side of the bowl. It
 * also contains a timer so the fish can move automatically, or a button
 * that the user can press to manually move the fish. */

namespace fishProgram
{
    public partial class frmMain : Form
    {

        PictureBox[] theTank = new PictureBox[8];
        int fishPosition = 0;
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        Boolean onOff = false;
        int move;
        int left;
        int right;
        int total;

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
            theTank[0] = picBox1;
            theTank[1] = picBox2;
            theTank[2] = picBox3;
            theTank[3] = picBox4;
            theTank[4] = picBox5;
            theTank[5] = picBox6;
            theTank[6] = picBox7;
            theTank[7] = picBox8;
            int randomInteger = r.Next(0, 8);
            theTank[randomInteger].Image = picManateeLeft.Image;
            theTank[randomInteger].Visible = true;
            fishPosition = randomInteger;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            theTank[fishPosition].Image = null;
            theTank[fishPosition].Visible = false;

            move = r.Next(0, 2);
            
            if (fishPosition == 0)
            {
                
                if (move == 0)
                {
                    fishPosition = 0;
                    theTank[fishPosition].Image = picManateeLeft.Image;
                }
                else if (move == 1)
                {
                    fishPosition += 1;
                    theTank[fishPosition].Image = picManateeRight.Image;
                }
            }
            else if (fishPosition == 7)
            {
                if (move == 0)
                {
                    fishPosition = 7;
                    theTank[fishPosition].Image = picManateeRight.Image;
                }
                else if (move == 1)
                {
                    fishPosition -= 1;
                    theTank[fishPosition].Image = picManateeLeft.Image;
                }
            }
            else
            {
                if (move == 0)
                {
                    fishPosition += 1;
                    theTank[fishPosition].Image = picManateeRight.Image;
                }
                else if (move == 1)
                {
                    fishPosition -= 1;
                    theTank[fishPosition].Image = picManateeLeft.Image;
                }
            }
            theTank[fishPosition].Visible = true;
            total += 1;
            lblTotal.Text = total.ToString();
            if (fishPosition == 0)
            {
                left += 1;
            }
            else if (fishPosition == 7)
            {
                right += 1;
            }
            lblLeft.Text = left.ToString();
            lblRight.Text = right.ToString();

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
    }
}

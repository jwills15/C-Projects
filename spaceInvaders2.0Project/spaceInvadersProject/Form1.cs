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
 * Date: 2/27/15
 * Project Description: This is the space invaders project. The user controls a
 * spaceship which fires bullets at aliens. The aliens move side to side and when
 * they hit a side they move down. Each alien has three lives and every time they
 * are hit they begin to move faster, but after three hits they die. If the aliens 
 * survive and pass the line at the bottom then the user loses. If the the user manages
 * to kill all the aliens then they move on to the next level, which makes the aliens
 * move faster. */

namespace spaceInvadersProject
{
    public partial class Form1 : Form
    {
        int alienSpeed = 2;
        int level = 1;

        PictureBox[] aliens = new PictureBox[3];
        Int32[] hit = new Int32[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnStart.Enabled == false)
            {
                int whichKey = e.KeyValue;
                int xcoord = picShip.Left;
                int ycoord = picShip.Right;

                if (whichKey == 37 && xcoord > 0)
                {
                    xcoord -= 15;
                }
                else if (whichKey == 39 && xcoord < this.Width - 84)
                {
                    xcoord += 15;
                }
                picShip.Left = xcoord;

                if (whichKey == 32)
                {
                    Tbullet.Enabled = true;
                }

                if (Tbullet.Enabled == false)
                {
                    lblBullet.Left = picShip.Left + 33;
                }
            }
        }

        private void Taliens_Tick(object sender, EventArgs e)
        {
            for (int n = 0; n < aliens.Length; n++)
            {
                int next = n + 1;
                if (next == 3)
                {
                    next = 0;
                }
                if (hit[n] >= 3)
                {
                    aliens[n].Height = 0;
                    aliens[n].Width = 0;
                    aliens[n].Left = aliens[next].Left;
                }

                int alienX = aliens[n].Left;
                
                if (alienX > this.Width - 80)
                {
                    if (hit[0] < 3)
                    {
                        alienX = alienX - alienSpeed;
                        aliens[0].Top += 40;
                        aliens[0].Left = alienX - alienSpeed;
                        aliens[1].Top += 40;
                        aliens[1].Left = alienX - 66;
                        aliens[2].Top += 40;
                        aliens[2].Left = alienX - 132;
                        alienSpeed *= -1;
                    }
                    else if (hit[1] < 3)
                    {
                        alienX = alienX - alienSpeed;
                        aliens[1].Top += 40;
                        aliens[1].Left = alienX;
                        aliens[2].Top += 40;
                        aliens[2].Left = alienX - 66;
                        alienSpeed *= -1;
                    }
                    else if (hit[2] < 3)
                    {
                        alienX = alienX - alienSpeed;
                        aliens[2].Top += 40;
                        aliens[2].Left = alienX;
                        alienSpeed *= -1;
                    }
                }
                else if (alienX <= 6)
                {
                    if (hit[2] < 3)
                    {
                        alienX = alienX - alienSpeed;
                        aliens[0].Top += 40;
                        aliens[0].Left = alienX + 132;
                        aliens[1].Top += 40;
                        aliens[1].Left = alienX + 66;
                        aliens[2].Top += 40;
                        aliens[2].Left = alienX;
                        alienSpeed *= -1;
                    }
                    else if (hit[1] < 3)
                    {
                        alienX = alienX - alienSpeed;
                        aliens[0].Top += 40;
                        aliens[0].Left = alienX + 66;
                        aliens[1].Top += 40;
                        aliens[1].Left = alienX;
                        alienSpeed *= -1;
                    }
                    else if (hit[0] < 3)
                    {
                        alienX = alienX - alienSpeed;
                        aliens[0].Top += 40;
                        aliens[0].Left = alienX;
                        alienSpeed *= -1;
                    }
                }
                else
                {
                    alienX += alienSpeed;
                    aliens[n].Left = alienX;
                }

                DialogResult resultAnswer = DialogResult;
                if (aliens[n].Bottom > 394 && hit[n] < 3)
                {
                    Taliens.Enabled = false;

                    resultAnswer = MessageBox.Show("You lost!" + "\n" + "\n" + "Play again?", "Oh No!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }
                if (resultAnswer == DialogResult.Yes)
                {
                    btnStart.Enabled = true;
                    btnStart.Visible = true;
                    lblControls.Visible = true;
                    lblName.Visible = true;
                    aliens[0].Visible = true;
                    aliens[0].Width = 60;
                    aliens[0].Height = 50;
                    aliens[0].Top = 12;
                    aliens[0].Left = 144;
                    aliens[1].Visible = true;
                    aliens[1].Width = 60;
                    aliens[1].Height = 50;
                    aliens[1].Top = 12;
                    aliens[1].Left = 78;
                    aliens[2].Visible = true;
                    aliens[2].Width = 60;
                    aliens[2].Height = 50;
                    aliens[2].Top = 12;
                    aliens[2].Left = 12;
                    picShip.Left = 232;
                    picShip.Top = 402;
                    lblBullet.Left = picShip.Left + 33;
                    lblBullet.Top = picShip.Top;
                    alienSpeed = 2;
                    hit[0] = 0;
                    hit[1] = 0;
                    hit[2] = 0;
                    level = 1;
                    lblLevel.Text = "Level 1";
                    lblLevel.Visible = true;
                }
                else if (resultAnswer == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void Tbullet_Tick(object sender, EventArgs e)
        {
            int bullety = lblBullet.Top;
            bullety -= 4;
            lblBullet.Top = bullety;
            if (lblBullet.Top < -15)
            {
                Tbullet.Enabled = false;
                lblBullet.Left = picShip.Left + 33;
                lblBullet.Top = picShip.Top;
            }

            for (int i = 0; i < aliens.Length; i++)
            {
                if (lblBullet.Left > aliens[i].Left && lblBullet.Right < aliens[i].Right
                    && lblBullet.Top < aliens[i].Bottom && lblBullet.Bottom > aliens[i].Top)
                {
                    aliens[i].Height -= 5;
                    aliens[i].Width -= 5;
                    Tbullet.Enabled = false;
                    lblBullet.Left = picShip.Left + 33;
                    lblBullet.Top = picShip.Top;
                    if (alienSpeed > 0)
                    {
                        alienSpeed += 1;
                    }
                    else if (alienSpeed < 0)
                    {
                        alienSpeed -= 1;
                    }
                    hit[i] += 1;
                }
            }
            
            if (hit[0] >= 3 && hit[1] >= 3 && hit[2] >= 3)
            {
                Taliens.Enabled = false;
                aliens[0].Visible = false;
                aliens[1].Visible = false;
                aliens[2].Visible = false;

                DialogResult resultAnswer = DialogResult;
                resultAnswer = MessageBox.Show("You win!" + "\n" + "\n" + "Continue to next level?", "Winner!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultAnswer == DialogResult.Yes)
                {
                    btnStart.Enabled = true;
                    btnStart.Visible = true;
                    lblControls.Visible = true;
                    lblName.Visible = true;
                    aliens[0].Visible = true;
                    aliens[0].Width = 60;
                    aliens[0].Height = 50;
                    aliens[0].Top = 12;
                    aliens[0].Left = 144;
                    aliens[1].Visible = true;
                    aliens[1].Width = 60;
                    aliens[1].Height = 50;
                    aliens[1].Top = 12;
                    aliens[1].Left = 78;
                    aliens[2].Visible = true;
                    aliens[2].Width = 60;
                    aliens[2].Height = 50;
                    aliens[2].Top = 12;
                    aliens[2].Left = 12;
                    picShip.Left = 232;
                    picShip.Top = 402;
                    lblBullet.Left = picShip.Left + 33;
                    lblBullet.Top = picShip.Top;
                    level += 1;
                    alienSpeed = 2 + level;
                    hit[0] = 0;
                    hit[1] = 0;
                    hit[2] = 0;
                    lblLevel.Text = "Level " + level.ToString();
                    lblLevel.Visible = true;
                }
                else if (resultAnswer == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStart.Visible = false;
            Taliens.Enabled = true;
            lblName.Visible = false;
            lblControls.Visible = false;
            lblLevel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aliens[0] = picAlien1;
            aliens[1] = picAlien2;
            aliens[2] = picAlien3;
            hit[0] = 0;
            hit[1] = 0;
            hit[2] = 0;
        }
    }
}

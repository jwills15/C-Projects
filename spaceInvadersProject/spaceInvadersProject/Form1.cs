using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spaceInvadersProject
{
    public partial class Form1 : Form
    {
        int alienSpeed = 2;
        int alien1Hit = 0;
        int alien2Hit = 0;
        int alien3Hit = 0;
        int level = 1;

        

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
                    xcoord -= 10;
                }
                else if (whichKey == 39 && xcoord < this.Width - 84)
                {
                    xcoord += 10;
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
            int alien1x = picAlien1.Left;
            int alien1y = picAlien1.Top;
            int alien2x = picAlien2.Left;
            int alien2y = picAlien2.Top;
            int alien3x = picAlien3.Left;
            int alien3y = picAlien3.Top;

            if (alien1Hit < 3)
            {
                if (alien1x > this.Width - 80)
                {
                    alienSpeed *= -1;
                    alien1y += 40;
                    alien2y += 40;
                    alien3y += 40;
                }
                else if (alien1x < 12)
                {
                    alienSpeed *= -1;
                    alien1y += 40;
                    alien2y += 40;
                    alien3y += 40;
                }
            }
            else if (alien2Hit < 3)
            {
                if (alien2x > this.Width - 80)
                {
                    alienSpeed *= -1;
                    alien1y += 40;
                    alien2y += 40;
                    alien3y += 40;
                }
                else if (alien2x < 12)
                {
                    alienSpeed *= -1;
                    alien1y += 40;
                    alien2y += 40;
                    alien3y += 40;
                }
            }
            else if (alien3Hit < 3)
            {
                if (alien3x > this.Width - 80)
                {
                    alienSpeed *= -1;
                    alien1y += 40;
                    alien2y += 40;
                    alien3y += 40;
                }
                else if (alien3x < 12)
                {
                    alienSpeed *= -1;
                    alien1y += 40;
                    alien2y += 40;
                    alien3y += 40;
                }
            }
            alien1x += alienSpeed;
            alien2x += alienSpeed;
            alien3x += alienSpeed;

            picAlien1.Left = alien1x;
            picAlien2.Left = alien2x;
            picAlien3.Left = alien3x;
            picAlien1.Top = alien1y;
            picAlien2.Top = alien2y;
            picAlien3.Top = alien3y;
            

            if (alien1Hit > 3)
            {
                alien1Hit += 1;
                picAlien1.Height = 60;
                picAlien1.Width = 60;
            }
            if (alien1Hit == 20)
            {
                picAlien1.Visible = false;
                picAlien1.Top = -50;
                picAlien1.Left = 50;
            }
            if (alien2Hit > 3)
            {
                alien2Hit += 1;
                picAlien2.Height = 60;
                picAlien2.Width = 60;
            }
            if (alien2Hit == 20)
            {
                picAlien2.Visible = false;
                picAlien2.Top = -50;
                picAlien2.Left = 50;
            }
            if (alien3Hit > 3)
            {
                alien3Hit += 1;
                picAlien3.Height = 60;
                picAlien3.Width = 60;
            }
            if (alien3Hit == 20)
            {
                picAlien3.Visible = false;
                picAlien3.Top = -50;
                picAlien3.Left = 50;
            }

            DialogResult resultAnswer = DialogResult;
            if (picAlien1.Bottom > 394 && alien1Hit < 3)
            {
                Taliens.Enabled = false;
                Tstars.Enabled = false;
                resultAnswer = MessageBox.Show("You lost!" + "\n" + "\n" + "Play again?", "Oh No!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (picAlien2.Bottom > 394 && alien2Hit < 3)
            {
                Taliens.Enabled = false;
                Tstars.Enabled = false;
                resultAnswer = MessageBox.Show("You lost!" + "\n" + "\n" + "Play again?", "Oh No!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (picAlien3.Bottom > 394 && alien3Hit < 3)
            {
                Taliens.Enabled = false;
                Tstars.Enabled = false;
                resultAnswer = MessageBox.Show("You lost!" + "\n" + "\n" + "Play again?", "Oh No!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                btnStart.Enabled = true;
                btnStart.Visible = true;
                lblControls.Visible = true;
                lblName.Visible = true;
                picAlien1.Visible = true;
                picAlien1.Image = picAlien1pic.Image;
                picAlien1.Width = 60;
                picAlien1.Height = 50;
                picAlien1.Top = 124;
                picAlien1.Left = 12;
                picAlien2.Visible = true;
                picAlien2.Image = picAlien2pic.Image;
                picAlien2.Width = 60;
                picAlien2.Height = 50;
                picAlien2.Top = 68;
                picAlien2.Left = 12;
                picAlien3.Visible = true;
                picAlien3.Image = picAlien3pic.Image;
                picAlien3.Width = 60;
                picAlien3.Height = 50;
                picAlien3.Top = 12;
                picAlien3.Left = 12;
                picShip.Left = 232;
                picShip.Top = 402;
                lblBullet.Left = picShip.Left + 33;
                lblBullet.Top = picShip.Top;
                alienSpeed = 2;
                alien1Hit = 0;
                alien2Hit = 0;
                alien3Hit = 0;
                level = 1;
                lblLevel.Text = "Level 1";
                lblLevel.Visible = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        private void Tbullet_Tick(object sender, EventArgs e)
        {
            int bullety = lblBullet.Top;
            bullety -= 3;
            lblBullet.Top = bullety;
            if (lblBullet.Top < -15)
            {
                Tbullet.Enabled = false;
                lblBullet.Left = picShip.Left + 33;
                lblBullet.Top = picShip.Top;
            }

            if (lblBullet.Left > picAlien1.Left && lblBullet.Right < picAlien1.Right
                && lblBullet.Top < picAlien1.Bottom && lblBullet.Bottom > picAlien1.Top)
            {
                picAlien1.Height -= 5;
                picAlien1.Width -= 5;
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
                alien1Hit += 1;
            }
            else if (lblBullet.Left > picAlien2.Left && lblBullet.Right < picAlien2.Right
                && lblBullet.Top < picAlien2.Bottom && lblBullet.Bottom > picAlien2.Top)
            {
                picAlien2.Height -= 5;
                picAlien2.Width -= 5;
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
                alien2Hit += 1;
            }
            else if (lblBullet.Left > picAlien3.Left && lblBullet.Right < picAlien3.Right
                && lblBullet.Top < picAlien3.Bottom && lblBullet.Bottom > picAlien3.Top)
            {
                picAlien3.Height -= 5;
                picAlien3.Width -= 5;
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
                alien3Hit += 1;
            }
            if (alien1Hit == 3)
            {
                picAlien1.Image = picExplode.Image;
                alien1Hit += 1;
            }
            if (alien2Hit == 3)
            {
                picAlien2.Image = picExplode.Image;
                alien2Hit += 1;
            }
            if (alien3Hit == 3)
            {
                picAlien3.Image = picExplode.Image;
                alien3Hit += 1;
            }
            if (alien1Hit > 3 && alien2Hit > 3 && alien3Hit > 3)
            {
                Taliens.Enabled = false;
                Tstars.Enabled = false;
                DialogResult resultAnswer = DialogResult;
                resultAnswer = MessageBox.Show("You win!" + "\n" + "\n" + "Continue to next level?", "Winner!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultAnswer == DialogResult.Yes)
                {
                    btnStart.Enabled = true;
                    btnStart.Visible = true;
                    lblControls.Visible = true;
                    lblName.Visible = true;
                    picAlien1.Visible = true;
                    picAlien1.Image = picAlien1pic.Image;
                    picAlien1.Width = 60;
                    picAlien1.Height = 50;
                    picAlien1.Top = 124;
                    picAlien1.Left = 12;
                    picAlien2.Visible = true;
                    picAlien2.Image = picAlien2pic.Image;
                    picAlien2.Width = 60;
                    picAlien2.Height = 50;
                    picAlien2.Top = 68;
                    picAlien2.Left = 12;
                    picAlien3.Visible = true;
                    picAlien3.Image = picAlien3pic.Image;
                    picAlien3.Width = 60;
                    picAlien3.Height = 50;
                    picAlien3.Top = 12;
                    picAlien3.Left = 12;
                    picShip.Left = 232;
                    picShip.Top = 402;
                    lblBullet.Left = picShip.Left + 33;
                    lblBullet.Top = picShip.Top;
                    level += 1;
                    alienSpeed = 2 + level;
                    alien1Hit = 0;
                    alien2Hit = 0;
                    alien3Hit = 0;
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
            Tstars.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

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
 * Date: 3/17/15
 * Project Description: This is a tank project where the user controls a tank that
 * fires bullets. An enemy tank targets the user, and the user must navigate through
 * the barricades and shoot the enemy three times to advance to the next level. If
 * the enemy tank touches the user tank, the user loses. */

namespace tankProject
{
    public partial class tankProject : Form
    {
        //global variables

        //game variables
        int level = 1;
        Boolean start = false;

        //user tank variables
        int direction = 2;
        int explode = 0;

        //enemy tank variables
        int enemySpeed = 5;
        int enemyHit = 0;

        public tankProject()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (start == true)
            {
                //finding key that user presses
                int whichKey = e.KeyValue;

                if (whichKey == 37)
                {
                    //tank left
                    picTankUser.Width = 100;
                    picTankUser.Height = 50;
                    picTankUser.Image = picTank1Left.Image;

                    //barriers
                    if (picTankUser.Left < lblBarrier1.Right && picTankUser.Left > lblBarrier1.Left
                        && picTankUser.Top <= lblBarrier1.Bottom)
                    {
                        picTankUser.Left = picTankUser.Left;
                    }
                    else if (picTankUser.Left < lblBarrier2.Right && picTankUser.Left > lblBarrier2.Left
                        && picTankUser.Bottom >= lblBarrier2.Top)
                    {
                        picTankUser.Left = picTankUser.Left;
                    }
                    else if (picTankUser.Left > 0)
                    {
                        picTankUser.Left -= 20;
                    }

                    //explosion moving with tank
                    picExplode.Left = picTankUser.Left - 10;
                    picExplode.Top = picTankUser.Top + 15;

                    //bullet moving with tank
                    if (Tbullet.Enabled == false)
                    {
                        direction = 0;

                        picBullet.Image = picBulletLeft.Image;
                        picBullet.Left = picTankUser.Left;
                        picBullet.Top = picTankUser.Top + 20;
                        picBullet.Width = 30;
                        picBullet.Height = 5;
                    }
                }
                else if (whichKey == 38)
                {
                    //tank up
                    picTankUser.Width = 50;
                    picTankUser.Height = 100;
                    picTankUser.Image = picTank1Up.Image;

                    //barriers
                    if (picTankUser.Top > lblBarrier1.Top && picTankUser.Top < lblBarrier1.Bottom
                        && picTankUser.Left > lblBarrier1.Left && picTankUser.Left < lblBarrier1.Right)
                    {
                        picTankUser.Top = picTankUser.Top;
                    }
                    else if (picTankUser.Top > lblBarrier1.Top && picTankUser.Top < lblBarrier1.Bottom
                        && picTankUser.Right > lblBarrier1.Left && picTankUser.Right < lblBarrier1.Right)
                    {
                        picTankUser.Top = picTankUser.Top;
                    }
                    else if (picTankUser.Top > 0)
                    {
                        picTankUser.Top -= 20;
                    }

                    //explosion moving with tank
                    picExplode.Left = picTankUser.Left + 15;
                    picExplode.Top = picTankUser.Top - 10;

                    //bullet moving with tank
                    if (Tbullet.Enabled == false)
                    {
                        direction = 1;

                        picBullet.Image = picBulletUp.Image;
                        picBullet.Left = picTankUser.Left + 22;
                        picBullet.Top = picTankUser.Top;
                        picBullet.Width = 5;
                        picBullet.Height = 30;
                    }
                }
                else if (whichKey == 39)
                {
                    //tank right
                    picTankUser.Width = 100;
                    picTankUser.Height = 50;
                    picTankUser.Image = picTank1Right.Image;

                    //barriers
                    if (picTankUser.Right < lblBarrier1.Right && picTankUser.Right > lblBarrier1.Left
                        && picTankUser.Top <= lblBarrier1.Bottom)
                    {
                        picTankUser.Left = picTankUser.Left;
                    }
                    else if (picTankUser.Right < lblBarrier2.Right && picTankUser.Right > lblBarrier2.Left
                        && picTankUser.Bottom >= lblBarrier2.Top)
                    {
                        picTankUser.Left = picTankUser.Left;
                    }
                    else if (picTankUser.Right < this.Width + 40)
                    {
                        picTankUser.Left += 20;
                    }

                    //explosion moving with tank
                    picExplode.Left = picTankUser.Left + 90;
                    picExplode.Top = picTankUser.Top + 15;

                    //bullet moving with tank
                    if (Tbullet.Enabled == false)
                    {
                        direction = 2;

                        picBullet.Image = picBulletRight.Image;
                        picBullet.Left = picTankUser.Left + 70;
                        picBullet.Top = picTankUser.Top + 22;
                        picBullet.Width = 30;
                        picBullet.Height = 5;
                    }
                }
                else if (whichKey == 40)
                {
                    //tank down
                    picTankUser.Width = 50;
                    picTankUser.Height = 100;
                    picTankUser.Image = picTank1Down.Image;

                    //barriers
                    if (picTankUser.Bottom > lblBarrier2.Top && picTankUser.Bottom < lblBarrier2.Bottom
                        && picTankUser.Left > lblBarrier2.Left && picTankUser.Left < lblBarrier2.Right)
                    {
                        picTankUser.Top = picTankUser.Top;
                    }
                    else if (picTankUser.Bottom > lblBarrier2.Top && picTankUser.Bottom < lblBarrier2.Bottom
                        && picTankUser.Right > lblBarrier2.Left && picTankUser.Right < lblBarrier2.Right)
                    {
                        picTankUser.Top = picTankUser.Top;
                    }
                    else if (picTankUser.Bottom < this.Height + 40)
                    {
                        picTankUser.Top += 20;
                    }

                    //explosion moving with tank
                    picExplode.Left = picTankUser.Left + 15;
                    picExplode.Top = picTankUser.Top + 90;

                    //bullet moving with tank
                    if (Tbullet.Enabled == false)
                    {
                        direction = 3;

                        picBullet.Image = picBulletDown.Image;
                        picBullet.Left = picTankUser.Left + 22;
                        picBullet.Top = picTankUser.Top + 70;
                        picBullet.Width = 5;
                        picBullet.Height = 30;
                    }
                }
                if (whichKey == 32)
                {
                    //spacebar fires bullet
                    if (Tbullet.Enabled == false)
                    {
                        picExplode.Visible = true;
                        Tbullet.Enabled = true;
                    }
                }
            }
        }

        private void Tbullet_Tick(object sender, EventArgs e)
        {
            //explosion from bullet firing
            explode += 1;
            if (explode >= 20)
            {
                picExplode.Visible = false;
                explode = 0;
            }

            //variable to end the bullets path
            Boolean end = false;

            //moving bullet direction of tank
            if (direction == 0)
            {
                picBullet.Left -= 8;
                if (picBullet.Left < -60)
                {
                    end = true;
                }
            }
            else if (direction == 1)
            {
                picBullet.Top -= 8;
                if (picBullet.Top < -60)
                {
                    end = true;
                }
            }
            else if (direction == 2)
            {
                picBullet.Left += 8;
                if (picBullet.Left > this.Width)
                {
                    end = true;
                }
            }
            else if (direction == 3)
            {
                picBullet.Top += 8;
                if (picBullet.Top > this.Height)
                {
                    end = true;
                }
            }

            //bullet hitting enemy tank
            if (picBullet.Left >= picTankEnemy.Left && picBullet.Right <= picTankEnemy.Right
                && picBullet.Top <= picTankEnemy.Bottom && picBullet.Bottom >= picTankEnemy.Top)
            {
                enemyHit += 1;
                end = true;
                enemySpeed += 5;
            }

            //winning game with user third hit
            if (enemyHit == 3)
            {
                Tenemy.Enabled = false;
                picTankEnemy.Image = picExplode.Image;
                picFireHit1.Visible = false;
                picFireHit2.Visible = false;
                start = false;
                lblLevel.Visible = true;

                DialogResult resultAnswer = DialogResult;
                resultAnswer = MessageBox.Show("You win!" + "\n" + "\n" + "Continue to next level?", "Winner!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultAnswer == DialogResult.Yes)
                {
                    picTankUser.Image = picTank1Right.Image;
                    picTankUser.Height = 50;
                    picTankUser.Width = 100;
                    picTankUser.Left = 12;
                    picTankUser.Top = 12;
                    picBullet.Image = picBulletRight.Image;
                    picBullet.Left = picTankUser.Left + 70;
                    picBullet.Top = picTankUser.Top + 22;
                    picBullet.Width = 30;
                    picBullet.Height = 5;
                    picExplode.Left = picTankUser.Left + 90;
                    picExplode.Top = picTankUser.Top + 15;
                    enemyHit = 0;
                    enemySpeed = 5 + (level * 2);
                    level += 1;
                    lblLevel.Text = "Level " + level.ToString();
                    picTankEnemy.Height = 50;
                    picTankEnemy.Width = 100;
                    picTankEnemy.Image = picTank2Left.Image;
                    picTankEnemy.Left = 862;
                    picTankEnemy.Top = 572;
                    picFireHit1.Left = picTankEnemy.Left + 28;
                    picFireHit1.Top = picTankEnemy.Top;
                    picFireHit2.Left = picTankEnemy.Right - 20;
                    picFireHit2.Top = picTankEnemy.Bottom - 20;
                    btnStart.Enabled = true;
                    btnStart.Visible = true;
                }
                else if (resultAnswer == DialogResult.No)
                {
                    this.Close();
                }
            }
            
            //bullet hitting barrier
            if (picBullet.Left < lblBarrier1.Right && picBullet.Left > lblBarrier1.Left
                        && picBullet.Top <= lblBarrier1.Bottom)
            {
                end = true;
            }
            else if (picBullet.Left < lblBarrier2.Right && picBullet.Left > lblBarrier2.Left
                && picBullet.Bottom >= lblBarrier2.Top)
            {
                end = true;
            }
            else if (picBullet.Top > lblBarrier1.Top && picBullet.Top < lblBarrier1.Bottom
                        && picBullet.Left > lblBarrier1.Left && picBullet.Left < lblBarrier1.Right)
            {
                end = true;
            }
            else if (picBullet.Top > lblBarrier1.Top && picBullet.Top < lblBarrier1.Bottom
                && picBullet.Right > lblBarrier1.Left && picBullet.Right < lblBarrier1.Right)
            {
                end = true;
            }
            else if (picBullet.Right < lblBarrier1.Right && picBullet.Right > lblBarrier1.Left
                        && picBullet.Top <= lblBarrier1.Bottom)
            {
                end = true;
            }
            else if (picBullet.Right < lblBarrier2.Right && picBullet.Right > lblBarrier2.Left
                && picBullet.Bottom >= lblBarrier2.Top)
            {
                end = true;
            }
            if (picBullet.Bottom > lblBarrier2.Top && picBullet.Bottom < lblBarrier2.Bottom
                        && picBullet.Left > lblBarrier2.Left && picBullet.Left < lblBarrier2.Right)
            {
                end = true;
            }
            else if (picBullet.Bottom > lblBarrier2.Top && picBullet.Bottom < lblBarrier2.Bottom
                && picBullet.Right > lblBarrier2.Left && picBullet.Right < lblBarrier2.Right)
            {
                end = true;
            }

            //resetting bullet after it's path ends
            if (end == true)
            {
                picExplode.Visible = false;
                explode = 0;

                Tbullet.Enabled = false;
                if (picTankUser.Image == picTank1Down.Image)
                {
                    direction = 3;

                    picBullet.Image = picBulletDown.Image;
                    picBullet.Left = picTankUser.Left + 22;
                    picBullet.Top = picTankUser.Top + 70;
                    picBullet.Width = 5;
                    picBullet.Height = 30;
                }
                else if (picTankUser.Image == picTank1Up.Image)
                {
                    direction = 1;

                    picBullet.Image = picBulletUp.Image;
                    picBullet.Left = picTankUser.Left + 22;
                    picBullet.Top = picTankUser.Top;
                    picBullet.Width = 5;
                    picBullet.Height = 30;
                }
                else if (picTankUser.Image == picTank1Left.Image)
                {
                    direction = 0;

                    picBullet.Image = picBulletLeft.Image;
                    picBullet.Left = picTankUser.Left;
                    picBullet.Top = picTankUser.Top + 22;
                    picBullet.Width = 30;
                    picBullet.Height = 5;
                }
                else if (picTankUser.Image == picTank1Right.Image)
                {
                    direction = 2;

                    picBullet.Image = picBulletRight.Image;
                    picBullet.Left = picTankUser.Left + 70;
                    picBullet.Top = picTankUser.Top + 22;
                    picBullet.Width = 30;
                    picBullet.Height = 5;
                }
            }
        }

        private void Tenemy_Tick(object sender, EventArgs e)
        {
            //finding locations of both tanks
            int Xenemy = picTankEnemy.Left;
            int Yenemy = picTankEnemy.Top;
            int Xuser = picTankUser.Left;
            int Yuser = picTankUser.Top;

            //moving enemy down
            if (Yenemy < Yuser)
            {
                if (picTankEnemy.Bottom > lblBarrier2.Top && picTankEnemy.Bottom < lblBarrier2.Bottom
                        && picTankEnemy.Left > lblBarrier2.Left && picTankEnemy.Left < lblBarrier2.Right)
                {
                    picTankEnemy.Top = picTankEnemy.Top;
                }
                else if (picTankEnemy.Bottom > lblBarrier2.Top && picTankEnemy.Bottom < lblBarrier2.Bottom
                    && picTankEnemy.Right > lblBarrier2.Left && picTankEnemy.Right < lblBarrier2.Right)
                {
                    picTankEnemy.Top = picTankEnemy.Top;
                }
                else
                {
                    picTankEnemy.Top += enemySpeed;
                    picTankEnemy.Image = picTank2Down.Image;
                    picTankEnemy.Width = 50;
                    picTankEnemy.Height = 100;
                }
            }
            //moving enemy up
            else if (Yenemy > Yuser)
            {
                if (picTankEnemy.Top > lblBarrier1.Top && picTankEnemy.Top < lblBarrier1.Bottom
                        && picTankEnemy.Left > lblBarrier1.Left && picTankEnemy.Left < lblBarrier1.Right)
                {
                    picTankUser.Top = picTankUser.Top;
                }
                else if (picTankEnemy.Top > lblBarrier1.Top && picTankEnemy.Top < lblBarrier1.Bottom
                    && picTankEnemy.Right > lblBarrier1.Left && picTankEnemy.Right < lblBarrier1.Right)
                {
                    picTankEnemy.Top = picTankEnemy.Top;
                }
                else
                {
                    picTankEnemy.Top -= enemySpeed;
                    picTankEnemy.Image = picTank2Up.Image;
                    picTankEnemy.Width = 50;
                    picTankEnemy.Height = 100;
                }
            }
            //moving enemy right
            if (Xenemy < Xuser)
            {
                if (picTankEnemy.Right < lblBarrier1.Right && picTankEnemy.Right > lblBarrier1.Left
                        && picTankEnemy.Top <= lblBarrier1.Bottom)
                {
                    picTankEnemy.Left = picTankEnemy.Left;
                }
                else if (picTankEnemy.Right < lblBarrier2.Right && picTankEnemy.Right > lblBarrier2.Left
                    && picTankEnemy.Bottom >= lblBarrier2.Top)
                {
                    picTankEnemy.Left = picTankEnemy.Left;
                }
                else
                {
                    picTankEnemy.Left += enemySpeed;
                    picTankEnemy.Image = picTank2Right.Image;
                    picTankEnemy.Width = 100;
                    picTankEnemy.Height = 50;
                }
            }
            //moving enemy left
            else if (Xenemy > Xuser)
            {
                if (picTankEnemy.Left < lblBarrier1.Right && picTankEnemy.Left > lblBarrier1.Left
                        && picTankEnemy.Top <= lblBarrier1.Bottom)
                {
                    picTankEnemy.Left = picTankEnemy.Left;
                }
                else if (picTankEnemy.Left < lblBarrier2.Right && picTankEnemy.Left > lblBarrier2.Left
                    && picTankEnemy.Bottom >= lblBarrier2.Top)
                {
                    picTankEnemy.Left = picTankEnemy.Left;
                }
                else
                {
                    picTankEnemy.Left -= enemySpeed;
                    picTankEnemy.Image = picTank2Left.Image;
                    picTankEnemy.Width = 100;
                    picTankEnemy.Height = 50;
                }
            }

            //moving fires with tank
            if (picTankEnemy.Image == picTank2Left.Image)
            {
                picFireHit1.Left = picTankEnemy.Left + 28;
                picFireHit1.Top = picTankEnemy.Top;
                picFireHit2.Left = picTankEnemy.Right - 20;
                picFireHit2.Top = picTankEnemy.Bottom - 20;
            }
            else if (picTankEnemy.Image == picTank2Right.Image)
            {
                picFireHit1.Left = picTankEnemy.Left;
                picFireHit1.Top = picTankEnemy.Top;
                picFireHit2.Left = picTankEnemy.Left + 57;
                picFireHit2.Top = picTankEnemy.Bottom - 20;
            }
            else if (picTankEnemy.Image == picTank2Up.Image)
            {
                picFireHit1.Left = picTankEnemy.Left;
                picFireHit1.Top = picTankEnemy.Bottom - 20;
                picFireHit2.Left = picTankEnemy.Right - 20;
                picFireHit2.Top = picTankEnemy.Bottom - 75;
            }
            else if (picTankEnemy.Image == picTank2Down.Image)
            {
                picFireHit1.Left = picTankEnemy.Left;
                picFireHit1.Top = picTankEnemy.Top;
                picFireHit2.Left = picTankEnemy.Right - 20;
                picFireHit2.Top = picTankEnemy.Top + 57;
            }

            //activating first fire when hit
            if (enemyHit >= 1)
            {
                picFireHit1.Visible = true;
            }

            //activating second fire when hit again
            if (enemyHit >= 2)
            {
                picFireHit2.Visible = true;
            }

            //enemy hitting user to lose
            Boolean lose = false;

            if (picTankEnemy.Left <= picTankUser.Right && picTankEnemy.Left >= picTankUser.Left
                && picTankEnemy.Top >= picTankUser.Top && picTankEnemy.Top <= picTankUser.Bottom)
            {
                lose = true;
            }
            else if (picTankEnemy.Right <= picTankUser.Right && picTankEnemy.Right >= picTankUser.Left
                && picTankEnemy.Top >= picTankUser.Top && picTankEnemy.Top <= picTankUser.Bottom)
            {
                lose = true;
            }
            else if (picTankEnemy.Right <= picTankUser.Right && picTankEnemy.Right >= picTankUser.Left
                && picTankEnemy.Bottom >= picTankUser.Top && picTankEnemy.Bottom <= picTankUser.Bottom)
            {
                lose = true;
            }
            else if (picTankEnemy.Left <= picTankUser.Right && picTankEnemy.Left >= picTankUser.Left
                && picTankEnemy.Bottom >= picTankUser.Top && picTankEnemy.Bottom <= picTankUser.Bottom)
            {
                lose = true;
            }

            if (lose == true)
            {
                Tenemy.Enabled = false;
                start = false;
                lblLevel.Visible = true;

                DialogResult resultAnswer = DialogResult;
                resultAnswer = MessageBox.Show("You lose!" + "\n" + "\n" + "Restart at first level?", "Loser!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultAnswer == DialogResult.Yes)
                {
                    picTankUser.Image = picTank1Right.Image;
                    picTankUser.Height = 50;
                    picTankUser.Width = 100;
                    picTankUser.Left = 12;
                    picTankUser.Top = 12;
                    picBullet.Image = picBulletRight.Image;
                    picBullet.Left = picTankUser.Left + 70;
                    picBullet.Top = picTankUser.Top + 22;
                    picBullet.Width = 30;
                    picBullet.Height = 5;
                    picExplode.Left = picTankUser.Left + 90;
                    picExplode.Top = picTankUser.Top + 15;
                    enemyHit = 0;
                    level = 1;
                    enemySpeed = 5;
                    lblLevel.Text = "Level " + level.ToString();
                    picTankEnemy.Height = 50;
                    picTankEnemy.Width = 100;
                    picTankEnemy.Image = picTank2Left.Image;
                    picTankEnemy.Left = 862;
                    picTankEnemy.Top = 572;
                    picFireHit1.Left = picTankEnemy.Left + 28;
                    picFireHit1.Top = picTankEnemy.Top;
                    picFireHit1.Visible = false;
                    picFireHit2.Left = picTankEnemy.Right - 20;
                    picFireHit2.Top = picTankEnemy.Bottom - 20;
                    picFireHit2.Visible = false;
                    btnStart.Enabled = true;
                    btnStart.Visible = true;
                }
                else if (resultAnswer == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //starting game when clicked
            btnStart.Enabled = false;
            btnStart.Visible = false;
            lblLevel.Visible = false;
            Tenemy.Enabled = true;
            start = true;
            lblName.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;

/* Name: Joshua Williams
 * Period: 0
 * Project Description: This is my final project, which is a rendition of the 
 * classic arcade game Galaga by Namco. */

namespace galagaFinalProject
{
    public partial class frmGame : Form
    {
        //arrays for aliens
        PictureBox[] alien1 = new PictureBox[20];
        PictureBox[] alien2 = new PictureBox[16];
        PictureBox[] alien3 = new PictureBox[4];
        //array for hitting 3rd alien multiple times
        Int32[] alien3hit = new Int32[4];
        //array for alien bullets
        Int32[] alienBulletDirection = new Int32[6];
        PictureBox[] alienBullet = new PictureBox[6];

        //int to run start position timer
        int startPosInt = 0;

        //picks random alien
        System.Random pickAlien = new System.Random((int)System.DateTime.Now.Ticks);

        //int to move alien 1
        int Talien1moveInt = 0;
        int Tmove1location = 0;
        int alien1move = 20;    
        int alien1initialX = 0;
        int alien1initialY = 0;

        //int to move alien 2
        int Talien2moveInt = 0;
        int Tmove2location = 0;
        int alien2move = 20;
        int alien2initialX = 0;
        int alien2initialY = 0;

        //int to move alien 3
        int Talien3moveInt = 0;
        int Tmove3location = 0;
        int alien3move = 5;
        int alien3initialX = 0;
        int alien3initialY = 0;

        //ints for bullet location
        int alienBullet1Direction = 0;
        int alienBullet2Direction = 0;
        int alienBullet3Direction = 0;
        int alienBullet4Direction = 0;
        int alienBullet5Direction = 0;
        int alienBullet6Direction = 0;

        //int to run idle movement timer
        int idleMovement = 0;

        //ability of user to move
        Boolean moveAbility = false;

        //keeps track of each alien types being hit
        int alien1hits = 0;
        int alien2hits = 0;
        int alien3hits = 0;

        //int to run ship explode timer
        int shipExplodeInt = 0;

        //ints to operate alien explode 1 timer
        int alienExplodeInt1 = 0;
        int alienExplodeWhichType1 = 0;
        int alienWhichExplode1 = 20;

        //ints to operate alien explode 2 timer
        int alienExplodeInt2 = 0;
        int alienExplodeWhichType2 = 0;
        int alienWhichExplode2 = 20;

        //ints to operate alien explode 3 timer
        int alienExplodeInt3 = 0;
        int alienExplodeWhichType3 = 0;
        int alienWhichExplode3 = 20;

        //ints to operate alien explode 4 timer
        int alienExplodeInt4 = 0;
        int alienExplodeWhichType4 = 0;
        int alienWhichExplode4 = 20;

        //int to run intro music timer
        int introMusicInt = 0;

        //int to keep track of score and alien score values
        int score = 0;
        int alien1score = 50;
        int alien2score = 80;
        int alien3score = 400;
        int bossScore = 4000;

        //int to get high score
        int highScore = 0;

        //int for speed of alien left/right and up/down
        int alienSpeedSide = 10;
        int alienSpeedDown = 15;

        //int to keep track of level and run level timer
        int level = 1;
        int nextLevelInt = 0;

        //int to run ship restart timer
        int shipRestartInt = 0;

        //int to keep track of multiplyer
        int multiplyer = 1;
        int consecutiveHits = 0;

        //int to keep track of hit ratio
        int totalHits = 0;
        int totalShots = 0;

        //int to run boss timer
        int bossInt = 0;

        //int to keep track of minion hits
        int bossMinion1hits = 0;
        int bossMinion2hits = 0;

        //int to run minion explode timers
        int minion1explodeInt = 0;
        int minion2explodeInt = 0;

        //ints for transfer to high score form
        public static int finalScore = 0;
        public static int finalTotalHits = 0;
        public static int finalTotalShots = 0;


        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            //uses custom galaga font
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Resources\emulogic.ttf");
            lblLives.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            lblStage.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            lblScore.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            lblScoreText.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            lblHighscore.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            lblHighScoreText.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
            //lblMultiplyer2.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            //lblMultiplyer3.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            //lblMultiplyer4.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            //lblMultiplyer5.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            //lblMultiplyer6.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblReady.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblLevel1.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblLevel2.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblLevel3.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblLevel4.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblBoss.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblGameOver.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblBossHealthLabel.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);

            //stops sounds from playing on launch
            alien1hitSound.Ctlcontrols.stop();
            alien2hitSound.Ctlcontrols.stop();
            alien3hit1sound.Ctlcontrols.stop();
            alien3hit2sound.Ctlcontrols.stop();
            shotSound.Ctlcontrols.stop();
            shipExplodeSound.Ctlcontrols.stop();
            alienFlyingSound.Ctlcontrols.stop();

            //sets objects for alien 1 arrays
            alien1[0] = picAlien1_1;
            alien1[1] = picAlien1_2;
            alien1[2] = picAlien1_3;
            alien1[3] = picAlien1_4;
            alien1[4] = picAlien1_5;
            alien1[5] = picAlien1_6;
            alien1[6] = picAlien1_7;
            alien1[7] = picAlien1_8;
            alien1[8] = picAlien1_9;
            alien1[9] = picAlien1_10;
            alien1[10] = picAlien1_11;
            alien1[11] = picAlien1_12;
            alien1[12] = picAlien1_13;
            alien1[13] = picAlien1_14;
            alien1[14] = picAlien1_15;
            alien1[15] = picAlien1_16;
            alien1[16] = picAlien1_17;
            alien1[17] = picAlien1_18;
            alien1[18] = picAlien1_19;
            alien1[19] = picAlien1_20;

            //sets objects for alien 2 array
            alien2[0] = picAlien2_1;
            alien2[1] = picAlien2_2;
            alien2[2] = picAlien2_3;
            alien2[3] = picAlien2_4;
            alien2[4] = picAlien2_5;
            alien2[5] = picAlien2_6;
            alien2[6] = picAlien2_7;
            alien2[7] = picAlien2_8;
            alien2[8] = picAlien2_9;
            alien2[9] = picAlien2_10;
            alien2[10] = picAlien2_11;
            alien2[11] = picAlien2_12;
            alien2[12] = picAlien2_13;
            alien2[13] = picAlien2_14;
            alien2[14] = picAlien2_15;
            alien2[15] = picAlien2_16;

            //sets objects for alien 3 array
            alien3[0] = picAlien3_1;
            alien3[1] = picAlien3_2;
            alien3[2] = picAlien3_3;
            alien3[3] = picAlien3_4;

            //sets objects for alien bullet arrays
            alienBullet[0] = picAlienBullet1;
            alienBullet[1] = picAlienBullet2;
            alienBullet[2] = picAlienBullet3;
            alienBullet[3] = picAlienBullet4;
            alienBullet[4] = picAlienBullet5;
            alienBullet[5] = picAlienBullet6;

            //sets image and position of alien 1s
            for (int n = 0; n < alien1.Length; n++)
            {
                alien1[n].Image = picAlien1v1down.Image;

                if (n < 10)
                {
                    alien1[n].Top = -65;
                }
                else
                {
                    alien1[n].Top = -30;
                }
            }
            //sets image and position of alien 2s
            for (int m = 0; m < alien2.Length; m++)
            {
                alien2[m].Image = picAlien2v1down.Image;

                if (m < 8)
                {
                    alien2[m].Top = -135;
                }
                else
                {
                    alien2[m].Top = -100;
                }
            }
            //sets image and position of alien 3s
            for (int p = 0; p < alien3.Length; p++)
            {
                alien3[p].Image = picAlien3v1down.Image;
                alien3hit[p] = 0;
                alien3[p].Top = -188;
            }

            //sets bullet to be behind ship
            picBullet1.Top = picShip.Top;
            picBullet2.Top = picShip.Top;

            //hides the alien bullets
            for (int n = 0; n < alienBullet.Length; n++)
            {
                alienBullet[n].Top = -30;
                alienBulletDirection[n] = 0;
            }

            //hides boss
            picBoss.Top = -360;

            //hides minions
            picMinion1.Top = -100;
            picMinion2.Top = -100;

            //gets high score and displays it
            string[] allLines = File.ReadAllLines(@"Resources\highScores.txt");
            highScore = int.Parse(allLines[2]);
            lblHighscore.Text = highScore.ToString();

        }

        private async void frmGame_KeyDown(object sender, KeyEventArgs e)
        {
            //checks if the ship should be able to move
            if (moveAbility == true)
            {
                //finds which key is pressed
                int whichKey = e.KeyValue;

                //moves the ship left
                if (whichKey == 37 && picShip.Left > 15)
                {
                    picShip.Left -= 24;
                }
                //moves the ship right
                else if (whichKey == 39 && picShip.Left < 580)
                {
                    picShip.Left += 24;
                }
                ////cheat code to skip through levels for testing
                //else if (whichKey == 84)
                //{
                //    if (level < 5)
                //    {
                //        alien1hits = 20;
                //        alien2hits = 16;
                //        alien3hits = 4;
                //        Talien1move.Enabled = false;
                //        Talien2move.Enabled = false;
                //        Talien3move.Enabled = false;
                //        level = 4;
                //    }
                //    else if (level == 5)
                //    {
                //        bossInt = 99;
                //    }
                //}
                ////add to score cheat for testing
                //else if (whichKey == 65)
                //{
                //    score += 5000;
                //    lblScore.Text = score.ToString();
                //    if (score > highScore)
                //    {
                //        lblHighscore.Text = score.ToString();
                //    }
                //}
                //fires the bullet
                if (TintroMusic.Enabled == false && TnextLevel.Enabled == false
                    && TshipRestart.Enabled == false)
                {
                    if (whichKey == 32)
                    {
                        //checks to see if bullet 1 is already fired
                        if (Tbullet1.Enabled == false)
                        {
                            Tbullet1.Enabled = true;
                            shotSound.Ctlcontrols.stop();
                            shotSound.Ctlcontrols.play();
                            //adds to number of bullets fired
                            totalShots += 1;
                        }
                        //checks to see if bullet 2 is already fired
                        else if (Tbullet2.Enabled == false)
                        {
                            //delays second bullet to prevent glitch
                            await Task.Delay(100);
                            Tbullet2.Enabled = true;
                            shotSound.Ctlcontrols.stop();
                            shotSound.Ctlcontrols.play();
                            //adds to number of bullets fired
                            totalShots += 1;
                        }
                    }
                }

                //checks to see if bullets are in use and puts them in correct position
                if (Tbullet1.Enabled == false)
                {
                    picBullet1.Left = picShip.Left + 18;
                    picBullet1.Top = picShip.Top;
                }
                if (Tbullet2.Enabled == false)
                {
                    picBullet2.Left = picShip.Left + 18;
                    picBullet2.Top = picShip.Top;
                }
            }
        }

        private void TidleMovement_Tick(object sender, EventArgs e)
        {
            if (consecutiveHits == 30)
            {
                multiplyer += 1;
                if (multiplyer == 2)
                {
                    PrivateFontCollection pfc = new PrivateFontCollection();
                    pfc.AddFontFile(@"Resources\emulogic.ttf");
                    lblMultiplyer2.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                    lblMultiplyer3.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                    lblMultiplyer4.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                    lblMultiplyer5.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                    lblMultiplyer6.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                    lblMultiplyer2.Visible = true;
                    lblMultiplyer3.Visible = false;
                    lblMultiplyer4.Visible = false;
                    lblMultiplyer5.Visible = false;
                    lblMultiplyer6.Visible = false;
                }
                else if (multiplyer == 3)
                {
                    lblMultiplyer2.Visible = false;
                    lblMultiplyer3.Visible = true;
                    lblMultiplyer4.Visible = false;
                    lblMultiplyer5.Visible = false;
                    lblMultiplyer6.Visible = false;
                }
                else if (multiplyer == 4)
                {
                    lblMultiplyer2.Visible = false;
                    lblMultiplyer3.Visible = false;
                    lblMultiplyer4.Visible = true;
                    lblMultiplyer5.Visible = false;
                    lblMultiplyer6.Visible = false;
                }
                else if (multiplyer == 5)
                {
                    lblMultiplyer2.Visible = false;
                    lblMultiplyer3.Visible = false;
                    lblMultiplyer4.Visible = false;
                    lblMultiplyer5.Visible = true;
                    lblMultiplyer6.Visible = false;
                }
                else if (multiplyer == 6)
                {
                    lblMultiplyer2.Visible = false;
                    lblMultiplyer3.Visible = false;
                    lblMultiplyer4.Visible = false;
                    lblMultiplyer5.Visible = false;
                    lblMultiplyer6.Visible = true;
                }
                consecutiveHits = 0;
            }

            //turns on next level timer and resets variables when aliens are destroyed
            if (alien1hits >= 20 && alien2hits >= 16 && alien3hits >= 4)
            {
                idleMovement = 0;
                System.Media.SoundPlayer stop = new System.Media.SoundPlayer();
                stop.Stop();
                level += 1;
                TnextLevel.Enabled = true;
                TidleMovement.Enabled = false;

                Talien1moveInt = 0;
                Tmove1location = 0;
                alien1move = 20;
                alien1initialX = 0;
                alien1initialY = 0;

                Talien2moveInt = 0;
                Tmove2location = 0;
                alien2move = 20;
                alien2initialX = 0;
                alien2initialY = 0;

                Talien3moveInt = 0;
                Tmove3location = 0;
                alien3move = 5;
                alien3initialX = 0;
                alien3initialY = 0;
            }

            //gets timer going
            idleMovement += 1;

            //8 images for full cycle (4 out, 4 back)
            if (idleMovement == 1)
            {
                //sends aliens out and V1 pics
                Out(sender, e);
                V1(sender, e);
                //plays ambience sound
                System.Media.SoundPlayer ambience = new System.Media.SoundPlayer(@"Resources\ambience.wav");
                ambience.Play();
            }
            else if (idleMovement == 2)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 3)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 4)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 5)
            {
                //sends aliens out and V2 pics
                Out(sender, e);
                V2(sender, e);
            }
            else if (idleMovement == 6)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 7)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 8)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 9)
            {
                //sends aliens out and V1 pics
                Out(sender, e);
                V1(sender, e);
            }
            else if (idleMovement == 10)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 11)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 12)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 13)
            {
                //sends aliens out and V2 pics
                Out(sender, e);
                V2(sender, e);
            }
            else if (idleMovement == 14)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 15)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 16)
            {
                //sends aliens out
                Out(sender, e);
            }
            else if (idleMovement == 17)
            {
                //sends aliens in and V1 pics
                In(sender, e);
                V1(sender, e);
            }
            else if (idleMovement == 18)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 19)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 20)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 21)
            {
                //sends aliens in and V2 pics
                In(sender, e);
                V2(sender, e);
            }
            else if (idleMovement == 22)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 23)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 24)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 25)
            {
                //sends aliens in and V1 pics
                In(sender, e);
                V1(sender, e);
            }
            else if (idleMovement == 26)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 27)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 28)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 29)
            {
                //sends aliens in and V2 pics
                In(sender, e);
                V2(sender, e);
            }
            else if (idleMovement == 30)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 31)
            {
                //sends aliens in
                In(sender, e);
            }
            else if (idleMovement == 32)
            {
                //sends aliens in
                In(sender, e);
                //resets timer
                idleMovement = 0;
            }
        }

        public void Out(object sender, EventArgs e)
        {
            //checks to see if the alien is being moved
            if (alien3move != 0)
            {
                //if not, moves the alien left or right
                alien3[0].Left -= 2;
            }
            //if so, moves the return coords for moving alien
            else
            {
                alien3initialX -= 2;
            }
            if (alien3move != 1)
            {
                alien3[1].Left -= 1;
            }
            else
            {
                alien3initialX -= 1;
            }
            if (alien3move != 2)
            {
                alien3[2].Left += 1;
            }
            else
            {
                alien3initialX += 1;
            }
            if (alien3move != 3)
            {
                alien3[3].Left += 2;
            }
            else
            {
                alien3initialX += 2;
            }

            if (alien2move != 0)
            {
                alien2[0].Left -= 4;
            }
            else
            {
                alien2initialX -= 4;
            }
            if (alien2move != 1)
            {
                alien2[1].Left -= 3;
            }
            else
            {
                alien2initialX -= 3;
            }
            if (alien2move != 2)
            {
                alien2[2].Left -= 2;
            }
            else
            {
                alien2initialX -= 2;
            }
            if (alien2move != 3)
            {
                alien2[3].Left -= 1;
            }
            else
            {
                alien2initialX -= 1;
            }
            if (alien2move != 4)
            {
                alien2[4].Left += 1;
            }
            else
            {
                alien2initialX += 1;
            }
            if (alien2move != 5)
            {
                alien2[5].Left += 2;
            }
            else
            {
                alien2initialX += 2;
            }
            if (alien2move != 6)
            {
                alien2[6].Left += 3;
            }
            else
            {
                alien2initialX += 3;
            }
            if (alien2move != 7)
            {
                alien2[7].Left += 4;
            }
            else
            {
                alien2initialX += 4;
            }
            if (alien2move != 8)
            {
                alien2[8].Left -= 4;
            }
            else
            {
                alien2initialX -= 4;
            }
            if (alien2move != 9)
            {
                alien2[9].Left -= 3;
            }
            else
            {
                alien2initialX -= 3;
            }
            if (alien2move != 10)
            {
                alien2[10].Left -= 2;
            }
            else
            {
                alien2initialX -= 2;
            }
            if (alien2move != 11)
            {
                alien2[11].Left -= 1;
            }
            else
            {
                alien2initialX -= 1;
            }
            if (alien2move != 12)
            {
                alien2[12].Left += 1;
            }
            else
            {
                alien2initialX += 1;
            }
            if (alien2move != 13)
            {
                alien2[13].Left += 2;
            }
            else
            {
                alien2initialX += 2;
            }
            if (alien2move != 14)
            {
                alien2[14].Left += 3;
            }
            else
            {
                alien2initialX += 3;
            }
            if (alien2move != 15)
            {
                alien2[15].Left += 4;
            }
            else
            {
                alien2initialX += 4;
            }

            //moves the aliens down
            for (int n = 0; n < alien2.Length; n++)
            {
                if (n < 8 && n != alien2move)
                {
                    alien2[n].Top += 1;
                }
                else if (n >= 8 && n != alien2move)
                {
                    alien2[n].Top += 2;
                }
                else if (n < 8)
                {
                    alien2initialY += 1;
                }
                else if (n >= 8)
                {
                    alien2initialY += 2;
                }
            }

            if (alien1move != 0)
            {
                alien1[0].Left -= 5;
            }
            else
            {
                alien1initialX -= 5;
            }
            if (alien1move != 1)
            {
                alien1[1].Left -= 4;
            }
            else
            {
                alien1initialX -= 4;
            }
            if (alien1move != 2)
            {
                alien1[2].Left -= 3;
            }
            else
            {
                alien1initialX -= 3;
            }
            if (alien1move != 3)
            {
                alien1[3].Left -= 2;
            }
            else
            {
                alien1initialX -= 2;
            }
            if (alien1move != 4)
            {
                alien1[4].Left -= 1;
            }
            else
            {
                alien1initialX -= 1;
            }
            if (alien1move != 5)
            {
                alien1[5].Left += 1;
            }
            else
            {
                alien1initialX += 1;
            }
            if (alien1move != 6)
            {
                alien1[6].Left += 2;
            }
            else
            {
                alien1initialX += 2;
            }
            if (alien1move != 7)
            {
                alien1[7].Left += 3;
            }
            else
            {
                alien1initialX += 3;
            }
            if (alien1move != 8)
            {
                alien1[8].Left += 4;
            }
            else
            {
                alien1initialX += 4;
            }
            if (alien1move != 9)
            {
                alien1[9].Left += 5;
            }
            else
            {
                alien1initialX += 5;
            }
            if (alien1move != 10)
            {
                alien1[10].Left -= 5;
            }
            else
            {
                alien1initialX -= 5;
            }
            if (alien1move != 11)
            {
                alien1[11].Left -= 4;
            }
            else
            {
                alien1initialX -= 4;
            }
            if (alien1move != 12)
            {
                alien1[12].Left -= 3;
            }
            else
            {
                alien1initialX -= 3;
            }
            if (alien1move != 13)
            {
                alien1[13].Left -= 2;
            }
            else
            {
                alien1initialX -= 2;
            }
            if (alien1move != 14)
            {
                alien1[14].Left -= 1;
            }
            else
            {
                alien1initialX -= 1;
            }
            if (alien1move != 15)
            {
                alien1[15].Left += 1;
            }
            else
            {
                alien1initialX += 1;
            }
            if (alien1move != 16)
            {
                alien1[16].Left += 2;
            }
            else
            {
                alien1initialX += 2;
            }
            if (alien1move != 17)
            {
                alien1[17].Left += 3;
            }
            else
            {
                alien1initialX += 3;
            }
            if (alien1move != 18)
            {
                alien1[18].Left += 4;
            }
            else
            {
                alien1initialX += 4;
            }
            if (alien1move != 19)
            {
                alien1[19].Left += 5;
            }
            else
            {
                alien1initialX += 5;
            }

            for (int n = 0; n < alien1.Length; n++)
            {
                if (n < 10 && n != alien1move)
                {
                    alien1[n].Top += 3;
                }
                else if (n >= 10 && n != alien1move)
                {
                    alien1[n].Top += 4;
                }
                else if (n < 10)
                {
                    alien1initialY += 3;
                }
                else if (n >= 10)
                {
                    alien1initialY += 4;
                }
            }
        }

        public void In(object sender, EventArgs e)
        {
            //checks to see if the alien is being moved
            if (alien3move != 0)
            {
                //if not, moves the alien
                alien3[0].Left += 2;
            }
            //if so, moves the aliens return coords
            else
            {
                alien3initialX += 2;
            }
            if (alien3move != 1)
            {
                alien3[1].Left += 1;
            }
            else
            {
                alien3initialX += 1;
            }
            if (alien3move != 2)
            {
                alien3[2].Left -= 1;
            }
            else
            {
                alien3initialX -= 1;
            }
            if (alien3move != 3)
            {
                alien3[3].Left -= 2;
            }
            else
            {
                alien3initialX -= 2;
            }

            if (alien2move != 0)
            {
                alien2[0].Left += 4;
            }
            else
            {
                alien2initialX += 4;
            }
            if (alien2move != 1)
            {
                alien2[1].Left += 3;
            }
            else
            {
                alien2initialX += 3;
            }
            if (alien2move != 2)
            {
                alien2[2].Left += 2;
            }
            else
            {
                alien2initialX += 2;
            }
            if (alien2move != 3)
            {
                alien2[3].Left += 1;
            }
            else
            {
                alien2initialX += 1;
            }
            if (alien2move != 4)
            {
                alien2[4].Left -= 1;
            }
            else
            {
                alien2initialX -= 1;
            }
            if (alien2move != 5)
            {
                alien2[5].Left -= 2;
            }
            else
            {
                alien2initialX -= 2;
            }
            if (alien2move != 6)
            {
                alien2[6].Left -= 3;
            }
            else
            {
                alien2initialX -= 3;
            }
            if (alien2move != 7)
            {
                alien2[7].Left -= 4;
            }
            else
            {
                alien2initialX -= 4;
            }
            if (alien2move != 8)
            {
                alien2[8].Left += 4;
            }
            else
            {
                alien2initialX += 4;
            }
            if (alien2move != 9)
            {
                alien2[9].Left += 3;
            }
            else
            {
                alien2initialX += 3;
            }
            if (alien2move != 10)
            {
                alien2[10].Left += 2;
            }
            else
            {
                alien2initialX += 2;
            }
            if (alien2move != 11)
            {
                alien2[11].Left += 1;
            }
            else
            {
                alien2initialX += 1;
            }
            if (alien2move != 12)
            {
                alien2[12].Left -= 1;
            }
            else
            {
                alien2initialX -= 1;
            }
            if (alien2move != 13)
            {
                alien2[13].Left -= 2;
            }
            else
            {
                alien2initialX -= 2;
            }
            if (alien2move != 14)
            {
                alien2[14].Left -= 3;
            }
            else
            {
                alien2initialX -= 3;
            }
            if (alien2move != 15)
            {
                alien2[15].Left -= 4;
            }
            else
            {
                alien2initialX -= 4;
            }

            //moves the aliens down
            for (int n = 0; n < alien2.Length; n++)
            {
                if (n < 8 && n != alien2move)
                {
                    alien2[n].Top -= 1;
                }
                else if (n >= 8 && n != alien2move)
                {
                    alien2[n].Top -= 2;
                }
                else if (n < 8)
                {
                    alien2initialY -= 1;
                }
                else if (n >= 8)
                {
                    alien2initialY -= 2;
                }
            }

            if (alien1move != 0)
            {
                alien1[0].Left += 5;
            }
            else
            {
                alien1initialX += 5;
            }
            if (alien1move != 1)
            {
                alien1[1].Left += 4;
            }
            else
            {
                alien1initialX += 4;
            }
            if (alien1move != 2)
            {
                alien1[2].Left += 3;
            }
            else
            {
                alien1initialX += 3;
            }
            if (alien1move != 3)
            {
                alien1[3].Left += 2;
            }
            else
            {
                alien1initialX += 2;
            }
            if (alien1move != 4)
            {
                alien1[4].Left += 1;
            }
            else
            {
                alien1initialX += 1;
            }
            if (alien1move != 5)
            {
                alien1[5].Left -= 1;
            }
            else
            {
                alien1initialX -= 1;
            }
            if (alien1move != 6)
            {
                alien1[6].Left -= 2;
            }
            else
            {
                alien1initialX -= 2;
            }
            if (alien1move != 7)
            {
                alien1[7].Left -= 3;
            }
            else
            {
                alien1initialX -= 3;
            }
            if (alien1move != 8)
            {
                alien1[8].Left -= 4;
            }
            else
            {
                alien1initialX -= 4;
            }
            if (alien1move != 9)
            {
                alien1[9].Left -= 5;
            }
            else
            {
                alien1initialX -= 5;
            }
            if (alien1move != 10)
            {
                alien1[10].Left += 5;
            }
            else
            {
                alien1initialX += 5;
            }
            if (alien1move != 11)
            {
                alien1[11].Left += 4;
            }
            else
            {
                alien1initialX += 4;
            }
            if (alien1move != 12)
            {
                alien1[12].Left += 3;
            }
            else
            {
                alien1initialX += 3;
            }
            if (alien1move != 13)
            {
                alien1[13].Left += 2;
            }
            else
            {
                alien1initialX += 2;
            }
            if (alien1move != 14)
            {
                alien1[14].Left += 1;
            }
            else
            {
                alien1initialX += 1;
            }
            if (alien1move != 15)
            {
                alien1[15].Left -= 1;
            }
            else
            {
                alien1initialX -= 1;
            }
            if (alien1move != 16)
            {
                alien1[16].Left -= 2;
            }
            else
            {
                alien1initialX -= 2;
            }
            if (alien1move != 17)
            {
                alien1[17].Left -= 3;
            }
            else
            {
                alien1initialX -= 3;
            }
            if (alien1move != 18)
            {
                alien1[18].Left -= 4;
            }
            else
            {
                alien1initialX -= 4;
            }
            if (alien1move != 19)
            {
                alien1[19].Left -= 5;
            }
            else
            {
                alien1initialX -= 5;
            }

            for (int n = 0; n < alien1.Length; n++)
            {
                if (n < 10 && n != alien1move)
                {
                    alien1[n].Top -= 3;
                }
                else if (n >= 10 && n != alien1move)
                {
                    alien1[n].Top -= 4;
                }
                else if (n < 10)
                {
                    alien1initialY -= 3;
                }
                else if (n >= 10)
                {
                    alien1initialY -= 4;
                }
            }
        }

        public void V1(object sender, EventArgs e)
        {
            //makes aliens V1 pics
            for (int n = 0; n < alien3.Length; n++)
            {
                //makes image down for starting
                if (TstartPos.Enabled == true)
                {
                    alien3[n].Image = picAlien3v1down.Image;
                }
                //makes image down if alien is moving
                else if (n == alien3move)
                {
                    if (alien3hit[n] == 0)
                    {
                        alien3[n].Image = picAlien3v1down.Image;
                    }
                    else if (alien3hit[n] == 1)
                    {
                        alien3[n].Image = picAlien3v3down.Image;
                    }
                }
                //makes image up if alien is not moving
                else
                {
                    if (alien3hit[n] == 0)
                    {
                        alien3[n].Image = picAlien3v1up.Image;
                    }
                    else if (alien3hit[n] == 1)
                    {
                        alien3[n].Image = picAlien3v3up.Image;
                    }
                }
            }

            for (int n = 0; n < alien2.Length; n++)
            {
                if (TalienExplode1.Enabled == true && alienWhichExplode1 == n
                    && alienExplodeWhichType1 == 2)
                {
                    //stop other paths
                }
                else if (TalienExplode2.Enabled == true && alienWhichExplode2 == n
                    && alienExplodeWhichType2 == 2)
                {
                    //stop other paths
                }
                else if (TalienExplode3.Enabled == true && alienWhichExplode3 == n
                    && alienExplodeWhichType3 == 2)
                {
                    //stop other paths
                }
                else if (TalienExplode4.Enabled == true && alienWhichExplode4 == n
                    && alienExplodeWhichType4 == 2)
                {
                    //stop other paths
                }
                else if (TstartPos.Enabled == true)
                {
                    alien2[n].Image = picAlien2v1down.Image;
                }
                else if (n == alien2move)
                {
                    alien2[n].Image = picAlien2v1down.Image;
                }
                else
                {
                    alien2[n].Image = picAlien2v1up.Image;
                }
            }

            for (int n = 0; n < alien1.Length; n++)
            {
                if (TalienExplode1.Enabled == true && alienWhichExplode1 == n
                    && alienExplodeWhichType1 == 1)
                {
                    //stop other paths
                }
                else if (TalienExplode2.Enabled == true && alienWhichExplode2 == n
                    && alienExplodeWhichType2 == 1)
                {
                    //stop other paths
                }
                else if (TalienExplode3.Enabled == true && alienWhichExplode3 == n
                    && alienExplodeWhichType3 == 1)
                {
                    //stop other paths
                }
                else if (TalienExplode4.Enabled == true && alienWhichExplode4 == n
                    && alienExplodeWhichType4 == 1)
                {
                    //stop other paths
                }
                else if (TstartPos.Enabled == true)
                {
                    alien1[n].Image = picAlien1v1down.Image;
                }
                else if (n == alien1move)
                {
                    alien1[n].Image = picAlien1v1down.Image;
                }
                else
                {
                    alien1[n].Image = picAlien1v1up.Image;
                }
            }
        }

        public void V2(object sender, EventArgs e)
        {
            //makes aliens V2 pics
            for (int n = 0; n < alien3.Length; n++)
            {
                //makes image down for starting
                if (TstartPos.Enabled == true)
                {
                    alien3[n].Image = picAlien3v2down.Image;
                }
                //makes image down for moving
                else if (n == alien3move)
                {
                    if (alien3hit[n] == 0)
                    {
                        alien3[n].Image = picAlien3v2down.Image;
                    }
                    else if (alien3hit[n] == 1)
                    {
                        alien3[n].Image = picAlien3v4down.Image;
                    }
                }
                //makes image up if alien is not moving
                else
                {
                    if (alien3hit[n] == 0)
                    {
                        alien3[n].Image = picAlien3v2up.Image;
                    }
                    else if (alien3hit[n] == 1)
                    {
                        alien3[n].Image = picAlien3v4up.Image;
                    }
                }
            }

            for (int n = 0; n < alien2.Length; n++)
            {
                if (TalienExplode1.Enabled == true && alienWhichExplode1 == n
                    && alienExplodeWhichType1 == 2)
                {
                    //stop other paths
                }
                else if (TalienExplode2.Enabled == true && alienWhichExplode2 == n
                    && alienExplodeWhichType2 == 2)
                {
                    //stop other paths
                }
                else if (TalienExplode3.Enabled == true && alienWhichExplode3 == n
                    && alienExplodeWhichType3 == 2)
                {
                    //stop other paths
                }
                else if (TalienExplode4.Enabled == true && alienWhichExplode4 == n
                    && alienExplodeWhichType4 == 2)
                {
                    //stop other paths
                }
                else if (TstartPos.Enabled == true)
                {
                    alien2[n].Image = picAlien2v2down.Image;
                }
                else if (n == alien2move)
                {
                    alien2[n].Image = picAlien2v2down.Image;
                }
                else
                {
                    alien2[n].Image = picAlien2v2up.Image;
                }
            }

            for (int n = 0; n < alien1.Length; n++)
            {
                if (TalienExplode1.Enabled == true && alienWhichExplode1 == n
                    && alienExplodeWhichType1 == 1)
                {
                    //stop other paths
                }
                else if (TalienExplode2.Enabled == true && alienWhichExplode2 == n
                    && alienExplodeWhichType2 == 1)
                {
                    //stop other paths
                }
                else if (TalienExplode3.Enabled == true && alienWhichExplode3 == n
                    && alienExplodeWhichType3 == 1)
                {
                    //stop other paths
                }
                else if (TalienExplode4.Enabled == true && alienWhichExplode4 == n
                    && alienExplodeWhichType4 == 1)
                {
                    //stop other paths
                }
                else if (TstartPos.Enabled == true)
                {
                    alien1[n].Image = picAlien1v2down.Image;
                }
                else if (n == alien1move)
                {
                    alien1[n].Image = picAlien1v2down.Image;
                }
                else
                {
                    alien1[n].Image = picAlien1v2up.Image;
                }
            }
        }

        private void Tbullet1_Tick(object sender, EventArgs e)
        {
            //calls on bullet function
            bullet(sender, e, picBullet1, Tbullet1);
        }

        private void Tbullet2_Tick(object sender, EventArgs e)
        {
            //calls on bullet function
            bullet(sender, e, picBullet2, Tbullet2);
        }

        public void bullet(object sender, EventArgs e, PictureBox whichBullet, Timer whichTimer)
        {
            //moves bullet down
            whichBullet.Top -= 20;

            //resets bullet if off the screen
            if (whichBullet.Top < -5)
            {
                whichTimer.Enabled = false;
                whichBullet.Left = picShip.Left + 18;
                whichBullet.Top = picShip.Top;
            }

            if (level != 5)
            {
                //checks to see if bullet hits the aliens
                for (int n = 0; n < alien1.Length; n++)
                {
                    //creates bullet box
                    Rectangle bulletBox = new Rectangle(whichBullet.Left, whichBullet.Top,
                            whichBullet.Width, whichBullet.Height);

                    if (n < 4)
                    {
                        //creates alien boxes
                        Rectangle alien1box = new Rectangle(alien1[n].Left, alien1[n].Top,
                            alien1[n].Width, alien1[n].Height);
                        Rectangle alien2box = new Rectangle(alien2[n].Left, alien2[n].Top,
                            alien2[n].Width, alien2[n].Height);
                        Rectangle alien3box = new Rectangle(alien3[n].Left, alien3[n].Top,
                            alien3[n].Width, alien3[n].Height);

                        //makes alien 1 explode when hit
                        if (bulletBox.IntersectsWith(alien1box) && alien1[n].Width != 93
                            && alien1[n].Image != picAlienExplode1.Image)
                        {
                            //sends it to first explode timer
                            if (TalienExplode1.Enabled == false)
                            {
                                alienExplodeWhichType1 = 1;
                                alienWhichExplode1 = n;
                                TalienExplode1.Enabled = true;
                            }
                            //sends it to second explode timer
                            else if (TalienExplode2.Enabled == false)
                            {
                                alienExplodeWhichType2 = 1;
                                alienWhichExplode2 = n;
                                TalienExplode2.Enabled = true;
                            }
                            //sends it to third explode timer
                            else if (TalienExplode3.Enabled == false)
                            {
                                alienExplodeWhichType3 = 1;
                                alienWhichExplode3 = n;
                                TalienExplode3.Enabled = true;
                            }
                            //sends it to fourth explode timer
                            else if (TalienExplode4.Enabled == false)
                            {
                                alienExplodeWhichType4 = 1;
                                alienWhichExplode4 = n;
                                TalienExplode4.Enabled = true;
                            }

                            //adds the score
                            score += alien1score * multiplyer;
                            lblScore.Text = score.ToString();
                            if (score > highScore)
                            {
                                lblHighscore.Text = score.ToString();
                            }

                            //adds to consecutive hits for multiplyer
                            consecutiveHits += 1;

                            //adds to total hits
                            totalHits += 1;

                            //resets the bullet
                            whichBullet.Left = picShip.Left + 18;
                            whichBullet.Top = picShip.Top;
                            whichTimer.Enabled = false;
                        }
                        //makes alien 2 explode when hit
                        else if (bulletBox.IntersectsWith(alien2box) && alien2[n].Width != 93
                            && alien2[n].Image != picAlienExplode1.Image)
                        {
                            //sends it to first explode timer
                            if (TalienExplode1.Enabled == false)
                            {
                                alienExplodeWhichType1 = 2;
                                alienWhichExplode1 = n;
                                TalienExplode1.Enabled = true;
                            }
                            //sends it to second explode timer
                            else if (TalienExplode2.Enabled == false)
                            {
                                alienExplodeWhichType2 = 2;
                                alienWhichExplode2 = n;
                                TalienExplode2.Enabled = true;
                            }
                            //sends it to third explode timer
                            else if (TalienExplode3.Enabled == false)
                            {
                                alienExplodeWhichType3 = 2;
                                alienWhichExplode3 = n;
                                TalienExplode3.Enabled = true;
                            }
                            //sends it to fourth explode timer
                            else if (TalienExplode4.Enabled == false)
                            {
                                alienExplodeWhichType4 = 2;
                                alienWhichExplode4 = n;
                                TalienExplode4.Enabled = true;
                            }

                            //adds the score
                            score += alien2score * multiplyer;
                            lblScore.Text = score.ToString();
                            if (score > highScore)
                            {
                                lblHighscore.Text = score.ToString();
                            }

                            //adds to consecutive hits for multiplyer
                            consecutiveHits += 1;

                            //adds to total hits
                            totalHits += 1;

                            //resets bullet
                            whichBullet.Left = picShip.Left + 18;
                            whichBullet.Top = picShip.Top;
                            whichTimer.Enabled = false;
                        }
                        //makes alien 3 explode when hit
                        else if (bulletBox.IntersectsWith(alien3box) && alien3[n].Width != 93
                            && alien3[n].Image != picAlienExplode1.Image)
                        {
                            //adds to total hits
                            totalHits += 1;
                            //checks to see how many times alien has been hit
                            //makes alien purple if first hit
                            if (alien3hit[n] == 0)
                            {
                                //plays sound of first alien 3 hit
                                alien3hit1sound.Ctlcontrols.play();
                                if (alien3move != n)
                                {
                                    alien3[n].Image = picAlien3v3up.Image;
                                }
                                else
                                {
                                    alien3[n].Image = picAlien3v3down.Image;
                                }
                                alien3hit[n] += 1;
                                whichBullet.Left = picShip.Left + 18;
                                whichBullet.Top = picShip.Top;
                                whichTimer.Enabled = false;
                            }
                            //makes alien explode if second hit
                            else if (alien3hit[n] == 1)
                            {
                                if (TalienExplode1.Enabled == false)
                                {
                                    alienExplodeWhichType1 = 3;
                                    alienWhichExplode1 = n;
                                    TalienExplode1.Enabled = true;

                                }
                                else if (TalienExplode2.Enabled == false)
                                {
                                    alienExplodeWhichType2 = 3;
                                    alienWhichExplode2 = n;
                                    TalienExplode2.Enabled = true;
                                }
                                else if (TalienExplode3.Enabled == false)
                                {
                                    alienExplodeWhichType3 = 3;
                                    alienWhichExplode3 = n;
                                    TalienExplode3.Enabled = true;
                                }
                                else if (TalienExplode4.Enabled == false)
                                {
                                    alienExplodeWhichType4 = 3;
                                    alienWhichExplode4 = n;
                                    TalienExplode4.Enabled = true;
                                }

                                //adds to score
                                score += alien3score * multiplyer;
                                lblScore.Text = score.ToString();
                                if (score > highScore)
                                {
                                    lblHighscore.Text = score.ToString();
                                }

                                //adds to consecutive hits for multiplyer
                                consecutiveHits += 1;

                                //resets bullet and adds to alien 3 hits
                                alien3hit[n] += 1;
                                whichBullet.Left = picShip.Left + 18;
                                whichBullet.Top = picShip.Top;
                                whichTimer.Enabled = false;
                            }
                        }
                    }
                    //checks if aliens 1 or 2 are hit
                    else if (n < 16)
                    {
                        Rectangle alien1box = new Rectangle(alien1[n].Left, alien1[n].Top,
                            alien1[n].Width, alien1[n].Height);
                        Rectangle alien2box = new Rectangle(alien2[n].Left, alien2[n].Top,
                            alien2[n].Width, alien2[n].Height);

                        if (bulletBox.IntersectsWith(alien1box) && alien1[n].Width != 93
                            && alien1[n].Image != picAlienExplode1.Image)
                        {
                            if (TalienExplode1.Enabled == false)
                            {
                                alienExplodeWhichType1 = 1;
                                alienWhichExplode1 = n;
                                TalienExplode1.Enabled = true;
                            }
                            else if (TalienExplode2.Enabled == false)
                            {
                                alienExplodeWhichType2 = 1;
                                alienWhichExplode2 = n;
                                TalienExplode2.Enabled = true;
                            }
                            else if (TalienExplode3.Enabled == false)
                            {
                                alienExplodeWhichType3 = 1;
                                alienWhichExplode3 = n;
                                TalienExplode3.Enabled = true;
                            }
                            else if (TalienExplode4.Enabled == false)
                            {
                                alienExplodeWhichType4 = 1;
                                alienWhichExplode4 = n;
                                TalienExplode4.Enabled = true;
                            }

                            score += alien1score * multiplyer;
                            lblScore.Text = score.ToString();
                            if (score > highScore)
                            {
                                lblHighscore.Text = score.ToString();
                            }

                            consecutiveHits += 1;

                            totalHits += 1;

                            whichBullet.Left = picShip.Left + 18;
                            whichBullet.Top = picShip.Top;
                            whichTimer.Enabled = false;
                        }
                        else if (bulletBox.IntersectsWith(alien2box) && alien2[n].Width != 93
                            && alien2[n].Image != picAlienExplode1.Image)
                        {
                            if (TalienExplode1.Enabled == false)
                            {
                                alienExplodeWhichType1 = 2;
                                alienWhichExplode1 = n;
                                TalienExplode1.Enabled = true;

                            }
                            else if (TalienExplode2.Enabled == false)
                            {
                                alienExplodeWhichType2 = 2;
                                alienWhichExplode2 = n;
                                TalienExplode2.Enabled = true;
                            }
                            else if (TalienExplode3.Enabled == false)
                            {
                                alienExplodeWhichType3 = 2;
                                alienWhichExplode3 = n;
                                TalienExplode3.Enabled = true;
                            }
                            else if (TalienExplode4.Enabled == false)
                            {
                                alienExplodeWhichType4 = 2;
                                alienWhichExplode4 = n;
                                TalienExplode4.Enabled = true;
                            }

                            score += alien2score * multiplyer;
                            lblScore.Text = score.ToString();
                            if (score > highScore)
                            {
                                lblHighscore.Text = score.ToString();
                            }

                            consecutiveHits += 1;

                            totalHits += 1;

                            whichBullet.Left = picShip.Left + 18;
                            whichBullet.Top = picShip.Top;
                            whichTimer.Enabled = false;
                        }
                    }
                    //checks if alien 1 is hit
                    else
                    {
                        Rectangle alien1box = new Rectangle(alien1[n].Left, alien1[n].Top,
                            alien1[n].Width, alien1[n].Height);

                        if (bulletBox.IntersectsWith(alien1box) && alien1[n].Width != 93
                            && alien1[n].Image != picAlienExplode1.Image)
                        {
                            if (TalienExplode1.Enabled == false)
                            {
                                alienExplodeWhichType1 = 1;
                                alienWhichExplode1 = n;
                                TalienExplode1.Enabled = true;
                            }
                            else if (TalienExplode2.Enabled == false)
                            {
                                alienExplodeWhichType2 = 1;
                                alienWhichExplode2 = n;
                                TalienExplode2.Enabled = true;
                            }
                            else if (TalienExplode3.Enabled == false)
                            {
                                alienExplodeWhichType3 = 1;
                                alienWhichExplode3 = n;
                                TalienExplode3.Enabled = true;
                            }
                            else if (TalienExplode4.Enabled == false)
                            {
                                alienExplodeWhichType4 = 1;
                                alienWhichExplode4 = n;
                                TalienExplode4.Enabled = true;
                            }

                            score += alien1score * multiplyer;
                            lblScore.Text = score.ToString();
                            if (score > highScore)
                            {
                                lblHighscore.Text = score.ToString();
                            }

                            consecutiveHits += 1;

                            totalHits += 1;

                            whichBullet.Left = picShip.Left + 18;
                            whichBullet.Top = picShip.Top;
                            whichTimer.Enabled = false;
                        }
                    }
                }
            }
            else if (level == 5)
            {
                //checks if aliens are hit
                Rectangle bulletBox = new Rectangle(whichBullet.Left, whichBullet.Top,
                            whichBullet.Width, whichBullet.Height);

                Rectangle bossBox = new Rectangle(picBoss.Left, picBoss.Top,
                            picBoss.Width, picBoss.Height);
                Rectangle minion1box = new Rectangle(picMinion1.Left, picMinion1.Top,
                            picMinion1.Width, picMinion1.Height);
                Rectangle minion2box = new Rectangle(picMinion2.Left, picMinion2.Top,
                            picMinion2.Width, picMinion2.Height);

                if (bulletBox.IntersectsWith(bossBox))
                {
                    //makes boss health go down when hit
                    lblBossHealth.Width -= 10;
                    if (lblBossHealth.Width <= 420 && lblBossHealth.Width > 200)
                    {
                        //changes color when 66% dead
                        lblBossHealth.BackColor = System.Drawing.Color.Yellow;
                    }
                    else if (lblBossHealth.Width <= 200 && lblBossHealth.Width > 0)
                    {
                        //changes color when 33% dead
                        lblBossHealth.BackColor = System.Drawing.Color.Red;
                    }
                    else if (lblBossHealth.Width == 0)
                    {
                        //sets bossInt for winning
                        bossInt = 99;
                    }

                    //resets the bullet
                    whichBullet.Left = picShip.Left + 18;
                    whichBullet.Top = picShip.Top;
                    whichTimer.Enabled = false;

                    //adds to total hits
                    totalHits += 1;
                }
                else if (bulletBox.IntersectsWith(minion1box) && picMinion1.Width != 93
                    && picMinion1.Image != picAlienExplode1.Image)
                {
                    //adds to minion hits
                    bossMinion1hits += 1;
                    if (bossMinion1hits == 2)
                    {
                        //makes minion explode when second hit
                        minion1explodeInt += 1;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        //plays sound for hitting minion
                        alien3hit1sound.Ctlcontrols.play();
                    }
                    //adds to total hits
                    totalHits += 1;

                    //resets the bullet
                    whichBullet.Left = picShip.Left + 18;
                    whichBullet.Top = picShip.Top;
                    whichTimer.Enabled = false;
                }
                else if (bulletBox.IntersectsWith(minion2box) && picMinion2.Width != 93
                    && picMinion2.Image != picAlienExplode1.Image)
                {
                    bossMinion2hits += 1;
                    if (bossMinion2hits == 2)
                    {
                        minion2explodeInt += 1;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        alien3hit1sound.Ctlcontrols.play();
                    }

                    //resets the bullet
                    whichBullet.Left = picShip.Left + 18;
                    whichBullet.Top = picShip.Top;
                    whichTimer.Enabled = false;
                    //adds to total hits
                    totalHits += 1;
                }
            }
        }

        private void TstartPos_Tick(object sender, EventArgs e)
        {
            //starts aliens moving
            startPosInt += 1;
            //changes alien images and moves alien 1s down
            for (int n = 0; n < alien1.Length; n++)
            {
                alien1[n].Top += 10;
                if (startPosInt == 1)
                {
                    V1(sender, e);
                }
                else if (startPosInt == 5)
                {
                    V2(sender, e);
                }
                else if (startPosInt == 9)
                {
                    V1(sender, e);
                }
                else if (startPosInt == 13)
                {
                    V2(sender, e);
                }
                else if (startPosInt == 17)
                {
                    V1(sender, e);
                }
                else if (startPosInt == 21)
                {
                    V2(sender, e);
                }
            }
            //moves alien 2s down
            for (int m = 0; m < alien2.Length; m++)
            {
                alien2[m].Top += 10;
            }
            //moves alien 3s down
            for (int p = 0; p < alien3.Length; p++)
            {
                alien3[p].Top += 10;

                //starts idle movement and alien movement when reaching ideal position
                if (alien3[p].Top >= 35)
                {
                    TstartPos.Enabled = false;
                    TidleMovement.Enabled = true;
                    Talien1move.Enabled = true;
                    Talien2move.Enabled = true;
                    Talien3move.Enabled = true;
                    startPosInt = 0;
                }
            }
        }

        private void Talien1move_Tick(object sender, EventArgs e)
        {
            //moves alien 1
            //gets timer going
            Talien1moveInt += 1;

            //randomly selects alien 1 to move
            if (Talien1moveInt == 5)
            {
                Tmove1location = picShip.Left;
                for (int n = 0; n < 100; n++)
                {
                    //makes sure alien is alive
                    alien1move = pickAlien.Next(0, 20);
                    if (alien1[alien1move].Width != 0 && alien1hits != 20)
                    {
                        n = 100;
                    }
                }

                //plays sound and finds initail coords of alien
                alien1initialX = alien1[alien1move].Left;
                alien1initialY = alien1[alien1move].Top;
                alienFlyingSound.Ctlcontrols.stop();
                alienFlyingSound.Ctlcontrols.play();
            }
            else if (Talien1moveInt > 5)
            {
                //moves alien sideways
                if (Tmove1location - alien1[alien1move].Left > 7)
                {
                    alien1[alien1move].Left += alienSpeedSide;
                }
                else if (Tmove1location - alien1[alien1move].Left < -7)
                {
                    alien1[alien1move].Left -= alienSpeedSide;
                }
                //moves alien down
                alien1[alien1move].Top += alienSpeedDown;

                //creates collision boxes
                Rectangle shipBox = new Rectangle(picShip.Left, picShip.Top,
                        picShip.Width, picShip.Height);
                Rectangle alien1Box = new Rectangle(alien1[alien1move].Left, alien1[alien1move].Top,
                        alien1[alien1move].Width, alien1[alien1move].Height);
                //finds if alien 1 hits the ship
                if (alien1Box.IntersectsWith(shipBox) && alien1[alien1move].Width != 93
                    && alien1[alien1move].Width != 0)
                {
                    TshipExplode.Enabled = true;
                    picBullet1.Visible = false;
                    picBullet2.Visible = false;
                    moveAbility = false;

                    alienExplodeWhichType4 = 1;
                    alienWhichExplode4 = alien1move;
                    TalienExplode4.Enabled = true;

                    score += alien1score;
                    lblScore.Text = score.ToString();
                    if (score > highScore)
                    {
                        lblHighscore.Text = score.ToString();
                    }

                    alien1move = 20;
                    Talien1moveInt = -13;
                    Talien1move.Enabled = false;

                    //resets alien 2 move timer
                    if (alien2move != 20)
                    {
                        alien2[alien2move].Left = alien2initialX;
                        alien2[alien2move].Top = alien2initialY;
                        alien2[alien2move].Image = picAlien2v1up.Image;
                    }
                    alien2move = 20;
                    Talien2moveInt = -13;
                    Talien2move.Enabled = false;

                    //resets alien 3 move timer
                    if (alien3move != 5)
                    {
                        if (alien3hit[alien3move] == 0)
                        {
                            alien3[alien3move].Image = picAlien3v1up.Image;
                        }
                        else if (alien3hit[alien3move] == 1)
                        {
                            alien3[alien3move].Image = picAlien3v3up.Image;
                        }
                        alien3[alien3move].Left = alien3initialX;
                        alien3[alien3move].Top = alien3initialY;
                    }
                    alien3move = 5;
                    Talien3moveInt = -13;
                    Talien3move.Enabled = false;
                }
                //if alien is shot the timer resets
                else if (alien1[alien1move].Width == 93)
                {
                    alien1move = 20;
                    Talien1moveInt = -13;
                }
                //if alien is off screen timer resets
                else if (alien1[alien1move].Top > this.Height)
                {
                    alien1[alien1move].Left = alien1initialX;
                    alien1[alien1move].Top = alien1initialY;
                    alien1[alien1move].Image = picAlien1v1up.Image;
                    alien1move = 20;
                    Talien1moveInt = -3;
                }

                if (alien1move != 20)
                {
                    if (level >= 3 && level <= 4 && picShip.Top - alien1[alien1move].Bottom <= 250
                    && Talien1bullets.Enabled == false)
                    {
                        Talien1bullets.Enabled = true;
                        picAlienBullet1.Left = alien1[alien1move].Left + 5;
                        picAlienBullet1.Top = alien1[alien1move].Bottom - 24;
                        picAlienBullet2.Left = alien1[alien1move].Right - 14;
                        picAlienBullet2.Top = alien1[alien1move].Bottom - 24;

                        if (picAlienBullet1.Left >= picShip.Left + 5)
                        {
                            //moves left
                            alienBullet1Direction = 1;
                        }
                        else if (picAlienBullet1.Left < picShip.Left + 5)
                        {
                            //moves right
                            alienBullet1Direction = 2;
                        }
                        if (picAlienBullet2.Left > picShip.Right - 14)
                        {
                            //moves left
                            alienBullet2Direction = 1;
                        }
                        else if (picAlienBullet2.Left <= picShip.Right - 14)
                        {
                            //moves right
                            alienBullet2Direction = 2;
                        }
                    }
                }
            }
        }

        private void Talien2move_Tick(object sender, EventArgs e)
        {
            //moves alien 2
            Talien2moveInt += 1;
            if (Talien2moveInt == 7)
            {
                Tmove2location = picShip.Left;
                for (int n = 0; n < 100; n++)
                {
                    alien2move = pickAlien.Next(0, 16);
                    if (alien2[alien2move].Width != 0 && alien2hits != 16)
                    {
                        n = 100;
                    }
                }

                alien2initialX = alien2[alien2move].Left;
                alien2initialY = alien2[alien2move].Top;
                alienFlyingSound.Ctlcontrols.stop();
                alienFlyingSound.Ctlcontrols.play();
            }
            else if (Talien2moveInt > 7)
            {
                if (Tmove2location - alien2[alien2move].Left > 7)
                {
                    alien2[alien2move].Left += alienSpeedSide;
                }
                else if (Tmove2location - alien2[alien2move].Left < -7)
                {
                    alien2[alien2move].Left -= alienSpeedSide;
                }
                alien2[alien2move].Top += alienSpeedDown;

                Rectangle shipBox = new Rectangle(picShip.Left, picShip.Top,
                        picShip.Width, picShip.Height);
                Rectangle alien2Box = new Rectangle(alien2[alien2move].Left, alien2[alien2move].Top,
                        alien2[alien2move].Width, alien2[alien2move].Height);
                if (alien2Box.IntersectsWith(shipBox) && alien2[alien2move].Width != 93
                    && alien2[alien2move].Width != 0)
                {
                    TshipExplode.Enabled = true;
                    picBullet1.Visible = false;
                    picBullet2.Visible = false;
                    moveAbility = false;

                    alienExplodeWhichType4 = 2;
                    alienWhichExplode4 = alien2move;
                    TalienExplode4.Enabled = true;

                    score += alien2score;
                    lblScore.Text = score.ToString();
                    if (score > highScore)
                    {
                        lblHighscore.Text = score.ToString();
                    }

                    alien2move = 20;
                    Talien2moveInt = -13;
                    Talien2move.Enabled = false;

                    if (alien1move != 20)
                    {
                        alien1[alien1move].Left = alien1initialX;
                        alien1[alien1move].Top = alien1initialY;
                        alien1[alien1move].Image = picAlien1v1up.Image;
                    }
                    alien1move = 20;
                    Talien1moveInt = -13;
                    Talien1move.Enabled = false;

                    if (alien3move != 5)
                    {
                        if (alien3hit[alien3move] == 0)
                        {
                            alien3[alien3move].Image = picAlien3v1up.Image;
                        }
                        else if (alien3hit[alien3move] == 1)
                        {
                            alien3[alien3move].Image = picAlien3v3up.Image;
                        }
                        alien3[alien3move].Left = alien3initialX;
                        alien3[alien3move].Top = alien3initialY;
                    }
                    alien3move = 5;
                    Talien3moveInt = -13;
                    Talien3move.Enabled = false;
                }
                else if (alien2[alien2move].Width == 93)
                {
                    alien2move = 20;
                    Talien2moveInt = -13;
                }
                else if (alien2[alien2move].Top > this.Height)
                {
                    alien2[alien2move].Left = alien2initialX;
                    alien2[alien2move].Top = alien2initialY;
                    alien2[alien2move].Image = picAlien2v1up.Image;
                    alien2move = 20;
                    Talien2moveInt = -3;
                }

                if (alien2move != 20)
                {
                    if (level >= 3 && level <= 4 && picShip.Top - alien2[alien2move].Bottom <= 250
                    && Talien2bullets.Enabled == false)
                    {
                        Talien2bullets.Enabled = true;
                        picAlienBullet3.Left = alien2[alien2move].Left + 5;
                        picAlienBullet3.Top = alien2[alien2move].Bottom - 24;
                        picAlienBullet4.Left = alien2[alien2move].Right - 14;
                        picAlienBullet4.Top = alien2[alien2move].Bottom - 24;

                        if (picAlienBullet3.Left >= picShip.Left + 5)
                        {
                            //moves left
                            alienBullet3Direction = 1;
                        }
                        else if (picAlienBullet3.Left < picShip.Left + 5)
                        {
                            //moves right
                            alienBullet3Direction = 2;
                        }
                        if (picAlienBullet4.Left > picShip.Right - 14)
                        {
                            //moves left
                            alienBullet4Direction = 1;
                        }
                        else if (picAlienBullet4.Left <= picShip.Right - 14)
                        {
                            //moves right
                            alienBullet4Direction = 2;
                        }
                    }
                }
            }
        }

        private void Talien3move_Tick(object sender, EventArgs e)
        {
            //moves alien 3
            Talien3moveInt += 1;
            if (Talien3moveInt == 30)
            {
                Tmove3location = picShip.Left;
                for (int n = 0; n < 100; n++)
                {
                    alien3move = pickAlien.Next(0, 4);
                    if (alien3[alien3move].Width != 0 && alien3hits != 4)
                    {
                        n = 100;
                    }
                }

                alien3initialX = alien3[alien3move].Left;
                alien3initialY = alien3[alien3move].Top;
                alienFlyingSound.Ctlcontrols.stop();
                alienFlyingSound.Ctlcontrols.play();
            }
            else if (Talien3moveInt > 30)
            {
                if (Tmove3location - alien3[alien3move].Left > 7)
                {
                    alien3[alien3move].Left += alienSpeedSide;
                }
                else if (Tmove3location - alien3[alien3move].Left < -7)
                {
                    alien3[alien3move].Left -= alienSpeedSide;
                }
                alien3[alien3move].Top += alienSpeedDown;

                Rectangle shipBox = new Rectangle(picShip.Left, picShip.Top,
                        picShip.Width, picShip.Height);
                Rectangle alien3Box = new Rectangle(alien3[alien3move].Left, alien3[alien3move].Top,
                        alien3[alien3move].Width, alien3[alien3move].Height);
                if (alien3Box.IntersectsWith(shipBox) && alien3[alien3move].Width != 0
                    && alien3[alien3move].Width != 93)
                {
                    TshipExplode.Enabled = true;
                    picBullet1.Visible = false;
                    picBullet2.Visible = false;
                    moveAbility = false;

                    if (alien3hit[alien3move] == 0)
                    {
                        alien3hit[alien3move] += 1;
                        alien3[alien3move].Left = alien3initialX;
                        alien3[alien3move].Top = alien3initialY;
                        alien3[alien3move].Image = picAlien3v3up.Image;
                        alien3move = 5;
                        Talien3moveInt = -13;
                        Talien3move.Enabled = false;
                    }
                    else if (alien3hit[alien3move] == 1)
                    {
                        alienExplodeWhichType4 = 3;
                        alienWhichExplode4 = alien3move;
                        TalienExplode4.Enabled = true;
                        alien3move = 5;
                        Talien3moveInt = -13;
                        Talien3move.Enabled = false;
                        score += alien3score;
                        lblScore.Text = score.ToString();
                        if (score > highScore)
                        {
                            lblHighscore.Text = score.ToString();
                        }
                    }

                    if (alien1move != 20)
                    {
                        alien1[alien1move].Left = alien1initialX;
                        alien1[alien1move].Top = alien1initialY;
                        alien1[alien1move].Image = picAlien1v1up.Image;
                    }
                    alien1move = 20;
                    Talien1moveInt = -13;
                    Talien1move.Enabled = false;
                    if (alien2move != 20)
                    {
                        alien2[alien2move].Left = alien2initialX;
                        alien2[alien2move].Top = alien2initialY;
                        alien2[alien2move].Image = picAlien2v1up.Image;
                    }
                    alien2move = 20;
                    Talien2moveInt = -13;
                    Talien2move.Enabled = false;
                }
                else if (alien3[alien3move].Width == 93)
                {
                    alien3move = 5;
                    Talien3moveInt = -13;
                }
                else if (alien3[alien3move].Top > this.Height)
                {
                    alien3[alien3move].Left = alien3initialX;
                    alien3[alien3move].Top = alien3initialY;
                    if (alien3hit[alien3move] == 0)
                    {
                        alien3[alien3move].Image = picAlien3v1up.Image;
                    }
                    else if (alien3hit[alien3move] == 1)
                    {
                        alien3[alien3move].Image = picAlien3v3up.Image;
                    }
                    alien3move = 5;
                    Talien3moveInt = -3;
                }

                if (alien3move != 5)
                {
                    if (level >= 3 && level <= 4 && picShip.Top - alien3[alien3move].Bottom <= 250
                    && Talien3bullets.Enabled == false)
                    {
                        Talien3bullets.Enabled = true;
                        picAlienBullet5.Left = alien3[alien3move].Left + 5;
                        picAlienBullet5.Top = alien3[alien3move].Bottom - 24;
                        picAlienBullet6.Left = alien3[alien3move].Right - 14;
                        picAlienBullet6.Top = alien3[alien3move].Bottom - 24;

                        if (picAlienBullet5.Left >= picShip.Left + 5)
                        {
                            //moves left
                            alienBullet5Direction = 1;
                        }
                        else if (picAlienBullet5.Left < picShip.Left + 5)
                        {
                            //moves right
                            alienBullet5Direction = 2;
                        }
                        if (picAlienBullet6.Left > picShip.Right - 14)
                        {
                            //moves left
                            alienBullet6Direction = 1;
                        }
                        else if (picAlienBullet6.Left <= picShip.Right - 14)
                        {
                            //moves right
                            alienBullet6Direction = 2;
                        }
                    }
                }
            }
        }

        private void TshipExplode_Tick(object sender, EventArgs e)
        {
            //resets multiplyer and consecutive hits
            multiplyer = 1;
            consecutiveHits = 0;
            lblMultiplyer2.Visible = false;
            lblMultiplyer3.Visible = false;
            lblMultiplyer4.Visible = false;
            lblMultiplyer5.Visible = false;

            //explodes the ship
            shipExplodeInt += 1;

            if (shipExplodeInt == 1)
            {
                //changes size and pic of ship and plays sound
                //changes to first pic in sequence
                picShip.Image = picShipExplode1.Image;
                //changes size and position
                picShip.Left -= 26;
                picShip.Top -= 24;
                picShip.Width = 96;
                picShip.Height = 96;
                //plays explosion sound
                shipExplodeSound.Ctlcontrols.play();
            }
            else if (shipExplodeInt == 2)
            {
                //next pic in sequence
                picShip.Image = picShipExplode2.Image;
            }
            else if (shipExplodeInt == 3)
            {
                //next pic in sequence
                picShip.Image = picShipExplode3.Image;
            }
            else if (shipExplodeInt == 4)
            {
                //next pic in sequence
                picShip.Image = picShipExplode4.Image;
            }
            else if (shipExplodeInt == 5)
            {
                //makes ship invisible
                picShip.Visible = false;
            }
            else if (shipExplodeInt == 6)
            {
                //starts restart timer and resets explode timer
                TshipExplode.Enabled = false;
                shipExplodeInt = 0;
                TshipRestart.Enabled = true;
            }

            //puts bullets back if in use
            if (Tbullet1.Enabled == true)
            {
                Tbullet1.Enabled = false;
                picBullet1.Left = picShip.Left + 18;
                picBullet1.Top = picShip.Top;
            }
            if (Tbullet2.Enabled == true)
            {
                Tbullet2.Enabled = false;
                picBullet2.Left = picShip.Left + 18;
                picBullet2.Top = picShip.Top;
            }
        }

        private void TalienExplode1_Tick(object sender, EventArgs e)
        {
            //explodes an alien
            alienExplodeInt1 += 1;

            if (alienExplodeInt1 == 1)
            {
                if (alienExplodeWhichType1 == 1)
                {
                    //explodes an alien 1
                    //sends the alien to the back to prevent covering others
                    alien1[alienWhichExplode1].SendToBack();
                    //changes to initial explode pic
                    alien1[alienWhichExplode1].Image = picAlienExplode1.Image;
                    //changes size and position
                    alien1[alienWhichExplode1].Left -= 27;
                    alien1[alienWhichExplode1].Top -= 33;
                    alien1[alienWhichExplode1].Width = 93;
                    alien1[alienWhichExplode1].Height = 96;
                    //plays explosion sound
                    alien1hitSound.Ctlcontrols.stop();
                    alien1hitSound.Ctlcontrols.play();
                }
                else if (alienExplodeWhichType1 == 2)
                {
                    //explodes an alien 2
                    alien2[alienWhichExplode1].SendToBack();
                    alien2[alienWhichExplode1].Image = picAlienExplode1.Image;
                    alien2[alienWhichExplode1].Left -= 27;
                    alien2[alienWhichExplode1].Top -= 33;
                    alien2[alienWhichExplode1].Width = 93;
                    alien2[alienWhichExplode1].Height = 96;
                    alien2hitSound.Ctlcontrols.stop();
                    alien2hitSound.Ctlcontrols.play();
                }
                else if (alienExplodeWhichType1 == 3)
                {
                    //explodes an alien 3
                    alien3[alienWhichExplode1].SendToBack();
                    alien3[alienWhichExplode1].Image = picAlienExplode1.Image;
                    alien3[alienWhichExplode1].Left -= 24;
                    alien3[alienWhichExplode1].Top -= 24;
                    alien3[alienWhichExplode1].Width = 93;
                    alien3[alienWhichExplode1].Height = 96;
                    alien3hit2sound.Ctlcontrols.stop();
                    alien3hit2sound.Ctlcontrols.play();
                }
            }
            else if (alienExplodeInt1 == 2)
            {
                //next pic in sequence
                if (alienExplodeWhichType1 == 1)
                {
                    alien1[alienWhichExplode1].Image = picAlienExplode2.Image;
                }
                else if (alienExplodeWhichType1 == 2)
                {
                    alien2[alienWhichExplode1].Image = picAlienExplode2.Image;
                }
                else if (alienExplodeWhichType1 == 3)
                {
                    alien3[alienWhichExplode1].Image = picAlienExplode2.Image;
                }
            }
            else if (alienExplodeInt1 == 3)
            {
                //next pic in sequence
                if (alienExplodeWhichType1 == 1)
                {
                    alien1[alienWhichExplode1].Image = picAlienExplode3.Image;
                }
                else if (alienExplodeWhichType1 == 2)
                {
                    alien2[alienWhichExplode1].Image = picAlienExplode3.Image;
                }
                else if (alienExplodeWhichType1 == 3)
                {
                    alien3[alienWhichExplode1].Image = picAlienExplode3.Image;
                }
            }
            else if (alienExplodeInt1 == 4)
            {
                //next pic in sequence
                if (alienExplodeWhichType1 == 1)
                {
                    alien1[alienWhichExplode1].Image = picAlienExplode4.Image;
                }
                else if (alienExplodeWhichType1 == 2)
                {
                    alien2[alienWhichExplode1].Image = picAlienExplode4.Image;
                }
                else if (alienExplodeWhichType1 == 3)
                {
                    alien3[alienWhichExplode1].Image = picAlienExplode4.Image;
                }
            }
            else if (alienExplodeInt1 == 5)
            {
                //next pic in sequence
                if (alienExplodeWhichType1 == 1)
                {
                    alien1[alienWhichExplode1].Image = picAlienExplode5.Image;
                }
                else if (alienExplodeWhichType1 == 2)
                {
                    alien2[alienWhichExplode1].Image = picAlienExplode5.Image;
                }
                else if (alienExplodeWhichType1 == 3)
                {
                    alien3[alienWhichExplode1].Image = picAlienExplode5.Image;
                }
            }
            else if (alienExplodeInt1 == 6)
            {
                //takes alien off the screen
                if (alienExplodeWhichType1 == 1)
                {
                    alien1[alienWhichExplode1].Width = 0;
                    alien1[alienWhichExplode1].Height = 0;
                    alien1[alienWhichExplode1].Top = -100;
                    alien1hits += 1;
                    if (alien1hits == 20)
                    {
                        for (int n = 0; n < alien1.Length; n++)
                        {
                            alien1[n].Width = 0;
                            alien1[n].Height = 0;
                            alien1[n].Top = -100;
                        }
                        Talien1move.Enabled = false;
                    }
                }
                else if (alienExplodeWhichType1 == 2)
                {
                    alien2[alienWhichExplode1].Width = 0;
                    alien2[alienWhichExplode1].Height = 0;
                    alien2[alienWhichExplode1].Top = -100;
                    alien2hits += 1;
                    if (alien2hits == 16)
                    {
                        for (int n = 0; n < alien2.Length; n++)
                        {
                            alien2[n].Width = 0;
                            alien2[n].Height = 0;
                            alien2[n].Top = -100;
                        }
                        Talien2move.Enabled = false;
                    }
                }
                else if (alienExplodeWhichType1 == 3)
                {
                    alien3[alienWhichExplode1].Width = 0;
                    alien3[alienWhichExplode1].Height = 0;
                    alien3[alienWhichExplode1].Top = -100;
                    alien3hits += 1;
                    if (alien3hits == 4)
                    {
                        for (int n = 0; n < alien3.Length; n++)
                        {
                            alien3[n].Width = 0;
                            alien3[n].Height = 0;
                            alien3[n].Top = -100;
                        }
                        Talien3move.Enabled = false;
                    }
                }
                //resets the timer
                TalienExplode1.Enabled = false;
                alienExplodeInt1 = 0;
            }
        }

        private void TalienExplode2_Tick(object sender, EventArgs e)
        {
            //explodes an alien (same code as first timer, prevents errors)
            alienExplodeInt2 += 1;

            if (alienExplodeInt2 == 1)
            {
                if (alienExplodeWhichType2 == 1)
                {
                    alien1[alienWhichExplode2].SendToBack();
                    alien1[alienWhichExplode2].Image = picAlienExplode1.Image;
                    alien1[alienWhichExplode2].Left -= 27;
                    alien1[alienWhichExplode2].Top -= 33;
                    alien1[alienWhichExplode2].Width = 93;
                    alien1[alienWhichExplode2].Height = 96;
                    alien1hitSound.Ctlcontrols.stop();
                    alien1hitSound.Ctlcontrols.play();
                }
                else if (alienExplodeWhichType2 == 2)
                {
                    alien2[alienWhichExplode2].SendToBack();
                    alien2[alienWhichExplode2].Image = picAlienExplode1.Image;
                    alien2[alienWhichExplode2].Left -= 27;
                    alien2[alienWhichExplode2].Top -= 33;
                    alien2[alienWhichExplode2].Width = 93;
                    alien2[alienWhichExplode2].Height = 96;
                    alien2hitSound.Ctlcontrols.stop();
                    alien2hitSound.Ctlcontrols.play();
                }
                else if (alienExplodeWhichType2 == 3)
                {
                    alien3[alienWhichExplode2].SendToBack();
                    alien3[alienWhichExplode2].Image = picAlienExplode1.Image;
                    alien3[alienWhichExplode2].Left -= 24;
                    alien3[alienWhichExplode2].Top -= 24;
                    alien3[alienWhichExplode2].Width = 93;
                    alien3[alienWhichExplode2].Height = 96;
                    alien3hit2sound.Ctlcontrols.stop();
                    alien3hit2sound.Ctlcontrols.play();
                }
            }
            else if (alienExplodeInt2 == 2)
            {
                if (alienExplodeWhichType2 == 1)
                {
                    alien1[alienWhichExplode2].Image = picAlienExplode2.Image;
                }
                else if (alienExplodeWhichType2 == 2)
                {
                    alien2[alienWhichExplode2].Image = picAlienExplode2.Image;
                }
                else if (alienExplodeWhichType2 == 3)
                {
                    alien3[alienWhichExplode2].Image = picAlienExplode2.Image;
                }
            }
            else if (alienExplodeInt2 == 3)
            {
                if (alienExplodeWhichType2 == 1)
                {
                    alien1[alienWhichExplode2].Image = picAlienExplode3.Image;
                }
                else if (alienExplodeWhichType2 == 2)
                {
                    alien2[alienWhichExplode2].Image = picAlienExplode3.Image;
                }
                else if (alienExplodeWhichType2 == 3)
                {
                    alien3[alienWhichExplode2].Image = picAlienExplode3.Image;
                }
            }
            else if (alienExplodeInt2 == 4)
            {
                if (alienExplodeWhichType2 == 1)
                {
                    alien1[alienWhichExplode2].Image = picAlienExplode4.Image;
                }
                else if (alienExplodeWhichType2 == 2)
                {
                    alien2[alienWhichExplode2].Image = picAlienExplode4.Image;
                }
                else if (alienExplodeWhichType2 == 3)
                {
                    alien3[alienWhichExplode2].Image = picAlienExplode4.Image;
                }
            }
            else if (alienExplodeInt2 == 5)
            {
                if (alienExplodeWhichType2 == 1)
                {
                    alien1[alienWhichExplode2].Image = picAlienExplode5.Image;
                }
                else if (alienExplodeWhichType2 == 2)
                {
                    alien2[alienWhichExplode2].Image = picAlienExplode5.Image;
                }
                else if (alienExplodeWhichType2 == 3)
                {
                    alien3[alienWhichExplode2].Image = picAlienExplode5.Image;
                }
            }
            else if (alienExplodeInt2 == 6)
            {
                if (alienExplodeWhichType2 == 1)
                {
                    alien1[alienWhichExplode2].Width = 0;
                    alien1[alienWhichExplode2].Height = 0;
                    alien1[alienWhichExplode2].Top = -100;
                    alien1hits += 1;
                    if (alien1hits == 20)
                    {
                        for (int n = 0; n < alien1.Length; n++)
                        {
                            alien1[n].Width = 0;
                            alien1[n].Height = 0;
                            alien1[n].Top = -100;
                        }
                        Talien1move.Enabled = false;
                    }
                }
                else if (alienExplodeWhichType2 == 2)
                {
                    alien2[alienWhichExplode2].Width = 0;
                    alien2[alienWhichExplode2].Height = 0;
                    alien2[alienWhichExplode2].Top = -100;
                    alien2hits += 1;
                    if (alien2hits == 16)
                    {
                        for (int n = 0; n < alien2.Length; n++)
                        {
                            alien2[n].Width = 0;
                            alien2[n].Height = 0;
                            alien2[n].Top = -100;
                        }
                        Talien2move.Enabled = false;
                    }
                }
                else if (alienExplodeWhichType2 == 3)
                {
                    alien3[alienWhichExplode2].Width = 0;
                    alien3[alienWhichExplode2].Height = 0;
                    alien3[alienWhichExplode2].Top = -100;
                    alien3hits += 1;
                    if (alien3hits == 4)
                    {
                        for (int n = 0; n < alien3.Length; n++)
                        {
                            alien3[n].Width = 0;
                            alien3[n].Height = 0;
                            alien3[n].Top = -100;
                        }
                        Talien3move.Enabled = false;
                    }
                }
                TalienExplode2.Enabled = false;
                alienExplodeInt2 = 0;
            }
        }

        private void TalienExplode3_Tick(object sender, EventArgs e)
        {
            //explodes an alien (same code as first timer, prevents errors)
            alienExplodeInt3 += 1;

            if (alienExplodeInt3 == 1)
            {
                if (alienExplodeWhichType3 == 1)
                {
                    alien1[alienWhichExplode3].SendToBack();
                    alien1[alienWhichExplode3].Image = picAlienExplode1.Image;
                    alien1[alienWhichExplode3].Left -= 27;
                    alien1[alienWhichExplode3].Top -= 33;
                    alien1[alienWhichExplode3].Width = 93;
                    alien1[alienWhichExplode3].Height = 96;
                    alien1hitSound.Ctlcontrols.stop();
                    alien1hitSound.Ctlcontrols.play();
                }
                else if (alienExplodeWhichType3 == 2)
                {
                    alien2[alienWhichExplode3].SendToBack();
                    alien2[alienWhichExplode3].Image = picAlienExplode1.Image;
                    alien2[alienWhichExplode3].Left -= 27;
                    alien2[alienWhichExplode3].Top -= 33;
                    alien2[alienWhichExplode3].Width = 93;
                    alien2[alienWhichExplode3].Height = 96;
                    alien2hitSound.Ctlcontrols.stop();
                    alien2hitSound.Ctlcontrols.play();
                }
                else if (alienExplodeWhichType3 == 3)
                {
                    alien3[alienWhichExplode3].SendToBack();
                    alien3[alienWhichExplode3].Image = picAlienExplode1.Image;
                    alien3[alienWhichExplode3].Left -= 27;
                    alien3[alienWhichExplode3].Top -= 33;
                    alien3[alienWhichExplode3].Width = 93;
                    alien3[alienWhichExplode3].Height = 96;
                    alien3hit2sound.Ctlcontrols.stop();
                    alien3hit2sound.Ctlcontrols.play();
                }
            }
            else if (alienExplodeInt3 == 2)
            {
                if (alienExplodeWhichType3 == 1)
                {
                    alien1[alienWhichExplode3].Image = picAlienExplode2.Image;
                }
                else if (alienExplodeWhichType3 == 2)
                {
                    alien2[alienWhichExplode3].Image = picAlienExplode2.Image;
                }
                else if (alienExplodeWhichType3 == 3)
                {
                    alien3[alienWhichExplode3].Image = picAlienExplode2.Image;
                }
            }
            else if (alienExplodeInt3 == 3)
            {
                if (alienExplodeWhichType3 == 1)
                {
                    alien1[alienWhichExplode3].Image = picAlienExplode3.Image;
                }
                else if (alienExplodeWhichType3 == 2)
                {
                    alien2[alienWhichExplode3].Image = picAlienExplode3.Image;
                }
                else if (alienExplodeWhichType3 == 3)
                {
                    alien3[alienWhichExplode3].Image = picAlienExplode3.Image;
                }
            }
            else if (alienExplodeInt3 == 4)
            {
                if (alienExplodeWhichType3 == 1)
                {
                    alien1[alienWhichExplode3].Image = picAlienExplode4.Image;
                }
                else if (alienExplodeWhichType3 == 2)
                {
                    alien2[alienWhichExplode3].Image = picAlienExplode4.Image;
                }
                else if (alienExplodeWhichType3 == 3)
                {
                    alien3[alienWhichExplode3].Image = picAlienExplode4.Image;
                }
            }
            else if (alienExplodeInt3 == 5)
            {
                if (alienExplodeWhichType3 == 1)
                {
                    alien1[alienWhichExplode3].Image = picAlienExplode5.Image;
                }
                else if (alienExplodeWhichType3 == 2)
                {
                    alien2[alienWhichExplode3].Image = picAlienExplode5.Image;
                }
                else if (alienExplodeWhichType3 == 3)
                {
                    alien3[alienWhichExplode3].Image = picAlienExplode5.Image;
                }
            }
            else if (alienExplodeInt3 == 6)
            {
                if (alienExplodeWhichType3 == 1)
                {
                    alien1[alienWhichExplode3].Width = 0;
                    alien1[alienWhichExplode3].Height = 0;
                    alien1[alienWhichExplode3].Top = -100;
                    alien1hits += 1;
                    if (alien1hits == 20)
                    {
                        for (int n = 0; n < alien1.Length; n++)
                        {
                            alien1[n].Width = 0;
                            alien1[n].Height = 0;
                            alien1[n].Top = -100;
                        }
                        Talien1move.Enabled = false;
                    }
                }
                else if (alienExplodeWhichType3 == 2)
                {
                    alien2[alienWhichExplode3].Width = 0;
                    alien2[alienWhichExplode3].Height = 0;
                    alien2[alienWhichExplode3].Top = -100;
                    alien2hits += 1;
                    if (alien2hits == 16)
                    {
                        for (int n = 0; n < alien2.Length; n++)
                        {
                            alien2[n].Width = 0;
                            alien2[n].Height = 0;
                            alien2[n].Top = -100;
                        }
                        Talien2move.Enabled = false;
                    }
                }
                else if (alienExplodeWhichType3 == 3)
                {
                    alien3[alienWhichExplode3].Width = 0;
                    alien3[alienWhichExplode3].Height = 0;
                    alien3[alienWhichExplode3].Top = -100;
                    alien3hits += 1;
                    if (alien3hits == 4)
                    {
                        for (int n = 0; n < alien3.Length; n++)
                        {
                            alien3[n].Width = 0;
                            alien3[n].Height = 0;
                            alien3[n].Top = -100;
                        }
                        Talien3move.Enabled = false;
                    }
                }
                TalienExplode3.Enabled = false;
                alienExplodeInt3 = 0;
            }
        }

        private void TalienExplode4_Tick(object sender, EventArgs e)
        {
            //explodes an alien (same code as first timer, prevents errors)
            alienExplodeInt4 += 1;

            if (alienExplodeInt4 == 1)
            {
                if (alienExplodeWhichType4 == 1)
                {
                    alien1[alienWhichExplode4].SendToBack();
                    alien1[alienWhichExplode4].Image = picAlienExplode1.Image;
                    alien1[alienWhichExplode4].Left -= 27;
                    alien1[alienWhichExplode4].Top -= 33;
                    alien1[alienWhichExplode4].Width = 93;
                    alien1[alienWhichExplode4].Height = 96;
                    alien1hitSound.Ctlcontrols.stop();
                    alien1hitSound.Ctlcontrols.play();
                }
                else if (alienExplodeWhichType4 == 2)
                {
                    alien2[alienWhichExplode4].SendToBack();
                    alien2[alienWhichExplode4].Image = picAlienExplode1.Image;
                    alien2[alienWhichExplode4].Left -= 27;
                    alien2[alienWhichExplode4].Top -= 33;
                    alien2[alienWhichExplode4].Width = 93;
                    alien2[alienWhichExplode4].Height = 96;
                    alien2hitSound.Ctlcontrols.stop();
                    alien2hitSound.Ctlcontrols.play();
                }
                else if (alienExplodeWhichType4 == 3)
                {
                    alien3[alienWhichExplode4].SendToBack();
                    alien3[alienWhichExplode4].Image = picAlienExplode1.Image;
                    alien3[alienWhichExplode4].Left -= 27;
                    alien3[alienWhichExplode4].Top -= 33;
                    alien3[alienWhichExplode4].Width = 93;
                    alien3[alienWhichExplode4].Height = 96;
                    alien3hit2sound.Ctlcontrols.stop();
                    alien3hit2sound.Ctlcontrols.play();
                }
            }
            else if (alienExplodeInt4 == 2)
            {
                if (alienExplodeWhichType4 == 1)
                {
                    alien1[alienWhichExplode4].Image = picAlienExplode2.Image;
                }
                else if (alienExplodeWhichType4 == 2)
                {
                    alien2[alienWhichExplode4].Image = picAlienExplode2.Image;
                }
                else if (alienExplodeWhichType4 == 3)
                {
                    alien3[alienWhichExplode4].Image = picAlienExplode2.Image;
                }
            }
            else if (alienExplodeInt4 == 3)
            {
                if (alienExplodeWhichType4 == 1)
                {
                    alien1[alienWhichExplode4].Image = picAlienExplode3.Image;
                }
                else if (alienExplodeWhichType4 == 2)
                {
                    alien2[alienWhichExplode4].Image = picAlienExplode3.Image;
                }
                else if (alienExplodeWhichType4 == 3)
                {
                    alien3[alienWhichExplode4].Image = picAlienExplode3.Image;
                }
            }
            else if (alienExplodeInt4 == 4)
            {
                if (alienExplodeWhichType4 == 1)
                {
                    alien1[alienWhichExplode4].Image = picAlienExplode4.Image;
                }
                else if (alienExplodeWhichType4 == 2)
                {
                    alien2[alienWhichExplode4].Image = picAlienExplode4.Image;
                }
                else if (alienExplodeWhichType4 == 3)
                {
                    alien3[alienWhichExplode4].Image = picAlienExplode4.Image;
                }
            }
            else if (alienExplodeInt4 == 5)
            {
                if (alienExplodeWhichType4 == 1)
                {
                    alien1[alienWhichExplode4].Image = picAlienExplode5.Image;
                }
                else if (alienExplodeWhichType4 == 2)
                {
                    alien2[alienWhichExplode4].Image = picAlienExplode5.Image;
                }
                else if (alienExplodeWhichType4 == 3)
                {
                    alien3[alienWhichExplode4].Image = picAlienExplode5.Image;
                }
            }
            else if (alienExplodeInt4 == 6)
            {
                if (alienExplodeWhichType4 == 1)
                {
                    alien1[alienWhichExplode4].Width = 0;
                    alien1[alienWhichExplode4].Height = 0;
                    alien1[alienWhichExplode4].Top = -100;
                    alien1hits += 1;
                    if (alien1hits == 20)
                    {
                        for (int n = 0; n < alien1.Length; n++)
                        {
                            alien1[n].Width = 0;
                            alien1[n].Height = 0;
                            alien1[n].Top = -100;
                        }
                        Talien1move.Enabled = false;
                    }
                }
                else if (alienExplodeWhichType4 == 2)
                {
                    alien2[alienWhichExplode4].Width = 0;
                    alien2[alienWhichExplode4].Height = 0;
                    alien2[alienWhichExplode4].Top = -100;
                    alien2hits += 1;
                    if (alien2hits == 16)
                    {
                        for (int n = 0; n < alien2.Length; n++)
                        {
                            alien2[n].Width = 0;
                            alien2[n].Height = 0;
                            alien2[n].Top = -100;
                        }
                        Talien2move.Enabled = false;
                    }
                }
                else if (alienExplodeWhichType4 == 3)
                {
                    alien3[alienWhichExplode4].Width = 0;
                    alien3[alienWhichExplode4].Height = 0;
                    alien3[alienWhichExplode4].Top = -100;
                    alien3hits += 1;
                    if (alien3hits == 4)
                    {
                        for (int n = 0; n < alien3.Length; n++)
                        {
                            alien3[n].Width = 0;
                            alien3[n].Height = 0;
                            alien3[n].Top = -100;
                        }
                        Talien3move.Enabled = false;
                    }
                }
                TalienExplode4.Enabled = false;
                alienExplodeInt4 = 0;
            }
        }

        private void TintroMusic_Tick(object sender, EventArgs e)
        {
            //plays intro music for starting up
            introMusicInt += 1;
            if (introMusicInt == 1)
            {
                //plays music
                System.Media.SoundPlayer startMusic = new System.Media.SoundPlayer(@"Resources\startMusic.wav");
                startMusic.Play();
            }
            else if (introMusicInt == 4)
            {
                //makes ship visible after delay
                picShip.Visible = true;
                picBullet1.Visible = true;
                picBullet2.Visible = true;
            }
            else if (introMusicInt == 6)
            {
                //makes ship moveable after delay and shows stage 2
                lblReady.Visible = false;
                lblLevel1.Visible = true;
                moveAbility = true;
            }
            else if (introMusicInt == 8)
            {
                //starts game and hides labels
                lblLevel1.Visible = false;
                TstartPos.Enabled = true;
                introMusicInt = 0;
                TintroMusic.Enabled = false;
            }
        }

        private void frmGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            //prevents errors when closing and reopening game
            alien1hitSound.Ctlcontrols.stop();
            alien2hitSound.Ctlcontrols.stop();
            alien3hit1sound.Ctlcontrols.stop();
            alien3hit2sound.Ctlcontrols.stop();
            shotSound.Ctlcontrols.stop();
            shipExplodeSound.Ctlcontrols.stop();
            alienFlyingSound.Ctlcontrols.stop();
            System.Media.SoundPlayer stop = new System.Media.SoundPlayer();
            stop.Stop();
            TidleMovement.Enabled = false;
            Talien1move.Enabled = false;
            Talien2move.Enabled = false;
            Talien3move.Enabled = false;
            Tbullet1.Enabled = false;
            Tbullet2.Enabled = false;
            TstartPos.Enabled = false;
            TshipExplode.Enabled = false;
            TalienExplode1.Enabled = false;
            TalienExplode2.Enabled = false;
            TalienExplode3.Enabled = false;
            TalienExplode4.Enabled = false;
            TintroMusic.Enabled = false;
            TnextLevel.Enabled = false;
            TshipRestart.Enabled = false;
            Talien1bullets.Enabled = false;
            Talien2bullets.Enabled = false;
            Talien3bullets.Enabled = false;
            TalienBoss.Enabled = false;
            TbossBullets.Enabled = false;
            Tminion1move.Enabled = false;
            Tminion2move.Enabled = false;

            finalTotalShots = totalShots;
            finalTotalHits = totalHits;
            finalScore = score;

            frmHighScore highScore = new frmHighScore();
            highScore.ShowDialog();
        }

        private void TnextLevel_Tick(object sender, EventArgs e)
        {
            //sets up the next level
            nextLevelInt += 1;

            if (nextLevelInt == 1)
            {
                //resets alien hits
                alien1hits = 0;
                alien2hits = 0;
                alien3hits = 0;

                //sets alien lefts
                alien1[0].Left = 103;
                alien1[1].Left = 147;
                alien1[2].Left = 191;
                alien1[3].Left = 235;
                alien1[4].Left = 279;
                alien1[5].Left = 323;
                alien1[6].Left = 367;
                alien1[7].Left = 411;
                alien1[8].Left = 455;
                alien1[9].Left = 499;
                alien1[10].Left = 103;
                alien1[11].Left = 147;
                alien1[12].Left = 191;
                alien1[13].Left = 235;
                alien1[14].Left = 279;
                alien1[15].Left = 323;
                alien1[16].Left = 367;
                alien1[17].Left = 411;
                alien1[18].Left = 455;
                alien1[19].Left = 499;

                alien2[0].Left = 147;
                alien2[1].Left = 191;
                alien2[2].Left = 235;
                alien2[3].Left = 279;
                alien2[4].Left = 323;
                alien2[5].Left = 367;
                alien2[6].Left = 411;
                alien2[7].Left = 455;
                alien2[8].Left = 147;
                alien2[9].Left = 191;
                alien2[10].Left = 235;
                alien2[11].Left = 279;
                alien2[12].Left = 323;
                alien2[13].Left = 367;
                alien2[14].Left = 411;
                alien2[15].Left = 455;

                alien3[0].Left = 223;
                alien3[1].Left = 273;
                alien3[2].Left = 323;
                alien3[3].Left = 373;

                //sets alien tops and images
                for (int n = 0; n < alien1.Length; n++)
                {
                    alien1[n].Image = picAlien1v1down.Image;
                    alien1[n].Width = 39;
                    alien1[n].Height = 30;
                    if (n < 10)
                    {
                        alien1[n].Top = -65;
                    }
                    else
                    {
                        alien1[n].Top = -30;
                    }
                }
                for (int m = 0; m < alien2.Length; m++)
                {
                    alien2[m].Image = picAlien2v1down.Image;
                    alien2[m].Width = 39;
                    alien2[m].Height = 30;
                    if (m < 8)
                    {
                        alien2[m].Top = -135;
                    }
                    else
                    {
                        alien2[m].Top = -100;
                    }
                }
                for (int p = 0; p < alien3.Length; p++)
                {
                    alien3[p].Image = picAlien3v1down.Image;
                    alien3hit[p] = 0;
                    alien3[p].Top = -188;
                    alien3[p].Width = 45;
                    alien3[p].Height = 48;
                }
            }
            else if (nextLevelInt == 2)
            {
                //checks if it is not the boss level
                if (level != 5)
                {
                    //displays level 2 label if it is level 2
                    if (level == 2)
                    {
                        lblLevel2.Visible = true;
                        picLevel2.Visible = true;
                        //makes aliens faster
                        alienSpeedSide = 13;
                        alienSpeedDown = 20;
                    }
                    //displays level 3 label if it is level 3
                    else if (level == 3)
                    {
                        lblLevel3.Visible = true;
                        picLevel3.Visible = true;
                        //normal alien speed
                        alienSpeedSide = 10;
                        alienSpeedDown = 15;
                    }
                    //displays level 4 label if it is level 4
                    else if (level == 4)
                    {
                        lblLevel4.Visible = true;
                        picLevel4.Visible = true;
                        //makes aliens faster
                        alienSpeedSide = 13;
                        alienSpeedDown = 20;
                    }
                    //plays next level sound
                    System.Media.SoundPlayer nextLevel = new System.Media.SoundPlayer(@"Resources\nextLevel.wav");
                    nextLevel.Play();
                }
                //shows boss level labels
                else if (level == 5)
                {
                    lblBoss.Visible = true;
                    picLevel1.Visible = false;
                    picLevel2.Visible = false;
                    picLevel3.Visible = false;
                    picLevel4.Visible = false;
                    picLevelBoss.Visible = true;
                    //plays boss level sound
                    System.Media.SoundPlayer bossLevel = new System.Media.SoundPlayer(@"Resources\bossLevel.wav");
                    bossLevel.Play();
                }
            }
            //hides labels if it is not the boss level
            else if (nextLevelInt == 4)
            {
                if (level == 2)
                {
                    lblLevel2.Visible = false;
                }
                else if (level == 3)
                {
                    lblLevel3.Visible = false;
                }
                else if (level == 4)
                {
                    lblLevel4.Visible = false;
                }
            }
            //starts the aliens moving down and sets timer if not boss level
            else if (nextLevelInt == 5)
            {
                if (level != 5)
                {
                    nextLevelInt = 0;
                    TstartPos.Enabled = true;
                    TnextLevel.Enabled = false;
                }
            }
            //hides boss level label
            else if (nextLevelInt == 9)
            {
                lblBoss.Visible = false;
            }
            else if (nextLevelInt == 10)
            {
                //starts boss level and resets timer
                nextLevelInt = 0;
                TalienBoss.Enabled = true;
                TnextLevel.Enabled = false;
            }
        }

        private void TshipRestart_Tick(object sender, EventArgs e)
        {
            //restarts ship after it has been destroyed
            shipRestartInt += 1;

            if (shipRestartInt == 1)
            {
                //if no more lives shows game over label
                if (pic1life.Visible == false && pic2life.Visible == false)
                {
                    lblGameOver.Visible = true;
                }
            }
            else if (shipRestartInt == 2)
            {
                if (lblGameOver.Visible == false)
                {
                    lblReady.Visible = true;
                    if (pic2life.Visible == true)
                    {
                        pic2life.Visible = false;
                    }
                    else if (pic1life.Visible == true)
                    {
                        pic1life.Visible = false;
                    }
                }
            }
            else if (shipRestartInt == 3)
            {
                if (lblGameOver.Visible == false)
                {
                    //resets ship
                    picShip.Left = 298;
                    picShip.Top = 641;
                    picShip.Width = 45;
                    picShip.Height = 48;
                    picShip.Image = picShipImage.Image;
                    picShip.Visible = true;
                    picBullet1.Left = picShip.Left + 18;
                    picBullet1.Top = picShip.Top;
                    picBullet2.Left = picShip.Left + 18;
                    picBullet2.Top = picShip.Top;
                    picBullet1.Visible = true;
                    picBullet2.Visible = true;
                }
            }
            else if (shipRestartInt == 4)
            {
                if (lblGameOver.Visible == false)
                {
                    //allows user to move again
                    moveAbility = true;
                }
            }
            else if (shipRestartInt == 5)
            {
                //closes game if game over
                if (lblGameOver.Visible == true)
                {
                    lblGameOver.Visible = false;
                    shipRestartInt = 0;
                    
                    this.Close();
                }
                //resumes game if user still has lives
                else if (lblGameOver.Visible == false)
                {
                    if (level < 5)
                    {
                        if (alien1hits < 20)
                        {
                            Talien1move.Enabled = true;
                        }
                        if (alien2hits < 16)
                        {
                            Talien2move.Enabled = true;
                        }
                        if (alien3hits < 4)
                        {
                            Talien3move.Enabled = true;
                        }
                    }
                    lblReady.Visible = false;
                    shipRestartInt = 0;
                    TshipRestart.Enabled = false;
                }
            }
        }

        private void Talien1bullets_Tick(object sender, EventArgs e)
        {
            //moves bullets sideways
            if (alienBullet1Direction == 1)
            {
                picAlienBullet1.Left -= 13;
            }
            else if (alienBullet1Direction == 2)
            {
                picAlienBullet1.Left += 13;
            }
            if (alienBullet2Direction == 1)
            {
                picAlienBullet2.Left -= 13;
            }
            else if (alienBullet2Direction == 2)
            {
                picAlienBullet2.Left += 13;
            }
            //moves bullet down
            picAlienBullet1.Top += 24;
            picAlienBullet2.Top += 24;

            //creates collision boxes
            Rectangle shipBox = new Rectangle(picShip.Left, picShip.Top,
                picShip.Width, picShip.Height);
            Rectangle alienBullet1box = new Rectangle(picAlienBullet1.Left,
                picAlienBullet1.Top, picAlienBullet1.Width, picAlienBullet1.Height);
            Rectangle alienBullet2box = new Rectangle(picAlienBullet2.Left,
                picAlienBullet2.Top, picAlienBullet2.Width, picAlienBullet2.Height);
            Boolean hit = false;
            if (alienBullet1box.IntersectsWith(shipBox))
            {
                hit = true;
            }
            else if (alienBullet2box.IntersectsWith(shipBox))
            {
                hit = true;
            }
            if (hit == true)
            {
                TshipExplode.Enabled = true;
                picBullet1.Visible = false;
                picBullet2.Visible = false;
                moveAbility = false;

                picAlienBullet1.Top = -30;
                picAlienBullet2.Top = -30;
                picAlienBullet3.Top = -30;
                picAlienBullet4.Top = -30;
                picAlienBullet5.Top = -30;
                picAlienBullet6.Top = -30;
                Talien1bullets.Enabled = false;
                Talien2bullets.Enabled = false;
                Talien3bullets.Enabled = false;

                //resets alien 1 move timer
                if (alien1move != 20)
                {
                    alien1[alien1move].Left = alien1initialX;
                    alien1[alien1move].Top = alien1initialY;
                    alien1[alien1move].Image = picAlien1v1up.Image;
                }
                alien1move = 20;
                Talien1moveInt = -13;
                Talien1move.Enabled = false;

                //resets alien 2 move timer
                if (alien2move != 20)
                {
                    alien2[alien2move].Left = alien2initialX;
                    alien2[alien2move].Top = alien2initialY;
                    alien2[alien2move].Image = picAlien2v1up.Image;
                }
                alien2move = 20;
                Talien2moveInt = -13;
                Talien2move.Enabled = false;

                //resets alien 3 move timer
                if (alien3move != 5)
                {
                    if (alien3hit[alien3move] == 0)
                    {
                        alien3[alien3move].Image = picAlien3v1up.Image;
                    }
                    else if (alien3hit[alien3move] == 1)
                    {
                        alien3[alien3move].Image = picAlien3v3up.Image;
                    }
                    alien3[alien3move].Left = alien3initialX;
                    alien3[alien3move].Top = alien3initialY;
                }
                alien3move = 5;
                Talien3moveInt = -13;
                Talien3move.Enabled = false;
            }


            if (picAlienBullet1.Top > this.Height + 150)
            {
                //alien1bulletsMoving = false;
                picAlienBullet1.Top = -30;
                picAlienBullet2.Top = -30;
                Talien1bullets.Enabled = false;
            }
        }

        private void Talien2bullets_Tick(object sender, EventArgs e)
        {
            //moves bullets sideways
            if (alienBullet3Direction == 1)
            {
                picAlienBullet3.Left -= 13;
            }
            else if (alienBullet3Direction == 2)
            {
                picAlienBullet3.Left += 13;
            }
            if (alienBullet4Direction == 1)
            {
                picAlienBullet4.Left -= 13;
            }
            else if (alienBullet4Direction == 2)
            {
                picAlienBullet4.Left += 13;
            }
            //moves bullet down
            picAlienBullet3.Top += 24;
            picAlienBullet4.Top += 24;

            //creates collision boxes
            Rectangle shipBox = new Rectangle(picShip.Left, picShip.Top,
                picShip.Width, picShip.Height);
            Rectangle alienBullet3box = new Rectangle(picAlienBullet3.Left,
                picAlienBullet3.Top, picAlienBullet3.Width, picAlienBullet3.Height);
            Rectangle alienBullet4box = new Rectangle(picAlienBullet4.Left,
                picAlienBullet4.Top, picAlienBullet4.Width, picAlienBullet4.Height);
            Boolean hit = false;
            if (alienBullet3box.IntersectsWith(shipBox))
            {
                hit = true;
            }
            else if (alienBullet4box.IntersectsWith(shipBox))
            {
                hit = true;
            }
            if (hit == true)
            {
                TshipExplode.Enabled = true;
                picBullet1.Visible = false;
                picBullet2.Visible = false;
                moveAbility = false;

                picAlienBullet1.Top = -30;
                picAlienBullet2.Top = -30;
                picAlienBullet3.Top = -30;
                picAlienBullet4.Top = -30;
                picAlienBullet5.Top = -30;
                picAlienBullet6.Top = -30;
                Talien1bullets.Enabled = false;
                Talien2bullets.Enabled = false;
                Talien3bullets.Enabled = false;

                //resets alien 1 move timer
                if (alien1move != 20)
                {
                    alien1[alien1move].Left = alien1initialX;
                    alien1[alien1move].Top = alien1initialY;
                    alien1[alien1move].Image = picAlien1v1up.Image;
                }
                alien1move = 20;
                Talien1moveInt = -13;
                Talien1move.Enabled = false;

                //resets alien 2 move timer
                if (alien2move != 20)
                {
                    alien2[alien2move].Left = alien2initialX;
                    alien2[alien2move].Top = alien2initialY;
                    alien2[alien2move].Image = picAlien2v1up.Image;
                }
                alien2move = 20;
                Talien2moveInt = -13;
                Talien2move.Enabled = false;

                //resets alien 3 move timer
                if (alien3move != 5)
                {
                    if (alien3hit[alien3move] == 0)
                    {
                        alien3[alien3move].Image = picAlien3v1up.Image;
                    }
                    else if (alien3hit[alien3move] == 1)
                    {
                        alien3[alien3move].Image = picAlien3v3up.Image;
                    }
                    alien3[alien3move].Left = alien3initialX;
                    alien3[alien3move].Top = alien3initialY;
                }
                alien3move = 5;
                Talien3moveInt = -13;
                Talien3move.Enabled = false;
            }


            if (picAlienBullet3.Top > this.Height + 150)
            {
                //alien1bulletsMoving = false;
                picAlienBullet3.Top = -30;
                picAlienBullet4.Top = -30;
                Talien2bullets.Enabled = false;
            }
        }

        private void Talien3bullets_Tick(object sender, EventArgs e)
        {
            //moves bullets sideways
            if (alienBullet5Direction == 1)
            {
                picAlienBullet5.Left -= 13;
            }
            else if (alienBullet5Direction == 2)
            {
                picAlienBullet5.Left += 13;
            }
            if (alienBullet6Direction == 1)
            {
                picAlienBullet6.Left -= 13;
            }
            else if (alienBullet6Direction == 2)
            {
                picAlienBullet6.Left += 13;
            }
            //moves bullet down
            picAlienBullet5.Top += 24;
            picAlienBullet6.Top += 24;

            //creates collision boxes
            Rectangle shipBox = new Rectangle(picShip.Left, picShip.Top,
                picShip.Width, picShip.Height);
            Rectangle alienBullet5box = new Rectangle(picAlienBullet5.Left,
                picAlienBullet5.Top, picAlienBullet5.Width, picAlienBullet5.Height);
            Rectangle alienBullet6box = new Rectangle(picAlienBullet6.Left,
                picAlienBullet6.Top, picAlienBullet6.Width, picAlienBullet6.Height);
            Boolean hit = false;
            if (alienBullet5box.IntersectsWith(shipBox))
            {
                hit = true;
            }
            else if (alienBullet6box.IntersectsWith(shipBox))
            {
                hit = true;
            }
            if (hit == true)
            {
                TshipExplode.Enabled = true;
                picBullet1.Visible = false;
                picBullet2.Visible = false;
                moveAbility = false;

                picAlienBullet1.Top = -30;
                picAlienBullet2.Top = -30;
                picAlienBullet3.Top = -30;
                picAlienBullet4.Top = -30;
                picAlienBullet5.Top = -30;
                picAlienBullet6.Top = -30;
                Talien1bullets.Enabled = false;
                Talien2bullets.Enabled = false;
                Talien3bullets.Enabled = false;

                //resets alien 1 move timer
                if (alien1move != 20)
                {
                    alien1[alien1move].Left = alien1initialX;
                    alien1[alien1move].Top = alien1initialY;
                    alien1[alien1move].Image = picAlien1v1up.Image;
                }
                alien1move = 20;
                Talien1moveInt = -13;
                Talien1move.Enabled = false;

                //resets alien 2 move timer
                if (alien2move != 20)
                {
                    alien2[alien2move].Left = alien2initialX;
                    alien2[alien2move].Top = alien2initialY;
                    alien2[alien2move].Image = picAlien2v1up.Image;
                }
                alien2move = 20;
                Talien2moveInt = -13;
                Talien2move.Enabled = false;

                //resets alien 3 move timer
                if (alien3move != 5)
                {
                    if (alien3hit[alien3move] == 0)
                    {
                        alien3[alien3move].Image = picAlien3v1up.Image;
                    }
                    else if (alien3hit[alien3move] == 1)
                    {
                        alien3[alien3move].Image = picAlien3v3up.Image;
                    }
                    alien3[alien3move].Left = alien3initialX;
                    alien3[alien3move].Top = alien3initialY;
                }
                alien3move = 5;
                Talien3moveInt = -13;
                Talien3move.Enabled = false;
            }


            if (picAlienBullet5.Top > this.Height + 150)
            {
                //alien1bulletsMoving = false;
                picAlienBullet5.Top = -30;
                picAlienBullet6.Top = -30;
                Talien3bullets.Enabled = false;
            }
        }

        private void TalienBoss_Tick(object sender, EventArgs e)
        {
            bossInt += 1;

            if (bossInt <= 18)
            {
                if (bossInt == 1)
                {
                    lblBossHealthLabel.Visible = true;
                    lblBossHealth.Visible = true;
                }
                else if (bossInt == 3)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (bossInt == 6)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (bossInt == 10)
                {
                    picBoss.Image = picBossV1.Image;
                }
                else if (bossInt == 14)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (bossInt == 18)
                {
                    picBoss.Image = picBossV1.Image;
                }
                picBoss.Top += 20;
            }
            else if (bossInt >= 19 && bossInt < 23)
            {
                if (bossInt == 20 && TshipRestart.Enabled == false 
                    && TshipExplode.Enabled == false)
                {
                    alienBulletDirection[0] = picShip.Left;
                    alienBulletDirection[1] = picShip.Right - 9;
                    alienBulletDirection[2] = picShip.Left - 31;
                    alienBulletDirection[3] = picShip.Right + 22;
                    alienBulletDirection[4] = picShip.Left - 62;
                    alienBulletDirection[5] = picShip.Right + 53;
                    alienBullet[0].Left = picBoss.Left + 135;
                    alienBullet[1].Left = picBoss.Left + 171;
                    alienBullet[2].Left = picBoss.Left + 104;
                    alienBullet[3].Left = picBoss.Left + 202;
                    alienBullet[4].Left = picBoss.Left + 73;
                    alienBullet[5].Left = picBoss.Left + 233;
                    alienBullet[0].Top = picBoss.Bottom - 24;
                    alienBullet[1].Top = picBoss.Bottom - 24;
                    alienBullet[2].Top = picBoss.Bottom - 24;
                    alienBullet[3].Top = picBoss.Bottom - 24;
                    alienBullet[4].Top = picBoss.Bottom - 24;
                    alienBullet[5].Top = picBoss.Bottom - 24;
                    TbossBullets.Enabled = true;
                }

                picBoss.Left -= 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV1.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV3.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v3down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v3down.Image;
                    }
                }
            }
            else if (bossInt >= 23 && bossInt < 27)
            {
                picBoss.Left -= 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV4.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v4down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v4down.Image;
                    }
                }
            }
            else if (bossInt >= 27 && bossInt < 31)
            {
                picBoss.Left -= 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV1.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV3.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v3down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v3down.Image;
                    }
                }
            }
            else if (bossInt >= 31 && bossInt < 35)
            {
                picBoss.Left -= 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV4.Image;
                }

                if (bossInt == 34 && TshipRestart.Enabled == false 
                    && TshipExplode.Enabled == false)
                {
                    picMinion1.Left = 30;
                    picMinion1.Top = -48;
                    picMinion1.Width = 45;
                    picMinion1.Height = 48;
                    bossMinion1hits = 0;
                    minion1explodeInt = 0;
                    Tminion1move.Interval = 100;
                    Tminion1move.Enabled = true;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v4down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v4down.Image;
                    }
                }
            }
            else if (bossInt >= 35 && bossInt < 39)
            {
                picBoss.Left += 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV1.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV3.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v3down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v3down.Image;
                    }
                }
            }
            else if (bossInt >= 39 && bossInt < 43)
            {
                picBoss.Left += 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV4.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v4down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v4down.Image;
                    }
                }
            }
            else if (bossInt >= 43 && bossInt < 47)
            {
                picBoss.Left += 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV1.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV3.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v3down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v3down.Image;
                    }
                }
            }
            else if (bossInt >= 47 && bossInt < 51)
            {
                picBoss.Left += 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV4.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v4down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v4down.Image;
                    }
                }
            }
            else if (bossInt >= 51 && bossInt < 55)
            {
                if (bossInt == 52 && TshipRestart.Enabled == false 
                    && TshipExplode.Enabled == false)
                {
                    alienBulletDirection[0] = picShip.Left;
                    alienBulletDirection[1] = picShip.Right - 9;
                    alienBulletDirection[2] = picShip.Left - 31;
                    alienBulletDirection[3] = picShip.Right + 22;
                    alienBulletDirection[4] = picShip.Left - 62;
                    alienBulletDirection[5] = picShip.Right + 53;
                    alienBullet[0].Left = picBoss.Left + 135;
                    alienBullet[1].Left = picBoss.Left + 171;
                    alienBullet[2].Left = picBoss.Left + 104;
                    alienBullet[3].Left = picBoss.Left + 202;
                    alienBullet[4].Left = picBoss.Left + 73;
                    alienBullet[5].Left = picBoss.Left + 233;
                    alienBullet[0].Top = picBoss.Bottom - 24;
                    alienBullet[1].Top = picBoss.Bottom - 24;
                    alienBullet[2].Top = picBoss.Bottom - 24;
                    alienBullet[3].Top = picBoss.Bottom - 24;
                    alienBullet[4].Top = picBoss.Bottom - 24;
                    alienBullet[5].Top = picBoss.Bottom - 24;
                    TbossBullets.Enabled = true;
                }
                picBoss.Left += 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV1.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV3.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v3down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v3down.Image;
                    }
                }
            }
            else if (bossInt >= 55 && bossInt < 59)
            {
                picBoss.Left += 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV4.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v4down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v4down.Image;
                    }
                }
            }
            else if (bossInt >= 59 && bossInt < 63)
            {
                picBoss.Left += 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV1.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV3.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v3down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v3down.Image;
                    }
                }
            }
            else if (bossInt >= 63 && bossInt < 67)
            {
                picBoss.Left += 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV4.Image;
                }

                if (bossInt == 66 && TshipRestart.Enabled == false 
                    && TshipExplode.Enabled == false)
                {
                    picMinion2.Left = this.Width - 75;
                    picMinion2.Top = -48;
                    picMinion2.Width = 45;
                    picMinion2.Height = 48;
                    bossMinion2hits = 0;
                    minion2explodeInt = 0;
                    Tminion2move.Interval = 100;
                    Tminion2move.Enabled = true;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v4down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v4down.Image;
                    }
                }
            }
            else if (bossInt >= 67 && bossInt < 71)
            {
                picBoss.Left -= 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV1.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV3.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v3down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v3down.Image;
                    }
                }
            }
            else if (bossInt >= 71 && bossInt < 75)
            {
                picBoss.Left -= 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV4.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v4down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v4down.Image;
                    }
                }
            }
            else if (bossInt >= 75 && bossInt < 79)
            {
                picBoss.Left -= 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV1.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV3.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v3down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v1down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v3down.Image;
                    }
                }
            }
            else if (bossInt >= 79 && bossInt < 82)
            {
                picBoss.Left -= 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV4.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v4down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v4down.Image;
                    }
                }
            }
            else if (bossInt == 82)
            {
                picBoss.Left -= 3;
                if (lblBossHealth.Width > 320)
                {
                    picBoss.Image = picBossV2.Image;
                }
                else if (lblBossHealth.Width <= 320 && lblBossHealth.Width > 0)
                {
                    picBoss.Image = picBossV4.Image;
                }

                if (TshipExplode.Enabled == false)
                {
                    if (bossMinion1hits == 0)
                    {
                        picMinion1.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion1hits == 1)
                    {
                        picMinion1.Image = picAlien3v4down.Image;
                    }
                    if (bossMinion2hits == 0)
                    {
                        picMinion2.Image = picAlien3v2down.Image;
                    }
                    else if (bossMinion2hits == 1)
                    {
                        picMinion2.Image = picAlien3v4down.Image;
                    }
                }

                bossInt = 18;
            }
            else if (bossInt == 100)
            {
                TalienBoss.Interval = 400;
                Tminion1move.Enabled = false;
                picMinion1.Top = -100;
                Tminion2move.Enabled = false;
                picMinion2.Top = -100;
                for (int n = 0; n < alienBullet.Length; n++)
                {
                    TbossBullets.Enabled = false;
                    alienBullet[n].Top = -30;
                }
                picBullet1.Top = -100;
                picBullet2.Top = -100;

                moveAbility = false;
                score += bossScore * multiplyer;
                lblScore.Text = score.ToString();
                if (score > highScore)
                {
                    lblHighscore.Text = score.ToString();
                }

                picBoss.Image = picBossExplode1.Image;
                picBoss.Width = 325;
                picBoss.Height = 336;
                alien3hit2sound.Ctlcontrols.stop();
                alien3hit2sound.Ctlcontrols.play();
                bossInt += 1;
            }
            else if (bossInt == 101)
            {
                picBoss.Image = picBossExplode2.Image;
                alien3hit2sound.Ctlcontrols.stop();
                alien3hit2sound.Ctlcontrols.play();
            }
            else if (bossInt == 102)
            {
                picBoss.Image = picBossExplode3.Image;
                alien3hit2sound.Ctlcontrols.stop();
                alien3hit2sound.Ctlcontrols.play();
            }
            else if (bossInt == 103)
            {
                picBoss.Image = picBossExplode4.Image;
                alien3hit2sound.Ctlcontrols.stop();
                alien3hit2sound.Ctlcontrols.play();
            }
            else if (bossInt == 104)
            {
                picBoss.Image = picBossExplode5.Image;
                alien3hit2sound.Ctlcontrols.stop();
                alien3hit2sound.Ctlcontrols.play();
            }
            else if (bossInt == 105)
            {
                picBoss.Width = 0;
                picBoss.Height = 0;
            }
            else if (bossInt == 106)
            {
                TalienBoss.Interval = 2500;
                lblBoss.Text = "Congratulations!";
                lblBoss.Visible = true;
                lblBossHealthLabel.Visible = false;
            }
            else if (bossInt == 107)
            {
                lblBoss.Text = "You Win!";
            }
            else if (bossInt == 108)
            {
                this.Close();
            }
        }

        private void TbossBullets_Tick(object sender, EventArgs e)
        {
            for (int n = 0; n < alienBullet.Length; n++)
            {
                if (alienBulletDirection[n] - alienBullet[n].Left > 9)
                {
                    alienBullet[n].Left += 17;
                }
                else if (alienBulletDirection[n] - alienBullet[n].Left < -9)
                {
                    alienBullet[n].Left -= 17;
                }
                alienBullet[n].Top += 30;
                if (alienBullet[n].Top > this.Height + 24)
                {
                    TbossBullets.Enabled = false;
                    alienBullet[n].Top = -30;
                }

                Rectangle shipBox = new Rectangle(picShip.Left, picShip.Top,
                picShip.Width, picShip.Height);
                Rectangle bulletBox = new Rectangle(alienBullet[n].Left,
                    alienBullet[n].Top, alienBullet[n].Width, alienBullet[n].Height);
                if (shipBox.IntersectsWith(bulletBox))
                {
                    {
                        TshipExplode.Enabled = true;
                        picBullet1.Visible = false;
                        picBullet2.Visible = false;
                        moveAbility = false;

                        picMinion1.Top = -100;
                        Tminion1move.Enabled = false;
                        picMinion2.Top = -100;
                        Tminion2move.Enabled = false;

                        for (int i = 0; i < alienBullet.Length; i++)
                        {
                            TbossBullets.Enabled = false;
                            alienBullet[i].Top = -30;
                        }
                    }
                }
            }
        }

        private void Tminion1move_Tick(object sender, EventArgs e)
        {
            if (minion1explodeInt == 0)
            {
                picMinion1.Top += 20;
                if (picMinion1.Bottom >= 300)
                {
                    if (picMinion1.Left - picShip.Left >= 9)
                    {
                        picMinion1.Left -= 15;
                    }
                    else if (picMinion1.Left - picShip.Left <= -9)
                    {
                        picMinion1.Left += 15;
                    }

                    Rectangle shipBox = new Rectangle(picShip.Left, picShip.Top,
                        picShip.Width, picShip.Height);
                    Rectangle minion1box = new Rectangle(picMinion1.Left, picMinion1.Top,
                        picMinion1.Width, picMinion1.Height);
                    //finds if minion hits the ship
                    if (minion1box.IntersectsWith(shipBox) && picMinion1.Width != 93
                        && picMinion1.Width != 0)
                    {
                        TshipExplode.Enabled = true;
                        picBullet1.Visible = false;
                        picBullet2.Visible = false;
                        moveAbility = false;

                        minion1explodeInt += 1;

                        picMinion2.Top = -100;
                        Tminion2move.Enabled = false;

                        for (int n = 0; n < alienBullet.Length; n++)
                        {
                            TbossBullets.Enabled = false;
                            alienBullet[n].Top = -30;
                        }
                    }
                }
            }
            else if (minion1explodeInt == 1)
            {
                Tminion1move.Interval = 50;
                picMinion1.SendToBack();
                picMinion1.Image = picAlienExplode1.Image;
                picMinion1.Left -= 24;
                picMinion1.Top -= 24;
                picMinion1.Width = 93;
                picMinion1.Height = 96;
                alien3hit2sound.Ctlcontrols.stop();
                alien3hit2sound.Ctlcontrols.play();
                minion1explodeInt += 1;
            }
            else if (minion1explodeInt == 2)
            {
                picMinion1.Image = picAlienExplode2.Image;
                minion1explodeInt += 1;
            }
            else if (minion1explodeInt == 3)
            {
                picMinion1.Image = picAlienExplode3.Image;
                minion1explodeInt += 1;
            }
            else if (minion1explodeInt == 4)
            {
                picMinion1.Image = picAlienExplode4.Image;
                minion1explodeInt += 1;
            }
            else if (minion1explodeInt == 5)
            {
                picMinion1.Image = picAlienExplode5.Image;
                minion1explodeInt += 1;
            }
            else if (minion1explodeInt == 6)
            {
                picMinion1.Top = -100;
                Tminion1move.Enabled = false;
            }
        }

        private void Tminion2move_Tick(object sender, EventArgs e)
        {
            if (minion2explodeInt == 0)
            {
                picMinion2.Top += 20;
                if (picMinion2.Bottom >= 300)
                {
                    if (picMinion2.Left - picShip.Left >= 9)
                    {
                        picMinion2.Left -= 15;
                    }
                    else if (picMinion2.Left - picShip.Left <= -9)
                    {
                        picMinion2.Left += 15;
                    }
                }
                Rectangle shipBox = new Rectangle(picShip.Left, picShip.Top,
                        picShip.Width, picShip.Height);
                Rectangle minion2box = new Rectangle(picMinion2.Left, picMinion2.Top,
                    picMinion2.Width, picMinion2.Height);
                //finds if minion hits the ship
                if (minion2box.IntersectsWith(shipBox) && picMinion2.Width != 93
                    && picMinion2.Width != 0)
                {
                    TshipExplode.Enabled = true;
                    picBullet1.Visible = false;
                    picBullet2.Visible = false;
                    moveAbility = false;

                    minion2explodeInt += 1;

                    picMinion1.Top = -100;
                    Tminion1move.Enabled = false;

                    for (int n = 0; n < alienBullet.Length; n++)
                    {
                        TbossBullets.Enabled = false;
                        alienBullet[n].Top = -30;
                    }
                }
            }
            else if (minion2explodeInt == 1)
            {
                Tminion2move.Interval = 50;
                picMinion2.SendToBack();
                picMinion2.Image = picAlienExplode1.Image;
                picMinion2.Left -= 24;
                picMinion2.Top -= 24;
                picMinion2.Width = 93;
                picMinion2.Height = 96;
                alien3hit2sound.Ctlcontrols.stop();
                alien3hit2sound.Ctlcontrols.play();
                minion2explodeInt += 1;
            }
            else if (minion2explodeInt == 2)
            {
                picMinion2.Image = picAlienExplode2.Image;
                minion2explodeInt += 1;
            }
            else if (minion2explodeInt == 3)
            {
                picMinion2.Image = picAlienExplode3.Image;
                minion2explodeInt += 1;
            }
            else if (minion2explodeInt == 4)
            {
                picMinion2.Image = picAlienExplode4.Image;
                minion2explodeInt += 1;
            }
            else if (minion2explodeInt == 5)
            {
                picMinion2.Image = picAlienExplode5.Image;
                minion2explodeInt += 1;
            }
            else if (minion2explodeInt == 6)
            {
                picMinion2.Top = -100;
                Tminion2move.Enabled = false;
            }
        }
    }
}

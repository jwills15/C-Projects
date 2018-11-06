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
    public partial class frmHighScore : Form
    {
        int userScore = 0;
        string userName = "";
        int userNameTracker = 0;
        decimal totalHits = 0;
        decimal totalShots = 0;
        decimal ratio = 0;
        int highScore1 = 0;
        string highScore1user = "";
        int highScore2 = 0;
        string highScore2user = "";
        int highScore3 = 0;
        string highScore3user = "";
        int highScore4 = 0;
        string highScore4user = "";
        int highScore5 = 0;
        string highScore5user = "";
        Boolean typeAbility = false;
        Boolean beatScore = false;

        public frmHighScore()
        {
            InitializeComponent();
        }

        private void frmHighScore_Load(object sender, EventArgs e)
        {
            //gets final scores from game form
            userScore = frmGame.finalScore;
            totalHits = frmGame.finalTotalHits;
            totalShots = frmGame.finalTotalShots;

            //finds ratio
            try
            {
                ratio = totalHits/totalShots;
            }
            catch
            {
                ratio = 0;
            }

            //read high scores from text file
            string[] allLines = File.ReadAllLines(@"Resources\highScores.txt");
            highScore1 = int.Parse(allLines[2]);
            highScore2 = int.Parse(allLines[3]);
            highScore3 = int.Parse(allLines[4]);
            highScore4 = int.Parse(allLines[5]);
            highScore5 = int.Parse(allLines[6]);
            highScore1user = allLines[7];
            highScore2user = allLines[8];
            highScore3user = allLines[9];
            highScore4user = allLines[10];
            highScore5user = allLines[11];

            //uses custom galaga font
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Resources\emulogic.ttf");
            lblResults.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblShotsLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblShots.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHitsLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHits.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblRatioLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblRatio.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblBeat.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblEnterInitials.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblUserScoreLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblUserScore.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblUserNameLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblUserName.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblTop5.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighScoreLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighNameLabel.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lbl1st.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lbl2nd.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lbl3rd.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lbl4th.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lbl5th.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighScore1.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighScore2.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighScore3.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighScore4.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighScore5.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighName1.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighName2.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighName3.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighName4.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHighName5.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

            //displays user results
            lblShots.Text = totalShots.ToString();
            lblHits.Text = totalHits.ToString();
            lblRatio.Text = ratio.ToString("P");

            //puts labels in correct positions
            lblResults.Left = 210;
            lblResults.Top = 230;
            lblShotsLabel.Left = 33;
            lblShotsLabel.Top = 311;
            lblShots.Left = 396;
            lblShots.Top = 311;
            lblHitsLabel.Left = 33;
            lblHitsLabel.Top = 366;
            lblHits.Left = 396;
            lblHits.Top = 366;
            lblRatioLabel.Left = 33;
            lblRatioLabel.Top = 431;
            lblRatio.Left = 396;
            lblRatio.Top = 431;

            if (userScore > highScore1)
            {
                beatScore = true;
                lblBeat.Text = "You beat the #1 high score!";
                highScore5 = highScore4;
                highScore4 = highScore3;
                highScore3 = highScore2;
                highScore2 = highScore1;
                highScore1 = userScore;

                highScore5user = highScore4user;
                highScore4user = highScore3user;
                highScore3user = highScore2user;
                highScore2user = highScore1user;
                highScore1user = userName;
            }
            else if (userScore > highScore2)
            {
                beatScore = true;
                lblBeat.Text = "You beat the #2 high score!";
                highScore5 = highScore4;
                highScore4 = highScore3;
                highScore3 = highScore2;
                highScore2 = userScore;

                highScore5user = highScore4user;
                highScore4user = highScore3user;
                highScore3user = highScore2user;
                highScore2user = userName;
            }
            else if (userScore > highScore3)
            {
                beatScore = true;
                lblBeat.Text = "You beat the #3 high score!";
                highScore5 = highScore4;
                highScore4 = highScore3;
                highScore3 = userScore;

                highScore5user = highScore4user;
                highScore4user = highScore3user;
                highScore3user = userName;
            }
            else if (userScore > highScore4)
            {
                beatScore = true;
                lblBeat.Text = "You beat the #4 high score!";
                highScore5 = highScore4;
                highScore4 = userScore;

                highScore5user = highScore4user;
                highScore4user = userName;
            }
            else if (userScore > highScore5)
            {
                beatScore = true;
                lblBeat.Text = "You beat the #5 high score!";
                highScore5 = userScore;
                highScore5user = userName;
            }
            lblHighScore1.Text = highScore1.ToString();
            lblHighScore2.Text = highScore2.ToString();
            lblHighScore3.Text = highScore3.ToString();
            lblHighScore4.Text = highScore4.ToString();
            lblHighScore5.Text = highScore5.ToString();

            lblHighName1.Text = highScore1user;
            lblHighName2.Text = highScore2user;
            lblHighName3.Text = highScore3user;
            lblHighName4.Text = highScore4user;
            lblHighName5.Text = highScore5user;

            lblUserScore.Text = userScore.ToString();
            lblUserName.Text = userName;
        }

        private void Tdelay_Tick(object sender, EventArgs e)
        {
            if (lblResults.Visible == true)
            {
                lblResults.Visible = false;
                lblShotsLabel.Visible = false;
                lblShots.Visible = false;
                lblHitsLabel.Visible = false;
                lblHits.Visible = false;
                lblRatioLabel.Visible = false;
                lblRatio.Visible = false;

                if (beatScore == true)
                {
                    lblBeat.Visible = true;
                    lblEnterInitials.Visible = true;
                }
                lblUserScoreLabel.Visible = true;
                lblUserScore.Visible = true;
                lblUserNameLabel.Visible = true;
                lblUserName.Visible = true;
                lblTop5.Visible = true;
                lblHighScoreLabel.Visible = true;
                lblHighNameLabel.Visible = true;
                lbl1st.Visible = true;
                lbl2nd.Visible = true;
                lbl3rd.Visible = true;
                lbl4th.Visible = true;
                lbl5th.Visible = true;
                lblHighScore1.Visible = true;
                lblHighScore2.Visible = true;
                lblHighScore3.Visible = true;
                lblHighScore4.Visible = true;
                lblHighScore5.Visible = true;
                lblHighName1.Visible = true;
                lblHighName2.Visible = true;
                lblHighName3.Visible = true;
                lblHighName4.Visible = true;
                lblHighName5.Visible = true;
            }
            else if (lblTop5.Visible == true)
            {
                lblBeat.Visible = false;
                lblEnterInitials.Visible = false;
                lblUserScoreLabel.Visible = false;
                lblUserScore.Visible = false;
                lblUserNameLabel.Visible = false;
                lblUserName.Visible = false;
                lblTop5.Visible = false;
                lblHighScoreLabel.Visible = false;
                lblHighNameLabel.Visible = false;
                lbl1st.Visible = false;
                lbl2nd.Visible = false;
                lbl3rd.Visible = false;
                lbl4th.Visible = false;
                lbl5th.Visible = false;
                lblHighScore1.Visible = false;
                lblHighScore2.Visible = false;
                lblHighScore3.Visible = false;
                lblHighScore4.Visible = false;
                lblHighScore5.Visible = false;
                lblHighName1.Visible = false;
                lblHighName2.Visible = false;
                lblHighName3.Visible = false;
                lblHighName4.Visible = false;
                lblHighName5.Visible = false;
                this.Close();
            }

            if (beatScore == true && lblTop5.Visible == true)
            {
                Tdelay.Enabled = false;
                typeAbility = true;
                if (userScore == highScore1)
                {
                    System.Media.SoundPlayer nameEntry1 = new System.Media.SoundPlayer(@"Resources\nameEntry1.wav");
                    nameEntry1.Play();
                }
                else
                {
                    System.Media.SoundPlayer nameEntry2 = new System.Media.SoundPlayer(@"Resources\nameEntry2-5.wav");
                    nameEntry2.Play();
                }
            }
        }

        private void frmHighScore_KeyDown(object sender, KeyEventArgs e)
        {
            if (typeAbility == true)
            {
                //finds which key is pressed
                int whichKey = e.KeyValue;

                //A
                if (whichKey == 65)
                {
                    userName += "A";
                    userNameTracker += 1;
                }
                //B
                else if (whichKey == 66)
                {
                    userName += "B";
                    userNameTracker += 1;
                }
                //C
                else if (whichKey == 67)
                {
                    userName += "C";
                    userNameTracker += 1;
                }
                //D
                else if (whichKey == 68)
                {
                    userName += "D";
                    userNameTracker += 1;
                }
                //E
                else if (whichKey == 69)
                {
                    userName += "E";
                    userNameTracker += 1;
                }
                //F
                else if (whichKey == 70)
                {
                    userName += "F";
                    userNameTracker += 1;
                }
                //G
                else if (whichKey == 71)
                {
                    userName += "G";
                    userNameTracker += 1;
                }
                //H
                else if (whichKey == 72)
                {
                    userName += "H";
                    userNameTracker += 1;
                }
                //I
                else if (whichKey == 73)
                {
                    userName += "I";
                    userNameTracker += 1;
                }
                //J
                else if (whichKey == 74)
                {
                    userName += "J";
                    userNameTracker += 1;
                }
                //K
                else if (whichKey == 75)
                {
                    userName += "K";
                    userNameTracker += 1;
                }
                //L
                else if (whichKey == 76)
                {
                    userName += "L";
                    userNameTracker += 1;
                }
                //M
                else if (whichKey == 77)
                {
                    userName += "M";
                    userNameTracker += 1;
                }
                //N
                else if (whichKey == 78)
                {
                    userName += "N";
                    userNameTracker += 1;
                }
                //O
                else if (whichKey == 79)
                {
                    userName += "O";
                    userNameTracker += 1;
                }
                //P
                else if (whichKey == 80)
                {
                    userName += "P";
                    userNameTracker += 1;
                }
                //Q
                else if (whichKey == 81)
                {
                    userName += "Q";
                    userNameTracker += 1;
                }
                //R
                else if (whichKey == 82)
                {
                    userName += "R";
                    userNameTracker += 1;
                }
                //S
                else if (whichKey == 83)
                {
                    userName += "S";
                    userNameTracker += 1;
                }
                //T
                else if (whichKey == 84)
                {
                    userName += "T";
                    userNameTracker += 1;
                }
                //U
                else if (whichKey == 85)
                {
                    userName += "U";
                    userNameTracker += 1;
                }
                //V
                else if (whichKey == 86)
                {
                    userName += "V";
                    userNameTracker += 1;
                }
                //W
                else if (whichKey == 87)
                {
                    userName += "W";
                    userNameTracker += 1;
                }
                //X
                else if (whichKey == 88)
                {
                    userName += "X";
                    userNameTracker += 1;
                }
                //Y
                else if (whichKey == 89)
                {
                    userName += "Y";
                    userNameTracker += 1;
                }
                //Z
                else if (whichKey == 90)
                {
                    userName += "Z";
                    userNameTracker += 1;
                }
                //.
                else if (whichKey == 190)
                {
                    userName += ".";
                    userNameTracker += 1;
                }
                lblUserName.Text = userName;

                if (userNameTracker == 3)
                {
                    typeAbility = false;
                    if (lblHighName1.Text == "")
                    {
                        lblHighName1.Text = userName;
                        highScore1user = userName;
                    }
                    else if (lblHighName2.Text == "")
                    {
                        lblHighName2.Text = userName;
                        highScore2user = userName;
                    }
                    else if (lblHighName3.Text == "")
                    {
                        lblHighName3.Text = userName;
                        highScore3user = userName;
                    }
                    else if (lblHighName4.Text == "")
                    {
                        lblHighName4.Text = userName;
                        highScore4user = userName;
                    }
                    else if (lblHighName5.Text == "")
                    {
                        lblHighName5.Text = userName;
                        highScore5user = userName;
                    }
                    Tdelay.Interval = 4000;
                    Tdelay.Enabled = true;
                }
            }
        }

        private void frmHighScore_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Media.SoundPlayer stop = new System.Media.SoundPlayer();
            stop.Stop();
            string[] allLines = File.ReadAllLines(@"Resources\highScores.txt");
            allLines[2] = highScore1.ToString();
            allLines[3] = highScore2.ToString();
            allLines[4] = highScore3.ToString();
            allLines[5] = highScore4.ToString();
            allLines[6] = highScore5.ToString();
            allLines[7] = highScore1user;
            allLines[8] = highScore2user;
            allLines[9] = highScore3user;
            allLines[10] = highScore4user;
            allLines[11] = highScore5user;
            File.WriteAllLines(@"Resources\highScores.txt", allLines);
        }
    }
}

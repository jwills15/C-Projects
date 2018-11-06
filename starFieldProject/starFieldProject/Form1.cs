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
 * Date: 2/26/15
 * Project Description: This is a project that simulates going through a star
 * field. The stars grow larger and move towards the corners to make it seem
 * like the user is going past them. */

namespace starFieldNotes
{
    public partial class frmMain : Form
    {
        //declare our array to hold the stars
        Label[] stars = new Label[28];
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //assign each star a position
            stars[0] = lblStar0;
            stars[1] = lblStar1;
            stars[2] = lblStar2;
            stars[3] = lblStar3;
            stars[4] = lblStar4;
            stars[5] = lblStar5;
            stars[6] = lblStar6;
            stars[7] = lblStar7;
            stars[8] = lblStar8;
            stars[9] = lblStar9;
            stars[10] = lblStar10;
            stars[11] = lblStar11;
            stars[12] = lblStar12;
            stars[13] = lblStar13;
            stars[14] = lblStar14;
            stars[15] = lblStar15;
            stars[16] = lblStar16;
            stars[17] = lblStar17;
            stars[18] = lblStar18;
            stars[19] = lblStar19;
            stars[20] = lblStar20;
            stars[21] = lblStar21;
            stars[22] = lblStar22;
            stars[23] = lblStar23;
            stars[24] = lblStar24;
            stars[25] = lblStar25;
            stars[26] = lblStar26;
            stars[27] = lblStar27;

            for (int n = 0; n < stars.Length; n++)
            {
                int randomX = r.Next(0, this.Width);
                int randomY = r.Next(0, this.Height);
                stars[n].Left = randomX;
                stars[n].Top = randomY;
                int thewidth = r.Next(1, 10);
                stars[n].Width = thewidth;
                stars[n].Height = thewidth;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //change the size of the stars
            for (int i = 0; i < stars.Length; i++)
            {
                if (stars[i].Width < 15)
                {
                    stars[i].Width += 1;
                    stars[i].Height += 1;
                }
                if (stars[i].Left < 0)
                {
                    int randomX = r.Next(0, this.Width);
                    int randomY = r.Next(0, this.Height);
                    stars[i].Left = randomX;
                    stars[i].Top = randomY;
                    stars[i].Height = 1;
                    stars[i].Width = 1;
                }
                else if (stars[i].Left > this.Width)
                {
                    int randomX = r.Next(0, this.Width);
                    int randomY = r.Next(0, this.Height);
                    stars[i].Left = randomX;
                    stars[i].Top = randomY;
                    stars[i].Height = 1;
                    stars[i].Width = 1;
                }
                if (stars[i].Left <= (this.Width / 2) && stars[i].Top <= (this.Height / 2))
                {
                    stars[i].Left -= 4;
                    stars[i].Top -= 4;
                }
                else if (stars[i].Left > (this.Width / 2) && stars[i].Top < (this.Height / 2))
                {
                    stars[i].Left += 4;
                    stars[i].Top -= 4;
                }
                else if (stars[i].Left < (this.Width / 2) && stars[i].Top > (this.Height / 2))
                {
                    stars[i].Left -= 4;
                    stars[i].Top += 4;
                }
                else if (stars[i].Left >= (this.Width / 2) && stars[i].Top >= (this.Height / 2))
                {
                    stars[i].Left += 4;
                    stars[i].Top += 4;
                }
            }
        }
    }
}

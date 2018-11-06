using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays
{
    public partial class frmMain : Form
    {
        //declare our global variables
        //declare an array to organize our picture boxes
        //declare a 2D array
        PictureBox[,] theTank = new PictureBox[3, 4];
        int fishRow = 0;
        int fishCol = 0;
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);

        //create a booleen switch
        Boolean onOff = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //this will randomly move the fish to some picture box
            theTank[fishRow, fishCol].Image = null;
            fishCol = r.Next(0, 4);
            fishRow = r.Next(0, 3);
            theTank[fishRow, fishCol].Image = picFish.Image;

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //this code runs one time at start up

            //row 1
            theTank[0, 0] = picBox1;
            theTank[0, 1] = picBox2;
            theTank[0, 2] = picBox3;
            theTank[0, 3] = picBox4;
            //row 2
            theTank[1, 0] = picBox5;
            theTank[1, 1] = picBox6;
            theTank[1, 2] = picBox7;
            theTank[1, 3] = picBox8;
            //row 3
            theTank[2, 0] = picBox9;
            theTank[2, 1] = picBox10;
            theTank[2, 2] = picBox11;
            theTank[2, 3] = picBox12;

            int randomIntegerCol = r.Next(0, 4);
            int randomIntegerRow = r.Next(0, 3);
            theTank[randomIntegerRow, randomIntegerCol].Image = picFish.Image;
            fishRow = randomIntegerRow;
            fishCol = randomIntegerCol;

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            //this moves the fish automatically
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this the move code
            btnMove_Click(sender, e);
        }
    }
}

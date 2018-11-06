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
 * Date: 2/11/15
 * Project Description: This is a project that plays the game tic-tac-toe.
 * Users take turns playing against each other as they try to get three in
 * a row. When a user wins or the game ends in a tie, the user has the option
 * to play again or close the program. */

namespace TTTproject
{
    public partial class frmMain : Form
    {
        Boolean Xturn = true;

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            picBox1.Image = letter(picBox1).Image;
            Boolean end = Xwin();
            Boolean finish = Owin();
            Boolean tie = draw();
            DialogResult resultAnswer = DialogResult;
            if (end == true)
            {
                resultAnswer = MessageBox.Show("X Wins!" + "\n" + "\n" + "Play again?", "Congratulations!", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            else if (finish == true)
            {
                resultAnswer = MessageBox.Show("O Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (tie == true)
            {
                resultAnswer = MessageBox.Show("It's a tie!" + "\n" + "\n" + "Play again?", "Good Game!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                picBox1.Image = null;
                picBox2.Image = null;
                picBox3.Image = null;
                picBox4.Image = null;
                picBox5.Image = null;
                picBox6.Image = null;
                picBox7.Image = null;
                picBox8.Image = null;
                picBox9.Image = null;
                Xturn = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        private void picBox2_Click(object sender, EventArgs e)
        {
            picBox2.Image = letter(picBox2).Image;
            Boolean end = Xwin();
            Boolean finish = Owin();
            Boolean tie = draw();
            DialogResult resultAnswer = DialogResult;
            if (end == true)
            {
                resultAnswer = MessageBox.Show("X Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            else if (finish == true)
            {
                resultAnswer = MessageBox.Show("O Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (tie == true)
            {
                resultAnswer = MessageBox.Show("It's a tie!" + "\n" + "\n" + "Play again?", "Good Game!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                picBox1.Image = null;
                picBox2.Image = null;
                picBox3.Image = null;
                picBox4.Image = null;
                picBox5.Image = null;
                picBox6.Image = null;
                picBox7.Image = null;
                picBox8.Image = null;
                picBox9.Image = null;
                Xturn = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        private void picBox3_Click(object sender, EventArgs e)
        {
            picBox3.Image = letter(picBox3).Image;
            Boolean end = Xwin();
            Boolean finish = Owin();
            Boolean tie = draw();
            DialogResult resultAnswer = DialogResult;
            if (end == true)
            {
                resultAnswer = MessageBox.Show("X Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            else if (finish == true)
            {
                resultAnswer = MessageBox.Show("O Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (tie == true)
            {
                resultAnswer = MessageBox.Show("It's a tie!" + "\n" + "\n" + "Play again?", "Good Game!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                picBox1.Image = null;
                picBox2.Image = null;
                picBox3.Image = null;
                picBox4.Image = null;
                picBox5.Image = null;
                picBox6.Image = null;
                picBox7.Image = null;
                picBox8.Image = null;
                picBox9.Image = null;
                Xturn = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        private void picBox4_Click(object sender, EventArgs e)
        {
            picBox4.Image = letter(picBox4).Image;
            Boolean end = Xwin();
            Boolean finish = Owin();
            Boolean tie = draw();
            DialogResult resultAnswer = DialogResult;
            if (end == true)
            {
                resultAnswer = MessageBox.Show("X Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            else if (finish == true)
            {
                resultAnswer = MessageBox.Show("O Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (tie == true)
            {
                resultAnswer = MessageBox.Show("It's a tie!" + "\n" + "\n" + "Play again?", "Good Game!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                picBox1.Image = null;
                picBox2.Image = null;
                picBox3.Image = null;
                picBox4.Image = null;
                picBox5.Image = null;
                picBox6.Image = null;
                picBox7.Image = null;
                picBox8.Image = null;
                picBox9.Image = null;
                Xturn = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        private void picBox5_Click(object sender, EventArgs e)
        {
            picBox5.Image = letter(picBox5).Image;
            Boolean end = Xwin();
            Boolean finish = Owin();
            Boolean tie = draw();
            DialogResult resultAnswer = DialogResult;
            if (end == true)
            {
                resultAnswer = MessageBox.Show("X Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            else if (finish == true)
            {
                resultAnswer = MessageBox.Show("O Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (tie == true)
            {
                resultAnswer = MessageBox.Show("It's a tie!" + "\n" + "\n" + "Play again?", "Good Game!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                picBox1.Image = null;
                picBox2.Image = null;
                picBox3.Image = null;
                picBox4.Image = null;
                picBox5.Image = null;
                picBox6.Image = null;
                picBox7.Image = null;
                picBox8.Image = null;
                picBox9.Image = null;
                Xturn = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        private void picBox6_Click(object sender, EventArgs e)
        {
            picBox6.Image = letter(picBox6).Image;
            Boolean end = Xwin();
            Boolean finish = Owin();
            Boolean tie = draw();
            DialogResult resultAnswer = DialogResult;
            if (end == true)
            {
                resultAnswer = MessageBox.Show("X Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            else if (finish == true)
            {
                resultAnswer = MessageBox.Show("O Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (tie == true)
            {
                resultAnswer = MessageBox.Show("It's a tie!" + "\n" + "\n" + "Play again?", "Good Game!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                picBox1.Image = null;
                picBox2.Image = null;
                picBox3.Image = null;
                picBox4.Image = null;
                picBox5.Image = null;
                picBox6.Image = null;
                picBox7.Image = null;
                picBox8.Image = null;
                picBox9.Image = null;
                Xturn = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        private void picBox7_Click(object sender, EventArgs e)
        {
            picBox7.Image = letter(picBox7).Image;
            Boolean end = Xwin();
            Boolean finish = Owin();
            Boolean tie = draw();
            DialogResult resultAnswer = DialogResult;
            if (end == true)
            {
                resultAnswer = MessageBox.Show("X Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            else if (finish == true)
            {
                resultAnswer = MessageBox.Show("O Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (tie == true)
            {
                resultAnswer = MessageBox.Show("It's a tie!" + "\n" + "\n" + "Play again?", "Good Game!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                picBox1.Image = null;
                picBox2.Image = null;
                picBox3.Image = null;
                picBox4.Image = null;
                picBox5.Image = null;
                picBox6.Image = null;
                picBox7.Image = null;
                picBox8.Image = null;
                picBox9.Image = null;
                Xturn = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        private void picBox8_Click(object sender, EventArgs e)
        {
            picBox8.Image = letter(picBox8).Image;
            Boolean end = Xwin();
            Boolean finish = Owin();
            Boolean tie = draw();
            DialogResult resultAnswer = DialogResult;
            if (end == true)
            {
                resultAnswer = MessageBox.Show("X Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            else if (finish == true)
            {
                resultAnswer = MessageBox.Show("O Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (tie == true)
            {
                resultAnswer = MessageBox.Show("It's a tie!" + "\n" + "\n" + "Play again?", "Good Game!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                picBox1.Image = null;
                picBox2.Image = null;
                picBox3.Image = null;
                picBox4.Image = null;
                picBox5.Image = null;
                picBox6.Image = null;
                picBox7.Image = null;
                picBox8.Image = null;
                picBox9.Image = null;
                Xturn = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        private void picBox9_Click(object sender, EventArgs e)
        {
            picBox9.Image = letter(picBox9).Image;
            Boolean end = Xwin();
            Boolean finish = Owin();
            Boolean tie = draw();
            DialogResult resultAnswer = DialogResult;
            if (end == true)
            {
                resultAnswer = MessageBox.Show("X Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            }
            else if (finish == true)
            {
                resultAnswer = MessageBox.Show("O Wins!" + "\n" + "\n" + "Play again?", "Congratulations!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else if (tie == true)
            {
                resultAnswer = MessageBox.Show("It's a tie!" + "\n" + "\n" + "Play again?", "Good Game!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            if (resultAnswer == DialogResult.Yes)
            {
                picBox1.Image = null;
                picBox2.Image = null;
                picBox3.Image = null;
                picBox4.Image = null;
                picBox5.Image = null;
                picBox6.Image = null;
                picBox7.Image = null;
                picBox8.Image = null;
                picBox9.Image = null;
                Xturn = true;
            }
            else if (resultAnswer == DialogResult.No)
            {
                this.Close();
            }
        }

        public PictureBox letter (PictureBox thepic)
        {
            if (thepic.Image == null)
            {
                if (Xturn == true)
                {
                    thepic.Image = picX.Image;
                    Xturn = false;
                }
                else if (Xturn == false)
                {
                    thepic.Image = picO.Image;
                    Xturn = true;
                }
            }
            return thepic;
        }

        public Boolean Xwin ()
        {
            Boolean test = false;
            if (picBox1.Image == picX.Image && picBox2.Image == picX.Image && picBox3.Image == picX.Image)
            {
                test = true;
            }
            else if (picBox4.Image == picX.Image && picBox5.Image == picX.Image && picBox6.Image == picX.Image)
            {
                test = true;
            }
            else if (picBox7.Image == picX.Image && picBox8.Image == picX.Image && picBox9.Image == picX.Image)
            {
                test = true;
            }
            else if (picBox1.Image == picX.Image && picBox4.Image == picX.Image && picBox7.Image == picX.Image)
            {
                test = true;
            }
            else if (picBox2.Image == picX.Image && picBox5.Image == picX.Image && picBox8.Image == picX.Image)
            {
                test = true;
            }
            else if (picBox3.Image == picX.Image && picBox6.Image == picX.Image && picBox9.Image == picX.Image)
            {
                test = true;
            }
            else if (picBox1.Image == picX.Image && picBox5.Image == picX.Image && picBox9.Image == picX.Image)
            {
                test = true;
            }
            else if (picBox3.Image == picX.Image && picBox5.Image == picX.Image && picBox7.Image == picX.Image)
            {
                test = true;
            }
            return test;
        }

        public Boolean Owin()
        {
            Boolean test = false;
            if (picBox1.Image == picO.Image && picBox2.Image == picO.Image && picBox3.Image == picO.Image)
            {
                test = true;
            }
            else if (picBox4.Image == picO.Image && picBox5.Image == picO.Image && picBox6.Image == picO.Image)
            {
                test = true;
            }
            else if (picBox7.Image == picO.Image && picBox8.Image == picO.Image && picBox9.Image == picO.Image)
            {
                test = true;
            }
            else if (picBox1.Image == picO.Image && picBox4.Image == picO.Image && picBox7.Image == picO.Image)
            {
                test = true;
            }
            else if (picBox2.Image == picO.Image && picBox5.Image == picO.Image && picBox8.Image == picO.Image)
            {
                test = true;
            }
            else if (picBox3.Image == picO.Image && picBox6.Image == picO.Image && picBox9.Image == picO.Image)
            {
                test = true;
            }
            else if (picBox1.Image == picO.Image && picBox5.Image == picO.Image && picBox9.Image == picO.Image)
            {
                test = true;
            }
            else if (picBox3.Image == picO.Image && picBox5.Image == picO.Image && picBox7.Image == picO.Image)
            {
                test = true;
            }
            return test;
        }

        public Boolean draw()
        {
            Boolean test = false;
            if (picBox1.Image == null)
            {
                test = false;
            }
            else if (picBox2.Image == null)
            {
                test = false;
            }
            else if (picBox3.Image == null)
            {
                test = false;
            }
            else if (picBox4.Image == null)
            {
                test = false;
            }
            else if (picBox5.Image == null)
            {
                test = false;
            }
            else if (picBox6.Image == null)
            {
                test = false;
            }
            else if (picBox7.Image == null)
            {
                test = false;
            }
            else if (picBox8.Image == null)
            {
                test = false;
            }
            else if (picBox9.Image == null)
            {
                test = false;
            }
            else
            {
                test = true;
            }
            return test;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBox1.Image = null;
            picBox2.Image = null;
            picBox3.Image = null;
            picBox4.Image = null;
            picBox5.Image = null;
            picBox6.Image = null;
            picBox7.Image = null;
            picBox8.Image = null;
            picBox9.Image = null;
            Xturn = true;
        }
    }
}

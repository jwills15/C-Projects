using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Joshua Williams
//Period: 0
//Date: 9/24/14
/*Project Description: This is a help page for my company.
 * It includes my company logo, trademark, and background.
 * It also can change the font and color of the text.*/
namespace HelpPageProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picLogo.Visible = false;
            lblTrade.Visible = false;
            lblBack.Visible = false;
            picBall.Visible = false;
            picCleat.Visible = false;
            picShin.Visible = false;
            lblCaption.Visible = false;
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            picLogo.Visible = true;
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
        
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            lblTitle.Font = fontDialog1.Font;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblTitle.ForeColor = colorDialog1.Color;
        }

        private void btnTrade_Click(object sender, EventArgs e)
        {
            lblTrade.Visible = true;
        }

        private void btnCompBack_Click(object sender, EventArgs e)
        {
            lblBack.Visible = true;
            picBall.Visible = true;
            picShin.Visible = false;
            picCleat.Visible = false;
            lblCaption.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picBall_Click(object sender, EventArgs e)
        {
            picBall.Visible = false;
            picShin.Visible = true;
        }

        private void picShin_Click(object sender, EventArgs e)
        {
            picShin.Visible = false;
            picCleat.Visible = true;
        }

        private void picCleat_Click(object sender, EventArgs e)
        {
            picCleat.Visible = false;
            picBall.Visible = true;
        }
    }
}

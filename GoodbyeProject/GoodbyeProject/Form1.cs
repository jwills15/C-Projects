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
//Date: 9/19/14
/*Program Description: This program translates "goodbye"
 * into Spanish, French, Latin, German, and Italian. Each
 * button changes the language of "goodbye" while also 
 * displaying the flag of each language's origin. */

namespace GoodbyeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFrench_Click(object sender, EventArgs e)
        {
            lblBye.Text = "Au Revoir";
            picEnglish.Visible = false;
            picFrench.Visible = true;
            picGerman.Visible = false;
            picItalian.Visible = false;
            picLatin.Visible = false;
            picSpanish.Visible = false;
        }

        private void btnItalian_Click(object sender, EventArgs e)
        {
            lblBye.Text = "Addio";
            picEnglish.Visible = false;
            picFrench.Visible = false;
            picGerman.Visible = false;
            picItalian.Visible = true;
            picLatin.Visible = false;
            picSpanish.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            lblBye.Text = "Adios";
            picEnglish.Visible = false;
            picFrench.Visible = false;
            picGerman.Visible = false;
            picItalian.Visible = false;
            picLatin.Visible = false;
            picSpanish.Visible = true;
        }

        private void btnLatin_Click(object sender, EventArgs e)
        {
            lblBye.Text = "Vale";
            picEnglish.Visible = false;
            picFrench.Visible = false;
            picGerman.Visible = false;
            picItalian.Visible = false;
            picLatin.Visible = true;
            picSpanish.Visible = false;
        }

        private void btnGerman_Click(object sender, EventArgs e)
        {
            lblBye.Text = "Auf Wiedersehen";
            picEnglish.Visible = false;
            picFrench.Visible = false;
            picGerman.Visible = true;
            picItalian.Visible = false;
            picLatin.Visible = false;
            picSpanish.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblBye.Text = "Goodbye";
            picEnglish.Visible = true;
            picFrench.Visible = false;
            picGerman.Visible = false;
            picItalian.Visible = false;
            picLatin.Visible = false;
            picSpanish.Visible = false;
        }

    }
}

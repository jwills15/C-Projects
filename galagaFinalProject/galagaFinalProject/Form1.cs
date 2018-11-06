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

/* Name: Joshua Williams
 * Period: 0
 * Project Description: This is my final project, which is a rendition of the 
 * classic arcade game Galaga by Namco. */

namespace galagaFinalProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer creditSound = new System.Media.SoundPlayer(@"Resources\creditSound.wav");
            creditSound.PlaySync();
            frmGame game = new frmGame();
            game.ShowDialog();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Resources\emulogic.ttf");
            lblStart.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblExit.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblHelp.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
        }
    }
}

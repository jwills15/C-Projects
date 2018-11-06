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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"Resources\emulogic.ttf");
            lblObjectives.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblControls.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblScoring.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblCredits.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblGame.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

            lblAlien1.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblAlien2.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblAlien3.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblBoss.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblMultiplier.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblBackFromScoring.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

            lblLeftArrow.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblRightArrow.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblSpace.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);
            lblBackFromControls.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

            lblObjectivesInfo.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblLevel1.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblLevel2.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblLevel3.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblLevel4.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblLevel5.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblBackFromObjectives.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

            lblActualCredits.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            lblBackFromCredits.Font = new Font(pfc.Families[0], 16, FontStyle.Regular);

            lblObjectives.Left = 95;
            lblControls.Left = 119;
            lblScoring.Left = 124;
            lblCredits.Left = 124;
            lblGame.Left = 52;

            lblObjectives.Top = 80;
            lblControls.Top = 155;
            lblScoring.Top = 230;
            lblCredits.Top = 305;
            lblGame.Top = 380;

            lblAlien1.Left = 12;
            picAlien1.Left = 277;
            lblAlien2.Left = 167;
            picAlien2.Left = 118;
            lblAlien3.Left = 12;
            picAlien3.Left = 277;
            lblBoss.Left = 167;
            picBoss.Left = 124;
            lblMultiplier.Left = 12;
            lblBackFromScoring.Left = 153;

            lblAlien1.Top = -100;
            picAlien1.Top = -100;
            lblAlien2.Top = -100;
            picAlien2.Top = -100;
            lblAlien3.Top = -100;
            picAlien3.Top = -100;
            lblBoss.Top = -100;
            picBoss.Top = -100;
            lblMultiplier.Top = -100;
            lblBackFromScoring.Top = -100;

            lblLeftArrow.Left = 12;
            picLeftArrow.Left = 322;
            picRightArrow.Left = 52;
            lblRightArrow.Left = 122;
            lblSpace.Left = 12;
            picSpace.Left = 172;
            lblBackFromControls.Left = 153;

            lblLeftArrow.Top = -100;
            picLeftArrow.Top = -100;
            picRightArrow.Top = -100;
            lblRightArrow.Top = -100;
            lblSpace.Top = -100;
            picSpace.Top = -100;
            lblBackFromControls.Top = -100;

            lblObjectivesInfo.Left = 12;
            lblLevel1.Left = 12;
            lblLevel2.Left = 12;
            lblLevel3.Left = 12;
            lblLevel4.Left = 12;
            lblLevel5.Left = 12;
            lblBackFromObjectives.Left = 153;

            lblObjectivesInfo.Top = -150;
            lblLevel1.Top = -100;
            lblLevel2.Top = -100;
            lblLevel3.Top = -100;
            lblLevel4.Top = -100;
            lblLevel5.Top = -100;
            lblBackFromObjectives.Top = -100;

            lblActualCredits.Left = 12;
            lblBackFromCredits.Left = 153;

            lblActualCredits.Top = this.Height + 100;
            lblBackFromCredits.Top = -100;
        }

        private void lblGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblObjectives_Click(object sender, EventArgs e)
        {
            lblObjectivesInfo.Top = 38;
            lblLevel1.Top = 188;
            lblLevel2.Top = 228;
            lblLevel3.Top = 268;
            lblLevel4.Top = 308;
            lblLevel5.Top = 358;
            lblBackFromObjectives.Top = 428;

            lblObjectives.Top = -100;
            lblControls.Top = -100;
            lblScoring.Top = -100;
            lblCredits.Top = -100;
            lblGame.Top = -100;
        }

        private void lblControls_Click(object sender, EventArgs e)
        {
            lblLeftArrow.Top = 74;
            picLeftArrow.Top = 81;
            picRightArrow.Top = 166;
            lblRightArrow.Top = 159;
            lblSpace.Top = 244;
            picSpace.Top = 312;
            lblBackFromControls.Top = 392;

            lblObjectives.Top = -100;
            lblControls.Top = -100;
            lblScoring.Top = -100;
            lblCredits.Top = -100;
            lblGame.Top = -100;
        }

        private void lblScoring_Click(object sender, EventArgs e)
        {
            lblAlien1.Top = 18;
            picAlien1.Top = 35;
            lblAlien2.Top = 98;
            picAlien2.Top = 115;
            lblAlien3.Top = 178;
            picAlien3.Top = 186;
            lblBoss.Top = 258;
            picBoss.Top = 265;
            lblMultiplier.Top = 338;
            lblBackFromScoring.Top = 448;

            lblObjectives.Top = -100;
            lblControls.Top = -100;
            lblScoring.Top = -100;
            lblCredits.Top = -100;
            lblGame.Top = -100;
        }

        private void lblCredits_Click(object sender, EventArgs e)
        {
            lblActualCredits.Top = 60;
            lblBackFromCredits.Top = 405;

            lblObjectives.Top = -100;
            lblControls.Top = -100;
            lblScoring.Top = -100;
            lblCredits.Top = -100;
            lblGame.Top = -100;
        }

        private void lblBackFromScoring_Click(object sender, EventArgs e)
        {
            lblObjectives.Top = 80;
            lblControls.Top = 155;
            lblScoring.Top = 230;
            lblCredits.Top = 305;
            lblGame.Top = 380;

            lblAlien1.Top = -100;
            picAlien1.Top = -100;
            lblAlien2.Top = -100;
            picAlien2.Top = -100;
            lblAlien3.Top = -100;
            picAlien3.Top = -100;
            lblBoss.Top = -100;
            picBoss.Top = -100;
            lblMultiplier.Top = -100;
            lblBackFromScoring.Top = -100;
        }

        private void lblMultiplier_Click(object sender, EventArgs e)
        {
            //accident
        }

        private void picBoss_Click(object sender, EventArgs e)
        {
            //accident
        }

        private void picAlien3_Click(object sender, EventArgs e)
        {
            //accident
        }

        private void picAlien2_Click(object sender, EventArgs e)
        {
            //accident
        }

        private void picAlien1_Click(object sender, EventArgs e)
        {
            //accident
        }

        private void lblBoss_Click(object sender, EventArgs e)
        {
            //accident
        }

        private void lblAlien3_Click(object sender, EventArgs e)
        {
            //accident
        }

        private void lblAlien2_Click(object sender, EventArgs e)
        {
            //accident
        }

        private void lblAlien1_Click(object sender, EventArgs e)
        {
            //accident
        }

        private void lblBackFromControls_Click(object sender, EventArgs e)
        {
            lblObjectives.Top = 80;
            lblControls.Top = 155;
            lblScoring.Top = 230;
            lblCredits.Top = 305;
            lblGame.Top = 380;

            lblLeftArrow.Top = -100;
            picLeftArrow.Top = -100;
            picRightArrow.Top = -100;
            lblRightArrow.Top = -100;
            lblSpace.Top = -100;
            picSpace.Top = -100;
            lblBackFromControls.Top = -100;
        }

        private void lblBackFromObjectives_Click(object sender, EventArgs e)
        {
            lblObjectives.Top = 80;
            lblControls.Top = 155;
            lblScoring.Top = 230;
            lblCredits.Top = 305;
            lblGame.Top = 380;

            lblObjectivesInfo.Top = -150;
            lblLevel1.Top = -100;
            lblLevel2.Top = -100;
            lblLevel3.Top = -100;
            lblLevel4.Top = -100;
            lblLevel5.Top = -100;
            lblBackFromObjectives.Top = -100;
        }

        private void lblBackFromCredits_Click(object sender, EventArgs e)
        {
            lblObjectives.Top = 80;
            lblControls.Top = 155;
            lblScoring.Top = 230;
            lblCredits.Top = 305;
            lblGame.Top = 380;

            lblActualCredits.Top = this.Height + 100;
            lblBackFromCredits.Top = -100;
        }
    }
}

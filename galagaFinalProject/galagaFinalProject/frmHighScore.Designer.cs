namespace galagaFinalProject
{
    partial class frmHighScore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHighScore));
            this.lblResults = new System.Windows.Forms.Label();
            this.lblShotsLabel = new System.Windows.Forms.Label();
            this.lblHitsLabel = new System.Windows.Forms.Label();
            this.lblRatioLabel = new System.Windows.Forms.Label();
            this.lblShots = new System.Windows.Forms.Label();
            this.lblHits = new System.Windows.Forms.Label();
            this.lblRatio = new System.Windows.Forms.Label();
            this.Tdelay = new System.Windows.Forms.Timer(this.components);
            this.lblBeat = new System.Windows.Forms.Label();
            this.lblEnterInitials = new System.Windows.Forms.Label();
            this.lblUserScoreLabel = new System.Windows.Forms.Label();
            this.lblUserNameLabel = new System.Windows.Forms.Label();
            this.lblHighNameLabel = new System.Windows.Forms.Label();
            this.lblHighScoreLabel = new System.Windows.Forms.Label();
            this.lbl1st = new System.Windows.Forms.Label();
            this.lbl2nd = new System.Windows.Forms.Label();
            this.lbl3rd = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lbl5th = new System.Windows.Forms.Label();
            this.lbl4th = new System.Windows.Forms.Label();
            this.lblHighScore1 = new System.Windows.Forms.Label();
            this.lblHighName1 = new System.Windows.Forms.Label();
            this.lblHighName2 = new System.Windows.Forms.Label();
            this.lblHighName3 = new System.Windows.Forms.Label();
            this.lblHighName4 = new System.Windows.Forms.Label();
            this.lblHighName5 = new System.Windows.Forms.Label();
            this.lblHighScore2 = new System.Windows.Forms.Label();
            this.lblHighScore3 = new System.Windows.Forms.Label();
            this.lblHighScore4 = new System.Windows.Forms.Label();
            this.lblHighScore5 = new System.Windows.Forms.Label();
            this.lblTop5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResults
            // 
            this.lblResults.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResults.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.ForeColor = System.Drawing.Color.White;
            this.lblResults.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblResults.Location = new System.Drawing.Point(22, 648);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(220, 50);
            this.lblResults.TabIndex = 116;
            this.lblResults.Text = "-Results-";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShotsLabel
            // 
            this.lblShotsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShotsLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShotsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblShotsLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblShotsLabel.Location = new System.Drawing.Point(22, 643);
            this.lblShotsLabel.Name = "lblShotsLabel";
            this.lblShotsLabel.Size = new System.Drawing.Size(292, 50);
            this.lblShotsLabel.TabIndex = 117;
            this.lblShotsLabel.Text = "Shots Fired:";
            this.lblShotsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHitsLabel
            // 
            this.lblHitsLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHitsLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHitsLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHitsLabel.Location = new System.Drawing.Point(12, 643);
            this.lblHitsLabel.Name = "lblHitsLabel";
            this.lblHitsLabel.Size = new System.Drawing.Size(357, 50);
            this.lblHitsLabel.TabIndex = 118;
            this.lblHitsLabel.Text = "Number of Hits:";
            this.lblHitsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRatioLabel
            // 
            this.lblRatioLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRatioLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatioLabel.ForeColor = System.Drawing.Color.White;
            this.lblRatioLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblRatioLabel.Location = new System.Drawing.Point(12, 643);
            this.lblRatioLabel.Name = "lblRatioLabel";
            this.lblRatioLabel.Size = new System.Drawing.Size(357, 50);
            this.lblRatioLabel.TabIndex = 119;
            this.lblRatioLabel.Text = "hit-miss ratio:";
            this.lblRatioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShots
            // 
            this.lblShots.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShots.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblShots.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblShots.Location = new System.Drawing.Point(22, 643);
            this.lblShots.Name = "lblShots";
            this.lblShots.Size = new System.Drawing.Size(211, 50);
            this.lblShots.TabIndex = 120;
            this.lblShots.Text = "0";
            this.lblShots.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHits
            // 
            this.lblHits.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHits.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHits.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHits.Location = new System.Drawing.Point(12, 643);
            this.lblHits.Name = "lblHits";
            this.lblHits.Size = new System.Drawing.Size(211, 50);
            this.lblHits.TabIndex = 121;
            this.lblHits.Text = "0";
            this.lblHits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRatio
            // 
            this.lblRatio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRatio.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatio.ForeColor = System.Drawing.Color.White;
            this.lblRatio.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblRatio.Location = new System.Drawing.Point(12, 643);
            this.lblRatio.Name = "lblRatio";
            this.lblRatio.Size = new System.Drawing.Size(211, 50);
            this.lblRatio.TabIndex = 122;
            this.lblRatio.Text = "0";
            this.lblRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Tdelay
            // 
            this.Tdelay.Enabled = true;
            this.Tdelay.Interval = 7500;
            this.Tdelay.Tick += new System.EventHandler(this.Tdelay_Tick);
            // 
            // lblBeat
            // 
            this.lblBeat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBeat.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeat.ForeColor = System.Drawing.Color.White;
            this.lblBeat.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblBeat.Location = new System.Drawing.Point(12, 9);
            this.lblBeat.Name = "lblBeat";
            this.lblBeat.Size = new System.Drawing.Size(616, 50);
            this.lblBeat.TabIndex = 123;
            this.lblBeat.Text = "You beat the high score!";
            this.lblBeat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBeat.Visible = false;
            // 
            // lblEnterInitials
            // 
            this.lblEnterInitials.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEnterInitials.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterInitials.ForeColor = System.Drawing.Color.White;
            this.lblEnterInitials.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblEnterInitials.Location = new System.Drawing.Point(73, 59);
            this.lblEnterInitials.Name = "lblEnterInitials";
            this.lblEnterInitials.Size = new System.Drawing.Size(495, 50);
            this.lblEnterInitials.TabIndex = 124;
            this.lblEnterInitials.Text = "Enter your initials!";
            this.lblEnterInitials.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnterInitials.Visible = false;
            // 
            // lblUserScoreLabel
            // 
            this.lblUserScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserScoreLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUserScoreLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserScoreLabel.Location = new System.Drawing.Point(120, 155);
            this.lblUserScoreLabel.Name = "lblUserScoreLabel";
            this.lblUserScoreLabel.Size = new System.Drawing.Size(150, 50);
            this.lblUserScoreLabel.TabIndex = 125;
            this.lblUserScoreLabel.Text = "Score:";
            this.lblUserScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserScoreLabel.Visible = false;
            // 
            // lblUserNameLabel
            // 
            this.lblUserNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserNameLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUserNameLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserNameLabel.Location = new System.Drawing.Point(382, 155);
            this.lblUserNameLabel.Name = "lblUserNameLabel";
            this.lblUserNameLabel.Size = new System.Drawing.Size(150, 50);
            this.lblUserNameLabel.TabIndex = 126;
            this.lblUserNameLabel.Text = "Name:";
            this.lblUserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserNameLabel.Visible = false;
            // 
            // lblHighNameLabel
            // 
            this.lblHighNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighNameLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighNameLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighNameLabel.Location = new System.Drawing.Point(420, 331);
            this.lblHighNameLabel.Name = "lblHighNameLabel";
            this.lblHighNameLabel.Size = new System.Drawing.Size(150, 50);
            this.lblHighNameLabel.TabIndex = 128;
            this.lblHighNameLabel.Text = "Name:";
            this.lblHighNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighNameLabel.Visible = false;
            // 
            // lblHighScoreLabel
            // 
            this.lblHighScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighScoreLabel.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighScoreLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighScoreLabel.Location = new System.Drawing.Point(220, 331);
            this.lblHighScoreLabel.Name = "lblHighScoreLabel";
            this.lblHighScoreLabel.Size = new System.Drawing.Size(150, 50);
            this.lblHighScoreLabel.TabIndex = 127;
            this.lblHighScoreLabel.Text = "Score:";
            this.lblHighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScoreLabel.Visible = false;
            // 
            // lbl1st
            // 
            this.lbl1st.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl1st.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1st.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl1st.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl1st.Location = new System.Drawing.Point(70, 381);
            this.lbl1st.Name = "lbl1st";
            this.lbl1st.Size = new System.Drawing.Size(100, 50);
            this.lbl1st.TabIndex = 129;
            this.lbl1st.Text = "1st";
            this.lbl1st.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1st.Visible = false;
            // 
            // lbl2nd
            // 
            this.lbl2nd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl2nd.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2nd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl2nd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl2nd.Location = new System.Drawing.Point(70, 431);
            this.lbl2nd.Name = "lbl2nd";
            this.lbl2nd.Size = new System.Drawing.Size(100, 50);
            this.lbl2nd.TabIndex = 130;
            this.lbl2nd.Text = "2nd";
            this.lbl2nd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2nd.Visible = false;
            // 
            // lbl3rd
            // 
            this.lbl3rd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl3rd.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3rd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl3rd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl3rd.Location = new System.Drawing.Point(70, 481);
            this.lbl3rd.Name = "lbl3rd";
            this.lbl3rd.Size = new System.Drawing.Size(100, 50);
            this.lbl3rd.TabIndex = 131;
            this.lbl3rd.Text = "3rd";
            this.lbl3rd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3rd.Visible = false;
            // 
            // lblUserScore
            // 
            this.lblUserScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserScore.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUserScore.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserScore.Location = new System.Drawing.Point(108, 205);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(174, 50);
            this.lblUserScore.TabIndex = 132;
            this.lblUserScore.Text = "0000000";
            this.lblUserScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserScore.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserName.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblUserName.Location = new System.Drawing.Point(382, 205);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(150, 50);
            this.lblUserName.TabIndex = 133;
            this.lblUserName.Text = "USR";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserName.Visible = false;
            // 
            // lbl5th
            // 
            this.lbl5th.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl5th.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5th.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl5th.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl5th.Location = new System.Drawing.Point(70, 581);
            this.lbl5th.Name = "lbl5th";
            this.lbl5th.Size = new System.Drawing.Size(100, 50);
            this.lbl5th.TabIndex = 134;
            this.lbl5th.Text = "5th";
            this.lbl5th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl5th.Visible = false;
            // 
            // lbl4th
            // 
            this.lbl4th.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl4th.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4th.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl4th.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl4th.Location = new System.Drawing.Point(70, 531);
            this.lbl4th.Name = "lbl4th";
            this.lbl4th.Size = new System.Drawing.Size(100, 50);
            this.lbl4th.TabIndex = 135;
            this.lbl4th.Text = "4th";
            this.lbl4th.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl4th.Visible = false;
            // 
            // lblHighScore1
            // 
            this.lblHighScore1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighScore1.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighScore1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighScore1.Location = new System.Drawing.Point(208, 381);
            this.lblHighScore1.Name = "lblHighScore1";
            this.lblHighScore1.Size = new System.Drawing.Size(174, 50);
            this.lblHighScore1.TabIndex = 136;
            this.lblHighScore1.Text = "0000000";
            this.lblHighScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScore1.Visible = false;
            // 
            // lblHighName1
            // 
            this.lblHighName1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighName1.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighName1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighName1.Location = new System.Drawing.Point(420, 381);
            this.lblHighName1.Name = "lblHighName1";
            this.lblHighName1.Size = new System.Drawing.Size(150, 50);
            this.lblHighName1.TabIndex = 137;
            this.lblHighName1.Text = "SCR";
            this.lblHighName1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighName1.Visible = false;
            // 
            // lblHighName2
            // 
            this.lblHighName2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighName2.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighName2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighName2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighName2.Location = new System.Drawing.Point(420, 431);
            this.lblHighName2.Name = "lblHighName2";
            this.lblHighName2.Size = new System.Drawing.Size(150, 50);
            this.lblHighName2.TabIndex = 138;
            this.lblHighName2.Text = "SCR";
            this.lblHighName2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighName2.Visible = false;
            // 
            // lblHighName3
            // 
            this.lblHighName3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighName3.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighName3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighName3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighName3.Location = new System.Drawing.Point(420, 481);
            this.lblHighName3.Name = "lblHighName3";
            this.lblHighName3.Size = new System.Drawing.Size(150, 50);
            this.lblHighName3.TabIndex = 139;
            this.lblHighName3.Text = "SCR";
            this.lblHighName3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighName3.Visible = false;
            // 
            // lblHighName4
            // 
            this.lblHighName4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighName4.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighName4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighName4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighName4.Location = new System.Drawing.Point(420, 531);
            this.lblHighName4.Name = "lblHighName4";
            this.lblHighName4.Size = new System.Drawing.Size(150, 50);
            this.lblHighName4.TabIndex = 140;
            this.lblHighName4.Text = "SCR";
            this.lblHighName4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighName4.Visible = false;
            // 
            // lblHighName5
            // 
            this.lblHighName5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighName5.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighName5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighName5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighName5.Location = new System.Drawing.Point(420, 581);
            this.lblHighName5.Name = "lblHighName5";
            this.lblHighName5.Size = new System.Drawing.Size(150, 50);
            this.lblHighName5.TabIndex = 141;
            this.lblHighName5.Text = "SCR";
            this.lblHighName5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighName5.Visible = false;
            // 
            // lblHighScore2
            // 
            this.lblHighScore2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighScore2.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighScore2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighScore2.Location = new System.Drawing.Point(208, 431);
            this.lblHighScore2.Name = "lblHighScore2";
            this.lblHighScore2.Size = new System.Drawing.Size(174, 50);
            this.lblHighScore2.TabIndex = 142;
            this.lblHighScore2.Text = "0000000";
            this.lblHighScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScore2.Visible = false;
            // 
            // lblHighScore3
            // 
            this.lblHighScore3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighScore3.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighScore3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighScore3.Location = new System.Drawing.Point(208, 481);
            this.lblHighScore3.Name = "lblHighScore3";
            this.lblHighScore3.Size = new System.Drawing.Size(174, 50);
            this.lblHighScore3.TabIndex = 143;
            this.lblHighScore3.Text = "0000000";
            this.lblHighScore3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScore3.Visible = false;
            // 
            // lblHighScore4
            // 
            this.lblHighScore4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighScore4.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighScore4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighScore4.Location = new System.Drawing.Point(208, 531);
            this.lblHighScore4.Name = "lblHighScore4";
            this.lblHighScore4.Size = new System.Drawing.Size(174, 50);
            this.lblHighScore4.TabIndex = 144;
            this.lblHighScore4.Text = "0000000";
            this.lblHighScore4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScore4.Visible = false;
            // 
            // lblHighScore5
            // 
            this.lblHighScore5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHighScore5.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighScore5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblHighScore5.Location = new System.Drawing.Point(208, 581);
            this.lblHighScore5.Name = "lblHighScore5";
            this.lblHighScore5.Size = new System.Drawing.Size(174, 50);
            this.lblHighScore5.TabIndex = 145;
            this.lblHighScore5.Text = "0000000";
            this.lblHighScore5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScore5.Visible = false;
            // 
            // lblTop5
            // 
            this.lblTop5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTop5.Font = new System.Drawing.Font("Emulogic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop5.ForeColor = System.Drawing.Color.White;
            this.lblTop5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTop5.Location = new System.Drawing.Point(230, 281);
            this.lblTop5.Name = "lblTop5";
            this.lblTop5.Size = new System.Drawing.Size(181, 50);
            this.lblTop5.TabIndex = 146;
            this.lblTop5.Text = "-Top 5-";
            this.lblTop5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTop5.Visible = false;
            // 
            // frmHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 711);
            this.Controls.Add(this.lblTop5);
            this.Controls.Add(this.lblHighScore5);
            this.Controls.Add(this.lblHighScore4);
            this.Controls.Add(this.lblHighScore3);
            this.Controls.Add(this.lblHighScore2);
            this.Controls.Add(this.lblHighName5);
            this.Controls.Add(this.lblHighName4);
            this.Controls.Add(this.lblHighName3);
            this.Controls.Add(this.lblHighName2);
            this.Controls.Add(this.lblHighName1);
            this.Controls.Add(this.lblHighScore1);
            this.Controls.Add(this.lbl4th);
            this.Controls.Add(this.lbl5th);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.lbl3rd);
            this.Controls.Add(this.lbl2nd);
            this.Controls.Add(this.lbl1st);
            this.Controls.Add(this.lblHighNameLabel);
            this.Controls.Add(this.lblHighScoreLabel);
            this.Controls.Add(this.lblUserNameLabel);
            this.Controls.Add(this.lblUserScoreLabel);
            this.Controls.Add(this.lblEnterInitials);
            this.Controls.Add(this.lblBeat);
            this.Controls.Add(this.lblRatio);
            this.Controls.Add(this.lblHits);
            this.Controls.Add(this.lblShots);
            this.Controls.Add(this.lblRatioLabel);
            this.Controls.Add(this.lblHitsLabel);
            this.Controls.Add(this.lblShotsLabel);
            this.Controls.Add(this.lblResults);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Galaga";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHighScore_FormClosed);
            this.Load += new System.EventHandler(this.frmHighScore_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHighScore_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblShotsLabel;
        private System.Windows.Forms.Label lblHitsLabel;
        private System.Windows.Forms.Label lblRatioLabel;
        private System.Windows.Forms.Label lblShots;
        private System.Windows.Forms.Label lblHits;
        private System.Windows.Forms.Label lblRatio;
        private System.Windows.Forms.Timer Tdelay;
        private System.Windows.Forms.Label lblBeat;
        private System.Windows.Forms.Label lblEnterInitials;
        private System.Windows.Forms.Label lblUserScoreLabel;
        private System.Windows.Forms.Label lblUserNameLabel;
        private System.Windows.Forms.Label lblHighNameLabel;
        private System.Windows.Forms.Label lblHighScoreLabel;
        private System.Windows.Forms.Label lbl1st;
        private System.Windows.Forms.Label lbl2nd;
        private System.Windows.Forms.Label lbl3rd;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lbl5th;
        private System.Windows.Forms.Label lbl4th;
        private System.Windows.Forms.Label lblHighScore1;
        private System.Windows.Forms.Label lblHighName1;
        private System.Windows.Forms.Label lblHighName2;
        private System.Windows.Forms.Label lblHighName3;
        private System.Windows.Forms.Label lblHighName4;
        private System.Windows.Forms.Label lblHighName5;
        private System.Windows.Forms.Label lblHighScore2;
        private System.Windows.Forms.Label lblHighScore3;
        private System.Windows.Forms.Label lblHighScore4;
        private System.Windows.Forms.Label lblHighScore5;
        private System.Windows.Forms.Label lblTop5;
    }
}
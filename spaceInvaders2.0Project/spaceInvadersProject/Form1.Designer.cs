namespace spaceInvadersProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picShip = new System.Windows.Forms.PictureBox();
            this.picAlien1 = new System.Windows.Forms.PictureBox();
            this.picAlien2 = new System.Windows.Forms.PictureBox();
            this.picAlien3 = new System.Windows.Forms.PictureBox();
            this.Taliens = new System.Windows.Forms.Timer(this.components);
            this.Tbullet = new System.Windows.Forms.Timer(this.components);
            this.lblBullet = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblControls = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien3)).BeginInit();
            this.SuspendLayout();
            // 
            // picShip
            // 
            this.picShip.Image = ((System.Drawing.Image)(resources.GetObject("picShip.Image")));
            this.picShip.Location = new System.Drawing.Point(232, 402);
            this.picShip.Name = "picShip";
            this.picShip.Size = new System.Drawing.Size(70, 70);
            this.picShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShip.TabIndex = 0;
            this.picShip.TabStop = false;
            // 
            // picAlien1
            // 
            this.picAlien1.Image = ((System.Drawing.Image)(resources.GetObject("picAlien1.Image")));
            this.picAlien1.Location = new System.Drawing.Point(144, 12);
            this.picAlien1.Name = "picAlien1";
            this.picAlien1.Size = new System.Drawing.Size(60, 50);
            this.picAlien1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlien1.TabIndex = 1;
            this.picAlien1.TabStop = false;
            // 
            // picAlien2
            // 
            this.picAlien2.Image = ((System.Drawing.Image)(resources.GetObject("picAlien2.Image")));
            this.picAlien2.Location = new System.Drawing.Point(78, 12);
            this.picAlien2.Name = "picAlien2";
            this.picAlien2.Size = new System.Drawing.Size(60, 50);
            this.picAlien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlien2.TabIndex = 2;
            this.picAlien2.TabStop = false;
            // 
            // picAlien3
            // 
            this.picAlien3.Image = ((System.Drawing.Image)(resources.GetObject("picAlien3.Image")));
            this.picAlien3.Location = new System.Drawing.Point(12, 12);
            this.picAlien3.Name = "picAlien3";
            this.picAlien3.Size = new System.Drawing.Size(60, 50);
            this.picAlien3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlien3.TabIndex = 3;
            this.picAlien3.TabStop = false;
            // 
            // Taliens
            // 
            this.Taliens.Interval = 50;
            this.Taliens.Tick += new System.EventHandler(this.Taliens_Tick);
            // 
            // Tbullet
            // 
            this.Tbullet.Interval = 1;
            this.Tbullet.Tick += new System.EventHandler(this.Tbullet_Tick);
            // 
            // lblBullet
            // 
            this.lblBullet.BackColor = System.Drawing.Color.Red;
            this.lblBullet.Location = new System.Drawing.Point(265, 402);
            this.lblBullet.Name = "lblBullet";
            this.lblBullet.Size = new System.Drawing.Size(4, 15);
            this.lblBullet.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 2);
            this.label1.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnStart.Location = new System.Drawing.Point(216, 303);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 34);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(442, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 26);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Joshua Williams\r\nPeriod 0 GITA 1";
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblControls.ForeColor = System.Drawing.Color.White;
            this.lblControls.Location = new System.Drawing.Point(154, 124);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(237, 140);
            this.lblControls.TabIndex = 8;
            this.lblControls.Text = "Space Invaders Controls:\r\n\r\nLeft Arrow Key = move left\r\nRight Arrow Key = move ri" +
    "ght\r\nSpace Bar = shoot\r\n\r\nHit each alien three times to win.";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(235, 344);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(59, 20);
            this.lblLevel.TabIndex = 13;
            this.lblLevel.Text = "Level 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(537, 484);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picAlien3);
            this.Controls.Add(this.picAlien2);
            this.Controls.Add(this.picAlien1);
            this.Controls.Add(this.picShip);
            this.Controls.Add(this.lblBullet);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Space Invaders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picShip;
        private System.Windows.Forms.PictureBox picAlien1;
        private System.Windows.Forms.PictureBox picAlien2;
        private System.Windows.Forms.PictureBox picAlien3;
        private System.Windows.Forms.Timer Taliens;
        private System.Windows.Forms.Timer Tbullet;
        private System.Windows.Forms.Label lblBullet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Label lblLevel;
    }
}


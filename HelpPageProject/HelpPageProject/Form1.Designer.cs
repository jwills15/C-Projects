namespace HelpPageProject
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.btnTrade = new System.Windows.Forms.Button();
            this.btnCompBack = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblBack = new System.Windows.Forms.Label();
            this.lblTrade = new System.Windows.Forms.Label();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.picCleat = new System.Windows.Forms.PictureBox();
            this.picShin = new System.Windows.Forms.PictureBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCleat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(405, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "exit the help page");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(12, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 40);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "reset the help page");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnColor.Location = new System.Drawing.Point(274, 304);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(125, 40);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color";
            this.toolTip1.SetToolTip(this.btnColor, "change the color of the title");
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFont.Location = new System.Drawing.Point(143, 304);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(125, 40);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "Font";
            this.toolTip1.SetToolTip(this.btnFont, "change the font of the title");
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogo.Location = new System.Drawing.Point(13, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(125, 40);
            this.btnLogo.TabIndex = 4;
            this.btnLogo.Text = "Logo";
            this.toolTip1.SetToolTip(this.btnLogo, "displays the J3W logo");
            this.btnLogo.UseVisualStyleBackColor = true;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // btnTrade
            // 
            this.btnTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTrade.Location = new System.Drawing.Point(12, 58);
            this.btnTrade.Name = "btnTrade";
            this.btnTrade.Size = new System.Drawing.Size(125, 40);
            this.btnTrade.TabIndex = 5;
            this.btnTrade.Text = "Trademark";
            this.toolTip1.SetToolTip(this.btnTrade, "displays the J3W trademark");
            this.btnTrade.UseVisualStyleBackColor = true;
            this.btnTrade.Click += new System.EventHandler(this.btnTrade_Click);
            // 
            // btnCompBack
            // 
            this.btnCompBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCompBack.Location = new System.Drawing.Point(13, 104);
            this.btnCompBack.Name = "btnCompBack";
            this.btnCompBack.Size = new System.Drawing.Size(125, 40);
            this.btnCompBack.TabIndex = 6;
            this.btnCompBack.Text = "Company Info";
            this.toolTip1.SetToolTip(this.btnCompBack, "displays the J3W company information");
            this.btnCompBack.UseVisualStyleBackColor = true;
            this.btnCompBack.Click += new System.EventHandler(this.btnCompBack_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 150);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 125);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            this.picLogo.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 2);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 18F);
            this.lblTitle.Location = new System.Drawing.Point(147, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 40);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "J3Williams Incorporated";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(139, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 2);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // lblBack
            // 
            this.lblBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblBack.Location = new System.Drawing.Point(144, 104);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(255, 171);
            this.lblBack.TabIndex = 11;
            this.lblBack.Text = resources.GetString("lblBack.Text");
            this.lblBack.Visible = false;
            // 
            // lblTrade
            // 
            this.lblTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrade.Location = new System.Drawing.Point(143, 60);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(382, 38);
            this.lblTrade.TabIndex = 12;
            this.lblTrade.Text = "\"Working Wonders in Soccer\"";
            this.lblTrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTrade.Visible = false;
            // 
            // picBall
            // 
            this.picBall.Image = ((System.Drawing.Image)(resources.GetObject("picBall.Image")));
            this.picBall.Location = new System.Drawing.Point(406, 104);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(119, 110);
            this.picBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBall.TabIndex = 13;
            this.picBall.TabStop = false;
            this.picBall.Visible = false;
            this.picBall.Click += new System.EventHandler(this.picBall_Click);
            // 
            // picCleat
            // 
            this.picCleat.Image = ((System.Drawing.Image)(resources.GetObject("picCleat.Image")));
            this.picCleat.Location = new System.Drawing.Point(405, 104);
            this.picCleat.Name = "picCleat";
            this.picCleat.Size = new System.Drawing.Size(119, 110);
            this.picCleat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCleat.TabIndex = 16;
            this.picCleat.TabStop = false;
            this.picCleat.Visible = false;
            this.picCleat.Click += new System.EventHandler(this.picCleat_Click);
            // 
            // picShin
            // 
            this.picShin.Image = ((System.Drawing.Image)(resources.GetObject("picShin.Image")));
            this.picShin.Location = new System.Drawing.Point(405, 104);
            this.picShin.Name = "picShin";
            this.picShin.Size = new System.Drawing.Size(119, 110);
            this.picShin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShin.TabIndex = 17;
            this.picShin.TabStop = false;
            this.picShin.Visible = false;
            this.picShin.Click += new System.EventHandler(this.picShin_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCaption.Location = new System.Drawing.Point(422, 217);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(102, 43);
            this.lblCaption.TabIndex = 18;
            this.lblCaption.Text = "Click on the product to change to the next one.";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblCaption.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Joshua Williams Period 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 356);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.picShin);
            this.Controls.Add(this.picCleat);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnCompBack);
            this.Controls.Add(this.btnTrade);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "J3W Help Page";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCleat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Button btnTrade;
        private System.Windows.Forms.Button btnCompBack;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.PictureBox picCleat;
        private System.Windows.Forms.PictureBox picShin;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label label3;
    }
}


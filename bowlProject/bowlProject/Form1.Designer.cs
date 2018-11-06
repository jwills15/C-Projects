namespace bowlProject
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picOhioSmall = new System.Windows.Forms.PictureBox();
            this.picAlabamaSmall = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predictionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schoolInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAlabama = new System.Windows.Forms.RadioButton();
            this.radOhioState = new System.Windows.Forms.RadioButton();
            this.lbxSchedules = new System.Windows.Forms.ListBox();
            this.picOhioBig = new System.Windows.Forms.PictureBox();
            this.picAlabamaBig = new System.Windows.Forms.PictureBox();
            this.cboOhioState = new System.Windows.Forms.ComboBox();
            this.cboAlabama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOhioOutput = new System.Windows.Forms.Label();
            this.lblAlabamaOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOhioSmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlabamaSmall)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOhioBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlabamaBig)).BeginInit();
            this.SuspendLayout();
            // 
            // picOhioSmall
            // 
            this.picOhioSmall.Image = ((System.Drawing.Image)(resources.GetObject("picOhioSmall.Image")));
            this.picOhioSmall.Location = new System.Drawing.Point(43, 90);
            this.picOhioSmall.Name = "picOhioSmall";
            this.picOhioSmall.Size = new System.Drawing.Size(100, 100);
            this.picOhioSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOhioSmall.TabIndex = 0;
            this.picOhioSmall.TabStop = false;
            // 
            // picAlabamaSmall
            // 
            this.picAlabamaSmall.Image = ((System.Drawing.Image)(resources.GetObject("picAlabamaSmall.Image")));
            this.picAlabamaSmall.Location = new System.Drawing.Point(463, 90);
            this.picAlabamaSmall.Name = "picAlabamaSmall";
            this.picAlabamaSmall.Size = new System.Drawing.Size(100, 100);
            this.picAlabamaSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlabamaSmall.TabIndex = 1;
            this.picAlabamaSmall.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.teamToolStripMenuItem,
            this.predictionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.teamToolStripMenuItem.Text = "Alabama";
            // 
            // alToolStripMenuItem
            // 
            this.alToolStripMenuItem.Name = "alToolStripMenuItem";
            this.alToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.alToolStripMenuItem.Text = "School Information";
            this.alToolStripMenuItem.Click += new System.EventHandler(this.alToolStripMenuItem_Click);
            // 
            // predictionToolStripMenuItem
            // 
            this.predictionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoolInformationToolStripMenuItem});
            this.predictionToolStripMenuItem.Name = "predictionToolStripMenuItem";
            this.predictionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.predictionToolStripMenuItem.Text = "Ohio State";
            // 
            // schoolInformationToolStripMenuItem
            // 
            this.schoolInformationToolStripMenuItem.Name = "schoolInformationToolStripMenuItem";
            this.schoolInformationToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.schoolInformationToolStripMenuItem.Text = "School Information";
            this.schoolInformationToolStripMenuItem.Click += new System.EventHandler(this.schoolInformationToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAlabama);
            this.groupBox1.Controls.Add(this.radOhioState);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(239, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teams";
            // 
            // radAlabama
            // 
            this.radAlabama.AutoSize = true;
            this.radAlabama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radAlabama.Location = new System.Drawing.Point(6, 55);
            this.radAlabama.Name = "radAlabama";
            this.radAlabama.Size = new System.Drawing.Size(90, 24);
            this.radAlabama.TabIndex = 1;
            this.radAlabama.Text = "Alabama";
            this.radAlabama.UseVisualStyleBackColor = true;
            this.radAlabama.CheckedChanged += new System.EventHandler(this.radAlabama_CheckedChanged);
            // 
            // radOhioState
            // 
            this.radOhioState.AutoSize = true;
            this.radOhioState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radOhioState.Location = new System.Drawing.Point(6, 25);
            this.radOhioState.Name = "radOhioState";
            this.radOhioState.Size = new System.Drawing.Size(103, 24);
            this.radOhioState.TabIndex = 0;
            this.radOhioState.Text = "Ohio State";
            this.radOhioState.UseVisualStyleBackColor = true;
            this.radOhioState.CheckedChanged += new System.EventHandler(this.radOhioState_CheckedChanged);
            // 
            // lbxSchedules
            // 
            this.lbxSchedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbxSchedules.FormattingEnabled = true;
            this.lbxSchedules.ItemHeight = 20;
            this.lbxSchedules.Items.AddRange(new object[] {
            "Ohio State Schedule",
            "Alabama Schedule"});
            this.lbxSchedules.Location = new System.Drawing.Point(214, 261);
            this.lbxSchedules.Name = "lbxSchedules";
            this.lbxSchedules.Size = new System.Drawing.Size(175, 24);
            this.lbxSchedules.TabIndex = 4;
            this.lbxSchedules.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // picOhioBig
            // 
            this.picOhioBig.Image = ((System.Drawing.Image)(resources.GetObject("picOhioBig.Image")));
            this.picOhioBig.Location = new System.Drawing.Point(12, 60);
            this.picOhioBig.Name = "picOhioBig";
            this.picOhioBig.Size = new System.Drawing.Size(160, 160);
            this.picOhioBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOhioBig.TabIndex = 5;
            this.picOhioBig.TabStop = false;
            this.picOhioBig.Visible = false;
            // 
            // picAlabamaBig
            // 
            this.picAlabamaBig.Image = ((System.Drawing.Image)(resources.GetObject("picAlabamaBig.Image")));
            this.picAlabamaBig.Location = new System.Drawing.Point(434, 60);
            this.picAlabamaBig.Name = "picAlabamaBig";
            this.picAlabamaBig.Size = new System.Drawing.Size(160, 160);
            this.picAlabamaBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAlabamaBig.TabIndex = 6;
            this.picAlabamaBig.TabStop = false;
            this.picAlabamaBig.Visible = false;
            // 
            // cboOhioState
            // 
            this.cboOhioState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboOhioState.FormattingEnabled = true;
            this.cboOhioState.Items.AddRange(new object[] {
            "1920",
            "1949",
            "1954",
            "1957",
            "1968",
            "1970",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2013",
            "2014"});
            this.cboOhioState.Location = new System.Drawing.Point(12, 261);
            this.cboOhioState.Name = "cboOhioState";
            this.cboOhioState.Size = new System.Drawing.Size(160, 28);
            this.cboOhioState.TabIndex = 7;
            this.cboOhioState.SelectedIndexChanged += new System.EventHandler(this.cboOhioState_SelectedIndexChanged);
            // 
            // cboAlabama
            // 
            this.cboAlabama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboAlabama.FormattingEnabled = true;
            this.cboAlabama.Items.AddRange(new object[] {
            "1925",
            "1926",
            "1930",
            "1934",
            "1937",
            "1941",
            "1942",
            "1944",
            "1945",
            "1947",
            "1952",
            "1953",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1996",
            "1998",
            "1999",
            "2001",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014"});
            this.cboAlabama.Location = new System.Drawing.Point(434, 261);
            this.cboAlabama.Name = "cboAlabama";
            this.cboAlabama.Size = new System.Drawing.Size(160, 28);
            this.cboAlabama.TabIndex = 8;
            this.cboAlabama.SelectedIndexChanged += new System.EventHandler(this.cboAlabama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ohio State Bowl History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(429, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Alabama Bowl History";
            // 
            // lblOhioOutput
            // 
            this.lblOhioOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOhioOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOhioOutput.Location = new System.Drawing.Point(12, 296);
            this.lblOhioOutput.Name = "lblOhioOutput";
            this.lblOhioOutput.Size = new System.Drawing.Size(160, 109);
            this.lblOhioOutput.TabIndex = 11;
            // 
            // lblAlabamaOutput
            // 
            this.lblAlabamaOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAlabamaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAlabamaOutput.Location = new System.Drawing.Point(434, 296);
            this.lblAlabamaOutput.Name = "lblAlabamaOutput";
            this.lblAlabamaOutput.Size = new System.Drawing.Size(160, 109);
            this.lblAlabamaOutput.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(239, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "2014 Schedules";
            // 
            // btnPredict
            // 
            this.btnPredict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPredict.Location = new System.Drawing.Point(239, 325);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(128, 48);
            this.btnPredict.TabIndex = 14;
            this.btnPredict.Text = "My Prediction";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "2015 Sugar Bowl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Joshua Williams\r\nPeriod 0 GITA 1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAlabamaOutput);
            this.Controls.Add(this.lblOhioOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAlabama);
            this.Controls.Add(this.cboOhioState);
            this.Controls.Add(this.picAlabamaSmall);
            this.Controls.Add(this.picAlabamaBig);
            this.Controls.Add(this.picOhioSmall);
            this.Controls.Add(this.picOhioBig);
            this.Controls.Add(this.lbxSchedules);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Bowl Program";
            ((System.ComponentModel.ISupportInitialize)(this.picOhioSmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlabamaSmall)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOhioBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAlabamaBig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOhioSmall;
        private System.Windows.Forms.PictureBox picAlabamaSmall;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAlabama;
        private System.Windows.Forms.RadioButton radOhioState;
        private System.Windows.Forms.ToolStripMenuItem teamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predictionToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxSchedules;
        private System.Windows.Forms.ToolStripMenuItem schoolInformationToolStripMenuItem;
        private System.Windows.Forms.PictureBox picOhioBig;
        private System.Windows.Forms.PictureBox picAlabamaBig;
        private System.Windows.Forms.ComboBox cboOhioState;
        private System.Windows.Forms.ComboBox cboAlabama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOhioOutput;
        private System.Windows.Forms.Label lblAlabamaOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


namespace BMIProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHeightIn = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHeightFt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPeople = new System.Windows.Forms.Label();
            this.lblAverageBMI = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height (Feet):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Weight (Pounds):";
            // 
            // txtHeightIn
            // 
            this.txtHeightIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtHeightIn.Location = new System.Drawing.Point(174, 47);
            this.txtHeightIn.Name = "txtHeightIn";
            this.txtHeightIn.Size = new System.Drawing.Size(118, 29);
            this.txtHeightIn.TabIndex = 2;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtWeight.Location = new System.Drawing.Point(174, 82);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(118, 29);
            this.txtWeight.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(12, 123);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 35);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate BMI";
            this.toolTip1.SetToolTip(this.btnCalculate, "Click to calculate your BMI.");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your BMI:";
            // 
            // lblBMI
            // 
            this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBMI.Location = new System.Drawing.Point(110, 170);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(182, 24);
            this.lblBMI.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAverageBMI);
            this.groupBox1.Controls.Add(this.lblTotalPeople);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(16, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 97);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totals";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(174, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 35);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Click to clear the data.");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Height (Inches):";
            // 
            // txtHeightFt
            // 
            this.txtHeightFt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtHeightFt.Location = new System.Drawing.Point(174, 12);
            this.txtHeightFt.Name = "txtHeightFt";
            this.txtHeightFt.Size = new System.Drawing.Size(118, 29);
            this.txtHeightFt.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(16, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 123);
            this.label6.TabIndex = 11;
            this.label6.Text = "BMI Categories:\r\n\r\nUnderweight < 18.5\r\nAverage Weight = 18.5-24.9\r\nOverweight = 2" +
    "5-29.9\r\nObesity > 30";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total People:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Average BMI:";
            // 
            // lblTotalPeople
            // 
            this.lblTotalPeople.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalPeople.Location = new System.Drawing.Point(114, 35);
            this.lblTotalPeople.Name = "lblTotalPeople";
            this.lblTotalPeople.Size = new System.Drawing.Size(147, 20);
            this.lblTotalPeople.TabIndex = 2;
            // 
            // lblAverageBMI
            // 
            this.lblAverageBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAverageBMI.Location = new System.Drawing.Point(114, 61);
            this.lblAverageBMI.Name = "lblAverageBMI";
            this.lblAverageBMI.Size = new System.Drawing.Size(147, 20);
            this.lblAverageBMI.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Joshua Williams\r\nPeriod 0 GITA 1";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(105, 445);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 27);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Click to exit the program.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 481);
            this.Controls.Add(this.txtHeightFt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtHeightIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHeightIn;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHeightFt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalPeople;
        private System.Windows.Forms.Label lblAverageBMI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


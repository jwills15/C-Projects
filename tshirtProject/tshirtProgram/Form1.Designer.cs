namespace tshirtProgram
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radXXL = new System.Windows.Forms.RadioButton();
            this.radXLarge = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkMonogram = new System.Windows.Forms.CheckBox();
            this.chkPocket = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblExtendedPrice = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Very Very Boards";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExit.Location = new System.Drawing.Point(383, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radXXL);
            this.groupBox1.Controls.Add(this.radXLarge);
            this.groupBox1.Controls.Add(this.radLarge);
            this.groupBox1.Controls.Add(this.radMedium);
            this.groupBox1.Controls.Add(this.radSmall);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // radXXL
            // 
            this.radXXL.AutoSize = true;
            this.radXXL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radXXL.Location = new System.Drawing.Point(109, 62);
            this.radXXL.Name = "radXXL";
            this.radXXL.Size = new System.Drawing.Size(66, 28);
            this.radXXL.TabIndex = 4;
            this.radXXL.TabStop = true;
            this.radXXL.Text = "XXL";
            this.radXXL.UseVisualStyleBackColor = true;
            this.radXXL.CheckedChanged += new System.EventHandler(this.radXXL_CheckedChanged);
            // 
            // radXLarge
            // 
            this.radXLarge.AutoSize = true;
            this.radXLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radXLarge.Location = new System.Drawing.Point(109, 28);
            this.radXLarge.Name = "radXLarge";
            this.radXLarge.Size = new System.Drawing.Size(52, 28);
            this.radXLarge.TabIndex = 3;
            this.radXLarge.TabStop = true;
            this.radXLarge.Text = "XL";
            this.radXLarge.UseVisualStyleBackColor = true;
            this.radXLarge.CheckedChanged += new System.EventHandler(this.radXLarge_CheckedChanged);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radLarge.Location = new System.Drawing.Point(6, 96);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(76, 28);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radMedium.Location = new System.Drawing.Point(6, 62);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(97, 28);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Checked = true;
            this.radSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.radSmall.Location = new System.Drawing.Point(6, 28);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(74, 28);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F);
            this.btnAddToOrder.Location = new System.Drawing.Point(260, 152);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(191, 31);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "&Add to Current Order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // btnClearItem
            // 
            this.btnClearItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.btnClearItem.Location = new System.Drawing.Point(307, 186);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(144, 28);
            this.btnClearItem.TabIndex = 4;
            this.btnClearItem.Text = "Clea&r the Current Item";
            this.btnClearItem.UseVisualStyleBackColor = true;
            this.btnClearItem.Click += new System.EventHandler(this.btnClearItem_Click);
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCompleteOrder.Location = new System.Drawing.Point(275, 11);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(176, 51);
            this.btnCompleteOrder.TabIndex = 5;
            this.btnCompleteOrder.Text = "&Complete the Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Enabled = false;
            this.btnSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSummary.Location = new System.Drawing.Point(275, 68);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(176, 41);
            this.btnSummary.TabIndex = 6;
            this.btnSummary.Text = "&Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCustomerName.Location = new System.Drawing.Point(164, 13);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 29);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtOrderNumber.Location = new System.Drawing.Point(164, 48);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(100, 29);
            this.txtOrderNumber.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtQuantity.Location = new System.Drawing.Point(340, 119);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(111, 29);
            this.txtQuantity.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Order Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(251, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity:";
            // 
            // chkMonogram
            // 
            this.chkMonogram.AutoSize = true;
            this.chkMonogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chkMonogram.Location = new System.Drawing.Point(24, 28);
            this.chkMonogram.Name = "chkMonogram";
            this.chkMonogram.Size = new System.Drawing.Size(121, 28);
            this.chkMonogram.TabIndex = 13;
            this.chkMonogram.Text = "Monogram";
            this.chkMonogram.UseVisualStyleBackColor = true;
            this.chkMonogram.CheckedChanged += new System.EventHandler(this.chkMonogram_CheckedChanged);
            // 
            // chkPocket
            // 
            this.chkPocket.AutoSize = true;
            this.chkPocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chkPocket.Location = new System.Drawing.Point(24, 62);
            this.chkPocket.Name = "chkPocket";
            this.chkPocket.Size = new System.Drawing.Size(86, 28);
            this.chkPocket.TabIndex = 14;
            this.chkPocket.Text = "Pocket";
            this.chkPocket.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(17, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Item Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(17, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Extended Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(6, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Order Total:";
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblItemPrice.Location = new System.Drawing.Point(121, 159);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(133, 24);
            this.lblItemPrice.TabIndex = 18;
            // 
            // lblExtendedPrice
            // 
            this.lblExtendedPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtendedPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblExtendedPrice.Location = new System.Drawing.Point(168, 189);
            this.lblExtendedPrice.Name = "lblExtendedPrice";
            this.lblExtendedPrice.Size = new System.Drawing.Size(133, 24);
            this.lblExtendedPrice.TabIndex = 19;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblOrderTotal.Location = new System.Drawing.Point(131, 85);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(133, 24);
            this.lblOrderTotal.TabIndex = 20;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMonogram);
            this.groupBox2.Controls.Add(this.chkPocket);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.Location = new System.Drawing.Point(251, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 98);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Additons";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 26);
            this.label8.TabIndex = 22;
            this.label8.Text = "Joshua Williams\r\nPeriod 0 GITA 1";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(12, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(471, 2);
            this.label9.TabIndex = 23;
            this.label9.Text = "label9";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.btnAddToOrder);
            this.groupBox3.Controls.Add(this.btnClearItem);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.txtQuantity);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblExtendedPrice);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblItemPrice);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(15, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 228);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtCustomerName);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtOrderNumber);
            this.groupBox4.Controls.Add(this.btnSummary);
            this.groupBox4.Controls.Add(this.lblOrderTotal);
            this.groupBox4.Controls.Add(this.btnCompleteOrder);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(15, 59);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 123);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 428);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "T-Shirt Sales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radXXL;
        private System.Windows.Forms.RadioButton radXLarge;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnCompleteOrder;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkMonogram;
        private System.Windows.Forms.CheckBox chkPocket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblExtendedPrice;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}


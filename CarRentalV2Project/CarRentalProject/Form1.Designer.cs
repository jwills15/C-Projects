namespace CarRentalProject
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
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtBegin = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMiles = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAverageAmountSpent = new System.Windows.Forms.Label();
            this.lblTotalAmountReceived = new System.Windows.Forms.Label();
            this.lblTotalCarsReturned = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radCarThree = new System.Windows.Forms.RadioButton();
            this.radCarTwo = new System.Windows.Forms.RadioButton();
            this.radCarOne = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSeats = new System.Windows.Forms.CheckBox();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picBlank = new System.Windows.Forms.PictureBox();
            this.picCar1 = new System.Windows.Forms.PictureBox();
            this.picCar2 = new System.Windows.Forms.PictureBox();
            this.picCar3 = new System.Windows.Forms.PictureBox();
            this.picReset = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnExit.Location = new System.Drawing.Point(775, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Close the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblFN.Location = new System.Drawing.Point(12, 15);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(106, 24);
            this.lblFN.TabIndex = 1;
            this.lblFN.Text = "First Name:";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblLN.Location = new System.Drawing.Point(12, 50);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(104, 24);
            this.lblLN.TabIndex = 2;
            this.lblLN.Text = "Last Name:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblStreet.Location = new System.Drawing.Point(12, 85);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(63, 24);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Street:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCity.Location = new System.Drawing.Point(12, 120);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 24);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblState.Location = new System.Drawing.Point(12, 155);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(56, 24);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblZip.Location = new System.Drawing.Point(12, 190);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(93, 24);
            this.lblZip.TabIndex = 6;
            this.lblZip.Text = "Zip Code:";
            // 
            // txtFN
            // 
            this.txtFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtFN.Location = new System.Drawing.Point(134, 12);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(154, 29);
            this.txtFN.TabIndex = 1;
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLN.Location = new System.Drawing.Point(134, 47);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(154, 29);
            this.txtLN.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtStreet.Location = new System.Drawing.Point(134, 82);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(154, 29);
            this.txtStreet.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtCity.Location = new System.Drawing.Point(134, 117);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(154, 29);
            this.txtCity.TabIndex = 4;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtState.Location = new System.Drawing.Point(134, 152);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(154, 29);
            this.txtState.TabIndex = 5;
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtZip.Location = new System.Drawing.Point(134, 187);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(154, 29);
            this.txtZip.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 2);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnClear.Location = new System.Drawing.Point(499, 424);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 50);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Clear all user inputs");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCustomer.Location = new System.Drawing.Point(294, 12);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(246, 134);
            this.lblCustomer.TabIndex = 15;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(369, 149);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 62);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Customer Information";
            this.toolTip1.SetToolTip(this.btnSubmit, "Create label with customer information for receipt");
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBegin.Location = new System.Drawing.Point(495, 240);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(191, 24);
            this.lblBegin.TabIndex = 17;
            this.lblBegin.Text = "Beginning Odometer:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblEnd.Location = new System.Drawing.Point(495, 275);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(166, 24);
            this.lblEnd.TabIndex = 18;
            this.lblEnd.Text = "Ending Odometer:";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDays.Location = new System.Drawing.Point(495, 310);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(122, 24);
            this.lblDays.TabIndex = 19;
            this.lblDays.Text = "Days Rented:";
            // 
            // txtBegin
            // 
            this.txtBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBegin.Location = new System.Drawing.Point(692, 237);
            this.txtBegin.Name = "txtBegin";
            this.txtBegin.Size = new System.Drawing.Size(165, 29);
            this.txtBegin.TabIndex = 8;
            // 
            // txtEnd
            // 
            this.txtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtEnd.Location = new System.Drawing.Point(692, 272);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(165, 29);
            this.txtEnd.TabIndex = 9;
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtDays.Location = new System.Drawing.Point(692, 307);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(165, 29);
            this.txtDays.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCalculate.Location = new System.Drawing.Point(606, 424);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 50);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "&Calculate Charge";
            this.toolTip1.SetToolTip(this.btnCalculate, "Calculate the charge owed for renting the car");
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(496, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Miles Driven:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(495, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total Charge:";
            // 
            // lblMiles
            // 
            this.lblMiles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblMiles.Location = new System.Drawing.Point(692, 351);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(165, 24);
            this.lblMiles.TabIndex = 26;
            // 
            // lblCharge
            // 
            this.lblCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCharge.Location = new System.Drawing.Point(692, 385);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(165, 24);
            this.lblCharge.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAverageAmountSpent);
            this.groupBox1.Controls.Add(this.lblTotalAmountReceived);
            this.groupBox1.Controls.Add(this.lblTotalCarsReturned);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(546, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 181);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Totals";
            // 
            // lblAverageAmountSpent
            // 
            this.lblAverageAmountSpent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageAmountSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAverageAmountSpent.Location = new System.Drawing.Point(190, 135);
            this.lblAverageAmountSpent.Name = "lblAverageAmountSpent";
            this.lblAverageAmountSpent.Size = new System.Drawing.Size(121, 20);
            this.lblAverageAmountSpent.TabIndex = 5;
            // 
            // lblTotalAmountReceived
            // 
            this.lblTotalAmountReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmountReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalAmountReceived.Location = new System.Drawing.Point(190, 88);
            this.lblTotalAmountReceived.Name = "lblTotalAmountReceived";
            this.lblTotalAmountReceived.Size = new System.Drawing.Size(121, 20);
            this.lblTotalAmountReceived.TabIndex = 4;
            // 
            // lblTotalCarsReturned
            // 
            this.lblTotalCarsReturned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCarsReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCarsReturned.Location = new System.Drawing.Point(190, 37);
            this.lblTotalCarsReturned.Name = "lblTotalCarsReturned";
            this.lblTotalCarsReturned.Size = new System.Drawing.Size(121, 20);
            this.lblTotalCarsReturned.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(9, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Average Amount Spent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(9, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Amount Received";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(9, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Cars Returned";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radCarThree);
            this.groupBox2.Controls.Add(this.radCarTwo);
            this.groupBox2.Controls.Add(this.radCarOne);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.Location = new System.Drawing.Point(16, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 136);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Options";
            // 
            // radCarThree
            // 
            this.radCarThree.AutoSize = true;
            this.radCarThree.Location = new System.Drawing.Point(7, 97);
            this.radCarThree.Name = "radCarThree";
            this.radCarThree.Size = new System.Drawing.Size(249, 28);
            this.radCarThree.TabIndex = 2;
            this.radCarThree.TabStop = true;
            this.radCarThree.Text = "Car 3 ($25/day, $0.20/mile)";
            this.toolTip1.SetToolTip(this.radCarThree, "Select Car Three (Tesla)");
            this.radCarThree.UseVisualStyleBackColor = true;
            this.radCarThree.CheckedChanged += new System.EventHandler(this.radCarThree_CheckedChanged);
            // 
            // radCarTwo
            // 
            this.radCarTwo.AutoSize = true;
            this.radCarTwo.Location = new System.Drawing.Point(7, 63);
            this.radCarTwo.Name = "radCarTwo";
            this.radCarTwo.Size = new System.Drawing.Size(249, 28);
            this.radCarTwo.TabIndex = 1;
            this.radCarTwo.TabStop = true;
            this.radCarTwo.Text = "Car 2 ($20/day, $0.15/mile)";
            this.toolTip1.SetToolTip(this.radCarTwo, "Select Car Two (Ford F150)");
            this.radCarTwo.UseVisualStyleBackColor = true;
            this.radCarTwo.CheckedChanged += new System.EventHandler(this.radCarTwo_CheckedChanged);
            // 
            // radCarOne
            // 
            this.radCarOne.AutoSize = true;
            this.radCarOne.Location = new System.Drawing.Point(7, 29);
            this.radCarOne.Name = "radCarOne";
            this.radCarOne.Size = new System.Drawing.Size(249, 28);
            this.radCarOne.TabIndex = 0;
            this.radCarOne.TabStop = true;
            this.radCarOne.Text = "Car 1 ($15/day, $0.12/mile)";
            this.toolTip1.SetToolTip(this.radCarOne, "Select Car One (Honda Accord)");
            this.radCarOne.UseVisualStyleBackColor = true;
            this.radCarOne.CheckedChanged += new System.EventHandler(this.radCarOne_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSeats);
            this.groupBox3.Controls.Add(this.chkSound);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox3.Location = new System.Drawing.Point(121, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 91);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // chkSeats
            // 
            this.chkSeats.AutoSize = true;
            this.chkSeats.Location = new System.Drawing.Point(6, 57);
            this.chkSeats.Name = "chkSeats";
            this.chkSeats.Size = new System.Drawing.Size(226, 28);
            this.chkSeats.TabIndex = 1;
            this.chkSeats.Text = "Leather Seats (+$3/day)";
            this.toolTip1.SetToolTip(this.chkSeats, "Add optional leather seats");
            this.chkSeats.UseVisualStyleBackColor = true;
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.Location = new System.Drawing.Point(7, 29);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(216, 28);
            this.chkSound.TabIndex = 0;
            this.chkSound.Text = "Bose Sound (+$2/day)";
            this.toolTip1.SetToolTip(this.chkSound, "Add optional Bose sound");
            this.chkSound.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 3;
            this.label7.Text = "Joshua Williams\r\nPeriod 0 GITA 1";
            // 
            // picBlank
            // 
            this.picBlank.Location = new System.Drawing.Point(311, 269);
            this.picBlank.Name = "picBlank";
            this.picBlank.Size = new System.Drawing.Size(158, 96);
            this.picBlank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlank.TabIndex = 31;
            this.picBlank.TabStop = false;
            // 
            // picCar1
            // 
            this.picCar1.Image = ((System.Drawing.Image)(resources.GetObject("picCar1.Image")));
            this.picCar1.Location = new System.Drawing.Point(311, 269);
            this.picCar1.Name = "picCar1";
            this.picCar1.Size = new System.Drawing.Size(158, 96);
            this.picCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar1.TabIndex = 32;
            this.picCar1.TabStop = false;
            this.picCar1.Visible = false;
            // 
            // picCar2
            // 
            this.picCar2.Image = ((System.Drawing.Image)(resources.GetObject("picCar2.Image")));
            this.picCar2.Location = new System.Drawing.Point(311, 269);
            this.picCar2.Name = "picCar2";
            this.picCar2.Size = new System.Drawing.Size(158, 96);
            this.picCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar2.TabIndex = 33;
            this.picCar2.TabStop = false;
            this.picCar2.Visible = false;
            // 
            // picCar3
            // 
            this.picCar3.Image = ((System.Drawing.Image)(resources.GetObject("picCar3.Image")));
            this.picCar3.Location = new System.Drawing.Point(311, 269);
            this.picCar3.Name = "picCar3";
            this.picCar3.Size = new System.Drawing.Size(158, 96);
            this.picCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar3.TabIndex = 34;
            this.picCar3.TabStop = false;
            this.picCar3.Visible = false;
            // 
            // picReset
            // 
            this.picReset.Location = new System.Drawing.Point(311, 269);
            this.picReset.Name = "picReset";
            this.picReset.Size = new System.Drawing.Size(158, 96);
            this.picReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReset.TabIndex = 34;
            this.picReset.TabStop = false;
            this.picReset.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 486);
            this.Controls.Add(this.picCar3);
            this.Controls.Add(this.picReset);
            this.Controls.Add(this.picCar1);
            this.Controls.Add(this.picCar2);
            this.Controls.Add(this.picBlank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtBegin);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblBegin);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Car Rental";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtBegin;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAverageAmountSpent;
        private System.Windows.Forms.Label lblTotalAmountReceived;
        private System.Windows.Forms.Label lblTotalCarsReturned;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radCarThree;
        private System.Windows.Forms.RadioButton radCarTwo;
        private System.Windows.Forms.RadioButton radCarOne;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSeats;
        private System.Windows.Forms.CheckBox chkSound;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picBlank;
        private System.Windows.Forms.PictureBox picCar1;
        private System.Windows.Forms.PictureBox picCar2;
        private System.Windows.Forms.PictureBox picCar3;
        private System.Windows.Forms.PictureBox picReset;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


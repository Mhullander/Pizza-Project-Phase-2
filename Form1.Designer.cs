namespace Pizza_Project_Phase_1
{
    partial class frmPizzaParlor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaParlor));
            this.gpbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.mtbZip = new System.Windows.Forms.MaskedTextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.gpbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkSundriedTomato = new System.Windows.Forms.CheckBox();
            this.chkSpinach = new System.Windows.Forms.CheckBox();
            this.chkArtichoke = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkBlackOlive = new System.Windows.Forms.CheckBox();
            this.chkMushroom = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gpbSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.gpbPricing = new System.Windows.Forms.GroupBox();
            this.lblTaxTotal = new System.Windows.Forms.Label();
            this.lblGTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.gpbActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.gpbPayment = new System.Windows.Forms.GroupBox();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.gpbQuantity = new System.Windows.Forms.GroupBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrDT = new System.Windows.Forms.Timer(this.components);
            this.errProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            this.gpbToppings.SuspendLayout();
            this.gpbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.gpbPricing.SuspendLayout();
            this.gpbActions.SuspendLayout();
            this.gpbPayment.SuspendLayout();
            this.gpbQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCustomerInfo
            // 
            this.gpbCustomerInfo.Controls.Add(this.cboState);
            this.gpbCustomerInfo.Controls.Add(this.mtbZip);
            this.gpbCustomerInfo.Controls.Add(this.lblZip);
            this.gpbCustomerInfo.Controls.Add(this.lblState);
            this.gpbCustomerInfo.Controls.Add(this.txtCity);
            this.gpbCustomerInfo.Controls.Add(this.lblCity);
            this.gpbCustomerInfo.Controls.Add(this.txtAddress2);
            this.gpbCustomerInfo.Controls.Add(this.lblAddress2);
            this.gpbCustomerInfo.Controls.Add(this.txtAddress);
            this.gpbCustomerInfo.Controls.Add(this.lblAddress1);
            this.gpbCustomerInfo.Controls.Add(this.txtName);
            this.gpbCustomerInfo.Controls.Add(this.lblName);
            this.gpbCustomerInfo.Controls.Add(this.lblPhoneNumber);
            this.gpbCustomerInfo.Controls.Add(this.mtbPhone);
            this.gpbCustomerInfo.Location = new System.Drawing.Point(268, 76);
            this.gpbCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbCustomerInfo.Name = "gpbCustomerInfo";
            this.gpbCustomerInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbCustomerInfo.Size = new System.Drawing.Size(285, 306);
            this.gpbCustomerInfo.TabIndex = 0;
            this.gpbCustomerInfo.TabStop = false;
            this.gpbCustomerInfo.Text = "Customer Info";
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AS",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cboState.Location = new System.Drawing.Point(87, 218);
            this.cboState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboState.MaxLength = 2;
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(69, 24);
            this.cboState.TabIndex = 11;
            // 
            // mtbZip
            // 
            this.mtbZip.Location = new System.Drawing.Point(87, 255);
            this.mtbZip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbZip.Mask = "00000-9999";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(104, 22);
            this.mtbZip.TabIndex = 13;
            this.mtbZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbZip.Enter += new System.EventHandler(this.mtbZip_Enter);
            this.mtbZip.Leave += new System.EventHandler(this.mtbZip_Leave);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(5, 258);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(69, 17);
            this.lblZip.TabIndex = 12;
            this.lblZip.Text = "Zip Code:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(5, 218);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45, 17);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State:";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(87, 181);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(174, 22);
            this.txtCity.TabIndex = 9;
            this.txtCity.Enter += new System.EventHandler(this.txtCity_Enter);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(5, 181);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(35, 17);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City:";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(87, 143);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress2.MaxLength = 25;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(174, 22);
            this.txtAddress2.TabIndex = 7;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(5, 146);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(76, 17);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address 2:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(87, 107);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.MaxLength = 25;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(174, 22);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(5, 110);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(76, 17);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "A&ddress 1:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 71);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.MaxLength = 25;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 22);
            this.txtName.TabIndex = 3;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "&Name:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(5, 39);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(53, 17);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone:";
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(87, 34);
            this.mtbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbPhone.Mask = "(000) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.ResetOnSpace = false;
            this.mtbPhone.Size = new System.Drawing.Size(161, 22);
            this.mtbPhone.TabIndex = 1;
            this.mtbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbPhone.Enter += new System.EventHandler(this.mtbPhone_Enter);
            this.mtbPhone.Leave += new System.EventHandler(this.mtbPhone_Leave);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(343, -7);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(428, 71);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Marie\'s Pizza Parlor";
            // 
            // picPizza
            // 
            this.picPizza.Image = ((System.Drawing.Image)(resources.GetObject("picPizza.Image")));
            this.picPizza.Location = new System.Drawing.Point(21, 57);
            this.picPizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(227, 426);
            this.picPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizza.TabIndex = 4;
            this.picPizza.TabStop = false;
            // 
            // gpbToppings
            // 
            this.gpbToppings.Controls.Add(this.chkGreenPepper);
            this.gpbToppings.Controls.Add(this.chkSundriedTomato);
            this.gpbToppings.Controls.Add(this.chkSpinach);
            this.gpbToppings.Controls.Add(this.chkArtichoke);
            this.gpbToppings.Controls.Add(this.chkOnion);
            this.gpbToppings.Controls.Add(this.chkBlackOlive);
            this.gpbToppings.Controls.Add(this.chkMushroom);
            this.gpbToppings.Controls.Add(this.chkSausage);
            this.gpbToppings.Controls.Add(this.chkPepperoni);
            this.gpbToppings.Controls.Add(this.chkExtraCheese);
            this.gpbToppings.Location = new System.Drawing.Point(752, 76);
            this.gpbToppings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbToppings.Name = "gpbToppings";
            this.gpbToppings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbToppings.Size = new System.Drawing.Size(200, 338);
            this.gpbToppings.TabIndex = 2;
            this.gpbToppings.TabStop = false;
            this.gpbToppings.Text = "Toppings";
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPepper.Location = new System.Drawing.Point(16, 286);
            this.chkGreenPepper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(152, 28);
            this.chkGreenPepper.TabIndex = 9;
            this.chkGreenPepper.Text = "Green Pepper";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            // 
            // chkSundriedTomato
            // 
            this.chkSundriedTomato.AutoSize = true;
            this.chkSundriedTomato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSundriedTomato.Location = new System.Drawing.Point(15, 258);
            this.chkSundriedTomato.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSundriedTomato.Name = "chkSundriedTomato";
            this.chkSundriedTomato.Size = new System.Drawing.Size(184, 28);
            this.chkSundriedTomato.TabIndex = 8;
            this.chkSundriedTomato.Text = "Sun-dried Tomato";
            this.chkSundriedTomato.UseVisualStyleBackColor = true;
            // 
            // chkSpinach
            // 
            this.chkSpinach.AutoSize = true;
            this.chkSpinach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpinach.Location = new System.Drawing.Point(15, 230);
            this.chkSpinach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSpinach.Name = "chkSpinach";
            this.chkSpinach.Size = new System.Drawing.Size(101, 28);
            this.chkSpinach.TabIndex = 7;
            this.chkSpinach.Text = "Spinach";
            this.chkSpinach.UseVisualStyleBackColor = true;
            // 
            // chkArtichoke
            // 
            this.chkArtichoke.AutoSize = true;
            this.chkArtichoke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArtichoke.Location = new System.Drawing.Point(16, 202);
            this.chkArtichoke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkArtichoke.Name = "chkArtichoke";
            this.chkArtichoke.Size = new System.Drawing.Size(111, 28);
            this.chkArtichoke.TabIndex = 6;
            this.chkArtichoke.Text = "Artichoke";
            this.chkArtichoke.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(16, 174);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(84, 28);
            this.chkOnion.TabIndex = 5;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlive
            // 
            this.chkBlackOlive.AutoSize = true;
            this.chkBlackOlive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBlackOlive.Location = new System.Drawing.Point(16, 146);
            this.chkBlackOlive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBlackOlive.Name = "chkBlackOlive";
            this.chkBlackOlive.Size = new System.Drawing.Size(134, 28);
            this.chkBlackOlive.TabIndex = 4;
            this.chkBlackOlive.Text = "Black Olives";
            this.chkBlackOlive.UseVisualStyleBackColor = true;
            // 
            // chkMushroom
            // 
            this.chkMushroom.AutoSize = true;
            this.chkMushroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushroom.Location = new System.Drawing.Point(15, 118);
            this.chkMushroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMushroom.Name = "chkMushroom";
            this.chkMushroom.Size = new System.Drawing.Size(123, 28);
            this.chkMushroom.TabIndex = 3;
            this.chkMushroom.Text = "Mushroom";
            this.chkMushroom.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSausage.Location = new System.Drawing.Point(16, 90);
            this.chkSausage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(106, 28);
            this.chkSausage.TabIndex = 2;
            this.chkSausage.Text = "Sausa&ge";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPepperoni.Location = new System.Drawing.Point(16, 62);
            this.chkPepperoni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(120, 28);
            this.chkPepperoni.TabIndex = 1;
            this.chkPepperoni.Text = "&Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(16, 34);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(146, 28);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Text = "E&xtra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // gpbSize
            // 
            this.gpbSize.Controls.Add(this.radLarge);
            this.gpbSize.Controls.Add(this.radMedium);
            this.gpbSize.Controls.Add(this.radSmall);
            this.gpbSize.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSize.Location = new System.Drawing.Point(574, 116);
            this.gpbSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSize.Name = "gpbSize";
            this.gpbSize.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbSize.Size = new System.Drawing.Size(149, 127);
            this.gpbSize.TabIndex = 1;
            this.gpbSize.TabStop = false;
            this.gpbSize.Text = "Size";
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLarge.Location = new System.Drawing.Point(13, 90);
            this.radLarge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(73, 27);
            this.radLarge.TabIndex = 2;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "&Large";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMedium.Location = new System.Drawing.Point(13, 63);
            this.radMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(95, 27);
            this.radMedium.TabIndex = 1;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "&Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSmall.Location = new System.Drawing.Point(13, 36);
            this.radSmall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(72, 27);
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "&Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(7, 35);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 27);
            this.nudQuantity.TabIndex = 0;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gpbPricing
            // 
            this.gpbPricing.Controls.Add(this.lblTaxTotal);
            this.gpbPricing.Controls.Add(this.lblGTotal);
            this.gpbPricing.Controls.Add(this.label2);
            this.gpbPricing.Controls.Add(this.lblSub);
            this.gpbPricing.Controls.Add(this.lblGrandTotal);
            this.gpbPricing.Controls.Add(this.lblTax);
            this.gpbPricing.Controls.Add(this.lblSubtotal);
            this.gpbPricing.Location = new System.Drawing.Point(752, 513);
            this.gpbPricing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbPricing.Name = "gpbPricing";
            this.gpbPricing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbPricing.Size = new System.Drawing.Size(200, 102);
            this.gpbPricing.TabIndex = 9;
            this.gpbPricing.TabStop = false;
            this.gpbPricing.Text = "Pricing";
            // 
            // lblTaxTotal
            // 
            this.lblTaxTotal.AutoSize = true;
            this.lblTaxTotal.Location = new System.Drawing.Point(88, 55);
            this.lblTaxTotal.Name = "lblTaxTotal";
            this.lblTaxTotal.Size = new System.Drawing.Size(0, 17);
            this.lblTaxTotal.TabIndex = 6;
            // 
            // lblGTotal
            // 
            this.lblGTotal.AutoSize = true;
            this.lblGTotal.Location = new System.Drawing.Point(88, 80);
            this.lblGTotal.Name = "lblGTotal";
            this.lblGTotal.Size = new System.Drawing.Size(0, 17);
            this.lblGTotal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(88, 30);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(0, 17);
            this.lblSub.TabIndex = 3;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(34, 80);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(48, 17);
            this.lblGrandTotal.TabIndex = 2;
            this.lblGrandTotal.Text = "Total: ";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(43, 55);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(39, 17);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax: ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(15, 30);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(68, 17);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal: ";
            // 
            // gpbActions
            // 
            this.gpbActions.Controls.Add(this.btnClose);
            this.gpbActions.Controls.Add(this.btnAccept);
            this.gpbActions.Controls.Add(this.chkMute);
            this.gpbActions.Controls.Add(this.btnReset);
            this.gpbActions.Controls.Add(this.btnPrice);
            this.gpbActions.Location = new System.Drawing.Point(277, 434);
            this.gpbActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbActions.Name = "gpbActions";
            this.gpbActions.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbActions.Size = new System.Drawing.Size(451, 91);
            this.gpbActions.TabIndex = 3;
            this.gpbActions.TabStop = false;
            this.gpbActions.Text = "Actions";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(371, 21);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(248, 21);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 30);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Location = new System.Drawing.Point(376, 64);
            this.chkMute.Margin = new System.Windows.Forms.Padding(4);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(61, 21);
            this.chkMute.TabIndex = 4;
            this.chkMute.Text = "Mute";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(127, 21);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(13, 21);
            this.btnPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(75, 30);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "Pr&ice";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // gpbPayment
            // 
            this.gpbPayment.Controls.Add(this.cboPayment);
            this.gpbPayment.Location = new System.Drawing.Point(752, 420);
            this.gpbPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbPayment.Name = "gpbPayment";
            this.gpbPayment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbPayment.Size = new System.Drawing.Size(200, 89);
            this.gpbPayment.TabIndex = 4;
            this.gpbPayment.TabStop = false;
            this.gpbPayment.Text = "Payment";
            // 
            // cboPayment
            // 
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express",
            "Check",
            "Cash"});
            this.cboPayment.Location = new System.Drawing.Point(19, 46);
            this.cboPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(151, 24);
            this.cboPayment.TabIndex = 0;
            // 
            // gpbQuantity
            // 
            this.gpbQuantity.Controls.Add(this.nudQuantity);
            this.gpbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbQuantity.Location = new System.Drawing.Point(574, 269);
            this.gpbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.gpbQuantity.Name = "gpbQuantity";
            this.gpbQuantity.Padding = new System.Windows.Forms.Padding(4);
            this.gpbQuantity.Size = new System.Drawing.Size(149, 103);
            this.gpbQuantity.TabIndex = 2;
            this.gpbQuantity.TabStop = false;
            this.gpbQuantity.Text = "Quantity";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Location = new System.Drawing.Point(560, 76);
            this.lblOrderNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(107, 17);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Order Number: ";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(673, 76);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(16, 17);
            this.lblNumber.TabIndex = 15;
            this.lblNumber.Text = "0";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(48, 503);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(48, 543);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 17);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Time";
            // 
            // tmrDT
            // 
            this.tmrDT.Enabled = true;
            this.tmrDT.Interval = 1000;
            this.tmrDT.Tick += new System.EventHandler(this.tmrDT_Tick);
            // 
            // errProv
            // 
            this.errProv.ContainerControl = this;
            // 
            // frmPizzaParlor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1067, 626);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.gpbQuantity);
            this.Controls.Add(this.gpbPayment);
            this.Controls.Add(this.gpbActions);
            this.Controls.Add(this.gpbPricing);
            this.Controls.Add(this.gpbSize);
            this.Controls.Add(this.gpbToppings);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.gpbCustomerInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPizzaParlor";
            this.Text = "Pizza Parlor Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbCustomerInfo.ResumeLayout(false);
            this.gpbCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            this.gpbToppings.ResumeLayout(false);
            this.gpbToppings.PerformLayout();
            this.gpbSize.ResumeLayout(false);
            this.gpbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.gpbPricing.ResumeLayout(false);
            this.gpbPricing.PerformLayout();
            this.gpbActions.ResumeLayout(false);
            this.gpbActions.PerformLayout();
            this.gpbPayment.ResumeLayout(false);
            this.gpbQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCustomerInfo;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.MaskedTextBox mtbZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.GroupBox gpbToppings;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkSundriedTomato;
        private System.Windows.Forms.CheckBox chkSpinach;
        private System.Windows.Forms.CheckBox chkArtichoke;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkBlackOlive;
        private System.Windows.Forms.CheckBox chkMushroom;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox gpbSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.GroupBox gpbPricing;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.GroupBox gpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.GroupBox gpbPayment;
        private System.Windows.Forms.ComboBox cboPayment;
        private System.Windows.Forms.GroupBox gpbQuantity;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDT;
        private System.Windows.Forms.Label lblGTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblTaxTotal;
        private System.Windows.Forms.ErrorProvider errProv;
    }
}


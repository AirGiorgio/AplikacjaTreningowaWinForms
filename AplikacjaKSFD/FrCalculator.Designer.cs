namespace AplikacjaKSFD
{
    partial class FrCalculator
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
            this.btnReturn = new AplikacjaKSFD.RoundButtons();
            this.btnCalculate = new AplikacjaKSFD.RoundButtons();
            this.lbAmount = new System.Windows.Forms.Label();
            this.TbResult = new System.Windows.Forms.TextBox();
            this.btnSaveResult = new AplikacjaKSFD.RoundButtons();
            this.lbHelpSaveResult = new System.Windows.Forms.Label();
            this.lbHelp = new System.Windows.Forms.Label();
            this.lbformula = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbGender = new System.Windows.Forms.Label();
            this.rbtMale = new System.Windows.Forms.RadioButton();
            this.rbtFemale = new System.Windows.Forms.RadioButton();
            this.lbGenderHelp = new System.Windows.Forms.Label();
            this.lbActivity = new System.Windows.Forms.Label();
            this.comboActivity = new System.Windows.Forms.ComboBox();
            this.lbActivityHelp = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.TbHeight = new System.Windows.Forms.MaskedTextBox();
            this.lbHeightHelp = new System.Windows.Forms.Label();
            this.lbWeight = new System.Windows.Forms.Label();
            this.TbWeight = new System.Windows.Forms.MaskedTextBox();
            this.lbWeightHelp = new System.Windows.Forms.Label();
            this.lbGoal = new System.Windows.Forms.Label();
            this.comboGoal = new System.Windows.Forms.ComboBox();
            this.lbGoalHelp = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.TbAge = new System.Windows.Forms.MaskedTextBox();
            this.lbAgeHelp = new System.Windows.Forms.Label();
            this.lbCalculateHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(1000, 830);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(220, 110);
            this.btnReturn.TabIndex = 53;
            this.btnReturn.Text = "Powrót do menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnCalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(810, 150);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(220, 110);
            this.btnCalculate.TabIndex = 59;
            this.btnCalculate.Text = "Oblicz";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.btnCalculate_MouseLeave);
            this.btnCalculate.MouseHover += new System.EventHandler(this.btnCalculate_MouseHover);
            // 
            // lbAmount
            // 
            this.lbAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAmount.AutoSize = true;
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbAmount.Location = new System.Drawing.Point(700, 340);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(428, 25);
            this.lbAmount.TabIndex = 60;
            this.lbAmount.Text = "Twoje zapotrzebowanie kaloryczne wynosi:";
            // 
            // TbResult
            // 
            this.TbResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TbResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TbResult.Location = new System.Drawing.Point(810, 380);
            this.TbResult.Name = "TbResult";
            this.TbResult.ReadOnly = true;
            this.TbResult.Size = new System.Drawing.Size(220, 38);
            this.TbResult.TabIndex = 61;
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveResult.FlatAppearance.BorderSize = 0;
            this.btnSaveResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnSaveResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnSaveResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSaveResult.Location = new System.Drawing.Point(810, 560);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(220, 110);
            this.btnSaveResult.TabIndex = 62;
            this.btnSaveResult.Text = "Zapisz wynik";
            this.btnSaveResult.UseVisualStyleBackColor = false;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            this.btnSaveResult.MouseLeave += new System.EventHandler(this.btnSaveResult_MouseLeave);
            this.btnSaveResult.MouseHover += new System.EventHandler(this.btnSaveResult_MouseHover);
            // 
            // lbHelpSaveResult
            // 
            this.lbHelpSaveResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHelpSaveResult.AutoSize = true;
            this.lbHelpSaveResult.BackColor = System.Drawing.Color.Transparent;
            this.lbHelpSaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbHelpSaveResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbHelpSaveResult.Location = new System.Drawing.Point(740, 690);
            this.lbHelpSaveResult.Name = "lbHelpSaveResult";
            this.lbHelpSaveResult.Size = new System.Drawing.Size(367, 75);
            this.lbHelpSaveResult.TabIndex = 63;
            this.lbHelpSaveResult.Text = "Zapisz, jesli chcesz aby twój wynik\r\nmożna było wczytać później podczas\r\n        " +
    "       układania diety";
            // 
            // lbHelp
            // 
            this.lbHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbHelp.AutoSize = true;
            this.lbHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbHelp.Location = new System.Drawing.Point(590, 30);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbHelp.Size = new System.Drawing.Size(403, 50);
            this.lbHelp.TabIndex = 64;
            this.lbHelp.Text = "Najedź kursorem nad elementy interfejsu\r\n            aby uzyskać wskazówki";
            // 
            // lbformula
            // 
            this.lbformula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbformula.AutoSize = true;
            this.lbformula.BackColor = System.Drawing.Color.Transparent;
            this.lbformula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbformula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbformula.Location = new System.Drawing.Point(670, 430);
            this.lbformula.Name = "lbformula";
            this.lbformula.Size = new System.Drawing.Size(526, 100);
            this.lbformula.TabIndex = 65;
            this.lbformula.Text = "      Obliczono według wzoru Harrisa-Benedicta. \r\nSą to wyliczenia orientacyjne. " +
    "Mogą w nieznacznym\r\nstopniu różnić się u poszczególnych osób ze względu\r\n       " +
    "        na parametry dodatkowe.\r\n";
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(1030, 20);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 75);
            this.btnHelp.TabIndex = 66;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_MouseHover);
            // 
            // lbGender
            // 
            this.lbGender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGender.AutoSize = true;
            this.lbGender.BackColor = System.Drawing.Color.Transparent;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbGender.Location = new System.Drawing.Point(30, 180);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(77, 36);
            this.lbGender.TabIndex = 67;
            this.lbGender.Text = "Płeć";
            // 
            // rbtMale
            // 
            this.rbtMale.AutoSize = true;
            this.rbtMale.BackColor = System.Drawing.Color.Transparent;
            this.rbtMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rbtMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbtMale.Location = new System.Drawing.Point(210, 180);
            this.rbtMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbtMale.Name = "rbtMale";
            this.rbtMale.Size = new System.Drawing.Size(185, 36);
            this.rbtMale.TabIndex = 68;
            this.rbtMale.TabStop = true;
            this.rbtMale.Text = "Mężczyzna";
            this.rbtMale.UseVisualStyleBackColor = false;
            this.rbtMale.MouseLeave += new System.EventHandler(this.rbtMale_MouseLeave);
            this.rbtMale.MouseHover += new System.EventHandler(this.rbtMale_MouseHover);
            // 
            // rbtFemale
            // 
            this.rbtFemale.AutoSize = true;
            this.rbtFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbtFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.rbtFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbtFemale.Location = new System.Drawing.Point(400, 180);
            this.rbtFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbtFemale.Name = "rbtFemale";
            this.rbtFemale.Size = new System.Drawing.Size(140, 36);
            this.rbtFemale.TabIndex = 69;
            this.rbtFemale.TabStop = true;
            this.rbtFemale.Text = "Kobieta";
            this.rbtFemale.UseVisualStyleBackColor = false;
            this.rbtFemale.MouseLeave += new System.EventHandler(this.rbtFemale_MouseLeave);
            this.rbtFemale.MouseHover += new System.EventHandler(this.rbtFemale_MouseHover);
            // 
            // lbGenderHelp
            // 
            this.lbGenderHelp.AutoSize = true;
            this.lbGenderHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbGenderHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbGenderHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbGenderHelp.Location = new System.Drawing.Point(290, 230);
            this.lbGenderHelp.Name = "lbGenderHelp";
            this.lbGenderHelp.Size = new System.Drawing.Size(140, 25);
            this.lbGenderHelp.TabIndex = 77;
            this.lbGenderHelp.Text = "Zaznacz płeć";
            // 
            // lbActivity
            // 
            this.lbActivity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbActivity.AutoSize = true;
            this.lbActivity.BackColor = System.Drawing.Color.Transparent;
            this.lbActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbActivity.Location = new System.Drawing.Point(10, 270);
            this.lbActivity.Name = "lbActivity";
            this.lbActivity.Size = new System.Drawing.Size(178, 72);
            this.lbActivity.TabIndex = 78;
            this.lbActivity.Text = "Aktywność \r\nfizyczna";
            // 
            // comboActivity
            // 
            this.comboActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboActivity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboActivity.FormattingEnabled = true;
            this.comboActivity.Items.AddRange(new object[] {
            "Znikoma",
            "Niska",
            "Umiarkowana",
            "Wysoka",
            "Bardzo wysoka"});
            this.comboActivity.Location = new System.Drawing.Point(190, 290);
            this.comboActivity.Name = "comboActivity";
            this.comboActivity.Size = new System.Drawing.Size(340, 39);
            this.comboActivity.TabIndex = 79;
            this.comboActivity.MouseLeave += new System.EventHandler(this.comboActivity_MouseLeave);
            this.comboActivity.MouseHover += new System.EventHandler(this.comboActivity_MouseHover);
            // 
            // lbActivityHelp
            // 
            this.lbActivityHelp.AutoSize = true;
            this.lbActivityHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbActivityHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbActivityHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbActivityHelp.Location = new System.Drawing.Point(185, 350);
            this.lbActivityHelp.Name = "lbActivityHelp";
            this.lbActivityHelp.Size = new System.Drawing.Size(344, 25);
            this.lbActivityHelp.TabIndex = 80;
            this.lbActivityHelp.Text = "Wybierz swoją aktywność fizyczną";
            // 
            // lbHeight
            // 
            this.lbHeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHeight.AutoSize = true;
            this.lbHeight.BackColor = System.Drawing.Color.Transparent;
            this.lbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbHeight.Location = new System.Drawing.Point(10, 425);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(115, 36);
            this.lbHeight.TabIndex = 81;
            this.lbHeight.Text = "Wzrost";
            // 
            // TbHeight
            // 
            this.TbHeight.BeepOnError = true;
            this.TbHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TbHeight.Location = new System.Drawing.Point(190, 425);
            this.TbHeight.Name = "TbHeight";
            this.TbHeight.Size = new System.Drawing.Size(340, 38);
            this.TbHeight.TabIndex = 82;
            this.TbHeight.MouseLeave += new System.EventHandler(this.TbHeight_MouseLeave);
            this.TbHeight.MouseHover += new System.EventHandler(this.TbHeight_MouseHover);
            // 
            // lbHeightHelp
            // 
            this.lbHeightHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbHeightHelp.AutoSize = true;
            this.lbHeightHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbHeightHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbHeightHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbHeightHelp.Location = new System.Drawing.Point(260, 485);
            this.lbHeightHelp.Name = "lbHeightHelp";
            this.lbHeightHelp.Size = new System.Drawing.Size(184, 25);
            this.lbHeightHelp.TabIndex = 83;
            this.lbHeightHelp.Text = "Podaj swój wzrost";
            // 
            // lbWeight
            // 
            this.lbWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbWeight.AutoSize = true;
            this.lbWeight.BackColor = System.Drawing.Color.Transparent;
            this.lbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbWeight.Location = new System.Drawing.Point(10, 680);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(97, 36);
            this.lbWeight.TabIndex = 84;
            this.lbWeight.Text = "Waga";
            // 
            // TbWeight
            // 
            this.TbWeight.BeepOnError = true;
            this.TbWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TbWeight.Location = new System.Drawing.Point(190, 680);
            this.TbWeight.Name = "TbWeight";
            this.TbWeight.Size = new System.Drawing.Size(340, 38);
            this.TbWeight.TabIndex = 85;
            this.TbWeight.ValidatingType = typeof(int);
            this.TbWeight.MouseLeave += new System.EventHandler(this.TbWeight_MouseLeave);
            this.TbWeight.MouseHover += new System.EventHandler(this.TbWeight_MouseHover);
            // 
            // lbWeightHelp
            // 
            this.lbWeightHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbWeightHelp.AutoSize = true;
            this.lbWeightHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbWeightHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbWeightHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbWeightHelp.Location = new System.Drawing.Point(260, 735);
            this.lbWeightHelp.Name = "lbWeightHelp";
            this.lbWeightHelp.Size = new System.Drawing.Size(185, 25);
            this.lbWeightHelp.TabIndex = 86;
            this.lbWeightHelp.Text = "Podaj swoją wagę";
            // 
            // lbGoal
            // 
            this.lbGoal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGoal.AutoSize = true;
            this.lbGoal.BackColor = System.Drawing.Color.Transparent;
            this.lbGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbGoal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbGoal.Location = new System.Drawing.Point(10, 815);
            this.lbGoal.Name = "lbGoal";
            this.lbGoal.Size = new System.Drawing.Size(133, 36);
            this.lbGoal.TabIndex = 87;
            this.lbGoal.Text = "Twój cel";
            // 
            // comboGoal
            // 
            this.comboGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboGoal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboGoal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboGoal.FormattingEnabled = true;
            this.comboGoal.Items.AddRange(new object[] {
            "Chcę schudnać",
            "Chcę utrzymać wagę",
            "Chcę przytyć"});
            this.comboGoal.Location = new System.Drawing.Point(190, 810);
            this.comboGoal.Name = "comboGoal";
            this.comboGoal.Size = new System.Drawing.Size(340, 39);
            this.comboGoal.TabIndex = 88;
            this.comboGoal.MouseLeave += new System.EventHandler(this.comboGoal_MouseLeave);
            this.comboGoal.MouseHover += new System.EventHandler(this.comboGoal_MouseHover);
            // 
            // lbGoalHelp
            // 
            this.lbGoalHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGoalHelp.AutoSize = true;
            this.lbGoalHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbGoalHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbGoalHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbGoalHelp.Location = new System.Drawing.Point(230, 880);
            this.lbGoalHelp.Name = "lbGoalHelp";
            this.lbGoalHelp.Size = new System.Drawing.Size(260, 25);
            this.lbGoalHelp.TabIndex = 89;
            this.lbGoalHelp.Text = "Podaj swój cel treningowy";
            // 
            // lbAge
            // 
            this.lbAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAge.AutoSize = true;
            this.lbAge.BackColor = System.Drawing.Color.Transparent;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbAge.Location = new System.Drawing.Point(10, 550);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(86, 36);
            this.lbAge.TabIndex = 90;
            this.lbAge.Text = "Wiek";
            // 
            // TbAge
            // 
            this.TbAge.BeepOnError = true;
            this.TbAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TbAge.Location = new System.Drawing.Point(190, 550);
            this.TbAge.Name = "TbAge";
            this.TbAge.Size = new System.Drawing.Size(340, 38);
            this.TbAge.TabIndex = 91;
            this.TbAge.MouseLeave += new System.EventHandler(this.TbAge_MouseLeave);
            this.TbAge.MouseHover += new System.EventHandler(this.TbAge_MouseHover);
            // 
            // lbAgeHelp
            // 
            this.lbAgeHelp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbAgeHelp.AutoSize = true;
            this.lbAgeHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbAgeHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAgeHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbAgeHelp.Location = new System.Drawing.Point(260, 610);
            this.lbAgeHelp.Name = "lbAgeHelp";
            this.lbAgeHelp.Size = new System.Drawing.Size(165, 25);
            this.lbAgeHelp.TabIndex = 92;
            this.lbAgeHelp.Text = "Podaj swój wiek";
            // 
            // lbCalculateHelp
            // 
            this.lbCalculateHelp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbCalculateHelp.AutoSize = true;
            this.lbCalculateHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbCalculateHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCalculateHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbCalculateHelp.Location = new System.Drawing.Point(730, 275);
            this.lbCalculateHelp.Name = "lbCalculateHelp";
            this.lbCalculateHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbCalculateHelp.Size = new System.Drawing.Size(375, 50);
            this.lbCalculateHelp.TabIndex = 93;
            this.lbCalculateHelp.Text = "    Wprowadź wszystkie swoje dane\r\ni kliknij ten przycisk aby obliczyć BMR";
            // 
            // FrCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::AplikacjaKSFD.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.lbCalculateHelp);
            this.Controls.Add(this.lbAgeHelp);
            this.Controls.Add(this.TbAge);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbGoalHelp);
            this.Controls.Add(this.comboGoal);
            this.Controls.Add(this.lbGoal);
            this.Controls.Add(this.lbWeightHelp);
            this.Controls.Add(this.TbWeight);
            this.Controls.Add(this.lbWeight);
            this.Controls.Add(this.lbHeightHelp);
            this.Controls.Add(this.TbHeight);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbActivityHelp);
            this.Controls.Add(this.comboActivity);
            this.Controls.Add(this.lbActivity);
            this.Controls.Add(this.lbGenderHelp);
            this.Controls.Add(this.rbtFemale);
            this.Controls.Add(this.rbtMale);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lbformula);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.lbHelpSaveResult);
            this.Controls.Add(this.btnSaveResult);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReturn);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrCalculator";
            this.ShowIcon = false;
            this.Text = "Kalkulator BMR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButtons btnReturn;
        private RoundButtons btnCalculate;
        private Label lbAmount;
        private TextBox TbResult;
        private RoundButtons btnSaveResult;
        private Label lbHelpSaveResult;
        private Label lbHelp;
        private Label lbformula;
        private Button btnHelp;
        private Label lbGender;
        private RadioButton rbtMale;
        private RadioButton rbtFemale;
        private Label lbGenderHelp;
        private Label lbActivity;
        private ComboBox comboActivity;
        private Label lbActivityHelp;
        private Label lbHeight;
        private MaskedTextBox TbHeight;
        private Label lbHeightHelp;
        private Label lbWeight;
        private MaskedTextBox TbWeight;
        private Label lbWeightHelp;
        private Label lbGoal;
        private ComboBox comboGoal;
        private Label lbGoalHelp;
        private Label lbAge;
        private MaskedTextBox TbAge;
        private Label lbAgeHelp;
        private Label lbCalculateHelp;
    }
}
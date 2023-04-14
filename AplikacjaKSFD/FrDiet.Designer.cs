namespace AplikacjaKSFD
{
    partial class FrDiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrDiet));
            this.lbState = new System.Windows.Forms.Label();
            this.btnLoad = new AplikacjaKSFD.RoundButtons();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.comboAmount = new System.Windows.Forms.ComboBox();
            this.TbLoad = new System.Windows.Forms.TextBox();
            this.BtnHint = new AplikacjaKSFD.RoundButtons();
            this.btnReturn = new AplikacjaKSFD.RoundButtons();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbProduct = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.TbAmount = new System.Windows.Forms.MaskedTextBox();
            this.btnCalculate = new AplikacjaKSFD.RoundButtons();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.btnPrevious = new AplikacjaKSFD.RoundButtons();
            this.btnNext = new AplikacjaKSFD.RoundButtons();
            this.btnAdd = new AplikacjaKSFD.RoundButtons();
            this.btnRemove = new AplikacjaKSFD.RoundButtons();
            this.btnSave = new AplikacjaKSFD.RoundButtons();
            this.lbCategoryHelp = new System.Windows.Forms.Label();
            this.lbProductHelp = new System.Windows.Forms.Label();
            this.lbAmountHelp = new System.Windows.Forms.Label();
            this.lbCalculateHelp = new System.Windows.Forms.Label();
            this.lbSaveHelp = new System.Windows.Forms.Label();
            this.lbResultHelp = new System.Windows.Forms.Label();
            this.lbResultAmount = new System.Windows.Forms.Label();
            this.lbHelp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.BackColor = System.Drawing.Color.Transparent;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbState.Location = new System.Drawing.Point(420, 30);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(977, 128);
            this.lbState.TabIndex = 43;
            this.lbState.Text = resources.GetString("lbState.Text");
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(540, 500);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(220, 110);
            this.btnLoad.TabIndex = 46;
            this.btnLoad.Text = "Wczytaj wynik z kalkulatora";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(1150, 50);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 75);
            this.btnHelp.TabIndex = 49;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_MouseHover);
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lbQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbQuestion.Location = new System.Drawing.Point(300, 260);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(752, 32);
            this.lbQuestion.TabIndex = 50;
            this.lbQuestion.Text = "Z ilu posiłków chciałbyś, aby składała się Twoja dieta?\r\n";
            // 
            // comboAmount
            // 
            this.comboAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAmount.DropDownWidth = 120;
            this.comboAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboAmount.FormattingEnabled = true;
            this.comboAmount.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6"});
            this.comboAmount.Location = new System.Drawing.Point(590, 330);
            this.comboAmount.Name = "comboAmount";
            this.comboAmount.Size = new System.Drawing.Size(120, 50);
            this.comboAmount.TabIndex = 51;
            this.comboAmount.SelectedIndexChanged += new System.EventHandler(this.comboAmount_SelectedIndexChanged);
            // 
            // TbLoad
            // 
            this.TbLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TbLoad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TbLoad.Location = new System.Drawing.Point(590, 650);
            this.TbLoad.Name = "TbLoad";
            this.TbLoad.ReadOnly = true;
            this.TbLoad.Size = new System.Drawing.Size(128, 49);
            this.TbLoad.TabIndex = 52;
            // 
            // BtnHint
            // 
            this.BtnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnHint.FlatAppearance.BorderSize = 0;
            this.BtnHint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.BtnHint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.BtnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnHint.Location = new System.Drawing.Point(38, 176);
            this.BtnHint.Name = "BtnHint";
            this.BtnHint.Size = new System.Drawing.Size(220, 110);
            this.BtnHint.TabIndex = 53;
            this.BtnHint.Text = "Wskazówki";
            this.BtnHint.UseVisualStyleBackColor = false;
            this.BtnHint.Click += new System.EventHandler(this.BtnHint_Click);
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
            this.btnReturn.Location = new System.Drawing.Point(1032, 842);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(187, 85);
            this.btnReturn.TabIndex = 54;
            this.btnReturn.Text = "Powrót do menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.BackColor = System.Drawing.Color.Transparent;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbCategory.Location = new System.Drawing.Point(10, 335);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(146, 32);
            this.lbCategory.TabIndex = 55;
            this.lbCategory.Text = "Kategoria\r\n";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbAmount.Location = new System.Drawing.Point(38, 574);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(77, 32);
            this.lbAmount.TabIndex = 56;
            this.lbAmount.Text = "Ilość\r\n";
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.BackColor = System.Drawing.Color.Transparent;
            this.lbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbProduct.Location = new System.Drawing.Point(23, 448);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(119, 32);
            this.lbProduct.TabIndex = 57;
            this.lbProduct.Text = "Produkt\r\n";
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.DropDownWidth = 408;
            this.comboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Items.AddRange(new object[] {
            "Zboża",
            "Nabiał",
            "Tłuszcze",
            "Ryby",
            "Owoce",
            "Białko i mięsa",
            "Suplementy",
            "Warzywa"});
            this.comboCategory.Location = new System.Drawing.Point(180, 330);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(408, 39);
            this.comboCategory.TabIndex = 58;
            this.comboCategory.SelectedIndexChanged += new System.EventHandler(this.comboCategory_SelectedIndexChanged);
            this.comboCategory.MouseLeave += new System.EventHandler(this.comboCategory_MouseLeave);
            this.comboCategory.MouseHover += new System.EventHandler(this.comboCategory_MouseHover);
            // 
            // comboProduct
            // 
            this.comboProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProduct.DropDownWidth = 408;
            this.comboProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(180, 445);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(408, 39);
            this.comboProduct.TabIndex = 59;
            this.comboProduct.MouseLeave += new System.EventHandler(this.comboProduct_MouseLeave);
            this.comboProduct.MouseHover += new System.EventHandler(this.comboProduct_MouseHover);
            // 
            // TbAmount
            // 
            this.TbAmount.BeepOnError = true;
            this.TbAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TbAmount.Location = new System.Drawing.Point(180, 570);
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(408, 38);
            this.TbAmount.TabIndex = 60;
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
            this.btnCalculate.Location = new System.Drawing.Point(251, 650);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(180, 90);
            this.btnCalculate.TabIndex = 61;
            this.btnCalculate.Text = "Przelicz";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.btnCalculate_MouseLeave);
            this.btnCalculate.MouseHover += new System.EventHandler(this.btnCalculate_MouseHover);
            // 
            // tbResult
            // 
            this.tbResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tbResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbResult.Location = new System.Drawing.Point(251, 819);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(179, 41);
            this.tbResult.TabIndex = 62;
            this.tbResult.MouseLeave += new System.EventHandler(this.tbResult_MouseLeave);
            this.tbResult.MouseHover += new System.EventHandler(this.tbResult_MouseHover);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(607, 461);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(88, 77);
            this.btnPrevious.TabIndex = 63;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(1112, 461);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 77);
            this.btnNext.TabIndex = 64;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(485, 728);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 70);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Dodaj do listy";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(485, 842);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 70);
            this.btnRemove.TabIndex = 67;
            this.btnRemove.Text = "Usuń z listy";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(666, 842);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 90);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Zapisz do pliku";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // lbCategoryHelp
            // 
            this.lbCategoryHelp.AutoSize = true;
            this.lbCategoryHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbCategoryHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCategoryHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbCategoryHelp.Location = new System.Drawing.Point(204, 389);
            this.lbCategoryHelp.Name = "lbCategoryHelp";
            this.lbCategoryHelp.Size = new System.Drawing.Size(280, 50);
            this.lbCategoryHelp.TabIndex = 69;
            this.lbCategoryHelp.Text = "Wybierz kategorię żywności\r\n\r\n";
            // 
            // lbProductHelp
            // 
            this.lbProductHelp.AutoSize = true;
            this.lbProductHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbProductHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbProductHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbProductHelp.Location = new System.Drawing.Point(162, 513);
            this.lbProductHelp.Name = "lbProductHelp";
            this.lbProductHelp.Size = new System.Drawing.Size(333, 25);
            this.lbProductHelp.TabIndex = 70;
            this.lbProductHelp.Text = "Wybierz produkt z danej kategorii\r\n";
            // 
            // lbAmountHelp
            // 
            this.lbAmountHelp.AutoSize = true;
            this.lbAmountHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbAmountHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbAmountHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbAmountHelp.Location = new System.Drawing.Point(41, 622);
            this.lbAmountHelp.Name = "lbAmountHelp";
            this.lbAmountHelp.Size = new System.Drawing.Size(557, 25);
            this.lbAmountHelp.TabIndex = 71;
            this.lbAmountHelp.Text = "Tu wpisz ilość produktu podaną w gramach lub mililitrach";
            // 
            // lbCalculateHelp
            // 
            this.lbCalculateHelp.AutoSize = true;
            this.lbCalculateHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbCalculateHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbCalculateHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbCalculateHelp.Location = new System.Drawing.Point(100, 764);
            this.lbCalculateHelp.Name = "lbCalculateHelp";
            this.lbCalculateHelp.Size = new System.Drawing.Size(275, 50);
            this.lbCalculateHelp.TabIndex = 72;
            this.lbCalculateHelp.Text = "Wciśnij aby przeliczyć ilość\r\n      produktu na kalorie\r\n";
            // 
            // lbSaveHelp
            // 
            this.lbSaveHelp.AutoSize = true;
            this.lbSaveHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbSaveHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbSaveHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbSaveHelp.Location = new System.Drawing.Point(623, 933);
            this.lbSaveHelp.Name = "lbSaveHelp";
            this.lbSaveHelp.Size = new System.Drawing.Size(292, 25);
            this.lbSaveHelp.TabIndex = 73;
            this.lbSaveHelp.Text = "Zapisz swoją listę na pulpicie";
            // 
            // lbResultHelp
            // 
            this.lbResultHelp.AutoSize = true;
            this.lbResultHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbResultHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbResultHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbResultHelp.Location = new System.Drawing.Point(150, 877);
            this.lbResultHelp.Name = "lbResultHelp";
            this.lbResultHelp.Size = new System.Drawing.Size(356, 50);
            this.lbResultHelp.TabIndex = 74;
            this.lbResultHelp.Text = "Tu pojawi się wynik po przeliczeniu \r\n     ilości produktu na ilość kalorii\r\n";
            // 
            // lbResultAmount
            // 
            this.lbResultAmount.AutoSize = true;
            this.lbResultAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbResultAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbResultAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbResultAmount.Location = new System.Drawing.Point(38, 821);
            this.lbResultAmount.Name = "lbResultAmount";
            this.lbResultAmount.Size = new System.Drawing.Size(177, 32);
            this.lbResultAmount.TabIndex = 75;
            this.lbResultAmount.Text = "Ilość kalorii:";
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbHelp.Location = new System.Drawing.Point(822, 176);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(403, 50);
            this.lbHelp.TabIndex = 76;
            this.lbHelp.Text = "Najedź kursorem nad elementy interfejsu\r\n            aby uzyskać wskazówki\r\n";
            // 
            // FrDiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AplikacjaKSFD.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.lbResultAmount);
            this.Controls.Add(this.lbResultHelp);
            this.Controls.Add(this.lbSaveHelp);
            this.Controls.Add(this.lbCalculateHelp);
            this.Controls.Add(this.lbAmountHelp);
            this.Controls.Add(this.lbProductHelp);
            this.Controls.Add(this.lbCategoryHelp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.TbAmount);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.BtnHint);
            this.Controls.Add(this.TbLoad);
            this.Controls.Add(this.comboAmount);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lbState);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "FrDiet";
            this.ShowIcon = false;
            this.Text = "Ułóż Dietę";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbState;
        private RoundButtons btnLoad;
        private Button btnHelp;
        private Label lbQuestion;
        private ComboBox comboAmount;
        private TextBox TbLoad;
        private RoundButtons BtnHint;
        private RoundButtons btnReturn;
        private Label lbCategory;
        private Label lbAmount;
        private Label lbProduct;
        private ComboBox comboCategory;
        private ComboBox comboProduct;
        private MaskedTextBox TbAmount;
        private RoundButtons btnCalculate;
        private TextBox tbResult;
        private RoundButtons btnPrevious;
        private RoundButtons btnNext;
        private RoundButtons btnAdd;
        private RoundButtons btnRemove;
        private RoundButtons btnSave;
        private Label lbCategoryHelp;
        private Label lbProductHelp;
        private Label lbAmountHelp;
        private Label lbCalculateHelp;
        private Label lbSaveHelp;
        private Label lbResultHelp;
        private Label lbResultAmount;
        private Label lbHelp;
    }
}
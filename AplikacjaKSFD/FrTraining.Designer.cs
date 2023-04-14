namespace AplikacjaKSFD
{
    partial class FrTraining
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
            this.picbox = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lbHelp = new System.Windows.Forms.Label();
            this.comboBodyPart = new System.Windows.Forms.ComboBox();
            this.comboTrainingAmount = new System.Windows.Forms.ComboBox();
            this.comboExercise = new System.Windows.Forms.ComboBox();
            this.btnNext = new AplikacjaKSFD.RoundButtons();
            this.btnPrevious = new AplikacjaKSFD.RoundButtons();
            this.lbGalery = new System.Windows.Forms.Label();
            this.lbTrainingAmount = new System.Windows.Forms.Label();
            this.lbExercise = new System.Windows.Forms.Label();
            this.lbBodyPart = new System.Windows.Forms.Label();
            this.comboSerieAmount = new System.Windows.Forms.ComboBox();
            this.btnReturn = new AplikacjaKSFD.RoundButtons();
            this.btnAdd = new AplikacjaKSFD.RoundButtons();
            this.btnDescription = new AplikacjaKSFD.RoundButtons();
            this.btnRemove = new AplikacjaKSFD.RoundButtons();
            this.BtnHint = new AplikacjaKSFD.RoundButtons();
            this.lbScrollHelp = new System.Windows.Forms.Label();
            this.btnSave = new AplikacjaKSFD.RoundButtons();
            this.lbSerie = new System.Windows.Forms.Label();
            this.lbSaveHelp = new System.Windows.Forms.Label();
            this.lbTrainingAmountHelp = new System.Windows.Forms.Label();
            this.lbBodyPartHelp = new System.Windows.Forms.Label();
            this.lbExerciseHelp = new System.Windows.Forms.Label();
            this.lbSerieAmountHelp = new System.Windows.Forms.Label();
            this.btnNextList = new AplikacjaKSFD.RoundButtons();
            this.btnPrevList = new AplikacjaKSFD.RoundButtons();
            this.lbDescriptionHelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox
            // 
            this.picbox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbox.InitialImage = null;
            this.picbox.Location = new System.Drawing.Point(770, 83);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(480, 582);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 0;
            this.picbox.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHelp.Location = new System.Drawing.Point(437, 30);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 75);
            this.btnHelp.TabIndex = 13;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            this.btnHelp.MouseLeave += new System.EventHandler(this.btnHelp_MouseLeave);
            this.btnHelp.MouseHover += new System.EventHandler(this.btnHelp_MouseHover);
            // 
            // lbHelp
            // 
            this.lbHelp.AutoSize = true;
            this.lbHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbHelp.Location = new System.Drawing.Point(555, 40);
            this.lbHelp.Name = "lbHelp";
            this.lbHelp.Size = new System.Drawing.Size(403, 50);
            this.lbHelp.TabIndex = 43;
            this.lbHelp.Text = "Najedź kursorem nad elementy interfejsu\r\n            aby uzyskać wskazówki";
            // 
            // comboBodyPart
            // 
            this.comboBodyPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBodyPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBodyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboBodyPart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBodyPart.FormattingEnabled = true;
            this.comboBodyPart.Items.AddRange(new object[] {
            "Barki",
            "Ramiona",
            "Plecy",
            "Klatka",
            "Brzuch",
            "Nogi"});
            this.comboBodyPart.Location = new System.Drawing.Point(12, 264);
            this.comboBodyPart.Name = "comboBodyPart";
            this.comboBodyPart.Size = new System.Drawing.Size(300, 39);
            this.comboBodyPart.TabIndex = 44;
            this.comboBodyPart.SelectedIndexChanged += new System.EventHandler(this.comboBodyPart_SelectedIndexChanged);
            this.comboBodyPart.MouseLeave += new System.EventHandler(this.comboBodyPart_MouseLeave);
            this.comboBodyPart.MouseHover += new System.EventHandler(this.comboBodyPart_MouseHover);
            // 
            // comboTrainingAmount
            // 
            this.comboTrainingAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboTrainingAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrainingAmount.DropDownWidth = 500;
            this.comboTrainingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboTrainingAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboTrainingAmount.FormattingEnabled = true;
            this.comboTrainingAmount.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboTrainingAmount.Location = new System.Drawing.Point(245, 171);
            this.comboTrainingAmount.Name = "comboTrainingAmount";
            this.comboTrainingAmount.Size = new System.Drawing.Size(500, 39);
            this.comboTrainingAmount.TabIndex = 45;
            this.comboTrainingAmount.SelectedIndexChanged += new System.EventHandler(this.comboTrainingAmount_SelectedIndexChanged);
            this.comboTrainingAmount.MouseLeave += new System.EventHandler(this.comboTrainingAmount_MouseLeave);
            this.comboTrainingAmount.MouseHover += new System.EventHandler(this.comboTrainingAmount_MouseHover);
            // 
            // comboExercise
            // 
            this.comboExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboExercise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboExercise.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboExercise.FormattingEnabled = true;
            this.comboExercise.Location = new System.Drawing.Point(312, 264);
            this.comboExercise.Name = "comboExercise";
            this.comboExercise.Size = new System.Drawing.Size(546, 39);
            this.comboExercise.TabIndex = 46;
            this.comboExercise.SelectedIndexChanged += new System.EventHandler(this.comboExercise_SelectedIndexChanged);
            this.comboExercise.MouseLeave += new System.EventHandler(this.comboExercise_MouseLeave);
            this.comboExercise.MouseHover += new System.EventHandler(this.comboExercise_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(1068, 750);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(190, 110);
            this.btnNext.TabIndex = 47;
            this.btnNext.Text = "Następne zdjęcie";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            this.btnNext.MouseHover += new System.EventHandler(this.btnNext_MouseHover);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(793, 750);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(190, 110);
            this.btnPrevious.TabIndex = 48;
            this.btnPrevious.Text = "Poprzednie zdjęcie";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            this.btnPrevious.MouseLeave += new System.EventHandler(this.btnPrevious_MouseLeave);
            this.btnPrevious.MouseHover += new System.EventHandler(this.btnPrevious_MouseHover);
            // 
            // lbGalery
            // 
            this.lbGalery.AutoSize = true;
            this.lbGalery.BackColor = System.Drawing.Color.Transparent;
            this.lbGalery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbGalery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbGalery.Location = new System.Drawing.Point(940, 105);
            this.lbGalery.Name = "lbGalery";
            this.lbGalery.Size = new System.Drawing.Size(201, 36);
            this.lbGalery.TabIndex = 49;
            this.lbGalery.Text = "Galeria zdjęć";
            // 
            // lbTrainingAmount
            // 
            this.lbTrainingAmount.AutoSize = true;
            this.lbTrainingAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbTrainingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTrainingAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbTrainingAmount.Location = new System.Drawing.Point(245, 139);
            this.lbTrainingAmount.Name = "lbTrainingAmount";
            this.lbTrainingAmount.Size = new System.Drawing.Size(482, 29);
            this.lbTrainingAmount.TabIndex = 50;
            this.lbTrainingAmount.Text = "Ilość jednostek treningowych w tygodniu";
            // 
            // lbExercise
            // 
            this.lbExercise.AutoSize = true;
            this.lbExercise.BackColor = System.Drawing.Color.Transparent;
            this.lbExercise.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbExercise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbExercise.Location = new System.Drawing.Point(334, 232);
            this.lbExercise.Name = "lbExercise";
            this.lbExercise.Size = new System.Drawing.Size(133, 29);
            this.lbExercise.TabIndex = 51;
            this.lbExercise.Text = "Ćwiczenie";
            // 
            // lbBodyPart
            // 
            this.lbBodyPart.AutoSize = true;
            this.lbBodyPart.BackColor = System.Drawing.Color.Transparent;
            this.lbBodyPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbBodyPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbBodyPart.Location = new System.Drawing.Point(12, 232);
            this.lbBodyPart.Name = "lbBodyPart";
            this.lbBodyPart.Size = new System.Drawing.Size(143, 29);
            this.lbBodyPart.TabIndex = 51;
            this.lbBodyPart.Text = "Partia ciała";
            // 
            // comboSerieAmount
            // 
            this.comboSerieAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboSerieAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSerieAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboSerieAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboSerieAmount.FormattingEnabled = true;
            this.comboSerieAmount.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboSerieAmount.Location = new System.Drawing.Point(859, 264);
            this.comboSerieAmount.Name = "comboSerieAmount";
            this.comboSerieAmount.Size = new System.Drawing.Size(100, 39);
            this.comboSerieAmount.TabIndex = 52;
            this.comboSerieAmount.MouseLeave += new System.EventHandler(this.comboSerieAmount_MouseLeave);
            this.comboSerieAmount.MouseHover += new System.EventHandler(this.comboSerieAmount_MouseHover);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(12, 765);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(190, 110);
            this.btnReturn.TabIndex = 53;
            this.btnReturn.Text = "Powrót do menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(500, 584);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 110);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Dodaj do listy";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDescription
            // 
            this.btnDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDescription.FlatAppearance.BorderSize = 0;
            this.btnDescription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnDescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnDescription.Location = new System.Drawing.Point(582, 509);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Size = new System.Drawing.Size(190, 110);
            this.btnDescription.TabIndex = 55;
            this.btnDescription.Text = "Wyświetl opis ćwiczenia";
            this.btnDescription.UseVisualStyleBackColor = false;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            this.btnDescription.MouseLeave += new System.EventHandler(this.btnDescription_MouseLeave);
            this.btnDescription.MouseHover += new System.EventHandler(this.btnDescription_MouseHover);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnRemove.Location = new System.Drawing.Point(53, 595);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(190, 110);
            this.btnRemove.TabIndex = 56;
            this.btnRemove.Text = "Usuń z listy";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // BtnHint
            // 
            this.BtnHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnHint.FlatAppearance.BorderSize = 0;
            this.BtnHint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.BtnHint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.BtnHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BtnHint.Location = new System.Drawing.Point(582, 361);
            this.BtnHint.Name = "BtnHint";
            this.BtnHint.Size = new System.Drawing.Size(190, 110);
            this.BtnHint.TabIndex = 57;
            this.BtnHint.Text = "Wskazówki";
            this.BtnHint.UseVisualStyleBackColor = false;
            this.BtnHint.Click += new System.EventHandler(this.BtnHint_Click);
            // 
            // lbScrollHelp
            // 
            this.lbScrollHelp.AutoSize = true;
            this.lbScrollHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbScrollHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbScrollHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbScrollHelp.Location = new System.Drawing.Point(973, 776);
            this.lbScrollHelp.Name = "lbScrollHelp";
            this.lbScrollHelp.Size = new System.Drawing.Size(120, 58);
            this.lbScrollHelp.TabIndex = 58;
            this.lbScrollHelp.Text = "Przewijaj\r\n  zdjęcia";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(555, 765);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 110);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Zapisz do pliku";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // lbSerie
            // 
            this.lbSerie.AutoSize = true;
            this.lbSerie.BackColor = System.Drawing.Color.Transparent;
            this.lbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbSerie.Location = new System.Drawing.Point(847, 222);
            this.lbSerie.Name = "lbSerie";
            this.lbSerie.Size = new System.Drawing.Size(126, 29);
            this.lbSerie.TabIndex = 60;
            this.lbSerie.Text = "Ilość serii";
            // 
            // lbSaveHelp
            // 
            this.lbSaveHelp.AutoSize = true;
            this.lbSaveHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbSaveHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbSaveHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbSaveHelp.Location = new System.Drawing.Point(516, 878);
            this.lbSaveHelp.Name = "lbSaveHelp";
            this.lbSaveHelp.Size = new System.Drawing.Size(292, 25);
            this.lbSaveHelp.TabIndex = 74;
            this.lbSaveHelp.Text = "Zapisz swoją listę na pulpicie";
            // 
            // lbTrainingAmountHelp
            // 
            this.lbTrainingAmountHelp.AutoSize = true;
            this.lbTrainingAmountHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbTrainingAmountHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTrainingAmountHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbTrainingAmountHelp.Location = new System.Drawing.Point(236, 211);
            this.lbTrainingAmountHelp.Name = "lbTrainingAmountHelp";
            this.lbTrainingAmountHelp.Size = new System.Drawing.Size(528, 29);
            this.lbTrainingAmountHelp.TabIndex = 75;
            this.lbTrainingAmountHelp.Text = "Wybierz ile razy w tygodniu chcesz trenować";
            // 
            // lbBodyPartHelp
            // 
            this.lbBodyPartHelp.AutoSize = true;
            this.lbBodyPartHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbBodyPartHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbBodyPartHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbBodyPartHelp.Location = new System.Drawing.Point(38, 309);
            this.lbBodyPartHelp.Name = "lbBodyPartHelp";
            this.lbBodyPartHelp.Size = new System.Drawing.Size(254, 58);
            this.lbBodyPartHelp.TabIndex = 76;
            this.lbBodyPartHelp.Text = "Wybierz partię ciała \r\nktórą chcesz ćwiczyć";
            // 
            // lbExerciseHelp
            // 
            this.lbExerciseHelp.AutoSize = true;
            this.lbExerciseHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbExerciseHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbExerciseHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbExerciseHelp.Location = new System.Drawing.Point(455, 309);
            this.lbExerciseHelp.Name = "lbExerciseHelp";
            this.lbExerciseHelp.Size = new System.Drawing.Size(235, 29);
            this.lbExerciseHelp.TabIndex = 77;
            this.lbExerciseHelp.Text = "Wybierz ćwiczenie ";
            // 
            // lbSerieAmountHelp
            // 
            this.lbSerieAmountHelp.AutoSize = true;
            this.lbSerieAmountHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbSerieAmountHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbSerieAmountHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbSerieAmountHelp.Location = new System.Drawing.Point(793, 309);
            this.lbSerieAmountHelp.Name = "lbSerieAmountHelp";
            this.lbSerieAmountHelp.Size = new System.Drawing.Size(226, 58);
            this.lbSerieAmountHelp.TabIndex = 78;
            this.lbSerieAmountHelp.Text = "Wybierz ilość serii\r\ndanego ćwiczenia";
            // 
            // btnNextList
            // 
            this.btnNextList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNextList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNextList.FlatAppearance.BorderSize = 0;
            this.btnNextList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnNextList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnNextList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnNextList.Location = new System.Drawing.Point(507, 448);
            this.btnNextList.Name = "btnNextList";
            this.btnNextList.Size = new System.Drawing.Size(88, 77);
            this.btnNextList.TabIndex = 79;
            this.btnNextList.Text = ">";
            this.btnNextList.UseVisualStyleBackColor = false;
            this.btnNextList.Click += new System.EventHandler(this.btnNextList_Click);
            // 
            // btnPrevList
            // 
            this.btnPrevList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrevList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrevList.FlatAppearance.BorderSize = 0;
            this.btnPrevList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnPrevList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnPrevList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnPrevList.Location = new System.Drawing.Point(140, 448);
            this.btnPrevList.Name = "btnPrevList";
            this.btnPrevList.Size = new System.Drawing.Size(88, 77);
            this.btnPrevList.TabIndex = 80;
            this.btnPrevList.Text = "<";
            this.btnPrevList.UseVisualStyleBackColor = false;
            this.btnPrevList.Click += new System.EventHandler(this.btnPrevList_Click);
            // 
            // lbDescriptionHelp
            // 
            this.lbDescriptionHelp.AutoSize = true;
            this.lbDescriptionHelp.BackColor = System.Drawing.Color.Transparent;
            this.lbDescriptionHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbDescriptionHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.lbDescriptionHelp.Location = new System.Drawing.Point(542, 628);
            this.lbDescriptionHelp.Name = "lbDescriptionHelp";
            this.lbDescriptionHelp.Size = new System.Drawing.Size(278, 50);
            this.lbDescriptionHelp.TabIndex = 81;
            this.lbDescriptionHelp.Text = "Wyświetl opis wykonywania\r\n      wybranego ćwiczenia";
            // 
            // FrTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AplikacjaKSFD.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.lbDescriptionHelp);
            this.Controls.Add(this.btnPrevList);
            this.Controls.Add(this.btnNextList);
            this.Controls.Add(this.lbSerieAmountHelp);
            this.Controls.Add(this.lbExerciseHelp);
            this.Controls.Add(this.lbBodyPartHelp);
            this.Controls.Add(this.lbTrainingAmountHelp);
            this.Controls.Add(this.lbSaveHelp);
            this.Controls.Add(this.lbSerie);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbScrollHelp);
            this.Controls.Add(this.BtnHint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnDescription);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.comboSerieAmount);
            this.Controls.Add(this.lbBodyPart);
            this.Controls.Add(this.lbExercise);
            this.Controls.Add(this.lbTrainingAmount);
            this.Controls.Add(this.lbGalery);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.comboExercise);
            this.Controls.Add(this.comboTrainingAmount);
            this.Controls.Add(this.comboBodyPart);
            this.Controls.Add(this.lbHelp);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.picbox);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrTraining";
            this.ShowIcon = false;
            this.Text = "Skomponuj Trening";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picbox;
        private Button btnHelp;
        private Label lbHelp;
        private ComboBox comboBodyPart;
        private ComboBox comboTrainingAmount;
        private ComboBox comboExercise;
        private RoundButtons btnNext;
        private RoundButtons btnPrevious;
        private Label lbGalery;
        private Label lbTrainingAmount;
        private Label lbExercise;
        private Label lbBodyPart;
        private ComboBox comboSerieAmount;
        private RoundButtons btnReturn;
        private RoundButtons btnAdd;
        private RoundButtons btnDescription;
        private RoundButtons btnRemove;
        private RoundButtons BtnHint;
        private Label lbScrollHelp;
        private RoundButtons btnSave;
        private Label lbSerie;
        private Label lbSaveHelp;
        private Label lbTrainingAmountHelp;
        private Label lbBodyPartHelp;
        private Label lbExerciseHelp;
        private Label lbSerieAmountHelp;
        private RoundButtons btnNextList;
        private RoundButtons btnPrevList;
        private Label lbDescriptionHelp;
    }
}
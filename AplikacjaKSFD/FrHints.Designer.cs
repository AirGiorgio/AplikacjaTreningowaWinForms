namespace AplikacjaKSFD
{
    partial class FrHints
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
            this.btnClose = new AplikacjaKSFD.RoundButtons();
            this.RtbHints = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(6)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(479, 546);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(163, 80);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "Zamknij";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RtbHints
            // 
            this.RtbHints.BackColor = System.Drawing.SystemColors.Control;
            this.RtbHints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RtbHints.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RtbHints.Location = new System.Drawing.Point(47, 108);
            this.RtbHints.Name = "RtbHints";
            this.RtbHints.ReadOnly = true;
            this.RtbHints.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RtbHints.Size = new System.Drawing.Size(595, 407);
            this.RtbHints.TabIndex = 51;
            this.RtbHints.Text = "";
            // 
            // FrHints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AplikacjaKSFD.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.RtbHints);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "FrHints";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wskazówki";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundButtons btnClose;
        private RichTextBox RtbHints;
    }
}
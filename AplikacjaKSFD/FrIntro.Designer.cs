namespace AplikacjaKSFD
{
    partial class FrIntro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PbLoading = new System.Windows.Forms.ProgressBar();
            this.IntroTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PbLoading
            // 
            this.PbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PbLoading.BackColor = System.Drawing.SystemColors.ControlText;
            this.PbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PbLoading.Location = new System.Drawing.Point(150, 850);
            this.PbLoading.Margin = new System.Windows.Forms.Padding(4);
            this.PbLoading.Maximum = 7;
            this.PbLoading.Name = "PbLoading";
            this.PbLoading.Size = new System.Drawing.Size(950, 70);
            this.PbLoading.TabIndex = 1;
            // 
            // IntroTimer
            // 
            this.IntroTimer.Interval = 600;
            this.IntroTimer.Tick += new System.EventHandler(this.IntroTimer_Tick);
            // 
            // FrIntro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImage = global::AplikacjaKSFD.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 977);
            this.Controls.Add(this.PbLoading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrIntro";
            this.ShowIcon = false;
            this.Text = "Intro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar PbLoading;
        private System.Windows.Forms.Timer IntroTimer;
    }
}
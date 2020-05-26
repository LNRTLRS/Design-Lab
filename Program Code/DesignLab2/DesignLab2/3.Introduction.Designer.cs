namespace DesignLab2
{
    partial class Introduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Introduction));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtGSR = new MetroFramework.Controls.MetroTextBox();
            this.txtHR = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnLaunchGame = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblTimer = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtGSR
            // 
            // 
            // 
            // 
            this.txtGSR.CustomButton.Image = null;
            this.txtGSR.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txtGSR.CustomButton.Name = "";
            this.txtGSR.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGSR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGSR.CustomButton.TabIndex = 1;
            this.txtGSR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGSR.CustomButton.UseSelectable = true;
            this.txtGSR.CustomButton.Visible = false;
            this.txtGSR.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtGSR.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGSR.Lines = new string[] {
        "0"};
            this.txtGSR.Location = new System.Drawing.Point(126, 419);
            this.txtGSR.MaxLength = 32767;
            this.txtGSR.Name = "txtGSR";
            this.txtGSR.PasswordChar = '\0';
            this.txtGSR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGSR.SelectedText = "";
            this.txtGSR.SelectionLength = 0;
            this.txtGSR.SelectionStart = 0;
            this.txtGSR.ShortcutsEnabled = true;
            this.txtGSR.Size = new System.Drawing.Size(98, 23);
            this.txtGSR.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtGSR.TabIndex = 38;
            this.txtGSR.Text = "0";
            this.txtGSR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGSR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtGSR.UseSelectable = true;
            this.txtGSR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGSR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtHR
            // 
            // 
            // 
            // 
            this.txtHR.CustomButton.Image = null;
            this.txtHR.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.txtHR.CustomButton.Name = "";
            this.txtHR.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtHR.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHR.CustomButton.TabIndex = 1;
            this.txtHR.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHR.CustomButton.UseSelectable = true;
            this.txtHR.CustomButton.Visible = false;
            this.txtHR.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtHR.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtHR.Lines = new string[] {
        "0"};
            this.txtHR.Location = new System.Drawing.Point(676, 419);
            this.txtHR.MaxLength = 32767;
            this.txtHR.Name = "txtHR";
            this.txtHR.PasswordChar = '\0';
            this.txtHR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHR.SelectedText = "";
            this.txtHR.SelectionLength = 0;
            this.txtHR.SelectionStart = 0;
            this.txtHR.ShortcutsEnabled = true;
            this.txtHR.Size = new System.Drawing.Size(98, 23);
            this.txtHR.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtHR.TabIndex = 40;
            this.txtHR.Text = "0";
            this.txtHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtHR.UseSelectable = true;
            this.txtHR.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHR.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(595, 423);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(75, 19);
            this.metroLabel9.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel9.TabIndex = 45;
            this.metroLabel9.Text = "Hearthrate:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseMnemonic = false;
            this.metroLabel9.UseStyleColors = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(701, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 423);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 49;
            this.metroLabel1.Text = "Skin Conduction:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseMnemonic = false;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(323, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(162, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 50;
            this.metroLabel2.Text = "Hotel Sanatorium";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseMnemonic = false;
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(146, 63);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(540, 262);
            this.axWindowsMediaPlayer1.TabIndex = 56;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btnLaunchGame
            // 
            this.btnLaunchGame.DisplayFocus = true;
            this.btnLaunchGame.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLaunchGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLaunchGame.Highlight = true;
            this.btnLaunchGame.Location = new System.Drawing.Point(305, 347);
            this.btnLaunchGame.Name = "btnLaunchGame";
            this.btnLaunchGame.Size = new System.Drawing.Size(218, 57);
            this.btnLaunchGame.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnLaunchGame.TabIndex = 57;
            this.btnLaunchGame.Text = "Launch Game";
            this.btnLaunchGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLaunchGame.UseSelectable = true;
            this.btnLaunchGame.Click += new System.EventHandler(this.btnLaunchGame_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(577, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel3.TabIndex = 60;
            this.metroLabel3.Text = "Time:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTimer.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimer.Location = new System.Drawing.Point(656, 25);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(32, 25);
            this.lblTimer.Style = MetroFramework.MetroColorStyle.Green;
            this.lblTimer.TabIndex = 59;
            this.lblTimer.Text = "45";
            this.lblTimer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnLaunchGame);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtHR);
            this.Controls.Add(this.txtGSR);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Introduction";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "SanaScape";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTextBox txtGSR;
        private MetroFramework.Controls.MetroTextBox txtHR;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private MetroFramework.Controls.MetroButton btnLaunchGame;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblTimer;
    }
}


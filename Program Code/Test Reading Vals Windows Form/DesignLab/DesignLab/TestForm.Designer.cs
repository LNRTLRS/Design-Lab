namespace DesignLab
{
    partial class TestForm
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
            this.lblCOM = new System.Windows.Forms.Label();
            this.lblBaud = new System.Windows.Forms.Label();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.dmnCOM = new System.Windows.Forms.DomainUpDown();
            this.txtRaw = new System.Windows.Forms.TextBox();
            this.sp = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // lblCOM
            // 
            this.lblCOM.AutoSize = true;
            this.lblCOM.Location = new System.Drawing.Point(12, 15);
            this.lblCOM.Name = "lblCOM";
            this.lblCOM.Size = new System.Drawing.Size(55, 13);
            this.lblCOM.TabIndex = 1;
            this.lblCOM.Text = "COM-port:";
            // 
            // lblBaud
            // 
            this.lblBaud.AutoSize = true;
            this.lblBaud.Location = new System.Drawing.Point(200, 15);
            this.lblBaud.Name = "lblBaud";
            this.lblBaud.Size = new System.Drawing.Size(56, 13);
            this.lblBaud.TabIndex = 3;
            this.lblBaud.Text = "Baudrate: ";
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "31250",
            "38400",
            "57600",
            "115200"});
            this.cmbBaud.Location = new System.Drawing.Point(262, 12);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(121, 21);
            this.cmbBaud.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(389, 10);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start Listening";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(12, 39);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.Size = new System.Drawing.Size(452, 20);
            this.txtAvg.TabIndex = 6;
            // 
            // dmnCOM
            // 
            this.dmnCOM.Items.Add("COM1");
            this.dmnCOM.Items.Add("COM2");
            this.dmnCOM.Items.Add("COM3");
            this.dmnCOM.Items.Add("COM4");
            this.dmnCOM.Items.Add("COM5");
            this.dmnCOM.Items.Add("COM6");
            this.dmnCOM.Location = new System.Drawing.Point(73, 13);
            this.dmnCOM.Name = "dmnCOM";
            this.dmnCOM.Size = new System.Drawing.Size(120, 20);
            this.dmnCOM.TabIndex = 7;
            // 
            // txtRaw
            // 
            this.txtRaw.Location = new System.Drawing.Point(12, 65);
            this.txtRaw.Multiline = true;
            this.txtRaw.Name = "txtRaw";
            this.txtRaw.Size = new System.Drawing.Size(452, 188);
            this.txtRaw.TabIndex = 8;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 268);
            this.Controls.Add(this.txtRaw);
            this.Controls.Add(this.dmnCOM);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbBaud);
            this.Controls.Add(this.lblBaud);
            this.Controls.Add(this.lblCOM);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TestForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCOM;
        private System.Windows.Forms.Label lblBaud;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.DomainUpDown dmnCOM;
        private System.Windows.Forms.TextBox txtRaw;
        private System.IO.Ports.SerialPort sp;
    }
}


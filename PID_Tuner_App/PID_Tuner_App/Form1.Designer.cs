namespace PID_Tuner_App
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
            this.PortMenu = new System.Windows.Forms.ComboBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.BaudRateMenu = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // PortMenu
            // 
            this.PortMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortMenu.FormattingEnabled = true;
            this.PortMenu.Location = new System.Drawing.Point(108, 38);
            this.PortMenu.Name = "PortMenu";
            this.PortMenu.Size = new System.Drawing.Size(121, 21);
            this.PortMenu.TabIndex = 0;
            this.PortMenu.SelectedIndexChanged += new System.EventHandler(this.PortMenu_SelectedIndexChanged);
            this.PortMenu.Click += new System.EventHandler(this.PortMenu_Click);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(76, 41);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(26, 13);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Port";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(44, 71);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(58, 13);
            this.BaudRateLabel.TabIndex = 2;
            this.BaudRateLabel.Text = "Baud Rate";
            // 
            // BaudRateMenu
            // 
            this.BaudRateMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateMenu.FormattingEnabled = true;
            this.BaudRateMenu.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRateMenu.Location = new System.Drawing.Point(108, 68);
            this.BaudRateMenu.Name = "BaudRateMenu";
            this.BaudRateMenu.Size = new System.Drawing.Size(121, 21);
            this.BaudRateMenu.TabIndex = 3;
            this.BaudRateMenu.SelectedIndexChanged += new System.EventHandler(this.BaudRateMenu_SelectedIndexChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(47, 110);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(182, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Location = new System.Drawing.Point(47, 139);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(182, 23);
            this.DisconnectButton.TabIndex = 5;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.BaudRateMenu);
            this.Controls.Add(this.BaudRateLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.PortMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortMenu;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.ComboBox BaudRateMenu;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.IO.Ports.SerialPort serialPort1;
    }
}


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
            this.SerialPanel = new System.Windows.Forms.Panel();
            this.SerialComLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.PLabel = new System.Windows.Forms.Label();
            this.ILabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.VelocityPanel = new System.Windows.Forms.Panel();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.SerialPanel.SuspendLayout();
            this.VelocityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortMenu
            // 
            this.PortMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortMenu.FormattingEnabled = true;
            this.PortMenu.Location = new System.Drawing.Point(81, 46);
            this.PortMenu.Name = "PortMenu";
            this.PortMenu.Size = new System.Drawing.Size(121, 21);
            this.PortMenu.TabIndex = 0;
            this.PortMenu.SelectedIndexChanged += new System.EventHandler(this.PortMenu_SelectedIndexChanged);
            this.PortMenu.Click += new System.EventHandler(this.PortMenu_Click);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortLabel.Location = new System.Drawing.Point(19, 49);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(56, 13);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "COM Port:";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BaudRateLabel.Location = new System.Drawing.Point(14, 79);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(61, 13);
            this.BaudRateLabel.TabIndex = 2;
            this.BaudRateLabel.Text = "Baud Rate:";
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
            this.BaudRateMenu.Location = new System.Drawing.Point(81, 76);
            this.BaudRateMenu.Name = "BaudRateMenu";
            this.BaudRateMenu.Size = new System.Drawing.Size(121, 21);
            this.BaudRateMenu.TabIndex = 3;
            this.BaudRateMenu.SelectedIndexChanged += new System.EventHandler(this.BaudRateMenu_SelectedIndexChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.Lime;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Location = new System.Drawing.Point(17, 113);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(185, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.BackColor = System.Drawing.Color.Red;
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisconnectButton.Location = new System.Drawing.Point(17, 113);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(185, 23);
            this.DisconnectButton.TabIndex = 5;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // SerialPanel
            // 
            this.SerialPanel.BackColor = System.Drawing.Color.Transparent;
            this.SerialPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerialPanel.Controls.Add(this.SerialComLabel);
            this.SerialPanel.Controls.Add(this.DisconnectButton);
            this.SerialPanel.Controls.Add(this.BaudRateMenu);
            this.SerialPanel.Controls.Add(this.ConnectButton);
            this.SerialPanel.Controls.Add(this.PortLabel);
            this.SerialPanel.Controls.Add(this.PortMenu);
            this.SerialPanel.Controls.Add(this.BaudRateLabel);
            this.SerialPanel.Location = new System.Drawing.Point(26, 26);
            this.SerialPanel.Name = "SerialPanel";
            this.SerialPanel.Size = new System.Drawing.Size(228, 149);
            this.SerialPanel.TabIndex = 6;
            // 
            // SerialComLabel
            // 
            this.SerialComLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialComLabel.AutoSize = true;
            this.SerialComLabel.BackColor = System.Drawing.Color.LightBlue;
            this.SerialComLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerialComLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SerialComLabel.Location = new System.Drawing.Point(9, 9);
            this.SerialComLabel.Name = "SerialComLabel";
            this.SerialComLabel.Padding = new System.Windows.Forms.Padding(3);
            this.SerialComLabel.Size = new System.Drawing.Size(205, 24);
            this.SerialComLabel.TabIndex = 7;
            this.SerialComLabel.Text = "Serial communication setup";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(69, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(46, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 20);
            this.textBox3.TabIndex = 9;
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Location = new System.Drawing.Point(17, 50);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(23, 13);
            this.PLabel.TabIndex = 10;
            this.PLabel.Text = "Kp:";
            // 
            // ILabel
            // 
            this.ILabel.AutoSize = true;
            this.ILabel.Location = new System.Drawing.Point(21, 77);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(19, 13);
            this.ILabel.TabIndex = 11;
            this.ILabel.Text = "Ki:";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(17, 103);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(23, 13);
            this.DLabel.TabIndex = 12;
            this.DLabel.Text = "Kd:";
            // 
            // VelocityPanel
            // 
            this.VelocityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VelocityPanel.Controls.Add(this.VelocityLabel);
            this.VelocityPanel.Controls.Add(this.PLabel);
            this.VelocityPanel.Controls.Add(this.DLabel);
            this.VelocityPanel.Controls.Add(this.textBox1);
            this.VelocityPanel.Controls.Add(this.ILabel);
            this.VelocityPanel.Controls.Add(this.textBox2);
            this.VelocityPanel.Controls.Add(this.textBox3);
            this.VelocityPanel.Location = new System.Drawing.Point(277, 26);
            this.VelocityPanel.Name = "VelocityPanel";
            this.VelocityPanel.Size = new System.Drawing.Size(144, 149);
            this.VelocityPanel.TabIndex = 13;
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.BackColor = System.Drawing.Color.LightBlue;
            this.VelocityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VelocityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VelocityLabel.Location = new System.Drawing.Point(18, 9);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Padding = new System.Windows.Forms.Padding(3);
            this.VelocityLabel.Size = new System.Drawing.Size(100, 24);
            this.VelocityLabel.TabIndex = 14;
            this.VelocityLabel.Text = "Velocity PID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VelocityPanel);
            this.Controls.Add(this.SerialPanel);
            this.Name = "Form1";
            this.Text = "PID Tunner App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SerialPanel.ResumeLayout(false);
            this.SerialPanel.PerformLayout();
            this.VelocityPanel.ResumeLayout(false);
            this.VelocityPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortMenu;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.ComboBox BaudRateMenu;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel SerialPanel;
        private System.Windows.Forms.Label SerialComLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Panel VelocityPanel;
        private System.Windows.Forms.Label VelocityLabel;
    }
}


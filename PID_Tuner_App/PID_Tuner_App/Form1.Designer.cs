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
            this.P_VelText = new System.Windows.Forms.TextBox();
            this.I_VelText = new System.Windows.Forms.TextBox();
            this.D_VelText = new System.Windows.Forms.TextBox();
            this.PLabel = new System.Windows.Forms.Label();
            this.ILabel = new System.Windows.Forms.Label();
            this.DLabel = new System.Windows.Forms.Label();
            this.VelocityPanel = new System.Windows.Forms.Panel();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.VelSendButton = new System.Windows.Forms.Button();
            this.VelReadButton = new System.Windows.Forms.Button();
            this.SerialPanel.SuspendLayout();
            this.VelocityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortMenu
            // 
            this.PortMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortMenu.FormattingEnabled = true;
            this.PortMenu.Location = new System.Drawing.Point(108, 57);
            this.PortMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PortMenu.Name = "PortMenu";
            this.PortMenu.Size = new System.Drawing.Size(160, 24);
            this.PortMenu.TabIndex = 0;
            this.PortMenu.SelectedIndexChanged += new System.EventHandler(this.PortMenu_SelectedIndexChanged);
            this.PortMenu.Click += new System.EventHandler(this.PortMenu_Click);
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PortLabel.Location = new System.Drawing.Point(25, 60);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(73, 17);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "COM Port:";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BaudRateLabel.Location = new System.Drawing.Point(19, 97);
            this.BaudRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(79, 17);
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
            this.BaudRateMenu.Location = new System.Drawing.Point(108, 94);
            this.BaudRateMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BaudRateMenu.Name = "BaudRateMenu";
            this.BaudRateMenu.Size = new System.Drawing.Size(160, 24);
            this.BaudRateMenu.TabIndex = 3;
            this.BaudRateMenu.SelectedIndexChanged += new System.EventHandler(this.BaudRateMenu_SelectedIndexChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.Lime;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Location = new System.Drawing.Point(23, 139);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(247, 28);
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
            this.DisconnectButton.Location = new System.Drawing.Point(23, 139);
            this.DisconnectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(247, 28);
            this.DisconnectButton.TabIndex = 5;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = false;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
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
            this.SerialPanel.Location = new System.Drawing.Point(35, 32);
            this.SerialPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SerialPanel.Name = "SerialPanel";
            this.SerialPanel.Size = new System.Drawing.Size(303, 183);
            this.SerialPanel.TabIndex = 6;
            // 
            // SerialComLabel
            // 
            this.SerialComLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialComLabel.AutoSize = true;
            this.SerialComLabel.BackColor = System.Drawing.Color.LightBlue;
            this.SerialComLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerialComLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SerialComLabel.Location = new System.Drawing.Point(12, 11);
            this.SerialComLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SerialComLabel.Name = "SerialComLabel";
            this.SerialComLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SerialComLabel.Size = new System.Drawing.Size(252, 30);
            this.SerialComLabel.TabIndex = 7;
            this.SerialComLabel.Text = "Serial communication setup";
            // 
            // P_VelText
            // 
            this.P_VelText.Location = new System.Drawing.Point(56, 55);
            this.P_VelText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.P_VelText.Name = "P_VelText";
            this.P_VelText.Size = new System.Drawing.Size(91, 22);
            this.P_VelText.TabIndex = 7;
            // 
            // I_VelText
            // 
            this.I_VelText.Location = new System.Drawing.Point(56, 88);
            this.I_VelText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.I_VelText.Name = "I_VelText";
            this.I_VelText.Size = new System.Drawing.Size(91, 22);
            this.I_VelText.TabIndex = 8;
            // 
            // D_VelText
            // 
            this.D_VelText.Location = new System.Drawing.Point(56, 118);
            this.D_VelText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.D_VelText.Name = "D_VelText";
            this.D_VelText.Size = new System.Drawing.Size(91, 22);
            this.D_VelText.TabIndex = 9;
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Location = new System.Drawing.Point(23, 58);
            this.PLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(26, 16);
            this.PLabel.TabIndex = 10;
            this.PLabel.Text = "Kp:";
            // 
            // ILabel
            // 
            this.ILabel.AutoSize = true;
            this.ILabel.Location = new System.Drawing.Point(28, 91);
            this.ILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(21, 16);
            this.ILabel.TabIndex = 11;
            this.ILabel.Text = "Ki:";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(23, 123);
            this.DLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(26, 16);
            this.DLabel.TabIndex = 12;
            this.DLabel.Text = "Kd:";
            // 
            // VelocityPanel
            // 
            this.VelocityPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VelocityPanel.Controls.Add(this.VelReadButton);
            this.VelocityPanel.Controls.Add(this.VelSendButton);
            this.VelocityPanel.Controls.Add(this.VelocityLabel);
            this.VelocityPanel.Controls.Add(this.PLabel);
            this.VelocityPanel.Controls.Add(this.DLabel);
            this.VelocityPanel.Controls.Add(this.P_VelText);
            this.VelocityPanel.Controls.Add(this.ILabel);
            this.VelocityPanel.Controls.Add(this.I_VelText);
            this.VelocityPanel.Controls.Add(this.D_VelText);
            this.VelocityPanel.Location = new System.Drawing.Point(369, 32);
            this.VelocityPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VelocityPanel.Name = "VelocityPanel";
            this.VelocityPanel.Size = new System.Drawing.Size(174, 200);
            this.VelocityPanel.TabIndex = 13;
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.BackColor = System.Drawing.Color.LightBlue;
            this.VelocityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VelocityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VelocityLabel.Location = new System.Drawing.Point(26, 11);
            this.VelocityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VelocityLabel.Size = new System.Drawing.Size(123, 30);
            this.VelocityLabel.TabIndex = 14;
            this.VelocityLabel.Text = "Velocity PID";
            // 
            // VelSendButton
            // 
            this.VelSendButton.BackColor = System.Drawing.Color.Lime;
            this.VelSendButton.Enabled = false;
            this.VelSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VelSendButton.Location = new System.Drawing.Point(88, 154);
            this.VelSendButton.Name = "VelSendButton";
            this.VelSendButton.Size = new System.Drawing.Size(59, 28);
            this.VelSendButton.TabIndex = 15;
            this.VelSendButton.Text = "Send";
            this.VelSendButton.UseVisualStyleBackColor = false;
            this.VelSendButton.Click += new System.EventHandler(this.VelSendButton_Click);
            // 
            // VelReadButton
            // 
            this.VelReadButton.BackColor = System.Drawing.Color.Red;
            this.VelReadButton.Enabled = false;
            this.VelReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VelReadButton.Location = new System.Drawing.Point(26, 154);
            this.VelReadButton.Name = "VelReadButton";
            this.VelReadButton.Size = new System.Drawing.Size(59, 28);
            this.VelReadButton.TabIndex = 14;
            this.VelReadButton.Text = "Read";
            this.VelReadButton.UseVisualStyleBackColor = false;
            this.VelReadButton.Click += new System.EventHandler(this.VelReadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.VelocityPanel);
            this.Controls.Add(this.SerialPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox P_VelText;
        private System.Windows.Forms.TextBox I_VelText;
        private System.Windows.Forms.TextBox D_VelText;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label ILabel;
        private System.Windows.Forms.Label DLabel;
        private System.Windows.Forms.Panel VelocityPanel;
        private System.Windows.Forms.Label VelocityLabel;
        private System.Windows.Forms.Button VelReadButton;
        private System.Windows.Forms.Button VelSendButton;
    }
}


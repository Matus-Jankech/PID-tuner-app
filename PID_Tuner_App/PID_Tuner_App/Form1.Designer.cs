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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.VelReadButton = new System.Windows.Forms.Button();
            this.VelSendButton = new System.Windows.Forms.Button();
            this.VelocityLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TiltReadButton = new System.Windows.Forms.Button();
            this.TiltSendButton = new System.Windows.Forms.Button();
            this.TiltLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.P_TiltText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.I_TiltText = new System.Windows.Forms.TextBox();
            this.D_TiltText = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SerialPanel.SuspendLayout();
            this.VelocityPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortMenu
            // 
            this.PortMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortMenu.FormattingEnabled = true;
            this.PortMenu.Location = new System.Drawing.Point(108, 57);
            this.PortMenu.Margin = new System.Windows.Forms.Padding(4);
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
            this.BaudRateMenu.Margin = new System.Windows.Forms.Padding(4);
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
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.DisconnectButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.SerialPanel.Margin = new System.Windows.Forms.Padding(4);
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
            this.SerialComLabel.Location = new System.Drawing.Point(18, 11);
            this.SerialComLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SerialComLabel.Name = "SerialComLabel";
            this.SerialComLabel.Padding = new System.Windows.Forms.Padding(4);
            this.SerialComLabel.Size = new System.Drawing.Size(252, 30);
            this.SerialComLabel.TabIndex = 7;
            this.SerialComLabel.Text = "Serial communication setup";
            // 
            // P_VelText
            // 
            this.P_VelText.Location = new System.Drawing.Point(56, 51);
            this.P_VelText.Margin = new System.Windows.Forms.Padding(4);
            this.P_VelText.Name = "P_VelText";
            this.P_VelText.Size = new System.Drawing.Size(91, 22);
            this.P_VelText.TabIndex = 7;
            // 
            // I_VelText
            // 
            this.I_VelText.Location = new System.Drawing.Point(56, 81);
            this.I_VelText.Margin = new System.Windows.Forms.Padding(4);
            this.I_VelText.Name = "I_VelText";
            this.I_VelText.Size = new System.Drawing.Size(91, 22);
            this.I_VelText.TabIndex = 8;
            // 
            // D_VelText
            // 
            this.D_VelText.Location = new System.Drawing.Point(56, 111);
            this.D_VelText.Margin = new System.Windows.Forms.Padding(4);
            this.D_VelText.Name = "D_VelText";
            this.D_VelText.Size = new System.Drawing.Size(91, 22);
            this.D_VelText.TabIndex = 9;
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Location = new System.Drawing.Point(23, 54);
            this.PLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(26, 16);
            this.PLabel.TabIndex = 10;
            this.PLabel.Text = "Kp:";
            // 
            // ILabel
            // 
            this.ILabel.AutoSize = true;
            this.ILabel.Location = new System.Drawing.Point(28, 84);
            this.ILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ILabel.Name = "ILabel";
            this.ILabel.Size = new System.Drawing.Size(21, 16);
            this.ILabel.TabIndex = 11;
            this.ILabel.Text = "Ki:";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.Location = new System.Drawing.Point(23, 114);
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
            this.VelocityPanel.Location = new System.Drawing.Point(346, 32);
            this.VelocityPanel.Margin = new System.Windows.Forms.Padding(4);
            this.VelocityPanel.Name = "VelocityPanel";
            this.VelocityPanel.Size = new System.Drawing.Size(174, 183);
            this.VelocityPanel.TabIndex = 13;
            // 
            // VelReadButton
            // 
            this.VelReadButton.BackColor = System.Drawing.Color.Red;
            this.VelReadButton.Enabled = false;
            this.VelReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VelReadButton.Location = new System.Drawing.Point(26, 143);
            this.VelReadButton.Name = "VelReadButton";
            this.VelReadButton.Size = new System.Drawing.Size(59, 28);
            this.VelReadButton.TabIndex = 14;
            this.VelReadButton.Text = "Read";
            this.VelReadButton.UseVisualStyleBackColor = false;
            this.VelReadButton.Click += new System.EventHandler(this.VelReadButton_Click);
            // 
            // VelSendButton
            // 
            this.VelSendButton.BackColor = System.Drawing.Color.Lime;
            this.VelSendButton.Enabled = false;
            this.VelSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VelSendButton.Location = new System.Drawing.Point(88, 143);
            this.VelSendButton.Name = "VelSendButton";
            this.VelSendButton.Size = new System.Drawing.Size(59, 28);
            this.VelSendButton.TabIndex = 15;
            this.VelSendButton.Text = "Send";
            this.VelSendButton.UseVisualStyleBackColor = false;
            this.VelSendButton.Click += new System.EventHandler(this.VelSendButton_Click);
            // 
            // VelocityLabel
            // 
            this.VelocityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.VelocityLabel.AutoSize = true;
            this.VelocityLabel.BackColor = System.Drawing.Color.LightBlue;
            this.VelocityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VelocityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VelocityLabel.Location = new System.Drawing.Point(24, 11);
            this.VelocityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VelocityLabel.Name = "VelocityLabel";
            this.VelocityLabel.Padding = new System.Windows.Forms.Padding(4);
            this.VelocityLabel.Size = new System.Drawing.Size(123, 30);
            this.VelocityLabel.TabIndex = 14;
            this.VelocityLabel.Text = "Velocity PID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TiltReadButton);
            this.panel1.Controls.Add(this.TiltSendButton);
            this.panel1.Controls.Add(this.TiltLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.P_TiltText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.I_TiltText);
            this.panel1.Controls.Add(this.D_TiltText);
            this.panel1.Location = new System.Drawing.Point(528, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 183);
            this.panel1.TabIndex = 14;
            // 
            // TiltReadButton
            // 
            this.TiltReadButton.BackColor = System.Drawing.Color.Red;
            this.TiltReadButton.Enabled = false;
            this.TiltReadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TiltReadButton.Location = new System.Drawing.Point(27, 143);
            this.TiltReadButton.Name = "TiltReadButton";
            this.TiltReadButton.Size = new System.Drawing.Size(59, 28);
            this.TiltReadButton.TabIndex = 14;
            this.TiltReadButton.Text = "Read";
            this.TiltReadButton.UseVisualStyleBackColor = false;
            this.TiltReadButton.Click += new System.EventHandler(this.TiltReadButton_Click);
            // 
            // TiltSendButton
            // 
            this.TiltSendButton.BackColor = System.Drawing.Color.Lime;
            this.TiltSendButton.Enabled = false;
            this.TiltSendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TiltSendButton.Location = new System.Drawing.Point(89, 143);
            this.TiltSendButton.Name = "TiltSendButton";
            this.TiltSendButton.Size = new System.Drawing.Size(59, 28);
            this.TiltSendButton.TabIndex = 15;
            this.TiltSendButton.Text = "Send";
            this.TiltSendButton.UseVisualStyleBackColor = false;
            this.TiltSendButton.Click += new System.EventHandler(this.TiltSendButton_Click);
            // 
            // TiltLabel
            // 
            this.TiltLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TiltLabel.AutoSize = true;
            this.TiltLabel.BackColor = System.Drawing.Color.LightBlue;
            this.TiltLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TiltLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TiltLabel.Location = new System.Drawing.Point(45, 11);
            this.TiltLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TiltLabel.Name = "TiltLabel";
            this.TiltLabel.Padding = new System.Windows.Forms.Padding(4);
            this.TiltLabel.Size = new System.Drawing.Size(83, 30);
            this.TiltLabel.TabIndex = 14;
            this.TiltLabel.Text = "Tilt PID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kd:";
            // 
            // P_TiltText
            // 
            this.P_TiltText.Location = new System.Drawing.Point(57, 51);
            this.P_TiltText.Margin = new System.Windows.Forms.Padding(4);
            this.P_TiltText.Name = "P_TiltText";
            this.P_TiltText.Size = new System.Drawing.Size(91, 22);
            this.P_TiltText.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ki:";
            // 
            // I_TiltText
            // 
            this.I_TiltText.Location = new System.Drawing.Point(57, 81);
            this.I_TiltText.Margin = new System.Windows.Forms.Padding(4);
            this.I_TiltText.Name = "I_TiltText";
            this.I_TiltText.Size = new System.Drawing.Size(91, 22);
            this.I_TiltText.TabIndex = 8;
            // 
            // D_TiltText
            // 
            this.D_TiltText.Location = new System.Drawing.Point(57, 111);
            this.D_TiltText.Margin = new System.Windows.Forms.Padding(4);
            this.D_TiltText.Name = "D_TiltText";
            this.D_TiltText.Size = new System.Drawing.Size(91, 22);
            this.D_TiltText.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(35, 231);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "Ref Vel";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Real Vel";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(849, 300);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(710, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 183);
            this.panel2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(27, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(89, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tilt PID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kd:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 51);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ki:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 81);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 111);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(91, 22);
            this.textBox3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VelocityPanel);
            this.Controls.Add(this.SerialPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PID Tunner App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SerialPanel.ResumeLayout(false);
            this.SerialPanel.PerformLayout();
            this.VelocityPanel.ResumeLayout(false);
            this.VelocityPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button TiltReadButton;
        private System.Windows.Forms.Button TiltSendButton;
        private System.Windows.Forms.Label TiltLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox P_TiltText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox I_TiltText;
        private System.Windows.Forms.TextBox D_TiltText;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}


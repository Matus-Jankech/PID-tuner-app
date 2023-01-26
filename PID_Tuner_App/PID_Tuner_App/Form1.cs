using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PID_Tuner_App
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            PortMenu.Items.AddRange(ports);
            try{
                PortMenu.SelectedIndex = 0;
            }
            catch{}
            BaudRateMenu.SelectedIndex = 0;
            DisconnectButton.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            while (serialPort1.IsOpen) { }
        }

        private void PortMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PortMenu.SelectedItem != null)
            {
                serialPort1.PortName = PortMenu.SelectedItem.ToString();
            }
        }

        private void PortMenu_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            PortMenu.Items.Clear();
            PortMenu.Items.AddRange(ports);
            try
            {
                PortMenu.SelectedIndex = 0;
            }
            catch { }
        }

        private void BaudRateMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BaudRateMenu.SelectedItem != null)
            {
                serialPort1.BaudRate = int.Parse(BaudRateMenu.SelectedItem.ToString());
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {   
            if (PortMenu.SelectedItem != null)
            {   
                ConnectButton.Visible = false;
                DisconnectButton.Visible = true;
                PortMenu.Enabled = false;
                BaudRateMenu.Enabled = false;
                ConnectButton.Enabled = false;
                DisconnectButton.Enabled = true;
                VelSendButton.Enabled = true;
                VelReadButton.Enabled = true;
                serialPort1.Open();
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            ConnectButton.Visible = true;
            DisconnectButton.Visible = false;
            PortMenu.Enabled = true;
            BaudRateMenu.Enabled = true;
            ConnectButton.Enabled = true;
            DisconnectButton.Enabled = false;
            VelSendButton.Enabled = false;
            VelReadButton.Enabled = false;
            serialPort1.Close();
            while (serialPort1.IsOpen) { }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string buffer;
            char identByte;

            buffer = serialPort1.ReadExisting();
            var parts = buffer.Split(';');
            identByte = Convert.ToChar(parts[0]);
            Double Kp = Convert.ToDouble(parts[1]);
            Double Ki = Convert.ToDouble(parts[2]);
            Double Kd = Convert.ToDouble(parts[3]);

            switch (identByte)
            {
                case 'v':
                    P_VelText.Invoke((MethodInvoker)(() => P_VelText.Text = Kp.ToString("0.000")));
                    I_VelText.Invoke((MethodInvoker)(() => I_VelText.Text = Ki.ToString("0.000")));
                    D_VelText.Invoke((MethodInvoker)(() => D_VelText.Text = Kd.ToString("0.000")));
                    break;
            }
        }

        private void VelSendButton_Click(object sender, EventArgs e)
        {
            string buffer1 = String.Format("v;{0:0.000}", Convert.ToDouble(P_VelText.Text));
            string buffer2 = String.Format(";{0:0.000}", Convert.ToDouble(I_VelText.Text));
            string buffer3 = String.Format(";{0:0.000}\n", Convert.ToDouble(D_VelText.Text));
            string buffer = buffer1 + buffer2 + buffer3;
            serialPort1.Write(buffer);

            Console.WriteLine(buffer);
        }

        private void VelReadButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("V\n");
        }
    }
}

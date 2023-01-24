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
            foreach (string port in ports)
            {
                PortMenu.Items.Add(port);
            }
            if (ports != null)
            {
                PortMenu.SelectedIndex = 0;
            }

            BaudRateMenu.SelectedIndex = 0;
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
            foreach (string port in ports)
            { 
                PortMenu.Items.Add(port); 
            }
            if (ports != null)
            {
                PortMenu.SelectedIndex = 0;
            }
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
            PortMenu.Enabled = false;
            BaudRateMenu.Enabled = false;
            ConnectButton.Enabled = false;
            DisconnectButton.Enabled = true;
            serialPort1.Open();
            Console.WriteLine(serialPort1.PortName);
            Console.WriteLine(serialPort1.BaudRate);
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            PortMenu.Enabled = true;
            BaudRateMenu.Enabled = true;
            ConnectButton.Enabled = true;
            DisconnectButton.Enabled = false;
            serialPort1.Close();
            while (serialPort1.IsOpen) { }
        }
    }
}

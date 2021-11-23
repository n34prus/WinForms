using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace HomeLightGUI
{
    public partial class SelectPortForm : Form
    {
        public SelectPortForm()
        {
            InitializeComponent();
            //выбираем COM порт
            string[] ports = SerialPort.GetPortNames();
            foreach (string enabledPort in ports)   //если подключен провод
            {
                if (enabledPort == "COM4") comboBoxSelectCom.SelectedItem = "COM4";
            }
            comboBoxSelectCom.Items.AddRange(SerialPort.GetPortNames());
            foreach (string enabledPort in ports)   //если подключен провод
            {
                if (enabledPort == "COM4") comboBoxSelectCom.SelectedItem = "COM4";
            }

        }

        private void buttonSelectCom_Click(object sender, EventArgs e)
        {
            int i = 0;
            UART.SetPort(comboBoxSelectCom.SelectedItem.ToString());
            buttonSelectCom.Text = "Trying to connect";
            this.Update();
            while (!Globals.portIsOpen) if (UART.Initialize()) Globals.portIsOpen = true;
                else
                {
                    i++;
                    buttonSelectCom.Text = "Trying to connect " + i.ToString();
                    this.Update();
                    if (i >= 5)
                    {
                        buttonSelectCom.Text = "RETRY";
                        this.Update();
                        return;
                    }
                }
            this.Close();
        }
    }
}

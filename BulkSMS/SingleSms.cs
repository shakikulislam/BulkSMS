using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkSMS
{
    public partial class SingleSms : Form
    {
        public SingleSms()
        {
            InitializeComponent();
            new Common().LoadModemList(comboBoxModemList);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxModemList.SelectedValue=="0")throw new Exception("Please select modem and try again");
                
                SerialPort serialPort = new SerialPort();
                serialPort.PortName = comboBoxModemList.SelectedValue.ToString();
                serialPort.Open();

                Thread.Sleep(100);
                serialPort.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);
                serialPort.WriteLine("AT+CMGF=1" + Environment.NewLine);
                Thread.Sleep(100);
                serialPort.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                Thread.Sleep(100);
                serialPort.WriteLine("AT+CMGS=\"" + textBoxNumber.Text + "\"" + Environment.NewLine);
                Thread.Sleep(100);
                serialPort.WriteLine(richTextBoxMessage.Text + Environment.NewLine);
                Thread.Sleep(100);
                serialPort.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);

                var response = serialPort.ReadExisting();
                labelStatus.Text = response.Contains("ERROR") ? "Failed!" : "Success";
                serialPort.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        
    }

}

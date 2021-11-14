using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace BulkSMS
{
    public partial class MultiNumber : Form
    {
        string strFileName;

        public MultiNumber()
        {
            InitializeComponent();
            new Common().LoadModemList(comboBoxModemList);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxModemList.SelectedValue == "0") throw new Exception("Please select modem and try again");

                if (dataGridViewNumberList.RowCount > 0)
                {
                    for (int ss = 0; ss < dataGridViewNumberList.RowCount; ss++)
                    {

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
                        serialPort.WriteLine("AT+CMGS=\"" + dataGridViewNumberList.Rows[ss].Cells["number"].Value + "\"" + Environment.NewLine);
                        Thread.Sleep(100);
                        serialPort.WriteLine(richTextBoxMessage.Text + Environment.NewLine);
                        Thread.Sleep(100);
                        serialPort.Write(new byte[] {26}, 0, 1);
                        Thread.Sleep(100);

                        var response = serialPort.ReadExisting();

                        dataGridViewNumberList.Rows[ss].Cells["status"].Value = response.Contains("ERROR") ? "Failed!" : "Success";
                        Thread.Sleep(100);
                        serialPort.Close();

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewNumberList_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewNumberList.Rows[e.RowIndex].Cells["sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void buttonBrows_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();
            ofd.Filter = "Excel |*.xls; *xlsx";
            ofd.ShowDialog();
            strFileName = ofd.FileName;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewNumberList.Rows.Clear();
                if (textBoxWorksheet.Text=="")throw new Exception("Please enter SheetName");

                Application xlApplication;
                Workbook xlWorkbook;
                Worksheet xlWorksheet;
                Range xlRange;

                int xlRow;

                if (strFileName != "")
                {
                    xlApplication = new Application();
                    xlWorkbook = xlApplication.Workbooks.Open(strFileName);
                    xlWorksheet = xlWorkbook.Worksheets[textBoxWorksheet.Text.Trim()];
                    xlRange = xlWorksheet.UsedRange;

                    int ss = 0;
                    for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                    {
                        ss++;
                        dataGridViewNumberList.Rows.Add(ss, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text);
                    }

                    xlWorkbook.Close();
                    xlApplication.Quit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

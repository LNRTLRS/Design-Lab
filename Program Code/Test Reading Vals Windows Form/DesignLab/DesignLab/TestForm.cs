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

namespace DesignLab
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if((dmnCOM.Text != null) && (cmbBaud.Text != null)) {
                sp.PortName = dmnCOM.Text;
                sp.BaudRate = Convert.ToInt32(cmbBaud.Text);
                sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ReceivedHandler);
                sp.Open();
            } 
        }

        private void ReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serial = (SerialPort)sender;
            string indata = serial.ReadLine();
            txtRaw.Text += indata + "\n";
        }
        private double GetAverage(double[] set)
        {
            double sum = 0.0;
            for(int i = 0; i < set.Length - 1; i++)
            {
                sum += set[i];
            }
            return (sum / set.Length);
        }
        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Close();
        }
    }
}

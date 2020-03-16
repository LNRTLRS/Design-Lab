using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Media;
using System.IO.Ports;
using System.IO;
using Microsoft.Win32;
using System.Windows;

namespace DesignLab2
{
    public partial class Initialisation: MetroForm
    {

        public static SerialPort myPortGSR = new SerialPort();
        public static SerialPort myPortPulse = new SerialPort();
        public static string[] values;
        private  string in_data;
        Timer timer = new Timer();
        int count_down = 30;

        public Initialisation()
        {
            InitializeComponent();
            //SerialPort myPortGSR = new SerialPort();
            //myPortGSR.BaudRate = 9600;
            //myPortGSR.PortName = "COM3";
            //myPortGSR.Parity = Parity.None;
            //myPortGSR.DataBits = 8;
            //myPortGSR.StopBits = StopBits.One;
            //myPortGSR.DataReceived += serialPort1_DataReceived;
            //try
            //{
            //    myPortGSR.Open();
            //    TxtGSR.Text = "";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
            
       
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            myPortGSR.Open();
            in_data = myPortGSR.ReadLine();
            this.Invoke(new EventHandler(displaydata_event));

        }

        private void displaydata_event(object sender, EventArgs e)
        {
            myPortGSR.Open();
            txtGSR.Text = in_data;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Story1 fo = new Story1();
            fo.Visible = true;
        }

        private void Initialize_Timer()
        {
            timer.Interval = 30000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            count_down--;
            lblTimer.Text = count_down.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home fo = new Home();
            fo.Visible = true;
        }
    }
}

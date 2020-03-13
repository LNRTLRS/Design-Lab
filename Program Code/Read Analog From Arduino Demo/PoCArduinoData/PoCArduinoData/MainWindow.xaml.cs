using System;
using System.IO.Ports;
using System.Windows;

namespace PoCArduinoData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static SerialPort myPort = new SerialPort();
        public static string[] values;
        public delegate void InvokeDelegate();
        public MainWindow()
        {
            InitializeComponent();
            ReadValues();
        }
        public void ReadValues()
        {
            myPort.BaudRate = 9600;
            myPort.PortName = "COM3";
            myPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            myPort.Open();
        }
        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            values = indata.Split('.');
            Console.WriteLine(values[0]);
        }
        private void btnClosePort_Click(object sender, RoutedEventArgs e)
        {
            myPort.Close();
        }
    }
}

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
using System.IO;
using Microsoft.Win32;
using System.Media;
using System.IO.Ports;

namespace DesignLab2
{
    public partial class BadStory1: MetroForm
    {
        Timer timer = new Timer();
        int count_down = 30;

        public BadStory1()
        {
            InitializeComponent();
            using (var soundPlayer = new SoundPlayer(@"C:\Users\diego\source\repos\DesignLab2\DesignLab2\Story\Story 1\Sounds\Welcome.wav"))
            {
                soundPlayer.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

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

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}

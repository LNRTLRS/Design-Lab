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

namespace DesignLab2
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Credits fo = new Credits();
            fo.Visible = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Initialisation fo = new Initialisation();
            fo.Visible = true;
        }
    }
}

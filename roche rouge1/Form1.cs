using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace roche_rouge1
{
    public partial class Form1 : Form
    {
        Robot robot;

        
        public Form1()
        {
            InitializeComponent();
            robot = new Robot();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mouseOn_Click(object sender, EventArgs e)
        {
            robot.startMouseMove();
        }

        private void mouseOff_Click(object sender, EventArgs e)
        {
            robot.stopMouseMove();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void spotifyStop_Click(object sender, EventArgs e)
        {
            TextBox spotifyTimeBox = (TextBox)spotifyTime;
            int timeInMin = 0;
            if (Int32.TryParse(spotifyTimeBox.Text, out timeInMin))
            {
                Spotify.stopPlaying(timeInMin);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void shutdown_Click(object sender, EventArgs e)
        {

        }
    }
}

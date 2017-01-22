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

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public enum SpotifyAction : long
        {
            None = 0,
            ShowToast = 1,
            ShowSpotify = 2,
            CopyTrackInfo = 3,
            SettingsSaved = 4,
            PasteTrackInfo = 5,
            ThumbsUp = 6,   // not usable, left in for future (hopefully!)
            ThumbsDown = 7, // not usable, left in for future (hopefully!)
            PlayPause = 917504,
            Mute = 524288,
            VolumeDown = 589824,
            VolumeUp = 655360,
            Stop = 851968,
            PreviousTrack = 786432,
            NextTrack = 720896,
            FastForward = 49 << 16,
            Rewind = 50 << 16,
        }
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
            SendMessage(GetSpotify(), 0x0319, IntPtr.Zero, new IntPtr((long)SpotifyAction.PlayPause));

            //TextBox spotifyTimeBox = (TextBox)spotifyTime;
            //int timeInMin = 0;
            //if (Int32.TryParse(spotifyTimeBox.Text, out timeInMin))
            //{
            //    robot.stopSpotify();
            //}

        }
        private static IntPtr GetSpotify()
        {
            var windowClassName = "SpotifyMainWindow";

            return FindWindow(windowClassName, null);
        }
    }
}

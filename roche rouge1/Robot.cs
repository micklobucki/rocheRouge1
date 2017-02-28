using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace roche_rouge1
{
    
    class Robot
    {
        public Boolean mouseMove;
        public Boolean lockDetector;
        private  Thread mouseThread;
        private  Thread lockDetectorThread;
        public Cursor Cursor { get; private set; }

        

        public Robot()
        {
            mouseMove = false;
            lockDetector = false;
        }
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);


        public void mouseMoveer()
        {
            if (!mouseMove)
            {
                Console.WriteLine(mouseThread.IsAlive);
                return;
            }
            while (mouseMove)
            {
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
                Thread.Sleep(5000);
                Cursor.Position = new Point(Cursor.Position.X + 50, Cursor.Position.Y + 50);
                Thread.Sleep(5000);

            }
        }
        public void startMouseMove()
        {
            if (!mouseMove)
            {
                mouseMove = true;
                mouseThread = new Thread(mouseMoveer);
                mouseThread.Start();
            }
        }

        public void stopMouseMove()
        {
            mouseMove = false;
        }

        public void startLockDetection()
        {
            if (!lockDetector)
            {
                lockDetector = true;
                Microsoft.Win32.SystemEvents.SessionSwitch += new Microsoft.Win32.SessionSwitchEventHandler(SystemEvents_SessionSwitch);
            }
        }
        public void stopLockDetection()
        {
            lockDetector = false;
        }

        void SystemEvents_SessionSwitch(object sender, Microsoft.Win32.SessionSwitchEventArgs e)
        {
            if (e.Reason == SessionSwitchReason.SessionLock && lockDetector)
            {
                Spotify.startStopPlaying();
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock && lockDetector)
            {
                Spotify.startStopPlaying();

            }
        }

    }
}

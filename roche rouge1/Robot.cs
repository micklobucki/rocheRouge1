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

        [FlagsAttribute]
        public enum EXECUTION_STATE : uint
        {
            ES_AWAYMODE_REQUIRED = 0x00000040,
            ES_CONTINUOUS = 0x80000000,
            ES_DISPLAY_REQUIRED = 0x00000002,
            ES_SYSTEM_REQUIRED = 0x00000001
            // Legacy flag, should not be used.
            // ES_USER_PRESENT = 0x00000004
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);

        public void mouseMoveer()
        {
            if (!mouseMove)
            {
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
                SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS | EXECUTION_STATE.ES_AWAYMODE_REQUIRED);
                mouseMove = true;
                //mouseThread = new Thread(mouseMoveer);
                //mouseThread.Start();
            }
        }

        public void stopMouseMove()
        {
            mouseMove = false;
            SetThreadExecutionState(EXECUTION_STATE.ES_CONTINUOUS);
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
                if (Spotify.checkIfSpotifyPlay())
                {
                Spotify.startStopPlaying();
                }
            }
            else if (e.Reason == SessionSwitchReason.SessionUnlock && lockDetector)
            {
                Spotify.startStopPlaying();
            }
        }

    }
}

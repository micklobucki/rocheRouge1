using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace roche_rouge1
{
    
    class Robot
    {
        public Boolean mouseMove;
        private  Thread mouseThread;
        public Cursor Cursor { get; private set; }

        public const int KEYEVENTF_EXTENTEDKEY = 1;
        public const int KEYEVENTF_KEYUP = 0;
        public const int VK_MEDIA_NEXT_TRACK = 0xB0;
        public const int VK_MEDIA_PLAY_PAUSE = 0xB3;
        public const int VK_MEDIA_PREV_TRACK = 0xB1;

        public Robot()
        {
            mouseMove = false;
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

        public void stopSpotify()
        {
            Console.WriteLine("1");

            keybd_event(VK_MEDIA_NEXT_TRACK, 0, KEYEVENTF_EXTENTEDKEY, IntPtr.Zero);

            Console.WriteLine("2");

        }
    }
}

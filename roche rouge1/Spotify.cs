using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace roche_rouge1
{
    static class Spotify
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public enum SpotifyAction : long
        {
            None = 0,
            CopyTrackInfo = 3,
            PasteTrackInfo = 5,
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

        private static IntPtr GetSpotify()
        {
            var windowClassName = "SpotifyMainWindow";

            return FindWindow(windowClassName, null);
        }

        public static async void stopPlaying(int time)
        {

            await Task.Delay(time * 60000);
            SendMessage(GetSpotify(), 0x0319, IntPtr.Zero, new IntPtr((long)SpotifyAction.PlayPause));
        }
    }
}

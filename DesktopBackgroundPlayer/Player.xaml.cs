using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Runtime.InteropServices;
using System.Windows.Interop;


namespace DesktopBackgroundPlayer
{
    /// <summary>
    /// Player.xaml 的互動邏輯
    /// </summary>
    /// 



    public partial class Player : Window
    {
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_EXSTYLE = (-20);

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(IntPtr hwnd, int nIndex);

        public Player()
        {
            InitializeComponent();
            this.Topmost = true;
            this.SourceInitialized += delegate
            {
                IntPtr hwnd = new WindowInteropHelper(this).Handle;
                uint extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
                SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_TRANSPARENT);
            };
            mediaElement.Opacity = 0.4;
            this.Opacity = 0.4;
            mediaElement.LoadedBehavior = MediaState.Manual;

            this.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            this.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            mediaElement.Height = System.Windows.SystemParameters.PrimaryScreenHeight;
            mediaElement.Width = System.Windows.SystemParameters.PrimaryScreenWidth;
            this.Left = 0;
            this.Top = 0;
            

            mediaElement.MediaEnded += Media_Ended;

        }

        public void SetAlpha(double value)
        {
            this.Opacity = value;
            mediaElement.Opacity = value;
        }

        private void Media_Ended(object sender, EventArgs e)
        {
            mediaElement.Position = TimeSpan.Zero;
            mediaElement.Play();
        }

        public void Open(String path)
        {
            mediaElement.Source = new Uri(path);
            mediaElement.Pause();
        }

        public void Pause()
        {
            mediaElement.Pause();
        }


        public void Stop()
        {
            mediaElement.Stop();
        }

        public void Play()
        {
            mediaElement.Play();
        }
    }
}

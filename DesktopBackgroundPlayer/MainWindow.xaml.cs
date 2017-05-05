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
using System.Windows.Navigation;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using Microsoft.Win32;
using System.IO;
using System.Windows.Shapes;

namespace DesktopBackgroundPlayer
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player;
        bool isopen;
        public MainWindow()
        {
            InitializeComponent();
            player = new Player();
            player.Hide();
            player.SetAlpha(0.4);
            isopen = false;
            this.Closed += MainWindow_Closed;



        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            player.Close();
        }

        private void button_pause_click(object sender, RoutedEventArgs e)
        {
            player.Pause();
        }

        private void button_play_click(object sender, RoutedEventArgs e)
        {
            player.Play();
        }

        private void button_open_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            String file = "";
            if (openFileDialog.ShowDialog() == true)
                file = openFileDialog.FileName;
            if (!file.Equals(""))
            {
                try
                {
                    player.Show();
                    player.Open(file);
                    isopen = true;
                    label.Content = "File : " + file;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Can't open " + file);
                }
            }
        }

        private void button_stop_click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            player.Hide();
            isopen = false;
            label.Content = "File : ";
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (player != null)
            {
                player.SetAlpha(e.NewValue / 100);
            }
        }
    }
}

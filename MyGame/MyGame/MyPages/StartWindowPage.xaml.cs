using MyGame;
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
using System.Windows.Shapes;

namespace WpfApp1.MyPages
{
    /// <summary>
    /// Логика взаимодействия для StartWindowPage.xaml
    /// </summary>
    public partial class StartWindowPage : Page
    {
        public static MainWindow mainWindow;
        public StartWindowPage()
        {
            InitializeComponent();
        }

        private void Output_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void StartSetings_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.AllWindowsFrame.Visibility = Visibility.Collapsed;
            mainWindow.SettingFrameCenter.Visibility = Visibility.Visible;
            mainWindow.SettingFrameCenter.Navigate(new StartSetingsPage());
        }
    }
}

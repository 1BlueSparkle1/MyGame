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
    /// Логика взаимодействия для StartSetingsPage.xaml
    /// </summary>
    public partial class StartSetingsPage : Page
    {
        public static MainWindow mainWindow;
        public StartSetingsPage()
        {
            InitializeComponent();
        }

        private void BackMenu_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SettingFrameCenter.Visibility= Visibility.Collapsed;
            mainWindow.AllWindowsFrame.Visibility= Visibility.Visible;
            mainWindow.AllWindowsFrame.Navigate(new StartWindowPage());
        }
    }
}

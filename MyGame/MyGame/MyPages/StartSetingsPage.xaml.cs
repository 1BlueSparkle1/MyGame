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
            if(App.Complexity == "Hard")
            {
                ComplexityCb.SelectedIndex = 0;
            }
            else if (App.Complexity == "Normal")
            {
                ComplexityCb.SelectedIndex = 1;
            }
            else if(App.Complexity == "Easy")
            {
                ComplexityCb.SelectedIndex = 2;
            }

            if (App.Brightness == "Black")
            {
                BrightnessCb.SelectedIndex = 0;
            }
            else if (App.Brightness == "Normal")
            {
                BrightnessCb.SelectedIndex = 1;
            }
            else if (App.Brightness == "White")
            {
                BrightnessCb.SelectedIndex = 2;
            }
            Refresh();
        }

        private void BackMenu_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.SettingFrameCenter.Visibility= Visibility.Collapsed;
            mainWindow.AllWindowsFrame.Visibility= Visibility.Visible;
            mainWindow.AllWindowsFrame.Navigate(new StartWindowPage());
        }

        private void Refresh()
        {
            if (BrightnessCb.SelectedIndex == 0)
            {
                mainWindow.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                App.Brightness = "Black";
            }
            else if(BrightnessCb.SelectedIndex == 1)
            {
                mainWindow.Background = new SolidColorBrush(Color.FromRgb(255, 213, 0));
                App.Brightness = "Normal";
            }
            else if (BrightnessCb.SelectedIndex == 2)
            {
                mainWindow.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                App.Brightness = "White";
            }

            if (ComplexityCb.SelectedIndex == 0)
            {
                App.Complexity = "Hard";
            }
            else if (ComplexityCb.SelectedIndex == 1)
            {
                App.Complexity = "Normal";
            }
            else if (ComplexityCb.SelectedIndex == 2)
            {
                App.Complexity = "Easy";
            }

        }

        private void BrightnessCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void ApplicationBtn_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}

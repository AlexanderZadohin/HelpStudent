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

namespace HelpStudent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void passwordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox.Visibility = Visibility.Collapsed;
        }

        private void passwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordBox.Password))
            {
                textBox.Visibility = Visibility.Visible;
            }
        }

        private void passwordBoxSec_GotFocus(object sender, RoutedEventArgs e)
        {
            textBoxSec.Visibility = Visibility.Collapsed;
        }

        private void passwordBoxSec_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(passwordBoxSec.Password))
            {
                textBoxSec.Visibility = Visibility.Visible;
            }
        }

    }
}

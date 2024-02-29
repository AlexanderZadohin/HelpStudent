using HelpStudent.Class;
using HelpStudent.View.Windows;
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

namespace HelpStudent.View.UsePage
{
    /// <summary>
    /// Логика взаимодействия для RegistrationScreenPage.xaml
    /// </summary>
    public partial class RegistrationScreenPage : Page
    {
        public RegistrationScreenPage()
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

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new View.UsePage.EnterScreenPage());
        }

        private void EmailTbl_GotFocus(object sender, RoutedEventArgs e)
        {
            EmailTbl.Text = "";
        }

        private void EmailTbl_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTbl.Text))
            {
                EmailTbl.Text = "Email";
            }
        }

        private void FIOTbl_GotFocus(object sender, RoutedEventArgs e)
        {
            FIOTbl.Text = "";
        }

        private void FIOTbl_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FIOTbl.Text))
            {
                FIOTbl.Text = "ФИО";
            }
        }
        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            MainScreenWindow mainScreenWindow = new MainScreenWindow();
            mainScreenWindow.Show();

            Window mainWindow = Window.GetWindow(this);
            mainWindow.Close();
        }
    }
}

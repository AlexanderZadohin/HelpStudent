using HelpStudent.Class;
using HelpStudent.View.Windows;
using System.Windows;
using System.Windows.Controls;

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
            if(PasswordPb.Password == "Password")
            {
                PasswordPb.Password = "";
            }
        }

        private void passwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordPb.Password))
            {
                PasswordPb.Password = "Password";
            }
        }

        private void passwordBoxSec_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordPbSec.Password == "Password")
            {
                PasswordPbSec.Password = "";
            }
        }

        private void passwordBoxSec_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordPbSec.Password))
            {
                PasswordPbSec.Password = "Password";
            }
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new View.UsePage.EnterScreenPage());
        }

        private void EmailTbl_GotFocus(object sender, RoutedEventArgs e)
        {
            EmailTb.Text = "";
        }

        private void EmailTbl_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(EmailTb.Text))
            {
                EmailTb.Text = "Email";
            }
        }

        private void FIOTbl_GotFocus(object sender, RoutedEventArgs e)
        {
            FIOTb.Text = "";
        }

        private void FIOTbl_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FIOTb.Text))
            {
                FIOTb.Text = "ФИО";
            }
        }
        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (FIOTb.Text == "Иванов Иван Иванович")
                mes += "Заполните ФИО!\n";
            if (EmailTb.Text == "Email")
                mes += "Заполните Email!\n";
            if (PasswordPb.Password == "")
                mes += "Введите пароль!\n";
            if (PasswordPbSec.Password == "")
                mes += "Введите пароль повторно!\n";
            if (PasswordPbSec.Password != PasswordPb.Password)
                mes += "Пароли не совпадают!\n";
            if (!string.IsNullOrEmpty(mes))
            {
                MessageBox.Show(mes, "Незаполненые поля", MessageBoxButton.OK, MessageBoxImage.Error);
                mes = string.Empty;
                return;
            }
            else
            {
                MainScreenWindow mainScreenWindow = new MainScreenWindow();
                mainScreenWindow.Show();
            }

            Window mainWindow = Window.GetWindow(this);
            mainWindow.Close();
        }
    }
}

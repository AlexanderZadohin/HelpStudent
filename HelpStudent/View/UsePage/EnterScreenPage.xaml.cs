using HelpStudent.Class;
using HelpStudent.Model;
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
    /// Логика взаимодействия для EnterScreenPage.xaml
    /// </summary>
    public partial class EnterScreenPage : Page
    {
        public event EventHandler EnterButtonClicked;
        public EnterScreenPage()
        {
            InitializeComponent();
        }

        private void passwordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox.Visibility = Visibility.Collapsed;
        }

        private void passwordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(PassworPb.Password))
            {
                textBox.Visibility = Visibility.Visible;
            }
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new View.UsePage.RegistrationScreenPage());
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

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] fullNameParts = FIOTbl.Text.Split(' '); // Предполагаем, что ФИО разделено пробелами

            // Проверяем, что введены все три части ФИО
            if (fullNameParts.Length == 3)
            {
                string lastName = fullNameParts[0];
                string firstName = fullNameParts[1];
                string middleName = fullNameParts[2];

                UserApp userApp = App.context.UserApp.FirstOrDefault(u =>
                    u.Password == PassworPb.Password &&
                    u.SecondName == lastName &&
                    u.FirstName == firstName &&
                    u.SurName == middleName);
                if (userApp != null)
                {
                    MainScreenWindow mainScreenWindow = new MainScreenWindow();
                    mainScreenWindow.Show();

                    Window mainWindow = Window.GetWindow(this);
                    mainWindow.Close();
                }
                else
                {
                    MessageBox.Show("Данные для входа введены неверно");
                }
            }
            else
            {
                MessageBox.Show("Введите корректно ФИО");
            }
        }
    }
}

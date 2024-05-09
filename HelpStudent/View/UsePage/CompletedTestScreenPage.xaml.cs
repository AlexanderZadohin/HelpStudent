using HelpStudent.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace HelpStudent.View.UsePage
{
    /// <summary>
    /// Логика взаимодействия для CompletedTestScreenPage.xaml
    /// </summary>
    public partial class CompletedTestScreenPage : Page
    {
        public CompletedTestScreenPage(UserApp user)
        {
            InitializeComponent();

            CongratulationsTb.DataContext = user;

            SubjectSpecialization specialization = new SubjectSpecialization();
            //specialization.id = Convert.ToInt32(user.);
            int spec = specialization.id;

            //CongratulationsTb.Text = $"Поздравляем, вы прошли тестирование! Вам подходит профессия: {user..AssumedProfession}";

            CollegeLb.ItemsSource = App.context.CollegeSpecialization.Where(c => c.idSpecialization == spec).ToList();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

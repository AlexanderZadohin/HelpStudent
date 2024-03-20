using HelpStudent.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace HelpStudent.View.UsePage
{
    /// <summary>
    /// Логика взаимодействия для TestSubjectScreenPage.xaml
    /// </summary>
    public partial class TestSubjectScreenPage : Page
    {
        private UserApp currentUser;
        public TestSubjectScreenPage(UserApp user)
        {
            InitializeComponent();

            FirstSubjectLsb.ItemsSource = App.context.SubjectStudies.ToList();
            SecondSubjectLsb.ItemsSource = App.context.SubjectStudies.ToList();
            currentUser = user;
        }
        private void GoTestBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new View.UsePage.TestScreenPage(currentUser));
        }
    }
}

using HelpStudent.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace HelpStudent.View.UsePage
{
    /// <summary>
    /// Логика взаимодействия для TestScreenPage.xaml
    /// </summary>
    public partial class TestScreenPage : Page
    {
        private UserApp currentUser;
        public TestScreenPage(UserApp user)
        {
            InitializeComponent();

            TestLb.ItemsSource = App.context.AnswerProf.ToList(); 
            
            currentUser = user;
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void GiveAnswerBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new View.UsePage.CompletedTestScreenPage(currentUser));
        }
    }
}

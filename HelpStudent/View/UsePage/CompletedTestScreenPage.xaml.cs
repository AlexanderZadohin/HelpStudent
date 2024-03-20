using HelpStudent.Model;
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

            CollegeLb.ItemsSource = App.context.College.ToList();
        }

        private void GoBackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}

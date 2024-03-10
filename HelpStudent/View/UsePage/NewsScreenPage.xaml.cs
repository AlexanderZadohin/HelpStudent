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
    /// Логика взаимодействия для NewsScreenPage.xaml
    /// </summary>
    public partial class NewsScreenPage : Page
    {
        public NewsScreenPage()
        {
            InitializeComponent();

            NewsLb.ItemsSource = App.context.NewsCollege.ToList();
        }

        private void NewsLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

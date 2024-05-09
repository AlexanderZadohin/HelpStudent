using HelpStudent.Model;
using System;
using System.Linq;
using System.Windows.Controls;

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
            var selectedNews = (NewsCollege)e.AddedItems[0];

            System.Diagnostics.Process.Start(selectedNews.LinkNews);
        }
    }
}

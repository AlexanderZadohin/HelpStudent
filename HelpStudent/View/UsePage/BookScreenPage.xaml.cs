using HelpStudent.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace HelpStudent.View.UsePage
{
    /// <summary>
    /// Логика взаимодействия для BookScreenPage.xaml
    /// </summary>
    public partial class BookScreenPage : Page
    {
        List<SubjectStudies> subjectStudies = new List<SubjectStudies>();
        public BookScreenPage()
        {
            InitializeComponent();

            subjectStudies = App.context.SubjectStudies.ToList();

            subjectStudies.Insert(0, new SubjectStudies() { SubjectName = "Все предметы" });

            SubjectCmb.ItemsSource = subjectStudies;

            SubjectCmb.SelectedValuePath = "id";

            SubjectCmb.SelectedIndex = 0;

        }

        private void SubjectCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SubjectCmb.SelectedIndex == 0)
            {
                BookMaterialLb.ItemsSource = App.context.EducationalMaterial.ToList();
            }
            else
            {
                BookMaterialLb.ItemsSource = App.context.EducationalMaterial.Where(b => b.idSubject == SubjectCmb.SelectedIndex).ToList();
            }
        }

        private void NameBookSearchTb_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (NameBookSearchTb.Text == string.Empty)
            {
                NameBookSearchTb.Text = "Введите название учебника";
            }
        }

        private void NameBookSearchTb_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (NameBookSearchTb.Text == "Введите название учебника")
            {
                NameBookSearchTb.Text = string.Empty;
            }
        }

        private void NameBookSearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(NameBookSearchTb.Text != "Введите название учебника")
            {
                BookMaterialLb.ItemsSource = App.context.EducationalMaterial.Where(b => b.NameBook.Contains(NameBookSearchTb.Text)).ToList();
            }
        }
    }
}

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

            BookMaterialLb.ItemsSource = App.context.EducationalMaterial.ToList();

            subjectStudies = App.context.SubjectStudies.ToList();

            subjectStudies.Insert(0, new SubjectStudies() { SubjectName = "Все предметы" });

            SubjectCmb.ItemsSource = subjectStudies;

            SubjectCmb.SelectedValuePath = "id";

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
    }
}

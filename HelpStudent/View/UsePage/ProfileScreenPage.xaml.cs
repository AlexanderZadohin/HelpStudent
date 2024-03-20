using HelpStudent.Model;
using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HelpStudent.View.UsePage
{
    /// <summary>
    /// Логика взаимодействия для ProfileScreenPage.xaml
    /// </summary>
    public partial class ProfileScreenPage : Page
    {
        public ProfileScreenPage(UserApp user)
        {
            InitializeComponent();

            FavoriteSubjectCmb.ItemsSource = App.context.SubjectStudies.ToList();
            FavoriteSubjectCmb.SelectedValuePath = "id";
            FavoriteSubjectCmb.SelectedIndex = Convert.ToInt32(user.idFavoriteSubject - 1);


            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(user.PhotoProfile);
            bitmap.EndInit();

            ProfileImg.Source = bitmap;
            ProfileAgeTb.Text = $"Возраст: {user.Age}";
            ProfileEmailTb.Text = $"Email: {user.Email}";
            ProfileFioTb.Text = $"{user.SurName} {user.FirstName} {user.SecondName}";
        }

        private void FavoriteSubjectCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CollgeLb.ItemsSource = App.context.CollegeSubject.Where(x => x.idSubject == FavoriteSubjectCmb.SelectedIndex + 1).ToList();
            SpecializationLb.ItemsSource = App.context.SubjectSpecialization.Where(x => x.idSubject == FavoriteSubjectCmb.SelectedIndex + 1).ToList();
        }
    }
}

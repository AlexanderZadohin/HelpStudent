using HelpStudent.Class;
using HelpStudent.View.UsePage;
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
using System.Windows.Shapes;

namespace HelpStudent.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainScreenWindow.xaml
    /// </summary>
    public partial class MainScreenWindow : Window
    {
        public MainScreenWindow()
        {
            InitializeComponent();

            MainScreenFrm.Navigate(new View.UsePage.TestSubjectScreenPage());

            TestTbl.Foreground = (SolidColorBrush)FindResource("ActiveElement");
            TestImg.Source = new BitmapImage(new Uri("/Resource/Icons/ActiveTestIcon.png", UriKind.Relative));
        }

        private void TestBarBtn_Click(object sender, RoutedEventArgs e)
        {
            MainScreenFrm.Navigate(new View.UsePage.TestSubjectScreenPage());

            TestTbl.Foreground = (SolidColorBrush)FindResource("ActiveElement");
            TestImg.Source = new BitmapImage(new Uri("/Resource/Icons/ActiveTestIcon.png", UriKind.Relative));
            NewsTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            NewsImg.Source = new BitmapImage(new Uri("/Resource/Icons/NewsIcon.png", UriKind.Relative));
            CollegeTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            CollegeImg.Source = new BitmapImage(new Uri("/Resource/Icons/CollegeIcon.png", UriKind.Relative));
            LrnMaterialTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            LrnMaterialImg.Source = new BitmapImage(new Uri("/Resource/Icons/LnMaterialIcon.png", UriKind.Relative));
            ProfileTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            ProfileImg.Source = new BitmapImage(new Uri("/Resource/Icons/ProfileIcon.png", UriKind.Relative));
        }

        private void NewsBarBtn_Click(object sender, RoutedEventArgs e)
        {
            MainScreenFrm.Navigate(new View.UsePage.NewsScreenPage());

            NewsTbl.Foreground = (SolidColorBrush)FindResource("ActiveElement");
            NewsImg.Source = new BitmapImage(new Uri("/Resource/Icons/ActiveNewsIcon.png", UriKind.Relative));
            TestTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            TestImg.Source = new BitmapImage(new Uri("/Resource/Icons/TestIcon.png", UriKind.Relative));
            CollegeTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            CollegeImg.Source = new BitmapImage(new Uri("/Resource/Icons/CollegeIcon.png", UriKind.Relative));
            LrnMaterialTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            LrnMaterialImg.Source = new BitmapImage(new Uri("/Resource/Icons/LnMaterialIcon.png", UriKind.Relative));
            ProfileTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            ProfileImg.Source = new BitmapImage(new Uri("/Resource/Icons/ProfileIcon.png", UriKind.Relative));
        }

        private void CollegeBarBtn_Click(object sender, RoutedEventArgs e)
        {
            MainScreenFrm.Navigate(new View.UsePage.CollegesScreenPage());

            CollegeTbl.Foreground = (SolidColorBrush)FindResource("ActiveElement");
            CollegeImg.Source = new BitmapImage(new Uri("/Resource/Icons/ActiveCollegeIcon.png", UriKind.Relative));
            NewsTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            NewsImg.Source = new BitmapImage(new Uri("/Resource/Icons/NewsIcon.png", UriKind.Relative));
            TestTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            TestImg.Source = new BitmapImage(new Uri("/Resource/Icons/TestIcon.png", UriKind.Relative));
            LrnMaterialTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            LrnMaterialImg.Source = new BitmapImage(new Uri("/Resource/Icons/LnMaterialIcon.png", UriKind.Relative));
            ProfileTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            ProfileImg.Source = new BitmapImage(new Uri("/Resource/Icons/ProfileIcon.png", UriKind.Relative));
        }

        private void LrnMaterialBarBtn_Click(object sender, RoutedEventArgs e)
        {
            MainScreenFrm.Navigate(new View.UsePage.BookScreenPage());

            LrnMaterialTbl.Foreground = (SolidColorBrush)FindResource("ActiveElement");
            LrnMaterialImg.Source = new BitmapImage(new Uri("/Resource/Icons/ActiveLnMaterial.png", UriKind.Relative));
            NewsTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            NewsImg.Source = new BitmapImage(new Uri("/Resource/Icons/NewsIcon.png", UriKind.Relative));
            CollegeTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            CollegeImg.Source = new BitmapImage(new Uri("/Resource/Icons/CollegeIcon.png", UriKind.Relative));
            TestTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            TestImg.Source = new BitmapImage(new Uri("/Resource/Icons/TestIcon.png", UriKind.Relative));
            ProfileTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            ProfileImg.Source = new BitmapImage(new Uri("/Resource/Icons/ProfileIcon.png", UriKind.Relative));
        }

        private void ProfileBarBtn_Click(object sender, RoutedEventArgs e)
        {
            MainScreenFrm.Navigate(new View.UsePage.ProfileScreenPage());

            ProfileTbl.Foreground = (SolidColorBrush)FindResource("ActiveElement");
            ProfileImg.Source = new BitmapImage(new Uri("/Resource/Icons/ActiveProfileIcon.png", UriKind.Relative));
            NewsTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            NewsImg.Source = new BitmapImage(new Uri("/Resource/Icons/NewsIcon.png", UriKind.Relative));
            CollegeTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            CollegeImg.Source = new BitmapImage(new Uri("/Resource/Icons/CollegeIcon.png", UriKind.Relative));
            LrnMaterialTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            LrnMaterialImg.Source = new BitmapImage(new Uri("/Resource/Icons/LnMaterialIcon.png", UriKind.Relative));
            TestTbl.Foreground = (SolidColorBrush)FindResource("TextColor");
            TestImg.Source = new BitmapImage(new Uri("/Resource/Icons/TestIcon.png", UriKind.Relative));
        }
    }
}

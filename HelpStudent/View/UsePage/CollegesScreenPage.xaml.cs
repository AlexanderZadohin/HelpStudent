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
    /// Логика взаимодействия для CollegesScreenPage.xaml
    /// </summary>
    public partial class CollegesScreenPage : Page
    {
        public CollegesScreenPage()
        {
            InitializeComponent();
        }

        private void CollegeSearchTb_GotFocus(object sender, RoutedEventArgs e)
        {
            CollegeSearchTb.Text = string.Empty;
        }

        private void CollegeSearchTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CollegeSearchTb.Text == "")
            {
                CollegeSearchTb.Text = "Введите название колледжа";
            }
        }
    }
}

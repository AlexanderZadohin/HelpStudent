﻿using System.Linq;
using System.Windows;
using System.Windows.Controls;

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


            CollegeLb.ItemsSource = App.context.College.ToList();
        }

        private void CollegeSearchTb_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CollegeSearchTb.Text == "Введите название колледжа")
            {
                CollegeSearchTb.Text = string.Empty;
            }
        }

        private void CollegeSearchTb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (CollegeSearchTb.Text == "")
            {
                CollegeSearchTb.Text = "Введите название колледжа";
            }
        }

        private void CollegeSearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CollegeSearchTb.Text != "Введите название колледжа")
            {
                CollegeLb.ItemsSource = App.context.College.Where(c => c.NameCollege.Contains(CollegeSearchTb.Text)).ToList();
            }
        }
    }
}

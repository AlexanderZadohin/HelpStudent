﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для BookScreenPage.xaml
    /// </summary>
    public partial class BookScreenPage : Page
    {
        public BookScreenPage()
        {
            InitializeComponent();

            BookMaterialLb.ItemsSource = App.context.EducationalMaterial.ToList();
            SubjectCmb.ItemsSource = App.context.SubjectStudies.ToList();
        }
    }
}

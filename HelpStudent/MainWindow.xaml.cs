using HelpStudent.Class;
using System.Windows;

namespace HelpStudent
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ClassFrame.FrameMenu = MainScreen;
            MainScreen.Navigate(new View.UsePage.EnterScreenPage());
        }
    }
}

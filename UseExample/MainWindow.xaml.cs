using System;
using System.Windows;
using ExperimentalProject.Views;

namespace UseExample
{
    /// <summary>
    ///     Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var dataContext = new ViewModels.MainWindow();
            DataContext = dataContext;
            Closed += dataContext.MainWindow_Closed;
        }
    }
}
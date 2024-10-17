using System;

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
            ViewModels.MainWindow dataContext = new ViewModels.MainWindow();
            DataContext = dataContext;
            Closed += dataContext.MainWindow_Closed;
        }
        
    }
}
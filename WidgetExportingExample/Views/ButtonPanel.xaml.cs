namespace WidgetExportingExample.Views
{
    /// <summary>
    ///     Логика взаимодействия для ButtonPanel.xaml
    /// </summary>
    public partial class ButtonPanel
    {
        public ButtonPanel()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }

        public ViewModel.ButtonPanel ViewModel { get; set; }
    }
}
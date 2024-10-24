

namespace WidgetExportingExample.Views
{
    /// <summary>
    ///     Логика взаимодействия для ButtonPanel.xaml
    /// </summary>
    public partial class ButtonPanel
    {
        public ViewModel.ButtonPanel ViewModel { get; set; }

        public ButtonPanel()
        {
            InitializeComponent();
            DataContext = ViewModel;
        }
    }
}
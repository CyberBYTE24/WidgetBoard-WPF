using System.Windows;

namespace WidgetExportingExample.Views
{
    /// <summary>
    ///     Логика взаимодействия для ButtonPanelSettings.xaml
    /// </summary>
    public partial class ButtonPanelSettings : Window
    {
        public ButtonPanelSettings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
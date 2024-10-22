using System;
using System.Windows.Controls;
using ExperimentalProject;

namespace WidgetExportingExample.Widgets
{
    internal class ButtonPanelWidget : ExperimentalProject.Widget
    {
        private string settings;
        public ButtonPanelWidget(UserControl control, IUserWidgetViewModel widgetViewModel, Guid widgetId) : base(control, widgetViewModel, widgetId)
        {
            Title = "Button Panel";
            MinRowSpan = 2;
            ColumnSpan = 1;
            OnSettingsWidgetEvent += OnSettingsHandler;
        }

        private void OnSettingsHandler(ExperimentalProject.Widget sender)
        {
            Views.ButtonPanelSettings settingsView = new Views.ButtonPanelSettings();
            var settingsViewModel = new ViewModel.ButtonPanelSettings();
            settingsView.DataContext = settingsViewModel;
            settingsViewModel.SelectedParameter = settings;


            if (settingsView.ShowDialog() == true)
            {
                Settings = settingsViewModel.SelectedParameter;
            }
        }
    }
}

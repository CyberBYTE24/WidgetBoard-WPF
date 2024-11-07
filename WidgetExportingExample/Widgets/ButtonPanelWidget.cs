using System;
using System.Windows.Controls;
using ExperimentalProject;
using WidgetExportingExample.Views;

namespace WidgetExportingExample.Widgets
{
    internal class ButtonPanelWidget : Widget
    {
        public ButtonPanelWidget(UserControl control, object widgetViewModel, Guid widgetId) : base(control,
            widgetViewModel, widgetId)
        {
            Title = "Button Panel";
            MinRowSpan = 2;
            ColumnSpan = 1;
            OnSettingsWidgetEvent += OnSettingsHandler;
        }

        private void OnSettingsHandler(Widget sender)
        {
            var settingsView = new ButtonPanelSettings();
            var settingsViewModel = new ViewModel.ButtonPanelSettings();
            settingsView.DataContext = settingsViewModel;
            settingsViewModel.SelectedParameter = Settings;


            if (settingsView.ShowDialog() == true) Settings = settingsViewModel.SelectedParameter;
        }
    }
}
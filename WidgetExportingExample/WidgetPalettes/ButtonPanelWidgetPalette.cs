using System;
using ExperimentalProject;
using WidgetExportingExample.Properties;
using WidgetExportingExample.Views;
using WidgetExportingExample.Widgets;

namespace WidgetExportingExample.WidgetPalettes
{
    internal class ButtonPanelWidgetPalette : WidgetPalette
    {
        public ButtonPanelWidgetPalette() : base(typeof(ButtonPanelWidget), typeof(ButtonPanel),
            typeof(ViewModel.ButtonPanel))
        {
            WidgetId = new Guid("64297CF5-73E4-44AD-9F19-694F7F2B52D1");
            Title = "Multifunctional Button Panel";
            GroupName = "With Settings";
            IconBytes = Resources.Icon1;
        }
    }
}
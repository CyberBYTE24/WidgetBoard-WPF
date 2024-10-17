using ExperimentalProject;
using System;
using System.Windows.Controls;

namespace WidgetExportingExample.Widgets
{
    internal class SampleWidgetThird : ExperimentalProject.Widget
    {
        public SampleWidgetThird(UserControl control, IUserWidgetViewModel widgetViewModel, Guid widgetId) : base(control, widgetViewModel, widgetId)
        {
            Title = "Sample Widget 3";
            MinRowSpan = 2;
            MinColumnSpan = 2;
        }
    }
}
using System;
using System.Windows.Controls;
using ExperimentalProject;

namespace WidgetExportingExample.Widgets
{
    internal class SampleWidgetThird : Widget
    {
        public SampleWidgetThird(UserControl control, object widgetViewModel, Guid widgetId) : base(control,
            widgetViewModel, widgetId)
        {
            Title = "Sample Widget 3";
            MinRowSpan = 2;
            MinColumnSpan = 2;
        }
    }
}
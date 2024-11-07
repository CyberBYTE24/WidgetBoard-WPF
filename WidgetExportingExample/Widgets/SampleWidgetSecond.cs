using System;
using System.Windows.Controls;
using ExperimentalProject;

namespace WidgetExportingExample.Widgets
{
    internal class SampleWidgetSecond : Widget
    {
        public SampleWidgetSecond(UserControl control, object widgetViewModel, Guid widgetId) : base(control,
            widgetViewModel, widgetId)
        {
            Title = "Sample Widget 2";
            MinColumnSpan = 2;
        }
    }
}
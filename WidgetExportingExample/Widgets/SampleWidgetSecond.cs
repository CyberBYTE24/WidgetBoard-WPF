using ExperimentalProject;
using System;
using System.Windows.Controls;

namespace WidgetExportingExample.Widgets
{
    internal class SampleWidgetSecond : ExperimentalProject.Widget
    {
        public SampleWidgetSecond(UserControl control, IUserWidgetViewModel widgetViewModel, Guid widgetId) : base(control, widgetViewModel, widgetId)
        {
            Title = "Sample Widget 2";
            MinColumnSpan = 2;
        }
    }
}
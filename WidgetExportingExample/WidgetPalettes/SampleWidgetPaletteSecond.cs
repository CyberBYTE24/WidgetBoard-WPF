using System;
using ExperimentalProject;
using WidgetExportingExample.Properties;
using WidgetExportingExample.ViewModel;
using WidgetExportingExample.Widgets;

namespace WidgetExportingExample.WidgetPalettes
{
    internal class SampleWidgetPaletteSecond : WidgetPalette
    {
        public SampleWidgetPaletteSecond() : base(typeof(SampleWidgetSecond), typeof(Views.SampleWidgetSecond),
            typeof(SampleWidget))
        {
            WidgetId = new Guid("7CFDB26F-B12C-4C1C-BD2A-A461EC0C48B0");
            Title = "Palette No.2";
            GroupName = "Without Settings";
            IconBytes = Resources.Icon1;
        }
    }
}
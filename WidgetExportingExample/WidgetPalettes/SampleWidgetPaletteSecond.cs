
using System;
using WidgetExportingExample.Properties;

namespace WidgetExportingExample.WidgetPalettes
{
    internal class SampleWidgetPaletteSecond : ExperimentalProject.WidgetPalette
    {

        public SampleWidgetPaletteSecond() : base(typeof(Widgets.SampleWidgetSecond), typeof(Views.SampleWidgetSecond), null)
        {
            WidgetId = new Guid("7CFDB26F-B12C-4C1C-BD2A-A461EC0C48B0");
            Title = "Palette No.2";
            GroupName = "Without Settings";
            IconBytes = Resources.Icon1;
        }
    }
}

using System;
using ExperimentalProject;
using WidgetExportingExample.Properties;
using WidgetExportingExample.Widgets;

namespace WidgetExportingExample.WidgetPalettes
{
    internal class SampleWidgetPaletteThird : WidgetPalette
    {
        public SampleWidgetPaletteThird() : base(typeof(SampleWidgetThird), typeof(Views.SampleWidgetThird), null)
        {
            WidgetId = new Guid("05E807AD-1155-4FF4-8ABD-674363AAB7C3");
            Title = "Palette No.3";
            GroupName = "Without Settings";
            IconBytes = Resources.Icon1;
        }
    }
}
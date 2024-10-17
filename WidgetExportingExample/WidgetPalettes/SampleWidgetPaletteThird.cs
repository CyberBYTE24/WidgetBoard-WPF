

using System;

namespace WidgetExportingExample.WidgetPalettes
{
    internal class SampleWidgetPaletteThird: ExperimentalProject.WidgetPalette
    {
        public SampleWidgetPaletteThird() : base(typeof(Widgets.SampleWidgetThird), typeof(Views.SampleWidgetThird), null)
        {
            WidgetId = new Guid("05E807AD-1155-4FF4-8ABD-674363AAB7C3");
            Title = "Palette No.3";
        }
    }
}


using System;

namespace WidgetExportingExample.WidgetPalettes
{
    internal class ButtonPanelWidgetPalette : ExperimentalProject.WidgetPalette
    {

        public ButtonPanelWidgetPalette() : base(typeof(Widgets.ButtonPanelWidget), typeof(Views.ButtonPanel), typeof(ViewModel.ButtonPanel))
        {
            WidgetId = new Guid("64297CF5-73E4-44AD-9F19-694F7F2B52D1");
            Title = "Button Panel";
        }
    }
}
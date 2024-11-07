using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using ExperimentalProject.Utilities;
using V = ExperimentalProject.Views;

namespace ExperimentalProject
{
    /// <summary>
    ///     Represents a view model for <see cref="V.WidgetPalette">WidgetPalette</see> that provide instantiating
    ///     <see cref="Widget">Widget</see> on a <see cref="V.WidgetBoard">WidgetBoard</see>.
    /// </summary>
    public abstract class WidgetPalette : INotifyPropertyChanged
    {
        private readonly bool isWidgetSettingsEnabled;
        private readonly Type widgetControlType;
        private readonly Type widgetType;
        private readonly Type widgetViewModelType;
        private byte[] iconBytes;
        private Guid widgetId;
        private RelayCommand createWidgetCommand;
        private string groupName;
        private string title;

        /// <summary>
        ///     Class that provides the ability to create widgets on a
        ///     <see cref="ExperimentalProject.Views.WidgetBoard">WidgetBoard</see>.
        /// </summary>
        /// <param name="widgetType">
        ///     The type of child class that should inherit
        ///     <see cref="ExperimentalProject.Widget">Widget</see> class.
        /// </param>
        /// <param name="widgetControlType">
        ///     The type that should inherit <see cref="UserControl">UserControl</see> and that will be
        ///     embedded in the Widget.
        /// </param>
        /// <param name="widgetViewModelType"></param>
        /// <exception cref="ArgumentException">Occurs when types are passed as arguments that do not inherit the required classes.</exception>
        protected WidgetPalette(Type widgetType, Type widgetControlType, Type widgetViewModelType)
        {
            WidgetPaletteView = new V.WidgetPalette
            {
                DataContext = this
            };
            if (widgetType.BaseType != typeof(Widget))
                throw new ArgumentException(
                    "Expected to get class type inherited from `ExperimentalProject.Widget` in `widgetType` argument");
            if (widgetControlType.BaseType != typeof(UserControl))
                throw new ArgumentException(
                    "Expected to get class type inherited from `System.Windows.Controls.UserControl` in `widgetControlType` argument");
            //if (widgetViewModelType.GetInterfaces().All(x => x != typeof(IUserWidgetViewModel)))
            //    throw new ArgumentException(
            //        "Expected to get class type what implement `IUserWidgetViewModel` in `widgetViewModelType` argument");

            if (widgetViewModelType != null &&
                widgetViewModelType.GetInterfaces().Any(x => x == typeof(IUserWidgetViewModel)))
                isWidgetSettingsEnabled = true;


            this.widgetType = widgetType;
            this.widgetControlType = widgetControlType;
            this.widgetViewModelType = widgetViewModelType;
        }

        /// <summary>
        ///     Describes the signature of event handlers that fire when <see cref="Widget">Widgets</see> are created.
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="widget">The <see cref="Widget">Widget</see> created as a result of the event</param>
        public delegate void OnCreateWidget(object sender, Widget widget);

        /// <summary>
        ///     Event that triggered when a new <see cref="Widget">Widget</see> is created
        /// </summary>
        public event OnCreateWidget OnCreateWidgetEvent;

        /// <summary>
        ///     Event that triggered when any properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Gets or sets the ByteArray of SVG file for drawing the icon
        /// </summary>
        public byte[] IconBytes
        {
            get => iconBytes;
            set
            {
                iconBytes = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IconBase64));
            }
        }

        /// <summary>
        ///     Gets or protected sets the widget variant ID
        /// </summary>
        public Guid WidgetId
        {
            get => widgetId;
            protected set
            {
                widgetId = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Command that triggered <see cref="OnCreateWidgetEvent">OnCreateWidgetEvent</see>
        /// </summary>
        public RelayCommand CreateWidgetCommand
        {
            get
            {
                return createWidgetCommand ??
                       (createWidgetCommand = new RelayCommand(obj => { CreateWidgetInstance(); }));
            }
        }

        /// <summary>
        ///     Gets or sets the name for grouping widgets in the palette
        /// </summary>
        public string GroupName
        {
            get => groupName;
            set
            {
                groupName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets the Icon in Base64 format
        /// </summary>
        public string IconBase64 => $"data:image/svg+xml;base64,{Convert.ToBase64String(IconBytes)}";

        /// <summary>
        ///     Gets or sets the title displayed in the interface of the <see cref="WidgetPalette" />
        /// </summary>
        public string Title
        {
            get => title;
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets the view for WidgetPalette Control
        /// </summary>
        internal V.WidgetPalette WidgetPaletteView { get; private set; }

        /// <summary>
        ///     Method that do trigger <see cref="PropertyChanged">PropertyChanged</see>
        /// </summary>
        /// <param name="prop">Property name</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        ///     Creates a widget based on the types specified in the constructor.
        /// </summary>
        /// <returns>Created <see cref="Widget">Widget</see> instance</returns>
        public Widget CreateWidgetInstance()
        {
            var controlView = (UserControl)widgetControlType.GetConstructor(new Type[] { })
                ?.Invoke(new object[] { });

            if (controlView == null)
                throw new Exception("ControlView class does not have a constructor with zero argument overload");


            object controlViewModel = null;

            if (widgetViewModelType != null)
            {
                controlViewModel = widgetViewModelType.GetConstructor(new Type[] { })
                    ?.Invoke(new object[] { });
                if (controlViewModel == null)
                    throw new Exception(
                        "ControlViewModel class does not have a constructor with zero argument overload");
            }

            var widget = (Widget)widgetType.GetConstructor(new[] { typeof(UserControl), typeof(object), typeof(Guid) })
                ?.Invoke(new[] { controlView, controlViewModel, WidgetId });

            if (widget == null)
                throw new Exception(
                    "ControlView class does not have a constructor with two arguments overload `UserControl` and `object` for ViewModel");

            widget.IsSettingsButtonVisible = controlViewModel is IUserWidgetViewModel;

            OnCreateWidgetEvent?.Invoke(this, widget);
            return widget;
        }
    }
}
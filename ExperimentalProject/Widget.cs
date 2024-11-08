﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ExperimentalProject.Utilities;
using V = ExperimentalProject.Views;

namespace ExperimentalProject
{
    /// <summary>
    ///     Represents a view model for <see cref="V.Widget">Widget</see> that can be placed on a
    ///     <see cref="V.WidgetBoard">WidgetBoard</see>.
    /// </summary>
    public abstract class Widget : INotifyPropertyChanged
    {
        private readonly object widgetViewModel;
        private readonly V.Widget widgetView;
        private double shadowOpacity;
        private int column;
        private int columnSpan;
        private int minColumnSpan = 1;
        private int minRowSpan = 1;
        private int row;
        private int rowSpan;
        private RelayCommand removeCommand;
        private RelayCommand settingsCommand;
        private string settings;
        private string title;

        /// <summary>
        ///     Class that represents the view model of a <see cref="V.Widget">Widget</see> on a widget board.
        /// </summary>
        /// <param name="widgetControl"><see cref="UserControl" /> to be included in the widget</param>
        /// <param name="widgetViewModel">ViewModel object for WidgetControl</param>
        /// <param name="widgetId">Widget type ID</param>
        protected Widget(UserControl widgetControl, object widgetViewModel, Guid widgetId)
        {
            this.widgetViewModel = widgetViewModel;
            widgetControl.DataContext = this.widgetViewModel;
            widgetView = new V.Widget(widgetControl)
            {
                DataContext = this
            };

            widgetView.SetBinding(V.Widget.RowSpanProperty,
                new Binding("RowSpan")
                    { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
            widgetView.SetBinding(V.Widget.MinRowSpanProperty,
                new Binding("MinRowSpan")
                    { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
            widgetView.SetBinding(V.Widget.ColumnSpanProperty,
                new Binding("ColumnSpan")
                    { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
            widgetView.SetBinding(V.Widget.MinColumnSpanProperty,
                new Binding("MinColumnSpan")
                    { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
            widgetView.SetBinding(V.Widget.RowProperty,
                new Binding("Row")
                    { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
            widgetView.SetBinding(V.Widget.ColumnProperty,
                new Binding("Column")
                    { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });
            widgetView.SetBinding(V.Widget.ShadowOpacityProperty,
                new Binding("ShadowOpacity")
                    { UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged, Mode = BindingMode.TwoWay });

            WidgetId = widgetId;
        }

        /// <summary>
        ///     Describes the signature of an event handler that fires when an action occurs on a widget.
        /// </summary>
        /// <param name="sender">Widget on which the action takes place</param>
        public delegate void ActionsWidgetHandler(Widget sender);

        /// <summary>
        ///     Event that triggered when Widget remove command was invoked
        /// </summary>
        public event ActionsWidgetHandler OnRemoveWidgetEvent;

        /// <summary>
        ///     Event that triggered when Widget settings command was invoked
        /// </summary>
        public event ActionsWidgetHandler OnSettingsWidgetEvent;

        /// <summary>
        ///     Event that triggered when any properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Gets or sets the custom settings for saving state in serialized data
        /// </summary>
        public virtual string Settings
        {
            get => settings;
            set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                settings = value;
                if (widgetViewModel is IUserWidgetViewModel model)
                    model.Settings = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the flag representing the visibility state of controls
        /// </summary>
        public bool IsManipulatorVisible
        {
            get => widgetView.ManipulatorVisibility == Visibility.Visible;
            set => widgetView.ManipulatorVisibility = value ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        ///     Gets or sets the flag representing the visibility state of Settings Button in header
        /// </summary>
        public bool IsSettingsButtonVisible
        {
            get => widgetView.SettingsButtonVisibility == Visibility.Visible;
            set => widgetView.SettingsButtonVisibility = value ? Visibility.Visible : Visibility.Collapsed;
        }

        /// <summary>
        ///     Gets or sets the transparency value of the shadow cast by the widget
        /// </summary>
        public double ShadowOpacity
        {
            get => shadowOpacity;
            set
            {
                shadowOpacity = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or protected sets the widget variant ID
        /// </summary>
        public Guid WidgetId { get; protected set; }

        /// <summary>
        ///     Gets or sets the X-position on <see cref="V.WidgetBoard">WidgetBoard</see> (measured in cells)
        /// </summary>
        public int Column
        {
            get => column;
            set
            {
                column = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the width on <see cref="V.WidgetBoard">WidgetBoard</see> (measured in cells)
        /// </summary>
        public int ColumnSpan
        {
            get => columnSpan;
            set
            {
                columnSpan = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the minimal Widget width (measured in cells)
        /// </summary>
        public int MinColumnSpan
        {
            get => minColumnSpan;
            set
            {
                minColumnSpan = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the minimal Widget height (measured in cells)
        /// </summary>
        public int MinRowSpan
        {
            get => minRowSpan;
            set
            {
                minRowSpan = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the widget height on <see cref="V.WidgetBoard">WidgetBoard</see> (measured in cells)
        /// </summary>
        public int Row
        {
            get => row;
            set
            {
                row = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Gets or sets the height on <see cref="V.WidgetBoard">WidgetBoard</see> (measured in cells)
        /// </summary>
        public int RowSpan
        {
            get => rowSpan;
            set
            {
                rowSpan = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Command that triggered <see cref="OnRemoveWidgetEvent">OnRemoveWidgetEvent</see>
        /// </summary>
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                       (removeCommand = new RelayCommand(obj => { OnRemoveWidgetEvent?.Invoke(this); }));
            }
        }

        /// <summary>
        ///     Command that triggered <see cref="OnSettingsWidgetEvent">OnSettingsWidgetEvent</see>
        /// </summary>
        public RelayCommand SettingsCommand
        {
            get
            {
                return settingsCommand ??
                       (settingsCommand = new RelayCommand(obj => { OnSettingsWidgetEvent?.Invoke(this); }));
            }
        }

        /// <summary>
        ///     Gets or sets the title displayed in the interface of the <see cref="Widget" />
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
        ///     Completed widget presentation for placement on <see cref="V.WidgetBoard">WidgetBoard</see>
        /// </summary>
        internal UserControl WidgetView => widgetView;

        /// <summary>
        ///     Method that do trigger <see cref="PropertyChanged">PropertyChanged</see>
        /// </summary>
        /// <param name="prop">Property name</param>
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        ///     Sets the cell height to use in building the interface.
        /// </summary>
        /// <param name="value">Cell height size</param>
        internal void SetCellHeight(double value)
        {
            widgetView.SetCellHeight(value);
        }

        /// <summary>
        ///     Sets the cell width to use in building the interface.
        /// </summary>
        /// <param name="value">Cell width size</param>
        internal void SetCellWidth(double value)
        {
            widgetView.SetCellWidth(value);
        }
    }
}
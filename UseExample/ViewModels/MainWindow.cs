using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Documents;
using System.Xml.Serialization;
using ExperimentalProject;
using UseExample.Utilities;

namespace UseExample.ViewModels
{
    internal class MainWindow : INotifyPropertyChanged
    {
        private bool isManipulatorHidden = true;
        private bool isSidebarHidden = true;
        private double cellSize = 120;
        private RelayCommand toggleManipulatorCommand;
        private RelayCommand toggleSidebarCommand;

        public MainWindow()
        {
            var a = Assembly.LoadFrom("WidgetExportingExample.dll");

            var parent = typeof(WidgetPalette);
            var inheritingTypes = a.DefinedTypes.Where(t => parent.IsAssignableFrom(t)).ToList();
            foreach (var type in inheritingTypes)
                WidgetPalette.Add((WidgetPalette)type.GetConstructor(new Type[] { })?.Invoke(new object[] { }));

            if (string.IsNullOrEmpty(Properties.Settings.Default.WidgetSerialized)) return;
            var serializer = new XmlSerializer(typeof(List<WidgetSerializable>));
            var reader = new StringReader(Properties.Settings.Default.WidgetSerialized);
            var deserialized = (List<WidgetSerializable>)serializer.Deserialize(reader);

            foreach (var widget in deserialized)
            {
                var palette = WidgetPalette.FirstOrDefault(x => x.WidgetId == widget.WidgetId);
                if (palette == null)
                    continue;
                var widgetInstance = palette.CreateWidgetInstance();

                widgetInstance.Row = widget.Row;
                widgetInstance.Column = widget.Column;
                widgetInstance.RowSpan = widget.RowSpan;
                widgetInstance.ColumnSpan = widget.ColumnSpan;
                widgetInstance.Settings = widget.Settings;

                WidgetBoard.Add(widgetInstance);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsManipulatorHidden
        {
            get => isManipulatorHidden;
            set
            {
                isManipulatorHidden = value;
                OnPropertyChanged();
            }
        }

        public bool IsSidebarHidden
        {
            get => isSidebarHidden;
            set
            {
                isSidebarHidden = value;
                OnPropertyChanged();
            }
        }

        public double CellSize
        {
            get => cellSize;
            set
            {
                cellSize = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Widget> WidgetBoard { get; set; } = new ObservableCollection<Widget>();

        public ObservableCollection<WidgetPalette> WidgetPalette { get; set; } =
            new ObservableCollection<WidgetPalette>();

        public RelayCommand ToggleManipulatorVisibleCommand
        {
            get
            {
                return toggleManipulatorCommand ?? (toggleManipulatorCommand = new RelayCommand(obj =>
                {
                    IsManipulatorHidden = !IsManipulatorHidden;
                    foreach (var widget in WidgetBoard)
                    {
                        widget.ShadowOpacity = IsManipulatorHidden ? 0.1 : 0.7;
                    }
                }));
            }
        }

        public RelayCommand ToggleSidebarVisibleCommand
        {
            get
            {
                return toggleSidebarCommand ?? (toggleSidebarCommand = new RelayCommand(obj =>
                {
                    IsSidebarHidden = !IsSidebarHidden;
                }));
            }
        }
        
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void MainWindow_Closed(object sender, EventArgs e)
        {
            List<WidgetSerializable> serializableWidgetStruct = new List<WidgetSerializable>();
            foreach (var widget in WidgetBoard)
            {
                serializableWidgetStruct.Add(new WidgetSerializable()
                {
                    Row = widget.Row,
                    Column = widget.Column,
                    RowSpan = widget.RowSpan,
                    ColumnSpan = widget.ColumnSpan,
                    WidgetId = widget.WidgetId,
                    Settings = widget.Settings
                });
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<WidgetSerializable>));
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, serializableWidgetStruct);
            Properties.Settings.Default.WidgetSerialized = writer.ToString();
            Properties.Settings.Default.Save();
            writer.Dispose();

        }
    }
}
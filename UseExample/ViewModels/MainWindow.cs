using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Serialization;
using ExperimentalProject;
using Microsoft.Win32;
using UseExample.Properties;
using UseExample.Utilities;
using Brush = System.Windows.Media.Brush;
using Brushes = System.Windows.Media.Brushes;

namespace UseExample.ViewModels
{
    internal class MainWindow : INotifyPropertyChanged
    {
        private bool isGridDisplayed;
        private bool isManipulatorHidden = true;
        private bool isSidebarHidden = true;
        private Brush backgroundImage = Brushes.LightSlateGray;
        private double cellSize = 120;
        private RelayCommand setBackgroundCommand;
        private RelayCommand toggleManipulatorCommand;
        private RelayCommand toggleSidebarCommand;

        public MainWindow()
        {
            var a = Assembly.LoadFrom("WidgetExportingExample.dll");

            var parent = typeof(WidgetPalette);
            var inheritingTypes = a.DefinedTypes.Where(t => parent.IsAssignableFrom(t)).ToList();
            foreach (var type in inheritingTypes)
                WidgetPalette.Add((WidgetPalette)type.GetConstructor(new Type[] { })?.Invoke(new object[] { }));

            if (string.IsNullOrEmpty(Settings.Default.WidgetSerialized)) return;
            var serializer = new XmlSerializer(typeof(List<WidgetSerializable>));
            var reader = new StringReader(Settings.Default.WidgetSerialized);
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

        public bool IsGridDisplayed
        {
            get => isGridDisplayed;
            set
            {
                isGridDisplayed = value;
                OnPropertyChanged();
            }
        }

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

        public Brush BackgroundColor
        {
            get => backgroundImage;
            set
            {
                backgroundImage = value;
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

        public RelayCommand SetBackgroundCommand
        {
            get
            {
                return setBackgroundCommand ?? (setBackgroundCommand = new RelayCommand(obj =>
                {
                    var dialog = new OpenFileDialog();
                    dialog.Filter = "Image files|*.png;*.jpg;*.bmp|All files (*.*)|*.*";
                    dialog.Multiselect = false;
                    if (dialog.ShowDialog() == true)
                    {
                        var image = Image.FromFile(dialog.FileName);
                        var bitmap = new Bitmap(image);
                        var bitmapSource = Imaging.CreateBitmapSourceFromHBitmap(
                            bitmap.GetHbitmap(),
                            IntPtr.Zero,
                            Int32Rect.Empty,
                            BitmapSizeOptions.FromEmptyOptions()
                        );
                        bitmap.Dispose();

                        BackgroundColor = new ImageBrush(bitmapSource)
                        {
                            Stretch = Stretch.UniformToFill
                        };
                    }
                }));
            }
        }

        public RelayCommand ToggleManipulatorVisibleCommand
        {
            get
            {
                return toggleManipulatorCommand ?? (toggleManipulatorCommand = new RelayCommand(obj =>
                {
                    IsGridDisplayed = IsManipulatorHidden;
                    IsManipulatorHidden = !IsManipulatorHidden;

                    foreach (var widget in WidgetBoard) widget.ShadowOpacity = IsManipulatorHidden ? 0.0 : 0.7;
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

        public void MainWindow_Closed(object sender, EventArgs e)
        {
            var serializableWidgetStruct = new List<WidgetSerializable>();
            foreach (var widget in WidgetBoard)
                serializableWidgetStruct.Add(new WidgetSerializable
                {
                    Row = widget.Row,
                    Column = widget.Column,
                    RowSpan = widget.RowSpan,
                    ColumnSpan = widget.ColumnSpan,
                    WidgetId = widget.WidgetId,
                    Settings = widget.Settings
                });

            var serializer = new XmlSerializer(typeof(List<WidgetSerializable>));
            var writer = new StringWriter();
            serializer.Serialize(writer, serializableWidgetStruct);
            Settings.Default.WidgetSerialized = writer.ToString();
            Settings.Default.Save();
            writer.Dispose();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
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
    /// <summary>
    /// ViewModel for MainWindow
    /// </summary>
    internal class MainWindow : INotifyPropertyChanged
    {
        private bool isGridDisplayed;
        private bool isManipulatorHidden = true;
        private bool isSidebarHidden = true;
        private bool isAutoCellSize = true;
        private bool ignoreWidgetCollision = false;
        private Brush backgroundBrush = Brushes.LightSlateGray;
        private double cellWidth = 120;
        private double cellHeight = 120;
        private int gridColumnCount = 10;
        private int gridRowCount = 5;
        private RelayCommand setBackgroundCommand;
        private RelayCommand toggleManipulatorCommand;
        private RelayCommand toggleSidebarCommand;
        private string backgroundImagePath;

        /// <summary>
        ///     Class that represents the view model of a <see cref="UseExample.MainWindow">Main Window</see>.
        /// </summary>
        public MainWindow()
        {
            var a = Assembly.LoadFrom("WidgetExportingExample.dll");

            var parent = typeof(WidgetPalette);
            var inheritingTypes = a.DefinedTypes.Where(t => parent.IsAssignableFrom(t)).ToList();
            foreach (var type in inheritingTypes)
                WidgetPalette.Add((WidgetPalette)type.GetConstructor(new Type[] { })?.Invoke(new object[] { }));


            if (string.IsNullOrEmpty(Settings.Default.WidgetSerialized)) return;

            var serializer = new XmlSerializer(typeof(WidgetBoardSerializable));
            var reader = new StringReader(Settings.Default.WidgetSerialized);
            var deserialized = (WidgetBoardSerializable)serializer.Deserialize(reader);
            reader.Dispose();

            CellHeight = deserialized.CellHeight;
            CellWidth = deserialized.CellWidth;
            GridColumnCount = deserialized.ColumnCount;
            GridRowCount = deserialized.RowCount;
            IsAutoCellSize = deserialized.AutomaticCellSize;
            IgnoreWidgetCollision = deserialized.IgnoreWidgetCollision;
            if (File.Exists(deserialized.BackgroundImagePath))
            {
                backgroundImagePath = deserialized.BackgroundImagePath;
                SetBackgroundImage(deserialized.BackgroundImagePath);
            }

            foreach (var widget in deserialized.WidgetsOnBoard)
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

        /// <summary>
        ///     Event that triggered when any properties are changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Bound property for grid visibility state on widget board
        /// </summary>
        public bool IsGridDisplayed
        {
            get => isGridDisplayed;
            set
            {
                isGridDisplayed = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Bound property for the visibility state of widget handles
        /// </summary>
        public bool IsManipulatorHidden
        {
            get => isManipulatorHidden;
            set
            {
                isManipulatorHidden = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Bound property for the visibility state of widget palette
        /// </summary>
        public bool IsSidebarHidden
        {
            get => isSidebarHidden;
            set
            {
                isSidebarHidden = value;
                OnPropertyChanged();
            }
        }

        public bool IgnoreWidgetCollision
        {
            get => ignoreWidgetCollision;
            set
            {
                ignoreWidgetCollision = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Bound property to fill the background with a color or image
        /// </summary>
        public Brush BackgroundColor
        {
            get => backgroundBrush;
            set
            {
                backgroundBrush = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Bound property for cell width
        /// </summary>
        public double CellWidth
        {
            get => cellWidth;
            set
            {
                cellWidth = value;
                OnPropertyChanged();
            }
        }

        public bool IsAutoCellSize
        {
            get => isAutoCellSize;
            set
            {
                isAutoCellSize = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Bound property for cell height
        /// </summary>
        public double CellHeight
        {
            get => cellHeight;
            set
            {
                cellHeight = value;
                OnPropertyChanged();
            }
        }

        public int GridColumnCount
        {
            get => gridColumnCount;
            set
            {
                gridColumnCount = value;
                OnPropertyChanged();
            }
        }

        public int GridRowCount
        {
            get=> gridRowCount;
            set
            {
                gridRowCount = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        ///     Bound property for widget list on the board
        /// </summary>
        public ObservableCollection<Widget> WidgetBoard { get; set; } = new ObservableCollection<Widget>();

        /// <summary>
        ///     Bound property for widget palettes list on the sidebar
        /// </summary>
        public ObservableCollection<WidgetPalette> WidgetPalette { get; set; } =
            new ObservableCollection<WidgetPalette>();

        /// <summary>
        ///     Command to define widget board background image from file
        /// </summary>
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
                        backgroundImagePath = dialog.FileName;
                        SetBackgroundImage(backgroundImagePath);
                    }
                }));
            }
        }

        private void SetBackgroundImage(string imagePath)
        {
            var image = Image.FromFile(imagePath);
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

        /// <summary>
        ///     Command to toggle widget handles visibility
        /// </summary>
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

        /// <summary>
        ///     Command to toggle widget palette visibility
        /// </summary>
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

            var serializableWidgetBoardStruct = new WidgetBoardSerializable
            {
                WidgetsOnBoard = serializableWidgetStruct,
                IgnoreWidgetCollision = IgnoreWidgetCollision,
                AutomaticCellSize = IsAutoCellSize,
                CellHeight = CellHeight,
                CellWidth = CellWidth,
                ColumnCount = GridColumnCount,
                RowCount = GridRowCount,
                BackgroundImagePath = backgroundImagePath
            };


            var serializer = new XmlSerializer(typeof(WidgetBoardSerializable));
            var writer = new StringWriter();
            serializer.Serialize(writer, serializableWidgetBoardStruct);
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
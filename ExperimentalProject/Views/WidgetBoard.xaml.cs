using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace ExperimentalProject.Views
{
    /// <summary>
    ///     Represent element for placing <see cref="ExperimentalProject.Widget">Widgets</see> and
    ///     <see cref="ExperimentalProject.WidgetPalette">WidgetPalettes</see>
    /// </summary>
    public partial class WidgetBoard
    {
        public static readonly DependencyProperty AutoCellSizeProperty;
        public static readonly DependencyProperty BoardBackgroundProperty;
        public static readonly DependencyProperty BoardForegroundProperty;
        public static readonly DependencyProperty CellHeightProperty;
        public static readonly DependencyProperty CellWidthProperty;
        public static readonly DependencyProperty GridColumnCountProperty;
        public static readonly DependencyProperty GridRowCountProperty;
        public static readonly DependencyProperty IgnoreWidgetCollisionProperty;
        public static readonly DependencyProperty IsGridDisplayedProperty;
        public static readonly DependencyProperty IsManipulatorHiddenProperty;
        public static readonly DependencyProperty IsSidebarHiddenProperty;
        public static readonly DependencyProperty PaletteBackgroundProperty;
        public static readonly DependencyProperty PaletteForegroundProperty;
        public static readonly DependencyProperty SidebarWidthProperty;
        public static readonly DependencyProperty WidgetsOnBoardProperty;
        public static readonly DependencyProperty WidgetsPaletteProperty;

        private readonly List<TextBlock> sidebarGroupLabels = new List<TextBlock>();
        private IWidgetTransformSolver _widgetTransformSolver;

        /// <summary>
        ///     Class for handling interface logic and providing bindings
        /// </summary>
        static WidgetBoard()
        {
            IsGridDisplayedProperty = DependencyProperty.Register(
                "IsGridDisplayed",
                typeof(bool),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    true,
                    OnIsGridDisplayedChanged
                )
            );
            BoardBackgroundProperty = DependencyProperty.Register(
                "BoardBackground",
                typeof(Brush),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    Brushes.LightGray,
                    OnBoardBackgroundChanged
                )
            );
            BoardForegroundProperty = DependencyProperty.Register(
                "BoardForeground",
                typeof(Brush),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    Brushes.DimGray,
                    OnBoardForegroundChanged
                )
            );
            PaletteBackgroundProperty = DependencyProperty.Register(
                "PaletteBackground",
                typeof(Brush),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    Brushes.Azure,
                    OnPaletteBackgroundChanged
                )
            );
            PaletteForegroundProperty = DependencyProperty.Register(
                "PaletteForeground",
                typeof(Brush),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    Brushes.DimGray,
                    OnPaletteForegroundChanged
                )
            );

            CellHeightProperty = DependencyProperty.Register(
                "CellHeight",
                typeof(double),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    150.0d,
                    OnCellHeightChanged
                )
            );
            CellWidthProperty = DependencyProperty.Register(
                "CellWidth",
                typeof(double),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    200.0d,
                    OnCellWidthChanged
                )
            );
            SidebarWidthProperty = DependencyProperty.Register(
                "SideboardWidth",
                typeof(double),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    204.0d
                )
            );
            WidgetsOnBoardProperty = DependencyProperty.Register(
                "WidgetsOnBoard",
                typeof(ObservableCollection<ExperimentalProject.Widget>),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    new ObservableCollection<ExperimentalProject.Widget>(),
                    OnWidgetsOnBoardChanged
                )
            );
            WidgetsPaletteProperty = DependencyProperty.Register(
                "WidgetsPalette",
                typeof(ObservableCollection<ExperimentalProject.WidgetPalette>),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    new ObservableCollection<ExperimentalProject.WidgetPalette>(),
                    OnWidgetsPaletteChanged
                )
            );
            IsManipulatorHiddenProperty = DependencyProperty.Register(
                "IsManipulatorHidden",
                typeof(bool),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    true,
                    OnIsManipulatorHiddenChanged
                )
            );
            IgnoreWidgetCollisionProperty = DependencyProperty.Register(
                "IgnoreWidgetCollision",
                typeof(bool),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    false,
                    OnIgnoreWidgetCollisionChanged
                )
            );
            IsSidebarHiddenProperty = DependencyProperty.Register(
                "IsSidebarHidden",
                typeof(bool),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    true,
                    OnIsSidebarHiddenChanged
                )
            );
            AutoCellSizeProperty = DependencyProperty.Register(
                "AutoCellSize",
                typeof(bool),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    true,
                    OnAutoCellSizeChanged
                )
            );
            GridColumnCountProperty = DependencyProperty.Register(
                "GridColumnCount",
                typeof(int),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    3,
                    OnGridColumnCountChanged
                )
            );
            GridRowCountProperty = DependencyProperty.Register(
                "GridRowCount",
                typeof(int),
                typeof(WidgetBoard),
                new FrameworkPropertyMetadata(
                    3,
                    OnGridRowCountChanged
                )
            );
        }

        private static void OnIgnoreWidgetCollisionChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is WidgetBoard board)) return;

            board._widgetTransformSolver.IgnoreWidgetCollision = (bool)e.NewValue;
        }

        /// <summary>
        ///     Class for handling interface logic and providing bindings
        /// </summary>
        public WidgetBoard()
        {
            InitializeComponent();
            Loaded += OnLoad;
            SizeChanged += OnSizeChanged;
            UpdateGridDimensions();
            _widgetTransformSolver = new WidgetTransformSolver(WidgetsOnBoard);
        }

        /// <summary>
        ///     Gets or sets the activity of calculated cell sizes
        /// </summary>
        public bool AutoCellSize
        {
            get => (bool)GetValue(AutoCellSizeProperty);
            set => SetValue(AutoCellSizeProperty, value);
        }

        /// <summary>
        ///     Gets or sets the grid's rendering state
        /// </summary>
        public bool IsGridDisplayed
        {
            get => (bool)GetValue(IsGridDisplayedProperty);
            set => SetValue(IsGridDisplayedProperty, value);
        }

        /// <summary>
        ///     Gets or sets the visibility of widget manipulators for <see cref="Widget" />
        /// </summary>
        public bool IsManipulatorHidden
        {
            get => (bool)GetValue(IsManipulatorHiddenProperty);
            set => SetValue(IsManipulatorHiddenProperty, value);
        }

        /// <summary>
        ///     Gets or sets the visibility of sidebar with <see cref="Views.WidgetPalette">WidgetPalette</see>
        /// </summary>
        public bool IsSidebarHidden
        {
            get => (bool)GetValue(IsSidebarHiddenProperty);
            set => SetValue(IsSidebarHiddenProperty, value);
        }

        public bool IgnoreWidgetCollision
        {
            get=> (bool) GetValue(IgnoreWidgetCollisionProperty);
            set=> SetValue(IgnoreWidgetCollisionProperty, value);
        }

        /// <summary>
        ///     Gets or sets the filling the background for the main widget board field
        /// </summary>
        public Brush BoardBackground
        {
            get => (Brush)GetValue(BoardBackgroundProperty);
            set => SetValue(BoardBackgroundProperty, value);
        }

        /// <summary>
        ///     Gets or sets the color for grid lines and other stuff
        /// </summary>
        public Brush BoardForeground
        {
            get => (Brush)GetValue(BoardForegroundProperty);
            set => SetValue(BoardForegroundProperty, value);
        }

        /// <summary>
        ///     Gets or sets the filling the background for the widget palette field
        /// </summary>
        public Brush PaletteBackground
        {
            get => (Brush)GetValue(PaletteBackgroundProperty);
            set => SetValue(PaletteBackgroundProperty, value);
        }

        /// <summary>
        ///     Gets or sets the color for Group Labels and other stuff
        /// </summary>
        public Brush PaletteForeground
        {
            get => (Brush)GetValue(PaletteForegroundProperty);
            set => SetValue(PaletteForegroundProperty, value);
        }

        /// <summary>
        ///     Gets or sets the cell height to use in building the interface.
        /// </summary>
        public double CellHeight
        {
            get => (double)GetValue(CellHeightProperty);
            set => SetValue(CellHeightProperty, value);
        }

        /// <summary>
        ///     Gets or sets the cell width to use in building the interface.
        /// </summary>
        public double CellWidth
        {
            get => (double)GetValue(CellWidthProperty);
            set => SetValue(CellWidthProperty, value);
        }

        /// <summary>
        ///     Gets or sets the sidebar width with <see cref="Views.WidgetPalette">WidgetPalette</see>
        /// </summary>
        public double SidebarWidth
        {
            get => (double)GetValue(SidebarWidthProperty);
            set => SetValue(SidebarWidthProperty, value);
        }

        /// <summary>
        ///     Gets or sets the displayed on background grid column count
        /// </summary>
        public int GridColumnCount
        {
            get => (int)GetValue(GridColumnCountProperty);
            set => SetValue(GridColumnCountProperty, value);
        }

        /// <summary>
        ///     Gets or sets the displayed on background grid row count
        /// </summary>
        public int GridRowCount
        {
            get => (int)GetValue(GridRowCountProperty);
            set => SetValue(GridRowCountProperty, value);
        }

        /// <summary>
        ///     Gets or sets the collection of <see cref="ExperimentalProject.Widget">Widgets</see> located on a board
        /// </summary>
        public ObservableCollection<ExperimentalProject.Widget> WidgetsOnBoard
        {
            get => (ObservableCollection<ExperimentalProject.Widget>)GetValue(WidgetsOnBoardProperty);
            set => SetValue(WidgetsOnBoardProperty, value);
        }

        /// <summary>
        ///     Gets or sets the collection of <see cref="ExperimentalProject.WidgetPalette">WidgetPalettes</see> located on a
        ///     board
        /// </summary>
        public ObservableCollection<ExperimentalProject.WidgetPalette> WidgetsPalette
        {
            get => (ObservableCollection<ExperimentalProject.WidgetPalette>)GetValue(WidgetsPaletteProperty);
            set => SetValue(WidgetsPaletteProperty, value);
        }

        /// <summary>
        ///     Handler called when the <see cref="AutoCellSize"> Auto cell size</see> value changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnAutoCellSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board)
                board.ToggleAutoCellSize();
        }

        /// <summary>
        ///     Handler called when the <see cref="BoardBackground">Board Background</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnBoardBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board) board.WidgetCanvas.Background = (Brush)e.NewValue;
        }

        /// <summary>
        ///     Handler called when the <see cref="BoardForeground">Board Foreground</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnBoardForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board)
                foreach (Line line in board.GridOverlay.Children)
                    line.Stroke = (Brush)e.NewValue;
        }

        /// <summary>
        ///     Handler called when the <see cref="CellHeight">CellHeight</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnCellHeightChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is WidgetBoard board)) return;

            board.ResizeGrid();
            foreach (var widget in board.WidgetsOnBoard)
                widget.SetCellHeight((double)e.NewValue);
        }

        /// <summary>
        ///     Handler called when the <see cref="CellWidth">CellWidth</see> changes
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void OnCellWidthChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is WidgetBoard board)) return;

            board.ResizeGrid();
            foreach (var widget in board.WidgetsOnBoard)
                widget.SetCellWidth((double)e.NewValue);
        }

        /// <summary>
        ///     Handler called when the <see cref="GridColumnCount">GridColumnCount</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnGridColumnCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board) board.UpdateGridDimensions();
        }

        /// <summary>
        ///     Handler called when the <see cref="GridRowCount">GridRowCount</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnGridRowCountChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board)
                board.UpdateGridDimensions();
        }

        /// <summary>
        ///     Handler called when the <see cref="IsGridDisplayed">Grid Displayed</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnIsGridDisplayedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board)
            {
                board.ResizeGrid();
                board.GridOverlay.Visibility = (bool)e.NewValue ? Visibility.Visible : Visibility.Hidden;
            }
        }

        /// <summary>
        ///     Handler called when the <see cref="IsManipulatorHidden">IsManipulatorHidden</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnIsManipulatorHiddenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board)
                board.ToggleWidgetManipulators();
        }

        /// <summary>
        ///     Handler called when the <see cref="IsSidebarHidden">IsSidebarHidden</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnIsSidebarHiddenChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board)
                board.ToggleWidgetSidebar();
        }

        /// <summary>
        ///     Handler called when the <see cref="PaletteBackground">Palette Background</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnPaletteBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board) board.WidgetSidebarBackground.Fill = (Brush)e.NewValue;
        }

        /// <summary>
        ///     Handler called when the <see cref="PaletteForeground">Palette Foreground</see> changes
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnPaletteForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board)
            {
                foreach (var label in board.sidebarGroupLabels)
                    label.Foreground = (Brush)e.NewValue;
                board.Resources["ForegroundBrush"] = (Brush)e.NewValue;
            }
        }

        /// <summary>
        ///     Handler called when the <see cref="WidgetsOnBoard">WidgetsOnBoard</see> replaced
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnWidgetsOnBoardChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board)
            {
                ((ObservableCollection<ExperimentalProject.Widget>)e.OldValue).CollectionChanged -=
                    board.OnBoardChangedHandler;
                ((ObservableCollection<ExperimentalProject.Widget>)e.NewValue).CollectionChanged +=
                    board.OnBoardChangedHandler;
                board._widgetTransformSolver =
                    new WidgetTransformSolver((ObservableCollection<ExperimentalProject.Widget>)e.NewValue);


                foreach (var widget in (ObservableCollection<ExperimentalProject.Widget>)e.NewValue)
                {
                    widget.WidgetTransformSolver = board._widgetTransformSolver;
                    board.AddWidget(widget);
                }
            }
        }

        /// <summary>
        ///     Handler called when the <see cref="WidgetPalette">WidgetPalette</see> replaced
        /// </summary>
        /// <param name="d">The <see cref="WidgetBoard" /> instance whose property has been changed </param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnWidgetsPaletteChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is WidgetBoard board)
            {
                var newWidgetsPalette = (ObservableCollection<ExperimentalProject.WidgetPalette>)e.NewValue;
                newWidgetsPalette.CollectionChanged += board.OnPaletteChangedHandler;

                foreach (var widgetPalette in (ObservableCollection<ExperimentalProject.WidgetPalette>)e.NewValue)
                    widgetPalette.OnCreateWidgetEvent += board.OnCreateWidgetHandler;
                board.RenderWidgetPalette();
            }
        }

        /// <summary>
        ///     Toggles visibility of <see cref="ExperimentalProject.Widget">Widget</see> Manipulators
        /// </summary>
        public void ToggleWidgetManipulators()
        {
            foreach (var widget in WidgetsOnBoard)
                widget.IsManipulatorVisible = !IsManipulatorHidden;
        }

        /// <summary>
        ///     Toggles visibility of sidebar with <see cref="ExperimentalProject.WidgetPalette">WidgetPalettes</see>
        /// </summary>
        public void ToggleWidgetSidebar()
        {
            var widthAnimation = new DoubleAnimation
            {
                From = IsSidebarHidden ? SidebarWidth : 0,
                To = IsSidebarHidden ? 0 : SidebarWidth,
                Duration = TimeSpan.FromMilliseconds(600),
                EasingFunction = new ElasticEase
                {
                    EasingMode = EasingMode.EaseInOut,
                    Oscillations = 0,
                    Springiness = 3
                }
            };

            widthAnimation.Completed += OnWidthAnimationCompletedHandler;

            WidgetSidebar.BeginAnimation(WidthProperty, widthAnimation);
            WidgetSidebar.Width = (int)widthAnimation.To;
        }

        /// <summary>
        ///     Add <see cref="ExperimentalProject.Widget">Widget</see> to this WidgetBoard
        /// </summary>
        /// <param name="widget">Widget to add</param>
        private void AddWidget(ExperimentalProject.Widget widget)
        {
            var cellHeight = (double)GetValue(CellHeightProperty);
            var cellWidth = (double)GetValue(CellWidthProperty);
            widget.IsManipulatorVisible = !IsManipulatorHidden;
            widget.OnRemoveWidgetEvent += RemoveWidget;
            widget.SetCellHeight(cellHeight);
            widget.SetCellWidth(cellWidth);
            WidgetCanvas.Children.Add(widget.WidgetView);
        }

        /// <summary>
        ///     Handler called when the <see cref="WidgetsOnBoard">WidgetsOnBoard</see> collection changed
        /// </summary>
        /// <param name="sender">The object that initiated the change to the collection</param>
        /// <param name="e">An object that describes a change in a collection</param>
        private void OnBoardChangedHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (ExperimentalProject.Widget widget in e.NewItems)
                    {
                        widget.WidgetTransformSolver = _widgetTransformSolver;
                        AddWidget(widget);
                    }
                    break;

                case NotifyCollectionChangedAction.Remove:
                    foreach (ExperimentalProject.Widget widget in e.OldItems)
                        RemoveWidget(widget);
                    break;
            }
        }

        /// <summary>
        ///     Handler called when <see cref="ExperimentalProject.WidgetPalette">WidgetPalette</see> instance create a new
        ///     <see cref="ExperimentalProject.Widget">Widget</see> instance
        /// </summary>
        /// <param name="sender">The object that initiated the change to the collection</param>
        /// <param name="widget">Created <see cref="ExperimentalProject.Widget">Widget</see> instance</param>
        private void OnCreateWidgetHandler(object sender, ExperimentalProject.Widget widget)
        {
            WidgetsOnBoard.Add(widget);
        }

        /// <summary>
        ///     Handler called when the <see cref="WidgetBoard">Widget Board</see> has been completely initialized
        /// </summary>
        /// <param name="sender">The <see cref="WidgetBoard" /> instance that has been initialized </param>
        private void OnLoad(object sender, RoutedEventArgs e)
        {
            ToggleAutoCellSize();
        }

        /// <summary>
        ///     Handler called when the <see cref="WidgetsPalette">WidgetsPalette</see> collection changed
        /// </summary>
        /// <param name="sender">The object that initiated the change to the collection</param>
        /// <param name="e">An object that describes a change in a collection</param>
        private void OnPaletteChangedHandler(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (ExperimentalProject.WidgetPalette widgetPalette in e.NewItems)
                    {
                        WidgetPalette.Children.Add(widgetPalette.WidgetPaletteView);
                        widgetPalette.OnCreateWidgetEvent += OnCreateWidgetHandler;
                    }

                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (ExperimentalProject.WidgetPalette widgetPalette in e.OldItems)
                    {
                        WidgetsPalette.Remove(widgetPalette);
                        WidgetPalette.Children.Remove(widgetPalette.WidgetPaletteView);
                    }

                    break;
                case NotifyCollectionChangedAction.Replace:
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        ///     Handler called when the <see cref="WidgetBoard">Widget Board</see> has been resized
        /// </summary>
        /// <param name="sender">The <see cref="WidgetBoard" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a size changing</param>
        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            ToggleAutoCellSize();
        }

        /// <summary>
        ///     Handler called then transform animation is completed
        /// </summary>
        /// <param name="sender">The object that initiated the change to the collection</param>
        /// <param name="e">Standard event arguments (empty)</param>
        private void OnWidthAnimationCompletedHandler(object sender, EventArgs e)
        {
            WidgetSidebar.BeginAnimation(WidthProperty, null);
        }

        /// <summary>
        ///     Remove <see cref="ExperimentalProject.Widget">Widget</see> from WidgetBoard
        /// </summary>
        /// <param name="widget">Removed <see cref="ExperimentalProject.Widget">Widget</see> instance</param>
        private void RemoveWidget(ExperimentalProject.Widget widget)
        {
            WidgetsOnBoard.Remove(widget);
            WidgetCanvas.Children.Remove(widget.WidgetView);
        }

        /// <summary>
        ///     Draw a widget palettes in sidebar
        /// </summary>
        private void RenderWidgetPalette()
        {
            sidebarGroupLabels.Clear();

            foreach (var widgetGroup in WidgetsPalette.OrderBy(x => x.GroupName).ThenBy(x => x.Title)
                         .GroupBy(x => x.GroupName))
            {
                var label = new TextBlock
                {
                    Text = widgetGroup.Key,
                    Padding = new Thickness(10, 10, 0, 0),
                    Foreground = PaletteForeground
                };
                sidebarGroupLabels.Add(label);
                WidgetPalette.Children.Add(label);

                foreach (var widget in widgetGroup) WidgetPalette.Children.Add(widget.WidgetPaletteView);
            }
        }

        /// <summary>
        ///     Update the positions of the background grid lines
        /// </summary>
        private void ResizeGrid()
        {
            if (!IsGridDisplayed)
                return;

            for (var i = 0; i <= GridColumnCount; i++)
            {
                ((Line)GridOverlay.Children[i]).X1 = i * CellWidth;
                ((Line)GridOverlay.Children[i]).X2 = i * CellWidth;
                ((Line)GridOverlay.Children[i]).Y1 = 0;
                ((Line)GridOverlay.Children[i]).Y2 = GridRowCount * CellHeight;
            }

            for (var i = 0; i <= GridRowCount; i++)
            {
                ((Line)GridOverlay.Children[i + GridColumnCount + 1]).X1 = 0;
                ((Line)GridOverlay.Children[i + GridColumnCount + 1]).X2 = GridColumnCount * CellWidth;
                ((Line)GridOverlay.Children[i + GridColumnCount + 1]).Y1 = i * CellHeight;
                ((Line)GridOverlay.Children[i + GridColumnCount + 1]).Y2 = i * CellHeight;
            }
        }

        /// <summary>
        ///     Update cell size by <see cref="AutoCellSize">AutoCellSize</see> value
        /// </summary>
        private void ToggleAutoCellSize()
        {
            if (AutoCellSize)
            {
                CellHeight = ActualHeight / GridRowCount;
                CellWidth = ActualWidth / GridColumnCount;
            }
            ResizeGrid();
        }

        /// <summary>
        ///     Complete updating grid lines
        /// </summary>
        private void UpdateGridDimensions()
        {
            GridOverlay.Children.Clear();

            for (var i = 0; i <= GridColumnCount; i++)
            {
                var verticalLine = new Line
                {
                    Stroke = BoardForeground,
                    StrokeThickness = 1,
                    StrokeDashArray = new DoubleCollection { 4, 4 },
                    ClipToBounds = true
                };
                GridOverlay.Children.Add(verticalLine);
            }

            for (var i = 0; i <= GridRowCount; i++)
            {
                var horizontalLine = new Line
                {
                    Stroke = BoardForeground,
                    StrokeThickness = 1,
                    StrokeDashArray = new DoubleCollection { 4, 4 },
                    ClipToBounds = true
                };
                GridOverlay.Children.Add(horizontalLine);
            }

            ToggleAutoCellSize();
        }
    }
}
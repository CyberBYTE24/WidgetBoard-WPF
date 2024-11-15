using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace ExperimentalProject.Views
{
    /// <summary>
    ///     Represents a Widget item on a <see cref="WidgetBoard">WidgetBoard</see>.
    /// </summary>
    public partial class Widget
    {
        public static readonly DependencyProperty ColumnProperty;
        public static readonly DependencyProperty ColumnSpanProperty;
        public static readonly DependencyProperty ManipulatorVisibilityProperty;
        public static readonly DependencyProperty MinColumnSpanProperty;
        public static readonly DependencyProperty MinRowSpanProperty;
        public static readonly DependencyProperty RowProperty;
        public static readonly DependencyProperty RowSpanProperty;
        public static readonly DependencyProperty SettingsButtonVisibilityProperty;
        public static readonly DependencyProperty ShadowOpacityProperty;

        private bool isDragging;
        private bool isResizing;
        private double cellHeight = 150;
        private double cellWidth = 200;
        private Point lastPosition;

        /// <summary>
        ///     Class for handling interface logic and providing bindings
        /// </summary>
        static Widget()
        {
            ColumnProperty = DependencyProperty.Register(
                "Column",
                typeof(int),
                typeof(Widget),
                new FrameworkPropertyMetadata(
                    0,
                    OnColumnChanged
                )
            );
            ColumnSpanProperty = DependencyProperty.Register(
                "ColumnSpan",
                typeof(int),
                typeof(Widget),
                new FrameworkPropertyMetadata(
                    1,
                    OnColumnSpanChanged
                )
            );
            RowProperty = DependencyProperty.Register(
                "Row",
                typeof(int),
                typeof(Widget),
                new FrameworkPropertyMetadata(
                    0,
                    OnRowChanged
                )
            );
            RowSpanProperty = DependencyProperty.Register(
                "RowSpan",
                typeof(int),
                typeof(Widget),
                new FrameworkPropertyMetadata(
                    1,
                    OnRowSpanChanged
                )
            );
            MinColumnSpanProperty = DependencyProperty.Register(
                "MinColumnSpan",
                typeof(int),
                typeof(Widget),
                new FrameworkPropertyMetadata(
                    1,
                    OnMinColumnSpanChanged
                )
            );
            MinRowSpanProperty = DependencyProperty.Register(
                "MinRowSpan",
                typeof(int),
                typeof(Widget),
                new FrameworkPropertyMetadata(
                    1,
                    OnMinRowSpanChanged
                )
            );
            ManipulatorVisibilityProperty = DependencyProperty.Register(
                "ManipulatorVisibility",
                typeof(Visibility),
                typeof(Widget),
                new FrameworkPropertyMetadata(
                    OnManipulatorVisibilityChanged
                )
            );
            SettingsButtonVisibilityProperty = DependencyProperty.Register(
                "SettingsButtonVisibility",
                typeof(Visibility),
                typeof(Widget),
                new FrameworkPropertyMetadata(
                    OnSettingsButtonVisibilityChanged
                )
            );
            ShadowOpacityProperty = DependencyProperty.Register(
                "ShadowOpacity",
                typeof(double),
                typeof(Widget),
                new FrameworkPropertyMetadata(
                    OnShadowOpacityChanged
                )
            );
        }

        /// <summary>
        ///     Class for handling interface logic and providing bindings
        /// </summary>
        /// <param name="userControl"></param>
        public Widget(UserControl userControl)
        {
            InitializeComponent();
            WidgetHeader.MouseLeftButtonDown += HeaderMouseLeftButtonDownHandler;
            WidgetHeader.MouseLeftButtonUp += HeaderMouseLeftButtonUpHandler;
            WidgetHeader.MouseMove += HeaderMouseMoveHandler;

            ResizeGrip.MouseLeftButtonDown += ResizeMouseLeftButtonDownHandler;
            ResizeGrip.MouseLeftButtonUp += ResizeMouseLeftButtonUpHandler;
            ResizeGrip.MouseMove += ResizeMouseMoveHandler;

            UserControl.Content = userControl;

            InitializeOnBoard();
        }

        /// <summary>
        ///     The transparency of the shadow cast by the widget
        /// </summary>
        public double ShadowOpacity
        {
            get => (double)GetValue(ShadowOpacityProperty);
            set => SetValue(ShadowOpacityProperty, value);
        }

        /// <summary>
        ///     Gets or sets the X-position on <see cref="WidgetBoard">WidgetBoard</see> (measured in cells)
        /// </summary>
        public int Column
        {
            get => (int)GetValue(ColumnProperty);
            set => SetValue(ColumnProperty, value);
        }

        /// <summary>
        ///     Gets or sets the width on <see cref="WidgetBoard">WidgetBoard</see> (measured in cells)
        /// </summary>
        public int ColumnSpan
        {
            get => (int)GetValue(ColumnSpanProperty);
            set => SetValue(ColumnSpanProperty, value);
        }

        /// <summary>
        ///     Gets or sets the minimal Widget width (measured in cells)
        /// </summary>
        public int MinColumnSpan
        {
            get => (int)GetValue(MinColumnSpanProperty);
            set => SetValue(MinColumnSpanProperty, value);
        }

        /// <summary>
        ///     Gets or sets the minimal Widget height (measured in cells)
        /// </summary>
        public int MinRowSpan
        {
            get => (int)GetValue(MinRowSpanProperty);
            set => SetValue(MinRowSpanProperty, value);
        }

        /// <summary>
        ///     Gets or sets the Y-position on <see cref="WidgetBoard">WidgetBoard</see> (measured in cells)
        /// </summary>
        public int Row
        {
            get => (int)GetValue(RowProperty);
            set => SetValue(RowProperty, value);
        }

        /// <summary>
        ///     Gets or sets the height on <see cref="WidgetBoard">WidgetBoard</see> (measured in cells)
        /// </summary>
        public int RowSpan
        {
            get => (int)GetValue(RowSpanProperty);
            set => SetValue(RowSpanProperty, value);
        }

        internal (int x1, int y1, int x2, int y2) Bound => (Column, Row, Column + ColumnSpan, Row + RowSpan);

        internal IWidgetTransformSolver WidgetTransformSolver { get; set; }

        /// <summary>
        ///     Gets or sets the visibility state of Widget manipulator
        /// </summary>
        public Visibility ManipulatorVisibility
        {
            get => (Visibility)GetValue(ManipulatorVisibilityProperty);
            set => SetValue(ManipulatorVisibilityProperty, value);
        }

        /// <summary>
        ///     Gets or sets the visibility of the settings button
        /// </summary>
        public Visibility SettingsButtonVisibility
        {
            get => (Visibility)GetValue(SettingsButtonVisibilityProperty);
            set => SetValue(SettingsButtonVisibilityProperty, value);
        }

        /// <summary>
        ///     Handler called when the Column changes
        /// </summary>
        /// <param name="d">The <see cref="Widget" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnColumnChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Widget widget)
                Canvas.SetLeft(widget, (int)e.NewValue * widget.cellWidth);
        }

        /// <summary>
        ///     Handler called when the ColumnSpan changes
        /// </summary>
        /// <param name="d">The <see cref="Widget" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnColumnSpanChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Widget widget)
                widget.Width = (int)e.NewValue * widget.cellWidth;
        }

        /// <summary>
        ///     Handler called when the Manipulator Visibility changes
        /// </summary>
        /// <param name="d">The <see cref="Widget" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnManipulatorVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Widget widget)
            {
                widget.ResizeGrip.Visibility = (Visibility)e.NewValue;
                widget.WidgetHeader.Visibility = (Visibility)e.NewValue;
            }
        }

        /// <summary>
        ///     Handler called when the Minimal ColumnSpan changes
        /// </summary>
        /// <param name="d">The <see cref="Widget" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnMinColumnSpanChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Widget widget) widget.InitializeOnBoard();
        }

        /// <summary>
        ///     Handler called when the Minimal RowSpan changes
        /// </summary>
        /// <param name="d">The <see cref="Widget" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnMinRowSpanChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Widget widget) widget.InitializeOnBoard();
        }

        /// <summary>
        ///     Handler called when the Row changes
        /// </summary>
        /// <param name="d">The <see cref="Widget" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnRowChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Widget widget)
                Canvas.SetTop(widget, (int)e.NewValue * widget.cellHeight);
        }

        /// <summary>
        ///     Handler called when the RowSpan changes
        /// </summary>
        /// <param name="d">The <see cref="Widget" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnRowSpanChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Widget widget)
                widget.Height = (int)e.NewValue * widget.cellHeight;
        }

        /// <summary>
        ///     Handler that is called when the visibility state changes
        /// </summary>
        /// <param name="d">The <see cref="Widget" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnSettingsButtonVisibilityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Widget widget) widget.SettingsButton.Visibility = (Visibility)e.NewValue;
        }

        /// <summary>
        ///     Handler that is called when the shadow opacity changes
        /// </summary>
        /// <param name="d">The <see cref="Widget" /> instance whose property has been changed</param>
        /// <param name="e">An object that describes a change in a dependent property</param>
        private static void OnShadowOpacityChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Widget widget)
                widget.ShadowOpacity = (double)e.NewValue;
        }

        /// <summary>
        ///     Set new cell height and then update transform
        /// </summary>
        /// <param name="value">New cell height</param>
        internal void SetCellHeight(double value)
        {
            cellHeight = value;
            InitializeOnBoard();
        }

        /// <summary>
        ///     Set new cell width and then update transform
        /// </summary>
        /// <param name="value">New cell width</param>
        internal void SetCellWidth(double value)
        {
            cellWidth = value;
            InitializeOnBoard();
        }

        /// <summary>
        ///     Handler called when Widget Drag start
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Provides data for mouse button events</param>
        private void HeaderMouseLeftButtonDownHandler(object sender, MouseButtonEventArgs e)
        {
            if (isResizing) return;

            isDragging = true;
            lastPosition = e.GetPosition(Parent as Canvas);
            Mouse.Capture(WidgetHeader);
            Panel.SetZIndex(this, 1);
        }

        /// <summary>
        ///     Handler called when Widget Drag end
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Provides data for mouse button events</param>
        private void HeaderMouseLeftButtonUpHandler(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(null);
            isDragging = false;

            var left = Canvas.GetLeft(this);
            var top = Canvas.GetTop(this);

            var snappedLeft = (int)Math.Round(left / cellWidth);
            var snappedTop = (int)Math.Round(top / cellHeight);

            var targetLeft = Column;
            var targetTop = Row;

            if (WidgetTransformSolver.IsWidgetTransformPossible(this, (snappedLeft, snappedTop, snappedLeft+ColumnSpan, snappedTop+RowSpan)))
            {
                targetLeft = snappedLeft;
                targetTop = snappedTop;
            }
            var leftAnimation = new DoubleAnimation
            {
                From = left,
                To = targetLeft * cellWidth,
                Duration = TimeSpan.FromMilliseconds(600)
            };

            leftAnimation.Completed += LeftAnimation_Completed;
            leftAnimation.EasingFunction = new ElasticEase
            {
                EasingMode = EasingMode.EaseOut,
                Oscillations = 1,
                Springiness = 3
            };

            var topAnimation = new DoubleAnimation
            {
                From = top,
                To = targetTop * cellHeight,
                Duration = TimeSpan.FromMilliseconds(600)
            };
            topAnimation.Completed += TopAnimation_Completed;
            topAnimation.EasingFunction = new ElasticEase
            {
                EasingMode = EasingMode.EaseOut,
                Oscillations = 1,
                Springiness = 3
            };

            BeginAnimation(Canvas.LeftProperty, leftAnimation);
            BeginAnimation(Canvas.TopProperty, topAnimation);

            Column = targetLeft;
            Row = targetTop;
            InitializeOnBoard();
        }

        /// <summary>
        ///     Handler called during Widget Drag
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Provides data for mouse position events</param>
        private void HeaderMouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (!isDragging) return;
            if (!(Parent is Canvas canvas)) return;

            var newPosition = e.GetPosition(canvas);
            var offsetX = newPosition.X - lastPosition.X;
            var offsetY = newPosition.Y - lastPosition.Y;

            var newLeft = Canvas.GetLeft(this) + offsetX;
            var newTop = Canvas.GetTop(this) + offsetY;

            Canvas.SetLeft(this, newLeft);
            Canvas.SetTop(this, newTop);

            lastPosition = newPosition;
        }

        /// <summary>
        ///     Handler called when the Height animation end
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Standard event argument object (empty)</param>
        private void HeightAnimation_Completed(object sender, EventArgs e)
        {
            BeginAnimation(HeightProperty, null);
            Panel.SetZIndex(this, 0);
        }

        /// <summary>
        ///     Update Widget transformation on <see cref="WidgetBoard" />
        /// </summary>
        private void InitializeOnBoard()
        {
            Canvas.SetTop(this, Row * cellHeight);
            Canvas.SetLeft(this, Column * cellWidth);
            Height = RowSpan * cellHeight;
            Width = ColumnSpan * cellWidth;
            MinWidth = cellWidth * MinColumnSpan;
            MinHeight = cellHeight * MinRowSpan;

            RowSpan = Math.Max(RowSpan, MinRowSpan);
            ColumnSpan = Math.Max(ColumnSpan, MinColumnSpan);
        }

        /// <summary>
        ///     Handler called when the X-position animation end
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Standard event argument object (empty)</param>
        private void LeftAnimation_Completed(object sender, EventArgs e)
        {
            BeginAnimation(Canvas.LeftProperty, null);
            Panel.SetZIndex(this, 0);
        }

        /// <summary>
        ///     Handler called when Widget Resize start
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Provides data for mouse button events</param>
        private void ResizeMouseLeftButtonDownHandler(object sender, MouseButtonEventArgs e)
        {
            isResizing = true;
            lastPosition = e.GetPosition(Parent as Canvas);
            Mouse.Capture(ResizeGrip);
            Panel.SetZIndex(this, 1);
        }

        /// <summary>
        ///     Handler called when Widget Resize end
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Provides data for mouse button events</param>
        private void ResizeMouseLeftButtonUpHandler(object sender, MouseButtonEventArgs e)
        {
            isResizing = false;
            Mouse.Capture(null);

            var snappedWidth = (int) Math.Round(Width / cellWidth);
            var snappedHeight = (int) Math.Round(Height / cellHeight);

            var targetWidth = ColumnSpan;
            var targetHeight = RowSpan;

            if (WidgetTransformSolver.IsWidgetTransformPossible(this,
                    (Column, Row, Column + snappedWidth, Row + snappedHeight)))
            {
                targetWidth = snappedWidth;
                targetHeight = snappedHeight;
            }

            var widthAnimation = new DoubleAnimation
            {
                From = Width,
                To = targetWidth * cellWidth,
                Duration = TimeSpan.FromMilliseconds(600)
            };
            widthAnimation.Completed += WidthAnimation_Completed;
            widthAnimation.EasingFunction = new ElasticEase
            {
                EasingMode = EasingMode.EaseOut,
                Oscillations = 1,
                Springiness = 3
            };

            var heightAnimation = new DoubleAnimation
            {
                From = Height,
                To = targetHeight * cellHeight,
                Duration = TimeSpan.FromMilliseconds(600)
            };
            heightAnimation.Completed += HeightAnimation_Completed;
            heightAnimation.EasingFunction = new ElasticEase
            {
                EasingMode = EasingMode.EaseOut,
                Oscillations = 1,
                Springiness = 3
            };
            BeginAnimation(WidthProperty, widthAnimation);
            BeginAnimation(HeightProperty, heightAnimation);
            RowSpan = Math.Max(targetHeight, MinRowSpan);
            ColumnSpan = Math.Max(targetWidth, MinColumnSpan);

            InitializeOnBoard();
        }

        /// <summary>
        ///     Handler called during Widget Resize
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Provides data for mouse position events</param>
        private void ResizeMouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (!isResizing) return;
            if (!(Parent is Canvas canvas)) return;

            var newPosition = e.GetPosition(canvas);
            var offsetX = newPosition.X - lastPosition.X;
            var offsetY = newPosition.Y - lastPosition.Y;

            var newWidth = Width + offsetX;
            var newHeight = Height + offsetY;

            Width = Math.Max(newWidth, MinWidth);
            Height = Math.Max(newHeight, MinHeight);

            lastPosition = newPosition;
        }

        /// <summary>
        ///     Handler called when the Y-position animation end
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Standard event argument object (empty)</param>
        private void TopAnimation_Completed(object sender, EventArgs e)
        {
            BeginAnimation(Canvas.TopProperty, null);
            Panel.SetZIndex(this, 0);
        }

        /// <summary>
        ///     Handler called when the Width animation end
        /// </summary>
        /// <param name="sender">The object that triggered the event</param>
        /// <param name="e">Standard event argument object (empty)</param>
        private void WidthAnimation_Completed(object sender, EventArgs e)
        {
            BeginAnimation(WidthProperty, null);
            Panel.SetZIndex(this, 0);
        }
    }
}
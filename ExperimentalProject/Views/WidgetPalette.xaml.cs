using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace ExperimentalProject.Views
{
    /// <summary>
    ///     Логика взаимодействия для WidgetPalette.xaml
    /// </summary>
    public partial class WidgetPalette
    {
        /// <summary>
        ///     Represents a UI element that allows <see cref="ExperimentalProject.Widget">Widgets</see> of the specified type to
        ///     be created on a <see cref="WidgetBoard">WidgetBoard</see>.
        /// </summary>
        public WidgetPalette()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        [Obsolete("Obsolete")]
        private double MeasureTextWidth(string text, TextBlock textBlock)
        {
            var formattedText = new FormattedText(
                text,
                CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface(textBlock.FontFamily, textBlock.FontStyle, textBlock.FontWeight, textBlock.FontStretch),
                textBlock.FontSize,
                textBlock.Foreground);

            return formattedText.WidthIncludingTrailingWhitespace;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            StartMarquee();
        }

        private void StartMarquee()
        {
            var textWidth = MeasureTextWidth(MarqueeText.Text, MarqueeText);
            var canvasWidth = MarqueeCanvas.ActualWidth;

            if (textWidth > canvasWidth)
            {
                var animation = new DoubleAnimation
                {
                    From = canvasWidth,
                    To = -textWidth,
                    Duration = new Duration(TimeSpan.FromSeconds(10)),
                    RepeatBehavior = RepeatBehavior.Forever
                };

                MarqueeText.BeginAnimation(Canvas.LeftProperty, animation);
            }
            else
            {
                Canvas.SetLeft(MarqueeText, (canvasWidth - textWidth) / 2);
            }
        }
    }
}
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows;
using System;
using System.Windows.Media;

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
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            StartMarquee();
        }

        private void StartMarquee()
        {
            double textWidth = MeasureTextWidth(MarqueeText.Text, MarqueeText);
            double canvasWidth = MarqueeCanvas.ActualWidth;

            if (textWidth > canvasWidth)
            {
                DoubleAnimation animation = new DoubleAnimation
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

        [Obsolete("Obsolete")]
        private double MeasureTextWidth(string text, TextBlock textBlock)
        {
            var formattedText = new FormattedText(
                text,
                System.Globalization.CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface(textBlock.FontFamily, textBlock.FontStyle, textBlock.FontWeight, textBlock.FontStretch),
                textBlock.FontSize,
                textBlock.Foreground);

            return formattedText.WidthIncludingTrailingWhitespace;
        }
    }
}
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using ExperimentalProject;
using WidgetExportingExample.Utilities;

namespace WidgetExportingExample.ViewModel
{
    public class ButtonPanel : INotifyPropertyChanged, IUserWidgetViewModel
    {
        private static readonly SolidColorBrush[] FirstColorScheme = new SolidColorBrush[4]
        {
            Brushes.Gray, Brushes.Orange, Brushes.Coral, Brushes.OrangeRed
        };

        private static readonly SolidColorBrush[] SecondColorScheme = new SolidColorBrush[4]
        {
            Brushes.Cyan, Brushes.LightSkyBlue, Brushes.LightCyan, Brushes.LightSteelBlue
        };

        private static readonly SolidColorBrush[] ThirdColorScheme = new SolidColorBrush[4]
        {
            Brushes.White, Brushes.DarkGray, Brushes.Gray, Brushes.DimGray
        };

        private RelayCommand firstCommand;
        private RelayCommand fourthCommand;
        private RelayCommand secondCommand;
        private RelayCommand thirdCommand;

        private SolidColorBrush firstButtonColor = FirstColorScheme[0];
        private SolidColorBrush fourthButtonColor = FirstColorScheme[3];
        private SolidColorBrush secondButtonColor = FirstColorScheme[1];
        private SolidColorBrush thirdButtonColor = FirstColorScheme[2];
        private string colorSchemeName;
        private string settings;

        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand FirstCommand
        {
            get
            {
                return firstCommand ?? (firstCommand = new RelayCommand(obj => { MessageBox.Show("First Command "); }));
            }
        }

        public RelayCommand FourthCommand
        {
            get
            {
                return fourthCommand ??
                       (fourthCommand = new RelayCommand(obj => { MessageBox.Show("Fourth Command "); }));
            }
        }

        public RelayCommand SecondCommand
        {
            get
            {
                return secondCommand ??
                       (secondCommand = new RelayCommand(obj => { MessageBox.Show("Second Command "); }));
            }
        }

        public RelayCommand ThirdCommand
        {
            get
            {
                return thirdCommand ?? (thirdCommand = new RelayCommand(obj => { MessageBox.Show("Third Command "); }));
            }
        }

        public SolidColorBrush FirstButtonColor
        {
            get => firstButtonColor;
            set
            {
                firstButtonColor = value;
                OnPropertyChanged();
            }
        }

        public SolidColorBrush FourthButtonColor
        {
            get => fourthButtonColor;
            set
            {
                fourthButtonColor = value;
                OnPropertyChanged();
            }
        }

        public SolidColorBrush SecondButtonColor
        {
            get => secondButtonColor;
            set
            {
                secondButtonColor = value;
                OnPropertyChanged();
            }
        }

        public SolidColorBrush ThirdButtonColor
        {
            get => thirdButtonColor;
            set
            {
                thirdButtonColor = value;
                OnPropertyChanged();
            }
        }

        public string ColorSchemeName
        {
            get => colorSchemeName;
            set
            {
                colorSchemeName = value;
                switch (value)
                {
                    case ButtonPanelSettings.FirstColorScheme:
                        FirstButtonColor = FirstColorScheme[0];
                        SecondButtonColor = FirstColorScheme[1];
                        ThirdButtonColor = FirstColorScheme[2];
                        FourthButtonColor = FirstColorScheme[3];
                        break;
                    case ButtonPanelSettings.SecondColorScheme:
                        FirstButtonColor = SecondColorScheme[0];
                        SecondButtonColor = SecondColorScheme[1];
                        ThirdButtonColor = SecondColorScheme[2];
                        FourthButtonColor = SecondColorScheme[3];
                        break;
                    case ButtonPanelSettings.ThirdColorScheme:
                        FirstButtonColor = ThirdColorScheme[0];
                        SecondButtonColor = ThirdColorScheme[1];
                        ThirdButtonColor = ThirdColorScheme[2];
                        FourthButtonColor = ThirdColorScheme[3];
                        break;
                }

                OnPropertyChanged();
            }
        }

        public string Settings
        {
            get => settings;
            set
            {
                settings = value;
                OnPropertyChanged();
                ColorSchemeName = value;
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
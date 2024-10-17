using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ExperimentalProject.Utilities;

namespace WidgetExportingExample.ViewModel
{
    internal class ButtonPanelSettings : INotifyPropertyChanged
    {
        public const string FirstColorScheme = "First Color Scheme";
        public const string SecondColorScheme = "Second Color Scheme";
        public const string ThirdColorScheme = "Third Color Scheme";
        private string selectedParameter;

        public ObservableCollection<string> FirstParameter { get; set; } = new ObservableCollection<string>()
        {
            FirstColorScheme,
            SecondColorScheme,
            ThirdColorScheme
        };

        public string SelectedParameter
        {
            get => selectedParameter;
            set
            {
                selectedParameter = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

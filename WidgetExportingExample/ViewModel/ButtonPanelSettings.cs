using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WidgetExportingExample.ViewModel
{
    internal class ButtonPanelSettings : INotifyPropertyChanged
    {
        public const string FirstColorScheme = "First Color Scheme";
        public const string SecondColorScheme = "Second Color Scheme";
        public const string ThirdColorScheme = "Third Color Scheme";
        private string selectedParameter;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<string> FirstParameter { get; set; } = new ObservableCollection<string>
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

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
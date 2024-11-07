using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WidgetExportingExample.Utilities;

namespace WidgetExportingExample.ViewModel
{
    internal class SampleWidget : INotifyPropertyChanged
    {
        private RelayCommand firstCommand;
        private RelayCommand fourthCommand;
        private RelayCommand secondCommand;
        private RelayCommand thirdCommand;


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

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
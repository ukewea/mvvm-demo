using MvvmDemo.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmDemo.ViewModels
{
    public class TableViewViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<DeviceParameter> Parameters { get; set; }

        public TableViewViewModel(ObservableCollection<DeviceParameter> parameters)
        {
            Parameters = parameters;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

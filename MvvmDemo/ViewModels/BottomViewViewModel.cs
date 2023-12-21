using MvvmDemo.Models;
using System.ComponentModel;

namespace MvvmDemo.ViewModels
{
    public class BottomViewViewModel : INotifyPropertyChanged
    {
        private readonly DeviceParameter _baudRateParameter;

        public BottomViewViewModel(DeviceParameter baudRateParameter)
        {
            _baudRateParameter = baudRateParameter;
            _baudRateParameter.PropertyChanged += OnPropertyChanged;
        }

        public string BaudRateRange
        {
            get
            {
                if (_baudRateParameter == null)
                    return "-";

                var value = _baudRateParameter.Value;
                return $"{value / 1000}.{(value / 100) % 10}K";
            }
        }

        ~BottomViewViewModel()
        {
            _baudRateParameter.PropertyChanged -= OnPropertyChanged;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BaudRateRange)));
        }
    }
}

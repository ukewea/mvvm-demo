using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MvvmDemo.Models
{
    public class DeviceParameter : INotifyPropertyChanged
    {
        private readonly string _name;
        private int _value;

        public string Name
        {
            get => _name;
        }

        public int Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value;
                    OnPropertyChanged();
                }
            }
        }

        public DeviceParameter(string name, int initialValue)
        {
            _name = name;
            Value = initialValue;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

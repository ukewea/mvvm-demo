using MvvmDemo.Models;
using MvvmDemo.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace MvvmDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ViewModels
        private readonly TableViewViewModel _tableViewViewModel;
        private readonly BottomViewViewModel _bottomViewViewModel;

        // data source (Model)
        public ObservableCollection<DeviceParameter> Parameters { get; }

        public MainWindow()
        {
            InitializeComponent();

            Parameters = new()
            {
                new("Baud Rate", 9600)
            };

            _tableViewViewModel = new TableViewViewModel(Parameters);
            _bottomViewViewModel = new BottomViewViewModel(Parameters.First(p => p.Name == "Baud Rate"));


            DataContext = new { TableView = _tableViewViewModel, BottomView = _bottomViewViewModel };
        }
    }
}

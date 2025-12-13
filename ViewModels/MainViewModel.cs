using Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Final.ViewModels.Commands;
namespace Final.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private MeteoViewModel _meteoViewModel;
        private BaseViewModel _viewModelActuel;

        public MainViewModel() 
        { 
            _meteoViewModel = new MeteoViewModel();
            ViewModelActuel = _meteoViewModel;

            OpenConfigurationWindowCommand = new RelayCommand(OpenConfigurationWindow, null);

        }

        public BaseViewModel ViewModelActuel
        {
            get { return _viewModelActuel; }
            set
            {
                _viewModelActuel = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand OpenConfigurationWindowCommand { get; set; }
        public void OpenConfigurationWindow(object? parameter)
        {
            var configWindow = new ConfigurationView
            {
                Owner = Application.Current.MainWindow,
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };

            configWindow.Show();
        }
    }
}

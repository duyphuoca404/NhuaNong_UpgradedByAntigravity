using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NhuaNong.ServiceLibrary;
using System.Windows;

namespace NhuaNong.Wpf.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly IServices _services;

        [ObservableProperty]
        private ObservableObject _currentViewModel;

        [ObservableProperty]
        private string _title = "NhuaNong WPF Pilot";

        public IRelayCommand NavigateHomeCommand { get; }
        public IRelayCommand NavigateOperationCommand { get; }
        public IRelayCommand NavigateSettingsCommand { get; }

        public MainViewModel(IServices services)
        {
            _services = services;
            
            // Initialize commands
            NavigateHomeCommand = new RelayCommand(() => CurrentViewModel = new HomeViewModel(_services));
            NavigateOperationCommand = new RelayCommand(() => CurrentViewModel = new OperationViewModel());
            NavigateSettingsCommand = new RelayCommand(() => CurrentViewModel = new SettingsViewModel());

            // Set default view
            CurrentViewModel = new HomeViewModel(_services);
        }
    }
}

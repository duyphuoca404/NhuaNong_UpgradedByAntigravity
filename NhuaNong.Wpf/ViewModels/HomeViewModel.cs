using CommunityToolkit.Mvvm.ComponentModel;
using NhuaNong.ServiceLibrary;

namespace NhuaNong.Wpf.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Dashboard";

        [ObservableProperty]
        private double _totalProduction;

        [ObservableProperty]
        private int _totalTrips;

        [ObservableProperty]
        private int _totalVehicles;

        [ObservableProperty]
        private int _activeAlerts;

        private readonly IServices _services;

        public HomeViewModel()
        {
            // Design-time support or default constructor if needed
        }

        public HomeViewModel(IServices services)
        {
            _services = services;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var stats = _services.GetDashboardStats();
                TotalProduction = stats.TotalProduction;
                TotalTrips = stats.TotalTrips;
                TotalVehicles = stats.TotalVehicles;
                ActiveAlerts = stats.ActiveAlerts;
            }
            catch (System.Exception ex)
            {
                System.Windows.MessageBox.Show("Error loading dashboard data: " + ex.ToString());
            }
        }
    }
}

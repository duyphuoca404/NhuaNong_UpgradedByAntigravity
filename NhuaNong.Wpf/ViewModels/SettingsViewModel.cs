using CommunityToolkit.Mvvm.ComponentModel;

namespace NhuaNong.Wpf.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Settings";

        public SettingsViewModel()
        {
        }
    }
}

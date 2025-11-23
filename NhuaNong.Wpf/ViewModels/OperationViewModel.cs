using CommunityToolkit.Mvvm.ComponentModel;

namespace NhuaNong.Wpf.ViewModels
{
    public partial class OperationViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = "Vận Hành";

        public OperationViewModel()
        {
        }
    }
}

using Unity;
using NhuaNong.ServiceLibrary;
using NhuaNong.Wpf.ViewModels;

namespace NhuaNong.Wpf
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            // Register ViewModels in the Unity Container
            ServiceContainer.Container.RegisterType<MainViewModel>();
        }

        public MainViewModel Main => ServiceContainer.Resolve<MainViewModel>();
    }
}

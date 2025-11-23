using Unity;
using Unity.Lifetime;
using System;

namespace NhuaNong.ServiceLibrary
{
    public static class ServiceContainer
    {
        private static IUnityContainer _container;

        public static IUnityContainer Container
        {
            get
            {
                if (_container == null)
                {
                    _container = new UnityContainer();
                    RegisterServices(_container);
                }
                return _container;
            }
        }

        private static void RegisterServices(IUnityContainer container)
        {
            // Register services here
            container.RegisterType<IServices, LocalServicesFactory>(new ContainerControlledLifetimeManager());
            
            // You can register other services or repositories here as needed
            // container.RegisterType<IMyRepository, MyRepository>();
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}

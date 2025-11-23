// Decompiled with JetBrains decompiler
// Type: NhuaNong.Core.IoC
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using Unity;
using Unity.Lifetime;

#nullable disable
namespace NhuaNong.Core
{
  public sealed class IoC
  {
    private static IUnityContainer _container = (IUnityContainer) new UnityContainer();

    public static void Register<I, T>() where T : I
    {
      IoC.Current.Container.RegisterType<I, T>(new ContainerControlledLifetimeManager());
    }

    public static void InjectStub<I>(I instance)
    {
      IoC.Current.Container.RegisterInstance<I>(instance, new ContainerControlledLifetimeManager());
    }

    public static T Retrieve<T>() => IoC.Current.Container.Resolve<T>();

    public static IoC Current => IoC.Nested.Instance;

    public IUnityContainer Container
    {
      get
      {
        if (IoC._container == null)
          IoC._container = (IUnityContainer) new UnityContainer();
        return IoC._container;
      }
    }

    private class Nested
    {
      internal static readonly IoC Instance = new IoC();
    }
  }
}

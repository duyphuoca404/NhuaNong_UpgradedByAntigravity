// Decompiled with JetBrains decompiler
// Type: NhuaNong.Core.RepositoryService`1
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using Microsoft.Practices.Unity;
using System.Data.Entity;

#nullable disable
namespace NhuaNong.Core
{
  public class RepositoryService<TContext> : IDbContextManager where TContext : DbContext, IDBContext, new()
  {
    private TContext _dbContext;

    public void Initialize(TContext context)
    {
      this._dbContext = context;
      IoC.Current.Container.RegisterInstance<RepositoryService<TContext>>(this);
      IoC.Current.Container.RegisterType(typeof (IEFRepository<>), typeof (EFRepository<>));
    }

    public IDBContext GetDBContext() => (IDBContext) this._dbContext;

    public IUnityContainer Container { get; set; }
  }
}

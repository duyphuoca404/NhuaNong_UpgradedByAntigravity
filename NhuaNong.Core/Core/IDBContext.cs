// Decompiled with JetBrains decompiler
// Type: NhuaNong.Core.IDBContext
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

#nullable disable
namespace NhuaNong.Core
{
  public interface IDBContext : IDisposable
  {
    IDbSet<TEntity> Set<TEntity>() where TEntity : class;

    DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

    void SaveChanges();
  }
}

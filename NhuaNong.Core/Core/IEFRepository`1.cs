// Decompiled with JetBrains decompiler
// Type: NhuaNong.Core.IEFRepository`1
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

#nullable disable
namespace NhuaNong.Core
{
  public interface IEFRepository<T> where T : class
  {
    void Add(T entity);

    void Attach(T entity);

    void Delete(T entity);

    void Delete(Expression<Func<T, bool>> where);

    IEnumerable<T> GetAll();

    IEnumerable<T> Get(Expression<Func<T, bool>> where);

    IQueryable<T> DoQuery();

    IQueryable<T> DoQuery(ISpecification<T> where);

    IList<T> SelectAll();

    IList<T> SelectAll(ISpecification<T> where);

    IList<T> SelectAll(Expression<Func<T, bool>> where);

    T GetById(int id);

    void Update(T entity);

    void Save();
  }
}

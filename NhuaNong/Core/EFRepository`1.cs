// Decompiled with JetBrains decompiler
// Type: NhuaNong.Core.EFRepository`1
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

#nullable disable
namespace NhuaNong.Core
{
  public class EFRepository<T> : IEFRepository<T>, IDisposable where T : class
  {
    private IDBContext _dbContext;
    private string _keyProperty = "ID";

    private DbSet<T> _dbSet { get; set; }

    public EFRepository(IDbContextManager dbCtxMng) => this.SetContext(dbCtxMng.GetDBContext());

    private void SetContext(IDBContext ctx)
    {
      this._dbContext = ctx;
      this._dbSet = ctx.Set<T>() as DbSet<T>;
    }

    public void Add(T entity) => this._dbSet.Add(entity);

    public void Attach(T entity) => this._dbSet.Attach(entity);

    public void Delete(T entity)
    {
      if (this._dbContext.Entry<T>(entity).State == EntityState.Detached)
        this._dbSet.Attach(entity);
      this._dbSet.Remove(entity);
    }

    public void Delete(Expression<Func<T, bool>> where)
    {
      foreach (T entity in this._dbSet.Where<T>(where).AsEnumerable<T>())
        this._dbSet.Remove(entity);
    }

    public IEnumerable<T> GetAll() => (IEnumerable<T>) this._dbSet.ToList<T>();

    public IEnumerable<T> Get(Expression<Func<T, bool>> where)
    {
      return this._dbSet != null ? (IEnumerable<T>) this._dbSet.Where<T>(where).ToList<T>() : throw new Exception("_dbSet is null");
    }

    public T GetById(int id)
    {
      return this._dbSet.Find(new object[1]{ (object) id });
    }

    public void Update(T entity)
    {
      this._dbSet.Attach(entity);
      this._dbContext.Entry<T>(entity).State = EntityState.Modified;
    }

    public void Save() => this._dbContext.SaveChanges();

    protected string GetKeyColumnName(T entity, DbContext context)
    {
      return ((IObjectContextAdapter) context).ObjectContext.CreateObjectSet<T>().EntitySet.ElementType.KeyMembers.First<EdmMember>().Name;
    }

    public IQueryable<T> DoQuery() => this._dbContext.Set<T>().AsQueryable<T>();

    public IQueryable<T> DoQuery(ISpecification<T> where)
    {
      return this._dbContext.Set<T>().AsQueryable<T>().Where<T>(where.EvalPredicate);
    }

    public IList<T> SelectAll()
    {
      try
      {
        IList<T> list = (IList<T>) this._dbSet.ToList<T>();
        return (IList<T>) this._dbContext.Set<T>().ToList<T>();
      }
      catch (Exception ex)
      {
        throw;
      }
    }

    public IList<T> SelectAll(Expression<Func<T, bool>> where)
    {
      return (IList<T>) this.Get(where).ToList<T>();
    }

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
    {
      return this._dbContext.Set<T>().Where<T>(expression);
    }

    public void Dispose()
    {
      if (this._dbContext == null)
        return;
      this._dbContext.Dispose();
    }

    public IList<T> SelectAll(ISpecification<T> where)
    {
      return (IList<T>) this.DoQuery(where).ToList<T>();
    }

    public string KeyProperty
    {
      get => this._keyProperty;
      set => this._keyProperty = value;
    }
  }
}

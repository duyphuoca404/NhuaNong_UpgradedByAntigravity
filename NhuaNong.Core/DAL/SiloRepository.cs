// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.SiloRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

#nullable disable
namespace NhuaNong.DAL
{
  public class SiloRepository : EFRepository<Silo>, ISiloRepository, IEFRepository<Silo>
  {
    public SiloRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new Silo(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<Silo> ListSilo_ByActivated(bool activated)
    {
      return (IList<Silo>) this.DoQuery((ISpecification<Silo>) new Specification<Silo>((Expression<Func<Silo, bool>>) (sl => sl.Activated == (bool?) activated))).ToList<Silo>();
    }

    public IList<Silo> ListSilo_ByActivated_MaNhomSilo(bool? activated, string maNhomSL)
    {
      return this.SelectAll((ISpecification<Silo>) new Specification<Silo>((Expression<Func<Silo, bool>>) (sl => (sl.Activated == activated || activated == new bool?()) && sl.NhomSilo.MaNhomSilo == maNhomSL)));
    }
  }
}

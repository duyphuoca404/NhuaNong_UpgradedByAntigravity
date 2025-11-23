// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.MACSiloRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;

#nullable disable
namespace NhuaNong.DAL
{
  public class MACSiloRepository : EFRepository<MACSilo>, IMACSiloRepository, IEFRepository<MACSilo>
  {
    public MACSiloRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new MACSilo(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<MACSilo> ListMACSilo_ByMACID(int macID)
    {
      return this.SelectAll((ISpecification<MACSilo>) new Specification<MACSilo>((Expression<Func<MACSilo, bool>>) (ms => ms.MACID.Equals(macID))));
    }
  }
}

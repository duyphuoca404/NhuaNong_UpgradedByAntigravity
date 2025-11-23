// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.vw_TotalMaterialRepository
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
  internal class vw_TotalMaterialRepository : 
    EFRepository<vw_PvTotalMaterial>,
    Ivw_TotalMaterialRepository,
    IEFRepository<vw_PvTotalMaterial>
  {
    public vw_TotalMaterialRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new vw_PvTotalMaterial(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<vw_PvTotalMaterial> ListvwTotalMaterial_ByCondition(
      int? MaterialID,
      bool? isManual)
    {
      return this.SelectAll((ISpecification<vw_PvTotalMaterial>) new Specification<vw_PvTotalMaterial>((Expression<Func<vw_PvTotalMaterial, bool>>) (o => ((int?) o.MaterialID == MaterialID || MaterialID == new int?()) && (o.IsManual == isManual || isManual == new bool?()))));
    }
  }
}

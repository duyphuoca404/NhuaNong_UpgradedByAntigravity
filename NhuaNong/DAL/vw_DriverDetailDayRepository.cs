// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.vw_DriverDetailDayRepository
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
  internal class vw_DriverDetailDayRepository : 
    EFRepository<vw_PvDriverDetailDay_WithID>,
    Ivw_DriverDetailDayRepository,
    IEFRepository<vw_PvDriverDetailDay_WithID>
  {
    public vw_DriverDetailDayRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new vw_PvDriverDetailDay_WithID(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<vw_PvDriverDetailDay_WithID> ListDriverDetailDay_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      int? taiXeID,
      bool? isManual)
    {
      Specification<vw_PvDriverDetailDay_WithID> specification = new Specification<vw_PvDriverDetailDay_WithID>((Expression<Func<vw_PvDriverDetailDay_WithID, bool>>) (o => (o.ID == (long?) taiXeID || taiXeID == new int?()) && (o.IsManual == isManual || isManual == new bool?())));
      return (IList<vw_PvDriverDetailDay_WithID>) this.GetAll();
    }

    public IList<vw_PvDriverDetailDay_WithID> ListDriverDetailDay_ByCondition_Update(
      DateTime? fromDate,
      DateTime? toDate,
      int? taiXeID,
      bool? isManual)
    {
      return this.SelectAll((ISpecification<vw_PvDriverDetailDay_WithID>) new Specification<vw_PvDriverDetailDay_WithID>((Expression<Func<vw_PvDriverDetailDay_WithID, bool>>) (o => o.ID == (long?) taiXeID || taiXeID == new int?())));
    }
  }
}

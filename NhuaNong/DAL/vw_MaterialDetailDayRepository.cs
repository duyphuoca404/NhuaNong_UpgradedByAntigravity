// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.vw_MaterialDetailDayRepository
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
  internal class vw_MaterialDetailDayRepository : 
    EFRepository<vw_PvMaterialDetailDay_WithID>,
    Ivw_MaterialDetailDayRepository,
    IEFRepository<vw_PvMaterialDetailDay_WithID>
  {
    public vw_MaterialDetailDayRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new vw_PvMaterialDetailDay_WithID(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<vw_PvMaterialDetailDay_WithID> ListvwMaterialDetailDay_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      int? MaterialID,
      bool? isManual)
    {
      Specification<vw_PvMaterialDetailDay_WithID> specification = new Specification<vw_PvMaterialDetailDay_WithID>((Expression<Func<vw_PvMaterialDetailDay_WithID, bool>>) (o => ((int?) o.MaterialID == MaterialID || MaterialID == new int?()) && (o.NgayMeTron >= fromDate || fromDate == (DateTime?) DateTime.MinValue) && (o.NgayMeTron <= toDate || toDate == (DateTime?) DateTime.MinValue) && (o.IsManual == isManual || isManual == new bool?())));
      return (IList<vw_PvMaterialDetailDay_WithID>) this.GetAll();
    }

    IList<vw_PvMaterialDetailDay_WithID> Ivw_MaterialDetailDayRepository.ListvwMaterialDetailDay_ByCondition_Update(
      DateTime? fromDate,
      DateTime? toDate,
      int? MaterialID,
      bool? isManual)
    {
      return this.SelectAll((ISpecification<vw_PvMaterialDetailDay_WithID>) new Specification<vw_PvMaterialDetailDay_WithID>((Expression<Func<vw_PvMaterialDetailDay_WithID, bool>>) (o => o.ID == (long?) MaterialID || MaterialID == new int?())));
    }
  }
}

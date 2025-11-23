// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.vw_TranferDetailDayRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

#nullable disable
namespace NhuaNong.DAL
{
  public class vw_TranferDetailDayRepository : 
    EFRepository<vw_PvTranferDetailDay_WithID>,
    Ivw_TranferDetailDayRepository,
    IEFRepository<vw_PvTranferDetailDay_WithID>
  {
    public vw_TranferDetailDayRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = "NgayMeTron_BienSo";
    }

    public IList<vw_PvTranferDetailDay_WithID> ListTranferDetailDay_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      int? xeID,
      bool? isQueued)
    {
      return (IList<vw_PvTranferDetailDay_WithID>) this.GetAll().ToList<vw_PvTranferDetailDay_WithID>();
    }

    public IList<vw_PvTranferDetailDay_WithID> ListTranferDetailDay_ByCondition_Update(
      DateTime? fromDate,
      DateTime? toDate,
      int? xeID,
      bool? isQueued)
    {
      return this.SelectAll((ISpecification<vw_PvTranferDetailDay_WithID>) new Specification<vw_PvTranferDetailDay_WithID>((Expression<Func<vw_PvTranferDetailDay_WithID, bool>>) (o => o.ID == (long?) xeID || xeID == new int?())));
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.vw_TotalTranferRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

#nullable disable
namespace NhuaNong.DAL
{
  internal class vw_TotalTranferRepository : 
    EFRepository<vw_PvTranferDetailDay_WithID>,
    Ivw_TotalTranferRepository,
    IEFRepository<vw_PvTranferDetailDay_WithID>
  {
    public vw_TotalTranferRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = "XeID";
    }

    public IList<vw_PvTranferDetailDay_WithID> ListvwTotalTranfer_ByCondition(
      int? xeID,
      bool? isManual)
    {
      return this.SelectAll((ISpecification<vw_PvTranferDetailDay_WithID>) new Specification<vw_PvTranferDetailDay_WithID>((Expression<Func<vw_PvTranferDetailDay_WithID, bool>>) (o => (int?) o.XeID == xeID || xeID == new int?())));
    }
  }
}

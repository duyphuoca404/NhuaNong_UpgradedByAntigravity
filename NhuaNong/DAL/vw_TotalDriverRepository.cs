// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.vw_TotalDriverRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.DAL
{
  internal class vw_TotalDriverRepository : 
    EFRepository<vw_PvDriverDetailDay_WithID>,
    Ivw_TotalDriverRepository,
    IEFRepository<vw_PvDriverDetailDay_WithID>
  {
    public vw_TotalDriverRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = "TaiXeID";
    }

    public IList<vw_PvDriverDetailDay_WithID> ListvwTotalDriver_ByCondition(
      int? taixeID,
      bool? isManual)
    {
      return (IList<vw_PvDriverDetailDay_WithID>) this.GetAll();
    }
  }
}

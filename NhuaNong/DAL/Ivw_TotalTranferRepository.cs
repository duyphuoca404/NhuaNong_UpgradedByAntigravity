// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.Ivw_TotalTranferRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.DAL
{
  internal interface Ivw_TotalTranferRepository : IEFRepository<vw_PvTranferDetailDay_WithID>
  {
    IList<vw_PvTranferDetailDay_WithID> ListvwTotalTranfer_ByCondition(int? xeID, bool? isManual);
  }
}

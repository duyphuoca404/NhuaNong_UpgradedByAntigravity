// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.IPhieuTronRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.DAL
{
  public interface IPhieuTronRepository : IEFRepository<PhieuTron>
  {
    PhieuTron GetByCode(string code);

    PhieuTron GetLastest();

    IList<PhieuTron> ListPhieuTron_ForTronOnline();

    IList<PhieuTron> ListPhieuTron_ByStatus(int status);

    IList<PhieuTron> ListPhieuTron_ByIsQueued(bool isQueued);

    IList<PhieuTron> ListPhieuTron_ByCondition(
      string maPhieuTron,
      DateTime fromDate,
      DateTime toDate,
      int? status,
      bool? isQueued);

    IList<string> ListMaPhieuTron_AutoComplete(string strInput, int? length);

    IList<PhieuTron> ListPhieuTron_AutoComplete(string strInput, int? length);
  }
}

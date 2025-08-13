// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.IViewDataMixRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.Data;
using NhuaNong.EntityModel;
using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.DAL
{
  public interface IViewDataMixRepository : IEFRepository<vw_DataMix>
  {
    IList<vw_DataMix> ListDataMix_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maPhieuTron,
      string khachHang,
      string congTruong,
      string hangMuc,
      string taiXe,
      string bienSo,
      string mac,
      string nhanVien);

    IList<vw_DataMix> ListDataMix_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maPhieuTron,
      int? khachHang,
      int? congTruong,
      int? hangMuc,
      int? mac,
      int? bienSo,
      int? taiXe,
      int? nhanVien,
      bool? active);

    ObjAggregationResult GetSumForIsQueuedAndTimeRange(
      DateTime? fromDate,
      DateTime? toDate,
      bool? activated);
  }
}

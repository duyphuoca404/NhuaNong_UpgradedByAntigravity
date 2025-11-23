// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.vw_SumWeight
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class vw_SumWeight
  {
    public int PhieuTronID { get; set; }

    public string MaPhieuTron { get; set; }

    public DateTime? NgayPhieuTron { get; set; }

    public DateTime? Ngay { get; set; }

    public TimeSpan? Gio { get; set; }

    public Decimal? KLDuTinh { get; set; }

    public Decimal? KLThuc { get; set; }

    public Decimal? SLMeDuTinh { get; set; }

    public Decimal? KLDuTinhCuaTungMe { get; set; }

    public int KH_int { get; set; }

    public int? CT_int { get; set; }

    public int? HM_int { get; set; }

    public int? MAC_int { get; set; }

    public int? Xe_int { get; set; }

    public int? TX_int { get; set; }

    public Decimal? SUM_Total_Value { get; set; }

    public Decimal? SUM_Total_ValueBat { get; set; }

    public Decimal? SUM_Total_ValueBatMan { get; set; }

    public bool? IsQueued { get; set; }

    public int? CreatedBy { get; set; }

    public string FullName { get; set; }

    public string KH { get; set; }

    public string CT { get; set; }

    public string BS { get; set; }

    public string MAC { get; set; }

    public string TX { get; set; }

    public string HM { get; set; }

    public Decimal? TongKhoiLuong { get; set; }

    public int? TongMeTron { get; set; }
  }
}

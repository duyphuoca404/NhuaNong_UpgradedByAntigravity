// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.MeTronChiTiet
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class MeTronChiTiet
  {
    public int MeTronChiTietID { get; set; }

    public int MeTronID { get; set; }

    public int? MACSiloID { get; set; }

    public Decimal? Value { get; set; }

    public Decimal? ValueBat { get; set; }

    public Decimal? SiloValue { get; set; }

    public Decimal? SaiSoDuoi { get; set; }

    public Decimal? SaiSoTren { get; set; }

    public Decimal? KLCanNhoNhat { get; set; }

    public Decimal? KLCanLonNhat { get; set; }

    public Decimal? TGNhapNhaOn { get; set; }

    public Decimal? TGNhapNhaOff { get; set; }

    public Decimal? TGKiemTraVatLieuRoi { get; set; }

    public Decimal? KLRoi { get; set; }

    public Decimal? KLDT_Tu1 { get; set; }

    public Decimal? KLDT_Tu2 { get; set; }

    public Decimal? KLDT_Tu3 { get; set; }

    public Decimal? KLDT_Den1 { get; set; }

    public Decimal? KLDT_Den2 { get; set; }

    public Decimal? KLDT_Den3 { get; set; }

    public int? TinhDoHutNuocID { get; set; }

    public Decimal? DoAm_NhomSlioAgg { get; set; }

    public Decimal? DoHutNuoc_NhomSiloAgg { get; set; }

    public int? SoiTrongCat_SiloId_NhomSiloAgg { get; set; }

    public Decimal? SoiTrongCat_Percent_NhomSiloAgg { get; set; }

    public int? MaterialID { get; set; }

    public string MaterialCode { get; set; }

    public string MaterialName { get; set; }

    public string MaSilo { get; set; }

    public int? STTSiloPLC { get; set; }

    public bool? IsManual { get; set; }

    public DateTime? NgayMTCT { get; set; }

    public int? PLCSaveId { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public byte[] VersionNo { get; set; }

    public Decimal? ValueBatAuto { get; set; }

    public Decimal? ValueBatMan { get; set; }

    public Decimal? ValueTol { get; set; }

    public Decimal? ValuePerTol { get; set; }

    public virtual MACSilo MACSilo { get; set; }

    public virtual MeTron MeTron { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.Silo
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class Silo
  {
    public Silo()
    {
      this.MACSiloes = (ICollection<MACSilo>) new HashSet<MACSilo>();
      this.Silo1 = (ICollection<Silo>) new HashSet<Silo>();
    }

    public int SiloID { get; set; }

    public string MaSilo { get; set; }

    public string TenSilo { get; set; }

    public int NhomSiloID { get; set; }

    public int? SoTT { get; set; }

    public Decimal? SaiSoDuoi { get; set; }

    public Decimal? SaiSoTren { get; set; }

    public Decimal? KLCanNhoNhat { get; set; }

    public Decimal? KLCanLonNhat { get; set; }

    public Decimal? TGNhapNhaOn { get; set; }

    public Decimal? TGNhapNhaOff { get; set; }

    public Decimal? TGKiemTraVatLieuRoi { get; set; }

    public Decimal? KLRoi { get; set; }

    public Decimal? K_Pulse { get; set; }

    public Decimal? KLDT_Tu1 { get; set; }

    public Decimal? KLDT_Tu2 { get; set; }

    public Decimal? KLDT_Tu3 { get; set; }

    public Decimal? KLDT_Den1 { get; set; }

    public Decimal? KLDT_Den2 { get; set; }

    public Decimal? KLDT_Den3 { get; set; }

    public Decimal? KLDT_DungTruoc1 { get; set; }

    public Decimal? KLDT_DungTruoc2 { get; set; }

    public Decimal? KLDT_DungTruoc3 { get; set; }

    public int? TinhDoHutNuocID { get; set; }

    public string TinhDoHutNuocName { get; set; }

    public Decimal? DoAm_NhomSlioAgg { get; set; }

    public Decimal? DoHutNuoc_NhomSiloAgg { get; set; }

    public Decimal? SoiTrongCat_NhomSiloAgg { get; set; }

    public int? SoiTrongCat_TruVaoSilo_NhomSiloAgg { get; set; }

    public int? MaterialID { get; set; }

    public string MaterialCode { get; set; }

    public string MaterialName { get; set; }

    public bool? Activated { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public byte[] VersionNo { get; set; }

    public bool? BuTruKLMT { get; set; }

    public bool? TuDongXNCD { get; set; }

    public virtual ICollection<MACSilo> MACSiloes { get; set; }

    public virtual Material Material { get; set; }

    public virtual NhomSilo NhomSilo { get; set; }

    public virtual ICollection<Silo> Silo1 { get; set; }

    public virtual Silo Silo2 { get; set; }

    public virtual TinhDoHutNuoc TinhDoHutNuoc { get; set; }
  }
}

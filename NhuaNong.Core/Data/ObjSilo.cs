// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjSilo
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjSilo : ObjectBase
  {
    [DataMember]
    public int SiloID { get; set; }

    [DataMember]
    public string MaSilo { get; set; }

    [DataMember]
    public string TenSilo { get; set; }

    [DataMember]
    public int NhomSiloID { get; set; }

    [DataMember]
    public int? SoTT { get; set; }

    [DataMember]
    public Decimal? SaiSoDuoi { get; set; }

    [DataMember]
    public Decimal? SaiSoTren { get; set; }

    [DataMember]
    public Decimal? KLCanNhoNhat { get; set; }

    [DataMember]
    public Decimal? KLCanLonNhat { get; set; }

    [DataMember]
    public Decimal? TGNhapNhaOn { get; set; }

    [DataMember]
    public Decimal? TGNhapNhaOff { get; set; }

    [DataMember]
    public Decimal? TGKiemTraVatLieuRoi { get; set; }

    [DataMember]
    public Decimal? KLRoi { get; set; }

    [DataMember]
    public Decimal? K_Pulse { get; set; }

    [DataMember]
    public Decimal? KLDT_Tu1 { get; set; }

    [DataMember]
    public Decimal? KLDT_Tu2 { get; set; }

    [DataMember]
    public Decimal? KLDT_Tu3 { get; set; }

    [DataMember]
    public Decimal? KLDT_Den1 { get; set; }

    [DataMember]
    public Decimal? KLDT_Den2 { get; set; }

    [DataMember]
    public Decimal? KLDT_Den3 { get; set; }

    [DataMember]
    public Decimal? KLDT_DungTruoc1 { get; set; }

    [DataMember]
    public Decimal? KLDT_DungTruoc2 { get; set; }

    [DataMember]
    public Decimal? KLDT_DungTruoc3 { get; set; }

    [DataMember]
    public int? TinhDoHutNuocID { get; set; }

    [DataMember]
    public string TinhDoHutNuocName { get; set; }

    [DataMember]
    public Decimal? DoAm_NhomSlioAgg { get; set; }

    [DataMember]
    public Decimal? DoHutNuoc_NhomSiloAgg { get; set; }

    [DataMember]
    public Decimal? SoiTrongCat_NhomSiloAgg { get; set; }

    [DataMember]
    public int? SoiTrongCat_TruVaoSilo_NhomSiloAgg { get; set; }

    [DataMember]
    public int? MaterialID { get; set; }

    [DataMember]
    public string MaterialCode { get; set; }

    [DataMember]
    public string MaterialName { get; set; }

    [DataMember]
    public bool? Activated { get; set; }

    [DataMember]
    public DateTime? CreationDate { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public DateTime? LatestUpdateDate { get; set; }

    [DataMember]
    public int? LatestUpdatedBy { get; set; }

    [DataMember]
    public byte[] VersionNo { get; set; }

    [DataMember]
    public bool? BuTruKLMT { get; set; }

    [DataMember]
    public bool? TuDongXNCD { get; set; }
  }
}

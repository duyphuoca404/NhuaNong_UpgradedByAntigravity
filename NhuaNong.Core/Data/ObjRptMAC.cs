// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjRptMAC
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjRptMAC : ObjectBase
  {
    [DataMember]
    public int MeTronID { get; set; }

    [DataMember]
    public DateTime? NgayMeTron { get; set; }

    [DataMember]
    public DateTime? Ngay { get; set; }

    [DataMember]
    public DateTime? Gio { get; set; }

    [DataMember]
    public int? Phieu { get; set; }

    [DataMember]
    public int? PhieuTronID { get; set; }

    [DataMember]
    public string MaPhieuTron { get; set; }

    [DataMember]
    public int? HD { get; set; }

    [DataMember]
    public string NoteHD { get; set; }

    [DataMember]
    public string MaHopDong { get; set; }

    [DataMember]
    public string KH { get; set; }

    [DataMember]
    public string NoteKH { get; set; }

    [DataMember]
    public string CT { get; set; }

    [DataMember]
    public string NoteCT { get; set; }

    [DataMember]
    public int? TaiXeID { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string TX { get; set; }

    [DataMember]
    public int? TX_int { get; set; }

    [DataMember]
    public string Plate { get; set; }

    [DataMember]
    public string MAC { get; set; }

    [DataMember]
    public string NoteMAC { get; set; }

    [DataMember]
    public string DoSut { get; set; }

    [DataMember]
    public Decimal? KLVC { get; set; }

    [DataMember]
    public Decimal? KLMe { get; set; }

    [DataMember]
    public Decimal? Agg1 { get; set; }

    [DataMember]
    public Decimal? Agg2 { get; set; }

    [DataMember]
    public Decimal? Agg3 { get; set; }

    [DataMember]
    public Decimal? Agg4 { get; set; }

    [DataMember]
    public Decimal? Agg5 { get; set; }

    [DataMember]
    public Decimal? Agg6 { get; set; }

    [DataMember]
    public Decimal? Ce1 { get; set; }

    [DataMember]
    public Decimal? Ce2 { get; set; }

    [DataMember]
    public Decimal? Ce3 { get; set; }

    [DataMember]
    public Decimal? Ce4 { get; set; }

    [DataMember]
    public Decimal? Wa { get; set; }

    [DataMember]
    public Decimal? Add1 { get; set; }

    [DataMember]
    public Decimal? Add2 { get; set; }

    [DataMember]
    public Decimal? Add3 { get; set; }

    [DataMember]
    public Decimal? Add4 { get; set; }

    [DataMember]
    public Decimal? Add5 { get; set; }

    [DataMember]
    public Decimal? Add6 { get; set; }

    [DataMember]
    public Decimal? Agg1_Bat { get; set; }

    [DataMember]
    public Decimal? Agg2_Bat { get; set; }

    [DataMember]
    public Decimal? Agg3_Bat { get; set; }

    [DataMember]
    public Decimal? Agg4_Bat { get; set; }

    [DataMember]
    public Decimal? Agg5_Bat { get; set; }

    [DataMember]
    public Decimal? Agg6_Bat { get; set; }

    [DataMember]
    public Decimal? Ce1_Bat { get; set; }

    [DataMember]
    public Decimal? Ce2_Bat { get; set; }

    [DataMember]
    public Decimal? Ce3_Bat { get; set; }

    [DataMember]
    public Decimal? Ce4_Bat { get; set; }

    [DataMember]
    public Decimal? Wa_Bat { get; set; }

    [DataMember]
    public Decimal? Add1_Bat { get; set; }

    [DataMember]
    public Decimal? Add2_Bat { get; set; }

    [DataMember]
    public Decimal? Add3_Bat { get; set; }

    [DataMember]
    public Decimal? Add4_Bat { get; set; }

    [DataMember]
    public Decimal? Add5_Bat { get; set; }

    [DataMember]
    public Decimal? Add6_Bat { get; set; }

    [DataMember]
    public Decimal? TKLVC { get; set; }

    [DataMember]
    public Decimal? TKLVCTheoMAC { get; set; }

    [DataMember]
    public Decimal? TKLVCTheoNgay { get; set; }
  }
}

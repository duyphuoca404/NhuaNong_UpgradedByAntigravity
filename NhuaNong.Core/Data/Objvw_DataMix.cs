// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.Objvw_DataMix
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class Objvw_DataMix : ObjectBase
  {
    [DataMember]
    public int MeTronID { get; set; }

    [DataMember]
    public int? LnNo { get; set; }

    [DataMember]
    public DateTime? NgayMeTron { get; set; }

    [DataMember]
    public DateTime? Ngay { get; set; }

    [DataMember]
    public TimeSpan? Gio { get; set; }

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
    public int? KH_int { get; set; }

    [DataMember]
    public string NoteKH { get; set; }

    [DataMember]
    public string CT { get; set; }

    [DataMember]
    public int? CT_int { get; set; }

    [DataMember]
    public string NoteCT { get; set; }

    [DataMember]
    public string HM { get; set; }

    [DataMember]
    public int? HM_int { get; set; }

    [DataMember]
    public Decimal? KLDuTinh { get; set; }

    [DataMember]
    public bool IsQueued { get; set; }

    [DataMember]
    public string TenNV { get; set; }

    [DataMember]
    public int? NV_int { get; set; }

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
    public int? Xe_int { get; set; }

    [DataMember]
    public string MAC { get; set; }

    [DataMember]
    public int? MAC_int { get; set; }

    [DataMember]
    public string NoteMAC { get; set; }

    [DataMember]
    public string DoSut { get; set; }

    [DataMember]
    public Decimal? KLVC { get; set; }

    [DataMember]
    public Decimal? KLMe { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public string FullName { get; set; }

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
    public Decimal? Ce5 { get; set; }

    [DataMember]
    public Decimal? Ce6 { get; set; }

    [DataMember]
    public Decimal? Wa1 { get; set; }

    [DataMember]
    public Decimal? Wa2 { get; set; }

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
    public Decimal? Add7 { get; set; }

    [DataMember]
    public Decimal? Add8 { get; set; }

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
    public Decimal? Ce5_Bat { get; set; }

    [DataMember]
    public Decimal? Ce6_Bat { get; set; }

    [DataMember]
    public Decimal? Wa1_Bat { get; set; }

    [DataMember]
    public Decimal? Wa2_Bat { get; set; }

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
    public Decimal? Add7_Bat { get; set; }

    [DataMember]
    public Decimal? Add8_Bat { get; set; }

    [DataMember]
    public Decimal? Agg1_Mac { get; set; }

    [DataMember]
    public Decimal? Agg2_Mac { get; set; }

    [DataMember]
    public Decimal? Agg3_Mac { get; set; }

    [DataMember]
    public Decimal? Agg4_Mac { get; set; }

    [DataMember]
    public Decimal? Agg5_Mac { get; set; }

    [DataMember]
    public Decimal? Agg6_Mac { get; set; }

    [DataMember]
    public Decimal? Ce1_Mac { get; set; }

    [DataMember]
    public Decimal? Ce2_Mac { get; set; }

    [DataMember]
    public Decimal? Ce3_Mac { get; set; }

    [DataMember]
    public Decimal? Ce4_Mac { get; set; }

    [DataMember]
    public Decimal? Ce5_Mac { get; set; }

    [DataMember]
    public Decimal? Ce6_Mac { get; set; }

    [DataMember]
    public Decimal? Wa1_Mac { get; set; }

    [DataMember]
    public Decimal? Wa2_Mac { get; set; }

    [DataMember]
    public Decimal? Add1_Mac { get; set; }

    [DataMember]
    public Decimal? Add2_Mac { get; set; }

    [DataMember]
    public Decimal? Add3_Mac { get; set; }

    [DataMember]
    public Decimal? Add4_Mac { get; set; }

    [DataMember]
    public Decimal? Add5_Mac { get; set; }

    [DataMember]
    public Decimal? Add6_Mac { get; set; }

    [DataMember]
    public Decimal? Add7_Mac { get; set; }

    [DataMember]
    public Decimal? Add8_Mac { get; set; }

    [DataMember]
    public Decimal? Agg1_Man { get; set; }

    [DataMember]
    public Decimal? Agg2_Man { get; set; }

    [DataMember]
    public Decimal? Agg3_Man { get; set; }

    [DataMember]
    public Decimal? Agg4_Man { get; set; }

    [DataMember]
    public Decimal? Agg5_Man { get; set; }

    [DataMember]
    public Decimal? Agg6_Man { get; set; }

    [DataMember]
    public Decimal? Ce1_Man { get; set; }

    [DataMember]
    public Decimal? Ce2_Man { get; set; }

    [DataMember]
    public Decimal? Ce3_Man { get; set; }

    [DataMember]
    public Decimal? Ce4_Man { get; set; }

    [DataMember]
    public Decimal? Ce5_Man { get; set; }

    [DataMember]
    public Decimal? Ce6_Man { get; set; }

    [DataMember]
    public Decimal? Wa1_Man { get; set; }

    [DataMember]
    public Decimal? Wa2_Man { get; set; }

    [DataMember]
    public Decimal? Add1_Man { get; set; }

    [DataMember]
    public Decimal? Add2_Man { get; set; }

    [DataMember]
    public Decimal? Add3_Man { get; set; }

    [DataMember]
    public Decimal? Add4_Man { get; set; }

    [DataMember]
    public Decimal? Add5_Man { get; set; }

    [DataMember]
    public Decimal? Add6_Man { get; set; }

    [DataMember]
    public Decimal? Add7_Man { get; set; }

    [DataMember]
    public Decimal? Add8_Man { get; set; }

    [DataMember]
    public Decimal? Agg1_Tol { get; set; }

    [DataMember]
    public Decimal? Agg2_Tol { get; set; }

    [DataMember]
    public Decimal? Agg3_Tol { get; set; }

    [DataMember]
    public Decimal? Agg4_Tol { get; set; }

    [DataMember]
    public Decimal? Agg5_Tol { get; set; }

    [DataMember]
    public Decimal? Agg6_Tol { get; set; }

    [DataMember]
    public Decimal? Ce1_Tol { get; set; }

    [DataMember]
    public Decimal? Ce2_Tol { get; set; }

    [DataMember]
    public Decimal? Ce3_Tol { get; set; }

    [DataMember]
    public Decimal? Ce4_Tol { get; set; }

    [DataMember]
    public Decimal? Ce5_Tol { get; set; }

    [DataMember]
    public Decimal? Ce6_Tol { get; set; }

    [DataMember]
    public Decimal? Wa1_Tol { get; set; }

    [DataMember]
    public Decimal? Wa2_Tol { get; set; }

    [DataMember]
    public Decimal? Add1_Tol { get; set; }

    [DataMember]
    public Decimal? Add2_Tol { get; set; }

    [DataMember]
    public Decimal? Add3_Tol { get; set; }

    [DataMember]
    public Decimal? Add4_Tol { get; set; }

    [DataMember]
    public Decimal? Add5_Tol { get; set; }

    [DataMember]
    public Decimal? Add6_Tol { get; set; }

    [DataMember]
    public Decimal? Add7_Tol { get; set; }

    [DataMember]
    public Decimal? Add8_Tol { get; set; }

    [DataMember]
    public Decimal? Agg1_PerTol { get; set; }

    [DataMember]
    public Decimal? Agg2_PerTol { get; set; }

    [DataMember]
    public Decimal? Agg3_PerTol { get; set; }

    [DataMember]
    public Decimal? Agg4_PerTol { get; set; }

    [DataMember]
    public Decimal? Agg5_PerTol { get; set; }

    [DataMember]
    public Decimal? Agg6_PerTol { get; set; }

    [DataMember]
    public Decimal? Ce1_PerTol { get; set; }

    [DataMember]
    public Decimal? Ce2_PerTol { get; set; }

    [DataMember]
    public Decimal? Ce3_PerTol { get; set; }

    [DataMember]
    public Decimal? Ce4_PerTol { get; set; }

    [DataMember]
    public Decimal? Ce5_PerTol { get; set; }

    [DataMember]
    public Decimal? Ce6_PerTol { get; set; }

    [DataMember]
    public Decimal? Wa1_PerTol { get; set; }

    [DataMember]
    public Decimal? Wa2_PerTol { get; set; }

    [DataMember]
    public Decimal? Add1_PerTol { get; set; }

    [DataMember]
    public Decimal? Add2_PerTol { get; set; }

    [DataMember]
    public Decimal? Add3_PerTol { get; set; }

    [DataMember]
    public Decimal? Add4_PerTol { get; set; }

    [DataMember]
    public Decimal? Add5_PerTol { get; set; }

    [DataMember]
    public Decimal? Add6_PerTol { get; set; }

    [DataMember]
    public Decimal? Add7_PerTol { get; set; }

    [DataMember]
    public Decimal? Add8_PerTol { get; set; }
  }
}

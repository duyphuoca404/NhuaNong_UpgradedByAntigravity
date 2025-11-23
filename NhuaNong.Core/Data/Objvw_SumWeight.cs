// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.Objvw_SumWeight
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class Objvw_SumWeight : ObjectBase
  {
    [DataMember]
    public int PhieuTronID { get; set; }

    [DataMember]
    public string MaPhieuTron { get; set; }

    [DataMember]
    public DateTime? NgayPhieuTron { get; set; }

    [DataMember]
    public DateTime? Ngay { get; set; }

    [DataMember]
    public TimeSpan? Gio { get; set; }

    [DataMember]
    public Decimal? KLDuTinh { get; set; }

    [DataMember]
    public Decimal? KLThuc { get; set; }

    [DataMember]
    public Decimal? SLMeDuTinh { get; set; }

    [DataMember]
    public Decimal? KLDuTinhCuaTungMe { get; set; }

    [DataMember]
    public int? KhachHangID { get; set; }

    [DataMember]
    public string TenKhachHang { get; set; }

    [DataMember]
    public int? CongTruongID { get; set; }

    [DataMember]
    public string TenCongTruong { get; set; }

    [DataMember]
    public int? HangMucID { get; set; }

    [DataMember]
    public string TenHangMuc { get; set; }

    [DataMember]
    public int? MACID { get; set; }

    [DataMember]
    public string TenMAC { get; set; }

    [DataMember]
    public int? XeID { get; set; }

    [DataMember]
    public string BienSo { get; set; }

    [DataMember]
    public int? TaiXeID { get; set; }

    [DataMember]
    public string TenTaiXe { get; set; }

    [DataMember]
    public Decimal? SUM_Total_Value { get; set; }

    [DataMember]
    public Decimal? SUM_Total_ValueBat { get; set; }

    [DataMember]
    public Decimal? SUM_Total_ValueBatMan { get; set; }

    [DataMember]
    public bool IsQueued { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public string FullName { get; set; }

    [DataMember]
    public Decimal? TongKhoiLuong { get; set; }

    [DataMember]
    public int? TongMeTron { get; set; }
  }
}

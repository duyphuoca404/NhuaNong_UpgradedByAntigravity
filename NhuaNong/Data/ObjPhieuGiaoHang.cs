// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjPhieuGiaoHang
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjPhieuGiaoHang : ObjectBase
  {
    [DataMember]
    public int PhieuTronID { get; set; }

    [DataMember]
    public string MaPhieuTron { get; set; }

    [DataMember]
    public int? NoPhieu { get; set; }

    [DataMember]
    public DateTime? NgayPhieuTron { get; set; }

    [DataMember]
    public Decimal? KLDuTinh { get; set; }

    [DataMember]
    public Decimal? KLThuc { get; set; }

    [DataMember]
    public Decimal? KLTronNhoNhat { get; set; }

    [DataMember]
    public Decimal? KLTronLonNhat { get; set; }

    [DataMember]
    public Decimal? KLDuTinhCuaTungMe { get; set; }

    [DataMember]
    public Decimal? KLBuTruMeCuoi { get; set; }

    [DataMember]
    public Decimal? SLMeDuTinh { get; set; }

    [DataMember]
    public Decimal? SLMeHieuChinh { get; set; }

    [DataMember]
    public Decimal? SLMeDaTron { get; set; }

    [DataMember]
    public int? HopDongID { get; set; }

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
    public string DiaDiem { get; set; }

    [DataMember]
    public int? MACID { get; set; }

    [DataMember]
    public string TenMAC { get; set; }

    [DataMember]
    public string CuongDo { get; set; }

    [DataMember]
    public string DoSut { get; set; }

    [DataMember]
    public Decimal? TheTich { get; set; }

    [DataMember]
    public Decimal? LuyKe { get; set; }

    [DataMember]
    public int? TaiXeID { get; set; }

    [DataMember]
    public string TenTaiXe { get; set; }

    [DataMember]
    public int? XeID { get; set; }

    [DataMember]
    public string BienSo { get; set; }

    [DataMember]
    public string NiemChi { get; set; }

    [DataMember]
    public string NguoiTron { get; set; }

    [DataMember]
    public string Temp1 { get; set; }

    [DataMember]
    public string Temp2 { get; set; }

    [DataMember]
    public string GioBD { get; set; }

    [DataMember]
    public string GioKT { get; set; }

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
    public string MaHopDong { get; set; }
  }
}

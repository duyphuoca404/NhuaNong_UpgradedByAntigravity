// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjPhieuTron
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjPhieuTron : ObjectBase
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
    public int? CongTruongID { get; set; }

    [DataMember]
    public int? MACID { get; set; }

    [DataMember]
    public int? HangMucID { get; set; }

    [DataMember]
    public string MoTa { get; set; }

    [DataMember]
    public int? Status { get; set; }

    [DataMember]
    public int? NguoiTron { get; set; }

    [DataMember]
    public DateTime? ThoiGianTron { get; set; }

    [DataMember]
    public bool? IsQueued { get; set; }

    [DataMember]
    public Decimal? MinKLTron { get; set; }

    [DataMember]
    public Decimal? MaxKLTron { get; set; }

    [DataMember]
    public Decimal? MaxKLXeCho { get; set; }

    [DataMember]
    public int? XeID { get; set; }

    [DataMember]
    public int? TaiXeID { get; set; }

    [DataMember]
    public int? NhanVienID { get; set; }

    [DataMember]
    public DateTime? CreationDate { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public DateTime? LatestUpdateDate { get; set; }

    [DataMember]
    public int? LatestUpdatedBy { get; set; }

    [DataMember]
    public string NPHopDongMaHopDong { get; set; }

    [DataMember]
    public string NPHopDongTenHopDong { get; set; }

    [DataMember]
    public string NPHangMucTenHangMuc { get; set; }

    [DataMember]
    public string NPKhachHangTenKhachHang { get; set; }

    [DataMember]
    public string NPCongTruongTenCongTruong { get; set; }

    [DataMember]
    public string NPCongTruongDiaChi { get; set; }

    [DataMember]
    public string NPTaiXeMaTaiXe { get; set; }

    [DataMember]
    public string NPTaiXeTenTaiXe { get; set; }

    [DataMember]
    public string NPXeBienSo { get; set; }

    [DataMember]
    public string NPNhanVienTenNhanVien { get; set; }

    [DataMember]
    public string NPMACMaMAC { get; set; }

    [DataMember]
    public string NPMACTenMAC { get; set; }

    [DataMember]
    public int NPMACMACID { get; set; }

    [DataMember]
    public string NPMACCuongDo { get; set; }

    [DataMember]
    public string NPMACDoSut { get; set; }

    [DataMember]
    public Decimal? NPHopDongKLDatHang { get; set; }

    [DataMember]
    public Decimal? NPHopDongKLDaGiao { get; set; }
  }
}

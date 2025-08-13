// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.DuLieuTron
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class DuLieuTron
  {
    public int DuLieuTronID { get; set; }

    public int? HopDongID { get; set; }

    public string MaHopDong { get; set; }

    public string TenHopDong { get; set; }

    public DateTime? NgayHopDong { get; set; }

    public string MoTa { get; set; }

    public int? KhachHangID { get; set; }

    public int? CongTruongID { get; set; }

    public int? MACID { get; set; }

    public string DoSut { get; set; }

    public Decimal? KLDatHang { get; set; }

    public Decimal? KLDaGiao { get; set; }

    public Decimal? KLConLai { get; set; }

    public Decimal? KLTaoPhieuTron { get; set; }

    public int? Status { get; set; }

    public int? LastStatus { get; set; }

    public int LnNo { get; set; }

    public string NPKhachHangMaKhachHang { get; set; }

    public string NPKhachHangTenKhachHang { get; set; }

    public string NPCongTruongMaCongTruong { get; set; }

    public string NPCongTruongTenCongTruong { get; set; }

    public string NPMACMaMAC { get; set; }

    public string NPMACTenMAC { get; set; }

    public Decimal? DLT_KLDuTinh { get; set; }

    public Decimal? DLT_KLTronNhoNhat { get; set; }

    public Decimal? DLT_KLTronLonNhat { get; set; }

    public Decimal? DLT_KLDuTinhCuaTungMe { get; set; }

    public Decimal? DLT_KLDuTinhCuaTungMe_NoiB { get; set; }

    public bool DLT_KLDuTinhCuaTungMe_NoiB_IsUsed { get; set; }

    public Decimal? DLT_KLBuTruMeCuoi { get; set; }

    public Decimal? DLT_SLMeDuTinh { get; set; }

    public Decimal? DLT_KLXeChoLonNhat { get; set; }

    public Decimal? DLT_MACSUMSiloValueCalc { get; set; }

    public Decimal? DLT_MACSUMSiloValue { get; set; }

    public bool Activated { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public byte[] VersionNo { get; set; }

    public int? HangMucID { get; set; }

    public virtual HopDong HopDong { get; set; }
  }
}

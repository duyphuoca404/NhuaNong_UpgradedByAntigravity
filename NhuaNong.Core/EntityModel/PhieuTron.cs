// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.PhieuTron
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class PhieuTron
  {
    public PhieuTron() => this.MeTrons = (ICollection<MeTron>) new HashSet<MeTron>();

    public int PhieuTronID { get; set; }

    public string MaPhieuTron { get; set; }

    public DateTime? NgayPhieuTron { get; set; }

    public Decimal? KLDuTinh { get; set; }

    public Decimal? KLThuc { get; set; }

    public Decimal? KLTronNhoNhat { get; set; }

    public Decimal? KLTronLonNhat { get; set; }

    public Decimal? KLDuTinhCuaTungMe { get; set; }

    public Decimal? KLBuTruMeCuoi { get; set; }

    public Decimal? SLMeDuTinh { get; set; }

    public Decimal? SLMeHieuChinh { get; set; }

    public Decimal? SLMeDaTron { get; set; }

    public int? HopDongID { get; set; }

    public int? KhachHangID { get; set; }

    public int? CongTruongID { get; set; }

    public int? MACID { get; set; }

    public string MoTa { get; set; }

    public int? Status { get; set; }

    public int? NguoiTron { get; set; }

    public DateTime? ThoiGianTron { get; set; }

    public bool? IsQueued { get; set; }

    public Decimal? MinKLTron { get; set; }

    public Decimal? MaxKLTron { get; set; }

    public Decimal? MaxKLXeCho { get; set; }

    public int? XeID { get; set; }

    public int? TaiXeID { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public int? NhanVienID { get; set; }

    public int? HangMucID { get; set; }

    public int? NoPhieu { get; set; }

    public virtual CongTruong CongTruong { get; set; }

    public virtual HopDong HopDong { get; set; }

    public virtual KhachHang KhachHang { get; set; }

    public virtual MAC MAC { get; set; }

    public virtual ICollection<MeTron> MeTrons { get; set; }

    public virtual TaiXe TaiXe { get; set; }

    public virtual Xe Xe { get; set; }

    public virtual NhanVien NhanVien { get; set; }

    public virtual HangMuc HangMuc { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.KhachHang
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class KhachHang
  {
    public KhachHang()
    {
      this.HopDongs = (ICollection<HopDong>) new HashSet<HopDong>();
      this.PhieuTrons = (ICollection<PhieuTron>) new HashSet<PhieuTron>();
    }

    public int KhachHangID { get; set; }

    public string MaKhachHang { get; set; }

    public string TenKhachHang { get; set; }

    public string GioiTinh { get; set; }

    public string DiaChi { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }

    public string GhiChu { get; set; }

    public bool Activated { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public byte[] VersionNo { get; set; }

    public virtual ICollection<HopDong> HopDongs { get; set; }

    public virtual ICollection<PhieuTron> PhieuTrons { get; set; }
  }
}

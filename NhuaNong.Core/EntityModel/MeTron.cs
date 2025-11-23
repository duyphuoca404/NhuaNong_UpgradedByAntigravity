// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.MeTron
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class MeTron
  {
    public MeTron()
    {
      this.MeTronChiTiets = (ICollection<MeTronChiTiet>) new HashSet<MeTronChiTiet>();
      this.MeTronChiTietGiaoHangs = (ICollection<MeTronChiTietGiaoHang>) new HashSet<MeTronChiTietGiaoHang>();
    }

    public int MeTronID { get; set; }

    public int? LnNo { get; set; }

    public DateTime? NgayMeTron { get; set; }

    public int PhieuTronID { get; set; }

    public Decimal? KhoiLuong { get; set; }

    public string MoTa { get; set; }

    public int? Status { get; set; }

    public bool? IsManual { get; set; }

    public bool? IsDeleted { get; set; }

    public int? DeletedBy { get; set; }

    public string DeleteReason { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public virtual PhieuTron PhieuTron { get; set; }

    public virtual ICollection<MeTronChiTiet> MeTronChiTiets { get; set; }

    public virtual ICollection<MeTronChiTietGiaoHang> MeTronChiTietGiaoHangs { get; set; }
  }
}

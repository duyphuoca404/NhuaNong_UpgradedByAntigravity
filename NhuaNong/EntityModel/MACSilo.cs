// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.MACSilo
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class MACSilo
  {
    public MACSilo()
    {
      this.MeTronChiTiets = (ICollection<MeTronChiTiet>) new HashSet<MeTronChiTiet>();
      this.MeTronChiTietGiaoHangs = (ICollection<MeTronChiTietGiaoHang>) new HashSet<MeTronChiTietGiaoHang>();
    }

    public int MACSiloID { get; set; }

    public int MACID { get; set; }

    public int SiloID { get; set; }

    public Decimal? SiloValue { get; set; }

    public string GhiChu { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public virtual MAC MAC { get; set; }

    public virtual Silo Silo { get; set; }

    public virtual ICollection<MeTronChiTiet> MeTronChiTiets { get; set; }

    public virtual ICollection<MeTronChiTietGiaoHang> MeTronChiTietGiaoHangs { get; set; }
  }
}

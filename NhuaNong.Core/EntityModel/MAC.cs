// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.MAC
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class MAC
  {
    public MAC()
    {
      this.HopDongs = (ICollection<HopDong>) new HashSet<HopDong>();
      this.MACSiloes = (ICollection<MACSilo>) new HashSet<MACSilo>();
      this.PhieuTrons = (ICollection<PhieuTron>) new HashSet<PhieuTron>();
    }

    public int MACID { get; set; }

    public string MaMAC { get; set; }

    public string TenMAC { get; set; }

    public string GhiChu { get; set; }

    public string DoSut { get; set; }

    public Decimal ThemBotNuoc1 { get; set; }

    public Decimal ThemBotNuoc2 { get; set; }

    public bool Activated { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public byte[] VersionNo { get; set; }

    public virtual ICollection<HopDong> HopDongs { get; set; }

    public virtual ICollection<MACSilo> MACSiloes { get; set; }

    public virtual ICollection<PhieuTron> PhieuTrons { get; set; }
  }
}

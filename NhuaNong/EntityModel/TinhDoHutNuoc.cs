// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.TinhDoHutNuoc
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class TinhDoHutNuoc
  {
    public TinhDoHutNuoc()
    {
      this.Silos = (ICollection<Silo>) new HashSet<Silo>();
      this.TinhDoHutNuocChiTiets = (ICollection<TinhDoHutNuocChiTiet>) new HashSet<TinhDoHutNuocChiTiet>();
    }

    public int TinhDoHutNuocID { get; set; }

    public string MaTinhDoHutNuoc { get; set; }

    public DateTime NgayTinhDoHut { get; set; }

    public int NhomSiloID { get; set; }

    public string Name { get; set; }

    public Decimal DoHutNuoc { get; set; }

    public string Description { get; set; }

    public byte[] VersionNo { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public virtual NhomSilo NhomSilo { get; set; }

    public virtual ICollection<Silo> Silos { get; set; }

    public virtual ICollection<TinhDoHutNuocChiTiet> TinhDoHutNuocChiTiets { get; set; }
  }
}

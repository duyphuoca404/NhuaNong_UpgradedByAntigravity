// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.NhomSilo
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class NhomSilo
  {
    public NhomSilo()
    {
      this.Silos = (ICollection<Silo>) new HashSet<Silo>();
      this.TinhDoHutNuocs = (ICollection<TinhDoHutNuoc>) new HashSet<TinhDoHutNuoc>();
    }

    public int NhomSiloID { get; set; }

    public string MaNhomSilo { get; set; }

    public string TenNhomSilo { get; set; }

    public string GhiChu { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public virtual ICollection<Silo> Silos { get; set; }

    public virtual ICollection<TinhDoHutNuoc> TinhDoHutNuocs { get; set; }
  }
}

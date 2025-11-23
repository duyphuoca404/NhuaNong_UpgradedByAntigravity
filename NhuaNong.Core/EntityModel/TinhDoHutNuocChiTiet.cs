// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.TinhDoHutNuocChiTiet
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class TinhDoHutNuocChiTiet
  {
    public int TinhDoHutNuocChiTietID { get; set; }

    public int TinhDoHutNuocID { get; set; }

    public string KichCo { get; set; }

    public Decimal Percentage { get; set; }

    public Decimal Value { get; set; }

    public byte[] VersionNo { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public virtual TinhDoHutNuoc TinhDoHutNuoc { get; set; }
  }
}

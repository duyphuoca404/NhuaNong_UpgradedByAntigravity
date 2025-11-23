// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.VatTu
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class VatTu
  {
    public int VatTuID { get; set; }

    public string MaVatTu { get; set; }

    public string TenVatTu { get; set; }

    public string Description { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public byte[] VersionNo { get; set; }
  }
}

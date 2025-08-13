// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.WeiSiloSaving
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class WeiSiloSaving
  {
    public int WeiSiloSavingID { get; set; }

    public string MaCan { get; set; }

    public string MaSilo { get; set; }

    public string GhiChu { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }
  }
}

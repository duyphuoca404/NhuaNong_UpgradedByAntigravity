// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.vw_PvTranferDetailDay_WithID
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class vw_PvTranferDetailDay_WithID
  {
    public long? ID { get; set; }

    public int XeID { get; set; }

    public string BienSo { get; set; }

    public int? Total_Tranfer { get; set; }

    public Decimal? Total_KL { get; set; }

    public DateTime? NgayMeTron { get; set; }

    public bool? IsQueued { get; set; }

    public string NgayMeTron_BienSo { get; set; }
  }
}

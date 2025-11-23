// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.vw_PvTotalMaterial
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class vw_PvTotalMaterial
  {
    public int MaterialID { get; set; }

    public string MaterialCode { get; set; }

    public string MaterialName { get; set; }

    public Decimal? Sum_ValueCP { get; set; }

    public Decimal? Sum_ValueBat { get; set; }

    public Decimal? SaiSo { get; set; }

    public Decimal? PerSaiSo { get; set; }

    public bool? IsManual { get; set; }

    public Decimal? Sum_ValueBatMan { get; set; }
  }
}

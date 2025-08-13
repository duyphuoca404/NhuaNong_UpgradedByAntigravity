// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.Weigh
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class Weigh
  {
    public int WeighID { get; set; }

    public string WeighCode { get; set; }

    public string WeighName { get; set; }

    public string Description { get; set; }

    public int? STT { get; set; }

    public Decimal? Zero { get; set; }

    public Decimal? Max { get; set; }

    public Decimal? Offset { get; set; }

    public Decimal? KLEmpty { get; set; }

    public Decimal? TimeEmpty { get; set; }

    public Decimal? Limit { get; set; }

    public Decimal? WeiToVib { get; set; }

    public Decimal? TON { get; set; }

    public Decimal? TOFF { get; set; }

    public Decimal? Spare { get; set; }

    public bool? GiuKLTC { get; set; }
  }
}

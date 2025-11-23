// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.bandwidth
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class bandwidth
  {
    public int bandwidthid { get; set; }

    public int? networkid { get; set; }

    public string gd { get; set; }

    public short? portsocketmode { get; set; }

    public string tps { get; set; }

    public string tpsport { get; set; }

    public short? frequencyindex { get; set; }

    public DateTime? timestamp_lastyear { get; set; }

    public double? lastyear { get; set; }

    public DateTime? timestamp_lastmonth { get; set; }

    public double? lastmonth { get; set; }

    public DateTime? timestamp_lastweek { get; set; }

    public double? lastweek { get; set; }

    public DateTime? timestamp_lastday { get; set; }

    public double? lastday { get; set; }

    public DateTime? timestamp_lasthour { get; set; }

    public double? lasthour { get; set; }

    public byte? active { get; set; }
  }
}

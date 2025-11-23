// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.Objvw_TotalMaterial
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class Objvw_TotalMaterial
  {
    [DataMember]
    public int MaterialID { get; set; }

    [DataMember]
    public string MaterialCode { get; set; }

    [DataMember]
    public string MaterialName { get; set; }

    [DataMember]
    public Decimal? Sum_ValueCP { get; set; }

    [DataMember]
    public Decimal? Sum_ValueBat { get; set; }

    [DataMember]
    public Decimal? Sum_ValueBatMan { get; set; }

    [DataMember]
    public Decimal? SaiSo { get; set; }

    [DataMember]
    public Decimal? PerSaiSo { get; set; }

    [DataMember]
    public bool? IsManual { get; set; }
  }
}

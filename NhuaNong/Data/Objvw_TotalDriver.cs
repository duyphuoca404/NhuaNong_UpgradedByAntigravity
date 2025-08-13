// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.Objvw_TotalDriver
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class Objvw_TotalDriver
  {
    [DataMember]
    public int TaiXeID { get; set; }

    [DataMember]
    public string MaTaiXe { get; set; }

    [DataMember]
    public string TenTaiXe { get; set; }

    [DataMember]
    public int? Total_Tranfer { get; set; }

    [DataMember]
    public Decimal? Total_KL { get; set; }

    [DataMember]
    public bool? IsManual { get; set; }
  }
}

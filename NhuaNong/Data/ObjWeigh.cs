// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjWeigh
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjWeigh : ObjectBase
  {
    [DataMember]
    public int WeighID { get; set; }

    [DataMember]
    public string WeighCode { get; set; }

    [DataMember]
    public string WeighName { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    public int? STT { get; set; }

    [DataMember]
    public Decimal? Zero { get; set; }

    [DataMember]
    public Decimal? Max { get; set; }

    [DataMember]
    public Decimal? Offset { get; set; }

    [DataMember]
    public Decimal? KLEmpty { get; set; }

    [DataMember]
    public Decimal? TimeEmpty { get; set; }

    [DataMember]
    public Decimal? Limit { get; set; }

    [DataMember]
    public Decimal? WeiToVib { get; set; }

    [DataMember]
    public Decimal? TON { get; set; }

    [DataMember]
    public Decimal? TOFF { get; set; }

    [DataMember]
    public Decimal? Spare { get; set; }

    [DataMember]
    public Decimal? TiLeXa { get; set; }

    [DataMember]
    public bool? GiuKLTC { get; set; }
  }
}

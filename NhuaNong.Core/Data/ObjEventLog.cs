// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjEventLog
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjEventLog : ObjectBase
  {
    [DataMember]
    public int EventLogID { get; set; }

    [DataMember]
    public string LogCode { get; set; }

    [DataMember]
    public DateTime LogDate { get; set; }

    [DataMember]
    public int? UserID { get; set; }

    [DataMember]
    public string UserName { get; set; }

    [DataMember]
    public int EventActionCodeID { get; set; }

    [DataMember]
    public string EventActionContent { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    public Decimal? OldValueNumeric { get; set; }

    [DataMember]
    public Decimal? NewValueNumeric { get; set; }

    [DataMember]
    public string OldValueText { get; set; }

    [DataMember]
    public string NewValueText { get; set; }

    [DataMember]
    public string Title1 { get; set; }

    [DataMember]
    public Decimal? Value1 { get; set; }

    [DataMember]
    public string Content1 { get; set; }

    [DataMember]
    public string Title2 { get; set; }

    [DataMember]
    public Decimal? Value2 { get; set; }

    [DataMember]
    public string Content2 { get; set; }

    [DataMember]
    public string Title3 { get; set; }

    [DataMember]
    public Decimal? Value3 { get; set; }

    [DataMember]
    public string Content3 { get; set; }

    [DataMember]
    public DateTime? CreationDate { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public DateTime? LatestUpdateDate { get; set; }

    [DataMember]
    public int? LatestUpdatedBy { get; set; }

    [DataMember]
    public byte[] VersionNo { get; set; }
  }
}

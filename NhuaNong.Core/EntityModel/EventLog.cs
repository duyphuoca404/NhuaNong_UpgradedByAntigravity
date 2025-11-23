// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.EventLog
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class EventLog
  {
    public int EventLogID { get; set; }

    public string LogCode { get; set; }

    public DateTime LogDate { get; set; }

    public int? UserID { get; set; }

    public string UserName { get; set; }

    public int EventActionCodeID { get; set; }

    public string EventActionContent { get; set; }

    public string Description { get; set; }

    public Decimal? OldValueNumeric { get; set; }

    public Decimal? NewValueNumeric { get; set; }

    public string OldValueText { get; set; }

    public string NewValueText { get; set; }

    public string Title1 { get; set; }

    public Decimal? Value1 { get; set; }

    public string Content1 { get; set; }

    public string Title2 { get; set; }

    public Decimal? Value2 { get; set; }

    public string Content2 { get; set; }

    public string Title3 { get; set; }

    public Decimal? Value3 { get; set; }

    public string Content3 { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public byte[] VersionNo { get; set; }

    public virtual EventActionCode EventActionCode { get; set; }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.TraceRecord
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class TraceRecord
  {
    public int TraceRecordID { get; set; }

    public DateTime RecordTime { get; set; }

    public int UserID { get; set; }

    public string UserName { get; set; }

    public string FullName { get; set; }

    public string FormName { get; set; }

    public string ActionName { get; set; }

    public byte[] VersionNo { get; set; }
  }
}

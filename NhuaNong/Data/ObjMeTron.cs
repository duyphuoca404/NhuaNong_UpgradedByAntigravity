// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjMeTron
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjMeTron : ObjectBase
  {
    [DataMember]
    public int MeTronID { get; set; }

    [DataMember]
    public int? LnNo { get; set; }

    [DataMember]
    public DateTime? NgayMeTron { get; set; }

    [DataMember]
    public Decimal? KhoiLuong { get; set; }

    [DataMember]
    public int PhieuTronID { get; set; }

    [DataMember]
    public string MoTa { get; set; }

    [DataMember]
    public int? Status { get; set; }

    [DataMember]
    public bool? IsManual { get; set; }

    [DataMember]
    public bool? IsDeleted { get; set; }

    [DataMember]
    public int? DeletedBy { get; set; }

    [DataMember]
    public string DeleteReason { get; set; }

    [DataMember]
    public DateTime? CreationDate { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public DateTime? LatestUpdateDate { get; set; }

    [DataMember]
    public int? LatestUpdatedBy { get; set; }

    [DataMember]
    public string NPPhieuTronMaPhieuTron { get; set; }

    [DataMember]
    public List<ObjMeTronChiTiet> LstMeTronChiTiet { get; set; }
  }
}

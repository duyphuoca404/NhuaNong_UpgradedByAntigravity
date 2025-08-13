// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjTaiXe
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjTaiXe : ObjectBase
  {
    [DataMember]
    public int TaiXeID { get; set; }

    [DataMember]
    public string MaTaiXe { get; set; }

    [DataMember]
    public string TenTaiXe { get; set; }

    [DataMember]
    public int? NamSinh { get; set; }

    [DataMember]
    public string GioiTinh { get; set; }

    [DataMember]
    public string Phone { get; set; }

    [DataMember]
    public string GhiChu { get; set; }

    [DataMember]
    public bool Activated { get; set; }

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

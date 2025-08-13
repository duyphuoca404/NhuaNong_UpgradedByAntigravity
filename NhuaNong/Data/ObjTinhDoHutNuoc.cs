// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjTinhDoHutNuoc
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.ComponentModel;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjTinhDoHutNuoc : ObjectBase
  {
    public BindingList<ObjTinhDoHutNuocChiTiet> BLstTinhDoHutNuocChiTiet { get; set; }

    [DataMember]
    public int TinhDoHutNuocID { get; set; }

    [DataMember]
    public string MaTinhDoHutNuoc { get; set; }

    [DataMember]
    public DateTime NgayTinhDoHut { get; set; }

    [DataMember]
    public int NhomSiloID { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public Decimal DoHutNuoc { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    public byte[] VersionNo { get; set; }

    [DataMember]
    public DateTime? CreationDate { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public DateTime? LatestUpdateDate { get; set; }

    [DataMember]
    public int? LatestUpdatedBy { get; set; }
  }
}

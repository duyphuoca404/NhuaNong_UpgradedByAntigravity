// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjSEC_User
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Runtime.Serialization;

#nullable disable
namespace NhuaNong.Data
{
  [DataContract]
  public class ObjSEC_User : ObjectBase
  {
    [DataMember]
    public int UserID { get; set; }

    [DataMember]
    public string UserName { get; set; }

    [DataMember]
    public string Password { get; set; }

    [DataMember]
    public string FullName { get; set; }

    [DataMember]
    public string Department { get; set; }

    [DataMember]
    public string Email { get; set; }

    [DataMember]
    public string Phone { get; set; }

    [DataMember]
    public string CellPhone { get; set; }

    [DataMember]
    public bool? IsActived { get; set; }

    [DataMember]
    public bool? IsInUse { get; set; }

    [DataMember]
    public DateTime? CreationDate { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public DateTime? LatestUpdateDate { get; set; }

    [DataMember]
    public int? LatestUpdatedBy { get; set; }

    [DataMember]
    public string NPOtherInfo { get; set; }
  }
}

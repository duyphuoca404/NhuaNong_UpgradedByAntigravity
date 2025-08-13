// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.ObjSEC_Function
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
  public class ObjSEC_Function : ObjectBase
  {
    [DataMember]
    public int FunctionID { get; set; }

    [DataMember]
    public string FunctionCode { get; set; }

    [DataMember]
    public string FunctionName { get; set; }

    [DataMember]
    public string MenuName { get; set; }

    [DataMember]
    public string OtherName { get; set; }

    [DataMember]
    public int? FunctionType { get; set; }

    [DataMember]
    public int? ParentID { get; set; }

    [DataMember]
    public bool? IsStatic { get; set; }

    [DataMember]
    public bool? ShowAsBarItem { get; set; }

    [DataMember]
    public int? DisplayOrder { get; set; }

    [DataMember]
    public bool? BeginAsAGroup { get; set; }

    [DataMember]
    public bool? Visible { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    public int? TypeInfoID { get; set; }

    [DataMember]
    public DateTime? CreationDate { get; set; }

    [DataMember]
    public int? CreatedBy { get; set; }

    [DataMember]
    public DateTime? LatestUpdateDate { get; set; }

    [DataMember]
    public int? LatestUpdatedBy { get; set; }

    [DataMember]
    public bool NPSelect { get; set; }

    public List<ObjSEC_Function> LstChildFunction { get; set; }
  }
}

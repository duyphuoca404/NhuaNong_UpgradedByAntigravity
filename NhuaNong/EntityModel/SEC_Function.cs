// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.SEC_Function
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class SEC_Function
  {
    public SEC_Function()
    {
      this.SEC_RoleFunction = (ICollection<NhuaNong.EntityModel.SEC_RoleFunction>) new HashSet<NhuaNong.EntityModel.SEC_RoleFunction>();
    }

    public int FunctionID { get; set; }

    public string FunctionCode { get; set; }

    public string FunctionName { get; set; }

    public string MenuName { get; set; }

    public string OtherName { get; set; }

    public int? FunctionType { get; set; }

    public int? ParentID { get; set; }

    public bool? IsStatic { get; set; }

    public bool? ShowAsBarItem { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? BeginAsAGroup { get; set; }

    public bool? Visible { get; set; }

    public string Description { get; set; }

    public int? TypeInfoID { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public virtual SEC_TypeInfo SEC_TypeInfo { get; set; }

    public virtual ICollection<NhuaNong.EntityModel.SEC_RoleFunction> SEC_RoleFunction { get; set; }
  }
}

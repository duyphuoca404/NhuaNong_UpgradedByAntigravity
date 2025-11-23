// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.SEC_Role
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class SEC_Role
  {
    public SEC_Role()
    {
      this.SEC_RoleFunction = (ICollection<NhuaNong.EntityModel.SEC_RoleFunction>) new HashSet<NhuaNong.EntityModel.SEC_RoleFunction>();
      this.SEC_UserRole = (ICollection<NhuaNong.EntityModel.SEC_UserRole>) new HashSet<NhuaNong.EntityModel.SEC_UserRole>();
    }

    public int RoleID { get; set; }

    public string RoleName { get; set; }

    public string Description { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public virtual ICollection<NhuaNong.EntityModel.SEC_RoleFunction> SEC_RoleFunction { get; set; }

    public virtual ICollection<NhuaNong.EntityModel.SEC_UserRole> SEC_UserRole { get; set; }
  }
}

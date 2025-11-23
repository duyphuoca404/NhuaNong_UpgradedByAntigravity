// Decompiled with JetBrains decompiler
// Type: NhuaNong.EntityModel.SEC_User
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.EntityModel
{
  public class SEC_User
  {
    public SEC_User()
    {
      this.SEC_UserRole = (ICollection<NhuaNong.EntityModel.SEC_UserRole>) new HashSet<NhuaNong.EntityModel.SEC_UserRole>();
    }

    public int UserID { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public string FullName { get; set; }

    public string Department { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string CellPhone { get; set; }

    public bool? IsActived { get; set; }

    public bool? IsInUse { get; set; }

    public DateTime? CreationDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? LatestUpdateDate { get; set; }

    public int? LatestUpdatedBy { get; set; }

    public virtual ICollection<NhuaNong.EntityModel.SEC_UserRole> SEC_UserRole { get; set; }
  }
}

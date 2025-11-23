// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.SEC_RoleHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class SEC_RoleHelper
  {
    public static string GenMemberValues(ObjSEC_Role obj)
    {
      return string.Empty + "#1@#RoleID#2@#" + obj.RoleID.ToString() + "#1@#RoleName#2@#" + obj.RoleName + "#1@#Description#2@#" + obj.Description + "#1@#CreationDate#2@#" + obj.CreationDate.ToString() + "#1@#CreatedBy#2@#" + obj.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + obj.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + obj.LatestUpdatedBy.ToString();
    }

    public static string GenMemberValues(SEC_Role ent)
    {
      return string.Empty + "#1@#RoleID#2@#" + ent.RoleID.ToString() + "#1@#RoleName#2@#" + ent.RoleName + "#1@#Description#2@#" + ent.Description + "#1@#CreationDate#2@#" + ent.CreationDate.ToString() + "#1@#CreatedBy#2@#" + ent.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + ent.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + ent.LatestUpdatedBy.ToString();
    }

    public static void CopyToObjSEC_Role(SEC_Role fromEnt, ObjSEC_Role toObj)
    {
      toObj.RoleID = fromEnt.RoleID;
      toObj.RoleName = fromEnt.RoleName;
      toObj.Description = fromEnt.Description;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      if (toObj.RoleID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntSEC_Role(ObjSEC_Role fromObj, SEC_Role toEnt)
    {
      toEnt.RoleID = fromObj.RoleID;
      toEnt.RoleName = fromObj.RoleName;
      toEnt.Description = fromObj.Description;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjSEC_Role BuildNewObjSEC_Role(SEC_Role entSEC_Role)
    {
      ObjSEC_Role toObj = new ObjSEC_Role();
      SEC_RoleHelper.CopyToObjSEC_Role(entSEC_Role, toObj);
      return toObj;
    }

    public static IList<ObjSEC_Role> BuildListObjSEC_Role(IList<SEC_Role> lstEntSEC_Role)
    {
      IList<ObjSEC_Role> objSecRoleList = (IList<ObjSEC_Role>) new List<ObjSEC_Role>();
      foreach (SEC_Role entSEC_Role in (IEnumerable<SEC_Role>) lstEntSEC_Role)
        objSecRoleList.Add(SEC_RoleHelper.BuildNewObjSEC_Role(entSEC_Role));
      return objSecRoleList;
    }

    public static SEC_Role BuildNewEntSEC_Role(ObjSEC_Role objSEC_Role)
    {
      SEC_Role toEnt = new SEC_Role();
      SEC_RoleHelper.CopyToEntSEC_Role(objSEC_Role, toEnt);
      return toEnt;
    }

    public static IList<SEC_Role> BuildListEntSEC_Role(IList<ObjSEC_Role> lstObjSEC_Role)
    {
      IList<SEC_Role> secRoleList = (IList<SEC_Role>) new List<SEC_Role>();
      foreach (ObjSEC_Role objSEC_Role in (IEnumerable<ObjSEC_Role>) lstObjSEC_Role)
        secRoleList.Add(SEC_RoleHelper.BuildNewEntSEC_Role(objSEC_Role));
      return secRoleList;
    }
  }
}

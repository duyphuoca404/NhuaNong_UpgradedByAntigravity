// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.SEC_UserRoleHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class SEC_UserRoleHelper
  {
    public static void CopyToObjSEC_UserRole(SEC_UserRole fromEnt, ObjSEC_UserRole toObj)
    {
      toObj.UserRoleID = fromEnt.UserRoleID;
      toObj.UserID = fromEnt.UserID;
      toObj.RoleID = fromEnt.RoleID;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      if (toObj.UserRoleID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntSEC_UserRole(ObjSEC_UserRole fromObj, SEC_UserRole toEnt)
    {
      toEnt.UserRoleID = fromObj.UserRoleID;
      toEnt.UserID = fromObj.UserID;
      toEnt.RoleID = fromObj.RoleID;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjSEC_UserRole BuildNewObjSEC_UserRole(SEC_UserRole entSEC_UserRole)
    {
      ObjSEC_UserRole toObj = new ObjSEC_UserRole();
      SEC_UserRoleHelper.CopyToObjSEC_UserRole(entSEC_UserRole, toObj);
      return toObj;
    }

    public static IList<ObjSEC_UserRole> BuildListObjSEC_UserRole(
      IList<SEC_UserRole> lstEntSEC_UserRole)
    {
      IList<ObjSEC_UserRole> objSecUserRoleList = (IList<ObjSEC_UserRole>) new List<ObjSEC_UserRole>();
      foreach (SEC_UserRole entSEC_UserRole in (IEnumerable<SEC_UserRole>) lstEntSEC_UserRole)
        objSecUserRoleList.Add(SEC_UserRoleHelper.BuildNewObjSEC_UserRole(entSEC_UserRole));
      return objSecUserRoleList;
    }

    public static SEC_UserRole BuildNewEntSEC_UserRole(ObjSEC_UserRole objSEC_UserRole)
    {
      SEC_UserRole toEnt = new SEC_UserRole();
      SEC_UserRoleHelper.CopyToEntSEC_UserRole(objSEC_UserRole, toEnt);
      return toEnt;
    }

    public static IList<SEC_UserRole> BuildListEntSEC_UserRole(
      IList<ObjSEC_UserRole> lstObjSEC_UserRole)
    {
      IList<SEC_UserRole> secUserRoleList = (IList<SEC_UserRole>) new List<SEC_UserRole>();
      foreach (ObjSEC_UserRole objSEC_UserRole in (IEnumerable<ObjSEC_UserRole>) lstObjSEC_UserRole)
        secUserRoleList.Add(SEC_UserRoleHelper.BuildNewEntSEC_UserRole(objSEC_UserRole));
      return secUserRoleList;
    }
  }
}

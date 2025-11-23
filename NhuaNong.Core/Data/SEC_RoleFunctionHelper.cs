// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.SEC_RoleFunctionHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class SEC_RoleFunctionHelper
  {
    public static void CopyToObjSEC_RoleFunction(
      SEC_RoleFunction fromEnt,
      ObjSEC_RoleFunction toObj)
    {
      toObj.RoleFunctionID = fromEnt.RoleFunctionID;
      toObj.RoleID = fromEnt.RoleID;
      toObj.FunctionID = fromEnt.FunctionID;
      toObj.Description = fromEnt.Description;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      if (toObj.RoleFunctionID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntSEC_RoleFunction(
      ObjSEC_RoleFunction fromObj,
      SEC_RoleFunction toEnt)
    {
      toEnt.RoleFunctionID = fromObj.RoleFunctionID;
      toEnt.RoleID = fromObj.RoleID;
      toEnt.FunctionID = fromObj.FunctionID;
      toEnt.Description = fromObj.Description;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjSEC_RoleFunction BuildNewObjSEC_RoleFunction(
      SEC_RoleFunction entSEC_RoleFunction)
    {
      ObjSEC_RoleFunction toObj = new ObjSEC_RoleFunction();
      SEC_RoleFunctionHelper.CopyToObjSEC_RoleFunction(entSEC_RoleFunction, toObj);
      return toObj;
    }

    public static IList<ObjSEC_RoleFunction> BuildListObjSEC_RoleFunction(
      IList<SEC_RoleFunction> lstEntSEC_RoleFunction)
    {
      IList<ObjSEC_RoleFunction> objSecRoleFunctionList = (IList<ObjSEC_RoleFunction>) new List<ObjSEC_RoleFunction>();
      foreach (SEC_RoleFunction entSEC_RoleFunction in (IEnumerable<SEC_RoleFunction>) lstEntSEC_RoleFunction)
        objSecRoleFunctionList.Add(SEC_RoleFunctionHelper.BuildNewObjSEC_RoleFunction(entSEC_RoleFunction));
      return objSecRoleFunctionList;
    }

    public static SEC_RoleFunction BuildNewEntSEC_RoleFunction(
      ObjSEC_RoleFunction objSEC_RoleFunction)
    {
      SEC_RoleFunction toEnt = new SEC_RoleFunction();
      SEC_RoleFunctionHelper.CopyToEntSEC_RoleFunction(objSEC_RoleFunction, toEnt);
      return toEnt;
    }

    public static IList<SEC_RoleFunction> BuildListEntSEC_RoleFunction(
      IList<ObjSEC_RoleFunction> lstObjSEC_RoleFunction)
    {
      IList<SEC_RoleFunction> secRoleFunctionList = (IList<SEC_RoleFunction>) new List<SEC_RoleFunction>();
      foreach (ObjSEC_RoleFunction objSEC_RoleFunction in (IEnumerable<ObjSEC_RoleFunction>) lstObjSEC_RoleFunction)
        secRoleFunctionList.Add(SEC_RoleFunctionHelper.BuildNewEntSEC_RoleFunction(objSEC_RoleFunction));
      return secRoleFunctionList;
    }
  }
}

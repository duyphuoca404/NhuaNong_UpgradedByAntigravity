// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.SEC_UserHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class SEC_UserHelper
  {
    public static string GenMemberValues(ObjSEC_User obj)
    {
      return string.Empty + "#1@#UserID#2@#" + obj.UserID.ToString() + "#1@#UserName#2@#" + obj.UserName + "#1@#Password#2@#" + obj.Password + "#1@#FullName#2@#" + obj.FullName + "#1@#Department#2@#" + obj.Department + "#1@#Email#2@#" + obj.Email + "#1@#Phone#2@#" + obj.Phone + "#1@#CellPhone#2@#" + obj.CellPhone + "#1@#IsActived#2@#" + obj.IsActived.ToString() + "#1@#IsInUse#2@#" + obj.IsInUse.ToString() + "#1@#CreationDate#2@#" + obj.CreationDate.ToString() + "#1@#CreatedBy#2@#" + obj.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + obj.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + obj.LatestUpdatedBy.ToString();
    }

    public static string GenMemberValues(SEC_User ent)
    {
      return string.Empty + "#1@#UserID#2@#" + ent.UserID.ToString() + "#1@#UserName#2@#" + ent.UserName + "#1@#Password#2@#" + ent.Password + "#1@#FullName#2@#" + ent.FullName + "#1@#Department#2@#" + ent.Department + "#1@#Email#2@#" + ent.Email + "#1@#Phone#2@#" + ent.Phone + "#1@#CellPhone#2@#" + ent.CellPhone + "#1@#IsActived#2@#" + ent.IsActived.ToString() + "#1@#IsInUse#2@#" + ent.IsInUse.ToString() + "#1@#CreationDate#2@#" + ent.CreationDate.ToString() + "#1@#CreatedBy#2@#" + ent.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + ent.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + ent.LatestUpdatedBy.ToString();
    }

    public static void CopyToObjSEC_User(SEC_User fromEnt, ObjSEC_User toObj)
    {
      toObj.UserID = fromEnt.UserID;
      toObj.UserName = fromEnt.UserName;
      toObj.Password = fromEnt.Password;
      toObj.FullName = fromEnt.FullName;
      toObj.Department = fromEnt.Department;
      toObj.Email = fromEnt.Email;
      toObj.Phone = fromEnt.Phone;
      toObj.CellPhone = fromEnt.CellPhone;
      toObj.IsActived = fromEnt.IsActived;
      toObj.IsInUse = fromEnt.IsInUse;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      if (toObj.UserID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntSEC_User(ObjSEC_User fromObj, SEC_User toEnt)
    {
      toEnt.UserID = fromObj.UserID;
      toEnt.UserName = fromObj.UserName;
      toEnt.Password = fromObj.Password;
      toEnt.FullName = fromObj.FullName;
      toEnt.Department = fromObj.Department;
      toEnt.Email = fromObj.Email;
      toEnt.Phone = fromObj.Phone;
      toEnt.CellPhone = fromObj.CellPhone;
      toEnt.IsActived = fromObj.IsActived;
      toEnt.IsInUse = fromObj.IsInUse;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjSEC_User BuildNewObjSEC_User(SEC_User entSEC_User)
    {
      ObjSEC_User toObj = new ObjSEC_User();
      SEC_UserHelper.CopyToObjSEC_User(entSEC_User, toObj);
      return toObj;
    }

    public static IList<ObjSEC_User> BuildListObjSEC_User(IList<SEC_User> lstEntSEC_User)
    {
      IList<ObjSEC_User> objSecUserList = (IList<ObjSEC_User>) new List<ObjSEC_User>();
      foreach (SEC_User entSEC_User in (IEnumerable<SEC_User>) lstEntSEC_User)
        objSecUserList.Add(SEC_UserHelper.BuildNewObjSEC_User(entSEC_User));
      return objSecUserList;
    }

    public static SEC_User BuildNewEntSEC_User(ObjSEC_User objSEC_User)
    {
      SEC_User toEnt = new SEC_User();
      SEC_UserHelper.CopyToEntSEC_User(objSEC_User, toEnt);
      return toEnt;
    }

    public static IList<SEC_User> BuildListEntSEC_User(IList<ObjSEC_User> lstObjSEC_User)
    {
      IList<SEC_User> secUserList = (IList<SEC_User>) new List<SEC_User>();
      foreach (ObjSEC_User objSEC_User in (IEnumerable<ObjSEC_User>) lstObjSEC_User)
        secUserList.Add(SEC_UserHelper.BuildNewEntSEC_User(objSEC_User));
      return secUserList;
    }
  }
}

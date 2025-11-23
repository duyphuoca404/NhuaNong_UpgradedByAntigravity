// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.SEC_TypeInfoHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class SEC_TypeInfoHelper
  {
    public static void CopyToObjSEC_TypeInfo(SEC_TypeInfo fromEnt, ObjSEC_TypeInfo toObj)
    {
      toObj.TypeInfoID = fromEnt.TypeInfoID;
      toObj.TypeInfo = fromEnt.TypeInfo;
      toObj.AssemblyID = fromEnt.AssemblyID;
      toObj.NPSEC_AssemblyAssemblyInfo = fromEnt.SEC_Assembly.AssemblyInfo;
      if (toObj.TypeInfoID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntSEC_TypeInfo(ObjSEC_TypeInfo fromObj, SEC_TypeInfo toEnt)
    {
      toEnt.TypeInfoID = fromObj.TypeInfoID;
      toEnt.TypeInfo = fromObj.TypeInfo;
      toEnt.AssemblyID = fromObj.AssemblyID;
    }

    public static ObjSEC_TypeInfo BuildNewObjSEC_TypeInfo(SEC_TypeInfo entSEC_TypeInfo)
    {
      ObjSEC_TypeInfo toObj = new ObjSEC_TypeInfo();
      SEC_TypeInfoHelper.CopyToObjSEC_TypeInfo(entSEC_TypeInfo, toObj);
      return toObj;
    }

    public static IList<ObjSEC_TypeInfo> BuildListObjSEC_TypeInfo(
      IList<SEC_TypeInfo> lstEntSEC_TypeInfo)
    {
      IList<ObjSEC_TypeInfo> objSecTypeInfoList = (IList<ObjSEC_TypeInfo>) new List<ObjSEC_TypeInfo>();
      foreach (SEC_TypeInfo entSEC_TypeInfo in (IEnumerable<SEC_TypeInfo>) lstEntSEC_TypeInfo)
        objSecTypeInfoList.Add(SEC_TypeInfoHelper.BuildNewObjSEC_TypeInfo(entSEC_TypeInfo));
      return objSecTypeInfoList;
    }

    public static SEC_TypeInfo BuildNewEntSEC_TypeInfo(ObjSEC_TypeInfo objSEC_TypeInfo)
    {
      SEC_TypeInfo toEnt = new SEC_TypeInfo();
      SEC_TypeInfoHelper.CopyToEntSEC_TypeInfo(objSEC_TypeInfo, toEnt);
      return toEnt;
    }

    public static IList<SEC_TypeInfo> BuildListEntSEC_TypeInfo(
      IList<ObjSEC_TypeInfo> lstObjSEC_TypeInfo)
    {
      IList<SEC_TypeInfo> secTypeInfoList = (IList<SEC_TypeInfo>) new List<SEC_TypeInfo>();
      foreach (ObjSEC_TypeInfo objSEC_TypeInfo in (IEnumerable<ObjSEC_TypeInfo>) lstObjSEC_TypeInfo)
        secTypeInfoList.Add(SEC_TypeInfoHelper.BuildNewEntSEC_TypeInfo(objSEC_TypeInfo));
      return secTypeInfoList;
    }
  }
}

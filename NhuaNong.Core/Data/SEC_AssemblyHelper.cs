// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.SEC_AssemblyHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class SEC_AssemblyHelper
  {
    public static void CopyToObjSEC_Assembly(SEC_Assembly fromEnt, ObjSEC_Assembly toObj)
    {
      toObj.AssemblyID = fromEnt.AssemblyID;
      toObj.AssemblyInfo = fromEnt.AssemblyInfo;
      if (toObj.AssemblyID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntSEC_Assembly(ObjSEC_Assembly fromObj, SEC_Assembly toEnt)
    {
      toEnt.AssemblyID = fromObj.AssemblyID;
      toEnt.AssemblyInfo = fromObj.AssemblyInfo;
    }

    public static ObjSEC_Assembly BuildNewObjSEC_Assembly(SEC_Assembly entSEC_Assembly)
    {
      ObjSEC_Assembly toObj = new ObjSEC_Assembly();
      SEC_AssemblyHelper.CopyToObjSEC_Assembly(entSEC_Assembly, toObj);
      return toObj;
    }

    public static IList<ObjSEC_Assembly> BuildListObjSEC_Assembly(
      IList<SEC_Assembly> lstEntSEC_Assembly)
    {
      IList<ObjSEC_Assembly> objSecAssemblyList = (IList<ObjSEC_Assembly>) new List<ObjSEC_Assembly>();
      foreach (SEC_Assembly entSEC_Assembly in (IEnumerable<SEC_Assembly>) lstEntSEC_Assembly)
        objSecAssemblyList.Add(SEC_AssemblyHelper.BuildNewObjSEC_Assembly(entSEC_Assembly));
      return objSecAssemblyList;
    }

    public static SEC_Assembly BuildNewEntSEC_Assembly(ObjSEC_Assembly objSEC_Assembly)
    {
      SEC_Assembly toEnt = new SEC_Assembly();
      SEC_AssemblyHelper.CopyToEntSEC_Assembly(objSEC_Assembly, toEnt);
      return toEnt;
    }

    public static IList<SEC_Assembly> BuildListEntSEC_Assembly(
      IList<ObjSEC_Assembly> lstObjSEC_Assembly)
    {
      IList<SEC_Assembly> secAssemblyList = (IList<SEC_Assembly>) new List<SEC_Assembly>();
      foreach (ObjSEC_Assembly objSEC_Assembly in (IEnumerable<ObjSEC_Assembly>) lstObjSEC_Assembly)
        secAssemblyList.Add(SEC_AssemblyHelper.BuildNewEntSEC_Assembly(objSEC_Assembly));
      return secAssemblyList;
    }
  }
}

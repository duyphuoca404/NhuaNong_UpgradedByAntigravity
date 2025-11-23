// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.SEC_FunctionHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class SEC_FunctionHelper
  {
    public static void CopyToObjSEC_Function(SEC_Function fromEnt, ObjSEC_Function toObj)
    {
      toObj.FunctionID = fromEnt.FunctionID;
      toObj.FunctionCode = fromEnt.FunctionCode;
      toObj.FunctionName = fromEnt.FunctionName;
      toObj.MenuName = fromEnt.MenuName;
      toObj.OtherName = fromEnt.OtherName;
      toObj.FunctionType = fromEnt.FunctionType;
      toObj.ParentID = fromEnt.ParentID;
      toObj.IsStatic = fromEnt.IsStatic;
      toObj.ShowAsBarItem = fromEnt.ShowAsBarItem;
      toObj.DisplayOrder = fromEnt.DisplayOrder;
      toObj.BeginAsAGroup = fromEnt.BeginAsAGroup;
      toObj.Visible = fromEnt.Visible;
      toObj.Description = fromEnt.Description;
      toObj.TypeInfoID = fromEnt.TypeInfoID;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      if (toObj.FunctionID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntSEC_Function(ObjSEC_Function fromObj, SEC_Function toEnt)
    {
      toEnt.FunctionID = fromObj.FunctionID;
      toEnt.FunctionCode = fromObj.FunctionCode;
      toEnt.FunctionName = fromObj.FunctionName;
      toEnt.MenuName = fromObj.MenuName;
      toEnt.OtherName = fromObj.OtherName;
      toEnt.FunctionType = fromObj.FunctionType;
      toEnt.ParentID = fromObj.ParentID;
      toEnt.IsStatic = fromObj.IsStatic;
      toEnt.ShowAsBarItem = fromObj.ShowAsBarItem;
      toEnt.DisplayOrder = fromObj.DisplayOrder;
      toEnt.BeginAsAGroup = fromObj.BeginAsAGroup;
      toEnt.Visible = fromObj.Visible;
      toEnt.Description = fromObj.Description;
      toEnt.TypeInfoID = fromObj.TypeInfoID;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjSEC_Function BuildNewObjSEC_Function(SEC_Function entSEC_Function)
    {
      ObjSEC_Function toObj = new ObjSEC_Function();
      SEC_FunctionHelper.CopyToObjSEC_Function(entSEC_Function, toObj);
      return toObj;
    }

    public static IList<ObjSEC_Function> BuildListObjSEC_Function(
      IList<SEC_Function> lstEntSEC_Function)
    {
      IList<ObjSEC_Function> objSecFunctionList = (IList<ObjSEC_Function>) new List<ObjSEC_Function>();
      foreach (SEC_Function entSEC_Function in (IEnumerable<SEC_Function>) lstEntSEC_Function)
        objSecFunctionList.Add(SEC_FunctionHelper.BuildNewObjSEC_Function(entSEC_Function));
      return objSecFunctionList;
    }

    public static SEC_Function BuildNewEntSEC_Function(ObjSEC_Function objSEC_Function)
    {
      SEC_Function toEnt = new SEC_Function();
      SEC_FunctionHelper.CopyToEntSEC_Function(objSEC_Function, toEnt);
      return toEnt;
    }

    public static IList<SEC_Function> BuildListEntSEC_Function(
      IList<ObjSEC_Function> lstObjSEC_Function)
    {
      IList<SEC_Function> secFunctionList = (IList<SEC_Function>) new List<SEC_Function>();
      foreach (ObjSEC_Function objSEC_Function in (IEnumerable<ObjSEC_Function>) lstObjSEC_Function)
        secFunctionList.Add(SEC_FunctionHelper.BuildNewEntSEC_Function(objSEC_Function));
      return secFunctionList;
    }
  }
}

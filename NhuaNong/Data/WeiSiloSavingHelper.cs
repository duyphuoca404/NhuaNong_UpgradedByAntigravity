// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.WeiSiloSavingHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class WeiSiloSavingHelper
  {
    public static void CopyToObjWeiSiloSaving(WeiSiloSaving fromEnt, ObjWeiSiloSaving toObj)
    {
      toObj.WeiSiloSavingID = fromEnt.WeiSiloSavingID;
      toObj.MaCan = fromEnt.MaCan;
      toObj.MaSilo = fromEnt.MaSilo;
      toObj.GhiChu = fromEnt.GhiChu;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      if (toObj.WeiSiloSavingID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntWeiSiloSaving(ObjWeiSiloSaving fromObj, WeiSiloSaving toEnt)
    {
      toEnt.WeiSiloSavingID = fromObj.WeiSiloSavingID;
      toEnt.MaCan = fromObj.MaCan;
      toEnt.MaSilo = fromObj.MaSilo;
      toEnt.GhiChu = fromObj.GhiChu;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjWeiSiloSaving BuildNewObjWeiSiloSaving(WeiSiloSaving entWeiSiloSaving)
    {
      ObjWeiSiloSaving toObj = new ObjWeiSiloSaving();
      WeiSiloSavingHelper.CopyToObjWeiSiloSaving(entWeiSiloSaving, toObj);
      return toObj;
    }

    public static IList<ObjWeiSiloSaving> BuildListObjWeiSiloSaving(
      IList<WeiSiloSaving> lstEntWeiSiloSaving)
    {
      IList<ObjWeiSiloSaving> objWeiSiloSavingList = (IList<ObjWeiSiloSaving>) new List<ObjWeiSiloSaving>();
      foreach (WeiSiloSaving entWeiSiloSaving in (IEnumerable<WeiSiloSaving>) lstEntWeiSiloSaving)
        objWeiSiloSavingList.Add(WeiSiloSavingHelper.BuildNewObjWeiSiloSaving(entWeiSiloSaving));
      return objWeiSiloSavingList;
    }

    public static WeiSiloSaving BuildNewEntWeiSiloSaving(ObjWeiSiloSaving objWeiSiloSaving)
    {
      WeiSiloSaving toEnt = new WeiSiloSaving();
      WeiSiloSavingHelper.CopyToEntWeiSiloSaving(objWeiSiloSaving, toEnt);
      return toEnt;
    }

    public static IList<WeiSiloSaving> BuildListEntWeiSiloSaving(
      IList<ObjWeiSiloSaving> lstObjWeiSiloSaving)
    {
      IList<WeiSiloSaving> weiSiloSavingList = (IList<WeiSiloSaving>) new List<WeiSiloSaving>();
      foreach (ObjWeiSiloSaving objWeiSiloSaving in (IEnumerable<ObjWeiSiloSaving>) lstObjWeiSiloSaving)
        weiSiloSavingList.Add(WeiSiloSavingHelper.BuildNewEntWeiSiloSaving(objWeiSiloSaving));
      return weiSiloSavingList;
    }
  }
}

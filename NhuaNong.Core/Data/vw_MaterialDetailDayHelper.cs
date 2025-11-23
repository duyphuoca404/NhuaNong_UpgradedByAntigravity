// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.vw_MaterialDetailDayHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  internal class vw_MaterialDetailDayHelper
  {
    public static void CopyToObjvw_MaterialDetailDay(
      vw_PvMaterialDetailDay fromEnt,
      Objvw_MaterialDetailDay toObj)
    {
      toObj.MaterialID = fromEnt.MaterialID;
      toObj.MaterialCode = fromEnt.MaterialCode;
      toObj.MaterialName = fromEnt.MaterialName;
      toObj.Sum_ValueCP = fromEnt.Sum_ValueCP;
      toObj.Sum_ValueBat = fromEnt.Sum_ValueBat;
      toObj.Sum_ValueBatMan = fromEnt.Sum_ValueBatMan;
      toObj.SaiSo = fromEnt.SaiSo;
      toObj.PerSaiSo = fromEnt.PerSaiSo;
      toObj.NgayMeTron = fromEnt.NgayMeTron;
      toObj.IsManual = fromEnt.IsManual;
    }

    public static void CopyToEntvw_MaterialDetailDay(
      Objvw_MaterialDetailDay fromObj,
      vw_PvMaterialDetailDay toEnt)
    {
      toEnt.MaterialID = fromObj.MaterialID;
      toEnt.MaterialCode = fromObj.MaterialCode;
      toEnt.MaterialName = fromObj.MaterialName;
      toEnt.Sum_ValueCP = fromObj.Sum_ValueCP;
      toEnt.Sum_ValueBat = fromObj.Sum_ValueBat;
      toEnt.Sum_ValueBatMan = fromObj.Sum_ValueBatMan;
      toEnt.SaiSo = fromObj.SaiSo;
      toEnt.PerSaiSo = fromObj.PerSaiSo;
      toEnt.NgayMeTron = fromObj.NgayMeTron;
      toEnt.IsManual = fromObj.IsManual;
    }

    public static Objvw_MaterialDetailDay BuildNewObjvw_MaterialDetailDay(
      vw_PvMaterialDetailDay entvw_MaterialDetailDay)
    {
      Objvw_MaterialDetailDay toObj = new Objvw_MaterialDetailDay();
      vw_MaterialDetailDayHelper.CopyToObjvw_MaterialDetailDay(entvw_MaterialDetailDay, toObj);
      return toObj;
    }

    public static IList<Objvw_MaterialDetailDay> BuildListObjvw_MaterialDetailDay(
      IList<vw_PvMaterialDetailDay> lstEntvw_MaterialDetailDay)
    {
      IList<Objvw_MaterialDetailDay> materialDetailDayList = (IList<Objvw_MaterialDetailDay>) new List<Objvw_MaterialDetailDay>();
      foreach (vw_PvMaterialDetailDay entvw_MaterialDetailDay in (IEnumerable<vw_PvMaterialDetailDay>) lstEntvw_MaterialDetailDay)
        materialDetailDayList.Add(vw_MaterialDetailDayHelper.BuildNewObjvw_MaterialDetailDay(entvw_MaterialDetailDay));
      return materialDetailDayList;
    }

    public static vw_PvMaterialDetailDay BuildNewEntvw_MaterialDetailDay(
      Objvw_MaterialDetailDay objvw_MaterialDetailDay)
    {
      vw_PvMaterialDetailDay toEnt = new vw_PvMaterialDetailDay();
      vw_MaterialDetailDayHelper.CopyToEntvw_MaterialDetailDay(objvw_MaterialDetailDay, toEnt);
      return toEnt;
    }

    public static IList<vw_PvMaterialDetailDay> BuildListEntvw_MaterialDetailDay(
      IList<Objvw_MaterialDetailDay> lstObjvw_MaterialDetailDay)
    {
      IList<vw_PvMaterialDetailDay> materialDetailDayList = (IList<vw_PvMaterialDetailDay>) new List<vw_PvMaterialDetailDay>();
      foreach (Objvw_MaterialDetailDay objvw_MaterialDetailDay in (IEnumerable<Objvw_MaterialDetailDay>) lstObjvw_MaterialDetailDay)
        materialDetailDayList.Add(vw_MaterialDetailDayHelper.BuildNewEntvw_MaterialDetailDay(objvw_MaterialDetailDay));
      return materialDetailDayList;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.vw_PvMaterialDetailDayWithIDHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  internal class vw_PvMaterialDetailDayWithIDHelper
  {
    public static void CopyToObjvw_MaterialDetailDayWithID(
      vw_PvMaterialDetailDay_WithID fromEnt,
      Objvw_MaterialDetailDayWithID toObj)
    {
      toObj.ID = (int) fromEnt.ID.Value;
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

    public static void CopyToEntvw_MaterialDetailDayWithID(
      Objvw_MaterialDetailDayWithID fromObj,
      vw_PvMaterialDetailDay_WithID toEnt)
    {
      toEnt.ID = new long?((long) fromObj.ID);
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

    public static Objvw_MaterialDetailDayWithID BuildNewObjvw_MaterialDetailDayWithID(
      vw_PvMaterialDetailDay_WithID entvw_MaterialDetailDay)
    {
      Objvw_MaterialDetailDayWithID toObj = new Objvw_MaterialDetailDayWithID();
      vw_PvMaterialDetailDayWithIDHelper.CopyToObjvw_MaterialDetailDayWithID(entvw_MaterialDetailDay, toObj);
      return toObj;
    }

    public static IList<Objvw_MaterialDetailDayWithID> BuildListObjvw_MaterialDetailDayWithID(
      IList<vw_PvMaterialDetailDay_WithID> lstEntvw_MaterialDetailDay)
    {
      IList<Objvw_MaterialDetailDayWithID> materialDetailDayWithIdList = (IList<Objvw_MaterialDetailDayWithID>) new List<Objvw_MaterialDetailDayWithID>();
      foreach (vw_PvMaterialDetailDay_WithID entvw_MaterialDetailDay in (IEnumerable<vw_PvMaterialDetailDay_WithID>) lstEntvw_MaterialDetailDay)
        materialDetailDayWithIdList.Add(vw_PvMaterialDetailDayWithIDHelper.BuildNewObjvw_MaterialDetailDayWithID(entvw_MaterialDetailDay));
      return materialDetailDayWithIdList;
    }

    public static vw_PvMaterialDetailDay_WithID BuildNewEntvw_MaterialDetailDayWithID(
      Objvw_MaterialDetailDayWithID objvw_MaterialDetailDay)
    {
      vw_PvMaterialDetailDay_WithID toEnt = new vw_PvMaterialDetailDay_WithID();
      vw_PvMaterialDetailDayWithIDHelper.CopyToEntvw_MaterialDetailDayWithID(objvw_MaterialDetailDay, toEnt);
      return toEnt;
    }

    public static IList<vw_PvMaterialDetailDay_WithID> BuildListEntvw_MaterialDetailDayWithID(
      IList<Objvw_MaterialDetailDayWithID> lstObjvw_MaterialDetailDay)
    {
      IList<vw_PvMaterialDetailDay_WithID> materialDetailDayWithIdList = (IList<vw_PvMaterialDetailDay_WithID>) new List<vw_PvMaterialDetailDay_WithID>();
      foreach (Objvw_MaterialDetailDayWithID objvw_MaterialDetailDay in (IEnumerable<Objvw_MaterialDetailDayWithID>) lstObjvw_MaterialDetailDay)
        materialDetailDayWithIdList.Add(vw_PvMaterialDetailDayWithIDHelper.BuildNewEntvw_MaterialDetailDayWithID(objvw_MaterialDetailDay));
      return materialDetailDayWithIdList;
    }
  }
}

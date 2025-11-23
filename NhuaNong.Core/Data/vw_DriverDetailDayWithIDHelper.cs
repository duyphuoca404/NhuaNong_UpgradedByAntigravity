// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.vw_DriverDetailDayWithIDHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  internal class vw_DriverDetailDayWithIDHelper
  {
    public static void CopyToObjvw_DriverDetailDayWithID(
      vw_PvDriverDetailDay_WithID fromEnt,
      Objvw_DriverDetailDayWithID toObj)
    {
      toObj.ID = (int) fromEnt.ID.Value;
      toObj.TaiXeID = fromEnt.TaiXeID;
      toObj.TenTaiXe = fromEnt.TenTaiXe;
      toObj.Total_Tranfer = fromEnt.Total_Tranfer;
      toObj.Total_KL = fromEnt.Total_KL;
      toObj.NgayMeTron = fromEnt.NgayMeTron;
      toObj.IsManual = fromEnt.IsManual;
    }

    public static void CopyToEntvw_DriverDetailDayWithID(
      Objvw_DriverDetailDayWithID fromObj,
      vw_PvDriverDetailDay_WithID toEnt)
    {
      toEnt.ID = new long?((long) fromObj.ID);
      toEnt.TaiXeID = fromObj.TaiXeID;
      toEnt.TenTaiXe = fromObj.TenTaiXe;
      toEnt.Total_Tranfer = fromObj.Total_Tranfer;
      toEnt.Total_KL = fromObj.Total_KL;
      toEnt.NgayMeTron = fromObj.NgayMeTron;
      toEnt.IsManual = fromObj.IsManual;
    }

    public static Objvw_DriverDetailDayWithID BuildNewObjvw_DriverDetailDayWithID(
      vw_PvDriverDetailDay_WithID entvw_MaterialDetailDay)
    {
      Objvw_DriverDetailDayWithID toObj = new Objvw_DriverDetailDayWithID();
      vw_DriverDetailDayWithIDHelper.CopyToObjvw_DriverDetailDayWithID(entvw_MaterialDetailDay, toObj);
      return toObj;
    }

    public static IList<Objvw_DriverDetailDayWithID> BuildListObjvw_DriverDetailDayWithID(
      IList<vw_PvDriverDetailDay_WithID> lstEntvw_MaterialDetailDay)
    {
      IList<Objvw_DriverDetailDayWithID> driverDetailDayWithIdList = (IList<Objvw_DriverDetailDayWithID>) new List<Objvw_DriverDetailDayWithID>();
      foreach (vw_PvDriverDetailDay_WithID entvw_MaterialDetailDay in (IEnumerable<vw_PvDriverDetailDay_WithID>) lstEntvw_MaterialDetailDay)
        driverDetailDayWithIdList.Add(vw_DriverDetailDayWithIDHelper.BuildNewObjvw_DriverDetailDayWithID(entvw_MaterialDetailDay));
      return driverDetailDayWithIdList;
    }

    public static vw_PvDriverDetailDay_WithID BuildNewEntvw_DriverDetailDayWithID(
      Objvw_DriverDetailDayWithID objvw_MaterialDetailDay)
    {
      vw_PvDriverDetailDay_WithID toEnt = new vw_PvDriverDetailDay_WithID();
      vw_DriverDetailDayWithIDHelper.CopyToEntvw_DriverDetailDayWithID(objvw_MaterialDetailDay, toEnt);
      return toEnt;
    }

    public static IList<vw_PvDriverDetailDay_WithID> BuildListEntCopyToObjvw_DriverDetailDayWithID(
      IList<Objvw_DriverDetailDayWithID> lstObjvw_MaterialDetailDay)
    {
      IList<vw_PvDriverDetailDay_WithID> driverDetailDayWithId = (IList<vw_PvDriverDetailDay_WithID>) new List<vw_PvDriverDetailDay_WithID>();
      foreach (Objvw_DriverDetailDayWithID objvw_MaterialDetailDay in (IEnumerable<Objvw_DriverDetailDayWithID>) lstObjvw_MaterialDetailDay)
        driverDetailDayWithId.Add(vw_DriverDetailDayWithIDHelper.BuildNewEntvw_DriverDetailDayWithID(objvw_MaterialDetailDay));
      return driverDetailDayWithId;
    }
  }
}

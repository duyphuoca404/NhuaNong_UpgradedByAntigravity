// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.vw_TranferDetailDayWithIDHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  internal class vw_TranferDetailDayWithIDHelper
  {
    public static void CopyToObjvw_TranferDetailDayWithID(
      vw_PvTranferDetailDay_WithID fromEnt,
      Objvw_TranferDetailDayWithID toObj)
    {
      toObj.ID = (int) fromEnt.ID.Value;
      toObj.XeID = fromEnt.XeID;
      toObj.BienSo = fromEnt.BienSo;
      toObj.Total_Tranfer = fromEnt.Total_Tranfer;
      toObj.Total_KL = fromEnt.Total_KL;
      toObj.NgayMeTron = fromEnt.NgayMeTron;
      toObj.IsQueued = fromEnt.IsQueued;
    }

    public static void CopyToEntvw_TranferDetailDayWithID(
      Objvw_TranferDetailDayWithID fromObj,
      vw_PvTranferDetailDay_WithID toEnt)
    {
      toEnt.ID = new long?((long) fromObj.ID);
      toEnt.XeID = fromObj.XeID;
      toEnt.BienSo = fromObj.BienSo;
      toEnt.Total_Tranfer = fromObj.Total_Tranfer;
      toEnt.Total_KL = fromObj.Total_KL;
      toEnt.NgayMeTron = fromObj.NgayMeTron;
      toEnt.IsQueued = fromObj.IsQueued;
    }

    public static Objvw_TranferDetailDayWithID BuildNewObjvw_TranferDetailDayWithID(
      vw_PvTranferDetailDay_WithID entCongTruong)
    {
      Objvw_TranferDetailDayWithID toObj = new Objvw_TranferDetailDayWithID();
      vw_TranferDetailDayWithIDHelper.CopyToObjvw_TranferDetailDayWithID(entCongTruong, toObj);
      return toObj;
    }

    public static IList<Objvw_TranferDetailDayWithID> BuildListObjvw_TranferDetailDayWithID(
      IList<vw_PvTranferDetailDay_WithID> lstEntCongTruong)
    {
      IList<Objvw_TranferDetailDayWithID> tranferDetailDayWithIdList = (IList<Objvw_TranferDetailDayWithID>) new List<Objvw_TranferDetailDayWithID>();
      foreach (vw_PvTranferDetailDay_WithID entCongTruong in (IEnumerable<vw_PvTranferDetailDay_WithID>) lstEntCongTruong)
        tranferDetailDayWithIdList.Add(vw_TranferDetailDayWithIDHelper.BuildNewObjvw_TranferDetailDayWithID(entCongTruong));
      return tranferDetailDayWithIdList;
    }

    public static vw_PvTranferDetailDay_WithID BuildNewEntvw_TranferDetailDayWithID(
      Objvw_TranferDetailDayWithID objCongTruong)
    {
      vw_PvTranferDetailDay_WithID toEnt = new vw_PvTranferDetailDay_WithID();
      vw_TranferDetailDayWithIDHelper.CopyToEntvw_TranferDetailDayWithID(objCongTruong, toEnt);
      return toEnt;
    }

    public static IList<vw_PvTranferDetailDay_WithID> BuildListEntvw_TranferDetailDayWithID(
      IList<Objvw_TranferDetailDayWithID> lstObjCongTruong)
    {
      IList<vw_PvTranferDetailDay_WithID> tranferDetailDayWithIdList = (IList<vw_PvTranferDetailDay_WithID>) new List<vw_PvTranferDetailDay_WithID>();
      foreach (Objvw_TranferDetailDayWithID objCongTruong in (IEnumerable<Objvw_TranferDetailDayWithID>) lstObjCongTruong)
        tranferDetailDayWithIdList.Add(vw_TranferDetailDayWithIDHelper.BuildNewEntvw_TranferDetailDayWithID(objCongTruong));
      return tranferDetailDayWithIdList;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.vw_TranferDetailDayHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class vw_TranferDetailDayHelper
  {
    public static void CopyToObjCongTruong(
      vw_PvTranferDetailDay fromEnt,
      Objvw_TranferDetailDay toObj)
    {
      toObj.XeID = fromEnt.XeID;
      toObj.BienSo = fromEnt.BienSo;
      toObj.Total_Tranfer = fromEnt.Total_Tranfer;
      toObj.Total_KL = fromEnt.Total_KL;
      toObj.NgayMeTron = fromEnt.NgayMeTron;
      toObj.IsQueued = fromEnt.IsQueued;
    }

    public static void CopyToEntCongTruong(
      Objvw_TranferDetailDay fromObj,
      vw_PvTranferDetailDay toEnt)
    {
      toEnt.XeID = fromObj.XeID;
      toEnt.BienSo = fromObj.BienSo;
      toEnt.Total_Tranfer = fromObj.Total_Tranfer;
      toEnt.Total_KL = fromObj.Total_KL;
      toEnt.NgayMeTron = fromObj.NgayMeTron;
      toEnt.IsQueued = fromObj.IsQueued;
    }

    public static Objvw_TranferDetailDay BuildNewObjCongTruong(vw_PvTranferDetailDay entCongTruong)
    {
      Objvw_TranferDetailDay toObj = new Objvw_TranferDetailDay();
      vw_TranferDetailDayHelper.CopyToObjCongTruong(entCongTruong, toObj);
      return toObj;
    }

    public static IList<Objvw_TranferDetailDay> BuildListObjvw_TranferDetailDay(
      IList<vw_PvTranferDetailDay> lstEntCongTruong)
    {
      IList<Objvw_TranferDetailDay> tranferDetailDayList = (IList<Objvw_TranferDetailDay>) new List<Objvw_TranferDetailDay>();
      foreach (vw_PvTranferDetailDay entCongTruong in (IEnumerable<vw_PvTranferDetailDay>) lstEntCongTruong)
        tranferDetailDayList.Add(vw_TranferDetailDayHelper.BuildNewObjCongTruong(entCongTruong));
      return tranferDetailDayList;
    }

    public static vw_PvTranferDetailDay BuildNewEntvw_TranferDetailDay(
      Objvw_TranferDetailDay objCongTruong)
    {
      vw_PvTranferDetailDay toEnt = new vw_PvTranferDetailDay();
      vw_TranferDetailDayHelper.CopyToEntCongTruong(objCongTruong, toEnt);
      return toEnt;
    }

    public static IList<vw_PvTranferDetailDay> BuildListEntvw_TranferDetailDay(
      IList<Objvw_TranferDetailDay> lstObjCongTruong)
    {
      IList<vw_PvTranferDetailDay> tranferDetailDayList = (IList<vw_PvTranferDetailDay>) new List<vw_PvTranferDetailDay>();
      foreach (Objvw_TranferDetailDay objCongTruong in (IEnumerable<Objvw_TranferDetailDay>) lstObjCongTruong)
        tranferDetailDayList.Add(vw_TranferDetailDayHelper.BuildNewEntvw_TranferDetailDay(objCongTruong));
      return tranferDetailDayList;
    }
  }
}

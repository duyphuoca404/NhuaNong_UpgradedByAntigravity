// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.vw_TotalDriverHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  internal class vw_TotalDriverHelper
  {
    public static void CopyToObjvw_TotalDriver(vw_PvTotalDriver fromEnt, Objvw_TotalDriver toObj)
    {
      toObj.TaiXeID = fromEnt.TaiXeID;
      toObj.MaTaiXe = fromEnt.MaTaiXe;
      toObj.TenTaiXe = fromEnt.TenTaiXe;
      toObj.Total_Tranfer = fromEnt.Total_Tranfer;
      toObj.Total_KL = fromEnt.Total_KL;
      toObj.IsManual = fromEnt.IsManual;
    }

    public static void CopyToEntvw_TotalDriver(Objvw_TotalDriver fromObj, vw_PvTotalDriver toEnt)
    {
      toEnt.TaiXeID = fromObj.TaiXeID;
      toEnt.MaTaiXe = fromObj.MaTaiXe;
      toEnt.TenTaiXe = fromObj.TenTaiXe;
      toEnt.Total_Tranfer = fromObj.Total_Tranfer;
      toEnt.Total_KL = fromObj.Total_KL;
      toEnt.IsManual = fromObj.IsManual;
    }

    public static Objvw_TotalDriver BuildNewObjvw_TotalDriver(vw_PvTotalDriver entvw_TotalDriver)
    {
      Objvw_TotalDriver toObj = new Objvw_TotalDriver();
      vw_TotalDriverHelper.CopyToObjvw_TotalDriver(entvw_TotalDriver, toObj);
      return toObj;
    }

    public static IList<Objvw_TotalDriver> BuildListObjvw_TotalDriver(
      IList<vw_PvTotalDriver> lstEntvw_TotalDriver)
    {
      IList<Objvw_TotalDriver> objvwTotalDriverList = (IList<Objvw_TotalDriver>) new List<Objvw_TotalDriver>();
      foreach (vw_PvTotalDriver entvw_TotalDriver in (IEnumerable<vw_PvTotalDriver>) lstEntvw_TotalDriver)
        objvwTotalDriverList.Add(vw_TotalDriverHelper.BuildNewObjvw_TotalDriver(entvw_TotalDriver));
      return objvwTotalDriverList;
    }

    public static vw_PvTotalDriver BuildNewEntvw_TotalDriver(Objvw_TotalDriver objvw_TotalDriver)
    {
      vw_PvTotalDriver toEnt = new vw_PvTotalDriver();
      vw_TotalDriverHelper.CopyToEntvw_TotalDriver(objvw_TotalDriver, toEnt);
      return toEnt;
    }

    public static IList<vw_PvTotalDriver> BuildListEntTotalTranfer(
      IList<Objvw_TotalDriver> lstObjvw_TotalDriver)
    {
      IList<vw_PvTotalDriver> vwPvTotalDriverList = (IList<vw_PvTotalDriver>) new List<vw_PvTotalDriver>();
      foreach (Objvw_TotalDriver objvw_TotalDriver in (IEnumerable<Objvw_TotalDriver>) lstObjvw_TotalDriver)
        vwPvTotalDriverList.Add(vw_TotalDriverHelper.BuildNewEntvw_TotalDriver(objvw_TotalDriver));
      return vwPvTotalDriverList;
    }
  }
}

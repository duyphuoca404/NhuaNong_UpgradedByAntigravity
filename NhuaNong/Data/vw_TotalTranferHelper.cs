// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.vw_TotalTranferHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  internal class vw_TotalTranferHelper
  {
    public static void CopyToObjvw_TotalTranfer(vw_PvTotalTranfer fromEnt, Objvw_TotalTranfer toObj)
    {
      toObj.XeID = fromEnt.XeID;
      toObj.BienSo = fromEnt.BienSo;
      toObj.Total_Tranfer = fromEnt.Total_Tranfer;
      toObj.Total_KL = fromEnt.Total_KL;
      toObj.IsManual = fromEnt.IsManual;
    }

    public static void CopyToEntvw_TotalTranfer(Objvw_TotalTranfer fromObj, vw_PvTotalTranfer toEnt)
    {
      toEnt.XeID = fromObj.XeID;
      toEnt.BienSo = fromObj.BienSo;
      toEnt.Total_Tranfer = fromObj.Total_Tranfer;
      toEnt.Total_KL = fromObj.Total_KL;
      toEnt.IsManual = fromObj.IsManual;
    }

    public static Objvw_TotalTranfer BuildNewObjvw_TotalTranfer(vw_PvTotalTranfer entvw_TotalTranfer)
    {
      Objvw_TotalTranfer toObj = new Objvw_TotalTranfer();
      vw_TotalTranferHelper.CopyToObjvw_TotalTranfer(entvw_TotalTranfer, toObj);
      return toObj;
    }

    public static IList<Objvw_TotalTranfer> BuildListObjvw_TotalTranfer(
      IList<vw_PvTotalTranfer> lstEntvw_TotalTranfer)
    {
      IList<Objvw_TotalTranfer> objvwTotalTranferList = (IList<Objvw_TotalTranfer>) new List<Objvw_TotalTranfer>();
      foreach (vw_PvTotalTranfer entvw_TotalTranfer in (IEnumerable<vw_PvTotalTranfer>) lstEntvw_TotalTranfer)
        objvwTotalTranferList.Add(vw_TotalTranferHelper.BuildNewObjvw_TotalTranfer(entvw_TotalTranfer));
      return objvwTotalTranferList;
    }

    public static vw_PvTotalTranfer BuildNewEntvw_TotalTranfer(Objvw_TotalTranfer objvw_TotalTranfer)
    {
      vw_PvTotalTranfer toEnt = new vw_PvTotalTranfer();
      vw_TotalTranferHelper.CopyToEntvw_TotalTranfer(objvw_TotalTranfer, toEnt);
      return toEnt;
    }

    public static IList<vw_PvTotalTranfer> BuildListEntTotalTranfer(
      IList<Objvw_TotalTranfer> lstObjvw_TotalTranfer)
    {
      IList<vw_PvTotalTranfer> vwPvTotalTranferList = (IList<vw_PvTotalTranfer>) new List<vw_PvTotalTranfer>();
      foreach (Objvw_TotalTranfer objvw_TotalTranfer in (IEnumerable<Objvw_TotalTranfer>) lstObjvw_TotalTranfer)
        vwPvTotalTranferList.Add(vw_TotalTranferHelper.BuildNewEntvw_TotalTranfer(objvw_TotalTranfer));
      return vwPvTotalTranferList;
    }
  }
}

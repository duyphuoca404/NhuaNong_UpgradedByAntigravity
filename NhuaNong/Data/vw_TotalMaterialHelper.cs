// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.vw_TotalMaterialHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  internal class vw_TotalMaterialHelper
  {
    public static void CopyToObjvw_TotalMaterial(
      vw_PvTotalMaterial fromEnt,
      Objvw_TotalMaterial toObj)
    {
      toObj.MaterialID = fromEnt.MaterialID;
      toObj.MaterialCode = fromEnt.MaterialCode;
      toObj.MaterialName = fromEnt.MaterialName;
      toObj.Sum_ValueCP = fromEnt.Sum_ValueCP;
      toObj.Sum_ValueBat = fromEnt.Sum_ValueBat;
      toObj.Sum_ValueBatMan = fromEnt.Sum_ValueBatMan;
      toObj.SaiSo = fromEnt.SaiSo;
      toObj.PerSaiSo = fromEnt.PerSaiSo;
      toObj.IsManual = fromEnt.IsManual;
    }

    public static void CopyToEntvw_TotalMaterial(
      Objvw_TotalMaterial fromObj,
      vw_PvTotalMaterial toEnt)
    {
      toEnt.MaterialID = fromObj.MaterialID;
      toEnt.MaterialCode = fromObj.MaterialCode;
      toEnt.MaterialName = fromObj.MaterialName;
      toEnt.Sum_ValueCP = fromObj.Sum_ValueCP;
      toEnt.Sum_ValueBat = fromObj.Sum_ValueBat;
      toEnt.Sum_ValueBatMan = fromObj.Sum_ValueBatMan;
      toEnt.SaiSo = fromObj.SaiSo;
      toEnt.PerSaiSo = fromObj.PerSaiSo;
      toEnt.IsManual = fromObj.IsManual;
    }

    public static Objvw_TotalMaterial BuildNewObjvw_TotalMaterial(
      vw_PvTotalMaterial entvw_TotalMaterial)
    {
      Objvw_TotalMaterial toObj = new Objvw_TotalMaterial();
      vw_TotalMaterialHelper.CopyToObjvw_TotalMaterial(entvw_TotalMaterial, toObj);
      return toObj;
    }

    public static IList<Objvw_TotalMaterial> BuildListObjvw_TotalMateria(
      IList<vw_PvTotalMaterial> lstEntvw_TotalMateria)
    {
      IList<Objvw_TotalMaterial> objvwTotalMaterialList = (IList<Objvw_TotalMaterial>) new List<Objvw_TotalMaterial>();
      foreach (vw_PvTotalMaterial entvw_TotalMaterial in (IEnumerable<vw_PvTotalMaterial>) lstEntvw_TotalMateria)
        objvwTotalMaterialList.Add(vw_TotalMaterialHelper.BuildNewObjvw_TotalMaterial(entvw_TotalMaterial));
      return objvwTotalMaterialList;
    }

    public static vw_PvTotalMaterial BuildNewEntvw_TotalMateria(
      Objvw_TotalMaterial objvw_TotalMaterial)
    {
      vw_PvTotalMaterial toEnt = new vw_PvTotalMaterial();
      vw_TotalMaterialHelper.CopyToEntvw_TotalMaterial(objvw_TotalMaterial, toEnt);
      return toEnt;
    }

    public static IList<vw_PvTotalMaterial> BuildListEntHangMuc(
      IList<Objvw_TotalMaterial> lstObjvw_TotalMaterial)
    {
      IList<vw_PvTotalMaterial> vwPvTotalMaterialList = (IList<vw_PvTotalMaterial>) new List<vw_PvTotalMaterial>();
      foreach (Objvw_TotalMaterial objvw_TotalMaterial in (IEnumerable<Objvw_TotalMaterial>) lstObjvw_TotalMaterial)
        vwPvTotalMaterialList.Add(vw_TotalMaterialHelper.BuildNewEntvw_TotalMateria(objvw_TotalMaterial));
      return vwPvTotalMaterialList;
    }
  }
}

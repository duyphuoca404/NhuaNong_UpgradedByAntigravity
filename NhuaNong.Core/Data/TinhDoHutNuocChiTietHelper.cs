// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.TinhDoHutNuocChiTietHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class TinhDoHutNuocChiTietHelper
  {
    public static void CopyToObjTinhDoHutNuocChiTiet(
      TinhDoHutNuocChiTiet fromEnt,
      ObjTinhDoHutNuocChiTiet toObj)
    {
      toObj.TinhDoHutNuocChiTietID = fromEnt.TinhDoHutNuocChiTietID;
      toObj.TinhDoHutNuocID = fromEnt.TinhDoHutNuocID;
      toObj.KichCo = fromEnt.KichCo;
      toObj.Percentage = fromEnt.Percentage;
      toObj.Value = fromEnt.Value;
      toObj.VersionNo = fromEnt.VersionNo;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      if (toObj.TinhDoHutNuocChiTietID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntTinhDoHutNuocChiTiet(
      ObjTinhDoHutNuocChiTiet fromObj,
      TinhDoHutNuocChiTiet toEnt)
    {
      toEnt.TinhDoHutNuocChiTietID = fromObj.TinhDoHutNuocChiTietID;
      toEnt.TinhDoHutNuocID = fromObj.TinhDoHutNuocID;
      toEnt.KichCo = fromObj.KichCo;
      toEnt.Percentage = fromObj.Percentage;
      toEnt.Value = fromObj.Value;
      toEnt.VersionNo = fromObj.VersionNo;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjTinhDoHutNuocChiTiet BuildNewObjTinhDoHutNuocChiTiet(
      TinhDoHutNuocChiTiet entTinhDoHutNuocChiTiet)
    {
      ObjTinhDoHutNuocChiTiet toObj = new ObjTinhDoHutNuocChiTiet();
      TinhDoHutNuocChiTietHelper.CopyToObjTinhDoHutNuocChiTiet(entTinhDoHutNuocChiTiet, toObj);
      return toObj;
    }

    public static IList<ObjTinhDoHutNuocChiTiet> BuildListObjTinhDoHutNuocChiTiet(
      IList<TinhDoHutNuocChiTiet> lstEntTinhDoHutNuocChiTiet)
    {
      IList<ObjTinhDoHutNuocChiTiet> doHutNuocChiTietList = (IList<ObjTinhDoHutNuocChiTiet>) new List<ObjTinhDoHutNuocChiTiet>();
      foreach (TinhDoHutNuocChiTiet entTinhDoHutNuocChiTiet in (IEnumerable<TinhDoHutNuocChiTiet>) lstEntTinhDoHutNuocChiTiet)
        doHutNuocChiTietList.Add(TinhDoHutNuocChiTietHelper.BuildNewObjTinhDoHutNuocChiTiet(entTinhDoHutNuocChiTiet));
      return doHutNuocChiTietList;
    }

    public static TinhDoHutNuocChiTiet BuildNewEntTinhDoHutNuocChiTiet(
      ObjTinhDoHutNuocChiTiet objTinhDoHutNuocChiTiet)
    {
      TinhDoHutNuocChiTiet toEnt = new TinhDoHutNuocChiTiet();
      TinhDoHutNuocChiTietHelper.CopyToEntTinhDoHutNuocChiTiet(objTinhDoHutNuocChiTiet, toEnt);
      return toEnt;
    }

    public static IList<TinhDoHutNuocChiTiet> BuildListEntTinhDoHutNuocChiTiet(
      IList<ObjTinhDoHutNuocChiTiet> lstObjTinhDoHutNuocChiTiet)
    {
      IList<TinhDoHutNuocChiTiet> doHutNuocChiTietList = (IList<TinhDoHutNuocChiTiet>) new List<TinhDoHutNuocChiTiet>();
      foreach (ObjTinhDoHutNuocChiTiet objTinhDoHutNuocChiTiet in (IEnumerable<ObjTinhDoHutNuocChiTiet>) lstObjTinhDoHutNuocChiTiet)
        doHutNuocChiTietList.Add(TinhDoHutNuocChiTietHelper.BuildNewEntTinhDoHutNuocChiTiet(objTinhDoHutNuocChiTiet));
      return doHutNuocChiTietList;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.HangMucHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  internal class HangMucHelper
  {
    public static void CopyToObjHangMuc(HangMuc fromEnt, ObjHangMuc toObj)
    {
      toObj.HangMucID = fromEnt.HangMucID;
      toObj.MaHangMuc = fromEnt.MaHangMuc;
      toObj.TenHangMuc = fromEnt.TenHangMuc;
      toObj.GhiChu = fromEnt.GhiChu;
      toObj.Activated = fromEnt.Activated;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.VersionNo = fromEnt.VersionNo;
      if (toObj.HangMucID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntHangMuc(ObjHangMuc fromObj, HangMuc toEnt)
    {
      toEnt.HangMucID = fromObj.HangMucID;
      toEnt.MaHangMuc = fromObj.MaHangMuc;
      toEnt.TenHangMuc = fromObj.TenHangMuc;
      toEnt.GhiChu = fromObj.GhiChu;
      toEnt.Activated = fromObj.Activated;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.VersionNo = fromObj.VersionNo;
    }

    public static ObjHangMuc BuildNewObjHangMuc(HangMuc entHangMuc)
    {
      ObjHangMuc toObj = new ObjHangMuc();
      HangMucHelper.CopyToObjHangMuc(entHangMuc, toObj);
      return toObj;
    }

    public static IList<ObjHangMuc> BuildListObjHangMuc(IList<HangMuc> lstEntHangMuc)
    {
      IList<ObjHangMuc> objHangMucList = (IList<ObjHangMuc>) new List<ObjHangMuc>();
      foreach (HangMuc entHangMuc in (IEnumerable<HangMuc>) lstEntHangMuc)
        objHangMucList.Add(HangMucHelper.BuildNewObjHangMuc(entHangMuc));
      return objHangMucList;
    }

    public static HangMuc BuildNewEntHangMuc(ObjHangMuc objHangMuc)
    {
      HangMuc toEnt = new HangMuc();
      HangMucHelper.CopyToEntHangMuc(objHangMuc, toEnt);
      return toEnt;
    }

    public static IList<HangMuc> BuildListEntHangMuc(IList<ObjHangMuc> lstObjHangMuc)
    {
      IList<HangMuc> hangMucList = (IList<HangMuc>) new List<HangMuc>();
      foreach (ObjHangMuc objHangMuc in (IEnumerable<ObjHangMuc>) lstObjHangMuc)
        hangMucList.Add(HangMucHelper.BuildNewEntHangMuc(objHangMuc));
      return hangMucList;
    }
  }
}

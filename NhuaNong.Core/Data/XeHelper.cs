// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.XeHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class XeHelper
  {
    public static void CopyToObjXe(Xe fromEnt, ObjXe toObj)
    {
      toObj.XeID = fromEnt.XeID;
      toObj.BienSo = fromEnt.BienSo;
      toObj.KhoiLuong = fromEnt.KhoiLuong;
      toObj.GhiChu = fromEnt.GhiChu;
      toObj.Activated = fromEnt.Activated;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.VersionNo = fromEnt.VersionNo;
      if (toObj.XeID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntXe(ObjXe fromObj, Xe toEnt)
    {
      toEnt.XeID = fromObj.XeID;
      toEnt.BienSo = fromObj.BienSo;
      toEnt.KhoiLuong = fromObj.KhoiLuong;
      toEnt.GhiChu = fromObj.GhiChu;
      toEnt.Activated = fromObj.Activated;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.VersionNo = fromObj.VersionNo;
    }

    public static ObjXe BuildNewObjXe(Xe entXe)
    {
      ObjXe toObj = new ObjXe();
      XeHelper.CopyToObjXe(entXe, toObj);
      return toObj;
    }

    public static IList<ObjXe> BuildListObjXe(IList<Xe> lstEntXe)
    {
      IList<ObjXe> objXeList = (IList<ObjXe>) new List<ObjXe>();
      foreach (Xe entXe in (IEnumerable<Xe>) lstEntXe)
        objXeList.Add(XeHelper.BuildNewObjXe(entXe));
      return objXeList;
    }

    public static Xe BuildNewEntXe(ObjXe objXe)
    {
      Xe toEnt = new Xe();
      XeHelper.CopyToEntXe(objXe, toEnt);
      return toEnt;
    }

    public static IList<Xe> BuildListEntXe(IList<ObjXe> lstObjXe)
    {
      IList<Xe> xeList = (IList<Xe>) new List<Xe>();
      foreach (ObjXe objXe in (IEnumerable<ObjXe>) lstObjXe)
        xeList.Add(XeHelper.BuildNewEntXe(objXe));
      return xeList;
    }
  }
}

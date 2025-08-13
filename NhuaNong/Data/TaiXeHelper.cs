// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.TaiXeHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class TaiXeHelper
  {
    public static void CopyToObjTaiXe(TaiXe fromEnt, ObjTaiXe toObj)
    {
      toObj.TaiXeID = fromEnt.TaiXeID;
      toObj.MaTaiXe = fromEnt.MaTaiXe;
      toObj.TenTaiXe = fromEnt.TenTaiXe;
      toObj.NamSinh = fromEnt.NamSinh;
      toObj.GioiTinh = fromEnt.GioiTinh;
      toObj.Phone = fromEnt.Phone;
      toObj.GhiChu = fromEnt.GhiChu;
      toObj.Activated = fromEnt.Activated;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.VersionNo = fromEnt.VersionNo;
      if (toObj.TaiXeID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntTaiXe(ObjTaiXe fromObj, TaiXe toEnt)
    {
      toEnt.TaiXeID = fromObj.TaiXeID;
      toEnt.MaTaiXe = fromObj.MaTaiXe;
      toEnt.TenTaiXe = fromObj.TenTaiXe;
      toEnt.NamSinh = fromObj.NamSinh;
      toEnt.GioiTinh = fromObj.GioiTinh;
      toEnt.Phone = fromObj.Phone;
      toEnt.GhiChu = fromObj.GhiChu;
      toEnt.Activated = fromObj.Activated;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.VersionNo = fromObj.VersionNo;
    }

    public static ObjTaiXe BuildNewObjTaiXe(TaiXe entTaiXe)
    {
      ObjTaiXe toObj = new ObjTaiXe();
      TaiXeHelper.CopyToObjTaiXe(entTaiXe, toObj);
      return toObj;
    }

    public static IList<ObjTaiXe> BuildListObjTaiXe(IList<TaiXe> lstEntTaiXe)
    {
      IList<ObjTaiXe> objTaiXeList = (IList<ObjTaiXe>) new List<ObjTaiXe>();
      foreach (TaiXe entTaiXe in (IEnumerable<TaiXe>) lstEntTaiXe)
        objTaiXeList.Add(TaiXeHelper.BuildNewObjTaiXe(entTaiXe));
      return objTaiXeList;
    }

    public static TaiXe BuildNewEntTaiXe(ObjTaiXe objTaiXe)
    {
      TaiXe toEnt = new TaiXe();
      TaiXeHelper.CopyToEntTaiXe(objTaiXe, toEnt);
      return toEnt;
    }

    public static IList<TaiXe> BuildListEntTaiXe(IList<ObjTaiXe> lstObjTaiXe)
    {
      IList<TaiXe> taiXeList = (IList<TaiXe>) new List<TaiXe>();
      foreach (ObjTaiXe objTaiXe in (IEnumerable<ObjTaiXe>) lstObjTaiXe)
        taiXeList.Add(TaiXeHelper.BuildNewEntTaiXe(objTaiXe));
      return taiXeList;
    }
  }
}

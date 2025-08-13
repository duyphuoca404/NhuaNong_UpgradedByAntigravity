// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.CongTruongHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class CongTruongHelper
  {
    public static void CopyToObjCongTruong(CongTruong fromEnt, ObjCongTruong toObj)
    {
      toObj.CongTruongID = fromEnt.CongTruongID;
      toObj.MaCongTruong = fromEnt.MaCongTruong;
      toObj.TenCongTruong = fromEnt.TenCongTruong;
      toObj.DiaChi = fromEnt.DiaChi;
      toObj.Phone = fromEnt.Phone;
      toObj.GhiChu = fromEnt.GhiChu;
      toObj.Activated = fromEnt.Activated;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.VersionNo = fromEnt.VersionNo;
      if (toObj.CongTruongID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntCongTruong(ObjCongTruong fromObj, CongTruong toEnt)
    {
      toEnt.CongTruongID = fromObj.CongTruongID;
      toEnt.MaCongTruong = fromObj.MaCongTruong;
      toEnt.TenCongTruong = fromObj.TenCongTruong;
      toEnt.DiaChi = fromObj.DiaChi;
      toEnt.Phone = fromObj.Phone;
      toEnt.GhiChu = fromObj.GhiChu;
      toEnt.Activated = fromObj.Activated;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.VersionNo = fromObj.VersionNo;
    }

    public static ObjCongTruong BuildNewObjCongTruong(CongTruong entCongTruong)
    {
      ObjCongTruong toObj = new ObjCongTruong();
      CongTruongHelper.CopyToObjCongTruong(entCongTruong, toObj);
      return toObj;
    }

    public static IList<ObjCongTruong> BuildListObjCongTruong(IList<CongTruong> lstEntCongTruong)
    {
      IList<ObjCongTruong> objCongTruongList = (IList<ObjCongTruong>) new List<ObjCongTruong>();
      foreach (CongTruong entCongTruong in (IEnumerable<CongTruong>) lstEntCongTruong)
        objCongTruongList.Add(CongTruongHelper.BuildNewObjCongTruong(entCongTruong));
      return objCongTruongList;
    }

    public static CongTruong BuildNewEntCongTruong(ObjCongTruong objCongTruong)
    {
      CongTruong toEnt = new CongTruong();
      CongTruongHelper.CopyToEntCongTruong(objCongTruong, toEnt);
      return toEnt;
    }

    public static IList<CongTruong> BuildListEntCongTruong(IList<ObjCongTruong> lstObjCongTruong)
    {
      IList<CongTruong> congTruongList = (IList<CongTruong>) new List<CongTruong>();
      foreach (ObjCongTruong objCongTruong in (IEnumerable<ObjCongTruong>) lstObjCongTruong)
        congTruongList.Add(CongTruongHelper.BuildNewEntCongTruong(objCongTruong));
      return congTruongList;
    }
  }
}

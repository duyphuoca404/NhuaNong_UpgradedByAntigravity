// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.NhanVienHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class NhanVienHelper
  {
    public static void CopyToObjNhanVien(NhanVien fromEnt, ObjNhanVien toObj)
    {
      toObj.NhanVienID = fromEnt.NhanVienID;
      toObj.MaNhanVien = fromEnt.MaNhanVien;
      toObj.TenNhanVien = fromEnt.TenNhanVien;
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
      if (toObj.NhanVienID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntNhanVien(ObjNhanVien fromObj, NhanVien toEnt)
    {
      toEnt.NhanVienID = fromObj.NhanVienID;
      toEnt.MaNhanVien = fromObj.MaNhanVien;
      toEnt.TenNhanVien = fromObj.TenNhanVien;
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

    public static ObjNhanVien BuildNewObjNhanVien(NhanVien entNhanVien)
    {
      ObjNhanVien toObj = new ObjNhanVien();
      NhanVienHelper.CopyToObjNhanVien(entNhanVien, toObj);
      return toObj;
    }

    public static IList<ObjNhanVien> BuildListObjNhanVien(IList<NhanVien> lstEntNhanVien)
    {
      IList<ObjNhanVien> objNhanVienList = (IList<ObjNhanVien>) new List<ObjNhanVien>();
      foreach (NhanVien entNhanVien in (IEnumerable<NhanVien>) lstEntNhanVien)
        objNhanVienList.Add(NhanVienHelper.BuildNewObjNhanVien(entNhanVien));
      return objNhanVienList;
    }

    public static NhanVien BuildNewEntNhanVien(ObjNhanVien objNhanVien)
    {
      NhanVien toEnt = new NhanVien();
      NhanVienHelper.CopyToEntNhanVien(objNhanVien, toEnt);
      return toEnt;
    }

    public static IList<NhanVien> BuildListEntNhanVien(IList<ObjNhanVien> lstObjNhanVien)
    {
      IList<NhanVien> nhanVienList = (IList<NhanVien>) new List<NhanVien>();
      foreach (ObjNhanVien objNhanVien in (IEnumerable<ObjNhanVien>) lstObjNhanVien)
        nhanVienList.Add(NhanVienHelper.BuildNewEntNhanVien(objNhanVien));
      return nhanVienList;
    }
  }
}

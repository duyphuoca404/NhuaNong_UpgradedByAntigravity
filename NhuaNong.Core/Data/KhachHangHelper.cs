// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.KhachHangHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class KhachHangHelper
  {
    public static void CopyToObjKhachHang(KhachHang fromEnt, ObjKhachHang toObj)
    {
      toObj.KhachHangID = fromEnt.KhachHangID;
      toObj.MaKhachHang = fromEnt.MaKhachHang;
      toObj.TenKhachHang = fromEnt.TenKhachHang;
      toObj.GioiTinh = fromEnt.GioiTinh;
      toObj.DiaChi = fromEnt.DiaChi;
      toObj.Email = fromEnt.Email;
      toObj.Phone = fromEnt.Phone;
      toObj.Fax = fromEnt.Fax;
      toObj.GhiChu = fromEnt.GhiChu;
      toObj.Activated = fromEnt.Activated;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.VersionNo = fromEnt.VersionNo;
      if (toObj.KhachHangID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntKhachHang(ObjKhachHang fromObj, KhachHang toEnt)
    {
      toEnt.KhachHangID = fromObj.KhachHangID;
      toEnt.MaKhachHang = fromObj.MaKhachHang;
      toEnt.TenKhachHang = fromObj.TenKhachHang;
      toEnt.GioiTinh = fromObj.GioiTinh;
      toEnt.DiaChi = fromObj.DiaChi;
      toEnt.Email = fromObj.Email;
      toEnt.Phone = fromObj.Phone;
      toEnt.Fax = fromObj.Fax;
      toEnt.GhiChu = fromObj.GhiChu;
      toEnt.Activated = fromObj.Activated;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.VersionNo = fromObj.VersionNo;
    }

    public static ObjKhachHang BuildNewObjKhachHang(KhachHang entKhachHang)
    {
      ObjKhachHang toObj = new ObjKhachHang();
      KhachHangHelper.CopyToObjKhachHang(entKhachHang, toObj);
      return toObj;
    }

    public static IList<ObjKhachHang> BuildListObjKhachHang(IList<KhachHang> lstEntKhachHang)
    {
      IList<ObjKhachHang> objKhachHangList = (IList<ObjKhachHang>) new List<ObjKhachHang>();
      foreach (KhachHang entKhachHang in (IEnumerable<KhachHang>) lstEntKhachHang)
        objKhachHangList.Add(KhachHangHelper.BuildNewObjKhachHang(entKhachHang));
      return objKhachHangList;
    }

    public static KhachHang BuildNewEntKhachHang(ObjKhachHang objKhachHang)
    {
      KhachHang toEnt = new KhachHang();
      KhachHangHelper.CopyToEntKhachHang(objKhachHang, toEnt);
      return toEnt;
    }

    public static IList<KhachHang> BuildListEntKhachHang(IList<ObjKhachHang> lstObjKhachHang)
    {
      IList<KhachHang> khachHangList = (IList<KhachHang>) new List<KhachHang>();
      foreach (ObjKhachHang objKhachHang in (IEnumerable<ObjKhachHang>) lstObjKhachHang)
        khachHangList.Add(KhachHangHelper.BuildNewEntKhachHang(objKhachHang));
      return khachHangList;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.PhieuGiaoHangHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class PhieuGiaoHangHelper
  {
    public static void CopyToObjPhieuTron(PhieuGiaoHang fromEnt, ObjPhieuGiaoHang toObj)
    {
      toObj.PhieuTronID = fromEnt.PhieuTronID;
      toObj.MaPhieuTron = fromEnt.MaPhieuTron;
      toObj.NgayPhieuTron = fromEnt.NgayPhieuTron;
      toObj.KLDuTinh = fromEnt.KLDuTinh;
      toObj.KLThuc = fromEnt.KLThuc;
      toObj.KLTronNhoNhat = fromEnt.KLTronNhoNhat;
      toObj.KLTronLonNhat = fromEnt.KLTronLonNhat;
      toObj.KLDuTinhCuaTungMe = fromEnt.KLDuTinhCuaTungMe;
      toObj.KLBuTruMeCuoi = fromEnt.KLBuTruMeCuoi;
      toObj.SLMeDuTinh = fromEnt.SLMeDuTinh;
      toObj.SLMeHieuChinh = fromEnt.SLMeHieuChinh;
      toObj.SLMeDaTron = fromEnt.SLMeDaTron;
      toObj.HopDongID = fromEnt.HopDongID;
      toObj.KhachHangID = fromEnt.KhachHangID;
      toObj.TenKhachHang = fromEnt.TenKhachHang;
      toObj.CongTruongID = fromEnt.CongTruongID;
      toObj.TenCongTruong = fromEnt.TenCongTruong;
      toObj.HangMucID = fromEnt.HangMucID;
      toObj.TenHangMuc = fromEnt.TenHangMuc;
      toObj.DiaDiem = fromEnt.DiaDiem;
      toObj.MACID = fromEnt.MACID;
      toObj.TenMAC = fromEnt.TenMAC;
      toObj.CuongDo = fromEnt.CuongDo;
      toObj.DoSut = fromEnt.DoSut;
      toObj.TheTich = fromEnt.TheTich;
      toObj.LuyKe = fromEnt.LuyKe;
      toObj.TaiXeID = fromEnt.TaiXeID;
      toObj.TenTaiXe = fromEnt.TenTaiXe;
      toObj.XeID = fromEnt.XeID;
      toObj.BienSo = fromEnt.BienSo;
      toObj.NiemChi = fromEnt.NiemChi;
      toObj.NguoiTron = fromEnt.NguoiTron;
      toObj.Temp1 = fromEnt.Temp1;
      toObj.Temp2 = fromEnt.Temp2;
      toObj.GioBD = fromEnt.GioBD;
      toObj.GioKT = fromEnt.GioKT;
      toObj.Activated = fromEnt.Activated;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.MaHopDong = fromEnt.MaHopDong;
      toObj.NoPhieu = fromEnt.NoPhieu;
      if (toObj.PhieuTronID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntPhieuTron(ObjPhieuGiaoHang fromObj, PhieuGiaoHang toEnt)
    {
      toEnt.PhieuTronID = fromObj.PhieuTronID;
      toEnt.MaPhieuTron = fromObj.MaPhieuTron;
      toEnt.NgayPhieuTron = fromObj.NgayPhieuTron;
      toEnt.KLDuTinh = fromObj.KLDuTinh;
      toEnt.KLThuc = fromObj.KLThuc;
      toEnt.KLTronNhoNhat = fromObj.KLTronNhoNhat;
      toEnt.KLTronLonNhat = fromObj.KLTronLonNhat;
      toEnt.KLDuTinhCuaTungMe = fromObj.KLDuTinhCuaTungMe;
      toEnt.KLBuTruMeCuoi = fromObj.KLBuTruMeCuoi;
      toEnt.SLMeDuTinh = fromObj.SLMeDuTinh;
      toEnt.SLMeHieuChinh = fromObj.SLMeHieuChinh;
      toEnt.SLMeDaTron = fromObj.SLMeDaTron;
      toEnt.HopDongID = fromObj.HopDongID;
      toEnt.KhachHangID = fromObj.KhachHangID;
      toEnt.TenKhachHang = fromObj.TenKhachHang;
      toEnt.CongTruongID = fromObj.CongTruongID;
      toEnt.TenCongTruong = fromObj.TenCongTruong;
      toEnt.HangMucID = fromObj.HangMucID;
      toEnt.TenHangMuc = fromObj.TenHangMuc;
      toEnt.DiaDiem = fromObj.DiaDiem;
      toEnt.MACID = fromObj.MACID;
      toEnt.TenMAC = fromObj.TenMAC;
      toEnt.CuongDo = fromObj.CuongDo;
      toEnt.DoSut = fromObj.DoSut;
      toEnt.TheTich = fromObj.TheTich;
      toEnt.LuyKe = fromObj.LuyKe;
      toEnt.TaiXeID = fromObj.TaiXeID;
      toEnt.TenTaiXe = fromObj.TenTaiXe;
      toEnt.XeID = fromObj.XeID;
      toEnt.BienSo = fromObj.BienSo;
      toEnt.NiemChi = fromObj.NiemChi;
      toEnt.NguoiTron = fromObj.NguoiTron;
      toEnt.Temp1 = fromObj.Temp1;
      toEnt.Temp2 = fromObj.Temp2;
      toEnt.GioBD = fromObj.GioBD;
      toEnt.GioKT = fromObj.GioKT;
      toEnt.Activated = fromObj.Activated;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.MaHopDong = fromObj.MaHopDong;
      toEnt.NoPhieu = fromObj.NoPhieu;
    }

    public static ObjPhieuGiaoHang BuildNewObjPhieuTron(PhieuGiaoHang entPhieuTron)
    {
      ObjPhieuGiaoHang toObj = new ObjPhieuGiaoHang();
      PhieuGiaoHangHelper.CopyToObjPhieuTron(entPhieuTron, toObj);
      return toObj;
    }

    public static IList<ObjPhieuGiaoHang> BuildListObjPhieuTron(IList<PhieuGiaoHang> lstEntPhieuTron)
    {
      IList<ObjPhieuGiaoHang> objPhieuGiaoHangList = (IList<ObjPhieuGiaoHang>) new List<ObjPhieuGiaoHang>();
      foreach (PhieuGiaoHang entPhieuTron in (IEnumerable<PhieuGiaoHang>) lstEntPhieuTron)
        objPhieuGiaoHangList.Add(PhieuGiaoHangHelper.BuildNewObjPhieuTron(entPhieuTron));
      return objPhieuGiaoHangList;
    }

    public static PhieuGiaoHang BuildNewEntPhieuTron(ObjPhieuGiaoHang objPhieuTron)
    {
      PhieuGiaoHang toEnt = new PhieuGiaoHang();
      PhieuGiaoHangHelper.CopyToEntPhieuTron(objPhieuTron, toEnt);
      return toEnt;
    }

    public static IList<PhieuGiaoHang> BuildListEntPhieuTron(IList<ObjPhieuGiaoHang> lstObjPhieuTron)
    {
      IList<PhieuGiaoHang> phieuGiaoHangList = (IList<PhieuGiaoHang>) new List<PhieuGiaoHang>();
      foreach (ObjPhieuGiaoHang objPhieuTron in (IEnumerable<ObjPhieuGiaoHang>) lstObjPhieuTron)
        phieuGiaoHangList.Add(PhieuGiaoHangHelper.BuildNewEntPhieuTron(objPhieuTron));
      return phieuGiaoHangList;
    }
  }
}

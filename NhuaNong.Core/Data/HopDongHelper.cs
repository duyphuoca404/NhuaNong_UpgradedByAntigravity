// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.HopDongHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace NhuaNong.Data
{
  public class HopDongHelper
  {
    public static string GenMemberValues(ObjHopDong obj)
    {
      return string.Empty + "#1@#HopDongID#2@#" + obj.HopDongID.ToString() + "#1@#MaHopDong#2@#" + obj.MaHopDong + "#1@#TenHopDong#2@#" + obj.TenHopDong + "#1@#NgayHopDong#2@#" + obj.NgayHopDong.ToString() + "#1@#MoTa#2@#" + obj.MoTa + "#1@#KhachHangID#2@#" + obj.KhachHangID.ToString() + "#1@#CongTruongID#2@#" + obj.CongTruongID.ToString() + "#1@#MACID#2@#" + obj.MACID.ToString() + "#1@#DoSut#2@#" + obj.DoSut + "#1@#KLDatHang#2@#" + obj.KLDatHang.ToString() + "#1@#KLDaGiao#2@#" + obj.KLDaGiao.ToString() + "#1@#KLConLai#2@#" + obj.KLConLai.ToString() + "#1@#KLTaoPhieuTron#2@#" + obj.KLTaoPhieuTron.ToString() + "#1@#Status#2@#" + obj.Status.ToString() + "#1@#DLT_KLDuTinh#2@#" + obj.DLT_KLDuTinh.ToString() + "#1@#DLT_KLTronNhoNhat#2@#" + obj.DLT_KLTronNhoNhat.ToString() + "#1@#DLT_KLTronLonNhat#2@#" + obj.DLT_KLTronLonNhat.ToString() + "#1@#DLT_KLDuTinhCuaTungMe#2@#" + obj.DLT_KLDuTinhCuaTungMe.ToString() + "#1@#DLT_KLDuTinhCuaTungMe_NoiB#2@#" + obj.DLT_KLDuTinhCuaTungMe_NoiB.ToString() + "#1@#DLT_KLDuTinhCuaTungMe_NoiB_IsUsed#2@#" + obj.DLT_KLDuTinhCuaTungMe_NoiB_IsUsed.ToString() + "#1@#DLT_KLBuTruMeCuoi#2@#" + obj.DLT_KLBuTruMeCuoi.ToString() + "#1@#DLT_SLMeDuTinh#2@#" + obj.DLT_SLMeDuTinh.ToString() + "#1@#DLT_KLXeChoLonNhat#2@#" + obj.DLT_KLXeChoLonNhat.ToString() + "#1@#DLT_MACSUMSiloValueCalc#2@#" + obj.DLT_MACSUMSiloValueCalc.ToString() + "#1@#DLT_MACSUMSiloValue#2@#" + obj.DLT_MACSUMSiloValue.ToString() + "#1@#CreationDate#2@#" + obj.CreationDate.ToString() + "#1@#CreatedBy#2@#" + obj.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + obj.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + obj.LatestUpdatedBy.ToString() + "#1@#VersionNo#2@#" + obj.VersionNo?.ToString();
    }

    public static string GenMemberValues(HopDong ent)
    {
      return string.Empty + "#1@#HopDongID#2@#" + ent.HopDongID.ToString() + "#1@#MaHopDong#2@#" + ent.MaHopDong + "#1@#TenHopDong#2@#" + ent.TenHopDong + "#1@#NgayHopDong#2@#" + ent.NgayHopDong.ToString() + "#1@#MoTa#2@#" + ent.MoTa + "#1@#KhachHangID#2@#" + ent.KhachHangID.ToString() + "#1@#CongTruongID#2@#" + ent.CongTruongID.ToString() + "#1@#MACID#2@#" + ent.MACID.ToString() + "#1@#DoSut#2@#" + ent.DoSut + "#1@#KLDatHang#2@#" + ent.KLDatHang.ToString() + "#1@#KLDaGiao#2@#" + ent.KLDaGiao.ToString() + "#1@#KLConLai#2@#" + ent.KLConLai.ToString() + "#1@#KLTaoPhieuTron#2@#" + ent.KLTaoPhieuTron.ToString() + "#1@#Status#2@#" + ent.Status.ToString() + "#1@#DLT_KLDuTinh#2@#" + ent.DLT_KLDuTinh.ToString() + "#1@#DLT_KLTronNhoNhat#2@#" + ent.DLT_KLTronNhoNhat.ToString() + "#1@#DLT_KLTronLonNhat#2@#" + ent.DLT_KLTronLonNhat.ToString() + "#1@#DLT_KLDuTinhCuaTungMe#2@#" + ent.DLT_KLDuTinhCuaTungMe.ToString() + "#1@#DLT_KLDuTinhCuaTungMe_NoiB#2@#" + ent.DLT_KLDuTinhCuaTungMe_NoiB.ToString() + "#1@#DLT_KLDuTinhCuaTungMe_NoiB_IsUsed#2@#" + ent.DLT_KLDuTinhCuaTungMe_NoiB_IsUsed.ToString() + "#1@#DLT_KLBuTruMeCuoi#2@#" + ent.DLT_KLBuTruMeCuoi.ToString() + "#1@#DLT_SLMeDuTinh#2@#" + ent.DLT_SLMeDuTinh.ToString() + "#1@#DLT_KLXeChoLonNhat#2@#" + ent.DLT_KLXeChoLonNhat.ToString() + "#1@#DLT_MACSUMSiloValueCalc#2@#" + ent.DLT_MACSUMSiloValueCalc.ToString() + "#1@#DLT_MACSUMSiloValue#2@#" + ent.DLT_MACSUMSiloValue.ToString() + "#1@#CreationDate#2@#" + ent.CreationDate.ToString() + "#1@#CreatedBy#2@#" + ent.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + ent.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + ent.LatestUpdatedBy.ToString() + "#1@#VersionNo#2@#" + ent.VersionNo?.ToString();
    }

    public static void CopyToObjHopDong(HopDong fromEnt, ObjHopDong toObj)
    {
      toObj.HopDongID = fromEnt.HopDongID;
      toObj.MaHopDong = fromEnt.MaHopDong;
      toObj.TenHopDong = fromEnt.TenHopDong;
      toObj.NgayHopDong = fromEnt.NgayHopDong;
      toObj.MoTa = fromEnt.MoTa;
      toObj.KhachHangID = fromEnt.KhachHangID;
      toObj.CongTruongID = fromEnt.CongTruongID;
      toObj.MACID = fromEnt.MACID;
      toObj.HangMucID = fromEnt.HangMucID;
      toObj.DoSut = fromEnt.DoSut;
      toObj.KLDatHang = fromEnt.KLDatHang;
      toObj.KLDaGiao = fromEnt.KLDaGiao;
      toObj.KLConLai = fromEnt.KLConLai;
      toObj.KLTaoPhieuTron = fromEnt.KLTaoPhieuTron;
      toObj.TongPhieu = fromEnt.TongPhieu;
      toObj.Status = fromEnt.Status;
      toObj.DLT_KLDuTinh = fromEnt.DLT_KLDuTinh;
      toObj.DLT_KLTronNhoNhat = fromEnt.DLT_KLTronNhoNhat;
      toObj.DLT_KLTronLonNhat = fromEnt.DLT_KLTronLonNhat;
      toObj.DLT_KLDuTinhCuaTungMe = fromEnt.DLT_KLDuTinhCuaTungMe;
      toObj.DLT_KLDuTinhCuaTungMe_NoiB = fromEnt.DLT_KLDuTinhCuaTungMe_NoiB;
      toObj.DLT_KLDuTinhCuaTungMe_NoiB_IsUsed = fromEnt.DLT_KLDuTinhCuaTungMe_NoiB_IsUsed;
      toObj.DLT_KLBuTruMeCuoi = fromEnt.DLT_KLBuTruMeCuoi;
      toObj.DLT_SLMeDuTinh = fromEnt.DLT_SLMeDuTinh;
      toObj.DLT_KLXeChoLonNhat = fromEnt.DLT_KLXeChoLonNhat;
      toObj.DLT_MACSUMSiloValueCalc = fromEnt.DLT_MACSUMSiloValueCalc;
      toObj.DLT_MACSUMSiloValue = fromEnt.DLT_MACSUMSiloValue;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.VersionNo = fromEnt.VersionNo;
      if (toObj.HopDongID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntHopDong(ObjHopDong fromObj, HopDong toEnt)
    {
      toEnt.HopDongID = fromObj.HopDongID;
      toEnt.MaHopDong = fromObj.MaHopDong;
      toEnt.TenHopDong = fromObj.TenHopDong;
      toEnt.NgayHopDong = fromObj.NgayHopDong;
      toEnt.MoTa = fromObj.MoTa;
      toEnt.KhachHangID = fromObj.KhachHangID;
      toEnt.CongTruongID = fromObj.CongTruongID;
      toEnt.MACID = fromObj.MACID;
      toEnt.HangMucID = fromObj.HangMucID;
      toEnt.DoSut = fromObj.DoSut;
      toEnt.KLDatHang = fromObj.KLDatHang;
      toEnt.KLDaGiao = fromObj.KLDaGiao;
      toEnt.KLConLai = fromObj.KLConLai;
      toEnt.KLTaoPhieuTron = fromObj.KLTaoPhieuTron;
      toEnt.TongPhieu = fromObj.TongPhieu;
      toEnt.Status = fromObj.Status;
      toEnt.DLT_KLDuTinh = fromObj.DLT_KLDuTinh;
      toEnt.DLT_KLTronNhoNhat = fromObj.DLT_KLTronNhoNhat;
      toEnt.DLT_KLTronLonNhat = fromObj.DLT_KLTronLonNhat;
      toEnt.DLT_KLDuTinhCuaTungMe = fromObj.DLT_KLDuTinhCuaTungMe;
      toEnt.DLT_KLDuTinhCuaTungMe_NoiB = fromObj.DLT_KLDuTinhCuaTungMe_NoiB;
      toEnt.DLT_KLDuTinhCuaTungMe_NoiB_IsUsed = fromObj.DLT_KLDuTinhCuaTungMe_NoiB_IsUsed;
      toEnt.DLT_KLBuTruMeCuoi = fromObj.DLT_KLBuTruMeCuoi;
      toEnt.DLT_SLMeDuTinh = fromObj.DLT_SLMeDuTinh;
      toEnt.DLT_KLXeChoLonNhat = fromObj.DLT_KLXeChoLonNhat;
      toEnt.DLT_MACSUMSiloValueCalc = fromObj.DLT_MACSUMSiloValueCalc;
      toEnt.DLT_MACSUMSiloValue = fromObj.DLT_MACSUMSiloValue;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.VersionNo = fromObj.VersionNo;
    }

    public static ObjHopDong BuildNewObjHopDong(HopDong entHopDong)
    {
      ObjHopDong toObj = new ObjHopDong();
      HopDongHelper.CopyToObjHopDong(entHopDong, toObj);
      return toObj;
    }

    public static IList<ObjHopDong> BuildListObjHopDong(IList<HopDong> lstEntHopDong)
    {
      IList<ObjHopDong> objHopDongList = (IList<ObjHopDong>) new List<ObjHopDong>();
      foreach (HopDong entHopDong in (IEnumerable<HopDong>) lstEntHopDong)
        objHopDongList.Add(HopDongHelper.BuildNewObjHopDong(entHopDong));
      return objHopDongList;
    }

    public static HopDong BuildNewEntHopDong(ObjHopDong objHopDong)
    {
      HopDong toEnt = new HopDong();
      HopDongHelper.CopyToEntHopDong(objHopDong, toEnt);
      return toEnt;
    }

    public static IList<HopDong> BuildListEntHopDong(IList<ObjHopDong> lstObjHopDong)
    {
      IList<HopDong> hopDongList = (IList<HopDong>) new List<HopDong>();
      foreach (ObjHopDong objHopDong in (IEnumerable<ObjHopDong>) lstObjHopDong)
        hopDongList.Add(HopDongHelper.BuildNewEntHopDong(objHopDong));
      return hopDongList;
    }

    public static void CopyToDataRowHopDong(ObjHopDong fromObj, DataRow toDataRow)
    {
      toDataRow["HopDongID"] = (object) fromObj.HopDongID;
      toDataRow["MaHopDong"] = (object) fromObj.MaHopDong;
      toDataRow["TenHopDong"] = (object) fromObj.TenHopDong;
      toDataRow["NgayHopDong"] = (object) fromObj.NgayHopDong;
      toDataRow["MoTa"] = (object) fromObj.MoTa;
      toDataRow["KhachHangID"] = (object) fromObj.KhachHangID;
      toDataRow["CongTruongID"] = (object) fromObj.CongTruongID;
      toDataRow["MACID"] = (object) fromObj.MACID;
      toDataRow["DoSut"] = (object) fromObj.DoSut;
      toDataRow["KLDatHang"] = (object) fromObj.KLDatHang;
      toDataRow["KLDaGiao"] = (object) fromObj.KLDaGiao;
      toDataRow["KLConLai"] = (object) fromObj.KLConLai;
      toDataRow["KLTaoPhieuTron"] = (object) fromObj.KLTaoPhieuTron;
      toDataRow["TongPhieu"] = (object) fromObj.TongPhieu;
      toDataRow["Status"] = (object) fromObj.Status;
      toDataRow["DLT_KLDuTinh"] = (object) fromObj.DLT_KLDuTinh;
      toDataRow["DLT_KLTronNhoNhat"] = (object) fromObj.DLT_KLTronNhoNhat;
      toDataRow["DLT_KLTronLonNhat"] = (object) fromObj.DLT_KLTronLonNhat;
      toDataRow["DLT_KLDuTinhCuaTungMe"] = (object) fromObj.DLT_KLDuTinhCuaTungMe;
      toDataRow["DLT_KLDuTinhCuaTungMe_NoiB"] = (object) fromObj.DLT_KLDuTinhCuaTungMe_NoiB;
      toDataRow["DLT_KLDuTinhCuaTungMe_NoiB_IsUsed"] = (object) fromObj.DLT_KLDuTinhCuaTungMe_NoiB_IsUsed;
      toDataRow["DLT_KLBuTruMeCuoi"] = (object) fromObj.DLT_KLBuTruMeCuoi;
      toDataRow["DLT_SLMeDuTinh"] = (object) fromObj.DLT_SLMeDuTinh;
      toDataRow["DLT_KLXeChoLonNhat"] = (object) fromObj.DLT_KLXeChoLonNhat;
      toDataRow["DLT_MACSUMSiloValueCalc"] = (object) fromObj.DLT_MACSUMSiloValueCalc;
      toDataRow["DLT_MACSUMSiloValue"] = (object) fromObj.DLT_MACSUMSiloValue;
      toDataRow["NPKhachHangMaKhachHang"] = (object) fromObj.NPKhachHangMaKhachHang;
      toDataRow["NPKhachHangTenKhachHang"] = (object) fromObj.NPKhachHangTenKhachHang;
      toDataRow["NPCongTruongMaCongTruong"] = (object) fromObj.NPCongTruongMaCongTruong;
      toDataRow["NPCongTruongTenCongTruong"] = (object) fromObj.NPCongTruongTenCongTruong;
      toDataRow["NPMACMaMAC"] = (object) fromObj.NPMACMaMAC;
      toDataRow["NPMACTenMAC"] = (object) fromObj.NPMACTenMAC;
      toDataRow["NPMACThemBotNuoc1"] = (object) fromObj.NPMACThemBotNuoc1;
      toDataRow["NPMACThemBotNuoc2"] = (object) fromObj.NPMACThemBotNuoc2;
    }
  }
}

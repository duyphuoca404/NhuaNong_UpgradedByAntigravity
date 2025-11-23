// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.vw_SumWeightHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class vw_SumWeightHelper
  {
    public static void CopyToObjvw_SumWeight(vw_SumWeight fromEnt, Objvw_SumWeight toObj)
    {
      toObj.PhieuTronID = fromEnt.PhieuTronID;
      toObj.MaPhieuTron = fromEnt.MaPhieuTron;
      toObj.NgayPhieuTron = fromEnt.NgayPhieuTron;
      toObj.Ngay = fromEnt.Ngay;
      toObj.Gio = fromEnt.Gio;
      toObj.KLDuTinh = fromEnt.KLDuTinh;
      toObj.KLThuc = fromEnt.KLThuc;
      toObj.SLMeDuTinh = fromEnt.SLMeDuTinh;
      toObj.KLDuTinhCuaTungMe = fromEnt.KLDuTinhCuaTungMe;
      toObj.KhachHangID = new int?(fromEnt.KH_int);
      toObj.CongTruongID = fromEnt.CT_int;
      toObj.HangMucID = fromEnt.HM_int;
      toObj.MACID = fromEnt.MAC_int;
      toObj.XeID = fromEnt.Xe_int;
      toObj.TaiXeID = fromEnt.TX_int;
      toObj.SUM_Total_Value = fromEnt.SUM_Total_Value;
      toObj.SUM_Total_ValueBat = fromEnt.SUM_Total_ValueBat;
      toObj.SUM_Total_ValueBatMan = fromEnt.SUM_Total_ValueBatMan;
      toObj.IsQueued = fromEnt.IsQueued.Value;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.FullName = fromEnt.FullName;
      toObj.TenKhachHang = fromEnt.KH;
      toObj.TenCongTruong = fromEnt.CT;
      toObj.BienSo = fromEnt.BS;
      toObj.TenMAC = fromEnt.MAC;
      toObj.TenTaiXe = fromEnt.TX;
      toObj.TenHangMuc = fromEnt.HM;
      toObj.TongKhoiLuong = fromEnt.TongKhoiLuong;
      toObj.TongMeTron = fromEnt.TongMeTron;
    }

    public static void CopyToEntvw_SumWeight(Objvw_SumWeight fromObj, vw_SumWeight toEnt)
    {
      toEnt.PhieuTronID = fromObj.PhieuTronID;
      toEnt.MaPhieuTron = fromObj.MaPhieuTron;
      toEnt.NgayPhieuTron = fromObj.NgayPhieuTron;
      toEnt.Ngay = fromObj.Ngay;
      toEnt.Gio = fromObj.Gio;
      toEnt.KLDuTinh = fromObj.KLDuTinh;
      toEnt.KLThuc = fromObj.KLThuc;
      toEnt.SLMeDuTinh = fromObj.SLMeDuTinh;
      toEnt.KLDuTinhCuaTungMe = fromObj.KLDuTinhCuaTungMe;
      toEnt.KH_int = fromObj.KhachHangID.Value;
      toEnt.CT_int = new int?(fromObj.CongTruongID.Value);
      toEnt.HM_int = new int?(fromObj.HangMucID.Value);
      toEnt.MAC_int = new int?(fromObj.MACID.Value);
      toEnt.Xe_int = new int?(fromObj.XeID.Value);
      toEnt.TX_int = new int?(fromObj.TaiXeID.Value);
      toEnt.SUM_Total_Value = fromObj.SUM_Total_Value;
      toEnt.SUM_Total_ValueBat = fromObj.SUM_Total_ValueBat;
      toEnt.SUM_Total_ValueBatMan = fromObj.SUM_Total_ValueBatMan;
      toEnt.IsQueued = new bool?(fromObj.IsQueued);
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.FullName = fromObj.FullName;
      toEnt.KH = fromObj.TenKhachHang;
      toEnt.CT = fromObj.TenCongTruong;
      toEnt.BS = fromObj.BienSo;
      toEnt.MAC = fromObj.TenMAC;
      toEnt.TX = fromObj.TenTaiXe;
      toEnt.HM = fromObj.TenHangMuc;
      toEnt.TongKhoiLuong = fromObj.TongKhoiLuong;
      toEnt.TongMeTron = fromObj.TongMeTron;
    }

    public static Objvw_SumWeight BuildNewObjvw_SumWeight(vw_SumWeight entvw_SumWeight)
    {
      Objvw_SumWeight toObj = new Objvw_SumWeight();
      vw_SumWeightHelper.CopyToObjvw_SumWeight(entvw_SumWeight, toObj);
      return toObj;
    }

    public static IList<Objvw_SumWeight> BuildListObjvw_SumWeight(
      IList<vw_SumWeight> lstEntvw_SumWeight)
    {
      IList<Objvw_SumWeight> objvwSumWeightList = (IList<Objvw_SumWeight>) new List<Objvw_SumWeight>();
      foreach (vw_SumWeight entvw_SumWeight in (IEnumerable<vw_SumWeight>) lstEntvw_SumWeight)
        objvwSumWeightList.Add(vw_SumWeightHelper.BuildNewObjvw_SumWeight(entvw_SumWeight));
      return objvwSumWeightList;
    }

    public static vw_SumWeight BuildNewEntvw_SumWeight(Objvw_SumWeight objvw_SumWeight)
    {
      vw_SumWeight toEnt = new vw_SumWeight();
      vw_SumWeightHelper.CopyToEntvw_SumWeight(objvw_SumWeight, toEnt);
      return toEnt;
    }

    public static IList<vw_SumWeight> BuildListEntvw_SumWeight(
      IList<Objvw_SumWeight> lstObjvw_SumWeight)
    {
      IList<vw_SumWeight> vwSumWeightList = (IList<vw_SumWeight>) new List<vw_SumWeight>();
      foreach (Objvw_SumWeight objvw_SumWeight in (IEnumerable<Objvw_SumWeight>) lstObjvw_SumWeight)
        vwSumWeightList.Add(vw_SumWeightHelper.BuildNewEntvw_SumWeight(objvw_SumWeight));
      return vwSumWeightList;
    }
  }
}

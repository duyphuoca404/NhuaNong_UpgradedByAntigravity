// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportChiTietKhoiLuongBeTongDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using NhuaNong.MasterData;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.Reports
{
  internal class ReportChiTietKhoiLuongBeTongDataPresenter(ISumWeightMngView view) : 
    MasterDataPresenter<ISumWeightMngView>(view)
  {
    public void ListKhachHang()
    {
      this._iView.BLstKhachHang = MasterDataPresenter<ISumWeightMngView>._iMasterDataModel.ListKhachHang();
    }

    public void ListCongTruong()
    {
      this._iView.BLstCongTruong = MasterDataPresenter<ISumWeightMngView>._iMasterDataModel.ListCongTruong();
    }

    public void ListHangMuc()
    {
      this._iView.BLstHangMuc = MasterDataPresenter<ISumWeightMngView>._iMasterDataModel.ListHangMuc();
    }

    public void ListMAC()
    {
      this._iView.BLstMAC = MasterDataPresenter<ISumWeightMngView>._iMasterDataModel.ListMAC();
    }

    public void ListXe()
    {
      this._iView.BLstXe = MasterDataPresenter<ISumWeightMngView>._iMasterDataModel.ListXe();
    }

    public void ListTaiXe()
    {
      this._iView.BLstTaiXe = MasterDataPresenter<ISumWeightMngView>._iMasterDataModel.ListTaiXe();
    }

    public void ListNhanVien()
    {
      this._iView.BLstNhanVien = MasterDataPresenter<ISumWeightMngView>._iMasterDataModel.ListNhanVien();
    }

    public void ListSumWeight_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maPhieuTron,
      int? khachHang,
      int? congTruong,
      int? hangMuc,
      int? mac,
      int? bienSo,
      int? taiXe,
      int? nhanVien,
      bool? moPhong)
    {
      this._iView.BLstSumWeight = MasterDataPresenter<ISumWeightMngView>._iMasterDataModel.ListSumWeight_ByCondition(fromDate, toDate, maPhieuTron, khachHang, congTruong, hangMuc, mac, bienSo, taiXe, nhanVien, moPhong);
    }

    public BindingList<Objvw_SumWeight> ListSumWeight_ByCondition_re(
      DateTime? fromDate,
      DateTime? toDate,
      string maPhieuTron,
      int? khachHang,
      int? congTruong,
      int? hangMuc,
      int? mac,
      int? bienSo,
      int? taiXe,
      int? nhanVien,
      bool? moPhong)
    {
      return MasterDataPresenter<ISumWeightMngView>._iMasterDataModel.ListSumWeight_ByCondition(fromDate, toDate, maPhieuTron, khachHang, congTruong, hangMuc, mac, bienSo, taiXe, nhanVien, moPhong);
    }
  }
}

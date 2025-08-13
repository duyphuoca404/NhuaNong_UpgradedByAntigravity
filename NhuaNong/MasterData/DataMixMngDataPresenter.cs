// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.DataMixMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class DataMixMngDataPresenter(IDataMixMngView view) : MasterDataPresenter<IDataMixMngView>(view)
  {
    public void ListDataMixStatus()
    {
      this._iView.LstDataMixStatus = Converter.EnumToListFieldCode<Enums.DuLieuTronStatus>(true);
    }

    public void ListKhachHang()
    {
      this._iView.BLstKhachHang = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListKhachHang();
    }

    public void ListCongTruong()
    {
      this._iView.BLstCongTruong = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListCongTruong();
    }

    public void ListHangMuc()
    {
      this._iView.BLstHangMuc = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListHangMuc();
    }

    public void ListMAC()
    {
      this._iView.BLstMAC = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListMAC();
    }

    public void ListSilo()
    {
      this._iView.BLstSilo = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListSilo();
    }

    public void ListXe()
    {
      this._iView.BLstXe = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListXe();
    }

    public void ListTaiXe()
    {
      this._iView.BLstTaiXe = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListTaiXe();
    }

    public void ListNhanVien()
    {
      this._iView.BLstNhanVien = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListNhanVien();
    }

    public void ListDataMix()
    {
      this._iView.BLstDataMix = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListDataMix();
    }

    public void ListDataMix_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maPT,
      string khachHang,
      string congTruong,
      string hangMuc,
      string taiXe,
      string bienXe,
      string mac,
      string nhanVIen)
    {
      this._iView.BLstDataMix = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListDataMix_ByCondition(fromDate, toDate, maPT, khachHang, congTruong, hangMuc, taiXe, bienXe, mac, nhanVIen);
    }

    public void ListDataMix_ByCondition(
      DateTime? fromDate,
      TimeSpan? fromTime,
      DateTime? toDate,
      TimeSpan? toTime,
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
      this._iView.BLstDataMix = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListDataMix_ByCondition(fromDate, fromTime, toDate, toTime, maPhieuTron, khachHang, congTruong, hangMuc, mac, bienSo, taiXe, nhanVien, moPhong);
    }

    public BindingList<Objvw_DataMix> ListDataMix_ByCondition_re(
      DateTime? fromDate,
      TimeSpan? fromTime,
      DateTime? toDate,
      TimeSpan? toTime,
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
      return MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListDataMix_ByCondition(fromDate, fromTime, toDate, toTime, maPhieuTron, khachHang, congTruong, hangMuc, mac, bienSo, taiXe, nhanVien, moPhong);
    }
  }
}

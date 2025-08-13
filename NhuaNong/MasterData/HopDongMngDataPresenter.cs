// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.HopDongMngDataPresenter
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
  public class HopDongMngDataPresenter(IHopDongMngView view) : MasterDataPresenter<IHopDongMngView>(view)
  {
    public void ListHopDong()
    {
      this._iView.BLstHopDong = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListHopDong();
    }

    public void ListHopDong(
      string maHopDong,
      DateTime fromDate,
      DateTime toDate,
      int? status,
      int? khachHangID,
      int? congTruongID,
      int? macID)
    {
      this._iView.BLstHopDong = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListHopDong_ByCondition(maHopDong, fromDate, toDate, status, khachHangID, congTruongID, macID);
    }

    public void SaveHopDong(BindingList<ObjHopDong> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.SaveHopDong(blstCT);
    }

    public void ListHopDongStatus()
    {
      this._iView.LstHopDongStatus = Converter.EnumToListFieldCode<Enums.HopDongStatus>(true);
    }

    public void ListKhachHang()
    {
      this._iView.BLstKhachHang = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListKhachHang();
    }

    public void ListKhachHang_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string diaChi,
      string phone,
      bool? active)
    {
      this._iView.BLstKhachHang = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListKhachHang_ByCondition(fromDate, toDate, maKH, tenKH, diaChi, phone, active);
    }

    public void ListCongTruong()
    {
      this._iView.BLstCongTruong = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListCongTruong();
    }

    public void ListCongTruong_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string diaChi,
      string phone,
      bool? active)
    {
      this._iView.BLstCongTruong = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListCongTruong_ByCondition(fromDate, toDate, maKH, tenKH, diaChi, phone, active);
    }

    public void ListMAC()
    {
      this._iView.BLstMAC = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListMAC();
    }
  }
}

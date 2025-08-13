// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.KhachHangMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class KhachHangMngDataPresenter(IKhachHangMngView view) : 
    MasterDataPresenter<IKhachHangMngView>(view)
  {
    public void ListKhachHang()
    {
      this._iView.BLstKhachHang = MasterDataPresenter<IKhachHangMngView>._iMasterDataModel.ListKhachHang();
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
      this._iView.BLstKhachHang = MasterDataPresenter<IKhachHangMngView>._iMasterDataModel.ListKhachHang_ByCondition(fromDate, toDate, maKH, tenKH, diaChi, phone, active);
    }

    public void SaveKhachHang(BindingList<ObjKhachHang> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<IKhachHangMngView>._iMasterDataModel.SaveKhachHang(blstCT);
    }
  }
}

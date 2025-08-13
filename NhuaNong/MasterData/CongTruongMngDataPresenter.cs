// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.CongTruongMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class CongTruongMngDataPresenter(ICongTruongMngView view) : 
    MasterDataPresenter<ICongTruongMngView>(view)
  {
    public void ListCongTruong()
    {
      this._iView.BLstCongTruong = MasterDataPresenter<ICongTruongMngView>._iMasterDataModel.ListCongTruong();
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
      this._iView.BLstCongTruong = MasterDataPresenter<ICongTruongMngView>._iMasterDataModel.ListCongTruong_ByCondition(fromDate, toDate, maKH, tenKH, diaChi, phone, active);
    }

    public void SaveCongTruong(BindingList<ObjCongTruong> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<ICongTruongMngView>._iMasterDataModel.SaveCongTruong(blstCT);
    }
  }
}

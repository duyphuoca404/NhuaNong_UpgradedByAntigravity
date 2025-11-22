// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.HangMucMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  internal class HangMucMngDataPresenter(IHangMucMngView view) : MasterDataPresenter<IHangMucMngView>(view)
  {
    public void ListHangMuc()
    {
      this._iView.BLstHangMuc = MasterDataPresenter<IHangMucMngView>._iMasterDataModel.ListHangMuc();
    }

    public void ListHangMuc_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      bool? active)
    {
      this._iView.BLstHangMuc = MasterDataPresenter<IHangMucMngView>._iMasterDataModel.ListHangMuc_ByCondition(fromDate, toDate, maKH, tenKH, active);
    }

    public void SaveHangMuc(BindingList<ObjHangMuc> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<IHangMucMngView>._iMasterDataModel.SaveHangMuc(blstCT);
    }
  }
}

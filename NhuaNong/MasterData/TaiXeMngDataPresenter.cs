// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.TaiXeMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class TaiXeMngDataPresenter(ITaiXeMngView view) : MasterDataPresenter<ITaiXeMngView>(view)
  {
    public void ListTaiXe()
    {
      this._iView.BLstTaiXe = MasterDataPresenter<ITaiXeMngView>._iMasterDataModel.ListTaiXe();
    }

    public void ListTaiXe_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string phone,
      bool? active)
    {
      this._iView.BLstTaiXe = MasterDataPresenter<ITaiXeMngView>._iMasterDataModel.ListTaiXe_ByCondition(fromDate, toDate, maKH, tenKH, phone, active);
    }

    public void SaveTaiXe(BindingList<ObjTaiXe> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<ITaiXeMngView>._iMasterDataModel.SaveTaiXe(blstCT);
    }
  }
}

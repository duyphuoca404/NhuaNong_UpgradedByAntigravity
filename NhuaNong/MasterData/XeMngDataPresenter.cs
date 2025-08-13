// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.XeMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class XeMngDataPresenter(IXeMngView view) : MasterDataPresenter<IXeMngView>(view)
  {
    public void ListXe()
    {
      this._iView.BLstXe = MasterDataPresenter<IXeMngView>._iMasterDataModel.ListXe();
    }

    public void ListXe_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string bienSo,
      bool? active)
    {
      this._iView.BLstXe = MasterDataPresenter<IXeMngView>._iMasterDataModel.ListXe_ByCondition(fromDate, toDate, bienSo, active);
    }

    public void SaveXe(BindingList<ObjXe> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<IXeMngView>._iMasterDataModel.SaveXe(blstCT);
    }
  }
}

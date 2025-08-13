// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.MACMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class MACMngDataPresenter(IMACMngView view) : MasterDataPresenter<IMACMngView>(view)
  {
    public void ListMAC()
    {
      this._iView.BLstMAC = MasterDataPresenter<IMACMngView>._iMasterDataModel.ListMAC();
    }

    public void ListMAC_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maMAC,
      string tenMAC,
      bool? active)
    {
      this._iView.BLstMAC = MasterDataPresenter<IMACMngView>._iMasterDataModel.ListMAC_ByCondition(fromDate, toDate, maMAC, tenMAC, active);
    }

    public void SaveMAC(BindingList<ObjMAC> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<IMACMngView>._iMasterDataModel.SaveMAC(blstCT);
    }
  }
}

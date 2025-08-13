// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.SiloDoAmMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class SiloDoAmMngDataPresenter(ISiloDoAmMngView view) : 
    MasterDataPresenter<ISiloDoAmMngView>(view)
  {
    public void ListSiloDoAm()
    {
      this._iView.BLstSiloDoAm = MasterDataPresenter<ISiloDoAmMngView>._iMasterDataModel.ListSilo_ByActivated_ByMaNhomSilo(new bool?(true), "Agg");
    }

    public void SaveSiloDoAm(BindingList<ObjSilo> blstSilo)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<ISiloDoAmMngView>._iMasterDataModel.SaveSilo(blstSilo);
    }
  }
}

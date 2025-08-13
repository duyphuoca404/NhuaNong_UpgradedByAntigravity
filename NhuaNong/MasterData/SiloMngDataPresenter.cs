// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.SiloMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class SiloMngDataPresenter(ISiloMngView view) : MasterDataPresenter<ISiloMngView>(view)
  {
    public void ListSilo()
    {
      this._iView.BLstSilo = MasterDataPresenter<ISiloMngView>._iMasterDataModel.ListSilo_ByActivated(true);
    }

    public void ListNhomSilo()
    {
      this._iView.BLstNhomSilo = MasterDataPresenter<ISiloMngView>._iMasterDataModel.ListNhomSilo();
    }

    public void SaveSilo(BindingList<ObjSilo> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<ISiloMngView>._iMasterDataModel.SaveSilo(blstCT);
    }
  }
}

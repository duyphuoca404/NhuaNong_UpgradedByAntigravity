// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.ConfigUIMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  internal class ConfigUIMngDataPresenter(IConfigUIMngView view) : 
    MasterDataPresenter<IConfigUIMngView>(view)
  {
    public void ListSilo_ByActivated_Agg(bool? isActived)
    {
      this._iView.BLstSilo_Agg = MasterDataPresenter<IConfigUIMngView>._iMasterDataModel.ListSilo_ByActivated_ByMaNhomSilo(isActived, "Agg");
    }

    public void ListSilo_ByActivated_Ce(bool? isActived)
    {
      this._iView.BLstSilo_Ce = MasterDataPresenter<IConfigUIMngView>._iMasterDataModel.ListSilo_ByActivated_ByMaNhomSilo(isActived, "Ce");
    }

    public void ListSilo_ByActivated_Wa(bool? isActived)
    {
      this._iView.BLstSilo_Wa = MasterDataPresenter<IConfigUIMngView>._iMasterDataModel.ListSilo_ByActivated_ByMaNhomSilo(isActived, "Wa");
    }

    public void ListSilo_ByActivated_Add(bool? isActived)
    {
      this._iView.BLstSilo_Add = MasterDataPresenter<IConfigUIMngView>._iMasterDataModel.ListSilo_ByActivated_ByMaNhomSilo(isActived, "Add");
    }

    public void SaveSilo(BindingList<ObjSilo> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<ISiloMngView>._iMasterDataModel.SaveSilo(blstCT);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewWeightDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  internal class NewWeightDataPresenter(INewWeightView view) : MasterDataPresenter<INewWeightView>(view)
  {
    public void GetWeiByKey(int soID)
    {
      this._iView.Weight = MasterDataPresenter<INewWeightView>._iMasterDataModel.GetWeighByKey(soID);
    }

    public void SaveWei(BindingList<ObjWeigh> btstWei)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewWeightView>._iMasterDataModel.SaveWeigh(btstWei);
    }
  }
}

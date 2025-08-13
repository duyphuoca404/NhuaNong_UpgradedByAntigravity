// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewMACDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewMACDataPresenter(INewMACView view) : MasterDataPresenter<INewMACView>(view)
  {
    public void BuildNewMAC()
    {
      this._iView.MAC = new ObjMAC()
      {
        MaMAC = MasterDataPresenter<INewMACView>._iMasterDataModel.GetNextCode("MAC"),
        TenMAC = string.Empty,
        Activated = true
      };
    }

    public void GetMACByKey(int soID)
    {
      this._iView.MAC = MasterDataPresenter<INewMACView>._iMasterDataModel.GetMACByKey(soID);
    }

    public void SaveMAC(BindingList<ObjMAC> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewMACView>._iMasterDataModel.SaveMAC(blstCT);
    }

    public void ListSilo_ByActivated(bool activated)
    {
      this._iView.BLstSilo = MasterDataPresenter<INewMACView>._iMasterDataModel.ListSilo_ByActivated(activated);
    }

    public void ListMACSilo_ByMACID(int macID)
    {
      this._iView.BLstMACSilo = MasterDataPresenter<INewMACView>._iMasterDataModel.ListMACSilo_ByMACID(macID);
    }
  }
}

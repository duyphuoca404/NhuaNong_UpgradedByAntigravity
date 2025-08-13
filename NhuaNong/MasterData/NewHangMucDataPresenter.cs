// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewHangMucDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  internal class NewHangMucDataPresenter(INewHangMucView view) : MasterDataPresenter<INewHangMucView>(view)
  {
    public void BuildNewHangMuc()
    {
      this._iView.HangMuc = new ObjHangMuc()
      {
        MaHangMuc = MasterDataPresenter<INewHangMucView>._iMasterDataModel.GetNextCode("HangMuc"),
        Activated = true
      };
    }

    public void GetHangMucByKey(int soID)
    {
      this._iView.HangMuc = MasterDataPresenter<INewHangMucView>._iMasterDataModel.GetHangMucByKey(soID);
    }

    public void SaveHangMuc(BindingList<ObjHangMuc> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewHangMucView>._iMasterDataModel.SaveHangMuc(blstCT);
    }
  }
}

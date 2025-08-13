// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewTaiXeDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewTaiXeDataPresenter(INewTaiXeView view) : MasterDataPresenter<INewTaiXeView>(view)
  {
    public void BuildNewTaiXe()
    {
      this._iView.TaiXe = new ObjTaiXe()
      {
        MaTaiXe = MasterDataPresenter<INewTaiXeView>._iMasterDataModel.GetNextCode("TaiXe"),
        GioiTinh = "M",
        Activated = true
      };
    }

    public void GetTaiXeByKey(int soID)
    {
      this._iView.TaiXe = MasterDataPresenter<INewTaiXeView>._iMasterDataModel.GetTaiXeByKey(soID);
    }

    public void SaveTaiXe(BindingList<ObjTaiXe> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewTaiXeView>._iMasterDataModel.SaveTaiXe(blstCT);
    }
  }
}

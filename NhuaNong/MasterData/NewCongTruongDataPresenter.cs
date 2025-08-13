// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewCongTruongDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewCongTruongDataPresenter(INewCongTruongView view) : 
    MasterDataPresenter<INewCongTruongView>(view)
  {
    public void BuildNewCongTruong()
    {
      this._iView.CongTruong = new ObjCongTruong()
      {
        MaCongTruong = MasterDataPresenter<INewCongTruongView>._iMasterDataModel.GetNextCode("CongTruong"),
        TenCongTruong = string.Empty,
        DiaChi = string.Empty,
        Phone = string.Empty,
        GhiChu = string.Empty,
        Activated = true
      };
    }

    public void GetCongTruongByKey(int soID)
    {
      this._iView.CongTruong = MasterDataPresenter<INewCongTruongView>._iMasterDataModel.GetCongTruongByKey(soID);
    }

    public void SaveCongTruong(BindingList<ObjCongTruong> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewCongTruongView>._iMasterDataModel.SaveCongTruong(blstCT);
    }
  }
}

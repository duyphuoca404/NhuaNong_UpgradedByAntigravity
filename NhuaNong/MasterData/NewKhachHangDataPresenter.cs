// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewKhachHangDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewKhachHangDataPresenter(INewKhachHangView view) : 
    MasterDataPresenter<INewKhachHangView>(view)
  {
    public void BuildNewKhachHang()
    {
      this._iView.KhachHang = new ObjKhachHang()
      {
        MaKhachHang = MasterDataPresenter<INewKhachHangView>._iMasterDataModel.GetNextCode("KhachHang"),
        TenKhachHang = string.Empty,
        Activated = true
      };
    }

    public void GetKhachHangByKey(int soID)
    {
      this._iView.KhachHang = MasterDataPresenter<INewKhachHangView>._iMasterDataModel.GetKhachHangByKey(soID);
    }

    public void SaveKhachHang(BindingList<ObjKhachHang> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewKhachHangView>._iMasterDataModel.SaveKhachHang(blstCT);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewNhanVienDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  internal class NewNhanVienDataPresenter(INewNhanVienView view) : 
    MasterDataPresenter<INewNhanVienView>(view)
  {
    public void BuildNewNhanVien()
    {
      this._iView.NhanVien = new ObjNhanVien()
      {
        MaNhanVien = MasterDataPresenter<INewNhanVienView>._iMasterDataModel.GetNextCode("NhanVien"),
        GioiTinh = "M",
        Activated = true
      };
    }

    public void GetNhanVienByKey(int soID)
    {
      this._iView.NhanVien = MasterDataPresenter<INewNhanVienView>._iMasterDataModel.GetNhanVienByKey(soID);
    }

    public void SaveNhanVien(BindingList<ObjNhanVien> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewNhanVienView>._iMasterDataModel.SaveNhanVien(blstCT);
    }
  }
}

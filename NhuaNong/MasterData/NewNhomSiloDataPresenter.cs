// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewNhomSiloDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewNhomSiloDataPresenter(INewNhomSiloView view) : 
    MasterDataPresenter<INewNhomSiloView>(view)
  {
    public void BuildNewNhomSilo()
    {
      this._iView.NhomSilo = new ObjNhomSilo()
      {
        MaNhomSilo = string.Empty,
        TenNhomSilo = string.Empty
      };
    }

    public void GetNhomSiloByKey(int soID)
    {
      this._iView.NhomSilo = MasterDataPresenter<INewNhomSiloView>._iMasterDataModel.GetNhomSiloByKey(soID);
    }

    public void SaveNhomSilo(BindingList<ObjNhomSilo> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewNhomSiloView>._iMasterDataModel.SaveNhomSilo(blstCT);
    }
  }
}

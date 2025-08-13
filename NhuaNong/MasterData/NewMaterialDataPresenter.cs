// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewMaterialDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewMaterialDataPresenter(INewMaterialView view) : 
    MasterDataPresenter<INewMaterialView>(view)
  {
    public void BuildNewMaterial()
    {
      this._iView.Material = new ObjMaterial()
      {
        MaterialCode = MasterDataPresenter<INewMaterialView>._iMasterDataModel.GetNextCode("Material"),
        MaterialName = string.Empty,
        Activated = true
      };
    }

    public void GetMaterialByKey(int soID)
    {
      this._iView.Material = MasterDataPresenter<INewMaterialView>._iMasterDataModel.GetMaterialByKey(soID);
    }

    public void SaveMaterial(BindingList<ObjMaterial> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewMaterialView>._iMasterDataModel.SaveMaterial(blstCT);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.MaterialMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class MaterialMngDataPresenter(IMaterialMngView view) : 
    MasterDataPresenter<IMaterialMngView>(view)
  {
    public void ListMaterial()
    {
      this._iView.BLstMaterial = MasterDataPresenter<IMaterialMngView>._iMasterDataModel.ListMaterial();
    }

    public void ListMaterial_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maVT,
      string tenVT,
      bool? active)
    {
      this._iView.BLstMaterial = MasterDataPresenter<IMaterialMngView>._iMasterDataModel.ListMaterial_ByCondition(fromDate, toDate, maVT, tenVT, active);
    }

    public void SaveMaterial(BindingList<ObjMaterial> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<IMaterialMngView>._iMasterDataModel.SaveMaterial(blstCT);
    }
  }
}

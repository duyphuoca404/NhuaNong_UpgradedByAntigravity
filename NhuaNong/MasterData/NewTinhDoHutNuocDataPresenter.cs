// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewTinhDoHutNuocDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewTinhDoHutNuocDataPresenter(INewTinhDoHutNuocView view) : 
    MasterDataPresenter<INewTinhDoHutNuocView>(view)
  {
    public void BuildNewTinhDoHutNuoc()
    {
      this._iView.TinhDoHutNuoc = new ObjTinhDoHutNuoc()
      {
        NgayTinhDoHut = DateTime.Now,
        MaTinhDoHutNuoc = MasterDataPresenter<INewTinhDoHutNuocView>._iMasterDataModel.GetNextCode("TinhDoHutNuoc"),
        BLstTinhDoHutNuocChiTiet = new BindingList<ObjTinhDoHutNuocChiTiet>()
      };
    }

    public void GetTinhDoHutNuocByKey(int soID)
    {
      this._iView.TinhDoHutNuoc = MasterDataPresenter<INewTinhDoHutNuocView>._iMasterDataModel.GetTinhDoHutNuocByKey(soID);
    }

    public void SaveTinhDoHutNuoc(BindingList<ObjTinhDoHutNuoc> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewTinhDoHutNuocView>._iMasterDataModel.SaveTinhDoHutNuoc(blstCT);
    }

    public void ListNhomSilo()
    {
      this._iView.BLstNhomSilo = MasterDataPresenter<INewTinhDoHutNuocView>._iMasterDataModel.ListNhomSilo();
    }
  }
}

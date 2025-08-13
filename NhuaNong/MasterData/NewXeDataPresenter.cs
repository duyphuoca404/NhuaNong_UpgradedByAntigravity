// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewXeDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewXeDataPresenter(INewXeView view) : MasterDataPresenter<INewXeView>(view)
  {
    public void BuildNewXe()
    {
      this._iView.Xe = new ObjXe()
      {
        BienSo = string.Empty,
        KhoiLuong = new Decimal?(0M),
        GhiChu = string.Empty,
        Activated = true
      };
    }

    public void GetXeByKey(int soID)
    {
      this._iView.Xe = MasterDataPresenter<INewXeView>._iMasterDataModel.GetXeByKey(soID);
    }

    public void SaveXe(BindingList<ObjXe> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewXeView>._iMasterDataModel.SaveXe(blstCT);
    }
  }
}

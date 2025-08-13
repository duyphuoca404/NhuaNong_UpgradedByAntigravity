// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NhanVienMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  internal class NhanVienMngDataPresenter(INhanVienMngView view) : 
    MasterDataPresenter<INhanVienMngView>(view)
  {
    public void ListNhanVien()
    {
      this._iView.BLstNhanVien = MasterDataPresenter<INhanVienMngView>._iMasterDataModel.ListNhanVien();
    }

    public void ListNhanVien_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string phone,
      bool? active)
    {
      this._iView.BLstNhanVien = MasterDataPresenter<INhanVienMngView>._iMasterDataModel.ListNhanVien_ByCondition(fromDate, toDate, maKH, tenKH, phone, active);
    }

    public void SaveNhanVien(BindingList<ObjNhanVien> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INhanVienMngView>._iMasterDataModel.SaveNhanVien(blstCT);
    }
  }
}

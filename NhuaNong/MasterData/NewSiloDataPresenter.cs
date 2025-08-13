// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewSiloDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewSiloDataPresenter(INewSiloView view) : MasterDataPresenter<INewSiloView>(view)
  {
    public void BuildNewSilo()
    {
      this._iView.Silo = new ObjSilo()
      {
        MaSilo = string.Empty,
        TenSilo = string.Empty,
        NhomSiloID = 0,
        MaterialID = new int?(),
        SaiSoDuoi = new Decimal?(0M),
        SaiSoTren = new Decimal?(0M),
        KLCanNhoNhat = new Decimal?(0M),
        KLCanLonNhat = new Decimal?(0M),
        TGNhapNhaOn = new Decimal?(0M),
        TGNhapNhaOff = new Decimal?(0M),
        TGKiemTraVatLieuRoi = new Decimal?(0M),
        KLRoi = new Decimal?(0M),
        KLDT_Tu1 = new Decimal?(0M),
        KLDT_Tu2 = new Decimal?(0M),
        KLDT_Tu3 = new Decimal?(0M),
        KLDT_Den1 = new Decimal?(0M),
        KLDT_Den2 = new Decimal?(0M),
        KLDT_Den3 = new Decimal?(0M),
        KLDT_DungTruoc1 = new Decimal?(0M),
        KLDT_DungTruoc2 = new Decimal?(0M),
        KLDT_DungTruoc3 = new Decimal?(0M),
        Activated = new bool?(true)
      };
    }

    public void GetSiloByKey(int soID)
    {
      this._iView.Silo = MasterDataPresenter<INewSiloView>._iMasterDataModel.GetSiloByKey(soID);
    }

    public void ListNhomSilo()
    {
      this._iView.BLstNhomSilo = MasterDataPresenter<INewSiloView>._iMasterDataModel.ListNhomSilo();
    }

    public void ListMaterial()
    {
      this._iView.BLstMaterial = MasterDataPresenter<INewSiloView>._iMasterDataModel.ListMaterial();
    }

    public void ListSiloNhomAgg()
    {
      this._iView.BLstSiloNhomAgg = MasterDataPresenter<INewSiloView>._iMasterDataModel.ListSilo_ByActivated_ByMaNhomSilo(new bool?(true), "Agg");
    }

    public void SaveSilo(BindingList<ObjSilo> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<INewSiloView>._iMasterDataModel.SaveSilo(blstCT);
    }
  }
}

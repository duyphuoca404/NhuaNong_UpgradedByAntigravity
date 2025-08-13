// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.PhieuTronMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class PhieuTronMngDataPresenter(IPhieuTronMngView view) : 
    MasterDataPresenter<IPhieuTronMngView>(view)
  {
    public void ListPhieuTron()
    {
      this._iView.BLstPhieuTron = MasterDataPresenter<IPhieuTronMngView>._iMasterDataModel.ListPhieuTron();
    }

    public void ListPhieuGiaoHang()
    {
      this._iView.BLstPhieuGiaoHang = MasterDataPresenter<IPhieuTronMngView>._iMasterDataModel.ListPhieuGiaoHang();
    }

    public void ListPhieuTron(
      string maPhieuTron,
      DateTime fromDate,
      DateTime toDate,
      int? status,
      bool? isQueued)
    {
      this._iView.BLstPhieuTron = MasterDataPresenter<IPhieuTronMngView>._iMasterDataModel.ListPhieuTron_ByCondition(maPhieuTron, fromDate, toDate, status, isQueued);
    }

    public void ListPhieuGiaoHang(
      string maPhieuTron,
      DateTime fromDate,
      DateTime toDate,
      bool? isQueued)
    {
      this._iView.BLstPhieuGiaoHang = MasterDataPresenter<IPhieuTronMngView>._iMasterDataModel.ListPhieuGiaoHang_ByCondition(maPhieuTron, fromDate, toDate, isQueued);
    }

    public void SavePhieuTron(BindingList<ObjPhieuTron> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<IPhieuTronMngView>._iMasterDataModel.SavePhieuTron(blstCT);
    }

    public void SavePhieuGiaoHang(BindingList<ObjPhieuGiaoHang> blstCT)
    {
      this._iView.IsSuccessfulSaved = MasterDataPresenter<IPhieuTronMngView>._iMasterDataModel.SavePhieuGiaoHang(blstCT);
    }

    public void ListPhieuTronStatus()
    {
      this._iView.LstPhieuTronStatus = Converter.EnumToListFieldCode<Enums.PhieuTronStatus>(true);
    }

    public void ListHopDong()
    {
      this._iView.BLstHopDong = MasterDataPresenter<IPhieuTronMngView>._iMasterDataModel.ListHopDong();
    }

    public ObjPhieuTron GetPhieuTronByKey(int ptID)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetPhieuTronByKey(ptID);
    }

    public ObjPhieuGiaoHang GetPhieuGiaoHangByKey(int ptID)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetPhieuGiaoHangByKey(ptID);
    }

    public ObjPhieuGiaoHang GetPhieuGiaoHangByCode(string ptID)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetPhieuGiaoHangByCode(ptID);
    }

    public ObjKhachHang GetKhachHangByKey(int khID)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetKhachHangByKey(khID);
    }

    public ObjCongTruong GetCongTruongByKey(int ctID)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetCongTruongByKey(ctID);
    }

    public ObjMAC GetMACByKey(int macID)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetMACByKey(macID);
    }

    public ObjTaiXe GetTaiXeByKey(int txID)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetTaiXeByKey(txID);
    }

    public ObjXe GetXeByKey(int xeID)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetXeByKey(xeID);
    }

    public void ListMeTron(int ptID)
    {
      this._iView.BLstMeTron = MasterDataPresenter<INewPhieuTronView>._iMasterDataModel.ListMeTronByPhieuTronID(ptID);
    }

    public void ListMeTronChiTiet(int ptID)
    {
      this._iView.BLstMeTronChiTiet = MasterDataPresenter<INewPhieuTronView>._iMasterDataModel.ListMeTronChiTietByPhieuTronID(ptID);
    }

    public ObjHopDong GetHopDongByKey(int hdID)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetHopDongByKey(hdID);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.TronOnlineDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.MasterData
{
  public class TronOnlineDataPresenter(INNView view) : MasterDataPresenter<INNView>(view)
  {
    public ObjDuLieuTron GetDLTByKey(int id)
    {
      return MasterDataPresenter<INNView>._iMasterDataModel.GetDuLieuTronByKey(id);
    }

    public ObjHopDong GetHopDongByKey(int hdID)
    {
      return MasterDataPresenter<INNView>._iMasterDataModel.GetHopDongByKey(hdID);
    }

    public ObjPhieuTron CreateAndSaveNewPhieuTron(ObjHopDong objHD, bool isManual)
    {
      ObjPhieuTron saveNewPhieuTron = new ObjPhieuTron();
      saveNewPhieuTron.MaPhieuTron = MasterDataPresenter<INNView>._iMasterDataModel.GetNextCode("PhieuTron");
      saveNewPhieuTron.Status = new int?(3);
      saveNewPhieuTron.HopDongID = new int?(objHD.HopDongID);
      saveNewPhieuTron.KhachHangID = objHD.KhachHangID;
      saveNewPhieuTron.CongTruongID = objHD.CongTruongID;
      saveNewPhieuTron.MACID = objHD.MACID;
      saveNewPhieuTron.HangMucID = objHD.HangMucID;
      saveNewPhieuTron.NgayPhieuTron = new DateTime?(DateTime.Now);
      saveNewPhieuTron.KLDuTinh = objHD.DLT_KLDuTinh;
      saveNewPhieuTron.MinKLTron = objHD.DLT_KLTronNhoNhat;
      saveNewPhieuTron.MaxKLTron = objHD.DLT_KLTronLonNhat;
      saveNewPhieuTron.SLMeDuTinh = objHD.DLT_SLMeDuTinh;
      saveNewPhieuTron.KLDuTinhCuaTungMe = objHD.DLT_KLDuTinhCuaTungMe;
      saveNewPhieuTron.KLBuTruMeCuoi = objHD.DLT_KLBuTruMeCuoi;
      ObjPhieuTron objPhieuTron1 = saveNewPhieuTron;
      Decimal? klDaGiao = objHD.KLDaGiao;
      Decimal? dltKlDuTinh = objHD.DLT_KLDuTinh;
      Decimal? nullable1 = klDaGiao.HasValue & dltKlDuTinh.HasValue ? new Decimal?(klDaGiao.GetValueOrDefault() + dltKlDuTinh.GetValueOrDefault()) : new Decimal?();
      objPhieuTron1.SLMeHieuChinh = nullable1;
      saveNewPhieuTron.IsQueued = new bool?(isManual);
      saveNewPhieuTron.CreatedBy = new int?(GlobalValues.UserID);
      saveNewPhieuTron.CreationDate = new DateTime?(DateTime.Now);
      int? tongPhieu1 = objHD.TongPhieu;
      int num = 0;
      if (tongPhieu1.GetValueOrDefault() == num & tongPhieu1.HasValue)
      {
        saveNewPhieuTron.NoPhieu = new int?(1);
      }
      else
      {
        ObjPhieuTron objPhieuTron2 = saveNewPhieuTron;
        int? tongPhieu2 = objHD.TongPhieu;
        int? nullable2 = tongPhieu2.HasValue ? new int?(tongPhieu2.GetValueOrDefault() + 1) : new int?();
        objPhieuTron2.NoPhieu = nullable2;
      }
      BindingList<ObjPhieuTron> blstCT = new BindingList<ObjPhieuTron>();
      blstCT.Add(saveNewPhieuTron);
      if (MasterDataPresenter<INNView>._iMasterDataModel.SavePhieuTron(blstCT))
        saveNewPhieuTron = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetPhieuTronByCode(saveNewPhieuTron.MaPhieuTron);
      return saveNewPhieuTron;
    }

    public ObjPhieuGiaoHang CreateAndSaveNewPhieuGiaoHang(
      ObjHopDong objHD,
      bool isManual,
      string TenKH,
      string TenCT,
      string TenMAC,
      string TenHM,
      string DiaDiem,
      string CuongDo,
      string DoSut,
      Decimal KLThuc)
    {
      ObjPhieuGiaoHang newPhieuGiaoHang = new ObjPhieuGiaoHang();
      newPhieuGiaoHang.MaPhieuTron = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetNextCode("PhieuGiaoHang");
      newPhieuGiaoHang.MaHopDong = objHD.MaHopDong;
      newPhieuGiaoHang.HopDongID = new int?(objHD.HopDongID);
      newPhieuGiaoHang.KhachHangID = objHD.KhachHangID;
      newPhieuGiaoHang.TenKhachHang = TenKH;
      newPhieuGiaoHang.CongTruongID = objHD.CongTruongID;
      newPhieuGiaoHang.TenCongTruong = TenCT;
      newPhieuGiaoHang.DiaDiem = DiaDiem;
      newPhieuGiaoHang.MACID = objHD.MACID;
      newPhieuGiaoHang.TenMAC = TenMAC;
      newPhieuGiaoHang.CuongDo = CuongDo;
      newPhieuGiaoHang.DoSut = DoSut;
      newPhieuGiaoHang.HangMucID = objHD.HangMucID;
      newPhieuGiaoHang.TenHangMuc = TenHM;
      newPhieuGiaoHang.NgayPhieuTron = new DateTime?(DateTime.Now);
      newPhieuGiaoHang.KLThuc = new Decimal?(KLThuc);
      newPhieuGiaoHang.KLDuTinh = objHD.DLT_KLDuTinh;
      newPhieuGiaoHang.KLTronNhoNhat = objHD.DLT_KLTronNhoNhat;
      newPhieuGiaoHang.KLTronLonNhat = objHD.DLT_KLTronLonNhat;
      newPhieuGiaoHang.SLMeDuTinh = objHD.DLT_SLMeDuTinh;
      newPhieuGiaoHang.KLDuTinhCuaTungMe = objHD.DLT_KLDuTinhCuaTungMe;
      newPhieuGiaoHang.KLBuTruMeCuoi = objHD.DLT_KLBuTruMeCuoi;
      ObjPhieuGiaoHang objPhieuGiaoHang1 = newPhieuGiaoHang;
      Decimal? klDaGiao = objHD.KLDaGiao;
      Decimal? nullable1 = objHD.DLT_KLDuTinh;
      Decimal? nullable2 = klDaGiao.HasValue & nullable1.HasValue ? new Decimal?(klDaGiao.GetValueOrDefault() + nullable1.GetValueOrDefault()) : new Decimal?();
      objPhieuGiaoHang1.SLMeHieuChinh = nullable2;
      newPhieuGiaoHang.CreatedBy = new int?(GlobalValues.UserID);
      newPhieuGiaoHang.CreationDate = new DateTime?(DateTime.Now);
      newPhieuGiaoHang.Activated = new bool?(isManual);
      newPhieuGiaoHang.Temp1 = "N/A";
      ObjPhieuGiaoHang objPhieuGiaoHang2 = newPhieuGiaoHang;
      nullable1 = objHD.KLDatHang;
      string str = nullable1.ToString();
      objPhieuGiaoHang2.Temp2 = str;
      int? tongPhieu = objHD.TongPhieu;
      int num = 0;
      if (tongPhieu.GetValueOrDefault() == num & tongPhieu.HasValue)
      {
        newPhieuGiaoHang.NoPhieu = new int?(1);
      }
      else
      {
        ObjPhieuGiaoHang objPhieuGiaoHang3 = newPhieuGiaoHang;
        tongPhieu = objHD.TongPhieu;
        int? nullable3 = tongPhieu.HasValue ? new int?(tongPhieu.GetValueOrDefault() + 1) : new int?();
        objPhieuGiaoHang3.NoPhieu = nullable3;
      }
      BindingList<ObjPhieuGiaoHang> blstCT = new BindingList<ObjPhieuGiaoHang>();
      blstCT.Add(newPhieuGiaoHang);
      if (MasterDataPresenter<ITronOnlineView>._iMasterDataModel.SavePhieuGiaoHang(blstCT))
        newPhieuGiaoHang = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetPhieuGiaoHangByCode(newPhieuGiaoHang.MaPhieuTron);
      return newPhieuGiaoHang;
    }

    public void ListPhieuTron_ForTronOnline()
    {
      this._iView.BLstPhieuTron = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.ListPhieuTron_ForTronOnline();
    }

    public void ListPhieuTron_ByIsQueued(bool isQueued)
    {
      this._iView.BLstPhieuTron = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.ListPhieuTron_ByIsQueued(isQueued);
    }

    public void ListMAC()
    {
      this._iView.BLstMAC = MasterDataPresenter<INNView>._iMasterDataModel.ListMAC();
    }

    public void ListMACSilo_ByPhieuTronID(int ptID)
    {
      this._iView.BLstMACSilo = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.ListMACSilo_ByPhieuTronID(ptID);
    }

    public void ListMACSilo_ByHopDongID(int hdID)
    {
      this._iView.BLstMACSilo = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.ListMACSilo_ByHopDongID(hdID);
    }

    public void ListSilo()
    {
      this._iView.BLstSilo = MasterDataPresenter<INNView>._iMasterDataModel.ListSilo_ByActivated(true);
    }

    public void ListTaiXe()
    {
      this._iView.BLstTaiXe = MasterDataPresenter<INNView>._iMasterDataModel.ListTaiXe_ByCondition(new DateTime?(DateTime.MinValue), new DateTime?(DateTime.MinValue), string.Empty, string.Empty, string.Empty, new bool?(true));
    }

    public void ListXe()
    {
      this._iView.BLstXe = MasterDataPresenter<INNView>._iMasterDataModel.ListXe_ByCondition(new DateTime?(DateTime.MinValue), new DateTime?(DateTime.MinValue), string.Empty, new bool?(true));
    }

    public void ListWei()
    {
      this._iView.BLstWeigh = MasterDataPresenter<INNView>._iMasterDataModel.ListWeigh();
    }

    public void ListWeiSiloSaving()
    {
      this._iView.BLstWeiSiloSaving = MasterDataPresenter<INNView>._iMasterDataModel.ListWeiSiloSaving();
    }

    public void ListWeiSiloVisible()
    {
      this._iView.BLstWeiSiloVisible = MasterDataPresenter<INNView>._iMasterDataModel.ListWeiSiloVisible();
    }

    public void ListTimerPara()
    {
      this._iView.BLstTimerPara = MasterDataPresenter<INNView>._iMasterDataModel.ListTimerPara();
    }

    public void ListDuLieuTron()
    {
      this._iView.BLstDuLieuTron = MasterDataPresenter<INNView>._iMasterDataModel.ListDuLieuTron(true);
    }

    public void GetLatestPhieuTron()
    {
    }

    public void BuildNewMeTronChiTiet(
      string maSilo,
      ObjMACSilo objMS,
      ObjSilo objSilo,
      SiloOnline objSiloOnline,
      int sttSiloPLC,
      bool isManualPLC,
      int trangThaiAutoMan,
      int phieuTronID,
      double valueBat,
      double valueBatAuto,
      double valueBatMan,
      int plcSaveId)
    {
      int? nullable1 = new int?();
      Decimal? nullable2 = new Decimal?();
      bool? nullable3 = new bool?();
      switch (trangThaiAutoMan)
      {
        case 0:
          nullable3 = new bool?(true);
          break;
        case 1:
          nullable3 = new bool?(false);
          break;
      }
      if (objMS != null)
      {
        nullable1 = new int?(objMS.MACSiloID);
        nullable2 = objMS.SiloValue;
      }
      Decimal? nullable4 = new Decimal?(0M);
      Decimal? nullable5 = new Decimal?(0M);
      ObjMeTronChiTiet objMTCT;
      if (objSilo != null && objSiloOnline != null)
      {
        Decimal num1;
        Decimal num2;
        if (plcSaveId == 0)
        {
          nullable4 = new Decimal?(objSiloOnline.KLCanCan);
          nullable5 = new Decimal?((Decimal) valueBat);
          num1 = objSiloOnline.KLCanCan - (Decimal) valueBat;
          num2 = num1 / objSiloOnline.KLCanCan * 100M;
        }
        else
        {
          nullable4 = new Decimal?(0M);
          nullable5 = new Decimal?((Decimal) valueBat);
          num1 = 0M;
          num2 = 0M;
        }
        objMTCT = new ObjMeTronChiTiet()
        {
          MACSiloID = nullable1,
          Value = nullable4,
          ValueBat = nullable5,
          ValueBatAuto = new Decimal?((Decimal) valueBatAuto),
          ValueBatMan = new Decimal?((Decimal) valueBatMan),
          ValueTol = new Decimal?(num1),
          ValuePerTol = new Decimal?(num2),
          SiloValue = nullable2,
          SaiSoDuoi = objSilo.SaiSoDuoi,
          SaiSoTren = objSilo.SaiSoTren,
          KLCanNhoNhat = objSilo.KLCanNhoNhat,
          KLCanLonNhat = objSilo.KLCanLonNhat,
          TGNhapNhaOn = objSilo.TGNhapNhaOn,
          TGNhapNhaOff = objSilo.TGNhapNhaOff,
          TGKiemTraVatLieuRoi = objSilo.TGKiemTraVatLieuRoi,
          KLRoi = objSilo.KLRoi,
          KLDT_Tu1 = new Decimal?(0M),
          KLDT_Tu2 = new Decimal?(0M),
          KLDT_Tu3 = new Decimal?(0M),
          KLDT_Den1 = objSilo.KLDT_Den1,
          KLDT_Den2 = objSilo.KLDT_Den2,
          KLDT_Den3 = objSilo.KLDT_Den3,
          DoAm_NhomSlioAgg = objSilo.DoAm_NhomSlioAgg,
          DoHutNuoc_NhomSiloAgg = objSilo.DoHutNuoc_NhomSiloAgg,
          SoiTrongCat_Percent_NhomSiloAgg = objSilo.SoiTrongCat_NhomSiloAgg,
          SoiTrongCat_SiloId_NhomSiloAgg = objSilo.SoiTrongCat_TruVaoSilo_NhomSiloAgg,
          MaterialID = objSilo.MaterialID,
          MaterialCode = objSilo.MaterialCode,
          MaterialName = objSilo.MaterialName,
          MaSilo = maSilo,
          STTSiloPLC = new int?(sttSiloPLC),
          IsManual = nullable3,
          NgayMTCT = new DateTime?(DateTime.Now),
          PLCSaveId = new int?(plcSaveId),
          CreatedBy = new int?(GlobalValues.UserID),
          CreationDate = new DateTime?(DateTime.Now)
        };
      }
      else
        objMTCT = new ObjMeTronChiTiet()
        {
          MACSiloID = nullable1,
          Value = new Decimal?(0M),
          ValueBat = new Decimal?((Decimal) valueBat),
          ValueBatAuto = new Decimal?((Decimal) valueBatAuto),
          ValueBatMan = new Decimal?((Decimal) valueBatMan),
          ValueTol = new Decimal?(0M),
          ValuePerTol = new Decimal?(0M),
          SiloValue = new Decimal?(0M),
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
          DoAm_NhomSlioAgg = new Decimal?(0M),
          DoHutNuoc_NhomSiloAgg = new Decimal?(0M),
          MaSilo = maSilo,
          STTSiloPLC = new int?(sttSiloPLC),
          IsManual = nullable3,
          NgayMTCT = new DateTime?(DateTime.Now),
          CreatedBy = new int?(GlobalValues.UserID),
          CreationDate = new DateTime?(DateTime.Now)
        };
      this._iView.CurMeTronChiTiet = MasterDataPresenter<INNView>._iMasterDataModel.SaveMeTronChiTiet(objMTCT, phieuTronID);
    }

    public void BuildNewMeTronChiTietGiaoHang(
      string maSilo,
      ObjMACSilo objMS,
      ObjSilo objSilo,
      SiloOnline objSiloOnline,
      int sttSiloPLC,
      bool isManualPLC,
      int trangThaiAutoMan,
      int phieuTronID,
      double valueBat,
      double valueBatAuto,
      double valueBatMan,
      int plcSaveId)
    {
      int? nullable1 = new int?();
      Decimal? nullable2 = new Decimal?();
      bool? nullable3 = new bool?();
      switch (trangThaiAutoMan)
      {
        case 0:
          nullable3 = new bool?(true);
          break;
        case 1:
          nullable3 = new bool?(false);
          break;
      }
      if (objMS != null)
      {
        nullable1 = new int?(objMS.MACSiloID);
        nullable2 = objMS.SiloValue;
      }
      Decimal? nullable4 = new Decimal?(0M);
      Decimal? nullable5 = new Decimal?(0M);
      ObjMeTronChiTietGiaoHang objMTCT;
      if (objSilo != null && objSiloOnline != null)
      {
        Decimal num1;
        Decimal num2;
        if (plcSaveId == 0)
        {
          nullable4 = new Decimal?(objSiloOnline.KLCanCan);
          nullable5 = new Decimal?((Decimal) valueBat);
          num1 = objSiloOnline.KLCanCan - (Decimal) valueBat;
          num2 = num1 / objSiloOnline.KLCanCan * 100M;
        }
        else
        {
          nullable4 = new Decimal?(0M);
          nullable5 = new Decimal?((Decimal) valueBat);
          num1 = 0M;
          num2 = 0M;
        }
        objMTCT = new ObjMeTronChiTietGiaoHang()
        {
          MACSiloID = nullable1,
          Value = nullable4,
          ValueBat = nullable5,
          ValueBatAuto = new Decimal?((Decimal) valueBatAuto),
          ValueBatMan = new Decimal?((Decimal) valueBatMan),
          ValueTol = new Decimal?(num1),
          ValuePerTol = new Decimal?(num2),
          SiloValue = nullable2,
          SaiSoDuoi = objSilo.SaiSoDuoi,
          SaiSoTren = objSilo.SaiSoTren,
          KLCanNhoNhat = objSilo.KLCanNhoNhat,
          KLCanLonNhat = objSilo.KLCanLonNhat,
          TGNhapNhaOn = objSilo.TGNhapNhaOn,
          TGNhapNhaOff = objSilo.TGNhapNhaOff,
          TGKiemTraVatLieuRoi = objSilo.TGKiemTraVatLieuRoi,
          KLRoi = objSilo.KLRoi,
          KLDT_Tu1 = objSilo.KLDT_Tu1,
          KLDT_Tu2 = objSilo.KLDT_Tu2,
          KLDT_Tu3 = objSilo.KLDT_Tu3,
          KLDT_Den1 = objSilo.KLDT_Den1,
          KLDT_Den2 = objSilo.KLDT_Den2,
          KLDT_Den3 = objSilo.KLDT_Den3,
          DoAm_NhomSlioAgg = objSilo.DoAm_NhomSlioAgg,
          DoHutNuoc_NhomSiloAgg = objSilo.DoHutNuoc_NhomSiloAgg,
          SoiTrongCat_Percent_NhomSiloAgg = objSilo.SoiTrongCat_NhomSiloAgg,
          SoiTrongCat_SiloId_NhomSiloAgg = objSilo.SoiTrongCat_TruVaoSilo_NhomSiloAgg,
          MaterialID = objSilo.MaterialID,
          MaterialCode = objSilo.MaterialCode,
          MaterialName = objSilo.MaterialName,
          MaSilo = maSilo,
          STTSiloPLC = new int?(sttSiloPLC),
          IsManual = nullable3,
          NgayMTCT = new DateTime?(DateTime.Now),
          PLCSaveId = new int?(plcSaveId),
          CreatedBy = new int?(GlobalValues.UserID),
          CreationDate = new DateTime?(DateTime.Now)
        };
      }
      else
        objMTCT = new ObjMeTronChiTietGiaoHang()
        {
          Value = new Decimal?(0M),
          ValueBat = new Decimal?((Decimal) valueBat),
          ValueBatAuto = new Decimal?((Decimal) valueBatAuto),
          ValueBatMan = new Decimal?((Decimal) valueBatMan),
          ValueTol = new Decimal?(0M),
          ValuePerTol = new Decimal?(0M),
          SiloValue = new Decimal?(0M),
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
          DoAm_NhomSlioAgg = new Decimal?(0M),
          DoHutNuoc_NhomSiloAgg = new Decimal?(0M),
          MaSilo = maSilo,
          STTSiloPLC = new int?(sttSiloPLC),
          IsManual = nullable3,
          NgayMTCT = new DateTime?(DateTime.Now),
          CreatedBy = new int?(GlobalValues.UserID),
          CreationDate = new DateTime?(DateTime.Now)
        };
      this._iView.CurMeTronChiTietGiaoHang = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.SaveMeTronChiTietGiaoHang(objMTCT, phieuTronID);
    }

    public void BuildSetPointNotHD(
      BindingList<ObjWeigh> blstWei,
      BindingList<ObjSilo> blstSilo,
      bool canUpdateWhenRunning)
    {
      SetPoint_NotHD setPointNotHd1 = new SetPoint_NotHD();
      Decimal? nullable1;
      bool? giuKltc;
      foreach (ObjWeigh objWeigh in (Collection<ObjWeigh>) blstWei)
      {
        switch (objWeigh.WeighCode)
        {
          case "Agg1":
            SetPoint_NotHD setPointNotHd2 = setPointNotHd1;
            nullable1 = objWeigh.TimeEmpty;
            setPointNotHd2.W_AG1_TG_DLC = nullable1.Value;
            nullable1 = objWeigh.Max;
            setPointNotHd2.W_AG1_TG_DLX = nullable1.Value;
            nullable1 = objWeigh.Offset;
            setPointNotHd2.W_AG1_TG_DLD = nullable1.Value;
            nullable1 = objWeigh.KLEmpty;
            setPointNotHd2.W_AG1_KL_BRO = nullable1.Value;
            nullable1 = objWeigh.WeiToVib;
            setPointNotHd2.W_AG1_KL_RUG = nullable1.Value;
            nullable1 = objWeigh.TON;
            setPointNotHd2.W_AG1_TG_ON_RUNG = nullable1.Value;
            nullable1 = objWeigh.TOFF;
            setPointNotHd2.W_AG1_TG_OF_RUNG = nullable1.Value;
            giuKltc = objWeigh.GiuKLTC;
            setPointNotHd2.GIU_LAI_CAN_AGG1 = giuKltc.Value;
            continue;
          case "Ce1":
            SetPoint_NotHD setPointNotHd3 = setPointNotHd1;
            nullable1 = objWeigh.TimeEmpty;
            setPointNotHd3.W_FD1_TG_DLC = nullable1.Value;
            nullable1 = objWeigh.Max;
            setPointNotHd3.W_FD1_TG_DLX = nullable1.Value;
            nullable1 = objWeigh.Offset;
            setPointNotHd3.W_FD1_TG_DLD = nullable1.Value;
            nullable1 = objWeigh.KLEmpty;
            setPointNotHd3.W_FD1_KL_BRO = nullable1.Value;
            nullable1 = objWeigh.WeiToVib;
            setPointNotHd3.W_FD1_KL_RUG = nullable1.Value;
            nullable1 = objWeigh.TON;
            setPointNotHd3.W_FD1_TG_ON_RUNG = nullable1.Value;
            nullable1 = objWeigh.TOFF;
            setPointNotHd3.W_FD1_TG_OF_RUNG = nullable1.Value;
            giuKltc = objWeigh.GiuKLTC;
            setPointNotHd3.GIU_LAI_CAN_CE1 = giuKltc.Value;
            continue;
          case "Wa1":
            SetPoint_NotHD setPointNotHd4 = setPointNotHd1;
            nullable1 = objWeigh.TimeEmpty;
            setPointNotHd4.W_AP1_TG_DLC = nullable1.Value;
            nullable1 = objWeigh.Max;
            setPointNotHd4.W_AP1_TG_DLX = nullable1.Value;
            nullable1 = objWeigh.Offset;
            setPointNotHd4.W_AP1_TG_DLD = nullable1.Value;
            Decimal? nullable2 = objWeigh.KLEmpty;
            nullable2 = new Decimal?(nullable2.Value);
            setPointNotHd4.W_AP1_KL_BRO = nullable2.Value;
            giuKltc = objWeigh.GiuKLTC;
            setPointNotHd4.GIU_LAI_CAN_WA1 = giuKltc.Value;
            continue;
          case "Add1":
            SetPoint_NotHD setPointNotHd5 = setPointNotHd1;
            nullable1 = objWeigh.TimeEmpty;
            setPointNotHd5.W_SB1_TG_DLC = nullable1.Value;
            nullable1 = objWeigh.Max;
            setPointNotHd5.W_SB1_TG_DLX = nullable1.Value;
            nullable1 = objWeigh.Offset;
            setPointNotHd5.W_SB1_TG_DLD = nullable1.Value;
            nullable1 = objWeigh.KLEmpty;
            setPointNotHd5.W_SB1_KL_BRO = nullable1.Value;
            nullable1 = objWeigh.WeiToVib;
            setPointNotHd5.W_SB1_KL_RUG = nullable1.Value;
            nullable1 = objWeigh.TON;
            setPointNotHd5.W_SB1_TG_ON_RUNG = nullable1.Value;
            nullable1 = objWeigh.TOFF;
            setPointNotHd5.W_SB1_TG_OF_RUNG = nullable1.Value;
            giuKltc = objWeigh.GiuKLTC;
            setPointNotHd5.GIU_LAI_CAN_CE1 = giuKltc.Value;
            continue;
          default:
            continue;
        }
      }
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) blstSilo)
      {
        string maSilo = objSilo.MaSilo;
        Decimal? nullable3;
        if (maSilo != null)
        {
          switch (maSilo.Length)
          {
            case 3:
              switch (maSilo[0])
              {
                case 'C':
                  if (maSilo == "Ce1")
                  {
                    SetPoint_NotHD setPointNotHd6 = setPointNotHd1;
                    nullable3 = objSilo.SaiSoTren;
                    setPointNotHd6.FD1_SS_TREN = nullable3.Value;
                    nullable3 = objSilo.SaiSoDuoi;
                    setPointNotHd6.FD1_SS_DUOI = nullable3.Value;
                    nullable3 = objSilo.KLRoi;
                    setPointNotHd6.FD1_KL_RTD = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOn;
                    setPointNotHd6.FD1_TG_ON_CAN = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOff;
                    setPointNotHd6.FD1_TG_OFF_CAN = nullable3.Value;
                    nullable3 = objSilo.TGKiemTraVatLieuRoi;
                    setPointNotHd6.FD1_TG_ODC = nullable3.Value;
                    setPointNotHd6.BuTruKLMT_Ce1 = objSilo.BuTruKLMT.Value;
                    setPointNotHd6.TuDongXNCD_Ce1 = objSilo.TuDongXNCD.Value;
                    continue;
                  }
                  continue;
                case 'W':
                  if (maSilo == "Wa1")
                  {
                    SetPoint_NotHD setPointNotHd7 = setPointNotHd1;
                    nullable3 = objSilo.SaiSoTren;
                    setPointNotHd7.AP1_SS_TREN = nullable3.Value;
                    nullable3 = objSilo.SaiSoDuoi;
                    setPointNotHd7.AP1_SS_DUOI = nullable3.Value;
                    nullable3 = objSilo.KLRoi;
                    setPointNotHd7.AP1_KL_RTD = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOn;
                    setPointNotHd7.AP1_TG_ON_CAN = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOff;
                    setPointNotHd7.AP1_TG_OFF_CAN = nullable3.Value;
                    nullable3 = objSilo.TGKiemTraVatLieuRoi;
                    setPointNotHd7.AP1_TG_ODC = nullable3.Value;
                    setPointNotHd7.BuTruKLMT_Wa1 = objSilo.BuTruKLMT.Value;
                    setPointNotHd7.TuDongXNCD_Wa1 = objSilo.TuDongXNCD.Value;
                    continue;
                  }
                  continue;
                default:
                  continue;
              }
            case 4:
              switch (maSilo[3])
              {
                case '1':
                  switch (maSilo)
                  {
                    case "Agg1":
                      SetPoint_NotHD setPointNotHd8 = setPointNotHd1;
                      nullable3 = objSilo.SaiSoTren;
                      setPointNotHd8.AG1_SS_TREN = nullable3.Value;
                      nullable3 = objSilo.SaiSoDuoi;
                      setPointNotHd8.AG1_SS_DUOI = nullable3.Value;
                      nullable3 = objSilo.KLRoi;
                      setPointNotHd8.AG1_KL_RTD = nullable3.Value;
                      nullable3 = objSilo.TGNhapNhaOn;
                      setPointNotHd8.AG1_TG_ON_CAN = nullable3.Value;
                      nullable3 = objSilo.TGNhapNhaOff;
                      setPointNotHd8.AG1_TG_OFF_CAN = nullable3.Value;
                      nullable3 = objSilo.TGKiemTraVatLieuRoi;
                      setPointNotHd8.AG1_TG_ODC = nullable3.Value;
                      setPointNotHd8.BuTruKLMT_Agg1 = objSilo.BuTruKLMT.Value;
                      setPointNotHd8.TuDongXNCD_Agg1 = objSilo.TuDongXNCD.Value;
                      continue;
                    case "Add1":
                      SetPoint_NotHD setPointNotHd9 = setPointNotHd1;
                      nullable3 = objSilo.SaiSoTren;
                      setPointNotHd9.SB1_SS_TREN = nullable3.Value;
                      nullable3 = objSilo.SaiSoDuoi;
                      setPointNotHd9.SB1_SS_DUOI = nullable3.Value;
                      nullable3 = objSilo.KLRoi;
                      setPointNotHd9.SB1_KL_RTD = nullable3.Value;
                      nullable3 = objSilo.TGNhapNhaOn;
                      setPointNotHd9.SB1_TG_ON_CAN = nullable3.Value;
                      nullable3 = objSilo.TGNhapNhaOff;
                      setPointNotHd9.SB1_TG_OFF_CAN = nullable3.Value;
                      nullable3 = objSilo.TGKiemTraVatLieuRoi;
                      setPointNotHd9.SB1_TG_ODC = nullable3.Value;
                      setPointNotHd9.BuTruKLMT_Add1 = objSilo.BuTruKLMT.Value;
                      setPointNotHd9.TuDongXNCD_Add1 = objSilo.TuDongXNCD.Value;
                      continue;
                    default:
                      continue;
                  }
                case '2':
                  if (maSilo == "Agg2")
                  {
                    SetPoint_NotHD setPointNotHd10 = setPointNotHd1;
                    nullable3 = objSilo.SaiSoTren;
                    setPointNotHd10.AG2_SS_TREN = nullable3.Value;
                    nullable3 = objSilo.SaiSoDuoi;
                    setPointNotHd10.AG2_SS_DUOI = nullable3.Value;
                    nullable3 = objSilo.KLRoi;
                    setPointNotHd10.AG2_KL_RTD = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOn;
                    setPointNotHd10.AG2_TG_ON_CAN = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOff;
                    setPointNotHd10.AG2_TG_OFF_CAN = nullable3.Value;
                    nullable3 = objSilo.TGKiemTraVatLieuRoi;
                    setPointNotHd10.AG2_TG_ODC = nullable3.Value;
                    setPointNotHd10.BuTruKLMT_Agg2 = objSilo.BuTruKLMT.Value;
                    setPointNotHd10.TuDongXNCD_Agg2 = objSilo.TuDongXNCD.Value;
                    continue;
                  }
                  continue;
                case '3':
                  if (maSilo == "Agg3")
                  {
                    SetPoint_NotHD setPointNotHd11 = setPointNotHd1;
                    nullable3 = objSilo.SaiSoTren;
                    setPointNotHd11.AG3_SS_TREN = nullable3.Value;
                    nullable3 = objSilo.SaiSoDuoi;
                    setPointNotHd11.AG3_SS_DUOI = nullable3.Value;
                    nullable3 = objSilo.KLRoi;
                    setPointNotHd11.AG3_KL_RTD = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOn;
                    setPointNotHd11.AG3_TG_ON_CAN = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOff;
                    setPointNotHd11.AG3_TG_OFF_CAN = nullable3.Value;
                    nullable3 = objSilo.TGKiemTraVatLieuRoi;
                    setPointNotHd11.AG3_TG_ODC = nullable3.Value;
                    setPointNotHd11.BuTruKLMT_Agg3 = objSilo.BuTruKLMT.Value;
                    setPointNotHd11.TuDongXNCD_Agg3 = objSilo.TuDongXNCD.Value;
                    continue;
                  }
                  continue;
                case '4':
                  if (maSilo == "Agg4")
                  {
                    SetPoint_NotHD setPointNotHd12 = setPointNotHd1;
                    nullable3 = objSilo.SaiSoTren;
                    setPointNotHd12.AG4_SS_TREN = nullable3.Value;
                    nullable3 = objSilo.SaiSoDuoi;
                    setPointNotHd12.AG4_SS_DUOI = nullable3.Value;
                    nullable3 = objSilo.KLRoi;
                    setPointNotHd12.AG4_KL_RTD = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOn;
                    setPointNotHd12.AG4_TG_ON_CAN = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOff;
                    setPointNotHd12.AG4_TG_OFF_CAN = nullable3.Value;
                    nullable3 = objSilo.TGKiemTraVatLieuRoi;
                    setPointNotHd12.AG4_TG_ODC = nullable3.Value;
                    setPointNotHd12.BuTruKLMT_Agg4 = objSilo.BuTruKLMT.Value;
                    setPointNotHd12.TuDongXNCD_Agg4 = objSilo.TuDongXNCD.Value;
                    continue;
                  }
                  continue;
                case '5':
                  if (maSilo == "Agg5")
                  {
                    SetPoint_NotHD setPointNotHd13 = setPointNotHd1;
                    nullable3 = objSilo.SaiSoTren;
                    setPointNotHd13.AG5_SS_TREN = nullable3.Value;
                    nullable3 = objSilo.SaiSoDuoi;
                    setPointNotHd13.AG5_SS_DUOI = nullable3.Value;
                    nullable3 = objSilo.KLRoi;
                    setPointNotHd13.AG5_KL_RTD = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOn;
                    setPointNotHd13.AG5_TG_ON_CAN = nullable3.Value;
                    nullable3 = objSilo.TGNhapNhaOff;
                    setPointNotHd13.AG5_TG_OFF_CAN = nullable3.Value;
                    nullable3 = objSilo.TGKiemTraVatLieuRoi;
                    setPointNotHd13.AG5_TG_ODC = nullable3.Value;
                    setPointNotHd13.BuTruKLMT_Agg5 = objSilo.BuTruKLMT.Value;
                    setPointNotHd13.TuDongXNCD_Agg5 = objSilo.TuDongXNCD.Value;
                    continue;
                  }
                  continue;
                default:
                  continue;
              }
            default:
              continue;
          }
        }
      }
      setPointNotHd1.CanUpdateWhenRunning = canUpdateWhenRunning;
      this._iView.SP_NotHD = setPointNotHd1;
    }

    public void BuildSetPoint(
      ObjHopDong objHD,
      BindingList<ObjMACSilo> blstMACSilo,
      BindingList<ObjWeigh> blstWei,
      BindingList<ObjSilo> blstSilo,
      int soMeCan,
      bool canUpdateWhenRunning)
    {
      SetPoint setPoint = new SetPoint();
      setPoint.ThemBotNuoc = objHD.NPMACThemBotNuoc1;
      Decimal num = objHD.DLT_KLDuTinhCuaTungMe.Value;
      foreach (ObjMACSilo objMacSilo in (Collection<ObjMACSilo>) blstMACSilo)
      {
        string npSiloMaSilo = objMacSilo.NPSiloMaSilo;
        if (npSiloMaSilo != null)
        {
          switch (npSiloMaSilo.Length)
          {
            case 3:
              switch (npSiloMaSilo[0])
              {
                case 'C':
                  if (npSiloMaSilo == "Ce1")
                  {
                    setPoint.KL_CaiDat_Ce1 = objMacSilo.SiloValue.Value;
                    setPoint.SV_FD1 = setPoint.KL_CaiDat_Ce1 * num;
                    continue;
                  }
                  continue;
                case 'W':
                  if (npSiloMaSilo == "Wa1")
                  {
                    setPoint.KL_CaiDat_Wa1 = objMacSilo.SiloValue.Value;
                    setPoint.SV_AP1 = setPoint.KL_CaiDat_Wa1 * num;
                    continue;
                  }
                  continue;
                default:
                  continue;
              }
            case 4:
              switch (npSiloMaSilo[3])
              {
                case '1':
                  switch (npSiloMaSilo)
                  {
                    case "Add1":
                      setPoint.KL_CaiDat_Add1 = objMacSilo.SiloValue.Value;
                      setPoint.SV_SB1 = setPoint.KL_CaiDat_Add1 * num;
                      continue;
                    case "Agg1":
                      setPoint.KL_CaiDat_Agg1 = objMacSilo.SiloValue.Value;
                      setPoint.SV_AG1 = setPoint.KL_CaiDat_Agg1 * num;
                      continue;
                    default:
                      continue;
                  }
                case '2':
                  if (npSiloMaSilo == "Agg2")
                  {
                    setPoint.KL_CaiDat_Agg2 = objMacSilo.SiloValue.Value;
                    setPoint.SV_AG2 = setPoint.KL_CaiDat_Agg2 * num;
                    continue;
                  }
                  continue;
                case '3':
                  if (npSiloMaSilo == "Agg3")
                  {
                    setPoint.KL_CaiDat_Agg3 = objMacSilo.SiloValue.Value;
                    setPoint.SV_AG3 = setPoint.KL_CaiDat_Agg3 * num;
                    continue;
                  }
                  continue;
                case '4':
                  if (npSiloMaSilo == "Agg4")
                  {
                    setPoint.KL_CaiDat_Agg4 = objMacSilo.SiloValue.Value;
                    setPoint.SV_AG4 = setPoint.KL_CaiDat_Agg4 * num;
                    continue;
                  }
                  continue;
                case '5':
                  if (npSiloMaSilo == "Agg5")
                  {
                    setPoint.KL_CaiDat_Agg5 = objMacSilo.SiloValue.Value;
                    setPoint.SV_AG5 = setPoint.KL_CaiDat_Agg5 * num;
                    continue;
                  }
                  continue;
                default:
                  continue;
              }
            default:
              continue;
          }
        }
      }
      setPoint.SO_ME_TRON = (Decimal) (int) objHD.DLT_SLMeDuTinh.Value;
      setPoint.KLTrenTungMe = objHD.DLT_KLDuTinhCuaTungMe.Value;
      setPoint.CanUpdateWhenRunning = canUpdateWhenRunning;
      this._iView.SP = setPoint;
    }

    public void UpdatePT(BindingList<ObjPhieuTron> blstCT)
    {
      this._iView.IsSuccessfulUpdatePT = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.SavePhieuTron(blstCT);
    }

    public bool ResolveUnfinishPhieuTron()
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.ResolveUnfinishPhieuTron();
    }

    public void SaveTronOnline(ObjPhieuTron objPT, BindingList<ObjMeTron> blstMT)
    {
      this._iView.SavingPhieuTron = MasterDataPresenter<ITronOnlineView>._iMasterDataModel.SaveTronOnline(objPT, blstMT);
    }

    public void SaveThemBotNuoc1(int macID, Decimal themBotNuoc1)
    {
      MasterDataPresenter<ITronOnlineView>._iMasterDataModel.SaveMacThemBotNuoc1(macID, themBotNuoc1);
    }

    public void SaveThemBotNuoc2(int macID, Decimal themBotNuoc2)
    {
      MasterDataPresenter<ITronOnlineView>._iMasterDataModel.SaveMacThemBotNuoc2(macID, themBotNuoc2);
    }

    public ObjMAC GetMACByKey(int macId)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetMACByKey(macId);
    }

    public ObjKhachHang GetKhachHangByKey(int khachHangId)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetKhachHangByKey(khachHangId);
    }

    public ObjCongTruong GetCongTruongByKey(int congTruongId)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetCongTruongByKey(congTruongId);
    }

    public ObjHangMuc GetHangMucByKey(int HangMucId)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.GetHangMucByKey(HangMucId);
    }

    public void SaveMacThemBotNuoc1(int macId, Decimal themBotNuoc1)
    {
    }

    public void SaveMacThemBotNuoc2(int macId, Decimal themBotNuoc2)
    {
    }

    public void SaveDuLieuTron(BindingList<ObjDuLieuTron> blstDLT)
    {
      MasterDataPresenter<ITronOnlineView>._iMasterDataModel.SaveDuLieuTron(blstDLT);
    }

    public ObjDuLieuTron AddDuLieuTron(ObjDuLieuTron objDLT)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.AddDuLieuTron(objDLT);
    }

    public ObjDuLieuTron UpdateDuLieuTron(ObjDuLieuTron objDLT)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.UpdateDuLieuTron(objDLT);
    }

    public bool DeleteDulieuTron(int id)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.DeleteDulieuTron(id);
    }

    public ObjHopDong SaveHopDong(ObjHopDong objHD, ObjDuLieuTron objDLT)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.SaveHopDong(objHD, objDLT);
    }

    public ObjHopDong SaveHopDong(ObjHopDong objHD)
    {
      return MasterDataPresenter<ITronOnlineView>._iMasterDataModel.SaveHopDong(objHD);
    }

    public BindingList<Objvw_DataMix> ListDataMix_ByCondition_re(
      DateTime? fromDate,
      TimeSpan? fromTime,
      DateTime? toDate,
      TimeSpan? toTime,
      string maPhieuTron,
      int? khachHang,
      int? congTruong,
      int? hangMuc,
      int? mac,
      int? bienSo,
      int? taiXe,
      int? nhanVien,
      bool? moPhong)
    {
      return MasterDataPresenter<INNView>._iMasterDataModel.ListDataMix_ByCondition(fromDate, fromTime, toDate, toTime, maPhieuTron, khachHang, congTruong, hangMuc, mac, bienSo, taiXe, nhanVien, moPhong);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.VanHanh
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.PLCMapping;
using NhuaNong.PLCModule;
using NhuaNong.UserControls;
using NhuaNong.Utils;
using S7.Net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class VanHanh : ControlViewBase, IBase, IPermission, INNView
  {
    private TronOnlineDataPresenter _presenter;
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private PLCController _plcController = new PLCController();
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private SetPoint _sp = new SetPoint();
    private SetPoint_NotHD _sp_NotHD = new SetPoint_NotHD();
    private ReceivingFromPLC _ro = new ReceivingFromPLC();
    private SendingToPLC _so = new SendingToPLC();
    private TronOnlineAttributes _TronOnlineAttributes = new TronOnlineAttributes();
    private ObjHopDong _selectedHD_Run;
    private ObjPhieuTron _selectedPT_Run;
    private BindingList<ObjTimerPara> _blstTimerPara = new BindingList<ObjTimerPara>();
    private BindingList<ObjSilo> _blstSilo = new BindingList<ObjSilo>();
    private BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    private BindingList<ObjMACSilo> _blstMACSilo = new BindingList<ObjMACSilo>();
    private BindingList<ObjMACSilo> _blstMACSilo_Run = new BindingList<ObjMACSilo>();
    private BindingList<ObjWeigh> _blstWeigh = new BindingList<ObjWeigh>();
    private BindingList<ObjWeiSiloSaving> _blstWeiSiloSaving = new BindingList<ObjWeiSiloSaving>();
    private BindingList<ObjWeiSiloVisible> _blstWeiSiloVisible = new BindingList<ObjWeiSiloVisible>();
    private BindingList<ObjDuLieuTron> _blstDuLieuTron = new BindingList<ObjDuLieuTron>();
    private BindingList<ObjPhieuTron> _blstPhieuTron = new BindingList<ObjPhieuTron>();
    private BindingList<ObjTaiXe> _blstTaiXe = new BindingList<ObjTaiXe>();
    private BindingList<ObjXe> _blstXe = new BindingList<ObjXe>();
    public BindingList<Objvw_DataMix> _blstDataMix = new BindingList<Objvw_DataMix>();
    private Thread _thread;
    private bool _Ready;
    private bool _isRunNoiTron;
    private bool _isRunBTX;
    private bool _isRunBTC;
    private bool _error;
    private bool _isSimulation;
    private bool _running;
    private bool isRealMode;
    private int soMeDangTron;
    private int slMeCanTron;
    private int _idSavePLC = -1;
    private int _idSave = -1;
    private IContainer components;
    private ucSiloFD siloFD;
    private ucSiloAGG siloAgg1;
    private ucSiloAGG siloAgg2;
    private ucSiloAGG siloAgg3;
    private ucSiloAGG siloAgg4;
    private ucSiloAGG siloAgg5;
    private ucBtnTron btnVanCanFD;
    private ucBtnTron btnVanCanAGG1;
    private ucBtnTron btnVanCanAGG2;
    private ucBtnTron btnVanCanAGG3;
    private ucBtnTron btnVanCanAGG4;
    private ucBtnTron btnVanCanAGG5;
    private ucTinHieuDo tinHieuCanSiloFD;
    private ucTinHieuDo tinHieuCanSiloAGG1;
    private ucTinHieuDo tinHieuCanSiloAGG2;
    private ucTinHieuDo tinHieuCanSiloAGG3;
    private ucTinHieuDo tinHieuCanSiloAGG4;
    private ucTinHieuDo tinHieuCanSiloAGG5;
    private ucTinHieuDo tinHieuCanSiloAP;
    private ucTinHieuDo tinHieuCanSiloSBS;
    private ucTinHieuBaoDay barFullSiloAGG1;
    private ucTinHieuBaoDay barFullSiloAGG2;
    private ucTinHieuBaoDay barFullSiloAGG3;
    private ucTinHieuBaoDay barFullSiloAGG4;
    private ucTinHieuBaoDay barFullSiloAGG5;
    private ucWeighFD weighFD;
    private ucWeighAGG weighAGG;
    private ucWeighAP weighAP;
    private ucWeighSBS weighSBS;
    private ucBtnXaCan btnXaCanFD;
    private ucBtnXaCan btnXaCanAP;
    private ucBtnXaCan btnXaCanAGG;
    private ucBtnXaCan btnXaCanSBS;
    private ucBtnMo btnMoCuaNoi;
    private ucBtnDong btnDongCuaNoi;
    private ucBtnBatDau btnBatDau;
    private ucBtnDung btnDung;
    private ucBtnHuy btnHuy;
    private ucBtnSIM btnSIM;
    private ucBtnCheDo btnCheDoHeThong;
    private ucBtnCheDo btnCheDoNapLieu;
    private ucBtnCheDo btnCheDoCuaNoi;
    private Label lblHeThong;
    private Label label1;
    private Label label2;
    private ucBonChuaKhi ucBonChuaKhi1;
    private ucSanRung sanRung;
    private ucMotorMini motorGauTaiFD;
    private ucTinHieunTanSayLua tinHieuTanSayLua;
    private ucMotorFat motorBomDau;
    private ucMotorExtra ucMotorExtra1;
    private ucPheuChua02 ucPheuChua021;
    private ucPheuChua03 ucPheuChua031;
    private ucMotorFat motorPheuChua02;
    private GroupBox groupBox1;
    private Label label4;
    private Label label3;
    private TextBox txtNhietDoTanSay;
    private TextBox txtNhietDoAGG;
    private TextBox txtNhietDoTuiLocKho;
    private Label label6;
    private Label label5;
    private TextBox txtNhietDoNhua;
    private ucPheuChuaCatDa ucPheuChuaCatDa1;
    private ucPheuChuaCatDa ucPheuChuaCatDa2;
    private ucPheuChuaCatDa ucPheuChuaCatDa3;
    private ucPheuChuaCatDa ucPheuChuaCatDa4;
    private ucPheuChuaCatDa ucPheuChuaCatDa5;
    private ucBtnXaCan btnXaCanAGG1;
    private ucBtnXaCan btnXaCanAGG2;
    private ucBtnXaCan btnXaCanAGG3;
    private ucBtnXaCan btnXaCanAGG4;
    private ucBtnXaCan btnXaCanAGG5;
    private ucTinHieuXanh tinHieuXaCanAGG1;
    private ucTinHieuXanh tinHieuXaCanAGG2;
    private ucTinHieuXanh tinHieuXaCanAGG3;
    private ucTinHieuXanh tinHieuXaCanAGG4;
    private ucTinHieuXanh tinHieuXaCanAGG5;
    private ucBangTaiCan bangTaiCan;
    private ucBTX bangTaiXien;
    private System.Windows.Forms.Timer timer1;
    private Label connectStus;
    private ucOngTanSay ucOngTanSay1;
    private ucOngBonChuaKhi ucOngBonChuaKhi1;
    private ucOngPheuChua03 ucOngPheuChua031;
    private ucOngPheuChua04 ucOngPheuChua041;
    private ucBomNgam bomNgamPheuChua;
    private ucPheuChua04 ucPheuChua041;
    private ucBonChuaTanSay ucBonChuaTanSay1;
    private ucOngMotor ucOngMotor1;
    private ucOngAP ucOngAP1;
    private ucMotorFat motorPheuChua01;
    private ucPheuChua01 ucPheuChua011;
    private ucBtnTron btnVanCanAP;
    private ucSiloAP siloAP;
    private ucOngSBS ucOngSBS1;
    private ucBtnTron btnVanCanSBS;
    private ucSiloSBS siloSBS;
    private ucTinHieuBaoDay barFullSiloSBS;
    private Label label7;
    private TextEdit textEdit1;
    private TextEdit textEdit3;
    private Label label8;
    private TextEdit txtTG_BomTuoiNhua;
    private Label label11;
    private ucBomKhi ucBomKhi1;
    private ucBtnBomKhi btnMayNenKhi;
    private MemoEdit memoEdit1;
    private Label label12;
    private ucVitTaiFD tinHIeuVitTaiFD;
    private ucTinHieuBaoDay tinHieuBaoMucThapFD;
    private ucTinHieuBaoDay tinHieuBaoMucCaoFD;
    private Label label10;
    private TextEdit textEdit4;
    private Label label9;
    private TextEdit textEdit2;
    private ucSiloFDFat siloFDFat;
    private ucSoMeDaCan slMeDaCanFD;
    private ucSoMeDaCan slMeDaCanAGG;
    private ucSoMeDaCan slMeDaCanAP;
    private ucSoMeDaCan slMeDaCanSBS;
    private ucBangGauTaiXiMangNhanh ucBangGauTaiXiMangNhanh1;
    private ucTinHieuBaoDay barFullSiloFD;
    private ucBtnFU btnFU_FD;
    private ucBtnFU btnFU_AG1;
    private ucBtnFU btnFU_AGG2;
    private ucBtnFU btnFU_AGG3;
    private ucBtnFU btnFU_AGG4;
    private ucBtnFU btnFU_AGG5;
    private ucBtnFU btnFU_AP;
    private ucBtnFU btnFU_SBS;
    private ucBangGauTaiXiMang ucBangGauTaiXiMang2;
    private ucBeTiep ucBeTiep1;
    private ucBtnTron btnRungCL1;
    private ucBtnTron btnRungCL2;
    private ucBtnTron btnRungCL3;
    private ucMotorMiniN motorGauTaiAGG1;
    private ucBangGauTaiCatDa ucBangGauTaiCatDa1;
    private ucBangGauTauCatDaNhanh ucBangGauTauCatDaNhanh1;
    private Label lblMAC;
    private Label checkDaat;
    private ucTinHieuSanRung tinHieuSanRung;
    private ucTinHieuDongCuaNoi tinHieuDongCuaNoi;
    private ucTinHieuMoCuaNoi tinHieuMoCuaNoi;
    private ucBtnSanRung btnSanRung;
    private ucBtnVitTai ucBtnVitTai1;
    private LabelControl lblNameCty;
    private LabelControl lblDec;
    private ucTinHieuTanSayQuay btnTanSay;
    private Label label13;
    private ucBtnCheDo btnCheDoXaCan;
    private GridLookUpEdit gluHopDong;
    private GridView glueHopDong;
    private GridColumn grcDuLieuTronID;
    private GridColumn grcMaHopDong;
    private GridColumn grcTenHopDong;
    private LabelControl lblDLT;
    private LabelControl labelControl3;
    private GridLookUpEdit gluTaiXe;
    private GridView gridView1;
    private GridColumn grcTaiXeID;
    private GridColumn grcMaTaiXe;
    private GridColumn grcTenTaiXe;
    private GridLookUpEdit glueBienSo;
    private GridView gridView2;
    private GridColumn grcXeID;
    private GridColumn grcBienSo;
    private LabelControl labelControl4;
    private GroupControl groupControl1;
    private TextEdit txtMAC;
    private LabelControl labelControl5;
    private TextEdit txtKhoiLuong;
    private LabelControl labelControl6;
    private TextEdit txtKhachHang;
    private LabelControl labelControl7;
    private TextEdit txtCongTruong;
    private LabelControl labelControl8;
    private TextEdit txtMaPhieuTron;
    private LabelControl labelControl9;
    private GroupControl VAA;
    private ucOngDanFD ucOngDanFD1;
    private ucTinHieuXaCan tinHieuXaCanAGG;
    private ucTinHieuXaCan tinHieuXaCanFD;
    private ucSoMeDaCan slMeDaCanNoiTron;
    private ucBtnNoiTron btnNoiTronR;
    private ucBtnNoiTron btnNoiTronL;
    private ucNoiTron ucNoiTron1;
    private GridControl grcMeTronCur;
    private GridView grvMeTronCur;
    private GridColumn gcMaPhieuTron;
    private GridColumn gcSTTMeTron;
    private GridColumn ggcNgayTron;
    private GridColumn gcGioTron;
    private GridColumn gcKhachHang;
    private GridColumn gcCongTruong;
    private GridColumn gcTenMAC;
    private GridColumn gcKhoiLuong;
    private ucMotorMini motorBomTuoiNhua;
    private ucOngDanSB ucOngDanSB2;
    private ucBtnXAHETAGG btnXaHetAGG;
    private ucTinHieuXaCan tinHieuBomTuoiNhua;
    private ucTinHieuXaCan tinHieuXaCanSBS;
    private ucTinHieuMoCuaNoi tinHieuCuaNoiMo;
    private ucTinHieuDongCuaNoi tinHieuCuaNoiDong;
    private ucTinHieuDo tinHieuXaCanAP;
    private ucTinHieuTanSayQuay btnDauDot;
    private ucTinHieuXaCan tinHieuCuaMo;
    private ucTinHieuXaCan tinHieuCuaDong;
    private ucBtnXaCan btnPheuSBS;
    private LabelControl lblPhone;
    private LabelControl lblGmail;

    public BindingList<ObjTimerPara> BLstTimerPara
    {
      set
      {
        this._blstTimerPara = value;
        foreach (ObjTimerPara objTimerPara in (Collection<ObjTimerPara>) this._blstTimerPara)
        {
          switch (objTimerPara.TimerParaCode)
          {
            case "HSN_AG1":
              this._sp_NotHD.HSN_AG1 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSN_AG2":
              this._sp_NotHD.HSN_AG2 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSN_AG3":
              this._sp_NotHD.HSN_AG3 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSN_AG4":
              this._sp_NotHD.HSN_AG4 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSN_AG5":
              this._sp_NotHD.HSN_AG5 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSN_AP1":
              this._sp_NotHD.HSN_AP1 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSN_FD1":
              this._sp_NotHD.HSN_FD1 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSN_SB1":
              this._sp_NotHD.HSN_SB1 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSX_AG1":
              this._sp_NotHD.HSX_AG1 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSX_AP1":
              this._sp_NotHD.HSX_AP1 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSX_FD1":
              this._sp_NotHD.HSX_FD1 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "HSX_SB1":
              this._sp_NotHD.HSX_SB1 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "TG_Bom_Tuoi_Nhua":
              this._sp_NotHD.TG_Bom_Tuoi_Nhua = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "TG_Tron":
              this._sp_NotHD.TG_Tron = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "TG_Xa100":
              this._sp_NotHD.TG_Xa100 = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "TG_Xa_AP_Sau_AG":
              this._sp_NotHD.TG_Xa_AP_Sau_AG = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "TG_Xa_FD_Sau_AG":
              this._sp_NotHD.TG_Xa_FD_Sau_AG = (double) objTimerPara.TimerParaValue.Value;
              continue;
            case "TG_Xa_SBS_Sau_AG":
              this._sp_NotHD.TG_Xa_SBS_Sau_AG = (double) objTimerPara.TimerParaValue.Value;
              continue;
            default:
              continue;
          }
        }
      }
    }

    public BindingList<ObjSilo> BLstSilo
    {
      set
      {
        this._blstSilo = value;
        foreach (ObjSilo objSilo in (Collection<ObjSilo>) this._blstSilo)
        {
          if (objSilo.MaSilo == "AGG1")
          {
            this.siloAgg1.SiloCaption = objSilo.MaSilo;
            this.siloAgg1.SiloDesc = objSilo.MaterialName;
          }
          else if (objSilo.MaSilo == "AGG2")
          {
            this.siloAgg2.SiloCaption = objSilo.MaSilo;
            this.siloAgg2.SiloDesc = objSilo.MaterialName;
          }
          else if (objSilo.MaSilo == "AGG3")
          {
            this.siloAgg3.SiloCaption = objSilo.MaSilo;
            this.siloAgg3.SiloDesc = objSilo.MaterialName;
          }
          else if (objSilo.MaSilo == "AG4")
          {
            this.siloAgg4.SiloCaption = objSilo.MaSilo;
            this.siloAgg4.SiloDesc = objSilo.MaterialName;
          }
          else if (objSilo.MaSilo == "AGG5")
          {
            this.siloAgg5.SiloCaption = objSilo.MaSilo;
            this.siloAgg5.SiloDesc = objSilo.MaterialName;
          }
          else if (!(objSilo.MaSilo == "AP1") && !(objSilo.MaSilo == "FD1"))
          {
            int num = objSilo.MaSilo == "SB1" ? 1 : 0;
          }
        }
      }
    }

    public BindingList<ObjMAC> BLstMAC
    {
      set => this._blstMAC = value;
    }

    public BindingList<ObjMACSilo> BLstMACSilo
    {
      set
      {
        this._blstMACSilo = value;
        this._blstMACSilo_Run = this._blstMACSilo;
      }
    }

    public BindingList<ObjWeigh> BLstWeigh
    {
      set => this._blstWeigh = value;
    }

    public BindingList<ObjWeiSiloSaving> BLstWeiSiloSaving
    {
      set => this._blstWeiSiloSaving = value;
    }

    public BindingList<ObjWeiSiloVisible> BLstWeiSiloVisible
    {
      set => this._blstWeiSiloVisible = value;
    }

    public BindingList<ObjDuLieuTron> BLstDuLieuTron
    {
      set
      {
        this._blstDuLieuTron = value;
        this.gluHopDong.Properties.DataSource = (object) this._blstDuLieuTron;
      }
    }

    public BindingList<ObjPhieuTron> BLstPhieuTron
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjTaiXe> BLstTaiXe
    {
      set
      {
        this._blstTaiXe = value;
        this.gluTaiXe.Properties.DataSource = (object) this._blstTaiXe;
      }
    }

    public BindingList<ObjXe> BLstXe
    {
      set
      {
        this._blstXe = value;
        this.glueBienSo.Properties.DataSource = (object) this._blstXe;
      }
    }

    public SetPoint SP
    {
      set
      {
        this._sp = value;
        this.BindSetPoint(this._sp);
      }
    }

    public SetPoint_NotHD SP_NotHD
    {
      set => this._sp_NotHD = value;
    }

    public BindingList<Objvw_DataMix> BLstDataMix
    {
      set => this._blstDataMix = value;
    }

    public SendingToPLC SO
    {
      set => throw new NotImplementedException();
    }

    public ObjMeTron CurMeTron
    {
      set => throw new NotImplementedException();
    }

    public ObjMeTronChiTiet CurMeTronChiTiet
    {
      set => throw new NotImplementedException();
    }

    public ObjMeTronChiTietGiaoHang CurMeTronChiTietGiaoHang
    {
      set => throw new NotImplementedException();
    }

    public ObjPhieuTron SavingPhieuTron
    {
      set => throw new NotImplementedException();
    }

    public bool IsSuccessfulUpdatePT
    {
      set => throw new NotImplementedException();
    }

    private void BindSetPoint(SetPoint sp)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) (() => this.BindSetPoint(sp)));
      }
      else
      {
        this.siloSBS.KLCaiDat = sp.KL_CaiDat_Add1;
        this.siloSBS.KLCanCan = sp.SV_SB1;
        this.siloFD.KLCaiDat = sp.KL_CaiDat_Ce1;
        this.siloFD.KLCanCan = sp.SV_FD1;
        this.siloAP.KLCaiDat = sp.KL_CaiDat_Wa1;
        this.siloAP.KLCanCan = sp.SV_AP1;
        this.siloAgg5.KLCaiDat = sp.KL_CaiDat_Agg5;
        this.siloAgg5.KLCanCan = sp.SV_AG5;
        this.siloAgg4.KLCaiDat = sp.KL_CaiDat_Agg4;
        this.siloAgg4.KLCanCan = sp.SV_AG4;
        this.siloAgg3.KLCaiDat = sp.KL_CaiDat_Agg3;
        this.siloAgg3.KLCanCan = sp.SV_AG3;
        this.siloAgg2.KLCaiDat = sp.KL_CaiDat_Agg2;
        this.siloAgg2.KLCanCan = sp.SV_AG2;
        this.siloAgg1.KLCaiDat = sp.KL_CaiDat_Agg1;
        this.siloAgg1.KLCanCan = sp.SV_AG1;
        this.SetSLMe(sp.SO_ME_TRON);
        this.ucNoiTron1.KL_TRON = sp.KLTrenTungMe;
        Application.DoEvents();
      }
    }

    private void SetSLMe(Decimal slMeTron)
    {
      TramTronLogger.WriteInfo("CHECKING ME TRON: " + slMeTron.ToString());
      this.slMeDaCanFD.SoLuongMeCanTron = this.slMeDaCanAGG.SoLuongMeCanTron = this.slMeDaCanAP.SoLuongMeCanTron = this.slMeDaCanSBS.SoLuongMeCanTron = this.slMeDaCanNoiTron.SoLuongMeCanTron = slMeTron;
    }

    public bool IsRunNoiTron
    {
      get => this._isRunNoiTron;
      set
      {
        this._isRunNoiTron = value;
        if (this._isRunNoiTron)
        {
          this.btnNoiTronL.IsTrangThai = ucBtnNoiTron.TrangThai.Run;
          this.btnNoiTronR.IsTrangThai = ucBtnNoiTron.TrangThai.Run;
        }
        else
        {
          this.btnNoiTronL.IsTrangThai = ucBtnNoiTron.TrangThai.Stop;
          this.btnNoiTronR.IsTrangThai = ucBtnNoiTron.TrangThai.Stop;
        }
      }
    }

    public bool IsRunBTX
    {
      get => this._isRunBTX;
      set
      {
        this._isRunBTX = value;
        if (this._isRunBTX)
          this.bangTaiXien.CheDo = ucBTX.Action.Start;
        else
          this.bangTaiXien.CheDo = ucBTX.Action.Pause;
      }
    }

    public bool IsRunBTC
    {
      get => this._isRunBTC;
      set
      {
        this._isRunBTC = value;
        if (this._isRunBTC)
          this.bangTaiCan.CheDo = ucBangTaiCan.Action.Start;
        else
          this.bangTaiCan.CheDo = ucBangTaiCan.Action.Pause;
      }
    }

    public VanHanh()
    {
      this.InitializeComponent();
      this._presenter = new TronOnlineDataPresenter((INNView) this);
      this.Caption = "Vận hành";
    }

    protected override void PopulateData()
    {
      this._presenter.ListTimerPara();
      this._presenter.ListDuLieuTron();
      this._presenter.ListTaiXe();
      this._presenter.ListXe();
      this._presenter.ListMAC();
      this._presenter.ListSilo();
      this._presenter.ListWei();
      this._presenter.ListWeiSiloSaving();
      this._presenter.ListWeiSiloVisible();
      this.LoadProduce();
    }

    private void VanHanh_Load(object sender, EventArgs e)
    {
      if (!this._plcController.IsConnected)
        return;
      this._Ready = true;
      this.timer1.Interval = 100;
      this._thread = new Thread(new ThreadStart(this.Running));
      this._thread.Name = "Running";
      this._thread.Start();
    }

    private void LoadProduce()
    {
      this.lblNameCty.Text = ConfigManager.TramTronConfig.NameProduct;
      this.lblPhone.Text = ConfigManager.TramTronConfig.PhoneProduct;
      this.lblDec.Text = ConfigManager.TramTronConfig.LocalProduct;
      this.lblGmail.Text = ConfigManager.TramTronConfig.GmailProduct;
    }

    public override void DoKeyDown(object sender, KeyEventArgs e)
    {
      switch (e.KeyCode)
      {
        case Keys.F1:
          if (!this.btnBatDau.Visible)
            break;
          TramTronLogger.WriteInfo(sender.ToString());
          this.InitRunning();
          break;
        case Keys.F2:
          if (!this.btnDung.Visible)
            break;
          TramTronLogger.WriteInfo(sender.ToString());
          this.DoPause();
          break;
        case Keys.F3:
          if (!this.btnHuy.Visible)
            break;
          TramTronLogger.WriteInfo(sender.ToString());
          break;
        case Keys.F4:
          if (!this.btnSIM.Visible)
            break;
          TramTronLogger.WriteInfo(sender.ToString());
          this.DoMoPhong();
          break;
        case Keys.F8:
          this.ShowFrmTimerPara();
          break;
      }
    }

    private void BuildSetPoint(ObjHopDong selectedHD, bool canUpdateWhenRunning)
    {
      if (selectedHD != null)
      {
        this._presenter.ListMACSilo_ByHopDongID(selectedHD.HopDongID);
        this._presenter.ListSilo();
        this._presenter.ListWei();
        this._presenter.BuildSetPoint(selectedHD, this._blstMACSilo, this._blstWeigh, this._blstSilo, this.slMeCanTron, canUpdateWhenRunning);
      }
      else
      {
        int num = (int) MessageBox.Show("Không có dữ liệu!");
      }
    }

    private void BuildSetPoint_NotHD()
    {
      this._presenter.ListSilo();
      this._presenter.ListWei();
      BindingList<ObjWeigh> blstWeigh = this._blstWeigh;
      BindingList<ObjSilo> blstSilo = this._blstSilo;
      this._presenter.BuildSetPointNotHD(this._blstWeigh, this._blstSilo, true);
    }

    private void Running()
    {
      while (this._Ready)
      {
        Thread.Sleep(500);
        try
        {
          if (this._plcController != null && !this._plcController.IsConnected)
            this._plcController = new PLCController();
          if (this._plcController.IsConnected)
          {
            if (this.InvokeRequired)
            {
              this.Invoke((Delegate) (() => this.timer1.Start()));
              break;
            }
            this.BuildSetPoint_NotHD();
            this.SendData_DB3_NewTread();
            this.SendData_DB4_NewTread();
            this._presenter.ListTimerPara();
            this.SendData_DB5_NewTread();
          }
          else if (this.InvokeRequired)
          {
            this.Invoke((Delegate) (() => { }));
            break;
          }
        }
        catch (System.Exception ex)
        {
        }
      }
    }

    private bool CheckConnection()
    {
      if (GlobalValues.PLCConnected)
        return true;
      TramTromMessageBox.ShowMessageDialog("PLC MẤT KẾT NỐI, VUI LÒNG KIỂM TRA LẠI KẾT NỐI");
      return false;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (this._TronOnlineAttributes.IsRunning)
        this.connectStus.Text = "CHẠY";
      else
        this.connectStus.Text = "Tạm Dừng";
      if (!this._plcController.IsConnected)
        return;
      this.ReceiveData_DB1(this._plcController.ReadBytes(S7.Net.DataType.DataBlock, 1, 0, 9));
      this.ReceiveData_DB7(this._plcController.ReadBytes(S7.Net.DataType.DataBlock, 7, 0, 200));
      this.ReceiveData_DB8(this._plcController.ReadBytes(S7.Net.DataType.DataBlock, 8, 0, 80));
      this.BindReceivingOnline(this._ro);
      this.BindReceivingOnline_DB8(this._ro);
    }

    private void Send_Data_DB_2_To_PLC()
    {
      this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 2, 0, new List<byte>()
      {
        this._so.Byte_0,
        this._so.Byte_1,
        this._so.Byte_2,
        this._so.Byte_3,
        this._so.Byte_4,
        this._so.Byte_5,
        this._so.Byte_6,
        this._so.Byte_7,
        this._so.Byte_8,
        this._so.Byte_9,
        this._so.Byte_10,
        this._so.Byte_11,
        this._so.Byte_12
      }.ToArray());
    }

    private void Send_Data_DB_3_To_PLC()
    {
      List<byte> byteList = new List<byte>();
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG1_SS_TREN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG1_SS_DUOI));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG1_KL_RTD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG1_TG_ON_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG1_TG_OFF_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG1_TG_ODC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG2_SS_TREN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG2_SS_DUOI));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG2_KL_RTD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG2_TG_ON_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG2_TG_OFF_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG2_TG_ODC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG3_SS_TREN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG3_SS_DUOI));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG3_KL_RTD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG3_TG_ON_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG3_TG_OFF_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG3_TG_ODC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG4_SS_TREN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG4_SS_DUOI));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG4_KL_RTD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG4_TG_ON_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG4_TG_OFF_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG4_TG_ODC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG5_SS_TREN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG5_SS_DUOI));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG5_KL_RTD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG5_TG_ON_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG5_TG_OFF_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AG5_TG_ODC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.FD1_SS_TREN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.FD1_SS_DUOI));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.FD1_KL_RTD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.FD1_TG_ON_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.FD1_TG_OFF_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.FD1_TG_ODC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AP1_SS_TREN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AP1_SS_DUOI));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AP1_KL_RTD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AP1_TG_ON_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AP1_TG_OFF_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.AP1_TG_ODC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.SB1_SS_TREN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.SB1_SS_DUOI));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.SB1_KL_RTD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.SB1_TG_ON_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.SB1_TG_OFF_CAN));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.SB1_TG_ODC));
      this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 3, 0, byteList.ToArray());
    }

    private void Send_Data_DB_4_To_PLC()
    {
      List<byte> byteList = new List<byte>();
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AG1_TG_DLC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AG1_TG_DLX));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AG1_TG_DLD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AG1_KL_BRO));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AG1_KL_RUG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AG1_TG_ON_RUNG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AG1_TG_OF_RUNG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_FD1_TG_DLC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_FD1_TG_DLX));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_FD1_TG_DLD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_FD1_KL_BRO));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_FD1_KL_RUG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_FD1_TG_ON_RUNG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_FD1_TG_OF_RUNG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AP1_TG_DLC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AP1_TG_DLX));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AP1_TG_DLD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_AP1_KL_BRO));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_SB1_TG_DLC));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_SB1_TG_DLX));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_SB1_TG_DLD));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_SB1_KL_BRO));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_SB1_KL_RUG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_SB1_TG_ON_RUNG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp_NotHD.W_SB1_TG_OF_RUNG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp.SO_ME_TRON));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp.SV_AG1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp.SV_AG2));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp.SV_AG3));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp.SV_AG4));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp.SV_AG5));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp.SV_FD1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp.SV_AP1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes((double) this._sp.SV_SB1));
      this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 4, 0, byteList.ToArray());
    }

    private void Send_Data_DB_5_To_PLC()
    {
      List<byte> byteList = new List<byte>();
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.TG_Tron));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.TG_Xa100));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.TG_Xa_FD_Sau_AG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.TG_Xa_AP_Sau_AG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.TG_Xa_SBS_Sau_AG));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.TG_Bom_Tuoi_Nhua));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSN_AG1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSN_AG2));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSN_AG3));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSN_AG4));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSN_AG5));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSX_AG1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSN_FD1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSX_FD1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSN_AP1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSX_AP1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSN_SB1));
      byteList.AddRange((IEnumerable<byte>) MappingHelper.SeparateFloatTo4Bytes(this._sp_NotHD.HSX_SB1));
      this._plcController.WriteBytes(S7.Net.DataType.DataBlock, 5, 0, byteList.ToArray());
    }

    private void SendData_DB2_NewTread()
    {
      new Thread(new ThreadStart(this.Send_Data_DB_2_To_PLC))
      {
        Name = "DB_2"
      }.Start();
    }

    private void SendData_DB3_NewTread()
    {
      new Thread(new ThreadStart(this.Send_Data_DB_3_To_PLC)).Start();
    }

    private void SendData_DB4_NewTread()
    {
      new Thread(new ThreadStart(this.Send_Data_DB_4_To_PLC)).Start();
    }

    private void SendData_DB5_NewTread()
    {
      new Thread(new ThreadStart(this.Send_Data_DB_5_To_PLC)).Start();
    }

    private void ReceiveData_DB1(byte[] a)
    {
      this._ro.StatusIO_00 = a[0];
      this._ro.StatusIO_01 = a[1];
      this._ro.StatusIO_02 = a[2];
      this._ro.StatusIO_03 = a[3];
      this._ro.StatusIO_04 = a[4];
      this._ro.StatusIO_05 = a[5];
      this._ro.StatusIO_06 = a[6];
      this._ro.StatusIO_07 = a[7];
      this._ro.StatusIO_08 = a[8];
    }

    private void ReceiveData_DB7(byte[] a)
    {
      this._ro.PV_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[0], a[1], a[2], a[3]));
      this._ro.Per_WAG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[4], a[5], a[6], a[7]));
      this._ro.WE_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[8], a[9], a[10], a[11]));
      this._ro.SMC_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[12], a[13], a[14], a[15]));
      this._ro.SMX_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[16], a[17], a[18], a[19]));
      this._ro.PV_AG2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[20], a[21], a[22], a[23]));
      this._ro.SMC_AG2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[24], a[25], a[26], a[27]));
      this._ro.SMX_AG2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[28], a[29], a[30], a[31]));
      this._ro.PV_AG3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[32], a[33], a[34], a[35]));
      this._ro.SMC_AG3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[36], a[37], a[38], a[39]));
      this._ro.SMX_AG3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[40], a[41], a[42], a[43]));
      this._ro.PV_AG4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[44], a[45], a[46], a[47]));
      this._ro.SMC_AG4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[48], a[49], a[50], a[51]));
      this._ro.SMX_AG4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[52], a[53], a[54], a[55]));
      this._ro.PV_AG5 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[56], a[57], a[58], a[59]));
      this._ro.SMC_AG5 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[60], a[61], a[62], a[63]));
      this._ro.SMX_AG5 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[64], a[65], a[66], a[67]));
      this._ro.PV_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[68], a[69], a[70], a[71]));
      this._ro.Per_WFD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[72], a[73], a[74], a[75]));
      this._ro.WE_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[76], a[77], a[78], a[79]));
      this._ro.SMC_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[80], a[81], a[82], a[83]));
      this._ro.SMX_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[84], a[85], a[86], a[87]));
      this._ro.PV_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[88], a[89], a[90], a[91]));
      this._ro.Per_WAP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[92], a[93], a[94], a[95]));
      this._ro.WE_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[96], a[97], a[98], a[99]));
      this._ro.SMC_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[100], a[101], a[102], a[103]));
      this._ro.SMX_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[104], a[105], a[106], a[107]));
      this._ro.PV_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[108], a[109], a[110], a[111]));
      this._ro.Per_WSB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[112], a[113], a[114], a[115]));
      this._ro.WE_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[116], a[117], a[118], a[119]));
      this._ro.SMC_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[120], a[121], a[122], a[123]));
      this._ro.SMX_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[124], a[125], a[126], a[(int) sbyte.MaxValue]));
      this._ro.SMC_MIXER = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[128], a[129], a[130], a[131]));
      this._ro.SMX_MIXER = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[132], a[133], a[134], a[135]));
      this._ro.TG_THUC_TRON = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[136], a[137], a[138], a[139]));
      this._ro.TG_THUC_XA = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[140], a[141], a[142], a[143]));
      this._ro.SMT = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[144], a[145], a[146], a[147]));
      this._ro.M3_ME = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[148], a[149], a[150], a[151]));
      this._ro.PVM_AG1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[152], a[153], a[154], a[155]));
      this._ro.PVM_AG2 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[156], a[157], a[158], a[159]));
      this._ro.PVM_AG3 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[160], a[161], a[162], a[163]));
      this._ro.PVM_AG4 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[164], a[165], a[166], a[167]));
      this._ro.PVM_AG5 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[168], a[169], a[170], a[171]));
      this._ro.PVM_FD1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[172], a[173], a[174], a[175]));
      this._ro.PVM_AP1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[176], a[177], a[178], a[179]));
      this._ro.PVM_SB1 = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[180], a[181], a[182], a[183]));
      this._ro.TEMP_TUILOC = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[184], a[185], a[186], a[187]));
      this._ro.TEMP_AGG = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[188], a[189], a[190], a[191]));
      this._ro.TEMP_TANSAY = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[192], a[193], a[194], a[195]));
      this._ro.TEMP_NHUA = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[196], a[197], a[198], a[199]));
    }

    private void ReceiveData_DB8(byte[] a)
    {
      this._ro.StatusIO_SAVEREPORT = a[0];
      this._ro.RE_PV_AGG1_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[4], a[5], a[6], a[7]));
      this._ro.RE_PVM_AGG1_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[8], a[9], a[10], a[11]));
      this._ro.RE_PV_AGG2_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[12], a[13], a[14], a[15]));
      this._ro.RE_PVM_AGG2_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[16], a[17], a[18], a[19]));
      this._ro.RE_PV_AGG3_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[20], a[21], a[22], a[23]));
      this._ro.RE_PVM_AGG3_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[24], a[25], a[26], a[27]));
      this._ro.RE_PV_AGG4_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[28], a[29], a[30], a[31]));
      this._ro.RE_PVM_AGG4_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[32], a[33], a[34], a[35]));
      this._ro.RE_PV_AGG5_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[36], a[37], a[38], a[39]));
      this._ro.RE_PVM_AGG5_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[40], a[41], a[42], a[43]));
      this._ro.RE_TEMP_TS_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[44], a[45], a[46], a[47]));
      this._ro.RE_TEMP_AG_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[48], a[49], a[50], a[51]));
      this._ro.RE_PV_FD1_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[52], a[53], a[54], a[55]));
      this._ro.RE_PVM_FD1_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[56], a[57], a[58], a[59]));
      this._ro.RE_PV_AP1_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[60], a[61], a[62], a[63]));
      this._ro.RE_PVM_AP1_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[64], a[65], a[66], a[67]));
      this._ro.RE_TEMP_AP_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[68], a[69], a[70], a[71]));
      this._ro.RE_PV_SB1_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[72], a[73], a[74], a[75]));
      this._ro.RE_PVM_SB1_R = this.ConvertData(MappingHelper.Merge4BytesIntoInt(a[76], a[77], a[78], a[79]));
    }

    private void BindReceivingOnline(ReceivingFromPLC ro)
    {
      try
      {
        if (this.InvokeRequired)
        {
          this.Invoke((Delegate) (() => this.BindReceivingOnline(ro)));
        }
        else
        {
          this.IsRunNoiTron = this._ro.TH_NOI_TRON;
          this.IsRunBTX = this._ro.TH_BTX;
          this.IsRunBTC = this._ro.TH_BTN;
          this._running = this._ro.RUNNING;
          this._TronOnlineAttributes.IsRunning = this._ro.RUNNING;
          if (this._running)
          {
            this.btnBatDau.Visible = false;
            this.gluHopDong.Visible = false;
          }
          else
          {
            this.btnBatDau.Visible = true;
            this.gluHopDong.Visible = true;
          }
          this._isSimulation = this._ro.SIMULATION;
          if (this._isSimulation)
          {
            this.btnSIM.IsTrangThai = ucBtnSIM.TrangThai.Run;
            this.isRealMode = false;
          }
          else
          {
            this.btnSIM.IsTrangThai = ucBtnSIM.TrangThai.Stop;
            this.isRealMode = true;
          }
          this.motorGauTaiFD.IsTrangThai = !this._ro.TH_GAU_FD ? ucMotorMini.TrangThai.Stop : ucMotorMini.TrangThai.Run;
          this.motorGauTaiAGG1.IsTrangThai = !this._ro.TH_GAU_COT_LIEU ? ucMotorMiniN.TrangThai.Stop : ucMotorMiniN.TrangThai.Run;
          this.motorPheuChua01.IsTrangThai = !this._ro.BOM_SBS ? ucMotorFat.TrangThai.Stop : ucMotorFat.TrangThai.Run;
          this.motorPheuChua02.IsTrangThai = !this._ro.CAN_AP1 ? ucMotorFat.TrangThai.Stop : ucMotorFat.TrangThai.Run;
          this.bomNgamPheuChua.IsTrangThai = !this._ro.BOM_NUOC ? ucBomNgam.TrangThai.Stop : ucBomNgam.TrangThai.Run;
          this.ucMotorExtra1.IsTrangThai = !this._ro.QUAT_GIO ? ucMotorExtra.TrangThai.Stop : ucMotorExtra.TrangThai.Run;
          this.motorBomDau.IsTrangThai = !this._ro.BOM_DAU ? ucMotorFat.TrangThai.Stop : ucMotorFat.TrangThai.Run;
          if (this._ro.TIN_HIEU_DAU_DOT)
          {
            this.tinHieuTanSayLua.IsTrangThai = ucTinHieunTanSayLua.TrangThai.Run;
            this.btnDauDot.IsTrangThai = ucTinHieuTanSayQuay.TrangThai.Run;
          }
          else
          {
            this.tinHieuTanSayLua.IsTrangThai = ucTinHieunTanSayLua.TrangThai.Stop;
            this.btnDauDot.IsTrangThai = ucTinHieuTanSayQuay.TrangThai.Stop;
          }
          this.btnTanSay.IsTrangThai = !this._ro.TH_TANG_SAY ? ucTinHieuTanSayQuay.TrangThai.Stop : ucTinHieuTanSayQuay.TrangThai.Run;
          this.bangTaiXien.CheDo = !this._ro.TH_BTX ? ucBTX.Action.Pause : ucBTX.Action.Start;
          this.bangTaiCan.CheDo = !this._ro.TH_BTN ? ucBangTaiCan.Action.Pause : ucBangTaiCan.Action.Start;
          this.btnMayNenKhi.IsTrangThai = !this._ro.MNK ? ucBtnBomKhi.TrangThai.Stop : ucBtnBomKhi.TrangThai.Run;
          this.tinHIeuVitTaiFD.CheDo = !this._ro.VIT_TAI_FD ? ucVitTaiFD.Action.Pause : ucVitTaiFD.Action.Start;
          this.tinHieuSanRung.IsTrangThai = !this._ro.TH_SANG_RUNG ? ucTinHieuSanRung.TrangThai.Stop : ucTinHieuSanRung.TrangThai.Run;
          this.tinHieuCuaNoiMo.Visible = this._ro.TH_CUA_MO;
          this.tinHieuCuaNoiDong.Visible = this._ro.TH_CUA_DONG;
          this.tinHieuCanSiloFD.Visible = this._ro.CAN_FD1;
          this.tinHieuCanSiloAGG1.Visible = this._ro.CAN_AG1;
          this.tinHieuCanSiloAGG2.Visible = this._ro.CAN_AG2;
          this.tinHieuCanSiloAGG3.Visible = this._ro.CAN_AG3;
          this.tinHieuCanSiloAGG4.Visible = this._ro.CAN_AG4;
          this.tinHieuCanSiloAGG5.Visible = this._ro.CAN_AG5;
          this.tinHieuCanSiloAP.Visible = this._ro.CAN_AP1;
          this.tinHieuCanSiloSBS.Visible = this._ro.CAN_SB1;
          this.tinHieuXaCanFD.Visible = this._ro.XA_W_FD1;
          this.tinHieuXaCanAGG.Visible = this._ro.XA_W_AG1;
          this.tinHieuXaCanAP.Visible = this._ro.XA_W_AP1;
          this.tinHieuXaCanSBS.Visible = this._ro.XA_W_SB1;
          if (this._ro.BOM_TUOi_NHUA)
          {
            this.motorBomTuoiNhua.IsTrangThai = ucMotorMini.TrangThai.Run;
            this.tinHieuBomTuoiNhua.Visible = true;
          }
          else
          {
            this.motorBomTuoiNhua.IsTrangThai = ucMotorMini.TrangThai.Stop;
            this.tinHieuBomTuoiNhua.Visible = false;
          }
          this.tinHieuXaCanAGG1.Visible = this._ro.XA_CL1;
          this.tinHieuXaCanAGG2.Visible = this._ro.XA_CL2;
          this.tinHieuXaCanAGG3.Visible = this._ro.XA_CL3;
          this.tinHieuXaCanAGG4.Visible = this._ro.XA_CL4;
          this.tinHieuXaCanAGG5.Visible = this._ro.XA_CL5;
          this.tinHieuBaoMucCaoFD.Visible = this._ro.TH_SILO_FD_HIGHT;
          this.tinHieuBaoMucThapFD.Visible = this._ro.TH_SILO_FD_LOW;
          this.barFullSiloFD.Visible = this._ro.TH_TRAN_FD1;
          this.barFullSiloAGG1.Visible = this._ro.TH_TRAN_AG1;
          this.barFullSiloAGG2.Visible = this._ro.TH_TRAN_AG2;
          this.barFullSiloAGG3.Visible = this._ro.TH_TRAN_AG3;
          this.barFullSiloAGG4.Visible = this._ro.TH_TRAN_AG4;
          this.barFullSiloAGG5.Visible = this._ro.TH_TRAN_AG5;
          this.barFullSiloSBS.Visible = this._ro.TH_TRAN_SB1;
          this.tinHieuCuaMo.Visible = this._ro.MO_CUA;
          this.tinHieuCuaDong.Visible = this._ro.DONG_CUA;
          this.siloFD.KLThucTe = this.CorectData(this._ro.PV_FD1);
          this.weighFD.Weight = this.CorectData(this._ro.WE_FD1);
          this.siloAgg1.KLThucTe = this.CorectData(this._ro.PV_AG1);
          this.siloAgg2.KLThucTe = this.CorectData(this._ro.PV_AG2);
          this.siloAgg3.KLThucTe = this.CorectData(this._ro.PV_AG3);
          this.siloAgg4.KLThucTe = this.CorectData(this._ro.PV_AG4);
          this.siloAgg5.KLThucTe = this.CorectData(this._ro.PV_AG5);
          this.weighAGG.Weight = this.CorectData(this._ro.WE_AG1);
          this.siloAP.KLThucTe = this.CorectData(this._ro.PV_AP1);
          this.weighAP.Weight = this.CorectData(this._ro.WE_AP1);
          this.siloSBS.KLThucTe = this.CorectData(this._ro.PV_SB1);
          this.weighSBS.Weight = this.CorectData(this._ro.WE_SB1);
          this.slMeDaCanFD.SoLuongMeDaTron = this.CorectData(this._ro.SMC_FD1);
          this.slMeDaCanAGG.SoLuongMeDaTron = this.CorectData(this._ro.SMC_AG1);
          this.slMeDaCanAP.SoLuongMeDaTron = this.CorectData(this._ro.SMC_AP1);
          this.slMeDaCanSBS.SoLuongMeDaTron = this.CorectData(this._ro.SMC_SB1);
          this.slMeDaCanNoiTron.SoLuongMeDaTron = this.CorectData(this._ro.SMC_MIXER);
          this.txtNhietDoTuiLocKho.Text = this.CorectData(this._ro.TEMP_TUILOC).ToString();
          this.txtNhietDoAGG.Text = this.CorectData(this._ro.TEMP_AGG).ToString();
          this.txtNhietDoTanSay.Text = this.CorectData(this._ro.TEMP_TANSAY).ToString();
          this.txtNhietDoNhua.Text = this.CorectData(this._ro.TEMP_NHUA).ToString();
          this.ucNoiTron1.TG_TRON = (Decimal) (int) this.CorectData(this._ro.TG_THUC_TRON);
          this.ucNoiTron1.TG_THỰC_XA = (Decimal) (int) this.CorectData(this._ro.TG_THUC_XA);
        }
      }
      catch (ThreadAbortException ex)
      {
        TramTromMessageBox.ShowMessageDialog(ex.ToString());
      }
    }

    private void BindReceivingOnline_DB8(ReceivingFromPLC ro)
    {
      try
      {
        if (this.InvokeRequired)
        {
          this.Invoke((Delegate) (() => this.BindReceivingOnline_DB8(ro)));
        }
        else
        {
          if (this._ro.SAVE_REPORT)
          {
            this.checkDaat.Text = "SAVING";
            this._idSavePLC = 1;
          }
          else if (!this._ro.SAVE_REPORT)
          {
            this.checkDaat.Text = "OUTING";
            this._idSavePLC = 0;
            this._idSave = 0;
          }
          int num = this._ro.RUNNING ? 1 : 0;
          this.SaveData();
        }
      }
      catch (ThreadAbortException ex)
      {
        TramTromMessageBox.ShowMessageDialog(ex.ToString());
      }
    }

    private void SaveData()
    {
      try
      {
        if (this._idSavePLC != 1 || this._idSave != 0 || this._idSavePLC != 1)
          return;
        this._idSave = -1;
        int trangThaiAutoManual = 0;
        if (this._isSimulation)
          trangThaiAutoManual = 1;
        this.SaveMTCT("WeiAgg1", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiAgg2", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiAgg3", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiAgg4", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiAgg5", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiCe1", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiWa1", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiAdd1", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiAdd2", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiAdd3", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        this.SaveMTCT("WeiAdd4", this.soMeDangTron, this.btnCheDoHeThong.IsOn, trangThaiAutoManual, 0);
        ObjPhieuTron selectedPtRun1 = this._selectedPT_Run;
        ++this.soMeDangTron;
        if ((Decimal) this.soMeDangTron > this._sp.SO_ME_TRON)
        {
          ObjPhieuTron selectedPtRun2 = this._selectedPT_Run;
          this._selectedHD_Run = (ObjHopDong) null;
        }
        this.LoadDataMix();
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void SaveMTCT(
      string maCan,
      int sttMe,
      bool isManual,
      int trangThaiAutoManual,
      int plcSaveId)
    {
      foreach (ObjWeiSiloSaving objWeiSiloSaving in this._blstWeiSiloSaving.Where<ObjWeiSiloSaving>((Func<ObjWeiSiloSaving, bool>) (o => o.MaCan == maCan)).ToList<ObjWeiSiloSaving>())
      {
        double valueBat = this.GetValueBat(objWeiSiloSaving.MaSilo);
        double valueBatAuto = this.GetValueBatAuto(objWeiSiloSaving.MaSilo);
        double valueBatMan = this.GetValueBatMan(objWeiSiloSaving.MaSilo);
        this.BuildNewCurMeTronChiTiet(objWeiSiloSaving.MaSilo, sttMe, isManual, trangThaiAutoManual, 0, valueBat, valueBatAuto, valueBatMan, plcSaveId);
      }
    }

    private double GetValueBat(string maSilo)
    {
      if (maSilo != null)
      {
        switch (maSilo.Length)
        {
          case 3:
            switch (maSilo[0])
            {
              case 'C':
                if (maSilo == "Ce1")
                  return (double) (int) this._ro.RE_PV_FD1_R;
                break;
              case 'W':
                if (maSilo == "Wa1")
                  return this._ro.RE_PV_AP1_R;
                break;
            }
            break;
          case 4:
            switch (maSilo[3])
            {
              case '1':
                switch (maSilo)
                {
                  case "Agg1":
                    return (double) (int) this._ro.RE_PV_AGG1_R;
                  case "Add1":
                    return this._ro.RE_PV_SB1_R;
                }
                break;
              case '2':
                switch (maSilo)
                {
                  case "Agg2":
                    return (double) (int) this._ro.RE_PV_AGG2_R;
                  case "Add2":
                    return this._ro.RE_TEMP_TS_R;
                }
                break;
              case '3':
                switch (maSilo)
                {
                  case "Agg3":
                    return (double) (int) this._ro.RE_PV_AGG3_R;
                  case "Add3":
                    return this._ro.RE_TEMP_AG_R;
                }
                break;
              case '4':
                switch (maSilo)
                {
                  case "Agg4":
                    return (double) (int) this._ro.RE_PV_AGG4_R;
                  case "Add4":
                    return this._ro.RE_TEMP_AP_R;
                }
                break;
              case '5':
                if (maSilo == "Agg5")
                  return (double) (int) this._ro.RE_PV_AGG5_R;
                break;
            }
            break;
        }
      }
      return 0.0;
    }

    private double GetValueBatAuto(string maSilo)
    {
      if (maSilo != null)
      {
        switch (maSilo.Length)
        {
          case 3:
            switch (maSilo[0])
            {
              case 'C':
                if (maSilo == "Ce1")
                  return (double) (int) this._ro.RE_PV_FD1_R;
                break;
              case 'W':
                if (maSilo == "Wa1")
                  return this._ro.RE_PV_AP1_R;
                break;
            }
            break;
          case 4:
            switch (maSilo[3])
            {
              case '1':
                switch (maSilo)
                {
                  case "Agg1":
                    return (double) (int) this._ro.RE_PV_AGG1_R;
                  case "Add1":
                    return (double) (int) this._ro.RE_PV_SB1_R;
                }
                break;
              case '2':
                switch (maSilo)
                {
                  case "Agg2":
                    return (double) (int) this._ro.RE_PV_AGG2_R;
                  case "Add2":
                    return this._ro.RE_TEMP_TS_R;
                }
                break;
              case '3':
                switch (maSilo)
                {
                  case "Agg3":
                    return (double) (int) this._ro.RE_PV_AGG3_R;
                  case "Add3":
                    return this._ro.RE_TEMP_AG_R;
                }
                break;
              case '4':
                switch (maSilo)
                {
                  case "Agg4":
                    return (double) (int) this._ro.RE_PV_AGG4_R;
                  case "Add4":
                    return this._ro.RE_TEMP_AP_R;
                }
                break;
              case '5':
                if (maSilo == "Agg5")
                  return (double) (int) this._ro.RE_PV_AGG5_R;
                break;
            }
            break;
        }
      }
      return 0.0;
    }

    private double GetValueBatMan(string maSilo)
    {
      if (maSilo != null)
      {
        switch (maSilo.Length)
        {
          case 3:
            switch (maSilo[0])
            {
              case 'C':
                if (maSilo == "Ce1")
                  return (double) (int) this._ro.RE_PVM_FD1_R;
                break;
              case 'W':
                if (maSilo == "Wa1")
                  return this._ro.RE_PVM_AP1_R;
                break;
            }
            break;
          case 4:
            switch (maSilo[3])
            {
              case '1':
                switch (maSilo)
                {
                  case "Agg1":
                    return (double) (int) this._ro.RE_PVM_AGG1_R;
                  case "Add1":
                    return (double) (int) this._ro.RE_PVM_SB1_R;
                }
                break;
              case '2':
                if (maSilo == "Agg2")
                  return (double) (int) this._ro.RE_PVM_AGG2_R;
                break;
              case '3':
                if (maSilo == "Agg3")
                  return (double) (int) this._ro.RE_PVM_AGG3_R;
                break;
              case '4':
                if (maSilo == "Agg4")
                  return (double) (int) this._ro.RE_PVM_AGG4_R;
                break;
              case '5':
                if (maSilo == "Agg5")
                  return (double) (int) this._ro.RE_PVM_AGG5_R;
                break;
            }
            break;
        }
      }
      return 0.0;
    }

    private bool BuildNewCurMeTronChiTiet(
      string strMaSilo,
      int num_bat_can,
      bool isManual,
      int trangThaiAutoMan,
      int phieuTronID,
      double valueBat,
      double valueBatAuto,
      double valueBatMan,
      int plcSaveId)
    {
      try
      {
        ObjMACSilo macSilo = this.GetMacSilo(strMaSilo, this._blstMACSilo_Run);
        ObjSilo silo = this.GetSilo(strMaSilo, this._blstSilo);
        SiloOnline siloOnline = this.GetSiloOnline(strMaSilo);
        this._presenter.BuildNewMeTronChiTiet(strMaSilo, macSilo, silo, siloOnline, num_bat_can, isManual, trangThaiAutoMan, phieuTronID, valueBat, valueBatAuto, valueBatMan, plcSaveId);
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    public ObjMACSilo GetMacSilo(string strMaSilo, BindingList<ObjMACSilo> blstMACSilo)
    {
      if (blstMACSilo != null)
      {
        foreach (ObjMACSilo macSilo in (Collection<ObjMACSilo>) blstMACSilo)
        {
          if (macSilo.NPSiloMaSilo == strMaSilo)
            return macSilo;
        }
      }
      return (ObjMACSilo) null;
    }

    public ObjSilo GetSilo(string maSilo, BindingList<ObjSilo> blstSilo)
    {
      foreach (ObjSilo silo in (Collection<ObjSilo>) blstSilo)
      {
        if (silo.MaSilo == maSilo)
          return silo;
      }
      return (ObjSilo) null;
    }

    public SiloOnline GetSiloOnline(string strMaSilo)
    {
      SiloOnline siloOnline = (SiloOnline) null;
      if (strMaSilo != null)
      {
        switch (strMaSilo.Length)
        {
          case 3:
            switch (strMaSilo[0])
            {
              case 'C':
                if (strMaSilo == "Ce1")
                {
                  siloOnline = this.siloFD.SiloOnline;
                  break;
                }
                break;
              case 'W':
                if (strMaSilo == "Wa1")
                {
                  siloOnline = this.siloAP.SiloOnline;
                  break;
                }
                break;
            }
            break;
          case 4:
            switch (strMaSilo[3])
            {
              case '1':
                switch (strMaSilo)
                {
                  case "Add1":
                    siloOnline = this.siloSBS.SiloOnline;
                    break;
                  case "Agg1":
                    siloOnline = this.siloAgg1.SiloOnline;
                    break;
                }
                break;
              case '2':
                if (strMaSilo == "Agg2")
                {
                  siloOnline = this.siloAgg2.SiloOnline;
                  break;
                }
                break;
              case '3':
                if (strMaSilo == "Agg3")
                {
                  siloOnline = this.siloAgg3.SiloOnline;
                  break;
                }
                break;
              case '4':
                if (strMaSilo == "Agg4")
                {
                  siloOnline = this.siloAgg4.SiloOnline;
                  break;
                }
                break;
              case '5':
                if (strMaSilo == "Agg5")
                {
                  siloOnline = this.siloAgg5.SiloOnline;
                  break;
                }
                break;
            }
            break;
        }
      }
      return siloOnline;
    }

    private Decimal CorectData(double data)
    {
      if (data > 32000.0 || data < -32000.0)
        return 0M;
      Decimal num = (Decimal) data;
      return data > double.MaxValue || data < double.MinValue ? 0M : num;
    }

    private double ConvertData(uint data)
    {
      double num1 = (double) data.ConvertToFloat();
      double num2;
      return num1 > 32000.0 || num1 < -32000.0 ? (num2 = 0.0) : num1;
    }

    private void ShowFrmTimerPara()
    {
      TimerParaMngView ctrView = new TimerParaMngView();
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListTimerPara();
      this.SendData_DB5_NewTread();
    }

    private void ShowFrmSilo(ucBaseSilo slBase, string maSilo)
    {
      Enums.FormAction action = Enums.FormAction.Edit;
      ObjSilo sl = this._blstSilo.Where<ObjSilo>((Func<ObjSilo, bool>) (o => o.MaSilo == maSilo)).First<ObjSilo>();
      bool showDoAm = false;
      NewSiloView ctrView = new NewSiloView(sl, action, false, showDoAm, false);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      slBase.SiloDesc = sl.MaterialName;
      this.BuildSetPoint_NotHD();
      this.SendData_DB3_NewTread();
    }

    private void ShowWeighMngView(string weiCode)
    {
      NewWeightView ctrView = new NewWeightView(this._blstWeigh.Where<ObjWeigh>((Func<ObjWeigh, bool>) (o => o.WeighCode == weiCode)).First<ObjWeigh>(), Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.BuildSetPoint_NotHD();
      this.SendData_DB4_NewTread();
    }

    private void siloFD_CaptionClick(object sender, EventArgs e)
    {
      this.ShowFrmSilo(sender as ucBaseSilo, "Ce1");
    }

    private void siloAgg1_CaptionClick(object sender, EventArgs e)
    {
      this.ShowFrmSilo(sender as ucBaseSilo, "Agg1");
    }

    private void siloAgg2_CaptionClick(object sender, EventArgs e)
    {
      this.ShowFrmSilo(sender as ucBaseSilo, "Agg2");
    }

    private void siloAgg3_CaptionClick(object sender, EventArgs e)
    {
      this.ShowFrmSilo(sender as ucBaseSilo, "Agg3");
    }

    private void siloAgg4_CaptionClick(object sender, EventArgs e)
    {
      this.ShowFrmSilo(sender as ucBaseSilo, "Agg4");
    }

    private void siloAgg5_CaptionClick(object sender, EventArgs e)
    {
      this.ShowFrmSilo(sender as ucBaseSilo, "Agg5");
    }

    private void siloAP_CaptionClick(object sender, EventArgs e)
    {
      this.ShowFrmSilo(sender as ucBaseSilo, "Wa1");
    }

    private void siloSBS_CaptionClick(object sender, EventArgs e)
    {
      this.ShowFrmSilo(sender as ucBaseSilo, "Add1");
    }

    private void weighFD_WeightClick(object sender, EventArgs e) => this.ShowWeighMngView("Ce1");

    private void weighAGG_WeightClick(object sender, EventArgs e) => this.ShowWeighMngView("Agg1");

    private void weighAP_WeightClick(object sender, EventArgs e) => this.ShowWeighMngView("Wa1");

    private void weighSBS_WeightClick(object sender, EventArgs e) => this.ShowWeighMngView("Add1");

    private void btnVanCanFD_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_FD1 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanFD_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_FD1 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG1_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG1 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG1_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG1 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG2_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG2 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG2_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG2 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG3_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG3 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG3_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG3 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG4_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG4 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG4_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG4 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG5_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG5 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAGG5_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AG5 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAP_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AP1 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanAP_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AP1 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanSBS_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_SB1 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnVanCanSBS_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_SB1 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_FD_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_FD1 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_FD_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_FD1 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AG1_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG1 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AG1_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG1 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AGG2_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG2 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AGG2_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG2 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AGG3_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG3 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AGG3_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG3 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AGG4_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG4 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AGG4_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG4 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AGG5_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG5 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AGG5_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AG5 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AP_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AP1 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_AP_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_AP1 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_SBS_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_SB1 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnFU_SBS_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_FU_SB1 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnXaCanFD_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaCanFD.IsOn)
      {
        this._so.SendingCommand.SW_XA_W_FD1 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_W_FD1 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaCanAGG_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaCanAGG.IsOn)
      {
        this._so.SendingCommand.SW_XA_W_AG1 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_W_AG1 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaCanAP_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaCanAP.IsOn)
      {
        this._so.SendingCommand.SW_XA_W_AP1 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_W_AP1 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaCanSBS_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaCanSBS.IsOn)
      {
        this._so.SendingCommand.SW_XA_W_SB1 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_W_SB1 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnRungCL1_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_RUNG_CL1 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnRungCL1_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_RUNG_CL1 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnRungCL2_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_RUNG_CL2 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnRungCL2_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_RUNG_CL2 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnRungCL3_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_RUNG_CL3 = true;
      this.SendData_DB2_NewTread();
    }

    private void btnRungCL3_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_RUNG_CL3 = false;
      this.SendData_DB2_NewTread();
    }

    private void btnXaCanAGG1_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaCanAGG1.IsOn)
      {
        this._so.SendingCommand.SW_XA_CL1 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_CL1 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaCanAGG2_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaCanAGG2.IsOn)
      {
        this._so.SendingCommand.SW_XA_CL2 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_CL2 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaCanAGG3_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaCanAGG3.IsOn)
      {
        this._so.SendingCommand.SW_XA_CL3 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_CL3 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaCanAGG4_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaCanAGG4.IsOn)
      {
        this._so.SendingCommand.SW_XA_CL4 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_CL4 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaCanAGG5_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaCanAGG5.IsOn)
      {
        this._so.SendingCommand.SW_XA_CL5 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_CL5 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnPheuSBS_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnPheuSBS.IsOn)
      {
        this._so.SendingCommand.SW_PHEU_SBS = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_PHEU_SBS = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void motorGauTaiFD_ButtonMouseDown(object sender, EventArgs e)
    {
      if (!this._ro.TH_GAU_FD)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Gàu tải FN?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_GAU_FD = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_GAU_FD = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        this._so.SendingCommand.NN_GAU_FD = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_GAU_FD = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void motorGauTaiFD_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_GAU_FD = false;
      this.SendData_DB2_NewTread();
    }

    private void motorGauTaiAGG1_ButtonMouseDown(object sender, EventArgs e)
    {
      if (!this._ro.TH_GAU_COT_LIEU)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Gàu tải cốt liệu?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_GAU_COT_LIEU = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_GAU_COT_LIEU = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        this._so.SendingCommand.NN_GAU_COT_LIEU = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_GAU_COT_LIEU = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void motorGauTaiAGG1_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_GAU_COT_LIEU = false;
      this.SendData_DB2_NewTread();
    }

    private void btnSanRung_ButtonMouseDown(object sender, EventArgs e)
    {
      if (!this._ro.TH_SANG_RUNG)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Sàn rung?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_SAN_RUNG = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_SAN_RUNG = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        this._so.SendingCommand.NN_SAN_RUNG = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_SAN_RUNG = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnSanRung_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_SAN_RUNG = false;
      this.SendData_DB2_NewTread();
    }

    private void ucBtnVitTai1_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_VIT_TAI_FD = true;
      this.SendData_DB2_NewTread();
    }

    private void ucBtnVitTai1_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_VIT_TAI_FD = false;
      this.SendData_DB2_NewTread();
    }

    private void tinHIeuVitTaiFD_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_VIT_TAI_FD = true;
      this.SendData_DB2_NewTread();
    }

    private void tinHIeuVitTaiFD_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_VIT_TAI_FD = false;
      this.SendData_DB2_NewTread();
    }

    private void btnMayNenKhi_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_MNK = true;
      this.SendData_DB2_NewTread();
    }

    private void btnMayNenKhi_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_MNK = false;
      this.SendData_DB2_NewTread();
    }

    private void btnNoiTronL_ButtonMouseDown(object sender, EventArgs e)
    {
      if (!this._ro.TH_NOI_TRON)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Nồi Trộn?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_NOI_TRON = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_NOI_TRON = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        this._so.SendingCommand.NN_NOI_TRON = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_NOI_TRON = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnNoiTronL_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_NOI_TRON = false;
      this.SendData_DB2_NewTread();
    }

    private void btnNoiTronR_ButtonMouseDown(object sender, EventArgs e)
    {
      if (!this._ro.TH_NOI_TRON)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Nồi Trộn?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_NOI_TRON = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_NOI_TRON = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        this._so.SendingCommand.NN_NOI_TRON = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_NOI_TRON = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnNoiTronR_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_NOI_TRON = false;
      this.SendData_DB2_NewTread();
    }

    private void bangTaiXien_ButtonMouseDown(object sender, EventArgs e)
    {
      if (this.bangTaiXien.CheDo == ucBTX.Action.Pause)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Băng Tải Xiên?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_BTX = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_BTX = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        if (this.bangTaiXien.CheDo != ucBTX.Action.Start)
          return;
        this._so.SendingCommand.NN_BTX = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_BTX = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void bangTaiXien_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BTX = false;
      this.SendData_DB2_NewTread();
    }

    private void bangTaiCan_ButtonMouseDown(object sender, EventArgs e)
    {
      if (this.bangTaiCan.CheDo == ucBangTaiCan.Action.Pause)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Băng Tải Ngang?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_BTN = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_BTN = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        this._so.SendingCommand.NN_BTN = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_BTN = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void bangTaiCan_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BTN = false;
      this.SendData_DB2_NewTread();
    }

    private void motorBomDau_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BOM_DAU = true;
      this.SendData_DB2_NewTread();
    }

    private void motorBomDau_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BOM_DAU = false;
      this.SendData_DB2_NewTread();
    }

    private void motorPheuChua01_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BOM_SBS = true;
      this.SendData_DB2_NewTread();
    }

    private void motorPheuChua01_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BOM_SBS = false;
      this.SendData_DB2_NewTread();
    }

    private void ucMotorExtra1_ButtonMouseDown(object sender, EventArgs e)
    {
      if (!this._ro.QUAT_GIO)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Quạt gió?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_QUAT_GIO = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_QUAT_GIO = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        this._so.SendingCommand.NN_QUAT_GIO = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_QUAT_GIO = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void ucMotorExtra1_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_QUAT_GIO = false;
      this.SendData_DB2_NewTread();
    }

    private void motorPheuChua02_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AP1 = true;
      this.SendData_DB2_NewTread();
    }

    private void motorPheuChua02_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_CAN_AP1 = false;
      this.SendData_DB2_NewTread();
    }

    private void bomNgamPheuChua_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BOM_NUOC = true;
      this.SendData_DB2_NewTread();
    }

    private void bomNgamPheuChua_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BOM_NUOC = false;
      this.SendData_DB2_NewTread();
    }

    private void btnTanSay_ButtonMouseDown(object sender, EventArgs e)
    {
      if (!this._ro.TH_TANG_SAY)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Tan sấy?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_TANG_SAY = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_TANG_SAY = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        this._so.SendingCommand.NN_TANG_SAY = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_TANG_SAY = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnTanSay_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_TANG_SAY = false;
      this.SendData_DB2_NewTread();
    }

    private void motorBomTuoiNhua_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BOMTUOINHUA = true;
      this.SendData_DB2_NewTread();
    }

    private void motorBomTuoiNhua_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_BOMTUOINHUA = false;
      this.SendData_DB2_NewTread();
    }

    private void btnXaHetAGG_ButtonMouseDown(object sender, EventArgs e)
    {
      if (this.btnXaHetAGG.IsTrangThai == ucBtnXAHETAGG.TrangThai.Stop)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Vệ sinh phễu AGG?") == DialogResult.Yes)
        {
          this._so.SendingCommand.NN_XAHETAGG = true;
          this.SendData_DB2_NewTread();
          Thread.Sleep(200);
          this._so.SendingCommand.NN_XAHETAGG = false;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        if (this.btnXaHetAGG.IsTrangThai != ucBtnXAHETAGG.TrangThai.Run)
          return;
        this._so.SendingCommand.NN_XAHETAGG = true;
        this.SendData_DB2_NewTread();
        Thread.Sleep(200);
        this._so.SendingCommand.NN_XAHETAGG = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaHetAGG_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_XAHETAGG = false;
      this.SendData_DB2_NewTread();
    }

    private void btnDauDot_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_DAU_DOT = true;
      this.SendData_DB2_NewTread();
    }

    private void btnDauDot_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_DAU_DOT = false;
      this.SendData_DB2_NewTread();
    }

    private void btnXaHetAGG_ButtonClick(object sender, EventArgs e)
    {
    }

    private void btnBatDau_ButtonClick(object sender, EventArgs e)
    {
      if (!this.btnBatDau.Visible)
        return;
      this.InitRunning();
    }

    private void btnDung_ButtonClick(object sender, EventArgs e) => this.DoPause();

    private void DoPause()
    {
      EventLogController.InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "F2", string.Empty, string.Empty, string.Empty);
      if (!this.CheckConnection())
        return;
      try
      {
        if (this.btnDung.IsOn)
        {
          if (TramTromMessageBox.ShowYesNoDialog(GlobalValues.Messages.ConfirmPausePhieuTron) != DialogResult.Yes)
            return;
          this._so.SendingCommand.F2_SW_PAU = true;
          this.SendData_DB2_NewTread();
          StatusConnected.CheckOpenSof(true, false);
        }
        else
        {
          this._so.SendingCommand.F2_SW_PAU = false;
          this.SendData_DB2_NewTread();
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void btnHuy_ButtonClick(object sender, EventArgs e)
    {
      this._so.SendingCommand.F3_NN_STOP = true;
      this.SendData_DB2_NewTread();
      Thread.Sleep(200);
      this._so.SendingCommand.F3_NN_STOP = false;
      this.SendData_DB2_NewTread();
    }

    private void btnSIM_ButtonClick(object sender, EventArgs e) => this.DoMoPhong();

    private void DoMoPhong()
    {
      if (!this._ro.SIMULATION)
      {
        if (TramTromMessageBox.ShowYesNoDialog("Xác nhận 'BẬT' Mô Phỏng?") == DialogResult.Yes)
        {
          this._so.SendingCommand.F4_SW_SIM = true;
          this.SendData_DB2_NewTread();
        }
      }
      else
      {
        this._so.SendingCommand.F4_SW_SIM = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnCheDoHeThong_ButtonClick(object sender, EventArgs e)
    {
      try
      {
        if (this.btnCheDoHeThong.IsOn)
        {
          this._so.SendingCommand.SW_MAN_AUTO = true;
          this.SendData_DB2_NewTread();
        }
        else
        {
          this._so.SendingCommand.SW_MAN_AUTO = false;
          this.SendData_DB2_NewTread();
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void btnCheDoXaCan_ButtonClick(object sender, EventArgs e)
    {
      try
      {
        if (this.btnCheDoXaCan.IsOn)
        {
          this._so.SendingCommand.SW_XA_COT_LIEU = true;
          this.SendData_DB2_NewTread();
        }
        else
        {
          this._so.SendingCommand.SW_XA_COT_LIEU = false;
          this.SendData_DB2_NewTread();
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void btnCheDoNapLieu_ButtonClick(object sender, EventArgs e)
    {
      try
      {
        if (this.btnCheDoNapLieu.IsOn)
        {
          this._so.SendingCommand.SW_NAP_NOI_TRON = true;
          this.SendData_DB2_NewTread();
        }
        else
        {
          this._so.SendingCommand.SW_NAP_NOI_TRON = false;
          this.SendData_DB2_NewTread();
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void btnCheDoCuaNoi_ButtonClick(object sender, EventArgs e)
    {
      try
      {
        if (this.btnCheDoCuaNoi.IsOn)
        {
          this._so.SendingCommand.SW_XA_NOI_TRON = true;
          this.SendData_DB2_NewTread();
        }
        else
        {
          this._so.SendingCommand.SW_XA_NOI_TRON = false;
          this.SendData_DB2_NewTread();
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void btnMoCuaNoi_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_MO_CUA = true;
      this.SendData_DB2_NewTread();
    }

    private void btnMoCuaNoi_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_MO_CUA = false;
      this.SendData_DB2_NewTread();
    }

    private void btnDongCuaNoi_ButtonMouseDown(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_DONG_CUA = true;
      this.SendData_DB2_NewTread();
    }

    private void btnDongCuaNoi_ButtonMouseUp(object sender, EventArgs e)
    {
      this._so.SendingCommand.NN_DONG_CUA = false;
      this.SendData_DB2_NewTread();
    }

    private void gluHopDong_EditValueChanged(object sender, EventArgs e)
    {
      if (this.gluHopDong.GetSelectedDataRow() is ObjDuLieuTron selectedDataRow)
      {
        this.UpdateInfoPT(selectedDataRow);
        this.BuildSetPoint(this._presenter.GetHopDongByKey(selectedDataRow.HopDongID.Value), true);
        this.Send_Data_DB_4_To_PLC();
      }
      else
      {
        int num = (int) MessageBox.Show("Không có đối tượng nào được chọn hoặc không khớp kiểu dữ liệu.");
      }
    }

    private void InitRunning(bool checkIsRunning = true)
    {
      if (!this.CheckConnection())
        return;
      if (this._TronOnlineAttributes.IsRunning && checkIsRunning)
      {
        string systemRunningCannotF1 = GlobalValues.Messages.SystemRunningCannotF1;
      }
      else
      {
        if (this.gluHopDong.EditValue == null)
          return;
        if (this.gluHopDong.GetSelectedDataRow() is ObjDuLieuTron selectedDataRow)
        {
          int? hopDongId = selectedDataRow.HopDongID;
          if (hopDongId.HasValue)
          {
            if (TramTromMessageBox.ShowYesNoDialog(string.Format(GlobalValues.Messages.RunningInfos, (object) selectedDataRow.TenHopDong, (object) selectedDataRow.DLT_KLDuTinh)) == DialogResult.No)
              return;
            TronOnlineDataPresenter presenter = this._presenter;
            hopDongId = selectedDataRow.HopDongID;
            int hdID = hopDongId.Value;
            this._selectedHD_Run = presenter.GetHopDongByKey(hdID);
            if (this._selectedHD_Run == null)
              return;
            this._selectedPT_Run = this._presenter.CreateAndSaveNewPhieuTron(this._selectedHD_Run, this.isRealMode);
            this.soMeDangTron = 1;
            this.txtMaPhieuTron.Text = this._selectedPT_Run.MaPhieuTron;
            if (this._selectedPT_Run == null)
              return;
            this.BuildSetPoint(this._selectedHD_Run, true);
            this._so.SendingCommand.F1_NN_RUN = true;
            this.SendData_DB2_NewTread();
            Thread.Sleep(100);
            this._so.SendingCommand.F1_NN_RUN = false;
            this.SendData_DB2_NewTread();
            this.Send_Data_DB_4_To_PLC();
            return;
          }
        }
        TramTromMessageBox.ShowWarningDialog(GlobalValues.Messages.EmptyDataCannotF1);
      }
    }

    private void txtTG_BomTuoiNhua_EditValueChanged(object sender, EventArgs e)
    {
      this._sp_NotHD.TG_Bom_Tuoi_Nhua = double.Parse(this.txtTG_BomTuoiNhua.Text);
      this.SendData_DB5_NewTread();
    }

    private void txtTG_BomTuoiNhua_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
        return;
      e.Handled = true;
    }

    private void gluHopDong_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Kind == ButtonPredefines.Ellipsis)
      {
        if (!(this.gluHopDong.GetSelectedDataRow() is ObjDuLieuTron selectedDataRow))
          return;
        NewDuLieuTronView ctrView = new NewDuLieuTronView(new ObjHopDong()
        {
          HopDongID = selectedDataRow.HopDongID.Value
        }, Enums.FormAction.Edit, true);
        ctrView.CanAddMAC = true;
        ctrView.CanViewMAC = true;
        ctrView.CanEditMAC = true;
        ViewManager.ShowViewDialog((ControlViewBase) ctrView);
        if (ctrView.GetDialogResult() == DialogResult.OK)
        {
          int num1 = selectedDataRow.Status.Value;
          ObjHopDong hopDongByMaHd = this._ser.GetHopDongByMaHD(ctrView.GetSavedHopDong().MaHopDong);
          DuLieuTronHelper.CopyToDuLieuTron_FromHopDong(hopDongByMaHd, selectedDataRow);
          selectedDataRow.Status = new int?(num1);
          int? status = selectedDataRow.Status;
          int num2 = 1;
          if (!(status.GetValueOrDefault() == num2 & status.HasValue))
            selectedDataRow.Status = new int?(0);
          ObjDuLieuTron objDuLieuTron = this._presenter.UpdateDuLieuTron(selectedDataRow);
          this.gluHopDong.Refresh();
          if (!this._TronOnlineAttributes.IsRunning)
            this.BuildSetPoint(hopDongByMaHd, false);
          this.UpdateInfoPT(objDuLieuTron);
        }
      }
      if (e.Button.Kind == ButtonPredefines.Plus)
      {
        NewDuLieuTronView ctrView = new NewDuLieuTronView((ObjHopDong) null, Enums.FormAction.New);
        ViewManager.ShowViewDialog((ControlViewBase) ctrView);
        if (ctrView.GetDialogResult() == DialogResult.OK)
        {
          this._presenter.ListDuLieuTron();
          this.gluHopDong.Refresh();
          this.gluHopDong.EditValue = (object) null;
        }
      }
      if (e.Button.Kind != ButtonPredefines.Search)
        return;
      this.ChangeHopDong(-1);
    }

    private void UpdateInfoPT(ObjDuLieuTron objDuLieuTron)
    {
      if (objDuLieuTron == null || !objDuLieuTron.HopDongID.HasValue)
        return;
      int? hopDongId = objDuLieuTron.HopDongID;
      int num1 = 0;
      if (hopDongId.GetValueOrDefault() == num1 & hopDongId.HasValue)
        return;
      ObjHopDong hopDongByKey = this._presenter.GetHopDongByKey(objDuLieuTron.HopDongID.Value);
      if (hopDongByKey == null)
        return;
      int khachHangId = hopDongByKey.KhachHangID.Value;
      int congTruongId = hopDongByKey.CongTruongID.Value;
      int num2 = hopDongByKey.MACID.Value;
      this.txtKhachHang.Text = this._presenter.GetKhachHangByKey(khachHangId).TenKhachHang;
      this.txtCongTruong.Text = this._presenter.GetCongTruongByKey(congTruongId).TenCongTruong;
      this.txtMAC.Text = hopDongByKey.NPMACTenMAC;
      this.txtKhoiLuong.Text = hopDongByKey.DLT_KLDuTinh.ToString();
    }

    private void glueHopDong_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
    {
      GridView view = sender as GridView;
      if (e.MenuType != GridMenuType.Row)
        return;
      int rowHandle = e.HitInfo.RowHandle;
      e.Menu.Items.Clear();
      e.Menu.Items.Add(new DXMenuItem("&Tạo mới Hợp đồng", new EventHandler(this.DoCreateNewDuLieuTron), (Image) ResourceNhua.plus_dlt)
      {
        Tag = (object) new VanHanh.RowInfo(view, rowHandle),
        Enabled = true
      });
      e.Menu.Items.Add(new DXMenuItem("&Chỉnh sửa Hợp đồng", new EventHandler(this.DoEditDuLieuTron), (Image) ResourceNhua.edit_dlt)
      {
        Tag = (object) new VanHanh.RowInfo(view, rowHandle),
        Enabled = true
      });
      e.Menu.Items.Add(new DXMenuItem("&Tìm Hợp đồng đã tạo", new EventHandler(this.DoChangeDuLieuTron), (Image) ResourceNhua.search_dll)
      {
        Tag = (object) new VanHanh.RowInfo(view, rowHandle),
        Enabled = true
      });
      e.Menu.Items.Add(new DXMenuItem("&Xóa dữ liệu trộn", new EventHandler(this.DoRemoveDuLieuTron), (Image) ResourceNhua.delete_dlt)
      {
        Tag = (object) new VanHanh.RowInfo(view, rowHandle),
        Enabled = true
      });
    }

    private void DoCreateNewDuLieuTron(object sender, EventArgs e)
    {
      this.CreateNewDuLieuTron(((sender as DXMenuItem).Tag as VanHanh.RowInfo).RowHandle);
    }

    private void DoEditDuLieuTron(object sender, EventArgs e)
    {
      this.EditHopDong(((sender as DXMenuItem).Tag as VanHanh.RowInfo).RowHandle);
    }

    private void DoChangeDuLieuTron(object sender, EventArgs e)
    {
      this.ChangeHopDong(((sender as DXMenuItem).Tag as VanHanh.RowInfo).RowHandle);
    }

    private void DoRemoveDuLieuTron(object sender, EventArgs e)
    {
      this.RemoveHopDong(((sender as DXMenuItem).Tag as VanHanh.RowInfo).RowHandle);
    }

    private void CreateNewDuLieuTron(int rowHandle)
    {
      NewHopDongView ctrView = new NewHopDongView((ObjHopDong) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      ObjHopDong hopDongByMaHd = this._ser.GetHopDongByMaHD(ctrView.GetSavedHopDong().MaHopDong);
      ObjDuLieuTron objDuLieuTron = new ObjDuLieuTron();
      DuLieuTronHelper.CopyToDuLieuTron_FromHopDong(hopDongByMaHd, objDuLieuTron);
      objDuLieuTron.DLT_KLDuTinhCuaTungMe_NoiB = new Decimal?((Decimal) 1);
      objDuLieuTron.Status = new int?(0);
      objDuLieuTron.Activated = true;
      this._blstDuLieuTron.Add(this._presenter.AddDuLieuTron(objDuLieuTron));
      this.gluHopDong.Refresh();
    }

    private void EditHopDong(int rowHandle)
    {
      if (!(this.glueHopDong.GetRow(rowHandle) is ObjDuLieuTron row) || !row.HopDongID.HasValue)
      {
        TramTromMessageBox.ShowWarningDialog("KHÔNG THỂ CHỈNH SỬA");
      }
      else
      {
        ObjHopDong ct = new ObjHopDong();
        int? nullable = row.HopDongID;
        ct.HopDongID = nullable.Value;
        NewHopDongView ctrView = new NewHopDongView(ct, Enums.FormAction.Edit);
        ViewManager.ShowViewDialog((ControlViewBase) ctrView);
        if (ctrView.GetDialogResult() != DialogResult.OK)
          return;
        nullable = row.Status;
        int num1 = nullable.Value;
        DuLieuTronHelper.CopyToDuLieuTron_FromHopDong(this._ser.GetHopDongByMaHD(ctrView.GetSavedHopDong().MaHopDong), row);
        row.Status = new int?(num1);
        int? status = row.Status;
        int num2 = 1;
        if (!(status.GetValueOrDefault() == num2 & status.HasValue))
          row.Status = new int?(0);
        this._presenter.UpdateDuLieuTron(row);
        this.gluHopDong.Refresh();
      }
    }

    private void ChangeHopDong(int rowHandle)
    {
      ObjDuLieuTron row = this.glueHopDong.GetRow(rowHandle) as ObjDuLieuTron;
      UcSearchHopDong ctrView = new UcSearchHopDong();
      ctrView.SearchStatus = new int?(0);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      ObjHopDong selectedObjects = ctrView.GetSelectedObjects();
      if (row != null)
      {
        DuLieuTronHelper.CopyToDuLieuTron_FromHopDong(selectedObjects, row);
        row.DLT_KLDuTinhCuaTungMe_NoiB = new Decimal?((Decimal) 1);
        row.Status = new int?(0);
        this._presenter.UpdateDuLieuTron(row);
        this.glueHopDong.RefreshData();
      }
      else
      {
        ObjDuLieuTron objDuLieuTron = new ObjDuLieuTron();
        DuLieuTronHelper.CopyToDuLieuTron_FromHopDong(selectedObjects, objDuLieuTron);
        objDuLieuTron.DLT_KLDuTinhCuaTungMe_NoiB = new Decimal?((Decimal) 1);
        objDuLieuTron.Status = new int?(0);
        this._blstDuLieuTron.Add(this._presenter.AddDuLieuTron(objDuLieuTron));
        this.glueHopDong.RefreshData();
      }
    }

    private void RemoveHopDong(int rowHandle)
    {
      if (!(this.glueHopDong.GetRow(rowHandle) is ObjDuLieuTron row) || !row.HopDongID.HasValue)
      {
        TramTromMessageBox.ShowWarningDialog(GlobalValues.Messages.EmptyDataCannotDelete);
      }
      else
      {
        this._presenter.DeleteDulieuTron(row.DuLieuTronID);
        this._blstDuLieuTron.Remove(row);
        this.glueHopDong.RefreshData();
        if (this._TronOnlineAttributes.IsRunning)
          return;
        this.glueHopDong.FocusedRowHandle = 0;
      }
    }

    private void gluTaiXe_EditValueChanged(object sender, EventArgs e) => this.SaveTaiXe();

    private void glueBienSo_EditValueChanged(object sender, EventArgs e) => this.SaveBienSo();

    private void SaveTaiXe()
    {
      try
      {
        if (!ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).SaveTaiXeTronOnline(Convert.ToInt32(this.gluTaiXe.EditValue)))
          return;
        ConfigManager.TramTronConfig.DriverNum = (int) this.gluTaiXe.EditValue;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void SaveBienSo()
    {
      try
      {
        if (!ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).SaveXeTronOnline((int) this.glueBienSo.EditValue))
          return;
        ConfigManager.TramTronConfig.XeNum = (int) this.glueBienSo.EditValue;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void LoadDataMix()
    {
      DateTime datValue = DateTime.Now.AddDays(-50.0);
      DateTime now = DateTime.Now;
      this._blstDataMix = this._presenter.ListDataMix_ByCondition_re(new DateTime?(Searching.BuildNew_StartDateTime(datValue, datValue.TimeOfDay)), new TimeSpan?(now.TimeOfDay), new DateTime?(Searching.BuildNew_EndDateTime(now, now.TimeOfDay)), new TimeSpan?(now.TimeOfDay), "", new int?(), new int?(), new int?(), new int?(), new int?(), new int?(), new int?(), new bool?());
      BindingList<Objvw_DataMix> list = new BindingList<Objvw_DataMix>();
      list.Add(this._blstDataMix[0]);
      this.Invoke((Delegate) (() => this.UpdateUI(list)));
    }

    private void UpdateUI(BindingList<Objvw_DataMix> result)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.UpdateUI(result)));
      else
        this.grcMeTronCur.DataSource = (object) result;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      EditorButtonImageOptions imageOptions = new EditorButtonImageOptions();
      SerializableAppearanceObject appearance = new SerializableAppearanceObject();
      SerializableAppearanceObject appearanceHovered = new SerializableAppearanceObject();
      SerializableAppearanceObject appearancePressed = new SerializableAppearanceObject();
      SerializableAppearanceObject appearanceDisabled = new SerializableAppearanceObject();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (VanHanh));
      this.siloFD = new ucSiloFD();
      this.siloAgg1 = new ucSiloAGG();
      this.siloAgg2 = new ucSiloAGG();
      this.siloAgg3 = new ucSiloAGG();
      this.siloAgg4 = new ucSiloAGG();
      this.siloAgg5 = new ucSiloAGG();
      this.barFullSiloAGG1 = new ucTinHieuBaoDay();
      this.barFullSiloAGG2 = new ucTinHieuBaoDay();
      this.barFullSiloAGG3 = new ucTinHieuBaoDay();
      this.barFullSiloAGG4 = new ucTinHieuBaoDay();
      this.barFullSiloAGG5 = new ucTinHieuBaoDay();
      this.weighFD = new ucWeighFD();
      this.weighAGG = new ucWeighAGG();
      this.weighAP = new ucWeighAP();
      this.weighSBS = new ucWeighSBS();
      this.btnXaCanFD = new ucBtnXaCan();
      this.btnXaCanAP = new ucBtnXaCan();
      this.btnXaCanAGG = new ucBtnXaCan();
      this.btnXaCanSBS = new ucBtnXaCan();
      this.lblHeThong = new Label();
      this.label1 = new Label();
      this.label2 = new Label();
      this.groupBox1 = new GroupBox();
      this.txtNhietDoNhua = new TextBox();
      this.txtNhietDoTanSay = new TextBox();
      this.txtNhietDoAGG = new TextBox();
      this.txtNhietDoTuiLocKho = new TextBox();
      this.label6 = new Label();
      this.label5 = new Label();
      this.label4 = new Label();
      this.label3 = new Label();
      this.btnXaCanAGG1 = new ucBtnXaCan();
      this.btnXaCanAGG2 = new ucBtnXaCan();
      this.btnXaCanAGG3 = new ucBtnXaCan();
      this.btnXaCanAGG4 = new ucBtnXaCan();
      this.btnXaCanAGG5 = new ucBtnXaCan();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.connectStus = new Label();
      this.siloAP = new ucSiloAP();
      this.siloSBS = new ucSiloSBS();
      this.barFullSiloSBS = new ucTinHieuBaoDay();
      this.label7 = new Label();
      this.label8 = new Label();
      this.label11 = new Label();
      this.label12 = new Label();
      this.tinHieuBaoMucThapFD = new ucTinHieuBaoDay();
      this.tinHieuBaoMucCaoFD = new ucTinHieuBaoDay();
      this.label10 = new Label();
      this.label9 = new Label();
      this.slMeDaCanFD = new ucSoMeDaCan();
      this.slMeDaCanAGG = new ucSoMeDaCan();
      this.slMeDaCanAP = new ucSoMeDaCan();
      this.slMeDaCanSBS = new ucSoMeDaCan();
      this.barFullSiloFD = new ucTinHieuBaoDay();
      this.lblMAC = new Label();
      this.checkDaat = new Label();
      this.lblNameCty = new LabelControl();
      this.lblDec = new LabelControl();
      this.label13 = new Label();
      this.lblDLT = new LabelControl();
      this.labelControl3 = new LabelControl();
      this.labelControl4 = new LabelControl();
      this.groupControl1 = new GroupControl();
      this.txtMaPhieuTron = new TextEdit();
      this.labelControl9 = new LabelControl();
      this.txtCongTruong = new TextEdit();
      this.labelControl8 = new LabelControl();
      this.txtKhachHang = new TextEdit();
      this.labelControl7 = new LabelControl();
      this.txtKhoiLuong = new TextEdit();
      this.labelControl6 = new LabelControl();
      this.txtMAC = new TextEdit();
      this.labelControl5 = new LabelControl();
      this.gluHopDong = new GridLookUpEdit();
      this.glueHopDong = new GridView();
      this.grcDuLieuTronID = new GridColumn();
      this.grcMaHopDong = new GridColumn();
      this.grcTenHopDong = new GridColumn();
      this.glueBienSo = new GridLookUpEdit();
      this.gridView2 = new GridView();
      this.grcXeID = new GridColumn();
      this.grcBienSo = new GridColumn();
      this.gluTaiXe = new GridLookUpEdit();
      this.gridView1 = new GridView();
      this.grcTaiXeID = new GridColumn();
      this.grcMaTaiXe = new GridColumn();
      this.grcTenTaiXe = new GridColumn();
      this.VAA = new GroupControl();
      this.lblPhone = new LabelControl();
      this.lblGmail = new LabelControl();
      this.btnCheDoXaCan = new ucBtnCheDo();
      this.btnTanSay = new ucTinHieuTanSayQuay();
      this.ucBtnVitTai1 = new ucBtnVitTai();
      this.btnSanRung = new ucBtnSanRung();
      this.tinHieuMoCuaNoi = new ucTinHieuMoCuaNoi();
      this.tinHieuDongCuaNoi = new ucTinHieuDongCuaNoi();
      this.tinHieuSanRung = new ucTinHieuSanRung();
      this.ucBangGauTauCatDaNhanh1 = new ucBangGauTauCatDaNhanh();
      this.ucBangGauTaiCatDa1 = new ucBangGauTaiCatDa();
      this.motorGauTaiAGG1 = new ucMotorMiniN();
      this.btnRungCL3 = new ucBtnTron();
      this.btnRungCL2 = new ucBtnTron();
      this.btnRungCL1 = new ucBtnTron();
      this.ucBeTiep1 = new ucBeTiep();
      this.ucBangGauTaiXiMang2 = new ucBangGauTaiXiMang();
      this.btnFU_SBS = new ucBtnFU();
      this.btnFU_AP = new ucBtnFU();
      this.btnFU_AGG5 = new ucBtnFU();
      this.btnFU_AGG4 = new ucBtnFU();
      this.btnFU_AGG3 = new ucBtnFU();
      this.btnFU_AGG2 = new ucBtnFU();
      this.btnFU_AG1 = new ucBtnFU();
      this.btnFU_FD = new ucBtnFU();
      this.ucBangGauTaiXiMangNhanh1 = new ucBangGauTaiXiMangNhanh();
      this.textEdit4 = new TextEdit();
      this.textEdit2 = new TextEdit();
      this.siloFDFat = new ucSiloFDFat();
      this.tinHIeuVitTaiFD = new ucVitTaiFD();
      this.memoEdit1 = new MemoEdit();
      this.btnMayNenKhi = new ucBtnBomKhi();
      this.ucBomKhi1 = new ucBomKhi();
      this.txtTG_BomTuoiNhua = new TextEdit();
      this.textEdit3 = new TextEdit();
      this.textEdit1 = new TextEdit();
      this.btnVanCanSBS = new ucBtnTron();
      this.ucOngSBS1 = new ucOngSBS();
      this.btnVanCanAP = new ucBtnTron();
      this.ucPheuChua011 = new ucPheuChua01();
      this.motorPheuChua01 = new ucMotorFat();
      this.ucOngAP1 = new ucOngAP();
      this.ucOngMotor1 = new ucOngMotor();
      this.ucBonChuaTanSay1 = new ucBonChuaTanSay();
      this.bomNgamPheuChua = new ucBomNgam();
      this.ucPheuChua041 = new ucPheuChua04();
      this.ucOngPheuChua041 = new ucOngPheuChua04();
      this.ucOngPheuChua031 = new ucOngPheuChua03();
      this.ucOngBonChuaKhi1 = new ucOngBonChuaKhi();
      this.ucOngTanSay1 = new ucOngTanSay();
      this.bangTaiXien = new ucBTX();
      this.bangTaiCan = new ucBangTaiCan();
      this.tinHieuXaCanAGG5 = new ucTinHieuXanh();
      this.tinHieuXaCanAGG4 = new ucTinHieuXanh();
      this.tinHieuXaCanAGG3 = new ucTinHieuXanh();
      this.tinHieuXaCanAGG2 = new ucTinHieuXanh();
      this.tinHieuXaCanAGG1 = new ucTinHieuXanh();
      this.ucPheuChuaCatDa5 = new ucPheuChuaCatDa();
      this.ucPheuChuaCatDa4 = new ucPheuChuaCatDa();
      this.ucPheuChuaCatDa3 = new ucPheuChuaCatDa();
      this.ucPheuChuaCatDa2 = new ucPheuChuaCatDa();
      this.ucPheuChuaCatDa1 = new ucPheuChuaCatDa();
      this.motorPheuChua02 = new ucMotorFat();
      this.ucPheuChua031 = new ucPheuChua03();
      this.ucPheuChua021 = new ucPheuChua02();
      this.ucMotorExtra1 = new ucMotorExtra();
      this.motorBomDau = new ucMotorFat();
      this.tinHieuTanSayLua = new ucTinHieunTanSayLua();
      this.motorGauTaiFD = new ucMotorMini();
      this.sanRung = new ucSanRung();
      this.ucBonChuaKhi1 = new ucBonChuaKhi();
      this.btnCheDoCuaNoi = new ucBtnCheDo();
      this.btnCheDoNapLieu = new ucBtnCheDo();
      this.btnCheDoHeThong = new ucBtnCheDo();
      this.btnSIM = new ucBtnSIM();
      this.btnHuy = new ucBtnHuy();
      this.btnDung = new ucBtnDung();
      this.btnBatDau = new ucBtnBatDau();
      this.btnDongCuaNoi = new ucBtnDong();
      this.btnMoCuaNoi = new ucBtnMo();
      this.tinHieuCanSiloSBS = new ucTinHieuDo();
      this.tinHieuCanSiloAP = new ucTinHieuDo();
      this.tinHieuCanSiloAGG5 = new ucTinHieuDo();
      this.tinHieuCanSiloAGG4 = new ucTinHieuDo();
      this.tinHieuCanSiloAGG3 = new ucTinHieuDo();
      this.tinHieuCanSiloAGG2 = new ucTinHieuDo();
      this.tinHieuCanSiloAGG1 = new ucTinHieuDo();
      this.tinHieuCanSiloFD = new ucTinHieuDo();
      this.btnVanCanAGG5 = new ucBtnTron();
      this.btnVanCanAGG4 = new ucBtnTron();
      this.btnVanCanAGG3 = new ucBtnTron();
      this.btnVanCanAGG2 = new ucBtnTron();
      this.btnVanCanAGG1 = new ucBtnTron();
      this.btnVanCanFD = new ucBtnTron();
      this.ucOngDanFD1 = new ucOngDanFD();
      this.tinHieuXaCanAGG = new ucTinHieuXaCan();
      this.tinHieuXaCanFD = new ucTinHieuXaCan();
      this.slMeDaCanNoiTron = new ucSoMeDaCan();
      this.btnNoiTronR = new ucBtnNoiTron();
      this.btnNoiTronL = new ucBtnNoiTron();
      this.ucNoiTron1 = new ucNoiTron();
      this.grcMeTronCur = new GridControl();
      this.grvMeTronCur = new GridView();
      this.gcMaPhieuTron = new GridColumn();
      this.gcSTTMeTron = new GridColumn();
      this.ggcNgayTron = new GridColumn();
      this.gcGioTron = new GridColumn();
      this.gcKhachHang = new GridColumn();
      this.gcCongTruong = new GridColumn();
      this.gcTenMAC = new GridColumn();
      this.gcKhoiLuong = new GridColumn();
      this.motorBomTuoiNhua = new ucMotorMini();
      this.ucOngDanSB2 = new ucOngDanSB();
      this.btnXaHetAGG = new ucBtnXAHETAGG();
      this.tinHieuBomTuoiNhua = new ucTinHieuXaCan();
      this.tinHieuXaCanSBS = new ucTinHieuXaCan();
      this.tinHieuCuaNoiMo = new ucTinHieuMoCuaNoi();
      this.tinHieuCuaNoiDong = new ucTinHieuDongCuaNoi();
      this.tinHieuXaCanAP = new ucTinHieuDo();
      this.btnDauDot = new ucTinHieuTanSayQuay();
      this.tinHieuCuaMo = new ucTinHieuXaCan();
      this.tinHieuCuaDong = new ucTinHieuXaCan();
      this.btnPheuSBS = new ucBtnXaCan();
      this.groupBox1.SuspendLayout();
      this.groupControl1.BeginInit();
      this.groupControl1.SuspendLayout();
      this.txtMaPhieuTron.Properties.BeginInit();
      this.txtCongTruong.Properties.BeginInit();
      this.txtKhachHang.Properties.BeginInit();
      this.txtKhoiLuong.Properties.BeginInit();
      this.txtMAC.Properties.BeginInit();
      this.gluHopDong.Properties.BeginInit();
      this.glueHopDong.BeginInit();
      this.glueBienSo.Properties.BeginInit();
      this.gridView2.BeginInit();
      this.gluTaiXe.Properties.BeginInit();
      this.gridView1.BeginInit();
      this.VAA.BeginInit();
      this.VAA.SuspendLayout();
      this.textEdit4.Properties.BeginInit();
      this.textEdit2.Properties.BeginInit();
      this.memoEdit1.Properties.BeginInit();
      this.txtTG_BomTuoiNhua.Properties.BeginInit();
      this.textEdit3.Properties.BeginInit();
      this.textEdit1.Properties.BeginInit();
      this.grcMeTronCur.BeginInit();
      this.grvMeTronCur.BeginInit();
      this.SuspendLayout();
      this.siloFD.DoAm = new Decimal(new int[4]);
      this.siloFD.DoHut = new Decimal(new int[4]);
      this.siloFD.KLCaiDat = new Decimal(new int[4]);
      this.siloFD.KLCanCan = new Decimal(new int[4]);
      this.siloFD.KLCanCan_Origin = new Decimal(new int[4]);
      this.siloFD.KLSaveThucTe = new Decimal(new int[4]);
      this.siloFD.KLTemp = new Decimal(new int[4]);
      this.siloFD.KLThucTe = new Decimal(new int[4]);
      this.siloFD.Location = new Point(306, 192);
      this.siloFD.Margin = new Padding(3, 2, 3, 2);
      this.siloFD.MaSilo = (string) null;
      this.siloFD.MaterialID = new int?();
      this.siloFD.Name = "siloFD";
      this.siloFD.ShowSiloDesc = true;
      this.siloFD.SiloCaption = "SILO";
      this.siloFD.SiloDesc = "F/D";
      this.siloFD.Size = new Size(80, 200);
      this.siloFD.TabIndex = 12;
      this.siloFD.CaptionClick += new UcBaseSilo2.DelCaptionEventHandler(this.siloFD_CaptionClick);
      this.siloAgg1.DoAm = new Decimal(new int[4]);
      this.siloAgg1.DoHut = new Decimal(new int[4]);
      this.siloAgg1.KLCaiDat = new Decimal(new int[4]);
      this.siloAgg1.KLCanCan = new Decimal(new int[4]);
      this.siloAgg1.KLCanCan_Origin = new Decimal(new int[4]);
      this.siloAgg1.KLSaveThucTe = new Decimal(new int[4]);
      this.siloAgg1.KLTemp = new Decimal(new int[4]);
      this.siloAgg1.KLThucTe = new Decimal(new int[4]);
      this.siloAgg1.Location = new Point(409, 192);
      this.siloAgg1.Margin = new Padding(3, 2, 3, 2);
      this.siloAgg1.MaSilo = (string) null;
      this.siloAgg1.MaterialID = new int?();
      this.siloAgg1.Name = "siloAgg1";
      this.siloAgg1.ShowSiloDesc = true;
      this.siloAgg1.SiloCaption = "SILO";
      this.siloAgg1.SiloDesc = "AGG1";
      this.siloAgg1.Size = new Size(80, 200);
      this.siloAgg1.TabIndex = 14;
      this.siloAgg1.CaptionClick += new UcBaseSilo2.DelCaptionEventHandler(this.siloAgg1_CaptionClick);
      this.siloAgg2.DoAm = new Decimal(new int[4]);
      this.siloAgg2.DoHut = new Decimal(new int[4]);
      this.siloAgg2.KLCaiDat = new Decimal(new int[4]);
      this.siloAgg2.KLCanCan = new Decimal(new int[4]);
      this.siloAgg2.KLCanCan_Origin = new Decimal(new int[4]);
      this.siloAgg2.KLSaveThucTe = new Decimal(new int[4]);
      this.siloAgg2.KLTemp = new Decimal(new int[4]);
      this.siloAgg2.KLThucTe = new Decimal(new int[4]);
      this.siloAgg2.Location = new Point(495, 192);
      this.siloAgg2.Margin = new Padding(3, 2, 3, 2);
      this.siloAgg2.MaSilo = (string) null;
      this.siloAgg2.MaterialID = new int?();
      this.siloAgg2.Name = "siloAgg2";
      this.siloAgg2.ShowSiloDesc = true;
      this.siloAgg2.SiloCaption = "SILO";
      this.siloAgg2.SiloDesc = "AGG2";
      this.siloAgg2.Size = new Size(80, 200);
      this.siloAgg2.TabIndex = 15;
      this.siloAgg2.CaptionClick += new UcBaseSilo2.DelCaptionEventHandler(this.siloAgg2_CaptionClick);
      this.siloAgg3.DoAm = new Decimal(new int[4]);
      this.siloAgg3.DoHut = new Decimal(new int[4]);
      this.siloAgg3.KLCaiDat = new Decimal(new int[4]);
      this.siloAgg3.KLCanCan = new Decimal(new int[4]);
      this.siloAgg3.KLCanCan_Origin = new Decimal(new int[4]);
      this.siloAgg3.KLSaveThucTe = new Decimal(new int[4]);
      this.siloAgg3.KLTemp = new Decimal(new int[4]);
      this.siloAgg3.KLThucTe = new Decimal(new int[4]);
      this.siloAgg3.Location = new Point(581, 192);
      this.siloAgg3.Margin = new Padding(3, 2, 3, 2);
      this.siloAgg3.MaSilo = (string) null;
      this.siloAgg3.MaterialID = new int?();
      this.siloAgg3.Name = "siloAgg3";
      this.siloAgg3.ShowSiloDesc = true;
      this.siloAgg3.SiloCaption = "SILO";
      this.siloAgg3.SiloDesc = "AGG3";
      this.siloAgg3.Size = new Size(80, 200);
      this.siloAgg3.TabIndex = 16;
      this.siloAgg3.CaptionClick += new UcBaseSilo2.DelCaptionEventHandler(this.siloAgg3_CaptionClick);
      this.siloAgg4.DoAm = new Decimal(new int[4]);
      this.siloAgg4.DoHut = new Decimal(new int[4]);
      this.siloAgg4.KLCaiDat = new Decimal(new int[4]);
      this.siloAgg4.KLCanCan = new Decimal(new int[4]);
      this.siloAgg4.KLCanCan_Origin = new Decimal(new int[4]);
      this.siloAgg4.KLSaveThucTe = new Decimal(new int[4]);
      this.siloAgg4.KLTemp = new Decimal(new int[4]);
      this.siloAgg4.KLThucTe = new Decimal(new int[4]);
      this.siloAgg4.Location = new Point(667, 192);
      this.siloAgg4.Margin = new Padding(3, 2, 3, 2);
      this.siloAgg4.MaSilo = (string) null;
      this.siloAgg4.MaterialID = new int?();
      this.siloAgg4.Name = "siloAgg4";
      this.siloAgg4.ShowSiloDesc = true;
      this.siloAgg4.SiloCaption = "SILO";
      this.siloAgg4.SiloDesc = "AGG4";
      this.siloAgg4.Size = new Size(80, 200);
      this.siloAgg4.TabIndex = 17;
      this.siloAgg4.CaptionClick += new UcBaseSilo2.DelCaptionEventHandler(this.siloAgg4_CaptionClick);
      this.siloAgg5.DoAm = new Decimal(new int[4]);
      this.siloAgg5.DoHut = new Decimal(new int[4]);
      this.siloAgg5.KLCaiDat = new Decimal(new int[4]);
      this.siloAgg5.KLCanCan = new Decimal(new int[4]);
      this.siloAgg5.KLCanCan_Origin = new Decimal(new int[4]);
      this.siloAgg5.KLSaveThucTe = new Decimal(new int[4]);
      this.siloAgg5.KLTemp = new Decimal(new int[4]);
      this.siloAgg5.KLThucTe = new Decimal(new int[4]);
      this.siloAgg5.Location = new Point(753, 192);
      this.siloAgg5.Margin = new Padding(3, 2, 3, 2);
      this.siloAgg5.MaSilo = (string) null;
      this.siloAgg5.MaterialID = new int?();
      this.siloAgg5.Name = "siloAgg5";
      this.siloAgg5.ShowSiloDesc = true;
      this.siloAgg5.SiloCaption = "SILO";
      this.siloAgg5.SiloDesc = "AGG5";
      this.siloAgg5.Size = new Size(80, 200);
      this.siloAgg5.TabIndex = 18;
      this.siloAgg5.CaptionClick += new UcBaseSilo2.DelCaptionEventHandler(this.siloAgg5_CaptionClick);
      this.barFullSiloAGG1.BackColor = Color.Red;
      this.barFullSiloAGG1.IsOn = false;
      this.barFullSiloAGG1.IsTrangThai = ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG1.Location = new Point(420, 196);
      this.barFullSiloAGG1.Name = "barFullSiloAGG1";
      this.barFullSiloAGG1.Size = new Size(60, 10);
      this.barFullSiloAGG1.TabIndex = 38;
      this.barFullSiloAGG2.BackColor = Color.Red;
      this.barFullSiloAGG2.IsOn = false;
      this.barFullSiloAGG2.IsTrangThai = ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG2.Location = new Point(506, 196);
      this.barFullSiloAGG2.Name = "barFullSiloAGG2";
      this.barFullSiloAGG2.Size = new Size(60, 10);
      this.barFullSiloAGG2.TabIndex = 39;
      this.barFullSiloAGG3.BackColor = Color.Red;
      this.barFullSiloAGG3.IsOn = false;
      this.barFullSiloAGG3.IsTrangThai = ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG3.Location = new Point(590, 196);
      this.barFullSiloAGG3.Name = "barFullSiloAGG3";
      this.barFullSiloAGG3.Size = new Size(60, 10);
      this.barFullSiloAGG3.TabIndex = 40;
      this.barFullSiloAGG4.BackColor = Color.Red;
      this.barFullSiloAGG4.IsOn = false;
      this.barFullSiloAGG4.IsTrangThai = ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG4.Location = new Point(676, 196);
      this.barFullSiloAGG4.Name = "barFullSiloAGG4";
      this.barFullSiloAGG4.Size = new Size(60, 10);
      this.barFullSiloAGG4.TabIndex = 41;
      this.barFullSiloAGG5.BackColor = Color.Red;
      this.barFullSiloAGG5.IsOn = false;
      this.barFullSiloAGG5.IsTrangThai = ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloAGG5.Location = new Point(761, 196);
      this.barFullSiloAGG5.Name = "barFullSiloAGG5";
      this.barFullSiloAGG5.Size = new Size(60, 10);
      this.barFullSiloAGG5.TabIndex = 42;
      this.weighFD.GiaTriWeight = new Decimal(new int[4]);
      this.weighFD.Location = new Point(306, 428);
      this.weighFD.Margin = new Padding(3, 2, 3, 2);
      this.weighFD.Name = "weighFD";
      this.weighFD.Size = new Size(80, 78);
      this.weighFD.TabIndex = 46;
      this.weighFD.Weight = new Decimal(new int[4]);
      this.weighFD.WeightClick += new ucBaseWeight.DelCaptionEventHandler(this.weighFD_WeightClick);
      this.weighAGG.GiaTriWeight = new Decimal(new int[4]);
      this.weighAGG.Location = new Point(416, 428);
      this.weighAGG.Margin = new Padding(3, 2, 3, 2);
      this.weighAGG.Name = "weighAGG";
      this.weighAGG.Size = new Size(416, 78);
      this.weighAGG.TabIndex = 47;
      this.weighAGG.Weight = new Decimal(new int[4]);
      this.weighAGG.WeightClick += new ucBaseWeight.DelCaptionEventHandler(this.weighAGG_WeightClick);
      this.weighAP.GiaTriWeight = new Decimal(new int[4]);
      this.weighAP.Location = new Point(867, 428);
      this.weighAP.Margin = new Padding(3, 2, 3, 2);
      this.weighAP.Name = "weighAP";
      this.weighAP.Size = new Size(80, 78);
      this.weighAP.TabIndex = 48;
      this.weighAP.Weight = new Decimal(new int[4]);
      this.weighAP.WeightClick += new ucBaseWeight.DelCaptionEventHandler(this.weighAP_WeightClick);
      this.weighSBS.GiaTriWeight = new Decimal(new int[4]);
      this.weighSBS.Location = new Point(980, 428);
      this.weighSBS.Margin = new Padding(3, 2, 3, 2);
      this.weighSBS.Name = "weighSBS";
      this.weighSBS.Size = new Size(80, 78);
      this.weighSBS.TabIndex = 49;
      this.weighSBS.Weight = new Decimal(new int[4]);
      this.weighSBS.WeightClick += new ucBaseWeight.DelCaptionEventHandler(this.weighSBS_WeightClick);
      this.btnXaCanFD.BackColor = Color.DarkGray;
      this.btnXaCanFD.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaCanFD.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanFD.IsOn = true;
      this.btnXaCanFD.IsRun = false;
      this.btnXaCanFD.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanFD.Location = new Point(327, 489);
      this.btnXaCanFD.Name = "btnXaCanFD";
      this.btnXaCanFD.Size = new Size(40, 18);
      this.btnXaCanFD.TabIndex = 50;
      this.btnXaCanFD.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnXaCanFD_ButtonClick);
      this.btnXaCanAP.BackColor = Color.DarkGray;
      this.btnXaCanAP.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaCanAP.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAP.IsOn = true;
      this.btnXaCanAP.IsRun = false;
      this.btnXaCanAP.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAP.Location = new Point(889, 489);
      this.btnXaCanAP.Name = "btnXaCanAP";
      this.btnXaCanAP.Size = new Size(40, 18);
      this.btnXaCanAP.TabIndex = 51;
      this.btnXaCanAP.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAP_ButtonClick);
      this.btnXaCanAGG.BackColor = Color.DarkGray;
      this.btnXaCanAGG.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaCanAGG.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG.IsOn = true;
      this.btnXaCanAGG.IsRun = false;
      this.btnXaCanAGG.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG.Location = new Point(598, 489);
      this.btnXaCanAGG.Name = "btnXaCanAGG";
      this.btnXaCanAGG.Size = new Size(52, 18);
      this.btnXaCanAGG.TabIndex = 52;
      this.btnXaCanAGG.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG_ButtonClick);
      this.btnXaCanSBS.BackColor = Color.DarkGray;
      this.btnXaCanSBS.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaCanSBS.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanSBS.IsOn = true;
      this.btnXaCanSBS.IsRun = false;
      this.btnXaCanSBS.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanSBS.Location = new Point(1001, 489);
      this.btnXaCanSBS.Name = "btnXaCanSBS";
      this.btnXaCanSBS.Size = new Size(40, 18);
      this.btnXaCanSBS.TabIndex = 53;
      this.btnXaCanSBS.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnXaCanSBS_ButtonClick);
      this.lblHeThong.BackColor = Color.Transparent;
      this.lblHeThong.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblHeThong.Location = new Point(444, 793);
      this.lblHeThong.Name = "lblHeThong";
      this.lblHeThong.Size = new Size(97, 23);
      this.lblHeThong.TabIndex = 68;
      this.lblHeThong.Text = "HỆ THỐNG";
      this.lblHeThong.TextAlign = ContentAlignment.MiddleCenter;
      this.label1.BackColor = Color.Transparent;
      this.label1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(660, 793);
      this.label1.Name = "label1";
      this.label1.Size = new Size(97, 23);
      this.label1.TabIndex = 69;
      this.label1.Text = "NẠP LIỆU";
      this.label1.TextAlign = ContentAlignment.MiddleCenter;
      this.label2.BackColor = Color.Transparent;
      this.label2.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(763, 793);
      this.label2.Name = "label2";
      this.label2.Size = new Size(97, 23);
      this.label2.TabIndex = 70;
      this.label2.Text = "CỬA NỒI";
      this.label2.TextAlign = ContentAlignment.MiddleCenter;
      this.groupBox1.BackColor = Color.White;
      this.groupBox1.Controls.Add((Control) this.txtNhietDoNhua);
      this.groupBox1.Controls.Add((Control) this.txtNhietDoTanSay);
      this.groupBox1.Controls.Add((Control) this.txtNhietDoAGG);
      this.groupBox1.Controls.Add((Control) this.txtNhietDoTuiLocKho);
      this.groupBox1.Controls.Add((Control) this.label6);
      this.groupBox1.Controls.Add((Control) this.label5);
      this.groupBox1.Controls.Add((Control) this.label4);
      this.groupBox1.Controls.Add((Control) this.label3);
      this.groupBox1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.groupBox1.Location = new Point(1650, 9);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(258, (int) sbyte.MaxValue);
      this.groupBox1.TabIndex = 90;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "THÔNG SỐ NHIỆT ĐỘ";
      this.txtNhietDoNhua.BackColor = Color.Black;
      this.txtNhietDoNhua.BorderStyle = BorderStyle.FixedSingle;
      this.txtNhietDoNhua.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNhietDoNhua.ForeColor = Color.Red;
      this.txtNhietDoNhua.Location = new Point(152, 98);
      this.txtNhietDoNhua.Name = "txtNhietDoNhua";
      this.txtNhietDoNhua.ReadOnly = true;
      this.txtNhietDoNhua.Size = new Size(100, 22);
      this.txtNhietDoNhua.TabIndex = 7;
      this.txtNhietDoNhua.Text = "30";
      this.txtNhietDoNhua.TextAlign = HorizontalAlignment.Center;
      this.txtNhietDoTanSay.BackColor = Color.Black;
      this.txtNhietDoTanSay.BorderStyle = BorderStyle.FixedSingle;
      this.txtNhietDoTanSay.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNhietDoTanSay.ForeColor = Color.Red;
      this.txtNhietDoTanSay.Location = new Point(152, 73);
      this.txtNhietDoTanSay.Name = "txtNhietDoTanSay";
      this.txtNhietDoTanSay.ReadOnly = true;
      this.txtNhietDoTanSay.Size = new Size(100, 22);
      this.txtNhietDoTanSay.TabIndex = 6;
      this.txtNhietDoTanSay.Text = "30";
      this.txtNhietDoTanSay.TextAlign = HorizontalAlignment.Center;
      this.txtNhietDoAGG.BackColor = Color.Black;
      this.txtNhietDoAGG.BorderStyle = BorderStyle.FixedSingle;
      this.txtNhietDoAGG.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNhietDoAGG.ForeColor = Color.Red;
      this.txtNhietDoAGG.Location = new Point(152, 48);
      this.txtNhietDoAGG.Name = "txtNhietDoAGG";
      this.txtNhietDoAGG.ReadOnly = true;
      this.txtNhietDoAGG.Size = new Size(100, 22);
      this.txtNhietDoAGG.TabIndex = 5;
      this.txtNhietDoAGG.Text = "30";
      this.txtNhietDoAGG.TextAlign = HorizontalAlignment.Center;
      this.txtNhietDoTuiLocKho.BackColor = Color.Black;
      this.txtNhietDoTuiLocKho.BorderStyle = BorderStyle.FixedSingle;
      this.txtNhietDoTuiLocKho.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNhietDoTuiLocKho.ForeColor = Color.Red;
      this.txtNhietDoTuiLocKho.Location = new Point(152, 23);
      this.txtNhietDoTuiLocKho.Name = "txtNhietDoTuiLocKho";
      this.txtNhietDoTuiLocKho.ReadOnly = true;
      this.txtNhietDoTuiLocKho.Size = new Size(100, 22);
      this.txtNhietDoTuiLocKho.TabIndex = 4;
      this.txtNhietDoTuiLocKho.Text = "30";
      this.txtNhietDoTuiLocKho.TextAlign = HorizontalAlignment.Center;
      this.label6.AutoSize = true;
      this.label6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label6.Location = new Point(32, 100);
      this.label6.Name = "label6";
      this.label6.Size = new Size(50, 16);
      this.label6.TabIndex = 3;
      this.label6.Text = "NHỰA";
      this.label5.AutoSize = true;
      this.label5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label5.Location = new Point(32, 75);
      this.label5.Name = "label5";
      this.label5.Size = new Size(72, 16);
      this.label5.TabIndex = 2;
      this.label5.Text = "TAN SẤY";
      this.label4.AutoSize = true;
      this.label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label4.Location = new Point(32, 50);
      this.label4.Name = "label4";
      this.label4.Size = new Size(39, 16);
      this.label4.TabIndex = 1;
      this.label4.Text = "AGG";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(32, 25);
      this.label3.Name = "label3";
      this.label3.Size = new Size(100, 16);
      this.label3.TabIndex = 0;
      this.label3.Text = "TÚI LỌC KHÔ";
      this.btnXaCanAGG1.BackColor = Color.DarkGray;
      this.btnXaCanAGG1.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaCanAGG1.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG1.IsOn = true;
      this.btnXaCanAGG1.IsRun = false;
      this.btnXaCanAGG1.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG1.Location = new Point(1488, 686);
      this.btnXaCanAGG1.Name = "btnXaCanAGG1";
      this.btnXaCanAGG1.Size = new Size(40, 18);
      this.btnXaCanAGG1.TabIndex = 96;
      this.btnXaCanAGG1.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG1_ButtonClick);
      this.btnXaCanAGG2.BackColor = Color.DarkGray;
      this.btnXaCanAGG2.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaCanAGG2.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG2.IsOn = true;
      this.btnXaCanAGG2.IsRun = false;
      this.btnXaCanAGG2.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG2.Location = new Point(1568, 686);
      this.btnXaCanAGG2.Name = "btnXaCanAGG2";
      this.btnXaCanAGG2.Size = new Size(40, 18);
      this.btnXaCanAGG2.TabIndex = 97;
      this.btnXaCanAGG2.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG2_ButtonClick);
      this.btnXaCanAGG3.BackColor = Color.DarkGray;
      this.btnXaCanAGG3.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaCanAGG3.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG3.IsOn = true;
      this.btnXaCanAGG3.IsRun = false;
      this.btnXaCanAGG3.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG3.Location = new Point(1649, 686);
      this.btnXaCanAGG3.Name = "btnXaCanAGG3";
      this.btnXaCanAGG3.Size = new Size(40, 18);
      this.btnXaCanAGG3.TabIndex = 98;
      this.btnXaCanAGG3.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG3_ButtonClick);
      this.btnXaCanAGG4.BackColor = Color.DarkGray;
      this.btnXaCanAGG4.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaCanAGG4.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG4.IsOn = true;
      this.btnXaCanAGG4.IsRun = false;
      this.btnXaCanAGG4.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG4.Location = new Point(1730, 686);
      this.btnXaCanAGG4.Name = "btnXaCanAGG4";
      this.btnXaCanAGG4.Size = new Size(40, 18);
      this.btnXaCanAGG4.TabIndex = 99;
      this.btnXaCanAGG4.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG4_ButtonClick);
      this.btnXaCanAGG5.BackColor = Color.DarkGray;
      this.btnXaCanAGG5.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaCanAGG5.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnXaCanAGG5.IsOn = true;
      this.btnXaCanAGG5.IsRun = false;
      this.btnXaCanAGG5.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnXaCanAGG5.Location = new Point(1811, 686);
      this.btnXaCanAGG5.Name = "btnXaCanAGG5";
      this.btnXaCanAGG5.Size = new Size(40, 18);
      this.btnXaCanAGG5.TabIndex = 100;
      this.btnXaCanAGG5.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnXaCanAGG5_ButtonClick);
      this.timer1.Tick += new EventHandler(this.timer1_Tick);
      this.connectStus.AutoSize = true;
      this.connectStus.Location = new Point(1003, 850);
      this.connectStus.Name = "connectStus";
      this.connectStus.Size = new Size(35, 13);
      this.connectStus.TabIndex = 112;
      this.connectStus.Text = "label7";
      this.connectStus.Visible = false;
      this.siloAP.DoAm = new Decimal(new int[4]);
      this.siloAP.DoHut = new Decimal(new int[4]);
      this.siloAP.KLCaiDat = new Decimal(new int[4]);
      this.siloAP.KLCanCan = new Decimal(new int[4]);
      this.siloAP.KLCanCan_Origin = new Decimal(new int[4]);
      this.siloAP.KLSaveThucTe = new Decimal(new int[4]);
      this.siloAP.KLTemp = new Decimal(new int[4]);
      this.siloAP.KLThucTe = new Decimal(new int[4]);
      this.siloAP.Location = new Point(867, 192);
      this.siloAP.Margin = new Padding(3, 2, 3, 2);
      this.siloAP.MaSilo = (string) null;
      this.siloAP.MaterialID = new int?();
      this.siloAP.Name = "siloAP";
      this.siloAP.ShowSiloDesc = true;
      this.siloAP.SiloCaption = "SILO";
      this.siloAP.SiloDesc = "AP";
      this.siloAP.Size = new Size(80, 200);
      this.siloAP.TabIndex = 125;
      this.siloAP.CaptionClick += new UcBaseSilo2.DelCaptionEventHandler(this.siloAP_CaptionClick);
      this.siloSBS.DoAm = new Decimal(new int[4]);
      this.siloSBS.DoHut = new Decimal(new int[4]);
      this.siloSBS.KLCaiDat = new Decimal(new int[4]);
      this.siloSBS.KLCanCan = new Decimal(new int[4]);
      this.siloSBS.KLCanCan_Origin = new Decimal(new int[4]);
      this.siloSBS.KLSaveThucTe = new Decimal(new int[4]);
      this.siloSBS.KLTemp = new Decimal(new int[4]);
      this.siloSBS.KLThucTe = new Decimal(new int[4]);
      this.siloSBS.Location = new Point(980, 192);
      this.siloSBS.Margin = new Padding(3, 2, 3, 2);
      this.siloSBS.MaSilo = (string) null;
      this.siloSBS.MaterialID = new int?();
      this.siloSBS.Name = "siloSBS";
      this.siloSBS.ShowSiloDesc = true;
      this.siloSBS.SiloCaption = "SILO";
      this.siloSBS.SiloDesc = "SBS";
      this.siloSBS.Size = new Size(80, 200);
      this.siloSBS.TabIndex = 128;
      this.siloSBS.CaptionClick += new UcBaseSilo2.DelCaptionEventHandler(this.siloSBS_CaptionClick);
      this.barFullSiloSBS.BackColor = Color.Red;
      this.barFullSiloSBS.IsOn = false;
      this.barFullSiloSBS.IsTrangThai = ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloSBS.Location = new Point(988, 196);
      this.barFullSiloSBS.Name = "barFullSiloSBS";
      this.barFullSiloSBS.Size = new Size(60, 10);
      this.barFullSiloSBS.TabIndex = 130;
      this.label7.AutoSize = true;
      this.label7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label7.Location = new Point(1528, 187);
      this.label7.Name = "label7";
      this.label7.Size = new Size(77, 20);
      this.label7.TabIndex = 134;
      this.label7.Text = "Nhập kho";
      this.label8.AutoSize = true;
      this.label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label8.Location = new Point(1528, 244);
      this.label8.Name = "label8";
      this.label8.Size = new Size(66, 20);
      this.label8.TabIndex = 137;
      this.label8.Text = "Tồn kho";
      this.label11.AutoSize = true;
      this.label11.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label11.Location = new Point(897, 579);
      this.label11.Name = "label11";
      this.label11.Size = new Size(112, 16);
      this.label11.TabIndex = 143;
      this.label11.Text = "TG BƠM NHỰA";
      this.label12.AutoSize = true;
      this.label12.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label12.Location = new Point(25, 9);
      this.label12.Name = "label12";
      this.label12.Size = new Size(96, 16);
      this.label12.TabIndex = 150;
      this.label12.Text = "THÔNG BÁO";
      this.tinHieuBaoMucThapFD.BackColor = Color.Red;
      this.tinHieuBaoMucThapFD.IsOn = false;
      this.tinHieuBaoMucThapFD.IsTrangThai = ucTinHieuBaoDay.TrangThai.Run;
      this.tinHieuBaoMucThapFD.Location = new Point(57, 570);
      this.tinHieuBaoMucThapFD.Name = "tinHieuBaoMucThapFD";
      this.tinHieuBaoMucThapFD.Size = new Size(80, 15);
      this.tinHieuBaoMucThapFD.TabIndex = 159;
      this.tinHieuBaoMucCaoFD.BackColor = Color.Red;
      this.tinHieuBaoMucCaoFD.IsOn = false;
      this.tinHieuBaoMucCaoFD.IsTrangThai = ucTinHieuBaoDay.TrangThai.Run;
      this.tinHieuBaoMucCaoFD.Location = new Point(57, 200);
      this.tinHieuBaoMucCaoFD.Name = "tinHieuBaoMucCaoFD";
      this.tinHieuBaoMucCaoFD.Size = new Size(80, 15);
      this.tinHieuBaoMucCaoFD.TabIndex = 158;
      this.label10.AutoSize = true;
      this.label10.BackColor = Color.Transparent;
      this.label10.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label10.Location = new Point(61, 282);
      this.label10.Name = "label10";
      this.label10.Size = new Size(77, 20);
      this.label10.TabIndex = 156;
      this.label10.Text = "Nhập kho";
      this.label9.AutoSize = true;
      this.label9.BackColor = Color.Transparent;
      this.label9.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label9.Location = new Point(61, 447);
      this.label9.Name = "label9";
      this.label9.Size = new Size(66, 20);
      this.label9.TabIndex = 154;
      this.label9.Text = "Tồn kho";
      this.slMeDaCanFD.Location = new Point(268, 487);
      this.slMeDaCanFD.Name = "slMeDaCanFD";
      this.slMeDaCanFD.Size = new Size(57, 20);
      this.slMeDaCanFD.SoLuongMeCanTron = new Decimal(new int[4]);
      this.slMeDaCanFD.SoLuongMeDaTron = new Decimal(new int[4]);
      this.slMeDaCanFD.TabIndex = 161;
      this.slMeDaCanAGG.Location = new Point(526, 488);
      this.slMeDaCanAGG.Name = "slMeDaCanAGG";
      this.slMeDaCanAGG.Size = new Size(57, 20);
      this.slMeDaCanAGG.SoLuongMeCanTron = new Decimal(new int[4]);
      this.slMeDaCanAGG.SoLuongMeDaTron = new Decimal(new int[4]);
      this.slMeDaCanAGG.TabIndex = 162;
      this.slMeDaCanAP.Location = new Point(829, 487);
      this.slMeDaCanAP.Name = "slMeDaCanAP";
      this.slMeDaCanAP.Size = new Size(57, 20);
      this.slMeDaCanAP.SoLuongMeCanTron = new Decimal(new int[4]);
      this.slMeDaCanAP.SoLuongMeDaTron = new Decimal(new int[4]);
      this.slMeDaCanAP.TabIndex = 163;
      this.slMeDaCanSBS.Location = new Point(941, 488);
      this.slMeDaCanSBS.Name = "slMeDaCanSBS";
      this.slMeDaCanSBS.Size = new Size(57, 20);
      this.slMeDaCanSBS.SoLuongMeCanTron = new Decimal(new int[4]);
      this.slMeDaCanSBS.SoLuongMeDaTron = new Decimal(new int[4]);
      this.slMeDaCanSBS.TabIndex = 164;
      this.barFullSiloFD.BackColor = Color.Red;
      this.barFullSiloFD.IsOn = false;
      this.barFullSiloFD.IsTrangThai = ucTinHieuBaoDay.TrangThai.Run;
      this.barFullSiloFD.Location = new Point(317, 196);
      this.barFullSiloFD.Name = "barFullSiloFD";
      this.barFullSiloFD.Size = new Size(60, 10);
      this.barFullSiloFD.TabIndex = 167;
      this.lblMAC.AutoSize = true;
      this.lblMAC.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblMAC.Location = new Point(1372, 845);
      this.lblMAC.Name = "lblMAC";
      this.lblMAC.Size = new Size(93, 20);
      this.lblMAC.TabIndex = 185;
      this.lblMAC.Text = "MACName";
      this.lblMAC.Visible = false;
      this.checkDaat.AutoSize = true;
      this.checkDaat.Location = new Point(1143, 850);
      this.checkDaat.Name = "checkDaat";
      this.checkDaat.Size = new Size(35, 13);
      this.checkDaat.TabIndex = 186;
      this.checkDaat.Text = "label7";
      this.checkDaat.Visible = false;
      this.lblNameCty.Appearance.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblNameCty.Appearance.ForeColor = Color.Red;
      this.lblNameCty.Appearance.Options.UseFont = true;
      this.lblNameCty.Appearance.Options.UseForeColor = true;
      this.lblNameCty.Appearance.Options.UseTextOptions = true;
      this.lblNameCty.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.lblNameCty.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.lblNameCty.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblNameCty.ImageAlignToText = ImageAlignToText.TopCenter;
      this.lblNameCty.Location = new Point(14, 5);
      this.lblNameCty.Name = "lblNameCty";
      this.lblNameCty.Size = new Size(400, 24);
      this.lblNameCty.TabIndex = 192;
      this.lblNameCty.Text = "HỆ THỐNG ĐIỀU KHIỂN  SMART AP";
      this.lblDec.Appearance.Font = new Font("Times New Roman", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDec.Appearance.ForeColor = Color.LightSeaGreen;
      this.lblDec.Appearance.Options.UseFont = true;
      this.lblDec.Appearance.Options.UseForeColor = true;
      this.lblDec.Appearance.Options.UseTextOptions = true;
      this.lblDec.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.lblDec.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.lblDec.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblDec.Location = new Point(14, 30);
      this.lblDec.Name = "lblDec";
      this.lblDec.Size = new Size(400, 20);
      this.lblDec.TabIndex = 193;
      this.lblDec.Text = "(DESIGNED by VIET DUC GREEN TECHNOLOGY CO., LTD)";
      this.label13.BackColor = Color.Transparent;
      this.label13.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.label13.Location = new Point(554, 793);
      this.label13.Name = "label13";
      this.label13.Size = new Size(97, 23);
      this.label13.TabIndex = 196;
      this.label13.Text = "XẢ CÂN";
      this.label13.TextAlign = ContentAlignment.MiddleCenter;
      this.lblDLT.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDLT.Appearance.Options.UseFont = true;
      this.lblDLT.Location = new Point(10, 34);
      this.lblDLT.Name = "lblDLT";
      this.lblDLT.Size = new Size(94, 16);
      this.lblDLT.TabIndex = 198;
      this.lblDLT.Text = "DỮ LIỆU TRỘN";
      this.labelControl3.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(10, 338);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(45, 16);
      this.labelControl3.TabIndex = 199;
      this.labelControl3.Text = "TÀI XẾ";
      this.labelControl4.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new Point(10, 390);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(57, 16);
      this.labelControl4.TabIndex = 201;
      this.labelControl4.Text = "BIỂN SỐ";
      this.groupControl1.Controls.Add((Control) this.txtMaPhieuTron);
      this.groupControl1.Controls.Add((Control) this.labelControl9);
      this.groupControl1.Controls.Add((Control) this.txtCongTruong);
      this.groupControl1.Controls.Add((Control) this.labelControl8);
      this.groupControl1.Controls.Add((Control) this.txtKhachHang);
      this.groupControl1.Controls.Add((Control) this.labelControl7);
      this.groupControl1.Controls.Add((Control) this.txtKhoiLuong);
      this.groupControl1.Controls.Add((Control) this.labelControl6);
      this.groupControl1.Controls.Add((Control) this.txtMAC);
      this.groupControl1.Controls.Add((Control) this.labelControl5);
      this.groupControl1.Controls.Add((Control) this.gluHopDong);
      this.groupControl1.Controls.Add((Control) this.glueBienSo);
      this.groupControl1.Controls.Add((Control) this.labelControl4);
      this.groupControl1.Controls.Add((Control) this.lblDLT);
      this.groupControl1.Controls.Add((Control) this.gluTaiXe);
      this.groupControl1.Controls.Add((Control) this.labelControl3);
      this.groupControl1.Location = new Point(1650, 146);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(258, 449);
      this.groupControl1.TabIndex = 203;
      this.groupControl1.Text = "THÔNG TIN DỮ LIỆU TRỘN";
      this.txtMaPhieuTron.Location = new Point(35, 109);
      this.txtMaPhieuTron.Name = "txtMaPhieuTron";
      this.txtMaPhieuTron.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.txtMaPhieuTron.Properties.ReadOnly = true;
      this.txtMaPhieuTron.Size = new Size(215, 22);
      this.txtMaPhieuTron.TabIndex = 212;
      this.labelControl9.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Location = new Point(10, 87);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new Size(106, 16);
      this.labelControl9.TabIndex = 211;
      this.labelControl9.Text = "MÃ PHIẾU TRỘN";
      this.txtCongTruong.Location = new Point(35, 210);
      this.txtCongTruong.Name = "txtCongTruong";
      this.txtCongTruong.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCongTruong.Properties.Appearance.Options.UseFont = true;
      this.txtCongTruong.Properties.ReadOnly = true;
      this.txtCongTruong.Size = new Size(215, 22);
      this.txtCongTruong.TabIndex = 210;
      this.labelControl8.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl8.Appearance.Options.UseFont = true;
      this.labelControl8.Location = new Point(10, 188);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new Size(101, 16);
      this.labelControl8.TabIndex = 209;
      this.labelControl8.Text = "CÔNG TRƯỜNG";
      this.txtKhachHang.Location = new Point(35, 160);
      this.txtKhachHang.Name = "txtKhachHang";
      this.txtKhachHang.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtKhachHang.Properties.Appearance.Options.UseFont = true;
      this.txtKhachHang.Properties.ReadOnly = true;
      this.txtKhachHang.Size = new Size(215, 22);
      this.txtKhachHang.TabIndex = 208;
      this.labelControl7.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl7.Appearance.Options.UseFont = true;
      this.labelControl7.Location = new Point(10, 138);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new Size(88, 16);
      this.labelControl7.TabIndex = 207;
      this.labelControl7.Text = "KHÁCH HÀNG";
      this.txtKhoiLuong.Location = new Point(36, 310);
      this.txtKhoiLuong.Name = "txtKhoiLuong";
      this.txtKhoiLuong.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtKhoiLuong.Properties.Appearance.Options.UseFont = true;
      this.txtKhoiLuong.Properties.ReadOnly = true;
      this.txtKhoiLuong.Size = new Size(215, 22);
      this.txtKhoiLuong.TabIndex = 206;
      this.labelControl6.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl6.Appearance.Options.UseFont = true;
      this.labelControl6.Location = new Point(10, 288);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new Size(81, 16);
      this.labelControl6.TabIndex = 205;
      this.labelControl6.Text = "KHỐI LƯỢNG";
      this.txtMAC.Location = new Point(36, 260);
      this.txtMAC.Name = "txtMAC";
      this.txtMAC.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMAC.Properties.Appearance.Options.UseFont = true;
      this.txtMAC.Properties.ReadOnly = true;
      this.txtMAC.Size = new Size(215, 22);
      this.txtMAC.TabIndex = 204;
      this.labelControl5.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new Point(10, 238);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(29, 16);
      this.labelControl5.TabIndex = 203;
      this.labelControl5.Text = "MAC";
      this.gluHopDong.EditValue = (object) "";
      this.gluHopDong.Location = new Point(36, 59);
      this.gluHopDong.Name = "gluHopDong";
      this.gluHopDong.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gluHopDong.Properties.Appearance.Options.UseFont = true;
      this.gluHopDong.Properties.Buttons.AddRange(new EditorButton[4]
      {
        new EditorButton(ButtonPredefines.Combo),
        new EditorButton(ButtonPredefines.Ellipsis, "", -1, true, true, true, imageOptions, new KeyShortcut(Keys.None), (AppearanceObject) appearance, (AppearanceObject) appearanceHovered, (AppearanceObject) appearancePressed, (AppearanceObject) appearanceDisabled, "Chỉnh sửa", (object) null, (SuperToolTip) null, ToolTipAnchor.Default),
        new EditorButton(ButtonPredefines.Plus),
        new EditorButton(ButtonPredefines.Search)
      });
      this.gluHopDong.Properties.DisplayMember = "TenHopDong";
      this.gluHopDong.Properties.NullText = "";
      this.gluHopDong.Properties.PopupView = (ColumnView) this.glueHopDong;
      this.gluHopDong.Properties.ValueMember = "DuLieuTronID";
      this.gluHopDong.Size = new Size(217, 22);
      this.gluHopDong.TabIndex = 197;
      this.gluHopDong.ButtonPressed += new ButtonPressedEventHandler(this.gluHopDong_ButtonPressed);
      this.gluHopDong.EditValueChanged += new EventHandler(this.gluHopDong_EditValueChanged);
      this.glueHopDong.Appearance.CustomizationFormHint.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.glueHopDong.Appearance.CustomizationFormHint.Options.UseFont = true;
      this.glueHopDong.Columns.AddRange(new GridColumn[3]
      {
        this.grcDuLieuTronID,
        this.grcMaHopDong,
        this.grcTenHopDong
      });
      this.glueHopDong.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.glueHopDong.Name = "glueHopDong";
      this.glueHopDong.OptionsEditForm.PopupEditFormWidth = 1200;
      this.glueHopDong.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.glueHopDong.OptionsView.ShowGroupPanel = false;
      this.glueHopDong.PopupMenuShowing += new PopupMenuShowingEventHandler(this.glueHopDong_PopupMenuShowing);
      this.grcDuLieuTronID.Caption = "DuLieuTronID";
      this.grcDuLieuTronID.FieldName = "DuLieuTronID";
      this.grcDuLieuTronID.Name = "grcDuLieuTronID";
      this.grcMaHopDong.AppearanceCell.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.grcMaHopDong.AppearanceCell.Options.UseFont = true;
      this.grcMaHopDong.Caption = "Mã Hợp Đồng";
      this.grcMaHopDong.FieldName = "MaHopDong";
      this.grcMaHopDong.MinWidth = 100;
      this.grcMaHopDong.Name = "grcMaHopDong";
      this.grcMaHopDong.Visible = true;
      this.grcMaHopDong.VisibleIndex = 0;
      this.grcMaHopDong.Width = 277;
      this.grcTenHopDong.AppearanceCell.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.grcTenHopDong.AppearanceCell.Options.UseFont = true;
      this.grcTenHopDong.Caption = "Tên Hợp Đồng";
      this.grcTenHopDong.FieldName = "TenHopDong";
      this.grcTenHopDong.MinWidth = 100;
      this.grcTenHopDong.Name = "grcTenHopDong";
      this.grcTenHopDong.Visible = true;
      this.grcTenHopDong.VisibleIndex = 1;
      this.grcTenHopDong.Width = 500;
      this.glueBienSo.EditValue = (object) "";
      this.glueBienSo.Location = new Point(35, 412);
      this.glueBienSo.Name = "glueBienSo";
      this.glueBienSo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.glueBienSo.Properties.Appearance.Options.UseFont = true;
      this.glueBienSo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.glueBienSo.Properties.DisplayMember = "BienSo";
      this.glueBienSo.Properties.NullText = "";
      this.glueBienSo.Properties.PopupView = (ColumnView) this.gridView2;
      this.glueBienSo.Properties.ValueMember = "XeID";
      this.glueBienSo.Size = new Size(216, 22);
      this.glueBienSo.TabIndex = 202;
      this.glueBienSo.EditValueChanged += new EventHandler(this.glueBienSo_EditValueChanged);
      this.gridView2.Columns.AddRange(new GridColumn[2]
      {
        this.grcXeID,
        this.grcBienSo
      });
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.grcXeID.Caption = "XeID";
      this.grcXeID.FieldName = "XeID";
      this.grcXeID.Name = "grcXeID";
      this.grcBienSo.Caption = "Biển Số";
      this.grcBienSo.FieldName = "BienSo";
      this.grcBienSo.Name = "grcBienSo";
      this.grcBienSo.Visible = true;
      this.grcBienSo.VisibleIndex = 0;
      this.gluTaiXe.EditValue = (object) "";
      this.gluTaiXe.Location = new Point(35, 360);
      this.gluTaiXe.Name = "gluTaiXe";
      this.gluTaiXe.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gluTaiXe.Properties.Appearance.Options.UseFont = true;
      this.gluTaiXe.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.gluTaiXe.Properties.DisplayMember = "TenTaiXe";
      this.gluTaiXe.Properties.NullText = "";
      this.gluTaiXe.Properties.PopupView = (ColumnView) this.gridView1;
      this.gluTaiXe.Properties.ValueMember = "TaiXeID";
      this.gluTaiXe.Size = new Size(218, 22);
      this.gluTaiXe.TabIndex = 200;
      this.gluTaiXe.EditValueChanged += new EventHandler(this.gluTaiXe_EditValueChanged);
      this.gridView1.Columns.AddRange(new GridColumn[3]
      {
        this.grcTaiXeID,
        this.grcMaTaiXe,
        this.grcTenTaiXe
      });
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.grcTaiXeID.Caption = "TaiXeID";
      this.grcTaiXeID.FieldName = "TaiXeID";
      this.grcTaiXeID.Name = "grcTaiXeID";
      this.grcMaTaiXe.Caption = "Mã Tài Xế";
      this.grcMaTaiXe.FieldName = "MaTaiXe";
      this.grcMaTaiXe.Name = "grcMaTaiXe";
      this.grcMaTaiXe.Visible = true;
      this.grcMaTaiXe.VisibleIndex = 0;
      this.grcTenTaiXe.Caption = "Tên Tài Xế";
      this.grcTenTaiXe.FieldName = "TenTaiXe";
      this.grcTenTaiXe.Name = "grcTenTaiXe";
      this.grcTenTaiXe.Visible = true;
      this.grcTenTaiXe.VisibleIndex = 1;
      this.VAA.Appearance.BackColor = Color.White;
      this.VAA.Appearance.Options.UseBackColor = true;
      this.VAA.BorderStyle = BorderStyles.Simple;
      this.VAA.Controls.Add((Control) this.lblPhone);
      this.VAA.Controls.Add((Control) this.lblGmail);
      this.VAA.Controls.Add((Control) this.lblNameCty);
      this.VAA.Controls.Add((Control) this.lblDec);
      this.VAA.Location = new Point(1217, 9);
      this.VAA.Name = "VAA";
      this.VAA.ShowCaption = false;
      this.VAA.Size = new Size(427, 90);
      this.VAA.TabIndex = 204;
      this.VAA.Text = "groupControl2";
      this.lblPhone.Appearance.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhone.Appearance.ForeColor = Color.Sienna;
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Appearance.Options.UseForeColor = true;
      this.lblPhone.Appearance.Options.UseTextOptions = true;
      this.lblPhone.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.lblPhone.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblPhone.Location = new Point(14, 67);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(400, 20);
      this.lblPhone.TabIndex = 195;
      this.lblPhone.Text = "Tel: 0913387319";
      this.lblGmail.Appearance.Font = new Font("Times New Roman", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblGmail.Appearance.ForeColor = Color.Black;
      this.lblGmail.Appearance.Options.UseFont = true;
      this.lblGmail.Appearance.Options.UseForeColor = true;
      this.lblGmail.Appearance.Options.UseTextOptions = true;
      this.lblGmail.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.lblGmail.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblGmail.Location = new Point(14, 48);
      this.lblGmail.Name = "lblGmail";
      this.lblGmail.Size = new Size(400, 20);
      this.lblGmail.TabIndex = 194;
      this.lblGmail.Text = "Email: Congnghexanhvietduc@gmail.com   ";
      this.btnCheDoXaCan.BackColor = Color.Transparent;
      this.btnCheDoXaCan.BackgroundImage = (Image) ResourceNhua._btnMAN;
      this.btnCheDoXaCan.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnCheDoXaCan.Bg_Click = ResourceNhua._btnAUTO;
      this.btnCheDoXaCan.Bg_NoClick = ResourceNhua._btnMAN;
      this.btnCheDoXaCan.IsOn = true;
      this.btnCheDoXaCan.IsTrangThai = ucBtnCheDo.TrangThai.Stop;
      this.btnCheDoXaCan.Location = new Point(551, 816);
      this.btnCheDoXaCan.Name = "btnCheDoXaCan";
      this.btnCheDoXaCan.Size = new Size(100, 40);
      this.btnCheDoXaCan.TabIndex = 195;
      this.btnCheDoXaCan.ButtonClick += new ucBtnCheDo.DelButtonEventHandler(this.btnCheDoXaCan_ButtonClick);
      this.btnTanSay.BackColor = Color.DarkGray;
      this.btnTanSay.BackgroundImage = (Image) ResourceNhua._tinHieuLoDot;
      this.btnTanSay.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnTanSay.Bg_Click = ResourceNhua._tinHieuLoDotRun;
      this.btnTanSay.Bg_NoClick = ResourceNhua._tinHieuLoDot;
      this.btnTanSay.IsOn = true;
      this.btnTanSay.IsTrangThai = ucTinHieuTanSayQuay.TrangThai.Stop;
      this.btnTanSay.Location = new Point(1080, 673);
      this.btnTanSay.Name = "btnTanSay";
      this.btnTanSay.Size = new Size(110, 32);
      this.btnTanSay.TabIndex = 194;
      this.btnTanSay.ButtonMouseDown += new ucTinHieuTanSayQuay.ButtonEventHandler(this.btnTanSay_ButtonMouseDown);
      this.btnTanSay.ButtonMouseUp += new ucTinHieuTanSayQuay.ButtonEventHandler(this.btnTanSay_ButtonMouseUp);
      this.ucBtnVitTai1.BackColor = Color.Transparent;
      this.ucBtnVitTai1.BackgroundImage = (Image) componentResourceManager.GetObject("ucBtnVitTai1.BackgroundImage");
      this.ucBtnVitTai1.Bg_Click = ResourceNhua._btnVuongRun;
      this.ucBtnVitTai1.Bg_NoClick = ResourceNhua._btnVuong;
      this.ucBtnVitTai1.IsOn = false;
      this.ucBtnVitTai1.Location = new Point(71, 604);
      this.ucBtnVitTai1.Name = "ucBtnVitTai1";
      this.ucBtnVitTai1.Size = new Size(50, 20);
      this.ucBtnVitTai1.TabIndex = 191;
      this.ucBtnVitTai1.Visible = false;
      this.ucBtnVitTai1.ButtonMouseDown += new ucBtnVitTai.ButtonEventHandler(this.ucBtnVitTai1_ButtonMouseDown);
      this.ucBtnVitTai1.ButtonMouseUp += new ucBtnVitTai.ButtonEventHandler(this.ucBtnVitTai1_ButtonMouseUp);
      this.btnSanRung.BackColor = Color.MediumTurquoise;
      this.btnSanRung.BackgroundImage = (Image) componentResourceManager.GetObject("btnSanRung.BackgroundImage");
      this.btnSanRung.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnSanRung.IsOn = false;
      this.btnSanRung.Location = new Point(705, 86);
      this.btnSanRung.Name = "btnSanRung";
      this.btnSanRung.Size = new Size(76, 44);
      this.btnSanRung.TabIndex = 190;
      this.btnSanRung.ButtonMouseDown += new ucBtnSanRung.ButtonEventHandler(this.btnSanRung_ButtonMouseDown);
      this.btnSanRung.ButtonMouseUp += new ucBtnSanRung.ButtonEventHandler(this.btnSanRung_ButtonMouseUp);
      this.tinHieuMoCuaNoi.BackColor = Color.Transparent;
      this.tinHieuMoCuaNoi.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuMoCuaNoi.BackgroundImage");
      this.tinHieuMoCuaNoi.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuMoCuaNoi.Location = new Point(522, 714);
      this.tinHieuMoCuaNoi.Name = "tinHieuMoCuaNoi";
      this.tinHieuMoCuaNoi.Size = new Size(30, 15);
      this.tinHieuMoCuaNoi.TabIndex = 189;
      this.tinHieuDongCuaNoi.BackColor = Color.Transparent;
      this.tinHieuDongCuaNoi.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuDongCuaNoi.BackgroundImage");
      this.tinHieuDongCuaNoi.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuDongCuaNoi.Location = new Point(737, 714);
      this.tinHieuDongCuaNoi.Name = "tinHieuDongCuaNoi";
      this.tinHieuDongCuaNoi.Size = new Size(30, 15);
      this.tinHieuDongCuaNoi.TabIndex = 188;
      this.tinHieuSanRung.BackColor = Color.DarkSlateGray;
      this.tinHieuSanRung.BackgroundImage = (Image) ResourceNhua._tinhieu_SanRung;
      this.tinHieuSanRung.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuSanRung.Bg_Click = ResourceNhua._tinhieu_SanRungRun;
      this.tinHieuSanRung.Bg_NoClick = ResourceNhua._tinhieu_SanRung;
      this.tinHieuSanRung.IsOn = true;
      this.tinHieuSanRung.IsTrangThai = ucTinHieuSanRung.TrangThai.Stop;
      this.tinHieuSanRung.Location = new Point(442, 94);
      this.tinHieuSanRung.Name = "tinHieuSanRung";
      this.tinHieuSanRung.Size = new Size(72, 64);
      this.tinHieuSanRung.TabIndex = 187;
      this.ucBangGauTauCatDaNhanh1.BackColor = Color.Transparent;
      this.ucBangGauTauCatDaNhanh1.BackgroundImage = (Image) ResourceNhua._banggautaicatdanhanh;
      this.ucBangGauTauCatDaNhanh1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucBangGauTauCatDaNhanh1.Location = new Point(941, 59);
      this.ucBangGauTauCatDaNhanh1.Name = "ucBangGauTauCatDaNhanh1";
      this.ucBangGauTauCatDaNhanh1.Size = new Size(159, 32);
      this.ucBangGauTauCatDaNhanh1.TabIndex = 184;
      this.ucBangGauTaiCatDa1.BackColor = Color.Transparent;
      this.ucBangGauTaiCatDa1.BackgroundImage = (Image) ResourceNhua._banggautaicatda;
      this.ucBangGauTaiCatDa1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucBangGauTaiCatDa1.Location = new Point(1092, 57);
      this.ucBangGauTaiCatDa1.Name = "ucBangGauTaiCatDa1";
      this.ucBangGauTaiCatDa1.Size = new Size(40, 593);
      this.ucBangGauTaiCatDa1.TabIndex = 183;
      this.motorGauTaiAGG1.BackColor = Color.Transparent;
      this.motorGauTaiAGG1.BackgroundImage = (Image) ResourceNhua._motor_miniN;
      this.motorGauTaiAGG1.BackgroundImageLayout = ImageLayout.Stretch;
      this.motorGauTaiAGG1.Bg_Click = ResourceNhua._motor_miniNRun;
      this.motorGauTaiAGG1.Bg_NoClick = ResourceNhua._motor_miniN;
      this.motorGauTaiAGG1.IsOn = true;
      this.motorGauTaiAGG1.IsTrangThai = ucMotorMiniN.TrangThai.Stop;
      this.motorGauTaiAGG1.Location = new Point(1120, 65);
      this.motorGauTaiAGG1.Name = "motorGauTaiAGG1";
      this.motorGauTaiAGG1.Size = new Size(58, 34);
      this.motorGauTaiAGG1.TabIndex = 182;
      this.motorGauTaiAGG1.ButtonMouseDown += new ucMotorMiniN.DelButtonEventHandler(this.motorGauTaiAGG1_ButtonMouseDown);
      this.motorGauTaiAGG1.ButtonMouseUp += new ucMotorMiniN.DelButtonEventHandler(this.motorGauTaiAGG1_ButtonMouseUp);
      this.btnRungCL3.BackColor = Color.DarkCyan;
      this.btnRungCL3.BackgroundImage = (Image) componentResourceManager.GetObject("btnRungCL3.BackgroundImage");
      this.btnRungCL3.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnRungCL3.Bg_Click = ResourceNhua._btnTronXRun;
      this.btnRungCL3.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnRungCL3.Bg_NoClick");
      this.btnRungCL3.IsOn = false;
      this.btnRungCL3.Location = new Point(1660, 649);
      this.btnRungCL3.Name = "btnRungCL3";
      this.btnRungCL3.Size = new Size(16, 16);
      this.btnRungCL3.TabIndex = 181;
      this.btnRungCL3.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnRungCL3_ButtonMouseDown);
      this.btnRungCL3.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnRungCL3_ButtonMouseUp);
      this.btnRungCL2.BackColor = Color.DarkCyan;
      this.btnRungCL2.BackgroundImage = (Image) componentResourceManager.GetObject("btnRungCL2.BackgroundImage");
      this.btnRungCL2.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnRungCL2.Bg_Click = ResourceNhua._btnTronXRun;
      this.btnRungCL2.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnRungCL2.Bg_NoClick");
      this.btnRungCL2.IsOn = false;
      this.btnRungCL2.Location = new Point(1581, 649);
      this.btnRungCL2.Name = "btnRungCL2";
      this.btnRungCL2.Size = new Size(16, 16);
      this.btnRungCL2.TabIndex = 180;
      this.btnRungCL2.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnRungCL2_ButtonMouseDown);
      this.btnRungCL2.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnRungCL2_ButtonMouseUp);
      this.btnRungCL1.BackColor = Color.DarkCyan;
      this.btnRungCL1.BackgroundImage = (Image) componentResourceManager.GetObject("btnRungCL1.BackgroundImage");
      this.btnRungCL1.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnRungCL1.Bg_Click = ResourceNhua._btnTronXRun;
      this.btnRungCL1.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnRungCL1.Bg_NoClick");
      this.btnRungCL1.IsOn = false;
      this.btnRungCL1.Location = new Point(1500, 649);
      this.btnRungCL1.Name = "btnRungCL1";
      this.btnRungCL1.Size = new Size(16, 16);
      this.btnRungCL1.TabIndex = 179;
      this.btnRungCL1.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnRungCL1_ButtonMouseDown);
      this.btnRungCL1.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnRungCL1_ButtonMouseUp);
      this.ucBeTiep1.BackColor = Color.Transparent;
      this.ucBeTiep1.BackgroundImage = (Image) ResourceNhua._betiep;
      this.ucBeTiep1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucBeTiep1.Location = new Point(161, 714);
      this.ucBeTiep1.Name = "ucBeTiep1";
      this.ucBeTiep1.Size = new Size(80, 30);
      this.ucBeTiep1.TabIndex = 178;
      this.ucBangGauTaiXiMang2.BackColor = Color.Transparent;
      this.ucBangGauTaiXiMang2.BackgroundImage = (Image) ResourceNhua._banggautaiximang;
      this.ucBangGauTaiXiMang2.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucBangGauTaiXiMang2.Location = new Point(199, 129);
      this.ucBangGauTaiXiMang2.Name = "ucBangGauTaiXiMang2";
      this.ucBangGauTaiXiMang2.Size = new Size(42, 586);
      this.ucBangGauTaiXiMang2.TabIndex = 177;
      this.btnFU_SBS.BackColor = Color.Transparent;
      this.btnFU_SBS.BackgroundImage = (Image) componentResourceManager.GetObject("btnFU_SBS.BackgroundImage");
      this.btnFU_SBS.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnFU_SBS.Bg_Click = ResourceNhua._btnFURun;
      this.btnFU_SBS.Bg_NoClick = ResourceNhua._btnFU;
      this.btnFU_SBS.IsOn = false;
      this.btnFU_SBS.Location = new Point(1007, 349);
      this.btnFU_SBS.Name = "btnFU_SBS";
      this.btnFU_SBS.Size = new Size(30, 15);
      this.btnFU_SBS.TabIndex = 176;
      this.btnFU_SBS.ButtonMouseDown += new ucBtnFU.ButtonEventHandler(this.btnFU_SBS_ButtonMouseDown);
      this.btnFU_SBS.ButtonMouseUp += new ucBtnFU.ButtonEventHandler(this.btnFU_SBS_ButtonMouseUp);
      this.btnFU_AP.BackColor = Color.Transparent;
      this.btnFU_AP.BackgroundImage = (Image) componentResourceManager.GetObject("btnFU_AP.BackgroundImage");
      this.btnFU_AP.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnFU_AP.Bg_Click = ResourceNhua._btnFURun;
      this.btnFU_AP.Bg_NoClick = ResourceNhua._btnFU;
      this.btnFU_AP.IsOn = false;
      this.btnFU_AP.Location = new Point(893, 349);
      this.btnFU_AP.Name = "btnFU_AP";
      this.btnFU_AP.Size = new Size(30, 15);
      this.btnFU_AP.TabIndex = 175;
      this.btnFU_AP.ButtonMouseDown += new ucBtnFU.ButtonEventHandler(this.btnFU_AP_ButtonMouseDown);
      this.btnFU_AP.ButtonMouseUp += new ucBtnFU.ButtonEventHandler(this.btnFU_AP_ButtonMouseUp);
      this.btnFU_AGG5.BackColor = Color.Transparent;
      this.btnFU_AGG5.BackgroundImage = (Image) componentResourceManager.GetObject("btnFU_AGG5.BackgroundImage");
      this.btnFU_AGG5.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnFU_AGG5.Bg_Click = ResourceNhua._btnFURun;
      this.btnFU_AGG5.Bg_NoClick = ResourceNhua._btnFU;
      this.btnFU_AGG5.IsOn = false;
      this.btnFU_AGG5.Location = new Point(778, 349);
      this.btnFU_AGG5.Name = "btnFU_AGG5";
      this.btnFU_AGG5.Size = new Size(30, 15);
      this.btnFU_AGG5.TabIndex = 174;
      this.btnFU_AGG5.ButtonMouseDown += new ucBtnFU.ButtonEventHandler(this.btnFU_AGG5_ButtonMouseDown);
      this.btnFU_AGG5.ButtonMouseUp += new ucBtnFU.ButtonEventHandler(this.btnFU_AGG5_ButtonMouseUp);
      this.btnFU_AGG4.BackColor = Color.Transparent;
      this.btnFU_AGG4.BackgroundImage = (Image) componentResourceManager.GetObject("btnFU_AGG4.BackgroundImage");
      this.btnFU_AGG4.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnFU_AGG4.Bg_Click = ResourceNhua._btnFURun;
      this.btnFU_AGG4.Bg_NoClick = ResourceNhua._btnFU;
      this.btnFU_AGG4.IsOn = false;
      this.btnFU_AGG4.Location = new Point(691, 349);
      this.btnFU_AGG4.Name = "btnFU_AGG4";
      this.btnFU_AGG4.Size = new Size(30, 15);
      this.btnFU_AGG4.TabIndex = 173;
      this.btnFU_AGG4.ButtonMouseDown += new ucBtnFU.ButtonEventHandler(this.btnFU_AGG4_ButtonMouseDown);
      this.btnFU_AGG4.ButtonMouseUp += new ucBtnFU.ButtonEventHandler(this.btnFU_AGG4_ButtonMouseUp);
      this.btnFU_AGG3.BackColor = Color.Transparent;
      this.btnFU_AGG3.BackgroundImage = (Image) componentResourceManager.GetObject("btnFU_AGG3.BackgroundImage");
      this.btnFU_AGG3.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnFU_AGG3.Bg_Click = ResourceNhua._btnFURun;
      this.btnFU_AGG3.Bg_NoClick = ResourceNhua._btnFU;
      this.btnFU_AGG3.IsOn = false;
      this.btnFU_AGG3.Location = new Point(606, 349);
      this.btnFU_AGG3.Name = "btnFU_AGG3";
      this.btnFU_AGG3.Size = new Size(30, 15);
      this.btnFU_AGG3.TabIndex = 172;
      this.btnFU_AGG3.ButtonMouseDown += new ucBtnFU.ButtonEventHandler(this.btnFU_AGG3_ButtonMouseDown);
      this.btnFU_AGG3.ButtonMouseUp += new ucBtnFU.ButtonEventHandler(this.btnFU_AGG3_ButtonMouseUp);
      this.btnFU_AGG2.BackColor = Color.Transparent;
      this.btnFU_AGG2.BackgroundImage = (Image) componentResourceManager.GetObject("btnFU_AGG2.BackgroundImage");
      this.btnFU_AGG2.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnFU_AGG2.Bg_Click = ResourceNhua._btnFURun;
      this.btnFU_AGG2.Bg_NoClick = ResourceNhua._btnFU;
      this.btnFU_AGG2.IsOn = false;
      this.btnFU_AGG2.Location = new Point(519, 349);
      this.btnFU_AGG2.Name = "btnFU_AGG2";
      this.btnFU_AGG2.Size = new Size(30, 15);
      this.btnFU_AGG2.TabIndex = 171;
      this.btnFU_AGG2.ButtonMouseDown += new ucBtnFU.ButtonEventHandler(this.btnFU_AGG2_ButtonMouseDown);
      this.btnFU_AGG2.ButtonMouseUp += new ucBtnFU.ButtonEventHandler(this.btnFU_AGG2_ButtonMouseUp);
      this.btnFU_AG1.BackColor = Color.Transparent;
      this.btnFU_AG1.BackgroundImage = (Image) componentResourceManager.GetObject("btnFU_AG1.BackgroundImage");
      this.btnFU_AG1.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnFU_AG1.Bg_Click = ResourceNhua._btnFURun;
      this.btnFU_AG1.Bg_NoClick = ResourceNhua._btnFU;
      this.btnFU_AG1.IsOn = false;
      this.btnFU_AG1.Location = new Point(434, 349);
      this.btnFU_AG1.Name = "btnFU_AG1";
      this.btnFU_AG1.Size = new Size(30, 15);
      this.btnFU_AG1.TabIndex = 170;
      this.btnFU_AG1.ButtonMouseDown += new ucBtnFU.ButtonEventHandler(this.btnFU_AG1_ButtonMouseDown);
      this.btnFU_AG1.ButtonMouseUp += new ucBtnFU.ButtonEventHandler(this.btnFU_AG1_ButtonMouseUp);
      this.btnFU_FD.BackColor = Color.Transparent;
      this.btnFU_FD.BackgroundImage = (Image) componentResourceManager.GetObject("btnFU_FD.BackgroundImage");
      this.btnFU_FD.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnFU_FD.Bg_Click = ResourceNhua._btnFURun;
      this.btnFU_FD.Bg_NoClick = ResourceNhua._btnFU;
      this.btnFU_FD.IsOn = false;
      this.btnFU_FD.Location = new Point(331, 349);
      this.btnFU_FD.Name = "btnFU_FD";
      this.btnFU_FD.Size = new Size(30, 15);
      this.btnFU_FD.TabIndex = 169;
      this.btnFU_FD.ButtonMouseDown += new ucBtnFU.ButtonEventHandler(this.btnFU_FD_ButtonMouseDown);
      this.btnFU_FD.ButtonMouseUp += new ucBtnFU.ButtonEventHandler(this.btnFU_FD_ButtonMouseUp);
      this.ucBangGauTaiXiMangNhanh1.BackColor = Color.Transparent;
      this.ucBangGauTaiXiMangNhanh1.BackgroundImage = (Image) ResourceNhua._banggautaiximangnhanh;
      this.ucBangGauTaiXiMangNhanh1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucBangGauTaiXiMangNhanh1.Location = new Point(239, 129);
      this.ucBangGauTaiXiMangNhanh1.Name = "ucBangGauTaiXiMangNhanh1";
      this.ucBangGauTaiXiMangNhanh1.Size = new Size(120, 74);
      this.ucBangGauTaiXiMangNhanh1.TabIndex = 166;
      this.textEdit4.EditValue = (object) "0";
      this.textEdit4.Location = new Point(55, 305);
      this.textEdit4.Name = "textEdit4";
      this.textEdit4.Properties.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textEdit4.Properties.Appearance.Options.UseFont = true;
      this.textEdit4.Properties.Appearance.Options.UseTextOptions = true;
      this.textEdit4.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.textEdit4.Properties.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.textEdit4.Size = new Size(86, 32);
      this.textEdit4.TabIndex = 155;
      this.textEdit2.EditValue = (object) "0";
      this.textEdit2.Location = new Point(55, 470);
      this.textEdit2.Name = "textEdit2";
      this.textEdit2.Properties.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textEdit2.Properties.Appearance.Options.UseFont = true;
      this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
      this.textEdit2.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.textEdit2.Properties.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.textEdit2.Properties.ReadOnly = true;
      this.textEdit2.Size = new Size(86, 32);
      this.textEdit2.TabIndex = 153;
      this.siloFDFat.BackColor = Color.Transparent;
      this.siloFDFat.BackgroundImage = (Image) componentResourceManager.GetObject("siloFDFat.BackgroundImage");
      this.siloFDFat.BackgroundImageLayout = ImageLayout.Stretch;
      this.siloFDFat.Location = new Point(49, 193);
      this.siloFDFat.Name = "siloFDFat";
      this.siloFDFat.Size = new Size(97, 500);
      this.siloFDFat.TabIndex = 152;
      this.tinHIeuVitTaiFD.BackColor = Color.Transparent;
      this.tinHIeuVitTaiFD.BackgroundImage = (Image) ResourceNhua._vittaiFD;
      this.tinHIeuVitTaiFD.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHIeuVitTaiFD.Bg_Click = ResourceNhua._vittaiFDRun;
      this.tinHIeuVitTaiFD.Bg_NoClick = ResourceNhua._vittaiFD;
      this.tinHIeuVitTaiFD.CheDo = ucVitTaiFD.Action.Pause;
      this.tinHIeuVitTaiFD.Location = new Point(46, 667);
      this.tinHIeuVitTaiFD.Name = "tinHIeuVitTaiFD";
      this.tinHIeuVitTaiFD.Size = new Size(141, 136);
      this.tinHIeuVitTaiFD.TabIndex = 151;
      this.tinHIeuVitTaiFD.ButtonMouseDown += new ucVitTaiFD.ButtonEventHandler(this.tinHIeuVitTaiFD_ButtonMouseDown);
      this.tinHIeuVitTaiFD.ButtonMouseUp += new ucVitTaiFD.ButtonEventHandler(this.tinHIeuVitTaiFD_ButtonMouseUp);
      this.memoEdit1.EditValue = (object) "";
      this.memoEdit1.Location = new Point(28, 32);
      this.memoEdit1.Name = "memoEdit1";
      this.memoEdit1.Properties.Appearance.BackColor = Color.White;
      this.memoEdit1.Properties.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.memoEdit1.Properties.Appearance.ForeColor = Color.Blue;
      this.memoEdit1.Properties.Appearance.Options.UseBackColor = true;
      this.memoEdit1.Properties.Appearance.Options.UseFont = true;
      this.memoEdit1.Properties.Appearance.Options.UseForeColor = true;
      this.memoEdit1.Properties.BorderStyle = BorderStyles.Simple;
      this.memoEdit1.Properties.ReadOnly = true;
      this.memoEdit1.Properties.ScrollBars = ScrollBars.None;
      this.memoEdit1.Size = new Size(326, 68);
      this.memoEdit1.TabIndex = 149;
      this.btnMayNenKhi.BackColor = Color.Transparent;
      this.btnMayNenKhi.BackgroundImage = (Image) ResourceNhua._tinhieu_BomKhi;
      this.btnMayNenKhi.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnMayNenKhi.Bg_Click = ResourceNhua._tinhieu_BomKhiRun;
      this.btnMayNenKhi.Bg_NoClick = ResourceNhua._tinhieu_BomKhi;
      this.btnMayNenKhi.IsOn = true;
      this.btnMayNenKhi.IsTrangThai = ucBtnBomKhi.TrangThai.Stop;
      this.btnMayNenKhi.Location = new Point(302, 666);
      this.btnMayNenKhi.Name = "btnMayNenKhi";
      this.btnMayNenKhi.Size = new Size(32, 24);
      this.btnMayNenKhi.TabIndex = 148;
      this.btnMayNenKhi.ButtonMouseDown += new ucBtnBomKhi.DelButtonEventHandler(this.btnMayNenKhi_ButtonMouseDown);
      this.btnMayNenKhi.ButtonMouseUp += new ucBtnBomKhi.DelButtonEventHandler(this.btnMayNenKhi_ButtonMouseUp);
      this.ucBomKhi1.BackColor = Color.Transparent;
      this.ucBomKhi1.BackgroundImage = (Image) componentResourceManager.GetObject("ucBomKhi1.BackgroundImage");
      this.ucBomKhi1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucBomKhi1.Location = new Point(273, 658);
      this.ucBomKhi1.Name = "ucBomKhi1";
      this.ucBomKhi1.Size = new Size(114, 90);
      this.ucBomKhi1.TabIndex = 147;
      this.txtTG_BomTuoiNhua.EditValue = (object) "0";
      this.txtTG_BomTuoiNhua.Location = new Point(900, 601);
      this.txtTG_BomTuoiNhua.Name = "txtTG_BomTuoiNhua";
      this.txtTG_BomTuoiNhua.Properties.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTG_BomTuoiNhua.Properties.Appearance.Options.UseFont = true;
      this.txtTG_BomTuoiNhua.Properties.Appearance.Options.UseTextOptions = true;
      this.txtTG_BomTuoiNhua.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.txtTG_BomTuoiNhua.Properties.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.txtTG_BomTuoiNhua.Size = new Size(109, 32);
      this.txtTG_BomTuoiNhua.TabIndex = 142;
      this.txtTG_BomTuoiNhua.EditValueChanged += new EventHandler(this.txtTG_BomTuoiNhua_EditValueChanged);
      this.txtTG_BomTuoiNhua.KeyPress += new KeyPressEventHandler(this.txtTG_BomTuoiNhua_KeyPress);
      this.textEdit3.EditValue = (object) "0";
      this.textEdit3.Location = new Point(1525, 267);
      this.textEdit3.Name = "textEdit3";
      this.textEdit3.Properties.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textEdit3.Properties.Appearance.Options.UseFont = true;
      this.textEdit3.Properties.Appearance.Options.UseTextOptions = true;
      this.textEdit3.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.textEdit3.Properties.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.textEdit3.Properties.ReadOnly = true;
      this.textEdit3.Size = new Size(86, 32);
      this.textEdit3.TabIndex = 138;
      this.textEdit1.EditValue = (object) "0";
      this.textEdit1.Location = new Point(1525, 210);
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Properties.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.textEdit1.Properties.Appearance.Options.UseFont = true;
      this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
      this.textEdit1.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.textEdit1.Properties.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.textEdit1.Size = new Size(86, 32);
      this.textEdit1.TabIndex = 136;
      this.btnVanCanSBS.BackColor = Color.Silver;
      this.btnVanCanSBS.BackgroundImage = (Image) componentResourceManager.GetObject("btnVanCanSBS.BackgroundImage");
      this.btnVanCanSBS.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnVanCanSBS.Bg_Click = (Bitmap) componentResourceManager.GetObject("btnVanCanSBS.Bg_Click");
      this.btnVanCanSBS.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnVanCanSBS.Bg_NoClick");
      this.btnVanCanSBS.IsOn = false;
      this.btnVanCanSBS.Location = new Point(1013, 371);
      this.btnVanCanSBS.Name = "btnVanCanSBS";
      this.btnVanCanSBS.Size = new Size(16, 16);
      this.btnVanCanSBS.TabIndex = 129;
      this.btnVanCanSBS.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnVanCanSBS_ButtonMouseDown);
      this.btnVanCanSBS.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnVanCanSBS_ButtonMouseUp);
      this.ucOngSBS1.BackColor = Color.Transparent;
      this.ucOngSBS1.BackgroundImage = (Image) ResourceNhua._ongSBS;
      this.ucOngSBS1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucOngSBS1.Location = new Point(996, 161);
      this.ucOngSBS1.Name = "ucOngSBS1";
      this.ucOngSBS1.Size = new Size(226, 99);
      this.ucOngSBS1.TabIndex = (int) sbyte.MaxValue;
      this.btnVanCanAP.BackColor = Color.Silver;
      this.btnVanCanAP.BackgroundImage = (Image) componentResourceManager.GetObject("btnVanCanAP.BackgroundImage");
      this.btnVanCanAP.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnVanCanAP.Bg_Click = (Bitmap) componentResourceManager.GetObject("btnVanCanAP.Bg_Click");
      this.btnVanCanAP.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnVanCanAP.Bg_NoClick");
      this.btnVanCanAP.IsOn = false;
      this.btnVanCanAP.Location = new Point(900, 371);
      this.btnVanCanAP.Name = "btnVanCanAP";
      this.btnVanCanAP.Size = new Size(16, 16);
      this.btnVanCanAP.TabIndex = 126;
      this.btnVanCanAP.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAP_ButtonMouseDown);
      this.btnVanCanAP.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAP_ButtonMouseUp);
      this.ucPheuChua011.BackColor = Color.Transparent;
      this.ucPheuChua011.BackgroundImage = (Image) componentResourceManager.GetObject("ucPheuChua011.BackgroundImage");
      this.ucPheuChua011.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucPheuChua011.Location = new Point(1231, 109);
      this.ucPheuChua011.Name = "ucPheuChua011";
      this.ucPheuChua011.Size = new Size(170, 212);
      this.ucPheuChua011.TabIndex = 124;
      this.motorPheuChua01.BackColor = Color.Transparent;
      this.motorPheuChua01.BackgroundImage = (Image) ResourceNhua._motor_fat;
      this.motorPheuChua01.BackgroundImageLayout = ImageLayout.Stretch;
      this.motorPheuChua01.Bg_Click = ResourceNhua._motor_fatRun;
      this.motorPheuChua01.Bg_NoClick = ResourceNhua._motor_fat;
      this.motorPheuChua01.IsOn = true;
      this.motorPheuChua01.IsTrangThai = ucMotorFat.TrangThai.Stop;
      this.motorPheuChua01.Location = new Point(1143, 259);
      this.motorPheuChua01.Name = "motorPheuChua01";
      this.motorPheuChua01.Size = new Size(88, 47);
      this.motorPheuChua01.TabIndex = 123;
      this.motorPheuChua01.ButtonMouseDown += new ucMotorFat.DelButtonEventHandler(this.motorPheuChua01_ButtonMouseDown);
      this.motorPheuChua01.ButtonMouseUp += new ucMotorFat.DelButtonEventHandler(this.motorPheuChua01_ButtonMouseUp);
      this.ucOngAP1.BackColor = Color.Transparent;
      this.ucOngAP1.BackgroundImage = (Image) ResourceNhua._ongAP;
      this.ucOngAP1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucOngAP1.Location = new Point(901, 146);
      this.ucOngAP1.Name = "ucOngAP1";
      this.ucOngAP1.Size = new Size(584, 115);
      this.ucOngAP1.TabIndex = 122;
      this.ucOngMotor1.BackColor = Color.Transparent;
      this.ucOngMotor1.BackgroundImage = (Image) componentResourceManager.GetObject("ucOngMotor1.BackgroundImage");
      this.ucOngMotor1.Location = new Point(1157, 480);
      this.ucOngMotor1.Name = "ucOngMotor1";
      this.ucOngMotor1.Size = new Size(40, 170);
      this.ucOngMotor1.TabIndex = 121;
      this.ucBonChuaTanSay1.BackColor = Color.Transparent;
      this.ucBonChuaTanSay1.BackgroundImage = (Image) componentResourceManager.GetObject("ucBonChuaTanSay1.BackgroundImage");
      this.ucBonChuaTanSay1.Location = new Point(1077, 646);
      this.ucBonChuaTanSay1.Name = "ucBonChuaTanSay1";
      this.ucBonChuaTanSay1.Size = new Size(203, 90);
      this.ucBonChuaTanSay1.TabIndex = 120;
      this.bomNgamPheuChua.BackColor = Color.DarkGray;
      this.bomNgamPheuChua.BackgroundImage = (Image) ResourceNhua._bom_ngam;
      this.bomNgamPheuChua.BackgroundImageLayout = ImageLayout.Stretch;
      this.bomNgamPheuChua.Bg_Click = ResourceNhua._bom_ngamRun;
      this.bomNgamPheuChua.Bg_NoClick = ResourceNhua._bom_ngam;
      this.bomNgamPheuChua.IsOn = true;
      this.bomNgamPheuChua.IsTrangThai = ucBomNgam.TrangThai.Stop;
      this.bomNgamPheuChua.Location = new Point(1387, 409);
      this.bomNgamPheuChua.Name = "bomNgamPheuChua";
      this.bomNgamPheuChua.Size = new Size(45, 70);
      this.bomNgamPheuChua.TabIndex = 118;
      this.bomNgamPheuChua.ButtonMouseDown += new ucBomNgam.DelButtonEventHandler(this.bomNgamPheuChua_ButtonMouseDown);
      this.bomNgamPheuChua.ButtonMouseUp += new ucBomNgam.DelButtonEventHandler(this.bomNgamPheuChua_ButtonMouseUp);
      this.ucPheuChua041.BackColor = Color.Transparent;
      this.ucPheuChua041.BackgroundImage = (Image) componentResourceManager.GetObject("ucPheuChua041.BackgroundImage");
      this.ucPheuChua041.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucPheuChua041.Location = new Point(1374, 349);
      this.ucPheuChua041.Name = "ucPheuChua041";
      this.ucPheuChua041.Size = new Size(72, 147);
      this.ucPheuChua041.TabIndex = 117;
      this.ucOngPheuChua041.BackColor = Color.Transparent;
      this.ucOngPheuChua041.BackgroundImage = (Image) componentResourceManager.GetObject("ucOngPheuChua041.BackgroundImage");
      this.ucOngPheuChua041.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucOngPheuChua041.Location = new Point(1298, 375);
      this.ucOngPheuChua041.Name = "ucOngPheuChua041";
      this.ucOngPheuChua041.Size = new Size(145, 52);
      this.ucOngPheuChua041.TabIndex = 116;
      this.ucOngPheuChua031.BackColor = Color.Transparent;
      this.ucOngPheuChua031.BackgroundImage = (Image) componentResourceManager.GetObject("ucOngPheuChua031.BackgroundImage");
      this.ucOngPheuChua031.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucOngPheuChua031.Location = new Point(1436, 459);
      this.ucOngPheuChua031.Name = "ucOngPheuChua031";
      this.ucOngPheuChua031.Size = new Size(51, 18);
      this.ucOngPheuChua031.TabIndex = 115;
      this.ucOngBonChuaKhi1.BackColor = Color.Transparent;
      this.ucOngBonChuaKhi1.BackgroundImage = (Image) componentResourceManager.GetObject("ucOngBonChuaKhi1.BackgroundImage");
      this.ucOngBonChuaKhi1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucOngBonChuaKhi1.Location = new Point(1031, 782);
      this.ucOngBonChuaKhi1.Name = "ucOngBonChuaKhi1";
      this.ucOngBonChuaKhi1.Size = new Size(46, 27);
      this.ucOngBonChuaKhi1.TabIndex = 114;
      this.ucOngTanSay1.BackColor = Color.Transparent;
      this.ucOngTanSay1.BackgroundImage = (Image) componentResourceManager.GetObject("ucOngTanSay1.BackgroundImage");
      this.ucOngTanSay1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucOngTanSay1.Location = new Point(1006, 714);
      this.ucOngTanSay1.Name = "ucOngTanSay1";
      this.ucOngTanSay1.Size = new Size(24, 58);
      this.ucOngTanSay1.TabIndex = 113;
      this.bangTaiXien.BackColor = Color.Transparent;
      this.bangTaiXien.BackgroundImage = (Image) ResourceNhua._btx;
      this.bangTaiXien.BackgroundImageLayout = ImageLayout.Stretch;
      this.bangTaiXien.Bg_Click = ResourceNhua._btxRun___Copy;
      this.bangTaiXien.Bg_NoClick = ResourceNhua._btx;
      this.bangTaiXien.CheDo = ucBTX.Action.Pause;
      this.bangTaiXien.Location = new Point(1285, 622);
      this.bangTaiXien.Name = "bangTaiXien";
      this.bangTaiXien.Size = new Size(180, 184);
      this.bangTaiXien.TabIndex = 108;
      this.bangTaiXien.ButtonMouseDown += new ucBTX.ButtonEventHandler(this.bangTaiXien_ButtonMouseDown);
      this.bangTaiXien.ButtonMouseUp += new ucBTX.ButtonEventHandler(this.bangTaiXien_ButtonMouseUp);
      this.bangTaiCan.BackColor = Color.Transparent;
      this.bangTaiCan.BackgroundImage = (Image) ResourceNhua._btc;
      this.bangTaiCan.BackgroundImageLayout = ImageLayout.Stretch;
      this.bangTaiCan.Bg_Click = ResourceNhua._btcRun___Copy;
      this.bangTaiCan.Bg_NoClick = ResourceNhua._btc;
      this.bangTaiCan.CheDo = ucBangTaiCan.Action.Pause;
      this.bangTaiCan.Location = new Point(1483, 769);
      this.bangTaiCan.Name = "bangTaiCan";
      this.bangTaiCan.Size = new Size(360, 30);
      this.bangTaiCan.TabIndex = 107;
      this.bangTaiCan.ButtonMouseDown += new ucBangTaiCan.ButtonEventHandler(this.bangTaiCan_ButtonMouseDown);
      this.bangTaiCan.ButtonMouseUp += new ucBangTaiCan.ButtonEventHandler(this.bangTaiCan_ButtonMouseUp);
      this.tinHieuXaCanAGG5.BackColor = Color.Transparent;
      this.tinHieuXaCanAGG5.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuXaCanAGG5.BackgroundImage");
      this.tinHieuXaCanAGG5.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuXaCanAGG5.Location = new Point(1819, 714);
      this.tinHieuXaCanAGG5.Name = "tinHieuXaCanAGG5";
      this.tinHieuXaCanAGG5.Size = new Size(24, 24);
      this.tinHieuXaCanAGG5.TabIndex = 105;
      this.tinHieuXaCanAGG5.Visible = false;
      this.tinHieuXaCanAGG4.BackColor = Color.Transparent;
      this.tinHieuXaCanAGG4.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuXaCanAGG4.BackgroundImage");
      this.tinHieuXaCanAGG4.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuXaCanAGG4.Location = new Point(1738, 714);
      this.tinHieuXaCanAGG4.Name = "tinHieuXaCanAGG4";
      this.tinHieuXaCanAGG4.Size = new Size(24, 24);
      this.tinHieuXaCanAGG4.TabIndex = 104;
      this.tinHieuXaCanAGG4.Visible = false;
      this.tinHieuXaCanAGG3.BackColor = Color.Transparent;
      this.tinHieuXaCanAGG3.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuXaCanAGG3.BackgroundImage");
      this.tinHieuXaCanAGG3.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuXaCanAGG3.Location = new Point(1657, 714);
      this.tinHieuXaCanAGG3.Name = "tinHieuXaCanAGG3";
      this.tinHieuXaCanAGG3.Size = new Size(24, 24);
      this.tinHieuXaCanAGG3.TabIndex = 103;
      this.tinHieuXaCanAGG3.Visible = false;
      this.tinHieuXaCanAGG2.BackColor = Color.Transparent;
      this.tinHieuXaCanAGG2.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuXaCanAGG2.BackgroundImage");
      this.tinHieuXaCanAGG2.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuXaCanAGG2.Location = new Point(1576, 714);
      this.tinHieuXaCanAGG2.Name = "tinHieuXaCanAGG2";
      this.tinHieuXaCanAGG2.Size = new Size(24, 24);
      this.tinHieuXaCanAGG2.TabIndex = 102;
      this.tinHieuXaCanAGG2.Visible = false;
      this.tinHieuXaCanAGG1.BackColor = Color.Transparent;
      this.tinHieuXaCanAGG1.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuXaCanAGG1.BackgroundImage");
      this.tinHieuXaCanAGG1.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuXaCanAGG1.Location = new Point(1495, 714);
      this.tinHieuXaCanAGG1.Name = "tinHieuXaCanAGG1";
      this.tinHieuXaCanAGG1.Size = new Size(24, 24);
      this.tinHieuXaCanAGG1.TabIndex = 101;
      this.tinHieuXaCanAGG1.Visible = false;
      this.ucPheuChuaCatDa5.BackColor = Color.Transparent;
      this.ucPheuChuaCatDa5.BackgroundImage = (Image) componentResourceManager.GetObject("ucPheuChuaCatDa5.BackgroundImage");
      this.ucPheuChuaCatDa5.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucPheuChuaCatDa5.Location = new Point(1794, 609);
      this.ucPheuChuaCatDa5.Name = "ucPheuChuaCatDa5";
      this.ucPheuChuaCatDa5.Size = new Size(75, 75);
      this.ucPheuChuaCatDa5.TabIndex = 95;
      this.ucPheuChuaCatDa5.WeighName = "AGG5";
      this.ucPheuChuaCatDa4.BackColor = Color.Transparent;
      this.ucPheuChuaCatDa4.BackgroundImage = (Image) componentResourceManager.GetObject("ucPheuChuaCatDa4.BackgroundImage");
      this.ucPheuChuaCatDa4.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucPheuChuaCatDa4.Location = new Point(1713, 609);
      this.ucPheuChuaCatDa4.Name = "ucPheuChuaCatDa4";
      this.ucPheuChuaCatDa4.Size = new Size(75, 75);
      this.ucPheuChuaCatDa4.TabIndex = 94;
      this.ucPheuChuaCatDa4.WeighName = "AGG4";
      this.ucPheuChuaCatDa3.BackColor = Color.Transparent;
      this.ucPheuChuaCatDa3.BackgroundImage = (Image) componentResourceManager.GetObject("ucPheuChuaCatDa3.BackgroundImage");
      this.ucPheuChuaCatDa3.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucPheuChuaCatDa3.Location = new Point(1632, 609);
      this.ucPheuChuaCatDa3.Name = "ucPheuChuaCatDa3";
      this.ucPheuChuaCatDa3.Size = new Size(75, 75);
      this.ucPheuChuaCatDa3.TabIndex = 93;
      this.ucPheuChuaCatDa3.WeighName = "AGG3";
      this.ucPheuChuaCatDa2.BackColor = Color.Transparent;
      this.ucPheuChuaCatDa2.BackgroundImage = (Image) componentResourceManager.GetObject("ucPheuChuaCatDa2.BackgroundImage");
      this.ucPheuChuaCatDa2.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucPheuChuaCatDa2.Location = new Point(1551, 609);
      this.ucPheuChuaCatDa2.Name = "ucPheuChuaCatDa2";
      this.ucPheuChuaCatDa2.Size = new Size(75, 75);
      this.ucPheuChuaCatDa2.TabIndex = 92;
      this.ucPheuChuaCatDa2.WeighName = "AGG2";
      this.ucPheuChuaCatDa1.BackColor = Color.Transparent;
      this.ucPheuChuaCatDa1.BackgroundImage = (Image) componentResourceManager.GetObject("ucPheuChuaCatDa1.BackgroundImage");
      this.ucPheuChuaCatDa1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucPheuChuaCatDa1.Location = new Point(1470, 609);
      this.ucPheuChuaCatDa1.Name = "ucPheuChuaCatDa1";
      this.ucPheuChuaCatDa1.Size = new Size(75, 75);
      this.ucPheuChuaCatDa1.TabIndex = 91;
      this.ucPheuChuaCatDa1.WeighName = "AGG1";
      this.motorPheuChua02.BackColor = Color.Transparent;
      this.motorPheuChua02.BackgroundImage = (Image) ResourceNhua._motor_fat;
      this.motorPheuChua02.BackgroundImageLayout = ImageLayout.Stretch;
      this.motorPheuChua02.Bg_Click = ResourceNhua._motor_fatRun;
      this.motorPheuChua02.Bg_NoClick = ResourceNhua._motor_fat;
      this.motorPheuChua02.IsOn = true;
      this.motorPheuChua02.IsTrangThai = ucMotorFat.TrangThai.Stop;
      this.motorPheuChua02.Location = new Point(1406, 259);
      this.motorPheuChua02.Name = "motorPheuChua02";
      this.motorPheuChua02.Size = new Size(88, 47);
      this.motorPheuChua02.TabIndex = 88;
      this.motorPheuChua02.ButtonMouseDown += new ucMotorFat.DelButtonEventHandler(this.motorPheuChua02_ButtonMouseDown);
      this.motorPheuChua02.ButtonMouseUp += new ucMotorFat.DelButtonEventHandler(this.motorPheuChua02_ButtonMouseUp);
      this.ucPheuChua031.BackColor = Color.Transparent;
      this.ucPheuChua031.BackgroundImage = (Image) componentResourceManager.GetObject("ucPheuChua031.BackgroundImage");
      this.ucPheuChua031.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucPheuChua031.Location = new Point(1485, 337);
      this.ucPheuChua031.Name = "ucPheuChua031";
      this.ucPheuChua031.Size = new Size(92, 157);
      this.ucPheuChua031.TabIndex = 85;
      this.ucPheuChua021.BackColor = Color.Transparent;
      this.ucPheuChua021.BackgroundImage = (Image) componentResourceManager.GetObject("ucPheuChua021.BackgroundImage");
      this.ucPheuChua021.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucPheuChua021.Location = new Point(1491, 142);
      this.ucPheuChua021.Name = "ucPheuChua021";
      this.ucPheuChua021.Size = new Size(150, 175);
      this.ucPheuChua021.TabIndex = 83;
      this.ucMotorExtra1.BackColor = Color.Transparent;
      this.ucMotorExtra1.BackgroundImage = (Image) ResourceNhua._motor_extra;
      this.ucMotorExtra1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucMotorExtra1.Bg_Click = ResourceNhua._motor_extraRun;
      this.ucMotorExtra1.Bg_NoClick = ResourceNhua._motor_extra;
      this.ucMotorExtra1.IsOn = true;
      this.ucMotorExtra1.IsTrangThai = ucMotorExtra.TrangThai.Stop;
      this.ucMotorExtra1.Location = new Point(1200, 428);
      this.ucMotorExtra1.Name = "ucMotorExtra1";
      this.ucMotorExtra1.Size = new Size(120, 102);
      this.ucMotorExtra1.TabIndex = 82;
      this.ucMotorExtra1.ButtonMouseDown += new ucMotorExtra.DelButtonEventHandler(this.ucMotorExtra1_ButtonMouseDown);
      this.ucMotorExtra1.ButtonMouseUp += new ucMotorExtra.DelButtonEventHandler(this.ucMotorExtra1_ButtonMouseUp);
      this.motorBomDau.BackColor = Color.Transparent;
      this.motorBomDau.BackgroundImage = (Image) ResourceNhua._motor_fat;
      this.motorBomDau.BackgroundImageLayout = ImageLayout.Stretch;
      this.motorBomDau.Bg_Click = ResourceNhua._motor_fatRun;
      this.motorBomDau.Bg_NoClick = ResourceNhua._motor_fat;
      this.motorBomDau.IsOn = true;
      this.motorBomDau.IsTrangThai = ucMotorFat.TrangThai.Stop;
      this.motorBomDau.Location = new Point(944, 769);
      this.motorBomDau.Name = "motorBomDau";
      this.motorBomDau.Size = new Size(88, 47);
      this.motorBomDau.TabIndex = 81;
      this.motorBomDau.ButtonMouseDown += new ucMotorFat.DelButtonEventHandler(this.motorBomDau_ButtonMouseDown);
      this.motorBomDau.ButtonMouseUp += new ucMotorFat.DelButtonEventHandler(this.motorBomDau_ButtonMouseUp);
      this.tinHieuTanSayLua.BackColor = Color.Transparent;
      this.tinHieuTanSayLua.BackgroundImage = (Image) ResourceNhua._tinhieutansayluaRun;
      this.tinHieuTanSayLua.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuTanSayLua.Bg_Click = ResourceNhua._tinhieutansayluaRun;
      this.tinHieuTanSayLua.Bg_NoClick = ResourceNhua._tinhieutansaylua;
      this.tinHieuTanSayLua.IsOn = false;
      this.tinHieuTanSayLua.IsTrangThai = ucTinHieunTanSayLua.TrangThai.Run;
      this.tinHieuTanSayLua.Location = new Point(1004, 659);
      this.tinHieuTanSayLua.Name = "tinHieuTanSayLua";
      this.tinHieuTanSayLua.Size = new Size(72, 56);
      this.tinHieuTanSayLua.TabIndex = 79;
      this.motorGauTaiFD.BackColor = Color.Transparent;
      this.motorGauTaiFD.BackgroundImage = (Image) ResourceNhua._motor_mini;
      this.motorGauTaiFD.BackgroundImageLayout = ImageLayout.Stretch;
      this.motorGauTaiFD.Bg_Click = ResourceNhua._motor_miniRun;
      this.motorGauTaiFD.Bg_NoClick = ResourceNhua._motor_mini;
      this.motorGauTaiFD.IsOn = true;
      this.motorGauTaiFD.IsTrangThai = ucMotorMini.TrangThai.Stop;
      this.motorGauTaiFD.Location = new Point(150, 129);
      this.motorGauTaiFD.Name = "motorGauTaiFD";
      this.motorGauTaiFD.Size = new Size(60, 36);
      this.motorGauTaiFD.TabIndex = 77;
      this.motorGauTaiFD.ButtonMouseDown += new ucMotorMini.DelButtonEventHandler(this.motorGauTaiFD_ButtonMouseDown);
      this.motorGauTaiFD.ButtonMouseUp += new ucMotorMini.DelButtonEventHandler(this.motorGauTaiFD_ButtonMouseUp);
      this.sanRung.BackColor = Color.Transparent;
      this.sanRung.BackgroundImage = (Image) componentResourceManager.GetObject("sanRung.BackgroundImage");
      this.sanRung.BackgroundImageLayout = ImageLayout.Stretch;
      this.sanRung.Location = new Point(365, 9);
      this.sanRung.Name = "sanRung";
      this.sanRung.Size = new Size(577, 184);
      this.sanRung.TabIndex = 75;
      this.ucBonChuaKhi1.BackColor = Color.Transparent;
      this.ucBonChuaKhi1.BackgroundImage = (Image) componentResourceManager.GetObject("ucBonChuaKhi1.BackgroundImage");
      this.ucBonChuaKhi1.Location = new Point(1077, 745);
      this.ucBonChuaKhi1.Name = "ucBonChuaKhi1";
      this.ucBonChuaKhi1.Size = new Size(202, 91);
      this.ucBonChuaKhi1.TabIndex = 71;
      this.btnCheDoCuaNoi.BackColor = Color.Transparent;
      this.btnCheDoCuaNoi.BackgroundImage = (Image) ResourceNhua._btnMAN;
      this.btnCheDoCuaNoi.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnCheDoCuaNoi.Bg_Click = ResourceNhua._btnAUTO;
      this.btnCheDoCuaNoi.Bg_NoClick = ResourceNhua._btnMAN;
      this.btnCheDoCuaNoi.IsOn = true;
      this.btnCheDoCuaNoi.IsTrangThai = ucBtnCheDo.TrangThai.Stop;
      this.btnCheDoCuaNoi.Location = new Point(763, 816);
      this.btnCheDoCuaNoi.Name = "btnCheDoCuaNoi";
      this.btnCheDoCuaNoi.Size = new Size(100, 40);
      this.btnCheDoCuaNoi.TabIndex = 67;
      this.btnCheDoCuaNoi.ButtonClick += new ucBtnCheDo.DelButtonEventHandler(this.btnCheDoCuaNoi_ButtonClick);
      this.btnCheDoNapLieu.BackColor = Color.Transparent;
      this.btnCheDoNapLieu.BackgroundImage = (Image) ResourceNhua._btnMAN;
      this.btnCheDoNapLieu.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnCheDoNapLieu.Bg_Click = ResourceNhua._btnAUTO;
      this.btnCheDoNapLieu.Bg_NoClick = ResourceNhua._btnMAN;
      this.btnCheDoNapLieu.IsOn = true;
      this.btnCheDoNapLieu.IsTrangThai = ucBtnCheDo.TrangThai.Stop;
      this.btnCheDoNapLieu.Location = new Point(657, 816);
      this.btnCheDoNapLieu.Name = "btnCheDoNapLieu";
      this.btnCheDoNapLieu.Size = new Size(100, 40);
      this.btnCheDoNapLieu.TabIndex = 66;
      this.btnCheDoNapLieu.ButtonClick += new ucBtnCheDo.DelButtonEventHandler(this.btnCheDoNapLieu_ButtonClick);
      this.btnCheDoHeThong.BackColor = Color.Transparent;
      this.btnCheDoHeThong.BackgroundImage = (Image) ResourceNhua._btnMAN;
      this.btnCheDoHeThong.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnCheDoHeThong.Bg_Click = ResourceNhua._btnAUTO;
      this.btnCheDoHeThong.Bg_NoClick = ResourceNhua._btnMAN;
      this.btnCheDoHeThong.IsOn = true;
      this.btnCheDoHeThong.IsTrangThai = ucBtnCheDo.TrangThai.Stop;
      this.btnCheDoHeThong.Location = new Point(445, 816);
      this.btnCheDoHeThong.Name = "btnCheDoHeThong";
      this.btnCheDoHeThong.Size = new Size(100, 40);
      this.btnCheDoHeThong.TabIndex = 65;
      this.btnCheDoHeThong.ButtonClick += new ucBtnCheDo.DelButtonEventHandler(this.btnCheDoHeThong_ButtonClick);
      this.btnSIM.BackColor = Color.Transparent;
      this.btnSIM.BackgroundImage = (Image) ResourceNhua._btnSIM;
      this.btnSIM.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnSIM.Bg_Click = ResourceNhua._btnSIMRun;
      this.btnSIM.Bg_NoClick = ResourceNhua._btnSIM;
      this.btnSIM.IsOn = true;
      this.btnSIM.IsTrangThai = ucBtnSIM.TrangThai.Stop;
      this.btnSIM.Location = new Point(339, 816);
      this.btnSIM.Name = "btnSIM";
      this.btnSIM.Size = new Size(100, 40);
      this.btnSIM.TabIndex = 64;
      this.btnSIM.ButtonClick += new ucBtnSIM.DelButtonEventHandler(this.btnSIM_ButtonClick);
      this.btnHuy.BackgroundImage = (Image) componentResourceManager.GetObject("btnHuy.BackgroundImage");
      this.btnHuy.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnHuy.Bg_Click = ResourceNhua._btnHuyRun;
      this.btnHuy.Bg_NoClick = ResourceNhua._btnHuy;
      this.btnHuy.IsOn = false;
      this.btnHuy.Location = new Point(233, 816);
      this.btnHuy.Name = "btnHuy";
      this.btnHuy.Size = new Size(100, 40);
      this.btnHuy.TabIndex = 63;
      this.btnHuy.ButtonClick += new ucBtnHuy.DelButtonEventHandler(this.btnHuy_ButtonClick);
      this.btnDung.BackColor = Color.Transparent;
      this.btnDung.BackgroundImage = (Image) ResourceNhua._btnDung;
      this.btnDung.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnDung.Bg_Click = ResourceNhua._btnTiepTuc;
      this.btnDung.Bg_NoClick = ResourceNhua._btnDung;
      this.btnDung.IsOn = true;
      this.btnDung.IsTrangThai = ucBtnDung.TrangThai.Stop;
      this.btnDung.Location = new Point((int) sbyte.MaxValue, 816);
      this.btnDung.Name = "btnDung";
      this.btnDung.Size = new Size(100, 40);
      this.btnDung.TabIndex = 62;
      this.btnDung.ButtonClick += new ucBtnDung.DelButtonEventHandler(this.btnDung_ButtonClick);
      this.btnBatDau.BackgroundImage = (Image) componentResourceManager.GetObject("btnBatDau.BackgroundImage");
      this.btnBatDau.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnBatDau.Bg_Click = ResourceNhua._btnBatDau_Run;
      this.btnBatDau.Bg_NoClick = ResourceNhua._btnBatDau;
      this.btnBatDau.IsOn = false;
      this.btnBatDau.Location = new Point(21, 816);
      this.btnBatDau.Name = "btnBatDau";
      this.btnBatDau.Size = new Size(100, 40);
      this.btnBatDau.TabIndex = 61;
      this.btnBatDau.ButtonClick += new ucBtnBatDau.DelButtonEventHandler(this.btnBatDau_ButtonClick);
      this.btnDongCuaNoi.BackgroundImage = (Image) componentResourceManager.GetObject("btnDongCuaNoi.BackgroundImage");
      this.btnDongCuaNoi.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnDongCuaNoi.Bg_Click = ResourceNhua._btnDongRun;
      this.btnDongCuaNoi.Bg_NoClick = ResourceNhua._btnDong;
      this.btnDongCuaNoi.IsOn = false;
      this.btnDongCuaNoi.Location = new Point(737, 736);
      this.btnDongCuaNoi.Name = "btnDongCuaNoi";
      this.btnDongCuaNoi.Size = new Size(100, 40);
      this.btnDongCuaNoi.TabIndex = 60;
      this.btnDongCuaNoi.ButtonMouseDown += new ucBtnDong.ButtonEventHandler(this.btnDongCuaNoi_ButtonMouseDown);
      this.btnDongCuaNoi.ButtonMouseUp += new ucBtnDong.ButtonEventHandler(this.btnDongCuaNoi_ButtonMouseUp);
      this.btnMoCuaNoi.BackgroundImage = (Image) componentResourceManager.GetObject("btnMoCuaNoi.BackgroundImage");
      this.btnMoCuaNoi.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnMoCuaNoi.Bg_Click = ResourceNhua._btnMoRun;
      this.btnMoCuaNoi.Bg_NoClick = ResourceNhua._btnMo;
      this.btnMoCuaNoi.IsOn = false;
      this.btnMoCuaNoi.Location = new Point(454, 736);
      this.btnMoCuaNoi.Name = "btnMoCuaNoi";
      this.btnMoCuaNoi.Size = new Size(100, 40);
      this.btnMoCuaNoi.TabIndex = 59;
      this.btnMoCuaNoi.ButtonMouseDown += new ucBtnMo.ButtonEventHandler(this.btnMoCuaNoi_ButtonMouseDown);
      this.btnMoCuaNoi.ButtonMouseUp += new ucBtnMo.ButtonEventHandler(this.btnMoCuaNoi_ButtonMouseUp);
      this.tinHieuCanSiloSBS.BackColor = Color.Transparent;
      this.tinHieuCanSiloSBS.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCanSiloSBS.BackgroundImage");
      this.tinHieuCanSiloSBS.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCanSiloSBS.Location = new Point(1010, 397);
      this.tinHieuCanSiloSBS.Name = "tinHieuCanSiloSBS";
      this.tinHieuCanSiloSBS.Size = new Size(24, 24);
      this.tinHieuCanSiloSBS.TabIndex = 36;
      this.tinHieuCanSiloSBS.Visible = false;
      this.tinHieuCanSiloAP.BackColor = Color.Transparent;
      this.tinHieuCanSiloAP.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCanSiloAP.BackgroundImage");
      this.tinHieuCanSiloAP.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCanSiloAP.Location = new Point(896, 397);
      this.tinHieuCanSiloAP.Name = "tinHieuCanSiloAP";
      this.tinHieuCanSiloAP.Size = new Size(24, 24);
      this.tinHieuCanSiloAP.TabIndex = 33;
      this.tinHieuCanSiloAP.Visible = false;
      this.tinHieuCanSiloAGG5.BackColor = Color.Transparent;
      this.tinHieuCanSiloAGG5.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCanSiloAGG5.BackgroundImage");
      this.tinHieuCanSiloAGG5.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCanSiloAGG5.Location = new Point(781, 397);
      this.tinHieuCanSiloAGG5.Name = "tinHieuCanSiloAGG5";
      this.tinHieuCanSiloAGG5.Size = new Size(24, 24);
      this.tinHieuCanSiloAGG5.TabIndex = 30;
      this.tinHieuCanSiloAGG5.Visible = false;
      this.tinHieuCanSiloAGG4.BackColor = Color.Transparent;
      this.tinHieuCanSiloAGG4.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCanSiloAGG4.BackgroundImage");
      this.tinHieuCanSiloAGG4.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCanSiloAGG4.Location = new Point(694, 397);
      this.tinHieuCanSiloAGG4.Name = "tinHieuCanSiloAGG4";
      this.tinHieuCanSiloAGG4.Size = new Size(24, 24);
      this.tinHieuCanSiloAGG4.TabIndex = 29;
      this.tinHieuCanSiloAGG4.Visible = false;
      this.tinHieuCanSiloAGG3.BackColor = Color.Transparent;
      this.tinHieuCanSiloAGG3.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCanSiloAGG3.BackgroundImage");
      this.tinHieuCanSiloAGG3.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCanSiloAGG3.Location = new Point(609, 397);
      this.tinHieuCanSiloAGG3.Name = "tinHieuCanSiloAGG3";
      this.tinHieuCanSiloAGG3.Size = new Size(24, 24);
      this.tinHieuCanSiloAGG3.TabIndex = 28;
      this.tinHieuCanSiloAGG3.Visible = false;
      this.tinHieuCanSiloAGG2.BackColor = Color.Transparent;
      this.tinHieuCanSiloAGG2.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCanSiloAGG2.BackgroundImage");
      this.tinHieuCanSiloAGG2.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCanSiloAGG2.Location = new Point(522, 397);
      this.tinHieuCanSiloAGG2.Name = "tinHieuCanSiloAGG2";
      this.tinHieuCanSiloAGG2.Size = new Size(24, 24);
      this.tinHieuCanSiloAGG2.TabIndex = 27;
      this.tinHieuCanSiloAGG2.Visible = false;
      this.tinHieuCanSiloAGG1.BackColor = Color.Transparent;
      this.tinHieuCanSiloAGG1.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCanSiloAGG1.BackgroundImage");
      this.tinHieuCanSiloAGG1.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCanSiloAGG1.Location = new Point(437, 397);
      this.tinHieuCanSiloAGG1.Name = "tinHieuCanSiloAGG1";
      this.tinHieuCanSiloAGG1.Size = new Size(24, 24);
      this.tinHieuCanSiloAGG1.TabIndex = 26;
      this.tinHieuCanSiloAGG1.Visible = false;
      this.tinHieuCanSiloFD.BackColor = Color.Transparent;
      this.tinHieuCanSiloFD.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCanSiloFD.BackgroundImage");
      this.tinHieuCanSiloFD.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCanSiloFD.Location = new Point(334, 397);
      this.tinHieuCanSiloFD.Name = "tinHieuCanSiloFD";
      this.tinHieuCanSiloFD.Size = new Size(24, 24);
      this.tinHieuCanSiloFD.TabIndex = 25;
      this.tinHieuCanSiloFD.Visible = false;
      this.btnVanCanAGG5.BackColor = Color.Silver;
      this.btnVanCanAGG5.BackgroundImage = (Image) componentResourceManager.GetObject("btnVanCanAGG5.BackgroundImage");
      this.btnVanCanAGG5.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnVanCanAGG5.Bg_Click = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG5.Bg_Click");
      this.btnVanCanAGG5.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG5.Bg_NoClick");
      this.btnVanCanAGG5.IsOn = false;
      this.btnVanCanAGG5.Location = new Point(784, 371);
      this.btnVanCanAGG5.Name = "btnVanCanAGG5";
      this.btnVanCanAGG5.Size = new Size(16, 16);
      this.btnVanCanAGG5.TabIndex = 24;
      this.btnVanCanAGG5.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG5_ButtonMouseDown);
      this.btnVanCanAGG5.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG5_ButtonMouseUp);
      this.btnVanCanAGG4.BackColor = Color.Silver;
      this.btnVanCanAGG4.BackgroundImage = (Image) componentResourceManager.GetObject("btnVanCanAGG4.BackgroundImage");
      this.btnVanCanAGG4.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnVanCanAGG4.Bg_Click = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG4.Bg_Click");
      this.btnVanCanAGG4.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG4.Bg_NoClick");
      this.btnVanCanAGG4.IsOn = false;
      this.btnVanCanAGG4.Location = new Point(698, 371);
      this.btnVanCanAGG4.Name = "btnVanCanAGG4";
      this.btnVanCanAGG4.Size = new Size(16, 16);
      this.btnVanCanAGG4.TabIndex = 23;
      this.btnVanCanAGG4.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG4_ButtonMouseDown);
      this.btnVanCanAGG4.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG4_ButtonMouseUp);
      this.btnVanCanAGG3.BackColor = Color.Silver;
      this.btnVanCanAGG3.BackgroundImage = (Image) componentResourceManager.GetObject("btnVanCanAGG3.BackgroundImage");
      this.btnVanCanAGG3.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnVanCanAGG3.Bg_Click = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG3.Bg_Click");
      this.btnVanCanAGG3.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG3.Bg_NoClick");
      this.btnVanCanAGG3.IsOn = false;
      this.btnVanCanAGG3.Location = new Point(612, 371);
      this.btnVanCanAGG3.Name = "btnVanCanAGG3";
      this.btnVanCanAGG3.Size = new Size(16, 16);
      this.btnVanCanAGG3.TabIndex = 22;
      this.btnVanCanAGG3.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG3_ButtonMouseDown);
      this.btnVanCanAGG3.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG3_ButtonMouseUp);
      this.btnVanCanAGG2.BackColor = Color.Silver;
      this.btnVanCanAGG2.BackgroundImage = (Image) componentResourceManager.GetObject("btnVanCanAGG2.BackgroundImage");
      this.btnVanCanAGG2.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnVanCanAGG2.Bg_Click = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG2.Bg_Click");
      this.btnVanCanAGG2.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG2.Bg_NoClick");
      this.btnVanCanAGG2.IsOn = false;
      this.btnVanCanAGG2.Location = new Point(526, 371);
      this.btnVanCanAGG2.Name = "btnVanCanAGG2";
      this.btnVanCanAGG2.Size = new Size(16, 16);
      this.btnVanCanAGG2.TabIndex = 21;
      this.btnVanCanAGG2.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG2_ButtonMouseDown);
      this.btnVanCanAGG2.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG2_ButtonMouseUp);
      this.btnVanCanAGG1.BackColor = Color.Silver;
      this.btnVanCanAGG1.BackgroundImage = (Image) componentResourceManager.GetObject("btnVanCanAGG1.BackgroundImage");
      this.btnVanCanAGG1.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnVanCanAGG1.Bg_Click = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG1.Bg_Click");
      this.btnVanCanAGG1.Bg_NoClick = (Bitmap) componentResourceManager.GetObject("btnVanCanAGG1.Bg_NoClick");
      this.btnVanCanAGG1.IsOn = false;
      this.btnVanCanAGG1.Location = new Point(441, 371);
      this.btnVanCanAGG1.Name = "btnVanCanAGG1";
      this.btnVanCanAGG1.Size = new Size(16, 16);
      this.btnVanCanAGG1.TabIndex = 20;
      this.btnVanCanAGG1.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG1_ButtonMouseDown);
      this.btnVanCanAGG1.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnVanCanAGG1_ButtonMouseUp);
      this.btnVanCanFD.BackColor = Color.Silver;
      this.btnVanCanFD.BackgroundImage = (Image) componentResourceManager.GetObject("btnVanCanFD.BackgroundImage");
      this.btnVanCanFD.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnVanCanFD.Bg_Click = ResourceNhua._btnTronRun;
      this.btnVanCanFD.Bg_NoClick = ResourceNhua._btnTron;
      this.btnVanCanFD.IsOn = false;
      this.btnVanCanFD.Location = new Point(338, 371);
      this.btnVanCanFD.Name = "btnVanCanFD";
      this.btnVanCanFD.Size = new Size(16, 16);
      this.btnVanCanFD.TabIndex = 19;
      this.btnVanCanFD.ButtonMouseDown += new ucBtnTron.DelButtonEventHandler(this.btnVanCanFD_ButtonMouseDown);
      this.btnVanCanFD.ButtonMouseUp += new ucBtnTron.DelButtonEventHandler(this.btnVanCanFD_ButtonMouseUp);
      this.ucOngDanFD1.BackColor = Color.Transparent;
      this.ucOngDanFD1.BackgroundImage = (Image) componentResourceManager.GetObject("ucOngDanFD1.BackgroundImage");
      this.ucOngDanFD1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucOngDanFD1.Location = new Point(333, 508);
      this.ucOngDanFD1.Name = "ucOngDanFD1";
      this.ucOngDanFD1.Size = new Size(130, 65);
      this.ucOngDanFD1.TabIndex = 213;
      this.tinHieuXaCanAGG.BackColor = Color.Transparent;
      this.tinHieuXaCanAGG.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuXaCanAGG.BackgroundImage");
      this.tinHieuXaCanAGG.BackgroundImageLayout = ImageLayout.Center;
      this.tinHieuXaCanAGG.Location = new Point(615, 540);
      this.tinHieuXaCanAGG.Name = "tinHieuXaCanAGG";
      this.tinHieuXaCanAGG.Size = new Size(20, 30);
      this.tinHieuXaCanAGG.TabIndex = 55;
      this.tinHieuXaCanAGG.Visible = false;
      this.tinHieuXaCanFD.BackColor = Color.LightSalmon;
      this.tinHieuXaCanFD.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuXaCanFD.BackgroundImage");
      this.tinHieuXaCanFD.BackgroundImageLayout = ImageLayout.Center;
      this.tinHieuXaCanFD.Location = new Point(439, 540);
      this.tinHieuXaCanFD.Name = "tinHieuXaCanFD";
      this.tinHieuXaCanFD.Size = new Size(20, 30);
      this.tinHieuXaCanFD.TabIndex = 217;
      this.tinHieuXaCanFD.Visible = false;
      this.slMeDaCanNoiTron.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.slMeDaCanNoiTron.Location = new Point(539, 621);
      this.slMeDaCanNoiTron.Margin = new Padding(6, 6, 6, 6);
      this.slMeDaCanNoiTron.Name = "slMeDaCanNoiTron";
      this.slMeDaCanNoiTron.Size = new Size(81, 31);
      this.slMeDaCanNoiTron.SoLuongMeCanTron = new Decimal(new int[4]);
      this.slMeDaCanNoiTron.SoLuongMeDaTron = new Decimal(new int[4]);
      this.slMeDaCanNoiTron.TabIndex = 221;
      this.btnNoiTronR.BackColor = Color.White;
      this.btnNoiTronR.BackgroundImage = (Image) ResourceNhua._btnNoiTron;
      this.btnNoiTronR.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnNoiTronR.Bg_Click = ResourceNhua._btnNoiTronRun;
      this.btnNoiTronR.Bg_NoClick = ResourceNhua._btnNoiTron;
      this.btnNoiTronR.IsOn = true;
      this.btnNoiTronR.IsTrangThai = ucBtnNoiTron.TrangThai.Stop;
      this.btnNoiTronR.Location = new Point(784, 648);
      this.btnNoiTronR.Name = "btnNoiTronR";
      this.btnNoiTronR.Size = new Size(32, 32);
      this.btnNoiTronR.TabIndex = 220;
      this.btnNoiTronR.ButtonMouseDown += new ucBtnNoiTron.DelButtonEventHandler(this.btnNoiTronR_ButtonMouseDown);
      this.btnNoiTronR.ButtonMouseUp += new ucBtnNoiTron.DelButtonEventHandler(this.btnNoiTronR_ButtonMouseUp);
      this.btnNoiTronL.BackColor = Color.White;
      this.btnNoiTronL.BackgroundImage = (Image) ResourceNhua._btnNoiTron;
      this.btnNoiTronL.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnNoiTronL.Bg_Click = ResourceNhua._btnNoiTronRun;
      this.btnNoiTronL.Bg_NoClick = ResourceNhua._btnNoiTron;
      this.btnNoiTronL.IsOn = true;
      this.btnNoiTronL.IsTrangThai = ucBtnNoiTron.TrangThai.Stop;
      this.btnNoiTronL.Location = new Point(475, 648);
      this.btnNoiTronL.Name = "btnNoiTronL";
      this.btnNoiTronL.Size = new Size(32, 32);
      this.btnNoiTronL.TabIndex = 219;
      this.btnNoiTronL.ButtonMouseDown += new ucBtnNoiTron.DelButtonEventHandler(this.btnNoiTronL_ButtonMouseDown);
      this.btnNoiTronL.ButtonMouseUp += new ucBtnNoiTron.DelButtonEventHandler(this.btnNoiTronL_ButtonMouseUp);
      this.ucNoiTron1.BackColor = Color.Transparent;
      this.ucNoiTron1.BackgroundImage = (Image) componentResourceManager.GetObject("ucNoiTron1.BackgroundImage");
      this.ucNoiTron1.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucNoiTron1.KL_TRON = new Decimal(new int[4]);
      this.ucNoiTron1.Location = new Point(410, 572);
      this.ucNoiTron1.Name = "ucNoiTron1";
      this.ucNoiTron1.Size = new Size(470, 160);
      this.ucNoiTron1.TabIndex = 218;
      this.ucNoiTron1.TG_THỰC_XA = new Decimal(new int[4]);
      this.ucNoiTron1.TG_TRON = new Decimal(new int[4]);
      this.grcMeTronCur.Location = new Point(21, 861);
      this.grcMeTronCur.MainView = (BaseView) this.grvMeTronCur;
      this.grcMeTronCur.Name = "grcMeTronCur";
      this.grcMeTronCur.Size = new Size(1858, 50);
      this.grcMeTronCur.TabIndex = 224;
      this.grcMeTronCur.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvMeTronCur
      });
      this.grvMeTronCur.Columns.AddRange(new GridColumn[8]
      {
        this.gcMaPhieuTron,
        this.gcSTTMeTron,
        this.ggcNgayTron,
        this.gcGioTron,
        this.gcKhachHang,
        this.gcCongTruong,
        this.gcTenMAC,
        this.gcKhoiLuong
      });
      this.grvMeTronCur.GridControl = this.grcMeTronCur;
      this.grvMeTronCur.Name = "grvMeTronCur";
      this.grvMeTronCur.OptionsFilter.ShowInHeaderSearchResults = ShowInHeaderSearchResultsMode.None;
      this.grvMeTronCur.OptionsFind.AllowFindPanel = false;
      this.grvMeTronCur.OptionsFind.ShowFindButton = false;
      this.grvMeTronCur.OptionsFind.ShowSearchNavButtons = false;
      this.grvMeTronCur.OptionsView.ShowGroupPanel = false;
      this.gcMaPhieuTron.Caption = "Mã phiếu trộn";
      this.gcMaPhieuTron.FieldName = "MaPhieuTron";
      this.gcMaPhieuTron.Name = "gcMaPhieuTron";
      this.gcMaPhieuTron.OptionsColumn.AllowFocus = false;
      this.gcMaPhieuTron.OptionsColumn.ReadOnly = true;
      this.gcMaPhieuTron.Visible = true;
      this.gcMaPhieuTron.VisibleIndex = 0;
      this.gcSTTMeTron.Caption = "STT Mẻ";
      this.gcSTTMeTron.FieldName = "LnNo";
      this.gcSTTMeTron.Name = "gcSTTMeTron";
      this.gcSTTMeTron.OptionsColumn.AllowFocus = false;
      this.gcSTTMeTron.OptionsColumn.ReadOnly = true;
      this.gcSTTMeTron.Visible = true;
      this.gcSTTMeTron.VisibleIndex = 1;
      this.ggcNgayTron.Caption = "Ngày trộn";
      this.ggcNgayTron.FieldName = "NgayMeTron";
      this.ggcNgayTron.Name = "ggcNgayTron";
      this.ggcNgayTron.OptionsColumn.AllowFocus = false;
      this.ggcNgayTron.OptionsColumn.ReadOnly = true;
      this.ggcNgayTron.Visible = true;
      this.ggcNgayTron.VisibleIndex = 2;
      this.gcGioTron.Caption = "Giờ trộn";
      this.gcGioTron.FieldName = "Gio";
      this.gcGioTron.Name = "gcGioTron";
      this.gcGioTron.OptionsColumn.AllowFocus = false;
      this.gcGioTron.OptionsColumn.ReadOnly = true;
      this.gcGioTron.Visible = true;
      this.gcGioTron.VisibleIndex = 3;
      this.gcKhachHang.Caption = "Khách hàng";
      this.gcKhachHang.FieldName = "KH";
      this.gcKhachHang.Name = "gcKhachHang";
      this.gcKhachHang.OptionsColumn.AllowFocus = false;
      this.gcKhachHang.OptionsColumn.ReadOnly = true;
      this.gcKhachHang.Visible = true;
      this.gcKhachHang.VisibleIndex = 4;
      this.gcCongTruong.Caption = "Công trường";
      this.gcCongTruong.FieldName = "CT";
      this.gcCongTruong.Name = "gcCongTruong";
      this.gcCongTruong.OptionsColumn.AllowFocus = false;
      this.gcCongTruong.OptionsColumn.ReadOnly = true;
      this.gcCongTruong.Visible = true;
      this.gcCongTruong.VisibleIndex = 5;
      this.gcTenMAC.Caption = "Tên MAC";
      this.gcTenMAC.FieldName = "MAC";
      this.gcTenMAC.Name = "gcTenMAC";
      this.gcTenMAC.OptionsColumn.AllowFocus = false;
      this.gcTenMAC.OptionsColumn.ReadOnly = true;
      this.gcTenMAC.Visible = true;
      this.gcTenMAC.VisibleIndex = 6;
      this.gcKhoiLuong.Caption = "Khối lượng";
      this.gcKhoiLuong.FieldName = "KLMe";
      this.gcKhoiLuong.Name = "gcKhoiLuong";
      this.gcKhoiLuong.OptionsColumn.AllowFocus = false;
      this.gcKhoiLuong.OptionsColumn.ReadOnly = true;
      this.gcKhoiLuong.Visible = true;
      this.gcKhoiLuong.VisibleIndex = 7;
      this.motorBomTuoiNhua.BackColor = Color.Transparent;
      this.motorBomTuoiNhua.BackgroundImage = (Image) ResourceNhua._motor_mini;
      this.motorBomTuoiNhua.BackgroundImageLayout = ImageLayout.Stretch;
      this.motorBomTuoiNhua.Bg_Click = ResourceNhua._motor_miniRun;
      this.motorBomTuoiNhua.Bg_NoClick = ResourceNhua._motor_mini;
      this.motorBomTuoiNhua.IsOn = true;
      this.motorBomTuoiNhua.IsTrangThai = ucMotorMini.TrangThai.Stop;
      this.motorBomTuoiNhua.Location = new Point(687, 528);
      this.motorBomTuoiNhua.Name = "motorBomTuoiNhua";
      this.motorBomTuoiNhua.Size = new Size(43, 30);
      this.motorBomTuoiNhua.TabIndex = 225;
      this.motorBomTuoiNhua.ButtonMouseDown += new ucMotorMini.DelButtonEventHandler(this.motorBomTuoiNhua_ButtonMouseDown);
      this.motorBomTuoiNhua.ButtonMouseUp += new ucMotorMini.DelButtonEventHandler(this.motorBomTuoiNhua_ButtonMouseUp);
      this.ucOngDanSB2.BackColor = Color.Transparent;
      this.ucOngDanSB2.BackgroundImage = (Image) componentResourceManager.GetObject("ucOngDanSB2.BackgroundImage");
      this.ucOngDanSB2.BackgroundImageLayout = ImageLayout.Stretch;
      this.ucOngDanSB2.Location = new Point(721, 508);
      this.ucOngDanSB2.Name = "ucOngDanSB2";
      this.ucOngDanSB2.Size = new Size(315, 65);
      this.ucOngDanSB2.TabIndex = 226;
      this.btnXaHetAGG.BackColor = Color.Transparent;
      this.btnXaHetAGG.BackgroundImage = (Image) ResourceNhua._btnVeSinhPheuAGG;
      this.btnXaHetAGG.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnXaHetAGG.Bg_Click = ResourceNhua._btnVeSinhPheuAGGRUN;
      this.btnXaHetAGG.Bg_NoClick = ResourceNhua._btnVeSinhPheuAGG;
      this.btnXaHetAGG.IsOn = true;
      this.btnXaHetAGG.IsTrangThai = ucBtnXAHETAGG.TrangThai.Stop;
      this.btnXaHetAGG.Location = new Point(869, 808);
      this.btnXaHetAGG.Name = "btnXaHetAGG";
      this.btnXaHetAGG.Size = new Size(85, 47);
      this.btnXaHetAGG.TabIndex = 229;
      this.btnXaHetAGG.ButtonMouseDown += new ucBtnXAHETAGG.DelButtonEventHandler(this.btnXaHetAGG_ButtonMouseDown);
      this.btnXaHetAGG.ButtonMouseUp += new ucBtnXAHETAGG.DelButtonEventHandler(this.btnXaHetAGG_ButtonMouseUp);
      this.btnXaHetAGG.ButtonClick += new ucBtnXAHETAGG.DelButtonEventHandler(this.btnXaHetAGG_ButtonClick);
      this.tinHieuBomTuoiNhua.BackColor = SystemColors.ActiveCaption;
      this.tinHieuBomTuoiNhua.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuBomTuoiNhua.BackgroundImage");
      this.tinHieuBomTuoiNhua.BackgroundImageLayout = ImageLayout.Center;
      this.tinHieuBomTuoiNhua.Location = new Point(725, 540);
      this.tinHieuBomTuoiNhua.Name = "tinHieuBomTuoiNhua";
      this.tinHieuBomTuoiNhua.Size = new Size(20, 30);
      this.tinHieuBomTuoiNhua.TabIndex = 230;
      this.tinHieuBomTuoiNhua.Visible = false;
      this.tinHieuXaCanSBS.BackColor = Color.LightCoral;
      this.tinHieuXaCanSBS.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuXaCanSBS.BackgroundImage");
      this.tinHieuXaCanSBS.BackgroundImageLayout = ImageLayout.Center;
      this.tinHieuXaCanSBS.Location = new Point(835, 540);
      this.tinHieuXaCanSBS.Name = "tinHieuXaCanSBS";
      this.tinHieuXaCanSBS.Size = new Size(20, 30);
      this.tinHieuXaCanSBS.TabIndex = 231;
      this.tinHieuXaCanSBS.Visible = false;
      this.tinHieuCuaNoiMo.BackColor = Color.Transparent;
      this.tinHieuCuaNoiMo.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCuaNoiMo.BackgroundImage");
      this.tinHieuCuaNoiMo.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCuaNoiMo.Location = new Point(506, 714);
      this.tinHieuCuaNoiMo.Name = "tinHieuCuaNoiMo";
      this.tinHieuCuaNoiMo.Size = new Size(30, 15);
      this.tinHieuCuaNoiMo.TabIndex = 232;
      this.tinHieuCuaNoiMo.Visible = false;
      this.tinHieuCuaNoiDong.BackColor = Color.Transparent;
      this.tinHieuCuaNoiDong.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuCuaNoiDong.BackgroundImage");
      this.tinHieuCuaNoiDong.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuCuaNoiDong.Location = new Point(751, 714);
      this.tinHieuCuaNoiDong.Name = "tinHieuCuaNoiDong";
      this.tinHieuCuaNoiDong.Size = new Size(30, 15);
      this.tinHieuCuaNoiDong.TabIndex = 233;
      this.tinHieuCuaNoiDong.Visible = false;
      this.tinHieuXaCanAP.BackColor = SystemColors.ActiveCaption;
      this.tinHieuXaCanAP.BackgroundImage = (Image) componentResourceManager.GetObject("tinHieuXaCanAP.BackgroundImage");
      this.tinHieuXaCanAP.BackgroundImageLayout = ImageLayout.Stretch;
      this.tinHieuXaCanAP.Location = new Point(896, 511);
      this.tinHieuXaCanAP.Name = "tinHieuXaCanAP";
      this.tinHieuXaCanAP.Size = new Size(20, 20);
      this.tinHieuXaCanAP.TabIndex = 234;
      this.tinHieuXaCanAP.Visible = false;
      this.btnDauDot.BackColor = Color.Transparent;
      this.btnDauDot.BackgroundImage = (Image) ResourceNhua._tinhieutansayquay;
      this.btnDauDot.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnDauDot.Bg_Click = ResourceNhua._tinhieutansayquayRun;
      this.btnDauDot.Bg_NoClick = ResourceNhua._tinhieutansayquay;
      this.btnDauDot.IsOn = true;
      this.btnDauDot.IsTrangThai = ucTinHieuTanSayQuay.TrangThai.Stop;
      this.btnDauDot.Location = new Point(956, 656);
      this.btnDauDot.Name = "btnDauDot";
      this.btnDauDot.Size = new Size(48, 48);
      this.btnDauDot.TabIndex = 235;
      this.btnDauDot.ButtonMouseDown += new ucTinHieuTanSayQuay.ButtonEventHandler(this.btnDauDot_ButtonMouseDown);
      this.btnDauDot.ButtonMouseUp += new ucTinHieuTanSayQuay.ButtonEventHandler(this.btnDauDot_ButtonMouseUp);
      this.tinHieuCuaMo.BackColor = Color.Transparent;
      this.tinHieuCuaMo.BackgroundImage = (Image) ResourceNhua._tinHieuCuaMo;
      this.tinHieuCuaMo.BackgroundImageLayout = ImageLayout.Center;
      this.tinHieuCuaMo.Location = new Point(605, 745);
      this.tinHieuCuaMo.Name = "tinHieuCuaMo";
      this.tinHieuCuaMo.Size = new Size(35, 25);
      this.tinHieuCuaMo.TabIndex = 236;
      this.tinHieuCuaMo.Visible = false;
      this.tinHieuCuaDong.BackColor = Color.Transparent;
      this.tinHieuCuaDong.BackgroundImage = (Image) ResourceNhua._tinHieuCuaDong;
      this.tinHieuCuaDong.BackgroundImageLayout = ImageLayout.Center;
      this.tinHieuCuaDong.Location = new Point(646, 745);
      this.tinHieuCuaDong.Name = "tinHieuCuaDong";
      this.tinHieuCuaDong.Size = new Size(35, 25);
      this.tinHieuCuaDong.TabIndex = 237;
      this.tinHieuCuaDong.Visible = false;
      this.btnPheuSBS.BackColor = Color.DarkGray;
      this.btnPheuSBS.BackgroundImageLayout = ImageLayout.Stretch;
      this.btnPheuSBS.BGColor = ucBtnXaCan.BGColorEnum.Gray;
      this.btnPheuSBS.IsOn = true;
      this.btnPheuSBS.IsRun = false;
      this.btnPheuSBS.IsTrangThai = ucBtnXaCan.TrangThai.Stop;
      this.btnPheuSBS.Location = new Point(1302, 256);
      this.btnPheuSBS.Name = "btnPheuSBS";
      this.btnPheuSBS.Size = new Size(36, 41);
      this.btnPheuSBS.TabIndex = 238;
      this.btnPheuSBS.ButtonClick += new ucBtnXaCan.DelButtonEventHandler(this.btnPheuSBS_ButtonClick);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Gainsboro;
      this.Controls.Add((Control) this.btnPheuSBS);
      this.Controls.Add((Control) this.tinHieuCuaDong);
      this.Controls.Add((Control) this.tinHieuCuaMo);
      this.Controls.Add((Control) this.btnDauDot);
      this.Controls.Add((Control) this.tinHieuXaCanAP);
      this.Controls.Add((Control) this.tinHieuCuaNoiDong);
      this.Controls.Add((Control) this.tinHieuCuaNoiMo);
      this.Controls.Add((Control) this.tinHieuXaCanSBS);
      this.Controls.Add((Control) this.tinHieuBomTuoiNhua);
      this.Controls.Add((Control) this.btnXaHetAGG);
      this.Controls.Add((Control) this.ucOngDanSB2);
      this.Controls.Add((Control) this.motorBomTuoiNhua);
      this.Controls.Add((Control) this.grcMeTronCur);
      this.Controls.Add((Control) this.slMeDaCanNoiTron);
      this.Controls.Add((Control) this.btnNoiTronR);
      this.Controls.Add((Control) this.btnNoiTronL);
      this.Controls.Add((Control) this.ucNoiTron1);
      this.Controls.Add((Control) this.tinHieuXaCanFD);
      this.Controls.Add((Control) this.ucOngDanFD1);
      this.Controls.Add((Control) this.VAA);
      this.Controls.Add((Control) this.groupControl1);
      this.Controls.Add((Control) this.label13);
      this.Controls.Add((Control) this.btnCheDoXaCan);
      this.Controls.Add((Control) this.btnTanSay);
      this.Controls.Add((Control) this.ucBtnVitTai1);
      this.Controls.Add((Control) this.btnSanRung);
      this.Controls.Add((Control) this.tinHieuMoCuaNoi);
      this.Controls.Add((Control) this.tinHieuDongCuaNoi);
      this.Controls.Add((Control) this.tinHieuSanRung);
      this.Controls.Add((Control) this.checkDaat);
      this.Controls.Add((Control) this.lblMAC);
      this.Controls.Add((Control) this.ucBangGauTauCatDaNhanh1);
      this.Controls.Add((Control) this.ucBangGauTaiCatDa1);
      this.Controls.Add((Control) this.motorGauTaiAGG1);
      this.Controls.Add((Control) this.btnRungCL3);
      this.Controls.Add((Control) this.btnRungCL2);
      this.Controls.Add((Control) this.btnRungCL1);
      this.Controls.Add((Control) this.ucBeTiep1);
      this.Controls.Add((Control) this.ucBangGauTaiXiMang2);
      this.Controls.Add((Control) this.btnFU_SBS);
      this.Controls.Add((Control) this.btnFU_AP);
      this.Controls.Add((Control) this.btnFU_AGG5);
      this.Controls.Add((Control) this.btnFU_AGG4);
      this.Controls.Add((Control) this.btnFU_AGG3);
      this.Controls.Add((Control) this.btnFU_AGG2);
      this.Controls.Add((Control) this.btnFU_AG1);
      this.Controls.Add((Control) this.btnFU_FD);
      this.Controls.Add((Control) this.barFullSiloFD);
      this.Controls.Add((Control) this.ucBangGauTaiXiMangNhanh1);
      this.Controls.Add((Control) this.slMeDaCanSBS);
      this.Controls.Add((Control) this.slMeDaCanAP);
      this.Controls.Add((Control) this.slMeDaCanAGG);
      this.Controls.Add((Control) this.slMeDaCanFD);
      this.Controls.Add((Control) this.tinHieuBaoMucThapFD);
      this.Controls.Add((Control) this.tinHieuBaoMucCaoFD);
      this.Controls.Add((Control) this.label10);
      this.Controls.Add((Control) this.textEdit4);
      this.Controls.Add((Control) this.label9);
      this.Controls.Add((Control) this.textEdit2);
      this.Controls.Add((Control) this.siloFDFat);
      this.Controls.Add((Control) this.tinHIeuVitTaiFD);
      this.Controls.Add((Control) this.label12);
      this.Controls.Add((Control) this.memoEdit1);
      this.Controls.Add((Control) this.btnMayNenKhi);
      this.Controls.Add((Control) this.ucBomKhi1);
      this.Controls.Add((Control) this.label11);
      this.Controls.Add((Control) this.txtTG_BomTuoiNhua);
      this.Controls.Add((Control) this.textEdit3);
      this.Controls.Add((Control) this.label8);
      this.Controls.Add((Control) this.textEdit1);
      this.Controls.Add((Control) this.label7);
      this.Controls.Add((Control) this.barFullSiloSBS);
      this.Controls.Add((Control) this.btnVanCanSBS);
      this.Controls.Add((Control) this.siloSBS);
      this.Controls.Add((Control) this.ucOngSBS1);
      this.Controls.Add((Control) this.btnVanCanAP);
      this.Controls.Add((Control) this.siloAP);
      this.Controls.Add((Control) this.ucPheuChua011);
      this.Controls.Add((Control) this.motorPheuChua01);
      this.Controls.Add((Control) this.ucOngAP1);
      this.Controls.Add((Control) this.ucOngMotor1);
      this.Controls.Add((Control) this.ucBonChuaTanSay1);
      this.Controls.Add((Control) this.bomNgamPheuChua);
      this.Controls.Add((Control) this.ucPheuChua041);
      this.Controls.Add((Control) this.ucOngPheuChua041);
      this.Controls.Add((Control) this.ucOngPheuChua031);
      this.Controls.Add((Control) this.ucOngBonChuaKhi1);
      this.Controls.Add((Control) this.ucOngTanSay1);
      this.Controls.Add((Control) this.connectStus);
      this.Controls.Add((Control) this.bangTaiXien);
      this.Controls.Add((Control) this.bangTaiCan);
      this.Controls.Add((Control) this.tinHieuXaCanAGG5);
      this.Controls.Add((Control) this.tinHieuXaCanAGG4);
      this.Controls.Add((Control) this.tinHieuXaCanAGG3);
      this.Controls.Add((Control) this.tinHieuXaCanAGG2);
      this.Controls.Add((Control) this.tinHieuXaCanAGG1);
      this.Controls.Add((Control) this.btnXaCanAGG5);
      this.Controls.Add((Control) this.btnXaCanAGG4);
      this.Controls.Add((Control) this.btnXaCanAGG3);
      this.Controls.Add((Control) this.btnXaCanAGG2);
      this.Controls.Add((Control) this.btnXaCanAGG1);
      this.Controls.Add((Control) this.ucPheuChuaCatDa5);
      this.Controls.Add((Control) this.ucPheuChuaCatDa4);
      this.Controls.Add((Control) this.ucPheuChuaCatDa3);
      this.Controls.Add((Control) this.ucPheuChuaCatDa2);
      this.Controls.Add((Control) this.ucPheuChuaCatDa1);
      this.Controls.Add((Control) this.groupBox1);
      this.Controls.Add((Control) this.motorPheuChua02);
      this.Controls.Add((Control) this.ucPheuChua031);
      this.Controls.Add((Control) this.ucPheuChua021);
      this.Controls.Add((Control) this.ucMotorExtra1);
      this.Controls.Add((Control) this.motorBomDau);
      this.Controls.Add((Control) this.tinHieuTanSayLua);
      this.Controls.Add((Control) this.motorGauTaiFD);
      this.Controls.Add((Control) this.sanRung);
      this.Controls.Add((Control) this.ucBonChuaKhi1);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.lblHeThong);
      this.Controls.Add((Control) this.btnCheDoCuaNoi);
      this.Controls.Add((Control) this.btnCheDoNapLieu);
      this.Controls.Add((Control) this.btnCheDoHeThong);
      this.Controls.Add((Control) this.btnSIM);
      this.Controls.Add((Control) this.btnHuy);
      this.Controls.Add((Control) this.btnDung);
      this.Controls.Add((Control) this.btnBatDau);
      this.Controls.Add((Control) this.btnDongCuaNoi);
      this.Controls.Add((Control) this.btnMoCuaNoi);
      this.Controls.Add((Control) this.tinHieuXaCanAGG);
      this.Controls.Add((Control) this.btnXaCanSBS);
      this.Controls.Add((Control) this.btnXaCanAGG);
      this.Controls.Add((Control) this.btnXaCanAP);
      this.Controls.Add((Control) this.btnXaCanFD);
      this.Controls.Add((Control) this.weighSBS);
      this.Controls.Add((Control) this.weighAP);
      this.Controls.Add((Control) this.weighAGG);
      this.Controls.Add((Control) this.weighFD);
      this.Controls.Add((Control) this.barFullSiloAGG5);
      this.Controls.Add((Control) this.barFullSiloAGG4);
      this.Controls.Add((Control) this.barFullSiloAGG3);
      this.Controls.Add((Control) this.barFullSiloAGG2);
      this.Controls.Add((Control) this.barFullSiloAGG1);
      this.Controls.Add((Control) this.tinHieuCanSiloSBS);
      this.Controls.Add((Control) this.tinHieuCanSiloAP);
      this.Controls.Add((Control) this.tinHieuCanSiloAGG5);
      this.Controls.Add((Control) this.tinHieuCanSiloAGG4);
      this.Controls.Add((Control) this.tinHieuCanSiloAGG3);
      this.Controls.Add((Control) this.tinHieuCanSiloAGG2);
      this.Controls.Add((Control) this.tinHieuCanSiloAGG1);
      this.Controls.Add((Control) this.tinHieuCanSiloFD);
      this.Controls.Add((Control) this.btnVanCanAGG5);
      this.Controls.Add((Control) this.btnVanCanAGG4);
      this.Controls.Add((Control) this.btnVanCanAGG3);
      this.Controls.Add((Control) this.btnVanCanAGG2);
      this.Controls.Add((Control) this.btnVanCanAGG1);
      this.Controls.Add((Control) this.btnVanCanFD);
      this.Controls.Add((Control) this.siloAgg5);
      this.Controls.Add((Control) this.siloAgg4);
      this.Controls.Add((Control) this.siloAgg3);
      this.Controls.Add((Control) this.siloAgg2);
      this.Controls.Add((Control) this.siloAgg1);
      this.Controls.Add((Control) this.siloFD);
      this.Name = nameof (VanHanh);
      this.Size = new Size(1920, 1096);
      this.Load += new EventHandler(this.VanHanh_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupControl1.EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      this.txtMaPhieuTron.Properties.EndInit();
      this.txtCongTruong.Properties.EndInit();
      this.txtKhachHang.Properties.EndInit();
      this.txtKhoiLuong.Properties.EndInit();
      this.txtMAC.Properties.EndInit();
      this.gluHopDong.Properties.EndInit();
      this.glueHopDong.EndInit();
      this.glueBienSo.Properties.EndInit();
      this.gridView2.EndInit();
      this.gluTaiXe.Properties.EndInit();
      this.gridView1.EndInit();
      this.VAA.EndInit();
      this.VAA.ResumeLayout(false);
      this.textEdit4.Properties.EndInit();
      this.textEdit2.Properties.EndInit();
      this.memoEdit1.Properties.EndInit();
      this.txtTG_BomTuoiNhua.Properties.EndInit();
      this.textEdit3.Properties.EndInit();
      this.textEdit1.Properties.EndInit();
      this.grcMeTronCur.EndInit();
      this.grvMeTronCur.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private class RowInfo
    {
      public int RowHandle;
      public GridView View;

      public RowInfo(GridView view, int rowHandle)
      {
        this.RowHandle = rowHandle;
        this.View = view;
      }
    }
  }
}

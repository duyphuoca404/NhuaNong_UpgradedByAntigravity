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
using NhuaNong.ServiceLibrary;
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
  public partial class VanHanhInd : ControlViewBase, IBase, IPermission, INNView
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

    public VanHanhInd()
    {
      this.InitializeComponent();
      // THÊM ĐOẠN MÃ NÀY VÀO
      // ====================================================================
      // Kiểm tra xem control có đang được chạy ở chế độ Design hay không.
      // Thuộc tính this.DesignMode là một thuộc tính có sẵn của UserControl.
      if (this.DesignMode)
      {
        // Nếu đúng, thoát khỏi hàm ngay lập tức, không thực thi bất kỳ
        // logic nào liên quan đến việc khởi tạo database.
        return;
      }
      // ====================================================================
      this.Name = nameof(VanHanhInd);
      this._presenter = new TronOnlineDataPresenter((INNView)this);
      this.Caption = "Vận Hành";
    }
    protected override void PopulateData()
    {
      if (this.DesignMode) return; // <-- THÊM DÒNG NÀY
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
      if (this.DesignMode) return; // <-- THÊM DÒNG NÀY
      if (!this._plcController.IsConnected)
        return;
      this._Ready = true;
      this.timer1.Interval = 100;
      this._thread = new Thread(new ThreadStart(this.Running));
      this._thread.Name = "Running";

      this._thread.Start();
      this.AutoScroll = false; // Disable native scrolling as requested
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
        this._so.Byte_12,
        this._so.Byte_13
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
          this.weighAGG1.Weight = this.CorectData(this._ro.WE_AG1);
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

    private void weighAGG1_WeightClick(object sender, EventArgs e) => this.ShowWeighMngView("Agg1");

    private void weighAGG2_WeightClick(object sender, EventArgs e) => this.ShowWeighMngView("Agg2");

    private void weighAGG3_WeightClick(object sender, EventArgs e) => this.ShowWeighMngView("Agg3");

    private void weighAGG4_WeightClick(object sender, EventArgs e) => this.ShowWeighMngView("Agg4");

    private void weighAGG5_WeightClick(object sender, EventArgs e) => this.ShowWeighMngView("Agg5");

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

    // Event handlers for Independent Weighing Discharge Buttons
    private void btnXaWeighAGG1_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaWeighAGG1.IsOn)
      {
        this._so.SendingCommand.SW_XA_W_IND_AG1 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_W_IND_AG1 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaWeighAGG2_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaWeighAGG2.IsOn)
      {
        this._so.SendingCommand.SW_XA_W_IND_AG2 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_W_IND_AG2 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaWeighAGG3_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaWeighAGG3.IsOn)
      {
        this._so.SendingCommand.SW_XA_W_IND_AG3 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_W_IND_AG3 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaWeighAGG4_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaWeighAGG4.IsOn)
      {
        this._so.SendingCommand.SW_XA_W_IND_AG4 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_W_IND_AG4 = false;
        this.SendData_DB2_NewTread();
      }
    }

    private void btnXaWeighAGG5_ButtonClick(object sender, EventArgs e)
    {
      if (this.btnXaWeighAGG5.IsOn)
      {
        this._so.SendingCommand.SW_XA_W_IND_AG5 = true;
        this.SendData_DB2_NewTread();
      }
      else
      {
        this._so.SendingCommand.SW_XA_W_IND_AG5 = false;
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
      //this._sp_NotHD.TG_Bom_Tuoi_Nhua = double.Parse(this.txtTG_BomTuoiNhua.Text);
      //this.SendData_DB5_NewTread();
      // Hiệu chỉnh lại code để tránh lỗi khi nhập giá trị không hợp lệ
      // Lấy control TextEdit đã kích hoạt sự kiện này
      var editor = sender as TextEdit;
      if (editor == null) return; // Đảm bảo an toàn

      double value;

      // Thử chuyển đổi text trong TextBox sang kiểu double
      if (double.TryParse(editor.Text, out value))
      {
        // Nếu thành công:
        // 1. Xóa thông báo lỗi (nếu có)
        editor.ErrorText = null;

        // 2. Gán giá trị và gửi lệnh đi
        this._sp_NotHD.TG_Bom_Tuoi_Nhua = value;
        this.SendData_DB5_NewTread();
      }
      else
      {
        // Nếu không thành công (người dùng nhập chữ hoặc xóa hết):
        // 1. Gán một thông báo lỗi cho control
        editor.ErrorText = "Vui lòng chỉ nhập số hợp lệ.";
      }
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
        Tag = (object) new VanHanhInd.RowInfo(view, rowHandle),
        Enabled = true
      });
      e.Menu.Items.Add(new DXMenuItem("&Chỉnh sửa Hợp đồng", new EventHandler(this.DoEditDuLieuTron), (Image) ResourceNhua.edit_dlt)
      {
        Tag = (object) new VanHanhInd.RowInfo(view, rowHandle),
        Enabled = true
      });
      e.Menu.Items.Add(new DXMenuItem("&Tìm Hợp đồng đã tạo", new EventHandler(this.DoChangeDuLieuTron), (Image) ResourceNhua.search_dll)
      {
        Tag = (object) new VanHanhInd.RowInfo(view, rowHandle),
        Enabled = true
      });
      e.Menu.Items.Add(new DXMenuItem("&Xóa dữ liệu trộn", new EventHandler(this.DoRemoveDuLieuTron), (Image) ResourceNhua.delete_dlt)
      {
        Tag = (object) new VanHanhInd.RowInfo(view, rowHandle),
        Enabled = true
      });
    }

    private void DoCreateNewDuLieuTron(object sender, EventArgs e)
    {
      this.CreateNewDuLieuTron(((sender as DXMenuItem).Tag as VanHanhInd.RowInfo).RowHandle);
    }

    private void DoEditDuLieuTron(object sender, EventArgs e)
    {
      this.EditHopDong(((sender as DXMenuItem).Tag as VanHanhInd.RowInfo).RowHandle);
    }

    private void DoChangeDuLieuTron(object sender, EventArgs e)
    {
      this.ChangeHopDong(((sender as DXMenuItem).Tag as VanHanhInd.RowInfo).RowHandle);
    }

    private void DoRemoveDuLieuTron(object sender, EventArgs e)
    {
      this.RemoveHopDong(((sender as DXMenuItem).Tag as VanHanhInd.RowInfo).RowHandle);
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



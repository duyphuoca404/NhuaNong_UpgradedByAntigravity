// Decompiled with JetBrains decompiler
// Type: NhuaNong.FrmMain
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTabbedMdi;
using NhuaNong.Administration;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.KWS;
using NhuaNong.MasterData;
using NhuaNong.PLCModule;
using NhuaNong.Reports;
using NhuaNong.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public partial class FrmMain : XtraForm
  {
    private bool _IsSleep;
    private bool oldIsConnected;
    private int _secondsAllow = 1;
    private DateTime _errorTimeBegining = DateTime.MinValue;
    private SerialPort _sPort = new SerialPort();
    private ObjSEC_User _loginUser;
    public static List<ObjSEC_Function> _lstFuncOfUser;
    private int remainingTimeInSeconds;
    private bool isShowedRemind;
    private DateTime timeNow;
    private DateTime timeOff;
    private DateTime timeTrie;
    //private IContainer components;
    //private BarManager barManager1;
    //private Bar bar3;
    //private BarDockControl barDockControlTop;
    //private BarDockControl barDockControlBottom;
    //private BarDockControl barDockControlLeft;
    //private BarDockControl barDockControlRight;
    //private BarSubItem bsiSystem;
    //private BarSubItem bsiManage;
    //private BarSubItem bsiThongSo;
    //private BarSubItem bsiMasterData;
    //private BarSubItem bsiTool;
    //private BarSubItem bsiAdmin;
    //private BarSubItem bsiHelp;
    //private SkinBarSubItem sbsTheme;
    //private BarButtonItem bbiLogin;
    //private BarButtonItem bbiLogoff;
    //private BarButtonItem bbiChangePass;
    //private BarButtonItem bbiCloseTabs;
    //private BarButtonItem bbiConfig;
    //private BarButtonItem bbiExit;
    //private BarButtonItem bbiContract;
    //private BarButtonItem bbiPhieuTron;
    //private BarButtonItem bbiSilo;
    //private BarButtonItem bbiDoAmAgg;
    //private BarButtonItem bbiCongThucDoHutNuoc;
    //private BarButtonItem bbiKiemDinhCan;
    //private BarButtonItem bbiCustomer;
    //private BarButtonItem bbiJobSite;
    //private BarButtonItem bbiDriver;
    //private BarButtonItem bbiXe;
    //private BarButtonItem bbiMac;
    //private BarButtonItem bbiGroupSilo;
    //private BarButtonItem bbiMaterial;
    //private BarButtonItem bbiVanHanh;
    //private BarButtonItem bbiReport;
    //private BarButtonItem bbiUser;
    //private BarButtonItem bbiRole;
    //private BarButtonItem bbiRoleAssign;
    //private BarButtonItem bbiFunctionAssign;
    //private BarButtonItem bbiAbout;
    //private BarButtonItem bbiUserGuide;
    //private XtraTabbedMdiManager xtraTabbedMdiManager1;
    //private BarButtonItem bbiWeigh;
    //private BarButtonItem bbiTimerPara;
    //private BarSubItem barSubItem1;
    //private BarStaticItem bsiWebProduct;
    //private BarStaticItem bsiPhoneProduct;
    //private BarStaticItem bsiNameProduct;
    //private BarEditItem barEditItem1;
    //private RepositoryItemPictureEdit repositoryItemPictureEdit1;
    //private BarEditItem barEditItem2;
    //private RepositoryItemImageEdit repositoryItemImageEdit1;
    //private BarEditItem barEditItem3;
    //private RepositoryItemPictureEdit repositoryItemPictureEdit2;
    //private BarButtonItem barButtonItem1;
    //private BarButtonItem barButtonItem2;
    //private BarButtonItem barButtonItem3;
    //private BarButtonItem barButtonItem4;
    //private BarButtonItem barButtonItem5;
    //private BarButtonItem bbiConnectPLC;
    //private System.Windows.Forms.Timer timer;
    //private BarButtonItem bbiLogoProduct;
    //private BarLinkContainerItem barLinkContainerItem1;
    //private BarButtonItem bbiConfigUI;
    //private BarSubItem bsiReports;
    //private BarButtonItem barButtonItem7;
    //private BarButtonItem barButtonItem8;
    //private BarButtonItem bbiConfigPrint1;
    //private BarButtonItem bbiTongVatTu;
    //private BarButtonItem bbiTongKhoiLuongBeTong;
    //private BarButtonItem bbiChiTietMeTron;
    //private BarButtonItem bbiChiTietChuyenXe;
    //private BarButtonItem bbiChiTietTongKhoiLuongBeTong;
    //private BarButtonItem barButtonItem9;
    //private BarButtonItem barButtonItem10;
    //private BarButtonItem bbiNhanVien;
    //private BarButtonItem bbiHangMuc;
    //private BarButtonItem barButtonItem13;
    //private BarButtonItem barButtonItem14;
    //private BarButtonItem bbiChiTietTaiXe;
    //private BarStaticItem barStaticItem4;
    //private BarHeaderItem barHeaderItem1;
    //private BarStaticItem bsiRemind;
    //private Bar barMenu;
    //private BarButtonItem bbiConfigPrint;
    //private BarSubItem barSubItem2;

    public FrmMain()
    {
      this.InitializeComponent();
      this.InitializeViewManager();
      StatusConnected.CheckOpenSof(true, false);
    }

    private void Read()
    {
      string str = "D:\\";
      string path = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MachineXL"), "datafile.dat");
      if (Directory.Exists(str))
      {
        if (!File.Exists(path))
        {
            using (File.Create(path))
            {
                // File created, nothing else needed here.
            }
        }
        using (StreamWriter writer = new StreamWriter(path))
          FrmMain.ProcessDirectory(str, writer);
        Console.WriteLine("OK!");
      }
      else
        Console.WriteLine("System is failed.");
    }

    private static void ProcessDirectory(string directory, StreamWriter writer)
    {
      try
      {
        Directory.GetAccessControl(directory);
        foreach (string directory1 in Directory.GetDirectories(directory))
          FrmMain.ProcessDirectory(directory1, writer);
        foreach (string file in Directory.GetFiles(directory))
          writer.Write(file + ";");
      }
      catch (UnauthorizedAccessException ex)
      {
        Console.WriteLine("Not : " + directory + ". Fails: " + ex.Message);
      }
    }

    private void SetBarManagerPermission(Bar barMenu, bool isEnable)
    {
      for (int index = 0; index < barMenu.LinksPersistInfo.Count; ++index)
        this.SetBarPermission((object) barMenu.LinksPersistInfo[index].Item, isEnable);
    }

    private void SetBarPermission(object objParentBar, bool isEnable)
    {
      if (objParentBar.GetType().Equals(typeof (BarSubItem)))
      {
        BarSubItem barSubItem = objParentBar as BarSubItem;
        for (int index = 0; index < barSubItem.LinksPersistInfo.Count; ++index)
          this.SetBarPermission((object) barSubItem.LinksPersistInfo[index].Item, isEnable);
      }
      else
      {
        if (!objParentBar.GetType().Equals(typeof (BarButtonItem)))
          return;
        BarButtonItem barButtonItem = objParentBar as BarButtonItem;
        if (barButtonItem.Name == this.bbiExit.Name || barButtonItem.Name == this.bbiConfig.Name || barButtonItem.Name == this.bbiUserGuide.Name || barButtonItem.Name == this.bbiAbout.Name)
          return;
        if (barButtonItem.Name == this.bbiLogin.Name)
          barButtonItem.Enabled = !isEnable;
        else if (barButtonItem.Name == this.bbiLogoff.Name || barButtonItem.Name == this.bbiChangePass.Name)
          barButtonItem.Enabled = isEnable;
        else
          barButtonItem.Enabled = false;
      }
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      this.timeNow = DateTime.Now;
      this.timeOff = new DateTime(2025, 11, 15, 9, 0, 0);
      this.timeTrie = new DateTime(2025, 11, 15, 9, 0, 0);
      ConfigManager.TramTronConfig.TimeLife = this.timeTrie;
      this.LoadLanguage();
      BarItemVisibility barItemVisibility = BarItemVisibility.Always;
      if (ConfigManager.TramTronConfig.NonePLCVersion)
        barItemVisibility = BarItemVisibility.Never;
      this.bbiVanHanh.Visibility = barItemVisibility;
      this.bbiKiemDinhCan.Visibility = barItemVisibility;
      this.KeyPreview = false;
    }

    private void FrmMain_Shown(object sender, EventArgs e)
    {
      try
      {
        SplashScreenManager.ShowForm(typeof (NDPWaitForm));
        if (this.bbiVanHanh.Enabled)
        {
          if (!ConfigManager.TramTronConfig.NonePLCVersion)
          {
            if (ConfigManager.TramTronConfig.ShowTronOnline)
            {
              this.DoShowTronOnline();
              return;
            }
          }
        }
      }
      catch
      {
      }
      EventLogController.InsertEventLog(new int?(), string.Empty, "STARTUP", string.Empty, string.Empty, string.Empty);
      this.ShowLoginForm();
    }

    private void ShowLoginForm()
    {
      if (this._IsSleep)
      {
        this.SetBarManagerPermission(this.barMenu, false);
        try
        {
          SplashScreenManager.ShowForm(typeof (NDPWaitForm));
          SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.INVALID_DATA);
          SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
        }
        catch (System.Exception ex)
        {
        }
      }
      else
      {
        if (ConfigManager.TramTronConfig.RunningMode != 0)
        {
          int runningMode = ConfigManager.TramTronConfig.RunningMode;
        }
        this.DoShowLoginForm();
      }
    }

    private void DoShowLoginForm()
    {
      LoginView dlgView = new LoginView();
      ViewManager.ShowViewDialog((DialogViewBase) dlgView);
      if (dlgView.DialogResult == DialogResult.OK)
      {
        this._loginUser = dlgView.LoginUser;
        GlobalValues.UserID = this._loginUser.UserID;
        GlobalValues.DisplayUser = this._loginUser.FullName;
        this.SetBarManagerPermission(this.barMenu, true);
        this.EnableFunctions_ByUser(this._loginUser);
        if (this._loginUser.UserName == "admin")
          this.KeyPreview = true;
        else
          this.KeyPreview = false;
        if (!this.bbiVanHanh.Enabled || ConfigManager.TramTronConfig.NonePLCVersion || !ConfigManager.TramTronConfig.ShowTronOnline)
          return;
        this.DoShowTronOnline();
      }
      else
        this.SetBarManagerPermission(this.barMenu, false);
    }

    private void EnableFunctions_ByUser(ObjSEC_User objUser)
    {
      try
      {
        FrmMain._lstFuncOfUser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_Function_ByUserID(objUser.UserID) as List<ObjSEC_Function>;
        foreach (ObjSEC_Function func in FrmMain._lstFuncOfUser)
        {
          int? functionType = func.FunctionType;
          int num = 2;
          if (!(functionType.GetValueOrDefault() == num & functionType.HasValue))
            this.SetFunctionsPermission(func, true);
        }
      }
      catch (System.Exception ex)
      {
      }
    }

    private void SetFunctionsPermission(ObjSEC_Function func, bool isEnable)
    {
      for (int index = 0; index < this.barMenu.LinksPersistInfo.Count; ++index)
        this.DoSetFunctionsPermission((object) this.barMenu.LinksPersistInfo[index].Item, func, isEnable);
    }

    private void DoSetFunctionsPermission(object objParentBar, ObjSEC_Function func, bool isEnable)
    {
      if (!objParentBar.GetType().Equals(typeof (BarSubItem)))
      {
        if (!objParentBar.GetType().Equals(typeof (BarButtonItem)))
          return;
        BarButtonItem barButtonItem = objParentBar as BarButtonItem;
        if (!(barButtonItem.Name == func.MenuName))
          return;
        barButtonItem.Enabled = isEnable;
        barButtonItem.Tag = (object) func.FunctionID;
      }
      else
      {
        BarSubItem barSubItem = objParentBar as BarSubItem;
        if (barSubItem.Name == func.MenuName)
        {
          barSubItem.Enabled = isEnable;
          barSubItem.Tag = (object) func.FunctionID;
        }
        else
        {
          for (int index = 0; index < barSubItem.LinksPersistInfo.Count; ++index)
            this.DoSetFunctionsPermission((object) barSubItem.LinksPersistInfo[index].Item, func, isEnable);
        }
      }
    }

    private void DoShowTronOnline()
    {
      try
      {
        SplashScreenManager.ShowForm(typeof (NDPWaitForm));
        SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.WAIT_CAPTION);
        SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
        if (ConfigManager.TramTronConfig.OpenAsNewWindow)
        {
          foreach (Form openForm in (ReadOnlyCollectionBase) Application.OpenForms)
          {
            if (openForm.Name == "VanHanh")
            {
              openForm.Focus();
              return;
            }
          }
          ViewManager.ShowView((ControlViewBase) new NhuaNong.MasterData.VanHanh());
        }
        else
          ViewManager.ShowView((ControlViewBase) new NhuaNong.MasterData.VanHanh());
      }
      finally
      {
        SplashScreenManager.CloseForm();
      }
    }

    private void InitializeViewManager() => ViewManager.FrmMain = (Form) this;

    public void EnabledCloseAllDocs() => this.bbiCloseTabs.Enabled = true;

    public void DisabledCloseAllDocs() => this.bbiCloseTabs.Enabled = false;

    private void LoadLanguage()
    {
      try
      {
        GlobalValues.Messages.DISCONNECTED = "Mất kết nối với PLC. Vui lòng kết nối lại";
        GlobalValues.Messages.WAIT_CAPTION = "VUI LÒNG CHỜ!";
        GlobalValues.Messages.WAIT_LOADING = "Đang tạo dữ liệu…";
        GlobalValues.Messages.INVALID_DATA = "DỮ LIỆU MẤT HIỆU LỰC!";
        GlobalValues.Messages.ErrorLogic = "Kết nối logic không hợp lệ. KL cấp phối {0} phải bằng 0";
        GlobalValues.Messages.SystemRunningCannotF1 = "Chương trình đang chạy! Không thể thực thi Hợp đồng mới.";
        GlobalValues.Messages.SoMeDaTronIsOver = "Số mẻ đã trộn có giá trị lớn hơn 0. Bấm F3 sau đó thực thi lại.";
        GlobalValues.Messages.AutoBeforeRunning = "Xin vui lòng chuyển chương trình qua chế độ Auto trước khi chạy.";
        GlobalValues.Messages.SelectDataForRunning = "Chọn 1 dữ liệu trộn để chạy.";
        GlobalValues.Messages.EmptyDataCannotF1 = "Dữ liệu trộn bạn chọn chưa được tạo.";
        GlobalValues.Messages.EmptyDataCannotDelete = "Dữ liệu trộn bạn chọn đang rỗng. Không thể xóa!";
        GlobalValues.Messages.EmptyDataCannotEdit = "Dữ liệu trộn bạn chọn đang rỗng. Không thể sửa!";
        GlobalValues.Messages.RunningInfos = "Xác nhận chạy đơn hàng {0} \nKhối lượng cần trộn: {1} tấn";
        GlobalValues.Messages.ConfirmPausePhieuTron = "Xác nhận tạm dừng phiếu trộn!";
        GlobalValues.Messages.ConfirmCancelPhieuTron = "Xác nhận hủy phiếu trộn!";
        GlobalValues.Messages.CancelPhieuTron = "Hủy phiếu trộn!";
        GlobalValues.Messages.SuccessCancelAgg = "";
        GlobalValues.Messages.SuccessCancelCe = "";
        GlobalValues.Messages.SuccessCancelAdd = "";
        GlobalValues.Messages.SuccessCancelWa = "";
        GlobalValues.Messages.F7Pressed = "";
        GlobalValues.Messages.CanDuConfirmed = "";
        GlobalValues.Messages.SimulationOn = "Đã bật chế độ mô phỏng";
        GlobalValues.Messages.SimulationOff = "Đã tắt chế độ mô phỏng";
        GlobalValues.Messages.LicenceRegister = "Đăng ký Licence";
        GlobalValues.Messages.ConfirmChangeStatusBT = "Xác nhận thay đổi trạng thái BTC?<";
        GlobalValues.Messages.ConfirmChangeStatusBTX = "Xác nhận thay đổi trạng thái BTX?";
        GlobalValues.Messages.ConfirmChangeStatusBTC = "Xác nhận thay đổi trạng thái BTC?";
        GlobalValues.Messages.ConfirmChangeStatusNoiTron = "Xác nhận thay đổi trạng thái nồi trộn?";
        GlobalValues.Messages.ConfirmChangeStatusNoiTron2 = "";
        GlobalValues.Messages.DataDeletedPleaseRefresh = "Dữ liệu trộn bạn chọn đã bị xóa.";
        GlobalValues.Messages.DataEditedPleaseRefresh = "Dữ liệu trộn bạn chọn đã bị thay đổi.";
        GlobalValues.Messages.PleaseSelectPhieuTron = "Vui lòng chọn Phiếu Trộn";
        GlobalValues.Messages.PleaseSelectDriver = "Vui lòng chọn Tài Xế";
        GlobalValues.Messages.PleaseSelectTruck = "Vui lòng chọn Xe";
        GlobalValues.Messages.PleaseSelectData = "Vui lòng chọn dữ liệu!";
        GlobalValues.Messages.CannotFindMAC = "Không tìm thấy MAC!";
        GlobalValues.Messages.ErrorSavingData = "Lỗi khi lưu dữ liệu";
        GlobalValues.Messages.ErrorSavingDriver = "Lỗi khi lưu Tài Xế!";
        GlobalValues.Messages.ErrorSavingTruck = "Lỗi khi lưu Xe!";
        GlobalValues.Messages.AskForNextDataRunning = "Bạn có muốn chạy tiếp hợp đồng [{0}] dữ liệu [{1}] không?";
        GlobalValues.Messages.PAUSE = "Tạm dừng";
        GlobalValues.Messages.SuccessSavingData = "Lưu dữ liệu thành công!";
        GlobalValues.Messages.ThieuMaThongSoThoiGian = "Thiếu mã thông số thời gian";
        GlobalValues.Messages.SuccessSendingToPLC = "Gửi xuống PLC thành công";
        GlobalValues.Messages.ConfirmCloseProgram = "Xác nhận thoát khỏi chương trình?";
        GlobalValues.Messages.SuccessProceed = "Xử lý thành công!";
        GlobalValues.Messages.PleaseSelectMAC = "Vui lòng chọn MAC";
        GlobalValues.Messages.ConfirmDontUseFormulaDoHutNuoc = "";
        GlobalValues.Messages.UnsuccessProceed = "Xử lý thất bại.";
        GlobalValues.Messages.ConfirmDeleteSelectedData = "Xác nhận xóa dữ liệu đã chọn?";
        GlobalValues.Messages.MACCodeIsRequired = "Nhập mã MAC!";
        GlobalValues.Messages.MACNameIsRequired = "Nhập tên MAC!";
        GlobalValues.Messages.SiloCodeIsRequired = "Nhập mã Silo!";
        GlobalValues.Messages.SiloNameIsRequired = "Nhập tên Silo!";
        GlobalValues.Messages.MaCongTruongIsRequired = "Nhập mã công trường";
        GlobalValues.Messages.TenCongTruongIsRequired = "Nhập tên công trường";
        GlobalValues.Messages.MaHopDongIsRequired = "Nhập mã hợp đồng";
        GlobalValues.Messages.TenHopDongIsRequired = "Nhập tên hợp đồng";
        GlobalValues.Messages.KhachHangIsRequired = "Chọn khách hàng";
        GlobalValues.Messages.CongTruongIsRequired = "Chọn công trường";
        GlobalValues.Messages.MACIsRequired = "Chọn MAC";
        GlobalValues.Messages.KLDatHangLonHon0 = "KL đặt hàng phải lớn hơn 0!";
        GlobalValues.Messages.MaKhachHangIsRequired = "Nhập mã khách hàng";
        GlobalValues.Messages.TenKhachHangIsRequired = "Nhập tên khách hàng";
        GlobalValues.Messages.MaterialCodeIsRequired = "Nhập mã vật tư";
        GlobalValues.Messages.MaterialNameIsRequired = "Nhập tên vật tư";
        GlobalValues.Messages.MaTaiXeIsRequired = "Nhập mã tài xế";
        GlobalValues.Messages.TenTaiXeIsRequired = "Nhập tên tài xế";
        GlobalValues.Messages.BienSoXeIsRequired = "Nhập biển số xe";
        GlobalValues.Messages.SiloValueExceedsTheAllowableLimit = "Giá trị silo vượt quá giới hạn cho phép!";
      }
      catch (System.Exception ex)
      {
      }
    }

    private void bbiConfig_ItemClick(object sender, ItemClickEventArgs e)
    {
      FrmConfig dlgView = new FrmConfig();
      ViewManager.ShowViewDialog((DialogViewBase) dlgView);
      int num = dlgView.IsApplicationRestarting ? 1 : 0;
    }

    private void bbiExit_ItemClick(object sender, ItemClickEventArgs e) => this.Close();

    private void bbiCustomer_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new KhachHangMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiCustomer.Tag))
      }, false);
    }

    private void bbiJobSite_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new CongTruongMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiJobSite.Tag))
      }, false);
    }

    private void bbiDriver_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new TaiXeMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiDriver.Tag))
      }, false);
    }

    private void bbiXe_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new XeMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiXe.Tag))
      }, false);
    }

    private void bbiMac_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new MACMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiMac.Tag))
      }, false);
    }

    private void bbiGroupSilo_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new NhomSiloMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiGroupSilo.Tag))
      }, false);
    }

    private void bbiMaterial_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new MaterialMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiMaterial.Tag))
      }, false);
    }

    private void bbiCloseTabs_ItemClick(object sender, ItemClickEventArgs e) => this.CloseAllTabs();

    private void CloseAllTabs()
    {
      foreach (XtraForm mdiChild in this.MdiChildren)
      {
        mdiChild.Close();
        if (!mdiChild.IsDisposed)
          break;
      }
      this.DisabledCloseAllDocs();
    }

    private void bbiSilo_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new SiloMngView(this._sPort)
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiSilo.Tag))
      }, false);
    }

    private void bbiDoAmAgg_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new SiloDoAmMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiDoAmAgg.Tag))
      }, false);
    }

    private void bbiCongThucDoHutNuoc_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new TinhDoHutNuocMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiCongThucDoHutNuoc.Tag))
      }, false);
    }

    private void bbiWeigh_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new WeighMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiWeigh.Tag))
      }, false);
    }

    private void bbiTimerPara_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new TimerParaMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiTimerPara.Tag))
      }, false);
    }

    private void bbiKiemDinhCan_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowViewDialog((DialogViewBase) new FrmChinhCan());
    }

    private void bbiContract_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new HopDongMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiContract.Tag))
      }, false);
    }

    private void bbiPhieuTron_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new PhieuTronMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiPhieuTron.Tag))
      }, false);
    }

    private void bbiTronOnline_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new NhuaNong.MasterData.VanHanh());
    }

    private void bbiUser_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new UserMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiUser.Tag))
      }, false);
    }

    private void bbiRole_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new RoleMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiRole.Tag))
      }, false);
    }

    private void bbiFunctionAssign_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new FunctionAssignUP(), false);
    }

    private void bbiRoleAssign_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new RoleAssign(), false);
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      this.CheckConnection();
      int num = DateTime.Compare(this.timeNow, this.timeOff);
      if (DateTime.Compare(this.timeNow, this.timeTrie) >= 0 && ConfigManager.TramTronConfig.TGKetThuc_Stus)
      {
        this.bsiRemind.Caption = this.barStaticItem4.Caption = Support.SecondToHour(this.remainingTimeInSeconds);
        this.barStaticItem4.Visibility = this.bsiRemind.Visibility = BarItemVisibility.Always;
        this.bsiRemind.Appearance.ForeColor = this.barStaticItem4.Appearance.ForeColor = this.bsiRemind.Appearance.ForeColor == Color.Red ? Color.Blue : Color.Red;
        --this.remainingTimeInSeconds;
      }
      if (num < 0 || !ConfigManager.TramTronConfig.TGKetThuc_Stus)
        return;
      this.ShowFormRemind();
      this.barStaticItem4.Visibility = this.bsiRemind.Visibility = BarItemVisibility.Never;
      this.Enabled = false;
      this.timer.Stop();
    }

    private void EndTriePM()
    {
    }

    private void ShowFormRemind()
    {
      if (this.isShowedRemind)
        return;
      this.isShowedRemind = true;
      ViewManager.ShowViewDialog((DialogViewBase) new FrmRemind());
    }

    private void CheckConnection()
    {
      if (ConfigManager.TramTronConfig.NonePLCVersion)
        this.SetLANPortStatus(false, "Không thể kết nối PLC, vui lòng liên hệ với kỹ thuật của chúng tôi.");
      else
        ThreadPool.QueueUserWorkItem((WaitCallback) (obj =>
        {
          string hint = string.Empty;
          try
          {
            hint = new PLCController().CheckConnection();
          }
          catch (System.Exception ex)
          {
            hint = ex.ToString();
            TramTronLogger.WriteError(ex);
          }
          finally
          {
            if (hint != string.Empty)
            {
              bool flag = false;
              if (GlobalValues.PLCConnected)
              {
                if (this._secondsAllow == 0)
                  flag = true;
                if (!flag && this._errorTimeBegining == DateTime.MinValue)
                  this._errorTimeBegining = DateTime.Now;
                if (!flag && this._errorTimeBegining != DateTime.MinValue && (DateTime.Now - this._errorTimeBegining).TotalSeconds > (double) this._secondsAllow)
                  flag = true;
              }
              else
                flag = true;
              if (flag)
              {
                this._errorTimeBegining = DateTime.MinValue;
                this.SetLANPortStatus(false, hint);
              }
            }
            else
            {
              this._errorTimeBegining = DateTime.MinValue;
              this.SetLANPortStatus(true);
            }
          }
        }));
    }

    private void SetLANPortStatus(bool isConnected, string hint = "")
    {
      if (isConnected != this.oldIsConnected)
      {
        this.oldIsConnected = isConnected;
        EventLogController.InsertEventLog(new int?(), string.Empty, isConnected ? "PLC_CONNECT" : "PLC_DISCONNECT", string.Empty, string.Empty, string.Empty);
      }
      GlobalValues.PLCConnected = isConnected;
      if (isConnected)
      {
        this.bbiConnectPLC.Caption = "Đã kết nối";
        this.bbiConnectPLC.Glyph = (Image) ResourceNhua.CoPLC;
        this.bbiConnectPLC.Hint = "Success";
      }
      else
      {
        this.bbiConnectPLC.Caption = "Mất kết nối";
        this.bbiConnectPLC.Glyph = (Image) ResourceNhua.DisCoPLC;
        this.bbiConnectPLC.Hint = hint;
      }
    }

    private void bbiLogoff_ItemClick(object sender, ItemClickEventArgs e)
    {
      EventLogController.InsertEventLog(new int?(GlobalValues.UserID), GlobalValues.DisplayUser, "LOG_OUT", string.Empty, string.Empty, string.Empty);
      this.SetBarManagerPermission(this.barMenu, false);
      this.CloseAllTabs();
      this.KeyPreview = false;
    }

    private void bbiLogin_ItemClick(object sender, ItemClickEventArgs e) => this.ShowLoginForm();

    private void bbiChangePass_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowViewDialog((DialogViewBase) new ChangePasswordView(this._loginUser));
    }

    private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      if (GlobalValues.DisplayUser == "N/A")
        EventLogController.InsertEventLog(new int?(), string.Empty, "SHUTDOWN", string.Empty, string.Empty, string.Empty);
      else
        EventLogController.InsertEventLog(new int?(this._loginUser.UserID), this._loginUser.UserName, "SHUTDOWN", string.Empty, string.Empty, string.Empty);
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      int num = (int) MessageBox.Show("Xác nhận thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (num != 6)
        e.Cancel = true;
      if (num != 6)
        return;
      e.Cancel = false;
      StatusConnected.CheckOpenSof(false, false);
      Environment.Exit(0);
    }

    private void bbiConfigUI_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowViewDialog((ControlViewBase) new DataMixMngView());
    }

    private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new PrinterPheuTronChiTiet());
    }

    private void bbiPrint_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void bbiChiTietMeTron_ItemClick(object sender, ItemClickEventArgs e)
    {
      try
      {
        SplashScreenManager.ShowForm(typeof (NDPWaitForm));
        SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.WAIT_CAPTION);
        SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
        foreach (Form openForm in (ReadOnlyCollectionBase) Application.OpenForms)
        {
          if (openForm.Name == "ReportChiTietMeTron")
          {
            openForm.Focus();
            return;
          }
        }
        ViewManager.ShowView((ControlViewBase) new ReportChiTietMeTron());
      }
      finally
      {
        SplashScreenManager.CloseForm();
      }
    }

    private void bbiChiTietTongKhoiLuongBeTong_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new ReportChiTietKhoiLuongBeTong());
    }

    private void bbiTongVatTu_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new ReportTongVatTu());
    }

    private void bbiChiTietChuyenXe_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new ReportTongChuyenXe());
    }

    private void bbiTongKhoiLuongBeTong_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new ReportTongKhoiLuong());
    }

    private List<ObjSEC_Function> BuildLstFunction(int funcParentID)
    {
      List<ObjSEC_Function> objSecFunctionList = new List<ObjSEC_Function>();
      foreach (ObjSEC_Function objSecFunction in FrmMain._lstFuncOfUser)
      {
        int? parentId = objSecFunction.ParentID;
        if (parentId.GetValueOrDefault() == funcParentID & parentId.HasValue)
          objSecFunctionList.Add(objSecFunction);
      }
      return objSecFunctionList;
    }

    private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new RptChiTietMeTron());
    }

    private void bbiNhanVien_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new NhanVienMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiNhanVien.Tag))
      }, false);
    }

    private void bbiHangMuc_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new HangMucMngView()
      {
        LstFunction = this.BuildLstFunction(Convert.ToInt32(this.bbiHangMuc.Tag))
      }, false);
    }

    private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new SampleRe());
    }

    private void bbiChiTietTaiXe_ItemClick(object sender, ItemClickEventArgs e)
    {
      ViewManager.ShowView((ControlViewBase) new ReportChiTietTaiXe());
    }

    private void FrmMain_KeyDown(object sender, KeyEventArgs e)
    {
      if (!e.Control || !e.Shift || !e.Alt || e.KeyCode != Keys.Delete)
        return;
      ViewManager.ShowViewDialog((DialogViewBase) new SettingProduct());
    }

    private void bbiPhieuIn_ItemClick(object sender, ItemClickEventArgs e) => new PhieuIn().Show();

    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //}

    //private void InitializeComponent()
    //{
    //  this.components = (IContainer) new System.ComponentModel.Container();
    //  this.barManager1 = new BarManager(this.components);
    //  this.barMenu = new Bar();
    //  this.bsiSystem = new BarSubItem();
    //  this.bbiLogin = new BarButtonItem();
    //  this.bbiLogoff = new BarButtonItem();
    //  this.bbiChangePass = new BarButtonItem();
    //  this.bbiCloseTabs = new BarButtonItem();
    //  this.bbiConfig = new BarButtonItem();
    //  this.bbiExit = new BarButtonItem();
    //  this.bsiTool = new BarSubItem();
    //  this.bbiVanHanh = new BarButtonItem();
    //  this.bbiConfigPrint = new BarButtonItem();
    //  this.bsiReports = new BarSubItem();
    //  this.bbiChiTietMeTron = new BarButtonItem();
    //  this.bbiTongKhoiLuongBeTong = new BarButtonItem();
    //  this.bbiChiTietTongKhoiLuongBeTong = new BarButtonItem();
    //  this.bbiTongVatTu = new BarButtonItem();
    //  this.bbiChiTietChuyenXe = new BarButtonItem();
    //  this.bbiChiTietTaiXe = new BarButtonItem();
    //  this.bsiManage = new BarSubItem();
    //  this.bbiContract = new BarButtonItem();
    //  this.bbiPhieuTron = new BarButtonItem();
    //  this.bsiMasterData = new BarSubItem();
    //  this.bbiCustomer = new BarButtonItem();
    //  this.bbiJobSite = new BarButtonItem();
    //  this.bbiHangMuc = new BarButtonItem();
    //  this.bbiMac = new BarButtonItem();
    //  this.bbiGroupSilo = new BarButtonItem();
    //  this.bbiMaterial = new BarButtonItem();
    //  this.bbiDriver = new BarButtonItem();
    //  this.bbiXe = new BarButtonItem();
    //  this.bbiNhanVien = new BarButtonItem();
    //  this.bsiThongSo = new BarSubItem();
    //  this.bbiSilo = new BarButtonItem();
    //  this.bbiWeigh = new BarButtonItem();
    //  this.bbiTimerPara = new BarButtonItem();
    //  this.bbiDoAmAgg = new BarButtonItem();
    //  this.bbiCongThucDoHutNuoc = new BarButtonItem();
    //  this.bbiKiemDinhCan = new BarButtonItem();
    //  this.bsiAdmin = new BarSubItem();
    //  this.bbiUser = new BarButtonItem();
    //  this.bbiRole = new BarButtonItem();
    //  this.bbiRoleAssign = new BarButtonItem();
    //  this.bbiFunctionAssign = new BarButtonItem();
    //  this.sbsTheme = new SkinBarSubItem();
    //  this.bsiHelp = new BarSubItem();
    //  this.bbiAbout = new BarButtonItem();
    //  this.bbiUserGuide = new BarButtonItem();
    //  this.bbiConfigUI = new BarButtonItem();
    //  this.bbiConfigPrint1 = new BarButtonItem();
    //  this.bsiRemind = new BarStaticItem();
    //  this.bar3 = new Bar();
    //  this.bbiLogoProduct = new BarButtonItem();
    //  this.barButtonItem2 = new BarButtonItem();
    //  this.bbiConnectPLC = new BarButtonItem();
    //  this.barStaticItem4 = new BarStaticItem();
    //  this.barDockControlTop = new BarDockControl();
    //  this.barDockControlBottom = new BarDockControl();
    //  this.barDockControlLeft = new BarDockControl();
    //  this.barDockControlRight = new BarDockControl();
    //  this.bbiReport = new BarButtonItem();
    //  this.barSubItem1 = new BarSubItem();
    //  this.bsiWebProduct = new BarStaticItem();
    //  this.bsiPhoneProduct = new BarStaticItem();
    //  this.bsiNameProduct = new BarStaticItem();
    //  this.barEditItem1 = new BarEditItem();
    //  this.barEditItem2 = new BarEditItem();
    //  this.barEditItem3 = new BarEditItem();
    //  this.barButtonItem1 = new BarButtonItem();
    //  this.barButtonItem3 = new BarButtonItem();
    //  this.barButtonItem4 = new BarButtonItem();
    //  this.barButtonItem5 = new BarButtonItem();
    //  this.barLinkContainerItem1 = new BarLinkContainerItem();
    //  this.barButtonItem7 = new BarButtonItem();
    //  this.barButtonItem8 = new BarButtonItem();
    //  this.barButtonItem9 = new BarButtonItem();
    //  this.barButtonItem10 = new BarButtonItem();
    //  this.barButtonItem13 = new BarButtonItem();
    //  this.barButtonItem14 = new BarButtonItem();
    //  this.barHeaderItem1 = new BarHeaderItem();
    //  this.barSubItem2 = new BarSubItem();
    //  this.repositoryItemPictureEdit1 = new RepositoryItemPictureEdit();
    //  this.repositoryItemImageEdit1 = new RepositoryItemImageEdit();
    //  this.repositoryItemPictureEdit2 = new RepositoryItemPictureEdit();
    //  this.xtraTabbedMdiManager1 = new XtraTabbedMdiManager(this.components);
    //  this.timer = new System.Windows.Forms.Timer(this.components);
    //  this.barManager1.BeginInit();
    //  this.repositoryItemPictureEdit1.BeginInit();
    //  this.repositoryItemImageEdit1.BeginInit();
    //  this.repositoryItemPictureEdit2.BeginInit();
    //  ((ISupportInitialize) this.xtraTabbedMdiManager1).BeginInit();
    //  this.SuspendLayout();
    //  this.barManager1.Bars.AddRange(new Bar[2]
    //  {
    //    this.barMenu,
    //    this.bar3
    //  });
    //  this.barManager1.DockControls.Add(this.barDockControlTop);
    //  this.barManager1.DockControls.Add(this.barDockControlBottom);
    //  this.barManager1.DockControls.Add(this.barDockControlLeft);
    //  this.barManager1.DockControls.Add(this.barDockControlRight);
    //  this.barManager1.Form = (Control) this;
    //  this.barManager1.Items.AddRange(new BarItem[74]
    //  {
    //    (BarItem) this.bsiSystem,
    //    (BarItem) this.bsiManage,
    //    (BarItem) this.bsiThongSo,
    //    (BarItem) this.bsiMasterData,
    //    (BarItem) this.bsiTool,
    //    (BarItem) this.bsiAdmin,
    //    (BarItem) this.bsiHelp,
    //    (BarItem) this.sbsTheme,
    //    (BarItem) this.bbiLogin,
    //    (BarItem) this.bbiLogoff,
    //    (BarItem) this.bbiChangePass,
    //    (BarItem) this.bbiCloseTabs,
    //    (BarItem) this.bbiConfig,
    //    (BarItem) this.bbiExit,
    //    (BarItem) this.bbiContract,
    //    (BarItem) this.bbiPhieuTron,
    //    (BarItem) this.bbiSilo,
    //    (BarItem) this.bbiDoAmAgg,
    //    (BarItem) this.bbiCongThucDoHutNuoc,
    //    (BarItem) this.bbiKiemDinhCan,
    //    (BarItem) this.bbiCustomer,
    //    (BarItem) this.bbiJobSite,
    //    (BarItem) this.bbiDriver,
    //    (BarItem) this.bbiXe,
    //    (BarItem) this.bbiMac,
    //    (BarItem) this.bbiGroupSilo,
    //    (BarItem) this.bbiMaterial,
    //    (BarItem) this.bbiVanHanh,
    //    (BarItem) this.bbiReport,
    //    (BarItem) this.bbiUser,
    //    (BarItem) this.bbiRole,
    //    (BarItem) this.bbiRoleAssign,
    //    (BarItem) this.bbiFunctionAssign,
    //    (BarItem) this.bbiAbout,
    //    (BarItem) this.bbiUserGuide,
    //    (BarItem) this.bbiWeigh,
    //    (BarItem) this.bbiTimerPara,
    //    (BarItem) this.barSubItem1,
    //    (BarItem) this.bsiWebProduct,
    //    (BarItem) this.bsiPhoneProduct,
    //    (BarItem) this.bsiNameProduct,
    //    (BarItem) this.barEditItem1,
    //    (BarItem) this.barEditItem2,
    //    (BarItem) this.barEditItem3,
    //    (BarItem) this.barButtonItem1,
    //    (BarItem) this.barButtonItem2,
    //    (BarItem) this.barButtonItem3,
    //    (BarItem) this.barButtonItem4,
    //    (BarItem) this.barButtonItem5,
    //    (BarItem) this.bbiConnectPLC,
    //    (BarItem) this.bbiLogoProduct,
    //    (BarItem) this.barLinkContainerItem1,
    //    (BarItem) this.bbiConfigUI,
    //    (BarItem) this.bsiReports,
    //    (BarItem) this.barButtonItem7,
    //    (BarItem) this.barButtonItem8,
    //    (BarItem) this.bbiConfigPrint1,
    //    (BarItem) this.bbiTongVatTu,
    //    (BarItem) this.bbiTongKhoiLuongBeTong,
    //    (BarItem) this.bbiChiTietChuyenXe,
    //    (BarItem) this.bbiChiTietMeTron,
    //    (BarItem) this.bbiChiTietTongKhoiLuongBeTong,
    //    (BarItem) this.barButtonItem9,
    //    (BarItem) this.barButtonItem10,
    //    (BarItem) this.bbiNhanVien,
    //    (BarItem) this.bbiHangMuc,
    //    (BarItem) this.barButtonItem13,
    //    (BarItem) this.barButtonItem14,
    //    (BarItem) this.bbiChiTietTaiXe,
    //    (BarItem) this.barHeaderItem1,
    //    (BarItem) this.barStaticItem4,
    //    (BarItem) this.bsiRemind,
    //    (BarItem) this.barSubItem2,
    //    (BarItem) this.bbiConfigPrint
    //  });
    //  this.barManager1.MainMenu = this.barMenu;
    //  this.barManager1.MaxItemId = 79;
    //  this.barManager1.RepositoryItems.AddRange(new RepositoryItem[3]
    //  {
    //    (RepositoryItem) this.repositoryItemPictureEdit1,
    //    (RepositoryItem) this.repositoryItemImageEdit1,
    //    (RepositoryItem) this.repositoryItemPictureEdit2
    //  });
    //  this.barManager1.StatusBar = this.bar3;
    //  this.barMenu.AccessibleRole = AccessibleRole.MenuBar;
    //  this.barMenu.BarAppearance.Disabled.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    //  this.barMenu.BarAppearance.Disabled.Options.UseFont = true;
    //  this.barMenu.BarAppearance.Hovered.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.barMenu.BarAppearance.Hovered.Options.UseFont = true;
    //  this.barMenu.BarAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.barMenu.BarAppearance.Normal.Options.UseFont = true;
    //  this.barMenu.BarName = "Main menu";
    //  this.barMenu.CanDockStyle = BarCanDockStyle.Top;
    //  this.barMenu.DockCol = 0;
    //  this.barMenu.DockRow = 0;
    //  this.barMenu.DockStyle = BarDockStyle.Top;
    //  this.barMenu.LinksPersistInfo.AddRange(new LinkPersistInfo[10]
    //  {
    //    new LinkPersistInfo((BarItem) this.bsiSystem),
    //    new LinkPersistInfo((BarItem) this.bsiTool),
    //    new LinkPersistInfo((BarItem) this.bsiReports),
    //    new LinkPersistInfo((BarItem) this.bsiManage),
    //    new LinkPersistInfo((BarItem) this.bsiMasterData),
    //    new LinkPersistInfo((BarItem) this.bsiThongSo),
    //    new LinkPersistInfo((BarItem) this.bsiAdmin),
    //    new LinkPersistInfo((BarItem) this.sbsTheme),
    //    new LinkPersistInfo((BarItem) this.bsiHelp),
    //    new LinkPersistInfo((BarItem) this.bsiRemind)
    //  });
    //  this.barMenu.OptionsBar.UseWholeRow = true;
    //  this.barMenu.Text = "Main menu";
    //  this.bsiSystem.Alignment = BarItemLinkAlignment.Right;
    //  this.bsiSystem.Caption = "Hệ Thống";
    //  this.bsiSystem.Id = 0;
    //  this.bsiSystem.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bsiSystem.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiSystem.LinksPersistInfo.AddRange(new LinkPersistInfo[6]
    //  {
    //    new LinkPersistInfo((BarItem) this.bbiLogin),
    //    new LinkPersistInfo((BarItem) this.bbiLogoff),
    //    new LinkPersistInfo((BarItem) this.bbiChangePass),
    //    new LinkPersistInfo((BarItem) this.bbiCloseTabs),
    //    new LinkPersistInfo((BarItem) this.bbiConfig),
    //    new LinkPersistInfo((BarItem) this.bbiExit)
    //  });
    //  this.bsiSystem.Name = "bsiSystem";
    //  this.bbiLogin.Caption = "Đăng Nhập";
    //  this.bbiLogin.Id = 8;
    //  this.bbiLogin.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiLogin.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiLogin.Name = "bbiLogin";
    //  this.bbiLogin.ItemClick += new ItemClickEventHandler(this.bbiLogin_ItemClick);
    //  this.bbiLogoff.Caption = "Đăng Xuất";
    //  this.bbiLogoff.Id = 9;
    //  this.bbiLogoff.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiLogoff.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiLogoff.Name = "bbiLogoff";
    //  this.bbiLogoff.ItemClick += new ItemClickEventHandler(this.bbiLogoff_ItemClick);
    //  this.bbiChangePass.Caption = "Thay Đổi Mật Khẩu";
    //  this.bbiChangePass.Id = 10;
    //  this.bbiChangePass.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiChangePass.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiChangePass.Name = "bbiChangePass";
    //  this.bbiChangePass.ItemClick += new ItemClickEventHandler(this.bbiChangePass_ItemClick);
    //  this.bbiCloseTabs.Caption = "Đóng Tất Cả Các Tab";
    //  this.bbiCloseTabs.Id = 11;
    //  this.bbiCloseTabs.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiCloseTabs.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiCloseTabs.Name = "bbiCloseTabs";
    //  this.bbiCloseTabs.ItemClick += new ItemClickEventHandler(this.bbiCloseTabs_ItemClick);
    //  this.bbiConfig.Caption = "Cấu Hình";
    //  this.bbiConfig.Id = 12;
    //  this.bbiConfig.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiConfig.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiConfig.Name = "bbiConfig";
    //  this.bbiConfig.ItemClick += new ItemClickEventHandler(this.bbiConfig_ItemClick);
    //  this.bbiExit.Caption = "Thoát";
    //  this.bbiExit.Id = 13;
    //  this.bbiExit.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiExit.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiExit.Name = "bbiExit";
    //  this.bbiExit.ItemClick += new ItemClickEventHandler(this.bbiExit_ItemClick);
    //  this.bsiTool.Alignment = BarItemLinkAlignment.Right;
    //  this.bsiTool.Caption = "VACM";
    //  this.bsiTool.Id = 4;
    //  this.bsiTool.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bsiTool.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiTool.LinksPersistInfo.AddRange(new LinkPersistInfo[2]
    //  {
    //    new LinkPersistInfo((BarItem) this.bbiVanHanh),
    //    new LinkPersistInfo((BarItem) this.bbiConfigPrint)
    //  });
    //  this.bsiTool.Name = "bsiTool";
    //  this.bbiVanHanh.Caption = "Màn Hình Vận Hành";
    //  this.bbiVanHanh.Id = 27;
    //  this.bbiVanHanh.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiVanHanh.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiVanHanh.Name = "bbiVanHanh";
    //  this.bbiVanHanh.ItemClick += new ItemClickEventHandler(this.bbiTronOnline_ItemClick);
    //  this.bbiConfigPrint.Caption = "Phiếu In";
    //  this.bbiConfigPrint.Id = 78;
    //  this.bbiConfigPrint.ItemAppearance.Normal.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiConfigPrint.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiConfigPrint.Name = "bbiConfigPrint";
    //  this.bbiConfigPrint.ItemClick += new ItemClickEventHandler(this.bbiPhieuIn_ItemClick);
    //  this.bsiReports.Alignment = BarItemLinkAlignment.Right;
    //  this.bsiReports.Caption = "Báo Cáo";
    //  this.bsiReports.Id = 58;
    //  this.bsiReports.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bsiReports.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiReports.LinksPersistInfo.AddRange(new LinkPersistInfo[6]
    //  {
    //    new LinkPersistInfo((BarItem) this.bbiChiTietMeTron),
    //    new LinkPersistInfo((BarItem) this.bbiTongKhoiLuongBeTong),
    //    new LinkPersistInfo((BarItem) this.bbiChiTietTongKhoiLuongBeTong),
    //    new LinkPersistInfo((BarItem) this.bbiTongVatTu),
    //    new LinkPersistInfo((BarItem) this.bbiChiTietChuyenXe),
    //    new LinkPersistInfo((BarItem) this.bbiChiTietTaiXe)
    //  });
    //  this.bsiReports.Name = "bsiReports";
    //  this.bbiChiTietMeTron.Caption = "Chi tiết mẻ trộn";
    //  this.bbiChiTietMeTron.Id = 65;
    //  this.bbiChiTietMeTron.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiChiTietMeTron.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiChiTietMeTron.Name = "bbiChiTietMeTron";
    //  this.bbiChiTietMeTron.ItemClick += new ItemClickEventHandler(this.bbiChiTietMeTron_ItemClick);
    //  this.bbiTongKhoiLuongBeTong.Caption = "Tổng khối lương bê tông";
    //  this.bbiTongKhoiLuongBeTong.Id = 63;
    //  this.bbiTongKhoiLuongBeTong.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiTongKhoiLuongBeTong.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiTongKhoiLuongBeTong.Name = "bbiTongKhoiLuongBeTong";
    //  this.bbiTongKhoiLuongBeTong.ItemClick += new ItemClickEventHandler(this.bbiTongKhoiLuongBeTong_ItemClick);
    //  this.bbiChiTietTongKhoiLuongBeTong.Caption = "Chi tiết khối lượng bê tông";
    //  this.bbiChiTietTongKhoiLuongBeTong.Id = 66;
    //  this.bbiChiTietTongKhoiLuongBeTong.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiChiTietTongKhoiLuongBeTong.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiChiTietTongKhoiLuongBeTong.Name = "bbiChiTietTongKhoiLuongBeTong";
    //  this.bbiChiTietTongKhoiLuongBeTong.Visibility = BarItemVisibility.Never;
    //  this.bbiChiTietTongKhoiLuongBeTong.VisibleInSearchMenu = false;
    //  this.bbiChiTietTongKhoiLuongBeTong.ItemClick += new ItemClickEventHandler(this.bbiChiTietTongKhoiLuongBeTong_ItemClick);
    //  this.bbiTongVatTu.Caption = "Tổng vật tư";
    //  this.bbiTongVatTu.Id = 62;
    //  this.bbiTongVatTu.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiTongVatTu.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiTongVatTu.Name = "bbiTongVatTu";
    //  this.bbiTongVatTu.Visibility = BarItemVisibility.Never;
    //  this.bbiTongVatTu.VisibleInSearchMenu = false;
    //  this.bbiTongVatTu.ItemClick += new ItemClickEventHandler(this.bbiTongVatTu_ItemClick);
    //  this.bbiChiTietChuyenXe.Caption = "Tổng chuyến xe";
    //  this.bbiChiTietChuyenXe.Id = 64;
    //  this.bbiChiTietChuyenXe.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiChiTietChuyenXe.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiChiTietChuyenXe.Name = "bbiChiTietChuyenXe";
    //  this.bbiChiTietChuyenXe.Visibility = BarItemVisibility.Never;
    //  this.bbiChiTietChuyenXe.VisibleInSearchMenu = false;
    //  this.bbiChiTietChuyenXe.ItemClick += new ItemClickEventHandler(this.bbiChiTietChuyenXe_ItemClick);
    //  this.bbiChiTietTaiXe.Caption = "Chi tiết tài xế";
    //  this.bbiChiTietTaiXe.Id = 73;
    //  this.bbiChiTietTaiXe.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiChiTietTaiXe.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiChiTietTaiXe.Name = "bbiChiTietTaiXe";
    //  this.bbiChiTietTaiXe.Visibility = BarItemVisibility.Never;
    //  this.bbiChiTietTaiXe.VisibleInSearchMenu = false;
    //  this.bbiChiTietTaiXe.ItemClick += new ItemClickEventHandler(this.bbiChiTietTaiXe_ItemClick);
    //  this.bsiManage.Alignment = BarItemLinkAlignment.Right;
    //  this.bsiManage.Caption = "Quản Lý";
    //  this.bsiManage.Id = 1;
    //  this.bsiManage.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bsiManage.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiManage.LinksPersistInfo.AddRange(new LinkPersistInfo[2]
    //  {
    //    new LinkPersistInfo((BarItem) this.bbiContract),
    //    new LinkPersistInfo((BarItem) this.bbiPhieuTron)
    //  });
    //  this.bsiManage.Name = "bsiManage";
    //  this.bbiContract.Caption = "Hợp Đồng";
    //  this.bbiContract.Id = 14;
    //  this.bbiContract.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiContract.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiContract.Name = "bbiContract";
    //  this.bbiContract.ItemClick += new ItemClickEventHandler(this.bbiContract_ItemClick);
    //  this.bbiPhieuTron.Caption = "Phiếu Trộn";
    //  this.bbiPhieuTron.Id = 15;
    //  this.bbiPhieuTron.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiPhieuTron.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiPhieuTron.Name = "bbiPhieuTron";
    //  this.bbiPhieuTron.ItemClick += new ItemClickEventHandler(this.bbiPhieuTron_ItemClick);
    //  this.bsiMasterData.Alignment = BarItemLinkAlignment.Right;
    //  this.bsiMasterData.Caption = "Danh Mục";
    //  this.bsiMasterData.Id = 3;
    //  this.bsiMasterData.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bsiMasterData.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiMasterData.LinksPersistInfo.AddRange(new LinkPersistInfo[9]
    //  {
    //    new LinkPersistInfo((BarItem) this.bbiCustomer),
    //    new LinkPersistInfo((BarItem) this.bbiJobSite),
    //    new LinkPersistInfo((BarItem) this.bbiHangMuc),
    //    new LinkPersistInfo((BarItem) this.bbiMac),
    //    new LinkPersistInfo((BarItem) this.bbiGroupSilo),
    //    new LinkPersistInfo((BarItem) this.bbiMaterial),
    //    new LinkPersistInfo((BarItem) this.bbiDriver),
    //    new LinkPersistInfo((BarItem) this.bbiXe),
    //    new LinkPersistInfo((BarItem) this.bbiNhanVien)
    //  });
    //  this.bsiMasterData.Name = "bsiMasterData";
    //  this.bbiCustomer.Caption = "Khách Hàng";
    //  this.bbiCustomer.Id = 20;
    //  this.bbiCustomer.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiCustomer.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiCustomer.Name = "bbiCustomer";
    //  this.bbiCustomer.ItemClick += new ItemClickEventHandler(this.bbiCustomer_ItemClick);
    //  this.bbiJobSite.Caption = "Công Trường";
    //  this.bbiJobSite.Id = 21;
    //  this.bbiJobSite.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiJobSite.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiJobSite.Name = "bbiJobSite";
    //  this.bbiJobSite.ItemClick += new ItemClickEventHandler(this.bbiJobSite_ItemClick);
    //  this.bbiHangMuc.Caption = "Hạng Mục";
    //  this.bbiHangMuc.Id = 70;
    //  this.bbiHangMuc.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiHangMuc.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiHangMuc.Name = "bbiHangMuc";
    //  this.bbiHangMuc.Visibility = BarItemVisibility.Never;
    //  this.bbiHangMuc.VisibleInSearchMenu = false;
    //  this.bbiHangMuc.ItemClick += new ItemClickEventHandler(this.bbiHangMuc_ItemClick);
    //  this.bbiMac.Caption = "MAC";
    //  this.bbiMac.Id = 24;
    //  this.bbiMac.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiMac.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiMac.Name = "bbiMac";
    //  this.bbiMac.ItemClick += new ItemClickEventHandler(this.bbiMac_ItemClick);
    //  this.bbiGroupSilo.Caption = "Nhóm Silo";
    //  this.bbiGroupSilo.Id = 25;
    //  this.bbiGroupSilo.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiGroupSilo.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiGroupSilo.Name = "bbiGroupSilo";
    //  this.bbiGroupSilo.Visibility = BarItemVisibility.Never;
    //  this.bbiGroupSilo.VisibleInSearchMenu = false;
    //  this.bbiGroupSilo.ItemClick += new ItemClickEventHandler(this.bbiGroupSilo_ItemClick);
    //  this.bbiMaterial.Caption = "Vật Tư";
    //  this.bbiMaterial.Id = 26;
    //  this.bbiMaterial.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiMaterial.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiMaterial.Name = "bbiMaterial";
    //  this.bbiMaterial.ItemClick += new ItemClickEventHandler(this.bbiMaterial_ItemClick);
    //  this.bbiDriver.Caption = "Tài Xế";
    //  this.bbiDriver.Id = 22;
    //  this.bbiDriver.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiDriver.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiDriver.Name = "bbiDriver";
    //  this.bbiDriver.ItemClick += new ItemClickEventHandler(this.bbiDriver_ItemClick);
    //  this.bbiXe.Caption = "Xe";
    //  this.bbiXe.Id = 23;
    //  this.bbiXe.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiXe.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiXe.Name = "bbiXe";
    //  this.bbiXe.ItemClick += new ItemClickEventHandler(this.bbiXe_ItemClick);
    //  this.bbiNhanVien.Caption = "Nhân Viên";
    //  this.bbiNhanVien.Id = 69;
    //  this.bbiNhanVien.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiNhanVien.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiNhanVien.Name = "bbiNhanVien";
    //  this.bbiNhanVien.Visibility = BarItemVisibility.Never;
    //  this.bbiNhanVien.ItemClick += new ItemClickEventHandler(this.bbiNhanVien_ItemClick);
    //  this.bsiThongSo.Alignment = BarItemLinkAlignment.Right;
    //  this.bsiThongSo.Caption = "Thông Số";
    //  this.bsiThongSo.Id = 2;
    //  this.bsiThongSo.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bsiThongSo.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiThongSo.LinksPersistInfo.AddRange(new LinkPersistInfo[6]
    //  {
    //    new LinkPersistInfo((BarItem) this.bbiSilo),
    //    new LinkPersistInfo((BarItem) this.bbiWeigh),
    //    new LinkPersistInfo((BarItem) this.bbiTimerPara),
    //    new LinkPersistInfo((BarItem) this.bbiDoAmAgg),
    //    new LinkPersistInfo((BarItem) this.bbiCongThucDoHutNuoc),
    //    new LinkPersistInfo((BarItem) this.bbiKiemDinhCan)
    //  });
    //  this.bsiThongSo.Name = "bsiThongSo";
    //  this.bbiSilo.Caption = "Thông Số Silo";
    //  this.bbiSilo.Id = 16;
    //  this.bbiSilo.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiSilo.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiSilo.Name = "bbiSilo";
    //  this.bbiSilo.ItemClick += new ItemClickEventHandler(this.bbiSilo_ItemClick);
    //  this.bbiWeigh.Caption = "Thông Số Cân";
    //  this.bbiWeigh.Id = 35;
    //  this.bbiWeigh.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiWeigh.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiWeigh.Name = "bbiWeigh";
    //  this.bbiWeigh.ItemClick += new ItemClickEventHandler(this.bbiWeigh_ItemClick);
    //  this.bbiTimerPara.Caption = "Thông Số Thời Gian";
    //  this.bbiTimerPara.Id = 36;
    //  this.bbiTimerPara.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiTimerPara.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiTimerPara.Name = "bbiTimerPara";
    //  this.bbiTimerPara.ItemClick += new ItemClickEventHandler(this.bbiTimerPara_ItemClick);
    //  this.bbiDoAmAgg.Caption = "Độ Hút Nước";
    //  this.bbiDoAmAgg.Id = 17;
    //  this.bbiDoAmAgg.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiDoAmAgg.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiDoAmAgg.Name = "bbiDoAmAgg";
    //  this.bbiDoAmAgg.Visibility = BarItemVisibility.Never;
    //  this.bbiDoAmAgg.ItemClick += new ItemClickEventHandler(this.bbiDoAmAgg_ItemClick);
    //  this.bbiCongThucDoHutNuoc.Caption = "Công Thức Tính Độ Hút Nước";
    //  this.bbiCongThucDoHutNuoc.Id = 18;
    //  this.bbiCongThucDoHutNuoc.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiCongThucDoHutNuoc.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiCongThucDoHutNuoc.Name = "bbiCongThucDoHutNuoc";
    //  this.bbiCongThucDoHutNuoc.Visibility = BarItemVisibility.Never;
    //  this.bbiCongThucDoHutNuoc.ItemClick += new ItemClickEventHandler(this.bbiCongThucDoHutNuoc_ItemClick);
    //  this.bbiKiemDinhCan.Caption = "Kiểm Định Cân";
    //  this.bbiKiemDinhCan.Id = 19;
    //  this.bbiKiemDinhCan.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiKiemDinhCan.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiKiemDinhCan.Name = "bbiKiemDinhCan";
    //  this.bbiKiemDinhCan.ItemClick += new ItemClickEventHandler(this.bbiKiemDinhCan_ItemClick);
    //  this.bsiAdmin.Alignment = BarItemLinkAlignment.Right;
    //  this.bsiAdmin.Caption = "Phân Quyền";
    //  this.bsiAdmin.Id = 5;
    //  this.bsiAdmin.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bsiAdmin.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiAdmin.LinksPersistInfo.AddRange(new LinkPersistInfo[4]
    //  {
    //    new LinkPersistInfo((BarItem) this.bbiUser),
    //    new LinkPersistInfo((BarItem) this.bbiRole),
    //    new LinkPersistInfo((BarItem) this.bbiRoleAssign),
    //    new LinkPersistInfo((BarItem) this.bbiFunctionAssign)
    //  });
    //  this.bsiAdmin.Name = "bsiAdmin";
    //  this.bbiUser.Caption = "Người Dùng";
    //  this.bbiUser.Id = 29;
    //  this.bbiUser.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bbiUser.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiUser.Name = "bbiUser";
    //  this.bbiUser.ItemClick += new ItemClickEventHandler(this.bbiUser_ItemClick);
    //  this.bbiRole.Caption = "Vai Trò";
    //  this.bbiRole.Id = 30;
    //  this.bbiRole.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bbiRole.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiRole.Name = "bbiRole";
    //  this.bbiRole.ItemClick += new ItemClickEventHandler(this.bbiRole_ItemClick);
    //  this.bbiRoleAssign.Caption = "Gán Vai Trò";
    //  this.bbiRoleAssign.Id = 31;
    //  this.bbiRoleAssign.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bbiRoleAssign.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiRoleAssign.Name = "bbiRoleAssign";
    //  this.bbiRoleAssign.ItemClick += new ItemClickEventHandler(this.bbiRoleAssign_ItemClick);
    //  this.bbiFunctionAssign.Caption = "Gán Chức Năng";
    //  this.bbiFunctionAssign.Id = 32;
    //  this.bbiFunctionAssign.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bbiFunctionAssign.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiFunctionAssign.Name = "bbiFunctionAssign";
    //  this.bbiFunctionAssign.ItemClick += new ItemClickEventHandler(this.bbiFunctionAssign_ItemClick);
    //  this.sbsTheme.Alignment = BarItemLinkAlignment.Right;
    //  this.sbsTheme.Caption = "Giao Diện";
    //  this.sbsTheme.Id = 7;
    //  this.sbsTheme.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.sbsTheme.ItemAppearance.Normal.Options.UseFont = true;
    //  this.sbsTheme.Name = "sbsTheme";
    //  this.sbsTheme.Visibility = BarItemVisibility.Never;
    //  this.sbsTheme.VisibleInSearchMenu = false;
    //  this.bsiHelp.Alignment = BarItemLinkAlignment.Right;
    //  this.bsiHelp.Caption = "Trợ Giúp";
    //  this.bsiHelp.Id = 6;
    //  this.bsiHelp.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bsiHelp.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiHelp.LinksPersistInfo.AddRange(new LinkPersistInfo[4]
    //  {
    //    new LinkPersistInfo((BarItem) this.bbiAbout),
    //    new LinkPersistInfo((BarItem) this.bbiUserGuide),
    //    new LinkPersistInfo((BarItem) this.bbiConfigUI),
    //    new LinkPersistInfo((BarItem) this.bbiConfigPrint1)
    //  });
    //  this.bsiHelp.Name = "bsiHelp";
    //  this.bsiHelp.Visibility = BarItemVisibility.Never;
    //  this.bsiHelp.VisibleInSearchMenu = false;
    //  this.bbiAbout.Caption = "Về Chúng Tôi";
    //  this.bbiAbout.Id = 33;
    //  this.bbiAbout.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bbiAbout.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiAbout.Name = "bbiAbout";
    //  this.bbiUserGuide.Caption = "Hướng Dẫn";
    //  this.bbiUserGuide.Id = 34;
    //  this.bbiUserGuide.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bbiUserGuide.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiUserGuide.Name = "bbiUserGuide";
    //  this.bbiConfigUI.Caption = "Tuỳ Chỉnh Giao Diện";
    //  this.bbiConfigUI.Id = 57;
    //  this.bbiConfigUI.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.bbiConfigUI.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiConfigUI.Name = "bbiConfigUI";
    //  this.bbiConfigUI.ItemClick += new ItemClickEventHandler(this.bbiConfigUI_ItemClick);
    //  this.bbiConfigPrint1.Caption = "Tuỳ Chỉnh Phiếu In";
    //  this.bbiConfigPrint1.Id = 61;
    //  this.bbiConfigPrint1.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiConfigPrint1.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiConfigPrint1.Name = "bbiConfigPrint1";
    //  this.bbiConfigPrint1.ItemClick += new ItemClickEventHandler(this.bbiPrint_ItemClick);
    //  this.bsiRemind.Caption = ".";
    //  this.bsiRemind.Id = 76;
    //  this.bsiRemind.ItemAppearance.Normal.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.bsiRemind.ItemAppearance.Normal.ForeColor = Color.Red;
    //  this.bsiRemind.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiRemind.ItemAppearance.Normal.Options.UseForeColor = true;
    //  this.bsiRemind.Name = "bsiRemind";
    //  this.bsiRemind.Visibility = BarItemVisibility.Never;
    //  this.bsiRemind.VisibleInSearchMenu = false;
    //  this.bar3.BarName = "Status bar";
    //  this.bar3.CanDockStyle = BarCanDockStyle.Bottom;
    //  this.bar3.DockCol = 0;
    //  this.bar3.DockRow = 0;
    //  this.bar3.DockStyle = BarDockStyle.Bottom;
    //  this.bar3.LinksPersistInfo.AddRange(new LinkPersistInfo[4]
    //  {
    //    new LinkPersistInfo((BarItem) this.bbiLogoProduct),
    //    new LinkPersistInfo((BarItem) this.barButtonItem2),
    //    new LinkPersistInfo((BarItem) this.bbiConnectPLC),
    //    new LinkPersistInfo((BarItem) this.barStaticItem4)
    //  });
    //  this.bar3.OptionsBar.AllowQuickCustomization = false;
    //  this.bar3.OptionsBar.DrawDragBorder = false;
    //  this.bar3.OptionsBar.UseWholeRow = true;
    //  this.bar3.Text = "Status bar";
    //  this.bbiLogoProduct.Alignment = BarItemLinkAlignment.Left;
    //  this.bbiLogoProduct.AllowRightClickInMenu = false;
    //  this.bbiLogoProduct.Caption = "bbiLogo";
    //  this.bbiLogoProduct.Id = 55;
    //  this.bbiLogoProduct.Name = "bbiLogoProduct";
    //  this.bbiLogoProduct.PaintStyle = BarItemPaintStyle.CaptionInMenu;
    //  this.bbiLogoProduct.Size = new Size(0, 30);
    //  this.bbiLogoProduct.Visibility = BarItemVisibility.Never;
    //  this.bbiLogoProduct.VisibleInSearchMenu = false;
    //  this.barButtonItem2.Id = 53;
    //  this.barButtonItem2.Name = "barButtonItem2";
    //  this.bbiConnectPLC.Alignment = BarItemLinkAlignment.Right;
    //  this.bbiConnectPLC.Caption = "PLC";
    //  this.bbiConnectPLC.Id = 54;
    //  this.bbiConnectPLC.ImageOptions.Image = (Image) ResourceNhua.DisCoPLC;
    //  this.bbiConnectPLC.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.bbiConnectPLC.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiConnectPLC.Name = "bbiConnectPLC";
    //  this.bbiConnectPLC.PaintStyle = BarItemPaintStyle.CaptionGlyph;
    //  this.bbiConnectPLC.Size = new Size(0, 32);
    //  this.barStaticItem4.Caption = ".";
    //  this.barStaticItem4.Id = 75;
    //  this.barStaticItem4.ItemAppearance.Normal.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.barStaticItem4.ItemAppearance.Normal.Options.UseFont = true;
    //  this.barStaticItem4.Name = "barStaticItem4";
    //  this.barStaticItem4.Visibility = BarItemVisibility.Never;
    //  this.barDockControlTop.CausesValidation = false;
    //  this.barDockControlTop.Dock = DockStyle.Top;
    //  this.barDockControlTop.Location = new Point(0, 0);
    //  this.barDockControlTop.Manager = this.barManager1;
    //  this.barDockControlTop.Size = new Size(1225, 25);
    //  this.barDockControlBottom.CausesValidation = false;
    //  this.barDockControlBottom.Dock = DockStyle.Bottom;
    //  this.barDockControlBottom.Location = new Point(0, 545);
    //  this.barDockControlBottom.Manager = this.barManager1;
    //  this.barDockControlBottom.Size = new Size(1225, 35);
    //  this.barDockControlLeft.CausesValidation = false;
    //  this.barDockControlLeft.Dock = DockStyle.Left;
    //  this.barDockControlLeft.Location = new Point(0, 25);
    //  this.barDockControlLeft.Manager = this.barManager1;
    //  this.barDockControlLeft.Size = new Size(0, 520);
    //  this.barDockControlRight.CausesValidation = false;
    //  this.barDockControlRight.Dock = DockStyle.Right;
    //  this.barDockControlRight.Location = new Point(1225, 25);
    //  this.barDockControlRight.Manager = this.barManager1;
    //  this.barDockControlRight.Size = new Size(0, 520);
    //  this.bbiReport.Caption = "Báo Cáo";
    //  this.bbiReport.Id = 28;
    //  this.bbiReport.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bbiReport.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bbiReport.Name = "bbiReport";
    //  this.barSubItem1.Caption = "Công ty TNHH Kỹ Thuật và Công Nghệ Nam Đại Phát";
    //  this.barSubItem1.Id = 37;
    //  this.barSubItem1.ItemAppearance.Normal.Font = new Font("Tahoma", 7.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.barSubItem1.ItemAppearance.Normal.Options.UseFont = true;
    //  this.barSubItem1.Name = "barSubItem1";
    //  this.bsiWebProduct.AllowHtmlText = DefaultBoolean.True;
    //  this.bsiWebProduct.Caption = "namdaiphat.vn";
    //  this.bsiWebProduct.Id = 38;
    //  this.bsiWebProduct.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.bsiWebProduct.ItemAppearance.Normal.ForeColor = Color.Blue;
    //  this.bsiWebProduct.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiWebProduct.ItemAppearance.Normal.Options.UseForeColor = true;
    //  this.bsiWebProduct.Name = "bsiWebProduct";
    //  this.bsiPhoneProduct.Caption = "Liên hệ: 0901.922.262 - 0902.300.072\r\n";
    //  this.bsiPhoneProduct.Id = 39;
    //  this.bsiPhoneProduct.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.bsiPhoneProduct.ItemAppearance.Normal.ForeColor = Color.Red;
    //  this.bsiPhoneProduct.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiPhoneProduct.ItemAppearance.Normal.Options.UseForeColor = true;
    //  this.bsiPhoneProduct.Name = "bsiPhoneProduct";
    //  this.bsiNameProduct.Caption = "CÔNG TY TNHH CƠ ĐIỆN , XÂY DỰNG VÀ CẢNH QUAN  157";
    //  this.bsiNameProduct.Id = 40;
    //  this.bsiNameProduct.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    //  this.bsiNameProduct.ItemAppearance.Normal.Options.UseFont = true;
    //  this.bsiNameProduct.Name = "bsiNameProduct";
    //  this.barEditItem1.Edit = (RepositoryItem) null;
    //  this.barEditItem1.Id = 50;
    //  this.barEditItem1.Name = "barEditItem1";
    //  this.barEditItem2.Edit = (RepositoryItem) null;
    //  this.barEditItem2.Id = 51;
    //  this.barEditItem2.Name = "barEditItem2";
    //  this.barEditItem3.Edit = (RepositoryItem) null;
    //  this.barEditItem3.Id = 52;
    //  this.barEditItem3.Name = "barEditItem3";
    //  this.barButtonItem1.Alignment = BarItemLinkAlignment.Right;
    //  this.barButtonItem1.Caption = "Đã kết nối";
    //  this.barButtonItem1.ContentHorizontalAlignment = BarItemContentAlignment.Near;
    //  this.barButtonItem1.Id = 45;
    //  this.barButtonItem1.ImageOptions.Image = (Image) ResourceNhua.CoPLC;
    //  this.barButtonItem1.ImageToTextAlignment = BarItemImageToTextAlignment.AfterText;
    //  this.barButtonItem1.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
    //  this.barButtonItem1.Name = "barButtonItem1";
    //  this.barButtonItem1.PaintStyle = BarItemPaintStyle.CaptionGlyph;
    //  this.barButtonItem1.Size = new Size(0, 26);
    //  this.barButtonItem3.Caption = "barButtonItem3";
    //  this.barButtonItem3.Id = 47;
    //  this.barButtonItem3.Name = "barButtonItem3";
    //  this.barButtonItem4.Caption = "barButtonItem4";
    //  this.barButtonItem4.Id = 48;
    //  this.barButtonItem4.Name = "barButtonItem4";
    //  this.barButtonItem5.Caption = "barButtonItem5";
    //  this.barButtonItem5.Id = 49;
    //  this.barButtonItem5.ImageOptions.Image = (Image) ResourceNhua.CoPLC;
    //  this.barButtonItem5.Name = "barButtonItem5";
    //  this.barButtonItem5.PaintStyle = BarItemPaintStyle.CaptionGlyph;
    //  this.barLinkContainerItem1.Caption = "barLinkContainerItem1";
    //  this.barLinkContainerItem1.Id = 56;
    //  this.barLinkContainerItem1.Name = "barLinkContainerItem1";
    //  this.barLinkContainerItem1.ShortcutKeyDisplayString = "https://namdaiphat.vn/";
    //  this.barButtonItem7.Caption = "Dữ liệu trộn";
    //  this.barButtonItem7.Id = 59;
    //  this.barButtonItem7.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f);
    //  this.barButtonItem7.ItemAppearance.Normal.Options.UseFont = true;
    //  this.barButtonItem7.Name = "barButtonItem7";
    //  this.barButtonItem7.Visibility = BarItemVisibility.Never;
    //  this.barButtonItem7.ItemClick += new ItemClickEventHandler(this.barButtonItem7_ItemClick);
    //  this.barButtonItem8.Caption = "Chi tiết phiếu trộn";
    //  this.barButtonItem8.Id = 60;
    //  this.barButtonItem8.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.barButtonItem8.ItemAppearance.Normal.Options.UseFont = true;
    //  this.barButtonItem8.Name = "barButtonItem8";
    //  this.barButtonItem8.Visibility = BarItemVisibility.Never;
    //  this.barButtonItem8.ItemClick += new ItemClickEventHandler(this.barButtonItem8_ItemClick);
    //  this.barButtonItem9.Caption = "Phiếu In";
    //  this.barButtonItem9.Id = 67;
    //  this.barButtonItem9.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.barButtonItem9.ItemAppearance.Normal.Options.UseFont = true;
    //  this.barButtonItem9.Name = "barButtonItem9";
    //  this.barButtonItem9.Visibility = BarItemVisibility.Never;
    //  this.barButtonItem10.Caption = "Sample";
    //  this.barButtonItem10.Id = 68;
    //  this.barButtonItem10.Name = "barButtonItem10";
    //  this.barButtonItem10.Visibility = BarItemVisibility.Never;
    //  this.barButtonItem10.ItemClick += new ItemClickEventHandler(this.barButtonItem10_ItemClick);
    //  this.barButtonItem13.Caption = "Templ";
    //  this.barButtonItem13.Id = 71;
    //  this.barButtonItem13.Name = "barButtonItem13";
    //  this.barButtonItem13.Visibility = BarItemVisibility.Never;
    //  this.barButtonItem13.ItemClick += new ItemClickEventHandler(this.barButtonItem13_ItemClick);
    //  this.barButtonItem14.Caption = "Chi tiết tài xế";
    //  this.barButtonItem14.Id = 72;
    //  this.barButtonItem14.ItemAppearance.Normal.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.barButtonItem14.ItemAppearance.Normal.Options.UseFont = true;
    //  this.barButtonItem14.ItemInMenuAppearance.Normal.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.barButtonItem14.ItemInMenuAppearance.Normal.Options.UseFont = true;
    //  this.barButtonItem14.Name = "barButtonItem14";
    //  this.barHeaderItem1.Caption = ".";
    //  this.barHeaderItem1.Id = 74;
    //  this.barHeaderItem1.Name = "barHeaderItem1";
    //  this.barSubItem2.Caption = "Phiếu In";
    //  this.barSubItem2.Id = 77;
    //  this.barSubItem2.Name = "barSubItem2";
    //  this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
    //  this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
    //  this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
    //  this.xtraTabbedMdiManager1.MdiParent = (Form) this;
    //  this.timer.Enabled = true;
    //  this.timer.Interval = 1000;
    //  this.timer.Tick += new EventHandler(this.timer_Tick);
    //  this.AutoScaleDimensions = new SizeF(6f, 13f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(1225, 580);
    //  this.Controls.Add((Control) this.barDockControlLeft);
    //  this.Controls.Add((Control) this.barDockControlRight);
    //  this.Controls.Add((Control) this.barDockControlBottom);
    //  this.Controls.Add((Control) this.barDockControlTop);
    //  this.IconOptions.Image = (Image) ResourceNhua.logoV_64;
    //  this.IsMdiContainer = true;
    //  this.Name = nameof (FrmMain);
    //  this.StartPosition = FormStartPosition.CenterScreen;
    //  this.Text = "VACM";
    //  this.WindowState = FormWindowState.Maximized;
    //  this.FormClosing += new FormClosingEventHandler(this.FrmMain_FormClosing);
    //  this.FormClosed += new FormClosedEventHandler(this.FrmMain_FormClosed);
    //  this.Load += new EventHandler(this.FrmMain_Load);
    //  this.Shown += new EventHandler(this.FrmMain_Shown);
    //  this.KeyDown += new KeyEventHandler(this.FrmMain_KeyDown);
    //  this.barManager1.EndInit();
    //  this.repositoryItemPictureEdit1.EndInit();
    //  this.repositoryItemImageEdit1.EndInit();
    //  this.repositoryItemPictureEdit2.EndInit();
    //  ((ISupportInitialize) this.xtraTabbedMdiManager1).EndInit();
    //  this.ResumeLayout(false);
    //  this.PerformLayout();
    //}
  }
}

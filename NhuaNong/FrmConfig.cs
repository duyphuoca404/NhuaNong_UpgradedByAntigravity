// Decompiled with JetBrains decompiler
// Type: NhuaNong.FrmConfig
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;
using NhuaNong.PLCMapping;
using NhuaNong.PLCModule;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public class FrmConfig : DialogViewBase
  {
    private bool _isRestarting;
    private bool _configError;
    private IContainer components;
    private PanelControl panelControl1;
    private SimpleButton btnCancel;
    private SimpleButton btnOk;
    private XtraTabControl tabConfig;
    private XtraTabPage tpgCompanyInfo;
    private XtraTabPage tpgRunningMode;
    private GroupControl grpStandAlone;
    private XtraTabPage tpgOptions;
    private XtraTabPage tpgGeneral;
    private LookUpEdit lueRunningMode;
    private GroupControl grpService;
    private TextEdit txtServerIP;
    private LabelControl lblEndpointAddress;
    private LabelControl lblRunningMode;
    private LabelControl lblAddress;
    private LabelControl lblCompanyName;
    private TextEdit txtDienThoaiCty;
    private TextEdit txtDiaChiCty;
    private TextEdit txtTenCty;
    private LabelControl lblPhone;
    private XtraTabControl xtraTabControl1;
    private XtraTabPage tpgRange;
    private XtraTabPage tpgFilter;
    private XtraTabPage tpgOthers;
    private CheckEdit chkTinhBuTru;
    private SimpleButton btnReportPathBrowse;
    private SimpleButton btnTestReportPath;
    private LabelControl lblReportPath;
    private CheckEdit chkTronOnline;
    private SpinEdit spnLatestHopDongDays;
    private SpinEdit spnLatestPhieuTronDays;
    private LabelControl lblLatestDay2;
    private LabelControl lblLatestDay;
    private LabelControl lblPhieuTron;
    private LabelControl lblContract;
    private LabelControl lblKLTronLonNhat;
    private LabelControl lblKLTronNhoNhat;
    private LabelControl lblKLChoLonNhat;
    private SpinEdit spnKLTronLonNhat;
    private SpinEdit spnKLTronNhoNhat;
    private SpinEdit spnKLChoLonNhat;
    private RadioGroup rdgLanguageRes;
    private LabelControl lblLanguage;
    private TextEdit txtLANPort;
    private TextEdit txtLANIP;
    private LabelControl labelControl4;
    private LabelControl lblIP;
    private TextEdit txtPLCPort;
    private SimpleButton btnTestPort;
    private SimpleButton btnChangePLCPort;
    private LabelControl labelControl1;
    private LookUpEdit lueLanguages;
    private LabelControl labelControl2;
    private SimpleButton btnLoadImage;
    private PictureEdit pictureEdit1;
    private LabelControl labelControl3;
    private SimpleButton simpleButton1;
    private ButtonEdit bteLogoPath;
    private TextEdit txtPassword;
    private TextEdit txtUsername;
    private TextEdit txtDatabase;
    private TextEdit txtServer;
    private LabelControl lblPassword;
    private LabelControl lblUsername;
    private LabelControl lblDatabase;
    private LabelControl lblServerName;
    private SpinEdit spnLatestBaoCaoDays;
    private LabelControl labelControl5;
    private LabelControl labelControl6;
    private LabelControl labelControl7;
    private CheckEdit chkDev;
    private XtraTabPage xtraTabPage1;
    private LabelControl labelControl8;
    private ButtonEdit beFilePathPLC;
    private SimpleButton btnUploadToPLC;
    private ButtonEdit bteImportPath_GH;
    private ButtonEdit bteExportPath;
    private ButtonEdit bteImportPath_CT;
    private ButtonEdit btePdfReaderPath;
    private LabelControl labelControl9;
    private SimpleButton simpleButton2;
    private SimpleButton simpleButton3;

    public bool IsApplicationRestarting => this._isRestarting;

    protected override void PopulateData()
    {
      try
      {
        this.lueRunningMode.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.RunningMode>(false);
        this.lueRunningMode.EditValue = (object) ConfigManager.TramTronConfig.RunningMode;
        this.txtServerIP.Text = ConfigManager.TramTronConfig.ServerIP;
        this.txtServer.Text = ".";
        this.txtDatabase.Text = ConfigManager.ServiceConfig.DatabaseName;
        this.txtUsername.Text = ConfigManager.ServiceConfig.UserID;
        this.txtPassword.Text = ConfigManager.ServiceConfig.Password;
        this.txtTenCty.Text = ConfigManager.TramTronConfig.TenCty;
        this.txtDiaChiCty.Text = ConfigManager.TramTronConfig.DiaChiCty;
        this.txtDienThoaiCty.Text = ConfigManager.TramTronConfig.DienThoaiCty;
        this.spnKLChoLonNhat.Value = ConfigManager.TramTronConfig.KLChoLonNhat;
        this.spnKLTronNhoNhat.Value = ConfigManager.TramTronConfig.KLTronNhoNhat;
        this.spnKLTronLonNhat.Value = ConfigManager.TramTronConfig.KLTronLonNhat;
        this.chkTronOnline.Checked = ConfigManager.TramTronConfig.ShowTronOnline;
        this.chkTinhBuTru.Checked = ConfigManager.TramTronConfig.TinhBuTru;
        this.spnLatestHopDongDays.EditValue = (object) ConfigManager.TramTronConfig.LatestHopDongDays;
        this.spnLatestPhieuTronDays.EditValue = (object) ConfigManager.TramTronConfig.LatestPhieuTronDays;
        this.spnLatestBaoCaoDays.EditValue = (object) ConfigManager.TramTronConfig.LatestBaoCaoDays;
        this.bteExportPath.Text = ConfigManager.TramTronConfig.ReportPath;
        this.bteImportPath_GH.Text = ConfigManager.TramTronConfig.PIPath;
        this.bteImportPath_CT.Text = ConfigManager.TramTronConfig.PICTPath;
        this.btePdfReaderPath.Text = ConfigManager.TramTronConfig.PdfReaderPath;
        this.rdgLanguageRes.SelectedIndex = ConfigManager.TramTronConfig.LanguageRes;
        this.lueLanguages.EditValue = (object) ConfigManager.TramTronConfig.LanguageRes;
        this.lueLanguages.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.LanguageRes>(false);
        this.txtPLCPort.Text = ConfigManager.TramTronConfig.SerialPort;
        this.txtLANIP.Text = ConfigManager.TramTronConfig.LANIP;
        this.txtLANPort.Text = ConfigManager.TramTronConfig.LANPort.ToString();
        this.bteLogoPath.Text = ConfigManager.TramTronConfig.LogoCty.ToString();
        this.chkDev.Checked = ConfigManager.TramTronConfig.DevEnv;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
        TramTronLogger.WriteError(ex);
      }
    }

    protected override void AdjustCulture()
    {
      try
      {
        this.Text = "Cấu hình";
      }
      catch (System.Exception ex)
      {
      }
    }

    public bool ValidateConnection(bool showMessage)
    {
      if ((int) this.lueRunningMode.EditValue == 0)
      {
        if (!this.ValidateDBConnection(showMessage))
          return false;
      }
      else if ((int) this.lueRunningMode.EditValue == 1 && !this.ValidateRemotingServerConnection(showMessage))
        return false;
      return true;
    }

    public bool ValidateDBConnection(bool showMessage) => true;

    public bool ValidateRemotingServerConnection(bool showMessage)
    {
      try
      {
        return true;
      }
      catch (WebException ex)
      {
        if (showMessage)
          TramTromMessageBox.ShowErrorDialog(string.Format("Không thể kết nối đến Server IP:{0}", (object) this.txtServerIP.Text));
        TramTronLogger.WriteError((System.Exception) ex);
        return false;
      }
      catch (System.Exception ex)
      {
        if (showMessage)
          TramTromMessageBox.ShowDEPErrorDialog(ex);
        TramTronLogger.WriteError(ex);
        return false;
      }
    }

    public FrmConfig() => this.InitializeComponent();

    private void FrmConfig_Load(object sender, EventArgs e) => this.EndPreventEvent();

    private static string GetMACAddress()
    {
      string macAddress = "";
      foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
      {
        if (networkInterface.NetworkInterfaceType != NetworkInterfaceType.Loopback && networkInterface.GetIPProperties().GetIPv4Properties().IsDhcpEnabled)
        {
          macAddress = networkInterface.GetPhysicalAddress().ToString();
          break;
        }
      }
      return macAddress;
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      try
      {
        if (!this.ValidateConnection(true))
        {
          this.tabConfig.SelectedTabPage = this.tpgRunningMode;
        }
        else
        {
          ConfigManager.TramTronConfig.RunningMode = 0;
          string machineName = Environment.MachineName;
          ConfigManager.ServiceConfig.ServerName = ".";
          switch (machineName)
          {
            case "DESKTOP-7KUDOEF":
              ConfigManager.ServiceConfig.ServerName = "DESKTOP-7KUDOEF";
              break;
            case "DESKTOP-S4RN2N9":
              ConfigManager.ServiceConfig.ServerName = "DESKTOP-S4RN2N9";
              break;
            case "ADMIN-PC":
              ConfigManager.ServiceConfig.ServerName = "ADMIN-PC";
              break;
          }
          if (ConfigManager.TramTronConfig.NgayTron_Stus)
            ConfigManager.ServiceConfig.ServerName = this.txtServer.Text;
          ConfigManager.ServiceConfig.DatabaseName = this.txtDatabase.Text;
          ConfigManager.ServiceConfig.UserID = this.txtUsername.Text;
          ConfigManager.ServiceConfig.Password = this.txtPassword.Text;
          ConfigManager.TramTronConfig.ServerIP = this.txtServerIP.Text;
          ConfigManager.TramTronConfig.TenCty = this.txtTenCty.Text;
          ConfigManager.TramTronConfig.DiaChiCty = this.txtDiaChiCty.Text;
          ConfigManager.TramTronConfig.DienThoaiCty = this.txtDienThoaiCty.Text;
          ConfigManager.TramTronConfig.KLChoLonNhat = this.spnKLChoLonNhat.Value;
          ConfigManager.TramTronConfig.KLTronNhoNhat = this.spnKLTronNhoNhat.Value;
          ConfigManager.TramTronConfig.KLTronLonNhat = this.spnKLTronLonNhat.Value;
          ConfigManager.TramTronConfig.TinhBuTru = this.chkTinhBuTru.Checked;
          ConfigManager.TramTronConfig.ShowTronOnline = this.chkTronOnline.Checked;
          ConfigManager.TramTronConfig.LatestHopDongDays = Convert.ToInt32(this.spnLatestHopDongDays.Value);
          ConfigManager.TramTronConfig.LatestPhieuTronDays = Convert.ToInt32(this.spnLatestPhieuTronDays.Value);
          ConfigManager.TramTronConfig.LatestBaoCaoDays = Convert.ToInt32(this.spnLatestBaoCaoDays.Value);
          ConfigManager.TramTronConfig.LANIP = this.txtLANIP.Text;
          ConfigManager.TramTronConfig.LANPort = Convert.ToInt32(this.txtLANPort.Text);
          ConfigManager.TramTronConfig.LogoCty = this.bteLogoPath.Text;
          ConfigManager.TramTronConfig.DevEnv = this.chkDev.Checked;
          ConfigManager.TramTronConfig.ReportPath = this.bteExportPath.Text;
          ConfigManager.TramTronConfig.PIPath = this.bteImportPath_GH.Text;
          ConfigManager.TramTronConfig.PICTPath = this.bteImportPath_CT.Text;
          ConfigManager.TramTronConfig.PdfReaderPath = this.btePdfReaderPath.Text;
          this.Close();
        }
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.Message);
      }
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    private void FrmConfig_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (this._isRestarting)
        return;
      this._configError = this.ValidateConnection(false);
    }

    private void rdgLanguageRes_EditValueChanging(object sender, ChangingEventArgs e)
    {
    }

    private void btnReportPathBrowse_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      int num = (int) folderBrowserDialog.ShowDialog();
      this.bteExportPath.Text = folderBrowserDialog.SelectedPath;
    }

    private void btnTestReportPath_Click(object sender, EventArgs e)
    {
      try
      {
        DirectoryMng.CreateDirectoryWithCheckExist(this.bteExportPath.Text);
        ConfigManager.TramTronConfig.ReportPath = this.bteExportPath.Text;
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowDEPErrorDialog(ex);
      }
    }

    private void btnChangePLCPort_Click(object sender, EventArgs e)
    {
      FrmPLCPort dlgView = new FrmPLCPort();
      ViewManager.ShowViewDialog((DialogViewBase) dlgView);
      if (dlgView.DialogResult != DialogResult.OK)
        return;
      this.txtPLCPort.Text = dlgView.PLCPortName;
      ConfigManager.TramTronConfig.SerialPort = this.txtPLCPort.Text;
    }

    private void btnTestPort_Click(object sender, EventArgs e)
    {
      (sender as SerialPort).ReadExisting();
      TramTromMessageBox.ShowMessageDialog("Test Success");
    }

    private void btnLoadImage_Click(object sender, EventArgs e)
    {
    }

    private void pictureEdit1_TextChanged(object sender, EventArgs e)
    {
    }

    private void pictureEdit1_LoadCompleted(object sender, EventArgs e)
    {
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
    }

    private void buttonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
      openFileDialog.Title = "Chọn hình ảnh";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.bteLogoPath.Text = openFileDialog.FileName;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show("Lỗi: " + ex.Message);
      }
    }

    private void bteLogoPath_EditValueChanged(object sender, EventArgs e)
    {
      if (!System.IO.File.Exists(this.bteLogoPath.Text))
        return;
      this.pictureEdit1.Image = Image.FromFile(this.bteLogoPath.Text);
      this.pictureEdit1.Properties.SizeMode = PictureSizeMode.Zoom;
      this.pictureEdit1.Properties.ShowZoomSubMenu = DefaultBoolean.True;
      this.pictureEdit1.Properties.SizeMode = PictureSizeMode.Squeeze;
    }

    private void beFilePath_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Step Files|*.s7p";
      openFileDialog.Title = "Chọn File";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.beFilePathPLC.Text = openFileDialog.FileName;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show("Lỗi: " + ex.Message);
      }
    }

    private void btnUploadToPLC_Click(object sender, EventArgs e)
    {
      PLCController plcController = new PLCController();
      if (plcController.IsConnected)
      {
        byte[] a1 = plcController.ReadBytes(S7.Net.DataType.DataBlock, 1, 0, 1000);
        byte[] numArray = System.IO.File.ReadAllBytes(this.beFilePathPLC.Text);
        byte[] a2 = numArray;
        if (!MappingHelper.ByteArraysEqual(a1, a2))
        {
          plcController.WriteBytes(S7.Net.DataType.DataBlock, 1, 0, numArray);
          TramTromMessageBox.ShowMessageDialog("PLC Upload thành công");
        }
        else
          TramTromMessageBox.ShowMessageDialog("PLC Upload thành công");
      }
      else
        TramTromMessageBox.ShowMessageDialog("PLC MẤT KẾT NỐI, VUI LÒNG KIỂM TRA LẠI KẾT NỐI");
    }

    private void bteExportPath_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
      folderBrowserDialog.Description = "Chọn Thư Mục";
      if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.bteExportPath.Text = folderBrowserDialog.SelectedPath;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show("Lỗi: " + ex.Message);
      }
    }

    private void bteImportPath_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Document File|*.docx";
      openFileDialog.Title = "Chọn File";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.bteImportPath_GH.Text = openFileDialog.FileName;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show("Lỗi: " + ex.Message);
      }
    }

    private void bteImportPath_CT_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Document File|*.docx";
      openFileDialog.Title = "Chọn File";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.bteImportPath_CT.Text = openFileDialog.FileName;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show("Lỗi: " + ex.Message);
      }
    }

    private void btePdfReaderPath_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Executable Files|*.exe";
      openFileDialog.Title = "Chọn Chương Trình Mở File PDF";
      if (openFileDialog.ShowDialog() != DialogResult.OK)
        return;
      try
      {
        this.btePdfReaderPath.Text = openFileDialog.FileName;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show("Lỗi: " + ex.Message);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panelControl1 = new PanelControl();
      this.btnCancel = new SimpleButton();
      this.btnOk = new SimpleButton();
      this.tabConfig = new XtraTabControl();
      this.tpgCompanyInfo = new XtraTabPage();
      this.bteLogoPath = new ButtonEdit();
      this.labelControl3 = new LabelControl();
      this.simpleButton1 = new SimpleButton();
      this.labelControl2 = new LabelControl();
      this.btnLoadImage = new SimpleButton();
      this.pictureEdit1 = new PictureEdit();
      this.txtDienThoaiCty = new TextEdit();
      this.txtDiaChiCty = new TextEdit();
      this.txtTenCty = new TextEdit();
      this.lblPhone = new LabelControl();
      this.lblAddress = new LabelControl();
      this.lblCompanyName = new LabelControl();
      this.tpgRunningMode = new XtraTabPage();
      this.txtPassword = new TextEdit();
      this.txtUsername = new TextEdit();
      this.txtDatabase = new TextEdit();
      this.txtServer = new TextEdit();
      this.lblPassword = new LabelControl();
      this.lblUsername = new LabelControl();
      this.lblDatabase = new LabelControl();
      this.lblServerName = new LabelControl();
      this.grpStandAlone = new GroupControl();
      this.grpService = new GroupControl();
      this.txtServerIP = new TextEdit();
      this.lblEndpointAddress = new LabelControl();
      this.lblRunningMode = new LabelControl();
      this.lueRunningMode = new LookUpEdit();
      this.tpgOptions = new XtraTabPage();
      this.xtraTabControl1 = new XtraTabControl();
      this.tpgRange = new XtraTabPage();
      this.spnKLTronLonNhat = new SpinEdit();
      this.spnKLTronNhoNhat = new SpinEdit();
      this.spnKLChoLonNhat = new SpinEdit();
      this.lblKLTronLonNhat = new LabelControl();
      this.lblKLTronNhoNhat = new LabelControl();
      this.lblKLChoLonNhat = new LabelControl();
      this.tpgFilter = new XtraTabPage();
      this.spnLatestBaoCaoDays = new SpinEdit();
      this.labelControl5 = new LabelControl();
      this.labelControl6 = new LabelControl();
      this.spnLatestHopDongDays = new SpinEdit();
      this.spnLatestPhieuTronDays = new SpinEdit();
      this.lblLatestDay2 = new LabelControl();
      this.lblLatestDay = new LabelControl();
      this.lblPhieuTron = new LabelControl();
      this.lblContract = new LabelControl();
      this.tpgOthers = new XtraTabPage();
      this.bteImportPath_CT = new ButtonEdit();
      this.btePdfReaderPath = new ButtonEdit();
      this.labelControl9 = new LabelControl();
      this.bteImportPath_GH = new ButtonEdit();
      this.bteExportPath = new ButtonEdit();
      this.chkDev = new CheckEdit();
      this.labelControl7 = new LabelControl();
      this.chkTronOnline = new CheckEdit();
      this.chkTinhBuTru = new CheckEdit();
      this.btnReportPathBrowse = new SimpleButton();
      this.btnTestReportPath = new SimpleButton();
      this.lblReportPath = new LabelControl();
      this.xtraTabPage1 = new XtraTabPage();
      this.labelControl8 = new LabelControl();
      this.beFilePathPLC = new ButtonEdit();
      this.btnUploadToPLC = new SimpleButton();
      this.tpgGeneral = new XtraTabPage();
      this.lueLanguages = new LookUpEdit();
      this.txtLANPort = new TextEdit();
      this.txtLANIP = new TextEdit();
      this.labelControl4 = new LabelControl();
      this.lblIP = new LabelControl();
      this.txtPLCPort = new TextEdit();
      this.btnTestPort = new SimpleButton();
      this.btnChangePLCPort = new SimpleButton();
      this.labelControl1 = new LabelControl();
      this.rdgLanguageRes = new RadioGroup();
      this.lblLanguage = new LabelControl();
      this.simpleButton2 = new SimpleButton();
      this.simpleButton3 = new SimpleButton();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.tabConfig.BeginInit();
      this.tabConfig.SuspendLayout();
      this.tpgCompanyInfo.SuspendLayout();
      this.bteLogoPath.Properties.BeginInit();
      this.pictureEdit1.Properties.BeginInit();
      this.txtDienThoaiCty.Properties.BeginInit();
      this.txtDiaChiCty.Properties.BeginInit();
      this.txtTenCty.Properties.BeginInit();
      this.tpgRunningMode.SuspendLayout();
      this.txtPassword.Properties.BeginInit();
      this.txtUsername.Properties.BeginInit();
      this.txtDatabase.Properties.BeginInit();
      this.txtServer.Properties.BeginInit();
      this.grpStandAlone.BeginInit();
      this.grpStandAlone.SuspendLayout();
      this.grpService.BeginInit();
      this.grpService.SuspendLayout();
      this.txtServerIP.Properties.BeginInit();
      this.lueRunningMode.Properties.BeginInit();
      this.tpgOptions.SuspendLayout();
      this.xtraTabControl1.BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.tpgRange.SuspendLayout();
      this.spnKLTronLonNhat.Properties.BeginInit();
      this.spnKLTronNhoNhat.Properties.BeginInit();
      this.spnKLChoLonNhat.Properties.BeginInit();
      this.tpgFilter.SuspendLayout();
      this.spnLatestBaoCaoDays.Properties.BeginInit();
      this.spnLatestHopDongDays.Properties.BeginInit();
      this.spnLatestPhieuTronDays.Properties.BeginInit();
      this.tpgOthers.SuspendLayout();
      this.bteImportPath_CT.Properties.BeginInit();
      this.btePdfReaderPath.Properties.BeginInit();
      this.bteImportPath_GH.Properties.BeginInit();
      this.bteExportPath.Properties.BeginInit();
      this.chkDev.Properties.BeginInit();
      this.chkTronOnline.Properties.BeginInit();
      this.chkTinhBuTru.Properties.BeginInit();
      this.xtraTabPage1.SuspendLayout();
      this.beFilePathPLC.Properties.BeginInit();
      this.tpgGeneral.SuspendLayout();
      this.lueLanguages.Properties.BeginInit();
      this.txtLANPort.Properties.BeginInit();
      this.txtLANIP.Properties.BeginInit();
      this.txtPLCPort.Properties.BeginInit();
      this.rdgLanguageRes.Properties.BeginInit();
      this.SuspendLayout();
      this.panelControl1.Controls.Add((Control) this.simpleButton3);
      this.panelControl1.Controls.Add((Control) this.simpleButton2);
      this.panelControl1.Controls.Add((Control) this.btnCancel);
      this.panelControl1.Controls.Add((Control) this.btnOk);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(0, 312);
      this.panelControl1.Margin = new Padding(3, 2, 3, 2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(691, 40);
      this.panelControl1.TabIndex = 0;
      this.btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnCancel.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnCancel.Appearance.Options.UseFont = true;
      this.btnCancel.Location = new Point(1045, 6);
      this.btnCancel.Margin = new Padding(3, 2, 3, 2);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(98, 30);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Huỷ Bỏ";
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnOk.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnOk.Appearance.Options.UseFont = true;
      this.btnOk.Location = new Point(931, 6);
      this.btnOk.Margin = new Padding(3, 2, 3, 2);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(98, 30);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "Lưu";
      this.btnOk.Click += new EventHandler(this.btnOk_Click);
      this.tabConfig.Dock = DockStyle.Fill;
      this.tabConfig.Location = new Point(0, 0);
      this.tabConfig.Margin = new Padding(3, 2, 3, 2);
      this.tabConfig.Name = "tabConfig";
      this.tabConfig.SelectedTabPage = this.tpgCompanyInfo;
      this.tabConfig.Size = new Size(691, 312);
      this.tabConfig.TabIndex = 0;
      this.tabConfig.TabPages.AddRange(new XtraTabPage[4]
      {
        this.tpgRunningMode,
        this.tpgCompanyInfo,
        this.tpgOptions,
        this.tpgGeneral
      });
      this.tpgCompanyInfo.Controls.Add((Control) this.bteLogoPath);
      this.tpgCompanyInfo.Controls.Add((Control) this.labelControl3);
      this.tpgCompanyInfo.Controls.Add((Control) this.simpleButton1);
      this.tpgCompanyInfo.Controls.Add((Control) this.labelControl2);
      this.tpgCompanyInfo.Controls.Add((Control) this.btnLoadImage);
      this.tpgCompanyInfo.Controls.Add((Control) this.pictureEdit1);
      this.tpgCompanyInfo.Controls.Add((Control) this.txtDienThoaiCty);
      this.tpgCompanyInfo.Controls.Add((Control) this.txtDiaChiCty);
      this.tpgCompanyInfo.Controls.Add((Control) this.txtTenCty);
      this.tpgCompanyInfo.Controls.Add((Control) this.lblPhone);
      this.tpgCompanyInfo.Controls.Add((Control) this.lblAddress);
      this.tpgCompanyInfo.Controls.Add((Control) this.lblCompanyName);
      this.tpgCompanyInfo.Margin = new Padding(3, 2, 3, 2);
      this.tpgCompanyInfo.Name = "tpgCompanyInfo";
      this.tpgCompanyInfo.Size = new Size(689, 287);
      this.tpgCompanyInfo.Text = "Thông Tin Cty";
      this.bteLogoPath.Location = new Point(167, 115);
      this.bteLogoPath.Name = "bteLogoPath";
      this.bteLogoPath.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.bteLogoPath.Size = new Size(304, 20);
      this.bteLogoPath.TabIndex = 12;
      this.bteLogoPath.ButtonClick += new ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
      this.bteLogoPath.EditValueChanged += new EventHandler(this.bteLogoPath_EditValueChanged);
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Appearance.Options.UseTextOptions = true;
      this.labelControl3.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.labelControl3.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl3.Location = new Point(49, 116);
      this.labelControl3.Margin = new Padding(3, 2, 3, 2);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(96, 16);
      this.labelControl3.TabIndex = 11;
      this.labelControl3.Text = "Đường dẫn logo";
      this.simpleButton1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.Location = new Point(280, 144);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(98, 30);
      this.simpleButton1.TabIndex = 10;
      this.simpleButton1.Text = "Load Logo";
      this.simpleButton1.Visible = false;
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(509, 134);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(74, 16);
      this.labelControl2.TabIndex = 9;
      this.labelControl2.Text = "Logo Công ty";
      this.btnLoadImage.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnLoadImage.Appearance.Options.UseFont = true;
      this.btnLoadImage.Location = new Point(167, 144);
      this.btnLoadImage.Name = "btnLoadImage";
      this.btnLoadImage.Size = new Size(98, 30);
      this.btnLoadImage.TabIndex = 7;
      this.btnLoadImage.Text = "Thay đổi";
      this.btnLoadImage.Visible = false;
      this.btnLoadImage.Click += new EventHandler(this.btnLoadImage_Click);
      this.pictureEdit1.Location = new Point(498, 28);
      this.pictureEdit1.Name = "pictureEdit1";
      this.pictureEdit1.Properties.NullText = " ";
      this.pictureEdit1.Properties.ShowCameraMenuItem = CameraMenuItemVisibility.Auto;
      this.pictureEdit1.Size = new Size(100, 100);
      this.pictureEdit1.TabIndex = 6;
      this.pictureEdit1.LoadCompleted += new EventHandler(this.pictureEdit1_LoadCompleted);
      this.pictureEdit1.TextChanged += new EventHandler(this.pictureEdit1_TextChanged);
      this.txtDienThoaiCty.Location = new Point(167, 85);
      this.txtDienThoaiCty.Margin = new Padding(3, 2, 3, 2);
      this.txtDienThoaiCty.Name = "txtDienThoaiCty";
      this.txtDienThoaiCty.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDienThoaiCty.Properties.Appearance.Options.UseFont = true;
      this.txtDienThoaiCty.Size = new Size(304, 22);
      this.txtDienThoaiCty.TabIndex = 5;
      this.txtDiaChiCty.Location = new Point(167, 55);
      this.txtDiaChiCty.Margin = new Padding(3, 2, 3, 2);
      this.txtDiaChiCty.Name = "txtDiaChiCty";
      this.txtDiaChiCty.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDiaChiCty.Properties.Appearance.Options.UseFont = true;
      this.txtDiaChiCty.Size = new Size(304, 22);
      this.txtDiaChiCty.TabIndex = 4;
      this.txtTenCty.Location = new Point(167, 25);
      this.txtTenCty.Margin = new Padding(3, 2, 3, 2);
      this.txtTenCty.Name = "txtTenCty";
      this.txtTenCty.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenCty.Properties.Appearance.Options.UseFont = true;
      this.txtTenCty.Size = new Size(304, 22);
      this.txtTenCty.TabIndex = 3;
      this.lblPhone.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Appearance.Options.UseTextOptions = true;
      this.lblPhone.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblPhone.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblPhone.Location = new Point(49, 88);
      this.lblPhone.Margin = new Padding(3, 2, 3, 2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(96, 16);
      this.lblPhone.TabIndex = 2;
      this.lblPhone.Text = "Số Điện Thoại";
      this.lblAddress.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblAddress.Appearance.Options.UseFont = true;
      this.lblAddress.Appearance.Options.UseTextOptions = true;
      this.lblAddress.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblAddress.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblAddress.Location = new Point(49, 58);
      this.lblAddress.Margin = new Padding(3, 2, 3, 2);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new Size(96, 16);
      this.lblAddress.TabIndex = 1;
      this.lblAddress.Text = "Địa Chỉ";
      this.lblCompanyName.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblCompanyName.Appearance.Options.UseFont = true;
      this.lblCompanyName.Appearance.Options.UseTextOptions = true;
      this.lblCompanyName.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblCompanyName.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblCompanyName.Location = new Point(49, 28);
      this.lblCompanyName.Margin = new Padding(3, 2, 3, 2);
      this.lblCompanyName.Name = "lblCompanyName";
      this.lblCompanyName.Size = new Size(96, 16);
      this.lblCompanyName.TabIndex = 0;
      this.lblCompanyName.Text = "Tên Công Ty";
      this.tpgRunningMode.Controls.Add((Control) this.txtPassword);
      this.tpgRunningMode.Controls.Add((Control) this.txtUsername);
      this.tpgRunningMode.Controls.Add((Control) this.txtDatabase);
      this.tpgRunningMode.Controls.Add((Control) this.txtServer);
      this.tpgRunningMode.Controls.Add((Control) this.lblPassword);
      this.tpgRunningMode.Controls.Add((Control) this.lblUsername);
      this.tpgRunningMode.Controls.Add((Control) this.lblDatabase);
      this.tpgRunningMode.Controls.Add((Control) this.lblServerName);
      this.tpgRunningMode.Controls.Add((Control) this.grpStandAlone);
      this.tpgRunningMode.Margin = new Padding(3, 2, 3, 2);
      this.tpgRunningMode.Name = "tpgRunningMode";
      this.tpgRunningMode.Size = new Size(689, 287);
      this.tpgRunningMode.Text = "Running Mode";
      this.txtPassword.Location = new Point(167, 115);
      this.txtPassword.Margin = new Padding(3, 2, 3, 2);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPassword.Properties.Appearance.Options.UseFont = true;
      this.txtPassword.Properties.MaxLength = 20;
      this.txtPassword.Properties.PasswordChar = '*';
      this.txtPassword.Size = new Size(189, 22);
      this.txtPassword.TabIndex = 15;
      this.txtUsername.Location = new Point(167, 85);
      this.txtUsername.Margin = new Padding(3, 2, 3, 2);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtUsername.Properties.Appearance.Options.UseFont = true;
      this.txtUsername.Size = new Size(189, 22);
      this.txtUsername.TabIndex = 14;
      this.txtDatabase.Location = new Point(167, 55);
      this.txtDatabase.Margin = new Padding(3, 2, 3, 2);
      this.txtDatabase.Name = "txtDatabase";
      this.txtDatabase.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDatabase.Properties.Appearance.Options.UseFont = true;
      this.txtDatabase.Size = new Size(189, 22);
      this.txtDatabase.TabIndex = 13;
      this.txtServer.Location = new Point(167, 25);
      this.txtServer.Margin = new Padding(3, 2, 3, 2);
      this.txtServer.Name = "txtServer";
      this.txtServer.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtServer.Properties.Appearance.Options.UseFont = true;
      this.txtServer.Size = new Size(189, 22);
      this.txtServer.TabIndex = 12;
      this.lblPassword.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPassword.Appearance.Options.UseFont = true;
      this.lblPassword.Appearance.Options.UseTextOptions = true;
      this.lblPassword.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblPassword.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblPassword.Location = new Point(49, 118);
      this.lblPassword.Margin = new Padding(3, 2, 3, 2);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new Size(93, 16);
      this.lblPassword.TabIndex = 11;
      this.lblPassword.Text = "Password";
      this.lblUsername.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblUsername.Appearance.Options.UseFont = true;
      this.lblUsername.Appearance.Options.UseTextOptions = true;
      this.lblUsername.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblUsername.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblUsername.Location = new Point(48, 88);
      this.lblUsername.Margin = new Padding(3, 2, 3, 2);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new Size(94, 16);
      this.lblUsername.TabIndex = 10;
      this.lblUsername.Text = "Username";
      this.lblDatabase.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDatabase.Appearance.Options.UseFont = true;
      this.lblDatabase.Appearance.Options.UseTextOptions = true;
      this.lblDatabase.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblDatabase.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblDatabase.Location = new Point(49, 58);
      this.lblDatabase.Margin = new Padding(3, 2, 3, 2);
      this.lblDatabase.Name = "lblDatabase";
      this.lblDatabase.Size = new Size(93, 16);
      this.lblDatabase.TabIndex = 9;
      this.lblDatabase.Text = "Database";
      this.lblServerName.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblServerName.Appearance.Options.UseFont = true;
      this.lblServerName.Appearance.Options.UseTextOptions = true;
      this.lblServerName.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblServerName.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblServerName.Location = new Point(49, 28);
      this.lblServerName.Margin = new Padding(3, 2, 3, 2);
      this.lblServerName.Name = "lblServerName";
      this.lblServerName.Size = new Size(93, 16);
      this.lblServerName.TabIndex = 8;
      this.lblServerName.Text = "Server Name";
      this.grpStandAlone.Controls.Add((Control) this.grpService);
      this.grpStandAlone.Controls.Add((Control) this.lblRunningMode);
      this.grpStandAlone.Controls.Add((Control) this.lueRunningMode);
      this.grpStandAlone.Location = new Point(1, 215);
      this.grpStandAlone.Margin = new Padding(3, 2, 3, 2);
      this.grpStandAlone.Name = "grpStandAlone";
      this.grpStandAlone.Size = new Size(689, 69);
      this.grpStandAlone.TabIndex = 0;
      this.grpStandAlone.Text = "Cấu hình cơ sở dữ liệu";
      this.grpStandAlone.Visible = false;
      this.grpService.Controls.Add((Control) this.txtServerIP);
      this.grpService.Controls.Add((Control) this.lblEndpointAddress);
      this.grpService.Location = new Point(63, 164);
      this.grpService.Margin = new Padding(3, 2, 3, 2);
      this.grpService.Name = "grpService";
      this.grpService.Size = new Size(501, 62);
      this.grpService.TabIndex = 1;
      this.grpService.Text = "Service";
      this.grpService.Visible = false;
      this.txtServerIP.Location = new Point(154, 30);
      this.txtServerIP.Margin = new Padding(3, 2, 3, 2);
      this.txtServerIP.Name = "txtServerIP";
      this.txtServerIP.Size = new Size(315, 20);
      this.txtServerIP.TabIndex = 1;
      this.txtServerIP.Visible = false;
      this.lblEndpointAddress.Location = new Point(81, 32);
      this.lblEndpointAddress.Margin = new Padding(3, 2, 3, 2);
      this.lblEndpointAddress.Name = "lblEndpointAddress";
      this.lblEndpointAddress.Size = new Size(39, 13);
      this.lblEndpointAddress.TabIndex = 0;
      this.lblEndpointAddress.Text = "Address";
      this.lblEndpointAddress.Visible = false;
      this.lblRunningMode.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblRunningMode.Appearance.Options.UseFont = true;
      this.lblRunningMode.Appearance.Options.UseTextOptions = true;
      this.lblRunningMode.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblRunningMode.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblRunningMode.Location = new Point(219, 233);
      this.lblRunningMode.Margin = new Padding(3, 2, 3, 2);
      this.lblRunningMode.Name = "lblRunningMode";
      this.lblRunningMode.Size = new Size(107, 16);
      this.lblRunningMode.TabIndex = 3;
      this.lblRunningMode.Text = "Running Mode";
      this.lblRunningMode.Visible = false;
      this.lueRunningMode.Location = new Point(333, 230);
      this.lueRunningMode.Margin = new Padding(3, 2, 3, 2);
      this.lueRunningMode.Name = "lueRunningMode";
      this.lueRunningMode.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueRunningMode.Properties.Appearance.Options.UseFont = true;
      this.lueRunningMode.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueRunningMode.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("Code", "Running Mode")
      });
      this.lueRunningMode.Properties.DisplayMember = "Code";
      this.lueRunningMode.Properties.DropDownRows = 2;
      this.lueRunningMode.Properties.NullText = "";
      this.lueRunningMode.Properties.PopupWidth = 60;
      this.lueRunningMode.Properties.ShowFooter = false;
      this.lueRunningMode.Properties.ValueMember = "ID";
      this.lueRunningMode.Size = new Size(189, 22);
      this.lueRunningMode.TabIndex = 2;
      this.lueRunningMode.Visible = false;
      this.tpgOptions.Controls.Add((Control) this.xtraTabControl1);
      this.tpgOptions.Margin = new Padding(3, 2, 3, 2);
      this.tpgOptions.Name = "tpgOptions";
      this.tpgOptions.Size = new Size(689, 287);
      this.tpgOptions.Text = "Hệ Thống";
      this.xtraTabControl1.Location = new Point(3, 2);
      this.xtraTabControl1.Margin = new Padding(3, 2, 3, 2);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.tpgRange;
      this.xtraTabControl1.Size = new Size(683, 282);
      this.xtraTabControl1.TabIndex = 0;
      this.xtraTabControl1.TabPages.AddRange(new XtraTabPage[4]
      {
        this.tpgRange,
        this.tpgFilter,
        this.tpgOthers,
        this.xtraTabPage1
      });
      this.tpgRange.Controls.Add((Control) this.spnKLTronLonNhat);
      this.tpgRange.Controls.Add((Control) this.spnKLTronNhoNhat);
      this.tpgRange.Controls.Add((Control) this.spnKLChoLonNhat);
      this.tpgRange.Controls.Add((Control) this.lblKLTronLonNhat);
      this.tpgRange.Controls.Add((Control) this.lblKLTronNhoNhat);
      this.tpgRange.Controls.Add((Control) this.lblKLChoLonNhat);
      this.tpgRange.Margin = new Padding(3, 2, 3, 2);
      this.tpgRange.Name = "tpgRange";
      this.tpgRange.Size = new Size(681, 257);
      this.tpgRange.Text = "Ràng Buộc";
      this.spnKLTronLonNhat.EditValue = (object) new Decimal(new int[4]);
      this.spnKLTronLonNhat.Location = new Point(232, 90);
      this.spnKLTronLonNhat.Margin = new Padding(3, 2, 3, 2);
      this.spnKLTronLonNhat.Name = "spnKLTronLonNhat";
      this.spnKLTronLonNhat.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLTronLonNhat.Properties.Appearance.Options.UseFont = true;
      this.spnKLTronLonNhat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLTronLonNhat.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnKLTronLonNhat.Properties.EditFormat.FormatString = "n1";
      this.spnKLTronLonNhat.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnKLTronLonNhat.Properties.Mask.EditMask = "n1";
      this.spnKLTronLonNhat.Size = new Size(107, 22);
      this.spnKLTronLonNhat.TabIndex = 5;
      this.spnKLTronNhoNhat.EditValue = (object) new Decimal(new int[4]);
      this.spnKLTronNhoNhat.Location = new Point(232, 60);
      this.spnKLTronNhoNhat.Margin = new Padding(3, 2, 3, 2);
      this.spnKLTronNhoNhat.Name = "spnKLTronNhoNhat";
      this.spnKLTronNhoNhat.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLTronNhoNhat.Properties.Appearance.Options.UseFont = true;
      this.spnKLTronNhoNhat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLTronNhoNhat.Properties.DisplayFormat.FormatString = "n1";
      this.spnKLTronNhoNhat.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnKLTronNhoNhat.Properties.EditFormat.FormatString = "n1";
      this.spnKLTronNhoNhat.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnKLTronNhoNhat.Properties.Mask.EditMask = "n1";
      this.spnKLTronNhoNhat.Size = new Size(107, 22);
      this.spnKLTronNhoNhat.TabIndex = 4;
      this.spnKLChoLonNhat.EditValue = (object) new Decimal(new int[4]);
      this.spnKLChoLonNhat.Location = new Point(232, 30);
      this.spnKLChoLonNhat.Margin = new Padding(3, 2, 3, 2);
      this.spnKLChoLonNhat.Name = "spnKLChoLonNhat";
      this.spnKLChoLonNhat.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLChoLonNhat.Properties.Appearance.Options.UseFont = true;
      this.spnKLChoLonNhat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLChoLonNhat.Properties.DisplayFormat.FormatString = "n1";
      this.spnKLChoLonNhat.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnKLChoLonNhat.Properties.EditFormat.FormatString = "n1";
      this.spnKLChoLonNhat.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnKLChoLonNhat.Properties.Mask.EditMask = "n1";
      this.spnKLChoLonNhat.Size = new Size(107, 22);
      this.spnKLChoLonNhat.TabIndex = 3;
      this.lblKLTronLonNhat.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLTronLonNhat.Appearance.Options.UseFont = true;
      this.lblKLTronLonNhat.Appearance.Options.UseTextOptions = true;
      this.lblKLTronLonNhat.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblKLTronLonNhat.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblKLTronLonNhat.Location = new Point(41, 93);
      this.lblKLTronLonNhat.Margin = new Padding(3, 2, 3, 2);
      this.lblKLTronLonNhat.Name = "lblKLTronLonNhat";
      this.lblKLTronLonNhat.Size = new Size(160, 16);
      this.lblKLTronLonNhat.TabIndex = 2;
      this.lblKLTronLonNhat.Text = "Số khối trộn lớn nhất";
      this.lblKLTronNhoNhat.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLTronNhoNhat.Appearance.Options.UseFont = true;
      this.lblKLTronNhoNhat.Appearance.Options.UseTextOptions = true;
      this.lblKLTronNhoNhat.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblKLTronNhoNhat.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblKLTronNhoNhat.Location = new Point(41, 63);
      this.lblKLTronNhoNhat.Margin = new Padding(3, 2, 3, 2);
      this.lblKLTronNhoNhat.Name = "lblKLTronNhoNhat";
      this.lblKLTronNhoNhat.Size = new Size(160, 16);
      this.lblKLTronNhoNhat.TabIndex = 1;
      this.lblKLTronNhoNhat.Text = "Số khối trộn nhỏ nhất";
      this.lblKLChoLonNhat.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLChoLonNhat.Appearance.Options.UseFont = true;
      this.lblKLChoLonNhat.Appearance.Options.UseTextOptions = true;
      this.lblKLChoLonNhat.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblKLChoLonNhat.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblKLChoLonNhat.Location = new Point(41, 33);
      this.lblKLChoLonNhat.Margin = new Padding(3, 2, 3, 2);
      this.lblKLChoLonNhat.Name = "lblKLChoLonNhat";
      this.lblKLChoLonNhat.Size = new Size(160, 16);
      this.lblKLChoLonNhat.TabIndex = 0;
      this.lblKLChoLonNhat.Text = "Số khối lớn nhất mà xe chở";
      this.tpgFilter.Controls.Add((Control) this.spnLatestBaoCaoDays);
      this.tpgFilter.Controls.Add((Control) this.labelControl5);
      this.tpgFilter.Controls.Add((Control) this.labelControl6);
      this.tpgFilter.Controls.Add((Control) this.spnLatestHopDongDays);
      this.tpgFilter.Controls.Add((Control) this.spnLatestPhieuTronDays);
      this.tpgFilter.Controls.Add((Control) this.lblLatestDay2);
      this.tpgFilter.Controls.Add((Control) this.lblLatestDay);
      this.tpgFilter.Controls.Add((Control) this.lblPhieuTron);
      this.tpgFilter.Controls.Add((Control) this.lblContract);
      this.tpgFilter.Margin = new Padding(3, 2, 3, 2);
      this.tpgFilter.Name = "tpgFilter";
      this.tpgFilter.Size = new Size(681, 257);
      this.tpgFilter.Text = "Bộ Lọc";
      this.spnLatestBaoCaoDays.EditValue = (object) new Decimal(new int[4]);
      this.spnLatestBaoCaoDays.Location = new Point(121, 90);
      this.spnLatestBaoCaoDays.Margin = new Padding(3, 2, 3, 2);
      this.spnLatestBaoCaoDays.Name = "spnLatestBaoCaoDays";
      this.spnLatestBaoCaoDays.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnLatestBaoCaoDays.Properties.Appearance.Options.UseFont = true;
      this.spnLatestBaoCaoDays.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnLatestBaoCaoDays.Size = new Size(107, 22);
      this.spnLatestBaoCaoDays.TabIndex = 8;
      this.labelControl5.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Appearance.Options.UseTextOptions = true;
      this.labelControl5.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
      this.labelControl5.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl5.Location = new Point(240, 90);
      this.labelControl5.Margin = new Padding(3, 2, 3, 2);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(154, 16);
      this.labelControl5.TabIndex = 7;
      this.labelControl5.Text = "ngày gần đây nhất";
      this.labelControl6.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl6.Appearance.Options.UseFont = true;
      this.labelControl6.Appearance.Options.UseTextOptions = true;
      this.labelControl6.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.labelControl6.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl6.Location = new Point(26, 90);
      this.labelControl6.Margin = new Padding(3, 2, 3, 2);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new Size(75, 16);
      this.labelControl6.TabIndex = 6;
      this.labelControl6.Text = "Báo cáo";
      this.spnLatestHopDongDays.EditValue = (object) new Decimal(new int[4]);
      this.spnLatestHopDongDays.Location = new Point(121, 30);
      this.spnLatestHopDongDays.Margin = new Padding(3, 2, 3, 2);
      this.spnLatestHopDongDays.Name = "spnLatestHopDongDays";
      this.spnLatestHopDongDays.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnLatestHopDongDays.Properties.Appearance.Options.UseFont = true;
      this.spnLatestHopDongDays.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnLatestHopDongDays.Size = new Size(107, 22);
      this.spnLatestHopDongDays.TabIndex = 5;
      this.spnLatestPhieuTronDays.EditValue = (object) new Decimal(new int[4]);
      this.spnLatestPhieuTronDays.Location = new Point(121, 60);
      this.spnLatestPhieuTronDays.Margin = new Padding(3, 2, 3, 2);
      this.spnLatestPhieuTronDays.Name = "spnLatestPhieuTronDays";
      this.spnLatestPhieuTronDays.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnLatestPhieuTronDays.Properties.Appearance.Options.UseFont = true;
      this.spnLatestPhieuTronDays.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnLatestPhieuTronDays.Size = new Size(107, 22);
      this.spnLatestPhieuTronDays.TabIndex = 4;
      this.lblLatestDay2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblLatestDay2.Appearance.Options.UseFont = true;
      this.lblLatestDay2.Appearance.Options.UseTextOptions = true;
      this.lblLatestDay2.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
      this.lblLatestDay2.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblLatestDay2.Location = new Point(240, 63);
      this.lblLatestDay2.Margin = new Padding(3, 2, 3, 2);
      this.lblLatestDay2.Name = "lblLatestDay2";
      this.lblLatestDay2.Size = new Size(154, 16);
      this.lblLatestDay2.TabIndex = 3;
      this.lblLatestDay2.Text = "ngày gần đây nhất";
      this.lblLatestDay.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblLatestDay.Appearance.Options.UseFont = true;
      this.lblLatestDay.Appearance.Options.UseTextOptions = true;
      this.lblLatestDay.Appearance.TextOptions.HAlignment = HorzAlignment.Near;
      this.lblLatestDay.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblLatestDay.Location = new Point(240, 33);
      this.lblLatestDay.Margin = new Padding(3, 2, 3, 2);
      this.lblLatestDay.Name = "lblLatestDay";
      this.lblLatestDay.Size = new Size(154, 16);
      this.lblLatestDay.TabIndex = 2;
      this.lblLatestDay.Text = "ngày gần đây nhất";
      this.lblPhieuTron.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhieuTron.Appearance.Options.UseFont = true;
      this.lblPhieuTron.Appearance.Options.UseTextOptions = true;
      this.lblPhieuTron.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblPhieuTron.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblPhieuTron.Location = new Point(26, 63);
      this.lblPhieuTron.Margin = new Padding(3, 2, 3, 2);
      this.lblPhieuTron.Name = "lblPhieuTron";
      this.lblPhieuTron.Size = new Size(75, 16);
      this.lblPhieuTron.TabIndex = 1;
      this.lblPhieuTron.Text = "Phiếu Trộn";
      this.lblContract.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblContract.Appearance.Options.UseFont = true;
      this.lblContract.Appearance.Options.UseTextOptions = true;
      this.lblContract.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblContract.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblContract.Location = new Point(26, 33);
      this.lblContract.Margin = new Padding(3, 2, 3, 2);
      this.lblContract.Name = "lblContract";
      this.lblContract.Size = new Size(75, 16);
      this.lblContract.TabIndex = 0;
      this.lblContract.Text = "Hợp Đồng";
      this.tpgOthers.Controls.Add((Control) this.bteImportPath_CT);
      this.tpgOthers.Controls.Add((Control) this.btePdfReaderPath);
      this.tpgOthers.Controls.Add((Control) this.labelControl9);
      this.tpgOthers.Controls.Add((Control) this.bteImportPath_GH);
      this.tpgOthers.Controls.Add((Control) this.bteExportPath);
      this.tpgOthers.Controls.Add((Control) this.chkDev);
      this.tpgOthers.Controls.Add((Control) this.labelControl7);
      this.tpgOthers.Controls.Add((Control) this.chkTronOnline);
      this.tpgOthers.Controls.Add((Control) this.chkTinhBuTru);
      this.tpgOthers.Controls.Add((Control) this.btnReportPathBrowse);
      this.tpgOthers.Controls.Add((Control) this.btnTestReportPath);
      this.tpgOthers.Controls.Add((Control) this.lblReportPath);
      this.tpgOthers.Margin = new Padding(3, 2, 3, 2);
      this.tpgOthers.Name = "tpgOthers";
      this.tpgOthers.Size = new Size(681, 257);
      this.tpgOthers.Text = "Khác";
      this.bteImportPath_CT.Location = new Point(135, 100);
      this.bteImportPath_CT.Name = "bteImportPath_CT";
      this.bteImportPath_CT.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.bteImportPath_CT.Size = new Size(460, 20);
      this.bteImportPath_CT.TabIndex = 16;
      this.bteImportPath_CT.ButtonClick += new ButtonPressedEventHandler(this.bteImportPath_CT_ButtonClick);
      this.btePdfReaderPath.Location = new Point(135, 135);
      this.btePdfReaderPath.Name = "btePdfReaderPath";
      this.btePdfReaderPath.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.btePdfReaderPath.Size = new Size(460, 20);
      this.btePdfReaderPath.TabIndex = 16;
      this.btePdfReaderPath.Click += new EventHandler(this.btePdfReaderPath_Click);
      this.labelControl9.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Appearance.Options.UseTextOptions = true;
      this.labelControl9.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.labelControl9.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl9.Location = new Point(7, 94);
      this.labelControl9.Margin = new Padding(3, 2, 3, 2);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new Size(117, 29);
      this.labelControl9.TabIndex = 15;
      this.labelControl9.Text = "Nhập File In Chi Tiết";
      this.bteImportPath_GH.Location = new Point(135, 65);
      this.bteImportPath_GH.Name = "bteImportPath_GH";
      this.bteImportPath_GH.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.bteImportPath_GH.Size = new Size(460, 20);
      this.bteImportPath_GH.TabIndex = 14;
      this.bteImportPath_GH.ButtonClick += new ButtonPressedEventHandler(this.bteImportPath_ButtonClick);
      this.bteExportPath.Location = new Point(135, 32);
      this.bteExportPath.Name = "bteExportPath";
      this.bteExportPath.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.bteExportPath.Size = new Size(460, 20);
      this.bteExportPath.TabIndex = 13;
      this.bteExportPath.ButtonClick += new ButtonPressedEventHandler(this.bteExportPath_ButtonClick);
      this.chkDev.Location = new Point(42, 225);
      this.chkDev.Margin = new Padding(3, 2, 3, 2);
      this.chkDev.Name = "chkDev";
      this.chkDev.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkDev.Properties.Appearance.Options.UseFont = true;
      this.chkDev.Properties.Caption = "Dev";
      this.chkDev.Size = new Size(278, 20);
      this.chkDev.TabIndex = 10;
      this.chkDev.Visible = false;
      this.labelControl7.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl7.Appearance.Options.UseFont = true;
      this.labelControl7.Appearance.Options.UseTextOptions = true;
      this.labelControl7.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.labelControl7.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl7.Location = new Point(17, 59);
      this.labelControl7.Margin = new Padding(3, 2, 3, 2);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new Size(107, 29);
      this.labelControl7.TabIndex = 6;
      this.labelControl7.Text = "Nhập File In Nhanh";
      this.chkTronOnline.Location = new Point(42, 176);
      this.chkTronOnline.Margin = new Padding(3, 2, 3, 2);
      this.chkTronOnline.Name = "chkTronOnline";
      this.chkTronOnline.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkTronOnline.Properties.Appearance.Options.UseFont = true;
      this.chkTronOnline.Properties.Caption = "Hiển thị màn hình Vận Hành lúc khởi động";
      this.chkTronOnline.Size = new Size(278, 20);
      this.chkTronOnline.TabIndex = 5;
      this.chkTinhBuTru.Location = new Point(42, 201);
      this.chkTinhBuTru.Margin = new Padding(3, 2, 3, 2);
      this.chkTinhBuTru.Name = "chkTinhBuTru";
      this.chkTinhBuTru.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkTinhBuTru.Properties.Appearance.Options.UseFont = true;
      this.chkTinhBuTru.Properties.Caption = "Tính khối lượng bù trừ";
      this.chkTinhBuTru.Size = new Size(278, 20);
      this.chkTinhBuTru.TabIndex = 4;
      this.chkTinhBuTru.Visible = false;
      this.btnReportPathBrowse.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnReportPathBrowse.Appearance.Options.UseFont = true;
      this.btnReportPathBrowse.Location = new Point(465, 141);
      this.btnReportPathBrowse.Margin = new Padding(3, 2, 3, 2);
      this.btnReportPathBrowse.Name = "btnReportPathBrowse";
      this.btnReportPathBrowse.Size = new Size(130, 30);
      this.btnReportPathBrowse.TabIndex = 3;
      this.btnReportPathBrowse.Text = "Tìm Đường Dẫn";
      this.btnReportPathBrowse.Visible = false;
      this.btnReportPathBrowse.Click += new EventHandler(this.btnReportPathBrowse_Click);
      this.btnTestReportPath.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnTestReportPath.Appearance.Options.UseFont = true;
      this.btnTestReportPath.Location = new Point(465, 178);
      this.btnTestReportPath.Margin = new Padding(3, 2, 3, 2);
      this.btnTestReportPath.Name = "btnTestReportPath";
      this.btnTestReportPath.Size = new Size(130, 30);
      this.btnTestReportPath.TabIndex = 2;
      this.btnTestReportPath.Text = "Lưu Đường Dẫn";
      this.btnTestReportPath.Visible = false;
      this.btnTestReportPath.Click += new EventHandler(this.btnTestReportPath_Click);
      this.lblReportPath.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblReportPath.Appearance.Options.UseFont = true;
      this.lblReportPath.Appearance.Options.UseTextOptions = true;
      this.lblReportPath.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.lblReportPath.AutoSizeMode = LabelAutoSizeMode.None;
      this.lblReportPath.Location = new Point(7, 26);
      this.lblReportPath.Margin = new Padding(3, 2, 3, 2);
      this.lblReportPath.Name = "lblReportPath";
      this.lblReportPath.Size = new Size(117, 29);
      this.lblReportPath.TabIndex = 0;
      this.lblReportPath.Text = "Xuất File BC";
      this.xtraTabPage1.Controls.Add((Control) this.labelControl8);
      this.xtraTabPage1.Controls.Add((Control) this.beFilePathPLC);
      this.xtraTabPage1.Controls.Add((Control) this.btnUploadToPLC);
      this.xtraTabPage1.Name = "xtraTabPage1";
      this.xtraTabPage1.PageVisible = false;
      this.xtraTabPage1.Size = new Size(681, 257);
      this.xtraTabPage1.Text = "Upload Program PLC";
      this.labelControl8.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl8.Appearance.Options.UseFont = true;
      this.labelControl8.Appearance.Options.UseTextOptions = true;
      this.labelControl8.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.labelControl8.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl8.Location = new Point(12, 26);
      this.labelControl8.Margin = new Padding(3, 2, 3, 2);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new Size(117, 29);
      this.labelControl8.TabIndex = 592;
      this.labelControl8.Text = "Đường dẫn File nạp";
      this.beFilePathPLC.Location = new Point(135, 30);
      this.beFilePathPLC.Name = "beFilePathPLC";
      this.beFilePathPLC.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.beFilePathPLC.Properties.Appearance.Options.UseFont = true;
      this.beFilePathPLC.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.beFilePathPLC.Size = new Size(304, 22);
      this.beFilePathPLC.TabIndex = 591;
      this.beFilePathPLC.ButtonClick += new ButtonPressedEventHandler(this.beFilePath_ButtonClick);
      this.btnUploadToPLC.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnUploadToPLC.Appearance.Options.UseFont = true;
      this.btnUploadToPLC.Location = new Point(457, 26);
      this.btnUploadToPLC.Name = "btnUploadToPLC";
      this.btnUploadToPLC.Size = new Size(130, 30);
      this.btnUploadToPLC.TabIndex = 590;
      this.btnUploadToPLC.Text = "Upload";
      this.btnUploadToPLC.Click += new EventHandler(this.btnUploadToPLC_Click);
      this.tpgGeneral.Controls.Add((Control) this.lueLanguages);
      this.tpgGeneral.Controls.Add((Control) this.txtLANPort);
      this.tpgGeneral.Controls.Add((Control) this.txtLANIP);
      this.tpgGeneral.Controls.Add((Control) this.labelControl4);
      this.tpgGeneral.Controls.Add((Control) this.lblIP);
      this.tpgGeneral.Controls.Add((Control) this.txtPLCPort);
      this.tpgGeneral.Controls.Add((Control) this.btnTestPort);
      this.tpgGeneral.Controls.Add((Control) this.btnChangePLCPort);
      this.tpgGeneral.Controls.Add((Control) this.labelControl1);
      this.tpgGeneral.Controls.Add((Control) this.rdgLanguageRes);
      this.tpgGeneral.Controls.Add((Control) this.lblLanguage);
      this.tpgGeneral.Margin = new Padding(3, 2, 3, 2);
      this.tpgGeneral.Name = "tpgGeneral";
      this.tpgGeneral.Size = new Size(689, 287);
      this.tpgGeneral.Text = "Cài Đặt Chung";
      this.lueLanguages.Location = new Point(100, 60);
      this.lueLanguages.Margin = new Padding(3, 2, 3, 2);
      this.lueLanguages.Name = "lueLanguages";
      this.lueLanguages.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueLanguages.Properties.Appearance.Options.UseFont = true;
      this.lueLanguages.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueLanguages.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("Code", "Languages")
      });
      this.lueLanguages.Properties.DisplayMember = "Code";
      this.lueLanguages.Properties.NullText = "";
      this.lueLanguages.Properties.ShowFooter = false;
      this.lueLanguages.Properties.ShowHeader = false;
      this.lueLanguages.Properties.ValueMember = "ID";
      this.lueLanguages.Size = new Size(150, 22);
      this.lueLanguages.TabIndex = 12;
      this.txtLANPort.Location = new Point(77, 242);
      this.txtLANPort.Margin = new Padding(3, 2, 3, 2);
      this.txtLANPort.Name = "txtLANPort";
      this.txtLANPort.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtLANPort.Properties.Appearance.Options.UseFont = true;
      this.txtLANPort.Size = new Size(142, 22);
      this.txtLANPort.TabIndex = 11;
      this.txtLANPort.Visible = false;
      this.txtLANIP.Location = new Point(100, 30);
      this.txtLANIP.Margin = new Padding(3, 2, 3, 2);
      this.txtLANIP.Name = "txtLANIP";
      this.txtLANIP.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtLANIP.Properties.Appearance.Options.UseFont = true;
      this.txtLANIP.Size = new Size(150, 22);
      this.txtLANIP.TabIndex = 10;
      this.labelControl4.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new Point(19, 183);
      this.labelControl4.Margin = new Padding(3, 2, 3, 2);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(60, 16);
      this.labelControl4.TabIndex = 9;
      this.labelControl4.Text = "Serial Port";
      this.labelControl4.Visible = false;
      this.lblIP.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblIP.Appearance.Options.UseFont = true;
      this.lblIP.Location = new Point(43, 33);
      this.lblIP.Margin = new Padding(3, 2, 3, 2);
      this.lblIP.Name = "lblIP";
      this.lblIP.Size = new Size(36, 16);
      this.lblIP.TabIndex = 8;
      this.lblIP.Text = "IP PLC";
      this.txtPLCPort.Location = new Point(53, 206);
      this.txtPLCPort.Margin = new Padding(3, 2, 3, 2);
      this.txtPLCPort.Name = "txtPLCPort";
      this.txtPLCPort.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPLCPort.Properties.Appearance.Options.UseFont = true;
      this.txtPLCPort.Size = new Size(195, 22);
      this.txtPLCPort.TabIndex = 7;
      this.txtPLCPort.Visible = false;
      this.btnTestPort.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnTestPort.Appearance.Options.UseFont = true;
      this.btnTestPort.Location = new Point(380, 203);
      this.btnTestPort.Margin = new Padding(3, 2, 3, 2);
      this.btnTestPort.Name = "btnTestPort";
      this.btnTestPort.Size = new Size(81, 24);
      this.btnTestPort.TabIndex = 6;
      this.btnTestPort.Text = "Test Port";
      this.btnTestPort.Visible = false;
      this.btnTestPort.Click += new EventHandler(this.btnTestPort_Click);
      this.btnChangePLCPort.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnChangePLCPort.Appearance.Options.UseFont = true;
      this.btnChangePLCPort.Location = new Point(288, 203);
      this.btnChangePLCPort.Margin = new Padding(3, 2, 3, 2);
      this.btnChangePLCPort.Name = "btnChangePLCPort";
      this.btnChangePLCPort.Size = new Size(81, 24);
      this.btnChangePLCPort.TabIndex = 5;
      this.btnChangePLCPort.Text = "Change";
      this.btnChangePLCPort.Visible = false;
      this.btnChangePLCPort.Click += new EventHandler(this.btnChangePLCPort_Click);
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(33, 244);
      this.labelControl1.Margin = new Padding(3, 2, 3, 2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(23, 16);
      this.labelControl1.TabIndex = 2;
      this.labelControl1.Text = "Port";
      this.labelControl1.Visible = false;
      this.rdgLanguageRes.Location = new Point(364, 32);
      this.rdgLanguageRes.Margin = new Padding(3, 2, 3, 2);
      this.rdgLanguageRes.Name = "rdgLanguageRes";
      this.rdgLanguageRes.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.rdgLanguageRes.Properties.Appearance.Options.UseFont = true;
      this.rdgLanguageRes.Properties.BorderStyle = BorderStyles.Flat;
      this.rdgLanguageRes.Size = new Size(195, 52);
      this.rdgLanguageRes.TabIndex = 1;
      this.rdgLanguageRes.Visible = false;
      this.rdgLanguageRes.EditValueChanging += new ChangingEventHandler(this.rdgLanguageRes_EditValueChanging);
      this.lblLanguage.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblLanguage.Appearance.Options.UseFont = true;
      this.lblLanguage.Location = new Point(23, 63);
      this.lblLanguage.Margin = new Padding(3, 2, 3, 2);
      this.lblLanguage.Name = "lblLanguage";
      this.lblLanguage.Size = new Size(56, 16);
      this.lblLanguage.TabIndex = 0;
      this.lblLanguage.Text = "Ngôn Ngữ";
      this.simpleButton2.Location = new Point(208, 5);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.Size = new Size(94, 30);
      this.simpleButton2.TabIndex = 2;
      this.simpleButton2.Text = "Lưu";
      this.simpleButton2.Click += new EventHandler(this.btnOk_Click);
      this.simpleButton3.Location = new Point(327, 5);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.Size = new Size(94, 30);
      this.simpleButton3.TabIndex = 3;
      this.simpleButton3.Text = "Đóng";
      this.simpleButton3.Click += new EventHandler(this.btnCancel_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(691, 352);
      this.Controls.Add((Control) this.tabConfig);
      this.Controls.Add((Control) this.panelControl1);
      this.IconOptions.Image = (Image) ResourceNhua.logoV_64;
      this.Name = nameof (FrmConfig);
      this.SizeGripStyle = SizeGripStyle.Hide;
      this.Text = nameof (FrmConfig);
      this.FormClosing += new FormClosingEventHandler(this.FrmConfig_FormClosing);
      this.Load += new EventHandler(this.FrmConfig_Load);
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.tabConfig.EndInit();
      this.tabConfig.ResumeLayout(false);
      this.tpgCompanyInfo.ResumeLayout(false);
      this.tpgCompanyInfo.PerformLayout();
      this.bteLogoPath.Properties.EndInit();
      this.pictureEdit1.Properties.EndInit();
      this.txtDienThoaiCty.Properties.EndInit();
      this.txtDiaChiCty.Properties.EndInit();
      this.txtTenCty.Properties.EndInit();
      this.tpgRunningMode.ResumeLayout(false);
      this.txtPassword.Properties.EndInit();
      this.txtUsername.Properties.EndInit();
      this.txtDatabase.Properties.EndInit();
      this.txtServer.Properties.EndInit();
      this.grpStandAlone.EndInit();
      this.grpStandAlone.ResumeLayout(false);
      this.grpService.EndInit();
      this.grpService.ResumeLayout(false);
      this.grpService.PerformLayout();
      this.txtServerIP.Properties.EndInit();
      this.lueRunningMode.Properties.EndInit();
      this.tpgOptions.ResumeLayout(false);
      this.xtraTabControl1.EndInit();
      this.xtraTabControl1.ResumeLayout(false);
      this.tpgRange.ResumeLayout(false);
      this.spnKLTronLonNhat.Properties.EndInit();
      this.spnKLTronNhoNhat.Properties.EndInit();
      this.spnKLChoLonNhat.Properties.EndInit();
      this.tpgFilter.ResumeLayout(false);
      this.spnLatestBaoCaoDays.Properties.EndInit();
      this.spnLatestHopDongDays.Properties.EndInit();
      this.spnLatestPhieuTronDays.Properties.EndInit();
      this.tpgOthers.ResumeLayout(false);
      this.bteImportPath_CT.Properties.EndInit();
      this.btePdfReaderPath.Properties.EndInit();
      this.bteImportPath_GH.Properties.EndInit();
      this.bteExportPath.Properties.EndInit();
      this.chkDev.Properties.EndInit();
      this.chkTronOnline.Properties.EndInit();
      this.chkTinhBuTru.Properties.EndInit();
      this.xtraTabPage1.ResumeLayout(false);
      this.beFilePathPLC.Properties.EndInit();
      this.tpgGeneral.ResumeLayout(false);
      this.tpgGeneral.PerformLayout();
      this.lueLanguages.Properties.EndInit();
      this.txtLANPort.Properties.EndInit();
      this.txtLANIP.Properties.EndInit();
      this.txtPLCPort.Properties.EndInit();
      this.rdgLanguageRes.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}

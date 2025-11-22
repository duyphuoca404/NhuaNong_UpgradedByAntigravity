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

namespace NhuaNong
{
  public partial class FrmConfig : DialogViewBase
  {

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


    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
      this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.btnOk = new DevExpress.XtraEditors.SimpleButton();
      this.tabConfig = new DevExpress.XtraTab.XtraTabControl();
      this.tpgCompanyInfo = new DevExpress.XtraTab.XtraTabPage();
      this.bteLogoPath = new DevExpress.XtraEditors.ButtonEdit();
      this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
      this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
      this.btnLoadImage = new DevExpress.XtraEditors.SimpleButton();
      this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
      this.txtDienThoaiCty = new DevExpress.XtraEditors.TextEdit();
      this.txtDiaChiCty = new DevExpress.XtraEditors.TextEdit();
      this.txtTenCty = new DevExpress.XtraEditors.TextEdit();
      this.lblPhone = new DevExpress.XtraEditors.LabelControl();
      this.lblAddress = new DevExpress.XtraEditors.LabelControl();
      this.lblCompanyName = new DevExpress.XtraEditors.LabelControl();
      this.tpgRunningMode = new DevExpress.XtraTab.XtraTabPage();
      this.txtPassword = new DevExpress.XtraEditors.TextEdit();
      this.txtUsername = new DevExpress.XtraEditors.TextEdit();
      this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
      this.txtServer = new DevExpress.XtraEditors.TextEdit();
      this.lblPassword = new DevExpress.XtraEditors.LabelControl();
      this.lblUsername = new DevExpress.XtraEditors.LabelControl();
      this.lblDatabase = new DevExpress.XtraEditors.LabelControl();
      this.lblServerName = new DevExpress.XtraEditors.LabelControl();
      this.grpStandAlone = new DevExpress.XtraEditors.GroupControl();
      this.grpService = new DevExpress.XtraEditors.GroupControl();
      this.txtServerIP = new DevExpress.XtraEditors.TextEdit();
      this.lblEndpointAddress = new DevExpress.XtraEditors.LabelControl();
      this.lblRunningMode = new DevExpress.XtraEditors.LabelControl();
      this.lueRunningMode = new DevExpress.XtraEditors.LookUpEdit();
      this.tpgOptions = new DevExpress.XtraTab.XtraTabPage();
      this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
      this.tpgRange = new DevExpress.XtraTab.XtraTabPage();
      this.spnKLTronLonNhat = new DevExpress.XtraEditors.SpinEdit();
      this.spnKLTronNhoNhat = new DevExpress.XtraEditors.SpinEdit();
      this.spnKLChoLonNhat = new DevExpress.XtraEditors.SpinEdit();
      this.lblKLTronLonNhat = new DevExpress.XtraEditors.LabelControl();
      this.lblKLTronNhoNhat = new DevExpress.XtraEditors.LabelControl();
      this.lblKLChoLonNhat = new DevExpress.XtraEditors.LabelControl();
      this.tpgFilter = new DevExpress.XtraTab.XtraTabPage();
      this.spnLatestBaoCaoDays = new DevExpress.XtraEditors.SpinEdit();
      this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
      this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
      this.spnLatestHopDongDays = new DevExpress.XtraEditors.SpinEdit();
      this.spnLatestPhieuTronDays = new DevExpress.XtraEditors.SpinEdit();
      this.lblLatestDay2 = new DevExpress.XtraEditors.LabelControl();
      this.lblLatestDay = new DevExpress.XtraEditors.LabelControl();
      this.lblPhieuTron = new DevExpress.XtraEditors.LabelControl();
      this.lblContract = new DevExpress.XtraEditors.LabelControl();
      this.tpgOthers = new DevExpress.XtraTab.XtraTabPage();
      this.bteImportPath_CT = new DevExpress.XtraEditors.ButtonEdit();
      this.btePdfReaderPath = new DevExpress.XtraEditors.ButtonEdit();
      this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
      this.bteImportPath_GH = new DevExpress.XtraEditors.ButtonEdit();
      this.bteExportPath = new DevExpress.XtraEditors.ButtonEdit();
      this.chkDev = new DevExpress.XtraEditors.CheckEdit();
      this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
      this.chkTronOnline = new DevExpress.XtraEditors.CheckEdit();
      this.chkTinhBuTru = new DevExpress.XtraEditors.CheckEdit();
      this.btnReportPathBrowse = new DevExpress.XtraEditors.SimpleButton();
      this.btnTestReportPath = new DevExpress.XtraEditors.SimpleButton();
      this.lblReportPath = new DevExpress.XtraEditors.LabelControl();
      this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
      this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
      this.beFilePathPLC = new DevExpress.XtraEditors.ButtonEdit();
      this.btnUploadToPLC = new DevExpress.XtraEditors.SimpleButton();
      this.tpgGeneral = new DevExpress.XtraTab.XtraTabPage();
      this.lueLanguages = new DevExpress.XtraEditors.LookUpEdit();
      this.txtLANPort = new DevExpress.XtraEditors.TextEdit();
      this.txtLANIP = new DevExpress.XtraEditors.TextEdit();
      this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
      this.lblIP = new DevExpress.XtraEditors.LabelControl();
      this.txtPLCPort = new DevExpress.XtraEditors.TextEdit();
      this.btnTestPort = new DevExpress.XtraEditors.SimpleButton();
      this.btnChangePLCPort = new DevExpress.XtraEditors.SimpleButton();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.rdgLanguageRes = new DevExpress.XtraEditors.RadioGroup();
      this.lblLanguage = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tabConfig)).BeginInit();
      this.tabConfig.SuspendLayout();
      this.tpgCompanyInfo.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bteLogoPath.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiCty.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiCty.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTenCty.Properties)).BeginInit();
      this.tpgRunningMode.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.grpStandAlone)).BeginInit();
      this.grpStandAlone.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grpService)).BeginInit();
      this.grpService.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtServerIP.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lueRunningMode.Properties)).BeginInit();
      this.tpgOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
      this.xtraTabControl1.SuspendLayout();
      this.tpgRange.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spnKLTronLonNhat.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spnKLTronNhoNhat.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spnKLChoLonNhat.Properties)).BeginInit();
      this.tpgFilter.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spnLatestBaoCaoDays.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spnLatestHopDongDays.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spnLatestPhieuTronDays.Properties)).BeginInit();
      this.tpgOthers.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bteImportPath_CT.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.btePdfReaderPath.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bteImportPath_GH.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bteExportPath.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkDev.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkTronOnline.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkTinhBuTru.Properties)).BeginInit();
      this.xtraTabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.beFilePathPLC.Properties)).BeginInit();
      this.tpgGeneral.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lueLanguages.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtLANPort.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtLANIP.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPLCPort.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.rdgLanguageRes.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // panelControl1
      // 
      this.panelControl1.Controls.Add(this.simpleButton3);
      this.panelControl1.Controls.Add(this.simpleButton2);
      this.panelControl1.Controls.Add(this.btnCancel);
      this.panelControl1.Controls.Add(this.btnOk);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelControl1.Location = new System.Drawing.Point(0, 326);
      this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(691, 26);
      this.panelControl1.TabIndex = 0;
      // 
      // simpleButton3
      // 
      this.simpleButton3.Location = new System.Drawing.Point(327, 5);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.Size = new System.Drawing.Size(94, 30);
      this.simpleButton3.TabIndex = 3;
      this.simpleButton3.Text = "Đóng";
      this.simpleButton3.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // simpleButton2
      // 
      this.simpleButton2.Location = new System.Drawing.Point(208, 5);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.Size = new System.Drawing.Size(94, 30);
      this.simpleButton2.TabIndex = 2;
      this.simpleButton2.Text = "Lưu";
      this.simpleButton2.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.Appearance.Options.UseFont = true;
      this.btnCancel.Location = new System.Drawing.Point(1045, 6);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(98, 30);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Huỷ Bỏ";
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOk
      // 
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOk.Appearance.Options.UseFont = true;
      this.btnOk.Location = new System.Drawing.Point(931, 6);
      this.btnOk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(98, 30);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "Lưu";
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // tabConfig
      // 
      this.tabConfig.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabConfig.Location = new System.Drawing.Point(0, 0);
      this.tabConfig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tabConfig.Name = "tabConfig";
      this.tabConfig.SelectedTabPage = this.tpgCompanyInfo;
      this.tabConfig.Size = new System.Drawing.Size(691, 326);
      this.tabConfig.TabIndex = 0;
      this.tabConfig.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpgRunningMode,
            this.tpgCompanyInfo,
            this.tpgOptions,
            this.tpgGeneral});
      // 
      // tpgCompanyInfo
      // 
      this.tpgCompanyInfo.Controls.Add(this.bteLogoPath);
      this.tpgCompanyInfo.Controls.Add(this.labelControl3);
      this.tpgCompanyInfo.Controls.Add(this.simpleButton1);
      this.tpgCompanyInfo.Controls.Add(this.labelControl2);
      this.tpgCompanyInfo.Controls.Add(this.btnLoadImage);
      this.tpgCompanyInfo.Controls.Add(this.pictureEdit1);
      this.tpgCompanyInfo.Controls.Add(this.txtDienThoaiCty);
      this.tpgCompanyInfo.Controls.Add(this.txtDiaChiCty);
      this.tpgCompanyInfo.Controls.Add(this.txtTenCty);
      this.tpgCompanyInfo.Controls.Add(this.lblPhone);
      this.tpgCompanyInfo.Controls.Add(this.lblAddress);
      this.tpgCompanyInfo.Controls.Add(this.lblCompanyName);
      this.tpgCompanyInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgCompanyInfo.Name = "tpgCompanyInfo";
      this.tpgCompanyInfo.Size = new System.Drawing.Size(689, 301);
      this.tpgCompanyInfo.Text = "Thông Tin Cty";
      // 
      // bteLogoPath
      // 
      this.bteLogoPath.Location = new System.Drawing.Point(209, 144);
      this.bteLogoPath.Name = "bteLogoPath";
      this.bteLogoPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.bteLogoPath.Size = new System.Drawing.Size(380, 25);
      this.bteLogoPath.TabIndex = 12;
      this.bteLogoPath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
      this.bteLogoPath.EditValueChanged += new System.EventHandler(this.bteLogoPath_EditValueChanged);
      // 
      // labelControl3
      // 
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Appearance.Options.UseTextOptions = true;
      this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl3.Location = new System.Drawing.Point(61, 145);
      this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new System.Drawing.Size(120, 20);
      this.labelControl3.TabIndex = 11;
      this.labelControl3.Text = "Đường dẫn logo";
      // 
      // simpleButton1
      // 
      this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.Location = new System.Drawing.Point(350, 180);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new System.Drawing.Size(123, 38);
      this.simpleButton1.TabIndex = 10;
      this.simpleButton1.Text = "Load Logo";
      this.simpleButton1.Visible = false;
      this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
      // 
      // labelControl2
      // 
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new System.Drawing.Point(407, 107);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new System.Drawing.Size(74, 16);
      this.labelControl2.TabIndex = 9;
      this.labelControl2.Text = "Logo Công ty";
      // 
      // btnLoadImage
      // 
      this.btnLoadImage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLoadImage.Appearance.Options.UseFont = true;
      this.btnLoadImage.Location = new System.Drawing.Point(209, 180);
      this.btnLoadImage.Name = "btnLoadImage";
      this.btnLoadImage.Size = new System.Drawing.Size(123, 38);
      this.btnLoadImage.TabIndex = 7;
      this.btnLoadImage.Text = "Thay đổi";
      this.btnLoadImage.Visible = false;
      this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
      // 
      // pictureEdit1
      // 
      this.pictureEdit1.Location = new System.Drawing.Point(623, 35);
      this.pictureEdit1.Name = "pictureEdit1";
      this.pictureEdit1.Properties.NullText = " ";
      this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
      this.pictureEdit1.Size = new System.Drawing.Size(125, 125);
      this.pictureEdit1.TabIndex = 6;
      this.pictureEdit1.LoadCompleted += new System.EventHandler(this.pictureEdit1_LoadCompleted);
      this.pictureEdit1.TextChanged += new System.EventHandler(this.pictureEdit1_TextChanged);
      // 
      // txtDienThoaiCty
      // 
      this.txtDienThoaiCty.Location = new System.Drawing.Point(209, 106);
      this.txtDienThoaiCty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtDienThoaiCty.Name = "txtDienThoaiCty";
      this.txtDienThoaiCty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDienThoaiCty.Properties.Appearance.Options.UseFont = true;
      this.txtDienThoaiCty.Size = new System.Drawing.Size(380, 28);
      this.txtDienThoaiCty.TabIndex = 5;
      // 
      // txtDiaChiCty
      // 
      this.txtDiaChiCty.Location = new System.Drawing.Point(209, 69);
      this.txtDiaChiCty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtDiaChiCty.Name = "txtDiaChiCty";
      this.txtDiaChiCty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDiaChiCty.Properties.Appearance.Options.UseFont = true;
      this.txtDiaChiCty.Size = new System.Drawing.Size(380, 28);
      this.txtDiaChiCty.TabIndex = 4;
      // 
      // txtTenCty
      // 
      this.txtTenCty.Location = new System.Drawing.Point(209, 31);
      this.txtTenCty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtTenCty.Name = "txtTenCty";
      this.txtTenCty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTenCty.Properties.Appearance.Options.UseFont = true;
      this.txtTenCty.Size = new System.Drawing.Size(380, 28);
      this.txtTenCty.TabIndex = 3;
      // 
      // lblPhone
      // 
      this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Appearance.Options.UseTextOptions = true;
      this.lblPhone.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblPhone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblPhone.Location = new System.Drawing.Point(61, 110);
      this.lblPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new System.Drawing.Size(120, 20);
      this.lblPhone.TabIndex = 2;
      this.lblPhone.Text = "Số Điện Thoại";
      // 
      // lblAddress
      // 
      this.lblAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAddress.Appearance.Options.UseFont = true;
      this.lblAddress.Appearance.Options.UseTextOptions = true;
      this.lblAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblAddress.Location = new System.Drawing.Point(61, 72);
      this.lblAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(120, 20);
      this.lblAddress.TabIndex = 1;
      this.lblAddress.Text = "Địa Chỉ";
      // 
      // lblCompanyName
      // 
      this.lblCompanyName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCompanyName.Appearance.Options.UseFont = true;
      this.lblCompanyName.Appearance.Options.UseTextOptions = true;
      this.lblCompanyName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblCompanyName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblCompanyName.Location = new System.Drawing.Point(61, 35);
      this.lblCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblCompanyName.Name = "lblCompanyName";
      this.lblCompanyName.Size = new System.Drawing.Size(120, 20);
      this.lblCompanyName.TabIndex = 0;
      this.lblCompanyName.Text = "Tên Công Ty";
      // 
      // tpgRunningMode
      // 
      this.tpgRunningMode.Controls.Add(this.txtPassword);
      this.tpgRunningMode.Controls.Add(this.txtUsername);
      this.tpgRunningMode.Controls.Add(this.txtDatabase);
      this.tpgRunningMode.Controls.Add(this.txtServer);
      this.tpgRunningMode.Controls.Add(this.lblPassword);
      this.tpgRunningMode.Controls.Add(this.lblUsername);
      this.tpgRunningMode.Controls.Add(this.lblDatabase);
      this.tpgRunningMode.Controls.Add(this.lblServerName);
      this.tpgRunningMode.Controls.Add(this.grpStandAlone);
      this.tpgRunningMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgRunningMode.Name = "tpgRunningMode";
      this.tpgRunningMode.Size = new System.Drawing.Size(689, 287);
      this.tpgRunningMode.Text = "Running Mode";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(209, 144);
      this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Properties.Appearance.Options.UseFont = true;
      this.txtPassword.Properties.MaxLength = 20;
      this.txtPassword.Properties.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(236, 28);
      this.txtPassword.TabIndex = 15;
      // 
      // txtUsername
      // 
      this.txtUsername.Location = new System.Drawing.Point(209, 106);
      this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUsername.Properties.Appearance.Options.UseFont = true;
      this.txtUsername.Size = new System.Drawing.Size(236, 28);
      this.txtUsername.TabIndex = 14;
      // 
      // txtDatabase
      // 
      this.txtDatabase.Location = new System.Drawing.Point(209, 69);
      this.txtDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtDatabase.Name = "txtDatabase";
      this.txtDatabase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDatabase.Properties.Appearance.Options.UseFont = true;
      this.txtDatabase.Size = new System.Drawing.Size(236, 28);
      this.txtDatabase.TabIndex = 13;
      // 
      // txtServer
      // 
      this.txtServer.Location = new System.Drawing.Point(209, 31);
      this.txtServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtServer.Name = "txtServer";
      this.txtServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtServer.Properties.Appearance.Options.UseFont = true;
      this.txtServer.Size = new System.Drawing.Size(236, 28);
      this.txtServer.TabIndex = 12;
      // 
      // lblPassword
      // 
      this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPassword.Appearance.Options.UseFont = true;
      this.lblPassword.Appearance.Options.UseTextOptions = true;
      this.lblPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblPassword.Location = new System.Drawing.Point(61, 147);
      this.lblPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(116, 20);
      this.lblPassword.TabIndex = 11;
      this.lblPassword.Text = "Password";
      // 
      // lblUsername
      // 
      this.lblUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUsername.Appearance.Options.UseFont = true;
      this.lblUsername.Appearance.Options.UseTextOptions = true;
      this.lblUsername.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblUsername.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblUsername.Location = new System.Drawing.Point(60, 110);
      this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(118, 20);
      this.lblUsername.TabIndex = 10;
      this.lblUsername.Text = "Username";
      // 
      // lblDatabase
      // 
      this.lblDatabase.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDatabase.Appearance.Options.UseFont = true;
      this.lblDatabase.Appearance.Options.UseTextOptions = true;
      this.lblDatabase.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblDatabase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblDatabase.Location = new System.Drawing.Point(61, 72);
      this.lblDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblDatabase.Name = "lblDatabase";
      this.lblDatabase.Size = new System.Drawing.Size(116, 20);
      this.lblDatabase.TabIndex = 9;
      this.lblDatabase.Text = "Database";
      // 
      // lblServerName
      // 
      this.lblServerName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblServerName.Appearance.Options.UseFont = true;
      this.lblServerName.Appearance.Options.UseTextOptions = true;
      this.lblServerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblServerName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblServerName.Location = new System.Drawing.Point(61, 35);
      this.lblServerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblServerName.Name = "lblServerName";
      this.lblServerName.Size = new System.Drawing.Size(116, 20);
      this.lblServerName.TabIndex = 8;
      this.lblServerName.Text = "Server Name";
      // 
      // grpStandAlone
      // 
      this.grpStandAlone.Controls.Add(this.grpService);
      this.grpStandAlone.Controls.Add(this.lblRunningMode);
      this.grpStandAlone.Controls.Add(this.lueRunningMode);
      this.grpStandAlone.Location = new System.Drawing.Point(1, 269);
      this.grpStandAlone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grpStandAlone.Name = "grpStandAlone";
      this.grpStandAlone.Size = new System.Drawing.Size(861, 86);
      this.grpStandAlone.TabIndex = 0;
      this.grpStandAlone.Text = "Cấu hình cơ sở dữ liệu";
      this.grpStandAlone.Visible = false;
      // 
      // grpService
      // 
      this.grpService.Controls.Add(this.txtServerIP);
      this.grpService.Controls.Add(this.lblEndpointAddress);
      this.grpService.Location = new System.Drawing.Point(63, 164);
      this.grpService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grpService.Name = "grpService";
      this.grpService.Size = new System.Drawing.Size(501, 62);
      this.grpService.TabIndex = 1;
      this.grpService.Text = "Service";
      this.grpService.Visible = false;
      // 
      // txtServerIP
      // 
      this.txtServerIP.Location = new System.Drawing.Point(154, 30);
      this.txtServerIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtServerIP.Name = "txtServerIP";
      this.txtServerIP.Size = new System.Drawing.Size(315, 20);
      this.txtServerIP.TabIndex = 1;
      this.txtServerIP.Visible = false;
      // 
      // lblEndpointAddress
      // 
      this.lblEndpointAddress.Location = new System.Drawing.Point(81, 32);
      this.lblEndpointAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblEndpointAddress.Name = "lblEndpointAddress";
      this.lblEndpointAddress.Size = new System.Drawing.Size(39, 13);
      this.lblEndpointAddress.TabIndex = 0;
      this.lblEndpointAddress.Text = "Address";
      this.lblEndpointAddress.Visible = false;
      // 
      // lblRunningMode
      // 
      this.lblRunningMode.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblRunningMode.Appearance.Options.UseFont = true;
      this.lblRunningMode.Appearance.Options.UseTextOptions = true;
      this.lblRunningMode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblRunningMode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblRunningMode.Location = new System.Drawing.Point(219, 233);
      this.lblRunningMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblRunningMode.Name = "lblRunningMode";
      this.lblRunningMode.Size = new System.Drawing.Size(107, 16);
      this.lblRunningMode.TabIndex = 3;
      this.lblRunningMode.Text = "Running Mode";
      this.lblRunningMode.Visible = false;
      // 
      // lueRunningMode
      // 
      this.lueRunningMode.Location = new System.Drawing.Point(333, 230);
      this.lueRunningMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lueRunningMode.Name = "lueRunningMode";
      this.lueRunningMode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lueRunningMode.Properties.Appearance.Options.UseFont = true;
      this.lueRunningMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lueRunningMode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Running Mode")});
      this.lueRunningMode.Properties.DisplayMember = "Code";
      this.lueRunningMode.Properties.DropDownRows = 2;
      this.lueRunningMode.Properties.NullText = "";
      this.lueRunningMode.Properties.PopupWidth = 60;
      this.lueRunningMode.Properties.ShowFooter = false;
      this.lueRunningMode.Properties.ValueMember = "ID";
      this.lueRunningMode.Size = new System.Drawing.Size(189, 22);
      this.lueRunningMode.TabIndex = 2;
      this.lueRunningMode.Visible = false;
      // 
      // tpgOptions
      // 
      this.tpgOptions.Controls.Add(this.xtraTabControl1);
      this.tpgOptions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgOptions.Name = "tpgOptions";
      this.tpgOptions.Size = new System.Drawing.Size(689, 287);
      this.tpgOptions.Text = "Hệ Thống";
      // 
      // xtraTabControl1
      // 
      this.xtraTabControl1.Location = new System.Drawing.Point(4, 2);
      this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.xtraTabControl1.Name = "xtraTabControl1";
      this.xtraTabControl1.SelectedTabPage = this.tpgRange;
      this.xtraTabControl1.Size = new System.Drawing.Size(854, 353);
      this.xtraTabControl1.TabIndex = 0;
      this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpgRange,
            this.tpgFilter,
            this.tpgOthers,
            this.xtraTabPage1});
      // 
      // tpgRange
      // 
      this.tpgRange.Controls.Add(this.spnKLTronLonNhat);
      this.tpgRange.Controls.Add(this.spnKLTronNhoNhat);
      this.tpgRange.Controls.Add(this.spnKLChoLonNhat);
      this.tpgRange.Controls.Add(this.lblKLTronLonNhat);
      this.tpgRange.Controls.Add(this.lblKLTronNhoNhat);
      this.tpgRange.Controls.Add(this.lblKLChoLonNhat);
      this.tpgRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgRange.Name = "tpgRange";
      this.tpgRange.Size = new System.Drawing.Size(681, 262);
      this.tpgRange.Text = "Ràng Buộc";
      // 
      // spnKLTronLonNhat
      // 
      this.spnKLTronLonNhat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.spnKLTronLonNhat.Location = new System.Drawing.Point(290, 112);
      this.spnKLTronLonNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.spnKLTronLonNhat.Name = "spnKLTronLonNhat";
      this.spnKLTronLonNhat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spnKLTronLonNhat.Properties.Appearance.Options.UseFont = true;
      this.spnKLTronLonNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.spnKLTronLonNhat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.spnKLTronLonNhat.Properties.EditFormat.FormatString = "n1";
      this.spnKLTronLonNhat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.spnKLTronLonNhat.Properties.Mask.EditMask = "n1";
      this.spnKLTronLonNhat.Size = new System.Drawing.Size(134, 28);
      this.spnKLTronLonNhat.TabIndex = 5;
      // 
      // spnKLTronNhoNhat
      // 
      this.spnKLTronNhoNhat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.spnKLTronNhoNhat.Location = new System.Drawing.Point(290, 75);
      this.spnKLTronNhoNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.spnKLTronNhoNhat.Name = "spnKLTronNhoNhat";
      this.spnKLTronNhoNhat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spnKLTronNhoNhat.Properties.Appearance.Options.UseFont = true;
      this.spnKLTronNhoNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.spnKLTronNhoNhat.Properties.DisplayFormat.FormatString = "n1";
      this.spnKLTronNhoNhat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.spnKLTronNhoNhat.Properties.EditFormat.FormatString = "n1";
      this.spnKLTronNhoNhat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.spnKLTronNhoNhat.Properties.Mask.EditMask = "n1";
      this.spnKLTronNhoNhat.Size = new System.Drawing.Size(134, 28);
      this.spnKLTronNhoNhat.TabIndex = 4;
      // 
      // spnKLChoLonNhat
      // 
      this.spnKLChoLonNhat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.spnKLChoLonNhat.Location = new System.Drawing.Point(290, 37);
      this.spnKLChoLonNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.spnKLChoLonNhat.Name = "spnKLChoLonNhat";
      this.spnKLChoLonNhat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spnKLChoLonNhat.Properties.Appearance.Options.UseFont = true;
      this.spnKLChoLonNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.spnKLChoLonNhat.Properties.DisplayFormat.FormatString = "n1";
      this.spnKLChoLonNhat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.spnKLChoLonNhat.Properties.EditFormat.FormatString = "n1";
      this.spnKLChoLonNhat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
      this.spnKLChoLonNhat.Properties.Mask.EditMask = "n1";
      this.spnKLChoLonNhat.Size = new System.Drawing.Size(134, 28);
      this.spnKLChoLonNhat.TabIndex = 3;
      // 
      // lblKLTronLonNhat
      // 
      this.lblKLTronLonNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKLTronLonNhat.Appearance.Options.UseFont = true;
      this.lblKLTronLonNhat.Appearance.Options.UseTextOptions = true;
      this.lblKLTronLonNhat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblKLTronLonNhat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblKLTronLonNhat.Location = new System.Drawing.Point(52, 116);
      this.lblKLTronLonNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblKLTronLonNhat.Name = "lblKLTronLonNhat";
      this.lblKLTronLonNhat.Size = new System.Drawing.Size(200, 20);
      this.lblKLTronLonNhat.TabIndex = 2;
      this.lblKLTronLonNhat.Text = "Số khối trộn lớn nhất";
      // 
      // lblKLTronNhoNhat
      // 
      this.lblKLTronNhoNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKLTronNhoNhat.Appearance.Options.UseFont = true;
      this.lblKLTronNhoNhat.Appearance.Options.UseTextOptions = true;
      this.lblKLTronNhoNhat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblKLTronNhoNhat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblKLTronNhoNhat.Location = new System.Drawing.Point(52, 79);
      this.lblKLTronNhoNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblKLTronNhoNhat.Name = "lblKLTronNhoNhat";
      this.lblKLTronNhoNhat.Size = new System.Drawing.Size(200, 20);
      this.lblKLTronNhoNhat.TabIndex = 1;
      this.lblKLTronNhoNhat.Text = "Số khối trộn nhỏ nhất";
      // 
      // lblKLChoLonNhat
      // 
      this.lblKLChoLonNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKLChoLonNhat.Appearance.Options.UseFont = true;
      this.lblKLChoLonNhat.Appearance.Options.UseTextOptions = true;
      this.lblKLChoLonNhat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblKLChoLonNhat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblKLChoLonNhat.Location = new System.Drawing.Point(52, 41);
      this.lblKLChoLonNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblKLChoLonNhat.Name = "lblKLChoLonNhat";
      this.lblKLChoLonNhat.Size = new System.Drawing.Size(200, 20);
      this.lblKLChoLonNhat.TabIndex = 0;
      this.lblKLChoLonNhat.Text = "Số khối lớn nhất mà xe chở";
      // 
      // tpgFilter
      // 
      this.tpgFilter.Controls.Add(this.spnLatestBaoCaoDays);
      this.tpgFilter.Controls.Add(this.labelControl5);
      this.tpgFilter.Controls.Add(this.labelControl6);
      this.tpgFilter.Controls.Add(this.spnLatestHopDongDays);
      this.tpgFilter.Controls.Add(this.spnLatestPhieuTronDays);
      this.tpgFilter.Controls.Add(this.lblLatestDay2);
      this.tpgFilter.Controls.Add(this.lblLatestDay);
      this.tpgFilter.Controls.Add(this.lblPhieuTron);
      this.tpgFilter.Controls.Add(this.lblContract);
      this.tpgFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgFilter.Name = "tpgFilter";
      this.tpgFilter.Size = new System.Drawing.Size(681, 257);
      this.tpgFilter.Text = "Bộ Lọc";
      // 
      // spnLatestBaoCaoDays
      // 
      this.spnLatestBaoCaoDays.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.spnLatestBaoCaoDays.Location = new System.Drawing.Point(151, 113);
      this.spnLatestBaoCaoDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.spnLatestBaoCaoDays.Name = "spnLatestBaoCaoDays";
      this.spnLatestBaoCaoDays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spnLatestBaoCaoDays.Properties.Appearance.Options.UseFont = true;
      this.spnLatestBaoCaoDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.spnLatestBaoCaoDays.Size = new System.Drawing.Size(134, 28);
      this.spnLatestBaoCaoDays.TabIndex = 8;
      // 
      // labelControl5
      // 
      this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Appearance.Options.UseTextOptions = true;
      this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
      this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl5.Location = new System.Drawing.Point(300, 113);
      this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new System.Drawing.Size(193, 20);
      this.labelControl5.TabIndex = 7;
      this.labelControl5.Text = "ngày gần đây nhất";
      // 
      // labelControl6
      // 
      this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl6.Appearance.Options.UseFont = true;
      this.labelControl6.Appearance.Options.UseTextOptions = true;
      this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl6.Location = new System.Drawing.Point(33, 113);
      this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new System.Drawing.Size(94, 20);
      this.labelControl6.TabIndex = 6;
      this.labelControl6.Text = "Báo cáo";
      // 
      // spnLatestHopDongDays
      // 
      this.spnLatestHopDongDays.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.spnLatestHopDongDays.Location = new System.Drawing.Point(151, 38);
      this.spnLatestHopDongDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.spnLatestHopDongDays.Name = "spnLatestHopDongDays";
      this.spnLatestHopDongDays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spnLatestHopDongDays.Properties.Appearance.Options.UseFont = true;
      this.spnLatestHopDongDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.spnLatestHopDongDays.Size = new System.Drawing.Size(134, 28);
      this.spnLatestHopDongDays.TabIndex = 5;
      // 
      // spnLatestPhieuTronDays
      // 
      this.spnLatestPhieuTronDays.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.spnLatestPhieuTronDays.Location = new System.Drawing.Point(151, 75);
      this.spnLatestPhieuTronDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.spnLatestPhieuTronDays.Name = "spnLatestPhieuTronDays";
      this.spnLatestPhieuTronDays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.spnLatestPhieuTronDays.Properties.Appearance.Options.UseFont = true;
      this.spnLatestPhieuTronDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.spnLatestPhieuTronDays.Size = new System.Drawing.Size(134, 28);
      this.spnLatestPhieuTronDays.TabIndex = 4;
      // 
      // lblLatestDay2
      // 
      this.lblLatestDay2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLatestDay2.Appearance.Options.UseFont = true;
      this.lblLatestDay2.Appearance.Options.UseTextOptions = true;
      this.lblLatestDay2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
      this.lblLatestDay2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblLatestDay2.Location = new System.Drawing.Point(300, 79);
      this.lblLatestDay2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblLatestDay2.Name = "lblLatestDay2";
      this.lblLatestDay2.Size = new System.Drawing.Size(193, 20);
      this.lblLatestDay2.TabIndex = 3;
      this.lblLatestDay2.Text = "ngày gần đây nhất";
      // 
      // lblLatestDay
      // 
      this.lblLatestDay.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLatestDay.Appearance.Options.UseFont = true;
      this.lblLatestDay.Appearance.Options.UseTextOptions = true;
      this.lblLatestDay.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
      this.lblLatestDay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblLatestDay.Location = new System.Drawing.Point(300, 42);
      this.lblLatestDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblLatestDay.Name = "lblLatestDay";
      this.lblLatestDay.Size = new System.Drawing.Size(193, 20);
      this.lblLatestDay.TabIndex = 2;
      this.lblLatestDay.Text = "ngày gần đây nhất";
      // 
      // lblPhieuTron
      // 
      this.lblPhieuTron.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblPhieuTron.Appearance.Options.UseFont = true;
      this.lblPhieuTron.Appearance.Options.UseTextOptions = true;
      this.lblPhieuTron.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblPhieuTron.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblPhieuTron.Location = new System.Drawing.Point(33, 79);
      this.lblPhieuTron.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblPhieuTron.Name = "lblPhieuTron";
      this.lblPhieuTron.Size = new System.Drawing.Size(94, 20);
      this.lblPhieuTron.TabIndex = 1;
      this.lblPhieuTron.Text = "Phiếu Trộn";
      // 
      // lblContract
      // 
      this.lblContract.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblContract.Appearance.Options.UseFont = true;
      this.lblContract.Appearance.Options.UseTextOptions = true;
      this.lblContract.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblContract.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblContract.Location = new System.Drawing.Point(33, 42);
      this.lblContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblContract.Name = "lblContract";
      this.lblContract.Size = new System.Drawing.Size(94, 20);
      this.lblContract.TabIndex = 0;
      this.lblContract.Text = "Hợp Đồng";
      // 
      // tpgOthers
      // 
      this.tpgOthers.Controls.Add(this.bteImportPath_CT);
      this.tpgOthers.Controls.Add(this.btePdfReaderPath);
      this.tpgOthers.Controls.Add(this.labelControl9);
      this.tpgOthers.Controls.Add(this.bteImportPath_GH);
      this.tpgOthers.Controls.Add(this.bteExportPath);
      this.tpgOthers.Controls.Add(this.chkDev);
      this.tpgOthers.Controls.Add(this.labelControl7);
      this.tpgOthers.Controls.Add(this.chkTronOnline);
      this.tpgOthers.Controls.Add(this.chkTinhBuTru);
      this.tpgOthers.Controls.Add(this.btnReportPathBrowse);
      this.tpgOthers.Controls.Add(this.btnTestReportPath);
      this.tpgOthers.Controls.Add(this.lblReportPath);
      this.tpgOthers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgOthers.Name = "tpgOthers";
      this.tpgOthers.Size = new System.Drawing.Size(681, 257);
      this.tpgOthers.Text = "Khác";
      // 
      // bteImportPath_CT
      // 
      this.bteImportPath_CT.Location = new System.Drawing.Point(169, 125);
      this.bteImportPath_CT.Name = "bteImportPath_CT";
      this.bteImportPath_CT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.bteImportPath_CT.Size = new System.Drawing.Size(575, 25);
      this.bteImportPath_CT.TabIndex = 16;
      this.bteImportPath_CT.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteImportPath_CT_ButtonClick);
      // 
      // btePdfReaderPath
      // 
      this.btePdfReaderPath.Location = new System.Drawing.Point(169, 169);
      this.btePdfReaderPath.Name = "btePdfReaderPath";
      this.btePdfReaderPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.btePdfReaderPath.Size = new System.Drawing.Size(575, 25);
      this.btePdfReaderPath.TabIndex = 16;
      this.btePdfReaderPath.Click += new System.EventHandler(this.btePdfReaderPath_Click);
      // 
      // labelControl9
      // 
      this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Appearance.Options.UseTextOptions = true;
      this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl9.Location = new System.Drawing.Point(9, 118);
      this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new System.Drawing.Size(146, 36);
      this.labelControl9.TabIndex = 15;
      this.labelControl9.Text = "Nhập File In Chi Tiết";
      // 
      // bteImportPath_GH
      // 
      this.bteImportPath_GH.Location = new System.Drawing.Point(169, 82);
      this.bteImportPath_GH.Name = "bteImportPath_GH";
      this.bteImportPath_GH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.bteImportPath_GH.Size = new System.Drawing.Size(575, 25);
      this.bteImportPath_GH.TabIndex = 14;
      this.bteImportPath_GH.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteImportPath_ButtonClick);
      // 
      // bteExportPath
      // 
      this.bteExportPath.Location = new System.Drawing.Point(169, 40);
      this.bteExportPath.Name = "bteExportPath";
      this.bteExportPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.bteExportPath.Size = new System.Drawing.Size(575, 25);
      this.bteExportPath.TabIndex = 13;
      this.bteExportPath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteExportPath_ButtonClick);
      // 
      // chkDev
      // 
      this.chkDev.Location = new System.Drawing.Point(53, 282);
      this.chkDev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.chkDev.Name = "chkDev";
      this.chkDev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkDev.Properties.Appearance.Options.UseFont = true;
      this.chkDev.Properties.Caption = "Dev";
      this.chkDev.Size = new System.Drawing.Size(348, 25);
      this.chkDev.TabIndex = 10;
      this.chkDev.Visible = false;
      // 
      // labelControl7
      // 
      this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl7.Appearance.Options.UseFont = true;
      this.labelControl7.Appearance.Options.UseTextOptions = true;
      this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl7.Location = new System.Drawing.Point(21, 74);
      this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new System.Drawing.Size(134, 36);
      this.labelControl7.TabIndex = 6;
      this.labelControl7.Text = "Nhập File In Nhanh";
      // 
      // chkTronOnline
      // 
      this.chkTronOnline.Location = new System.Drawing.Point(53, 220);
      this.chkTronOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.chkTronOnline.Name = "chkTronOnline";
      this.chkTronOnline.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkTronOnline.Properties.Appearance.Options.UseFont = true;
      this.chkTronOnline.Properties.Caption = "Hiển thị màn hình Vận Hành lúc khởi động";
      this.chkTronOnline.Size = new System.Drawing.Size(348, 25);
      this.chkTronOnline.TabIndex = 5;
      // 
      // chkTinhBuTru
      // 
      this.chkTinhBuTru.Location = new System.Drawing.Point(53, 252);
      this.chkTinhBuTru.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.chkTinhBuTru.Name = "chkTinhBuTru";
      this.chkTinhBuTru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chkTinhBuTru.Properties.Appearance.Options.UseFont = true;
      this.chkTinhBuTru.Properties.Caption = "Tính khối lượng bù trừ";
      this.chkTinhBuTru.Size = new System.Drawing.Size(348, 25);
      this.chkTinhBuTru.TabIndex = 4;
      this.chkTinhBuTru.Visible = false;
      // 
      // btnReportPathBrowse
      // 
      this.btnReportPathBrowse.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnReportPathBrowse.Appearance.Options.UseFont = true;
      this.btnReportPathBrowse.Location = new System.Drawing.Point(581, 177);
      this.btnReportPathBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnReportPathBrowse.Name = "btnReportPathBrowse";
      this.btnReportPathBrowse.Size = new System.Drawing.Size(163, 38);
      this.btnReportPathBrowse.TabIndex = 3;
      this.btnReportPathBrowse.Text = "Tìm Đường Dẫn";
      this.btnReportPathBrowse.Visible = false;
      this.btnReportPathBrowse.Click += new System.EventHandler(this.btnReportPathBrowse_Click);
      // 
      // btnTestReportPath
      // 
      this.btnTestReportPath.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTestReportPath.Appearance.Options.UseFont = true;
      this.btnTestReportPath.Location = new System.Drawing.Point(581, 223);
      this.btnTestReportPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnTestReportPath.Name = "btnTestReportPath";
      this.btnTestReportPath.Size = new System.Drawing.Size(163, 38);
      this.btnTestReportPath.TabIndex = 2;
      this.btnTestReportPath.Text = "Lưu Đường Dẫn";
      this.btnTestReportPath.Visible = false;
      this.btnTestReportPath.Click += new System.EventHandler(this.btnTestReportPath_Click);
      // 
      // lblReportPath
      // 
      this.lblReportPath.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblReportPath.Appearance.Options.UseFont = true;
      this.lblReportPath.Appearance.Options.UseTextOptions = true;
      this.lblReportPath.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.lblReportPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.lblReportPath.Location = new System.Drawing.Point(9, 33);
      this.lblReportPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblReportPath.Name = "lblReportPath";
      this.lblReportPath.Size = new System.Drawing.Size(146, 36);
      this.lblReportPath.TabIndex = 0;
      this.lblReportPath.Text = "Xuất File BC";
      // 
      // xtraTabPage1
      // 
      this.xtraTabPage1.Controls.Add(this.labelControl8);
      this.xtraTabPage1.Controls.Add(this.beFilePathPLC);
      this.xtraTabPage1.Controls.Add(this.btnUploadToPLC);
      this.xtraTabPage1.Name = "xtraTabPage1";
      this.xtraTabPage1.PageVisible = false;
      this.xtraTabPage1.Size = new System.Drawing.Size(681, 257);
      this.xtraTabPage1.Text = "Upload Program PLC";
      // 
      // labelControl8
      // 
      this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl8.Appearance.Options.UseFont = true;
      this.labelControl8.Appearance.Options.UseTextOptions = true;
      this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
      this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl8.Location = new System.Drawing.Point(15, 33);
      this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new System.Drawing.Size(146, 36);
      this.labelControl8.TabIndex = 592;
      this.labelControl8.Text = "Đường dẫn File nạp";
      // 
      // beFilePathPLC
      // 
      this.beFilePathPLC.Location = new System.Drawing.Point(169, 38);
      this.beFilePathPLC.Name = "beFilePathPLC";
      this.beFilePathPLC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.beFilePathPLC.Properties.Appearance.Options.UseFont = true;
      this.beFilePathPLC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
      this.beFilePathPLC.Size = new System.Drawing.Size(380, 28);
      this.beFilePathPLC.TabIndex = 591;
      this.beFilePathPLC.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beFilePath_ButtonClick);
      // 
      // btnUploadToPLC
      // 
      this.btnUploadToPLC.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUploadToPLC.Appearance.Options.UseFont = true;
      this.btnUploadToPLC.Location = new System.Drawing.Point(571, 33);
      this.btnUploadToPLC.Name = "btnUploadToPLC";
      this.btnUploadToPLC.Size = new System.Drawing.Size(163, 38);
      this.btnUploadToPLC.TabIndex = 590;
      this.btnUploadToPLC.Text = "Upload";
      this.btnUploadToPLC.Click += new System.EventHandler(this.btnUploadToPLC_Click);
      // 
      // tpgGeneral
      // 
      this.tpgGeneral.Controls.Add(this.lueLanguages);
      this.tpgGeneral.Controls.Add(this.txtLANPort);
      this.tpgGeneral.Controls.Add(this.txtLANIP);
      this.tpgGeneral.Controls.Add(this.labelControl4);
      this.tpgGeneral.Controls.Add(this.lblIP);
      this.tpgGeneral.Controls.Add(this.txtPLCPort);
      this.tpgGeneral.Controls.Add(this.btnTestPort);
      this.tpgGeneral.Controls.Add(this.btnChangePLCPort);
      this.tpgGeneral.Controls.Add(this.labelControl1);
      this.tpgGeneral.Controls.Add(this.rdgLanguageRes);
      this.tpgGeneral.Controls.Add(this.lblLanguage);
      this.tpgGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tpgGeneral.Name = "tpgGeneral";
      this.tpgGeneral.Size = new System.Drawing.Size(689, 287);
      this.tpgGeneral.Text = "Cài Đặt Chung";
      // 
      // lueLanguages
      // 
      this.lueLanguages.Location = new System.Drawing.Point(125, 75);
      this.lueLanguages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lueLanguages.Name = "lueLanguages";
      this.lueLanguages.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lueLanguages.Properties.Appearance.Options.UseFont = true;
      this.lueLanguages.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.lueLanguages.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Languages")});
      this.lueLanguages.Properties.DisplayMember = "Code";
      this.lueLanguages.Properties.NullText = "";
      this.lueLanguages.Properties.ShowFooter = false;
      this.lueLanguages.Properties.ShowHeader = false;
      this.lueLanguages.Properties.ValueMember = "ID";
      this.lueLanguages.Size = new System.Drawing.Size(188, 28);
      this.lueLanguages.TabIndex = 12;
      // 
      // txtLANPort
      // 
      this.txtLANPort.Location = new System.Drawing.Point(96, 302);
      this.txtLANPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtLANPort.Name = "txtLANPort";
      this.txtLANPort.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLANPort.Properties.Appearance.Options.UseFont = true;
      this.txtLANPort.Size = new System.Drawing.Size(178, 28);
      this.txtLANPort.TabIndex = 11;
      this.txtLANPort.Visible = false;
      // 
      // txtLANIP
      // 
      this.txtLANIP.Location = new System.Drawing.Point(125, 37);
      this.txtLANIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtLANIP.Name = "txtLANIP";
      this.txtLANIP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtLANIP.Properties.Appearance.Options.UseFont = true;
      this.txtLANIP.Size = new System.Drawing.Size(188, 28);
      this.txtLANIP.TabIndex = 10;
      // 
      // labelControl4
      // 
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new System.Drawing.Point(15, 146);
      this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new System.Drawing.Size(60, 16);
      this.labelControl4.TabIndex = 9;
      this.labelControl4.Text = "Serial Port";
      this.labelControl4.Visible = false;
      // 
      // lblIP
      // 
      this.lblIP.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblIP.Appearance.Options.UseFont = true;
      this.lblIP.Location = new System.Drawing.Point(34, 26);
      this.lblIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblIP.Name = "lblIP";
      this.lblIP.Size = new System.Drawing.Size(36, 16);
      this.lblIP.TabIndex = 8;
      this.lblIP.Text = "IP PLC";
      // 
      // txtPLCPort
      // 
      this.txtPLCPort.Location = new System.Drawing.Point(66, 257);
      this.txtPLCPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.txtPLCPort.Name = "txtPLCPort";
      this.txtPLCPort.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPLCPort.Properties.Appearance.Options.UseFont = true;
      this.txtPLCPort.Size = new System.Drawing.Size(244, 28);
      this.txtPLCPort.TabIndex = 7;
      this.txtPLCPort.Visible = false;
      // 
      // btnTestPort
      // 
      this.btnTestPort.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTestPort.Appearance.Options.UseFont = true;
      this.btnTestPort.Location = new System.Drawing.Point(475, 254);
      this.btnTestPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnTestPort.Name = "btnTestPort";
      this.btnTestPort.Size = new System.Drawing.Size(101, 30);
      this.btnTestPort.TabIndex = 6;
      this.btnTestPort.Text = "Test Port";
      this.btnTestPort.Visible = false;
      this.btnTestPort.Click += new System.EventHandler(this.btnTestPort_Click);
      // 
      // btnChangePLCPort
      // 
      this.btnChangePLCPort.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnChangePLCPort.Appearance.Options.UseFont = true;
      this.btnChangePLCPort.Location = new System.Drawing.Point(360, 254);
      this.btnChangePLCPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btnChangePLCPort.Name = "btnChangePLCPort";
      this.btnChangePLCPort.Size = new System.Drawing.Size(101, 30);
      this.btnChangePLCPort.TabIndex = 5;
      this.btnChangePLCPort.Text = "Change";
      this.btnChangePLCPort.Visible = false;
      this.btnChangePLCPort.Click += new System.EventHandler(this.btnChangePLCPort_Click);
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new System.Drawing.Point(26, 195);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(23, 16);
      this.labelControl1.TabIndex = 2;
      this.labelControl1.Text = "Port";
      this.labelControl1.Visible = false;
      // 
      // rdgLanguageRes
      // 
      this.rdgLanguageRes.Location = new System.Drawing.Point(455, 40);
      this.rdgLanguageRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.rdgLanguageRes.Name = "rdgLanguageRes";
      this.rdgLanguageRes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdgLanguageRes.Properties.Appearance.Options.UseFont = true;
      this.rdgLanguageRes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
      this.rdgLanguageRes.Size = new System.Drawing.Size(244, 65);
      this.rdgLanguageRes.TabIndex = 1;
      this.rdgLanguageRes.Visible = false;
      this.rdgLanguageRes.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.rdgLanguageRes_EditValueChanging);
      // 
      // lblLanguage
      // 
      this.lblLanguage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLanguage.Appearance.Options.UseFont = true;
      this.lblLanguage.Location = new System.Drawing.Point(18, 50);
      this.lblLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.lblLanguage.Name = "lblLanguage";
      this.lblLanguage.Size = new System.Drawing.Size(56, 16);
      this.lblLanguage.TabIndex = 0;
      this.lblLanguage.Text = "Ngôn Ngữ";
      // 
      // FrmConfig
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(691, 352);
      this.Controls.Add(this.tabConfig);
      this.Controls.Add(this.panelControl1);
      this.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
      this.Name = "FrmConfig";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "FrmConfig";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConfig_FormClosing);
      this.Load += new System.EventHandler(this.FrmConfig_Load);
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.tabConfig)).EndInit();
      this.tabConfig.ResumeLayout(false);
      this.tpgCompanyInfo.ResumeLayout(false);
      this.tpgCompanyInfo.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bteLogoPath.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiCty.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiCty.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtTenCty.Properties)).EndInit();
      this.tpgRunningMode.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.grpStandAlone)).EndInit();
      this.grpStandAlone.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grpService)).EndInit();
      this.grpService.ResumeLayout(false);
      this.grpService.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtServerIP.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lueRunningMode.Properties)).EndInit();
      this.tpgOptions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
      this.xtraTabControl1.ResumeLayout(false);
      this.tpgRange.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.spnKLTronLonNhat.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spnKLTronNhoNhat.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spnKLChoLonNhat.Properties)).EndInit();
      this.tpgFilter.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.spnLatestBaoCaoDays.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spnLatestHopDongDays.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spnLatestPhieuTronDays.Properties)).EndInit();
      this.tpgOthers.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.bteImportPath_CT.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.btePdfReaderPath.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bteImportPath_GH.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bteExportPath.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkDev.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkTronOnline.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chkTinhBuTru.Properties)).EndInit();
      this.xtraTabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.beFilePathPLC.Properties)).EndInit();
      this.tpgGeneral.ResumeLayout(false);
      this.tpgGeneral.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lueLanguages.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtLANPort.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtLANIP.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPLCPort.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.rdgLanguageRes.Properties)).EndInit();
      this.ResumeLayout(false);

    }


    // Đây là code do DnSpy tạo ra, không phải do Dootpeek tạo ra.
    //// Token: 0x06000079 RID: 121 RVA: 0x00006078 File Offset: 0x00004278
    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //  {
    //    this.components.Dispose();
    //  }
    //  base.Dispose(disposing);
    //}

    //// Token: 0x0600007A RID: 122 RVA: 0x00006098 File Offset: 0x00004298
    //private void InitializeComponent()
    //{
    //  this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
    //  this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
    //  this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
    //  this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
    //  this.btnOk = new DevExpress.XtraEditors.SimpleButton();
    //  this.tabConfig = new DevExpress.XtraTab.XtraTabControl();
    //  this.tpgCompanyInfo = new DevExpress.XtraTab.XtraTabPage();
    //  this.bteLogoPath = new DevExpress.XtraEditors.ButtonEdit();
    //  this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
    //  this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
    //  this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
    //  this.btnLoadImage = new DevExpress.XtraEditors.SimpleButton();
    //  this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
    //  this.txtDienThoaiCty = new DevExpress.XtraEditors.TextEdit();
    //  this.txtDiaChiCty = new DevExpress.XtraEditors.TextEdit();
    //  this.txtTenCty = new DevExpress.XtraEditors.TextEdit();
    //  this.lblPhone = new DevExpress.XtraEditors.LabelControl();
    //  this.lblAddress = new DevExpress.XtraEditors.LabelControl();
    //  this.lblCompanyName = new DevExpress.XtraEditors.LabelControl();
    //  this.tpgRunningMode = new DevExpress.XtraTab.XtraTabPage();
    //  this.txtPassword = new DevExpress.XtraEditors.TextEdit();
    //  this.txtUsername = new DevExpress.XtraEditors.TextEdit();
    //  this.txtDatabase = new DevExpress.XtraEditors.TextEdit();
    //  this.txtServer = new DevExpress.XtraEditors.TextEdit();
    //  this.lblPassword = new DevExpress.XtraEditors.LabelControl();
    //  this.lblUsername = new DevExpress.XtraEditors.LabelControl();
    //  this.lblDatabase = new DevExpress.XtraEditors.LabelControl();
    //  this.lblServerName = new DevExpress.XtraEditors.LabelControl();
    //  this.grpStandAlone = new DevExpress.XtraEditors.GroupControl();
    //  this.grpService = new DevExpress.XtraEditors.GroupControl();
    //  this.txtServerIP = new DevExpress.XtraEditors.TextEdit();
    //  this.lblEndpointAddress = new DevExpress.XtraEditors.LabelControl();
    //  this.lblRunningMode = new DevExpress.XtraEditors.LabelControl();
    //  this.lueRunningMode = new DevExpress.XtraEditors.LookUpEdit();
    //  this.tpgOptions = new DevExpress.XtraTab.XtraTabPage();
    //  this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
    //  this.tpgRange = new DevExpress.XtraTab.XtraTabPage();
    //  this.spnKLTronLonNhat = new DevExpress.XtraEditors.SpinEdit();
    //  this.spnKLTronNhoNhat = new DevExpress.XtraEditors.SpinEdit();
    //  this.spnKLChoLonNhat = new DevExpress.XtraEditors.SpinEdit();
    //  this.lblKLTronLonNhat = new DevExpress.XtraEditors.LabelControl();
    //  this.lblKLTronNhoNhat = new DevExpress.XtraEditors.LabelControl();
    //  this.lblKLChoLonNhat = new DevExpress.XtraEditors.LabelControl();
    //  this.tpgFilter = new DevExpress.XtraTab.XtraTabPage();
    //  this.spnLatestBaoCaoDays = new DevExpress.XtraEditors.SpinEdit();
    //  this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
    //  this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
    //  this.spnLatestHopDongDays = new DevExpress.XtraEditors.SpinEdit();
    //  this.spnLatestPhieuTronDays = new DevExpress.XtraEditors.SpinEdit();
    //  this.lblLatestDay2 = new DevExpress.XtraEditors.LabelControl();
    //  this.lblLatestDay = new DevExpress.XtraEditors.LabelControl();
    //  this.lblPhieuTron = new DevExpress.XtraEditors.LabelControl();
    //  this.lblContract = new DevExpress.XtraEditors.LabelControl();
    //  this.tpgOthers = new DevExpress.XtraTab.XtraTabPage();
    //  this.bteImportPath_CT = new DevExpress.XtraEditors.ButtonEdit();
    //  this.btePdfReaderPath = new DevExpress.XtraEditors.ButtonEdit();
    //  this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
    //  this.bteImportPath_GH = new DevExpress.XtraEditors.ButtonEdit();
    //  this.bteExportPath = new DevExpress.XtraEditors.ButtonEdit();
    //  this.chkDev = new DevExpress.XtraEditors.CheckEdit();
    //  this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
    //  this.chkTronOnline = new DevExpress.XtraEditors.CheckEdit();
    //  this.chkTinhBuTru = new DevExpress.XtraEditors.CheckEdit();
    //  this.btnReportPathBrowse = new DevExpress.XtraEditors.SimpleButton();
    //  this.btnTestReportPath = new DevExpress.XtraEditors.SimpleButton();
    //  this.lblReportPath = new DevExpress.XtraEditors.LabelControl();
    //  this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
    //  this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
    //  this.beFilePathPLC = new DevExpress.XtraEditors.ButtonEdit();
    //  this.btnUploadToPLC = new DevExpress.XtraEditors.SimpleButton();
    //  this.tpgGeneral = new DevExpress.XtraTab.XtraTabPage();
    //  this.lueLanguages = new DevExpress.XtraEditors.LookUpEdit();
    //  this.txtLANPort = new DevExpress.XtraEditors.TextEdit();
    //  this.txtLANIP = new DevExpress.XtraEditors.TextEdit();
    //  this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
    //  this.lblIP = new DevExpress.XtraEditors.LabelControl();
    //  this.txtPLCPort = new DevExpress.XtraEditors.TextEdit();
    //  this.btnTestPort = new DevExpress.XtraEditors.SimpleButton();
    //  this.btnChangePLCPort = new DevExpress.XtraEditors.SimpleButton();
    //  this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
    //  this.rdgLanguageRes = new DevExpress.XtraEditors.RadioGroup();
    //  this.lblLanguage = new DevExpress.XtraEditors.LabelControl();
    //  ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
    //  this.panelControl1.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.tabConfig)).BeginInit();
    //  this.tabConfig.SuspendLayout();
    //  this.tpgCompanyInfo.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.bteLogoPath.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiCty.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiCty.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtTenCty.Properties)).BeginInit();
    //  this.tpgRunningMode.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.grpStandAlone)).BeginInit();
    //  this.grpStandAlone.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.grpService)).BeginInit();
    //  this.grpService.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtServerIP.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.lueRunningMode.Properties)).BeginInit();
    //  this.tpgOptions.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
    //  this.xtraTabControl1.SuspendLayout();
    //  this.tpgRange.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnKLTronLonNhat.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnKLTronNhoNhat.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnKLChoLonNhat.Properties)).BeginInit();
    //  this.tpgFilter.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnLatestBaoCaoDays.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnLatestHopDongDays.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnLatestPhieuTronDays.Properties)).BeginInit();
    //  this.tpgOthers.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.bteImportPath_CT.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.btePdfReaderPath.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.bteImportPath_GH.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.bteExportPath.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.chkDev.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.chkTronOnline.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.chkTinhBuTru.Properties)).BeginInit();
    //  this.xtraTabPage1.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.beFilePathPLC.Properties)).BeginInit();
    //  this.tpgGeneral.SuspendLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.lueLanguages.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtLANPort.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtLANIP.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtPLCPort.Properties)).BeginInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.rdgLanguageRes.Properties)).BeginInit();
    //  this.SuspendLayout();
    //  // 
    //  // panelControl1
    //  // 
    //  this.panelControl1.Controls.Add(this.simpleButton3);
    //  this.panelControl1.Controls.Add(this.simpleButton2);
    //  this.panelControl1.Controls.Add(this.btnCancel);
    //  this.panelControl1.Controls.Add(this.btnOk);
    //  this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
    //  this.panelControl1.Location = new System.Drawing.Point(0, 384);
    //  this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.panelControl1.Name = "panelControl1";
    //  this.panelControl1.Size = new System.Drawing.Size(806, 49);
    //  this.panelControl1.TabIndex = 0;
    //  // 
    //  // simpleButton3
    //  // 
    //  this.simpleButton3.Location = new System.Drawing.Point(382, 6);
    //  this.simpleButton3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.simpleButton3.Name = "simpleButton3";
    //  this.simpleButton3.Size = new System.Drawing.Size(110, 37);
    //  this.simpleButton3.TabIndex = 3;
    //  this.simpleButton3.Text = "Đóng";
    //  this.simpleButton3.Click += new System.EventHandler(this.btnCancel_Click);
    //  // 
    //  // simpleButton2
    //  // 
    //  this.simpleButton2.Location = new System.Drawing.Point(243, 6);
    //  this.simpleButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.simpleButton2.Name = "simpleButton2";
    //  this.simpleButton2.Size = new System.Drawing.Size(110, 37);
    //  this.simpleButton2.TabIndex = 2;
    //  this.simpleButton2.Text = "Lưu";
    //  this.simpleButton2.Click += new System.EventHandler(this.btnOk_Click);
    //  // 
    //  // btnCancel
    //  // 
    //  this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
    //  this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.btnCancel.Appearance.Options.UseFont = true;
    //  this.btnCancel.Location = new System.Drawing.Point(1219, 7);
    //  this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.btnCancel.Name = "btnCancel";
    //  this.btnCancel.Size = new System.Drawing.Size(114, 37);
    //  this.btnCancel.TabIndex = 1;
    //  this.btnCancel.Text = "Huỷ Bỏ";
    //  this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
    //  // 
    //  // btnOk
    //  // 
    //  this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
    //  this.btnOk.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.btnOk.Appearance.Options.UseFont = true;
    //  this.btnOk.Location = new System.Drawing.Point(1086, 7);
    //  this.btnOk.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.btnOk.Name = "btnOk";
    //  this.btnOk.Size = new System.Drawing.Size(114, 37);
    //  this.btnOk.TabIndex = 0;
    //  this.btnOk.Text = "Lưu";
    //  this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
    //  // 
    //  // tabConfig
    //  // 
    //  this.tabConfig.Dock = System.Windows.Forms.DockStyle.Fill;
    //  this.tabConfig.Location = new System.Drawing.Point(0, 0);
    //  this.tabConfig.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.tabConfig.Name = "tabConfig";
    //  this.tabConfig.SelectedTabPage = this.tpgCompanyInfo;
    //  this.tabConfig.Size = new System.Drawing.Size(806, 384);
    //  this.tabConfig.TabIndex = 0;
    //  this.tabConfig.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
    //        this.tpgRunningMode,
    //        this.tpgCompanyInfo,
    //        this.tpgOptions,
    //        this.tpgGeneral});
    //  // 
    //  // tpgCompanyInfo
    //  // 
    //  this.tpgCompanyInfo.Controls.Add(this.bteLogoPath);
    //  this.tpgCompanyInfo.Controls.Add(this.labelControl3);
    //  this.tpgCompanyInfo.Controls.Add(this.simpleButton1);
    //  this.tpgCompanyInfo.Controls.Add(this.labelControl2);
    //  this.tpgCompanyInfo.Controls.Add(this.btnLoadImage);
    //  this.tpgCompanyInfo.Controls.Add(this.pictureEdit1);
    //  this.tpgCompanyInfo.Controls.Add(this.txtDienThoaiCty);
    //  this.tpgCompanyInfo.Controls.Add(this.txtDiaChiCty);
    //  this.tpgCompanyInfo.Controls.Add(this.txtTenCty);
    //  this.tpgCompanyInfo.Controls.Add(this.lblPhone);
    //  this.tpgCompanyInfo.Controls.Add(this.lblAddress);
    //  this.tpgCompanyInfo.Controls.Add(this.lblCompanyName);
    //  this.tpgCompanyInfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.tpgCompanyInfo.Name = "tpgCompanyInfo";
    //  this.tpgCompanyInfo.Size = new System.Drawing.Size(804, 354);
    //  this.tpgCompanyInfo.Text = "Thông Tin Cty";
    //  // 
    //  // bteLogoPath
    //  // 
    //  this.bteLogoPath.Location = new System.Drawing.Point(195, 142);
    //  this.bteLogoPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.bteLogoPath.Name = "bteLogoPath";
    //  this.bteLogoPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton()});
    //  this.bteLogoPath.Size = new System.Drawing.Size(355, 22);
    //  this.bteLogoPath.TabIndex = 12;
    //  this.bteLogoPath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
    //  this.bteLogoPath.EditValueChanged += new System.EventHandler(this.bteLogoPath_EditValueChanged);
    //  // 
    //  // labelControl3
    //  // 
    //  this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.labelControl3.Appearance.Options.UseFont = true;
    //  this.labelControl3.Appearance.Options.UseTextOptions = true;
    //  this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.labelControl3.Location = new System.Drawing.Point(57, 143);
    //  this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.labelControl3.Name = "labelControl3";
    //  this.labelControl3.Size = new System.Drawing.Size(112, 20);
    //  this.labelControl3.TabIndex = 11;
    //  this.labelControl3.Text = "Đường dẫn logo";
    //  // 
    //  // simpleButton1
    //  // 
    //  this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.simpleButton1.Appearance.Options.UseFont = true;
    //  this.simpleButton1.Location = new System.Drawing.Point(327, 177);
    //  this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.simpleButton1.Name = "simpleButton1";
    //  this.simpleButton1.Size = new System.Drawing.Size(114, 37);
    //  this.simpleButton1.TabIndex = 10;
    //  this.simpleButton1.Text = "Load Logo";
    //  this.simpleButton1.Visible = false;
    //  this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
    //  // 
    //  // labelControl2
    //  // 
    //  this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.labelControl2.Appearance.Options.UseFont = true;
    //  this.labelControl2.Location = new System.Drawing.Point(594, 165);
    //  this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.labelControl2.Name = "labelControl2";
    //  this.labelControl2.Size = new System.Drawing.Size(95, 19);
    //  this.labelControl2.TabIndex = 9;
    //  this.labelControl2.Text = "Logo Công ty";
    //  // 
    //  // btnLoadImage
    //  // 
    //  this.btnLoadImage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.btnLoadImage.Appearance.Options.UseFont = true;
    //  this.btnLoadImage.Location = new System.Drawing.Point(195, 177);
    //  this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.btnLoadImage.Name = "btnLoadImage";
    //  this.btnLoadImage.Size = new System.Drawing.Size(114, 37);
    //  this.btnLoadImage.TabIndex = 7;
    //  this.btnLoadImage.Text = "Thay đổi";
    //  this.btnLoadImage.Visible = false;
    //  this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
    //  // 
    //  // pictureEdit1
    //  // 
    //  this.pictureEdit1.Location = new System.Drawing.Point(581, 34);
    //  this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.pictureEdit1.Name = "pictureEdit1";
    //  this.pictureEdit1.Properties.NullText = " ";
    //  this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
    //  this.pictureEdit1.Size = new System.Drawing.Size(117, 123);
    //  this.pictureEdit1.TabIndex = 6;
    //  this.pictureEdit1.LoadCompleted += new System.EventHandler(this.pictureEdit1_LoadCompleted);
    //  this.pictureEdit1.TextChanged += new System.EventHandler(this.pictureEdit1_TextChanged);
    //  // 
    //  // txtDienThoaiCty
    //  // 
    //  this.txtDienThoaiCty.Location = new System.Drawing.Point(195, 105);
    //  this.txtDienThoaiCty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtDienThoaiCty.Name = "txtDienThoaiCty";
    //  this.txtDienThoaiCty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtDienThoaiCty.Properties.Appearance.Options.UseFont = true;
    //  this.txtDienThoaiCty.Size = new System.Drawing.Size(355, 26);
    //  this.txtDienThoaiCty.TabIndex = 5;
    //  // 
    //  // txtDiaChiCty
    //  // 
    //  this.txtDiaChiCty.Location = new System.Drawing.Point(195, 68);
    //  this.txtDiaChiCty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtDiaChiCty.Name = "txtDiaChiCty";
    //  this.txtDiaChiCty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtDiaChiCty.Properties.Appearance.Options.UseFont = true;
    //  this.txtDiaChiCty.Size = new System.Drawing.Size(355, 26);
    //  this.txtDiaChiCty.TabIndex = 4;
    //  // 
    //  // txtTenCty
    //  // 
    //  this.txtTenCty.Location = new System.Drawing.Point(195, 31);
    //  this.txtTenCty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtTenCty.Name = "txtTenCty";
    //  this.txtTenCty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtTenCty.Properties.Appearance.Options.UseFont = true;
    //  this.txtTenCty.Size = new System.Drawing.Size(355, 26);
    //  this.txtTenCty.TabIndex = 3;
    //  // 
    //  // lblPhone
    //  // 
    //  this.lblPhone.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblPhone.Appearance.Options.UseFont = true;
    //  this.lblPhone.Appearance.Options.UseTextOptions = true;
    //  this.lblPhone.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblPhone.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblPhone.Location = new System.Drawing.Point(57, 108);
    //  this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblPhone.Name = "lblPhone";
    //  this.lblPhone.Size = new System.Drawing.Size(112, 20);
    //  this.lblPhone.TabIndex = 2;
    //  this.lblPhone.Text = "Số Điện Thoại";
    //  // 
    //  // lblAddress
    //  // 
    //  this.lblAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblAddress.Appearance.Options.UseFont = true;
    //  this.lblAddress.Appearance.Options.UseTextOptions = true;
    //  this.lblAddress.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblAddress.Location = new System.Drawing.Point(57, 71);
    //  this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblAddress.Name = "lblAddress";
    //  this.lblAddress.Size = new System.Drawing.Size(112, 20);
    //  this.lblAddress.TabIndex = 1;
    //  this.lblAddress.Text = "Địa Chỉ";
    //  // 
    //  // lblCompanyName
    //  // 
    //  this.lblCompanyName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblCompanyName.Appearance.Options.UseFont = true;
    //  this.lblCompanyName.Appearance.Options.UseTextOptions = true;
    //  this.lblCompanyName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblCompanyName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblCompanyName.Location = new System.Drawing.Point(57, 34);
    //  this.lblCompanyName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblCompanyName.Name = "lblCompanyName";
    //  this.lblCompanyName.Size = new System.Drawing.Size(112, 20);
    //  this.lblCompanyName.TabIndex = 0;
    //  this.lblCompanyName.Text = "Tên Công Ty";
    //  // 
    //  // tpgRunningMode
    //  // 
    //  this.tpgRunningMode.Controls.Add(this.txtPassword);
    //  this.tpgRunningMode.Controls.Add(this.txtUsername);
    //  this.tpgRunningMode.Controls.Add(this.txtDatabase);
    //  this.tpgRunningMode.Controls.Add(this.txtServer);
    //  this.tpgRunningMode.Controls.Add(this.lblPassword);
    //  this.tpgRunningMode.Controls.Add(this.lblUsername);
    //  this.tpgRunningMode.Controls.Add(this.lblDatabase);
    //  this.tpgRunningMode.Controls.Add(this.lblServerName);
    //  this.tpgRunningMode.Controls.Add(this.grpStandAlone);
    //  this.tpgRunningMode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.tpgRunningMode.Name = "tpgRunningMode";
    //  this.tpgRunningMode.Size = new System.Drawing.Size(804, 354);
    //  this.tpgRunningMode.Text = "Running Mode";
    //  // 
    //  // txtPassword
    //  // 
    //  this.txtPassword.Location = new System.Drawing.Point(195, 142);
    //  this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtPassword.Name = "txtPassword";
    //  this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtPassword.Properties.Appearance.Options.UseFont = true;
    //  this.txtPassword.Properties.MaxLength = 20;
    //  this.txtPassword.Properties.PasswordChar = '*';
    //  this.txtPassword.Size = new System.Drawing.Size(220, 26);
    //  this.txtPassword.TabIndex = 15;
    //  // 
    //  // txtUsername
    //  // 
    //  this.txtUsername.Location = new System.Drawing.Point(195, 105);
    //  this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtUsername.Name = "txtUsername";
    //  this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtUsername.Properties.Appearance.Options.UseFont = true;
    //  this.txtUsername.Size = new System.Drawing.Size(220, 26);
    //  this.txtUsername.TabIndex = 14;
    //  // 
    //  // txtDatabase
    //  // 
    //  this.txtDatabase.Location = new System.Drawing.Point(195, 68);
    //  this.txtDatabase.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtDatabase.Name = "txtDatabase";
    //  this.txtDatabase.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtDatabase.Properties.Appearance.Options.UseFont = true;
    //  this.txtDatabase.Size = new System.Drawing.Size(220, 26);
    //  this.txtDatabase.TabIndex = 13;
    //  // 
    //  // txtServer
    //  // 
    //  this.txtServer.Location = new System.Drawing.Point(195, 31);
    //  this.txtServer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtServer.Name = "txtServer";
    //  this.txtServer.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtServer.Properties.Appearance.Options.UseFont = true;
    //  this.txtServer.Size = new System.Drawing.Size(220, 26);
    //  this.txtServer.TabIndex = 12;
    //  // 
    //  // lblPassword
    //  // 
    //  this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblPassword.Appearance.Options.UseFont = true;
    //  this.lblPassword.Appearance.Options.UseTextOptions = true;
    //  this.lblPassword.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblPassword.Location = new System.Drawing.Point(57, 145);
    //  this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblPassword.Name = "lblPassword";
    //  this.lblPassword.Size = new System.Drawing.Size(108, 20);
    //  this.lblPassword.TabIndex = 11;
    //  this.lblPassword.Text = "Password";
    //  // 
    //  // lblUsername
    //  // 
    //  this.lblUsername.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblUsername.Appearance.Options.UseFont = true;
    //  this.lblUsername.Appearance.Options.UseTextOptions = true;
    //  this.lblUsername.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblUsername.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblUsername.Location = new System.Drawing.Point(56, 108);
    //  this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblUsername.Name = "lblUsername";
    //  this.lblUsername.Size = new System.Drawing.Size(110, 20);
    //  this.lblUsername.TabIndex = 10;
    //  this.lblUsername.Text = "Username";
    //  // 
    //  // lblDatabase
    //  // 
    //  this.lblDatabase.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblDatabase.Appearance.Options.UseFont = true;
    //  this.lblDatabase.Appearance.Options.UseTextOptions = true;
    //  this.lblDatabase.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblDatabase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblDatabase.Location = new System.Drawing.Point(57, 71);
    //  this.lblDatabase.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblDatabase.Name = "lblDatabase";
    //  this.lblDatabase.Size = new System.Drawing.Size(108, 20);
    //  this.lblDatabase.TabIndex = 9;
    //  this.lblDatabase.Text = "Database";
    //  // 
    //  // lblServerName
    //  // 
    //  this.lblServerName.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblServerName.Appearance.Options.UseFont = true;
    //  this.lblServerName.Appearance.Options.UseTextOptions = true;
    //  this.lblServerName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblServerName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblServerName.Location = new System.Drawing.Point(57, 34);
    //  this.lblServerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblServerName.Name = "lblServerName";
    //  this.lblServerName.Size = new System.Drawing.Size(108, 20);
    //  this.lblServerName.TabIndex = 8;
    //  this.lblServerName.Text = "Server Name";
    //  // 
    //  // grpStandAlone
    //  // 
    //  this.grpStandAlone.Controls.Add(this.grpService);
    //  this.grpStandAlone.Controls.Add(this.lblRunningMode);
    //  this.grpStandAlone.Controls.Add(this.lueRunningMode);
    //  this.grpStandAlone.Location = new System.Drawing.Point(1, 265);
    //  this.grpStandAlone.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.grpStandAlone.Name = "grpStandAlone";
    //  this.grpStandAlone.Size = new System.Drawing.Size(804, 85);
    //  this.grpStandAlone.TabIndex = 0;
    //  this.grpStandAlone.Text = "Cấu hình cơ sở dữ liệu";
    //  this.grpStandAlone.Visible = false;
    //  // 
    //  // grpService
    //  // 
    //  this.grpService.Controls.Add(this.txtServerIP);
    //  this.grpService.Controls.Add(this.lblEndpointAddress);
    //  this.grpService.Location = new System.Drawing.Point(74, 202);
    //  this.grpService.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.grpService.Name = "grpService";
    //  this.grpService.Size = new System.Drawing.Size(584, 76);
    //  this.grpService.TabIndex = 1;
    //  this.grpService.Text = "Service";
    //  this.grpService.Visible = false;
    //  // 
    //  // txtServerIP
    //  // 
    //  this.txtServerIP.Location = new System.Drawing.Point(180, 37);
    //  this.txtServerIP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtServerIP.Name = "txtServerIP";
    //  this.txtServerIP.Size = new System.Drawing.Size(368, 22);
    //  this.txtServerIP.TabIndex = 1;
    //  this.txtServerIP.Visible = false;
    //  // 
    //  // lblEndpointAddress
    //  // 
    //  this.lblEndpointAddress.Location = new System.Drawing.Point(94, 39);
    //  this.lblEndpointAddress.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblEndpointAddress.Name = "lblEndpointAddress";
    //  this.lblEndpointAddress.Size = new System.Drawing.Size(46, 16);
    //  this.lblEndpointAddress.TabIndex = 0;
    //  this.lblEndpointAddress.Text = "Address";
    //  this.lblEndpointAddress.Visible = false;
    //  // 
    //  // lblRunningMode
    //  // 
    //  this.lblRunningMode.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblRunningMode.Appearance.Options.UseFont = true;
    //  this.lblRunningMode.Appearance.Options.UseTextOptions = true;
    //  this.lblRunningMode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblRunningMode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblRunningMode.Location = new System.Drawing.Point(255, 287);
    //  this.lblRunningMode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblRunningMode.Name = "lblRunningMode";
    //  this.lblRunningMode.Size = new System.Drawing.Size(125, 20);
    //  this.lblRunningMode.TabIndex = 3;
    //  this.lblRunningMode.Text = "Running Mode";
    //  this.lblRunningMode.Visible = false;
    //  // 
    //  // lueRunningMode
    //  // 
    //  this.lueRunningMode.Location = new System.Drawing.Point(388, 283);
    //  this.lueRunningMode.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lueRunningMode.Name = "lueRunningMode";
    //  this.lueRunningMode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lueRunningMode.Properties.Appearance.Options.UseFont = true;
    //  this.lueRunningMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
    //  this.lueRunningMode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
    //        new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
    //        new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Running Mode", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
    //  this.lueRunningMode.Properties.DisplayMember = "Code";
    //  this.lueRunningMode.Properties.DropDownRows = 2;
    //  this.lueRunningMode.Properties.NullText = "";
    //  this.lueRunningMode.Properties.PopupWidth = 70;
    //  this.lueRunningMode.Properties.ShowFooter = false;
    //  this.lueRunningMode.Properties.ValueMember = "ID";
    //  this.lueRunningMode.Size = new System.Drawing.Size(220, 26);
    //  this.lueRunningMode.TabIndex = 2;
    //  this.lueRunningMode.Visible = false;
    //  // 
    //  // tpgOptions
    //  // 
    //  this.tpgOptions.Controls.Add(this.xtraTabControl1);
    //  this.tpgOptions.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.tpgOptions.Name = "tpgOptions";
    //  this.tpgOptions.Size = new System.Drawing.Size(804, 354);
    //  this.tpgOptions.Text = "Hệ Thống";
    //  // 
    //  // xtraTabControl1
    //  // 
    //  this.xtraTabControl1.Location = new System.Drawing.Point(4, 2);
    //  this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.xtraTabControl1.Name = "xtraTabControl1";
    //  this.xtraTabControl1.SelectedTabPage = this.tpgRange;
    //  this.xtraTabControl1.Size = new System.Drawing.Size(797, 347);
    //  this.xtraTabControl1.TabIndex = 0;
    //  this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
    //        this.tpgRange,
    //        this.tpgFilter,
    //        this.tpgOthers,
    //        this.xtraTabPage1});
    //  // 
    //  // tpgRange
    //  // 
    //  this.tpgRange.Controls.Add(this.spnKLTronLonNhat);
    //  this.tpgRange.Controls.Add(this.spnKLTronNhoNhat);
    //  this.tpgRange.Controls.Add(this.spnKLChoLonNhat);
    //  this.tpgRange.Controls.Add(this.lblKLTronLonNhat);
    //  this.tpgRange.Controls.Add(this.lblKLTronNhoNhat);
    //  this.tpgRange.Controls.Add(this.lblKLChoLonNhat);
    //  this.tpgRange.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.tpgRange.Name = "tpgRange";
    //  this.tpgRange.Size = new System.Drawing.Size(795, 317);
    //  this.tpgRange.Text = "Ràng Buộc";
    //  // 
    //  // spnKLTronLonNhat
    //  // 
    //  this.spnKLTronLonNhat.EditValue = new decimal(new int[] {
    //        0,
    //        0,
    //        0,
    //        0});
    //  this.spnKLTronLonNhat.Location = new System.Drawing.Point(271, 111);
    //  this.spnKLTronLonNhat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.spnKLTronLonNhat.Name = "spnKLTronLonNhat";
    //  this.spnKLTronLonNhat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.spnKLTronLonNhat.Properties.Appearance.Options.UseFont = true;
    //  this.spnKLTronLonNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
    //  this.spnKLTronLonNhat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
    //  this.spnKLTronLonNhat.Properties.EditFormat.FormatString = "n1";
    //  this.spnKLTronLonNhat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
    //  this.spnKLTronLonNhat.Properties.Mask.EditMask = "n1";
    //  this.spnKLTronLonNhat.Size = new System.Drawing.Size(125, 26);
    //  this.spnKLTronLonNhat.TabIndex = 5;
    //  // 
    //  // spnKLTronNhoNhat
    //  // 
    //  this.spnKLTronNhoNhat.EditValue = new decimal(new int[] {
    //        0,
    //        0,
    //        0,
    //        0});
    //  this.spnKLTronNhoNhat.Location = new System.Drawing.Point(271, 74);
    //  this.spnKLTronNhoNhat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.spnKLTronNhoNhat.Name = "spnKLTronNhoNhat";
    //  this.spnKLTronNhoNhat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.spnKLTronNhoNhat.Properties.Appearance.Options.UseFont = true;
    //  this.spnKLTronNhoNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
    //  this.spnKLTronNhoNhat.Properties.DisplayFormat.FormatString = "n1";
    //  this.spnKLTronNhoNhat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
    //  this.spnKLTronNhoNhat.Properties.EditFormat.FormatString = "n1";
    //  this.spnKLTronNhoNhat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
    //  this.spnKLTronNhoNhat.Properties.Mask.EditMask = "n1";
    //  this.spnKLTronNhoNhat.Size = new System.Drawing.Size(125, 26);
    //  this.spnKLTronNhoNhat.TabIndex = 4;
    //  // 
    //  // spnKLChoLonNhat
    //  // 
    //  this.spnKLChoLonNhat.EditValue = new decimal(new int[] {
    //        0,
    //        0,
    //        0,
    //        0});
    //  this.spnKLChoLonNhat.Location = new System.Drawing.Point(271, 37);
    //  this.spnKLChoLonNhat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.spnKLChoLonNhat.Name = "spnKLChoLonNhat";
    //  this.spnKLChoLonNhat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.spnKLChoLonNhat.Properties.Appearance.Options.UseFont = true;
    //  this.spnKLChoLonNhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
    //  this.spnKLChoLonNhat.Properties.DisplayFormat.FormatString = "n1";
    //  this.spnKLChoLonNhat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
    //  this.spnKLChoLonNhat.Properties.EditFormat.FormatString = "n1";
    //  this.spnKLChoLonNhat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
    //  this.spnKLChoLonNhat.Properties.Mask.EditMask = "n1";
    //  this.spnKLChoLonNhat.Size = new System.Drawing.Size(125, 26);
    //  this.spnKLChoLonNhat.TabIndex = 3;
    //  // 
    //  // lblKLTronLonNhat
    //  // 
    //  this.lblKLTronLonNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblKLTronLonNhat.Appearance.Options.UseFont = true;
    //  this.lblKLTronLonNhat.Appearance.Options.UseTextOptions = true;
    //  this.lblKLTronLonNhat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblKLTronLonNhat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblKLTronLonNhat.Location = new System.Drawing.Point(48, 114);
    //  this.lblKLTronLonNhat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblKLTronLonNhat.Name = "lblKLTronLonNhat";
    //  this.lblKLTronLonNhat.Size = new System.Drawing.Size(187, 20);
    //  this.lblKLTronLonNhat.TabIndex = 2;
    //  this.lblKLTronLonNhat.Text = "Số khối trộn lớn nhất";
    //  // 
    //  // lblKLTronNhoNhat
    //  // 
    //  this.lblKLTronNhoNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblKLTronNhoNhat.Appearance.Options.UseFont = true;
    //  this.lblKLTronNhoNhat.Appearance.Options.UseTextOptions = true;
    //  this.lblKLTronNhoNhat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblKLTronNhoNhat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblKLTronNhoNhat.Location = new System.Drawing.Point(48, 78);
    //  this.lblKLTronNhoNhat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblKLTronNhoNhat.Name = "lblKLTronNhoNhat";
    //  this.lblKLTronNhoNhat.Size = new System.Drawing.Size(187, 20);
    //  this.lblKLTronNhoNhat.TabIndex = 1;
    //  this.lblKLTronNhoNhat.Text = "Số khối trộn nhỏ nhất";
    //  // 
    //  // lblKLChoLonNhat
    //  // 
    //  this.lblKLChoLonNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblKLChoLonNhat.Appearance.Options.UseFont = true;
    //  this.lblKLChoLonNhat.Appearance.Options.UseTextOptions = true;
    //  this.lblKLChoLonNhat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblKLChoLonNhat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblKLChoLonNhat.Location = new System.Drawing.Point(48, 41);
    //  this.lblKLChoLonNhat.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblKLChoLonNhat.Name = "lblKLChoLonNhat";
    //  this.lblKLChoLonNhat.Size = new System.Drawing.Size(187, 20);
    //  this.lblKLChoLonNhat.TabIndex = 0;
    //  this.lblKLChoLonNhat.Text = "Số khối lớn nhất mà xe chở";
    //  // 
    //  // tpgFilter
    //  // 
    //  this.tpgFilter.Controls.Add(this.spnLatestBaoCaoDays);
    //  this.tpgFilter.Controls.Add(this.labelControl5);
    //  this.tpgFilter.Controls.Add(this.labelControl6);
    //  this.tpgFilter.Controls.Add(this.spnLatestHopDongDays);
    //  this.tpgFilter.Controls.Add(this.spnLatestPhieuTronDays);
    //  this.tpgFilter.Controls.Add(this.lblLatestDay2);
    //  this.tpgFilter.Controls.Add(this.lblLatestDay);
    //  this.tpgFilter.Controls.Add(this.lblPhieuTron);
    //  this.tpgFilter.Controls.Add(this.lblContract);
    //  this.tpgFilter.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.tpgFilter.Name = "tpgFilter";
    //  this.tpgFilter.Size = new System.Drawing.Size(795, 317);
    //  this.tpgFilter.Text = "Bộ Lọc";
    //  // 
    //  // spnLatestBaoCaoDays
    //  // 
    //  this.spnLatestBaoCaoDays.EditValue = new decimal(new int[] {
    //        0,
    //        0,
    //        0,
    //        0});
    //  this.spnLatestBaoCaoDays.Location = new System.Drawing.Point(141, 111);
    //  this.spnLatestBaoCaoDays.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.spnLatestBaoCaoDays.Name = "spnLatestBaoCaoDays";
    //  this.spnLatestBaoCaoDays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.spnLatestBaoCaoDays.Properties.Appearance.Options.UseFont = true;
    //  this.spnLatestBaoCaoDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
    //  this.spnLatestBaoCaoDays.Size = new System.Drawing.Size(125, 26);
    //  this.spnLatestBaoCaoDays.TabIndex = 8;
    //  // 
    //  // labelControl5
    //  // 
    //  this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.labelControl5.Appearance.Options.UseFont = true;
    //  this.labelControl5.Appearance.Options.UseTextOptions = true;
    //  this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
    //  this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.labelControl5.Location = new System.Drawing.Point(280, 111);
    //  this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.labelControl5.Name = "labelControl5";
    //  this.labelControl5.Size = new System.Drawing.Size(180, 20);
    //  this.labelControl5.TabIndex = 7;
    //  this.labelControl5.Text = "ngày gần đây nhất";
    //  // 
    //  // labelControl6
    //  // 
    //  this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.labelControl6.Appearance.Options.UseFont = true;
    //  this.labelControl6.Appearance.Options.UseTextOptions = true;
    //  this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.labelControl6.Location = new System.Drawing.Point(30, 111);
    //  this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.labelControl6.Name = "labelControl6";
    //  this.labelControl6.Size = new System.Drawing.Size(88, 20);
    //  this.labelControl6.TabIndex = 6;
    //  this.labelControl6.Text = "Báo cáo";
    //  // 
    //  // spnLatestHopDongDays
    //  // 
    //  this.spnLatestHopDongDays.EditValue = new decimal(new int[] {
    //        0,
    //        0,
    //        0,
    //        0});
    //  this.spnLatestHopDongDays.Location = new System.Drawing.Point(141, 37);
    //  this.spnLatestHopDongDays.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.spnLatestHopDongDays.Name = "spnLatestHopDongDays";
    //  this.spnLatestHopDongDays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.spnLatestHopDongDays.Properties.Appearance.Options.UseFont = true;
    //  this.spnLatestHopDongDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
    //  this.spnLatestHopDongDays.Size = new System.Drawing.Size(125, 26);
    //  this.spnLatestHopDongDays.TabIndex = 5;
    //  // 
    //  // spnLatestPhieuTronDays
    //  // 
    //  this.spnLatestPhieuTronDays.EditValue = new decimal(new int[] {
    //        0,
    //        0,
    //        0,
    //        0});
    //  this.spnLatestPhieuTronDays.Location = new System.Drawing.Point(141, 74);
    //  this.spnLatestPhieuTronDays.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.spnLatestPhieuTronDays.Name = "spnLatestPhieuTronDays";
    //  this.spnLatestPhieuTronDays.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.spnLatestPhieuTronDays.Properties.Appearance.Options.UseFont = true;
    //  this.spnLatestPhieuTronDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
    //  this.spnLatestPhieuTronDays.Size = new System.Drawing.Size(125, 26);
    //  this.spnLatestPhieuTronDays.TabIndex = 4;
    //  // 
    //  // lblLatestDay2
    //  // 
    //  this.lblLatestDay2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblLatestDay2.Appearance.Options.UseFont = true;
    //  this.lblLatestDay2.Appearance.Options.UseTextOptions = true;
    //  this.lblLatestDay2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
    //  this.lblLatestDay2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblLatestDay2.Location = new System.Drawing.Point(280, 78);
    //  this.lblLatestDay2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblLatestDay2.Name = "lblLatestDay2";
    //  this.lblLatestDay2.Size = new System.Drawing.Size(180, 20);
    //  this.lblLatestDay2.TabIndex = 3;
    //  this.lblLatestDay2.Text = "ngày gần đây nhất";
    //  // 
    //  // lblLatestDay
    //  // 
    //  this.lblLatestDay.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblLatestDay.Appearance.Options.UseFont = true;
    //  this.lblLatestDay.Appearance.Options.UseTextOptions = true;
    //  this.lblLatestDay.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
    //  this.lblLatestDay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblLatestDay.Location = new System.Drawing.Point(280, 41);
    //  this.lblLatestDay.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblLatestDay.Name = "lblLatestDay";
    //  this.lblLatestDay.Size = new System.Drawing.Size(180, 20);
    //  this.lblLatestDay.TabIndex = 2;
    //  this.lblLatestDay.Text = "ngày gần đây nhất";
    //  // 
    //  // lblPhieuTron
    //  // 
    //  this.lblPhieuTron.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblPhieuTron.Appearance.Options.UseFont = true;
    //  this.lblPhieuTron.Appearance.Options.UseTextOptions = true;
    //  this.lblPhieuTron.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblPhieuTron.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblPhieuTron.Location = new System.Drawing.Point(30, 78);
    //  this.lblPhieuTron.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblPhieuTron.Name = "lblPhieuTron";
    //  this.lblPhieuTron.Size = new System.Drawing.Size(88, 20);
    //  this.lblPhieuTron.TabIndex = 1;
    //  this.lblPhieuTron.Text = "Phiếu Trộn";
    //  // 
    //  // lblContract
    //  // 
    //  this.lblContract.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblContract.Appearance.Options.UseFont = true;
    //  this.lblContract.Appearance.Options.UseTextOptions = true;
    //  this.lblContract.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblContract.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblContract.Location = new System.Drawing.Point(30, 41);
    //  this.lblContract.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblContract.Name = "lblContract";
    //  this.lblContract.Size = new System.Drawing.Size(88, 20);
    //  this.lblContract.TabIndex = 0;
    //  this.lblContract.Text = "Hợp Đồng";
    //  // 
    //  // tpgOthers
    //  // 
    //  this.tpgOthers.Controls.Add(this.bteImportPath_CT);
    //  this.tpgOthers.Controls.Add(this.btePdfReaderPath);
    //  this.tpgOthers.Controls.Add(this.labelControl9);
    //  this.tpgOthers.Controls.Add(this.bteImportPath_GH);
    //  this.tpgOthers.Controls.Add(this.bteExportPath);
    //  this.tpgOthers.Controls.Add(this.chkDev);
    //  this.tpgOthers.Controls.Add(this.labelControl7);
    //  this.tpgOthers.Controls.Add(this.chkTronOnline);
    //  this.tpgOthers.Controls.Add(this.chkTinhBuTru);
    //  this.tpgOthers.Controls.Add(this.btnReportPathBrowse);
    //  this.tpgOthers.Controls.Add(this.btnTestReportPath);
    //  this.tpgOthers.Controls.Add(this.lblReportPath);
    //  this.tpgOthers.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.tpgOthers.Name = "tpgOthers";
    //  this.tpgOthers.Size = new System.Drawing.Size(795, 317);
    //  this.tpgOthers.Text = "Khác";
    //  // 
    //  // bteImportPath_CT
    //  // 
    //  this.bteImportPath_CT.Location = new System.Drawing.Point(158, 123);
    //  this.bteImportPath_CT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.bteImportPath_CT.Name = "bteImportPath_CT";
    //  this.bteImportPath_CT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton()});
    //  this.bteImportPath_CT.Size = new System.Drawing.Size(537, 22);
    //  this.bteImportPath_CT.TabIndex = 16;
    //  this.bteImportPath_CT.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteImportPath_CT_ButtonClick);
    //  // 
    //  // btePdfReaderPath
    //  // 
    //  this.btePdfReaderPath.Location = new System.Drawing.Point(158, 166);
    //  this.btePdfReaderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.btePdfReaderPath.Name = "btePdfReaderPath";
    //  this.btePdfReaderPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton()});
    //  this.btePdfReaderPath.Size = new System.Drawing.Size(537, 22);
    //  this.btePdfReaderPath.TabIndex = 16;
    //  this.btePdfReaderPath.Click += new System.EventHandler(this.btePdfReaderPath_Click);
    //  // 
    //  // labelControl9
    //  // 
    //  this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.labelControl9.Appearance.Options.UseFont = true;
    //  this.labelControl9.Appearance.Options.UseTextOptions = true;
    //  this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.labelControl9.Location = new System.Drawing.Point(8, 116);
    //  this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.labelControl9.Name = "labelControl9";
    //  this.labelControl9.Size = new System.Drawing.Size(136, 36);
    //  this.labelControl9.TabIndex = 15;
    //  this.labelControl9.Text = "Nhập File In Chi Tiết";
    //  // 
    //  // bteImportPath_GH
    //  // 
    //  this.bteImportPath_GH.Location = new System.Drawing.Point(158, 80);
    //  this.bteImportPath_GH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.bteImportPath_GH.Name = "bteImportPath_GH";
    //  this.bteImportPath_GH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton()});
    //  this.bteImportPath_GH.Size = new System.Drawing.Size(537, 22);
    //  this.bteImportPath_GH.TabIndex = 14;
    //  this.bteImportPath_GH.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteImportPath_ButtonClick);
    //  // 
    //  // bteExportPath
    //  // 
    //  this.bteExportPath.Location = new System.Drawing.Point(158, 39);
    //  this.bteExportPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.bteExportPath.Name = "bteExportPath";
    //  this.bteExportPath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton()});
    //  this.bteExportPath.Size = new System.Drawing.Size(537, 22);
    //  this.bteExportPath.TabIndex = 13;
    //  this.bteExportPath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteExportPath_ButtonClick);
    //  // 
    //  // chkDev
    //  // 
    //  this.chkDev.Location = new System.Drawing.Point(49, 277);
    //  this.chkDev.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.chkDev.Name = "chkDev";
    //  this.chkDev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.chkDev.Properties.Appearance.Options.UseFont = true;
    //  this.chkDev.Properties.Caption = "Dev";
    //  this.chkDev.Size = new System.Drawing.Size(324, 24);
    //  this.chkDev.TabIndex = 10;
    //  this.chkDev.Visible = false;
    //  // 
    //  // labelControl7
    //  // 
    //  this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.labelControl7.Appearance.Options.UseFont = true;
    //  this.labelControl7.Appearance.Options.UseTextOptions = true;
    //  this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.labelControl7.Location = new System.Drawing.Point(20, 73);
    //  this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.labelControl7.Name = "labelControl7";
    //  this.labelControl7.Size = new System.Drawing.Size(125, 36);
    //  this.labelControl7.TabIndex = 6;
    //  this.labelControl7.Text = "Nhập File In Nhanh";
    //  // 
    //  // chkTronOnline
    //  // 
    //  this.chkTronOnline.Location = new System.Drawing.Point(49, 217);
    //  this.chkTronOnline.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.chkTronOnline.Name = "chkTronOnline";
    //  this.chkTronOnline.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.chkTronOnline.Properties.Appearance.Options.UseFont = true;
    //  this.chkTronOnline.Properties.Caption = "Hiển thị màn hình Vận Hành lúc khởi động";
    //  this.chkTronOnline.Size = new System.Drawing.Size(324, 25);
    //  this.chkTronOnline.TabIndex = 5;
    //  // 
    //  // chkTinhBuTru
    //  // 
    //  this.chkTinhBuTru.Location = new System.Drawing.Point(49, 247);
    //  this.chkTinhBuTru.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.chkTinhBuTru.Name = "chkTinhBuTru";
    //  this.chkTinhBuTru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.chkTinhBuTru.Properties.Appearance.Options.UseFont = true;
    //  this.chkTinhBuTru.Properties.Caption = "Tính khối lượng bù trừ";
    //  this.chkTinhBuTru.Size = new System.Drawing.Size(324, 25);
    //  this.chkTinhBuTru.TabIndex = 4;
    //  this.chkTinhBuTru.Visible = false;
    //  // 
    //  // btnReportPathBrowse
    //  // 
    //  this.btnReportPathBrowse.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.btnReportPathBrowse.Appearance.Options.UseFont = true;
    //  this.btnReportPathBrowse.Location = new System.Drawing.Point(542, 174);
    //  this.btnReportPathBrowse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.btnReportPathBrowse.Name = "btnReportPathBrowse";
    //  this.btnReportPathBrowse.Size = new System.Drawing.Size(152, 37);
    //  this.btnReportPathBrowse.TabIndex = 3;
    //  this.btnReportPathBrowse.Text = "Tìm Đường Dẫn";
    //  this.btnReportPathBrowse.Visible = false;
    //  this.btnReportPathBrowse.Click += new System.EventHandler(this.btnReportPathBrowse_Click);
    //  // 
    //  // btnTestReportPath
    //  // 
    //  this.btnTestReportPath.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.btnTestReportPath.Appearance.Options.UseFont = true;
    //  this.btnTestReportPath.Location = new System.Drawing.Point(542, 219);
    //  this.btnTestReportPath.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.btnTestReportPath.Name = "btnTestReportPath";
    //  this.btnTestReportPath.Size = new System.Drawing.Size(152, 37);
    //  this.btnTestReportPath.TabIndex = 2;
    //  this.btnTestReportPath.Text = "Lưu Đường Dẫn";
    //  this.btnTestReportPath.Visible = false;
    //  this.btnTestReportPath.Click += new System.EventHandler(this.btnTestReportPath_Click);
    //  // 
    //  // lblReportPath
    //  // 
    //  this.lblReportPath.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblReportPath.Appearance.Options.UseFont = true;
    //  this.lblReportPath.Appearance.Options.UseTextOptions = true;
    //  this.lblReportPath.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.lblReportPath.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.lblReportPath.Location = new System.Drawing.Point(8, 32);
    //  this.lblReportPath.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblReportPath.Name = "lblReportPath";
    //  this.lblReportPath.Size = new System.Drawing.Size(136, 36);
    //  this.lblReportPath.TabIndex = 0;
    //  this.lblReportPath.Text = "Xuất File BC";
    //  // 
    //  // xtraTabPage1
    //  // 
    //  this.xtraTabPage1.Controls.Add(this.labelControl8);
    //  this.xtraTabPage1.Controls.Add(this.beFilePathPLC);
    //  this.xtraTabPage1.Controls.Add(this.btnUploadToPLC);
    //  this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.xtraTabPage1.Name = "xtraTabPage1";
    //  this.xtraTabPage1.PageVisible = false;
    //  this.xtraTabPage1.Size = new System.Drawing.Size(795, 317);
    //  this.xtraTabPage1.Text = "Upload Program PLC";
    //  // 
    //  // labelControl8
    //  // 
    //  this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.labelControl8.Appearance.Options.UseFont = true;
    //  this.labelControl8.Appearance.Options.UseTextOptions = true;
    //  this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
    //  this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
    //  this.labelControl8.Location = new System.Drawing.Point(14, 32);
    //  this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.labelControl8.Name = "labelControl8";
    //  this.labelControl8.Size = new System.Drawing.Size(136, 36);
    //  this.labelControl8.TabIndex = 592;
    //  this.labelControl8.Text = "Đường dẫn File nạp";
    //  // 
    //  // beFilePathPLC
    //  // 
    //  this.beFilePathPLC.Location = new System.Drawing.Point(158, 37);
    //  this.beFilePathPLC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.beFilePathPLC.Name = "beFilePathPLC";
    //  this.beFilePathPLC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.beFilePathPLC.Properties.Appearance.Options.UseFont = true;
    //  this.beFilePathPLC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton()});
    //  this.beFilePathPLC.Size = new System.Drawing.Size(355, 26);
    //  this.beFilePathPLC.TabIndex = 591;
    //  this.beFilePathPLC.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beFilePath_ButtonClick);
    //  // 
    //  // btnUploadToPLC
    //  // 
    //  this.btnUploadToPLC.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.btnUploadToPLC.Appearance.Options.UseFont = true;
    //  this.btnUploadToPLC.Location = new System.Drawing.Point(533, 32);
    //  this.btnUploadToPLC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.btnUploadToPLC.Name = "btnUploadToPLC";
    //  this.btnUploadToPLC.Size = new System.Drawing.Size(152, 37);
    //  this.btnUploadToPLC.TabIndex = 590;
    //  this.btnUploadToPLC.Text = "Upload";
    //  this.btnUploadToPLC.Click += new System.EventHandler(this.btnUploadToPLC_Click);
    //  // 
    //  // tpgGeneral
    //  // 
    //  this.tpgGeneral.Controls.Add(this.lueLanguages);
    //  this.tpgGeneral.Controls.Add(this.txtLANPort);
    //  this.tpgGeneral.Controls.Add(this.txtLANIP);
    //  this.tpgGeneral.Controls.Add(this.labelControl4);
    //  this.tpgGeneral.Controls.Add(this.lblIP);
    //  this.tpgGeneral.Controls.Add(this.txtPLCPort);
    //  this.tpgGeneral.Controls.Add(this.btnTestPort);
    //  this.tpgGeneral.Controls.Add(this.btnChangePLCPort);
    //  this.tpgGeneral.Controls.Add(this.labelControl1);
    //  this.tpgGeneral.Controls.Add(this.rdgLanguageRes);
    //  this.tpgGeneral.Controls.Add(this.lblLanguage);
    //  this.tpgGeneral.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.tpgGeneral.Name = "tpgGeneral";
    //  this.tpgGeneral.Size = new System.Drawing.Size(804, 354);
    //  this.tpgGeneral.Text = "Cài Đặt Chung";
    //  // 
    //  // lueLanguages
    //  // 
    //  this.lueLanguages.Location = new System.Drawing.Point(117, 74);
    //  this.lueLanguages.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lueLanguages.Name = "lueLanguages";
    //  this.lueLanguages.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lueLanguages.Properties.Appearance.Options.UseFont = true;
    //  this.lueLanguages.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
    //        new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
    //  this.lueLanguages.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
    //        new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 23, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
    //        new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Languages", 23, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
    //  this.lueLanguages.Properties.DisplayMember = "Code";
    //  this.lueLanguages.Properties.NullText = "";
    //  this.lueLanguages.Properties.ShowFooter = false;
    //  this.lueLanguages.Properties.ShowHeader = false;
    //  this.lueLanguages.Properties.ValueMember = "ID";
    //  this.lueLanguages.Size = new System.Drawing.Size(175, 26);
    //  this.lueLanguages.TabIndex = 12;
    //  // 
    //  // txtLANPort
    //  // 
    //  this.txtLANPort.Location = new System.Drawing.Point(90, 298);
    //  this.txtLANPort.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtLANPort.Name = "txtLANPort";
    //  this.txtLANPort.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtLANPort.Properties.Appearance.Options.UseFont = true;
    //  this.txtLANPort.Size = new System.Drawing.Size(166, 26);
    //  this.txtLANPort.TabIndex = 11;
    //  this.txtLANPort.Visible = false;
    //  // 
    //  // txtLANIP
    //  // 
    //  this.txtLANIP.Location = new System.Drawing.Point(117, 37);
    //  this.txtLANIP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtLANIP.Name = "txtLANIP";
    //  this.txtLANIP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtLANIP.Properties.Appearance.Options.UseFont = true;
    //  this.txtLANIP.Size = new System.Drawing.Size(175, 26);
    //  this.txtLANIP.TabIndex = 10;
    //  // 
    //  // labelControl4
    //  // 
    //  this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.labelControl4.Appearance.Options.UseFont = true;
    //  this.labelControl4.Location = new System.Drawing.Point(22, 225);
    //  this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.labelControl4.Name = "labelControl4";
    //  this.labelControl4.Size = new System.Drawing.Size(73, 19);
    //  this.labelControl4.TabIndex = 9;
    //  this.labelControl4.Text = "Serial Port";
    //  this.labelControl4.Visible = false;
    //  // 
    //  // lblIP
    //  // 
    //  this.lblIP.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblIP.Appearance.Options.UseFont = true;
    //  this.lblIP.Location = new System.Drawing.Point(50, 41);
    //  this.lblIP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblIP.Name = "lblIP";
    //  this.lblIP.Size = new System.Drawing.Size(47, 19);
    //  this.lblIP.TabIndex = 8;
    //  this.lblIP.Text = "IP PLC";
    //  // 
    //  // txtPLCPort
    //  // 
    //  this.txtPLCPort.Location = new System.Drawing.Point(62, 254);
    //  this.txtPLCPort.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.txtPLCPort.Name = "txtPLCPort";
    //  this.txtPLCPort.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.txtPLCPort.Properties.Appearance.Options.UseFont = true;
    //  this.txtPLCPort.Size = new System.Drawing.Size(227, 26);
    //  this.txtPLCPort.TabIndex = 7;
    //  this.txtPLCPort.Visible = false;
    //  // 
    //  // btnTestPort
    //  // 
    //  this.btnTestPort.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.btnTestPort.Appearance.Options.UseFont = true;
    //  this.btnTestPort.Location = new System.Drawing.Point(443, 250);
    //  this.btnTestPort.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.btnTestPort.Name = "btnTestPort";
    //  this.btnTestPort.Size = new System.Drawing.Size(94, 30);
    //  this.btnTestPort.TabIndex = 6;
    //  this.btnTestPort.Text = "Test Port";
    //  this.btnTestPort.Visible = false;
    //  this.btnTestPort.Click += new System.EventHandler(this.btnTestPort_Click);
    //  // 
    //  // btnChangePLCPort
    //  // 
    //  this.btnChangePLCPort.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.btnChangePLCPort.Appearance.Options.UseFont = true;
    //  this.btnChangePLCPort.Location = new System.Drawing.Point(336, 250);
    //  this.btnChangePLCPort.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.btnChangePLCPort.Name = "btnChangePLCPort";
    //  this.btnChangePLCPort.Size = new System.Drawing.Size(94, 30);
    //  this.btnChangePLCPort.TabIndex = 5;
    //  this.btnChangePLCPort.Text = "Change";
    //  this.btnChangePLCPort.Visible = false;
    //  this.btnChangePLCPort.Click += new System.EventHandler(this.btnChangePLCPort_Click);
    //  // 
    //  // labelControl1
    //  // 
    //  this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.labelControl1.Appearance.Options.UseFont = true;
    //  this.labelControl1.Location = new System.Drawing.Point(38, 300);
    //  this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.labelControl1.Name = "labelControl1";
    //  this.labelControl1.Size = new System.Drawing.Size(29, 19);
    //  this.labelControl1.TabIndex = 2;
    //  this.labelControl1.Text = "Port";
    //  this.labelControl1.Visible = false;
    //  // 
    //  // rdgLanguageRes
    //  // 
    //  this.rdgLanguageRes.Location = new System.Drawing.Point(425, 39);
    //  this.rdgLanguageRes.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.rdgLanguageRes.Name = "rdgLanguageRes";
    //  this.rdgLanguageRes.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.rdgLanguageRes.Properties.Appearance.Options.UseFont = true;
    //  this.rdgLanguageRes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
    //  this.rdgLanguageRes.Size = new System.Drawing.Size(227, 64);
    //  this.rdgLanguageRes.TabIndex = 1;
    //  this.rdgLanguageRes.Visible = false;
    //  this.rdgLanguageRes.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.rdgLanguageRes_EditValueChanging);
    //  // 
    //  // lblLanguage
    //  // 
    //  this.lblLanguage.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //  this.lblLanguage.Appearance.Options.UseFont = true;
    //  this.lblLanguage.Location = new System.Drawing.Point(27, 78);
    //  this.lblLanguage.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
    //  this.lblLanguage.Name = "lblLanguage";
    //  this.lblLanguage.Size = new System.Drawing.Size(73, 21);
    //  this.lblLanguage.TabIndex = 0;
    //  this.lblLanguage.Text = "Ngôn Ngữ";
    //  // 
    //  // FrmConfig
    //  // 
    //  this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
    //  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //  this.ClientSize = new System.Drawing.Size(806, 433);
    //  this.Controls.Add(this.tabConfig);
    //  this.Controls.Add(this.panelControl1);
    //  this.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
    //  this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
    //  this.Name = "FrmConfig";
    //  this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
    //  this.Text = "FrmConfig";
    //  this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConfig_FormClosing);
    //  this.Load += new System.EventHandler(this.FrmConfig_Load);
    //  ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
    //  this.panelControl1.ResumeLayout(false);
    //  ((System.ComponentModel.ISupportInitialize)(this.tabConfig)).EndInit();
    //  this.tabConfig.ResumeLayout(false);
    //  this.tpgCompanyInfo.ResumeLayout(false);
    //  this.tpgCompanyInfo.PerformLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.bteLogoPath.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtDienThoaiCty.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtDiaChiCty.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtTenCty.Properties)).EndInit();
    //  this.tpgRunningMode.ResumeLayout(false);
    //  ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtDatabase.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.grpStandAlone)).EndInit();
    //  this.grpStandAlone.ResumeLayout(false);
    //  ((System.ComponentModel.ISupportInitialize)(this.grpService)).EndInit();
    //  this.grpService.ResumeLayout(false);
    //  this.grpService.PerformLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtServerIP.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.lueRunningMode.Properties)).EndInit();
    //  this.tpgOptions.ResumeLayout(false);
    //  ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
    //  this.xtraTabControl1.ResumeLayout(false);
    //  this.tpgRange.ResumeLayout(false);
    //  ((System.ComponentModel.ISupportInitialize)(this.spnKLTronLonNhat.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnKLTronNhoNhat.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnKLChoLonNhat.Properties)).EndInit();
    //  this.tpgFilter.ResumeLayout(false);
    //  ((System.ComponentModel.ISupportInitialize)(this.spnLatestBaoCaoDays.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnLatestHopDongDays.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.spnLatestPhieuTronDays.Properties)).EndInit();
    //  this.tpgOthers.ResumeLayout(false);
    //  ((System.ComponentModel.ISupportInitialize)(this.bteImportPath_CT.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.btePdfReaderPath.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.bteImportPath_GH.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.bteExportPath.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.chkDev.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.chkTronOnline.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.chkTinhBuTru.Properties)).EndInit();
    //  this.xtraTabPage1.ResumeLayout(false);
    //  ((System.ComponentModel.ISupportInitialize)(this.beFilePathPLC.Properties)).EndInit();
    //  this.tpgGeneral.ResumeLayout(false);
    //  this.tpgGeneral.PerformLayout();
    //  ((System.ComponentModel.ISupportInitialize)(this.lueLanguages.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtLANPort.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtLANIP.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.txtPLCPort.Properties)).EndInit();
    //  ((System.ComponentModel.ISupportInitialize)(this.rdgLanguageRes.Properties)).EndInit();
    //  this.ResumeLayout(false);

    //}

    //// Token: 0x04000047 RID: 71
    //private global::System.ComponentModel.IContainer components;

    //// Token: 0x04000048 RID: 72
    //private global::DevExpress.XtraEditors.PanelControl panelControl1;

    //// Token: 0x04000049 RID: 73
    //private global::DevExpress.XtraEditors.SimpleButton btnCancel;

    //// Token: 0x0400004A RID: 74
    //private global::DevExpress.XtraEditors.SimpleButton btnOk;

    //// Token: 0x0400004B RID: 75
    //private global::DevExpress.XtraTab.XtraTabControl tabConfig;

    //// Token: 0x0400004C RID: 76
    //private global::DevExpress.XtraTab.XtraTabPage tpgCompanyInfo;

    //// Token: 0x0400004D RID: 77
    //private global::DevExpress.XtraTab.XtraTabPage tpgRunningMode;

    //// Token: 0x0400004E RID: 78
    //private global::DevExpress.XtraEditors.GroupControl grpStandAlone;

    //// Token: 0x0400004F RID: 79
    //private global::DevExpress.XtraTab.XtraTabPage tpgOptions;

    //// Token: 0x04000050 RID: 80
    //private global::DevExpress.XtraTab.XtraTabPage tpgGeneral;

    //// Token: 0x04000051 RID: 81
    //private global::DevExpress.XtraEditors.LookUpEdit lueRunningMode;

    //// Token: 0x04000052 RID: 82
    //private global::DevExpress.XtraEditors.GroupControl grpService;

    //// Token: 0x04000053 RID: 83
    //private global::DevExpress.XtraEditors.TextEdit txtServerIP;

    //// Token: 0x04000054 RID: 84
    //private global::DevExpress.XtraEditors.LabelControl lblEndpointAddress;

    //// Token: 0x04000055 RID: 85
    //private global::DevExpress.XtraEditors.LabelControl lblRunningMode;

    //// Token: 0x04000056 RID: 86
    //private global::DevExpress.XtraEditors.LabelControl lblAddress;

    //// Token: 0x04000057 RID: 87
    //private global::DevExpress.XtraEditors.LabelControl lblCompanyName;

    //// Token: 0x04000058 RID: 88
    //private global::DevExpress.XtraEditors.TextEdit txtDienThoaiCty;

    //// Token: 0x04000059 RID: 89
    //private global::DevExpress.XtraEditors.TextEdit txtDiaChiCty;

    //// Token: 0x0400005A RID: 90
    //private global::DevExpress.XtraEditors.TextEdit txtTenCty;

    //// Token: 0x0400005B RID: 91
    //private global::DevExpress.XtraEditors.LabelControl lblPhone;

    //// Token: 0x0400005C RID: 92
    //private global::DevExpress.XtraTab.XtraTabControl xtraTabControl1;

    //// Token: 0x0400005D RID: 93
    //private global::DevExpress.XtraTab.XtraTabPage tpgRange;

    //// Token: 0x0400005E RID: 94
    //private global::DevExpress.XtraTab.XtraTabPage tpgFilter;

    //// Token: 0x0400005F RID: 95
    //private global::DevExpress.XtraTab.XtraTabPage tpgOthers;

    //// Token: 0x04000060 RID: 96
    //private global::DevExpress.XtraEditors.CheckEdit chkTinhBuTru;

    //// Token: 0x04000061 RID: 97
    //private global::DevExpress.XtraEditors.SimpleButton btnReportPathBrowse;

    //// Token: 0x04000062 RID: 98
    //private global::DevExpress.XtraEditors.SimpleButton btnTestReportPath;

    //// Token: 0x04000063 RID: 99
    //private global::DevExpress.XtraEditors.LabelControl lblReportPath;

    //// Token: 0x04000064 RID: 100
    //private global::DevExpress.XtraEditors.CheckEdit chkTronOnline;

    //// Token: 0x04000065 RID: 101
    //private global::DevExpress.XtraEditors.SpinEdit spnLatestHopDongDays;

    //// Token: 0x04000066 RID: 102
    //private global::DevExpress.XtraEditors.SpinEdit spnLatestPhieuTronDays;

    //// Token: 0x04000067 RID: 103
    //private global::DevExpress.XtraEditors.LabelControl lblLatestDay2;

    //// Token: 0x04000068 RID: 104
    //private global::DevExpress.XtraEditors.LabelControl lblLatestDay;

    //// Token: 0x04000069 RID: 105
    //private global::DevExpress.XtraEditors.LabelControl lblPhieuTron;

    //// Token: 0x0400006A RID: 106
    //private global::DevExpress.XtraEditors.LabelControl lblContract;

    //// Token: 0x0400006B RID: 107
    //private global::DevExpress.XtraEditors.LabelControl lblKLTronLonNhat;

    //// Token: 0x0400006C RID: 108
    //private global::DevExpress.XtraEditors.LabelControl lblKLTronNhoNhat;

    //// Token: 0x0400006D RID: 109
    //private global::DevExpress.XtraEditors.LabelControl lblKLChoLonNhat;

    //// Token: 0x0400006E RID: 110
    //private global::DevExpress.XtraEditors.SpinEdit spnKLTronLonNhat;

    //// Token: 0x0400006F RID: 111
    //private global::DevExpress.XtraEditors.SpinEdit spnKLTronNhoNhat;

    //// Token: 0x04000070 RID: 112
    //private global::DevExpress.XtraEditors.SpinEdit spnKLChoLonNhat;

    //// Token: 0x04000071 RID: 113
    //private global::DevExpress.XtraEditors.RadioGroup rdgLanguageRes;

    //// Token: 0x04000072 RID: 114
    //private global::DevExpress.XtraEditors.LabelControl lblLanguage;

    //// Token: 0x04000073 RID: 115
    //private global::DevExpress.XtraEditors.TextEdit txtLANPort;

    //// Token: 0x04000074 RID: 116
    //private global::DevExpress.XtraEditors.TextEdit txtLANIP;

    //// Token: 0x04000075 RID: 117
    //private global::DevExpress.XtraEditors.LabelControl labelControl4;

    //// Token: 0x04000076 RID: 118
    //private global::DevExpress.XtraEditors.LabelControl lblIP;

    //// Token: 0x04000077 RID: 119
    //private global::DevExpress.XtraEditors.TextEdit txtPLCPort;

    //// Token: 0x04000078 RID: 120
    //private global::DevExpress.XtraEditors.SimpleButton btnTestPort;

    //// Token: 0x04000079 RID: 121
    //private global::DevExpress.XtraEditors.SimpleButton btnChangePLCPort;

    //// Token: 0x0400007A RID: 122
    //private global::DevExpress.XtraEditors.LabelControl labelControl1;

    //// Token: 0x0400007B RID: 123
    //private global::DevExpress.XtraEditors.LookUpEdit lueLanguages;

    //// Token: 0x0400007C RID: 124
    //private global::DevExpress.XtraEditors.LabelControl labelControl2;

    //// Token: 0x0400007D RID: 125
    //private global::DevExpress.XtraEditors.SimpleButton btnLoadImage;

    //// Token: 0x0400007E RID: 126
    //private global::DevExpress.XtraEditors.PictureEdit pictureEdit1;

    //// Token: 0x0400007F RID: 127
    //private global::DevExpress.XtraEditors.LabelControl labelControl3;

    //// Token: 0x04000080 RID: 128
    //private global::DevExpress.XtraEditors.SimpleButton simpleButton1;

    //// Token: 0x04000081 RID: 129
    //private global::DevExpress.XtraEditors.ButtonEdit bteLogoPath;

    //// Token: 0x04000082 RID: 130
    //private global::DevExpress.XtraEditors.TextEdit txtPassword;

    //// Token: 0x04000083 RID: 131
    //private global::DevExpress.XtraEditors.TextEdit txtUsername;

    //// Token: 0x04000084 RID: 132
    //private global::DevExpress.XtraEditors.TextEdit txtDatabase;

    //// Token: 0x04000085 RID: 133
    //private global::DevExpress.XtraEditors.TextEdit txtServer;

    //// Token: 0x04000086 RID: 134
    //private global::DevExpress.XtraEditors.LabelControl lblPassword;

    //// Token: 0x04000087 RID: 135
    //private global::DevExpress.XtraEditors.LabelControl lblUsername;

    //// Token: 0x04000088 RID: 136
    //private global::DevExpress.XtraEditors.LabelControl lblDatabase;

    //// Token: 0x04000089 RID: 137
    //private global::DevExpress.XtraEditors.LabelControl lblServerName;

    //// Token: 0x0400008A RID: 138
    //private global::DevExpress.XtraEditors.SpinEdit spnLatestBaoCaoDays;

    //// Token: 0x0400008B RID: 139
    //private global::DevExpress.XtraEditors.LabelControl labelControl5;

    //// Token: 0x0400008C RID: 140
    //private global::DevExpress.XtraEditors.LabelControl labelControl6;

    //// Token: 0x0400008D RID: 141
    //private global::DevExpress.XtraEditors.LabelControl labelControl7;

    //// Token: 0x0400008E RID: 142
    //private global::DevExpress.XtraEditors.CheckEdit chkDev;

    //// Token: 0x0400008F RID: 143
    //private global::DevExpress.XtraTab.XtraTabPage xtraTabPage1;

    //// Token: 0x04000090 RID: 144
    //private global::DevExpress.XtraEditors.LabelControl labelControl8;

    //// Token: 0x04000091 RID: 145
    //private global::DevExpress.XtraEditors.ButtonEdit beFilePathPLC;

    //// Token: 0x04000092 RID: 146
    //private global::DevExpress.XtraEditors.SimpleButton btnUploadToPLC;

    //// Token: 0x04000093 RID: 147
    //private global::DevExpress.XtraEditors.ButtonEdit bteImportPath_GH;

    //// Token: 0x04000094 RID: 148
    //private global::DevExpress.XtraEditors.ButtonEdit bteExportPath;

    //// Token: 0x04000095 RID: 149
    //private global::DevExpress.XtraEditors.ButtonEdit bteImportPath_CT;

    //// Token: 0x04000096 RID: 150
    //private global::DevExpress.XtraEditors.ButtonEdit btePdfReaderPath;

    //// Token: 0x04000097 RID: 151
    //private global::DevExpress.XtraEditors.LabelControl labelControl9;

    //// Token: 0x04000098 RID: 152
    //private global::DevExpress.XtraEditors.SimpleButton simpleButton2;

    //// Token: 0x04000099 RID: 153
    //private global::DevExpress.XtraEditors.SimpleButton simpleButton3;
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportChiTietKhoiLuongBeTong
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Reports
{
  public class ReportChiTietKhoiLuongBeTong : ControlViewBase, ISumWeightMngView, IBase, IPermission
  {
    private ReportChiTietKhoiLuongBeTongDataPresenter _presenter;
    public BindingList<Objvw_SumWeight> _blstSumWeight = new BindingList<Objvw_SumWeight>();
    public BindingList<ObjKhachHang> _blstKH = new BindingList<ObjKhachHang>();
    public BindingList<ObjCongTruong> _blstCT = new BindingList<ObjCongTruong>();
    public BindingList<ObjHangMuc> _blstHM = new BindingList<ObjHangMuc>();
    public BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    public BindingList<ObjXe> _blstXe = new BindingList<ObjXe>();
    public BindingList<ObjTaiXe> _blstTX = new BindingList<ObjTaiXe>();
    public BindingList<ObjNhanVien> _blstNV = new BindingList<ObjNhanVien>();
    private IContainer components;
    private GroupControl groupControl1;
    private GroupControl groupControl2;
    private GridControl grcChiTietKhoiLuongBeTong;
    private GridView grvChiTietKhoiLuongBeTong;
    private GridColumn gcMaPhieuTron;
    private GridColumn gcKhachHang;
    private GridColumn gcCongTruong;
    private GridColumn gcMAC;
    private GridColumn gcNhanVien;
    private GridColumn gcTaiXe;
    private GridColumn gcXe;
    private GridColumn gcTongKhoi;
    private GridColumn gcSoMe;
    private GridColumn gcKhoi;
    private GridColumn gcTongVatTu;
    private PanelControl panelControl1;
    private LabelControl labelControl4;
    private PanelControl panelControl2;
    private TextEdit txtMaPhieuTron;
    private LookUpEdit lueCheDo;
    private LabelControl labelControl11;
    private LookUpEdit lueNhanVien;
    private LabelControl labelControl10;
    private LookUpEdit lueMAC;
    private LabelControl labelControl9;
    private LookUpEdit lueBienSo;
    private LabelControl labelControl7;
    private LookUpEdit lueHangMuc;
    private LabelControl labelControl6;
    private LookUpEdit lueKhachHang;
    private LabelControl labelControl5;
    private LookUpEdit lueCongTruong;
    private LabelControl labelControl1;
    private SimpleButton btnReset;
    private SimpleButton btnSearch;
    private LookUpEdit lueTaiXe;
    private LabelControl labelControl3;
    private LabelControl labelControl2;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl labelControl8;
    private LabelControl lblFromDate;
    private GridColumn gcTongCP;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private SimpleButton btnExportExcel;
    private LabelControl labelControl12;
    private GridColumn gcNgayPhieuTron;
    private GridColumn gcHangMuc;

    public BindingList<Objvw_SumWeight> BLstSumWeight
    {
      set
      {
        this._blstSumWeight = value;
        this.grcChiTietKhoiLuongBeTong.DataSource = (object) this._blstSumWeight;
      }
    }

    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set
      {
        this._blstKH = value;
        this.lueKhachHang.Properties.DataSource = (object) this._blstKH;
      }
    }

    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set
      {
        this._blstCT = value;
        this.lueCongTruong.Properties.DataSource = (object) this._blstCT;
      }
    }

    public BindingList<ObjHangMuc> BLstHangMuc
    {
      set
      {
        this._blstHM = value;
        this.lueHangMuc.Properties.DataSource = (object) this._blstHM;
      }
    }

    public BindingList<ObjMAC> BLstMAC
    {
      set
      {
        this._blstMAC = value;
        this.lueMAC.Properties.DataSource = (object) this._blstMAC;
      }
    }

    public BindingList<ObjXe> BLstXe
    {
      set
      {
        this._blstXe = value;
        this.lueBienSo.Properties.DataSource = (object) this._blstXe;
      }
    }

    public BindingList<ObjTaiXe> BLstTaiXe
    {
      set
      {
        this._blstTX = value;
        this.lueTaiXe.Properties.DataSource = (object) this._blstTX;
      }
    }

    public BindingList<ObjNhanVien> BLstNhanVien
    {
      set => this._blstNV = value;
    }

    public ReportChiTietKhoiLuongBeTong()
    {
      this.InitializeComponent();
      this._presenter = new ReportChiTietKhoiLuongBeTongDataPresenter((ISumWeightMngView) this);
      this.Caption = "Chi tiết khối lượng bê tông";
      this._presenter.ListKhachHang();
      this._presenter.ListCongTruong();
      this._presenter.ListHangMuc();
      this._presenter.ListMAC();
      this._presenter.ListXe();
      this._presenter.ListTaiXe();
      this._presenter.ListNhanVien();
      this.lueNhanVien.Properties.DataSource = (object) Converter.ConvertToBindingList<ObjSEC_User>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_User() as List<ObjSEC_User>);
    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(true);
      int slSiloAgg = ConfigManager.TramTronConfig.SL_Silo_AGG;
      int slSiloCe = ConfigManager.TramTronConfig.SL_Silo_CE;
      int slSiloWa = ConfigManager.TramTronConfig.SL_Silo_WA;
      int slSiloAdd = ConfigManager.TramTronConfig.SL_Silo_ADD;
      this.LoadSearchDefaultValues();
    }

    private void LoadDataMix()
    {
      try
      {
        bool? moPhong = new bool?();
        if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
          moPhong = new bool?(false);
        else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
          moPhong = new bool?(true);
        this._blstSumWeight = this._presenter.ListSumWeight_ByCondition_re(new DateTime?(Searching.Build_StartDateTime(this.datFromDate.DateTime)), new DateTime?(Searching.Build_EndDateTime(this.datToDate.DateTime)), this.txtMaPhieuTron.Text, (int?) this.lueKhachHang.EditValue, (int?) this.lueCongTruong.EditValue, (int?) this.lueHangMuc.EditValue, (int?) this.lueMAC.EditValue, (int?) this.lueBienSo.EditValue, (int?) this.lueTaiXe.EditValue, (int?) this.lueNhanVien.EditValue, moPhong);
        this.Invoke((Delegate) (() => this.UpdateUI(this._blstSumWeight)));
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void UpdateUI(BindingList<Objvw_SumWeight> result)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.UpdateUI(result)));
      else
        this.grcChiTietKhoiLuongBeTong.DataSource = (object) result;
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestBaoCaoDays);
      this.datToDate.EditValue = (object) DateTime.Now;
      this.txtMaPhieuTron.Text = string.Empty;
      this.lueKhachHang.EditValue = (object) null;
      this.lueCongTruong.EditValue = (object) null;
      this.lueHangMuc.EditValue = (object) null;
      this.lueMAC.EditValue = (object) null;
      this.lueBienSo.EditValue = (object) null;
      this.lueTaiXe.EditValue = (object) null;
      this.lueNhanVien.EditValue = (object) null;
      this.lueCheDo.EditValue = (object) 2;
    }

    protected override void PopulateData() => Task.Run((Action) (() => this.LoadDataMix()));

    private void btnSearch_Click(object sender, EventArgs e)
    {
      Task.Run((Action) (() => this.LoadDataMix()));
    }

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string title = "BÁO CÁO CHI TIẾT KHỐI LƯỢNG BÊ TÔNG";
        string str1 = string.Format("Từ ngày: {0} - đến ngày: {1}", (object) FormatToString.DateTimeToString(this.datFromDate.DateTime), (object) FormatToString.DateTimeToString(this.datToDate.DateTime));
        string str2 = string.Format("Khách hàng: {0}", (object) this.lueKhachHang.Text);
        string str3 = string.Format("Công trường: {0}", (object) this.lueCongTruong.Text);
        string str4 = string.Format("Hạng mục: {0}", (object) this.lueHangMuc.Text);
        string str5 = string.Format("MAC: {0}", (object) this.lueMAC.Text);
        string str6 = string.Format("Tài xế: {0}", (object) this.lueTaiXe.Text);
        string str7 = string.Format("Biển số: {0}", (object) this.lueBienSo.Text);
        string str8 = string.Format("Nhân viên: {0}", (object) this.lueNhanVien.Text);
        List<string> lstHeader = new List<string>();
        lstHeader.Add(str1);
        if (this.lueKhachHang.EditValue != null)
          lstHeader.Add(str2);
        if (this.lueCongTruong.EditValue != null)
          lstHeader.Add(str3);
        if (this.lueHangMuc.EditValue != null)
          lstHeader.Add(str4);
        if (this.lueMAC.EditValue != null)
          lstHeader.Add(str5);
        if (this.lueTaiXe.EditValue != null)
          lstHeader.Add(str6);
        if (this.lueBienSo.EditValue != null)
          lstHeader.Add(str7);
        if (this.lueNhanVien.EditValue != null)
          lstHeader.Add(str8);
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.grcChiTietKhoiLuongBeTong, true, true, title, lstHeader);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
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
      this.groupControl2 = new GroupControl();
      this.grcChiTietKhoiLuongBeTong = new GridControl();
      this.grvChiTietKhoiLuongBeTong = new GridView();
      this.gcMaPhieuTron = new GridColumn();
      this.gcNgayPhieuTron = new GridColumn();
      this.gcKhachHang = new GridColumn();
      this.gcCongTruong = new GridColumn();
      this.gcHangMuc = new GridColumn();
      this.gcMAC = new GridColumn();
      this.gcNhanVien = new GridColumn();
      this.gcTaiXe = new GridColumn();
      this.gcXe = new GridColumn();
      this.gcTongKhoi = new GridColumn();
      this.gcSoMe = new GridColumn();
      this.gcKhoi = new GridColumn();
      this.gcTongCP = new GridColumn();
      this.gcTongVatTu = new GridColumn();
      this.groupControl1 = new GroupControl();
      this.groupBox2 = new GroupBox();
      this.btnExportExcel = new SimpleButton();
      this.groupBox1 = new GroupBox();
      this.labelControl12 = new LabelControl();
      this.txtMaPhieuTron = new TextEdit();
      this.lueCheDo = new LookUpEdit();
      this.labelControl11 = new LabelControl();
      this.lueNhanVien = new LookUpEdit();
      this.labelControl10 = new LabelControl();
      this.lueMAC = new LookUpEdit();
      this.labelControl9 = new LabelControl();
      this.lueBienSo = new LookUpEdit();
      this.labelControl7 = new LabelControl();
      this.lueHangMuc = new LookUpEdit();
      this.labelControl6 = new LabelControl();
      this.lueKhachHang = new LookUpEdit();
      this.labelControl5 = new LabelControl();
      this.lueCongTruong = new LookUpEdit();
      this.labelControl1 = new LabelControl();
      this.btnReset = new SimpleButton();
      this.btnSearch = new SimpleButton();
      this.lueTaiXe = new LookUpEdit();
      this.labelControl3 = new LabelControl();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.labelControl8 = new LabelControl();
      this.lblFromDate = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.panelControl1 = new PanelControl();
      this.labelControl4 = new LabelControl();
      this.panelControl2 = new PanelControl();
      this.groupControl2.BeginInit();
      this.groupControl2.SuspendLayout();
      this.grcChiTietKhoiLuongBeTong.BeginInit();
      this.grvChiTietKhoiLuongBeTong.BeginInit();
      this.groupControl1.BeginInit();
      this.groupControl1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.txtMaPhieuTron.Properties.BeginInit();
      this.lueCheDo.Properties.BeginInit();
      this.lueNhanVien.Properties.BeginInit();
      this.lueMAC.Properties.BeginInit();
      this.lueBienSo.Properties.BeginInit();
      this.lueHangMuc.Properties.BeginInit();
      this.lueKhachHang.Properties.BeginInit();
      this.lueCongTruong.Properties.BeginInit();
      this.lueTaiXe.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.SuspendLayout();
      this.groupControl2.Controls.Add((Control) this.grcChiTietKhoiLuongBeTong);
      this.groupControl2.Dock = DockStyle.Fill;
      this.groupControl2.Location = new Point(2, 2);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(1068, 779);
      this.groupControl2.TabIndex = 1;
      this.groupControl2.Text = "Dữ liệu";
      this.grcChiTietKhoiLuongBeTong.Dock = DockStyle.Fill;
      this.grcChiTietKhoiLuongBeTong.Location = new Point(2, 23);
      this.grcChiTietKhoiLuongBeTong.MainView = (BaseView) this.grvChiTietKhoiLuongBeTong;
      this.grcChiTietKhoiLuongBeTong.Name = "grcChiTietKhoiLuongBeTong";
      this.grcChiTietKhoiLuongBeTong.Size = new Size(1064, 754);
      this.grcChiTietKhoiLuongBeTong.TabIndex = 0;
      this.grcChiTietKhoiLuongBeTong.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvChiTietKhoiLuongBeTong
      });
      this.grvChiTietKhoiLuongBeTong.AppearancePrint.HeaderPanel.BackColor = Color.DodgerBlue;
      this.grvChiTietKhoiLuongBeTong.AppearancePrint.HeaderPanel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grvChiTietKhoiLuongBeTong.AppearancePrint.HeaderPanel.ForeColor = Color.White;
      this.grvChiTietKhoiLuongBeTong.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.grvChiTietKhoiLuongBeTong.AppearancePrint.HeaderPanel.Options.UseFont = true;
      this.grvChiTietKhoiLuongBeTong.AppearancePrint.HeaderPanel.Options.UseForeColor = true;
      this.grvChiTietKhoiLuongBeTong.Columns.AddRange(new GridColumn[14]
      {
        this.gcMaPhieuTron,
        this.gcNgayPhieuTron,
        this.gcKhachHang,
        this.gcCongTruong,
        this.gcHangMuc,
        this.gcMAC,
        this.gcNhanVien,
        this.gcTaiXe,
        this.gcXe,
        this.gcTongKhoi,
        this.gcSoMe,
        this.gcKhoi,
        this.gcTongCP,
        this.gcTongVatTu
      });
      this.grvChiTietKhoiLuongBeTong.GridControl = this.grcChiTietKhoiLuongBeTong;
      this.grvChiTietKhoiLuongBeTong.Name = "grvChiTietKhoiLuongBeTong";
      this.grvChiTietKhoiLuongBeTong.OptionsView.ShowFooter = true;
      this.gcMaPhieuTron.Caption = "Mã phiếu trộn";
      this.gcMaPhieuTron.FieldName = "MaPhieuTron";
      this.gcMaPhieuTron.MinWidth = 100;
      this.gcMaPhieuTron.Name = "gcMaPhieuTron";
      this.gcMaPhieuTron.OptionsColumn.AllowFocus = false;
      this.gcMaPhieuTron.OptionsColumn.ReadOnly = true;
      this.gcMaPhieuTron.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Count, "MaPhieuTron", "{0} - phiếu")
      });
      this.gcMaPhieuTron.Visible = true;
      this.gcMaPhieuTron.VisibleIndex = 0;
      this.gcMaPhieuTron.Width = 100;
      this.gcNgayPhieuTron.Caption = "Ngày lập";
      this.gcNgayPhieuTron.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.gcNgayPhieuTron.DisplayFormat.FormatType = FormatType.DateTime;
      this.gcNgayPhieuTron.FieldName = "NgayPhieuTron";
      this.gcNgayPhieuTron.MinWidth = 100;
      this.gcNgayPhieuTron.Name = "gcNgayPhieuTron";
      this.gcNgayPhieuTron.OptionsColumn.AllowFocus = false;
      this.gcNgayPhieuTron.OptionsColumn.ReadOnly = true;
      this.gcNgayPhieuTron.Visible = true;
      this.gcNgayPhieuTron.VisibleIndex = 1;
      this.gcNgayPhieuTron.Width = 100;
      this.gcKhachHang.Caption = "Khách hàng";
      this.gcKhachHang.FieldName = "TenKhachHang";
      this.gcKhachHang.MinWidth = 100;
      this.gcKhachHang.Name = "gcKhachHang";
      this.gcKhachHang.OptionsColumn.AllowFocus = false;
      this.gcKhachHang.OptionsColumn.ReadOnly = true;
      this.gcKhachHang.Visible = true;
      this.gcKhachHang.VisibleIndex = 2;
      this.gcKhachHang.Width = 100;
      this.gcCongTruong.Caption = "Công trường";
      this.gcCongTruong.FieldName = "TenCongTruong";
      this.gcCongTruong.MinWidth = 100;
      this.gcCongTruong.Name = "gcCongTruong";
      this.gcCongTruong.OptionsColumn.AllowFocus = false;
      this.gcCongTruong.OptionsColumn.ReadOnly = true;
      this.gcCongTruong.Visible = true;
      this.gcCongTruong.VisibleIndex = 3;
      this.gcCongTruong.Width = 100;
      this.gcHangMuc.Caption = "Tên Hạng mục";
      this.gcHangMuc.FieldName = "TenHangMuc";
      this.gcHangMuc.MinWidth = 100;
      this.gcHangMuc.Name = "gcHangMuc";
      this.gcHangMuc.OptionsColumn.AllowFocus = false;
      this.gcHangMuc.OptionsColumn.ReadOnly = true;
      this.gcHangMuc.Visible = true;
      this.gcHangMuc.VisibleIndex = 4;
      this.gcHangMuc.Width = 100;
      this.gcMAC.Caption = "MAC";
      this.gcMAC.FieldName = "TenMAC";
      this.gcMAC.MinWidth = 100;
      this.gcMAC.Name = "gcMAC";
      this.gcMAC.OptionsColumn.AllowFocus = false;
      this.gcMAC.OptionsColumn.ReadOnly = true;
      this.gcMAC.Visible = true;
      this.gcMAC.VisibleIndex = 5;
      this.gcMAC.Width = 100;
      this.gcNhanVien.Caption = "Người trộn";
      this.gcNhanVien.FieldName = "FullName";
      this.gcNhanVien.MinWidth = 100;
      this.gcNhanVien.Name = "gcNhanVien";
      this.gcNhanVien.OptionsColumn.AllowFocus = false;
      this.gcNhanVien.OptionsColumn.ReadOnly = true;
      this.gcNhanVien.Visible = true;
      this.gcNhanVien.VisibleIndex = 6;
      this.gcNhanVien.Width = 100;
      this.gcTaiXe.Caption = "Tài xế";
      this.gcTaiXe.FieldName = "TenTaiXe";
      this.gcTaiXe.MinWidth = 100;
      this.gcTaiXe.Name = "gcTaiXe";
      this.gcTaiXe.OptionsColumn.AllowFocus = false;
      this.gcTaiXe.OptionsColumn.ReadOnly = true;
      this.gcTaiXe.Visible = true;
      this.gcTaiXe.VisibleIndex = 7;
      this.gcTaiXe.Width = 100;
      this.gcXe.Caption = "Biển số";
      this.gcXe.FieldName = "BienSo";
      this.gcXe.MinWidth = 100;
      this.gcXe.Name = "gcXe";
      this.gcXe.OptionsColumn.AllowFocus = false;
      this.gcXe.OptionsColumn.ReadOnly = true;
      this.gcXe.Visible = true;
      this.gcXe.VisibleIndex = 8;
      this.gcXe.Width = 100;
      this.gcTongKhoi.Caption = "Tổng khối";
      this.gcTongKhoi.FieldName = "TongKhoiLuong";
      this.gcTongKhoi.MinWidth = 100;
      this.gcTongKhoi.Name = "gcTongKhoi";
      this.gcTongKhoi.OptionsColumn.AllowFocus = false;
      this.gcTongKhoi.OptionsColumn.ReadOnly = true;
      this.gcTongKhoi.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "TongKhoiLuong", "{0:0.##}")
      });
      this.gcTongKhoi.Visible = true;
      this.gcTongKhoi.VisibleIndex = 9;
      this.gcTongKhoi.Width = 100;
      this.gcSoMe.Caption = "Số mẻ";
      this.gcSoMe.FieldName = "TongMeTron";
      this.gcSoMe.MinWidth = 100;
      this.gcSoMe.Name = "gcSoMe";
      this.gcSoMe.OptionsColumn.AllowFocus = false;
      this.gcSoMe.OptionsColumn.ReadOnly = true;
      this.gcSoMe.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "TongMeTron", "{0:0.##}")
      });
      this.gcSoMe.Visible = true;
      this.gcSoMe.VisibleIndex = 10;
      this.gcSoMe.Width = 100;
      this.gcKhoi.Caption = "M3/Mẻ";
      this.gcKhoi.FieldName = "KLDuTinhCuaTungMe";
      this.gcKhoi.MinWidth = 100;
      this.gcKhoi.Name = "gcKhoi";
      this.gcKhoi.OptionsColumn.AllowFocus = false;
      this.gcKhoi.OptionsColumn.ReadOnly = true;
      this.gcKhoi.Visible = true;
      this.gcKhoi.VisibleIndex = 11;
      this.gcKhoi.Width = 100;
      this.gcTongCP.Caption = "Tổng cấp phối";
      this.gcTongCP.FieldName = "SUM_Total_Value";
      this.gcTongCP.MinWidth = 100;
      this.gcTongCP.Name = "gcTongCP";
      this.gcTongCP.OptionsColumn.AllowFocus = false;
      this.gcTongCP.OptionsColumn.ReadOnly = true;
      this.gcTongCP.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "SUM_Total_Value", "{0:0.##}")
      });
      this.gcTongCP.Visible = true;
      this.gcTongCP.VisibleIndex = 12;
      this.gcTongCP.Width = 100;
      this.gcTongVatTu.Caption = "Tổng thực cân";
      this.gcTongVatTu.FieldName = "SUM_Total_ValueBat";
      this.gcTongVatTu.MinWidth = 100;
      this.gcTongVatTu.Name = "gcTongVatTu";
      this.gcTongVatTu.OptionsColumn.AllowFocus = false;
      this.gcTongVatTu.OptionsColumn.ReadOnly = true;
      this.gcTongVatTu.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "SUM_Total_ValueBat", "{0:0.##}")
      });
      this.gcTongVatTu.Visible = true;
      this.gcTongVatTu.VisibleIndex = 13;
      this.gcTongVatTu.Width = 100;
      this.groupControl1.Controls.Add((Control) this.groupBox2);
      this.groupControl1.Controls.Add((Control) this.groupBox1);
      this.groupControl1.Controls.Add((Control) this.labelControl2);
      this.groupControl1.Dock = DockStyle.Right;
      this.groupControl1.Location = new Point(1070, 2);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(280, 779);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "Tác vụ";
      this.groupBox2.Controls.Add((Control) this.btnExportExcel);
      this.groupBox2.Dock = DockStyle.Bottom;
      this.groupBox2.Location = new Point(2, 631);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(276, 146);
      this.groupBox2.TabIndex = 75;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Xuất dữ liệu";
      this.btnExportExcel.AllowFocus = false;
      this.btnExportExcel.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnExportExcel.Appearance.Options.UseFont = true;
      this.btnExportExcel.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.btnExportExcel.ImageOptions.Image = (Image) ResourceNhua.eexport_Excel;
      this.btnExportExcel.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
      this.btnExportExcel.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.btnExportExcel.Location = new Point(80, 60);
      this.btnExportExcel.Name = "btnExportExcel";
      this.btnExportExcel.Size = new Size(120, 45);
      this.btnExportExcel.TabIndex = 74;
      this.btnExportExcel.Text = "Xuất Excel";
      this.btnExportExcel.Click += new EventHandler(this.btnExportExcel_Click);
      this.groupBox1.Controls.Add((Control) this.labelControl12);
      this.groupBox1.Controls.Add((Control) this.txtMaPhieuTron);
      this.groupBox1.Controls.Add((Control) this.lueCheDo);
      this.groupBox1.Controls.Add((Control) this.labelControl11);
      this.groupBox1.Controls.Add((Control) this.lueNhanVien);
      this.groupBox1.Controls.Add((Control) this.labelControl10);
      this.groupBox1.Controls.Add((Control) this.lueMAC);
      this.groupBox1.Controls.Add((Control) this.labelControl9);
      this.groupBox1.Controls.Add((Control) this.lueBienSo);
      this.groupBox1.Controls.Add((Control) this.labelControl7);
      this.groupBox1.Controls.Add((Control) this.lueHangMuc);
      this.groupBox1.Controls.Add((Control) this.labelControl6);
      this.groupBox1.Controls.Add((Control) this.lueKhachHang);
      this.groupBox1.Controls.Add((Control) this.labelControl5);
      this.groupBox1.Controls.Add((Control) this.lueCongTruong);
      this.groupBox1.Controls.Add((Control) this.labelControl1);
      this.groupBox1.Controls.Add((Control) this.btnReset);
      this.groupBox1.Controls.Add((Control) this.btnSearch);
      this.groupBox1.Controls.Add((Control) this.lueTaiXe);
      this.groupBox1.Controls.Add((Control) this.labelControl3);
      this.groupBox1.Controls.Add((Control) this.datToDate);
      this.groupBox1.Controls.Add((Control) this.datFromDate);
      this.groupBox1.Controls.Add((Control) this.labelControl8);
      this.groupBox1.Controls.Add((Control) this.lblFromDate);
      this.groupBox1.Dock = DockStyle.Fill;
      this.groupBox1.Location = new Point(2, 23);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(276, 754);
      this.groupBox1.TabIndex = 73;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Bộ loc";
      this.labelControl12.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl12.Appearance.Options.UseFont = true;
      this.labelControl12.Location = new Point(17, 93);
      this.labelControl12.Name = "labelControl12";
      this.labelControl12.Size = new Size(79, 16);
      this.labelControl12.TabIndex = 78;
      this.labelControl12.Text = "Mã phiếu trộn";
      this.txtMaPhieuTron.Location = new Point(112, 90);
      this.txtMaPhieuTron.Name = "txtMaPhieuTron";
      this.txtMaPhieuTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.txtMaPhieuTron.Size = new Size(150, 22);
      this.txtMaPhieuTron.TabIndex = 72;
      this.lueCheDo.Location = new Point(112, 330);
      this.lueCheDo.Name = "lueCheDo";
      this.lueCheDo.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueCheDo.Properties.Appearance.Options.UseFont = true;
      this.lueCheDo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueCheDo.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("DisplayText", "Chế độ")
      });
      this.lueCheDo.Properties.DisplayMember = "DisplayText";
      this.lueCheDo.Properties.NullText = "";
      this.lueCheDo.Properties.ValueMember = "ID";
      this.lueCheDo.Size = new Size(150, 22);
      this.lueCheDo.TabIndex = 71;
      this.labelControl11.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl11.Appearance.Options.UseFont = true;
      this.labelControl11.Location = new Point(17, 333);
      this.labelControl11.Name = "labelControl11";
      this.labelControl11.Size = new Size(40, 16);
      this.labelControl11.TabIndex = 70;
      this.labelControl11.Text = "Chế độ";
      this.lueNhanVien.Location = new Point(112, 300);
      this.lueNhanVien.Name = "lueNhanVien";
      this.lueNhanVien.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueNhanVien.Properties.Appearance.Options.UseFont = true;
      this.lueNhanVien.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueNhanVien.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("UserID", "UserID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("FullName", "Tên Nhân viên")
      });
      this.lueNhanVien.Properties.DisplayMember = "FullName";
      this.lueNhanVien.Properties.NullText = "";
      this.lueNhanVien.Properties.ValueMember = "UserID";
      this.lueNhanVien.Size = new Size(150, 22);
      this.lueNhanVien.TabIndex = 69;
      this.labelControl10.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl10.Appearance.Options.UseFont = true;
      this.labelControl10.Location = new Point(17, 303);
      this.labelControl10.Name = "labelControl10";
      this.labelControl10.Size = new Size(60, 16);
      this.labelControl10.TabIndex = 68;
      this.labelControl10.Text = "Người trộn";
      this.lueMAC.Location = new Point(112, 270);
      this.lueMAC.Name = "lueMAC";
      this.lueMAC.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueMAC.Properties.Appearance.Options.UseFont = true;
      this.lueMAC.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueMAC.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("MACID", "MACID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenMAC", "Tên MAC")
      });
      this.lueMAC.Properties.DisplayMember = "TenMAC";
      this.lueMAC.Properties.NullText = "";
      this.lueMAC.Properties.ValueMember = "MACID";
      this.lueMAC.Size = new Size(150, 22);
      this.lueMAC.TabIndex = 67;
      this.labelControl9.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Location = new Point(17, 273);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new Size(52, 16);
      this.labelControl9.TabIndex = 66;
      this.labelControl9.Text = "Tên MAC";
      this.lueBienSo.Location = new Point(112, 240);
      this.lueBienSo.Name = "lueBienSo";
      this.lueBienSo.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueBienSo.Properties.Appearance.Options.UseFont = true;
      this.lueBienSo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueBienSo.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("XeID", "XeID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("BienSo", "Biển số")
      });
      this.lueBienSo.Properties.DisplayMember = "BienSo";
      this.lueBienSo.Properties.NullText = "";
      this.lueBienSo.Properties.ValueMember = "XeID";
      this.lueBienSo.Size = new Size(150, 22);
      this.lueBienSo.TabIndex = 65;
      this.labelControl7.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl7.Appearance.Options.UseFont = true;
      this.labelControl7.Location = new Point(17, 243);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new Size(41, 16);
      this.labelControl7.TabIndex = 64;
      this.labelControl7.Text = "Biển số";
      this.lueHangMuc.Location = new Point(112, 180);
      this.lueHangMuc.Name = "lueHangMuc";
      this.lueHangMuc.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueHangMuc.Properties.Appearance.Options.UseFont = true;
      this.lueHangMuc.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueHangMuc.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("HangMucID", "HangMucID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenHangMuc", "Tên Hạng mục")
      });
      this.lueHangMuc.Properties.DisplayMember = "TenHangMuc";
      this.lueHangMuc.Properties.NullText = "";
      this.lueHangMuc.Properties.ValueMember = "HangMucID";
      this.lueHangMuc.Size = new Size(150, 22);
      this.lueHangMuc.TabIndex = 63;
      this.labelControl6.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl6.Appearance.Options.UseFont = true;
      this.labelControl6.Location = new Point(17, 183);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new Size(57, 16);
      this.labelControl6.TabIndex = 62;
      this.labelControl6.Text = "Hạng mục";
      this.lueKhachHang.Location = new Point(112, 120);
      this.lueKhachHang.Name = "lueKhachHang";
      this.lueKhachHang.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueKhachHang.Properties.Appearance.Options.UseFont = true;
      this.lueKhachHang.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueKhachHang.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("KhachHangID", "KhachHangID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenKhachHang", "Tên Khách hàng")
      });
      this.lueKhachHang.Properties.DisplayMember = "TenKhachHang";
      this.lueKhachHang.Properties.NullText = "";
      this.lueKhachHang.Properties.ValueMember = "KhachHangID";
      this.lueKhachHang.Size = new Size(150, 22);
      this.lueKhachHang.TabIndex = 61;
      this.labelControl5.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new Point(17, 123);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(66, 16);
      this.labelControl5.TabIndex = 60;
      this.labelControl5.Text = "Khách hàng";
      this.lueCongTruong.Location = new Point(112, 150);
      this.lueCongTruong.Name = "lueCongTruong";
      this.lueCongTruong.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueCongTruong.Properties.Appearance.Options.UseFont = true;
      this.lueCongTruong.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueCongTruong.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("CongTruongID", "CongTruongID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.True),
        new LookUpColumnInfo("TenCongTruong", "Tên Công trường")
      });
      this.lueCongTruong.Properties.DisplayMember = "TenCongTruong";
      this.lueCongTruong.Properties.NullText = "";
      this.lueCongTruong.Properties.ValueMember = "CongTruongID";
      this.lueCongTruong.Size = new Size(150, 22);
      this.lueCongTruong.TabIndex = 59;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(17, 153);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(71, 16);
      this.labelControl1.TabIndex = 58;
      this.labelControl1.Text = "Công trường";
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(17, 380);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(108, 32);
      this.btnReset.TabIndex = 57;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(154, 380);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(108, 32);
      this.btnSearch.TabIndex = 56;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
      this.lueTaiXe.Location = new Point(112, 210);
      this.lueTaiXe.Name = "lueTaiXe";
      this.lueTaiXe.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueTaiXe.Properties.Appearance.Options.UseFont = true;
      this.lueTaiXe.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueTaiXe.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("TaiXeID", "TaiXeID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenTaiXe", "Tên Tài xế")
      });
      this.lueTaiXe.Properties.DisplayMember = "TenTaiXe";
      this.lueTaiXe.Properties.NullText = "";
      this.lueTaiXe.Properties.ValueMember = "TaiXeID";
      this.lueTaiXe.Size = new Size(150, 22);
      this.lueTaiXe.TabIndex = 55;
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(17, 213);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(35, 16);
      this.labelControl3.TabIndex = 54;
      this.labelControl3.Text = "Tài xế";
      this.datToDate.EditValue = (object) null;
      this.datToDate.Location = new Point(112, 60);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datToDate.Properties.Appearance.Options.UseFont = true;
      this.datToDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datToDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datToDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datToDate.Size = new Size(150, 22);
      this.datToDate.TabIndex = 52;
      this.datFromDate.EditValue = (object) null;
      this.datFromDate.Location = new Point(112, 30);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datFromDate.Properties.Appearance.Options.UseFont = true;
      this.datFromDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datFromDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datFromDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datFromDate.Size = new Size(150, 22);
      this.datFromDate.TabIndex = 51;
      this.labelControl8.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl8.Appearance.Options.UseFont = true;
      this.labelControl8.Location = new Point(17, 63);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new Size(54, 16);
      this.labelControl8.TabIndex = 50;
      this.labelControl8.Text = "Đến ngày";
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(17, 33);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(69, 16);
      this.lblFromDate.TabIndex = 49;
      this.lblFromDate.Text = "Tạo từ ngày";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(11, 142);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(79, 16);
      this.labelControl2.TabIndex = 53;
      this.labelControl2.Text = "Mã phiếu trộn";
      this.panelControl1.Controls.Add((Control) this.labelControl4);
      this.panelControl1.Dock = DockStyle.Top;
      this.panelControl1.Location = new Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(1352, 50);
      this.panelControl1.TabIndex = 2;
      this.labelControl4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.labelControl4.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Appearance.Options.UseTextOptions = true;
      this.labelControl4.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.labelControl4.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl4.Location = new Point(10, 2);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(893, 48);
      this.labelControl4.TabIndex = 0;
      this.labelControl4.Text = "BÁO CÁO CHI TIẾT KHỐI LƯỢNG BÊ TÔNG";
      this.panelControl2.Controls.Add((Control) this.groupControl2);
      this.panelControl2.Controls.Add((Control) this.groupControl1);
      this.panelControl2.Dock = DockStyle.Fill;
      this.panelControl2.Location = new Point(0, 50);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(1352, 783);
      this.panelControl2.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.panelControl2);
      this.Controls.Add((Control) this.panelControl1);
      this.Name = nameof (ReportChiTietKhoiLuongBeTong);
      this.Size = new Size(1352, 833);
      this.groupControl2.EndInit();
      this.groupControl2.ResumeLayout(false);
      this.grcChiTietKhoiLuongBeTong.EndInit();
      this.grvChiTietKhoiLuongBeTong.EndInit();
      this.groupControl1.EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupControl1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.txtMaPhieuTron.Properties.EndInit();
      this.lueCheDo.Properties.EndInit();
      this.lueNhanVien.Properties.EndInit();
      this.lueMAC.Properties.EndInit();
      this.lueBienSo.Properties.EndInit();
      this.lueHangMuc.Properties.EndInit();
      this.lueKhachHang.Properties.EndInit();
      this.lueCongTruong.Properties.EndInit();
      this.lueTaiXe.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

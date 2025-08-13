// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportTongKhoiLuong
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
  public class ReportTongKhoiLuong : ControlViewBase, ISumWeightMngView, IBase, IPermission
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
    private GroupControl groupControl2;
    private GridControl grcTongKhoiLuong;
    private GridView grvTongKhoiLuong;
    private GridColumn gcNgayLap;
    private GridColumn gcKhachHang;
    private GridColumn gcMAC;
    private GridColumn gcTongKhoiLuong;
    private GridColumn gcMeTron;
    private GroupControl groupControl1;
    private SimpleButton simpleButton1;
    private SimpleButton btnTimKiem;
    private PanelControl panelControl1;
    private LabelControl labelControl4;
    private PanelControl panelControl2;
    private TextEdit txtMaPhieuTron;
    private LookUpEdit lueKhachHang;
    private LabelControl labelControl5;
    private LookUpEdit lueCongTruong;
    private LabelControl labelControl1;
    private LabelControl labelControl2;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl labelControl8;
    private LabelControl lblFromDate;
    private LookUpEdit lueCheDo;
    private LabelControl labelControl11;
    private LookUpEdit lueMAC;
    private LabelControl labelControl9;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private SimpleButton btnExportExcel;

    public BindingList<Objvw_SumWeight> BLstSumWeight
    {
      set
      {
        this._blstSumWeight = value;
        this.grcTongKhoiLuong.DataSource = (object) this._blstSumWeight;
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

    public BindingList<ObjMAC> BLstMAC
    {
      set
      {
        this._blstMAC = value;
        this.lueMAC.Properties.DataSource = (object) this._blstMAC;
      }
    }

    public BindingList<ObjHangMuc> BLstHangMuc
    {
      set => this._blstHM = value;
    }

    public BindingList<ObjXe> BLstXe
    {
      set => this._blstXe = value;
    }

    public BindingList<ObjTaiXe> BLstTaiXe
    {
      set => this._blstTX = value;
    }

    public BindingList<ObjNhanVien> BLstNhanVien
    {
      set => this._blstNV = value;
    }

    public ReportTongKhoiLuong()
    {
      this.InitializeComponent();
      this._presenter = new ReportChiTietKhoiLuongBeTongDataPresenter((ISumWeightMngView) this);
      this.Caption = "Tổng khối lương";
      this._presenter.ListKhachHang();
      this._presenter.ListCongTruong();
      this._presenter.ListMAC();
    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(true);
      this.LoadSearchDefaultValues();
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestBaoCaoDays);
      this.datToDate.EditValue = (object) DateTime.Now;
      this.lueKhachHang.EditValue = (object) null;
      this.lueCongTruong.EditValue = (object) null;
      this.lueMAC.EditValue = (object) null;
      this.lueCheDo.EditValue = (object) 2;
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
        this._blstSumWeight = this._presenter.ListSumWeight_ByCondition_re(new DateTime?(Searching.Build_StartDateTime(this.datFromDate.DateTime)), new DateTime?(Searching.Build_EndDateTime(this.datToDate.DateTime)), this.txtMaPhieuTron.Text, (int?) this.lueKhachHang.EditValue, (int?) this.lueCongTruong.EditValue, new int?(), (int?) this.lueMAC.EditValue, new int?(), new int?(), new int?(), moPhong);
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
        this.grcTongKhoiLuong.DataSource = (object) result;
    }

    protected override void PopulateData() => Task.Run((Action) (() => this.LoadDataMix()));

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      Task.Run((Action) (() => this.LoadDataMix()));
    }

    private void simpleButton1_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string title = "BÁO CÁO TỔNG KHỐI LƯỢNG BÊ TÔNG";
        string str1 = string.Format("Từ ngày: {0} - đến ngày: {1}", (object) FormatToString.DateTimeToString(this.datFromDate.DateTime), (object) FormatToString.DateTimeToString(this.datToDate.DateTime));
        string str2 = string.Format("Khách hàng: {0}", (object) this.lueKhachHang.Text);
        string str3 = string.Format("Công trường: {0}", (object) this.lueCongTruong.Text);
        string str4 = string.Format("MAC: {0}", (object) this.lueMAC.Text);
        List<string> lstHeader = new List<string>();
        lstHeader.Add(str1);
        if (this.lueKhachHang.EditValue != null)
          lstHeader.Add(str2);
        if (this.lueCongTruong.EditValue != null)
          lstHeader.Add(str3);
        if (this.lueMAC.EditValue != null)
          lstHeader.Add(str4);
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.grcTongKhoiLuong, true, true, title, lstHeader);
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
      this.grcTongKhoiLuong = new GridControl();
      this.grvTongKhoiLuong = new GridView();
      this.gcNgayLap = new GridColumn();
      this.gcKhachHang = new GridColumn();
      this.gcMAC = new GridColumn();
      this.gcTongKhoiLuong = new GridColumn();
      this.gcMeTron = new GridColumn();
      this.groupControl1 = new GroupControl();
      this.groupBox1 = new GroupBox();
      this.lueCheDo = new LookUpEdit();
      this.labelControl11 = new LabelControl();
      this.lueMAC = new LookUpEdit();
      this.labelControl9 = new LabelControl();
      this.txtMaPhieuTron = new TextEdit();
      this.lueKhachHang = new LookUpEdit();
      this.labelControl5 = new LabelControl();
      this.lueCongTruong = new LookUpEdit();
      this.labelControl1 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.labelControl8 = new LabelControl();
      this.lblFromDate = new LabelControl();
      this.simpleButton1 = new SimpleButton();
      this.btnTimKiem = new SimpleButton();
      this.groupBox2 = new GroupBox();
      this.btnExportExcel = new SimpleButton();
      this.panelControl1 = new PanelControl();
      this.labelControl4 = new LabelControl();
      this.panelControl2 = new PanelControl();
      this.groupControl2.BeginInit();
      this.groupControl2.SuspendLayout();
      this.grcTongKhoiLuong.BeginInit();
      this.grvTongKhoiLuong.BeginInit();
      this.groupControl1.BeginInit();
      this.groupControl1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.lueCheDo.Properties.BeginInit();
      this.lueMAC.Properties.BeginInit();
      this.txtMaPhieuTron.Properties.BeginInit();
      this.lueKhachHang.Properties.BeginInit();
      this.lueCongTruong.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.groupBox2.SuspendLayout();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.SuspendLayout();
      this.groupControl2.Controls.Add((Control) this.grcTongKhoiLuong);
      this.groupControl2.Dock = DockStyle.Fill;
      this.groupControl2.Location = new Point(2, 2);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(632, 513);
      this.groupControl2.TabIndex = 3;
      this.groupControl2.Text = "Dữ liệu";
      this.grcTongKhoiLuong.Dock = DockStyle.Fill;
      this.grcTongKhoiLuong.Location = new Point(2, 23);
      this.grcTongKhoiLuong.MainView = (BaseView) this.grvTongKhoiLuong;
      this.grcTongKhoiLuong.Name = "grcTongKhoiLuong";
      this.grcTongKhoiLuong.Size = new Size(628, 488);
      this.grcTongKhoiLuong.TabIndex = 0;
      this.grcTongKhoiLuong.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvTongKhoiLuong
      });
      this.grvTongKhoiLuong.AppearancePrint.FooterPanel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grvTongKhoiLuong.AppearancePrint.FooterPanel.Options.UseFont = true;
      this.grvTongKhoiLuong.AppearancePrint.HeaderPanel.BackColor = Color.DodgerBlue;
      this.grvTongKhoiLuong.AppearancePrint.HeaderPanel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grvTongKhoiLuong.AppearancePrint.HeaderPanel.ForeColor = Color.White;
      this.grvTongKhoiLuong.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.grvTongKhoiLuong.AppearancePrint.HeaderPanel.Options.UseFont = true;
      this.grvTongKhoiLuong.AppearancePrint.HeaderPanel.Options.UseForeColor = true;
      this.grvTongKhoiLuong.Columns.AddRange(new GridColumn[5]
      {
        this.gcNgayLap,
        this.gcKhachHang,
        this.gcMAC,
        this.gcTongKhoiLuong,
        this.gcMeTron
      });
      this.grvTongKhoiLuong.GridControl = this.grcTongKhoiLuong;
      this.grvTongKhoiLuong.Name = "grvTongKhoiLuong";
      this.grvTongKhoiLuong.OptionsView.ShowFooter = true;
      this.gcNgayLap.Caption = "Ngày lập";
      this.gcNgayLap.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.gcNgayLap.DisplayFormat.FormatType = FormatType.DateTime;
      this.gcNgayLap.FieldName = "NgayPhieuTron";
      this.gcNgayLap.Name = "gcNgayLap";
      this.gcNgayLap.OptionsColumn.AllowFocus = false;
      this.gcNgayLap.OptionsColumn.ReadOnly = true;
      this.gcNgayLap.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Count, "NgayPhieuTron", "{0} - phiếu")
      });
      this.gcNgayLap.Visible = true;
      this.gcNgayLap.VisibleIndex = 0;
      this.gcKhachHang.Caption = "Khách hàng";
      this.gcKhachHang.FieldName = "TenKhachHang";
      this.gcKhachHang.Name = "gcKhachHang";
      this.gcKhachHang.OptionsColumn.AllowFocus = false;
      this.gcKhachHang.OptionsColumn.ReadOnly = true;
      this.gcKhachHang.Visible = true;
      this.gcKhachHang.VisibleIndex = 1;
      this.gcMAC.Caption = "MAC";
      this.gcMAC.FieldName = "TenMAC";
      this.gcMAC.Name = "gcMAC";
      this.gcMAC.OptionsColumn.AllowFocus = false;
      this.gcMAC.OptionsColumn.ReadOnly = true;
      this.gcMAC.Visible = true;
      this.gcMAC.VisibleIndex = 2;
      this.gcTongKhoiLuong.Caption = "Tổng khối lượng";
      this.gcTongKhoiLuong.FieldName = "TongKhoiLuong";
      this.gcTongKhoiLuong.Name = "gcTongKhoiLuong";
      this.gcTongKhoiLuong.OptionsColumn.AllowFocus = false;
      this.gcTongKhoiLuong.OptionsColumn.ReadOnly = true;
      this.gcTongKhoiLuong.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "TongKhoiLuong", "{0:0.##}")
      });
      this.gcTongKhoiLuong.Visible = true;
      this.gcTongKhoiLuong.VisibleIndex = 3;
      this.gcMeTron.Caption = "Mẻ trộn";
      this.gcMeTron.FieldName = "TongMeTron";
      this.gcMeTron.Name = "gcMeTron";
      this.gcMeTron.OptionsColumn.AllowFocus = false;
      this.gcMeTron.OptionsColumn.ReadOnly = true;
      this.gcMeTron.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "TongMeTron", "{0:0.##}")
      });
      this.gcMeTron.Visible = true;
      this.gcMeTron.VisibleIndex = 4;
      this.groupControl1.Controls.Add((Control) this.groupBox1);
      this.groupControl1.Controls.Add((Control) this.groupBox2);
      this.groupControl1.Dock = DockStyle.Right;
      this.groupControl1.Location = new Point(634, 2);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(280, 513);
      this.groupControl1.TabIndex = 2;
      this.groupControl1.Text = "Tác vụ";
      this.groupBox1.Controls.Add((Control) this.lueCheDo);
      this.groupBox1.Controls.Add((Control) this.labelControl11);
      this.groupBox1.Controls.Add((Control) this.lueMAC);
      this.groupBox1.Controls.Add((Control) this.labelControl9);
      this.groupBox1.Controls.Add((Control) this.txtMaPhieuTron);
      this.groupBox1.Controls.Add((Control) this.lueKhachHang);
      this.groupBox1.Controls.Add((Control) this.labelControl5);
      this.groupBox1.Controls.Add((Control) this.lueCongTruong);
      this.groupBox1.Controls.Add((Control) this.labelControl1);
      this.groupBox1.Controls.Add((Control) this.labelControl2);
      this.groupBox1.Controls.Add((Control) this.datToDate);
      this.groupBox1.Controls.Add((Control) this.datFromDate);
      this.groupBox1.Controls.Add((Control) this.labelControl8);
      this.groupBox1.Controls.Add((Control) this.lblFromDate);
      this.groupBox1.Controls.Add((Control) this.simpleButton1);
      this.groupBox1.Controls.Add((Control) this.btnTimKiem);
      this.groupBox1.Dock = DockStyle.Fill;
      this.groupBox1.Location = new Point(2, 23);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(276, 342);
      this.groupBox1.TabIndex = 88;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Bộ lọc";
      this.lueCheDo.Location = new Point(112, 210);
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
      this.lueCheDo.TabIndex = 86;
      this.labelControl11.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl11.Appearance.Options.UseFont = true;
      this.labelControl11.Location = new Point(15, 213);
      this.labelControl11.Name = "labelControl11";
      this.labelControl11.Size = new Size(40, 16);
      this.labelControl11.TabIndex = 85;
      this.labelControl11.Text = "Chế độ";
      this.lueMAC.Location = new Point(112, 180);
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
      this.lueMAC.TabIndex = 84;
      this.labelControl9.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Location = new Point(15, 183);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new Size(52, 16);
      this.labelControl9.TabIndex = 83;
      this.labelControl9.Text = "Tên MAC";
      this.txtMaPhieuTron.Location = new Point(112, 90);
      this.txtMaPhieuTron.Name = "txtMaPhieuTron";
      this.txtMaPhieuTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.txtMaPhieuTron.Size = new Size(150, 22);
      this.txtMaPhieuTron.TabIndex = 82;
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
      this.lueKhachHang.TabIndex = 81;
      this.labelControl5.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new Point(15, 123);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(66, 16);
      this.labelControl5.TabIndex = 80;
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
      this.lueCongTruong.TabIndex = 79;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(15, 153);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(71, 16);
      this.labelControl1.TabIndex = 78;
      this.labelControl1.Text = "Công trường";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(15, 93);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(79, 16);
      this.labelControl2.TabIndex = 77;
      this.labelControl2.Text = "Mã phiếu trộn";
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
      this.datToDate.TabIndex = 76;
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
      this.datFromDate.TabIndex = 75;
      this.labelControl8.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl8.Appearance.Options.UseFont = true;
      this.labelControl8.Location = new Point(15, 63);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new Size(54, 16);
      this.labelControl8.TabIndex = 74;
      this.labelControl8.Text = "Đến ngày";
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(15, 33);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(69, 16);
      this.lblFromDate.TabIndex = 73;
      this.lblFromDate.Text = "Tạo từ ngày";
      this.simpleButton1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.Location = new Point(15, 260);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(108, 32);
      this.simpleButton1.TabIndex = 9;
      this.simpleButton1.Text = "Làm mới";
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.btnTimKiem.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnTimKiem.Appearance.Options.UseFont = true;
      this.btnTimKiem.Location = new Point(154, 260);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new Size(108, 32);
      this.btnTimKiem.TabIndex = 8;
      this.btnTimKiem.Text = "Tìm";
      this.btnTimKiem.Click += new EventHandler(this.btnTimKiem_Click);
      this.groupBox2.Controls.Add((Control) this.btnExportExcel);
      this.groupBox2.Dock = DockStyle.Bottom;
      this.groupBox2.Location = new Point(2, 365);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(276, 146);
      this.groupBox2.TabIndex = 87;
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
      this.panelControl1.Controls.Add((Control) this.labelControl4);
      this.panelControl1.Dock = DockStyle.Top;
      this.panelControl1.Location = new Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(916, 50);
      this.panelControl1.TabIndex = 4;
      this.labelControl4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.labelControl4.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl4.Location = new Point(10, 2);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(904, 50);
      this.labelControl4.TabIndex = 0;
      this.labelControl4.Text = "BÁO CÁO TỔNG KHỐI LƯỢNG BÊ TÔNG";
      this.panelControl2.Controls.Add((Control) this.groupControl2);
      this.panelControl2.Controls.Add((Control) this.groupControl1);
      this.panelControl2.Dock = DockStyle.Fill;
      this.panelControl2.Location = new Point(0, 50);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(916, 517);
      this.panelControl2.TabIndex = 5;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.panelControl2);
      this.Controls.Add((Control) this.panelControl1);
      this.Name = nameof (ReportTongKhoiLuong);
      this.Size = new Size(916, 567);
      this.groupControl2.EndInit();
      this.groupControl2.ResumeLayout(false);
      this.grcTongKhoiLuong.EndInit();
      this.grvTongKhoiLuong.EndInit();
      this.groupControl1.EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.lueCheDo.Properties.EndInit();
      this.lueMAC.Properties.EndInit();
      this.txtMaPhieuTron.Properties.EndInit();
      this.lueKhachHang.Properties.EndInit();
      this.lueCongTruong.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.groupBox2.ResumeLayout(false);
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

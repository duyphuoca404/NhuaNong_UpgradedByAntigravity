// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.DataMixMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class DataMixMngView : ControlViewBase, IDataMixMngView, IBase, IPermission
  {
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private DataMixMngDataPresenter _presenter;
    public BindingList<Objvw_DataMix> _blstDataMix = new BindingList<Objvw_DataMix>();
    private IContainer components;
    private GroupBox groupBox4;
    private PanelControl panelControl1;
    private LabelControl labelControl4;
    private GridControl grcDataMix;
    private GridView grvDataMix;
    private GridColumn gcMaPhieuTron;
    private GridColumn gcDate;
    private GridColumn gcTime;
    private GridColumn gcKhachHang;
    private GridColumn gcCongTruong;
    private GridColumn gcTaiXe;
    private GridColumn gcMAC;
    private GridColumn gcKLMe;
    private GridColumn gcAgg1;
    private GridColumn gcAgg2;
    private GridColumn gcAgg3;
    private GridColumn gcAgg4;
    private GridColumn gcAgg5;
    private GridColumn gcAgg6;
    private GridColumn gcCe1;
    private GridColumn gcCe2;
    private GridColumn gcCe3;
    private GridColumn gcCe4;
    private GridColumn gcCe5;
    private GridColumn gcWa1;
    private GridColumn gcWa2;
    private GridColumn gcAdd1;
    private GridColumn gcAdd2;
    private GridColumn gcAdd3;
    private GridColumn gcAdd4;
    private GridColumn gcAdd5;
    private GridColumn gcAdd6;
    private GridView gridView1;
    private GroupControl groupControl1;
    private GroupBox groupBox3;
    private DateEdit datToDate;
    private SimpleButton simpleButton1;
    private DateEdit datFromDate;
    private LabelControl labelControl2;
    private LookUpEdit lookUpEdit5;
    private LabelControl labelControl1;
    private LabelControl labelControl9;
    private LookUpEdit lookUpEdit4;
    private LabelControl labelControl8;
    private LookUpEdit lookUpEdit3;
    private LabelControl labelControl7;
    private LookUpEdit lookUpEdit2;
    private LabelControl labelControl6;
    private LookUpEdit lookUpEdit1;
    private LabelControl labelControl5;
    private TextEdit txtMaPT;
    private LabelControl labelControl3;
    private GroupBox groupBox5;
    private SimpleButton simpleButton2;
    private GroupControl groupControl2;
    private LookUpEdit lookUpEdit6;
    private LabelControl labelControl10;
    private SimpleButton simpleButton3;
    private LookUpEdit lookUpEdit7;
    private LabelControl labelControl11;
    private LookUpEdit lookUpEdit8;
    private LabelControl labelControl12;
    private GridColumn gcAgg1_Bat;
    private GridColumn gcAgg2_Bat;
    private GridColumn gcAgg3_Bat;
    private GridColumn gcAgg4_Bat;
    private GridColumn gcAgg5_Bat;
    private GridColumn gcAgg6_Bat;
    private GridColumn gcCe1_Bat;
    private GridColumn gcCe2_Bat;
    private GridColumn gcCe3_Bat;
    private GridColumn gcCe4_Bat;
    private GridColumn gcCe5_Bat;
    private GridColumn gcWa1_Bat;
    private GridColumn gcWa2_Bat;
    private GridColumn gcAdd1_Bat;
    private GridColumn gcAdd2_Bat;
    private GridColumn gcAdd3_Bat;
    private GridColumn gcAdd4_Bat;
    private GridColumn gcAdd5_Bat;
    private GridColumn gridColumn1;

    public BindingList<Objvw_DataMix> BLstDataMix
    {
      set
      {
        this._blstDataMix = value;
        this.grcDataMix.DataSource = (object) this._ser.ListDataMix();
      }
    }

    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjHangMuc> BLstHangMuc
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjMAC> BLstMAC
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjXe> BLstXe
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjTaiXe> BLstTaiXe
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjNhanVien> BLstNhanVien
    {
      set => throw new NotImplementedException();
    }

    public List<FieldCode> LstDataMixStatus
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjSilo> BLstSilo
    {
      set => throw new NotImplementedException();
    }

    public DataMixMngView()
    {
      this.InitializeComponent();
      this._presenter = new DataMixMngDataPresenter((IDataMixMngView) this);
      this._presenter.ListDataMix();
      this.Caption = "Data Mix";
    }

    protected override void PopulateStaticData()
    {
      this.LoadSearchDefaultValues();
      this.gcMaPhieuTron.Visible = false;
    }

    protected override void PopulateData()
    {
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) null;
      this.datToDate.EditValue = (object) Searching.Build_EndDateTime(DateTime.Now);
      this.txtMaPT.Text = string.Empty;
    }

    private void LoadDataMix()
    {
      this.grcDataMix.DataSource = (object) this._ser.ListDataMix_ByCondition(new DateTime?(Searching.Build_StartDateTime(this.datFromDate.DateTime)), new DateTime?(Searching.Build_StartDateTime(this.datToDate.DateTime)), this.txtMaPT.Text, "Nam Dai Phat", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
    }

    private void simpleButton1_Click_1(object sender, EventArgs e) => this.LoadDataMix();

    private void simpleButton3_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (DataMixMngView));
      this.groupBox4 = new GroupBox();
      this.panelControl1 = new PanelControl();
      this.labelControl4 = new LabelControl();
      this.grcDataMix = new GridControl();
      this.grvDataMix = new GridView();
      this.gcMaPhieuTron = new GridColumn();
      this.gcDate = new GridColumn();
      this.gridColumn1 = new GridColumn();
      this.gcTime = new GridColumn();
      this.gcKhachHang = new GridColumn();
      this.gcCongTruong = new GridColumn();
      this.gcTaiXe = new GridColumn();
      this.gcMAC = new GridColumn();
      this.gcKLMe = new GridColumn();
      this.gcAgg1 = new GridColumn();
      this.gcAgg1_Bat = new GridColumn();
      this.gcAgg2 = new GridColumn();
      this.gcAgg2_Bat = new GridColumn();
      this.gcAgg3 = new GridColumn();
      this.gcAgg3_Bat = new GridColumn();
      this.gcAgg4 = new GridColumn();
      this.gcAgg4_Bat = new GridColumn();
      this.gcAgg5 = new GridColumn();
      this.gcAgg5_Bat = new GridColumn();
      this.gcAgg6 = new GridColumn();
      this.gcAgg6_Bat = new GridColumn();
      this.gcCe1 = new GridColumn();
      this.gcCe1_Bat = new GridColumn();
      this.gcCe2 = new GridColumn();
      this.gcCe2_Bat = new GridColumn();
      this.gcCe3 = new GridColumn();
      this.gcCe3_Bat = new GridColumn();
      this.gcCe4 = new GridColumn();
      this.gcCe4_Bat = new GridColumn();
      this.gcCe5 = new GridColumn();
      this.gcCe5_Bat = new GridColumn();
      this.gcWa1 = new GridColumn();
      this.gcWa1_Bat = new GridColumn();
      this.gcWa2 = new GridColumn();
      this.gcWa2_Bat = new GridColumn();
      this.gcAdd1 = new GridColumn();
      this.gcAdd1_Bat = new GridColumn();
      this.gcAdd2 = new GridColumn();
      this.gcAdd2_Bat = new GridColumn();
      this.gcAdd3 = new GridColumn();
      this.gcAdd3_Bat = new GridColumn();
      this.gcAdd4 = new GridColumn();
      this.gcAdd4_Bat = new GridColumn();
      this.gcAdd5 = new GridColumn();
      this.gcAdd5_Bat = new GridColumn();
      this.gcAdd6 = new GridColumn();
      this.gridView1 = new GridView();
      this.groupControl1 = new GroupControl();
      this.groupBox3 = new GroupBox();
      this.lookUpEdit8 = new LookUpEdit();
      this.labelControl12 = new LabelControl();
      this.simpleButton3 = new SimpleButton();
      this.lookUpEdit7 = new LookUpEdit();
      this.labelControl11 = new LabelControl();
      this.lookUpEdit6 = new LookUpEdit();
      this.labelControl10 = new LabelControl();
      this.datToDate = new DateEdit();
      this.simpleButton1 = new SimpleButton();
      this.datFromDate = new DateEdit();
      this.labelControl2 = new LabelControl();
      this.lookUpEdit5 = new LookUpEdit();
      this.labelControl1 = new LabelControl();
      this.labelControl9 = new LabelControl();
      this.lookUpEdit4 = new LookUpEdit();
      this.labelControl8 = new LabelControl();
      this.lookUpEdit3 = new LookUpEdit();
      this.labelControl7 = new LabelControl();
      this.lookUpEdit2 = new LookUpEdit();
      this.labelControl6 = new LabelControl();
      this.lookUpEdit1 = new LookUpEdit();
      this.labelControl5 = new LabelControl();
      this.txtMaPT = new TextEdit();
      this.labelControl3 = new LabelControl();
      this.groupBox5 = new GroupBox();
      this.simpleButton2 = new SimpleButton();
      this.groupControl2 = new GroupControl();
      this.groupBox4.SuspendLayout();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.grcDataMix.BeginInit();
      this.grvDataMix.BeginInit();
      this.gridView1.BeginInit();
      this.groupControl1.BeginInit();
      this.groupControl1.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.lookUpEdit8.Properties.BeginInit();
      this.lookUpEdit7.Properties.BeginInit();
      this.lookUpEdit6.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.lookUpEdit5.Properties.BeginInit();
      this.lookUpEdit4.Properties.BeginInit();
      this.lookUpEdit3.Properties.BeginInit();
      this.lookUpEdit2.Properties.BeginInit();
      this.lookUpEdit1.Properties.BeginInit();
      this.txtMaPT.Properties.BeginInit();
      this.groupBox5.SuspendLayout();
      this.groupControl2.BeginInit();
      this.groupControl2.SuspendLayout();
      this.SuspendLayout();
      this.groupBox4.Controls.Add((Control) this.panelControl1);
      this.groupBox4.Dock = DockStyle.Top;
      this.groupBox4.Location = new Point(0, 0);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new Size(1181, 79);
      this.groupBox4.TabIndex = 2;
      this.groupBox4.TabStop = false;
      this.panelControl1.BorderStyle = BorderStyles.NoBorder;
      this.panelControl1.Controls.Add((Control) this.labelControl4);
      this.panelControl1.Dock = DockStyle.Top;
      this.panelControl1.Location = new Point(3, 16);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(1175, 56);
      this.panelControl1.TabIndex = 2;
      this.labelControl4.Appearance.Font = new Font("Tahoma", 26.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Appearance.Options.UseTextOptions = true;
      this.labelControl4.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
      this.labelControl4.Appearance.TextOptions.VAlignment = VertAlignment.Center;
      this.labelControl4.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl4.Dock = DockStyle.Fill;
      this.labelControl4.Location = new Point(0, 0);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(1175, 56);
      this.labelControl4.TabIndex = 0;
      this.labelControl4.Text = "BÁO CÁO CHI TIẾT MẺ TRỘN";
      this.grcDataMix.Dock = DockStyle.Fill;
      this.grcDataMix.Location = new Point(2, 23);
      this.grcDataMix.MainView = (BaseView) this.grvDataMix;
      this.grcDataMix.Name = "grcDataMix";
      this.grcDataMix.Size = new Size(933, 571);
      this.grcDataMix.TabIndex = 0;
      this.grcDataMix.ViewCollection.AddRange(new BaseView[2]
      {
        (BaseView) this.grvDataMix,
        (BaseView) this.gridView1
      });
      this.grvDataMix.Columns.AddRange(new GridColumn[46]
      {
        this.gcMaPhieuTron,
        this.gcDate,
        this.gridColumn1,
        this.gcTime,
        this.gcKhachHang,
        this.gcCongTruong,
        this.gcTaiXe,
        this.gcMAC,
        this.gcKLMe,
        this.gcAgg1,
        this.gcAgg1_Bat,
        this.gcAgg2,
        this.gcAgg2_Bat,
        this.gcAgg3,
        this.gcAgg3_Bat,
        this.gcAgg4,
        this.gcAgg4_Bat,
        this.gcAgg5,
        this.gcAgg5_Bat,
        this.gcAgg6,
        this.gcAgg6_Bat,
        this.gcCe1,
        this.gcCe1_Bat,
        this.gcCe2,
        this.gcCe2_Bat,
        this.gcCe3,
        this.gcCe3_Bat,
        this.gcCe4,
        this.gcCe4_Bat,
        this.gcCe5,
        this.gcCe5_Bat,
        this.gcWa1,
        this.gcWa1_Bat,
        this.gcWa2,
        this.gcWa2_Bat,
        this.gcAdd1,
        this.gcAdd1_Bat,
        this.gcAdd2,
        this.gcAdd2_Bat,
        this.gcAdd3,
        this.gcAdd3_Bat,
        this.gcAdd4,
        this.gcAdd4_Bat,
        this.gcAdd5,
        this.gcAdd5_Bat,
        this.gcAdd6
      });
      this.grvDataMix.GridControl = this.grcDataMix;
      this.grvDataMix.Name = "grvDataMix";
      this.grvDataMix.OptionsView.ShowFooter = true;
      this.gcMaPhieuTron.Caption = "Mã Phiếu trộn";
      this.gcMaPhieuTron.FieldName = "MaPhieuTron";
      this.gcMaPhieuTron.MinWidth = 75;
      this.gcMaPhieuTron.Name = "gcMaPhieuTron";
      this.gcMaPhieuTron.OptionsColumn.AllowEdit = false;
      this.gcMaPhieuTron.OptionsColumn.ReadOnly = true;
      this.gcMaPhieuTron.Visible = true;
      this.gcMaPhieuTron.VisibleIndex = 0;
      this.gcDate.Caption = "Ngày trộn";
      this.gcDate.FieldName = "Ngay";
      this.gcDate.MinWidth = 75;
      this.gcDate.Name = "gcDate";
      this.gcDate.OptionsColumn.AllowEdit = false;
      this.gcDate.OptionsColumn.ReadOnly = true;
      this.gcDate.Visible = true;
      this.gcDate.VisibleIndex = 1;
      this.gridColumn1.Caption = "Is Manual";
      this.gridColumn1.FieldName = "IsManual";
      this.gridColumn1.MinWidth = 50;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Visible = true;
      this.gridColumn1.VisibleIndex = 2;
      this.gcTime.Caption = "Giờ";
      this.gcTime.FieldName = "Gio";
      this.gcTime.MinWidth = 75;
      this.gcTime.Name = "gcTime";
      this.gcTime.OptionsColumn.AllowEdit = false;
      this.gcTime.OptionsColumn.ReadOnly = true;
      this.gcTime.Visible = true;
      this.gcTime.VisibleIndex = 3;
      this.gcKhachHang.Caption = "Khách hàng";
      this.gcKhachHang.FieldName = "KH";
      this.gcKhachHang.MinWidth = 100;
      this.gcKhachHang.Name = "gcKhachHang";
      this.gcKhachHang.OptionsColumn.AllowEdit = false;
      this.gcKhachHang.OptionsColumn.ReadOnly = true;
      this.gcKhachHang.Visible = true;
      this.gcKhachHang.VisibleIndex = 4;
      this.gcKhachHang.Width = 100;
      this.gcCongTruong.Caption = "Công trường";
      this.gcCongTruong.FieldName = "CT";
      this.gcCongTruong.MinWidth = 100;
      this.gcCongTruong.Name = "gcCongTruong";
      this.gcCongTruong.OptionsColumn.AllowEdit = false;
      this.gcCongTruong.OptionsColumn.ReadOnly = true;
      this.gcCongTruong.Visible = true;
      this.gcCongTruong.VisibleIndex = 5;
      this.gcCongTruong.Width = 100;
      this.gcTaiXe.Caption = "Tài xế";
      this.gcTaiXe.FieldName = "Name";
      this.gcTaiXe.MinWidth = 75;
      this.gcTaiXe.Name = "gcTaiXe";
      this.gcTaiXe.OptionsColumn.AllowEdit = false;
      this.gcTaiXe.OptionsColumn.ReadOnly = true;
      this.gcTaiXe.Visible = true;
      this.gcTaiXe.VisibleIndex = 44;
      this.gcMAC.Caption = "MAC";
      this.gcMAC.FieldName = "NoteMAC";
      this.gcMAC.MinWidth = 75;
      this.gcMAC.Name = "gcMAC";
      this.gcMAC.OptionsColumn.AllowEdit = false;
      this.gcMAC.OptionsColumn.ReadOnly = true;
      this.gcMAC.Visible = true;
      this.gcMAC.VisibleIndex = 6;
      this.gcKLMe.Caption = "KL Mẻ";
      this.gcKLMe.FieldName = "KLMe";
      this.gcKLMe.MinWidth = 75;
      this.gcKLMe.Name = "gcKLMe";
      this.gcKLMe.OptionsColumn.AllowEdit = false;
      this.gcKLMe.OptionsColumn.ReadOnly = true;
      this.gcKLMe.Visible = true;
      this.gcKLMe.VisibleIndex = 7;
      this.gcAgg1.Caption = "Agg 1";
      this.gcAgg1.FieldName = "Agg1";
      this.gcAgg1.MinWidth = 75;
      this.gcAgg1.Name = "gcAgg1";
      this.gcAgg1.OptionsColumn.AllowEdit = false;
      this.gcAgg1.OptionsColumn.ReadOnly = true;
      this.gcAgg1.Visible = true;
      this.gcAgg1.VisibleIndex = 8;
      this.gcAgg1_Bat.Caption = "T_Agg1";
      this.gcAgg1_Bat.FieldName = "Agg1_Bat";
      this.gcAgg1_Bat.MinWidth = 75;
      this.gcAgg1_Bat.Name = "gcAgg1_Bat";
      this.gcAgg1_Bat.Visible = true;
      this.gcAgg1_Bat.VisibleIndex = 9;
      this.gcAgg2.Caption = "Agg 2";
      this.gcAgg2.FieldName = "Agg2";
      this.gcAgg2.MinWidth = 75;
      this.gcAgg2.Name = "gcAgg2";
      this.gcAgg2.OptionsColumn.AllowEdit = false;
      this.gcAgg2.OptionsColumn.ReadOnly = true;
      this.gcAgg2.Visible = true;
      this.gcAgg2.VisibleIndex = 10;
      this.gcAgg2_Bat.Caption = "T_Agg2";
      this.gcAgg2_Bat.FieldName = "Agg2_Bat";
      this.gcAgg2_Bat.MinWidth = 75;
      this.gcAgg2_Bat.Name = "gcAgg2_Bat";
      this.gcAgg2_Bat.Visible = true;
      this.gcAgg2_Bat.VisibleIndex = 11;
      this.gcAgg3.Caption = "Agg 3";
      this.gcAgg3.FieldName = "Agg3";
      this.gcAgg3.MinWidth = 75;
      this.gcAgg3.Name = "gcAgg3";
      this.gcAgg3.OptionsColumn.AllowEdit = false;
      this.gcAgg3.OptionsColumn.ReadOnly = true;
      this.gcAgg3.Visible = true;
      this.gcAgg3.VisibleIndex = 12;
      this.gcAgg3_Bat.Caption = "T_Agg3";
      this.gcAgg3_Bat.FieldName = "Agg3_Bat";
      this.gcAgg3_Bat.MinWidth = 75;
      this.gcAgg3_Bat.Name = "gcAgg3_Bat";
      this.gcAgg3_Bat.Visible = true;
      this.gcAgg3_Bat.VisibleIndex = 13;
      this.gcAgg4.Caption = "Agg 4";
      this.gcAgg4.FieldName = "Agg4";
      this.gcAgg4.MinWidth = 75;
      this.gcAgg4.Name = "gcAgg4";
      this.gcAgg4.OptionsColumn.AllowEdit = false;
      this.gcAgg4.OptionsColumn.ReadOnly = true;
      this.gcAgg4.Visible = true;
      this.gcAgg4.VisibleIndex = 14;
      this.gcAgg4_Bat.Caption = "T_Agg4";
      this.gcAgg4_Bat.FieldName = "Agg4_Bat";
      this.gcAgg4_Bat.MinWidth = 75;
      this.gcAgg4_Bat.Name = "gcAgg4_Bat";
      this.gcAgg4_Bat.Visible = true;
      this.gcAgg4_Bat.VisibleIndex = 15;
      this.gcAgg5.Caption = "Agg 5";
      this.gcAgg5.FieldName = "Agg5";
      this.gcAgg5.MinWidth = 75;
      this.gcAgg5.Name = "gcAgg5";
      this.gcAgg5.OptionsColumn.AllowEdit = false;
      this.gcAgg5.OptionsColumn.ReadOnly = true;
      this.gcAgg5.Visible = true;
      this.gcAgg5.VisibleIndex = 16;
      this.gcAgg5_Bat.Caption = "T_Agg5";
      this.gcAgg5_Bat.FieldName = "Agg5_Bat";
      this.gcAgg5_Bat.MinWidth = 75;
      this.gcAgg5_Bat.Name = "gcAgg5_Bat";
      this.gcAgg5_Bat.Visible = true;
      this.gcAgg5_Bat.VisibleIndex = 17;
      this.gcAgg6.Caption = "Agg 6";
      this.gcAgg6.FieldName = "Agg6";
      this.gcAgg6.MinWidth = 75;
      this.gcAgg6.Name = "gcAgg6";
      this.gcAgg6.OptionsColumn.AllowEdit = false;
      this.gcAgg6.OptionsColumn.ReadOnly = true;
      this.gcAgg6.Visible = true;
      this.gcAgg6.VisibleIndex = 18;
      this.gcAgg6_Bat.Caption = "T_Agg6";
      this.gcAgg6_Bat.FieldName = "Agg6_Bat";
      this.gcAgg6_Bat.MinWidth = 75;
      this.gcAgg6_Bat.Name = "gcAgg6_Bat";
      this.gcAgg6_Bat.Visible = true;
      this.gcAgg6_Bat.VisibleIndex = 19;
      this.gcCe1.Caption = "Ce 1";
      this.gcCe1.FieldName = "Ce1";
      this.gcCe1.MinWidth = 75;
      this.gcCe1.Name = "gcCe1";
      this.gcCe1.OptionsColumn.AllowEdit = false;
      this.gcCe1.OptionsColumn.ReadOnly = true;
      this.gcCe1.Visible = true;
      this.gcCe1.VisibleIndex = 20;
      this.gcCe1_Bat.Caption = "T_Ce1";
      this.gcCe1_Bat.FieldName = "Ce1_Bat";
      this.gcCe1_Bat.MinWidth = 75;
      this.gcCe1_Bat.Name = "gcCe1_Bat";
      this.gcCe1_Bat.Visible = true;
      this.gcCe1_Bat.VisibleIndex = 21;
      this.gcCe2.Caption = "Ce 2";
      this.gcCe2.FieldName = "Ce2";
      this.gcCe2.MinWidth = 75;
      this.gcCe2.Name = "gcCe2";
      this.gcCe2.OptionsColumn.AllowEdit = false;
      this.gcCe2.OptionsColumn.ReadOnly = true;
      this.gcCe2.Visible = true;
      this.gcCe2.VisibleIndex = 22;
      this.gcCe2_Bat.Caption = "T_Ce2";
      this.gcCe2_Bat.FieldName = "Ce2_Bat";
      this.gcCe2_Bat.MinWidth = 75;
      this.gcCe2_Bat.Name = "gcCe2_Bat";
      this.gcCe2_Bat.Visible = true;
      this.gcCe2_Bat.VisibleIndex = 23;
      this.gcCe3.Caption = "Ce 3";
      this.gcCe3.FieldName = "Ce3";
      this.gcCe3.MinWidth = 75;
      this.gcCe3.Name = "gcCe3";
      this.gcCe3.OptionsColumn.AllowEdit = false;
      this.gcCe3.OptionsColumn.ReadOnly = true;
      this.gcCe3.Visible = true;
      this.gcCe3.VisibleIndex = 24;
      this.gcCe3_Bat.Caption = "T_Ce3";
      this.gcCe3_Bat.FieldName = "Ce3_Bat";
      this.gcCe3_Bat.MinWidth = 75;
      this.gcCe3_Bat.Name = "gcCe3_Bat";
      this.gcCe3_Bat.Visible = true;
      this.gcCe3_Bat.VisibleIndex = 25;
      this.gcCe4.Caption = "Ce 4";
      this.gcCe4.FieldName = "Ce4";
      this.gcCe4.MinWidth = 75;
      this.gcCe4.Name = "gcCe4";
      this.gcCe4.OptionsColumn.AllowEdit = false;
      this.gcCe4.OptionsColumn.ReadOnly = true;
      this.gcCe4.Visible = true;
      this.gcCe4.VisibleIndex = 26;
      this.gcCe4_Bat.Caption = "T_Ce4";
      this.gcCe4_Bat.FieldName = "Ce4_Bat";
      this.gcCe4_Bat.MinWidth = 75;
      this.gcCe4_Bat.Name = "gcCe4_Bat";
      this.gcCe4_Bat.Visible = true;
      this.gcCe4_Bat.VisibleIndex = 27;
      this.gcCe5.Caption = "Ce 5";
      this.gcCe5.FieldName = "Ce5";
      this.gcCe5.MinWidth = 75;
      this.gcCe5.Name = "gcCe5";
      this.gcCe5.OptionsColumn.AllowEdit = false;
      this.gcCe5.OptionsColumn.ReadOnly = true;
      this.gcCe5.Visible = true;
      this.gcCe5.VisibleIndex = 28;
      this.gcCe5_Bat.Caption = "T_Ce5";
      this.gcCe5_Bat.FieldName = "Ce5_Bat";
      this.gcCe5_Bat.MinWidth = 75;
      this.gcCe5_Bat.Name = "gcCe5_Bat";
      this.gcCe5_Bat.Visible = true;
      this.gcCe5_Bat.VisibleIndex = 29;
      this.gcWa1.Caption = "Wa 1";
      this.gcWa1.FieldName = "Wa1";
      this.gcWa1.MinWidth = 75;
      this.gcWa1.Name = "gcWa1";
      this.gcWa1.OptionsColumn.AllowEdit = false;
      this.gcWa1.OptionsColumn.ReadOnly = true;
      this.gcWa1.Visible = true;
      this.gcWa1.VisibleIndex = 30;
      this.gcWa1_Bat.Caption = "T_Wa1";
      this.gcWa1_Bat.FieldName = "Wa1_Bat";
      this.gcWa1_Bat.MinWidth = 75;
      this.gcWa1_Bat.Name = "gcWa1_Bat";
      this.gcWa1_Bat.Visible = true;
      this.gcWa1_Bat.VisibleIndex = 31;
      this.gcWa2.Caption = "Wa 2";
      this.gcWa2.FieldName = "Wa2";
      this.gcWa2.MinWidth = 75;
      this.gcWa2.Name = "gcWa2";
      this.gcWa2.OptionsColumn.AllowEdit = false;
      this.gcWa2.OptionsColumn.ReadOnly = true;
      this.gcWa2.Visible = true;
      this.gcWa2.VisibleIndex = 32;
      this.gcWa2_Bat.Caption = "T_Wa2";
      this.gcWa2_Bat.FieldName = "Wa2_Bat";
      this.gcWa2_Bat.MinWidth = 75;
      this.gcWa2_Bat.Name = "gcWa2_Bat";
      this.gcWa2_Bat.Visible = true;
      this.gcWa2_Bat.VisibleIndex = 33;
      this.gcAdd1.Caption = "Add 1";
      this.gcAdd1.FieldName = "Add1";
      this.gcAdd1.MinWidth = 75;
      this.gcAdd1.Name = "gcAdd1";
      this.gcAdd1.OptionsColumn.AllowEdit = false;
      this.gcAdd1.OptionsColumn.ReadOnly = true;
      this.gcAdd1.Visible = true;
      this.gcAdd1.VisibleIndex = 34;
      this.gcAdd1_Bat.Caption = "T_Add1";
      this.gcAdd1_Bat.FieldName = "Add1_Bat";
      this.gcAdd1_Bat.MinWidth = 75;
      this.gcAdd1_Bat.Name = "gcAdd1_Bat";
      this.gcAdd1_Bat.Visible = true;
      this.gcAdd1_Bat.VisibleIndex = 35;
      this.gcAdd2.Caption = "Add 2";
      this.gcAdd2.FieldName = "Add2";
      this.gcAdd2.MinWidth = 75;
      this.gcAdd2.Name = "gcAdd2";
      this.gcAdd2.OptionsColumn.AllowEdit = false;
      this.gcAdd2.OptionsColumn.ReadOnly = true;
      this.gcAdd2.Visible = true;
      this.gcAdd2.VisibleIndex = 36;
      this.gcAdd2_Bat.Caption = "T_Add2";
      this.gcAdd2_Bat.FieldName = "Add2_Bat";
      this.gcAdd2_Bat.MinWidth = 75;
      this.gcAdd2_Bat.Name = "gcAdd2_Bat";
      this.gcAdd2_Bat.Visible = true;
      this.gcAdd2_Bat.VisibleIndex = 37;
      this.gcAdd3.Caption = "Add 3";
      this.gcAdd3.FieldName = "Add3";
      this.gcAdd3.MinWidth = 75;
      this.gcAdd3.Name = "gcAdd3";
      this.gcAdd3.OptionsColumn.AllowEdit = false;
      this.gcAdd3.OptionsColumn.ReadOnly = true;
      this.gcAdd3.Visible = true;
      this.gcAdd3.VisibleIndex = 38;
      this.gcAdd3_Bat.Caption = "T_Add3";
      this.gcAdd3_Bat.FieldName = "Add3_Bat";
      this.gcAdd3_Bat.MinWidth = 75;
      this.gcAdd3_Bat.Name = "gcAdd3_Bat";
      this.gcAdd3_Bat.Visible = true;
      this.gcAdd3_Bat.VisibleIndex = 39;
      this.gcAdd4.Caption = "Add 4";
      this.gcAdd4.FieldName = "Add4";
      this.gcAdd4.MinWidth = 75;
      this.gcAdd4.Name = "gcAdd4";
      this.gcAdd4.OptionsColumn.AllowEdit = false;
      this.gcAdd4.OptionsColumn.ReadOnly = true;
      this.gcAdd4.Visible = true;
      this.gcAdd4.VisibleIndex = 40;
      this.gcAdd4_Bat.Caption = "T_Add4";
      this.gcAdd4_Bat.FieldName = "Add4_Bat";
      this.gcAdd4_Bat.MinWidth = 75;
      this.gcAdd4_Bat.Name = "gcAdd4_Bat";
      this.gcAdd4_Bat.Visible = true;
      this.gcAdd4_Bat.VisibleIndex = 41;
      this.gcAdd5.Caption = "Add 5";
      this.gcAdd5.FieldName = "Add5";
      this.gcAdd5.MinWidth = 75;
      this.gcAdd5.Name = "gcAdd5";
      this.gcAdd5.OptionsColumn.AllowEdit = false;
      this.gcAdd5.OptionsColumn.ReadOnly = true;
      this.gcAdd5.Visible = true;
      this.gcAdd5.VisibleIndex = 42;
      this.gcAdd5_Bat.Caption = "T_Add5";
      this.gcAdd5_Bat.FieldName = "Add5_Bat";
      this.gcAdd5_Bat.MinWidth = 75;
      this.gcAdd5_Bat.Name = "gcAdd5_Bat";
      this.gcAdd5_Bat.Visible = true;
      this.gcAdd5_Bat.VisibleIndex = 43;
      this.gcAdd6.Caption = "Add 6";
      this.gcAdd6.FieldName = "Add5";
      this.gcAdd6.MinWidth = 75;
      this.gcAdd6.Name = "gcAdd6";
      this.gcAdd6.OptionsColumn.AllowEdit = false;
      this.gcAdd6.OptionsColumn.ReadOnly = true;
      this.gcAdd6.Visible = true;
      this.gcAdd6.VisibleIndex = 45;
      this.gridView1.GridControl = this.grcDataMix;
      this.gridView1.Name = "gridView1";
      this.groupControl1.Controls.Add((Control) this.grcDataMix);
      this.groupControl1.Dock = DockStyle.Right;
      this.groupControl1.Location = new Point(244, 79);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(937, 596);
      this.groupControl1.TabIndex = 4;
      this.groupControl1.Text = "Dữ liệu";
      this.groupBox3.Controls.Add((Control) this.lookUpEdit8);
      this.groupBox3.Controls.Add((Control) this.labelControl12);
      this.groupBox3.Controls.Add((Control) this.simpleButton3);
      this.groupBox3.Controls.Add((Control) this.lookUpEdit7);
      this.groupBox3.Controls.Add((Control) this.labelControl11);
      this.groupBox3.Controls.Add((Control) this.lookUpEdit6);
      this.groupBox3.Controls.Add((Control) this.labelControl10);
      this.groupBox3.Controls.Add((Control) this.datToDate);
      this.groupBox3.Controls.Add((Control) this.simpleButton1);
      this.groupBox3.Controls.Add((Control) this.datFromDate);
      this.groupBox3.Controls.Add((Control) this.labelControl2);
      this.groupBox3.Controls.Add((Control) this.lookUpEdit5);
      this.groupBox3.Controls.Add((Control) this.labelControl1);
      this.groupBox3.Controls.Add((Control) this.labelControl9);
      this.groupBox3.Controls.Add((Control) this.lookUpEdit4);
      this.groupBox3.Controls.Add((Control) this.labelControl8);
      this.groupBox3.Controls.Add((Control) this.lookUpEdit3);
      this.groupBox3.Controls.Add((Control) this.labelControl7);
      this.groupBox3.Controls.Add((Control) this.lookUpEdit2);
      this.groupBox3.Controls.Add((Control) this.labelControl6);
      this.groupBox3.Controls.Add((Control) this.lookUpEdit1);
      this.groupBox3.Controls.Add((Control) this.labelControl5);
      this.groupBox3.Controls.Add((Control) this.txtMaPT);
      this.groupBox3.Controls.Add((Control) this.labelControl3);
      this.groupBox3.Location = new Point(5, 30);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new Size(229, 383);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Bộ lọc";
      this.lookUpEdit8.Location = new Point(102, 158);
      this.lookUpEdit8.Name = "lookUpEdit8";
      this.lookUpEdit8.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit8.Properties.NullText = "";
      this.lookUpEdit8.Size = new Size(115, 20);
      this.lookUpEdit8.TabIndex = 19;
      this.labelControl12.Location = new Point(36, 161);
      this.labelControl12.Name = "labelControl12";
      this.labelControl12.Size = new Size(47, 13);
      this.labelControl12.TabIndex = 18;
      this.labelControl12.Text = "Hạng mục";
      this.simpleButton3.Location = new Point(17, 328);
      this.simpleButton3.Name = "simpleButton3";
      this.simpleButton3.Size = new Size(74, 32);
      this.simpleButton3.TabIndex = 17;
      this.simpleButton3.Text = "Làm mới";
      this.simpleButton3.Click += new EventHandler(this.simpleButton3_Click);
      this.lookUpEdit7.Location = new Point(102, 184);
      this.lookUpEdit7.Name = "lookUpEdit7";
      this.lookUpEdit7.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit7.Properties.NullText = "";
      this.lookUpEdit7.Size = new Size(115, 20);
      this.lookUpEdit7.TabIndex = 16;
      this.labelControl11.Location = new Point(54, 187);
      this.labelControl11.Name = "labelControl11";
      this.labelControl11.Size = new Size(29, 13);
      this.labelControl11.TabIndex = 15;
      this.labelControl11.Text = "Tài xế";
      this.lookUpEdit6.Location = new Point(102, 132);
      this.lookUpEdit6.Name = "lookUpEdit6";
      this.lookUpEdit6.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit6.Properties.NullText = "";
      this.lookUpEdit6.Size = new Size(115, 20);
      this.lookUpEdit6.TabIndex = 14;
      this.labelControl10.Location = new Point(22, 135);
      this.labelControl10.Name = "labelControl10";
      this.labelControl10.Size = new Size(61, 13);
      this.labelControl10.TabIndex = 13;
      this.labelControl10.Text = "Công trường";
      this.datToDate.EditValue = (object) null;
      this.datToDate.Location = new Point(102, 54);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Size = new Size(115, 20);
      this.datToDate.TabIndex = 3;
      this.simpleButton1.Location = new Point(114, 328);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(103, 32);
      this.simpleButton1.TabIndex = 2;
      this.simpleButton1.Text = "Tìm kiếm";
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click_1);
      this.datFromDate.EditValue = (object) null;
      this.datFromDate.Location = new Point(102, 28);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Size = new Size(115, 20);
      this.datFromDate.TabIndex = 2;
      this.labelControl2.Location = new Point(63, 57);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(20, 13);
      this.labelControl2.TabIndex = 1;
      this.labelControl2.Text = "Đến";
      this.lookUpEdit5.Location = new Point(102, 288);
      this.lookUpEdit5.Name = "lookUpEdit5";
      this.lookUpEdit5.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit5.Properties.NullText = "";
      this.lookUpEdit5.Size = new Size(115, 20);
      this.lookUpEdit5.TabIndex = 12;
      this.labelControl1.Location = new Point(70, 31);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(13, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Từ";
      this.labelControl9.Location = new Point(49, 291);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new Size(34, 13);
      this.labelControl9.TabIndex = 11;
      this.labelControl9.Text = "Chế độ";
      this.lookUpEdit4.Location = new Point(102, 262);
      this.lookUpEdit4.Name = "lookUpEdit4";
      this.lookUpEdit4.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit4.Properties.NullText = "";
      this.lookUpEdit4.Size = new Size(115, 20);
      this.lookUpEdit4.TabIndex = 10;
      this.labelControl8.Location = new Point(35, 265);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new Size(48, 13);
      this.labelControl8.TabIndex = 9;
      this.labelControl8.Text = "Nhân viên";
      this.lookUpEdit3.Location = new Point(102, 210);
      this.lookUpEdit3.Name = "lookUpEdit3";
      this.lookUpEdit3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit3.Properties.NullText = "";
      this.lookUpEdit3.Size = new Size(115, 20);
      this.lookUpEdit3.TabIndex = 8;
      this.labelControl7.Location = new Point(49, 213);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new Size(34, 13);
      this.labelControl7.TabIndex = 7;
      this.labelControl7.Text = "Biển số";
      this.lookUpEdit2.Location = new Point(102, 236);
      this.lookUpEdit2.Name = "lookUpEdit2";
      this.lookUpEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit2.Properties.NullText = "";
      this.lookUpEdit2.Size = new Size(115, 20);
      this.lookUpEdit2.TabIndex = 6;
      this.labelControl6.Location = new Point(40, 239);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new Size(43, 13);
      this.labelControl6.TabIndex = 5;
      this.labelControl6.Text = "Tên MAC";
      this.lookUpEdit1.Location = new Point(102, 106);
      this.lookUpEdit1.Name = "lookUpEdit1";
      this.lookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit1.Properties.NullText = "";
      this.lookUpEdit1.Size = new Size(115, 20);
      this.lookUpEdit1.TabIndex = 4;
      this.labelControl5.Location = new Point(27, 109);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(56, 13);
      this.labelControl5.TabIndex = 3;
      this.labelControl5.Text = "Khách hàng";
      this.txtMaPT.Location = new Point(102, 80);
      this.txtMaPT.Name = "txtMaPT";
      this.txtMaPT.Size = new Size(115, 20);
      this.txtMaPT.TabIndex = 2;
      this.labelControl3.Location = new Point(17, 83);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(66, 13);
      this.labelControl3.TabIndex = 1;
      this.labelControl3.Text = "Mã phiếu trộn";
      this.groupBox5.Controls.Add((Control) this.simpleButton2);
      this.groupBox5.Location = new Point(5, 419);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new Size(228, 97);
      this.groupBox5.TabIndex = 4;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Xuất dữ liệu";
      this.groupBox5.Visible = false;
      this.simpleButton2.BackgroundImageLayout = ImageLayout.Center;
      this.simpleButton2.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.simpleButton2.ImageOptions.Image = (Image) componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      this.simpleButton2.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.simpleButton2.Location = new Point(63, 34);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.Size = new Size(86, 46);
      this.simpleButton2.TabIndex = 13;
      this.groupControl2.Controls.Add((Control) this.groupBox5);
      this.groupControl2.Controls.Add((Control) this.groupBox3);
      this.groupControl2.Dock = DockStyle.Left;
      this.groupControl2.Location = new Point(0, 79);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(238, 596);
      this.groupControl2.TabIndex = 5;
      this.groupControl2.Text = "Tìm kiếm";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.groupControl2);
      this.Controls.Add((Control) this.groupControl1);
      this.Controls.Add((Control) this.groupBox4);
      this.Name = nameof (DataMixMngView);
      this.Size = new Size(1181, 675);
      this.groupBox4.ResumeLayout(false);
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.grcDataMix.EndInit();
      this.grvDataMix.EndInit();
      this.gridView1.EndInit();
      this.groupControl1.EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.lookUpEdit8.Properties.EndInit();
      this.lookUpEdit7.Properties.EndInit();
      this.lookUpEdit6.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.lookUpEdit5.Properties.EndInit();
      this.lookUpEdit4.Properties.EndInit();
      this.lookUpEdit3.Properties.EndInit();
      this.lookUpEdit2.Properties.EndInit();
      this.lookUpEdit1.Properties.EndInit();
      this.txtMaPT.Properties.EndInit();
      this.groupBox5.ResumeLayout(false);
      this.groupControl2.EndInit();
      this.groupControl2.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

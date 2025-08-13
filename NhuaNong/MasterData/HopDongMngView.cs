// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.HopDongMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class HopDongMngView : ControlViewBase, IHopDongMngView, IBase, IPermission
  {
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private HopDongMngDataPresenter _presenter;
    private int? _searchStatus = new int?(-1);
    private bool _useAsSearching;
    private BindingList<ObjHopDong> _blstHopDong = new BindingList<ObjHopDong>();
    private BindingList<ObjKhachHang> _blstKhachHang = new BindingList<ObjKhachHang>();
    private BindingList<ObjCongTruong> _blstCongTruong = new BindingList<ObjCongTruong>();
    private BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    private List<FieldCode> _lstHopDongStatus = new List<FieldCode>();
    private IContainer components;
    private BarManager barManager1;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarButtonItem bbiInsert;
    private BarButtonItem bbiUpdate;
    private BarButtonItem bbiDelete;
    private BarButtonItem bbiView;
    private BarCheckItem barCheckItem1;
    private GroupControl grpMaster;
    private GroupControl grpSearch;
    private SimpleButton btnReset;
    private LabelControl lblActive;
    private Label lblMaHopDong;
    private Label lblToDate;
    private SimpleButton btnSearch;
    private LookUpEdit lueHDStatus;
    private TextEdit txtMaHopDong;
    private DateEdit datDenNgay;
    private DateEdit datTuNgay;
    private LabelControl lblFromDate;
    private LookUpEdit lueMAC;
    private LabelControl lblMAC;
    private LookUpEdit lueCongTruong;
    private LabelControl lblCongTruong;
    private LookUpEdit lueKhachHang;
    private LabelControl lblKhachHang;
    private GridControl grcHopDong;
    private GridView grvHopDong;
    private GridColumn gcMaHopDong;
    private GridColumn gcTenHopDong;
    private GridColumn gcNgayHopDong;
    private GridColumn gcKhachHang;
    private GridColumn gcCongTruong;
    private GridColumn gcMAC;
    private GridColumn gcStatus;
    private GridColumn gcKLDatHang;
    private GridColumn gcKLDaGiao;
    private GridColumn gcKLTaoPhieuTron;
    private GridColumn gcMoTa;
    private RepositoryItemLookUpEdit ilueHDStatus;
    private RepositoryItemTextEdit itedKhachHang;
    private RepositoryItemLookUpEdit illueKhachHang;
    private RepositoryItemLookUpEdit ilueCongTruong;
    private RepositoryItemLookUpEdit ilueMAC;
    private BarButtonItem barButtonItem1;
    private Bar barButtons;
    private BarStaticItem bsiCaption;

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public HopDongMngView()
    {
      try
      {
        this.InitializeComponent();
        this._presenter = new HopDongMngDataPresenter((IHopDongMngView) this);
        this.Caption = this.bsiCaption.Caption;
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    public int? SearchStatus
    {
      set
      {
        if (!value.HasValue)
          value = new int?(-1);
        this._searchStatus = value;
        this.lueHDStatus.EditValue = (object) value;
      }
    }

    public bool UseAsSearching
    {
      set
      {
        this._useAsSearching = value;
        this.barButtons.Visible = !this._useAsSearching;
      }
    }

    public BindingList<ObjHopDong> BLstHopDong
    {
      set
      {
        this._blstHopDong = value;
        this.grcHopDong.DataSource = (object) this._blstHopDong;
      }
    }

    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set
      {
        this._blstKhachHang = value;
        this.lueKhachHang.Properties.DataSource = (object) this._blstKhachHang;
        this.illueKhachHang.DataSource = (object) this._blstKhachHang;
      }
    }

    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set
      {
        this._blstCongTruong = value;
        this.lueCongTruong.Properties.DataSource = (object) this._blstCongTruong;
        this.ilueCongTruong.DataSource = (object) this._blstCongTruong;
      }
    }

    public BindingList<ObjMAC> BLstMAC
    {
      set
      {
        this._blstMAC = value;
        this.lueMAC.Properties.DataSource = (object) this._blstMAC;
        this.ilueMAC.DataSource = (object) this._blstMAC;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public List<FieldCode> LstHopDongStatus
    {
      set
      {
        this._lstHopDongStatus = value;
        this.ilueHDStatus.DataSource = (object) this._lstHopDongStatus;
        this.lueHDStatus.Properties.DataSource = (object) this._lstHopDongStatus;
      }
    }

    protected override void PopulateStaticData()
    {
      this._presenter.ListKhachHang();
      this._presenter.ListCongTruong();
      this._presenter.ListMAC();
      this.LoadHDStatus();
      this.LoadSearchDefaultValues();
    }

    protected override void PopulateData() => this.LoadHopDong();

    protected override void AdjustCulture()
    {
    }

    public override List<T> GetSelectedObjects<T>()
    {
      List<T> selectedObjects = new List<T>();
      foreach (int selectedRow in this.grvHopDong.GetSelectedRows())
      {
        T row = (T) this.grvHopDong.GetRow(selectedRow);
        selectedObjects.Add(row);
      }
      return selectedObjects;
    }

    private void LoadHopDong()
    {
      this._presenter.ListHopDong(this.txtMaHopDong.Text, Searching.Build_StartDateTime(this.datTuNgay.DateTime), Searching.Build_EndDateTime(this.datDenNgay.DateTime), (int?) this.lueHDStatus.EditValue, (int?) this.lueKhachHang.EditValue, (int?) this.lueCongTruong.EditValue, (int?) this.lueMAC.EditValue);
    }

    private void LoadSearchDefaultValues()
    {
      this.datTuNgay.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestHopDongDays);
      this.datDenNgay.EditValue = (object) DateTime.Now;
      this.txtMaHopDong.Text = string.Empty;
      this.lueHDStatus.EditValue = (object) this._searchStatus;
      this.lueKhachHang.EditValue = (object) null;
      this.lueCongTruong.EditValue = (object) null;
      this.lueMAC.EditValue = (object) null;
    }

    private void LoadHDStatus() => this._presenter.ListHopDongStatus();

    private void SuccessfullySave(bool isSuccess)
    {
    }

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadHopDong();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewHopDongView ctrView = new NewHopDongView((ObjHopDong) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListHopDong();
      this.FocusRow(this.grvHopDong, this.grvHopDong.RowCount);
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvHopDong.RowCount == 0)
        return;
      int focusedRowHandle = this.grvHopDong.FocusedRowHandle;
      NewHopDongView ctrView = new NewHopDongView(this.grvHopDong.GetRow(focusedRowHandle) as ObjHopDong, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListHopDong();
      this.FocusRow(this.grvHopDong, focusedRowHandle);
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      BindingList<ObjHopDong> blstCT = new BindingList<ObjHopDong>();
      foreach (int selectedRow in this.grvHopDong.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjHopDong row = this.grvHopDong.GetRow(selectedRow) as ObjHopDong;
          row.MarkAsDeleted = true;
          blstCT.Add(row);
        }
      }
      foreach (ObjHopDong objHopDong in (Collection<ObjHopDong>) blstCT)
        this._blstHopDong.Remove(objHopDong);
      this.FocusRow(this.grvHopDong, this.grvHopDong.RowCount);
      this._presenter.SaveHopDong(blstCT);
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvHopDong.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewHopDongView(this.grvHopDong.GetRow(this.grvHopDong.FocusedRowHandle) as ObjHopDong, Enums.FormAction.View));
    }

    private void BindPermission()
    {
      this.bbiInsert.Enabled = this.CheckHasPermission(this.bbiInsert.Name);
      this.bbiUpdate.Enabled = this.CheckHasPermission(this.bbiUpdate.Name);
      this.bbiDelete.Enabled = this.CheckHasPermission(this.bbiDelete.Name);
      this.bbiView.Enabled = this.CheckHasPermission(this.bbiView.Name);
    }

    private bool CheckHasPermission(string funcName)
    {
      foreach (ObjSEC_Function objSecFunction in this._lstFunction)
      {
        if (objSecFunction.MenuName == funcName)
          return true;
      }
      return false;
    }

    private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
    {
      if (this.grvHopDong.RowCount == 0)
        return;
      int focusedRowHandle = this.grvHopDong.FocusedRowHandle;
      NewPhieuTronView ctrView = new NewPhieuTronView(this.grvHopDong.GetRow(focusedRowHandle) as ObjHopDong, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListHopDong();
      this.FocusRow(this.grvHopDong, focusedRowHandle);
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
      this.barManager1 = new BarManager(this.components);
      this.barButtons = new Bar();
      this.bsiCaption = new BarStaticItem();
      this.bbiInsert = new BarButtonItem();
      this.bbiUpdate = new BarButtonItem();
      this.bbiDelete = new BarButtonItem();
      this.bbiView = new BarButtonItem();
      this.barButtonItem1 = new BarButtonItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.barCheckItem1 = new BarCheckItem();
      this.grpSearch = new GroupControl();
      this.lueMAC = new LookUpEdit();
      this.lblMAC = new LabelControl();
      this.lueCongTruong = new LookUpEdit();
      this.lblCongTruong = new LabelControl();
      this.lueKhachHang = new LookUpEdit();
      this.lblKhachHang = new LabelControl();
      this.btnReset = new SimpleButton();
      this.lblActive = new LabelControl();
      this.lblMaHopDong = new Label();
      this.lblToDate = new Label();
      this.btnSearch = new SimpleButton();
      this.lueHDStatus = new LookUpEdit();
      this.txtMaHopDong = new TextEdit();
      this.datDenNgay = new DateEdit();
      this.datTuNgay = new DateEdit();
      this.lblFromDate = new LabelControl();
      this.grpMaster = new GroupControl();
      this.grcHopDong = new GridControl();
      this.grvHopDong = new GridView();
      this.gcMaHopDong = new GridColumn();
      this.gcTenHopDong = new GridColumn();
      this.gcNgayHopDong = new GridColumn();
      this.gcKhachHang = new GridColumn();
      this.illueKhachHang = new RepositoryItemLookUpEdit();
      this.gcCongTruong = new GridColumn();
      this.ilueCongTruong = new RepositoryItemLookUpEdit();
      this.gcMAC = new GridColumn();
      this.ilueMAC = new RepositoryItemLookUpEdit();
      this.gcStatus = new GridColumn();
      this.ilueHDStatus = new RepositoryItemLookUpEdit();
      this.gcKLDatHang = new GridColumn();
      this.gcKLDaGiao = new GridColumn();
      this.gcKLTaoPhieuTron = new GridColumn();
      this.gcMoTa = new GridColumn();
      this.itedKhachHang = new RepositoryItemTextEdit();
      this.barManager1.BeginInit();
      this.grpSearch.BeginInit();
      this.grpSearch.SuspendLayout();
      this.lueMAC.Properties.BeginInit();
      this.lueCongTruong.Properties.BeginInit();
      this.lueKhachHang.Properties.BeginInit();
      this.lueHDStatus.Properties.BeginInit();
      this.txtMaHopDong.Properties.BeginInit();
      this.datDenNgay.Properties.BeginInit();
      this.datDenNgay.Properties.CalendarTimeProperties.BeginInit();
      this.datTuNgay.Properties.BeginInit();
      this.datTuNgay.Properties.CalendarTimeProperties.BeginInit();
      this.grpMaster.BeginInit();
      this.grpMaster.SuspendLayout();
      this.grcHopDong.BeginInit();
      this.grvHopDong.BeginInit();
      this.illueKhachHang.BeginInit();
      this.ilueCongTruong.BeginInit();
      this.ilueMAC.BeginInit();
      this.ilueHDStatus.BeginInit();
      this.itedKhachHang.BeginInit();
      this.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[1]
      {
        this.barButtons
      });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barManager1.Items.AddRange(new BarItem[7]
      {
        (BarItem) this.bsiCaption,
        (BarItem) this.bbiInsert,
        (BarItem) this.bbiUpdate,
        (BarItem) this.barCheckItem1,
        (BarItem) this.bbiDelete,
        (BarItem) this.bbiView,
        (BarItem) this.barButtonItem1
      });
      this.barManager1.MainMenu = this.barButtons;
      this.barManager1.MaxItemId = 7;
      this.barButtons.BarName = "Main menu";
      this.barButtons.CanDockStyle = BarCanDockStyle.Top;
      this.barButtons.DockCol = 0;
      this.barButtons.DockRow = 0;
      this.barButtons.DockStyle = BarDockStyle.Top;
      this.barButtons.FloatLocation = new Point(311, 180);
      this.barButtons.LinksPersistInfo.AddRange(new LinkPersistInfo[6]
      {
        new LinkPersistInfo((BarItem) this.bsiCaption),
        new LinkPersistInfo((BarItem) this.bbiInsert),
        new LinkPersistInfo((BarItem) this.bbiUpdate),
        new LinkPersistInfo((BarItem) this.bbiDelete),
        new LinkPersistInfo((BarItem) this.bbiView),
        new LinkPersistInfo((BarItem) this.barButtonItem1)
      });
      this.barButtons.OptionsBar.UseWholeRow = true;
      this.barButtons.Text = "Main menu";
      this.bsiCaption.Alignment = BarItemLinkAlignment.Left;
      this.bsiCaption.Caption = "Hợp đồng";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiInsert.Alignment = BarItemLinkAlignment.Left;
      this.bbiInsert.Caption = "Thêm";
      this.bbiInsert.Id = 1;
      this.bbiInsert.ImageOptions.Image = (Image) ResourceNhua.add_file;
      this.bbiInsert.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiInsert.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiInsert.Name = "bbiInsert";
      this.bbiInsert.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiInsert.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick);
      this.bbiUpdate.Alignment = BarItemLinkAlignment.Left;
      this.bbiUpdate.Caption = "Sửa";
      this.bbiUpdate.Id = 2;
      this.bbiUpdate.ImageOptions.Image = (Image) ResourceNhua.edit_file;
      this.bbiUpdate.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiUpdate.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiUpdate.Name = "bbiUpdate";
      this.bbiUpdate.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiUpdate.ItemClick += new ItemClickEventHandler(this.barButtonItem2_ItemClick);
      this.bbiDelete.Alignment = BarItemLinkAlignment.Left;
      this.bbiDelete.Caption = "Xoá";
      this.bbiDelete.Id = 4;
      this.bbiDelete.ImageOptions.Image = (Image) ResourceNhua.delete_file;
      this.bbiDelete.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiDelete.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiDelete.Name = "bbiDelete";
      this.bbiDelete.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiDelete.ItemClick += new ItemClickEventHandler(this.barButtonItem3_ItemClick);
      this.bbiView.Alignment = BarItemLinkAlignment.Left;
      this.bbiView.Caption = "Xem";
      this.bbiView.Id = 5;
      this.bbiView.ImageOptions.Image = (Image) ResourceNhua.view_file;
      this.bbiView.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiView.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiView.Name = "bbiView";
      this.bbiView.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiView.ItemClick += new ItemClickEventHandler(this.barButtonItem4_ItemClick);
      this.barButtonItem1.Caption = "Tạo Phiếu trộn";
      this.barButtonItem1.Id = 6;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.Visibility = BarItemVisibility.Never;
      this.barButtonItem1.ItemClick += new ItemClickEventHandler(this.barButtonItem1_ItemClick_1);
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Margin = new Padding(2);
      this.barDockControlTop.Size = new Size(891, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 650);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(2);
      this.barDockControlBottom.Size = new Size(891, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(2);
      this.barDockControlLeft.Size = new Size(0, 610);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(891, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(2);
      this.barDockControlRight.Size = new Size(0, 610);
      this.barCheckItem1.Caption = "barCheckItem1";
      this.barCheckItem1.Id = 3;
      this.barCheckItem1.Name = "barCheckItem1";
      this.grpSearch.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grpSearch.AppearanceCaption.Options.UseFont = true;
      this.grpSearch.Controls.Add((Control) this.lueMAC);
      this.grpSearch.Controls.Add((Control) this.lblMAC);
      this.grpSearch.Controls.Add((Control) this.lueCongTruong);
      this.grpSearch.Controls.Add((Control) this.lblCongTruong);
      this.grpSearch.Controls.Add((Control) this.lueKhachHang);
      this.grpSearch.Controls.Add((Control) this.lblKhachHang);
      this.grpSearch.Controls.Add((Control) this.btnReset);
      this.grpSearch.Controls.Add((Control) this.lblActive);
      this.grpSearch.Controls.Add((Control) this.lblMaHopDong);
      this.grpSearch.Controls.Add((Control) this.lblToDate);
      this.grpSearch.Controls.Add((Control) this.btnSearch);
      this.grpSearch.Controls.Add((Control) this.lueHDStatus);
      this.grpSearch.Controls.Add((Control) this.txtMaHopDong);
      this.grpSearch.Controls.Add((Control) this.datDenNgay);
      this.grpSearch.Controls.Add((Control) this.datTuNgay);
      this.grpSearch.Controls.Add((Control) this.lblFromDate);
      this.grpSearch.Dock = DockStyle.Right;
      this.grpSearch.Location = new Point(611, 40);
      this.grpSearch.Margin = new Padding(2);
      this.grpSearch.Name = "grpSearch";
      this.grpSearch.Size = new Size(280, 610);
      this.grpSearch.TabIndex = 4;
      this.grpSearch.Tag = (object) "2";
      this.grpSearch.Text = "Tìm kiếm";
      this.lueMAC.Location = new Point(112, 195);
      this.lueMAC.Margin = new Padding(2);
      this.lueMAC.MenuManager = (IDXMenuManager) this.barManager1;
      this.lueMAC.Name = "lueMAC";
      this.lueMAC.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueMAC.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("MACID", "MACID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaMAC", "Mã MAC", 30, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenMAC", "Tên MAC", 30, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.lueMAC.Properties.DisplayMember = "TenMAC";
      this.lueMAC.Properties.NullText = "";
      this.lueMAC.Properties.ShowFooter = false;
      this.lueMAC.Properties.ValueMember = "MACID";
      this.lueMAC.Size = new Size(150, 20);
      this.lueMAC.TabIndex = 107;
      this.lblMAC.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMAC.Appearance.Options.UseFont = true;
      this.lblMAC.Location = new Point(19, 196);
      this.lblMAC.Margin = new Padding(2);
      this.lblMAC.Name = "lblMAC";
      this.lblMAC.Size = new Size(26, 16);
      this.lblMAC.TabIndex = 106;
      this.lblMAC.Text = "MAC";
      this.lueCongTruong.Location = new Point(112, 165);
      this.lueCongTruong.Margin = new Padding(2);
      this.lueCongTruong.MenuManager = (IDXMenuManager) this.barManager1;
      this.lueCongTruong.Name = "lueCongTruong";
      this.lueCongTruong.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueCongTruong.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("CongTruongID", "CongTruongID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaCongTruong", "Mã Công Trường", 30, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenCongTruong", "Tên Công Trường", 30, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.lueCongTruong.Properties.DisplayMember = "TenCongTruong";
      this.lueCongTruong.Properties.NullText = "";
      this.lueCongTruong.Properties.ShowFooter = false;
      this.lueCongTruong.Properties.ValueMember = "CongTruongID";
      this.lueCongTruong.Size = new Size(150, 20);
      this.lueCongTruong.TabIndex = 105;
      this.lblCongTruong.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblCongTruong.Appearance.Options.UseFont = true;
      this.lblCongTruong.Location = new Point(19, 166);
      this.lblCongTruong.Margin = new Padding(2);
      this.lblCongTruong.Name = "lblCongTruong";
      this.lblCongTruong.Size = new Size(71, 16);
      this.lblCongTruong.TabIndex = 104;
      this.lblCongTruong.Text = "Công trường";
      this.lueKhachHang.Location = new Point(112, 135);
      this.lueKhachHang.Margin = new Padding(2);
      this.lueKhachHang.MenuManager = (IDXMenuManager) this.barManager1;
      this.lueKhachHang.Name = "lueKhachHang";
      this.lueKhachHang.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueKhachHang.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("KhachHangID", "KhachHangID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaKhachHang", "Mã Khách Hàng", 30, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenKhachHang", "Tên Khách Hàng", 40, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.lueKhachHang.Properties.DisplayMember = "TenKhachHang";
      this.lueKhachHang.Properties.NullText = "";
      this.lueKhachHang.Properties.ShowFooter = false;
      this.lueKhachHang.Properties.ValueMember = "KhachHangID";
      this.lueKhachHang.Size = new Size(150, 20);
      this.lueKhachHang.TabIndex = 103;
      this.lblKhachHang.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKhachHang.Appearance.Options.UseFont = true;
      this.lblKhachHang.Location = new Point(19, 136);
      this.lblKhachHang.Margin = new Padding(2);
      this.lblKhachHang.Name = "lblKhachHang";
      this.lblKhachHang.Size = new Size(66, 16);
      this.lblKhachHang.TabIndex = 102;
      this.lblKhachHang.Text = "Khách hàng";
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(19, 275);
      this.btnReset.Margin = new Padding(2);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(105, 35);
      this.btnReset.TabIndex = 101;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.lblActive.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblActive.Appearance.Options.UseFont = true;
      this.lblActive.Location = new Point(19, 226);
      this.lblActive.Margin = new Padding(2);
      this.lblActive.Name = "lblActive";
      this.lblActive.Size = new Size(59, 16);
      this.lblActive.TabIndex = 100;
      this.lblActive.Text = "Trạng thái";
      this.lblMaHopDong.AutoSize = true;
      this.lblMaHopDong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaHopDong.Location = new Point(16, 106);
      this.lblMaHopDong.Margin = new Padding(2, 0, 2, 0);
      this.lblMaHopDong.Name = "lblMaHopDong";
      this.lblMaHopDong.Size = new Size(82, 16);
      this.lblMaHopDong.TabIndex = 99;
      this.lblMaHopDong.Text = "Mã Hợp đồng";
      this.lblToDate.AutoSize = true;
      this.lblToDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblToDate.Location = new Point(16, 76);
      this.lblToDate.Margin = new Padding(2, 0, 2, 0);
      this.lblToDate.Name = "lblToDate";
      this.lblToDate.Size = new Size(61, 16);
      this.lblToDate.TabIndex = 98;
      this.lblToDate.Text = "Đến ngày";
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(155, 275);
      this.btnSearch.Margin = new Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(105, 35);
      this.btnSearch.TabIndex = 97;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
      this.lueHDStatus.Location = new Point(112, 225);
      this.lueHDStatus.Margin = new Padding(2);
      this.lueHDStatus.MenuManager = (IDXMenuManager) this.barManager1;
      this.lueHDStatus.Name = "lueHDStatus";
      this.lueHDStatus.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueHDStatus.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("DisplayText", "Trạng Thái")
      });
      this.lueHDStatus.Properties.DisplayMember = "DisplayText";
      this.lueHDStatus.Properties.NullText = "";
      this.lueHDStatus.Properties.ValueMember = "ID";
      this.lueHDStatus.Size = new Size(150, 20);
      this.lueHDStatus.TabIndex = 96;
      this.txtMaHopDong.Location = new Point(112, 105);
      this.txtMaHopDong.Margin = new Padding(2);
      this.txtMaHopDong.Name = "txtMaHopDong";
      this.txtMaHopDong.Size = new Size(150, 20);
      this.txtMaHopDong.TabIndex = 95;
      this.datDenNgay.EditValue = (object) null;
      this.datDenNgay.Location = new Point(112, 75);
      this.datDenNgay.Margin = new Padding(2);
      this.datDenNgay.Name = "datDenNgay";
      this.datDenNgay.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datDenNgay.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datDenNgay.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datDenNgay.Size = new Size(150, 20);
      this.datDenNgay.TabIndex = 94;
      this.datTuNgay.EditValue = (object) null;
      this.datTuNgay.Location = new Point(112, 45);
      this.datTuNgay.Margin = new Padding(2);
      this.datTuNgay.Name = "datTuNgay";
      this.datTuNgay.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datTuNgay.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datTuNgay.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datTuNgay.Size = new Size(150, 20);
      this.datTuNgay.TabIndex = 93;
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(19, 46);
      this.lblFromDate.Margin = new Padding(2);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(73, 16);
      this.lblFromDate.TabIndex = 92;
      this.lblFromDate.Text = "Tạo Từ ngày";
      this.grpMaster.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grpMaster.AppearanceCaption.Options.UseFont = true;
      this.grpMaster.Controls.Add((Control) this.grcHopDong);
      this.grpMaster.Dock = DockStyle.Fill;
      this.grpMaster.Location = new Point(0, 40);
      this.grpMaster.Margin = new Padding(2);
      this.grpMaster.Name = "grpMaster";
      this.grpMaster.Size = new Size(611, 610);
      this.grpMaster.TabIndex = 5;
      this.grpMaster.Tag = (object) "1";
      this.grpMaster.Text = "Dữ liệu";
      this.grcHopDong.Dock = DockStyle.Fill;
      this.grcHopDong.EmbeddedNavigator.Margin = new Padding(2);
      this.grcHopDong.Location = new Point(2, 23);
      this.grcHopDong.MainView = (BaseView) this.grvHopDong;
      this.grcHopDong.Margin = new Padding(2);
      this.grcHopDong.MenuManager = (IDXMenuManager) this.barManager1;
      this.grcHopDong.Name = "grcHopDong";
      this.grcHopDong.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.ilueHDStatus,
        (RepositoryItem) this.itedKhachHang,
        (RepositoryItem) this.illueKhachHang,
        (RepositoryItem) this.ilueCongTruong,
        (RepositoryItem) this.ilueMAC
      });
      this.grcHopDong.Size = new Size(607, 585);
      this.grcHopDong.TabIndex = 0;
      this.grcHopDong.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvHopDong
      });
      this.grvHopDong.Columns.AddRange(new GridColumn[11]
      {
        this.gcMaHopDong,
        this.gcTenHopDong,
        this.gcNgayHopDong,
        this.gcKhachHang,
        this.gcCongTruong,
        this.gcMAC,
        this.gcStatus,
        this.gcKLDatHang,
        this.gcKLDaGiao,
        this.gcKLTaoPhieuTron,
        this.gcMoTa
      });
      this.grvHopDong.DetailHeight = 284;
      this.grvHopDong.GridControl = this.grcHopDong;
      this.grvHopDong.Name = "grvHopDong";
      this.grvHopDong.OptionsView.ColumnAutoWidth = false;
      this.grvHopDong.OptionsView.ShowFooter = true;
      this.gcMaHopDong.Caption = "Mã Hợp Đồng";
      this.gcMaHopDong.FieldName = "MaHopDong";
      this.gcMaHopDong.MinWidth = 100;
      this.gcMaHopDong.Name = "gcMaHopDong";
      this.gcMaHopDong.OptionsColumn.AllowEdit = false;
      this.gcMaHopDong.Visible = true;
      this.gcMaHopDong.VisibleIndex = 0;
      this.gcMaHopDong.Width = 100;
      this.gcTenHopDong.Caption = "Tên Hợp Đồng";
      this.gcTenHopDong.FieldName = "TenHopDong";
      this.gcTenHopDong.MinWidth = 300;
      this.gcTenHopDong.Name = "gcTenHopDong";
      this.gcTenHopDong.OptionsColumn.AllowEdit = false;
      this.gcTenHopDong.Visible = true;
      this.gcTenHopDong.VisibleIndex = 1;
      this.gcTenHopDong.Width = 300;
      this.gcNgayHopDong.Caption = "Ngày tạo hợp đồng";
      this.gcNgayHopDong.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.gcNgayHopDong.DisplayFormat.FormatType = FormatType.DateTime;
      this.gcNgayHopDong.FieldName = "NgayHopDong";
      this.gcNgayHopDong.MinWidth = 150;
      this.gcNgayHopDong.Name = "gcNgayHopDong";
      this.gcNgayHopDong.OptionsColumn.AllowEdit = false;
      this.gcNgayHopDong.Visible = true;
      this.gcNgayHopDong.VisibleIndex = 2;
      this.gcNgayHopDong.Width = 150;
      this.gcKhachHang.Caption = "Khách Hàng";
      this.gcKhachHang.ColumnEdit = (RepositoryItem) this.illueKhachHang;
      this.gcKhachHang.FieldName = "KhachHangID";
      this.gcKhachHang.MinWidth = 150;
      this.gcKhachHang.Name = "gcKhachHang";
      this.gcKhachHang.OptionsColumn.AllowEdit = false;
      this.gcKhachHang.Visible = true;
      this.gcKhachHang.VisibleIndex = 3;
      this.gcKhachHang.Width = 150;
      this.illueKhachHang.AutoHeight = false;
      this.illueKhachHang.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.illueKhachHang.DisplayMember = "TenKhachHang";
      this.illueKhachHang.Name = "illueKhachHang";
      this.illueKhachHang.NullText = "";
      this.illueKhachHang.ValueMember = "KhachHangID";
      this.gcCongTruong.Caption = "Công Trường";
      this.gcCongTruong.ColumnEdit = (RepositoryItem) this.ilueCongTruong;
      this.gcCongTruong.FieldName = "CongTruongID";
      this.gcCongTruong.MinWidth = 150;
      this.gcCongTruong.Name = "gcCongTruong";
      this.gcCongTruong.OptionsColumn.AllowEdit = false;
      this.gcCongTruong.Visible = true;
      this.gcCongTruong.VisibleIndex = 4;
      this.gcCongTruong.Width = 150;
      this.ilueCongTruong.AutoHeight = false;
      this.ilueCongTruong.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueCongTruong.DisplayMember = "TenCongTruong";
      this.ilueCongTruong.Name = "ilueCongTruong";
      this.ilueCongTruong.ValueMember = "CongTruongID";
      this.gcMAC.Caption = "MAC";
      this.gcMAC.ColumnEdit = (RepositoryItem) this.ilueMAC;
      this.gcMAC.FieldName = "MACID";
      this.gcMAC.MinWidth = 150;
      this.gcMAC.Name = "gcMAC";
      this.gcMAC.OptionsColumn.AllowEdit = false;
      this.gcMAC.Visible = true;
      this.gcMAC.VisibleIndex = 5;
      this.gcMAC.Width = 160;
      this.ilueMAC.AutoHeight = false;
      this.ilueMAC.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueMAC.DisplayMember = "TenMAC";
      this.ilueMAC.Name = "ilueMAC";
      this.ilueMAC.ValueMember = "MACID";
      this.gcStatus.Caption = "Trạng Thái";
      this.gcStatus.ColumnEdit = (RepositoryItem) this.ilueHDStatus;
      this.gcStatus.FieldName = "Status";
      this.gcStatus.MinWidth = 150;
      this.gcStatus.Name = "gcStatus";
      this.gcStatus.OptionsColumn.AllowEdit = false;
      this.gcStatus.Visible = true;
      this.gcStatus.VisibleIndex = 6;
      this.gcStatus.Width = 150;
      this.ilueHDStatus.AutoHeight = false;
      this.ilueHDStatus.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueHDStatus.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("DisplayText", "DisplayText")
      });
      this.ilueHDStatus.DisplayMember = "DisplayText";
      this.ilueHDStatus.Name = "ilueHDStatus";
      this.ilueHDStatus.NullText = "";
      this.ilueHDStatus.ShowFooter = false;
      this.ilueHDStatus.ShowHeader = false;
      this.ilueHDStatus.ValueMember = "ID";
      this.gcKLDatHang.Caption = "Khối Lượng Đặt Hàng";
      this.gcKLDatHang.FieldName = "KLDatHang";
      this.gcKLDatHang.MinWidth = 150;
      this.gcKLDatHang.Name = "gcKLDatHang";
      this.gcKLDatHang.OptionsColumn.AllowEdit = false;
      this.gcKLDatHang.Visible = true;
      this.gcKLDatHang.VisibleIndex = 7;
      this.gcKLDatHang.Width = 150;
      this.gcKLDaGiao.Caption = "Khối Lượng Đã Giao";
      this.gcKLDaGiao.FieldName = "KLDaGiao";
      this.gcKLDaGiao.MinWidth = 150;
      this.gcKLDaGiao.Name = "gcKLDaGiao";
      this.gcKLDaGiao.OptionsColumn.AllowEdit = false;
      this.gcKLDaGiao.Visible = true;
      this.gcKLDaGiao.VisibleIndex = 8;
      this.gcKLDaGiao.Width = 150;
      this.gcKLTaoPhieuTron.Caption = "KL Đã Tạo Dữ Liệu Trôn";
      this.gcKLTaoPhieuTron.FieldName = "KLTaoPhieuTron";
      this.gcKLTaoPhieuTron.MinWidth = 150;
      this.gcKLTaoPhieuTron.Name = "gcKLTaoPhieuTron";
      this.gcKLTaoPhieuTron.OptionsColumn.AllowEdit = false;
      this.gcKLTaoPhieuTron.Width = 150;
      this.gcMoTa.Caption = "Mô tả";
      this.gcMoTa.FieldName = "MoTa";
      this.gcMoTa.MinWidth = 150;
      this.gcMoTa.Name = "gcMoTa";
      this.gcMoTa.OptionsColumn.AllowEdit = false;
      this.gcMoTa.Visible = true;
      this.gcMoTa.VisibleIndex = 9;
      this.gcMoTa.Width = 150;
      this.itedKhachHang.AutoHeight = false;
      this.itedKhachHang.Name = "itedKhachHang";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.grpMaster);
      this.Controls.Add((Control) this.grpSearch);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (HopDongMngView);
      this.Size = new Size(891, 650);
      this.Tag = (object) "qw";
      this.barManager1.EndInit();
      this.grpSearch.EndInit();
      this.grpSearch.ResumeLayout(false);
      this.grpSearch.PerformLayout();
      this.lueMAC.Properties.EndInit();
      this.lueCongTruong.Properties.EndInit();
      this.lueKhachHang.Properties.EndInit();
      this.lueHDStatus.Properties.EndInit();
      this.txtMaHopDong.Properties.EndInit();
      this.datDenNgay.Properties.CalendarTimeProperties.EndInit();
      this.datDenNgay.Properties.EndInit();
      this.datTuNgay.Properties.CalendarTimeProperties.EndInit();
      this.datTuNgay.Properties.EndInit();
      this.grpMaster.EndInit();
      this.grpMaster.ResumeLayout(false);
      this.grcHopDong.EndInit();
      this.grvHopDong.EndInit();
      this.illueKhachHang.EndInit();
      this.ilueCongTruong.EndInit();
      this.ilueMAC.EndInit();
      this.ilueHDStatus.EndInit();
      this.itedKhachHang.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

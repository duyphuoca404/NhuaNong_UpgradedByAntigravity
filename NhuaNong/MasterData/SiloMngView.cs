// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.SiloMngView
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
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class SiloMngView : ControlViewBase, ISiloMngView, IBase, IPermission
  {
    private SiloMngDataPresenter _presenter;
    private SerialPort _sPort;
    private BindingList<ObjSilo> _blstSilo = new BindingList<ObjSilo>();
    private BindingList<ObjNhomSilo> _blstNhomSilo = new BindingList<ObjNhomSilo>();
    private bool _showDoAm;
    private bool _showKLCanMinMax;
    private bool _showMaterial;
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private IContainer components;
    private BarManager barManager1;
    private Bar bar2;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarStaticItem bsiCaption;
    private BarButtonItem bbiInsert;
    private BarButtonItem bbiUpdate;
    private BarButtonItem bbiDelete;
    private BarButtonItem bbiView;
    private GroupControl grcMaster;
    private GridControl grcSilo;
    private AdvBandedGridView graSilo;
    private BandedGridColumn gcNhomSilo;
    private RepositoryItemLookUpEdit ilueNhomSilo;
    private BandedGridColumn gcMaSilo;
    private BandedGridColumn gcTenSilo;
    private BandedGridColumn gcSaiSoDuoi;
    private BandedGridColumn gcSaiSoTren;
    private BandedGridColumn gcKLCanNhoNhat;
    private BandedGridColumn gcKLCanLonNhat;
    private BandedGridColumn gcTGNhapNhaOn;
    private BandedGridColumn gcTGNhapNhaOff;
    private BandedGridColumn gcTGKiemTraVatLieuRoi;
    private BandedGridColumn gcKLRoi;
    private BandedGridColumn gcKPulse;
    private BandedGridColumn gcSoTT;
    private BandedGridColumn gcActivated;
    private BandedGridColumn gcTu1;
    private BandedGridColumn gcDen1;
    private BandedGridColumn gcDungTruoc1;
    private BandedGridColumn gcTu2;
    private BandedGridColumn gcDen2;
    private BandedGridColumn gcDungTruoc2;
    private BandedGridColumn gcTu3;
    private BandedGridColumn gcDen3;
    private BandedGridColumn gcDungTruoc3;
    private RepositoryItemButtonEdit repositoryItemButtonEdit1;
    private GridBand gridBand3;
    private GridBand grdBandThongSoSilo;
    private GridBand grdBandThongSoKhac;

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public SiloMngView(SerialPort sPort)
    {
      this.InitializeComponent();
      this._presenter = new SiloMngDataPresenter((ISiloMngView) this);
      this._sPort = sPort;
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjSilo> BLstSilo
    {
      set
      {
        this._blstSilo = value;
        this.grcSilo.DataSource = (object) this._blstSilo;
        this.graSilo.ExpandAllGroups();
      }
    }

    public BindingList<ObjNhomSilo> BLstNhomSilo
    {
      set
      {
        this._blstNhomSilo = value;
        this.ilueNhomSilo.DataSource = (object) this._blstNhomSilo;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void PopulateStaticData() => this._presenter.ListNhomSilo();

    protected override void PopulateData() => this._presenter.ListSilo();

    private void SuccessfullySave(bool isSuccess)
    {
    }

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewSiloView ctrView = new NewSiloView((ObjSilo) null, Enums.FormAction.New, false, true, this._showKLCanMinMax);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListSilo();
      this.FocusRow(this.graSilo, this.graSilo.RowCount);
    }

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.graSilo.RowCount == 0)
        return;
      int focusedRowHandle = this.graSilo.FocusedRowHandle;
      this._blstSilo.Where<ObjSilo>((Func<ObjSilo, bool>) (o => o.MaSilo == (this.graSilo.GetRow(focusedRowHandle) as ObjSilo).MaSilo)).First<ObjSilo>();
      this._showDoAm = false;
      if ((this.graSilo.GetRow(focusedRowHandle) as ObjSilo).MaSilo.Contains("Agg"))
        this._showDoAm = true;
      NewSiloView ctrView = new NewSiloView(this.graSilo.GetRow(focusedRowHandle) as ObjSilo, Enums.FormAction.Edit, true, this._showDoAm, this._showKLCanMinMax);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListSilo();
      this.FocusRow(this.graSilo, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      BindingList<ObjSilo> blstCT = new BindingList<ObjSilo>();
      foreach (int selectedRow in this.graSilo.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjSilo row = this.graSilo.GetRow(selectedRow) as ObjSilo;
          row.MarkAsDeleted = true;
          blstCT.Add(row);
        }
      }
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) blstCT)
        this._blstSilo.Remove(objSilo);
      this.FocusRow(this.graSilo, this.graSilo.RowCount);
      this._presenter.SaveSilo(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.graSilo.RowCount == 0)
        return;
      this._blstSilo.Where<ObjSilo>((Func<ObjSilo, bool>) (o => o.MaSilo == (this.graSilo.GetRow(this.graSilo.FocusedRowHandle) as ObjSilo).MaSilo)).First<ObjSilo>();
      this._showDoAm = false;
      if ((this.graSilo.GetRow(this.graSilo.FocusedRowHandle) as ObjSilo).MaSilo.Contains("Agg"))
        this._showDoAm = true;
      ViewManager.ShowViewDialog((ControlViewBase) new NewSiloView(this.graSilo.GetRow(this.graSilo.FocusedRowHandle) as ObjSilo, Enums.FormAction.View, true, this._showDoAm, this._showKLCanMinMax));
    }

    private void BindPermission()
    {
      this.bbiInsert.Enabled = this.CheckHasPermission(this.bbiInsert.Name);
      this.bbiUpdate.Enabled = this.CheckHasPermission(this.bbiUpdate.Name);
      this.bbiDelete.Enabled = this.CheckHasPermission(this.bbiDelete.Name);
      this.bbiView.Enabled = this.CheckHasPermission(this.bbiView.Name);
      this._showKLCanMinMax = this.CheckHasPermission("ShowKLCanMinMax");
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
      this.bar2 = new Bar();
      this.bsiCaption = new BarStaticItem();
      this.bbiInsert = new BarButtonItem();
      this.bbiUpdate = new BarButtonItem();
      this.bbiDelete = new BarButtonItem();
      this.bbiView = new BarButtonItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.grcMaster = new GroupControl();
      this.grcSilo = new GridControl();
      this.graSilo = new AdvBandedGridView();
      this.gcNhomSilo = new BandedGridColumn();
      this.ilueNhomSilo = new RepositoryItemLookUpEdit();
      this.gcMaSilo = new BandedGridColumn();
      this.gcTenSilo = new BandedGridColumn();
      this.gcSaiSoDuoi = new BandedGridColumn();
      this.gcSaiSoTren = new BandedGridColumn();
      this.gcKLCanNhoNhat = new BandedGridColumn();
      this.gcKLCanLonNhat = new BandedGridColumn();
      this.gcTGNhapNhaOn = new BandedGridColumn();
      this.gcTGNhapNhaOff = new BandedGridColumn();
      this.gcTGKiemTraVatLieuRoi = new BandedGridColumn();
      this.gcKLRoi = new BandedGridColumn();
      this.gcKPulse = new BandedGridColumn();
      this.gcSoTT = new BandedGridColumn();
      this.gcActivated = new BandedGridColumn();
      this.gcTu1 = new BandedGridColumn();
      this.gcDen1 = new BandedGridColumn();
      this.gcDungTruoc1 = new BandedGridColumn();
      this.gcTu2 = new BandedGridColumn();
      this.gcDen2 = new BandedGridColumn();
      this.gcDungTruoc2 = new BandedGridColumn();
      this.gcTu3 = new BandedGridColumn();
      this.gcDen3 = new BandedGridColumn();
      this.gcDungTruoc3 = new BandedGridColumn();
      this.repositoryItemButtonEdit1 = new RepositoryItemButtonEdit();
      this.gridBand3 = new GridBand();
      this.grdBandThongSoSilo = new GridBand();
      this.grdBandThongSoKhac = new GridBand();
      this.barManager1.BeginInit();
      this.grcMaster.BeginInit();
      this.grcMaster.SuspendLayout();
      this.grcSilo.BeginInit();
      this.graSilo.BeginInit();
      this.ilueNhomSilo.BeginInit();
      this.repositoryItemButtonEdit1.BeginInit();
      this.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[1]{ this.bar2 });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barManager1.Items.AddRange(new BarItem[5]
      {
        (BarItem) this.bsiCaption,
        (BarItem) this.bbiInsert,
        (BarItem) this.bbiUpdate,
        (BarItem) this.bbiDelete,
        (BarItem) this.bbiView
      });
      this.barManager1.MainMenu = this.bar2;
      this.barManager1.MaxItemId = 5;
      this.bar2.BarName = "Main menu";
      this.bar2.DockCol = 0;
      this.bar2.DockRow = 0;
      this.bar2.DockStyle = BarDockStyle.Top;
      this.bar2.LinksPersistInfo.AddRange(new LinkPersistInfo[5]
      {
        new LinkPersistInfo((BarItem) this.bsiCaption),
        new LinkPersistInfo((BarItem) this.bbiInsert),
        new LinkPersistInfo((BarItem) this.bbiUpdate),
        new LinkPersistInfo((BarItem) this.bbiDelete),
        new LinkPersistInfo((BarItem) this.bbiView)
      });
      this.bar2.OptionsBar.MultiLine = true;
      this.bar2.OptionsBar.UseWholeRow = true;
      this.bar2.Text = "Main menu";
      this.bsiCaption.Caption = "Silo";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiInsert.Caption = "Thêm";
      this.bbiInsert.Id = 1;
      this.bbiInsert.ImageOptions.Image = (Image) ResourceNhua.add_file;
      this.bbiInsert.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiInsert.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiInsert.Name = "bbiInsert";
      this.bbiInsert.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiInsert.ItemClick += new ItemClickEventHandler(this.bbiInsert_ItemClick);
      this.bbiUpdate.Caption = "Sửa";
      this.bbiUpdate.Id = 2;
      this.bbiUpdate.ImageOptions.Image = (Image) ResourceNhua.edit_file;
      this.bbiUpdate.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiUpdate.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiUpdate.Name = "bbiUpdate";
      this.bbiUpdate.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiUpdate.ItemClick += new ItemClickEventHandler(this.bbiUpdate_ItemClick);
      this.bbiDelete.Caption = "Xoá";
      this.bbiDelete.Id = 3;
      this.bbiDelete.ImageOptions.Image = (Image) ResourceNhua.delete_file;
      this.bbiDelete.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiDelete.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiDelete.Name = "bbiDelete";
      this.bbiDelete.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiDelete.ItemClick += new ItemClickEventHandler(this.bbiDelete_ItemClick);
      this.bbiView.Caption = "Xem";
      this.bbiView.Id = 4;
      this.bbiView.ImageOptions.Image = (Image) ResourceNhua.view_file;
      this.bbiView.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiView.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiView.Name = "bbiView";
      this.bbiView.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiView.ItemClick += new ItemClickEventHandler(this.bbiView_ItemClick);
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Margin = new Padding(2);
      this.barDockControlTop.Size = new Size(848, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 488);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(2);
      this.barDockControlBottom.Size = new Size(848, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(2);
      this.barDockControlLeft.Size = new Size(0, 448);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(848, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(2);
      this.barDockControlRight.Size = new Size(0, 448);
      this.grcMaster.Controls.Add((Control) this.grcSilo);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(848, 448);
      this.grcMaster.TabIndex = 4;
      this.grcMaster.Text = "Dữ liệu";
      this.grcSilo.Dock = DockStyle.Fill;
      this.grcSilo.EmbeddedNavigator.Margin = new Padding(2);
      this.grcSilo.Location = new Point(2, 23);
      this.grcSilo.MainView = (BaseView) this.graSilo;
      this.grcSilo.Margin = new Padding(2);
      this.grcSilo.MenuManager = (IDXMenuManager) this.barManager1;
      this.grcSilo.Name = "grcSilo";
      this.grcSilo.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.repositoryItemButtonEdit1,
        (RepositoryItem) this.ilueNhomSilo
      });
      this.grcSilo.Size = new Size(844, 423);
      this.grcSilo.TabIndex = 0;
      this.grcSilo.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.graSilo
      });
      this.graSilo.Bands.AddRange(new GridBand[3]
      {
        this.gridBand3,
        this.grdBandThongSoSilo,
        this.grdBandThongSoKhac
      });
      this.graSilo.Columns.AddRange(new BandedGridColumn[23]
      {
        this.gcMaSilo,
        this.gcTenSilo,
        this.gcNhomSilo,
        this.gcSaiSoDuoi,
        this.gcSaiSoTren,
        this.gcKLCanNhoNhat,
        this.gcKLCanLonNhat,
        this.gcTGNhapNhaOn,
        this.gcTGNhapNhaOff,
        this.gcTGKiemTraVatLieuRoi,
        this.gcKLRoi,
        this.gcKPulse,
        this.gcSoTT,
        this.gcActivated,
        this.gcTu1,
        this.gcDen1,
        this.gcDungTruoc1,
        this.gcTu2,
        this.gcDen2,
        this.gcDungTruoc2,
        this.gcTu3,
        this.gcDen3,
        this.gcDungTruoc3
      });
      this.graSilo.DetailHeight = 284;
      this.graSilo.GridControl = this.grcSilo;
      this.graSilo.Name = "graSilo";
      this.gcNhomSilo.Caption = "Nhóm Silo";
      this.gcNhomSilo.ColumnEdit = (RepositoryItem) this.ilueNhomSilo;
      this.gcNhomSilo.FieldName = "NhomSiloID";
      this.gcNhomSilo.MinWidth = 324;
      this.gcNhomSilo.Name = "gcNhomSilo";
      this.gcNhomSilo.OptionsColumn.AllowEdit = false;
      this.gcNhomSilo.RowCount = 3;
      this.gcNhomSilo.Width = 378;
      this.ilueNhomSilo.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueNhomSilo.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("NhomSiloID", "Name4", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaNhomSilo", "Mã Nhóm Silo"),
        new LookUpColumnInfo("TenNhomSilo", "Tên Nhóm Silo")
      });
      this.ilueNhomSilo.Name = "ilueNhomSilo";
      this.gcMaSilo.Caption = "Mã Silo";
      this.gcMaSilo.FieldName = "MaSilo";
      this.gcMaSilo.MinWidth = 324;
      this.gcMaSilo.Name = "gcMaSilo";
      this.gcMaSilo.OptionsColumn.AllowEdit = false;
      this.gcMaSilo.Visible = true;
      this.gcMaSilo.Width = 324;
      this.gcTenSilo.Caption = "Tên Silo";
      this.gcTenSilo.FieldName = "TenSilo";
      this.gcTenSilo.MinWidth = 324;
      this.gcTenSilo.Name = "gcTenSilo";
      this.gcTenSilo.OptionsColumn.AllowEdit = false;
      this.gcTenSilo.RowIndex = 1;
      this.gcTenSilo.Visible = true;
      this.gcTenSilo.Width = 324;
      this.gcSaiSoDuoi.Caption = "Sai Số Dưới [%]";
      this.gcSaiSoDuoi.FieldName = "SaiSoDuoi";
      this.gcSaiSoDuoi.MinWidth = 119;
      this.gcSaiSoDuoi.Name = "gcSaiSoDuoi";
      this.gcSaiSoDuoi.OptionsColumn.AllowEdit = false;
      this.gcSaiSoDuoi.RowCount = 2;
      this.gcSaiSoDuoi.Visible = true;
      this.gcSaiSoDuoi.Width = 119;
      this.gcSaiSoTren.Caption = "Sai Số Trên [%]";
      this.gcSaiSoTren.FieldName = "SaiSoTren";
      this.gcSaiSoTren.MinWidth = 119;
      this.gcSaiSoTren.Name = "gcSaiSoTren";
      this.gcSaiSoTren.OptionsColumn.AllowEdit = false;
      this.gcSaiSoTren.RowCount = 2;
      this.gcSaiSoTren.Visible = true;
      this.gcSaiSoTren.Width = 119;
      this.gcKLCanNhoNhat.Caption = "KL Cân Nhỏ Nhất [Kg]";
      this.gcKLCanNhoNhat.FieldName = "KLCanNhoNhat";
      this.gcKLCanNhoNhat.MinWidth = 119;
      this.gcKLCanNhoNhat.Name = "gcKLCanNhoNhat";
      this.gcKLCanNhoNhat.OptionsColumn.AllowEdit = false;
      this.gcKLCanNhoNhat.RowCount = 2;
      this.gcKLCanNhoNhat.Visible = true;
      this.gcKLCanNhoNhat.Width = 119;
      this.gcKLCanLonNhat.Caption = "KL Cân Lớn Nhất [Kg]";
      this.gcKLCanLonNhat.FieldName = "KLCanLonNhat";
      this.gcKLCanLonNhat.MinWidth = 119;
      this.gcKLCanLonNhat.Name = "gcKLCanLonNhat";
      this.gcKLCanLonNhat.OptionsColumn.AllowEdit = false;
      this.gcKLCanLonNhat.RowCount = 2;
      this.gcKLCanLonNhat.Visible = true;
      this.gcKLCanLonNhat.Width = 119;
      this.gcTGNhapNhaOn.Caption = "TG Nhấp Nhả On [0.1s]";
      this.gcTGNhapNhaOn.FieldName = "TGNhapNhaOn";
      this.gcTGNhapNhaOn.MinWidth = 119;
      this.gcTGNhapNhaOn.Name = "gcTGNhapNhaOn";
      this.gcTGNhapNhaOn.OptionsColumn.AllowEdit = false;
      this.gcTGNhapNhaOn.RowCount = 2;
      this.gcTGNhapNhaOn.Visible = true;
      this.gcTGNhapNhaOn.Width = 119;
      this.gcTGNhapNhaOff.Caption = "TG Nhấp Nhả Off [0.1s]";
      this.gcTGNhapNhaOff.FieldName = "TGNhapNhaOff";
      this.gcTGNhapNhaOff.MinWidth = 119;
      this.gcTGNhapNhaOff.Name = "gcTGNhapNhaOff";
      this.gcTGNhapNhaOff.OptionsColumn.AllowEdit = false;
      this.gcTGNhapNhaOff.RowCount = 2;
      this.gcTGNhapNhaOff.Visible = true;
      this.gcTGNhapNhaOff.Width = 119;
      this.gcTGKiemTraVatLieuRoi.Caption = "TG Tính Lượng Rơi Thêm [0.1s]";
      this.gcTGKiemTraVatLieuRoi.FieldName = "TGKiemTraVatLieuRoi";
      this.gcTGKiemTraVatLieuRoi.MinWidth = 119;
      this.gcTGKiemTraVatLieuRoi.Name = "gcTGKiemTraVatLieuRoi";
      this.gcTGKiemTraVatLieuRoi.OptionsColumn.AllowEdit = false;
      this.gcTGKiemTraVatLieuRoi.RowCount = 2;
      this.gcTGKiemTraVatLieuRoi.Visible = true;
      this.gcTGKiemTraVatLieuRoi.Width = 119;
      this.gcKLRoi.Caption = "KL Rơi [Kg]";
      this.gcKLRoi.FieldName = "KLRoi";
      this.gcKLRoi.MinWidth = 119;
      this.gcKLRoi.Name = "gcKLRoi";
      this.gcKLRoi.OptionsColumn.AllowEdit = false;
      this.gcKLRoi.RowCount = 2;
      this.gcKLRoi.Visible = true;
      this.gcKLRoi.Width = 119;
      this.gcKPulse.Caption = "Xung";
      this.gcKPulse.DisplayFormat.FormatString = "n0";
      this.gcKPulse.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcKPulse.FieldName = "K_Pulse";
      this.gcKPulse.MinWidth = 119;
      this.gcKPulse.Name = "gcKPulse";
      this.gcKPulse.OptionsColumn.AllowEdit = false;
      this.gcKPulse.RowCount = 2;
      this.gcKPulse.Width = 119;
      this.gcSoTT.Caption = "STT";
      this.gcSoTT.FieldName = "SoTT";
      this.gcSoTT.MinWidth = 238;
      this.gcSoTT.Name = "gcSoTT";
      this.gcSoTT.OptionsColumn.AllowEdit = false;
      this.gcSoTT.RowCount = 2;
      this.gcSoTT.Visible = true;
      this.gcSoTT.Width = 238;
      this.gcActivated.AppearanceHeader.Options.UseTextOptions = true;
      this.gcActivated.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcActivated.Caption = "Kích Hoạt";
      this.gcActivated.FieldName = "Activated";
      this.gcActivated.MinWidth = 238;
      this.gcActivated.Name = "gcActivated";
      this.gcActivated.OptionsColumn.AllowEdit = false;
      this.gcActivated.RowCount = 2;
      this.gcActivated.Width = 238;
      this.gcTu1.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTu1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTu1.Caption = "Từ";
      this.gcTu1.FieldName = "KLDT_Tu1";
      this.gcTu1.MinWidth = 750;
      this.gcTu1.Name = "gcTu1";
      this.gcTu1.Visible = true;
      this.gcTu1.Width = 7045;
      this.gcDen1.AppearanceHeader.Options.UseTextOptions = true;
      this.gcDen1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcDen1.Caption = "Đến";
      this.gcDen1.FieldName = "KLDT_Den1";
      this.gcDen1.MinWidth = 750;
      this.gcDen1.Name = "gcDen1";
      this.gcDen1.Visible = true;
      this.gcDen1.Width = 7045;
      this.gcDungTruoc1.Caption = "Dừng Trước";
      this.gcDungTruoc1.FieldName = "KLDT_DungTruoc1";
      this.gcDungTruoc1.MinWidth = 750;
      this.gcDungTruoc1.Name = "gcDungTruoc1";
      this.gcDungTruoc1.Visible = true;
      this.gcDungTruoc1.Width = 7045;
      this.gcTu2.Caption = "Từ 2";
      this.gcTu2.FieldName = "KLDT_Tu2";
      this.gcTu2.MinWidth = 750;
      this.gcTu2.Name = "gcTu2";
      this.gcTu2.Visible = true;
      this.gcTu2.Width = 7045;
      this.gcDen2.Caption = "Đến2";
      this.gcDen2.FieldName = "KLDT_Den2";
      this.gcDen2.MinWidth = 750;
      this.gcDen2.Name = "gcDen2";
      this.gcDen2.Visible = true;
      this.gcDen2.Width = 7045;
      this.gcDungTruoc2.Caption = "Dừng Trước2";
      this.gcDungTruoc2.FieldName = "KLDT_DungTruoc2";
      this.gcDungTruoc2.MinWidth = 750;
      this.gcDungTruoc2.Name = "gcDungTruoc2";
      this.gcDungTruoc2.Visible = true;
      this.gcDungTruoc2.Width = 7045;
      this.gcTu3.Caption = "Từ 3";
      this.gcTu3.FieldName = "KLDT_Tu3";
      this.gcTu3.MinWidth = 750;
      this.gcTu3.Name = "gcTu3";
      this.gcTu3.Visible = true;
      this.gcTu3.Width = 7045;
      this.gcDen3.Caption = "Đến 3";
      this.gcDen3.FieldName = "KLDT_Den3";
      this.gcDen3.MinWidth = 750;
      this.gcDen3.Name = "gcDen3";
      this.gcDen3.Visible = true;
      this.gcDen3.Width = 7045;
      this.gcDungTruoc3.Caption = "Dừng Trước";
      this.gcDungTruoc3.FieldName = "KLDT_DungTruoc3";
      this.gcDungTruoc3.MinWidth = 750;
      this.gcDungTruoc3.Name = "gcDungTruoc3";
      this.gcDungTruoc3.Visible = true;
      this.gcDungTruoc3.Width = 7045;
      this.repositoryItemButtonEdit1.AutoHeight = false;
      this.repositoryItemButtonEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton()
      });
      this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
      this.gridBand3.Caption = "Tên Gọi";
      this.gridBand3.Columns.Add(this.gcNhomSilo);
      this.gridBand3.Columns.Add(this.gcMaSilo);
      this.gridBand3.Columns.Add(this.gcTenSilo);
      this.gridBand3.Fixed = FixedStyle.Left;
      this.gridBand3.MinWidth = 277;
      this.gridBand3.Name = "gridBand3";
      this.gridBand3.OptionsBand.AllowMove = false;
      this.gridBand3.OptionsBand.ShowCaption = false;
      this.gridBand3.VisibleIndex = 0;
      this.gridBand3.Width = 324;
      this.grdBandThongSoSilo.Caption = "Thông Số Silo";
      this.grdBandThongSoSilo.Columns.Add(this.gcSaiSoDuoi);
      this.grdBandThongSoSilo.Columns.Add(this.gcSaiSoTren);
      this.grdBandThongSoSilo.Columns.Add(this.gcKLCanNhoNhat);
      this.grdBandThongSoSilo.Columns.Add(this.gcKLCanLonNhat);
      this.grdBandThongSoSilo.Columns.Add(this.gcTGNhapNhaOn);
      this.grdBandThongSoSilo.Columns.Add(this.gcTGNhapNhaOff);
      this.grdBandThongSoSilo.Columns.Add(this.gcTGKiemTraVatLieuRoi);
      this.grdBandThongSoSilo.Columns.Add(this.gcKLRoi);
      this.grdBandThongSoSilo.Columns.Add(this.gcKPulse);
      this.grdBandThongSoSilo.MinWidth = 480;
      this.grdBandThongSoSilo.Name = "grdBandThongSoSilo";
      this.grdBandThongSoSilo.VisibleIndex = 1;
      this.grdBandThongSoSilo.Width = 952;
      this.grdBandThongSoKhac.Caption = "Thông số khác";
      this.grdBandThongSoKhac.Columns.Add(this.gcSoTT);
      this.grdBandThongSoKhac.Columns.Add(this.gcActivated);
      this.grdBandThongSoKhac.MinWidth = 238;
      this.grdBandThongSoKhac.Name = "grdBandThongSoKhac";
      this.grdBandThongSoKhac.Visible = false;
      this.grdBandThongSoKhac.VisibleIndex = -1;
      this.grdBandThongSoKhac.Width = 238;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.grcMaster);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (SiloMngView);
      this.Size = new Size(848, 488);
      this.barManager1.EndInit();
      this.grcMaster.EndInit();
      this.grcMaster.ResumeLayout(false);
      this.grcSilo.EndInit();
      this.graSilo.EndInit();
      this.ilueNhomSilo.EndInit();
      this.repositoryItemButtonEdit1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

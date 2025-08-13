// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.SiloDoAmMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data.Filtering;
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class SiloDoAmMngView : ControlViewBase, ISiloDoAmMngView, IBase, IPermission
  {
    private SiloDoAmMngDataPresenter _presenter;
    private BindingList<ObjSilo> _blstSiloDoAm = new BindingList<ObjSilo>();
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private IContainer components;
    private BarManager barManager1;
    private Bar bar2;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarStaticItem bsiCaption;
    private BarButtonItem bbiSave;
    private BarButtonItem bbiRefresh;
    private GroupControl grcMaster;
    private GridControl grcData;
    private GridView grvData;
    private GridColumn gcMaSilo;
    private GridColumn gcTenSilo;
    private GridColumn gcTinhDoHutNuoc;
    private RepositoryItemButtonEdit ibtnTinhDoHutNuoc;
    private GridColumn gcDoHutNuoc;
    private RepositoryItemSpinEdit spnDoHutNuoc;
    private GridColumn gcDoAm;
    private RepositoryItemSpinEdit ispnDoAm;
    private GridColumn gcSoiTrongCat;
    private RepositoryItemSpinEdit ispnSoiTrongCat;
    private GridColumn gcSoiTrongCat_TruVaoSilo;
    private RepositoryItemLookUpEdit ilueSoiTrongCat_TruVaoSilo;

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public SiloDoAmMngView()
    {
      this.InitializeComponent();
      this._presenter = new SiloDoAmMngDataPresenter((ISiloDoAmMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjSilo> BLstSiloDoAm
    {
      set
      {
        this._blstSiloDoAm = value;
        this.grcData.DataSource = (object) this._blstSiloDoAm;
        this.ilueSoiTrongCat_TruVaoSilo.DataSource = (object) this._blstSiloDoAm;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void InitLayout()
    {
      this.grvData.ActiveFilterCriteria = (CriteriaOperator) new BinaryOperator("MarkAsDeleted", false);
    }

    protected override void PopulateData() => this._presenter.ListSiloDoAm();

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessProceed);
    }

    private void ibtnTinhDoHutNuoc_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Kind == ButtonPredefines.Ellipsis)
      {
        TinhDoHutNuocMngView ctrView = new TinhDoHutNuocMngView();
        ctrView.ShowGroupStatus = true;
        ViewManager.ShowViewDialog((ControlViewBase) ctrView);
        if (!ctrView.Choosed || ctrView.SelectedTinhDoHutNuoc == null)
          return;
        ObjSilo row = this.grvData.GetRow(this.grvData.FocusedRowHandle) as ObjSilo;
        row.TinhDoHutNuocName = ctrView.SelectedTinhDoHutNuoc.Name;
        row.TinhDoHutNuocID = new int?(ctrView.SelectedTinhDoHutNuoc.TinhDoHutNuocID);
        row.DoHutNuoc_NhomSiloAgg = new Decimal?(ctrView.SelectedTinhDoHutNuoc.DoHutNuoc);
        this.grvData.RefreshRow(this.grvData.FocusedRowHandle);
      }
      else
      {
        if (e.Button.Kind != ButtonPredefines.Delete || TramTromMessageBox.ShowYesNoDialog("Không sử dụng công thức tính độ hút nước?") != DialogResult.Yes)
          return;
        ObjSilo row = this.grvData.GetRow(this.grvData.FocusedRowHandle) as ObjSilo;
        row.TinhDoHutNuocName = (string) null;
        row.TinhDoHutNuocID = new int?();
        row.DoHutNuoc_NhomSiloAgg = new Decimal?(0M);
        this.grvData.RefreshRow(this.grvData.FocusedRowHandle);
      }
    }

    private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.grvData.PostEditor();
      this._presenter.SaveSiloDoAm(this._blstSiloDoAm);
    }

    private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
    {
      this._presenter.ListSiloDoAm();
    }

    private void BindPermission()
    {
      this.bbiSave.Enabled = this.CheckHasPermission(this.bbiSave.Name);
      this.bbiRefresh.Enabled = this.CheckHasPermission(this.bbiRefresh.Name);
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
      this.bbiSave = new BarButtonItem();
      this.bbiRefresh = new BarButtonItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.grcMaster = new GroupControl();
      this.grcData = new GridControl();
      this.grvData = new GridView();
      this.gcMaSilo = new GridColumn();
      this.gcTenSilo = new GridColumn();
      this.gcTinhDoHutNuoc = new GridColumn();
      this.ibtnTinhDoHutNuoc = new RepositoryItemButtonEdit();
      this.gcDoHutNuoc = new GridColumn();
      this.spnDoHutNuoc = new RepositoryItemSpinEdit();
      this.gcDoAm = new GridColumn();
      this.ispnDoAm = new RepositoryItemSpinEdit();
      this.gcSoiTrongCat = new GridColumn();
      this.ispnSoiTrongCat = new RepositoryItemSpinEdit();
      this.gcSoiTrongCat_TruVaoSilo = new GridColumn();
      this.ilueSoiTrongCat_TruVaoSilo = new RepositoryItemLookUpEdit();
      this.barManager1.BeginInit();
      this.grcMaster.BeginInit();
      this.grcMaster.SuspendLayout();
      this.grcData.BeginInit();
      this.grvData.BeginInit();
      this.ibtnTinhDoHutNuoc.BeginInit();
      this.spnDoHutNuoc.BeginInit();
      this.ispnDoAm.BeginInit();
      this.ispnSoiTrongCat.BeginInit();
      this.ilueSoiTrongCat_TruVaoSilo.BeginInit();
      this.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[1]{ this.bar2 });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barManager1.Items.AddRange(new BarItem[3]
      {
        (BarItem) this.bsiCaption,
        (BarItem) this.bbiSave,
        (BarItem) this.bbiRefresh
      });
      this.barManager1.MainMenu = this.bar2;
      this.barManager1.MaxItemId = 3;
      this.bar2.BarName = "Main menu";
      this.bar2.DockCol = 0;
      this.bar2.DockRow = 0;
      this.bar2.DockStyle = BarDockStyle.Top;
      this.bar2.LinksPersistInfo.AddRange(new LinkPersistInfo[3]
      {
        new LinkPersistInfo((BarItem) this.bsiCaption),
        new LinkPersistInfo((BarItem) this.bbiSave),
        new LinkPersistInfo((BarItem) this.bbiRefresh)
      });
      this.bar2.OptionsBar.MultiLine = true;
      this.bar2.OptionsBar.UseWholeRow = true;
      this.bar2.Text = "Main menu";
      this.bsiCaption.Caption = "Độ hút nước";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiSave.Caption = "Lưu";
      this.bbiSave.Id = 1;
      this.bbiSave.ImageOptions.Image = (Image) ResourceNhua.save_file;
      this.bbiSave.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiSave.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiSave.Name = "bbiSave";
      this.bbiSave.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiSave.ItemClick += new ItemClickEventHandler(this.bbiSave_ItemClick);
      this.bbiRefresh.Caption = "Làm mới";
      this.bbiRefresh.Id = 2;
      this.bbiRefresh.ImageOptions.Image = (Image) ResourceNhua.refresh_file;
      this.bbiRefresh.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiRefresh.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiRefresh.Name = "bbiRefresh";
      this.bbiRefresh.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiRefresh.ItemClick += new ItemClickEventHandler(this.bbiRefresh_ItemClick);
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
      this.grcMaster.Controls.Add((Control) this.grcData);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(848, 448);
      this.grcMaster.TabIndex = 4;
      this.grcMaster.Text = "Dữ liệu";
      this.grcData.Dock = DockStyle.Fill;
      this.grcData.EmbeddedNavigator.Margin = new Padding(2);
      this.grcData.Location = new Point(2, 23);
      this.grcData.MainView = (BaseView) this.grvData;
      this.grcData.Margin = new Padding(2);
      this.grcData.MenuManager = (IDXMenuManager) this.barManager1;
      this.grcData.Name = "grcData";
      this.grcData.RepositoryItems.AddRange(new RepositoryItem[5]
      {
        (RepositoryItem) this.ibtnTinhDoHutNuoc,
        (RepositoryItem) this.ilueSoiTrongCat_TruVaoSilo,
        (RepositoryItem) this.ispnSoiTrongCat,
        (RepositoryItem) this.spnDoHutNuoc,
        (RepositoryItem) this.ispnDoAm
      });
      this.grcData.Size = new Size(844, 423);
      this.grcData.TabIndex = 0;
      this.grcData.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvData
      });
      this.grvData.Columns.AddRange(new GridColumn[7]
      {
        this.gcMaSilo,
        this.gcTenSilo,
        this.gcTinhDoHutNuoc,
        this.gcDoHutNuoc,
        this.gcDoAm,
        this.gcSoiTrongCat,
        this.gcSoiTrongCat_TruVaoSilo
      });
      this.grvData.DetailHeight = 284;
      this.grvData.GridControl = this.grcData;
      this.grvData.Name = "grvData";
      this.gcMaSilo.Caption = "Mã Silo";
      this.gcMaSilo.FieldName = "MaSilo";
      this.gcMaSilo.MinWidth = 22;
      this.gcMaSilo.Name = "gcMaSilo";
      this.gcMaSilo.OptionsColumn.ReadOnly = true;
      this.gcMaSilo.Visible = true;
      this.gcMaSilo.VisibleIndex = 0;
      this.gcMaSilo.Width = 80;
      this.gcTenSilo.Caption = "Tên Silo";
      this.gcTenSilo.FieldName = "TenSilo";
      this.gcTenSilo.MinWidth = 22;
      this.gcTenSilo.Name = "gcTenSilo";
      this.gcTenSilo.OptionsColumn.ReadOnly = true;
      this.gcTenSilo.Visible = true;
      this.gcTenSilo.VisibleIndex = 1;
      this.gcTenSilo.Width = 80;
      this.gcTinhDoHutNuoc.Caption = "Công Thức Độ Hút Nước";
      this.gcTinhDoHutNuoc.ColumnEdit = (RepositoryItem) this.ibtnTinhDoHutNuoc;
      this.gcTinhDoHutNuoc.FieldName = "TinhDoHutNuocName";
      this.gcTinhDoHutNuoc.MinWidth = 22;
      this.gcTinhDoHutNuoc.Name = "gcTinhDoHutNuoc";
      this.gcTinhDoHutNuoc.Visible = true;
      this.gcTinhDoHutNuoc.VisibleIndex = 2;
      this.gcTinhDoHutNuoc.Width = 80;
      this.ibtnTinhDoHutNuoc.AutoHeight = false;
      this.ibtnTinhDoHutNuoc.Buttons.AddRange(new EditorButton[2]
      {
        new EditorButton(),
        new EditorButton(ButtonPredefines.Delete)
      });
      this.ibtnTinhDoHutNuoc.Name = "ibtnTinhDoHutNuoc";
      this.ibtnTinhDoHutNuoc.NullText = "Không có";
      this.ibtnTinhDoHutNuoc.ReadOnly = true;
      this.ibtnTinhDoHutNuoc.ButtonPressed += new ButtonPressedEventHandler(this.ibtnTinhDoHutNuoc_ButtonPressed);
      this.gcDoHutNuoc.Caption = "Độ Hút Nước";
      this.gcDoHutNuoc.ColumnEdit = (RepositoryItem) this.spnDoHutNuoc;
      this.gcDoHutNuoc.DisplayFormat.FormatString = "n2";
      this.gcDoHutNuoc.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcDoHutNuoc.FieldName = "DoHutNuoc_NhomSiloAgg";
      this.gcDoHutNuoc.MinWidth = 22;
      this.gcDoHutNuoc.Name = "gcDoHutNuoc";
      this.gcDoHutNuoc.OptionsColumn.ReadOnly = true;
      this.gcDoHutNuoc.Visible = true;
      this.gcDoHutNuoc.VisibleIndex = 3;
      this.gcDoHutNuoc.Width = 80;
      this.spnDoHutNuoc.AutoHeight = false;
      this.spnDoHutNuoc.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnDoHutNuoc.DisplayFormat.FormatString = "n2";
      this.spnDoHutNuoc.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnDoHutNuoc.EditFormat.FormatString = "n2";
      this.spnDoHutNuoc.EditFormat.FormatType = FormatType.Numeric;
      this.spnDoHutNuoc.Name = "spnDoHutNuoc";
      this.gcDoAm.Caption = "Độ Ấm";
      this.gcDoAm.ColumnEdit = (RepositoryItem) this.ispnDoAm;
      this.gcDoAm.DisplayFormat.FormatString = "n2";
      this.gcDoAm.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcDoAm.FieldName = "DoAm_NhomSlioAgg";
      this.gcDoAm.MinWidth = 22;
      this.gcDoAm.Name = "gcDoAm";
      this.gcDoAm.OptionsColumn.ReadOnly = true;
      this.gcDoAm.Visible = true;
      this.gcDoAm.VisibleIndex = 4;
      this.gcDoAm.Width = 80;
      this.ispnDoAm.AutoHeight = false;
      this.ispnDoAm.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnDoAm.DisplayFormat.FormatString = "n2";
      this.ispnDoAm.DisplayFormat.FormatType = FormatType.Numeric;
      this.ispnDoAm.EditFormat.FormatString = "n2";
      this.ispnDoAm.EditFormat.FormatType = FormatType.Numeric;
      this.ispnDoAm.Name = "ispnDoAm";
      this.gcSoiTrongCat.Caption = "Sỏi Trong Cát (%)";
      this.gcSoiTrongCat.ColumnEdit = (RepositoryItem) this.ispnSoiTrongCat;
      this.gcSoiTrongCat.DisplayFormat.FormatString = "n2";
      this.gcSoiTrongCat.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcSoiTrongCat.FieldName = "SoiTrongCat_NhomSiloAgg";
      this.gcSoiTrongCat.MinWidth = 22;
      this.gcSoiTrongCat.Name = "gcSoiTrongCat";
      this.gcSoiTrongCat.Visible = true;
      this.gcSoiTrongCat.VisibleIndex = 5;
      this.gcSoiTrongCat.Width = 80;
      this.ispnSoiTrongCat.AutoHeight = false;
      this.ispnSoiTrongCat.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnSoiTrongCat.DisplayFormat.FormatString = "n2";
      this.ispnSoiTrongCat.DisplayFormat.FormatType = FormatType.Numeric;
      this.ispnSoiTrongCat.EditFormat.FormatString = "n2";
      this.ispnSoiTrongCat.EditFormat.FormatType = FormatType.Numeric;
      this.ispnSoiTrongCat.MaxValue = new Decimal(new int[4]
      {
        100,
        0,
        0,
        0
      });
      this.ispnSoiTrongCat.Name = "ispnSoiTrongCat";
      this.gcSoiTrongCat_TruVaoSilo.Caption = "Trừ Vào Silo";
      this.gcSoiTrongCat_TruVaoSilo.ColumnEdit = (RepositoryItem) this.ilueSoiTrongCat_TruVaoSilo;
      this.gcSoiTrongCat_TruVaoSilo.FieldName = "SoiTrongCat_TruVaoSilo_NhomSiloAgg";
      this.gcSoiTrongCat_TruVaoSilo.MinWidth = 22;
      this.gcSoiTrongCat_TruVaoSilo.Name = "gcSoiTrongCat_TruVaoSilo";
      this.gcSoiTrongCat_TruVaoSilo.Visible = true;
      this.gcSoiTrongCat_TruVaoSilo.VisibleIndex = 6;
      this.gcSoiTrongCat_TruVaoSilo.Width = 80;
      this.ilueSoiTrongCat_TruVaoSilo.AutoHeight = false;
      this.ilueSoiTrongCat_TruVaoSilo.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueSoiTrongCat_TruVaoSilo.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("MaSilo", "Mã Silo"),
        new LookUpColumnInfo("TenSilo", "Tên Silo")
      });
      this.ilueSoiTrongCat_TruVaoSilo.DisplayMember = "TenSilo";
      this.ilueSoiTrongCat_TruVaoSilo.Name = "ilueSoiTrongCat_TruVaoSilo";
      this.ilueSoiTrongCat_TruVaoSilo.NullText = "";
      this.ilueSoiTrongCat_TruVaoSilo.ValueMember = "SiloID";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.grcMaster);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (SiloDoAmMngView);
      this.Size = new Size(848, 488);
      this.barManager1.EndInit();
      this.grcMaster.EndInit();
      this.grcMaster.ResumeLayout(false);
      this.grcData.EndInit();
      this.grvData.EndInit();
      this.ibtnTinhDoHutNuoc.EndInit();
      this.spnDoHutNuoc.EndInit();
      this.ispnDoAm.EndInit();
      this.ispnSoiTrongCat.EndInit();
      this.ilueSoiTrongCat_TruVaoSilo.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

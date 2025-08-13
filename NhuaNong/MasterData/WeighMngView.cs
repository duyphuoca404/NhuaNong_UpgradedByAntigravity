// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.WeighMngView
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
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class WeighMngView : ControlViewBase, IWeighMngView, IBase, IPermission
  {
    private BindingList<ObjWeigh> _blstWeigh = new BindingList<ObjWeigh>();
    private WeighMngDataPresenter _presenter;
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private IContainer components;
    private BarManager barManager1;
    private Bar bar2;
    private BarStaticItem bsiCaption;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarButtonItem bbiSave;
    private BarButtonItem bbiRefresh;
    private GroupControl grpMaster;
    private GridControl grcData;
    private GridView grvData;
    private GridColumn gcWeighCode;
    private RepositoryItemTextEdit itxtWeigh;
    private GridColumn gcWeighName;
    private RepositoryItemTextEdit itxtWeighName;
    private GridColumn gcDesc;
    private RepositoryItemTextEdit itxtDesc;
    private GridColumn gcZero;
    private RepositoryItemSpinEdit ispnZero;
    private GridColumn gcMax;
    private RepositoryItemSpinEdit ispnMax;
    private GridColumn gcOffset;
    private RepositoryItemSpinEdit ispnOffset;
    private GridColumn gcKLEmpty;
    private RepositoryItemSpinEdit ispnKLEmpty;
    private GridColumn gcTimeEmpty;
    private RepositoryItemSpinEdit ispnTimeEmpty;
    private GridColumn gcLimit;
    private RepositoryItemSpinEdit ispnLimit;
    private GridColumn gcWeiToVib;
    private RepositoryItemSpinEdit ispnWeiToVib;
    private GridColumn gcTON;
    private RepositoryItemSpinEdit ispnTON;
    private GridColumn gcTOFF;
    private RepositoryItemSpinEdit ispnTOFF;
    private GridColumn gcSpare;
    private RepositoryItemSpinEdit ispnSpare;
    private GridColumn gcSTT;
    private RepositoryItemSpinEdit ispnSTT;
    private GridColumn gcMarkAsDeleted;
    private GridColumn gcTilexa;
    private RepositoryItemSpinEdit repositoryItemSpinEdit1;

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public WeighMngView()
    {
      this.InitializeComponent();
      this._presenter = new WeighMngDataPresenter((IWeighMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjWeigh> BLstWeigh
    {
      set
      {
        this._blstWeigh = value;
        this.grcData.DataSource = (object) this._blstWeigh;
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

    protected override void PopulateData() => this._presenter.ListWeigh();

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
        TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessSavingData);
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.ErrorSavingData);
    }

    private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.grvData.PostEditor();
      this._presenter.SaveWeigh(this._blstWeigh);
    }

    private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
    {
      this._presenter.ListWeigh();
    }

    private void grcData_ProcessGridKey(object sender, KeyEventArgs e)
    {
      if (!e.Control || e.KeyCode != Keys.Delete)
        return;
      foreach (int selectedRow in this.grvData.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjWeigh row = this.grvData.GetRow(selectedRow) as ObjWeigh;
          if (row.IsNewObject)
            this._blstWeigh.Remove(row);
          else
            row.MarkAsDeleted = true;
        }
      }
      this.grvData.RefreshData();
    }

    private void BindPermission()
    {
      this.bbiSave.Enabled = this._lstFunction.Where<ObjSEC_Function>((Func<ObjSEC_Function, bool>) (o => o.FunctionCode == "SaveWeigh")).FirstOrDefault<ObjSEC_Function>() != null;
      this.bbiRefresh.Enabled = this._lstFunction.Where<ObjSEC_Function>((Func<ObjSEC_Function, bool>) (o => o.FunctionCode == "RefreshWeigh")).FirstOrDefault<ObjSEC_Function>() != null;
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
      this.grpMaster = new GroupControl();
      this.grcData = new GridControl();
      this.grvData = new GridView();
      this.gcWeighCode = new GridColumn();
      this.itxtWeigh = new RepositoryItemTextEdit();
      this.gcWeighName = new GridColumn();
      this.itxtWeighName = new RepositoryItemTextEdit();
      this.gcDesc = new GridColumn();
      this.itxtDesc = new RepositoryItemTextEdit();
      this.gcZero = new GridColumn();
      this.ispnZero = new RepositoryItemSpinEdit();
      this.gcMax = new GridColumn();
      this.ispnMax = new RepositoryItemSpinEdit();
      this.gcOffset = new GridColumn();
      this.ispnOffset = new RepositoryItemSpinEdit();
      this.gcKLEmpty = new GridColumn();
      this.ispnKLEmpty = new RepositoryItemSpinEdit();
      this.gcTimeEmpty = new GridColumn();
      this.ispnTimeEmpty = new RepositoryItemSpinEdit();
      this.gcLimit = new GridColumn();
      this.ispnLimit = new RepositoryItemSpinEdit();
      this.gcWeiToVib = new GridColumn();
      this.ispnWeiToVib = new RepositoryItemSpinEdit();
      this.gcTON = new GridColumn();
      this.ispnTON = new RepositoryItemSpinEdit();
      this.gcTOFF = new GridColumn();
      this.ispnTOFF = new RepositoryItemSpinEdit();
      this.gcSpare = new GridColumn();
      this.ispnSpare = new RepositoryItemSpinEdit();
      this.gcSTT = new GridColumn();
      this.ispnSTT = new RepositoryItemSpinEdit();
      this.gcMarkAsDeleted = new GridColumn();
      this.gcTilexa = new GridColumn();
      this.repositoryItemSpinEdit1 = new RepositoryItemSpinEdit();
      this.barManager1.BeginInit();
      this.grpMaster.BeginInit();
      this.grpMaster.SuspendLayout();
      this.grcData.BeginInit();
      this.grvData.BeginInit();
      this.itxtWeigh.BeginInit();
      this.itxtWeighName.BeginInit();
      this.itxtDesc.BeginInit();
      this.ispnZero.BeginInit();
      this.ispnMax.BeginInit();
      this.ispnOffset.BeginInit();
      this.ispnKLEmpty.BeginInit();
      this.ispnTimeEmpty.BeginInit();
      this.ispnLimit.BeginInit();
      this.ispnWeiToVib.BeginInit();
      this.ispnTON.BeginInit();
      this.ispnTOFF.BeginInit();
      this.ispnSpare.BeginInit();
      this.ispnSTT.BeginInit();
      this.repositoryItemSpinEdit1.BeginInit();
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
      this.bsiCaption.Caption = "Thông số Cân";
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
      this.bbiRefresh.Caption = "Làm mơi";
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
      this.barDockControlTop.Size = new Size(772, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 488);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(2);
      this.barDockControlBottom.Size = new Size(772, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(2);
      this.barDockControlLeft.Size = new Size(0, 448);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(772, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(2);
      this.barDockControlRight.Size = new Size(0, 448);
      this.grpMaster.Controls.Add((Control) this.grcData);
      this.grpMaster.Dock = DockStyle.Fill;
      this.grpMaster.Location = new Point(0, 40);
      this.grpMaster.Margin = new Padding(2);
      this.grpMaster.Name = "grpMaster";
      this.grpMaster.Size = new Size(772, 448);
      this.grpMaster.TabIndex = 4;
      this.grpMaster.Text = "Dữ liệu";
      this.grcData.Dock = DockStyle.Fill;
      this.grcData.EmbeddedNavigator.Margin = new Padding(2);
      this.grcData.Location = new Point(2, 23);
      this.grcData.MainView = (BaseView) this.grvData;
      this.grcData.Margin = new Padding(2);
      this.grcData.MenuManager = (IDXMenuManager) this.barManager1;
      this.grcData.Name = "grcData";
      this.grcData.RepositoryItems.AddRange(new RepositoryItem[15]
      {
        (RepositoryItem) this.itxtWeigh,
        (RepositoryItem) this.itxtWeighName,
        (RepositoryItem) this.itxtDesc,
        (RepositoryItem) this.ispnZero,
        (RepositoryItem) this.ispnMax,
        (RepositoryItem) this.ispnOffset,
        (RepositoryItem) this.ispnKLEmpty,
        (RepositoryItem) this.ispnTimeEmpty,
        (RepositoryItem) this.ispnLimit,
        (RepositoryItem) this.ispnWeiToVib,
        (RepositoryItem) this.ispnTON,
        (RepositoryItem) this.ispnTOFF,
        (RepositoryItem) this.ispnSpare,
        (RepositoryItem) this.ispnSTT,
        (RepositoryItem) this.repositoryItemSpinEdit1
      });
      this.grcData.Size = new Size(768, 423);
      this.grcData.TabIndex = 0;
      this.grcData.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvData
      });
      this.grcData.ProcessGridKey += new KeyEventHandler(this.grcData_ProcessGridKey);
      this.grvData.Columns.AddRange(new GridColumn[16]
      {
        this.gcWeighCode,
        this.gcWeighName,
        this.gcDesc,
        this.gcZero,
        this.gcMax,
        this.gcOffset,
        this.gcKLEmpty,
        this.gcTimeEmpty,
        this.gcLimit,
        this.gcWeiToVib,
        this.gcTON,
        this.gcTOFF,
        this.gcSpare,
        this.gcSTT,
        this.gcMarkAsDeleted,
        this.gcTilexa
      });
      this.grvData.DetailHeight = 284;
      this.grvData.GridControl = this.grcData;
      this.grvData.Name = "grvData";
      this.grvData.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.grvData.OptionsView.ShowFooter = true;
      this.gcWeighCode.Caption = "Mã";
      this.gcWeighCode.ColumnEdit = (RepositoryItem) this.itxtWeigh;
      this.gcWeighCode.FieldName = "WeighCode";
      this.gcWeighCode.MinWidth = 22;
      this.gcWeighCode.Name = "gcWeighCode";
      this.gcWeighCode.OptionsColumn.AllowEdit = false;
      this.gcWeighCode.OptionsColumn.AllowMove = false;
      this.gcWeighCode.Visible = true;
      this.gcWeighCode.VisibleIndex = 0;
      this.gcWeighCode.Width = 80;
      this.itxtWeigh.AutoHeight = false;
      this.itxtWeigh.Name = "itxtWeigh";
      this.gcWeighName.Caption = "Tên";
      this.gcWeighName.ColumnEdit = (RepositoryItem) this.itxtWeighName;
      this.gcWeighName.FieldName = "WeighName";
      this.gcWeighName.MinWidth = 22;
      this.gcWeighName.Name = "gcWeighName";
      this.gcWeighName.Visible = true;
      this.gcWeighName.VisibleIndex = 1;
      this.gcWeighName.Width = 80;
      this.itxtWeighName.AutoHeight = false;
      this.itxtWeighName.Name = "itxtWeighName";
      this.gcDesc.Caption = "Mô tả";
      this.gcDesc.ColumnEdit = (RepositoryItem) this.itxtDesc;
      this.gcDesc.FieldName = "Description";
      this.gcDesc.MinWidth = 22;
      this.gcDesc.Name = "gcDesc";
      this.gcDesc.Width = 80;
      this.itxtDesc.AutoHeight = false;
      this.itxtDesc.Name = "itxtDesc";
      this.gcZero.Caption = "TG Trễ Cân";
      this.gcZero.ColumnEdit = (RepositoryItem) this.ispnZero;
      this.gcZero.FieldName = "Zero";
      this.gcZero.MinWidth = 22;
      this.gcZero.Name = "gcZero";
      this.gcZero.Width = 80;
      this.ispnZero.AutoHeight = false;
      this.ispnZero.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnZero.DisplayFormat.FormatString = "n2";
      this.ispnZero.DisplayFormat.FormatType = FormatType.Numeric;
      this.ispnZero.EditFormat.FormatString = "n2";
      this.ispnZero.EditFormat.FormatType = FormatType.Numeric;
      this.ispnZero.Mask.EditMask = "n2";
      this.ispnZero.Name = "ispnZero";
      this.gcMax.Caption = "TG Trễ Xả";
      this.gcMax.ColumnEdit = (RepositoryItem) this.ispnMax;
      this.gcMax.FieldName = "Max";
      this.gcMax.MinWidth = 22;
      this.gcMax.Name = "gcMax";
      this.gcMax.Visible = true;
      this.gcMax.VisibleIndex = 8;
      this.gcMax.Width = 80;
      this.ispnMax.AutoHeight = false;
      this.ispnMax.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnMax.Name = "ispnMax";
      this.gcOffset.Caption = "TG Trễ Đóng";
      this.gcOffset.ColumnEdit = (RepositoryItem) this.ispnOffset;
      this.gcOffset.FieldName = "Offset";
      this.gcOffset.MinWidth = 22;
      this.gcOffset.Name = "gcOffset";
      this.gcOffset.Visible = true;
      this.gcOffset.VisibleIndex = 7;
      this.gcOffset.Width = 80;
      this.ispnOffset.AutoHeight = false;
      this.ispnOffset.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnOffset.Name = "ispnOffset";
      this.gcKLEmpty.Caption = "KL Báo Cân Rỗng";
      this.gcKLEmpty.ColumnEdit = (RepositoryItem) this.ispnKLEmpty;
      this.gcKLEmpty.FieldName = "KLEmpty";
      this.gcKLEmpty.MinWidth = 22;
      this.gcKLEmpty.Name = "gcKLEmpty";
      this.gcKLEmpty.Visible = true;
      this.gcKLEmpty.VisibleIndex = 2;
      this.gcKLEmpty.Width = 80;
      this.ispnKLEmpty.AutoHeight = false;
      this.ispnKLEmpty.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnKLEmpty.Name = "ispnKLEmpty";
      this.gcTimeEmpty.Caption = "Thời Gian Ổn Định Cân";
      this.gcTimeEmpty.ColumnEdit = (RepositoryItem) this.ispnTimeEmpty;
      this.gcTimeEmpty.FieldName = "TimeEmpty";
      this.gcTimeEmpty.MinWidth = 22;
      this.gcTimeEmpty.Name = "gcTimeEmpty";
      this.gcTimeEmpty.Visible = true;
      this.gcTimeEmpty.VisibleIndex = 3;
      this.gcTimeEmpty.Width = 80;
      this.ispnTimeEmpty.AutoHeight = false;
      this.ispnTimeEmpty.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnTimeEmpty.Name = "ispnTimeEmpty";
      this.gcLimit.Caption = "Limit";
      this.gcLimit.ColumnEdit = (RepositoryItem) this.ispnLimit;
      this.gcLimit.FieldName = "Limit";
      this.gcLimit.MinWidth = 22;
      this.gcLimit.Name = "gcLimit";
      this.gcLimit.Width = 80;
      this.ispnLimit.AutoHeight = false;
      this.ispnLimit.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnLimit.Name = "ispnLimit";
      this.gcWeiToVib.Caption = "KL Rung Cân";
      this.gcWeiToVib.ColumnEdit = (RepositoryItem) this.ispnWeiToVib;
      this.gcWeiToVib.FieldName = "WeiToVib";
      this.gcWeiToVib.MinWidth = 22;
      this.gcWeiToVib.Name = "gcWeiToVib";
      this.gcWeiToVib.Visible = true;
      this.gcWeiToVib.VisibleIndex = 4;
      this.gcWeiToVib.Width = 80;
      this.ispnWeiToVib.AutoHeight = false;
      this.ispnWeiToVib.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnWeiToVib.Name = "ispnWeiToVib";
      this.gcTON.Caption = "T ON";
      this.gcTON.ColumnEdit = (RepositoryItem) this.ispnTON;
      this.gcTON.FieldName = "TON";
      this.gcTON.MinWidth = 22;
      this.gcTON.Name = "gcTON";
      this.gcTON.Visible = true;
      this.gcTON.VisibleIndex = 5;
      this.gcTON.Width = 80;
      this.ispnTON.AutoHeight = false;
      this.ispnTON.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnTON.Name = "ispnTON";
      this.gcTOFF.Caption = "T OFF";
      this.gcTOFF.ColumnEdit = (RepositoryItem) this.ispnTOFF;
      this.gcTOFF.FieldName = "TOFF";
      this.gcTOFF.MinWidth = 22;
      this.gcTOFF.Name = "gcTOFF";
      this.gcTOFF.Visible = true;
      this.gcTOFF.VisibleIndex = 6;
      this.gcTOFF.Width = 80;
      this.ispnTOFF.AutoHeight = false;
      this.ispnTOFF.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnTOFF.Name = "ispnTOFF";
      this.gcSpare.Caption = "Spare";
      this.gcSpare.ColumnEdit = (RepositoryItem) this.ispnSpare;
      this.gcSpare.FieldName = "Spare";
      this.gcSpare.MinWidth = 22;
      this.gcSpare.Name = "gcSpare";
      this.gcSpare.Width = 80;
      this.ispnSpare.AutoHeight = false;
      this.ispnSpare.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnSpare.Name = "ispnSpare";
      this.gcSTT.Caption = "Số TT";
      this.gcSTT.ColumnEdit = (RepositoryItem) this.ispnSTT;
      this.gcSTT.FieldName = "STT";
      this.gcSTT.MinWidth = 22;
      this.gcSTT.Name = "gcSTT";
      this.gcSTT.Width = 80;
      this.ispnSTT.AutoHeight = false;
      this.ispnSTT.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnSTT.Name = "ispnSTT";
      this.gcMarkAsDeleted.Caption = "Mark As Deleted";
      this.gcMarkAsDeleted.FieldName = "MarkAsDeleted";
      this.gcMarkAsDeleted.MinWidth = 22;
      this.gcMarkAsDeleted.Name = "gcMarkAsDeleted";
      this.gcMarkAsDeleted.Width = 80;
      this.gcTilexa.Caption = "Tỷ lệ xả";
      this.gcTilexa.ColumnEdit = (RepositoryItem) this.repositoryItemSpinEdit1;
      this.gcTilexa.FieldName = "TiLeXa";
      this.gcTilexa.MinWidth = 22;
      this.gcTilexa.Name = "gcTilexa";
      this.gcTilexa.Width = 80;
      this.repositoryItemSpinEdit1.AutoHeight = false;
      this.repositoryItemSpinEdit1.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.grpMaster);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (WeighMngView);
      this.Size = new Size(772, 488);
      this.barManager1.EndInit();
      this.grpMaster.EndInit();
      this.grpMaster.ResumeLayout(false);
      this.grcData.EndInit();
      this.grvData.EndInit();
      this.itxtWeigh.EndInit();
      this.itxtWeighName.EndInit();
      this.itxtDesc.EndInit();
      this.ispnZero.EndInit();
      this.ispnMax.EndInit();
      this.ispnOffset.EndInit();
      this.ispnKLEmpty.EndInit();
      this.ispnTimeEmpty.EndInit();
      this.ispnLimit.EndInit();
      this.ispnWeiToVib.EndInit();
      this.ispnTON.EndInit();
      this.ispnTOFF.EndInit();
      this.ispnSpare.EndInit();
      this.ispnSTT.EndInit();
      this.repositoryItemSpinEdit1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

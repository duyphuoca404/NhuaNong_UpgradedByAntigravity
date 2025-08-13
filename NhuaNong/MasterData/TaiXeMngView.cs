// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.TaiXeMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
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
  public class TaiXeMngView : ControlViewBase, ITaiXeMngView, IBase, IPermission
  {
    private TaiXeMngDataPresenter _presenter;
    private BindingList<ObjTaiXe> _blstTaiXe = new BindingList<ObjTaiXe>();
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
    private GroupControl grcSearch;
    private GroupControl grcMaster;
    private SimpleButton btnReset;
    private LabelControl lblPhone;
    private LabelControl lblActive;
    private LabelControl lblTenTaiXe;
    private Label lblMaTaiXe;
    private Label lblToDate;
    private SimpleButton btnSearch;
    private LookUpEdit lueActive;
    private TextEdit txtPhone;
    private TextEdit txtTenTX;
    private TextEdit txtMaTX;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl lblFromDate;
    private GridControl grcTaiXe;
    private GridView grvTaiXe;
    private GridColumn gcMaTaiXe;
    private GridColumn gcTenTaiXe;
    private GridColumn gcPhone;
    private GridColumn gcGhiChu;
    private GridColumn gcActivated;

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public TaiXeMngView()
    {
      this.InitializeComponent();
      this._presenter = new TaiXeMngDataPresenter((ITaiXeMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjTaiXe> BLstTaiXe
    {
      set
      {
        this._blstTaiXe = value;
        this.grcTaiXe.DataSource = (object) this._blstTaiXe;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void PopulateStaticData()
    {
      this.lueActive.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.ActiveEnum>(true);
      this.LoadSearchDefaultValues();
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
        this.LoadTaiXe();
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.UnsuccessProceed);
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) null;
      this.datToDate.EditValue = (object) Searching.Build_EndDateTime(DateTime.Now);
      this.txtMaTX.Text = this.txtTenTX.Text = this.txtPhone.Text = string.Empty;
      this.lueActive.EditValue = (object) -1;
    }

    private void LoadTaiXe()
    {
      try
      {
        SplashScreenManager.ShowForm(typeof (NDPWaitForm));
        SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.WAIT_CAPTION);
        SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
        if (Convert.ToInt32(this.lueActive.EditValue) != 1)
          Convert.ToInt32(this.lueActive.EditValue);
        this._presenter.ListTaiXe_ByCondition(new DateTime?(this.datFromDate.DateTime), new DateTime?(this.datToDate.DateTime), this.txtMaTX.Text, this.txtTenTX.Text, this.txtPhone.Text, new bool?(true));
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowDEPErrorDialog(ex);
        TramTronLogger.WriteError(ex);
      }
      finally
      {
        SplashScreenManager.CloseForm();
      }
    }

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadTaiXe();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewTaiXeView ctrView = new NewTaiXeView((ObjTaiXe) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadTaiXe();
      this.FocusRow(this.grvTaiXe, this.grvTaiXe.RowCount);
    }

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvTaiXe.RowCount == 0)
        return;
      int focusedRowHandle = this.grvTaiXe.FocusedRowHandle;
      NewTaiXeView ctrView = new NewTaiXeView(this.grvTaiXe.GetRow(focusedRowHandle) as ObjTaiXe, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadTaiXe();
      this.FocusRow(this.grvTaiXe, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (TramTromMessageBox.ShowYesNoDialog(GlobalValues.Messages.ConfirmDeleteSelectedData) != DialogResult.Yes)
        return;
      BindingList<ObjTaiXe> blstCT = new BindingList<ObjTaiXe>();
      foreach (int selectedRow in this.grvTaiXe.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjTaiXe row = this.grvTaiXe.GetRow(selectedRow) as ObjTaiXe;
          row.Activated = false;
          blstCT.Add(row);
          this.LoadTaiXe();
        }
      }
      this._presenter.SaveTaiXe(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvTaiXe.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewTaiXeView(this.grvTaiXe.GetRow(this.grvTaiXe.FocusedRowHandle) as ObjTaiXe, Enums.FormAction.View));
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
      this.grcSearch = new GroupControl();
      this.btnReset = new SimpleButton();
      this.lblPhone = new LabelControl();
      this.lblActive = new LabelControl();
      this.lblTenTaiXe = new LabelControl();
      this.lblMaTaiXe = new Label();
      this.lblToDate = new Label();
      this.btnSearch = new SimpleButton();
      this.lueActive = new LookUpEdit();
      this.txtPhone = new TextEdit();
      this.txtTenTX = new TextEdit();
      this.txtMaTX = new TextEdit();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.lblFromDate = new LabelControl();
      this.grcMaster = new GroupControl();
      this.grcTaiXe = new GridControl();
      this.grvTaiXe = new GridView();
      this.gcMaTaiXe = new GridColumn();
      this.gcTenTaiXe = new GridColumn();
      this.gcPhone = new GridColumn();
      this.gcGhiChu = new GridColumn();
      this.gcActivated = new GridColumn();
      this.barManager1.BeginInit();
      this.grcSearch.BeginInit();
      this.grcSearch.SuspendLayout();
      this.lueActive.Properties.BeginInit();
      this.txtPhone.Properties.BeginInit();
      this.txtTenTX.Properties.BeginInit();
      this.txtMaTX.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.grcMaster.BeginInit();
      this.grcMaster.SuspendLayout();
      this.grcTaiXe.BeginInit();
      this.grvTaiXe.BeginInit();
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
      this.bsiCaption.Caption = "Tài xế";
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
      this.grcSearch.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grcSearch.AppearanceCaption.Options.UseFont = true;
      this.grcSearch.Controls.Add((Control) this.btnReset);
      this.grcSearch.Controls.Add((Control) this.lblPhone);
      this.grcSearch.Controls.Add((Control) this.lblActive);
      this.grcSearch.Controls.Add((Control) this.lblTenTaiXe);
      this.grcSearch.Controls.Add((Control) this.lblMaTaiXe);
      this.grcSearch.Controls.Add((Control) this.lblToDate);
      this.grcSearch.Controls.Add((Control) this.btnSearch);
      this.grcSearch.Controls.Add((Control) this.lueActive);
      this.grcSearch.Controls.Add((Control) this.txtPhone);
      this.grcSearch.Controls.Add((Control) this.txtTenTX);
      this.grcSearch.Controls.Add((Control) this.txtMaTX);
      this.grcSearch.Controls.Add((Control) this.datToDate);
      this.grcSearch.Controls.Add((Control) this.datFromDate);
      this.grcSearch.Controls.Add((Control) this.lblFromDate);
      this.grcSearch.Dock = DockStyle.Right;
      this.grcSearch.Location = new Point(568, 40);
      this.grcSearch.Margin = new Padding(2);
      this.grcSearch.Name = "grcSearch";
      this.grcSearch.Size = new Size(280, 448);
      this.grcSearch.TabIndex = 4;
      this.grcSearch.Text = "Tìm kiếm";
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(13, 215);
      this.btnReset.Margin = new Padding(2);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(105, 35);
      this.btnReset.TabIndex = 107;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.lblPhone.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Location = new Point(13, 168);
      this.lblPhone.Margin = new Padding(2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(75, 16);
      this.lblPhone.TabIndex = 106;
      this.lblPhone.Text = "Số điện thoại";
      this.lblActive.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblActive.Appearance.Options.UseFont = true;
      this.lblActive.Location = new Point(24, 278);
      this.lblActive.Margin = new Padding(2);
      this.lblActive.Name = "lblActive";
      this.lblActive.Size = new Size(59, 16);
      this.lblActive.TabIndex = 105;
      this.lblActive.Text = "Trạng thái";
      this.lblActive.Visible = false;
      this.lblTenTaiXe.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenTaiXe.Appearance.Options.UseFont = true;
      this.lblTenTaiXe.Location = new Point(13, 138);
      this.lblTenTaiXe.Margin = new Padding(2);
      this.lblTenTaiXe.Name = "lblTenTaiXe";
      this.lblTenTaiXe.Size = new Size(57, 16);
      this.lblTenTaiXe.TabIndex = 103;
      this.lblTenTaiXe.Text = "Tên tài xế";
      this.lblMaTaiXe.AutoSize = true;
      this.lblMaTaiXe.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaTaiXe.Location = new Point(10, 108);
      this.lblMaTaiXe.Margin = new Padding(2, 0, 2, 0);
      this.lblMaTaiXe.Name = "lblMaTaiXe";
      this.lblMaTaiXe.Size = new Size(60, 16);
      this.lblMaTaiXe.TabIndex = 102;
      this.lblMaTaiXe.Text = "Mã tài xế";
      this.lblToDate.AutoSize = true;
      this.lblToDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblToDate.Location = new Point(10, 78);
      this.lblToDate.Margin = new Padding(2, 0, 2, 0);
      this.lblToDate.Name = "lblToDate";
      this.lblToDate.Size = new Size(62, 16);
      this.lblToDate.TabIndex = 101;
      this.lblToDate.Text = "Đến ngày";
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(157, 215);
      this.btnSearch.Margin = new Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(105, 35);
      this.btnSearch.TabIndex = 100;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
      this.lueActive.Location = new Point(112, 275);
      this.lueActive.Margin = new Padding(2);
      this.lueActive.MenuManager = (IDXMenuManager) this.barManager1;
      this.lueActive.Name = "lueActive";
      this.lueActive.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueActive.Properties.Appearance.Options.UseFont = true;
      this.lueActive.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueActive.Properties.Columns.AddRange(new LookUpColumnInfo[1]
      {
        new LookUpColumnInfo("DisplayText", "Trạng thái", 40, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.lueActive.Properties.DisplayMember = "DisplayText";
      this.lueActive.Properties.NullText = "";
      this.lueActive.Properties.ValueMember = "ID";
      this.lueActive.Size = new Size(150, 22);
      this.lueActive.TabIndex = 99;
      this.lueActive.Visible = false;
      this.txtPhone.Location = new Point(112, 165);
      this.txtPhone.Margin = new Padding(2);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPhone.Properties.Appearance.Options.UseFont = true;
      this.txtPhone.Properties.Name = "txtPhone";
      this.txtPhone.Size = new Size(150, 22);
      this.txtPhone.TabIndex = 98;
      this.txtTenTX.Location = new Point(112, 135);
      this.txtTenTX.Margin = new Padding(2);
      this.txtTenTX.Name = "txtTenTX";
      this.txtTenTX.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenTX.Properties.Appearance.Options.UseFont = true;
      this.txtTenTX.Size = new Size(150, 22);
      this.txtTenTX.TabIndex = 96;
      this.txtMaTX.Location = new Point(112, 105);
      this.txtMaTX.Margin = new Padding(2);
      this.txtMaTX.Name = "txtMaTX";
      this.txtMaTX.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaTX.Properties.Appearance.Options.UseFont = true;
      this.txtMaTX.Size = new Size(150, 22);
      this.txtMaTX.TabIndex = 95;
      this.datToDate.EditValue = (object) null;
      this.datToDate.Location = new Point(112, 75);
      this.datToDate.Margin = new Padding(2);
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
      this.datToDate.TabIndex = 94;
      this.datFromDate.EditValue = (object) null;
      this.datFromDate.Location = new Point(112, 45);
      this.datFromDate.Margin = new Padding(2);
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
      this.datFromDate.TabIndex = 93;
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(13, 48);
      this.lblFromDate.Margin = new Padding(2);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(73, 16);
      this.lblFromDate.TabIndex = 92;
      this.lblFromDate.Text = "Tạo Từ ngày";
      this.grcMaster.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grcMaster.AppearanceCaption.Options.UseFont = true;
      this.grcMaster.Controls.Add((Control) this.grcTaiXe);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(568, 448);
      this.grcMaster.TabIndex = 5;
      this.grcMaster.Text = "Dữ liệu";
      this.grcTaiXe.Dock = DockStyle.Fill;
      this.grcTaiXe.EmbeddedNavigator.Margin = new Padding(2);
      this.grcTaiXe.Location = new Point(2, 23);
      this.grcTaiXe.MainView = (BaseView) this.grvTaiXe;
      this.grcTaiXe.Margin = new Padding(2);
      this.grcTaiXe.MenuManager = (IDXMenuManager) this.barManager1;
      this.grcTaiXe.Name = "grcTaiXe";
      this.grcTaiXe.Size = new Size(564, 423);
      this.grcTaiXe.TabIndex = 0;
      this.grcTaiXe.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvTaiXe
      });
      this.grvTaiXe.Columns.AddRange(new GridColumn[5]
      {
        this.gcMaTaiXe,
        this.gcTenTaiXe,
        this.gcPhone,
        this.gcGhiChu,
        this.gcActivated
      });
      this.grvTaiXe.DetailHeight = 284;
      this.grvTaiXe.GridControl = this.grcTaiXe;
      this.grvTaiXe.Name = "grvTaiXe";
      this.grvTaiXe.OptionsView.ShowFooter = true;
      this.gcMaTaiXe.Caption = "Mã Tài xế";
      this.gcMaTaiXe.FieldName = "MaTaiXe";
      this.gcMaTaiXe.MinWidth = 22;
      this.gcMaTaiXe.Name = "gcMaTaiXe";
      this.gcMaTaiXe.Visible = true;
      this.gcMaTaiXe.VisibleIndex = 0;
      this.gcMaTaiXe.Width = 80;
      this.gcTenTaiXe.Caption = "Tên Tài xế";
      this.gcTenTaiXe.FieldName = "TenTaiXe";
      this.gcTenTaiXe.MinWidth = 22;
      this.gcTenTaiXe.Name = "gcTenTaiXe";
      this.gcTenTaiXe.Visible = true;
      this.gcTenTaiXe.VisibleIndex = 1;
      this.gcTenTaiXe.Width = 80;
      this.gcPhone.Caption = "Phone";
      this.gcPhone.FieldName = "Phone";
      this.gcPhone.MinWidth = 22;
      this.gcPhone.Name = "gcPhone";
      this.gcPhone.Visible = true;
      this.gcPhone.VisibleIndex = 2;
      this.gcPhone.Width = 80;
      this.gcGhiChu.Caption = "Ghi Chú";
      this.gcGhiChu.FieldName = "GhiChu";
      this.gcGhiChu.MinWidth = 22;
      this.gcGhiChu.Name = "gcGhiChu";
      this.gcGhiChu.Visible = true;
      this.gcGhiChu.VisibleIndex = 3;
      this.gcGhiChu.Width = 80;
      this.gcActivated.Caption = "Active";
      this.gcActivated.FieldName = "Activated";
      this.gcActivated.MinWidth = 22;
      this.gcActivated.Name = "gcActivated";
      this.gcActivated.Width = 80;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Caption = "Timer";
      this.Controls.Add((Control) this.grcMaster);
      this.Controls.Add((Control) this.grcSearch);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (TaiXeMngView);
      this.Size = new Size(848, 488);
      this.barManager1.EndInit();
      this.grcSearch.EndInit();
      this.grcSearch.ResumeLayout(false);
      this.grcSearch.PerformLayout();
      this.lueActive.Properties.EndInit();
      this.txtPhone.Properties.EndInit();
      this.txtTenTX.Properties.EndInit();
      this.txtMaTX.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.grcMaster.EndInit();
      this.grcMaster.ResumeLayout(false);
      this.grcTaiXe.EndInit();
      this.grvTaiXe.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

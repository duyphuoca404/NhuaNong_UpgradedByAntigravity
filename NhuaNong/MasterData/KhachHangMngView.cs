// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.KhachHangMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Svg;
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
  public class KhachHangMngView : ControlViewBase, IKhachHangMngView, IBase, IPermission
  {
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private KhachHangMngDataPresenter _presenter;
    private BindingList<ObjKhachHang> _blstKhachHang = new BindingList<ObjKhachHang>();
    private IContainer components;
    private BarManager barManager1;
    private Bar barButton;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarStaticItem bsiCaption;
    private BarButtonItem bbiInsert;
    private BarButtonItem bbiUpdate;
    private BarButtonItem bbiDelete;
    private BarButtonItem bbiView;
    private BarStaticItem barStaticItem1;
    private GroupControl grcSearch;
    private GroupControl grcMasterInfo;
    private SimpleButton btnReset;
    private LabelControl labelControl5;
    private LabelControl labelControl4;
    private LabelControl labelControl3;
    private LabelControl labelControl2;
    private Label label3;
    private Label label2;
    private SimpleButton btnSearch;
    private LookUpEdit lueActive;
    private TextEdit txtPhone;
    private TextEdit txtDiaChi;
    private TextEdit txtTenKH;
    private TextEdit txtMaKH;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl labelControl1;
    private GridControl grcKhachHang;
    private GridView grvKhachHang;
    private GridColumn gcMaKhachHang;
    private GridColumn gcTenKhachHang;
    private GridColumn gcDiaChi;
    private GridColumn gcPhone;
    private GridColumn gcGhiChu;
    private GridColumn gcActivateds;

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public KhachHangMngView()
    {
      this.InitializeComponent();
      this._presenter = new KhachHangMngDataPresenter((IKhachHangMngView) this);
      this.Caption = "Khách hàng";
    }

    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set
      {
        this._blstKhachHang = value;
        this.grcKhachHang.DataSource = (object) this._blstKhachHang;
      }
    }

    protected override void PopulateStaticData()
    {
      this.lueActive.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.ActiveEnum>(true);
      this.LoadSearchDefaultValues();
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
        this.LoadKhachHang();
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.UnsuccessProceed);
    }

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewKhachHangView ctrView = new NewKhachHangView((ObjKhachHang) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadKhachHang();
      this.FocusRow(this.grvKhachHang, this.grvKhachHang.RowCount);
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) null;
      this.datToDate.EditValue = (object) Searching.Build_EndDateTime(DateTime.Now);
      this.txtMaKH.Text = this.txtTenKH.Text = this.txtDiaChi.Text = this.txtPhone.Text = string.Empty;
      this.lueActive.EditValue = (object) -1;
    }

    private void LoadKhachHang()
    {
      try
      {
        SplashScreenManager.ShowForm(typeof (NDPWaitForm));
        SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.WAIT_CAPTION);
        SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
        if (Convert.ToInt32(this.lueActive.EditValue) != 1)
          Convert.ToInt32(this.lueActive.EditValue);
        this._presenter.ListKhachHang_ByCondition(new DateTime?(this.datFromDate.DateTime), new DateTime?(this.datToDate.DateTime), this.txtMaKH.Text, this.txtTenKH.Text, this.txtDiaChi.Text, this.txtPhone.Text, new bool?(true));
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      finally
      {
        SplashScreenManager.CloseForm();
      }
    }

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadKhachHang();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvKhachHang.RowCount == 0)
        return;
      int focusedRowHandle = this.grvKhachHang.FocusedRowHandle;
      NewKhachHangView ctrView = new NewKhachHangView(this.grvKhachHang.GetRow(focusedRowHandle) as ObjKhachHang, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadKhachHang();
      this.FocusRow(this.grvKhachHang, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (TramTromMessageBox.ShowYesNoDialog(GlobalValues.Messages.ConfirmDeleteSelectedData) != DialogResult.Yes)
        return;
      BindingList<ObjKhachHang> blstCT = new BindingList<ObjKhachHang>();
      foreach (int selectedRow in this.grvKhachHang.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjKhachHang row = this.grvKhachHang.GetRow(selectedRow) as ObjKhachHang;
          row.Activated = false;
          blstCT.Add(row);
          this.LoadKhachHang();
        }
      }
      this._presenter.SaveKhachHang(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvKhachHang.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewKhachHangView(this.grvKhachHang.GetRow(this.grvKhachHang.FocusedRowHandle) as ObjKhachHang, Enums.FormAction.View));
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (KhachHangMngView));
      this.barManager1 = new BarManager(this.components);
      this.barButton = new Bar();
      this.barStaticItem1 = new BarStaticItem();
      this.bbiInsert = new BarButtonItem();
      this.bbiUpdate = new BarButtonItem();
      this.bbiDelete = new BarButtonItem();
      this.bbiView = new BarButtonItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.bsiCaption = new BarStaticItem();
      this.grcSearch = new GroupControl();
      this.btnReset = new SimpleButton();
      this.labelControl5 = new LabelControl();
      this.labelControl4 = new LabelControl();
      this.labelControl3 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.label3 = new Label();
      this.label2 = new Label();
      this.btnSearch = new SimpleButton();
      this.lueActive = new LookUpEdit();
      this.txtPhone = new TextEdit();
      this.txtDiaChi = new TextEdit();
      this.txtTenKH = new TextEdit();
      this.txtMaKH = new TextEdit();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.labelControl1 = new LabelControl();
      this.grcMasterInfo = new GroupControl();
      this.grcKhachHang = new GridControl();
      this.grvKhachHang = new GridView();
      this.gcMaKhachHang = new GridColumn();
      this.gcTenKhachHang = new GridColumn();
      this.gcDiaChi = new GridColumn();
      this.gcPhone = new GridColumn();
      this.gcGhiChu = new GridColumn();
      this.gcActivateds = new GridColumn();
      this.barManager1.BeginInit();
      this.grcSearch.BeginInit();
      this.grcSearch.SuspendLayout();
      this.lueActive.Properties.BeginInit();
      this.txtPhone.Properties.BeginInit();
      this.txtDiaChi.Properties.BeginInit();
      this.txtTenKH.Properties.BeginInit();
      this.txtMaKH.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.grcMasterInfo.BeginInit();
      this.grcMasterInfo.SuspendLayout();
      this.grcKhachHang.BeginInit();
      this.grvKhachHang.BeginInit();
      this.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[1]
      {
        this.barButton
      });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barManager1.Items.AddRange(new BarItem[6]
      {
        (BarItem) this.bsiCaption,
        (BarItem) this.bbiInsert,
        (BarItem) this.bbiUpdate,
        (BarItem) this.bbiDelete,
        (BarItem) this.bbiView,
        (BarItem) this.barStaticItem1
      });
      this.barManager1.MainMenu = this.barButton;
      this.barManager1.MaxItemId = 6;
      this.barButton.BarAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.barButton.BarAppearance.Normal.Options.UseFont = true;
      this.barButton.BarName = "Main menu";
      this.barButton.CanDockStyle = BarCanDockStyle.Top;
      this.barButton.DockCol = 0;
      this.barButton.DockRow = 0;
      this.barButton.DockStyle = BarDockStyle.Top;
      this.barButton.FloatLocation = new Point(371, (int) sbyte.MaxValue);
      this.barButton.LinksPersistInfo.AddRange(new LinkPersistInfo[5]
      {
        new LinkPersistInfo((BarItem) this.barStaticItem1),
        new LinkPersistInfo((BarItem) this.bbiInsert),
        new LinkPersistInfo((BarItem) this.bbiUpdate),
        new LinkPersistInfo((BarItem) this.bbiDelete),
        new LinkPersistInfo((BarItem) this.bbiView)
      });
      this.barButton.OptionsBar.MultiLine = true;
      this.barButton.OptionsBar.UseWholeRow = true;
      this.barButton.Text = "Main menu";
      this.barStaticItem1.Caption = "Khách Hàng";
      this.barStaticItem1.Id = 5;
      this.barStaticItem1.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
      this.barStaticItem1.Name = "barStaticItem1";
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
      this.bbiUpdate.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("bbiUpdate.ImageOptions.LargeImage");
      this.bbiUpdate.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiUpdate.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiUpdate.Name = "bbiUpdate";
      this.bbiUpdate.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiUpdate.ItemClick += new ItemClickEventHandler(this.bbiUpdate_ItemClick);
      this.bbiDelete.Caption = "Xoá";
      this.bbiDelete.Id = 3;
      this.bbiDelete.ImageOptions.Image = (Image) ResourceNhua.delete_file;
      this.bbiDelete.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("bbiDelete.ImageOptions.LargeImage");
      this.bbiDelete.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiDelete.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiDelete.Name = "bbiDelete";
      this.bbiDelete.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiDelete.ItemClick += new ItemClickEventHandler(this.bbiDelete_ItemClick);
      this.bbiView.Caption = "Xem";
      this.bbiView.Id = 4;
      this.bbiView.ImageOptions.Image = (Image) componentResourceManager.GetObject("bbiView.ImageOptions.Image");
      this.bbiView.ImageOptions.LargeImage = (Image) componentResourceManager.GetObject("bbiView.ImageOptions.LargeImage");
      this.bbiView.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiView.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiView.Name = "bbiView";
      this.bbiView.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiView.ItemClick += new ItemClickEventHandler(this.bbiView_ItemClick);
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Margin = new Padding(4);
      this.barDockControlTop.Size = new Size(1019, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 560);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(4);
      this.barDockControlBottom.Size = new Size(1019, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(4);
      this.barDockControlLeft.Size = new Size(0, 520);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(1019, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(4);
      this.barDockControlRight.Size = new Size(0, 520);
      this.bsiCaption.Caption = "Khách Hàng";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ImageOptions.SvgImage = (SvgImage) componentResourceManager.GetObject("bsiCaption.ImageOptions.SvgImage");
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bsiCaption.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.grcSearch.Controls.Add((Control) this.btnReset);
      this.grcSearch.Controls.Add((Control) this.labelControl5);
      this.grcSearch.Controls.Add((Control) this.labelControl4);
      this.grcSearch.Controls.Add((Control) this.labelControl3);
      this.grcSearch.Controls.Add((Control) this.labelControl2);
      this.grcSearch.Controls.Add((Control) this.label3);
      this.grcSearch.Controls.Add((Control) this.label2);
      this.grcSearch.Controls.Add((Control) this.btnSearch);
      this.grcSearch.Controls.Add((Control) this.lueActive);
      this.grcSearch.Controls.Add((Control) this.txtPhone);
      this.grcSearch.Controls.Add((Control) this.txtDiaChi);
      this.grcSearch.Controls.Add((Control) this.txtTenKH);
      this.grcSearch.Controls.Add((Control) this.txtMaKH);
      this.grcSearch.Controls.Add((Control) this.datToDate);
      this.grcSearch.Controls.Add((Control) this.datFromDate);
      this.grcSearch.Controls.Add((Control) this.labelControl1);
      this.grcSearch.Dock = DockStyle.Right;
      this.grcSearch.Location = new Point(739, 40);
      this.grcSearch.Margin = new Padding(4);
      this.grcSearch.Name = "grcSearch";
      this.grcSearch.Size = new Size(280, 520);
      this.grcSearch.TabIndex = 48;
      this.grcSearch.Text = "Tìm kiếm";
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(13, 245);
      this.btnReset.Margin = new Padding(4);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(105, 35);
      this.btnReset.TabIndex = 75;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.labelControl5.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new Point(13, 198);
      this.labelControl5.Margin = new Padding(4);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(75, 16);
      this.labelControl5.TabIndex = 74;
      this.labelControl5.Text = "Số điện thoại";
      this.labelControl4.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new Point(13, 332);
      this.labelControl4.Margin = new Padding(4);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(59, 16);
      this.labelControl4.TabIndex = 73;
      this.labelControl4.Text = "Trạng thái";
      this.labelControl4.Visible = false;
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(13, 168);
      this.labelControl3.Margin = new Padding(4);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(39, 16);
      this.labelControl3.TabIndex = 72;
      this.labelControl3.Text = "Địa chỉ";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(13, 138);
      this.labelControl2.Margin = new Padding(4);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(91, 16);
      this.labelControl2.TabIndex = 71;
      this.labelControl2.Text = "Tên khách hàng";
      this.label3.AutoSize = true;
      this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label3.Location = new Point(10, 108);
      this.label3.Margin = new Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new Size(94, 16);
      this.label3.TabIndex = 70;
      this.label3.Text = "Mã khách hàng";
      this.label2.AutoSize = true;
      this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label2.Location = new Point(10, 78);
      this.label2.Margin = new Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new Size(62, 16);
      this.label2.TabIndex = 69;
      this.label2.Text = "Đến ngày";
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(157, 245);
      this.btnSearch.Margin = new Padding(4);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(105, 35);
      this.btnSearch.TabIndex = 68;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
      this.lueActive.Location = new Point(112, 329);
      this.lueActive.Margin = new Padding(4);
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
      this.lueActive.TabIndex = 67;
      this.lueActive.Visible = false;
      this.txtPhone.Location = new Point(112, 195);
      this.txtPhone.Margin = new Padding(4);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPhone.Properties.Appearance.Options.UseFont = true;
      this.txtPhone.Properties.Name = "txtPhone";
      this.txtPhone.Size = new Size(150, 22);
      this.txtPhone.TabIndex = 66;
      this.txtDiaChi.Location = new Point(112, 165);
      this.txtDiaChi.Margin = new Padding(4);
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
      this.txtDiaChi.Size = new Size(150, 22);
      this.txtDiaChi.TabIndex = 65;
      this.txtTenKH.Location = new Point(112, 135);
      this.txtTenKH.Margin = new Padding(4);
      this.txtTenKH.Name = "txtTenKH";
      this.txtTenKH.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenKH.Properties.Appearance.Options.UseFont = true;
      this.txtTenKH.Size = new Size(150, 22);
      this.txtTenKH.TabIndex = 64;
      this.txtMaKH.Location = new Point(112, 105);
      this.txtMaKH.Margin = new Padding(4);
      this.txtMaKH.Name = "txtMaKH";
      this.txtMaKH.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaKH.Properties.Appearance.Options.UseFont = true;
      this.txtMaKH.Size = new Size(150, 22);
      this.txtMaKH.TabIndex = 63;
      this.datToDate.EditValue = (object) null;
      this.datToDate.Location = new Point(112, 75);
      this.datToDate.Margin = new Padding(4);
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
      this.datToDate.TabIndex = 62;
      this.datFromDate.EditValue = (object) null;
      this.datFromDate.Location = new Point(112, 45);
      this.datFromDate.Margin = new Padding(4);
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
      this.datFromDate.TabIndex = 61;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(13, 48);
      this.labelControl1.Margin = new Padding(4);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(73, 16);
      this.labelControl1.TabIndex = 60;
      this.labelControl1.Text = "Tạo Từ ngày";
      this.grcMasterInfo.Controls.Add((Control) this.grcKhachHang);
      this.grcMasterInfo.Dock = DockStyle.Fill;
      this.grcMasterInfo.Location = new Point(0, 40);
      this.grcMasterInfo.Margin = new Padding(4);
      this.grcMasterInfo.Name = "grcMasterInfo";
      this.grcMasterInfo.Size = new Size(739, 520);
      this.grcMasterInfo.TabIndex = 49;
      this.grcMasterInfo.Text = "Dữ liệu";
      this.grcKhachHang.Dock = DockStyle.Fill;
      this.grcKhachHang.EmbeddedNavigator.Margin = new Padding(4);
      this.grcKhachHang.Location = new Point(2, 23);
      this.grcKhachHang.MainView = (BaseView) this.grvKhachHang;
      this.grcKhachHang.Margin = new Padding(4);
      this.grcKhachHang.Name = "grcKhachHang";
      this.grcKhachHang.Size = new Size(735, 495);
      this.grcKhachHang.TabIndex = 61;
      this.grcKhachHang.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvKhachHang
      });
      this.grvKhachHang.Columns.AddRange(new GridColumn[6]
      {
        this.gcMaKhachHang,
        this.gcTenKhachHang,
        this.gcDiaChi,
        this.gcPhone,
        this.gcGhiChu,
        this.gcActivateds
      });
      this.grvKhachHang.DetailHeight = 437;
      this.grvKhachHang.GridControl = this.grcKhachHang;
      this.grvKhachHang.Name = "grvKhachHang";
      this.grvKhachHang.OptionsView.ShowFooter = true;
      this.gcMaKhachHang.Caption = "Mã Khách Hàng";
      this.gcMaKhachHang.FieldName = "MaKhachHang";
      this.gcMaKhachHang.MinWidth = 31;
      this.gcMaKhachHang.Name = "gcMaKhachHang";
      this.gcMaKhachHang.OptionsColumn.AllowEdit = false;
      this.gcMaKhachHang.OptionsColumn.ReadOnly = true;
      this.gcMaKhachHang.Visible = true;
      this.gcMaKhachHang.VisibleIndex = 0;
      this.gcMaKhachHang.Width = 117;
      this.gcTenKhachHang.Caption = "Tên Khách Hàng";
      this.gcTenKhachHang.FieldName = "TenKhachHang";
      this.gcTenKhachHang.MinWidth = 31;
      this.gcTenKhachHang.Name = "gcTenKhachHang";
      this.gcTenKhachHang.OptionsColumn.AllowEdit = false;
      this.gcTenKhachHang.OptionsColumn.ReadOnly = true;
      this.gcTenKhachHang.Visible = true;
      this.gcTenKhachHang.VisibleIndex = 1;
      this.gcTenKhachHang.Width = 117;
      this.gcDiaChi.Caption = "Địa Chỉ";
      this.gcDiaChi.FieldName = "DiaChi";
      this.gcDiaChi.MinWidth = 31;
      this.gcDiaChi.Name = "gcDiaChi";
      this.gcDiaChi.OptionsColumn.AllowEdit = false;
      this.gcDiaChi.OptionsColumn.ReadOnly = true;
      this.gcDiaChi.Visible = true;
      this.gcDiaChi.VisibleIndex = 2;
      this.gcDiaChi.Width = 117;
      this.gcPhone.Caption = "Phone";
      this.gcPhone.FieldName = "Phone";
      this.gcPhone.MinWidth = 31;
      this.gcPhone.Name = "gcPhone";
      this.gcPhone.OptionsColumn.AllowEdit = false;
      this.gcPhone.OptionsColumn.ReadOnly = true;
      this.gcPhone.Visible = true;
      this.gcPhone.VisibleIndex = 3;
      this.gcPhone.Width = 117;
      this.gcGhiChu.Caption = "Ghi Chú";
      this.gcGhiChu.FieldName = "GhiChu";
      this.gcGhiChu.MinWidth = 31;
      this.gcGhiChu.Name = "gcGhiChu";
      this.gcGhiChu.OptionsColumn.AllowEdit = false;
      this.gcGhiChu.OptionsColumn.ReadOnly = true;
      this.gcGhiChu.Visible = true;
      this.gcGhiChu.VisibleIndex = 4;
      this.gcGhiChu.Width = 117;
      this.gcActivateds.Caption = "Active";
      this.gcActivateds.FieldName = "Activated";
      this.gcActivateds.MinWidth = 31;
      this.gcActivateds.Name = "gcActivateds";
      this.gcActivateds.OptionsColumn.AllowEdit = false;
      this.gcActivateds.OptionsColumn.ReadOnly = true;
      this.gcActivateds.Width = 117;
      this.AutoScaleDimensions = new SizeF(8f, 17f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.grcMasterInfo);
      this.Controls.Add((Control) this.grcSearch);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Font = new Font("Microsoft Sans Serif", 10.2f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Margin = new Padding(4);
      this.Name = nameof (KhachHangMngView);
      this.Size = new Size(1019, 560);
      this.barManager1.EndInit();
      this.grcSearch.EndInit();
      this.grcSearch.ResumeLayout(false);
      this.grcSearch.PerformLayout();
      this.lueActive.Properties.EndInit();
      this.txtPhone.Properties.EndInit();
      this.txtDiaChi.Properties.EndInit();
      this.txtTenKH.Properties.EndInit();
      this.txtMaKH.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.grcMasterInfo.EndInit();
      this.grcMasterInfo.ResumeLayout(false);
      this.grcKhachHang.EndInit();
      this.grvKhachHang.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

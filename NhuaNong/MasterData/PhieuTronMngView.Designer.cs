using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace NhuaNong.MasterData
{
  public partial class PhieuTronMngView
  {
    private IContainer components;
    private BarManager barManager1;
    private Bar barButtons;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarStaticItem bsiCaption;
    private BarButtonItem bbiUpdate;
    private BarButtonItem bbiDelete;
    private BarButtonItem bbiView;
    private GroupControl grcMaster;
    private GroupControl grcSearch;
    private GridControl grcPhieuTron;
    private GridView grvPhieuTron;
    private GridColumn gcMaPhieuTron;
    private GridColumn gcNgayPhieuTron;
    private GridColumn gcViewMaHopDong;
    private GridColumn gcStatus;
    private RepositoryItemLookUpEdit iluePTStatus;
    private GridColumn gcKLDuTinh;
    private GridColumn gcKLThuc;
    private GridColumn gcKLDuTinhTungMe;
    private GridColumn gcKLBuTruMeCuoi;
    private GridColumn gcSLMeDuTinh;
    private GridColumn gcSLMeHieuChinh;
    private GridColumn gcSLMeDaTron;
    private GridColumn gcMoTa;
    private SimpleButton btnReset;
    private LabelControl lblActive;
    private Label lblMaPhieuTron;
    private Label lblToDate;
    private SimpleButton btnSearch;
    private LookUpEdit luePTStatus;
    private TextEdit txtMaPhieuTron;
    private DateEdit datDenNgay;
    private DateEdit datTuNgay;
    private LabelControl lblFromDate;
    private RepositoryItemLookUpEdit ilueMaHopDong;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer)new System.ComponentModel.Container();
      this.barManager1 = new BarManager(this.components);
      this.barButtons = new Bar();
      this.bsiCaption = new BarStaticItem();
      this.bbiUpdate = new BarButtonItem();
      this.bbiDelete = new BarButtonItem();
      this.bbiView = new BarButtonItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.grcSearch = new GroupControl();
      this.btnReset = new SimpleButton();
      this.lblActive = new LabelControl();
      this.lblMaPhieuTron = new Label();
      this.lblToDate = new Label();
      this.btnSearch = new SimpleButton();
      this.luePTStatus = new LookUpEdit();
      this.txtMaPhieuTron = new TextEdit();
      this.datDenNgay = new DateEdit();
      this.datTuNgay = new DateEdit();
      this.lblFromDate = new LabelControl();
      this.grcMaster = new GroupControl();
      this.grcPhieuTron = new GridControl();
      this.grvPhieuTron = new GridView();
      this.gcMaPhieuTron = new GridColumn();
      this.gcNgayPhieuTron = new GridColumn();
      this.gcViewMaHopDong = new GridColumn();
      this.ilueMaHopDong = new RepositoryItemLookUpEdit();
      this.gcStatus = new GridColumn();
      this.iluePTStatus = new RepositoryItemLookUpEdit();
      this.gcKLDuTinh = new GridColumn();
      this.gcKLThuc = new GridColumn();
      this.gcKLDuTinhTungMe = new GridColumn();
      this.gcKLBuTruMeCuoi = new GridColumn();
      this.gcSLMeDuTinh = new GridColumn();
      this.gcSLMeHieuChinh = new GridColumn();
      this.gcSLMeDaTron = new GridColumn();
      this.gcMoTa = new GridColumn();
      this.barManager1.BeginInit();
      this.grcSearch.BeginInit();
      this.grcSearch.SuspendLayout();
      this.luePTStatus.Properties.BeginInit();
      this.txtMaPhieuTron.Properties.BeginInit();
      this.datDenNgay.Properties.CalendarTimeProperties.BeginInit();
      this.datDenNgay.Properties.BeginInit();
      this.datTuNgay.Properties.CalendarTimeProperties.BeginInit();
      this.datTuNgay.Properties.BeginInit();
      this.grcMaster.BeginInit();
      this.grcMaster.SuspendLayout();
      this.grcPhieuTron.BeginInit();
      this.grvPhieuTron.BeginInit();
      this.ilueMaHopDong.BeginInit();
      this.iluePTStatus.BeginInit();
      this.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[1]
      {
        this.barButtons
      });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control)this;
      this.barManager1.Items.AddRange(new BarItem[4]
      {
        (BarItem) this.bsiCaption,
        (BarItem) this.bbiUpdate,
        (BarItem) this.bbiDelete,
        (BarItem) this.bbiView
      });
      this.barManager1.MainMenu = this.barButtons;
      this.barManager1.MaxItemId = 4;
      this.barButtons.BarName = "Main menu";
      this.barButtons.DockCol = 0;
      this.barButtons.DockRow = 0;
      this.barButtons.DockStyle = BarDockStyle.Top;
      this.barButtons.LinksPersistInfo.AddRange(new LinkPersistInfo[4]
      {
        new LinkPersistInfo((BarItem) this.bsiCaption),
        new LinkPersistInfo((BarItem) this.bbiUpdate),
        new LinkPersistInfo((BarItem) this.bbiDelete),
        new LinkPersistInfo((BarItem) this.bbiView)
      });
      this.barButtons.OptionsBar.MultiLine = true;
      this.barButtons.OptionsBar.UseWholeRow = true;
      this.barButtons.Text = "Main menu";
      this.bsiCaption.Caption = "Phiếu trộn";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiUpdate.Caption = "Sửa";
      this.bbiUpdate.Id = 1;
      this.bbiUpdate.ImageOptions.Image = (Image)ResourceNhua.edit_file;
      this.bbiUpdate.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.bbiUpdate.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiUpdate.Name = "bbiUpdate";
      this.bbiUpdate.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiUpdate.Visibility = BarItemVisibility.Never;
      this.bbiDelete.Caption = "Xoá";
      this.bbiDelete.Id = 2;
      this.bbiDelete.ImageOptions.Image = (Image)ResourceNhua.delete_file;
      this.bbiDelete.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.bbiDelete.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiDelete.Name = "bbiDelete";
      this.bbiDelete.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiDelete.Visibility = BarItemVisibility.Never;
      this.bbiView.Caption = "Xem";
      this.bbiView.Id = 3;
      this.bbiView.ImageOptions.Image = (Image)ResourceNhua.view_file;
      this.bbiView.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.bbiView.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiView.Name = "bbiView";
      this.bbiView.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiView.ItemClick += new ItemClickEventHandler(this.bbiView_ItemClick);
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
      this.grcSearch.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.grcSearch.AppearanceCaption.Options.UseFont = true;
      this.grcSearch.Controls.Add((Control)this.btnReset);
      this.grcSearch.Controls.Add((Control)this.lblActive);
      this.grcSearch.Controls.Add((Control)this.lblMaPhieuTron);
      this.grcSearch.Controls.Add((Control)this.lblToDate);
      this.grcSearch.Controls.Add((Control)this.btnSearch);
      this.grcSearch.Controls.Add((Control)this.luePTStatus);
      this.grcSearch.Controls.Add((Control)this.txtMaPhieuTron);
      this.grcSearch.Controls.Add((Control)this.datDenNgay);
      this.grcSearch.Controls.Add((Control)this.datTuNgay);
      this.grcSearch.Controls.Add((Control)this.lblFromDate);
      this.grcSearch.Dock = DockStyle.Right;
      this.grcSearch.Location = new Point(492, 40);
      this.grcSearch.Margin = new Padding(2);
      this.grcSearch.Name = "grcSearch";
      this.grcSearch.Size = new Size(280, 448);
      this.grcSearch.TabIndex = 4;
      this.grcSearch.Text = "Tìm kiếm";
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(21, 185);
      this.btnReset.Margin = new Padding(2);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(105, 35);
      this.btnReset.TabIndex = 111;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.lblActive.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblActive.Appearance.Options.UseFont = true;
      this.lblActive.Location = new Point(21, 138);
      this.lblActive.Margin = new Padding(2);
      this.lblActive.Name = "lblActive";
      this.lblActive.Size = new Size(59, 16);
      this.lblActive.TabIndex = 110;
      this.lblActive.Text = "Trạng thái";
      this.lblMaPhieuTron.AutoSize = true;
      this.lblMaPhieuTron.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblMaPhieuTron.Location = new Point(18, 108);
      this.lblMaPhieuTron.Margin = new Padding(2, 0, 2, 0);
      this.lblMaPhieuTron.Name = "lblMaPhieuTron";
      this.lblMaPhieuTron.Size = new Size(83, 16);
      this.lblMaPhieuTron.TabIndex = 109;
      this.lblMaPhieuTron.Text = "Mã Hợp đồng";
      this.lblToDate.AutoSize = true;
      this.lblToDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblToDate.Location = new Point(18, 78);
      this.lblToDate.Margin = new Padding(2, 0, 2, 0);
      this.lblToDate.Name = "lblToDate";
      this.lblToDate.Size = new Size(62, 16);
      this.lblToDate.TabIndex = 108;
      this.lblToDate.Text = "Đến ngày";
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(157, 185);
      this.btnSearch.Margin = new Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(105, 35);
      this.btnSearch.TabIndex = 107;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
      this.luePTStatus.Location = new Point(112, 135);
      this.luePTStatus.Margin = new Padding(2);
      this.luePTStatus.MenuManager = (IDXMenuManager)this.barManager1;
      this.luePTStatus.Name = "luePTStatus";
      this.luePTStatus.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.luePTStatus.Properties.Appearance.Options.UseFont = true;
      this.luePTStatus.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.luePTStatus.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("DisplayText", "Trạng Thái")
      });
      this.luePTStatus.Properties.DisplayMember = "DisplayText";
      this.luePTStatus.Properties.NullText = "";
      this.luePTStatus.Properties.ValueMember = "ID";
      this.luePTStatus.Size = new Size(150, 22);
      this.luePTStatus.TabIndex = 106;
      this.txtMaPhieuTron.Location = new Point(112, 105);
      this.txtMaPhieuTron.Margin = new Padding(2);
      this.txtMaPhieuTron.Name = "txtMaPhieuTron";
      this.txtMaPhieuTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtMaPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.txtMaPhieuTron.Size = new Size(150, 22);
      this.txtMaPhieuTron.TabIndex = 105;
      this.datDenNgay.EditValue = (object)null;
      this.datDenNgay.Location = new Point(112, 75);
      this.datDenNgay.Margin = new Padding(2);
      this.datDenNgay.Name = "datDenNgay";
      this.datDenNgay.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datDenNgay.Properties.Appearance.Options.UseFont = true;
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
      this.datDenNgay.Size = new Size(150, 22);
      this.datDenNgay.TabIndex = 104;
      this.datTuNgay.EditValue = (object)null;
      this.datTuNgay.Location = new Point(112, 45);
      this.datTuNgay.Margin = new Padding(2);
      this.datTuNgay.Name = "datTuNgay";
      this.datTuNgay.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datTuNgay.Properties.Appearance.Options.UseFont = true;
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
      this.datTuNgay.Size = new Size(150, 22);
      this.datTuNgay.TabIndex = 103;
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(21, 48);
      this.lblFromDate.Margin = new Padding(2);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(73, 16);
      this.lblFromDate.TabIndex = 102;
      this.lblFromDate.Text = "Tạo Từ ngày";
      this.grcMaster.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.grcMaster.AppearanceCaption.Options.UseFont = true;
      this.grcMaster.Controls.Add((Control)this.grcPhieuTron);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(492, 448);
      this.grcMaster.TabIndex = 5;
      this.grcMaster.Text = "Dữ liệu";
      this.grcPhieuTron.Dock = DockStyle.Fill;
      this.grcPhieuTron.EmbeddedNavigator.Margin = new Padding(2);
      this.grcPhieuTron.Location = new Point(2, 23);
      this.grcPhieuTron.MainView = (BaseView)this.grvPhieuTron;
      this.grcPhieuTron.Margin = new Padding(2);
      this.grcPhieuTron.MenuManager = (IDXMenuManager)this.barManager1;
      this.grcPhieuTron.Name = "grcPhieuTron";
      this.grcPhieuTron.RepositoryItems.AddRange(new RepositoryItem[2]
      {
        (RepositoryItem) this.iluePTStatus,
        (RepositoryItem) this.ilueMaHopDong
      });
      this.grcPhieuTron.Size = new Size(488, 423);
      this.grcPhieuTron.TabIndex = 0;
      this.grcPhieuTron.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvPhieuTron
      });
      this.grvPhieuTron.Columns.AddRange(new GridColumn[12]
      {
        this.gcMaPhieuTron,
        this.gcNgayPhieuTron,
        this.gcViewMaHopDong,
        this.gcStatus,
        this.gcKLDuTinh,
        this.gcKLThuc,
        this.gcKLDuTinhTungMe,
        this.gcKLBuTruMeCuoi,
        this.gcSLMeDuTinh,
        this.gcSLMeHieuChinh,
        this.gcSLMeDaTron,
        this.gcMoTa
      });
      this.grvPhieuTron.DetailHeight = 284;
      this.grvPhieuTron.GridControl = this.grcPhieuTron;
      this.grvPhieuTron.Name = "grvPhieuTron";
      this.grvPhieuTron.OptionsView.ShowFooter = true;
      this.gcMaPhieuTron.Caption = "Mã Phiếu";
      this.gcMaPhieuTron.FieldName = "MaPhieuTron";
      this.gcMaPhieuTron.MinWidth = 100;
      this.gcMaPhieuTron.Name = "gcMaPhieuTron";
      this.gcMaPhieuTron.OptionsColumn.AllowEdit = false;
      this.gcMaPhieuTron.Visible = true;
      this.gcMaPhieuTron.VisibleIndex = 0;
      this.gcMaPhieuTron.Width = 100;
      this.gcNgayPhieuTron.Caption = "Ngày Tạo";
      this.gcNgayPhieuTron.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
      this.gcNgayPhieuTron.DisplayFormat.FormatType = FormatType.DateTime;
      this.gcNgayPhieuTron.FieldName = "NgayPhieuTron";
      this.gcNgayPhieuTron.MinWidth = 100;
      this.gcNgayPhieuTron.Name = "gcNgayPhieuTron";
      this.gcNgayPhieuTron.OptionsColumn.AllowEdit = false;
      this.gcNgayPhieuTron.Visible = true;
      this.gcNgayPhieuTron.VisibleIndex = 1;
      this.gcNgayPhieuTron.Width = 100;
      this.gcViewMaHopDong.Caption = "Mã Hợp Đồng";
      this.gcViewMaHopDong.ColumnEdit = (RepositoryItem)this.ilueMaHopDong;
      this.gcViewMaHopDong.FieldName = "HopDongID";
      this.gcViewMaHopDong.MinWidth = 100;
      this.gcViewMaHopDong.Name = "gcViewMaHopDong";
      this.gcViewMaHopDong.OptionsColumn.AllowEdit = false;
      this.gcViewMaHopDong.Visible = true;
      this.gcViewMaHopDong.VisibleIndex = 2;
      this.gcViewMaHopDong.Width = 100;
      this.ilueMaHopDong.AutoHeight = false;
      this.ilueMaHopDong.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueMaHopDong.DisplayMember = "MaHopDong";
      this.ilueMaHopDong.Name = "ilueMaHopDong";
      this.ilueMaHopDong.ValueMember = "HopDongID";
      this.gcStatus.Caption = "Trạng Thái";
      this.gcStatus.ColumnEdit = (RepositoryItem)this.iluePTStatus;
      this.gcStatus.FieldName = "Status";
      this.gcStatus.MinWidth = 100;
      this.gcStatus.Name = "gcStatus";
      this.gcStatus.OptionsColumn.AllowEdit = false;
      this.gcStatus.Visible = true;
      this.gcStatus.VisibleIndex = 3;
      this.gcStatus.Width = 100;
      this.iluePTStatus.AutoHeight = false;
      this.iluePTStatus.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.iluePTStatus.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("DisplayText", "Trạng Thái")
      });
      this.iluePTStatus.DisplayMember = "DisplayText";
      this.iluePTStatus.Name = "iluePTStatus";
      this.iluePTStatus.NullText = "";
      this.iluePTStatus.ShowFooter = false;
      this.iluePTStatus.ShowHeader = false;
      this.iluePTStatus.ValueMember = "ID";
      this.gcKLDuTinh.Caption = "KL Dự Tính";
      this.gcKLDuTinh.DisplayFormat.FormatString = "n2";
      this.gcKLDuTinh.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcKLDuTinh.FieldName = "KLDuTinh";
      this.gcKLDuTinh.MinWidth = 100;
      this.gcKLDuTinh.Name = "gcKLDuTinh";
      this.gcKLDuTinh.OptionsColumn.AllowEdit = false;
      this.gcKLDuTinh.Visible = true;
      this.gcKLDuTinh.VisibleIndex = 4;
      this.gcKLDuTinh.Width = 100;
      this.gcKLThuc.Caption = "Luỹ Kế";
      this.gcKLThuc.DisplayFormat.FormatString = "n2";
      this.gcKLThuc.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcKLThuc.FieldName = "KLThuc";
      this.gcKLThuc.MinWidth = 100;
      this.gcKLThuc.Name = "gcKLThuc";
      this.gcKLThuc.OptionsColumn.AllowEdit = false;
      this.gcKLThuc.Visible = true;
      this.gcKLThuc.VisibleIndex = 5;
      this.gcKLThuc.Width = 100;
      this.gcKLDuTinhTungMe.Caption = "KL Dự Tính Từng Mẻ";
      this.gcKLDuTinhTungMe.DisplayFormat.FormatString = "n2";
      this.gcKLDuTinhTungMe.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcKLDuTinhTungMe.FieldName = "KLDuTinhCuaTungMe";
      this.gcKLDuTinhTungMe.MinWidth = 100;
      this.gcKLDuTinhTungMe.Name = "gcKLDuTinhTungMe";
      this.gcKLDuTinhTungMe.OptionsColumn.AllowEdit = false;
      this.gcKLDuTinhTungMe.Visible = true;
      this.gcKLDuTinhTungMe.VisibleIndex = 6;
      this.gcKLDuTinhTungMe.Width = 100;
      this.gcKLBuTruMeCuoi.Caption = "KL Bù Trừ Mẻ Cuối";
      this.gcKLBuTruMeCuoi.DisplayFormat.FormatString = "n2";
      this.gcKLBuTruMeCuoi.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcKLBuTruMeCuoi.FieldName = "KLBuTruMeCuoi";
      this.gcKLBuTruMeCuoi.MinWidth = 100;
      this.gcKLBuTruMeCuoi.Name = "gcKLBuTruMeCuoi";
      this.gcKLBuTruMeCuoi.OptionsColumn.AllowEdit = false;
      this.gcKLBuTruMeCuoi.Visible = true;
      this.gcKLBuTruMeCuoi.VisibleIndex = 7;
      this.gcKLBuTruMeCuoi.Width = 100;
      this.gcSLMeDuTinh.Caption = "SL Mẻ Dự Tính";
      this.gcSLMeDuTinh.DisplayFormat.FormatString = "n2";
      this.gcSLMeDuTinh.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcSLMeDuTinh.FieldName = "SLMeDuTinh";
      this.gcSLMeDuTinh.MinWidth = 100;
      this.gcSLMeDuTinh.Name = "gcSLMeDuTinh";
      this.gcSLMeDuTinh.OptionsColumn.AllowEdit = false;
      this.gcSLMeDuTinh.Visible = true;
      this.gcSLMeDuTinh.VisibleIndex = 8;
      this.gcSLMeDuTinh.Width = 100;
      this.gcSLMeHieuChinh.Caption = "SL Mẻ Thêm Bớt";
      this.gcSLMeHieuChinh.DisplayFormat.FormatString = "n2";
      this.gcSLMeHieuChinh.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcSLMeHieuChinh.FieldName = "SLMeHieuChinh";
      this.gcSLMeHieuChinh.MinWidth = 100;
      this.gcSLMeHieuChinh.Name = "gcSLMeHieuChinh";
      this.gcSLMeHieuChinh.OptionsColumn.AllowEdit = false;
      this.gcSLMeHieuChinh.Width = 80;
      this.gcSLMeDaTron.Caption = "SL Mẻ Đã Trộn";
      this.gcSLMeDaTron.DisplayFormat.FormatString = "n2";
      this.gcSLMeDaTron.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcSLMeDaTron.FieldName = "SLMeDaTron";
      this.gcSLMeDaTron.MinWidth = 100;
      this.gcSLMeDaTron.Name = "gcSLMeDaTron";
      this.gcSLMeDaTron.OptionsColumn.AllowEdit = false;
      this.gcSLMeDaTron.Width = 80;
      this.gcMoTa.Caption = "Niêm chì";
      this.gcMoTa.FieldName = "MoTa";
      this.gcMoTa.MinWidth = 100;
      this.gcMoTa.Name = "gcMoTa";
      this.gcMoTa.OptionsColumn.AllowEdit = false;
      this.gcMoTa.Visible = true;
      this.gcMoTa.VisibleIndex = 9;
      this.gcMoTa.Width = 100;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.grcMaster);
      this.Controls.Add((Control)this.grcSearch);
      this.Controls.Add((Control)this.barDockControlLeft);
      this.Controls.Add((Control)this.barDockControlRight);
      this.Controls.Add((Control)this.barDockControlBottom);
      this.Controls.Add((Control)this.barDockControlTop);
      this.Name = "PhieuTronMngView";
      this.Size = new Size(772, 488);
      this.barManager1.EndInit();
      this.grcSearch.EndInit();
      this.grcSearch.ResumeLayout(false);
      this.grcSearch.PerformLayout();
      this.luePTStatus.Properties.EndInit();
      this.txtMaPhieuTron.Properties.EndInit();
      this.datDenNgay.Properties.CalendarTimeProperties.EndInit();
      this.datDenNgay.Properties.EndInit();
      this.datTuNgay.Properties.CalendarTimeProperties.EndInit();
      this.datTuNgay.Properties.EndInit();
      this.grcMaster.EndInit();
      this.grcMaster.ResumeLayout(false);
      this.grcPhieuTron.EndInit();
      this.grvPhieuTron.EndInit();
      this.ilueMaHopDong.EndInit();
      this.iluePTStatus.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.MasterData
{
  public partial class CongTruongMngView
  {
    private IContainer components;
    private BarManager barManager1;
    private Bar bar2;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarStaticItem bsiCaption;
    private BarStaticItem barStaticItem1;
    private BarButtonItem bbiInsert;
    private BarButtonItem bbiUpdate;
    private BarButtonItem bbiDelete;
    private BarButtonItem bbiView;
    private GroupControl grcSearch;
    private GroupControl grpMaster;
    private SimpleButton btnReset;
    private LabelControl lblPhone;
    private LabelControl lblActive;
    private LabelControl lblAddress;
    private LabelControl lblTenCongTruong;
    private Label lblMaCongTruong;
    private Label lblToDate;
    private SimpleButton btnSearch;
    private LookUpEdit lueActive;
    private TextEdit txtPhone;
    private TextEdit txtDiaChi;
    private TextEdit txtTenCT;
    private TextEdit txtMaCT;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl lblFromDate;
    private GridControl grcCongTruong;
    private GridView grvCongTruong;
    private GridColumn gcMaCongTruong;
    private GridColumn gcTenCongTruong;
    private GridColumn gcDiaChi;
    private GridColumn gcPhone;
    private GridColumn gcGhiChu;
    private GridColumn gcActivated;
    // Token: 0x06000E60 RID: 3680 RVA: 0x0007ECC4 File Offset: 0x0007CEC4
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    // Token: 0x06000E61 RID: 3681 RVA: 0x0007ECE4 File Offset: 0x0007CEE4
    private void InitializeComponent()
    {
      this.components = new Container();
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
      this.barStaticItem1 = new BarStaticItem();
      this.grcSearch = new GroupControl();
      this.btnReset = new SimpleButton();
      this.lblPhone = new LabelControl();
      this.lblActive = new LabelControl();
      this.lblAddress = new LabelControl();
      this.lblTenCongTruong = new LabelControl();
      this.lblMaCongTruong = new Label();
      this.lblToDate = new Label();
      this.btnSearch = new SimpleButton();
      this.lueActive = new LookUpEdit();
      this.txtPhone = new TextEdit();
      this.txtDiaChi = new TextEdit();
      this.txtTenCT = new TextEdit();
      this.txtMaCT = new TextEdit();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.lblFromDate = new LabelControl();
      this.grpMaster = new GroupControl();
      this.grcCongTruong = new GridControl();
      this.grvCongTruong = new GridView();
      this.gcMaCongTruong = new GridColumn();
      this.gcTenCongTruong = new GridColumn();
      this.gcDiaChi = new GridColumn();
      this.gcPhone = new GridColumn();
      this.gcGhiChu = new GridColumn();
      this.gcActivated = new GridColumn();
      ((ISupportInitialize)this.barManager1).BeginInit();
      ((ISupportInitialize)this.grcSearch).BeginInit();
      this.grcSearch.SuspendLayout();
      ((ISupportInitialize)this.lueActive.Properties).BeginInit();
      ((ISupportInitialize)this.txtPhone.Properties).BeginInit();
      ((ISupportInitialize)this.txtDiaChi.Properties).BeginInit();
      ((ISupportInitialize)this.txtTenCT.Properties).BeginInit();
      ((ISupportInitialize)this.txtMaCT.Properties).BeginInit();
      ((ISupportInitialize)this.datToDate.Properties.CalendarTimeProperties).BeginInit();
      ((ISupportInitialize)this.datToDate.Properties).BeginInit();
      ((ISupportInitialize)this.datFromDate.Properties.CalendarTimeProperties).BeginInit();
      ((ISupportInitialize)this.datFromDate.Properties).BeginInit();
      ((ISupportInitialize)this.grpMaster).BeginInit();
      this.grpMaster.SuspendLayout();
      ((ISupportInitialize)this.grcCongTruong).BeginInit();
      ((ISupportInitialize)this.grvCongTruong).BeginInit();
      base.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[]
      {
                this.bar2
      });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new BarItem[]
      {
                this.bsiCaption,
                this.bbiInsert,
                this.bbiUpdate,
                this.bbiDelete,
                this.bbiView
      });
      this.barManager1.MainMenu = this.bar2;
      this.barManager1.MaxItemId = 5;
      this.bar2.BarName = "Main menu";
      this.bar2.DockCol = 0;
      this.bar2.DockRow = 0;
      this.bar2.DockStyle = BarDockStyle.Top;
      this.bar2.LinksPersistInfo.AddRange(new LinkPersistInfo[]
      {
                new LinkPersistInfo(this.bsiCaption),
                new LinkPersistInfo(this.bbiInsert),
                new LinkPersistInfo(this.bbiUpdate),
                new LinkPersistInfo(this.bbiDelete),
                new LinkPersistInfo(this.bbiView)
      });
      this.bar2.OptionsBar.MultiLine = true;
      this.bar2.OptionsBar.UseWholeRow = true;
      this.bar2.Text = "Main menu";
      this.bsiCaption.Caption = "Công Trường";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiInsert.Caption = "Thêm";
      this.bbiInsert.Id = 1;
      this.bbiInsert.ImageOptions.Image = ResourceNhua.add_file;
      this.bbiInsert.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.bbiInsert.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiInsert.Name = "bbiInsert";
      this.bbiInsert.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiInsert.ItemClick += this.bbiInsert_ItemClick;
      this.bbiUpdate.Caption = "Sửa";
      this.bbiUpdate.Id = 2;
      this.bbiUpdate.ImageOptions.Image = ResourceNhua.edit_file;
      this.bbiUpdate.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.bbiUpdate.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiUpdate.Name = "bbiUpdate";
      this.bbiUpdate.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiUpdate.ItemClick += this.bbiUpdate_ItemClick;
      this.bbiDelete.Caption = "Xoá";
      this.bbiDelete.Id = 3;
      this.bbiDelete.ImageOptions.Image = ResourceNhua.delete_file;
      this.bbiDelete.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.bbiDelete.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiDelete.Name = "bbiDelete";
      this.bbiDelete.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiDelete.ItemClick += this.bbiDelete_ItemClick;
      this.bbiView.Caption = "Xem";
      this.bbiView.Id = 4;
      this.bbiView.ImageOptions.Image = ResourceNhua.view_file;
      this.bbiView.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.bbiView.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiView.Name = "bbiView";
      this.bbiView.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiView.ItemClick += this.bbiView_ItemClick;
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Margin = new Padding(2);
      this.barDockControlTop.Size = new Size(981, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 594);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(2);
      this.barDockControlBottom.Size = new Size(981, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(2);
      this.barDockControlLeft.Size = new Size(0, 554);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(981, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(2);
      this.barDockControlRight.Size = new Size(0, 554);
      this.barStaticItem1.Caption = "Khách Hàng";
      this.barStaticItem1.Id = 5;
      this.barStaticItem1.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
      this.barStaticItem1.Name = "barStaticItem1";
      this.grcSearch.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.grcSearch.AppearanceCaption.Options.UseFont = true;
      this.grcSearch.Controls.Add(this.btnReset);
      this.grcSearch.Controls.Add(this.lblPhone);
      this.grcSearch.Controls.Add(this.lblActive);
      this.grcSearch.Controls.Add(this.lblAddress);
      this.grcSearch.Controls.Add(this.lblTenCongTruong);
      this.grcSearch.Controls.Add(this.lblMaCongTruong);
      this.grcSearch.Controls.Add(this.lblToDate);
      this.grcSearch.Controls.Add(this.btnSearch);
      this.grcSearch.Controls.Add(this.lueActive);
      this.grcSearch.Controls.Add(this.txtPhone);
      this.grcSearch.Controls.Add(this.txtDiaChi);
      this.grcSearch.Controls.Add(this.txtTenCT);
      this.grcSearch.Controls.Add(this.txtMaCT);
      this.grcSearch.Controls.Add(this.datToDate);
      this.grcSearch.Controls.Add(this.datFromDate);
      this.grcSearch.Controls.Add(this.lblFromDate);
      this.grcSearch.Dock = DockStyle.Right;
      this.grcSearch.Location = new Point(701, 40);
      this.grcSearch.Margin = new Padding(2);
      this.grcSearch.Name = "grcSearch";
      this.grcSearch.Size = new Size(280, 554);
      this.grcSearch.TabIndex = 4;
      this.grcSearch.Text = "Tìm kiếm";
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(15, 215);
      this.btnReset.Margin = new Padding(2);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(105, 35);
      this.btnReset.TabIndex = 91;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += this.btnReset_Click;
      this.lblPhone.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Location = new Point(15, 168);
      this.lblPhone.Margin = new Padding(2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(75, 16);
      this.lblPhone.TabIndex = 90;
      this.lblPhone.Text = "Số điện thoại";
      this.lblActive.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblActive.Appearance.Options.UseFont = true;
      this.lblActive.Location = new Point(13, 333);
      this.lblActive.Margin = new Padding(2);
      this.lblActive.Name = "lblActive";
      this.lblActive.Size = new Size(59, 16);
      this.lblActive.TabIndex = 89;
      this.lblActive.Text = "Trạng thái";
      this.lblActive.Visible = false;
      this.lblAddress.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblAddress.Appearance.Options.UseFont = true;
      this.lblAddress.Location = new Point(15, 296);
      this.lblAddress.Margin = new Padding(2);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new Size(39, 16);
      this.lblAddress.TabIndex = 88;
      this.lblAddress.Text = "Địa chỉ";
      this.lblAddress.Visible = false;
      this.lblTenCongTruong.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblTenCongTruong.Appearance.Options.UseFont = true;
      this.lblTenCongTruong.Location = new Point(15, 108);
      this.lblTenCongTruong.Margin = new Padding(2);
      this.lblTenCongTruong.Name = "lblTenCongTruong";
      this.lblTenCongTruong.Size = new Size(95, 16);
      this.lblTenCongTruong.TabIndex = 87;
      this.lblTenCongTruong.Text = "Tên công trường";
      this.lblMaCongTruong.AutoSize = true;
      this.lblMaCongTruong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblMaCongTruong.Location = new Point(12, 138);
      this.lblMaCongTruong.Margin = new Padding(2, 0, 2, 0);
      this.lblMaCongTruong.Name = "lblMaCongTruong";
      this.lblMaCongTruong.Size = new Size(98, 16);
      this.lblMaCongTruong.TabIndex = 86;
      this.lblMaCongTruong.Text = "Mã công trường";
      this.lblToDate.AutoSize = true;
      this.lblToDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblToDate.Location = new Point(12, 78);
      this.lblToDate.Margin = new Padding(2, 0, 2, 0);
      this.lblToDate.Name = "lblToDate";
      this.lblToDate.Size = new Size(62, 16);
      this.lblToDate.TabIndex = 85;
      this.lblToDate.Text = "Đến ngày";
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(157, 215);
      this.btnSearch.Margin = new Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(105, 35);
      this.btnSearch.TabIndex = 84;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += this.btnSearch_Click;
      this.lueActive.Location = new Point(112, 330);
      this.lueActive.Margin = new Padding(2);
      this.lueActive.MenuManager = this.barManager1;
      this.lueActive.Name = "lueActive";
      this.lueActive.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lueActive.Properties.Appearance.Options.UseFont = true;
      this.lueActive.Properties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.lueActive.Properties.Columns.AddRange(new LookUpColumnInfo[]
      {
                new LookUpColumnInfo("DisplayText", "Trạng thái", 40, FormatType.None, "", true, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default)
      });
      this.lueActive.Properties.DisplayMember = "DisplayText";
      this.lueActive.Properties.NullText = "";
      this.lueActive.Properties.ValueMember = "ID";
      this.lueActive.Size = new Size(150, 22);
      this.lueActive.TabIndex = 83;
      this.lueActive.Visible = false;
      this.txtPhone.Location = new Point(112, 165);
      this.txtPhone.Margin = new Padding(2);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.txtPhone.Properties.Appearance.Options.UseFont = true;
      this.txtPhone.Properties.Name = "txtPhone";
      this.txtPhone.Size = new Size(150, 22);
      this.txtPhone.TabIndex = 82;
      this.txtDiaChi.Location = new Point(112, 293);
      this.txtDiaChi.Margin = new Padding(2);
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
      this.txtDiaChi.Size = new Size(150, 22);
      this.txtDiaChi.TabIndex = 81;
      this.txtDiaChi.Visible = false;
      this.txtTenCT.Location = new Point(112, 105);
      this.txtTenCT.Margin = new Padding(2);
      this.txtTenCT.Name = "txtTenCT";
      this.txtTenCT.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.txtTenCT.Properties.Appearance.Options.UseFont = true;
      this.txtTenCT.Size = new Size(150, 22);
      this.txtTenCT.TabIndex = 80;
      this.txtMaCT.Location = new Point(112, 135);
      this.txtMaCT.Margin = new Padding(2);
      this.txtMaCT.Name = "txtMaCT";
      this.txtMaCT.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.txtMaCT.Properties.Appearance.Options.UseFont = true;
      this.txtMaCT.Size = new Size(150, 22);
      this.txtMaCT.TabIndex = 79;
      this.datToDate.EditValue = null;
      this.datToDate.Location = new Point(112, 75);
      this.datToDate.Margin = new Padding(2);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.datToDate.Properties.Appearance.Options.UseFont = true;
      this.datToDate.Properties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datToDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datToDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datToDate.Size = new Size(150, 22);
      this.datToDate.TabIndex = 78;
      this.datFromDate.EditValue = null;
      this.datFromDate.Location = new Point(112, 45);
      this.datFromDate.Margin = new Padding(2);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.datFromDate.Properties.Appearance.Options.UseFont = true;
      this.datFromDate.Properties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datFromDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datFromDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datFromDate.Size = new Size(150, 22);
      this.datFromDate.TabIndex = 77;
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(15, 48);
      this.lblFromDate.Margin = new Padding(2);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(73, 16);
      this.lblFromDate.TabIndex = 76;
      this.lblFromDate.Text = "Tạo Từ ngày";
      this.grpMaster.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.grpMaster.AppearanceCaption.Options.UseFont = true;
      this.grpMaster.Controls.Add(this.grcCongTruong);
      this.grpMaster.Dock = DockStyle.Fill;
      this.grpMaster.Location = new Point(0, 40);
      this.grpMaster.Margin = new Padding(2);
      this.grpMaster.Name = "grpMaster";
      this.grpMaster.Size = new Size(701, 554);
      this.grpMaster.TabIndex = 9;
      this.grpMaster.Text = "Dữ liệu";
      this.grcCongTruong.Dock = DockStyle.Fill;
      this.grcCongTruong.EmbeddedNavigator.Margin = new Padding(2);
      this.grcCongTruong.Location = new Point(2, 23);
      this.grcCongTruong.MainView = this.grvCongTruong;
      this.grcCongTruong.Margin = new Padding(2);
      this.grcCongTruong.MenuManager = this.barManager1;
      this.grcCongTruong.Name = "grcCongTruong";
      this.grcCongTruong.Size = new Size(697, 529);
      this.grcCongTruong.TabIndex = 0;
      this.grcCongTruong.ViewCollection.AddRange(new BaseView[]
      {
                this.grvCongTruong
      });
      this.grvCongTruong.Columns.AddRange(new GridColumn[]
      {
                this.gcMaCongTruong,
                this.gcTenCongTruong,
                this.gcDiaChi,
                this.gcPhone,
                this.gcGhiChu,
                this.gcActivated
      });
      this.grvCongTruong.DetailHeight = 284;
      this.grvCongTruong.GridControl = this.grcCongTruong;
      this.grvCongTruong.Name = "grvCongTruong";
      this.grvCongTruong.OptionsView.ShowFooter = true;
      this.gcMaCongTruong.Caption = "Mã Công trường";
      this.gcMaCongTruong.FieldName = "MaCongTruong";
      this.gcMaCongTruong.MinWidth = 19;
      this.gcMaCongTruong.Name = "gcMaCongTruong";
      this.gcMaCongTruong.OptionsColumn.AllowEdit = false;
      this.gcMaCongTruong.Visible = true;
      this.gcMaCongTruong.VisibleIndex = 0;
      this.gcMaCongTruong.Width = 70;
      this.gcTenCongTruong.Caption = "Tên Công Trường";
      this.gcTenCongTruong.FieldName = "TenCongTruong";
      this.gcTenCongTruong.MinWidth = 19;
      this.gcTenCongTruong.Name = "gcTenCongTruong";
      this.gcTenCongTruong.OptionsColumn.AllowEdit = false;
      this.gcTenCongTruong.Visible = true;
      this.gcTenCongTruong.VisibleIndex = 1;
      this.gcTenCongTruong.Width = 70;
      this.gcDiaChi.Caption = "Địa Chỉ";
      this.gcDiaChi.FieldName = "DiaChi";
      this.gcDiaChi.MinWidth = 19;
      this.gcDiaChi.Name = "gcDiaChi";
      this.gcDiaChi.OptionsColumn.AllowEdit = false;
      this.gcDiaChi.Visible = true;
      this.gcDiaChi.VisibleIndex = 2;
      this.gcDiaChi.Width = 70;
      this.gcPhone.Caption = "Phone";
      this.gcPhone.FieldName = "Phone";
      this.gcPhone.MinWidth = 19;
      this.gcPhone.Name = "gcPhone";
      this.gcPhone.OptionsColumn.AllowEdit = false;
      this.gcPhone.Visible = true;
      this.gcPhone.VisibleIndex = 3;
      this.gcPhone.Width = 70;
      this.gcGhiChu.Caption = "Ghi Chú";
      this.gcGhiChu.FieldName = "GhiChu";
      this.gcGhiChu.MinWidth = 19;
      this.gcGhiChu.Name = "gcGhiChu";
      this.gcGhiChu.OptionsColumn.AllowEdit = false;
      this.gcGhiChu.Visible = true;
      this.gcGhiChu.VisibleIndex = 4;
      this.gcGhiChu.Width = 70;
      this.gcActivated.Caption = "Active";
      this.gcActivated.FieldName = "Activated";
      this.gcActivated.MinWidth = 19;
      this.gcActivated.Name = "gcActivated";
      this.gcActivated.OptionsColumn.AllowEdit = false;
      this.gcActivated.Width = 70;
      base.AutoScaleDimensions = new SizeF(6f, 13f);
      base.AutoScaleMode = AutoScaleMode.Font;
      base.Controls.Add(this.grpMaster);
      base.Controls.Add(this.grcSearch);
      base.Controls.Add(this.barDockControlLeft);
      base.Controls.Add(this.barDockControlRight);
      base.Controls.Add(this.barDockControlBottom);
      base.Controls.Add(this.barDockControlTop);
      base.Name = "CongTruongMngView";
      base.Size = new Size(981, 594);
      ((ISupportInitialize)this.barManager1).EndInit();
      ((ISupportInitialize)this.grcSearch).EndInit();
      this.grcSearch.ResumeLayout(false);
      this.grcSearch.PerformLayout();
      ((ISupportInitialize)this.lueActive.Properties).EndInit();
      ((ISupportInitialize)this.txtPhone.Properties).EndInit();
      ((ISupportInitialize)this.txtDiaChi.Properties).EndInit();
      ((ISupportInitialize)this.txtTenCT.Properties).EndInit();
      ((ISupportInitialize)this.txtMaCT.Properties).EndInit();
      ((ISupportInitialize)this.datToDate.Properties.CalendarTimeProperties).EndInit();
      ((ISupportInitialize)this.datToDate.Properties).EndInit();
      ((ISupportInitialize)this.datFromDate.Properties.CalendarTimeProperties).EndInit();
      ((ISupportInitialize)this.datFromDate.Properties).EndInit();
      ((ISupportInitialize)this.grpMaster).EndInit();
      this.grpMaster.ResumeLayout(false);
      ((ISupportInitialize)this.grcCongTruong).EndInit();
      ((ISupportInitialize)this.grvCongTruong).EndInit();
      base.ResumeLayout(false);
      base.PerformLayout();
    }
  }
}

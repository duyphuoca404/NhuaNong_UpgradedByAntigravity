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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace NhuaNong.MasterData
{
  public partial class HopDongMngView
  {
    private IContainer components;

    // Token: 0x04000B4A RID: 2890
    private BarManager barManager1;

    // Token: 0x04000B4B RID: 2891
    private BarDockControl barDockControlTop;

    // Token: 0x04000B4C RID: 2892
    private BarDockControl barDockControlBottom;

    // Token: 0x04000B4D RID: 2893
    private BarDockControl barDockControlLeft;

    // Token: 0x04000B4E RID: 2894
    private BarDockControl barDockControlRight;

    // Token: 0x04000B4F RID: 2895
    private BarButtonItem bbiInsert;

    // Token: 0x04000B50 RID: 2896
    private BarButtonItem bbiUpdate;

    // Token: 0x04000B51 RID: 2897
    private BarButtonItem bbiDelete;

    // Token: 0x04000B52 RID: 2898
    private BarButtonItem bbiView;

    // Token: 0x04000B53 RID: 2899
    private BarCheckItem barCheckItem1;

    // Token: 0x04000B54 RID: 2900
    private GroupControl grpMaster;

    // Token: 0x04000B55 RID: 2901
    private GroupControl grpSearch;

    // Token: 0x04000B56 RID: 2902
    private SimpleButton btnReset;

    // Token: 0x04000B57 RID: 2903
    private LabelControl lblActive;

    // Token: 0x04000B58 RID: 2904
    private Label lblMaHopDong;

    // Token: 0x04000B59 RID: 2905
    private Label lblToDate;

    // Token: 0x04000B5A RID: 2906
    private SimpleButton btnSearch;

    // Token: 0x04000B5B RID: 2907
    private LookUpEdit lueHDStatus;

    // Token: 0x04000B5C RID: 2908
    private TextEdit txtMaHopDong;

    // Token: 0x04000B5D RID: 2909
    private DateEdit datDenNgay;

    // Token: 0x04000B5E RID: 2910
    private DateEdit datTuNgay;

    // Token: 0x04000B5F RID: 2911
    private LabelControl lblFromDate;

    // Token: 0x04000B60 RID: 2912
    private LookUpEdit lueMAC;

    // Token: 0x04000B61 RID: 2913
    private LabelControl lblMAC;

    // Token: 0x04000B62 RID: 2914
    private LookUpEdit lueCongTruong;

    // Token: 0x04000B63 RID: 2915
    private LabelControl lblCongTruong;

    // Token: 0x04000B64 RID: 2916
    private LookUpEdit lueKhachHang;

    // Token: 0x04000B65 RID: 2917
    private LabelControl lblKhachHang;

    // Token: 0x04000B66 RID: 2918
    private GridControl grcHopDong;

    // Token: 0x04000B67 RID: 2919
    private GridView grvHopDong;

    // Token: 0x04000B68 RID: 2920
    private GridColumn gcMaHopDong;

    // Token: 0x04000B69 RID: 2921
    private GridColumn gcTenHopDong;

    // Token: 0x04000B6A RID: 2922
    private GridColumn gcNgayHopDong;

    // Token: 0x04000B6B RID: 2923
    private GridColumn gcKhachHang;

    // Token: 0x04000B6C RID: 2924
    private GridColumn gcCongTruong;

    // Token: 0x04000B6D RID: 2925
    private GridColumn gcMAC;

    // Token: 0x04000B6E RID: 2926
    private GridColumn gcStatus;

    // Token: 0x04000B6F RID: 2927
    private GridColumn gcKLDatHang;

    // Token: 0x04000B70 RID: 2928
    private GridColumn gcKLDaGiao;

    // Token: 0x04000B71 RID: 2929
    private GridColumn gcKLTaoPhieuTron;

    // Token: 0x04000B72 RID: 2930
    private GridColumn gcMoTa;

    // Token: 0x04000B73 RID: 2931
    private RepositoryItemLookUpEdit ilueHDStatus;

    // Token: 0x04000B74 RID: 2932
    private RepositoryItemTextEdit itedKhachHang;

    // Token: 0x04000B75 RID: 2933
    private RepositoryItemLookUpEdit illueKhachHang;

    // Token: 0x04000B76 RID: 2934
    private RepositoryItemLookUpEdit ilueCongTruong;

    // Token: 0x04000B77 RID: 2935
    private RepositoryItemLookUpEdit ilueMAC;

    // Token: 0x04000B78 RID: 2936
    private BarButtonItem barButtonItem1;

    // Token: 0x04000B79 RID: 2937
    private Bar barButtons;

    // Token: 0x04000B7A RID: 2938
    private BarStaticItem bsiCaption;
    // Token: 0x06000E87 RID: 3719 RVA: 0x000812D0 File Offset: 0x0007F4D0
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    // Token: 0x06000E88 RID: 3720 RVA: 0x000812F0 File Offset: 0x0007F4F0
    private void InitializeComponent()
    {
      this.components = new Container();
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
      ((ISupportInitialize)this.barManager1).BeginInit();
      ((ISupportInitialize)this.grpSearch).BeginInit();
      this.grpSearch.SuspendLayout();
      ((ISupportInitialize)this.lueMAC.Properties).BeginInit();
      ((ISupportInitialize)this.lueCongTruong.Properties).BeginInit();
      ((ISupportInitialize)this.lueKhachHang.Properties).BeginInit();
      ((ISupportInitialize)this.lueHDStatus.Properties).BeginInit();
      ((ISupportInitialize)this.txtMaHopDong.Properties).BeginInit();
      ((ISupportInitialize)this.datDenNgay.Properties).BeginInit();
      ((ISupportInitialize)this.datDenNgay.Properties.CalendarTimeProperties).BeginInit();
      ((ISupportInitialize)this.datTuNgay.Properties).BeginInit();
      ((ISupportInitialize)this.datTuNgay.Properties.CalendarTimeProperties).BeginInit();
      ((ISupportInitialize)this.grpMaster).BeginInit();
      this.grpMaster.SuspendLayout();
      ((ISupportInitialize)this.grcHopDong).BeginInit();
      ((ISupportInitialize)this.grvHopDong).BeginInit();
      ((ISupportInitialize)this.illueKhachHang).BeginInit();
      ((ISupportInitialize)this.ilueCongTruong).BeginInit();
      ((ISupportInitialize)this.ilueMAC).BeginInit();
      ((ISupportInitialize)this.ilueHDStatus).BeginInit();
      ((ISupportInitialize)this.itedKhachHang).BeginInit();
      base.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[]
      {
                this.barButtons
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
                this.barCheckItem1,
                this.bbiDelete,
                this.bbiView,
                this.barButtonItem1
      });
      this.barManager1.MainMenu = this.barButtons;
      this.barManager1.MaxItemId = 7;
      this.barButtons.BarName = "Main menu";
      this.barButtons.CanDockStyle = BarCanDockStyle.Top;
      this.barButtons.DockCol = 0;
      this.barButtons.DockRow = 0;
      this.barButtons.DockStyle = BarDockStyle.Top;
      this.barButtons.FloatLocation = new Point(311, 180);
      this.barButtons.LinksPersistInfo.AddRange(new LinkPersistInfo[]
      {
                new LinkPersistInfo(this.bsiCaption),
                new LinkPersistInfo(this.bbiInsert),
                new LinkPersistInfo(this.bbiUpdate),
                new LinkPersistInfo(this.bbiDelete),
                new LinkPersistInfo(this.bbiView),
                new LinkPersistInfo(this.barButtonItem1)
      });
      this.barButtons.OptionsBar.UseWholeRow = true;
      this.barButtons.Text = "Main menu";
      this.bsiCaption.Alignment = BarItemLinkAlignment.Left;
      this.bsiCaption.Caption = "Hợp đồng";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiInsert.Alignment = BarItemLinkAlignment.Left;
      this.bbiInsert.Caption = "Thêm";
      this.bbiInsert.Id = 1;
      this.bbiInsert.ImageOptions.Image = ResourceNhua.add_file;
      this.bbiInsert.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.bbiInsert.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiInsert.Name = "bbiInsert";
      this.bbiInsert.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiInsert.ItemClick += this.barButtonItem1_ItemClick;
      this.bbiUpdate.Alignment = BarItemLinkAlignment.Left;
      this.bbiUpdate.Caption = "Sửa";
      this.bbiUpdate.Id = 2;
      this.bbiUpdate.ImageOptions.Image = ResourceNhua.edit_file;
      this.bbiUpdate.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.bbiUpdate.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiUpdate.Name = "bbiUpdate";
      this.bbiUpdate.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiUpdate.ItemClick += this.barButtonItem2_ItemClick;
      this.bbiDelete.Alignment = BarItemLinkAlignment.Left;
      this.bbiDelete.Caption = "Xoá";
      this.bbiDelete.Id = 4;
      this.bbiDelete.ImageOptions.Image = ResourceNhua.delete_file;
      this.bbiDelete.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.bbiDelete.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiDelete.Name = "bbiDelete";
      this.bbiDelete.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiDelete.ItemClick += this.barButtonItem3_ItemClick;
      this.bbiView.Alignment = BarItemLinkAlignment.Left;
      this.bbiView.Caption = "Xem";
      this.bbiView.Id = 5;
      this.bbiView.ImageOptions.Image = ResourceNhua.view_file;
      this.bbiView.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.bbiView.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiView.Name = "bbiView";
      this.bbiView.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiView.ItemClick += this.barButtonItem4_ItemClick;
      this.barButtonItem1.Caption = "Tạo Phiếu trộn";
      this.barButtonItem1.Id = 6;
      this.barButtonItem1.Name = "barButtonItem1";
      this.barButtonItem1.Visibility = BarItemVisibility.Never;
      this.barButtonItem1.ItemClick += this.barButtonItem1_ItemClick_1;
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
      this.grpSearch.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.grpSearch.AppearanceCaption.Options.UseFont = true;
      this.grpSearch.Controls.Add(this.lueMAC);
      this.grpSearch.Controls.Add(this.lblMAC);
      this.grpSearch.Controls.Add(this.lueCongTruong);
      this.grpSearch.Controls.Add(this.lblCongTruong);
      this.grpSearch.Controls.Add(this.lueKhachHang);
      this.grpSearch.Controls.Add(this.lblKhachHang);
      this.grpSearch.Controls.Add(this.btnReset);
      this.grpSearch.Controls.Add(this.lblActive);
      this.grpSearch.Controls.Add(this.lblMaHopDong);
      this.grpSearch.Controls.Add(this.lblToDate);
      this.grpSearch.Controls.Add(this.btnSearch);
      this.grpSearch.Controls.Add(this.lueHDStatus);
      this.grpSearch.Controls.Add(this.txtMaHopDong);
      this.grpSearch.Controls.Add(this.datDenNgay);
      this.grpSearch.Controls.Add(this.datTuNgay);
      this.grpSearch.Controls.Add(this.lblFromDate);
      this.grpSearch.Dock = DockStyle.Right;
      this.grpSearch.Location = new Point(611, 40);
      this.grpSearch.Margin = new Padding(2);
      this.grpSearch.Name = "grpSearch";
      this.grpSearch.Size = new Size(280, 610);
      this.grpSearch.TabIndex = 4;
      this.grpSearch.Tag = "2";
      this.grpSearch.Text = "Tìm kiếm";
      this.lueMAC.Location = new Point(112, 195);
      this.lueMAC.Margin = new Padding(2);
      this.lueMAC.MenuManager = this.barManager1;
      this.lueMAC.Name = "lueMAC";
      this.lueMAC.Properties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.lueMAC.Properties.Columns.AddRange(new LookUpColumnInfo[]
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
      this.lblMAC.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblMAC.Appearance.Options.UseFont = true;
      this.lblMAC.Location = new Point(19, 196);
      this.lblMAC.Margin = new Padding(2);
      this.lblMAC.Name = "lblMAC";
      this.lblMAC.Size = new Size(26, 16);
      this.lblMAC.TabIndex = 106;
      this.lblMAC.Text = "MAC";
      this.lueCongTruong.Location = new Point(112, 165);
      this.lueCongTruong.Margin = new Padding(2);
      this.lueCongTruong.MenuManager = this.barManager1;
      this.lueCongTruong.Name = "lueCongTruong";
      this.lueCongTruong.Properties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.lueCongTruong.Properties.Columns.AddRange(new LookUpColumnInfo[]
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
      this.lblCongTruong.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblCongTruong.Appearance.Options.UseFont = true;
      this.lblCongTruong.Location = new Point(19, 166);
      this.lblCongTruong.Margin = new Padding(2);
      this.lblCongTruong.Name = "lblCongTruong";
      this.lblCongTruong.Size = new Size(71, 16);
      this.lblCongTruong.TabIndex = 104;
      this.lblCongTruong.Text = "Công trường";
      this.lueKhachHang.Location = new Point(112, 135);
      this.lueKhachHang.Margin = new Padding(2);
      this.lueKhachHang.MenuManager = this.barManager1;
      this.lueKhachHang.Name = "lueKhachHang";
      this.lueKhachHang.Properties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.lueKhachHang.Properties.Columns.AddRange(new LookUpColumnInfo[]
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
      this.lblKhachHang.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblKhachHang.Appearance.Options.UseFont = true;
      this.lblKhachHang.Location = new Point(19, 136);
      this.lblKhachHang.Margin = new Padding(2);
      this.lblKhachHang.Name = "lblKhachHang";
      this.lblKhachHang.Size = new Size(66, 16);
      this.lblKhachHang.TabIndex = 102;
      this.lblKhachHang.Text = "Khách hàng";
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(19, 275);
      this.btnReset.Margin = new Padding(2);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(105, 35);
      this.btnReset.TabIndex = 101;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += this.btnReset_Click;
      this.lblActive.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblActive.Appearance.Options.UseFont = true;
      this.lblActive.Location = new Point(19, 226);
      this.lblActive.Margin = new Padding(2);
      this.lblActive.Name = "lblActive";
      this.lblActive.Size = new Size(59, 16);
      this.lblActive.TabIndex = 100;
      this.lblActive.Text = "Trạng thái";
      this.lblMaHopDong.AutoSize = true;
      this.lblMaHopDong.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblMaHopDong.Location = new Point(16, 106);
      this.lblMaHopDong.Margin = new Padding(2, 0, 2, 0);
      this.lblMaHopDong.Name = "lblMaHopDong";
      this.lblMaHopDong.Size = new Size(82, 16);
      this.lblMaHopDong.TabIndex = 99;
      this.lblMaHopDong.Text = "Mã Hợp đồng";
      this.lblToDate.AutoSize = true;
      this.lblToDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblToDate.Location = new Point(16, 76);
      this.lblToDate.Margin = new Padding(2, 0, 2, 0);
      this.lblToDate.Name = "lblToDate";
      this.lblToDate.Size = new Size(61, 16);
      this.lblToDate.TabIndex = 98;
      this.lblToDate.Text = "Đến ngày";
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(155, 275);
      this.btnSearch.Margin = new Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(105, 35);
      this.btnSearch.TabIndex = 97;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += this.btnSearch_Click;
      this.lueHDStatus.Location = new Point(112, 225);
      this.lueHDStatus.Margin = new Padding(2);
      this.lueHDStatus.MenuManager = this.barManager1;
      this.lueHDStatus.Name = "lueHDStatus";
      this.lueHDStatus.Properties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.lueHDStatus.Properties.Columns.AddRange(new LookUpColumnInfo[]
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
      this.datDenNgay.EditValue = null;
      this.datDenNgay.Location = new Point(112, 75);
      this.datDenNgay.Margin = new Padding(2);
      this.datDenNgay.Name = "datDenNgay";
      this.datDenNgay.Properties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.datDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[]
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
      this.datTuNgay.EditValue = null;
      this.datTuNgay.Location = new Point(112, 45);
      this.datTuNgay.Margin = new Padding(2);
      this.datTuNgay.Name = "datTuNgay";
      this.datTuNgay.Properties.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.datTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[]
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
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(19, 46);
      this.lblFromDate.Margin = new Padding(2);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(73, 16);
      this.lblFromDate.TabIndex = 92;
      this.lblFromDate.Text = "Tạo Từ ngày";
      this.grpMaster.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.grpMaster.AppearanceCaption.Options.UseFont = true;
      this.grpMaster.Controls.Add(this.grcHopDong);
      this.grpMaster.Dock = DockStyle.Fill;
      this.grpMaster.Location = new Point(0, 40);
      this.grpMaster.Margin = new Padding(2);
      this.grpMaster.Name = "grpMaster";
      this.grpMaster.Size = new Size(611, 610);
      this.grpMaster.TabIndex = 5;
      this.grpMaster.Tag = "1";
      this.grpMaster.Text = "Dữ liệu";
      this.grcHopDong.Dock = DockStyle.Fill;
      this.grcHopDong.EmbeddedNavigator.Margin = new Padding(2);
      this.grcHopDong.Location = new Point(2, 23);
      this.grcHopDong.MainView = this.grvHopDong;
      this.grcHopDong.Margin = new Padding(2);
      this.grcHopDong.MenuManager = this.barManager1;
      this.grcHopDong.Name = "grcHopDong";
      this.grcHopDong.RepositoryItems.AddRange(new RepositoryItem[]
      {
                this.ilueHDStatus,
                this.itedKhachHang,
                this.illueKhachHang,
                this.ilueCongTruong,
                this.ilueMAC
      });
      this.grcHopDong.Size = new Size(607, 585);
      this.grcHopDong.TabIndex = 0;
      this.grcHopDong.ViewCollection.AddRange(new BaseView[]
      {
                this.grvHopDong
      });
      this.grvHopDong.Columns.AddRange(new GridColumn[]
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
      this.gcKhachHang.ColumnEdit = this.illueKhachHang;
      this.gcKhachHang.FieldName = "KhachHangID";
      this.gcKhachHang.MinWidth = 150;
      this.gcKhachHang.Name = "gcKhachHang";
      this.gcKhachHang.OptionsColumn.AllowEdit = false;
      this.gcKhachHang.Visible = true;
      this.gcKhachHang.VisibleIndex = 3;
      this.gcKhachHang.Width = 150;
      this.illueKhachHang.AutoHeight = false;
      this.illueKhachHang.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.illueKhachHang.DisplayMember = "TenKhachHang";
      this.illueKhachHang.Name = "illueKhachHang";
      this.illueKhachHang.NullText = "";
      this.illueKhachHang.ValueMember = "KhachHangID";
      this.gcCongTruong.Caption = "Công Trường";
      this.gcCongTruong.ColumnEdit = this.ilueCongTruong;
      this.gcCongTruong.FieldName = "CongTruongID";
      this.gcCongTruong.MinWidth = 150;
      this.gcCongTruong.Name = "gcCongTruong";
      this.gcCongTruong.OptionsColumn.AllowEdit = false;
      this.gcCongTruong.Visible = true;
      this.gcCongTruong.VisibleIndex = 4;
      this.gcCongTruong.Width = 150;
      this.ilueCongTruong.AutoHeight = false;
      this.ilueCongTruong.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueCongTruong.DisplayMember = "TenCongTruong";
      this.ilueCongTruong.Name = "ilueCongTruong";
      this.ilueCongTruong.ValueMember = "CongTruongID";
      this.gcMAC.Caption = "MAC";
      this.gcMAC.ColumnEdit = this.ilueMAC;
      this.gcMAC.FieldName = "MACID";
      this.gcMAC.MinWidth = 150;
      this.gcMAC.Name = "gcMAC";
      this.gcMAC.OptionsColumn.AllowEdit = false;
      this.gcMAC.Visible = true;
      this.gcMAC.VisibleIndex = 5;
      this.gcMAC.Width = 160;
      this.ilueMAC.AutoHeight = false;
      this.ilueMAC.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueMAC.DisplayMember = "TenMAC";
      this.ilueMAC.Name = "ilueMAC";
      this.ilueMAC.ValueMember = "MACID";
      this.gcStatus.Caption = "Trạng Thái";
      this.gcStatus.ColumnEdit = this.ilueHDStatus;
      this.gcStatus.FieldName = "Status";
      this.gcStatus.MinWidth = 150;
      this.gcStatus.Name = "gcStatus";
      this.gcStatus.OptionsColumn.AllowEdit = false;
      this.gcStatus.Visible = true;
      this.gcStatus.VisibleIndex = 6;
      this.gcStatus.Width = 150;
      this.ilueHDStatus.AutoHeight = false;
      this.ilueHDStatus.Buttons.AddRange(new EditorButton[]
      {
                new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueHDStatus.Columns.AddRange(new LookUpColumnInfo[]
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
      base.AutoScaleDimensions = new SizeF(6f, 13f);
      base.AutoScaleMode = AutoScaleMode.Font;
      base.Controls.Add(this.grpMaster);
      base.Controls.Add(this.grpSearch);
      base.Controls.Add(this.barDockControlLeft);
      base.Controls.Add(this.barDockControlRight);
      base.Controls.Add(this.barDockControlBottom);
      base.Controls.Add(this.barDockControlTop);
      base.Name = "HopDongMngView";
      base.Size = new Size(891, 650);
      base.Tag = "qw";
      ((ISupportInitialize)this.barManager1).EndInit();
      ((ISupportInitialize)this.grpSearch).EndInit();
      this.grpSearch.ResumeLayout(false);
      this.grpSearch.PerformLayout();
      ((ISupportInitialize)this.lueMAC.Properties).EndInit();
      ((ISupportInitialize)this.lueCongTruong.Properties).EndInit();
      ((ISupportInitialize)this.lueKhachHang.Properties).EndInit();
      ((ISupportInitialize)this.lueHDStatus.Properties).EndInit();
      ((ISupportInitialize)this.txtMaHopDong.Properties).EndInit();
      ((ISupportInitialize)this.datDenNgay.Properties.CalendarTimeProperties).EndInit();
      ((ISupportInitialize)this.datDenNgay.Properties).EndInit();
      ((ISupportInitialize)this.datTuNgay.Properties.CalendarTimeProperties).EndInit();
      ((ISupportInitialize)this.datTuNgay.Properties).EndInit();
      ((ISupportInitialize)this.grpMaster).EndInit();
      this.grpMaster.ResumeLayout(false);
      ((ISupportInitialize)this.grcHopDong).EndInit();
      ((ISupportInitialize)this.grvHopDong).EndInit();
      ((ISupportInitialize)this.illueKhachHang).EndInit();
      ((ISupportInitialize)this.ilueCongTruong).EndInit();
      ((ISupportInitialize)this.ilueMAC).EndInit();
      ((ISupportInitialize)this.ilueHDStatus).EndInit();
      ((ISupportInitialize)this.itedKhachHang).EndInit();
      base.ResumeLayout(false);
      base.PerformLayout();
    }
  }
}

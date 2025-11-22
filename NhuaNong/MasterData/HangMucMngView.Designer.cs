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
  public partial class HangMucMngView
  {
    private IContainer components;
    private SimpleButton btnReset;
    private LabelControl lblActive;
    private LabelControl lblTenHangMuc;
    private Label lblMaHangMuc;
    private Label lblToDate;
    private SimpleButton btnSearch;
    private LookUpEdit lueActive;
    private BarManager barManager1;
    private Bar bar2;
    private BarStaticItem bsiCaption;
    private BarButtonItem bbiInsert;
    private BarButtonItem bbiUpdate;
    private BarButtonItem bbiDelete;
    private BarButtonItem bbiView;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private GroupControl grcMaster;
    private GridControl grcHangMuc;
    private GridView grvHangMuc;
    private GridColumn gcMaHangMuc;
    private GridColumn gcTenHangMuc;
    private GridColumn gcGhiChu;
    private GridColumn gcActivated;
    private GroupControl grcSearch;
    private TextEdit txtTenHM;
    private TextEdit txtMaHM;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl lblFromDate;
    // Token: 0x06000950 RID: 2384 RVA: 0x000587D4 File Offset: 0x000569D4
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    // Token: 0x06000951 RID: 2385 RVA: 0x000587F4 File Offset: 0x000569F4
    private void InitializeComponent()
    {
      this.components = new Container();
      this.btnReset = new SimpleButton();
      this.lblActive = new LabelControl();
      this.lblTenHangMuc = new LabelControl();
      this.lblMaHangMuc = new Label();
      this.lblToDate = new Label();
      this.btnSearch = new SimpleButton();
      this.lueActive = new LookUpEdit();
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
      this.txtTenHM = new TextEdit();
      this.txtMaHM = new TextEdit();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.lblFromDate = new LabelControl();
      this.grcMaster = new GroupControl();
      this.grcHangMuc = new GridControl();
      this.grvHangMuc = new GridView();
      this.gcMaHangMuc = new GridColumn();
      this.gcTenHangMuc = new GridColumn();
      this.gcGhiChu = new GridColumn();
      this.gcActivated = new GridColumn();
      this.grcSearch = new GroupControl();
      ((ISupportInitialize)this.lueActive.Properties).BeginInit();
      ((ISupportInitialize)this.barManager1).BeginInit();
      ((ISupportInitialize)this.txtTenHM.Properties).BeginInit();
      ((ISupportInitialize)this.txtMaHM.Properties).BeginInit();
      ((ISupportInitialize)this.datToDate.Properties.CalendarTimeProperties).BeginInit();
      ((ISupportInitialize)this.datToDate.Properties).BeginInit();
      ((ISupportInitialize)this.datFromDate.Properties.CalendarTimeProperties).BeginInit();
      ((ISupportInitialize)this.datFromDate.Properties).BeginInit();
      ((ISupportInitialize)this.grcMaster).BeginInit();
      this.grcMaster.SuspendLayout();
      ((ISupportInitialize)this.grcHangMuc).BeginInit();
      ((ISupportInitialize)this.grvHangMuc).BeginInit();
      ((ISupportInitialize)this.grcSearch).BeginInit();
      this.grcSearch.SuspendLayout();
      base.SuspendLayout();
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(21, 185);
      this.btnReset.Margin = new Padding(2);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(105, 35);
      this.btnReset.TabIndex = 107;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += this.btnReset_Click;
      this.lblActive.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblActive.Appearance.Options.UseFont = true;
      this.lblActive.Location = new Point(21, 261);
      this.lblActive.Margin = new Padding(2);
      this.lblActive.Name = "lblActive";
      this.lblActive.Size = new Size(59, 16);
      this.lblActive.TabIndex = 105;
      this.lblActive.Text = "Trạng thái";
      this.lblActive.Visible = false;
      this.lblTenHangMuc.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblTenHangMuc.Appearance.Options.UseFont = true;
      this.lblTenHangMuc.Location = new Point(21, 138);
      this.lblTenHangMuc.Margin = new Padding(2);
      this.lblTenHangMuc.Name = "lblTenHangMuc";
      this.lblTenHangMuc.Size = new Size(82, 16);
      this.lblTenHangMuc.TabIndex = 103;
      this.lblTenHangMuc.Text = "Tên hạng mục";
      this.lblMaHangMuc.AutoSize = true;
      this.lblMaHangMuc.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblMaHangMuc.Location = new Point(18, 108);
      this.lblMaHangMuc.Margin = new Padding(2, 0, 2, 0);
      this.lblMaHangMuc.Name = "lblMaHangMuc";
      this.lblMaHangMuc.Size = new Size(85, 16);
      this.lblMaHangMuc.TabIndex = 102;
      this.lblMaHangMuc.Text = "Mã hạng mục";
      this.lblToDate.AutoSize = true;
      this.lblToDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblToDate.Location = new Point(18, 78);
      this.lblToDate.Margin = new Padding(2, 0, 2, 0);
      this.lblToDate.Name = "lblToDate";
      this.lblToDate.Size = new Size(62, 16);
      this.lblToDate.TabIndex = 101;
      this.lblToDate.Text = "Đến ngày";
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(157, 185);
      this.btnSearch.Margin = new Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(105, 35);
      this.btnSearch.TabIndex = 100;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += this.btnSearch_Click;
      this.lueActive.Location = new Point(112, 258);
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
      this.lueActive.TabIndex = 99;
      this.lueActive.Visible = false;
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
      this.bsiCaption.Caption = "Hạng mục";
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
      this.barDockControlTop.Size = new Size(1037, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 560);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(2);
      this.barDockControlBottom.Size = new Size(1037, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(2);
      this.barDockControlLeft.Size = new Size(0, 520);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(1037, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(2);
      this.barDockControlRight.Size = new Size(0, 520);
      this.txtTenHM.Location = new Point(112, 135);
      this.txtTenHM.Margin = new Padding(2);
      this.txtTenHM.Name = "txtTenHM";
      this.txtTenHM.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.txtTenHM.Properties.Appearance.Options.UseFont = true;
      this.txtTenHM.Size = new Size(150, 22);
      this.txtTenHM.TabIndex = 96;
      this.txtMaHM.Location = new Point(112, 105);
      this.txtMaHM.Margin = new Padding(2);
      this.txtMaHM.Name = "txtMaHM";
      this.txtMaHM.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.txtMaHM.Properties.Appearance.Options.UseFont = true;
      this.txtMaHM.Size = new Size(150, 22);
      this.txtMaHM.TabIndex = 95;
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
      this.datToDate.TabIndex = 94;
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
      this.datFromDate.TabIndex = 93;
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(21, 48);
      this.lblFromDate.Margin = new Padding(2);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(73, 16);
      this.lblFromDate.TabIndex = 92;
      this.lblFromDate.Text = "Tạo Từ ngày";
      this.grcMaster.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.grcMaster.AppearanceCaption.Options.UseFont = true;
      this.grcMaster.Controls.Add(this.grcHangMuc);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(757, 520);
      this.grcMaster.TabIndex = 9;
      this.grcMaster.Text = "Dữ liệu";
      this.grcHangMuc.Dock = DockStyle.Fill;
      this.grcHangMuc.EmbeddedNavigator.Margin = new Padding(2);
      this.grcHangMuc.Location = new Point(2, 23);
      this.grcHangMuc.MainView = this.grvHangMuc;
      this.grcHangMuc.Margin = new Padding(2);
      this.grcHangMuc.MenuManager = this.barManager1;
      this.grcHangMuc.Name = "grcHangMuc";
      this.grcHangMuc.Size = new Size(753, 495);
      this.grcHangMuc.TabIndex = 0;
      this.grcHangMuc.ViewCollection.AddRange(new BaseView[]
      {
                this.grvHangMuc
      });
      this.grvHangMuc.Columns.AddRange(new GridColumn[]
      {
                this.gcMaHangMuc,
                this.gcTenHangMuc,
                this.gcGhiChu,
                this.gcActivated
      });
      this.grvHangMuc.DetailHeight = 284;
      this.grvHangMuc.GridControl = this.grcHangMuc;
      this.grvHangMuc.Name = "grvHangMuc";
      this.grvHangMuc.OptionsView.ShowFooter = true;
      this.gcMaHangMuc.Caption = "Mã Hạng mục";
      this.gcMaHangMuc.FieldName = "MaHangMuc";
      this.gcMaHangMuc.MinWidth = 22;
      this.gcMaHangMuc.Name = "gcMaHangMuc";
      this.gcMaHangMuc.Visible = true;
      this.gcMaHangMuc.VisibleIndex = 0;
      this.gcMaHangMuc.Width = 80;
      this.gcTenHangMuc.Caption = "Tên Hạng mục";
      this.gcTenHangMuc.FieldName = "TenHangMuc";
      this.gcTenHangMuc.MinWidth = 22;
      this.gcTenHangMuc.Name = "gcTenHangMuc";
      this.gcTenHangMuc.Visible = true;
      this.gcTenHangMuc.VisibleIndex = 1;
      this.gcTenHangMuc.Width = 80;
      this.gcGhiChu.Caption = "Ghi Chú";
      this.gcGhiChu.FieldName = "GhiChu";
      this.gcGhiChu.MinWidth = 22;
      this.gcGhiChu.Name = "gcGhiChu";
      this.gcGhiChu.Visible = true;
      this.gcGhiChu.VisibleIndex = 2;
      this.gcGhiChu.Width = 80;
      this.gcActivated.Caption = "Active";
      this.gcActivated.FieldName = "Activated";
      this.gcActivated.MinWidth = 22;
      this.gcActivated.Name = "gcActivated";
      this.gcActivated.Width = 80;
      this.grcSearch.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.grcSearch.AppearanceCaption.Options.UseFont = true;
      this.grcSearch.Controls.Add(this.btnReset);
      this.grcSearch.Controls.Add(this.lblActive);
      this.grcSearch.Controls.Add(this.lblTenHangMuc);
      this.grcSearch.Controls.Add(this.lblMaHangMuc);
      this.grcSearch.Controls.Add(this.lblToDate);
      this.grcSearch.Controls.Add(this.btnSearch);
      this.grcSearch.Controls.Add(this.lueActive);
      this.grcSearch.Controls.Add(this.txtTenHM);
      this.grcSearch.Controls.Add(this.txtMaHM);
      this.grcSearch.Controls.Add(this.datToDate);
      this.grcSearch.Controls.Add(this.datFromDate);
      this.grcSearch.Controls.Add(this.lblFromDate);
      this.grcSearch.Dock = DockStyle.Right;
      this.grcSearch.Location = new Point(757, 40);
      this.grcSearch.Margin = new Padding(2);
      this.grcSearch.Name = "grcSearch";
      this.grcSearch.Size = new Size(280, 520);
      this.grcSearch.TabIndex = 8;
      this.grcSearch.Text = "Tìm kiếm";
      base.AutoScaleDimensions = new SizeF(6f, 13f);
      base.AutoScaleMode = AutoScaleMode.Font;
      base.Controls.Add(this.grcMaster);
      base.Controls.Add(this.grcSearch);
      base.Controls.Add(this.barDockControlLeft);
      base.Controls.Add(this.barDockControlRight);
      base.Controls.Add(this.barDockControlBottom);
      base.Controls.Add(this.barDockControlTop);
      this.Name = "HangMucMngView";
      base.Size = new Size(1037, 560);
      ((ISupportInitialize)this.lueActive.Properties).EndInit();
      ((ISupportInitialize)this.barManager1).EndInit();
      ((ISupportInitialize)this.txtTenHM.Properties).EndInit();
      ((ISupportInitialize)this.txtMaHM.Properties).EndInit();
      ((ISupportInitialize)this.datToDate.Properties.CalendarTimeProperties).EndInit();
      ((ISupportInitialize)this.datToDate.Properties).EndInit();
      ((ISupportInitialize)this.datFromDate.Properties.CalendarTimeProperties).EndInit();
      ((ISupportInitialize)this.datFromDate.Properties).EndInit();
      ((ISupportInitialize)this.grcMaster).EndInit();
      this.grcMaster.ResumeLayout(false);
      ((ISupportInitialize)this.grcHangMuc).EndInit();
      ((ISupportInitialize)this.grvHangMuc).EndInit();
      ((ISupportInitialize)this.grcSearch).EndInit();
      this.grcSearch.ResumeLayout(false);
      this.grcSearch.PerformLayout();
      base.ResumeLayout(false);
      base.PerformLayout();
    }

  }
}

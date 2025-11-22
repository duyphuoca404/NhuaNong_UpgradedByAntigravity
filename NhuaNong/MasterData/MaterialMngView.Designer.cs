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
  public partial class MaterialMngView
  {
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
    private GroupControl grcSearch;
    private SimpleButton btnReset;
    private LabelControl lblActive;
    private LabelControl lblTenVatTu;
    private Label lblMaVatTu;
    private Label lblToDate;
    private SimpleButton btnSearch;
    private LookUpEdit lueActive;
    private TextEdit txtTenVT;
    private TextEdit txtMaVT;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl lblFromDate;
    private GridControl grcMaterial;
    private GridView grvMaterial;
    private GridColumn gcMaterialCode;
    private GridColumn gcMaterialName;
    private GridColumn gcDescription;
    private GridColumn gcActivated;
    private GridColumn gcNhaCungCap;
    private GridColumn gcDonVi;
    private GridColumn gcDonGia;

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
      this.lblActive = new LabelControl();
      this.lblTenVatTu = new LabelControl();
      this.lblMaVatTu = new Label();
      this.lblToDate = new Label();
      this.btnSearch = new SimpleButton();
      this.lueActive = new LookUpEdit();
      this.txtTenVT = new TextEdit();
      this.txtMaVT = new TextEdit();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.lblFromDate = new LabelControl();
      this.grcMaster = new GroupControl();
      this.grcMaterial = new GridControl();
      this.grvMaterial = new GridView();
      this.gcMaterialCode = new GridColumn();
      this.gcMaterialName = new GridColumn();
      this.gcNhaCungCap = new GridColumn();
      this.gcDonVi = new GridColumn();
      this.gcDonGia = new GridColumn();
      this.gcDescription = new GridColumn();
      this.gcActivated = new GridColumn();
      this.barManager1.BeginInit();
      this.grcSearch.BeginInit();
      this.grcSearch.SuspendLayout();
      this.lueActive.Properties.BeginInit();
      this.txtTenVT.Properties.BeginInit();
      this.txtMaVT.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.grcMaster.BeginInit();
      this.grcMaster.SuspendLayout();
      this.grcMaterial.BeginInit();
      this.grvMaterial.BeginInit();
      this.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[1] { this.bar2 });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control)this;
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
      this.bsiCaption.Caption = "Vật tư";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiInsert.Caption = "Thêm";
      this.bbiInsert.Id = 1;
      this.bbiInsert.ImageOptions.Image = (Image)ResourceNhua.add_file;
      this.bbiInsert.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.bbiInsert.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiInsert.Name = "bbiInsert";
      this.bbiInsert.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiInsert.ItemClick += new ItemClickEventHandler(this.bbiInsert_ItemClick);
      this.bbiUpdate.Caption = "Sửa";
      this.bbiUpdate.Id = 2;
      this.bbiUpdate.ImageOptions.Image = (Image)ResourceNhua.edit_file;
      this.bbiUpdate.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.bbiUpdate.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiUpdate.Name = "bbiUpdate";
      this.bbiUpdate.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiUpdate.ItemClick += new ItemClickEventHandler(this.bbiUpdate_ItemClick);
      this.bbiDelete.Caption = "Xoá";
      this.bbiDelete.Id = 3;
      this.bbiDelete.ImageOptions.Image = (Image)ResourceNhua.delete_file;
      this.bbiDelete.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.bbiDelete.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiDelete.Name = "bbiDelete";
      this.bbiDelete.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiDelete.ItemClick += new ItemClickEventHandler(this.bbiDelete_ItemClick);
      this.bbiView.Caption = "Xem";
      this.bbiView.Id = 4;
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
      this.grcSearch.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.grcSearch.AppearanceCaption.Options.UseFont = true;
      this.grcSearch.Controls.Add((Control)this.btnReset);
      this.grcSearch.Controls.Add((Control)this.lblActive);
      this.grcSearch.Controls.Add((Control)this.lblTenVatTu);
      this.grcSearch.Controls.Add((Control)this.lblMaVatTu);
      this.grcSearch.Controls.Add((Control)this.lblToDate);
      this.grcSearch.Controls.Add((Control)this.btnSearch);
      this.grcSearch.Controls.Add((Control)this.lueActive);
      this.grcSearch.Controls.Add((Control)this.txtTenVT);
      this.grcSearch.Controls.Add((Control)this.txtMaVT);
      this.grcSearch.Controls.Add((Control)this.datToDate);
      this.grcSearch.Controls.Add((Control)this.datFromDate);
      this.grcSearch.Controls.Add((Control)this.lblFromDate);
      this.grcSearch.Dock = DockStyle.Right;
      this.grcSearch.Location = new Point(568, 40);
      this.grcSearch.Margin = new Padding(2);
      this.grcSearch.Name = "grcSearch";
      this.grcSearch.Size = new Size(280, 448);
      this.grcSearch.TabIndex = 4;
      this.grcSearch.Text = "Tìm kiếm";
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(22, 185);
      this.btnReset.Margin = new Padding(2);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(105, 35);
      this.btnReset.TabIndex = 115;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.lblActive.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblActive.Appearance.Options.UseFont = true;
      this.lblActive.Location = new Point(22, 332);
      this.lblActive.Margin = new Padding(2);
      this.lblActive.Name = "lblActive";
      this.lblActive.Size = new Size(59, 16);
      this.lblActive.TabIndex = 114;
      this.lblActive.Text = "Trạng thái";
      this.lblActive.Visible = false;
      this.lblTenVatTu.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblTenVatTu.Appearance.Options.UseFont = true;
      this.lblTenVatTu.Location = new Point(22, 138);
      this.lblTenVatTu.Margin = new Padding(2);
      this.lblTenVatTu.Name = "lblTenVatTu";
      this.lblTenVatTu.Size = new Size(61, 16);
      this.lblTenVatTu.TabIndex = 113;
      this.lblTenVatTu.Text = "Tên Vật tư";
      this.lblMaVatTu.AutoSize = true;
      this.lblMaVatTu.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblMaVatTu.Location = new Point(19, 108);
      this.lblMaVatTu.Margin = new Padding(2, 0, 2, 0);
      this.lblMaVatTu.Name = "lblMaVatTu";
      this.lblMaVatTu.Size = new Size(64, 16);
      this.lblMaVatTu.TabIndex = 112;
      this.lblMaVatTu.Text = "Mã Vật tư";
      this.lblToDate.AutoSize = true;
      this.lblToDate.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblToDate.Location = new Point(19, 78);
      this.lblToDate.Margin = new Padding(2, 0, 2, 0);
      this.lblToDate.Name = "lblToDate";
      this.lblToDate.Size = new Size(62, 16);
      this.lblToDate.TabIndex = 111;
      this.lblToDate.Text = "Đến ngày";
      this.btnSearch.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new Point(157, 185);
      this.btnSearch.Margin = new Padding(2);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new Size(105, 35);
      this.btnSearch.TabIndex = 110;
      this.btnSearch.Text = "Tìm";
      this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
      this.lueActive.Location = new Point(112, 329);
      this.lueActive.Margin = new Padding(2);
      this.lueActive.MenuManager = (IDXMenuManager)this.barManager1;
      this.lueActive.Name = "lueActive";
      this.lueActive.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
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
      this.lueActive.TabIndex = 109;
      this.lueActive.Visible = false;
      this.txtTenVT.Location = new Point(112, 135);
      this.txtTenVT.Margin = new Padding(2);
      this.txtTenVT.Name = "txtTenVT";
      this.txtTenVT.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtTenVT.Properties.Appearance.Options.UseFont = true;
      this.txtTenVT.Size = new Size(150, 22);
      this.txtTenVT.TabIndex = 108;
      this.txtMaVT.Location = new Point(112, 105);
      this.txtMaVT.Margin = new Padding(2);
      this.txtMaVT.Name = "txtMaVT";
      this.txtMaVT.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtMaVT.Properties.Appearance.Options.UseFont = true;
      this.txtMaVT.Size = new Size(150, 22);
      this.txtMaVT.TabIndex = 107;
      this.datToDate.EditValue = (object)null;
      this.datToDate.Location = new Point(112, 75);
      this.datToDate.Margin = new Padding(2);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
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
      this.datToDate.TabIndex = 106;
      this.datFromDate.EditValue = (object)null;
      this.datFromDate.Location = new Point(112, 45);
      this.datFromDate.Margin = new Padding(2);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
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
      this.datFromDate.TabIndex = 105;
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(22, 48);
      this.lblFromDate.Margin = new Padding(2);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(73, 16);
      this.lblFromDate.TabIndex = 104;
      this.lblFromDate.Text = "Tạo Từ ngày";
      this.grcMaster.AppearanceCaption.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.grcMaster.AppearanceCaption.Options.UseFont = true;
      this.grcMaster.Controls.Add((Control)this.grcMaterial);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(568, 448);
      this.grcMaster.TabIndex = 5;
      this.grcMaster.Text = "Dữ liệu";
      this.grcMaterial.Dock = DockStyle.Fill;
      this.grcMaterial.EmbeddedNavigator.Margin = new Padding(2);
      this.grcMaterial.Location = new Point(2, 23);
      this.grcMaterial.MainView = (BaseView)this.grvMaterial;
      this.grcMaterial.Margin = new Padding(2);
      this.grcMaterial.MenuManager = (IDXMenuManager)this.barManager1;
      this.grcMaterial.Name = "grcMaterial";
      this.grcMaterial.Size = new Size(564, 423);
      this.grcMaterial.TabIndex = 0;
      this.grcMaterial.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvMaterial
      });
      this.grvMaterial.Columns.AddRange(new GridColumn[7]
      {
        this.gcMaterialCode,
        this.gcMaterialName,
        this.gcNhaCungCap,
        this.gcDonVi,
        this.gcDonGia,
        this.gcDescription,
        this.gcActivated
      });
      this.grvMaterial.DetailHeight = 284;
      this.grvMaterial.GridControl = this.grcMaterial;
      this.grvMaterial.Name = "grvMaterial";
      this.grvMaterial.OptionsView.ShowFooter = true;
      this.gcMaterialCode.Caption = "Mã Vật Tư";
      this.gcMaterialCode.FieldName = "MaterialCode";
      this.gcMaterialCode.MinWidth = 90;
      this.gcMaterialCode.Name = "gcMaterialCode";
      this.gcMaterialCode.OptionsColumn.AllowEdit = false;
      this.gcMaterialCode.Visible = true;
      this.gcMaterialCode.VisibleIndex = 0;
      this.gcMaterialCode.Width = 90;
      this.gcMaterialName.Caption = "Tên Vật Tư";
      this.gcMaterialName.FieldName = "MaterialName";
      this.gcMaterialName.MinWidth = 90;
      this.gcMaterialName.Name = "gcMaterialName";
      this.gcMaterialName.OptionsColumn.AllowEdit = false;
      this.gcMaterialName.Visible = true;
      this.gcMaterialName.VisibleIndex = 1;
      this.gcMaterialName.Width = 90;
      this.gcNhaCungCap.Caption = "Nhà cung cấp";
      this.gcNhaCungCap.FieldName = "Supplier";
      this.gcNhaCungCap.MinWidth = 90;
      this.gcNhaCungCap.Name = "gcNhaCungCap";
      this.gcNhaCungCap.Visible = true;
      this.gcNhaCungCap.VisibleIndex = 2;
      this.gcNhaCungCap.Width = 90;
      this.gcDonVi.Caption = "Đơn vị";
      this.gcDonVi.FieldName = "UnitName";
      this.gcDonVi.MinWidth = 90;
      this.gcDonVi.Name = "gcDonVi";
      this.gcDonVi.Visible = true;
      this.gcDonVi.VisibleIndex = 3;
      this.gcDonVi.Width = 90;
      this.gcDonGia.Caption = "Đơn giá";
      this.gcDonGia.FieldName = "Price";
      this.gcDonGia.MinWidth = 90;
      this.gcDonGia.Name = "gcDonGia";
      this.gcDonGia.Visible = true;
      this.gcDonGia.VisibleIndex = 4;
      this.gcDonGia.Width = 90;
      this.gcDescription.Caption = "Mô Tả";
      this.gcDescription.FieldName = "Description";
      this.gcDescription.MinWidth = 90;
      this.gcDescription.Name = "gcDescription";
      this.gcDescription.OptionsColumn.AllowEdit = false;
      this.gcDescription.Visible = true;
      this.gcDescription.VisibleIndex = 5;
      this.gcDescription.Width = 90;
      this.gcActivated.Caption = "Active";
      this.gcActivated.FieldName = "Activated";
      this.gcActivated.MinWidth = 90;
      this.gcActivated.Name = "gcActivated";
      this.gcActivated.Width = 70;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.grcMaster);
      this.Controls.Add((Control)this.grcSearch);
      this.Controls.Add((Control)this.barDockControlLeft);
      this.Controls.Add((Control)this.barDockControlRight);
      this.Controls.Add((Control)this.barDockControlBottom);
      this.Controls.Add((Control)this.barDockControlTop);
      this.Name = "MaterialMngView";
      this.Size = new Size(848, 488);
      this.barManager1.EndInit();
      this.grcSearch.EndInit();
      this.grcSearch.ResumeLayout(false);
      this.grcSearch.PerformLayout();
      this.lueActive.Properties.EndInit();
      this.txtTenVT.Properties.EndInit();
      this.txtMaVT.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.grcMaster.EndInit();
      this.grcMaster.ResumeLayout(false);
      this.grcMaterial.EndInit();
      this.grvMaterial.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

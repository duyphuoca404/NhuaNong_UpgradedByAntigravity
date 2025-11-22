using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
  public partial class TinhDoHutNuocMngView
  {
    private IContainer components;
    private BarManager barManager1;
    private Bar barButtons;
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
    private GridControl grcTinhDoHutNuoc;
    private GridView grvTinhDoHutNuoc;
    private GridColumn gcMaTinhDoHutNuoc;
    private GridColumn gcNgayTinhDoHut;
    private RepositoryItemDateEdit idatNgayTinhDoHut;
    private GridColumn gcName;
    private GridColumn gcNhomSilo;
    private RepositoryItemLookUpEdit ilueNhomSilo;
    private GridColumn gcDoHutNuoc;
    private RepositoryItemSpinEdit ispnDoHutNuoc;
    private GridColumn gcGhiChu;
    private PanelControl grpStatus;
    private SimpleButton btnClose;
    private SimpleButton btnSelete;

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
      this.bbiInsert = new BarButtonItem();
      this.bbiUpdate = new BarButtonItem();
      this.bbiDelete = new BarButtonItem();
      this.bbiView = new BarButtonItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.grcMaster = new GroupControl();
      this.grcTinhDoHutNuoc = new GridControl();
      this.grvTinhDoHutNuoc = new GridView();
      this.gcMaTinhDoHutNuoc = new GridColumn();
      this.gcNgayTinhDoHut = new GridColumn();
      this.idatNgayTinhDoHut = new RepositoryItemDateEdit();
      this.gcName = new GridColumn();
      this.gcNhomSilo = new GridColumn();
      this.ilueNhomSilo = new RepositoryItemLookUpEdit();
      this.gcDoHutNuoc = new GridColumn();
      this.ispnDoHutNuoc = new RepositoryItemSpinEdit();
      this.gcGhiChu = new GridColumn();
      this.grpStatus = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSelete = new SimpleButton();
      this.barManager1.BeginInit();
      this.grcMaster.BeginInit();
      this.grcMaster.SuspendLayout();
      this.grcTinhDoHutNuoc.BeginInit();
      this.grvTinhDoHutNuoc.BeginInit();
      this.idatNgayTinhDoHut.BeginInit();
      this.idatNgayTinhDoHut.CalendarTimeProperties.BeginInit();
      this.ilueNhomSilo.BeginInit();
      this.ispnDoHutNuoc.BeginInit();
      this.grpStatus.BeginInit();
      this.grpStatus.SuspendLayout();
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
      this.barManager1.Items.AddRange(new BarItem[5]
      {
        (BarItem) this.bsiCaption,
        (BarItem) this.bbiInsert,
        (BarItem) this.bbiUpdate,
        (BarItem) this.bbiDelete,
        (BarItem) this.bbiView
      });
      this.barManager1.MainMenu = this.barButtons;
      this.barManager1.MaxItemId = 5;
      this.barButtons.BarName = "Main menu";
      this.barButtons.DockCol = 0;
      this.barButtons.DockRow = 0;
      this.barButtons.DockStyle = BarDockStyle.Top;
      this.barButtons.LinksPersistInfo.AddRange(new LinkPersistInfo[5]
      {
        new LinkPersistInfo((BarItem) this.bsiCaption),
        new LinkPersistInfo((BarItem) this.bbiInsert),
        new LinkPersistInfo((BarItem) this.bbiUpdate),
        new LinkPersistInfo((BarItem) this.bbiDelete),
        new LinkPersistInfo((BarItem) this.bbiView)
      });
      this.barButtons.OptionsBar.MultiLine = true;
      this.barButtons.OptionsBar.UseWholeRow = true;
      this.barButtons.Text = "Main menu";
      this.bsiCaption.Caption = "Tính Độ Hút Nước";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 13.8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiInsert.Caption = "Thêm";
      this.bbiInsert.Id = 1;
      this.bbiInsert.ImageOptions.Image = (Image)ResourceNhua.add_file;
      this.bbiInsert.Name = "bbiInsert";
      this.bbiInsert.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiInsert.ItemClick += new ItemClickEventHandler(this.bbiInsert_ItemClick);
      this.bbiUpdate.Caption = "Sửa";
      this.bbiUpdate.Id = 2;
      this.bbiUpdate.ImageOptions.Image = (Image)ResourceNhua.edit_file;
      this.bbiUpdate.Name = "bbiUpdate";
      this.bbiUpdate.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiUpdate.ItemClick += new ItemClickEventHandler(this.bbiUpdate_ItemClick);
      this.bbiDelete.Caption = "Xoá";
      this.bbiDelete.Id = 3;
      this.bbiDelete.ImageOptions.Image = (Image)ResourceNhua.delete_file;
      this.bbiDelete.Name = "bbiDelete";
      this.bbiDelete.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiDelete.ItemClick += new ItemClickEventHandler(this.bbiDelete_ItemClick);
      this.bbiView.Caption = "Xem";
      this.bbiView.Id = 4;
      this.bbiView.ImageOptions.Image = (Image)ResourceNhua.view_file;
      this.bbiView.Name = "bbiView";
      this.bbiView.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiView.ItemClick += new ItemClickEventHandler(this.bbiView_ItemClick);
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Margin = new Padding(2, 2, 2, 2);
      this.barDockControlTop.Size = new Size(848, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 488);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(2, 2, 2, 2);
      this.barDockControlBottom.Size = new Size(848, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(2, 2, 2, 2);
      this.barDockControlLeft.Size = new Size(0, 448);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(848, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(2, 2, 2, 2);
      this.barDockControlRight.Size = new Size(0, 448);
      this.grcMaster.Controls.Add((Control)this.grcTinhDoHutNuoc);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2, 2, 2, 2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(848, 448);
      this.grcMaster.TabIndex = 4;
      this.grcMaster.Text = "Dữ liệu";
      this.grcTinhDoHutNuoc.Dock = DockStyle.Fill;
      this.grcTinhDoHutNuoc.EmbeddedNavigator.Margin = new Padding(2, 2, 2, 2);
      this.grcTinhDoHutNuoc.Location = new Point(2, 23);
      this.grcTinhDoHutNuoc.MainView = (BaseView)this.grvTinhDoHutNuoc;
      this.grcTinhDoHutNuoc.Margin = new Padding(2, 2, 2, 2);
      this.grcTinhDoHutNuoc.MenuManager = (IDXMenuManager)this.barManager1;
      this.grcTinhDoHutNuoc.Name = "grcTinhDoHutNuoc";
      this.grcTinhDoHutNuoc.RepositoryItems.AddRange(new RepositoryItem[3]
      {
        (RepositoryItem) this.idatNgayTinhDoHut,
        (RepositoryItem) this.ilueNhomSilo,
        (RepositoryItem) this.ispnDoHutNuoc
      });
      this.grcTinhDoHutNuoc.Size = new Size(844, 423);
      this.grcTinhDoHutNuoc.TabIndex = 0;
      this.grcTinhDoHutNuoc.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvTinhDoHutNuoc
      });
      this.grvTinhDoHutNuoc.Columns.AddRange(new GridColumn[6]
      {
        this.gcMaTinhDoHutNuoc,
        this.gcNgayTinhDoHut,
        this.gcName,
        this.gcNhomSilo,
        this.gcDoHutNuoc,
        this.gcGhiChu
      });
      this.grvTinhDoHutNuoc.DetailHeight = 284;
      this.grvTinhDoHutNuoc.GridControl = this.grcTinhDoHutNuoc;
      this.grvTinhDoHutNuoc.Name = "grvTinhDoHutNuoc";
      this.grvTinhDoHutNuoc.FocusedRowChanged += new FocusedRowChangedEventHandler(this.grvTinhDoHutNuoc_FocusedRowChanged);
      this.gcMaTinhDoHutNuoc.Caption = "Mã Độ Hút Nước";
      this.gcMaTinhDoHutNuoc.FieldName = "MaTinhDoHutNuoc";
      this.gcMaTinhDoHutNuoc.MinWidth = 22;
      this.gcMaTinhDoHutNuoc.Name = "gcMaTinhDoHutNuoc";
      this.gcMaTinhDoHutNuoc.OptionsColumn.ReadOnly = true;
      this.gcMaTinhDoHutNuoc.Visible = true;
      this.gcMaTinhDoHutNuoc.VisibleIndex = 0;
      this.gcMaTinhDoHutNuoc.Width = 80;
      this.gcNgayTinhDoHut.Caption = "Ngày tạo";
      this.gcNgayTinhDoHut.ColumnEdit = (RepositoryItem)this.idatNgayTinhDoHut;
      this.gcNgayTinhDoHut.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.gcNgayTinhDoHut.DisplayFormat.FormatType = FormatType.DateTime;
      this.gcNgayTinhDoHut.FieldName = "NgayTinhDoHut";
      this.gcNgayTinhDoHut.MinWidth = 22;
      this.gcNgayTinhDoHut.Name = "gcNgayTinhDoHut";
      this.gcNgayTinhDoHut.OptionsColumn.ReadOnly = true;
      this.gcNgayTinhDoHut.Visible = true;
      this.gcNgayTinhDoHut.VisibleIndex = 1;
      this.gcNgayTinhDoHut.Width = 80;
      this.idatNgayTinhDoHut.AutoHeight = false;
      this.idatNgayTinhDoHut.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.idatNgayTinhDoHut.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.idatNgayTinhDoHut.DisplayFormat.FormatString = "g";
      this.idatNgayTinhDoHut.DisplayFormat.FormatType = FormatType.DateTime;
      this.idatNgayTinhDoHut.EditFormat.FormatString = "g";
      this.idatNgayTinhDoHut.EditFormat.FormatType = FormatType.DateTime;
      this.idatNgayTinhDoHut.Mask.EditMask = "g";
      this.idatNgayTinhDoHut.Name = "idatNgayTinhDoHut";
      this.idatNgayTinhDoHut.ReadOnly = true;
      this.gcName.Caption = "Diễn Giải";
      this.gcName.FieldName = "Name";
      this.gcName.MinWidth = 22;
      this.gcName.Name = "gcName";
      this.gcName.OptionsColumn.ReadOnly = true;
      this.gcName.Visible = true;
      this.gcName.VisibleIndex = 2;
      this.gcName.Width = 80;
      this.gcNhomSilo.Caption = "Nhóm Vật liệu";
      this.gcNhomSilo.ColumnEdit = (RepositoryItem)this.ilueNhomSilo;
      this.gcNhomSilo.FieldName = "NhomSiloID";
      this.gcNhomSilo.MinWidth = 22;
      this.gcNhomSilo.Name = "gcNhomSilo";
      this.gcNhomSilo.OptionsColumn.ReadOnly = true;
      this.gcNhomSilo.Visible = true;
      this.gcNhomSilo.VisibleIndex = 3;
      this.gcNhomSilo.Width = 80;
      this.ilueNhomSilo.AutoHeight = false;
      this.ilueNhomSilo.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ilueNhomSilo.DisplayMember = "TenNhomSilo";
      this.ilueNhomSilo.Name = "ilueNhomSilo";
      this.ilueNhomSilo.ReadOnly = true;
      this.ilueNhomSilo.ValueMember = "NhomSiloID";
      this.gcDoHutNuoc.Caption = "Độ Hút Nước";
      this.gcDoHutNuoc.ColumnEdit = (RepositoryItem)this.ispnDoHutNuoc;
      this.gcDoHutNuoc.FieldName = "DoHutNuoc";
      this.gcDoHutNuoc.MinWidth = 22;
      this.gcDoHutNuoc.Name = "gcDoHutNuoc";
      this.gcDoHutNuoc.OptionsColumn.ReadOnly = true;
      this.gcDoHutNuoc.Visible = true;
      this.gcDoHutNuoc.VisibleIndex = 4;
      this.gcDoHutNuoc.Width = 80;
      this.ispnDoHutNuoc.AutoHeight = false;
      this.ispnDoHutNuoc.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.ispnDoHutNuoc.DisplayFormat.FormatString = "n2";
      this.ispnDoHutNuoc.DisplayFormat.FormatType = FormatType.Numeric;
      this.ispnDoHutNuoc.EditFormat.FormatString = "n2";
      this.ispnDoHutNuoc.EditFormat.FormatType = FormatType.Numeric;
      this.ispnDoHutNuoc.Name = "ispnDoHutNuoc";
      this.ispnDoHutNuoc.ReadOnly = true;
      this.gcGhiChu.Caption = "Ghi Chú";
      this.gcGhiChu.FieldName = "Description";
      this.gcGhiChu.MinWidth = 22;
      this.gcGhiChu.Name = "gcGhiChu";
      this.gcGhiChu.OptionsColumn.ReadOnly = true;
      this.gcGhiChu.Visible = true;
      this.gcGhiChu.VisibleIndex = 5;
      this.gcGhiChu.Width = 80;
      this.grpStatus.Controls.Add((Control)this.btnClose);
      this.grpStatus.Controls.Add((Control)this.btnSelete);
      this.grpStatus.Dock = DockStyle.Bottom;
      this.grpStatus.Location = new Point(0, 439);
      this.grpStatus.Margin = new Padding(2, 2, 2, 2);
      this.grpStatus.Name = "grpStatus";
      this.grpStatus.Size = new Size(848, 49);
      this.grpStatus.TabIndex = 9;
      this.btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnClose.Location = new Point(718, 13);
      this.btnClose.Margin = new Padding(2, 2, 2, 2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 24);
      this.btnClose.TabIndex = 4;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
      this.btnSelete.Location = new Point(613, 13);
      this.btnSelete.Margin = new Padding(2, 2, 2, 2);
      this.btnSelete.Name = "btnSelete";
      this.btnSelete.Size = new Size(98, 24);
      this.btnSelete.TabIndex = 3;
      this.btnSelete.Text = "Chọn";
      this.btnSelete.Click += new EventHandler(this.btnSelete_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.grpStatus);
      this.Controls.Add((Control)this.grcMaster);
      this.Controls.Add((Control)this.barDockControlLeft);
      this.Controls.Add((Control)this.barDockControlRight);
      this.Controls.Add((Control)this.barDockControlBottom);
      this.Controls.Add((Control)this.barDockControlTop);
      this.Name = "TinhDoHutNuocMngView";
      this.Size = new Size(848, 488);
      this.barManager1.EndInit();
      this.grcMaster.EndInit();
      this.grcMaster.ResumeLayout(false);
      this.grcTinhDoHutNuoc.EndInit();
      this.grvTinhDoHutNuoc.EndInit();
      this.idatNgayTinhDoHut.CalendarTimeProperties.EndInit();
      this.idatNgayTinhDoHut.EndInit();
      this.ilueNhomSilo.EndInit();
      this.ispnDoHutNuoc.EndInit();
      this.grpStatus.EndInit();
      this.grpStatus.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

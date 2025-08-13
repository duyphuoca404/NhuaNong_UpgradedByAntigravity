// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NhomSiloMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NhomSiloMngView : ControlViewBase, INhomSiloMngView, IBase, IPermission
  {
    private NhomSiloMngDataPresenter _presenter;
    private BindingList<ObjNhomSilo> _blstNhomSilo = new BindingList<ObjNhomSilo>();
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
    private GroupControl grcMaster;
    private GridControl grcNhomSilo;
    private GridView grvNhomSilo;
    private GridColumn gcMaNhomSilo;
    private GridColumn gcTenNhomSilo;
    private GridColumn gcGhiChu;

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public NhomSiloMngView()
    {
      this.InitializeComponent();
      this._presenter = new NhomSiloMngDataPresenter((INhomSiloMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjNhomSilo> BLstNhomSilo
    {
      set
      {
        this._blstNhomSilo = value;
        this.grcNhomSilo.DataSource = (object) this._blstNhomSilo;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    private void SuccessfullySave(bool isSuccess)
    {
    }

    protected override void PopulateData() => this._presenter.ListNhomSilo();

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewNhomSiloView ctrView = new NewNhomSiloView((ObjNhomSilo) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListNhomSilo();
      this.FocusRow(this.grvNhomSilo, this.grvNhomSilo.RowCount);
    }

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvNhomSilo.RowCount == 0)
        return;
      int focusedRowHandle = this.grvNhomSilo.FocusedRowHandle;
      NewNhomSiloView ctrView = new NewNhomSiloView(this.grvNhomSilo.GetRow(focusedRowHandle) as ObjNhomSilo, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListNhomSilo();
      this.FocusRow(this.grvNhomSilo, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      BindingList<ObjNhomSilo> blstCT = new BindingList<ObjNhomSilo>();
      foreach (int selectedRow in this.grvNhomSilo.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjNhomSilo row = this.grvNhomSilo.GetRow(selectedRow) as ObjNhomSilo;
          row.MarkAsDeleted = true;
          blstCT.Add(row);
        }
      }
      foreach (ObjNhomSilo objNhomSilo in (Collection<ObjNhomSilo>) blstCT)
        this._blstNhomSilo.Remove(objNhomSilo);
      this.FocusRow(this.grvNhomSilo, this.grvNhomSilo.RowCount);
      this._presenter.SaveNhomSilo(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvNhomSilo.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewNhomSiloView(this.grvNhomSilo.GetRow(this.grvNhomSilo.FocusedRowHandle) as ObjNhomSilo, Enums.FormAction.View));
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
      this.grcMaster = new GroupControl();
      this.grcNhomSilo = new GridControl();
      this.grvNhomSilo = new GridView();
      this.gcMaNhomSilo = new GridColumn();
      this.gcTenNhomSilo = new GridColumn();
      this.gcGhiChu = new GridColumn();
      this.barManager1.BeginInit();
      this.grcMaster.BeginInit();
      this.grcMaster.SuspendLayout();
      this.grcNhomSilo.BeginInit();
      this.grvNhomSilo.BeginInit();
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
      this.bsiCaption.Caption = "Nhóm Silo";
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
      this.grcMaster.Controls.Add((Control) this.grcNhomSilo);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2, 2, 2, 2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(848, 448);
      this.grcMaster.TabIndex = 4;
      this.grcMaster.Text = "Dữ liệu";
      this.grcNhomSilo.Dock = DockStyle.Fill;
      this.grcNhomSilo.EmbeddedNavigator.Margin = new Padding(2, 2, 2, 2);
      this.grcNhomSilo.Location = new Point(2, 23);
      this.grcNhomSilo.MainView = (BaseView) this.grvNhomSilo;
      this.grcNhomSilo.Margin = new Padding(2, 2, 2, 2);
      this.grcNhomSilo.MenuManager = (IDXMenuManager) this.barManager1;
      this.grcNhomSilo.Name = "grcNhomSilo";
      this.grcNhomSilo.Size = new Size(844, 423);
      this.grcNhomSilo.TabIndex = 0;
      this.grcNhomSilo.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvNhomSilo
      });
      this.grvNhomSilo.Columns.AddRange(new GridColumn[3]
      {
        this.gcMaNhomSilo,
        this.gcTenNhomSilo,
        this.gcGhiChu
      });
      this.grvNhomSilo.DetailHeight = 284;
      this.grvNhomSilo.GridControl = this.grcNhomSilo;
      this.grvNhomSilo.Name = "grvNhomSilo";
      this.gcMaNhomSilo.Caption = "Mã Nhóm Silo";
      this.gcMaNhomSilo.FieldName = "MaNhomSilo";
      this.gcMaNhomSilo.MinWidth = 22;
      this.gcMaNhomSilo.Name = "gcMaNhomSilo";
      this.gcMaNhomSilo.OptionsColumn.AllowEdit = false;
      this.gcMaNhomSilo.Visible = true;
      this.gcMaNhomSilo.VisibleIndex = 0;
      this.gcMaNhomSilo.Width = 80;
      this.gcTenNhomSilo.Caption = "Tên Nhóm Silo";
      this.gcTenNhomSilo.FieldName = "TenNhomSilo";
      this.gcTenNhomSilo.MinWidth = 22;
      this.gcTenNhomSilo.Name = "gcTenNhomSilo";
      this.gcTenNhomSilo.OptionsColumn.AllowEdit = false;
      this.gcTenNhomSilo.Visible = true;
      this.gcTenNhomSilo.VisibleIndex = 1;
      this.gcTenNhomSilo.Width = 80;
      this.gcGhiChu.Caption = "Ghi Chú";
      this.gcGhiChu.FieldName = "GhiChu";
      this.gcGhiChu.MinWidth = 22;
      this.gcGhiChu.Name = "gcGhiChu";
      this.gcGhiChu.OptionsColumn.AllowEdit = false;
      this.gcGhiChu.Visible = true;
      this.gcGhiChu.VisibleIndex = 2;
      this.gcGhiChu.Width = 80;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.grcMaster);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (NhomSiloMngView);
      this.Size = new Size(848, 488);
      this.barManager1.EndInit();
      this.grcMaster.EndInit();
      this.grcMaster.ResumeLayout(false);
      this.grcNhomSilo.EndInit();
      this.grvNhomSilo.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

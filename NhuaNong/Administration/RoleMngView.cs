// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.RoleMngView
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
namespace NhuaNong.Administration
{
  public class RoleMngView : ControlViewBase, IRoleMngView, IBase, IPermission
  {
    private RoleMngDataPresenter _presenter;
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private BindingList<ObjSEC_Role> _blstRole = new BindingList<ObjSEC_Role>();
    private IContainer components;
    private BarManager barManager1;
    private Bar bar1;
    private BarStaticItem bsiCaption;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private GroupControl grpMaster;
    private GridControl grcRole;
    private GridView grvRole;
    private GridColumn gcRoleName;
    private GridColumn gcDesc;
    private BarButtonItem barButtonItem1;
    private BarButtonItem bbiInsert;
    private BarButtonItem bbiUpdate;
    private BarButtonItem bbiDelete;
    private BarButtonItem bbiView;

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public BindingList<ObjSEC_Role> BLstRole
    {
      set
      {
        this._blstRole = value;
        this.grcRole.DataSource = (object) this._blstRole;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public RoleMngView()
    {
      this.InitializeComponent();
      this._presenter = new RoleMngDataPresenter((IRoleMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    protected override void PopulateData() => this._presenter.ListRole();

    private void SuccessfullySave(bool isSuccess)
    {
    }

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewRoleView ctrView = new NewRoleView((ObjSEC_Role) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListRole();
      this.FocusRow(this.grvRole, this.grvRole.RowCount);
    }

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvRole.RowCount == 0)
        return;
      int focusedRowHandle = this.grvRole.FocusedRowHandle;
      NewRoleView ctrView = new NewRoleView(this.grvRole.GetRow(focusedRowHandle) as ObjSEC_Role, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListRole();
      this.FocusRow(this.grvRole, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (TramTromMessageBox.ShowYesNoDialog("Xác nhận xóa dữ liệu đã chọn.") != DialogResult.Yes)
        return;
      BindingList<ObjSEC_Role> blstCT = new BindingList<ObjSEC_Role>();
      foreach (int selectedRow in this.grvRole.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjSEC_Role row = this.grvRole.GetRow(selectedRow) as ObjSEC_Role;
          row.MarkAsDeleted = true;
          blstCT.Add(row);
        }
      }
      foreach (ObjSEC_Role objSecRole in (Collection<ObjSEC_Role>) blstCT)
        this._blstRole.Remove(objSecRole);
      this.FocusRow(this.grvRole, this.grvRole.RowCount);
      this._presenter.SaveRole(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvRole.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewRoleView(this.grvRole.GetRow(this.grvRole.FocusedRowHandle) as ObjSEC_Role, Enums.FormAction.View));
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
      this.bar1 = new Bar();
      this.bsiCaption = new BarStaticItem();
      this.bbiInsert = new BarButtonItem();
      this.bbiUpdate = new BarButtonItem();
      this.bbiDelete = new BarButtonItem();
      this.bbiView = new BarButtonItem();
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.barButtonItem1 = new BarButtonItem();
      this.grpMaster = new GroupControl();
      this.grcRole = new GridControl();
      this.grvRole = new GridView();
      this.gcRoleName = new GridColumn();
      this.gcDesc = new GridColumn();
      this.barManager1.BeginInit();
      this.grpMaster.BeginInit();
      this.grpMaster.SuspendLayout();
      this.grcRole.BeginInit();
      this.grvRole.BeginInit();
      this.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[1]{ this.bar1 });
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barManager1.Items.AddRange(new BarItem[6]
      {
        (BarItem) this.bsiCaption,
        (BarItem) this.barButtonItem1,
        (BarItem) this.bbiInsert,
        (BarItem) this.bbiUpdate,
        (BarItem) this.bbiDelete,
        (BarItem) this.bbiView
      });
      this.barManager1.MaxItemId = 10;
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new LinkPersistInfo[5]
      {
        new LinkPersistInfo((BarItem) this.bsiCaption),
        new LinkPersistInfo((BarItem) this.bbiInsert),
        new LinkPersistInfo((BarItem) this.bbiUpdate),
        new LinkPersistInfo((BarItem) this.bbiDelete),
        new LinkPersistInfo((BarItem) this.bbiView)
      });
      this.bar1.Text = "Tools";
      this.bsiCaption.Caption = "Vai trò";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.bsiCaption.ItemAppearance.Normal.Options.UseFont = true;
      this.bsiCaption.Name = "bsiCaption";
      this.bbiInsert.Caption = "Thêm";
      this.bbiInsert.Id = 6;
      this.bbiInsert.ImageOptions.Image = (Image) ResourceNhua.add_file;
      this.bbiInsert.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiInsert.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiInsert.Name = "bbiInsert";
      this.bbiInsert.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiInsert.ItemClick += new ItemClickEventHandler(this.bbiInsert_ItemClick);
      this.bbiUpdate.Caption = "Sửa";
      this.bbiUpdate.Id = 7;
      this.bbiUpdate.ImageOptions.Image = (Image) ResourceNhua.edit_file;
      this.bbiUpdate.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiUpdate.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiUpdate.Name = "bbiUpdate";
      this.bbiUpdate.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiUpdate.ItemClick += new ItemClickEventHandler(this.bbiUpdate_ItemClick);
      this.bbiDelete.Caption = "Xoá";
      this.bbiDelete.Id = 8;
      this.bbiDelete.ImageOptions.Image = (Image) ResourceNhua.delete_file;
      this.bbiDelete.ItemAppearance.Normal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.bbiDelete.ItemAppearance.Normal.Options.UseFont = true;
      this.bbiDelete.Name = "bbiDelete";
      this.bbiDelete.PaintStyle = BarItemPaintStyle.CaptionGlyph;
      this.bbiDelete.ItemClick += new ItemClickEventHandler(this.bbiDelete_ItemClick);
      this.bbiView.Caption = "Xem";
      this.bbiView.Id = 9;
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
      this.barDockControlTop.Size = new Size(943, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 488);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(2);
      this.barDockControlBottom.Size = new Size(943, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(2);
      this.barDockControlLeft.Size = new Size(0, 448);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(943, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(2);
      this.barDockControlRight.Size = new Size(0, 448);
      this.barButtonItem1.Caption = "Thêm";
      this.barButtonItem1.Id = 5;
      this.barButtonItem1.Name = "barButtonItem1";
      this.grpMaster.Controls.Add((Control) this.grcRole);
      this.grpMaster.Dock = DockStyle.Fill;
      this.grpMaster.Location = new Point(0, 40);
      this.grpMaster.Margin = new Padding(2);
      this.grpMaster.Name = "grpMaster";
      this.grpMaster.Size = new Size(943, 448);
      this.grpMaster.TabIndex = 4;
      this.grpMaster.Text = "Dữ liệu";
      this.grcRole.Dock = DockStyle.Fill;
      this.grcRole.EmbeddedNavigator.Margin = new Padding(2);
      this.grcRole.Location = new Point(2, 23);
      this.grcRole.MainView = (BaseView) this.grvRole;
      this.grcRole.Margin = new Padding(2);
      this.grcRole.MenuManager = (IDXMenuManager) this.barManager1;
      this.grcRole.Name = "grcRole";
      this.grcRole.Size = new Size(939, 423);
      this.grcRole.TabIndex = 0;
      this.grcRole.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvRole
      });
      this.grvRole.Columns.AddRange(new GridColumn[2]
      {
        this.gcRoleName,
        this.gcDesc
      });
      this.grvRole.DetailHeight = 284;
      this.grvRole.GridControl = this.grcRole;
      this.grvRole.Name = "grvRole";
      this.grvRole.OptionsView.ShowFooter = true;
      this.gcRoleName.Caption = "Tên Vai trò";
      this.gcRoleName.FieldName = "RoleName";
      this.gcRoleName.MinWidth = 19;
      this.gcRoleName.Name = "gcRoleName";
      this.gcRoleName.OptionsColumn.AllowEdit = false;
      this.gcRoleName.Visible = true;
      this.gcRoleName.VisibleIndex = 0;
      this.gcRoleName.Width = 70;
      this.gcDesc.Caption = "Miêu tả";
      this.gcDesc.FieldName = "Description";
      this.gcDesc.MinWidth = 19;
      this.gcDesc.Name = "gcDesc";
      this.gcDesc.OptionsColumn.AllowEdit = false;
      this.gcDesc.Visible = true;
      this.gcDesc.VisibleIndex = 1;
      this.gcDesc.Width = 70;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.grpMaster);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (RoleMngView);
      this.Size = new Size(943, 488);
      this.barManager1.EndInit();
      this.grpMaster.EndInit();
      this.grpMaster.ResumeLayout(false);
      this.grcRole.EndInit();
      this.grvRole.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

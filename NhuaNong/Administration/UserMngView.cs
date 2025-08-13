// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.UserMngView
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
  public class UserMngView : ControlViewBase, IBase, IPermission, IUserMngView
  {
    private UserMngDataPresenter _presenter;
    private BindingList<ObjSEC_User> _blstUser = new BindingList<ObjSEC_User>();
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private IContainer components;
    private BarManager barManager1;
    private Bar bar1;
    private BarStaticItem bsiCaption;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarButtonItem bbiInsert;
    private BarButtonItem bbiUpdate;
    private BarButtonItem bbiDelete;
    private BarButtonItem bbiView;
    private GroupControl grcMaster;
    private GridControl grcUser;
    private GridView grvUser;
    private GridColumn gcUserName;
    private GridColumn gcFullName;
    private GridColumn gcDepartment;
    private GridColumn gcPhone;
    private GridColumn gcEmail;
    private GridColumn gcIsActive;

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public UserMngView()
    {
      this.InitializeComponent();
      this._presenter = new UserMngDataPresenter((IUserMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    protected override void PopulateData() => this.LoadUser();

    private void SuccessfullySave(bool isSuccess)
    {
    }

    public BindingList<ObjSEC_User> BLstUser
    {
      set
      {
        this._blstUser = value;
        this.grcUser.DataSource = (object) this._blstUser;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    private void LoadUser()
    {
      try
      {
        bool? active = new bool?();
        active = new bool?(true);
        this._presenter.ListUser_ByActive(active);
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowDEPErrorDialog(ex);
        TramTronLogger.WriteError(ex);
      }
    }

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewUserView ctrView = new NewUserView((ObjSEC_User) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListUser();
      this.FocusRow(this.grvUser, this.grvUser.RowCount);
    }

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvUser.RowCount == 0)
        return;
      int focusedRowHandle = this.grvUser.FocusedRowHandle;
      NewUserView ctrView = new NewUserView(this.grvUser.GetRow(focusedRowHandle) as ObjSEC_User, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListUser();
      this.FocusRow(this.grvUser, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (TramTromMessageBox.ShowYesNoDialog(GlobalValues.Messages.ConfirmDeleteSelectedData) != DialogResult.Yes)
        return;
      BindingList<ObjSEC_User> blstCT = new BindingList<ObjSEC_User>();
      foreach (int selectedRow in this.grvUser.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjSEC_User row = this.grvUser.GetRow(selectedRow) as ObjSEC_User;
          row.IsActived = new bool?(false);
          blstCT.Add(row);
        }
      }
      foreach (ObjSEC_User objSecUser in (Collection<ObjSEC_User>) blstCT)
        this._blstUser.Remove(objSecUser);
      this.FocusRow(this.grvUser, this.grvUser.RowCount);
      this._presenter.SaveUser(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvUser.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewUserView(this.grvUser.GetRow(this.grvUser.FocusedRowHandle) as ObjSEC_User, Enums.FormAction.View));
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
      this.grcMaster = new GroupControl();
      this.grcUser = new GridControl();
      this.grvUser = new GridView();
      this.gcUserName = new GridColumn();
      this.gcFullName = new GridColumn();
      this.gcDepartment = new GridColumn();
      this.gcPhone = new GridColumn();
      this.gcEmail = new GridColumn();
      this.gcIsActive = new GridColumn();
      this.barManager1.BeginInit();
      this.grcMaster.BeginInit();
      this.grcMaster.SuspendLayout();
      this.grcUser.BeginInit();
      this.grvUser.BeginInit();
      this.SuspendLayout();
      this.barManager1.Bars.AddRange(new Bar[1]{ this.bar1 });
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
      this.barManager1.MaxItemId = 5;
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
      this.bsiCaption.Caption = "Người dùng";
      this.bsiCaption.Id = 0;
      this.bsiCaption.ItemAppearance.Normal.Font = new Font("Tahoma", 10.2f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
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
      this.barDockControlTop.Size = new Size(853, 40);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 535);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Margin = new Padding(2);
      this.barDockControlBottom.Size = new Size(853, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 40);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Margin = new Padding(2);
      this.barDockControlLeft.Size = new Size(0, 495);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(853, 40);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Margin = new Padding(2);
      this.barDockControlRight.Size = new Size(0, 495);
      this.grcMaster.Controls.Add((Control) this.grcUser);
      this.grcMaster.Dock = DockStyle.Fill;
      this.grcMaster.Location = new Point(0, 40);
      this.grcMaster.Margin = new Padding(2);
      this.grcMaster.Name = "grcMaster";
      this.grcMaster.Size = new Size(853, 495);
      this.grcMaster.TabIndex = 4;
      this.grcMaster.Text = "Dữ liệu";
      this.grcUser.Dock = DockStyle.Fill;
      this.grcUser.EmbeddedNavigator.Margin = new Padding(2);
      this.grcUser.Location = new Point(2, 23);
      this.grcUser.MainView = (BaseView) this.grvUser;
      this.grcUser.Margin = new Padding(2);
      this.grcUser.MenuManager = (IDXMenuManager) this.barManager1;
      this.grcUser.Name = "grcUser";
      this.grcUser.Size = new Size(849, 470);
      this.grcUser.TabIndex = 0;
      this.grcUser.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvUser
      });
      this.grvUser.Columns.AddRange(new GridColumn[6]
      {
        this.gcUserName,
        this.gcFullName,
        this.gcDepartment,
        this.gcPhone,
        this.gcEmail,
        this.gcIsActive
      });
      this.grvUser.DetailHeight = 284;
      this.grvUser.GridControl = this.grcUser;
      this.grvUser.Name = "grvUser";
      this.grvUser.OptionsView.ShowFooter = true;
      this.gcUserName.Caption = "User Name";
      this.gcUserName.FieldName = "UserName";
      this.gcUserName.MinWidth = 19;
      this.gcUserName.Name = "gcUserName";
      this.gcUserName.OptionsColumn.AllowEdit = false;
      this.gcUserName.Visible = true;
      this.gcUserName.VisibleIndex = 0;
      this.gcUserName.Width = 70;
      this.gcFullName.Caption = "Full Name";
      this.gcFullName.FieldName = "FullName";
      this.gcFullName.MinWidth = 19;
      this.gcFullName.Name = "gcFullName";
      this.gcFullName.OptionsColumn.AllowEdit = false;
      this.gcFullName.Visible = true;
      this.gcFullName.VisibleIndex = 1;
      this.gcFullName.Width = 70;
      this.gcDepartment.Caption = "Department";
      this.gcDepartment.FieldName = "Department";
      this.gcDepartment.MinWidth = 19;
      this.gcDepartment.Name = "gcDepartment";
      this.gcDepartment.OptionsColumn.AllowEdit = false;
      this.gcDepartment.Width = 70;
      this.gcPhone.Caption = "Phone";
      this.gcPhone.FieldName = "Phone";
      this.gcPhone.MinWidth = 19;
      this.gcPhone.Name = "gcPhone";
      this.gcPhone.OptionsColumn.AllowEdit = false;
      this.gcPhone.Visible = true;
      this.gcPhone.VisibleIndex = 2;
      this.gcPhone.Width = 70;
      this.gcEmail.Caption = "Email";
      this.gcEmail.FieldName = "Email";
      this.gcEmail.MinWidth = 19;
      this.gcEmail.Name = "gcEmail";
      this.gcEmail.OptionsColumn.AllowEdit = false;
      this.gcEmail.Visible = true;
      this.gcEmail.VisibleIndex = 3;
      this.gcEmail.Width = 70;
      this.gcIsActive.Caption = "Active";
      this.gcIsActive.FieldName = "IsActived";
      this.gcIsActive.MinWidth = 19;
      this.gcIsActive.Name = "gcIsActive";
      this.gcIsActive.OptionsColumn.AllowEdit = false;
      this.gcIsActive.Width = 70;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.grcMaster);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (UserMngView);
      this.Size = new Size(853, 535);
      this.barManager1.EndInit();
      this.grcMaster.EndInit();
      this.grcMaster.ResumeLayout(false);
      this.grcUser.EndInit();
      this.grvUser.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

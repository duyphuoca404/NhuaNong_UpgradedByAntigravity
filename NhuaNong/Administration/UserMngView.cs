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
  public partial class UserMngView : ControlViewBase, IBase, IPermission, IUserMngView
  {
    private UserMngDataPresenter _presenter;
    private BindingList<ObjSEC_User> _blstUser = new BindingList<ObjSEC_User>();
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    

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
      this.Name = nameof(UserMngView);
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

    
  }
}

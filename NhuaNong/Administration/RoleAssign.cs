using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Administration
{
  public partial class RoleAssign : ControlViewBase, IBase, IRoleAssignView
  {
    private BindingList<ObjSEC_Role> _blstRole = new BindingList<ObjSEC_Role>();
    private BindingList<ObjSEC_User> _blstUser = new BindingList<ObjSEC_User>();
    private BindingList<ObjSEC_UserRole> _blstUserRole = new BindingList<ObjSEC_UserRole>();
    private RoleAssignDataPresenter _presenter;
    private ObjSEC_User _user;
    

    public BindingList<ObjSEC_Role> BLstRole
    {
      set
      {
        this._blstRole = value;
        this.grcRole.DataSource = (object) this._blstRole;
      }
    }

    public BindingList<ObjSEC_User> BLstUser
    {
      set
      {
        this._blstUser = value;
        this.grcUser.DataSource = (object) this._blstUser;
      }
    }

    public BindingList<ObjSEC_UserRole> BLstUserRole
    {
      set
      {
        this._blstUserRole = value;
        this.MapUserRole();
      }
    }

    private void MapUserRole()
    {
      foreach (ObjSEC_Role role in (Collection<ObjSEC_Role>) this._blstRole)
        role.NPSelect = this.CheckIsSelected(this._user, role);
      this.grvRole.RefreshData();
    }

    protected override void PopulateData() => this._presenter.ListUserRole();

    protected override void PopulateStaticData()
    {
      this._presenter.ListUser();
      this._presenter.ListRole();
    }

    private void SaveData() => this._presenter.SaveUserRole(this._blstUserRole);

    private bool CheckIsSelected(ObjSEC_User user, ObjSEC_Role role)
    {
      foreach (ObjSEC_UserRole objSecUserRole in (Collection<ObjSEC_UserRole>) this._blstUserRole)
      {
        if (!objSecUserRole.MarkAsDeleted && objSecUserRole.UserID == user.UserID && objSecUserRole.RoleID == role.RoleID)
          return true;
      }
      return false;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      this._presenter.ListUserRole();
      TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessProceed);
    }

    public RoleAssign()
    {
      this.InitializeComponent();
      this.Name = nameof(RoleAssign);
      this._presenter = new RoleAssignDataPresenter((IRoleAssignView) this);
      this.Caption = "Phân quyền vai trò";
    }

    private void AssignRole(ObjSEC_User user, ObjSEC_Role role, bool isAssign)
    {
      if (isAssign)
      {
        ObjSEC_UserRole userRole = this.GetUserRole(user, role);
        if (userRole == null)
          this._blstUserRole.Add(new ObjSEC_UserRole()
          {
            UserID = user.UserID,
            RoleID = role.RoleID
          });
        else
          userRole.MarkAsDeleted = false;
      }
      else
      {
        ObjSEC_UserRole userRole = this.GetUserRole(user, role);
        if (userRole.IsNewObject)
          this._blstUserRole.Remove(userRole);
        else
          userRole.MarkAsDeleted = true;
      }
    }

    private ObjSEC_UserRole GetUserRole(ObjSEC_User user, ObjSEC_Role role)
    {
      foreach (ObjSEC_UserRole userRole in (Collection<ObjSEC_UserRole>) this._blstUserRole)
      {
        if (userRole.UserID == user.UserID && userRole.RoleID == role.RoleID)
          return userRole;
      }
      return (ObjSEC_UserRole) null;
    }

    private void grvUser_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      if (e.FocusedRowHandle < 0)
        return;
      this._user = this.grvUser.GetRow(this.grvUser.FocusedRowHandle) as ObjSEC_User;
      this.MapUserRole();
    }

    private void grvRole_CellValueChanging(object sender, CellValueChangedEventArgs e)
    {
      this.AssignRole(this._user, this.grvRole.GetRow(this.grvRole.FocusedRowHandle) as ObjSEC_Role, Convert.ToBoolean(e.Value));
    }

    private void btnSave_Click(object sender, EventArgs e) => this.SaveData();

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.RoleAssignDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.Administration
{
  public class RoleAssignDataPresenter(IRoleAssignView view) : 
    AdministrationPresenter<IRoleAssignView>(view)
  {
    public void ListRole()
    {
      this._iView.BLstRole = AdministrationPresenter<IRoleAssignView>._iAdministrationModel.ListSEC_Role();
    }

    public void ListUser()
    {
      this._iView.BLstUser = AdministrationPresenter<IRoleAssignView>._iAdministrationModel.ListSEC_User();
    }

    public void ListUserRole()
    {
      this._iView.BLstUserRole = AdministrationPresenter<IRoleAssignView>._iAdministrationModel.ListSEC_UserRole();
    }

    public void SaveUserRole(BindingList<ObjSEC_UserRole> blstUserRole)
    {
      this._iView.IsSuccessfulSaved = AdministrationPresenter<IRoleAssignView>._iAdministrationModel.SaveSEC_UserRole(blstUserRole);
    }
  }
}

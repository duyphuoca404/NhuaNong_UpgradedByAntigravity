// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.NewRoleDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.Administration
{
  public class NewRoleDataPresenter(INewRoleView view) : AdministrationPresenter<INewRoleView>(view)
  {
    public void BuildNewRole()
    {
      this._iView.Role = new ObjSEC_Role()
      {
        RoleName = string.Empty,
        Description = string.Empty
      };
    }

    public void GetRoleByKey(int soID)
    {
      this._iView.Role = AdministrationPresenter<INewRoleView>._iAdministrationModel.GetSEC_RoleByKey(soID);
    }

    public void SaveRole(BindingList<ObjSEC_Role> blstCT)
    {
      this._iView.IsSuccessfulSaved = AdministrationPresenter<INewRoleView>._iAdministrationModel.SaveSEC_Role(blstCT);
    }
  }
}

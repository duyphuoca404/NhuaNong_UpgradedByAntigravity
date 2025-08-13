// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.FunctionAssignDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.Administration
{
  public class FunctionAssignDataPresenter(IFunctionAssignView view) : 
    AdministrationPresenter<IFunctionAssignView>(view)
  {
    public void ListFunction_FuncType()
    {
      this._iView.BLstFunction_FuncType = AdministrationPresenter<IFunctionAssignView>._iAdministrationModel.ListSEC_Function_ByFunctionType(2);
    }

    public void ListFunction_MenuType()
    {
      this._iView.BLstFunction_MenuType = AdministrationPresenter<IFunctionAssignView>._iAdministrationModel.ListSEC_Function_ByFunctionType(1);
    }

    public void ListRole()
    {
      this._iView.BLstRole = AdministrationPresenter<IFunctionAssignView>._iAdministrationModel.ListSEC_Role();
    }

    public void ListRoleFunction()
    {
      this._iView.BLstRoleFunction = AdministrationPresenter<IFunctionAssignView>._iAdministrationModel.ListSEC_RoleFunction();
    }

    public void SaveRoleFunction(BindingList<ObjSEC_RoleFunction> blstRoleFunction)
    {
      this._iView.IsSuccessfulSaved = AdministrationPresenter<IFunctionAssignView>._iAdministrationModel.SaveSEC_RoleFunction(blstRoleFunction);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.RoleMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.Administration
{
  public class RoleMngDataPresenter(IRoleMngView view) : AdministrationPresenter<IRoleMngView>(view)
  {
    public void ListRole()
    {
      this._iView.BLstRole = AdministrationPresenter<IRoleMngView>._iAdministrationModel.ListSEC_Role();
    }

    public void SaveRole(BindingList<ObjSEC_Role> blstCT)
    {
      this._iView.IsSuccessfulSaved = AdministrationPresenter<IRoleMngView>._iAdministrationModel.SaveSEC_Role(blstCT);
    }
  }
}

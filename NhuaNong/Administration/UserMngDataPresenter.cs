// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.UserMngDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.Administration
{
  public class UserMngDataPresenter(IUserMngView view) : AdministrationPresenter<IUserMngView>(view)
  {
    public void ListUser()
    {
      this._iView.BLstUser = AdministrationPresenter<IUserMngView>._iAdministrationModel.ListSEC_User();
    }

    public void ListUser_ByActive(bool? active)
    {
      this._iView.BLstUser = AdministrationPresenter<IUserMngView>._iAdministrationModel.ListSEC_User_ByActive(active);
    }

    public void SaveUser(BindingList<ObjSEC_User> blstCT)
    {
      this._iView.IsSuccessfulSaved = AdministrationPresenter<IUserMngView>._iAdministrationModel.SaveSEC_User(blstCT);
    }
  }
}

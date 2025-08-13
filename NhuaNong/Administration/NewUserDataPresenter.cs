// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.NewUserDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System.ComponentModel;

#nullable disable
namespace NhuaNong.Administration
{
  public class NewUserDataPresenter(INewUserView view) : AdministrationPresenter<INewUserView>(view)
  {
    public void BuildNewUser()
    {
      this._iView.User = new ObjSEC_User()
      {
        UserName = string.Empty,
        Password = string.Empty,
        FullName = string.Empty,
        Department = string.Empty,
        Email = string.Empty,
        Phone = string.Empty,
        IsActived = new bool?(true),
        IsInUse = new bool?(false)
      };
    }

    public void GetUserByKey(int soID)
    {
      this._iView.User = AdministrationPresenter<INewUserView>._iAdministrationModel.GetSEC_UserByKey(soID);
    }

    public void SaveUser(BindingList<ObjSEC_User> blstCT)
    {
      this._iView.IsSuccessfulSaved = AdministrationPresenter<INewUserView>._iAdministrationModel.SaveSEC_User(blstCT);
    }
  }
}

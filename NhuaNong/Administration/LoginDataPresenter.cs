// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.LoginDataPresenter
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

#nullable disable
namespace NhuaNong.Administration
{
  public class LoginDataPresenter(ILoginView view) : AdministrationPresenter<ILoginView>(view)
  {
    public void GetSEC_User_ByUsername_Pass(string username, string password)
    {
      this._iView.LoginUser = AdministrationPresenter<ILoginView>._iAdministrationModel.GetSEC_User_ByUsername_Pass(username, password);
    }
  }
}

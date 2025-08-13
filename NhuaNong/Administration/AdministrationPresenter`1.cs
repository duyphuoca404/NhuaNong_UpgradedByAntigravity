// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.AdministrationPresenter`1
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

#nullable disable
namespace NhuaNong.Administration
{
  public class AdministrationPresenter<T> where T : IBase
  {
    protected static IAdministrationModel _iAdministrationModel { get; private set; }

    protected T _iView { get; private set; }

    static AdministrationPresenter()
    {
      AdministrationPresenter<T>._iAdministrationModel = (IAdministrationModel) new AdministrationModel();
    }

    public AdministrationPresenter(T view) => this._iView = view;
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.MasterDataPresenter`1
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

#nullable disable
namespace NhuaNong.MasterData
{
  public class MasterDataPresenter<T> where T : IBase
  {
    public MasterDataPresenter(T view) => this._iView = view;

    private protected static IMasterDataModel _iMasterDataModel { get; private set; } = (IMasterDataModel) new MasterDataModel();

    private protected T _iView { get; private set; }
  }
}

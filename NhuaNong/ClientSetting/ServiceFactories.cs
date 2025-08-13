// Decompiled with JetBrains decompiler
// Type: NhuaNong.ClientSetting.ServiceFactories
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

#nullable disable
namespace NhuaNong.ClientSetting
{
  public class ServiceFactories
  {
    public static IServices GetFactory(int mode)
    {
      if (mode == 0)
        return (IServices) new LocalServicesFactory();
      return (IServices) new LocalServicesFactory();
    }
  }
}

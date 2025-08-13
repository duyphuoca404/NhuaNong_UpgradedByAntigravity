// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.ConfigManager
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

#nullable disable
namespace NhuaNong.Utils
{
  public class ConfigManager
  {
    private static TramTronConfig _TramTronConfig = new TramTronConfig();
    private static ServiceConfig _ServiceConfig = new ServiceConfig();

    public static TramTronConfig TramTronConfig => ConfigManager._TramTronConfig;

    public static ServiceConfig ServiceConfig => ConfigManager._ServiceConfig;
  }
}

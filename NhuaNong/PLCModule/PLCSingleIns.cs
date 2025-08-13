// Decompiled with JetBrains decompiler
// Type: NhuaNong.PLCModule.PLCSingleIns
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Utils;
using S7.Net;

#nullable disable
namespace NhuaNong.PLCModule
{
  public class PLCSingleIns
  {
    private static Plc instance;
    private static readonly object lockObject = new object();

    private PLCSingleIns()
    {
    }

    public static Plc Instance
    {
      get
      {
        lock (PLCSingleIns.lockObject)
        {
          if (PLCSingleIns.instance == null)
          {
            PLCSingleIns.instance = new Plc(CpuType.S71200, ConfigManager.TramTronConfig.LANIP, (short) 0, (short) 1);
            PLCSingleIns.instance.Open();
          }
          return PLCSingleIns.instance;
        }
      }
    }
  }
}

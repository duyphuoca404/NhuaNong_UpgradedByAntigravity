// Decompiled with JetBrains decompiler
// Type: NhuaNong.EventLogController
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.ServiceLibrary;
using NhuaNong.Data;
using NhuaNong.Utils;

#nullable disable
namespace NhuaNong
{
  public class EventLogController
  {
    public static bool InsertEventLog(ObjEventLog objEventLog)
    {
      return ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).InsertEventLog(objEventLog);
    }

    public static bool InsertEventLog(
      int? userId,
      string userName,
      string eventActionCode,
      string result,
      string oldValueText,
      string newValueText)
    {
      return ServiceFactories.GetFactory(0).InsertEventLog(userId, userName, eventActionCode, result, oldValueText, newValueText);
    }
  }
}

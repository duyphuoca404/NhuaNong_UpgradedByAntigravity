// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.FormatToString
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;

#nullable disable
namespace NhuaNong.Utils
{
  public class FormatToString
  {
    public static string DateTimeToString(DateTime dateTime)
    {
      try
      {
        return dateTime.Day.ToString() + "/" + dateTime.Month.ToString() + "/" + dateTime.Year.ToString();
      }
      catch (System.Exception ex)
      {
        throw ex;
      }
    }
  }
}

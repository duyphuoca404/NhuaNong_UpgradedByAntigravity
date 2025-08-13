// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.Searching
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using System;
using System.Data.SqlTypes;

#nullable disable
namespace NhuaNong.Utils
{
  public class Searching
  {
    public static DateTime Build_StartDateTime(DateTime datValue)
    {
      if (datValue == DateTime.MinValue)
        return SqlDateTime.MinValue.Value;
      datValue = datValue.AddSeconds(-(double) datValue.Second);
      datValue = datValue.AddMinutes(-(double) datValue.Minute);
      datValue = datValue.AddHours(-(double) datValue.Hour);
      return datValue;
    }

    public static DateTime BuildNew_StartDateTime(DateTime datValue, TimeSpan timeValue)
    {
      if (datValue == DateTime.MinValue)
        return SqlDateTime.MinValue.Value;
      datValue = datValue.Date;
      datValue = datValue.Add(timeValue);
      return datValue;
    }

    public static DateTime Build_EndDateTime(DateTime datValue)
    {
      if (datValue == DateTime.MinValue)
        return SqlDateTime.MaxValue.Value;
      datValue = datValue.AddSeconds((double) (60 - datValue.Second));
      datValue = datValue.AddMinutes((double) (60 - datValue.Minute));
      datValue = datValue.AddHours((double) (24 - datValue.Hour));
      return datValue;
    }

    public static DateTime BuildNew_EndDateTime(DateTime datValue, TimeSpan timeValue)
    {
      if (datValue == DateTime.MinValue)
        return SqlDateTime.MaxValue.Value;
      datValue = datValue.Date;
      datValue = datValue.Add(timeValue);
      return datValue;
    }
  }
}

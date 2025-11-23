// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.TimerParaHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class TimerParaHelper
  {
    public static void CopyToObjTimerPara(TimerPara fromEnt, ObjTimerPara toObj)
    {
      toObj.TimerParaID = fromEnt.TimerParaID;
      toObj.TimerParaCode = fromEnt.TimerParaCode;
      toObj.TimerParaValue = fromEnt.TimerParaValue;
      toObj.Description = fromEnt.Description;
      if (toObj.TimerParaID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntTimerPara(ObjTimerPara fromObj, TimerPara toEnt)
    {
      toEnt.TimerParaID = fromObj.TimerParaID;
      toEnt.TimerParaCode = fromObj.TimerParaCode;
      toEnt.TimerParaValue = fromObj.TimerParaValue;
      toEnt.Description = fromObj.Description;
    }

    public static ObjTimerPara BuildNewObjTimerPara(TimerPara entTimerPara)
    {
      ObjTimerPara toObj = new ObjTimerPara();
      TimerParaHelper.CopyToObjTimerPara(entTimerPara, toObj);
      return toObj;
    }

    public static IList<ObjTimerPara> BuildListObjTimerPara(IList<TimerPara> lstEntTimerPara)
    {
      IList<ObjTimerPara> objTimerParaList = (IList<ObjTimerPara>) new List<ObjTimerPara>();
      foreach (TimerPara entTimerPara in (IEnumerable<TimerPara>) lstEntTimerPara)
        objTimerParaList.Add(TimerParaHelper.BuildNewObjTimerPara(entTimerPara));
      return objTimerParaList;
    }

    public static TimerPara BuildNewEntTimerPara(ObjTimerPara objTimerPara)
    {
      TimerPara toEnt = new TimerPara();
      TimerParaHelper.CopyToEntTimerPara(objTimerPara, toEnt);
      return toEnt;
    }

    public static IList<TimerPara> BuildListEntTimerPara(IList<ObjTimerPara> lstObjTimerPara)
    {
      IList<TimerPara> timerParaList = (IList<TimerPara>) new List<TimerPara>();
      foreach (ObjTimerPara objTimerPara in (IEnumerable<ObjTimerPara>) lstObjTimerPara)
        timerParaList.Add(TimerParaHelper.BuildNewEntTimerPara(objTimerPara));
      return timerParaList;
    }
  }
}

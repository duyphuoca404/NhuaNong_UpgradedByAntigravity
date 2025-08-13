// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.PCInputHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class PCInputHelper
  {
    public static void CopyToObjPCInput(PCInput fromEnt, ObjPCInput toObj)
    {
      toObj.PCInputID = fromEnt.PCInputID;
      toObj.Code = fromEnt.Code;
      toObj.Value = fromEnt.Value;
      toObj.Description = fromEnt.Description;
      if (toObj.PCInputID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntPCInput(ObjPCInput fromObj, PCInput toEnt)
    {
      toEnt.PCInputID = fromObj.PCInputID;
      toEnt.Code = fromObj.Code;
      toEnt.Value = fromObj.Value;
      toEnt.Description = fromObj.Description;
    }

    public static ObjPCInput BuildNewObjPCInput(PCInput entPCInput)
    {
      ObjPCInput toObj = new ObjPCInput();
      PCInputHelper.CopyToObjPCInput(entPCInput, toObj);
      return toObj;
    }

    public static IList<ObjPCInput> BuildListObjPCInput(IList<PCInput> lstEntPCInput)
    {
      IList<ObjPCInput> objPcInputList = (IList<ObjPCInput>) new List<ObjPCInput>();
      foreach (PCInput entPCInput in (IEnumerable<PCInput>) lstEntPCInput)
        objPcInputList.Add(PCInputHelper.BuildNewObjPCInput(entPCInput));
      return objPcInputList;
    }

    public static PCInput BuildNewEntPCInput(ObjPCInput objPCInput)
    {
      PCInput toEnt = new PCInput();
      PCInputHelper.CopyToEntPCInput(objPCInput, toEnt);
      return toEnt;
    }

    public static IList<PCInput> BuildListEntPCInput(IList<ObjPCInput> lstObjPCInput)
    {
      IList<PCInput> pcInputList = (IList<PCInput>) new List<PCInput>();
      foreach (ObjPCInput objPCInput in (IEnumerable<ObjPCInput>) lstObjPCInput)
        pcInputList.Add(PCInputHelper.BuildNewEntPCInput(objPCInput));
      return pcInputList;
    }
  }
}

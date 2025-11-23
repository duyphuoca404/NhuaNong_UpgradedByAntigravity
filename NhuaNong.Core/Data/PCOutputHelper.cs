// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.PCOutputHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class PCOutputHelper
  {
    public static void CopyToObjPCOutput(PCOutput fromEnt, ObjPCOutput toObj)
    {
      toObj.PCOutputID = fromEnt.PCOutputID;
      toObj.Code = fromEnt.Code;
      toObj.Value = fromEnt.Value;
      toObj.Description = fromEnt.Description;
      if (toObj.PCOutputID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntPCOutput(ObjPCOutput fromObj, PCOutput toEnt)
    {
      toEnt.PCOutputID = fromObj.PCOutputID;
      toEnt.Code = fromObj.Code;
      toEnt.Value = fromObj.Value;
      toEnt.Description = fromObj.Description;
    }

    public static ObjPCOutput BuildNewObjPCOutput(PCOutput entPCOutput)
    {
      ObjPCOutput toObj = new ObjPCOutput();
      PCOutputHelper.CopyToObjPCOutput(entPCOutput, toObj);
      return toObj;
    }

    public static IList<ObjPCOutput> BuildListObjPCOutput(IList<PCOutput> lstEntPCOutput)
    {
      IList<ObjPCOutput> objPcOutputList = (IList<ObjPCOutput>) new List<ObjPCOutput>();
      foreach (PCOutput entPCOutput in (IEnumerable<PCOutput>) lstEntPCOutput)
        objPcOutputList.Add(PCOutputHelper.BuildNewObjPCOutput(entPCOutput));
      return objPcOutputList;
    }

    public static PCOutput BuildNewEntPCOutput(ObjPCOutput objPCOutput)
    {
      PCOutput toEnt = new PCOutput();
      PCOutputHelper.CopyToEntPCOutput(objPCOutput, toEnt);
      return toEnt;
    }

    public static IList<PCOutput> BuildListEntPCOutput(IList<ObjPCOutput> lstObjPCOutput)
    {
      IList<PCOutput> pcOutputList = (IList<PCOutput>) new List<PCOutput>();
      foreach (ObjPCOutput objPCOutput in (IEnumerable<ObjPCOutput>) lstObjPCOutput)
        pcOutputList.Add(PCOutputHelper.BuildNewEntPCOutput(objPCOutput));
      return pcOutputList;
    }
  }
}

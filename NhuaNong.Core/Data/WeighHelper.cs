// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.WeighHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class WeighHelper
  {
    public static void CopyToObjWeigh(Weigh fromEnt, ObjWeigh toObj)
    {
      toObj.WeighID = fromEnt.WeighID;
      toObj.WeighCode = fromEnt.WeighCode;
      toObj.WeighName = fromEnt.WeighName;
      toObj.Description = fromEnt.Description;
      toObj.STT = fromEnt.STT;
      toObj.Zero = fromEnt.Zero;
      toObj.Max = fromEnt.Max;
      toObj.Offset = fromEnt.Offset;
      toObj.KLEmpty = fromEnt.KLEmpty;
      toObj.TimeEmpty = fromEnt.TimeEmpty;
      toObj.Limit = fromEnt.Limit;
      toObj.WeiToVib = fromEnt.WeiToVib;
      toObj.TON = fromEnt.TON;
      toObj.TOFF = fromEnt.TOFF;
      toObj.Spare = fromEnt.Spare;
      toObj.GiuKLTC = fromEnt.GiuKLTC;
      if (toObj.WeighID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntWeigh(ObjWeigh fromObj, Weigh toEnt)
    {
      toEnt.WeighID = fromObj.WeighID;
      toEnt.WeighCode = fromObj.WeighCode;
      toEnt.WeighName = fromObj.WeighName;
      toEnt.Description = fromObj.Description;
      toEnt.STT = fromObj.STT;
      toEnt.Zero = fromObj.Zero;
      toEnt.Max = fromObj.Max;
      toEnt.Offset = fromObj.Offset;
      toEnt.KLEmpty = fromObj.KLEmpty;
      toEnt.TimeEmpty = fromObj.TimeEmpty;
      toEnt.Limit = fromObj.Limit;
      toEnt.WeiToVib = fromObj.WeiToVib;
      toEnt.TON = fromObj.TON;
      toEnt.TOFF = fromObj.TOFF;
      toEnt.Spare = fromObj.Spare;
      toEnt.GiuKLTC = fromObj.GiuKLTC;
    }

    public static ObjWeigh BuildNewObjWeigh(Weigh entWeigh)
    {
      ObjWeigh toObj = new ObjWeigh();
      WeighHelper.CopyToObjWeigh(entWeigh, toObj);
      return toObj;
    }

    public static IList<ObjWeigh> BuildListObjWeigh(IList<Weigh> lstEntWeigh)
    {
      IList<ObjWeigh> objWeighList = (IList<ObjWeigh>) new List<ObjWeigh>();
      foreach (Weigh entWeigh in (IEnumerable<Weigh>) lstEntWeigh)
        objWeighList.Add(WeighHelper.BuildNewObjWeigh(entWeigh));
      return objWeighList;
    }

    public static Weigh BuildNewEntWeigh(ObjWeigh objWeigh)
    {
      Weigh toEnt = new Weigh();
      WeighHelper.CopyToEntWeigh(objWeigh, toEnt);
      return toEnt;
    }

    public static IList<Weigh> BuildListEntWeigh(IList<ObjWeigh> lstObjWeigh)
    {
      IList<Weigh> weighList = (IList<Weigh>) new List<Weigh>();
      foreach (ObjWeigh objWeigh in (IEnumerable<ObjWeigh>) lstObjWeigh)
        weighList.Add(WeighHelper.BuildNewEntWeigh(objWeigh));
      return weighList;
    }
  }
}

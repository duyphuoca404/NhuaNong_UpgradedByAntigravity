// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.MACSiloHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class MACSiloHelper
  {
    public static void CopyToObjMACSilo(MACSilo fromEnt, ObjMACSilo toObj)
    {
      toObj.MACSiloID = fromEnt.MACSiloID;
      toObj.MACID = fromEnt.MACID;
      toObj.SiloID = fromEnt.SiloID;
      toObj.SiloValue = fromEnt.SiloValue;
      toObj.GhiChu = fromEnt.GhiChu;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.NPSiloMaSilo = fromEnt.Silo.MaSilo;
      toObj.NPSiloTenSilo = fromEnt.Silo.TenSilo;
      toObj.NPSiloMaterialName = fromEnt.Silo.MaterialName;
      if (toObj.MACSiloID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntMACSilo(ObjMACSilo fromObj, MACSilo toEnt)
    {
      toEnt.MACSiloID = fromObj.MACSiloID;
      toEnt.MACID = fromObj.MACID;
      toEnt.SiloID = fromObj.SiloID;
      toEnt.SiloValue = fromObj.SiloValue;
      toEnt.GhiChu = fromObj.GhiChu;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjMACSilo BuildNewObjMACSilo(MACSilo entMACSilo)
    {
      ObjMACSilo toObj = new ObjMACSilo();
      MACSiloHelper.CopyToObjMACSilo(entMACSilo, toObj);
      return toObj;
    }

    public static IList<ObjMACSilo> BuildListObjMACSilo(IList<MACSilo> lstEntMACSilo)
    {
      IList<ObjMACSilo> objMacSiloList = (IList<ObjMACSilo>) new List<ObjMACSilo>();
      foreach (MACSilo entMACSilo in (IEnumerable<MACSilo>) lstEntMACSilo)
        objMacSiloList.Add(MACSiloHelper.BuildNewObjMACSilo(entMACSilo));
      return objMacSiloList;
    }

    public static MACSilo BuildNewEntMACSilo(ObjMACSilo objMACSilo)
    {
      MACSilo toEnt = new MACSilo();
      MACSiloHelper.CopyToEntMACSilo(objMACSilo, toEnt);
      return toEnt;
    }

    public static IList<MACSilo> BuildListEntMACSilo(IList<ObjMACSilo> lstObjMACSilo)
    {
      IList<MACSilo> macSiloList = (IList<MACSilo>) new List<MACSilo>();
      foreach (ObjMACSilo objMACSilo in (IEnumerable<ObjMACSilo>) lstObjMACSilo)
        macSiloList.Add(MACSiloHelper.BuildNewEntMACSilo(objMACSilo));
      return macSiloList;
    }
  }
}

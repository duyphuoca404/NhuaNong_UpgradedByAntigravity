// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.TinhDoHutNuocHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class TinhDoHutNuocHelper
  {
    public static void CopyToObjTinhDoHutNuoc(TinhDoHutNuoc fromEnt, ObjTinhDoHutNuoc toObj)
    {
      toObj.TinhDoHutNuocID = fromEnt.TinhDoHutNuocID;
      toObj.MaTinhDoHutNuoc = fromEnt.MaTinhDoHutNuoc;
      toObj.NgayTinhDoHut = fromEnt.NgayTinhDoHut;
      toObj.NhomSiloID = fromEnt.NhomSiloID;
      toObj.Name = fromEnt.Name;
      toObj.DoHutNuoc = fromEnt.DoHutNuoc;
      toObj.Description = fromEnt.Description;
      toObj.VersionNo = fromEnt.VersionNo;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      if (toObj.TinhDoHutNuocID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntTinhDoHutNuoc(ObjTinhDoHutNuoc fromObj, TinhDoHutNuoc toEnt)
    {
      toEnt.TinhDoHutNuocID = fromObj.TinhDoHutNuocID;
      toEnt.MaTinhDoHutNuoc = fromObj.MaTinhDoHutNuoc;
      toEnt.NgayTinhDoHut = fromObj.NgayTinhDoHut;
      toEnt.NhomSiloID = fromObj.NhomSiloID;
      toEnt.Name = fromObj.Name;
      toEnt.DoHutNuoc = fromObj.DoHutNuoc;
      toEnt.Description = fromObj.Description;
      toEnt.VersionNo = fromObj.VersionNo;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjTinhDoHutNuoc BuildNewObjTinhDoHutNuoc(TinhDoHutNuoc entTinhDoHutNuoc)
    {
      ObjTinhDoHutNuoc toObj = new ObjTinhDoHutNuoc();
      TinhDoHutNuocHelper.CopyToObjTinhDoHutNuoc(entTinhDoHutNuoc, toObj);
      return toObj;
    }

    public static IList<ObjTinhDoHutNuoc> BuildListObjTinhDoHutNuoc(
      IList<TinhDoHutNuoc> lstEntTinhDoHutNuoc)
    {
      IList<ObjTinhDoHutNuoc> objTinhDoHutNuocList = (IList<ObjTinhDoHutNuoc>) new List<ObjTinhDoHutNuoc>();
      foreach (TinhDoHutNuoc entTinhDoHutNuoc in (IEnumerable<TinhDoHutNuoc>) lstEntTinhDoHutNuoc)
        objTinhDoHutNuocList.Add(TinhDoHutNuocHelper.BuildNewObjTinhDoHutNuoc(entTinhDoHutNuoc));
      return objTinhDoHutNuocList;
    }

    public static TinhDoHutNuoc BuildNewEntTinhDoHutNuoc(ObjTinhDoHutNuoc objTinhDoHutNuoc)
    {
      TinhDoHutNuoc toEnt = new TinhDoHutNuoc();
      TinhDoHutNuocHelper.CopyToEntTinhDoHutNuoc(objTinhDoHutNuoc, toEnt);
      return toEnt;
    }

    public static IList<TinhDoHutNuoc> BuildListEntTinhDoHutNuoc(
      IList<ObjTinhDoHutNuoc> lstObjTinhDoHutNuoc)
    {
      IList<TinhDoHutNuoc> tinhDoHutNuocList = (IList<TinhDoHutNuoc>) new List<TinhDoHutNuoc>();
      foreach (ObjTinhDoHutNuoc objTinhDoHutNuoc in (IEnumerable<ObjTinhDoHutNuoc>) lstObjTinhDoHutNuoc)
        tinhDoHutNuocList.Add(TinhDoHutNuocHelper.BuildNewEntTinhDoHutNuoc(objTinhDoHutNuoc));
      return tinhDoHutNuocList;
    }
  }
}

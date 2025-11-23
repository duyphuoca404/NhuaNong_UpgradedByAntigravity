// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.WeiSiloVisibleHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class WeiSiloVisibleHelper
  {
    public static void CopyToObjWeiSiloVisible(WeiSiloVisible fromEnt, ObjWeiSiloVisible toObj)
    {
      toObj.WeiSiloVisibleID = fromEnt.WeiSiloVisibleID;
      toObj.Code = fromEnt.Code;
      toObj.Type = fromEnt.Type;
      toObj.Visible = fromEnt.Visible;
      if (toObj.WeiSiloVisibleID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntWeiSiloVisible(ObjWeiSiloVisible fromObj, WeiSiloVisible toEnt)
    {
      toEnt.WeiSiloVisibleID = fromObj.WeiSiloVisibleID;
      toEnt.Code = fromObj.Code;
      toEnt.Type = fromObj.Type;
      toEnt.Visible = fromObj.Visible;
    }

    public static ObjWeiSiloVisible BuildNewObjWeiSiloVisible(WeiSiloVisible entWeiSiloVisible)
    {
      ObjWeiSiloVisible toObj = new ObjWeiSiloVisible();
      WeiSiloVisibleHelper.CopyToObjWeiSiloVisible(entWeiSiloVisible, toObj);
      return toObj;
    }

    public static IList<ObjWeiSiloVisible> BuildListObjWeiSiloVisible(
      IList<WeiSiloVisible> lstEntWeiSiloVisible)
    {
      IList<ObjWeiSiloVisible> objWeiSiloVisibleList = (IList<ObjWeiSiloVisible>) new List<ObjWeiSiloVisible>();
      foreach (WeiSiloVisible entWeiSiloVisible in (IEnumerable<WeiSiloVisible>) lstEntWeiSiloVisible)
        objWeiSiloVisibleList.Add(WeiSiloVisibleHelper.BuildNewObjWeiSiloVisible(entWeiSiloVisible));
      return objWeiSiloVisibleList;
    }

    public static WeiSiloVisible BuildNewEntWeiSiloVisible(ObjWeiSiloVisible objWeiSiloVisible)
    {
      WeiSiloVisible toEnt = new WeiSiloVisible();
      WeiSiloVisibleHelper.CopyToEntWeiSiloVisible(objWeiSiloVisible, toEnt);
      return toEnt;
    }

    public static IList<WeiSiloVisible> BuildListEntWeiSiloVisible(
      IList<ObjWeiSiloVisible> lstObjWeiSiloVisible)
    {
      IList<WeiSiloVisible> weiSiloVisibleList = (IList<WeiSiloVisible>) new List<WeiSiloVisible>();
      foreach (ObjWeiSiloVisible objWeiSiloVisible in (IEnumerable<ObjWeiSiloVisible>) lstObjWeiSiloVisible)
        weiSiloVisibleList.Add(WeiSiloVisibleHelper.BuildNewEntWeiSiloVisible(objWeiSiloVisible));
      return weiSiloVisibleList;
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.MaterialHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class MaterialHelper
  {
    public static void CopyToObjMaterial(Material fromEnt, ObjMaterial toObj)
    {
      toObj.MaterialID = fromEnt.MaterialID;
      toObj.MaterialCode = fromEnt.MaterialCode;
      toObj.MaterialName = fromEnt.MaterialName;
      toObj.Supplier = fromEnt.Supplier;
      toObj.Unit = fromEnt.Unit;
      toObj.Price = fromEnt.Price;
      toObj.Description = fromEnt.Description;
      toObj.Activated = fromEnt.Activated;
      toObj.VersionNo = fromEnt.VersionNo;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      if (toObj.MaterialID <= 0)
        return;
      toObj.IsNewObject = false;
      if (!fromEnt.Unit.HasValue)
        return;
      for (int index = 0; index < Converter.EnumToListFieldCode<Enums.Unit>(true).Count; ++index)
      {
        if (Converter.EnumToListFieldCode<Enums.Unit>(true)[index].ID == fromEnt.Unit.Value)
          toObj.UnitName = Converter.EnumToListFieldCode<Enums.Unit>(true)[index].Code;
      }
    }

    public static void CopyToEntMaterial(ObjMaterial fromObj, Material toEnt)
    {
      toEnt.MaterialID = fromObj.MaterialID;
      toEnt.MaterialCode = fromObj.MaterialCode;
      toEnt.MaterialName = fromObj.MaterialName;
      toEnt.Supplier = fromObj.Supplier;
      toEnt.Unit = fromObj.Unit;
      toEnt.Price = fromObj.Price;
      toEnt.Description = fromObj.Description;
      toEnt.Activated = fromObj.Activated;
      toEnt.VersionNo = fromObj.VersionNo;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
    }

    public static ObjMaterial BuildNewObjMaterial(Material entMaterial)
    {
      ObjMaterial toObj = new ObjMaterial();
      MaterialHelper.CopyToObjMaterial(entMaterial, toObj);
      return toObj;
    }

    public static IList<ObjMaterial> BuildListObjMaterial(IList<Material> lstEntMaterial)
    {
      IList<ObjMaterial> objMaterialList = (IList<ObjMaterial>) new List<ObjMaterial>();
      foreach (Material entMaterial in (IEnumerable<Material>) lstEntMaterial)
        objMaterialList.Add(MaterialHelper.BuildNewObjMaterial(entMaterial));
      return objMaterialList;
    }

    public static Material BuildNewEntMaterial(ObjMaterial objMaterial)
    {
      Material toEnt = new Material();
      MaterialHelper.CopyToEntMaterial(objMaterial, toEnt);
      return toEnt;
    }

    public static IList<Material> BuildListEntMaterial(IList<ObjMaterial> lstObjMaterial)
    {
      IList<Material> materialList = (IList<Material>) new List<Material>();
      foreach (ObjMaterial objMaterial in (IEnumerable<ObjMaterial>) lstObjMaterial)
        materialList.Add(MaterialHelper.BuildNewEntMaterial(objMaterial));
      return materialList;
    }
  }
}

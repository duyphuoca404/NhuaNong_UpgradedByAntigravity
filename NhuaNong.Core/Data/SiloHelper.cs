// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.SiloHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class SiloHelper
  {
    public static string GenMemberValues(ObjSilo obj)
    {
      return string.Empty + "#1@#SiloID#2@#" + obj.SiloID.ToString() + "#1@#MaSilo#2@#" + obj.MaSilo + "#1@#TenSilo#2@#" + obj.TenSilo + "#1@#NhomSiloID#2@#" + obj.NhomSiloID.ToString() + "#1@#SoTT#2@#" + obj.SoTT.ToString() + "#1@#SaiSoDuoi#2@#" + obj.SaiSoDuoi.ToString() + "#1@#SaiSoTren#2@#" + obj.SaiSoTren.ToString() + "#1@#KLCanNhoNhat#2@#" + obj.KLCanNhoNhat.ToString() + "#1@#KLCanLonNhat#2@#" + obj.KLCanLonNhat.ToString() + "#1@#TGNhapNhaOn#2@#" + obj.TGNhapNhaOn.ToString() + "#1@#TGNhapNhaOff#2@#" + obj.TGNhapNhaOff.ToString() + "#1@#TGKiemTraVatLieuRoi#2@#" + obj.TGKiemTraVatLieuRoi.ToString() + "#1@#KLRoi#2@#" + obj.KLRoi.ToString() + "#1@#K_Pulse#2@#" + obj.K_Pulse.ToString() + "#1@#KLDT_Tu1#2@#" + obj.KLDT_Tu1.ToString() + "#1@#KLDT_Tu2#2@#" + obj.KLDT_Tu2.ToString() + "#1@#KLDT_Tu3#2@#" + obj.KLDT_Tu3.ToString() + "#1@#KLDT_Den1#2@#" + obj.KLDT_Den1.ToString() + "#1@#KLDT_Den2#2@#" + obj.KLDT_Den2.ToString() + "#1@#KLDT_Den3#2@#" + obj.KLDT_Den3.ToString() + "#1@#KLDT_DungTruoc1#2@#" + obj.KLDT_DungTruoc1.ToString() + "#1@#KLDT_DungTruoc2#2@#" + obj.KLDT_DungTruoc2.ToString() + "#1@#KLDT_DungTruoc3#2@#" + obj.KLDT_DungTruoc3.ToString() + "#1@#TinhDoHutNuocID#2@#" + obj.TinhDoHutNuocID.ToString() + "#1@#TinhDoHutNuocName#2@#" + obj.TinhDoHutNuocName + "#1@#DoAm_NhomSlioAgg#2@#" + obj.DoAm_NhomSlioAgg.ToString() + "#1@#DoHutNuoc_NhomSiloAgg#2@#" + obj.DoHutNuoc_NhomSiloAgg.ToString() + "#1@#SoiTrongCat_NhomSiloAgg#2@#" + obj.SoiTrongCat_NhomSiloAgg.ToString() + "#1@#SoiTrongCat_TruVaoSilo_NhomSiloAgg#2@#" + obj.SoiTrongCat_TruVaoSilo_NhomSiloAgg.ToString() + "#1@#MaterialID#2@#" + obj.MaterialID.ToString() + "#1@#MaterialCode#2@#" + obj.MaterialCode + "#1@#MaterialName#2@#" + obj.MaterialName + "#1@#Activated#2@#" + obj.Activated.ToString() + "#1@#CreationDate#2@#" + obj.CreationDate.ToString() + "#1@#CreatedBy#2@#" + obj.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + obj.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + obj.LatestUpdatedBy.ToString() + "#1@#VersionNo#2@#" + obj.VersionNo?.ToString();
    }

    public static string GenMemberValues(Silo ent)
    {
      return string.Empty + "#1@#SiloID#2@#" + ent.SiloID.ToString() + "#1@#MaSilo#2@#" + ent.MaSilo + "#1@#TenSilo#2@#" + ent.TenSilo + "#1@#NhomSiloID#2@#" + ent.NhomSiloID.ToString() + "#1@#SoTT#2@#" + ent.SoTT.ToString() + "#1@#SaiSoDuoi#2@#" + ent.SaiSoDuoi.ToString() + "#1@#SaiSoTren#2@#" + ent.SaiSoTren.ToString() + "#1@#KLCanNhoNhat#2@#" + ent.KLCanNhoNhat.ToString() + "#1@#KLCanLonNhat#2@#" + ent.KLCanLonNhat.ToString() + "#1@#TGNhapNhaOn#2@#" + ent.TGNhapNhaOn.ToString() + "#1@#TGNhapNhaOff#2@#" + ent.TGNhapNhaOff.ToString() + "#1@#TGKiemTraVatLieuRoi#2@#" + ent.TGKiemTraVatLieuRoi.ToString() + "#1@#KLRoi#2@#" + ent.KLRoi.ToString() + "#1@#K_Pulse#2@#" + ent.K_Pulse.ToString() + "#1@#KLDT_Tu1#2@#" + ent.KLDT_Tu1.ToString() + "#1@#KLDT_Tu2#2@#" + ent.KLDT_Tu2.ToString() + "#1@#KLDT_Tu3#2@#" + ent.KLDT_Tu3.ToString() + "#1@#KLDT_Den1#2@#" + ent.KLDT_Den1.ToString() + "#1@#KLDT_Den2#2@#" + ent.KLDT_Den2.ToString() + "#1@#KLDT_Den3#2@#" + ent.KLDT_Den3.ToString() + "#1@#KLDT_DungTruoc1#2@#" + ent.KLDT_DungTruoc1.ToString() + "#1@#KLDT_DungTruoc2#2@#" + ent.KLDT_DungTruoc2.ToString() + "#1@#KLDT_DungTruoc3#2@#" + ent.KLDT_DungTruoc3.ToString() + "#1@#TinhDoHutNuocID#2@#" + ent.TinhDoHutNuocID.ToString() + "#1@#TinhDoHutNuocName#2@#" + ent.TinhDoHutNuocName + "#1@#DoAm_NhomSlioAgg#2@#" + ent.DoAm_NhomSlioAgg.ToString() + "#1@#DoHutNuoc_NhomSiloAgg#2@#" + ent.DoHutNuoc_NhomSiloAgg.ToString() + "#1@#SoiTrongCat_NhomSiloAgg#2@#" + ent.SoiTrongCat_NhomSiloAgg.ToString() + "#1@#SoiTrongCat_TruVaoSilo_NhomSiloAgg#2@#" + ent.SoiTrongCat_TruVaoSilo_NhomSiloAgg.ToString() + "#1@#MaterialID#2@#" + ent.MaterialID.ToString() + "#1@#MaterialCode#2@#" + ent.MaterialCode + "#1@#MaterialName#2@#" + ent.MaterialName + "#1@#Activated#2@#" + ent.Activated.ToString() + "#1@#CreationDate#2@#" + ent.CreationDate.ToString() + "#1@#CreatedBy#2@#" + ent.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + ent.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + ent.LatestUpdatedBy.ToString() + "#1@#VersionNo#2@#" + ent.VersionNo?.ToString();
    }

    public static void CopyToObjSilo(Silo fromEnt, ObjSilo toObj)
    {
      toObj.SiloID = fromEnt.SiloID;
      toObj.MaSilo = fromEnt.MaSilo;
      toObj.TenSilo = fromEnt.TenSilo;
      toObj.NhomSiloID = fromEnt.NhomSiloID;
      toObj.SoTT = fromEnt.SoTT;
      toObj.SaiSoDuoi = fromEnt.SaiSoDuoi;
      toObj.SaiSoTren = fromEnt.SaiSoTren;
      toObj.KLCanNhoNhat = fromEnt.KLCanNhoNhat;
      toObj.KLCanLonNhat = fromEnt.KLCanLonNhat;
      toObj.TGNhapNhaOn = fromEnt.TGNhapNhaOn;
      toObj.TGNhapNhaOff = fromEnt.TGNhapNhaOff;
      toObj.TGKiemTraVatLieuRoi = fromEnt.TGKiemTraVatLieuRoi;
      toObj.KLRoi = fromEnt.KLRoi;
      toObj.K_Pulse = fromEnt.K_Pulse;
      toObj.KLDT_Tu1 = fromEnt.KLDT_Tu1;
      toObj.KLDT_Tu2 = fromEnt.KLDT_Tu2;
      toObj.KLDT_Tu3 = fromEnt.KLDT_Tu3;
      toObj.KLDT_Den1 = fromEnt.KLDT_Den1;
      toObj.KLDT_Den2 = fromEnt.KLDT_Den2;
      toObj.KLDT_Den3 = fromEnt.KLDT_Den3;
      toObj.KLDT_DungTruoc1 = fromEnt.KLDT_DungTruoc1;
      toObj.KLDT_DungTruoc2 = fromEnt.KLDT_DungTruoc2;
      toObj.KLDT_DungTruoc3 = fromEnt.KLDT_DungTruoc3;
      toObj.TinhDoHutNuocID = fromEnt.TinhDoHutNuocID;
      toObj.TinhDoHutNuocName = fromEnt.TinhDoHutNuocName;
      toObj.DoAm_NhomSlioAgg = fromEnt.DoAm_NhomSlioAgg;
      toObj.DoHutNuoc_NhomSiloAgg = fromEnt.DoHutNuoc_NhomSiloAgg;
      toObj.SoiTrongCat_NhomSiloAgg = fromEnt.SoiTrongCat_NhomSiloAgg;
      toObj.SoiTrongCat_TruVaoSilo_NhomSiloAgg = fromEnt.SoiTrongCat_TruVaoSilo_NhomSiloAgg;
      toObj.MaterialID = fromEnt.MaterialID;
      toObj.MaterialCode = fromEnt.MaterialCode;
      toObj.MaterialName = fromEnt.MaterialName;
      toObj.Activated = fromEnt.Activated;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.VersionNo = fromEnt.VersionNo;
      toObj.BuTruKLMT = fromEnt.BuTruKLMT;
      toObj.TuDongXNCD = fromEnt.TuDongXNCD;
      if (toObj.SiloID > 0)
        toObj.IsNewObject = false;
      if (fromEnt.Material == null)
        return;
      toObj.MaterialID = new int?(fromEnt.Material.MaterialID);
      toObj.MaterialCode = fromEnt.Material.MaterialCode;
      toObj.MaterialName = fromEnt.Material.MaterialName;
    }

    public static void CopyToEntSilo(ObjSilo fromObj, Silo toEnt)
    {
      toEnt.SiloID = fromObj.SiloID;
      toEnt.MaSilo = fromObj.MaSilo;
      toEnt.TenSilo = fromObj.TenSilo;
      toEnt.NhomSiloID = fromObj.NhomSiloID;
      toEnt.SoTT = fromObj.SoTT;
      toEnt.SaiSoDuoi = fromObj.SaiSoDuoi;
      toEnt.SaiSoTren = fromObj.SaiSoTren;
      toEnt.KLCanNhoNhat = fromObj.KLCanNhoNhat;
      toEnt.KLCanLonNhat = fromObj.KLCanLonNhat;
      toEnt.TGNhapNhaOn = fromObj.TGNhapNhaOn;
      toEnt.TGNhapNhaOff = fromObj.TGNhapNhaOff;
      toEnt.TGKiemTraVatLieuRoi = fromObj.TGKiemTraVatLieuRoi;
      toEnt.KLRoi = fromObj.KLRoi;
      toEnt.K_Pulse = fromObj.K_Pulse;
      toEnt.KLDT_Tu1 = fromObj.KLDT_Tu1;
      toEnt.KLDT_Tu2 = fromObj.KLDT_Tu2;
      toEnt.KLDT_Tu3 = fromObj.KLDT_Tu3;
      toEnt.KLDT_Den1 = fromObj.KLDT_Den1;
      toEnt.KLDT_Den2 = fromObj.KLDT_Den2;
      toEnt.KLDT_Den3 = fromObj.KLDT_Den3;
      toEnt.KLDT_DungTruoc1 = fromObj.KLDT_DungTruoc1;
      toEnt.KLDT_DungTruoc2 = fromObj.KLDT_DungTruoc2;
      toEnt.KLDT_DungTruoc3 = fromObj.KLDT_DungTruoc3;
      toEnt.TinhDoHutNuocID = fromObj.TinhDoHutNuocID;
      toEnt.TinhDoHutNuocName = fromObj.TinhDoHutNuocName;
      toEnt.DoAm_NhomSlioAgg = fromObj.DoAm_NhomSlioAgg;
      toEnt.DoHutNuoc_NhomSiloAgg = fromObj.DoHutNuoc_NhomSiloAgg;
      toEnt.SoiTrongCat_NhomSiloAgg = fromObj.SoiTrongCat_NhomSiloAgg;
      toEnt.SoiTrongCat_TruVaoSilo_NhomSiloAgg = fromObj.SoiTrongCat_TruVaoSilo_NhomSiloAgg;
      toEnt.MaterialID = fromObj.MaterialID;
      toEnt.MaterialCode = fromObj.MaterialCode;
      toEnt.MaterialName = fromObj.MaterialName;
      toEnt.Activated = fromObj.Activated;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.VersionNo = fromObj.VersionNo;
      toEnt.BuTruKLMT = fromObj.BuTruKLMT;
      toEnt.TuDongXNCD = fromObj.TuDongXNCD;
    }

    public static ObjSilo BuildNewObjSilo(Silo entSilo)
    {
      ObjSilo toObj = new ObjSilo();
      SiloHelper.CopyToObjSilo(entSilo, toObj);
      return toObj;
    }

    public static IList<ObjSilo> BuildListObjSilo(IList<Silo> lstEntSilo)
    {
      IList<ObjSilo> objSiloList = (IList<ObjSilo>) new List<ObjSilo>();
      foreach (Silo entSilo in (IEnumerable<Silo>) lstEntSilo)
        objSiloList.Add(SiloHelper.BuildNewObjSilo(entSilo));
      return objSiloList;
    }

    public static Silo BuildNewEntSilo(ObjSilo objSilo)
    {
      Silo toEnt = new Silo();
      SiloHelper.CopyToEntSilo(objSilo, toEnt);
      return toEnt;
    }

    public static IList<Silo> BuildListEntSilo(IList<ObjSilo> lstObjSilo)
    {
      IList<Silo> siloList = (IList<Silo>) new List<Silo>();
      foreach (ObjSilo objSilo in (IEnumerable<ObjSilo>) lstObjSilo)
        siloList.Add(SiloHelper.BuildNewEntSilo(objSilo));
      return siloList;
    }
  }
}

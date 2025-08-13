// Decompiled with JetBrains decompiler
// Type: NhuaNong.Data.MeTronChiTietHelper
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.EntityModel;
using System.Collections.Generic;

#nullable disable
namespace NhuaNong.Data
{
  public class MeTronChiTietHelper
  {
    public static string GenMemberValues(ObjMeTronChiTiet obj)
    {
      return string.Empty + "#1@#MeTronChiTietID#2@#" + obj.MeTronChiTietID.ToString() + "#1@#MeTronID#2@#" + obj.MeTronID.ToString() + "#1@#MACSiloID#2@#" + obj.MACSiloID.ToString() + "#1@#Value#2@#" + obj.Value.ToString() + "#1@#ValueBat#2@#" + obj.ValueBat.ToString() + "#1@#SiloValue#2@#" + obj.SiloValue.ToString() + "#1@#SaiSoDuoi#2@#" + obj.SaiSoDuoi.ToString() + "#1@#SaiSoTren#2@#" + obj.SaiSoTren.ToString() + "#1@#KLCanNhoNhat#2@#" + obj.KLCanNhoNhat.ToString() + "#1@#KLCanLonNhat#2@#" + obj.KLCanLonNhat.ToString() + "#1@#TGNhapNhaOn#2@#" + obj.TGNhapNhaOn.ToString() + "#1@#TGNhapNhaOff#2@#" + obj.TGNhapNhaOff.ToString() + "#1@#TGKiemTraVatLieuRoi#2@#" + obj.TGKiemTraVatLieuRoi.ToString() + "#1@#KLRoi#2@#" + obj.KLRoi.ToString() + "#1@#KLDT_Tu1#2@#" + obj.KLDT_Tu1.ToString() + "#1@#KLDT_Tu2#2@#" + obj.KLDT_Tu2.ToString() + "#1@#KLDT_Tu3#2@#" + obj.KLDT_Tu3.ToString() + "#1@#KLDT_Den1#2@#" + obj.KLDT_Den1.ToString() + "#1@#KLDT_Den2#2@#" + obj.KLDT_Den2.ToString() + "#1@#KLDT_Den3#2@#" + obj.KLDT_Den3.ToString() + "#1@#TinhDoHutNuocID#2@#" + obj.TinhDoHutNuocID.ToString() + "#1@#DoAm_NhomSlioAgg#2@#" + obj.DoAm_NhomSlioAgg.ToString() + "#1@#DoHutNuoc_NhomSiloAgg#2@#" + obj.DoHutNuoc_NhomSiloAgg.ToString() + "#1@#SoiTrongCat_SiloId_NhomSiloAgg#2@#" + obj.SoiTrongCat_SiloId_NhomSiloAgg.ToString() + "#1@#SoiTrongCat_Percent_NhomSiloAgg#2@#" + obj.SoiTrongCat_Percent_NhomSiloAgg.ToString() + "#1@#MaterialID#2@#" + obj.MaterialID.ToString() + "#1@#MaterialCode#2@#" + obj.MaterialCode + "#1@#MaterialName#2@#" + obj.MaterialName + "#1@#MaSilo#2@#" + obj.MaSilo + "#1@#STTSiloPLC#2@#" + obj.STTSiloPLC.ToString() + "#1@#IsManual#2@#" + obj.IsManual.ToString() + "#1@#NgayMTCT#2@#" + obj.NgayMTCT.ToString() + "#1@#PLCSaveId#2@#" + obj.PLCSaveId.ToString() + "#1@#CreationDate#2@#" + obj.CreationDate.ToString() + "#1@#CreatedBy#2@#" + obj.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + obj.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + obj.LatestUpdatedBy.ToString() + "#1@#VersionNo#2@#" + obj.VersionNo?.ToString();
    }

    public static string GenMemberValues(MeTronChiTiet ent)
    {
      return string.Empty + "#1@#MeTronChiTietID#2@#" + ent.MeTronChiTietID.ToString() + "#1@#MeTronID#2@#" + ent.MeTronID.ToString() + "#1@#MACSiloID#2@#" + ent.MACSiloID.ToString() + "#1@#Value#2@#" + ent.Value.ToString() + "#1@#ValueBat#2@#" + ent.ValueBat.ToString() + "#1@#SiloValue#2@#" + ent.SiloValue.ToString() + "#1@#SaiSoDuoi#2@#" + ent.SaiSoDuoi.ToString() + "#1@#SaiSoTren#2@#" + ent.SaiSoTren.ToString() + "#1@#KLCanNhoNhat#2@#" + ent.KLCanNhoNhat.ToString() + "#1@#KLCanLonNhat#2@#" + ent.KLCanLonNhat.ToString() + "#1@#TGNhapNhaOn#2@#" + ent.TGNhapNhaOn.ToString() + "#1@#TGNhapNhaOff#2@#" + ent.TGNhapNhaOff.ToString() + "#1@#TGKiemTraVatLieuRoi#2@#" + ent.TGKiemTraVatLieuRoi.ToString() + "#1@#KLRoi#2@#" + ent.KLRoi.ToString() + "#1@#KLDT_Tu1#2@#" + ent.KLDT_Tu1.ToString() + "#1@#KLDT_Tu2#2@#" + ent.KLDT_Tu2.ToString() + "#1@#KLDT_Tu3#2@#" + ent.KLDT_Tu3.ToString() + "#1@#KLDT_Den1#2@#" + ent.KLDT_Den1.ToString() + "#1@#KLDT_Den2#2@#" + ent.KLDT_Den2.ToString() + "#1@#KLDT_Den3#2@#" + ent.KLDT_Den3.ToString() + "#1@#TinhDoHutNuocID#2@#" + ent.TinhDoHutNuocID.ToString() + "#1@#DoAm_NhomSlioAgg#2@#" + ent.DoAm_NhomSlioAgg.ToString() + "#1@#DoHutNuoc_NhomSiloAgg#2@#" + ent.DoHutNuoc_NhomSiloAgg.ToString() + "#1@#SoiTrongCat_SiloId_NhomSiloAgg#2@#" + ent.SoiTrongCat_SiloId_NhomSiloAgg.ToString() + "#1@#SoiTrongCat_Percent_NhomSiloAgg#2@#" + ent.SoiTrongCat_Percent_NhomSiloAgg.ToString() + "#1@#MaterialID#2@#" + ent.MaterialID.ToString() + "#1@#MaterialCode#2@#" + ent.MaterialCode + "#1@#MaterialName#2@#" + ent.MaterialName + "#1@#MaSilo#2@#" + ent.MaSilo + "#1@#STTSiloPLC#2@#" + ent.STTSiloPLC.ToString() + "#1@#IsManual#2@#" + ent.IsManual.ToString() + "#1@#NgayMTCT#2@#" + ent.NgayMTCT.ToString() + "#1@#PLCSaveId#2@#" + ent.PLCSaveId.ToString() + "#1@#CreationDate#2@#" + ent.CreationDate.ToString() + "#1@#CreatedBy#2@#" + ent.CreatedBy.ToString() + "#1@#LatestUpdateDate#2@#" + ent.LatestUpdateDate.ToString() + "#1@#LatestUpdatedBy#2@#" + ent.LatestUpdatedBy.ToString() + "#1@#VersionNo#2@#" + ent.VersionNo?.ToString();
    }

    public static void CopyToObjMeTronChiTiet(MeTronChiTiet fromEnt, ObjMeTronChiTiet toObj)
    {
      toObj.MeTronChiTietID = fromEnt.MeTronChiTietID;
      toObj.MeTronID = fromEnt.MeTronID;
      toObj.MACSiloID = fromEnt.MACSiloID;
      toObj.Value = fromEnt.Value;
      toObj.ValueBat = fromEnt.ValueBat;
      toObj.ValueBatAuto = fromEnt.ValueBatAuto;
      toObj.ValueBatMan = fromEnt.ValueBatMan;
      toObj.ValueTol = fromEnt.ValueTol;
      toObj.ValuePerTol = fromEnt.ValuePerTol;
      toObj.SiloValue = fromEnt.SiloValue;
      toObj.SaiSoDuoi = fromEnt.SaiSoDuoi;
      toObj.SaiSoTren = fromEnt.SaiSoTren;
      toObj.KLCanNhoNhat = fromEnt.KLCanNhoNhat;
      toObj.KLCanLonNhat = fromEnt.KLCanLonNhat;
      toObj.TGNhapNhaOn = fromEnt.TGNhapNhaOn;
      toObj.TGNhapNhaOff = fromEnt.TGNhapNhaOff;
      toObj.TGKiemTraVatLieuRoi = fromEnt.TGKiemTraVatLieuRoi;
      toObj.KLRoi = fromEnt.KLRoi;
      toObj.KLDT_Tu1 = fromEnt.KLDT_Tu1;
      toObj.KLDT_Tu2 = fromEnt.KLDT_Tu2;
      toObj.KLDT_Tu3 = fromEnt.KLDT_Tu3;
      toObj.KLDT_Den1 = fromEnt.KLDT_Den1;
      toObj.KLDT_Den2 = fromEnt.KLDT_Den2;
      toObj.KLDT_Den3 = fromEnt.KLDT_Den3;
      toObj.TinhDoHutNuocID = fromEnt.TinhDoHutNuocID;
      toObj.DoAm_NhomSlioAgg = fromEnt.DoAm_NhomSlioAgg;
      toObj.DoHutNuoc_NhomSiloAgg = fromEnt.DoHutNuoc_NhomSiloAgg;
      toObj.SoiTrongCat_SiloId_NhomSiloAgg = fromEnt.SoiTrongCat_SiloId_NhomSiloAgg;
      toObj.SoiTrongCat_Percent_NhomSiloAgg = fromEnt.SoiTrongCat_Percent_NhomSiloAgg;
      toObj.MaterialID = fromEnt.MaterialID;
      toObj.MaterialCode = fromEnt.MaterialCode;
      toObj.MaterialName = fromEnt.MaterialName;
      toObj.MaSilo = fromEnt.MaSilo;
      toObj.STTSiloPLC = fromEnt.STTSiloPLC;
      toObj.IsManual = fromEnt.IsManual;
      toObj.NgayMTCT = fromEnt.NgayMTCT;
      toObj.PLCSaveId = fromEnt.PLCSaveId;
      toObj.CreationDate = fromEnt.CreationDate;
      toObj.CreatedBy = fromEnt.CreatedBy;
      toObj.LatestUpdateDate = fromEnt.LatestUpdateDate;
      toObj.LatestUpdatedBy = fromEnt.LatestUpdatedBy;
      toObj.VersionNo = fromEnt.VersionNo;
      if (toObj.MeTronChiTietID <= 0)
        return;
      toObj.IsNewObject = false;
    }

    public static void CopyToEntMeTronChiTiet(ObjMeTronChiTiet fromObj, MeTronChiTiet toEnt)
    {
      toEnt.MeTronChiTietID = fromObj.MeTronChiTietID;
      toEnt.MeTronID = fromObj.MeTronID;
      toEnt.MACSiloID = fromObj.MACSiloID;
      toEnt.Value = fromObj.Value;
      toEnt.ValueBat = fromObj.ValueBat;
      toEnt.ValueBatAuto = fromObj.ValueBatAuto;
      toEnt.ValueBatMan = fromObj.ValueBatMan;
      toEnt.ValueTol = fromObj.ValueTol;
      toEnt.ValuePerTol = fromObj.ValuePerTol;
      toEnt.SiloValue = fromObj.SiloValue;
      toEnt.SaiSoDuoi = fromObj.SaiSoDuoi;
      toEnt.SaiSoTren = fromObj.SaiSoTren;
      toEnt.KLCanNhoNhat = fromObj.KLCanNhoNhat;
      toEnt.KLCanLonNhat = fromObj.KLCanLonNhat;
      toEnt.TGNhapNhaOn = fromObj.TGNhapNhaOn;
      toEnt.TGNhapNhaOff = fromObj.TGNhapNhaOff;
      toEnt.TGKiemTraVatLieuRoi = fromObj.TGKiemTraVatLieuRoi;
      toEnt.KLRoi = fromObj.KLRoi;
      toEnt.KLDT_Tu1 = fromObj.KLDT_Tu1;
      toEnt.KLDT_Tu2 = fromObj.KLDT_Tu2;
      toEnt.KLDT_Tu3 = fromObj.KLDT_Tu3;
      toEnt.KLDT_Den1 = fromObj.KLDT_Den1;
      toEnt.KLDT_Den2 = fromObj.KLDT_Den2;
      toEnt.KLDT_Den3 = fromObj.KLDT_Den3;
      toEnt.TinhDoHutNuocID = fromObj.TinhDoHutNuocID;
      toEnt.DoAm_NhomSlioAgg = fromObj.DoAm_NhomSlioAgg;
      toEnt.DoHutNuoc_NhomSiloAgg = fromObj.DoHutNuoc_NhomSiloAgg;
      toEnt.SoiTrongCat_SiloId_NhomSiloAgg = fromObj.SoiTrongCat_SiloId_NhomSiloAgg;
      toEnt.SoiTrongCat_Percent_NhomSiloAgg = fromObj.SoiTrongCat_Percent_NhomSiloAgg;
      toEnt.MaterialID = fromObj.MaterialID;
      toEnt.MaterialCode = fromObj.MaterialCode;
      toEnt.MaterialName = fromObj.MaterialName;
      toEnt.MaSilo = fromObj.MaSilo;
      toEnt.STTSiloPLC = fromObj.STTSiloPLC;
      toEnt.IsManual = fromObj.IsManual;
      toEnt.NgayMTCT = fromObj.NgayMTCT;
      toEnt.PLCSaveId = fromObj.PLCSaveId;
      toEnt.CreationDate = fromObj.CreationDate;
      toEnt.CreatedBy = fromObj.CreatedBy;
      toEnt.LatestUpdateDate = fromObj.LatestUpdateDate;
      toEnt.LatestUpdatedBy = fromObj.LatestUpdatedBy;
      toEnt.VersionNo = fromObj.VersionNo;
    }

    public static ObjMeTronChiTiet BuildNewObjMeTronChiTiet(MeTronChiTiet entMeTronChiTiet)
    {
      ObjMeTronChiTiet toObj = new ObjMeTronChiTiet();
      MeTronChiTietHelper.CopyToObjMeTronChiTiet(entMeTronChiTiet, toObj);
      return toObj;
    }

    public static IList<ObjMeTronChiTiet> BuildListObjMeTronChiTiet(
      IList<MeTronChiTiet> lstEntMeTronChiTiet)
    {
      IList<ObjMeTronChiTiet> objMeTronChiTietList = (IList<ObjMeTronChiTiet>) new List<ObjMeTronChiTiet>();
      foreach (MeTronChiTiet entMeTronChiTiet in (IEnumerable<MeTronChiTiet>) lstEntMeTronChiTiet)
        objMeTronChiTietList.Add(MeTronChiTietHelper.BuildNewObjMeTronChiTiet(entMeTronChiTiet));
      return objMeTronChiTietList;
    }

    public static MeTronChiTiet BuildNewEntMeTronChiTiet(ObjMeTronChiTiet objMeTronChiTiet)
    {
      MeTronChiTiet toEnt = new MeTronChiTiet();
      MeTronChiTietHelper.CopyToEntMeTronChiTiet(objMeTronChiTiet, toEnt);
      return toEnt;
    }

    public static IList<MeTronChiTiet> BuildListEntMeTronChiTiet(
      IList<ObjMeTronChiTiet> lstObjMeTronChiTiet)
    {
      IList<MeTronChiTiet> meTronChiTietList = (IList<MeTronChiTiet>) new List<MeTronChiTiet>();
      foreach (ObjMeTronChiTiet objMeTronChiTiet in (IEnumerable<ObjMeTronChiTiet>) lstObjMeTronChiTiet)
        meTronChiTietList.Add(MeTronChiTietHelper.BuildNewEntMeTronChiTiet(objMeTronChiTiet));
      return meTronChiTietList;
    }
  }
}

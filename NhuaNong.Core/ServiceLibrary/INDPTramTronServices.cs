// Decompiled with JetBrains decompiler
// Type: NhuaNong.ServiceLibrary.INDPTramTronServices
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Data;
using System;
using System.Collections.Generic;
using System.ServiceModel;

#nullable disable
namespace NhuaNong.ServiceLibrary
{
  [ServiceContract]
  public interface INDPTramTronServices
  {
    [OperationContract]
    ObjCongTruong GetCongTruongByKey(int ctID);

    [OperationContract]
    IList<ObjCongTruong> ListCongTruong();

    [OperationContract]
    IList<ObjCongTruong> ListCongTruong_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string diaChi,
      string phone,
      bool? active);

    [OperationContract]
    bool SaveCongTruong(IList<ObjCongTruong> lstCT);

    [OperationContract]
    ObjKhachHang GetKhachHangByKey(int ctID);

    [OperationContract]
    IList<ObjKhachHang> ListKhachHang();

    [OperationContract]
    IList<ObjKhachHang> ListKhachHang_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maKH,
      string tenKH,
      string diaChi,
      string phone,
      bool? active);

    [OperationContract]
    bool SaveKhachHang(IList<ObjKhachHang> lstCT);

    [OperationContract]
    string GetNextCode(string strTblName);

    [OperationContract]
    NhuaNong.Core.BusinessObject.DashboardStats GetDashboardStats();
  }
}

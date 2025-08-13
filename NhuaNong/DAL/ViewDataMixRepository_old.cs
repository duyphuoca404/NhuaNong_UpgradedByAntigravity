// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.ViewDataMixRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.Data;
using NhuaNong.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

#nullable disable
namespace NhuaNong.DAL
{
  public class ViewDataMixRepository : 
    EFRepository<vw_DataMix>,
    IViewDataMixRepository,
    IEFRepository<vw_DataMix>
  {
    public ViewDataMixRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = "MeTronID";
    }

    public IList<vw_DataMix> ListDataMix(DateTime? fromDate, DateTime? toDate, string maPhieuTron)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ViewDataMixRepository.\u003C\u003Ec__DisplayClass1_0 cDisplayClass10 = new ViewDataMixRepository.\u003C\u003Ec__DisplayClass1_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.maPhieuTron = maPhieuTron;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.fromDate = fromDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.toDate = toDate;
      ParameterExpression parameterExpression;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      return this.SelectAll((ISpecification<vw_DataMix>) new Specification<vw_DataMix>(Expression.Lambda<Func<vw_DataMix, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.OrElse(o.MaPhieuTron.Contains(cDisplayClass10.maPhieuTron), (Expression) Expression.Equal((Expression) Expression.Call(cDisplayClass10.maPhieuTron, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty))))), (Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_NgayMeTron))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass1_0.fromDate))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual)))), (Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_NgayMeTron))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass1_0.toDate))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual)))), parameterExpression)));
    }

    public IList<vw_DataMix> ListDataMix_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maPhieuTron,
      string khachHang,
      string congTruong,
      string hangMuc,
      string taiXe,
      string bienSo,
      string mac,
      string nhanVien)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20 = new ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.fromDate = fromDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.toDate = toDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.maPhieuTron = maPhieuTron;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.khachHang = khachHang;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.congTruong = congTruong;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.hangMuc = hangMuc;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.taiXe = taiXe;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.bienSo = bienSo;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.mac = mac;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass20.nhanVien = nhanVien;
      ParameterExpression parameterExpression;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      return this.SelectAll((ISpecification<vw_DataMix>) new Specification<vw_DataMix>(Expression.Lambda<Func<vw_DataMix, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.OrElse(o.NgayMeTron >= cDisplayClass20.fromDate && o.NgayMeTron <= cDisplayClass20.toDate && o.MaPhieuTron.Contains(cDisplayClass20.maPhieuTron), (Expression) Expression.Equal((Expression) Expression.Call(cDisplayClass20.maPhieuTron, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty))))), (Expression) Expression.OrElse((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_KH))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.khachHang)))), (Expression) Expression.Equal((Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.khachHang))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_CT))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.congTruong)))), (Expression) Expression.Equal((Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.congTruong))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_Plate))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.hangMuc)))), (Expression) Expression.Equal((Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.hangMuc))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_Name))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.taiXe)))), (Expression) Expression.Equal((Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.taiXe))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_TX))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.bienSo)))), (Expression) Expression.Equal((Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.bienSo))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_MAC))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.mac)))), (Expression) Expression.Equal((Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.mac))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_NoteMAC))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.nhanVien)))), (Expression) Expression.Equal((Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass20, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass2_0.nhanVien))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), parameterExpression)));
    }

    public IList<vw_DataMix> ListDataMix_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maPhieuTron,
      int? khachHang,
      int? congTruong,
      int? hangMuc,
      int? mac,
      int? bienSo,
      int? taiXe,
      int? nhanVien,
      bool? moPhong)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0 cDisplayClass30 = new ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.fromDate = fromDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.toDate = toDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.maPhieuTron = maPhieuTron;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.khachHang = khachHang;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.congTruong = congTruong;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.hangMuc = hangMuc;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.mac = mac;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.bienSo = bienSo;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.taiXe = taiXe;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.nhanVien = nhanVien;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass30.moPhong = moPhong;
      ParameterExpression parameterExpression;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      return (IList<vw_DataMix>) this.SelectAll((ISpecification<vw_DataMix>) new Specification<vw_DataMix>(Expression.Lambda<Func<vw_DataMix, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso(o.NgayMeTron >= cDisplayClass30.fromDate && o.NgayMeTron <= cDisplayClass30.toDate, (Expression) Expression.OrElse(o.MaPhieuTron.Contains(cDisplayClass30.maPhieuTron), (Expression) Expression.Equal((Expression) Expression.Call(cDisplayClass30.maPhieuTron, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_KH_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.khachHang)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.khachHang))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_CT_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.congTruong)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.congTruong))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_HM_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.hangMuc)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.hangMuc))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_MAC_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.mac)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.mac))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_Xe_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.bienSo)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.bienSo))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_TaiXeID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.taiXe)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.taiXe))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_CreatedBy))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.nhanVien)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.nhanVien))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_DataMix.get_IsQueued))), typeof (bool?)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.moPhong)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass30, typeof (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewDataMixRepository.\u003C\u003Ec__DisplayClass3_0.moPhong))), (Expression) Expression.New(typeof (bool?))))), parameterExpression))).OrderByDescending<vw_DataMix, int>((Func<vw_DataMix, int>) (dm => dm.MeTronID)).ToList<vw_DataMix>();
    }

    public ObjAggregationResult GetSumForIsQueuedAndTimeRange(
      DateTime? fromDate,
      DateTime? toDate,
      bool? activated)
    {
      IQueryable<vw_DataMix> source = this.DoQuery((ISpecification<vw_DataMix>) new Specification<vw_DataMix>((Expression<Func<vw_DataMix, bool>>) (data => (data.IsQueued == activated || activated == new bool?()) && (data.NgayMeTron >= fromDate || fromDate == (DateTime?) DateTime.MinValue) && (data.NgayMeTron <= toDate || toDate == (DateTime?) DateTime.MinValue))));
      ObjAggregationResult queuedAndTimeRange = new ObjAggregationResult();
      queuedAndTimeRange.Total_Agg1 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg1));
      queuedAndTimeRange.Total_Agg2 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg2));
      queuedAndTimeRange.Total_Agg3 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg3));
      queuedAndTimeRange.Total_Agg4 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg4));
      queuedAndTimeRange.Total_Agg5 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg5));
      queuedAndTimeRange.Total_Ce1 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce1));
      queuedAndTimeRange.Total_Ce2 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce2));
      queuedAndTimeRange.Total_Ce3 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce3));
      queuedAndTimeRange.Total_Ce4 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce4));
      queuedAndTimeRange.Total_Ce5 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce5));
      queuedAndTimeRange.Total_Wa1 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Wa1));
      queuedAndTimeRange.Total_Wa2 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Wa2));
      queuedAndTimeRange.Total_Add1 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add1));
      queuedAndTimeRange.Total_Add2 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add2));
      queuedAndTimeRange.Total_Add3 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add3));
      queuedAndTimeRange.Total_Add4 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add4));
      queuedAndTimeRange.Total_Add5 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add5));
      queuedAndTimeRange.Total_Add6 = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add6));
      queuedAndTimeRange.Total_Agg1_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg1_Bat));
      queuedAndTimeRange.Total_Agg2_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg2_Bat));
      queuedAndTimeRange.Total_Agg3_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg3_Bat));
      queuedAndTimeRange.Total_Agg4_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg4_Bat));
      queuedAndTimeRange.Total_Agg5_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg5_Bat));
      queuedAndTimeRange.Total_Ce1_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce1_Bat));
      queuedAndTimeRange.Total_Ce2_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce2_Bat));
      queuedAndTimeRange.Total_Ce3_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce3_Bat));
      queuedAndTimeRange.Total_Ce4_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce4_Bat));
      queuedAndTimeRange.Total_Ce5_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce5_Bat));
      queuedAndTimeRange.Total_Wa1_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Wa1_Bat));
      queuedAndTimeRange.Total_Wa2_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Wa2_Bat));
      queuedAndTimeRange.Total_Add1_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add1_Bat));
      queuedAndTimeRange.Total_Add2_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add2_Bat));
      queuedAndTimeRange.Total_Add3_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add3_Bat));
      queuedAndTimeRange.Total_Add4_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add4_Bat));
      queuedAndTimeRange.Total_Add5_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add5_Bat));
      queuedAndTimeRange.Total_Add6_Bat = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add6_Bat));
      queuedAndTimeRange.Total_Agg1_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg1_Man));
      queuedAndTimeRange.Total_Agg2_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg2_Man));
      queuedAndTimeRange.Total_Agg3_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg3_Man));
      queuedAndTimeRange.Total_Agg4_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg4_Man));
      queuedAndTimeRange.Total_Agg5_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Agg5_Man));
      queuedAndTimeRange.Total_Ce1_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce1_Man));
      queuedAndTimeRange.Total_Ce2_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce2_Man));
      queuedAndTimeRange.Total_Ce3_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce3_Man));
      queuedAndTimeRange.Total_Ce4_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce4_Man));
      queuedAndTimeRange.Total_Ce5_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Ce5_Man));
      queuedAndTimeRange.Total_Wa1_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Wa1_Man));
      queuedAndTimeRange.Total_Wa2_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Wa2_Man));
      queuedAndTimeRange.Total_Add1_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add1_Man));
      queuedAndTimeRange.Total_Add2_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add2_Man));
      queuedAndTimeRange.Total_Add3_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add3_Man));
      queuedAndTimeRange.Total_Add4_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add4_Man));
      queuedAndTimeRange.Total_Add5_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add5_Man));
      queuedAndTimeRange.Total_Add6_Man = source.Sum<vw_DataMix>((Expression<Func<vw_DataMix, Decimal?>>) (data => data.Add6_Man));
      return queuedAndTimeRange;
    }
  }
}

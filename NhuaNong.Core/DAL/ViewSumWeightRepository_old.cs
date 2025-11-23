// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.ViewSumWeightRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

#nullable disable
namespace NhuaNong.DAL
{
  internal class ViewSumWeightRepository : 
    EFRepository<vw_SumWeight>,
    IViewSumWeightRepository,
    IEFRepository<vw_SumWeight>
  {
    public ViewSumWeightRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = "PhieuTronID";
    }

    public IList<vw_SumWeight> ListSumWeight_ByCondition(
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
      bool? active)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0 cDisplayClass10 = new ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.fromDate = fromDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.toDate = toDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.maPhieuTron = maPhieuTron;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.khachHang = khachHang;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.congTruong = congTruong;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.hangMuc = hangMuc;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.mac = mac;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.bienSo = bienSo;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.taiXe = taiXe;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.nhanVien = nhanVien;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.active = active;
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
      return this.SelectAll((ISpecification<vw_SumWeight>) new Specification<vw_SumWeight>(Expression.Lambda<Func<vw_SumWeight, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso(o.NgayPhieuTron >= cDisplayClass10.fromDate && o.NgayPhieuTron <= cDisplayClass10.toDate, (Expression) Expression.OrElse(o.MaPhieuTron.Contains(cDisplayClass10.maPhieuTron), (Expression) Expression.Equal((Expression) Expression.Call(cDisplayClass10.maPhieuTron, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_SumWeight.get_KH_int))), typeof (int?)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.khachHang)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.khachHang))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_SumWeight.get_CT_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.congTruong)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.congTruong))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_SumWeight.get_HM_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.hangMuc)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.hangMuc))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_SumWeight.get_MAC_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.mac)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.mac))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_SumWeight.get_Xe_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.bienSo)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.bienSo))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_SumWeight.get_TX_int))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.taiXe)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.taiXe))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_SumWeight.get_CreatedBy))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.nhanVien)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.nhanVien))), (Expression) Expression.Constant((object) new int?(), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_SumWeight.get_IsQueued))), typeof (bool?)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.active)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (ViewSumWeightRepository.\u003C\u003Ec__DisplayClass1_0.active))), (Expression) Expression.New(typeof (bool?))))), parameterExpression)));
    }
  }
}

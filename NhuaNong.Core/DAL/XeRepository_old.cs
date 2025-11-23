// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.XeRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Reflection;

#nullable disable
namespace NhuaNong.DAL
{
  public class XeRepository : EFRepository<Xe>, IXeRepository, IEFRepository<Xe>
  {
    public XeRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new Xe(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<Xe> ListXe_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string bienSo,
      bool? active)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      XeRepository.\u003C\u003Ec__DisplayClass1_0 cDisplayClass10 = new XeRepository.\u003C\u003Ec__DisplayClass1_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.bienSo = bienSo;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.fromDate = fromDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.toDate = toDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.active = active;
      ParameterExpression parameterExpression;
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      return this.SelectAll((ISpecification<Xe>) new Specification<Xe>(Expression.Lambda<Func<Xe, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.OrElse(o.BienSo.Contains(cDisplayClass10.bienSo), (Expression) Expression.Equal((Expression) Expression.Call(cDisplayClass10.bienSo, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty))))), (Expression) Expression.OrElse((Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Xe.get_CreationDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (XeRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (XeRepository.\u003C\u003Ec__DisplayClass1_0.fromDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (XeRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (XeRepository.\u003C\u003Ec__DisplayClass1_0.fromDate))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (DateTime.MinValue))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))))), (Expression) Expression.OrElse((Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Xe.get_CreationDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (XeRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (XeRepository.\u003C\u003Ec__DisplayClass1_0.toDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (XeRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (XeRepository.\u003C\u003Ec__DisplayClass1_0.toDate))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (DateTime.MinValue))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Xe.get_Activated))), typeof (bool?)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (XeRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (XeRepository.\u003C\u003Ec__DisplayClass1_0.active)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (XeRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (XeRepository.\u003C\u003Ec__DisplayClass1_0.active))), (Expression) Expression.Constant((object) new bool?(), typeof (bool?))))), parameterExpression)));
    }
  }
}

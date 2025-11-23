// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.MACRepository
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
  public class MACRepository : EFRepository<MAC>, IMACRepository, IEFRepository<MAC>
  {
    public MACRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new MAC(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<MAC> ListMAC_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maMAC,
      string tenMAC,
      bool? active)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      MACRepository.\u003C\u003Ec__DisplayClass1_0 cDisplayClass10 = new MACRepository.\u003C\u003Ec__DisplayClass1_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.maMAC = maMAC;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.tenMAC = tenMAC;
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
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
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
      return this.SelectAll((ISpecification<MAC>) new Specification<MAC>(Expression.Lambda<Func<MAC, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.OrElse(o.MaMAC.Contains(cDisplayClass10.maMAC), (Expression) Expression.Equal((Expression) Expression.Call(cDisplayClass10.maMAC, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty))))), (Expression) Expression.OrElse((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (MAC.get_TenMAC))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MACRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MACRepository.\u003C\u003Ec__DisplayClass1_0.tenMAC)))), (Expression) Expression.Equal((Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MACRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MACRepository.\u003C\u003Ec__DisplayClass1_0.tenMAC))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (MAC.get_CreationDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MACRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MACRepository.\u003C\u003Ec__DisplayClass1_0.fromDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MACRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MACRepository.\u003C\u003Ec__DisplayClass1_0.fromDate))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (DateTime.MinValue))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))))), (Expression) Expression.OrElse((Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (MAC.get_CreationDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MACRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MACRepository.\u003C\u003Ec__DisplayClass1_0.toDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MACRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MACRepository.\u003C\u003Ec__DisplayClass1_0.toDate))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (DateTime.MinValue))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (MAC.get_Activated))), typeof (bool?)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MACRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MACRepository.\u003C\u003Ec__DisplayClass1_0.active)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MACRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MACRepository.\u003C\u003Ec__DisplayClass1_0.active))), (Expression) Expression.Constant((object) new bool?(), typeof (bool?))))), parameterExpression)));
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.MaterialRepository
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
  public class MaterialRepository : 
    EFRepository<Material>,
    IMaterialRepository,
    IEFRepository<Material>
  {
    public MaterialRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new Material(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public IList<Material> ListMaterial_ByCondition(
      DateTime? fromDate,
      DateTime? toDate,
      string maVT,
      string tenVT,
      bool? active)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      MaterialRepository.\u003C\u003Ec__DisplayClass1_0 cDisplayClass10 = new MaterialRepository.\u003C\u003Ec__DisplayClass1_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.maVT = maVT;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass10.tenVT = tenVT;
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
      return this.SelectAll((ISpecification<Material>) new Specification<Material>(Expression.Lambda<Func<Material, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.OrElse(o.MaterialCode.Contains(cDisplayClass10.maVT), (Expression) Expression.Equal((Expression) Expression.Call(cDisplayClass10.maVT, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty))))), (Expression) Expression.OrElse((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Material.get_MaterialName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MaterialRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MaterialRepository.\u003C\u003Ec__DisplayClass1_0.tenVT)))), (Expression) Expression.Equal((Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MaterialRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MaterialRepository.\u003C\u003Ec__DisplayClass1_0.tenVT))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty)))))), (Expression) Expression.OrElse((Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Material.get_CreationDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MaterialRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MaterialRepository.\u003C\u003Ec__DisplayClass1_0.fromDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MaterialRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MaterialRepository.\u003C\u003Ec__DisplayClass1_0.fromDate))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (DateTime.MinValue))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))))), (Expression) Expression.OrElse((Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Material.get_CreationDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MaterialRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MaterialRepository.\u003C\u003Ec__DisplayClass1_0.toDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MaterialRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MaterialRepository.\u003C\u003Ec__DisplayClass1_0.toDate))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (DateTime.MinValue))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Material.get_Activated))), typeof (bool?)), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MaterialRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MaterialRepository.\u003C\u003Ec__DisplayClass1_0.active)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass10, typeof (MaterialRepository.\u003C\u003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle(__fieldref (MaterialRepository.\u003C\u003Ec__DisplayClass1_0.active))), (Expression) Expression.Constant((object) new bool?(), typeof (bool?))))), parameterExpression)));
    }
  }
}

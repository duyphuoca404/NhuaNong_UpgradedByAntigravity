// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.PhieuTronRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

#nullable disable
namespace NhuaNong.DAL
{
  public class PhieuTronRepository : 
    EFRepository<PhieuTron>,
    IPhieuTronRepository,
    IEFRepository<PhieuTron>
  {
    public PhieuTronRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new PhieuTron(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public PhieuTron GetByCode(string code)
    {
      return this.DoQuery((ISpecification<PhieuTron>) new Specification<PhieuTron>((Expression<Func<PhieuTron, bool>>) (pt => pt.MaPhieuTron == code))).FirstOrDefault<PhieuTron>();
    }

    public PhieuTron GetLastest()
    {
      return this.DoQuery().OrderByDescending<PhieuTron, int>((Expression<Func<PhieuTron, int>>) (mt => mt.PhieuTronID)).FirstOrDefault<PhieuTron>();
    }

    public IList<PhieuTron> ListPhieuTron_ForTronOnline()
    {
      return (IList<PhieuTron>) this.DoQuery((ISpecification<PhieuTron>) new Specification<PhieuTron>((Expression<Func<PhieuTron, bool>>) (pt => pt.IsQueued == (bool?) true && (pt.Status == (int?) 0 || pt.Status == (int?) 2 || pt.Status == (int?) 3 || pt.Status == (int?) 6 || pt.Status == (int?) 5 || pt.Status == (int?) 7)))).OrderBy<PhieuTron, int>((Expression<Func<PhieuTron, int>>) (m => m.PhieuTronID)).ToList<PhieuTron>();
    }

    public IList<PhieuTron> ListPhieuTron_ByStatus(int status)
    {
      return this.SelectAll((ISpecification<PhieuTron>) new Specification<PhieuTron>((Expression<Func<PhieuTron, bool>>) (pt => pt.Status == (int?) status)));
    }

    public IList<PhieuTron> ListPhieuTron_ByIsQueued(bool isQueued)
    {
      return this.SelectAll((ISpecification<PhieuTron>) new Specification<PhieuTron>((Expression<Func<PhieuTron, bool>>) (pt => pt.IsQueued == (bool?) isQueued)));
    }

    public IList<PhieuTron> ListPhieuTron_ByCondition(
      string maPhieuTron,
      DateTime fromDate,
      DateTime toDate,
      int? status,
      bool? isQueued)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0 cDisplayClass60 = new PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass60.maPhieuTron = maPhieuTron;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass60.fromDate = fromDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass60.toDate = toDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass60.status = status;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass60.isQueued = isQueued;
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
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      // ISSUE: method reference
      // ISSUE: field reference
      // ISSUE: field reference
      return (IList<PhieuTron>) this.SelectAll((ISpecification<PhieuTron>) new Specification<PhieuTron>(Expression.Lambda<Func<PhieuTron, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.OrElse(pt.MaPhieuTron.Contains(cDisplayClass60.maPhieuTron), (Expression) Expression.Equal((Expression) Expression.Call(cDisplayClass60.maPhieuTron, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty))))), (Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PhieuTron.get_NgayPhieuTron))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass60, typeof (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0.fromDate))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual)))), (Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PhieuTron.get_NgayPhieuTron))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass60, typeof (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0.toDate))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual)))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PhieuTron.get_Status))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass60, typeof (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0.status)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass60, typeof (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0.status))), (Expression) Expression.Convert((Expression) Expression.Constant((object) -1, typeof (int)), typeof (int?))))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PhieuTron.get_IsQueued))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass60, typeof (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0.isQueued)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass60, typeof (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuTronRepository.\u003C\u003Ec__DisplayClass6_0.isQueued))), (Expression) Expression.Constant((object) new bool?(), typeof (bool?))))), parameterExpression))).OrderByDescending<PhieuTron, int>((Func<PhieuTron, int>) (pt => pt.PhieuTronID)).ToList<PhieuTron>();
    }

    public IList<string> ListMaPhieuTron_AutoComplete(string strInput, int? length)
    {
      if (strInput.Trim() == string.Empty)
        return (IList<string>) new List<string>();
      Specification<PhieuTron> where = new Specification<PhieuTron>((Expression<Func<PhieuTron, bool>>) (pt => pt.MaPhieuTron.Contains(strInput)));
      List<string> stringList = new List<string>();
      List<string> list;
      if (length.HasValue)
        list = this.DoQuery((ISpecification<PhieuTron>) where).Take<PhieuTron>(length.Value).Select<PhieuTron, string>((Expression<Func<PhieuTron, string>>) (p => p.MaPhieuTron)).ToList<string>();
      else
        list = this.DoQuery((ISpecification<PhieuTron>) where).Select<PhieuTron, string>((Expression<Func<PhieuTron, string>>) (p => p.MaPhieuTron)).ToList<string>();
      return (IList<string>) list;
    }

    public IList<PhieuTron> ListPhieuTron_AutoComplete(string strInput, int? length)
    {
      if (strInput.Trim() == string.Empty)
        return (IList<PhieuTron>) new List<PhieuTron>();
      Specification<PhieuTron> where = new Specification<PhieuTron>((Expression<Func<PhieuTron, bool>>) (pt => pt.MaPhieuTron.Contains(strInput)));
      List<PhieuTron> phieuTronList = new List<PhieuTron>();
      return !length.HasValue ? (IList<PhieuTron>) this.DoQuery((ISpecification<PhieuTron>) where).ToList<PhieuTron>() : (IList<PhieuTron>) this.DoQuery((ISpecification<PhieuTron>) where).Take<PhieuTron>(length.Value).ToList<PhieuTron>();
    }
  }
}

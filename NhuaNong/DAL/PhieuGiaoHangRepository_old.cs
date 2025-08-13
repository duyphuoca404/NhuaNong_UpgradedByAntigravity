// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.PhieuGiaoHangRepository
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
  public class PhieuGiaoHangRepository : 
    EFRepository<PhieuGiaoHang>,
    IPhieuGiaoHangRepository,
    IEFRepository<PhieuGiaoHang>
  {
    public PhieuGiaoHangRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new PhieuGiaoHang(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public PhieuGiaoHang GetByCode(string code)
    {
      return this.DoQuery((ISpecification<PhieuGiaoHang>) new Specification<PhieuGiaoHang>((Expression<Func<PhieuGiaoHang, bool>>) (pt => pt.MaPhieuTron == code))).FirstOrDefault<PhieuGiaoHang>();
    }

    public PhieuGiaoHang GetLastest()
    {
      return this.DoQuery().OrderByDescending<PhieuGiaoHang, int>((Expression<Func<PhieuGiaoHang, int>>) (mt => mt.PhieuTronID)).FirstOrDefault<PhieuGiaoHang>();
    }

    public IList<string> ListMaPhieuTron_AutoComplete(string strInput, int? length)
    {
      if (strInput.Trim() == string.Empty)
        return (IList<string>) new List<string>();
      Specification<PhieuGiaoHang> where = new Specification<PhieuGiaoHang>((Expression<Func<PhieuGiaoHang, bool>>) (pt => pt.MaPhieuTron.Contains(strInput)));
      List<string> stringList = new List<string>();
      List<string> list;
      if (length.HasValue)
        list = this.DoQuery((ISpecification<PhieuGiaoHang>) where).Take<PhieuGiaoHang>(length.Value).Select<PhieuGiaoHang, string>((Expression<Func<PhieuGiaoHang, string>>) (p => p.MaPhieuTron)).ToList<string>();
      else
        list = this.DoQuery((ISpecification<PhieuGiaoHang>) where).Select<PhieuGiaoHang, string>((Expression<Func<PhieuGiaoHang, string>>) (p => p.MaPhieuTron)).ToList<string>();
      return (IList<string>) list;
    }

    public IList<PhieuGiaoHang> ListPhieuTron_AutoComplete(string strInput, int? length)
    {
      if (strInput.Trim() == string.Empty)
        return (IList<PhieuGiaoHang>) new List<PhieuGiaoHang>();
      Specification<PhieuGiaoHang> where = new Specification<PhieuGiaoHang>((Expression<Func<PhieuGiaoHang, bool>>) (pt => pt.MaPhieuTron.Contains(strInput)));
      List<PhieuGiaoHang> phieuGiaoHangList = new List<PhieuGiaoHang>();
      return !length.HasValue ? (IList<PhieuGiaoHang>) this.DoQuery((ISpecification<PhieuGiaoHang>) where).ToList<PhieuGiaoHang>() : (IList<PhieuGiaoHang>) this.DoQuery((ISpecification<PhieuGiaoHang>) where).Take<PhieuGiaoHang>(length.Value).ToList<PhieuGiaoHang>();
    }

    public IList<PhieuGiaoHang> ListPhieuTron_ByCondition(
      string maPhieuTron,
      DateTime fromDate,
      DateTime toDate,
      int? status,
      bool? isQueued)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0 cDisplayClass50 = new PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass50.maPhieuTron = maPhieuTron;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass50.fromDate = fromDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass50.toDate = toDate;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass50.isQueued = isQueued;
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
      return (IList<PhieuGiaoHang>) this.SelectAll((ISpecification<PhieuGiaoHang>) new Specification<PhieuGiaoHang>(Expression.Lambda<Func<PhieuGiaoHang, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.OrElse(pt.MaPhieuTron.Contains(cDisplayClass50.maPhieuTron), (Expression) Expression.Equal((Expression) Expression.Call(cDisplayClass50.maPhieuTron, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Trim)), Array.Empty<Expression>()), (Expression) Expression.Field((Expression) null, FieldInfo.GetFieldFromHandle(__fieldref (string.Empty))))), (Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PhieuGiaoHang.get_NgayPhieuTron))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass50, typeof (PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0.fromDate))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual)))), (Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PhieuGiaoHang.get_NgayPhieuTron))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass50, typeof (PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0.toDate))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual)))), (Expression) Expression.OrElse((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (PhieuGiaoHang.get_Activated))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass50, typeof (PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0.isQueued)))), (Expression) Expression.Equal((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass50, typeof (PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0)), FieldInfo.GetFieldFromHandle(__fieldref (PhieuGiaoHangRepository.\u003C\u003Ec__DisplayClass5_0.isQueued))), (Expression) Expression.Constant((object) new bool?(), typeof (bool?))))), parameterExpression))).OrderByDescending<PhieuGiaoHang, int>((Func<PhieuGiaoHang, int>) (pt => pt.PhieuTronID)).ToList<PhieuGiaoHang>();
    }

    public IList<PhieuGiaoHang> ListPhieuTron_ByCondition(
      string maPhieuTron,
      DateTime fromDate,
      DateTime toDate,
      bool? isQueued)
    {
      throw new NotImplementedException();
    }

    public IList<PhieuGiaoHang> ListPhieuTron_ByIsQueued(bool isQueued)
    {
      return this.SelectAll((ISpecification<PhieuGiaoHang>) new Specification<PhieuGiaoHang>((Expression<Func<PhieuGiaoHang, bool>>) (pt => pt.Activated == (bool?) isQueued)));
    }
  }
}

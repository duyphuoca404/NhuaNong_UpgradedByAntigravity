// Decompiled with JetBrains decompiler
// Type: NhuaNong.DAL.MeTronRepository
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

#nullable disable
namespace NhuaNong.DAL
{
  public class MeTronRepository : EFRepository<MeTron>, IMeTronRepository, IEFRepository<MeTron>
  {
    public MeTronRepository(IDbContextManager dbCtxMng)
      : base(dbCtxMng)
    {
      this.KeyProperty = this.GetKeyColumnName(new MeTron(), (DbContext) new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
    }

    public MeTron GetMeTron(int phieuTronId, int lnNo)
    {
      return this.DoQuery((ISpecification<MeTron>) new Specification<MeTron>((Expression<Func<MeTron, bool>>) (mt => mt.PhieuTronID == phieuTronId && mt.LnNo == (int?) lnNo))).OrderByDescending<MeTron, int>((Expression<Func<MeTron, int>>) (mt => mt.MeTronID)).FirstOrDefault<MeTron>();
    }

    public MeTron GetLatestMeTronFromPhieuTron(int phieuTronId)
    {
      return this.DoQuery((ISpecification<MeTron>) new Specification<MeTron>((Expression<Func<MeTron, bool>>) (mt => mt.PhieuTronID == phieuTronId))).OrderByDescending<MeTron, int>((Expression<Func<MeTron, int>>) (mt => mt.MeTronID)).FirstOrDefault<MeTron>();
    }
  }
}

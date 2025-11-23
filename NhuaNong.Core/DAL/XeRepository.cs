using System;
using System.Collections.Generic;
using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;

namespace NhuaNong.DAL;

public class XeRepository : EFRepository<Xe>, IXeRepository, IEFRepository<Xe>
{
	public XeRepository(IDbContextManager dbCtxMng)
		: base(dbCtxMng)
	{
		base.KeyProperty = GetKeyColumnName(new Xe(), new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
	}

	public IList<Xe> ListXe_ByCondition(DateTime? fromDate, DateTime? toDate, string bienSo, bool? active)
	{
		Specification<Xe> specification = new Specification<Xe>((Xe o) => (o.BienSo.Contains(bienSo) || bienSo.Trim() == string.Empty) && (o.CreationDate >= fromDate || fromDate == DateTime.MinValue) && (o.CreationDate <= toDate || toDate == DateTime.MinValue) && ((bool?)o.Activated == active || active == (bool?)null));
		return SelectAll(specification);
	}
}

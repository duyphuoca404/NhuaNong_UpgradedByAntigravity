using System;
using System.Collections.Generic;
using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;

namespace NhuaNong.DAL;

public class MACRepository : EFRepository<MAC>, IMACRepository, IEFRepository<MAC>
{
	public MACRepository(IDbContextManager dbCtxMng)
		: base(dbCtxMng)
	{
		base.KeyProperty = GetKeyColumnName(new MAC(), new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
	}

	public IList<MAC> ListMAC_ByCondition(DateTime? fromDate, DateTime? toDate, string maMAC, string tenMAC, bool? active)
	{
		Specification<MAC> specification = new Specification<MAC>((MAC o) => (o.MaMAC.Contains(maMAC) || maMAC.Trim() == string.Empty) && (o.TenMAC.Contains(tenMAC) || tenMAC.Trim() == string.Empty) && (o.CreationDate >= fromDate || fromDate == DateTime.MinValue) && (o.CreationDate <= toDate || toDate == DateTime.MinValue) && ((bool?)o.Activated == active || active == (bool?)null));
		return SelectAll(specification);
	}
}

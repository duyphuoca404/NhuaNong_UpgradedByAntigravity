using System;
using System.Collections.Generic;
using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;

namespace NhuaNong.DAL;

public class MaterialRepository : EFRepository<Material>, IMaterialRepository, IEFRepository<Material>
{
	public MaterialRepository(IDbContextManager dbCtxMng)
		: base(dbCtxMng)
	{
		base.KeyProperty = GetKeyColumnName(new Material(), new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
	}

	public IList<Material> ListMaterial_ByCondition(DateTime? fromDate, DateTime? toDate, string maVT, string tenVT, bool? active)
	{
		Specification<Material> specification = new Specification<Material>((Material o) => (o.MaterialCode.Contains(maVT) || maVT.Trim() == string.Empty) && (o.MaterialName.Contains(tenVT) || tenVT.Trim() == string.Empty) && (o.CreationDate >= fromDate || fromDate == DateTime.MinValue) && (o.CreationDate <= toDate || toDate == DateTime.MinValue) && ((bool?)o.Activated == active || active == (bool?)null));
		return SelectAll(specification);
	}
}

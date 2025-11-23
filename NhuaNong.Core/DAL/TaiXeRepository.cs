using System;
using System.Collections.Generic;
using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;

namespace NhuaNong.DAL;

public class TaiXeRepository : EFRepository<TaiXe>, ITaiXeRepository, IEFRepository<TaiXe>
{
	public TaiXeRepository(IDbContextManager dbCtxMng)
		: base(dbCtxMng)
	{
		base.KeyProperty = GetKeyColumnName(new TaiXe(), new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
	}

	public IList<TaiXe> ListTaiXe_ByCondition(DateTime? fromDate, DateTime? toDate, string maKH, string tenKH, string phone, bool? active)
	{
		Specification<TaiXe> specification = new Specification<TaiXe>((TaiXe o) => (o.MaTaiXe.Contains(maKH) || maKH.Trim() == string.Empty) && (o.TenTaiXe.Contains(tenKH) || tenKH.Trim() == string.Empty) && (o.Phone.Contains(phone) || phone.Trim() == string.Empty) && (o.CreationDate >= fromDate || fromDate == DateTime.MinValue) && (o.CreationDate <= toDate || toDate == DateTime.MinValue) && ((bool?)o.Activated == active || active == (bool?)null));
		return SelectAll(specification);
	}
}

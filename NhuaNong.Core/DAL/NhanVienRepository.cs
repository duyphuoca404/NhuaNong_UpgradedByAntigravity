using System;
using System.Collections.Generic;
using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;

namespace NhuaNong.DAL;

internal class NhanVienRepository : EFRepository<NhanVien>, INhanVienRepository, IEFRepository<NhanVien>
{
	public NhanVienRepository(IDbContextManager dbCtxMng)
		: base(dbCtxMng)
	{
		base.KeyProperty = GetKeyColumnName(new NhanVien(), new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
	}

	public IList<NhanVien> ListNhanVien_ByCondition(DateTime? fromDate, DateTime? toDate, string maKH, string tenKH, string phone, bool? active)
	{
		Specification<NhanVien> specification = new Specification<NhanVien>((NhanVien o) => (o.MaNhanVien.Contains(maKH) || maKH.Trim() == string.Empty) && (o.TenNhanVien.Contains(tenKH) || tenKH.Trim() == string.Empty) && (o.Phone.Contains(phone) || phone.Trim() == string.Empty) && (o.CreationDate >= fromDate || fromDate == DateTime.MinValue) && (o.CreationDate <= toDate || toDate == DateTime.MinValue) && ((bool?)o.Activated == active || active == (bool?)null));
		return SelectAll(specification);
	}
}

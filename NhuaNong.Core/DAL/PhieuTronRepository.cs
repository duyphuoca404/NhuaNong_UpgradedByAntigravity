using System;
using System.Collections.Generic;
using System.Linq;
using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;

namespace NhuaNong.DAL;

public class PhieuTronRepository : EFRepository<PhieuTron>, IPhieuTronRepository, IEFRepository<PhieuTron>
{
	public PhieuTronRepository(IDbContextManager dbCtxMng)
		: base(dbCtxMng)
	{
		base.KeyProperty = GetKeyColumnName(new PhieuTron(), new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
	}

	public PhieuTron GetByCode(string code)
	{
		Specification<PhieuTron> specification = new Specification<PhieuTron>((PhieuTron pt) => pt.MaPhieuTron == code);
		return DoQuery(specification).FirstOrDefault();
	}

	public PhieuTron GetLastest()
	{
		return (from mt in DoQuery()
			orderby mt.PhieuTronID descending
			select mt).FirstOrDefault();
	}

	public IList<PhieuTron> ListPhieuTron_ForTronOnline()
	{
		Specification<PhieuTron> specification = new Specification<PhieuTron>((PhieuTron pt) => pt.IsQueued == (bool?)true && (pt.Status == (int?)0 || pt.Status == (int?)2 || pt.Status == (int?)3 || pt.Status == (int?)6 || pt.Status == (int?)5 || pt.Status == (int?)7));
		return (from m in DoQuery(specification)
			orderby m.PhieuTronID
			select m).ToList();
	}

	public IList<PhieuTron> ListPhieuTron_ByStatus(int status)
	{
		Specification<PhieuTron> specification = new Specification<PhieuTron>((PhieuTron pt) => pt.Status == (int?)status);
		return SelectAll(specification);
	}

	public IList<PhieuTron> ListPhieuTron_ByIsQueued(bool isQueued)
	{
		Specification<PhieuTron> specification = new Specification<PhieuTron>((PhieuTron pt) => pt.IsQueued == (bool?)isQueued);
		return SelectAll(specification);
	}

	public IList<PhieuTron> ListPhieuTron_ByCondition(string maPhieuTron, DateTime fromDate, DateTime toDate, int? status, bool? isQueued)
	{
		Specification<PhieuTron> specification = new Specification<PhieuTron>((PhieuTron pt) => (pt.MaPhieuTron.Contains(maPhieuTron) || maPhieuTron.Trim() == string.Empty) && pt.NgayPhieuTron >= fromDate && pt.NgayPhieuTron <= toDate && (pt.Status == status || status == (int?)(-1)) && (pt.IsQueued == isQueued || isQueued == (bool?)null));
		return (from pt in SelectAll(specification)
			orderby pt.PhieuTronID descending
			select pt).ToList();
	}

	public IList<string> ListMaPhieuTron_AutoComplete(string strInput, int? length)
	{
		if (strInput.Trim() == string.Empty)
		{
			return new List<string>();
		}
		Specification<PhieuTron> specification = new Specification<PhieuTron>((PhieuTron pt) => pt.MaPhieuTron.Contains(strInput));
		List<string> list = new List<string>();
		if (length.HasValue)
		{
			return (from p in DoQuery(specification).Take(length.Value)
				select p.MaPhieuTron).ToList();
		}
		return (from p in DoQuery(specification)
			select p.MaPhieuTron).ToList();
	}

	public IList<PhieuTron> ListPhieuTron_AutoComplete(string strInput, int? length)
	{
		if (strInput.Trim() == string.Empty)
		{
			return new List<PhieuTron>();
		}
		Specification<PhieuTron> specification = new Specification<PhieuTron>((PhieuTron pt) => pt.MaPhieuTron.Contains(strInput));
		List<PhieuTron> list = new List<PhieuTron>();
		if (length.HasValue)
		{
			return DoQuery(specification).Take(length.Value).ToList();
		}
		return DoQuery(specification).ToList();
	}
}

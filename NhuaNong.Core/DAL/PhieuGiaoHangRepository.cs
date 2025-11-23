using System;
using System.Collections.Generic;
using System.Linq;
using NhuaNong.Core;
using NhuaNong.EntityModel;
using NhuaNong.Utils;

namespace NhuaNong.DAL;

public class PhieuGiaoHangRepository : EFRepository<PhieuGiaoHang>, IPhieuGiaoHangRepository, IEFRepository<PhieuGiaoHang>
{
	public PhieuGiaoHangRepository(IDbContextManager dbCtxMng)
		: base(dbCtxMng)
	{
		base.KeyProperty = GetKeyColumnName(new PhieuGiaoHang(), new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString));
	}

	public PhieuGiaoHang GetByCode(string code)
	{
		Specification<PhieuGiaoHang> specification = new Specification<PhieuGiaoHang>((PhieuGiaoHang pt) => pt.MaPhieuTron == code);
		return DoQuery(specification).FirstOrDefault();
	}

	public PhieuGiaoHang GetLastest()
	{
		return (from mt in DoQuery()
			orderby mt.PhieuTronID descending
			select mt).FirstOrDefault();
	}

	public IList<string> ListMaPhieuTron_AutoComplete(string strInput, int? length)
	{
		if (strInput.Trim() == string.Empty)
		{
			return new List<string>();
		}
		Specification<PhieuGiaoHang> specification = new Specification<PhieuGiaoHang>((PhieuGiaoHang pt) => pt.MaPhieuTron.Contains(strInput));
		List<string> list = new List<string>();
		if (length.HasValue)
		{
			return (from p in DoQuery(specification).Take(length.Value)
				select p.MaPhieuTron).ToList();
		}
		return (from p in DoQuery(specification)
			select p.MaPhieuTron).ToList();
	}

	public IList<PhieuGiaoHang> ListPhieuTron_AutoComplete(string strInput, int? length)
	{
		if (strInput.Trim() == string.Empty)
		{
			return new List<PhieuGiaoHang>();
		}
		Specification<PhieuGiaoHang> specification = new Specification<PhieuGiaoHang>((PhieuGiaoHang pt) => pt.MaPhieuTron.Contains(strInput));
		List<PhieuGiaoHang> list = new List<PhieuGiaoHang>();
		if (length.HasValue)
		{
			return DoQuery(specification).Take(length.Value).ToList();
		}
		return DoQuery(specification).ToList();
	}

	public IList<PhieuGiaoHang> ListPhieuTron_ByCondition(string maPhieuTron, DateTime fromDate, DateTime toDate, int? status, bool? isQueued)
	{
		Specification<PhieuGiaoHang> specification = new Specification<PhieuGiaoHang>((PhieuGiaoHang pt) => (pt.MaPhieuTron.Contains(maPhieuTron) || maPhieuTron.Trim() == string.Empty) && pt.NgayPhieuTron >= fromDate && pt.NgayPhieuTron <= toDate && (pt.Activated == isQueued || isQueued == (bool?)null));
		return (from pt in SelectAll(specification)
			orderby pt.PhieuTronID descending
			select pt).ToList();
	}

	public IList<PhieuGiaoHang> ListPhieuTron_ByCondition(string maPhieuTron, DateTime fromDate, DateTime toDate, bool? isQueued)
	{
		throw new NotImplementedException();
	}

	public IList<PhieuGiaoHang> ListPhieuTron_ByIsQueued(bool isQueued)
	{
		Specification<PhieuGiaoHang> specification = new Specification<PhieuGiaoHang>((PhieuGiaoHang pt) => pt.Activated == (bool?)isQueued);
		return SelectAll(specification);
	}
}

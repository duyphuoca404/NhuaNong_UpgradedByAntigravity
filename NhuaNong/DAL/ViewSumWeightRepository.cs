using System;
using System.Collections.Generic;
using NhuaNong.Core;
using NhuaNong.EntityModel;

namespace NhuaNong.DAL;

internal class ViewSumWeightRepository : EFRepository<vw_SumWeight>, IViewSumWeightRepository, IEFRepository<vw_SumWeight>
{
	public ViewSumWeightRepository(IDbContextManager dbCtxMng)
		: base(dbCtxMng)
	{
		base.KeyProperty = "PhieuTronID";
	}

	public IList<vw_SumWeight> ListSumWeight_ByCondition(DateTime? fromDate, DateTime? toDate, string maPhieuTron, int? khachHang, int? congTruong, int? hangMuc, int? mac, int? bienSo, int? taiXe, int? nhanVien, bool? active)
	{
		Specification<vw_SumWeight> specification = new Specification<vw_SumWeight>((vw_SumWeight o) => o.NgayPhieuTron >= fromDate && o.NgayPhieuTron <= toDate && (o.MaPhieuTron.Contains(maPhieuTron) || maPhieuTron.Trim() == string.Empty) && ((int?)o.KH_int == khachHang || khachHang == (int?)null) && (o.CT_int == congTruong || congTruong == (int?)null) && (o.HM_int == hangMuc || hangMuc == (int?)null) && (o.MAC_int == mac || mac == (int?)null) && (o.Xe_int == bienSo || bienSo == (int?)null) && (o.TX_int == taiXe || taiXe == (int?)null) && (o.CreatedBy == nhanVien || nhanVien == (int?)null) && (o.IsQueued == active || active == new bool?()));
		return SelectAll(specification);
	}
}

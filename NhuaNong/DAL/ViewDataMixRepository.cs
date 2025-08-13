using System;
using System.Collections.Generic;
using System.Linq;
using NhuaNong.Core;
using NhuaNong.Data;
using NhuaNong.EntityModel;

namespace NhuaNong.DAL;

public class ViewDataMixRepository : EFRepository<vw_DataMix>, IViewDataMixRepository, IEFRepository<vw_DataMix>
{
	public ViewDataMixRepository(IDbContextManager dbCtxMng)
		: base(dbCtxMng)
	{
		base.KeyProperty = "MeTronID";
	}

	public IList<vw_DataMix> ListDataMix(DateTime? fromDate, DateTime? toDate, string maPhieuTron)
	{
		Specification<vw_DataMix> specification = new Specification<vw_DataMix>((vw_DataMix o) => (o.MaPhieuTron.Contains(maPhieuTron) || maPhieuTron.Trim() == string.Empty) && o.NgayMeTron >= fromDate && o.NgayMeTron <= toDate);
		return SelectAll(specification);
	}

	public IList<vw_DataMix> ListDataMix_ByCondition(DateTime? fromDate, DateTime? toDate, string maPhieuTron, string khachHang, string congTruong, string hangMuc, string taiXe, string bienSo, string mac, string nhanVien)
	{
		Specification<vw_DataMix> specification = new Specification<vw_DataMix>((vw_DataMix o) => ((o.NgayMeTron >= fromDate && o.NgayMeTron <= toDate && o.MaPhieuTron.Contains(maPhieuTron)) || maPhieuTron.Trim() == string.Empty) && (o.KH.Contains(khachHang) || khachHang.Trim() == string.Empty) && (o.CT.Contains(congTruong) || congTruong.Trim() == string.Empty) && (o.Plate.Contains(hangMuc) || hangMuc.Trim() == string.Empty) && (o.Name.Contains(taiXe) || taiXe.Trim() == string.Empty) && (o.TX.Contains(bienSo) || bienSo.Trim() == string.Empty) && (o.MAC.Contains(mac) || mac.Trim() == string.Empty) && (o.NoteMAC.Contains(nhanVien) || nhanVien.Trim() == string.Empty));
		return SelectAll(specification);
	}

	public IList<vw_DataMix> ListDataMix_ByCondition(DateTime? fromDate, DateTime? toDate, string maPhieuTron, int? khachHang, int? congTruong, int? hangMuc, int? mac, int? bienSo, int? taiXe, int? nhanVien, bool? moPhong)
	{
		Specification<vw_DataMix> specification = new Specification<vw_DataMix>((vw_DataMix o) => o.NgayMeTron >= fromDate && o.NgayMeTron <= toDate && (o.MaPhieuTron.Contains(maPhieuTron) || maPhieuTron.Trim() == string.Empty) && (o.KH_int == khachHang || khachHang == (int?)null) && (o.CT_int == congTruong || congTruong == (int?)null) && (o.HM_int == hangMuc || hangMuc == (int?)null) && (o.MAC_int == mac || mac == (int?)null) && (o.Xe_int == bienSo || bienSo == (int?)null) && (o.TaiXeID == taiXe || taiXe == (int?)null) && (o.CreatedBy == nhanVien || nhanVien == (int?)null) && (o.IsQueued == moPhong || moPhong == new bool?()));
		return (from dm in SelectAll(specification)
			orderby dm.MeTronID descending
			select dm).ToList();
	}

	public ObjAggregationResult GetSumForIsQueuedAndTimeRange(DateTime? fromDate, DateTime? toDate, bool? activated)
	{
		Specification<vw_DataMix> specification = new Specification<vw_DataMix>((vw_DataMix data) => (data.IsQueued == activated || activated == (bool?)null) && (data.NgayMeTron >= fromDate || fromDate == DateTime.MinValue) && (data.NgayMeTron <= toDate || toDate == DateTime.MinValue));
		IQueryable<vw_DataMix> source = DoQuery(specification);
		ObjAggregationResult objAggregationResult = new ObjAggregationResult();
		objAggregationResult.Total_Agg1 = source.Sum((vw_DataMix data) => data.Agg1);
		objAggregationResult.Total_Agg2 = source.Sum((vw_DataMix data) => data.Agg2);
		objAggregationResult.Total_Agg3 = source.Sum((vw_DataMix data) => data.Agg3);
		objAggregationResult.Total_Agg4 = source.Sum((vw_DataMix data) => data.Agg4);
		objAggregationResult.Total_Agg5 = source.Sum((vw_DataMix data) => data.Agg5);
		objAggregationResult.Total_Ce1 = source.Sum((vw_DataMix data) => data.Ce1);
		objAggregationResult.Total_Ce2 = source.Sum((vw_DataMix data) => data.Ce2);
		objAggregationResult.Total_Ce3 = source.Sum((vw_DataMix data) => data.Ce3);
		objAggregationResult.Total_Ce4 = source.Sum((vw_DataMix data) => data.Ce4);
		objAggregationResult.Total_Ce5 = source.Sum((vw_DataMix data) => data.Ce5);
		objAggregationResult.Total_Wa1 = source.Sum((vw_DataMix data) => data.Wa1);
		objAggregationResult.Total_Wa2 = source.Sum((vw_DataMix data) => data.Wa2);
		objAggregationResult.Total_Add1 = source.Sum((vw_DataMix data) => data.Add1);
		objAggregationResult.Total_Add2 = source.Sum((vw_DataMix data) => data.Add2);
		objAggregationResult.Total_Add3 = source.Sum((vw_DataMix data) => data.Add3);
		objAggregationResult.Total_Add4 = source.Sum((vw_DataMix data) => data.Add4);
		objAggregationResult.Total_Add5 = source.Sum((vw_DataMix data) => data.Add5);
		objAggregationResult.Total_Add6 = source.Sum((vw_DataMix data) => data.Add6);
		objAggregationResult.Total_Agg1_Bat = source.Sum((vw_DataMix data) => data.Agg1_Bat);
		objAggregationResult.Total_Agg2_Bat = source.Sum((vw_DataMix data) => data.Agg2_Bat);
		objAggregationResult.Total_Agg3_Bat = source.Sum((vw_DataMix data) => data.Agg3_Bat);
		objAggregationResult.Total_Agg4_Bat = source.Sum((vw_DataMix data) => data.Agg4_Bat);
		objAggregationResult.Total_Agg5_Bat = source.Sum((vw_DataMix data) => data.Agg5_Bat);
		objAggregationResult.Total_Ce1_Bat = source.Sum((vw_DataMix data) => data.Ce1_Bat);
		objAggregationResult.Total_Ce2_Bat = source.Sum((vw_DataMix data) => data.Ce2_Bat);
		objAggregationResult.Total_Ce3_Bat = source.Sum((vw_DataMix data) => data.Ce3_Bat);
		objAggregationResult.Total_Ce4_Bat = source.Sum((vw_DataMix data) => data.Ce4_Bat);
		objAggregationResult.Total_Ce5_Bat = source.Sum((vw_DataMix data) => data.Ce5_Bat);
		objAggregationResult.Total_Wa1_Bat = source.Sum((vw_DataMix data) => data.Wa1_Bat);
		objAggregationResult.Total_Wa2_Bat = source.Sum((vw_DataMix data) => data.Wa2_Bat);
		objAggregationResult.Total_Add1_Bat = source.Sum((vw_DataMix data) => data.Add1_Bat);
		objAggregationResult.Total_Add2_Bat = source.Sum((vw_DataMix data) => data.Add2_Bat);
		objAggregationResult.Total_Add3_Bat = source.Sum((vw_DataMix data) => data.Add3_Bat);
		objAggregationResult.Total_Add4_Bat = source.Sum((vw_DataMix data) => data.Add4_Bat);
		objAggregationResult.Total_Add5_Bat = source.Sum((vw_DataMix data) => data.Add5_Bat);
		objAggregationResult.Total_Add6_Bat = source.Sum((vw_DataMix data) => data.Add6_Bat);
		objAggregationResult.Total_Agg1_Man = source.Sum((vw_DataMix data) => data.Agg1_Man);
		objAggregationResult.Total_Agg2_Man = source.Sum((vw_DataMix data) => data.Agg2_Man);
		objAggregationResult.Total_Agg3_Man = source.Sum((vw_DataMix data) => data.Agg3_Man);
		objAggregationResult.Total_Agg4_Man = source.Sum((vw_DataMix data) => data.Agg4_Man);
		objAggregationResult.Total_Agg5_Man = source.Sum((vw_DataMix data) => data.Agg5_Man);
		objAggregationResult.Total_Ce1_Man = source.Sum((vw_DataMix data) => data.Ce1_Man);
		objAggregationResult.Total_Ce2_Man = source.Sum((vw_DataMix data) => data.Ce2_Man);
		objAggregationResult.Total_Ce3_Man = source.Sum((vw_DataMix data) => data.Ce3_Man);
		objAggregationResult.Total_Ce4_Man = source.Sum((vw_DataMix data) => data.Ce4_Man);
		objAggregationResult.Total_Ce5_Man = source.Sum((vw_DataMix data) => data.Ce5_Man);
		objAggregationResult.Total_Wa1_Man = source.Sum((vw_DataMix data) => data.Wa1_Man);
		objAggregationResult.Total_Wa2_Man = source.Sum((vw_DataMix data) => data.Wa2_Man);
		objAggregationResult.Total_Add1_Man = source.Sum((vw_DataMix data) => data.Add1_Man);
		objAggregationResult.Total_Add2_Man = source.Sum((vw_DataMix data) => data.Add2_Man);
		objAggregationResult.Total_Add3_Man = source.Sum((vw_DataMix data) => data.Add3_Man);
		objAggregationResult.Total_Add4_Man = source.Sum((vw_DataMix data) => data.Add4_Man);
		objAggregationResult.Total_Add5_Man = source.Sum((vw_DataMix data) => data.Add5_Man);
		objAggregationResult.Total_Add6_Man = source.Sum((vw_DataMix data) => data.Add6_Man);
		return objAggregationResult;
	}
}

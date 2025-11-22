using System;
using System.ComponentModel;
using NhuaNong.Data;
using NhuaNong.Utils;

namespace NhuaNong.MasterData
{
	// Token: 0x02000093 RID: 147
	public class DataMixMngDataPresenter : MasterDataPresenter<IDataMixMngView>
	{
		// Token: 0x060008C8 RID: 2248 RVA: 0x00051F0D File Offset: 0x0005010D
		public DataMixMngDataPresenter(IDataMixMngView view) : base(view)
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00051F16 File Offset: 0x00050116
		public void ListDataMixStatus()
		{
			base._iView.LstDataMixStatus = Converter.EnumToListFieldCode<Enums.DuLieuTronStatus>(true);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00051F29 File Offset: 0x00050129
		public void ListKhachHang()
		{
			base._iView.BLstKhachHang = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListKhachHang();
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00051F40 File Offset: 0x00050140
		public void ListCongTruong()
		{
			base._iView.BLstCongTruong = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListCongTruong();
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00051F57 File Offset: 0x00050157
		public void ListHangMuc()
		{
			base._iView.BLstHangMuc = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListHangMuc();
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00051F6E File Offset: 0x0005016E
		public void ListMAC()
		{
			base._iView.BLstMAC = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListMAC();
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00051F85 File Offset: 0x00050185
		public void ListSilo()
		{
			base._iView.BLstSilo = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListSilo();
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00051F9C File Offset: 0x0005019C
		public void ListXe()
		{
			base._iView.BLstXe = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListXe();
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00051FB3 File Offset: 0x000501B3
		public void ListTaiXe()
		{
			base._iView.BLstTaiXe = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListTaiXe();
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00051FCA File Offset: 0x000501CA
		public void ListNhanVien()
		{
			base._iView.BLstNhanVien = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListNhanVien();
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00051FE1 File Offset: 0x000501E1
		public void ListDataMix()
		{
			base._iView.BLstDataMix = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListDataMix();
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00051FF8 File Offset: 0x000501F8
		public void ListDataMix_ByCondition(DateTime? fromDate, DateTime? toDate, string maPT, string khachHang, string congTruong, string hangMuc, string taiXe, string bienXe, string mac, string nhanVIen)
		{
			base._iView.BLstDataMix = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListDataMix_ByCondition(fromDate, toDate, maPT, khachHang, congTruong, hangMuc, taiXe, bienXe, mac, nhanVIen);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0005202C File Offset: 0x0005022C
		public void ListDataMix_ByCondition(DateTime? fromDate, TimeSpan? fromTime, DateTime? toDate, TimeSpan? toTime, string maPhieuTron, int? khachHang, int? congTruong, int? hangMuc, int? mac, int? bienSo, int? taiXe, int? nhanVien, bool? moPhong)
		{
			base._iView.BLstDataMix = MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListDataMix_ByCondition(fromDate, fromTime, toDate, toTime, maPhieuTron, khachHang, congTruong, hangMuc, mac, bienSo, taiXe, nhanVien, moPhong);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00052068 File Offset: 0x00050268
		public BindingList<Objvw_DataMix> ListDataMix_ByCondition_re(DateTime? fromDate, TimeSpan? fromTime, DateTime? toDate, TimeSpan? toTime, string maPhieuTron, int? khachHang, int? congTruong, int? hangMuc, int? mac, int? bienSo, int? taiXe, int? nhanVien, bool? moPhong)
		{
			return MasterDataPresenter<IDataMixMngView>._iMasterDataModel.ListDataMix_ByCondition(fromDate, fromTime, toDate, toTime, maPhieuTron, khachHang, congTruong, hangMuc, mac, bienSo, taiXe, nhanVien, moPhong);
		}
	}
}

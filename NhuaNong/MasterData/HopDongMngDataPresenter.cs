using System;
using System.ComponentModel;
using NhuaNong.Data;
using NhuaNong.Utils;

namespace NhuaNong.MasterData
{
	// Token: 0x020000BC RID: 188
	public class HopDongMngDataPresenter : MasterDataPresenter<IHopDongMngView>
	{
		// Token: 0x06000E62 RID: 3682 RVA: 0x00080B3F File Offset: 0x0007ED3F
		public HopDongMngDataPresenter(IHopDongMngView view) : base(view)
		{
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00080B48 File Offset: 0x0007ED48
		public void ListHopDong()
		{
			base._iView.BLstHopDong = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListHopDong();
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00080B60 File Offset: 0x0007ED60
		public void ListHopDong(string maHopDong, DateTime fromDate, DateTime toDate, int? status, int? khachHangID, int? congTruongID, int? macID)
		{
			base._iView.BLstHopDong = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListHopDong_ByCondition(maHopDong, fromDate, toDate, status, khachHangID, congTruongID, macID);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00080B8D File Offset: 0x0007ED8D
		public void SaveHopDong(BindingList<ObjHopDong> blstCT)
		{
			base._iView.IsSuccessfulSaved = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.SaveHopDong(blstCT);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00080BA5 File Offset: 0x0007EDA5
		public void ListHopDongStatus()
		{
			base._iView.LstHopDongStatus = Converter.EnumToListFieldCode<Enums.HopDongStatus>(true);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00080BB8 File Offset: 0x0007EDB8
		public void ListKhachHang()
		{
			base._iView.BLstKhachHang = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListKhachHang();
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00080BD0 File Offset: 0x0007EDD0
		public void ListKhachHang_ByCondition(DateTime? fromDate, DateTime? toDate, string maKH, string tenKH, string diaChi, string phone, bool? active)
		{
			base._iView.BLstKhachHang = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListKhachHang_ByCondition(fromDate, toDate, maKH, tenKH, diaChi, phone, active);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00080BFD File Offset: 0x0007EDFD
		public void ListCongTruong()
		{
			base._iView.BLstCongTruong = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListCongTruong();
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00080C14 File Offset: 0x0007EE14
		public void ListCongTruong_ByCondition(DateTime? fromDate, DateTime? toDate, string maKH, string tenKH, string diaChi, string phone, bool? active)
		{
			base._iView.BLstCongTruong = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListCongTruong_ByCondition(fromDate, toDate, maKH, tenKH, diaChi, phone, active);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00080C41 File Offset: 0x0007EE41
		public void ListMAC()
		{
			base._iView.BLstMAC = MasterDataPresenter<IHopDongMngView>._iMasterDataModel.ListMAC();
		}
	}
}

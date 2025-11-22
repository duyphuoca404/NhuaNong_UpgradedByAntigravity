using System;
using System.ComponentModel;
using NhuaNong.Data;

namespace NhuaNong.MasterData
{
	// Token: 0x02000097 RID: 151
	internal class HangMucMngDataPresenter : MasterDataPresenter<IHangMucMngView>
	{
		// Token: 0x0600093C RID: 2364 RVA: 0x00058352 File Offset: 0x00056552
		public HangMucMngDataPresenter(IHangMucMngView view) : base(view)
		{
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0005835B File Offset: 0x0005655B
		public void ListHangMuc()
		{
			base._iView.BLstHangMuc = MasterDataPresenter<IHangMucMngView>._iMasterDataModel.ListHangMuc();
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00058372 File Offset: 0x00056572
		public void ListHangMuc_ByCondition(DateTime? fromDate, DateTime? toDate, string maKH, string tenKH, bool? active)
		{
			base._iView.BLstHangMuc = MasterDataPresenter<IHangMucMngView>._iMasterDataModel.ListHangMuc_ByCondition(fromDate, toDate, maKH, tenKH, active);
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00058390 File Offset: 0x00056590
		public void SaveHangMuc(BindingList<ObjHangMuc> blstCT)
		{
			base._iView.IsSuccessfulSaved = MasterDataPresenter<IHangMucMngView>._iMasterDataModel.SaveHangMuc(blstCT);
		}
	}
}

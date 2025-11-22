using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Data;
using NhuaNong.Utils;

namespace NhuaNong.MasterData
{
	// Token: 0x020000BD RID: 189
	public partial class HopDongMngView : ControlViewBase, IHopDongMngView, IBase, IPermission
	{
		// Token: 0x17000464 RID: 1124
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00080C58 File Offset: 0x0007EE58
		public List<ObjSEC_Function> LstFunction
		{
			set
			{
				this._lstFunction = value;
				this.BindPermission();
			}
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00080C68 File Offset: 0x0007EE68
		public HopDongMngView()
		{
			try
			{
				this.InitializeComponent();
				this._presenter = new HopDongMngDataPresenter(this);
				base.Caption = this.bsiCaption.Caption;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00080D0C File Offset: 0x0007EF0C
		public int? SearchStatus
		{
			set
			{
				if (value == null)
				{
					value = new int?(-1);
				}
				this._searchStatus = value;
				this.lueHDStatus.EditValue = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x00080D37 File Offset: 0x0007EF37
		public bool UseAsSearching
		{
			set
			{
				this._useAsSearching = value;
				this.barButtons.Visible = !this._useAsSearching;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00080D54 File Offset: 0x0007EF54
		public BindingList<ObjHopDong> BLstHopDong
		{
			set
			{
				this._blstHopDong = value;
				this.grcHopDong.DataSource = this._blstHopDong;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00080D6E File Offset: 0x0007EF6E
		public BindingList<ObjKhachHang> BLstKhachHang
		{
			set
			{
				this._blstKhachHang = value;
				this.lueKhachHang.Properties.DataSource = this._blstKhachHang;
				this.illueKhachHang.DataSource = this._blstKhachHang;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x00080D9E File Offset: 0x0007EF9E
		public BindingList<ObjCongTruong> BLstCongTruong
		{
			set
			{
				this._blstCongTruong = value;
				this.lueCongTruong.Properties.DataSource = this._blstCongTruong;
				this.ilueCongTruong.DataSource = this._blstCongTruong;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x00080DCE File Offset: 0x0007EFCE
		public BindingList<ObjMAC> BLstMAC
		{
			set
			{
				this._blstMAC = value;
				this.lueMAC.Properties.DataSource = this._blstMAC;
				this.ilueMAC.DataSource = this._blstMAC;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x00080DFE File Offset: 0x0007EFFE
		public bool IsSuccessfulSaved
		{
			set
			{
				this.SuccessfullySave(value);
			}
		}

		// Token: 0x1700046C RID: 1132
		// (set) Token: 0x06000E75 RID: 3701 RVA: 0x00080E07 File Offset: 0x0007F007
		public List<FieldCode> LstHopDongStatus
		{
			set
			{
				this._lstHopDongStatus = value;
				this.ilueHDStatus.DataSource = this._lstHopDongStatus;
				this.lueHDStatus.Properties.DataSource = this._lstHopDongStatus;
			}
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00080E37 File Offset: 0x0007F037
		protected override void PopulateStaticData()
		{
			this._presenter.ListKhachHang();
			this._presenter.ListCongTruong();
			this._presenter.ListMAC();
			this.LoadHDStatus();
			this.LoadSearchDefaultValues();
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00080E66 File Offset: 0x0007F066
		protected override void PopulateData()
		{
			this.LoadHopDong();
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x0000235E File Offset: 0x0000055E
		protected override void AdjustCulture()
		{
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00080E70 File Offset: 0x0007F070
		public override List<T> GetSelectedObjects<T>()
		{
			List<T> list = new List<T>();
			foreach (int rowHandle in this.grvHopDong.GetSelectedRows())
			{
				T item = (T)((object)this.grvHopDong.GetRow(rowHandle));
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00080EC0 File Offset: 0x0007F0C0
		private void LoadHopDong()
		{
			this._presenter.ListHopDong(this.txtMaHopDong.Text, Searching.Build_StartDateTime(this.datTuNgay.DateTime), Searching.Build_EndDateTime(this.datDenNgay.DateTime), (int?)this.lueHDStatus.EditValue, (int?)this.lueKhachHang.EditValue, (int?)this.lueCongTruong.EditValue, (int?)this.lueMAC.EditValue);
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x00080F44 File Offset: 0x0007F144
		private void LoadSearchDefaultValues()
		{
			this.datTuNgay.EditValue = DateTime.Now.AddDays(-(double)ConfigManager.TramTronConfig.LatestHopDongDays);
			this.datDenNgay.EditValue = DateTime.Now;
			this.txtMaHopDong.Text = string.Empty;
			this.lueHDStatus.EditValue = this._searchStatus;
			this.lueKhachHang.EditValue = null;
			this.lueCongTruong.EditValue = null;
			this.lueMAC.EditValue = null;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00080FD9 File Offset: 0x0007F1D9
		private void LoadHDStatus()
		{
			this._presenter.ListHopDongStatus();
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x0000235E File Offset: 0x0000055E
		private void SuccessfullySave(bool isSuccess)
		{
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00080E66 File Offset: 0x0007F066
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadHopDong();
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00080FE6 File Offset: 0x0007F1E6
		private void btnReset_Click(object sender, EventArgs e)
		{
			this.LoadSearchDefaultValues();
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00080FEE File Offset: 0x0007F1EE
		private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
		{
			NewHopDongView newHopDongView = new NewHopDongView(null, Enums.FormAction.New);
			ViewManager.ShowViewDialog(newHopDongView);
			if (newHopDongView.GetDialogResult() != DialogResult.OK)
			{
				return;
			}
			this._presenter.ListHopDong();
			base.FocusRow(this.grvHopDong, this.grvHopDong.RowCount);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00081028 File Offset: 0x0007F228
		private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (this.grvHopDong.RowCount == 0)
			{
				return;
			}
			int focusedRowHandle = this.grvHopDong.FocusedRowHandle;
			NewHopDongView newHopDongView = new NewHopDongView(this.grvHopDong.GetRow(focusedRowHandle) as ObjHopDong, Enums.FormAction.Edit);
			ViewManager.ShowViewDialog(newHopDongView);
			if (newHopDongView.GetDialogResult() != DialogResult.OK)
			{
				return;
			}
			this._presenter.ListHopDong();
			base.FocusRow(this.grvHopDong, focusedRowHandle);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00081090 File Offset: 0x0007F290
		private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
		{
			BindingList<ObjHopDong> bindingList = new BindingList<ObjHopDong>();
			foreach (int num in this.grvHopDong.GetSelectedRows())
			{
				if (num >= 0)
				{
					ObjHopDong objHopDong = this.grvHopDong.GetRow(num) as ObjHopDong;
					objHopDong.MarkAsDeleted = true;
					bindingList.Add(objHopDong);
				}
			}
			foreach (ObjHopDong item in bindingList)
			{
				this._blstHopDong.Remove(item);
			}
			base.FocusRow(this.grvHopDong, this.grvHopDong.RowCount);
			this._presenter.SaveHopDong(bindingList);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00081154 File Offset: 0x0007F354
		private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (this.grvHopDong.RowCount == 0)
			{
				return;
			}
			ViewManager.ShowViewDialog(new NewHopDongView(this.grvHopDong.GetRow(this.grvHopDong.FocusedRowHandle) as ObjHopDong, Enums.FormAction.View));
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0008118C File Offset: 0x0007F38C
		private void BindPermission()
		{
			this.bbiInsert.Enabled = this.CheckHasPermission(this.bbiInsert.Name);
			this.bbiUpdate.Enabled = this.CheckHasPermission(this.bbiUpdate.Name);
			this.bbiDelete.Enabled = this.CheckHasPermission(this.bbiDelete.Name);
			this.bbiView.Enabled = this.CheckHasPermission(this.bbiView.Name);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0008120C File Offset: 0x0007F40C
		private bool CheckHasPermission(string funcName)
		{
			using (List<ObjSEC_Function>.Enumerator enumerator = this._lstFunction.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.MenuName == funcName)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0008126C File Offset: 0x0007F46C
		private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
		{
			if (this.grvHopDong.RowCount == 0)
			{
				return;
			}
			int focusedRowHandle = this.grvHopDong.FocusedRowHandle;
			NewPhieuTronView newPhieuTronView = new NewPhieuTronView(this.grvHopDong.GetRow(focusedRowHandle) as ObjHopDong, Enums.FormAction.New);
			ViewManager.ShowViewDialog(newPhieuTronView);
			if (newPhieuTronView.GetDialogResult() == DialogResult.OK)
			{
				this._presenter.ListHopDong();
				base.FocusRow(this.grvHopDong, focusedRowHandle);
			}
		}

		// Token: 0x04000B40 RID: 2880
		private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();

		// Token: 0x04000B41 RID: 2881
		private HopDongMngDataPresenter _presenter;

		// Token: 0x04000B42 RID: 2882
		private int? _searchStatus = new int?(-1);

		// Token: 0x04000B43 RID: 2883
		private bool _useAsSearching;

		// Token: 0x04000B44 RID: 2884
		private BindingList<ObjHopDong> _blstHopDong = new BindingList<ObjHopDong>();

		// Token: 0x04000B45 RID: 2885
		private BindingList<ObjKhachHang> _blstKhachHang = new BindingList<ObjKhachHang>();

		// Token: 0x04000B46 RID: 2886
		private BindingList<ObjCongTruong> _blstCongTruong = new BindingList<ObjCongTruong>();

		// Token: 0x04000B47 RID: 2887
		private BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();

		// Token: 0x04000B48 RID: 2888
		private List<FieldCode> _lstHopDongStatus = new List<FieldCode>();

		// Token: 0x04000B49 RID: 2889
	}
}

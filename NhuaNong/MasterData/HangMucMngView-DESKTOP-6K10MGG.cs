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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using NhuaNong.Data;
using NhuaNong.Utils;

namespace NhuaNong.MasterData
{
	// Token: 0x02000098 RID: 152
	public partial class HangMucMngView : ControlViewBase, IHangMucMngView, IBase, IPermission
	{
		// Token: 0x1700027C RID: 636
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x000583A8 File Offset: 0x000565A8
		public List<ObjSEC_Function> LstFunction
		{
			set
			{
				this._lstFunction = value;
				this.BindPermission();
			}
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000583B8 File Offset: 0x000565B8
		public HangMucMngView()
		{
			this.InitializeComponent();
			this._presenter = new HangMucMngDataPresenter(this);
			base.Caption = this.bsiCaption.Caption;
		}

		// Token: 0x1700027D RID: 637
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00058404 File Offset: 0x00056604
		public BindingList<ObjHangMuc> BLstHangMuc
		{
			set
			{
				this._blstHangMuc = value;
				this.grcHangMuc.DataSource = this._blstHangMuc;
			}
		}

		// Token: 0x1700027E RID: 638
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x0005841E File Offset: 0x0005661E
		public bool IsSuccessfulSaved
		{
			set
			{
				this.SuccessfullySave(value);
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00058427 File Offset: 0x00056627
		protected override void PopulateStaticData()
		{
			this.lueActive.Properties.DataSource = Converter.EnumToListFieldCode<Enums.ActiveEnum>(true);
			this.LoadSearchDefaultValues();
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00058445 File Offset: 0x00056645
		private void SuccessfullySave(bool isSuccess)
		{
			if (isSuccess)
			{
				this.LoadHangMuc();
				return;
			}
			TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.UnsuccessProceed);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0005845C File Offset: 0x0005665C
		private void LoadSearchDefaultValues()
		{
			this.datFromDate.EditValue = null;
			this.datToDate.EditValue = Searching.Build_EndDateTime(DateTime.Now);
			this.txtMaHM.Text = (this.txtTenHM.Text = string.Empty);
			this.lueActive.EditValue = -1;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x000584C0 File Offset: 0x000566C0
		private void LoadHangMuc()
		{
			try
			{
				SplashScreenManager.ShowForm(typeof(NDPWaitForm));
				SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.WAIT_CAPTION);
				SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
				if (Convert.ToInt32(this.lueActive.EditValue) != 1)
				{
					Convert.ToInt32(this.lueActive.EditValue);
				}
				this._presenter.ListHangMuc_ByCondition(new DateTime?(this.datFromDate.DateTime), new DateTime?(this.datToDate.DateTime), this.txtMaHM.Text, this.txtTenHM.Text, null);
			}
			catch (Exception ex)
			{
				TramTromMessageBox.ShowDEPErrorDialog(ex);
				TramTronLogger.WriteError(ex);
			}
			finally
			{
				SplashScreenManager.CloseForm();
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0005859C File Offset: 0x0005679C
		private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
		{
			NewHangMucView newHangMucView = new NewHangMucView(null, Enums.FormAction.New);
			ViewManager.ShowViewDialog(newHangMucView);
			if (newHangMucView.GetDialogResult() != DialogResult.OK)
			{
				return;
			}
			this.LoadHangMuc();
			base.FocusRow(this.grvHangMuc, this.grvHangMuc.RowCount);
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x000585D4 File Offset: 0x000567D4
		private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (this.grvHangMuc.RowCount == 0)
			{
				return;
			}
			int focusedRowHandle = this.grvHangMuc.FocusedRowHandle;
			NewHangMucView newHangMucView = new NewHangMucView(this.grvHangMuc.GetRow(focusedRowHandle) as ObjHangMuc, Enums.FormAction.Edit);
			ViewManager.ShowViewDialog(newHangMucView);
			if (newHangMucView.GetDialogResult() != DialogResult.OK)
			{
				return;
			}
			this.LoadHangMuc();
			base.FocusRow(this.grvHangMuc, focusedRowHandle);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00058634 File Offset: 0x00056834
		private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (TramTromMessageBox.ShowYesNoDialog(GlobalValues.Messages.ConfirmDeleteSelectedData) != DialogResult.Yes)
			{
				return;
			}
			BindingList<ObjHangMuc> bindingList = new BindingList<ObjHangMuc>();
			foreach (int num in this.grvHangMuc.GetSelectedRows())
			{
				if (num >= 0)
				{
					ObjHangMuc objHangMuc = this.grvHangMuc.GetRow(num) as ObjHangMuc;
					objHangMuc.Activated = false;
					bindingList.Add(objHangMuc);
					this.LoadHangMuc();
				}
			}
			this._presenter.SaveHangMuc(bindingList);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x000586AC File Offset: 0x000568AC
		private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
		{
			if (this.grvHangMuc.RowCount == 0)
			{
				return;
			}
			ViewManager.ShowViewDialog(new NewHangMucView(this.grvHangMuc.GetRow(this.grvHangMuc.FocusedRowHandle) as ObjHangMuc, Enums.FormAction.View));
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x000586E2 File Offset: 0x000568E2
		private void btnSearch_Click(object sender, EventArgs e)
		{
			this.LoadHangMuc();
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000586EA File Offset: 0x000568EA
		private void btnReset_Click(object sender, EventArgs e)
		{
			this.LoadSearchDefaultValues();
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x000586F4 File Offset: 0x000568F4
		private void BindPermission()
		{
			this.bbiInsert.Enabled = this.CheckHasPermission(this.bbiInsert.Name);
			this.bbiUpdate.Enabled = this.CheckHasPermission(this.bbiUpdate.Name);
			this.bbiDelete.Enabled = this.CheckHasPermission(this.bbiDelete.Name);
			this.bbiView.Enabled = this.CheckHasPermission(this.bbiView.Name);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00058774 File Offset: 0x00056974
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



		// Token: 0x04000703 RID: 1795
		private HangMucMngDataPresenter _presenter;

		// Token: 0x04000704 RID: 1796
		private BindingList<ObjHangMuc> _blstHangMuc = new BindingList<ObjHangMuc>();

		// Token: 0x04000705 RID: 1797
		private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();


	}
}

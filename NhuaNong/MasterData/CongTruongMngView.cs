// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.CongTruongMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class CongTruongMngView : ControlViewBase, ICongTruongMngView, IBase, IPermission
  {
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private CongTruongMngDataPresenter _presenter;
    public BindingList<ObjCongTruong> _blstCongTruong = new BindingList<ObjCongTruong>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set
      {
        this._blstCongTruong = value;
        this.grcCongTruong.DataSource = (object) this._blstCongTruong;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public CongTruongMngView()
    {
      this.InitializeComponent();
      this._presenter = new CongTruongMngDataPresenter((ICongTruongMngView) this);
      this.Caption = this.bsiCaption.Caption;
      // 2. Ngay lập tức ghi đè lại thuộc tính Name bằng giá trị an toàn, sau này sẽ không bị lỗi khi sử dụng Name trong các phương thức khác
      // (ví dụ: khi sử dụng Name trong các phương thức FocusRow, GetDialogResult, v.v.) hoặc khi đổi tên lớp thì chương trình vẫn hoạt động bình thường
      this.Name = nameof(CongTruongMngView);
    }

    protected override void PopulateStaticData()
    {
      this.lueActive.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.ActiveEnum>(true);
      this.LoadSearchDefaultValues();
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
        this.LoadCongTruong();
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.UnsuccessProceed);
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) null;
      this.datToDate.EditValue = (object) Searching.Build_EndDateTime(DateTime.Now);
      this.txtMaCT.Text = this.txtTenCT.Text = this.txtDiaChi.Text = this.txtPhone.Text = string.Empty;
      this.lueActive.EditValue = (object) -1;
    }

    private void LoadCongTruong()
    {
      try
      {
        SplashScreenManager.ShowForm(typeof (NDPWaitForm));
        SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.WAIT_CAPTION);
        SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
        if (Convert.ToInt32(this.lueActive.EditValue) != 1)
          Convert.ToInt32(this.lueActive.EditValue);
        this._presenter.ListCongTruong_ByCondition(new DateTime?(this.datFromDate.DateTime), new DateTime?(this.datToDate.DateTime), this.txtMaCT.Text, this.txtTenCT.Text, this.txtDiaChi.Text, this.txtPhone.Text, new bool?(true));
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowDEPErrorDialog(ex);
        TramTronLogger.WriteError(ex);
      }
      finally
      {
        SplashScreenManager.CloseForm();
      }
    }

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewCongTruongView ctrView = new NewCongTruongView((ObjCongTruong) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadCongTruong();
      this.FocusRow(this.grvCongTruong, this.grvCongTruong.RowCount);
    }

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadCongTruong();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvCongTruong.RowCount == 0)
        return;
      int focusedRowHandle = this.grvCongTruong.FocusedRowHandle;
      NewCongTruongView ctrView = new NewCongTruongView(this.grvCongTruong.GetRow(focusedRowHandle) as ObjCongTruong, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadCongTruong();
      this.FocusRow(this.grvCongTruong, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (TramTromMessageBox.ShowYesNoDialog(GlobalValues.Messages.ConfirmDeleteSelectedData) != DialogResult.Yes)
        return;
      BindingList<ObjCongTruong> blstCT = new BindingList<ObjCongTruong>();
      foreach (int selectedRow in this.grvCongTruong.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjCongTruong row = this.grvCongTruong.GetRow(selectedRow) as ObjCongTruong;
          row.Activated = false;
          blstCT.Add(row);
          this.LoadCongTruong();
        }
      }
      this._presenter.SaveCongTruong(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvCongTruong.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewCongTruongView(this.grvCongTruong.GetRow(this.grvCongTruong.FocusedRowHandle) as ObjCongTruong, Enums.FormAction.View));
    }

    private void BindPermission()
    {
      this.bbiInsert.Enabled = this.CheckHasPermission(this.bbiInsert.Name);
      this.bbiUpdate.Enabled = this.CheckHasPermission(this.bbiUpdate.Name);
      this.bbiDelete.Enabled = this.CheckHasPermission(this.bbiDelete.Name);
      this.bbiView.Enabled = this.CheckHasPermission(this.bbiView.Name);
    }

    private bool CheckHasPermission(string funcName)
    {
      foreach (ObjSEC_Function objSecFunction in this._lstFunction)
      {
        if (objSecFunction.MenuName == funcName)
          return true;
      }
      return false;
    }

    
  }
}

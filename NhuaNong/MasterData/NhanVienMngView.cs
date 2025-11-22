// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NhanVienMngView
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
  public partial class NhanVienMngView : ControlViewBase, INhanVienMngView, IBase, IPermission
  {
    private NhanVienMngDataPresenter _presenter;
    private BindingList<ObjNhanVien> _blstNhanVien = new BindingList<ObjNhanVien>();
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public NhanVienMngView()
    {
      this.InitializeComponent();
      this.Name = nameof(NhanVienMngView);
      this._presenter = new NhanVienMngDataPresenter((INhanVienMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjNhanVien> BLstNhanVien
    {
      set
      {
        this._blstNhanVien = value;
        this.grcNhanVien.DataSource = (object) this._blstNhanVien;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void PopulateStaticData()
    {
      this.lueActive.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.ActiveEnum>(true);
      this.LoadSearchDefaultValues();
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
        this.LoadNhanVien();
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.UnsuccessProceed);
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) null;
      this.datToDate.EditValue = (object) Searching.Build_EndDateTime(DateTime.Now);
      this.txtMaNV.Text = this.txtTenNV.Text = this.txtPhone.Text = string.Empty;
      this.lueActive.EditValue = (object) -1;
    }

    private void LoadNhanVien()
    {
      try
      {
        SplashScreenManager.ShowForm(typeof (NDPWaitForm));
        SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.WAIT_CAPTION);
        SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
        if (Convert.ToInt32(this.lueActive.EditValue) != 1)
          Convert.ToInt32(this.lueActive.EditValue);
        this._presenter.ListNhanVien_ByCondition(new DateTime?(this.datFromDate.DateTime), new DateTime?(this.datToDate.DateTime), this.txtMaNV.Text, this.txtTenNV.Text, this.txtPhone.Text, new bool?(true));
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
      NewNhanVienView ctrView = new NewNhanVienView((ObjNhanVien) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadNhanVien();
      this.FocusRow(this.grvNhanVien, this.grvNhanVien.RowCount);
    }

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvNhanVien.RowCount == 0)
        return;
      int focusedRowHandle = this.grvNhanVien.FocusedRowHandle;
      NewNhanVienView ctrView = new NewNhanVienView(this.grvNhanVien.GetRow(focusedRowHandle) as ObjNhanVien, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadNhanVien();
      this.FocusRow(this.grvNhanVien, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (TramTromMessageBox.ShowYesNoDialog(GlobalValues.Messages.ConfirmDeleteSelectedData) != DialogResult.Yes)
        return;
      BindingList<ObjNhanVien> blstCT = new BindingList<ObjNhanVien>();
      foreach (int selectedRow in this.grvNhanVien.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjNhanVien row = this.grvNhanVien.GetRow(selectedRow) as ObjNhanVien;
          row.Activated = false;
          blstCT.Add(row);
          this.LoadNhanVien();
        }
      }
      this._presenter.SaveNhanVien(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvNhanVien.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewNhanVienView(this.grvNhanVien.GetRow(this.grvNhanVien.FocusedRowHandle) as ObjNhanVien, Enums.FormAction.View));
    }

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadNhanVien();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

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

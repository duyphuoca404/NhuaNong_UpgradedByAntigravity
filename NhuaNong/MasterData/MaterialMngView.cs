// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.MaterialMngView
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
  public partial class MaterialMngView : ControlViewBase, IMaterialMngView, IBase, IPermission
  {
    private MaterialMngDataPresenter _presenter;
    private BindingList<ObjMaterial> _blstMaterial = new BindingList<ObjMaterial>();
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public MaterialMngView()
    {
      this.InitializeComponent();
      this._presenter = new MaterialMngDataPresenter((IMaterialMngView) this);
      this.Caption = this.bsiCaption.Caption;
      this.Name = nameof(MaterialMngView);
    }

    public BindingList<ObjMaterial> BLstMaterial
    {
      set
      {
        this._blstMaterial = value;
        this.grcMaterial.DataSource = (object) this._blstMaterial;
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
        this.LoadMaterial();
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.UnsuccessProceed);
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) null;
      this.datToDate.EditValue = (object) Searching.Build_EndDateTime(DateTime.Now);
      this.txtMaVT.Text = this.txtTenVT.Text = string.Empty;
      this.lueActive.EditValue = (object) -1;
    }

    private void LoadMaterial()
    {
      try
      {
        SplashScreenManager.ShowForm(typeof (NDPWaitForm));
        SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.WAIT_CAPTION);
        SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
        if (Convert.ToInt32(this.lueActive.EditValue) != 1)
          Convert.ToInt32(this.lueActive.EditValue);
        this._presenter.ListMaterial_ByCondition(new DateTime?(this.datFromDate.DateTime), new DateTime?(this.datToDate.DateTime), this.txtMaVT.Text, this.txtTenVT.Text, new bool?(true));
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

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadMaterial();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewMaterialView ctrView = new NewMaterialView((ObjMaterial) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadMaterial();
      this.FocusRow(this.grvMaterial, this.grvMaterial.RowCount);
    }

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvMaterial.RowCount == 0)
        return;
      int focusedRowHandle = this.grvMaterial.FocusedRowHandle;
      NewMaterialView ctrView = new NewMaterialView(this.grvMaterial.GetRow(focusedRowHandle) as ObjMaterial, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadMaterial();
      this.FocusRow(this.grvMaterial, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (TramTromMessageBox.ShowYesNoDialog(GlobalValues.Messages.ConfirmDeleteSelectedData) != DialogResult.Yes)
        return;
      BindingList<ObjMaterial> blstCT = new BindingList<ObjMaterial>();
      foreach (int selectedRow in this.grvMaterial.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjMaterial row = this.grvMaterial.GetRow(selectedRow) as ObjMaterial;
          row.Activated = false;
          blstCT.Add(row);
          this.LoadMaterial();
        }
      }
      this._presenter.SaveMaterial(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvMaterial.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewMaterialView(this.grvMaterial.GetRow(this.grvMaterial.FocusedRowHandle) as ObjMaterial, Enums.FormAction.View));
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

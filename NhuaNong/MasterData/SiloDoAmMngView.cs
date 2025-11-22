// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.SiloDoAmMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data.Filtering;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class SiloDoAmMngView : ControlViewBase, ISiloDoAmMngView, IBase, IPermission
  {
    private SiloDoAmMngDataPresenter _presenter;
    private BindingList<ObjSilo> _blstSiloDoAm = new BindingList<ObjSilo>();
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public SiloDoAmMngView()
    {
      this.InitializeComponent();
      this.Name = nameof(SiloDoAmMngView);
      this._presenter = new SiloDoAmMngDataPresenter((ISiloDoAmMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjSilo> BLstSiloDoAm
    {
      set
      {
        this._blstSiloDoAm = value;
        this.grcData.DataSource = (object) this._blstSiloDoAm;
        this.ilueSoiTrongCat_TruVaoSilo.DataSource = (object) this._blstSiloDoAm;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void InitLayout()
    {
      this.grvData.ActiveFilterCriteria = (CriteriaOperator) new BinaryOperator("MarkAsDeleted", false);
    }

    protected override void PopulateData() => this._presenter.ListSiloDoAm();

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessProceed);
    }

    private void ibtnTinhDoHutNuoc_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Kind == ButtonPredefines.Ellipsis)
      {
        TinhDoHutNuocMngView ctrView = new TinhDoHutNuocMngView();
        ctrView.ShowGroupStatus = true;
        ViewManager.ShowViewDialog((ControlViewBase) ctrView);
        if (!ctrView.Choosed || ctrView.SelectedTinhDoHutNuoc == null)
          return;
        ObjSilo row = this.grvData.GetRow(this.grvData.FocusedRowHandle) as ObjSilo;
        row.TinhDoHutNuocName = ctrView.SelectedTinhDoHutNuoc.Name;
        row.TinhDoHutNuocID = new int?(ctrView.SelectedTinhDoHutNuoc.TinhDoHutNuocID);
        row.DoHutNuoc_NhomSiloAgg = new Decimal?(ctrView.SelectedTinhDoHutNuoc.DoHutNuoc);
        this.grvData.RefreshRow(this.grvData.FocusedRowHandle);
      }
      else
      {
        if (e.Button.Kind != ButtonPredefines.Delete || TramTromMessageBox.ShowYesNoDialog("Không sử dụng công thức tính độ hút nước?") != DialogResult.Yes)
          return;
        ObjSilo row = this.grvData.GetRow(this.grvData.FocusedRowHandle) as ObjSilo;
        row.TinhDoHutNuocName = (string) null;
        row.TinhDoHutNuocID = new int?();
        row.DoHutNuoc_NhomSiloAgg = new Decimal?(0M);
        this.grvData.RefreshRow(this.grvData.FocusedRowHandle);
      }
    }

    private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.grvData.PostEditor();
      this._presenter.SaveSiloDoAm(this._blstSiloDoAm);
    }

    private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
    {
      this._presenter.ListSiloDoAm();
    }

    private void BindPermission()
    {
      this.bbiSave.Enabled = this.CheckHasPermission(this.bbiSave.Name);
      this.bbiRefresh.Enabled = this.CheckHasPermission(this.bbiRefresh.Name);
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

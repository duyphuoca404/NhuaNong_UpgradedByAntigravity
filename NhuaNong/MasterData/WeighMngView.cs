// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.WeighMngView
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
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class WeighMngView : ControlViewBase, IWeighMngView, IBase, IPermission
  {
    private BindingList<ObjWeigh> _blstWeigh = new BindingList<ObjWeigh>();
    private WeighMngDataPresenter _presenter;
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public WeighMngView()
    {
      this.InitializeComponent();
      this.Name = nameof(WeighMngView);
      this._presenter = new WeighMngDataPresenter((IWeighMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjWeigh> BLstWeigh
    {
      set
      {
        this._blstWeigh = value;
        this.grcData.DataSource = (object) this._blstWeigh;
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

    protected override void PopulateData() => this._presenter.ListWeigh();

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
        TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessSavingData);
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.ErrorSavingData);
    }

    private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      this.grvData.PostEditor();
      this._presenter.SaveWeigh(this._blstWeigh);
    }

    private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
    {
      this._presenter.ListWeigh();
    }

    private void grcData_ProcessGridKey(object sender, KeyEventArgs e)
    {
      if (!e.Control || e.KeyCode != Keys.Delete)
        return;
      foreach (int selectedRow in this.grvData.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjWeigh row = this.grvData.GetRow(selectedRow) as ObjWeigh;
          if (row.IsNewObject)
            this._blstWeigh.Remove(row);
          else
            row.MarkAsDeleted = true;
        }
      }
      this.grvData.RefreshData();
    }

    private void BindPermission()
    {
      this.bbiSave.Enabled = this._lstFunction.Where<ObjSEC_Function>((Func<ObjSEC_Function, bool>) (o => o.FunctionCode == "SaveWeigh")).FirstOrDefault<ObjSEC_Function>() != null;
      this.bbiRefresh.Enabled = this._lstFunction.Where<ObjSEC_Function>((Func<ObjSEC_Function, bool>) (o => o.FunctionCode == "RefreshWeigh")).FirstOrDefault<ObjSEC_Function>() != null;
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

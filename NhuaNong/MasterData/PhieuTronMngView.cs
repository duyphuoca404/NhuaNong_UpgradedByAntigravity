// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.PhieuTronMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
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
  public partial class PhieuTronMngView : ControlViewBase, IPhieuTronMngView, IBase, IPermission
  {
    private PhieuTronMngDataPresenter _presenter;
    private int? _searchStatus = new int?(-1);
    private bool _useAsSearching;
    private BindingList<ObjPhieuTron> _blstPhieuTron = new BindingList<ObjPhieuTron>();
    private BindingList<ObjHopDong> _blstHopDong = new BindingList<ObjHopDong>();
    private List<FieldCode> _lstPhieuTronStatus = new List<FieldCode>();
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public PhieuTronMngView()
    {
      this.InitializeComponent();
      this.Name = nameof(PhieuTronMngView);
      this._presenter = new PhieuTronMngDataPresenter((IPhieuTronMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    public int? SearchStatus
    {
      set
      {
        if (!value.HasValue)
          value = new int?(-1);
        this._searchStatus = value;
        this.luePTStatus.EditValue = (object) value;
      }
    }

    public bool UseAsSearching
    {
      set
      {
        this._useAsSearching = value;
        this.barButtons.Visible = !this._useAsSearching;
      }
    }

    public BindingList<ObjPhieuTron> BLstPhieuTron
    {
      set
      {
        this._blstPhieuTron = value;
        this.grcPhieuTron.DataSource = (object) this._blstPhieuTron;
      }
    }

    public BindingList<ObjHopDong> BLstHopDong
    {
      set
      {
        this._blstHopDong = value;
        this.ilueMaHopDong.DataSource = (object) this._blstHopDong;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public List<FieldCode> LstPhieuTronStatus
    {
      set
      {
        this._lstPhieuTronStatus = value;
        this.iluePTStatus.DataSource = (object) this._lstPhieuTronStatus;
        this.luePTStatus.Properties.DataSource = (object) this._lstPhieuTronStatus;
      }
    }

    public BindingList<ObjMeTron> BLstMeTron
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjMeTronChiTiet> BLstMeTronChiTiet
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjPhieuGiaoHang> BLstPhieuGiaoHang
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjMeTronChiTietGiaoHang> BLstMeTronChiTietGiaoHang
    {
      set => throw new NotImplementedException();
    }

    protected override void PopulateStaticData()
    {
      this._presenter.ListHopDong();
      this.LoadPTStatus();
      this.LoadSearchDefaultValues();
    }

    protected override void PopulateData() => this.LoadPhieuTron();

    public override List<T> GetSelectedObjects<T>()
    {
      List<T> selectedObjects = new List<T>();
      foreach (int selectedRow in this.grvPhieuTron.GetSelectedRows())
      {
        T row = (T) this.grvPhieuTron.GetRow(selectedRow);
        selectedObjects.Add(row);
      }
      return selectedObjects;
    }

    private void LoadSearchDefaultValues()
    {
      this.datTuNgay.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestPhieuTronDays);
      this.datDenNgay.EditValue = (object) DateTime.Now;
      this.txtMaPhieuTron.Text = string.Empty;
      this.luePTStatus.EditValue = (object) -1;
    }

    private void LoadPTStatus() => this._presenter.ListPhieuTronStatus();

    private void LoadPhieuTron()
    {
      this._presenter.ListPhieuTron(this.txtMaPhieuTron.Text, Searching.Build_StartDateTime(this.datTuNgay.DateTime), Searching.Build_EndDateTime(this.datDenNgay.DateTime), (int?) this.luePTStatus.EditValue, new bool?());
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      this.grvPhieuTron.RefreshData();
    }

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadPhieuTron();

    private void btnReset_Click(object sender, EventArgs e)
    {
      this.LoadSearchDefaultValues();
      this.LoadPhieuTron();
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvPhieuTron.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewPhieuTronView(this.grvPhieuTron.GetRow(this.grvPhieuTron.FocusedRowHandle) as ObjPhieuTron, Enums.FormAction.View));
    }

    private void BindPermission()
    {
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

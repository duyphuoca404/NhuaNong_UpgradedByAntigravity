// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.SiloMngView
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
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class SiloMngView : ControlViewBase, ISiloMngView, IBase, IPermission
  {
    private SiloMngDataPresenter _presenter;
    private SerialPort _sPort;
    private BindingList<ObjSilo> _blstSilo = new BindingList<ObjSilo>();
    private BindingList<ObjNhomSilo> _blstNhomSilo = new BindingList<ObjNhomSilo>();
    private bool _showDoAm;
    private bool _showKLCanMinMax;
    private bool _showMaterial;
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public SiloMngView(SerialPort sPort)
    {
      this.InitializeComponent();
      this.Name = nameof(SiloMngView);
      this._presenter = new SiloMngDataPresenter((ISiloMngView) this);
      this._sPort = sPort;
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjSilo> BLstSilo
    {
      set
      {
        this._blstSilo = value;
        this.grcSilo.DataSource = (object) this._blstSilo;
        this.graSilo.ExpandAllGroups();
      }
    }

    public BindingList<ObjNhomSilo> BLstNhomSilo
    {
      set
      {
        this._blstNhomSilo = value;
        this.ilueNhomSilo.DataSource = (object) this._blstNhomSilo;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void PopulateStaticData() => this._presenter.ListNhomSilo();

    protected override void PopulateData() => this._presenter.ListSilo();

    private void SuccessfullySave(bool isSuccess)
    {
    }

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewSiloView ctrView = new NewSiloView((ObjSilo) null, Enums.FormAction.New, false, true, this._showKLCanMinMax);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListSilo();
      this.FocusRow(this.graSilo, this.graSilo.RowCount);
    }

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.graSilo.RowCount == 0)
        return;
      int focusedRowHandle = this.graSilo.FocusedRowHandle;
      this._blstSilo.Where<ObjSilo>((Func<ObjSilo, bool>) (o => o.MaSilo == (this.graSilo.GetRow(focusedRowHandle) as ObjSilo).MaSilo)).First<ObjSilo>();
      this._showDoAm = false;
      if ((this.graSilo.GetRow(focusedRowHandle) as ObjSilo).MaSilo.Contains("Agg"))
        this._showDoAm = true;
      NewSiloView ctrView = new NewSiloView(this.graSilo.GetRow(focusedRowHandle) as ObjSilo, Enums.FormAction.Edit, true, this._showDoAm, this._showKLCanMinMax);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListSilo();
      this.FocusRow(this.graSilo, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      BindingList<ObjSilo> blstCT = new BindingList<ObjSilo>();
      foreach (int selectedRow in this.graSilo.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjSilo row = this.graSilo.GetRow(selectedRow) as ObjSilo;
          row.MarkAsDeleted = true;
          blstCT.Add(row);
        }
      }
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) blstCT)
        this._blstSilo.Remove(objSilo);
      this.FocusRow(this.graSilo, this.graSilo.RowCount);
      this._presenter.SaveSilo(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.graSilo.RowCount == 0)
        return;
      this._blstSilo.Where<ObjSilo>((Func<ObjSilo, bool>) (o => o.MaSilo == (this.graSilo.GetRow(this.graSilo.FocusedRowHandle) as ObjSilo).MaSilo)).First<ObjSilo>();
      this._showDoAm = false;
      if ((this.graSilo.GetRow(this.graSilo.FocusedRowHandle) as ObjSilo).MaSilo.Contains("Agg"))
        this._showDoAm = true;
      ViewManager.ShowViewDialog((ControlViewBase) new NewSiloView(this.graSilo.GetRow(this.graSilo.FocusedRowHandle) as ObjSilo, Enums.FormAction.View, true, this._showDoAm, this._showKLCanMinMax));
    }

    private void BindPermission()
    {
      this.bbiInsert.Enabled = this.CheckHasPermission(this.bbiInsert.Name);
      this.bbiUpdate.Enabled = this.CheckHasPermission(this.bbiUpdate.Name);
      this.bbiDelete.Enabled = this.CheckHasPermission(this.bbiDelete.Name);
      this.bbiView.Enabled = this.CheckHasPermission(this.bbiView.Name);
      this._showKLCanMinMax = this.CheckHasPermission("ShowKLCanMinMax");
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

// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.TimerParaMngView
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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class TimerParaMngView : ControlViewBase, ITimerParaMngView, IBase, IPermission
  {
    private TimerParaMngDataPresenter _presenter;
    private BindingList<ObjTimerPara> _blstTimerPara = new BindingList<ObjTimerPara>();
    private List<ObjTimerPara> _listTimer = new List<ObjTimerPara>();
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public TimerParaMngView()
    {
      this.InitializeComponent();
      this.Name = nameof(TimerParaMngView);
      this._presenter = new TimerParaMngDataPresenter((ITimerParaMngView) this);
      this.Caption = this.bsiCaption.Caption;
    }

    public BindingList<ObjTimerPara> BLstTimerPara
    {
      set
      {
        this._blstTimerPara = value;
        this._listTimer.Add(this._blstTimerPara[0]);
        this._listTimer.Add(this._blstTimerPara[1]);
        this._listTimer.Add(this._blstTimerPara[2]);
        this._listTimer.Add(this._blstTimerPara[4]);
        this._listTimer.Add(this._blstTimerPara[5]);
        this._listTimer.Add(this._blstTimerPara[6]);
        this._listTimer.Add(this._blstTimerPara[7]);
        this._listTimer.Add(this._blstTimerPara[8]);
        this._listTimer.Add(this._blstTimerPara[9]);
        this._listTimer.Add(this._blstTimerPara[10]);
        this._listTimer.Add(this._blstTimerPara[11]);
        this._listTimer.Add(this._blstTimerPara[12]);
        this._listTimer.Add(this._blstTimerPara[13]);
        this._listTimer.Add(this._blstTimerPara[14]);
        this._listTimer.Add(this._blstTimerPara[15]);
        this._listTimer.Add(this._blstTimerPara[16]);
        this._listTimer.Add(this._blstTimerPara[17]);
        this.grcData.DataSource = (object) this._listTimer;
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

    protected override void PopulateData() => this._presenter.ListTimerPara();

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
      {
        TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessSavingData);
        this._dlgRes = DialogResult.OK;
        this.Close();
      }
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.ErrorSavingData);
    }

    private void grcData_ProcessGridKey(object sender, KeyEventArgs e)
    {
      if (!e.Control || e.KeyCode != Keys.Delete)
        return;
      foreach (int selectedRow in this.grvData.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjTimerPara row = this.grvData.GetRow(selectedRow) as ObjTimerPara;
          if (row.IsNewObject)
            this._blstTimerPara.Remove(row);
          else
            row.MarkAsDeleted = true;
        }
      }
      this.grvData.RefreshData();
    }

    private void bbiSaveTimer_ItemClick(object sender, ItemClickEventArgs e)
    {
      foreach (ObjTimerPara objTimerPara in (Collection<ObjTimerPara>) this._blstTimerPara)
      {
        if (string.IsNullOrEmpty(objTimerPara.TimerParaCode))
        {
          TramTromMessageBox.ShowDEPErrorDialog(GlobalValues.Messages.ThieuMaThongSoThoiGian);
          return;
        }
      }
      this.grvData.PostEditor();
      this._presenter.SaveTimerPara(this._blstTimerPara);
    }

    private void bbiRefreshTimer_ItemClick(object sender, ItemClickEventArgs e)
    {
      this._presenter.ListTimerPara();
    }

    private void bbiPLCTimer_ItemClick(object sender, ItemClickEventArgs e)
    {
    }

    private void BindPermission()
    {
      this.bbiSaveTimer.Enabled = this.CheckHasPermission(this.bbiSaveTimer.Name);
      this.bbiRefreshTimer.Enabled = this.CheckHasPermission(this.bbiRefreshTimer.Name);
      this.bbiPLCTimer.Enabled = this.CheckHasPermission(this.bbiPLCTimer.Name);
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

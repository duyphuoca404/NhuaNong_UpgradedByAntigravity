// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.HopDongMngView
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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class HopDongMngView : ControlViewBase, IHopDongMngView, IBase, IPermission
  {
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private HopDongMngDataPresenter _presenter;
    private int? _searchStatus = new int?(-1);
    private bool _useAsSearching;
    private BindingList<ObjHopDong> _blstHopDong = new BindingList<ObjHopDong>();
    private BindingList<ObjKhachHang> _blstKhachHang = new BindingList<ObjKhachHang>();
    private BindingList<ObjCongTruong> _blstCongTruong = new BindingList<ObjCongTruong>();
    private BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    private List<FieldCode> _lstHopDongStatus = new List<FieldCode>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    //public HopDongMngView()
    //{
    //  try
    //  {
    //    this.InitializeComponent();
    //    this._presenter = new HopDongMngDataPresenter((IHopDongMngView) this);
    //    this.Caption = this.bsiCaption.Caption;
    //  }
    //  catch (System.Exception ex)
    //  {
    //    int num = (int) MessageBox.Show(ex.Message);
    //  }
    //}

    public HopDongMngView()
    {
      this.InitializeComponent();
      this.Name = nameof(HopDongMngView);

      // THÊM "LÁ CHẮN" NÀY VÀO, MỤC ĐÍCH LÀ CHỈ CHẠY KHI NÓ KHÔNG Ở CHẾ ĐỘ THIẾT KẾ, NHƯng NẾU Ở CHẾ ĐỘ THIẾT KẾ THÌ SẼ KHÔNG CÓ GÌ XẢY RA
      if (!this.DesignMode)
      {
        try
        {
          this._presenter = new HopDongMngDataPresenter((IHopDongMngView)this);
          this.Caption = this.bsiCaption.Caption;
        }
        catch (System.Exception ex)
        {
          int num = (int)MessageBox.Show(ex.Message);
        }
      }
    }

    public int? SearchStatus
    {
      set
      {
        if (!value.HasValue)
          value = new int?(-1);
        this._searchStatus = value;
        this.lueHDStatus.EditValue = (object) value;
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

    public BindingList<ObjHopDong> BLstHopDong
    {
      set
      {
        this._blstHopDong = value;
        this.grcHopDong.DataSource = (object) this._blstHopDong;
      }
    }

    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set
      {
        this._blstKhachHang = value;
        this.lueKhachHang.Properties.DataSource = (object) this._blstKhachHang;
        this.illueKhachHang.DataSource = (object) this._blstKhachHang;
      }
    }

    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set
      {
        this._blstCongTruong = value;
        this.lueCongTruong.Properties.DataSource = (object) this._blstCongTruong;
        this.ilueCongTruong.DataSource = (object) this._blstCongTruong;
      }
    }

    public BindingList<ObjMAC> BLstMAC
    {
      set
      {
        this._blstMAC = value;
        this.lueMAC.Properties.DataSource = (object) this._blstMAC;
        this.ilueMAC.DataSource = (object) this._blstMAC;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public List<FieldCode> LstHopDongStatus
    {
      set
      {
        this._lstHopDongStatus = value;
        this.ilueHDStatus.DataSource = (object) this._lstHopDongStatus;
        this.lueHDStatus.Properties.DataSource = (object) this._lstHopDongStatus;
      }
    }

    protected override void PopulateStaticData()
    {
      this._presenter.ListKhachHang();
      this._presenter.ListCongTruong();
      this._presenter.ListMAC();
      this.LoadHDStatus();
      this.LoadSearchDefaultValues();
    }

    protected override void PopulateData() => this.LoadHopDong();

    protected override void AdjustCulture()
    {
    }

    public override List<T> GetSelectedObjects<T>()
    {
      List<T> selectedObjects = new List<T>();
      foreach (int selectedRow in this.grvHopDong.GetSelectedRows())
      {
        T row = (T) this.grvHopDong.GetRow(selectedRow);
        selectedObjects.Add(row);
      }
      return selectedObjects;
    }

    private void LoadHopDong()
    {
      this._presenter.ListHopDong(this.txtMaHopDong.Text, Searching.Build_StartDateTime(this.datTuNgay.DateTime), Searching.Build_EndDateTime(this.datDenNgay.DateTime), (int?) this.lueHDStatus.EditValue, (int?) this.lueKhachHang.EditValue, (int?) this.lueCongTruong.EditValue, (int?) this.lueMAC.EditValue);
    }

    private void LoadSearchDefaultValues()
    {
      this.datTuNgay.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestHopDongDays);
      this.datDenNgay.EditValue = (object) DateTime.Now;
      this.txtMaHopDong.Text = string.Empty;
      this.lueHDStatus.EditValue = (object) this._searchStatus;
      this.lueKhachHang.EditValue = (object) null;
      this.lueCongTruong.EditValue = (object) null;
      this.lueMAC.EditValue = (object) null;
    }

    private void LoadHDStatus() => this._presenter.ListHopDongStatus();

    private void SuccessfullySave(bool isSuccess)
    {
    }

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadHopDong();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewHopDongView ctrView = new NewHopDongView((ObjHopDong) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListHopDong();
      this.FocusRow(this.grvHopDong, this.grvHopDong.RowCount);
    }

    private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvHopDong.RowCount == 0)
        return;
      int focusedRowHandle = this.grvHopDong.FocusedRowHandle;
      NewHopDongView ctrView = new NewHopDongView(this.grvHopDong.GetRow(focusedRowHandle) as ObjHopDong, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListHopDong();
      this.FocusRow(this.grvHopDong, focusedRowHandle);
    }

    private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
    {
      BindingList<ObjHopDong> blstCT = new BindingList<ObjHopDong>();
      foreach (int selectedRow in this.grvHopDong.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjHopDong row = this.grvHopDong.GetRow(selectedRow) as ObjHopDong;
          row.MarkAsDeleted = true;
          blstCT.Add(row);
        }
      }
      foreach (ObjHopDong objHopDong in (Collection<ObjHopDong>) blstCT)
        this._blstHopDong.Remove(objHopDong);
      this.FocusRow(this.grvHopDong, this.grvHopDong.RowCount);
      this._presenter.SaveHopDong(blstCT);
    }

    private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvHopDong.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewHopDongView(this.grvHopDong.GetRow(this.grvHopDong.FocusedRowHandle) as ObjHopDong, Enums.FormAction.View));
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

    private void barButtonItem1_ItemClick_1(object sender, ItemClickEventArgs e)
    {
      if (this.grvHopDong.RowCount == 0)
        return;
      int focusedRowHandle = this.grvHopDong.FocusedRowHandle;
      NewPhieuTronView ctrView = new NewPhieuTronView(this.grvHopDong.GetRow(focusedRowHandle) as ObjHopDong, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListHopDong();
      this.FocusRow(this.grvHopDong, focusedRowHandle);
    }

    
  }
}

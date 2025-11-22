// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.KhachHangMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Svg;
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
  public partial class KhachHangMngView : ControlViewBase, IKhachHangMngView, IBase, IPermission
  {
    private List<ObjSEC_Function> _lstFunction = new List<ObjSEC_Function>();
    private KhachHangMngDataPresenter _presenter;
    private BindingList<ObjKhachHang> _blstKhachHang = new BindingList<ObjKhachHang>();
    

    public List<ObjSEC_Function> LstFunction
    {
      set
      {
        this._lstFunction = value;
        this.BindPermission();
      }
    }

    public KhachHangMngView()
    {
      this.InitializeComponent();
      //this.Load += new EventHandler(this.KhachHangMngView_Load);
    }
    private void KhachHangMngView_Load(object sender, EventArgs e)
    {
      //ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KhachHangMngView));
      //// Lệnh này sẽ gán các thuộc tính hình ảnh cho các nút trên thanh công cụ
      //this.bbiUpdate.ImageOptions.LargeImage = (Image)componentResourceManager.GetObject("bbiUpdate.ImageOptions.LargeImage");
      //this.bbiDelete.ImageOptions.LargeImage = (Image)componentResourceManager.GetObject("bbiDelete.ImageOptions.LargeImage");
      //this.bbiView.ImageOptions.Image = (Image)componentResourceManager.GetObject("bbiView.ImageOptions.Image");
      //this.bbiView.ImageOptions.LargeImage = (Image)componentResourceManager.GetObject("bbiView.ImageOptions.LargeImage");
      //this.bsiCaption.ImageOptions.SvgImage = (SvgImage)componentResourceManager.GetObject("bsiCaption.ImageOptions.SvgImage");


      this._presenter = new KhachHangMngDataPresenter((IKhachHangMngView)this);
      this.Caption = "Khách hàng";
      this.Name = nameof(KhachHangMngView);
    }
    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set
      {
        this._blstKhachHang = value;
        this.grcKhachHang.DataSource = (object) this._blstKhachHang;
      }
    }

    protected override void PopulateStaticData()
    {
      this.lueActive.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.ActiveEnum>(true);
      this.LoadSearchDefaultValues();
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
        this.LoadKhachHang();
      else
        TramTromMessageBox.ShowErrorDialog(GlobalValues.Messages.UnsuccessProceed);
    }

    private void bbiInsert_ItemClick(object sender, ItemClickEventArgs e)
    {
      NewKhachHangView ctrView = new NewKhachHangView((ObjKhachHang) null, Enums.FormAction.New);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadKhachHang();
      this.FocusRow(this.grvKhachHang, this.grvKhachHang.RowCount);
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) null;
      this.datToDate.EditValue = (object) Searching.Build_EndDateTime(DateTime.Now);
      this.txtMaKH.Text = this.txtTenKH.Text = this.txtDiaChi.Text = this.txtPhone.Text = string.Empty;
      this.lueActive.EditValue = (object) -1;
    }

    private void LoadKhachHang()
    {
      try
      {
        SplashScreenManager.ShowForm(typeof (NDPWaitForm));
        SplashScreenManager.Default.SetWaitFormCaption(GlobalValues.Messages.WAIT_CAPTION);
        SplashScreenManager.Default.SetWaitFormDescription(GlobalValues.Messages.WAIT_LOADING);
        if (Convert.ToInt32(this.lueActive.EditValue) != 1)
          Convert.ToInt32(this.lueActive.EditValue);
        this._presenter.ListKhachHang_ByCondition(new DateTime?(this.datFromDate.DateTime), new DateTime?(this.datToDate.DateTime), this.txtMaKH.Text, this.txtTenKH.Text, this.txtDiaChi.Text, this.txtPhone.Text, new bool?(true));
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
      finally
      {
        SplashScreenManager.CloseForm();
      }
    }

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadKhachHang();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void bbiUpdate_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvKhachHang.RowCount == 0)
        return;
      int focusedRowHandle = this.grvKhachHang.FocusedRowHandle;
      NewKhachHangView ctrView = new NewKhachHangView(this.grvKhachHang.GetRow(focusedRowHandle) as ObjKhachHang, Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView);
      if (ctrView.GetDialogResult() != DialogResult.OK)
        return;
      this.LoadKhachHang();
      this.FocusRow(this.grvKhachHang, focusedRowHandle);
    }

    private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (TramTromMessageBox.ShowYesNoDialog(GlobalValues.Messages.ConfirmDeleteSelectedData) != DialogResult.Yes)
        return;
      BindingList<ObjKhachHang> blstCT = new BindingList<ObjKhachHang>();
      foreach (int selectedRow in this.grvKhachHang.GetSelectedRows())
      {
        if (selectedRow >= 0)
        {
          ObjKhachHang row = this.grvKhachHang.GetRow(selectedRow) as ObjKhachHang;
          row.Activated = false;
          blstCT.Add(row);
          this.LoadKhachHang();
        }
      }
      this._presenter.SaveKhachHang(blstCT);
    }

    private void bbiView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (this.grvKhachHang.RowCount == 0)
        return;
      ViewManager.ShowViewDialog((ControlViewBase) new NewKhachHangView(this.grvKhachHang.GetRow(this.grvKhachHang.FocusedRowHandle) as ObjKhachHang, Enums.FormAction.View));
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

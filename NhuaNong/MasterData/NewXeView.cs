// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewXeView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class NewXeView : ControlViewBase, INewXeView, IBase
  {
    private NewXeDataPresenter _presenter;
    private string _NewXeCaption = "Thêm Xe";
    private string _EditXeCaption = "Sửa Xe";
    private string _ViewXeCaption = "Xem Xe";
    private ObjXe _xe;
    

    private bool IsSaveClose { get; set; }

    public NewXeView()
    {
      this.InitializeComponent();
      this.Name = nameof(NewXeView);
      this._presenter = new NewXeDataPresenter((INewXeView) this);
    }

    public NewXeView(ObjXe ct, Enums.FormAction action)
      : this()
    {
      this._xe = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    public ObjXe Xe
    {
      set => this._xe = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void SetupLayout() => this.DisableConstrol();

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewXe();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetXeByKey(this._xe.XeID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtBienSo.DataBindings.Clear();
      this.txtBienSo.DataBindings.Add("Text", (object) this._xe, "BienSo");
      this.spnKhoiLuong.DataBindings.Clear();
      this.spnKhoiLuong.DataBindings.Add("EditValue", (object) this._xe, "KhoiLuong");
      this.memGhiChu.DataBindings.Clear();
      this.memGhiChu.DataBindings.Add("Text", (object) this._xe, "GhiChu");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._xe, "Activated");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewXeCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditXeCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewXeCaption;
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtBienSo.Text == string.Empty)
      {
        this.txtBienSo.ErrorText = GlobalValues.Messages.BienSoXeIsRequired;
        flag = false;
      }
      return flag;
    }

    private void DisableConstrol()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.Edit:
          this.btnSaveNew.Visible = false;
          break;
        case Enums.FormAction.View:
          this.txtBienSo.Properties.ReadOnly = true;
          this.spnKhoiLuong.Properties.ReadOnly = true;
          this.memGhiChu.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjXe> blstCT = new BindingList<ObjXe>();
      blstCT.Add(this._xe);
      this._presenter.SaveXe(blstCT);
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessProceed);
      this._dlgRes = DialogResult.OK;
      if (this.IsSaveClose)
      {
        this.Close();
      }
      else
      {
        this._presenter.BuildNewXe();
        this.BindData();
      }
    }

    private void btnSaveNew_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = false;
      this.SaveData();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = true;
      this.SaveData();
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    private void spnKhoiLuong_EditValueChanged(object sender, EventArgs e)
    {
      this._xe.KhoiLuong = new Decimal?(this.spnKhoiLuong.Value);
    }

    
  }
}

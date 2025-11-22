// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewTaiXeView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class NewTaiXeView : ControlViewBase, INewTaiXeView, IBase
  {
    private NewTaiXeDataPresenter _presenter;
    private string _NewTaiXeCaption = "Thêm Tài xế";
    private string _EditTaiXeCaption = "Sửa Tài xế";
    private string _ViewTaiXeCaption = "Xem Tài xế";
    private ObjTaiXe _tx;
    

    private bool IsSaveClose { get; set; }

    public NewTaiXeView()
    {
      this.InitializeComponent();
      this.Name = nameof(NewTaiXeView);
      this._presenter = new NewTaiXeDataPresenter((INewTaiXeView) this);
    }

    public NewTaiXeView(ObjTaiXe ct, Enums.FormAction action)
      : this()
    {
      this._tx = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    public ObjTaiXe TaiXe
    {
      set => this._tx = value;
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
          this._presenter.BuildNewTaiXe();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetTaiXeByKey(this._tx.TaiXeID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaTaiXe.DataBindings.Clear();
      this.txtMaTaiXe.DataBindings.Add("Text", (object) this._tx, "MaTaiXe");
      this.txtTenTaiXe.DataBindings.Clear();
      this.txtTenTaiXe.DataBindings.Add("Text", (object) this._tx, "TenTaiXe");
      this.txtPhone.DataBindings.Clear();
      this.txtPhone.DataBindings.Add("Text", (object) this._tx, "Phone");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._tx, "Activated");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewTaiXeCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditTaiXeCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewTaiXeCaption;
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaTaiXe.Text == string.Empty)
      {
        this.txtMaTaiXe.ErrorText = GlobalValues.Messages.MaTaiXeIsRequired;
        flag = false;
      }
      if (this.txtTenTaiXe.Text == string.Empty)
      {
        this.txtTenTaiXe.ErrorText = GlobalValues.Messages.TenTaiXeIsRequired;
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
          this.txtMaTaiXe.Properties.ReadOnly = true;
          this.txtTenTaiXe.Properties.ReadOnly = true;
          this.txtPhone.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjTaiXe> blstCT = new BindingList<ObjTaiXe>();
      blstCT.Add(this._tx);
      this._presenter.SaveTaiXe(blstCT);
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
        this._presenter.BuildNewTaiXe();
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

    
  }
}

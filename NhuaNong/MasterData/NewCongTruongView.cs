// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewCongTruongView
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
  public partial class NewCongTruongView : ControlViewBase, INewCongTruongView, IBase
  {
    private NewCongTruongDataPresenter _presenter;
    private string _NewCongTruongCaption = "Thêm Công trường";
    private string _EditCongTruongCaption = "Sửa Công trường";
    private string _ViewCongTruongCaption = "Xem Công trường";
    private ObjCongTruong _ct;
    

    private bool IsSaveClose { get; set; }

    public ObjCongTruong CongTruong
    {
      set => this._ct = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public NewCongTruongView()
    {
      this.InitializeComponent();
      this.Name = nameof(NewCongTruongView);
      this._presenter = new NewCongTruongDataPresenter((INewCongTruongView) this);
    }

    public NewCongTruongView(ObjCongTruong ct, Enums.FormAction action)
      : this()
    {
      this._ct = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    protected override void SetupLayout() => this.DisableConstrol();

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewCongTruong();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetCongTruongByKey(this._ct.CongTruongID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaCongTruong.DataBindings.Clear();
      this.txtMaCongTruong.DataBindings.Add("Text", (object) this._ct, "MaCongTruong");
      this.txtTenCongTruong.DataBindings.Clear();
      this.txtTenCongTruong.DataBindings.Add("Text", (object) this._ct, "TenCongTruong");
      this.txtDiaChi.DataBindings.Clear();
      this.txtDiaChi.DataBindings.Add("Text", (object) this._ct, "DiaChi");
      this.txtPhone.DataBindings.Clear();
      this.txtPhone.DataBindings.Add("Text", (object) this._ct, "Phone");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._ct, "Activated");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewCongTruongCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditCongTruongCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewCongTruongCaption;
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaCongTruong.Text == string.Empty)
      {
        this.txtMaCongTruong.ErrorText = GlobalValues.Messages.MaCongTruongIsRequired;
        flag = false;
      }
      if (this.txtTenCongTruong.Text == string.Empty)
      {
        this.txtTenCongTruong.ErrorText = GlobalValues.Messages.TenCongTruongIsRequired;
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
          this.txtMaCongTruong.Properties.ReadOnly = true;
          this.txtTenCongTruong.Properties.ReadOnly = true;
          this.txtDiaChi.Properties.ReadOnly = true;
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
      BindingList<ObjCongTruong> blstCT = new BindingList<ObjCongTruong>();
      blstCT.Add(this._ct);
      this._presenter.SaveCongTruong(blstCT);
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
        this._presenter.BuildNewCongTruong();
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
      TramTronLogger.WriteInfo(sender.ToString());
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    
  }
}

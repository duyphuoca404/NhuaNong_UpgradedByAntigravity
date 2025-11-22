// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewHangMucView
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
  public partial class NewHangMucView : ControlViewBase, INewHangMucView, IBase
  {
    private NewHangMucDataPresenter _presenter;
    private string _NewTaiXeCaption = "Thêm Hạng mục";
    private string _EditTaiXeCaption = "Sửa Hạng mục";
    private string _ViewTaiXeCaption = "Xem Hạng mục";
    private ObjHangMuc _hm;
    

    private bool IsSaveClose { get; set; }

    public NewHangMucView()
    {
      this.InitializeComponent();
      this.Name = nameof(NewHangMucView);
      this._presenter = new NewHangMucDataPresenter((INewHangMucView) this);
    }

    public NewHangMucView(ObjHangMuc ct, Enums.FormAction action)
      : this()
    {
      this._hm = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    public ObjHangMuc HangMuc
    {
      set => this._hm = value;
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
          this._presenter.BuildNewHangMuc();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetHangMucByKey(this._hm.HangMucID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaHangMuc.DataBindings.Clear();
      this.txtMaHangMuc.DataBindings.Add("Text", (object) this._hm, "MaHangMuc");
      this.txtTenHangMuc.DataBindings.Clear();
      this.txtTenHangMuc.DataBindings.Add("Text", (object) this._hm, "TenHangMuc");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._hm, "Activated");
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
      if (this.txtMaHangMuc.Text == string.Empty)
      {
        this.txtMaHangMuc.ErrorText = GlobalValues.Messages.MaHangMucIsRequired;
        flag = false;
      }
      if (this.txtTenHangMuc.Text == string.Empty)
      {
        this.txtTenHangMuc.ErrorText = GlobalValues.Messages.TenHangMucIsRequired;
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
          this.txtMaHangMuc.Properties.ReadOnly = true;
          this.txtTenHangMuc.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjHangMuc> blstCT = new BindingList<ObjHangMuc>();
      blstCT.Add(this._hm);
      this._presenter.SaveHangMuc(blstCT);
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
        this._presenter.BuildNewHangMuc();
        this.BindData();
      }
    }

    private void btnSaveNew_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = false;
      this.SaveData();
      TramTronLogger.WriteInfo(sender.ToString());
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

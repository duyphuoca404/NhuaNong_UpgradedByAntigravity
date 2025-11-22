// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewKhachHangView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
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
  public partial class NewKhachHangView : ControlViewBase, INewKhachHangView, IBase
  {
    private NewKhachHangDataPresenter _presenter;
    private string _NewKhachHangCaption = "Thêm Khách hàng";
    private string _EditKhachHangCaption = "Sửa Khách hàng";
    private string _ViewKhachHangCaption = "Xem Khách hàng";
    private ObjKhachHang _ct;
    

    protected bool IsSaveClose { get; set; }

    public ObjKhachHang KhachHang
    {
      set => this._ct = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      int num = (int) MessageBox.Show(GlobalValues.Messages.SuccessProceed);
      this._dlgRes = DialogResult.OK;
      if (this.IsSaveClose)
      {
        this.Close();
      }
      else
      {
        this._presenter.BuildNewKhachHang();
        this.BindData();
      }
    }

    public NewKhachHangView()
    {
      this.InitializeComponent();
      this.Name = nameof(NewKhachHangView);
      this._presenter = new NewKhachHangDataPresenter((INewKhachHangView) this);
    }

    public NewKhachHangView(ObjKhachHang ct, Enums.FormAction action)
      : this()
    {
      this._ct = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewKhachHangCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditKhachHangCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewKhachHangCaption;
          break;
      }
    }

    protected override void SetupLayout() => this.DisableConstrol();

    private void DisableConstrol()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.Edit:
          this.btnSaveNew.Visible = false;
          break;
        case Enums.FormAction.View:
          this.txtMaKhachHang.Properties.ReadOnly = true;
          this.txtTenKhachHang.Properties.ReadOnly = true;
          this.txtDiaChi.Properties.ReadOnly = true;
          this.txtPhone.Properties.ReadOnly = true;
          this.txtEmail.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewKhachHang();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetKhachHangByKey(this._ct.KhachHangID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaKhachHang.DataBindings.Clear();
      this.txtMaKhachHang.DataBindings.Add("Text", (object) this._ct, "MaKhachHang");
      this.txtTenKhachHang.DataBindings.Clear();
      this.txtTenKhachHang.DataBindings.Add("Text", (object) this._ct, "TenKhachHang");
      this.txtDiaChi.DataBindings.Clear();
      this.txtDiaChi.DataBindings.Add("Text", (object) this._ct, "DiaChi");
      this.txtPhone.DataBindings.Clear();
      this.txtPhone.DataBindings.Add("Text", (object) this._ct, "Phone");
      this.txtEmail.DataBindings.Clear();
      this.txtEmail.DataBindings.Add("Text", (object) this._ct, "Email");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._ct, "Activated");
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjKhachHang> blstCT = new BindingList<ObjKhachHang>();
      blstCT.Add(this._ct);
      this._presenter.SaveKhachHang(blstCT);
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaKhachHang.Text == string.Empty)
      {
        this.txtMaKhachHang.ErrorText = GlobalValues.Messages.MaKhachHangIsRequired;
        flag = false;
      }
      if (this.txtTenKhachHang.Text == string.Empty)
      {
        this.txtTenKhachHang.ErrorText = "Nhập lại tên khách hàng";
        flag = false;
      }
      return flag;
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = true;
      this.SaveData();
      TramTronLogger.WriteInfo(sender.ToString());
    }

    private void btnSaveNew_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = false;
      this.SaveData();
      TramTronLogger.WriteInfo(sender.ToString());
    }

    
  }
}

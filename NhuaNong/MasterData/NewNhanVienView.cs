// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewNhanVienView
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
  public partial class NewNhanVienView : ControlViewBase, INewNhanVienView, IBase
  {
    private NewNhanVienDataPresenter _presenter;
    private string _NewTaiXeCaption = "Thêm Nhân viên";
    private string _EditTaiXeCaption = "Sửa Nhân viên";
    private string _ViewTaiXeCaption = "Xem Nhân viên";
    private ObjNhanVien _nv;
    

    private bool IsSaveClose { get; set; }

    public NewNhanVienView()
    {
      this.InitializeComponent();
      this.Name = nameof(NewNhanVienView);
      this._presenter = new NewNhanVienDataPresenter((INewNhanVienView) this);
    }

    public NewNhanVienView(ObjNhanVien ct, Enums.FormAction action)
      : this()
    {
      this._nv = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    public ObjNhanVien NhanVien
    {
      set => this._nv = value;
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
          this._presenter.BuildNewNhanVien();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetNhanVienByKey(this._nv.NhanVienID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaNhanVien.DataBindings.Clear();
      this.txtMaNhanVien.DataBindings.Add("Text", (object) this._nv, "MaNhanVien");
      this.txtTenNhanVien.DataBindings.Clear();
      this.txtTenNhanVien.DataBindings.Add("Text", (object) this._nv, "TenNhanVien");
      this.txtPhone.DataBindings.Clear();
      this.txtPhone.DataBindings.Add("Text", (object) this._nv, "Phone");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._nv, "Activated");
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
      if (this.txtMaNhanVien.Text == string.Empty)
      {
        this.txtMaNhanVien.ErrorText = GlobalValues.Messages.MaNhanVienIsRequired;
        flag = false;
      }
      if (this.txtTenNhanVien.Text == string.Empty)
      {
        this.txtTenNhanVien.ErrorText = GlobalValues.Messages.TenNhanVienIsRequired;
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
          this.txtMaNhanVien.Properties.ReadOnly = true;
          this.txtTenNhanVien.Properties.ReadOnly = true;
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
      BindingList<ObjNhanVien> blstCT = new BindingList<ObjNhanVien>();
      blstCT.Add(this._nv);
      this._presenter.SaveNhanVien(blstCT);
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
        this._presenter.BuildNewNhanVien();
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

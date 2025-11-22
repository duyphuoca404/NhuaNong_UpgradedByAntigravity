// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewTinhDoHutNuocView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
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
  public partial class NewTinhDoHutNuocView : ControlViewBase, INewTinhDoHutNuocView, IBase
  {
    private NewTinhDoHutNuocDataPresenter _presenter;
    private ObjTinhDoHutNuoc _ct;
    private BindingList<ObjNhomSilo> _blstNhomSilo = new BindingList<ObjNhomSilo>();
    

    private bool IsSaveClose { get; set; }

    public ObjTinhDoHutNuoc TinhDoHutNuoc
    {
      set => this._ct = value;
    }

    public BindingList<ObjNhomSilo> BLstNhomSilo
    {
      set
      {
        this._blstNhomSilo = value;
        this.lueNhomSilo.Properties.DataSource = (object) this._blstNhomSilo;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public NewTinhDoHutNuocView()
    {
      this.InitializeComponent();
      this.Name = nameof(NewTinhDoHutNuocView);
      this._presenter = new NewTinhDoHutNuocDataPresenter((INewTinhDoHutNuocView) this);
    }

    public NewTinhDoHutNuocView(ObjTinhDoHutNuoc ct, Enums.FormAction action)
      : this()
    {
      this._ct = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    protected override void SetupLayout() => this.DisableConstrol();

    protected override void PopulateStaticData() => this._presenter.ListNhomSilo();

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewTinhDoHutNuoc();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetTinhDoHutNuocByKey(this._ct.TinhDoHutNuocID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaTinhDoHutNuoc.DataBindings.Clear();
      this.txtMaTinhDoHutNuoc.DataBindings.Add("Text", (object) this._ct, "MaTinhDoHutNuoc");
      this.datNgayTinhDoHut.DataBindings.Clear();
      this.datNgayTinhDoHut.DataBindings.Add("DateTime", (object) this._ct, "NgayTinhDoHut");
      this.lueNhomSilo.DataBindings.Clear();
      this.lueNhomSilo.DataBindings.Add("EditValue", (object) this._ct, "NhomSiloID");
      this.spnDHN.DataBindings.Clear();
      this.spnDHN.DataBindings.Add("EditValue", (object) this._ct, "DoHutNuoc");
      this.txtDesc.DataBindings.Clear();
      this.txtDesc.DataBindings.Add("Text", (object) this._ct, "Description");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = "Thêm Độ Hút Nước";
          break;
        case Enums.FormAction.Edit:
          this.Caption = "Sửa Độ Hút Nước";
          break;
        case Enums.FormAction.View:
          this.Caption = "Độ Hút Nước";
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaTinhDoHutNuoc.Text == string.Empty)
      {
        this.txtMaTinhDoHutNuoc.ErrorText = "Vui lòng nhập [Mã tính ĐHN].";
        flag = false;
      }
      if (this._ct.NhomSiloID <= 0)
      {
        this.lueNhomSilo.ErrorText = "Vui lòng chọn [NVL].";
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
          this.lueNhomSilo.Properties.ReadOnly = true;
          this.txtDesc.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjTinhDoHutNuoc> blstCT = new BindingList<ObjTinhDoHutNuoc>();
      blstCT.Add(this._ct);
      this._presenter.SaveTinhDoHutNuoc(blstCT);
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
        this._presenter.BuildNewTinhDoHutNuoc();
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

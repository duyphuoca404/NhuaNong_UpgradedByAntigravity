// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewSiloView
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
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class NewSiloView : ControlViewBase, INewSiloView, IBase
  {
    private NewSiloDataPresenter _presenter;
    private bool _ShowDoAm;
    private bool _CanSuaTenSilo = true;
    private string _NewSiloCaption = "Thêm Silo";
    private string _EditSiloCaption = "Sửa Silo";
    private string _ViewSiloCaption = "Xem Silo";
    private ObjSilo _sl;
    private BindingList<ObjNhomSilo> _blstNhomSilo = new BindingList<ObjNhomSilo>();
    private BindingList<ObjSilo> _blstSiloNhomAgg = new BindingList<ObjSilo>();
    private BindingList<ObjMaterial> _blstMaterial = new BindingList<ObjMaterial>();
    

    private bool IsSaveClose { get; set; }

    public ObjSilo Silo
    {
      set => this._sl = value;
    }

    public NewSiloView()
    {
      this.InitializeComponent();
      this.Name = nameof(NewSiloView);
      this._presenter = new NewSiloDataPresenter((INewSiloView) this);
    }

    public NewSiloView(
      ObjSilo sl,
      Enums.FormAction action,
      bool canSuaTenSilo,
      bool showDoAm,
      bool showKLCan)
      : this()
    {
      this._sl = sl;
      this.FormAction = action;
      this._CanSuaTenSilo = canSuaTenSilo;
      PanelControl pnlDoAm = this.pnlDoAm;
      this._ShowDoAm = showDoAm;
      int num = showDoAm ? 1 : 0;
      pnlDoAm.Visible = num != 0;
      this.pnlKLCan.Visible = showKLCan;
      this.SetCaption();
    }

    public BindingList<ObjSilo> BLstSiloNhomAgg
    {
      set
      {
        this._blstSiloNhomAgg = value;
        this.lueSiloNhomAgg.Properties.DataSource = (object) this._blstSiloNhomAgg;
      }
    }

    public BindingList<ObjNhomSilo> BLstNhomSilo
    {
      set
      {
        this._blstNhomSilo = value;
        this.lueNhomSilo.Properties.DataSource = (object) this._blstNhomSilo;
      }
    }

    public BindingList<ObjMaterial> BLstMaterial
    {
      set
      {
        this._blstMaterial = value;
        this.lueMaterial.Properties.DataSource = (object) this._blstMaterial;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public bool ShowDoAm => this._ShowDoAm;

    protected override void SetupLayout() => this.DisableConstrol();

    protected override void PopulateStaticData()
    {
      this._presenter.ListNhomSilo();
      this._presenter.ListMaterial();
      this._presenter.ListSiloNhomAgg();
    }

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewSilo();
          break;
        case Enums.FormAction.Edit:
          if (this._ShowDoAm)
            this.lueNhomSilo.ReadOnly = false;
          this._presenter.GetSiloByKey(this._sl.SiloID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaSilo.DataBindings.Clear();
      this.txtMaSilo.DataBindings.Add("Text", (object) this._sl, "MaSilo");
      this.txtTenSilo.DataBindings.Clear();
      this.txtTenSilo.DataBindings.Add("Text", (object) this._sl, "TenSilo");
      this.lueNhomSilo.DataBindings.Clear();
      this.lueNhomSilo.DataBindings.Add("EditValue", (object) this._sl, "NhomSiloID");
      this.lueMaterial.DataBindings.Clear();
      this.lueMaterial.DataBindings.Add("EditValue", (object) this._sl, "MaterialID");
      if (this._ShowDoAm)
      {
        this.spnDoAm.DataBindings.Clear();
        this.spnDoAm.DataBindings.Add("EditValue", (object) this._sl, "DoAm_NhomSlioAgg");
        this.spnDoHutNuoc.DataBindings.Clear();
        this.spnDoHutNuoc.DataBindings.Add("EditValue", (object) this._sl, "DoHutNuoc_NhomSiloAgg");
        this.lueSiloNhomAgg.DataBindings.Clear();
        this.lueSiloNhomAgg.DataBindings.Add("EditValue", (object) this._sl, "SoiTrongCat_TruVaoSilo_NhomSiloAgg");
      }
      this.spnSaiSoDuoi.DataBindings.Clear();
      this.spnSaiSoDuoi.DataBindings.Add("EditValue", (object) this._sl, "SaiSoDuoi");
      this.spnSaiSoTren.DataBindings.Clear();
      this.spnSaiSoTren.DataBindings.Add("EditValue", (object) this._sl, "SaiSoTren");
      this.spnKLCanNhoNhat.DataBindings.Clear();
      this.spnKLCanNhoNhat.DataBindings.Add("EditValue", (object) this._sl, "KLCanNhoNhat");
      this.spnKLCanLonNhat.DataBindings.Clear();
      this.spnKLCanLonNhat.DataBindings.Add("EditValue", (object) this._sl, "KLCanLonNhat");
      this.spnTGNhapNhaOn.DataBindings.Clear();
      this.spnTGNhapNhaOn.DataBindings.Add("EditValue", (object) this._sl, "TGNhapNhaOn");
      this.spnTGNhapNhaOff.DataBindings.Clear();
      this.spnTGNhapNhaOff.DataBindings.Add("EditValue", (object) this._sl, "TGNhapNhaOff");
      this.spnTGKiemTraVatLieuRoi.DataBindings.Clear();
      this.spnTGKiemTraVatLieuRoi.DataBindings.Add("EditValue", (object) this._sl, "TGKiemTraVatLieuRoi");
      this.spnKPulse.DataBindings.Clear();
      this.spnKPulse.DataBindings.Add("EditValue", (object) this._sl, "K_Pulse");
      this.spnKLRoiTrongTGT3.DataBindings.Clear();
      this.spnKLRoiTrongTGT3.DataBindings.Add("EditValue", (object) this._sl, "KLRoi");
      this.chkActivated.DataBindings.Clear();
      this.chkActivated.DataBindings.Add("Checked", (object) this._sl, "Activated");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewSiloCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditSiloCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewSiloCaption;
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtTenSilo.Text == string.Empty)
      {
        this.txtTenSilo.ErrorText = GlobalValues.Messages.SiloCodeIsRequired;
        flag = false;
      }
      if (this.lueMaterial.EditValue == DBNull.Value)
      {
        this.lueMaterial.ErrorText = GlobalValues.Messages.MaterialNameIsRequired;
        flag = false;
      }
      return flag;
    }

    private void DisableConstrol()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          if (this._CanSuaTenSilo)
            break;
          this.txtMaSilo.Properties.ReadOnly = true;
          this.txtTenSilo.Properties.ReadOnly = true;
          break;
        case Enums.FormAction.Edit:
          if (this._CanSuaTenSilo)
            break;
          this.txtMaSilo.Properties.ReadOnly = true;
          this.txtTenSilo.Properties.ReadOnly = true;
          break;
        case Enums.FormAction.View:
          this.txtMaSilo.Properties.ReadOnly = true;
          this.txtTenSilo.Properties.ReadOnly = true;
          this.lueMaterial.ReadOnly = true;
          this.chkActivated.ReadOnly = true;
          this.spnSaiSoDuoi.ReadOnly = true;
          this.spnSaiSoTren.ReadOnly = true;
          this.spnTGNhapNhaOn.ReadOnly = true;
          this.spnTGNhapNhaOff.ReadOnly = true;
          this.spnTGKiemTraVatLieuRoi.ReadOnly = true;
          this.spnKLRoiTrongTGT3.ReadOnly = true;
          this.spnKPulse.ReadOnly = true;
          this.spnDoAm.ReadOnly = true;
          this.spnDoHutNuoc.ReadOnly = true;
          this.spnKLCanLonNhat.ReadOnly = true;
          this.spnKLCanNhoNhat.ReadOnly = true;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjSilo> blstCT = new BindingList<ObjSilo>();
      blstCT.Add(this._sl);
      this._presenter.SaveSilo(blstCT);
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
        this._presenter.BuildNewSilo();
        this.BindData();
      }
    }

    private void spnSaiSoDuoi_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnSaiSoDuoi);
      this._sl.SaiSoDuoi = new Decimal?(this.spnSaiSoDuoi.Value);
    }

    private void spnSaiSoTren_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnSaiSoTren);
      this._sl.SaiSoTren = new Decimal?(this.spnSaiSoTren.Value);
    }

    private void spnKLCanNhoNhat_EditValueChanged(object sender, EventArgs e)
    {
      if (this.spnKLCanNhoNhat.Value < 0M)
        this.spnKLCanNhoNhat.Value = 0M;
      this._sl.KLCanNhoNhat = new Decimal?(this.spnKLCanNhoNhat.Value);
    }

    private void spnKLCanLonNhat_EditValueChanged(object sender, EventArgs e)
    {
      if (this.spnKLCanLonNhat.Value < 0M)
        this.spnKLCanLonNhat.Value = 0M;
      this._sl.KLCanLonNhat = new Decimal?(this.spnKLCanLonNhat.Value);
    }

    private void spnTGNhapNhaOn_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnTGNhapNhaOn);
      this._sl.TGNhapNhaOn = new Decimal?(this.spnTGNhapNhaOn.Value);
    }

    private void spnTGNhapNhaOff_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnTGNhapNhaOff);
      this._sl.TGNhapNhaOff = new Decimal?(this.spnTGNhapNhaOff.Value);
    }

    private void spnKLRoiTrongTGT3_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnKLRoiTrongTGT3);
      this._sl.KLRoi = new Decimal?(this.spnKLRoiTrongTGT3.Value);
    }

    private void spnTGKiemTraVatLieuRoi_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnTGKiemTraVatLieuRoi);
      this._sl.TGKiemTraVatLieuRoi = new Decimal?(this.spnTGKiemTraVatLieuRoi.Value);
    }

    private void spnKPulse_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnKPulse);
      this._sl.K_Pulse = new Decimal?(this.spnKPulse.Value);
    }

    private void spnDoAm_EditValueChanged(object sender, EventArgs e)
    {
      if (this.spnDoAm.Value < 0M)
        this.spnDoAm.Value = 0M;
      this._sl.DoAm_NhomSlioAgg = new Decimal?(this.spnDoAm.Value);
    }

    private void spnDoHutNuoc_EditValueChanged(object sender, EventArgs e)
    {
      if (this.spnDoHutNuoc.Value < 0M)
        this.spnDoHutNuoc.Value = 0M;
      this._sl.DoHutNuoc_NhomSiloAgg = new Decimal?(this.spnDoHutNuoc.Value);
    }

    private void chkActivated_CheckedChanged(object sender, EventArgs e)
    {
      this._sl.Activated = new bool?(this.chkActivated.Checked);
    }

    private void lueMaterial_EditValueChanged(object sender, EventArgs e)
    {
      this._sl.MaterialID = new int?();
      if (this.lueMaterial.EditValue == DBNull.Value)
        return;
      ObjMaterial objMaterial = this._blstMaterial.Single<ObjMaterial>((Func<ObjMaterial, bool>) (o => o.MaterialID == Convert.ToInt32(this.lueMaterial.EditValue)));
      this._sl.MaterialID = new int?(objMaterial.MaterialID);
      this._sl.MaterialCode = objMaterial.MaterialCode;
      this._sl.MaterialName = objMaterial.MaterialName;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = true;
      this.SaveData();
      TramTronLogger.WriteInfo(sender.ToString());
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    private void chcChoPhepBuTruKhoiLuong_CheckedChanged(object sender, EventArgs e)
    {
      this._sl.BuTruKLMT = new bool?(this.chcChoPhepBuTruKhoiLuong.Checked);
    }

    private void chcChoPhepTuDongXNCD_CheckedChanged(object sender, EventArgs e)
    {
      this._sl.TuDongXNCD = new bool?(this.chcChoPhepTuDongXNCD.Checked);
    }

    private void btnLuu_Click(object sender, EventArgs e)
    {
    }

    
  }
}

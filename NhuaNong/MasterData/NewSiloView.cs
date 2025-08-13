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
  public class NewSiloView : ControlViewBase, INewSiloView, IBase
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
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl panelControl2;
    private PanelControl panelControl1;
    private TextEdit txtMaSilo;
    private LabelControl lblMaSilo;
    private TextEdit txtTenSilo;
    private LabelControl lblTenSilo;
    private LookUpEdit lueNhomSilo;
    private LabelControl lblNhomSilo;
    private LookUpEdit lueMaterial;
    private LabelControl lblVatTu;
    private LabelControl lblSaiSoDuoi;
    private LabelControl labelControl1;
    private CheckEdit chkActivated;
    private LabelControl lblSaiSoTren;
    private LabelControl lblTGNhapNhaOFF;
    private LabelControl lblTGNhapNhaON;
    private LabelControl lblKLRoiTuDo;
    private LabelControl lblTGTinhLuongRoiThem;
    private SpinEdit spnKPulse;
    private SpinEdit spnTGKiemTraVatLieuRoi;
    private SpinEdit spnKLRoiTrongTGT3;
    private SpinEdit spnTGNhapNhaOff;
    private SpinEdit spnTGNhapNhaOn;
    private SpinEdit spnSaiSoTren;
    private SpinEdit spnSaiSoDuoi;
    private LabelControl lblXung;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private LookUpEdit lueSiloNhomAgg;
    private PanelControl pnlDoAm;
    private LabelControl lblDoHutNuoc;
    private LabelControl lblDoAm;
    private SpinEdit spnDoHutNuoc;
    private SpinEdit spnDoAm;
    private PanelControl pnlKLCan;
    private SpinEdit spnKLCanLonNhat;
    private SpinEdit spnKLCanNhoNhat;
    private LabelControl labelControl2;
    private LabelControl labelControl3;
    private LabelControl labelControl5;
    private LabelControl labelControl4;
    private CheckBox chcChoPhepBuTruKhoiLuong;
    private CheckBox chcChoPhepTuDongXNCD;

    private bool IsSaveClose { get; set; }

    public ObjSilo Silo
    {
      set => this._sl = value;
    }

    public NewSiloView()
    {
      this.InitializeComponent();
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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlMain = new PanelControl();
      this.pnlKLCan = new PanelControl();
      this.spnKLCanLonNhat = new SpinEdit();
      this.spnKLCanNhoNhat = new SpinEdit();
      this.labelControl2 = new LabelControl();
      this.labelControl3 = new LabelControl();
      this.pnlDoAm = new PanelControl();
      this.labelControl5 = new LabelControl();
      this.labelControl4 = new LabelControl();
      this.spnDoHutNuoc = new SpinEdit();
      this.spnDoAm = new SpinEdit();
      this.lblDoHutNuoc = new LabelControl();
      this.lblDoAm = new LabelControl();
      this.spnKPulse = new SpinEdit();
      this.spnTGKiemTraVatLieuRoi = new SpinEdit();
      this.spnKLRoiTrongTGT3 = new SpinEdit();
      this.spnTGNhapNhaOff = new SpinEdit();
      this.spnTGNhapNhaOn = new SpinEdit();
      this.spnSaiSoTren = new SpinEdit();
      this.spnSaiSoDuoi = new SpinEdit();
      this.lblXung = new LabelControl();
      this.lblTGTinhLuongRoiThem = new LabelControl();
      this.lblKLRoiTuDo = new LabelControl();
      this.lblTGNhapNhaOFF = new LabelControl();
      this.lblTGNhapNhaON = new LabelControl();
      this.lblSaiSoTren = new LabelControl();
      this.lblSaiSoDuoi = new LabelControl();
      this.panelControl2 = new PanelControl();
      this.lueSiloNhomAgg = new LookUpEdit();
      this.labelControl1 = new LabelControl();
      this.chkActivated = new CheckEdit();
      this.lueNhomSilo = new LookUpEdit();
      this.lblNhomSilo = new LabelControl();
      this.lueMaterial = new LookUpEdit();
      this.lblVatTu = new LabelControl();
      this.txtTenSilo = new TextEdit();
      this.lblTenSilo = new LabelControl();
      this.txtMaSilo = new TextEdit();
      this.lblMaSilo = new LabelControl();
      this.panelControl1 = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.chcChoPhepBuTruKhoiLuong = new CheckBox();
      this.chcChoPhepTuDongXNCD = new CheckBox();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.pnlKLCan.BeginInit();
      this.pnlKLCan.SuspendLayout();
      this.spnKLCanLonNhat.Properties.BeginInit();
      this.spnKLCanNhoNhat.Properties.BeginInit();
      this.pnlDoAm.BeginInit();
      this.pnlDoAm.SuspendLayout();
      this.spnDoHutNuoc.Properties.BeginInit();
      this.spnDoAm.Properties.BeginInit();
      this.spnKPulse.Properties.BeginInit();
      this.spnTGKiemTraVatLieuRoi.Properties.BeginInit();
      this.spnKLRoiTrongTGT3.Properties.BeginInit();
      this.spnTGNhapNhaOff.Properties.BeginInit();
      this.spnTGNhapNhaOn.Properties.BeginInit();
      this.spnSaiSoTren.Properties.BeginInit();
      this.spnSaiSoDuoi.Properties.BeginInit();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.lueSiloNhomAgg.Properties.BeginInit();
      this.chkActivated.Properties.BeginInit();
      this.lueNhomSilo.Properties.BeginInit();
      this.lueMaterial.Properties.BeginInit();
      this.txtTenSilo.Properties.BeginInit();
      this.txtMaSilo.Properties.BeginInit();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.pnlKLCan);
      this.pnlMain.Controls.Add((Control) this.pnlDoAm);
      this.pnlMain.Controls.Add((Control) this.spnKPulse);
      this.pnlMain.Controls.Add((Control) this.spnTGKiemTraVatLieuRoi);
      this.pnlMain.Controls.Add((Control) this.spnKLRoiTrongTGT3);
      this.pnlMain.Controls.Add((Control) this.spnTGNhapNhaOff);
      this.pnlMain.Controls.Add((Control) this.spnTGNhapNhaOn);
      this.pnlMain.Controls.Add((Control) this.spnSaiSoTren);
      this.pnlMain.Controls.Add((Control) this.spnSaiSoDuoi);
      this.pnlMain.Controls.Add((Control) this.lblXung);
      this.pnlMain.Controls.Add((Control) this.lblTGTinhLuongRoiThem);
      this.pnlMain.Controls.Add((Control) this.lblKLRoiTuDo);
      this.pnlMain.Controls.Add((Control) this.lblTGNhapNhaOFF);
      this.pnlMain.Controls.Add((Control) this.lblTGNhapNhaON);
      this.pnlMain.Controls.Add((Control) this.lblSaiSoTren);
      this.pnlMain.Controls.Add((Control) this.lblSaiSoDuoi);
      this.pnlMain.Controls.Add((Control) this.panelControl2);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(686, 366);
      this.pnlMain.TabIndex = 0;
      this.pnlKLCan.Controls.Add((Control) this.spnKLCanLonNhat);
      this.pnlKLCan.Controls.Add((Control) this.spnKLCanNhoNhat);
      this.pnlKLCan.Controls.Add((Control) this.labelControl2);
      this.pnlKLCan.Controls.Add((Control) this.labelControl3);
      this.pnlKLCan.Location = new Point(456, 193);
      this.pnlKLCan.Name = "pnlKLCan";
      this.pnlKLCan.Size = new Size(225, 79);
      this.pnlKLCan.TabIndex = 20;
      this.spnKLCanLonNhat.EditValue = (object) new Decimal(new int[4]);
      this.spnKLCanLonNhat.Location = new Point(137, 42);
      this.spnKLCanLonNhat.Margin = new Padding(2);
      this.spnKLCanLonNhat.Name = "spnKLCanLonNhat";
      this.spnKLCanLonNhat.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLCanLonNhat.Properties.Appearance.Options.UseFont = true;
      this.spnKLCanLonNhat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLCanLonNhat.Size = new Size(80, 22);
      this.spnKLCanLonNhat.TabIndex = 19;
      this.spnKLCanLonNhat.EditValueChanged += new EventHandler(this.spnKLCanLonNhat_EditValueChanged);
      this.spnKLCanNhoNhat.EditValue = (object) new Decimal(new int[4]);
      this.spnKLCanNhoNhat.Location = new Point(137, 13);
      this.spnKLCanNhoNhat.Margin = new Padding(2);
      this.spnKLCanNhoNhat.Name = "spnKLCanNhoNhat";
      this.spnKLCanNhoNhat.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLCanNhoNhat.Properties.Appearance.Options.UseFont = true;
      this.spnKLCanNhoNhat.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLCanNhoNhat.Properties.EditValueChangedDelay = 1;
      this.spnKLCanNhoNhat.Size = new Size(80, 22);
      this.spnKLCanNhoNhat.TabIndex = 18;
      this.spnKLCanNhoNhat.EditValueChanged += new EventHandler(this.spnKLCanNhoNhat_EditValueChanged);
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(4, 45);
      this.labelControl2.Margin = new Padding(2);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(125, 16);
      this.labelControl2.TabIndex = 17;
      this.labelControl2.Text = "KL Cân Lớn Nhất  [Kg]";
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(6, 16);
      this.labelControl3.Margin = new Padding(2);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(123, 16);
      this.labelControl3.TabIndex = 16;
      this.labelControl3.Text = "KL Cân Nhỏ Nhất [Kg]";
      this.pnlDoAm.Controls.Add((Control) this.labelControl5);
      this.pnlDoAm.Controls.Add((Control) this.labelControl4);
      this.pnlDoAm.Controls.Add((Control) this.spnDoHutNuoc);
      this.pnlDoAm.Controls.Add((Control) this.spnDoAm);
      this.pnlDoAm.Controls.Add((Control) this.lblDoHutNuoc);
      this.pnlDoAm.Controls.Add((Control) this.lblDoAm);
      this.pnlDoAm.Location = new Point(456, 100);
      this.pnlDoAm.Name = "pnlDoAm";
      this.pnlDoAm.Size = new Size(225, 74);
      this.pnlDoAm.TabIndex = 15;
      this.labelControl5.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new Point(185, 45);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(12, 16);
      this.labelControl5.TabIndex = 5;
      this.labelControl5.Text = "%";
      this.labelControl4.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new Point(185, 16);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(12, 16);
      this.labelControl4.TabIndex = 4;
      this.labelControl4.Text = "%";
      this.spnDoHutNuoc.EditValue = (object) new Decimal(new int[4]);
      this.spnDoHutNuoc.Location = new Point(96, 42);
      this.spnDoHutNuoc.Name = "spnDoHutNuoc";
      this.spnDoHutNuoc.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnDoHutNuoc.Properties.Appearance.Options.UseFont = true;
      this.spnDoHutNuoc.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnDoHutNuoc.Size = new Size(80, 22);
      this.spnDoHutNuoc.TabIndex = 3;
      this.spnDoHutNuoc.EditValueChanged += new EventHandler(this.spnDoHutNuoc_EditValueChanged);
      this.spnDoAm.EditValue = (object) new Decimal(new int[4]);
      this.spnDoAm.Location = new Point(96, 13);
      this.spnDoAm.Name = "spnDoAm";
      this.spnDoAm.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnDoAm.Properties.Appearance.Options.UseFont = true;
      this.spnDoAm.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnDoAm.Size = new Size(80, 22);
      this.spnDoAm.TabIndex = 2;
      this.spnDoAm.EditValueChanged += new EventHandler(this.spnDoAm_EditValueChanged);
      this.lblDoHutNuoc.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDoHutNuoc.Appearance.Options.UseFont = true;
      this.lblDoHutNuoc.Location = new Point(14, 45);
      this.lblDoHutNuoc.Name = "lblDoHutNuoc";
      this.lblDoHutNuoc.Size = new Size(72, 16);
      this.lblDoHutNuoc.TabIndex = 1;
      this.lblDoHutNuoc.Text = "Độ Hút Nước";
      this.lblDoAm.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDoAm.Appearance.Options.UseFont = true;
      this.lblDoAm.Location = new Point(44, 16);
      this.lblDoAm.Name = "lblDoAm";
      this.lblDoAm.Size = new Size(39, 16);
      this.lblDoAm.TabIndex = 0;
      this.lblDoAm.Text = "Độ Ẩm";
      this.spnKPulse.EditValue = (object) new Decimal(new int[4]);
      this.spnKPulse.Location = new Point(340, 282);
      this.spnKPulse.Margin = new Padding(2);
      this.spnKPulse.Name = "spnKPulse";
      this.spnKPulse.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKPulse.Properties.Appearance.Options.UseFont = true;
      this.spnKPulse.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKPulse.Size = new Size(107, 22);
      this.spnKPulse.TabIndex = 14;
      this.spnKPulse.Visible = false;
      this.spnKPulse.EditValueChanged += new EventHandler(this.spnKPulse_EditValueChanged);
      this.spnTGKiemTraVatLieuRoi.EditValue = (object) new Decimal(new int[4]);
      this.spnTGKiemTraVatLieuRoi.Location = new Point(340, 250);
      this.spnTGKiemTraVatLieuRoi.Margin = new Padding(2);
      this.spnTGKiemTraVatLieuRoi.Name = "spnTGKiemTraVatLieuRoi";
      this.spnTGKiemTraVatLieuRoi.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnTGKiemTraVatLieuRoi.Properties.Appearance.Options.UseFont = true;
      this.spnTGKiemTraVatLieuRoi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTGKiemTraVatLieuRoi.Size = new Size(107, 22);
      this.spnTGKiemTraVatLieuRoi.TabIndex = 13;
      this.spnTGKiemTraVatLieuRoi.EditValueChanged += new EventHandler(this.spnTGKiemTraVatLieuRoi_EditValueChanged);
      this.spnKLRoiTrongTGT3.EditValue = (object) new Decimal(new int[4]);
      this.spnKLRoiTrongTGT3.Location = new Point(340, 220);
      this.spnKLRoiTrongTGT3.Margin = new Padding(2);
      this.spnKLRoiTrongTGT3.Name = "spnKLRoiTrongTGT3";
      this.spnKLRoiTrongTGT3.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLRoiTrongTGT3.Properties.Appearance.Options.UseFont = true;
      this.spnKLRoiTrongTGT3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLRoiTrongTGT3.Size = new Size(107, 22);
      this.spnKLRoiTrongTGT3.TabIndex = 12;
      this.spnKLRoiTrongTGT3.EditValueChanged += new EventHandler(this.spnKLRoiTrongTGT3_EditValueChanged);
      this.spnTGNhapNhaOff.EditValue = (object) new Decimal(new int[4]);
      this.spnTGNhapNhaOff.Location = new Point(340, 190);
      this.spnTGNhapNhaOff.Margin = new Padding(2);
      this.spnTGNhapNhaOff.Name = "spnTGNhapNhaOff";
      this.spnTGNhapNhaOff.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnTGNhapNhaOff.Properties.Appearance.Options.UseFont = true;
      this.spnTGNhapNhaOff.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTGNhapNhaOff.Size = new Size(107, 22);
      this.spnTGNhapNhaOff.TabIndex = 11;
      this.spnTGNhapNhaOff.EditValueChanged += new EventHandler(this.spnTGNhapNhaOff_EditValueChanged);
      this.spnTGNhapNhaOn.EditValue = (object) new Decimal(new int[4]);
      this.spnTGNhapNhaOn.Location = new Point(340, 160);
      this.spnTGNhapNhaOn.Margin = new Padding(2);
      this.spnTGNhapNhaOn.Name = "spnTGNhapNhaOn";
      this.spnTGNhapNhaOn.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnTGNhapNhaOn.Properties.Appearance.Options.UseFont = true;
      this.spnTGNhapNhaOn.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTGNhapNhaOn.Size = new Size(107, 22);
      this.spnTGNhapNhaOn.TabIndex = 10;
      this.spnTGNhapNhaOn.EditValueChanged += new EventHandler(this.spnTGNhapNhaOn_EditValueChanged);
      this.spnSaiSoTren.EditValue = (object) new Decimal(new int[4]);
      this.spnSaiSoTren.Location = new Point(340, 130);
      this.spnSaiSoTren.Margin = new Padding(2);
      this.spnSaiSoTren.Name = "spnSaiSoTren";
      this.spnSaiSoTren.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnSaiSoTren.Properties.Appearance.Options.UseFont = true;
      this.spnSaiSoTren.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnSaiSoTren.Size = new Size(107, 22);
      this.spnSaiSoTren.TabIndex = 9;
      this.spnSaiSoTren.EditValueChanged += new EventHandler(this.spnSaiSoTren_EditValueChanged);
      this.spnSaiSoDuoi.EditValue = (object) new Decimal(new int[4]);
      this.spnSaiSoDuoi.Location = new Point(340, 100);
      this.spnSaiSoDuoi.Margin = new Padding(2);
      this.spnSaiSoDuoi.Name = "spnSaiSoDuoi";
      this.spnSaiSoDuoi.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnSaiSoDuoi.Properties.Appearance.Options.UseFont = true;
      this.spnSaiSoDuoi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnSaiSoDuoi.Properties.EditValueChangedDelay = 1;
      this.spnSaiSoDuoi.Size = new Size(107, 22);
      this.spnSaiSoDuoi.TabIndex = 8;
      this.spnSaiSoDuoi.EditValueChanged += new EventHandler(this.spnSaiSoDuoi_EditValueChanged);
      this.lblXung.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblXung.Appearance.Options.UseFont = true;
      this.lblXung.Location = new Point(294, 285);
      this.lblXung.Margin = new Padding(2);
      this.lblXung.Name = "lblXung";
      this.lblXung.Size = new Size(29, 16);
      this.lblXung.TabIndex = 7;
      this.lblXung.Text = "Xung";
      this.lblXung.Visible = false;
      this.lblTGTinhLuongRoiThem.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTGTinhLuongRoiThem.Appearance.Options.UseFont = true;
      this.lblTGTinhLuongRoiThem.Location = new Point(131, 253);
      this.lblTGTinhLuongRoiThem.Margin = new Padding(2);
      this.lblTGTinhLuongRoiThem.Name = "lblTGTinhLuongRoiThem";
      this.lblTGTinhLuongRoiThem.Size = new Size(192, 16);
      this.lblTGTinhLuongRoiThem.TabIndex = 6;
      this.lblTGTinhLuongRoiThem.Text = "TG Tính Lượng Rơi Thêm (T3) [s]";
      this.lblKLRoiTuDo.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLRoiTuDo.Appearance.Options.UseFont = true;
      this.lblKLRoiTuDo.Location = new Point(225, 223);
      this.lblKLRoiTuDo.Margin = new Padding(2);
      this.lblKLRoiTuDo.Name = "lblKLRoiTuDo";
      this.lblKLRoiTuDo.Size = new Size(98, 16);
      this.lblKLRoiTuDo.TabIndex = 5;
      this.lblKLRoiTuDo.Text = "KL rơi tự do  [Kg]";
      this.lblTGNhapNhaOFF.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTGNhapNhaOFF.Appearance.Options.UseFont = true;
      this.lblTGNhapNhaOFF.Location = new Point(172, 193);
      this.lblTGNhapNhaOFF.Margin = new Padding(2);
      this.lblTGNhapNhaOFF.Name = "lblTGNhapNhaOFF";
      this.lblTGNhapNhaOFF.Size = new Size(151, 16);
      this.lblTGNhapNhaOFF.TabIndex = 4;
      this.lblTGNhapNhaOFF.Text = "TG Nhấp Nhả OFF (T2) [s]";
      this.lblTGNhapNhaON.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTGNhapNhaON.Appearance.Options.UseFont = true;
      this.lblTGNhapNhaON.Location = new Point(178, 163);
      this.lblTGNhapNhaON.Margin = new Padding(2);
      this.lblTGNhapNhaON.Name = "lblTGNhapNhaON";
      this.lblTGNhapNhaON.Size = new Size(145, 16);
      this.lblTGNhapNhaON.TabIndex = 3;
      this.lblTGNhapNhaON.Text = "TG Nhấp Nhả ON (T1) [s]";
      this.lblSaiSoTren.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblSaiSoTren.Appearance.Options.UseFont = true;
      this.lblSaiSoTren.Location = new Point(227, 134);
      this.lblSaiSoTren.Margin = new Padding(2);
      this.lblSaiSoTren.Name = "lblSaiSoTren";
      this.lblSaiSoTren.Size = new Size(96, 16);
      this.lblSaiSoTren.TabIndex = 2;
      this.lblSaiSoTren.Text = "Sai Số Trên [Kg]";
      this.lblSaiSoDuoi.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblSaiSoDuoi.Appearance.Options.UseFont = true;
      this.lblSaiSoDuoi.Location = new Point(228, 103);
      this.lblSaiSoDuoi.Margin = new Padding(2);
      this.lblSaiSoDuoi.Name = "lblSaiSoDuoi";
      this.lblSaiSoDuoi.Size = new Size(95, 16);
      this.lblSaiSoDuoi.TabIndex = 1;
      this.lblSaiSoDuoi.Text = "Sai Số Dưới [Kg]";
      this.panelControl2.Controls.Add((Control) this.lueSiloNhomAgg);
      this.panelControl2.Controls.Add((Control) this.labelControl1);
      this.panelControl2.Controls.Add((Control) this.chkActivated);
      this.panelControl2.Controls.Add((Control) this.lueNhomSilo);
      this.panelControl2.Controls.Add((Control) this.lblNhomSilo);
      this.panelControl2.Controls.Add((Control) this.lueMaterial);
      this.panelControl2.Controls.Add((Control) this.lblVatTu);
      this.panelControl2.Controls.Add((Control) this.txtTenSilo);
      this.panelControl2.Controls.Add((Control) this.lblTenSilo);
      this.panelControl2.Controls.Add((Control) this.txtMaSilo);
      this.panelControl2.Controls.Add((Control) this.lblMaSilo);
      this.panelControl2.Dock = DockStyle.Top;
      this.panelControl2.Location = new Point(2, 2);
      this.panelControl2.Margin = new Padding(2);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(682, 80);
      this.panelControl2.TabIndex = 0;
      this.lueSiloNhomAgg.Location = new Point(488, 47);
      this.lueSiloNhomAgg.Margin = new Padding(2);
      this.lueSiloNhomAgg.Name = "lueSiloNhomAgg";
      this.lueSiloNhomAgg.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueSiloNhomAgg.Properties.Appearance.Options.UseFont = true;
      this.lueSiloNhomAgg.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueSiloNhomAgg.Properties.NullText = "";
      this.lueSiloNhomAgg.Size = new Size(60, 22);
      this.lueSiloNhomAgg.TabIndex = 36;
      this.lueSiloNhomAgg.Visible = false;
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(578, 49);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 35;
      this.labelControl1.Text = "Kích hoạt";
      this.labelControl1.Visible = false;
      this.chkActivated.Location = new Point(644, 46);
      this.chkActivated.Margin = new Padding(2);
      this.chkActivated.Name = "chkActivated";
      this.chkActivated.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkActivated.Properties.Appearance.Options.UseFont = true;
      this.chkActivated.Properties.Caption = "";
      this.chkActivated.Size = new Size(21, 20);
      this.chkActivated.TabIndex = 34;
      this.chkActivated.Visible = false;
      this.chkActivated.CheckedChanged += new EventHandler(this.chkActivated_CheckedChanged);
      this.lueNhomSilo.Location = new Point(538, 15);
      this.lueNhomSilo.Margin = new Padding(2);
      this.lueNhomSilo.Name = "lueNhomSilo";
      this.lueNhomSilo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueNhomSilo.Properties.Appearance.Options.UseFont = true;
      this.lueNhomSilo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueNhomSilo.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("NhomSiloID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaNhomSilo", "Mã Nhóm Silo"),
        new LookUpColumnInfo("TenNhomSilo", "Tên Nhóm Silo")
      });
      this.lueNhomSilo.Properties.DisplayMember = "TenNhomSilo";
      this.lueNhomSilo.Properties.NullText = "";
      this.lueNhomSilo.Properties.ReadOnly = true;
      this.lueNhomSilo.Properties.ShowFooter = false;
      this.lueNhomSilo.Properties.ValueMember = "NhomSiloID";
      this.lueNhomSilo.Size = new Size(110, 22);
      this.lueNhomSilo.TabIndex = 33;
      this.lueNhomSilo.Visible = false;
      this.lblNhomSilo.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblNhomSilo.Appearance.Options.UseFont = true;
      this.lblNhomSilo.Location = new Point(462, 19);
      this.lblNhomSilo.Margin = new Padding(2);
      this.lblNhomSilo.Name = "lblNhomSilo";
      this.lblNhomSilo.Size = new Size(62, 16);
      this.lblNhomSilo.TabIndex = 32;
      this.lblNhomSilo.Text = "Nhóm Silo";
      this.lblNhomSilo.Visible = false;
      this.lueMaterial.Location = new Point(265, 45);
      this.lueMaterial.Margin = new Padding(2);
      this.lueMaterial.Name = "lueMaterial";
      this.lueMaterial.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.lueMaterial.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueMaterial.Properties.Appearance.Options.UseBackColor = true;
      this.lueMaterial.Properties.Appearance.Options.UseFont = true;
      this.lueMaterial.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueMaterial.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("MaterialID", "ID", 20, FormatType.Numeric, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaterialName", "Vật tư")
      });
      this.lueMaterial.Properties.DisplayMember = "MaterialName";
      this.lueMaterial.Properties.NullText = "";
      this.lueMaterial.Properties.ShowFooter = false;
      this.lueMaterial.Properties.ValueMember = "MaterialID";
      this.lueMaterial.Size = new Size(180, 22);
      this.lueMaterial.TabIndex = 31;
      this.lueMaterial.EditValueChanged += new EventHandler(this.lueMaterial_EditValueChanged);
      this.lblVatTu.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblVatTu.Appearance.Options.UseFont = true;
      this.lblVatTu.Location = new Point(208, 48);
      this.lblVatTu.Margin = new Padding(2);
      this.lblVatTu.Name = "lblVatTu";
      this.lblVatTu.Size = new Size(33, 16);
      this.lblVatTu.TabIndex = 30;
      this.lblVatTu.Text = "Vật tư";
      this.txtTenSilo.Location = new Point(265, 13);
      this.txtTenSilo.Margin = new Padding(2);
      this.txtTenSilo.Name = "txtTenSilo";
      this.txtTenSilo.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtTenSilo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenSilo.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenSilo.Properties.Appearance.Options.UseFont = true;
      this.txtTenSilo.Size = new Size(180, 22);
      this.txtTenSilo.TabIndex = 29;
      this.lblTenSilo.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenSilo.Appearance.Options.UseFont = true;
      this.lblTenSilo.Location = new Point(200, 17);
      this.lblTenSilo.Margin = new Padding(2);
      this.lblTenSilo.Name = "lblTenSilo";
      this.lblTenSilo.Size = new Size(50, 16);
      this.lblTenSilo.TabIndex = 28;
      this.lblTenSilo.Text = "Tên Silo";
      this.txtMaSilo.Location = new Point(90, 22);
      this.txtMaSilo.Margin = new Padding(2);
      this.txtMaSilo.Name = "txtMaSilo";
      this.txtMaSilo.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaSilo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaSilo.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaSilo.Properties.Appearance.Options.UseFont = true;
      this.txtMaSilo.Properties.ReadOnly = true;
      this.txtMaSilo.Size = new Size(51, 22);
      this.txtMaSilo.TabIndex = 27;
      this.txtMaSilo.Visible = false;
      this.lblMaSilo.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaSilo.Appearance.Options.UseFont = true;
      this.lblMaSilo.Location = new Point(33, 26);
      this.lblMaSilo.Margin = new Padding(2);
      this.lblMaSilo.Name = "lblMaSilo";
      this.lblMaSilo.Size = new Size(45, 16);
      this.lblMaSilo.TabIndex = 26;
      this.lblMaSilo.Text = "Mã Silo";
      this.lblMaSilo.Visible = false;
      this.panelControl1.Controls.Add((Control) this.btnClose);
      this.panelControl1.Controls.Add((Control) this.btnSave);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(0, 319);
      this.panelControl1.Margin = new Padding(2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(686, 47);
      this.panelControl1.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(349, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(225, 9);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.chcChoPhepBuTruKhoiLuong.AutoSize = true;
      this.chcChoPhepBuTruKhoiLuong.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chcChoPhepBuTruKhoiLuong.Location = new Point(114, 287);
      this.chcChoPhepBuTruKhoiLuong.Name = "chcChoPhepBuTruKhoiLuong";
      this.chcChoPhepBuTruKhoiLuong.RightToLeft = RightToLeft.Yes;
      this.chcChoPhepBuTruKhoiLuong.Size = new Size(230, 20);
      this.chcChoPhepBuTruKhoiLuong.TabIndex = 2;
      this.chcChoPhepBuTruKhoiLuong.Text = "Cho phép bù trừ khối lượng mẻ trộn";
      this.chcChoPhepBuTruKhoiLuong.UseVisualStyleBackColor = true;
      this.chcChoPhepBuTruKhoiLuong.Visible = false;
      this.chcChoPhepBuTruKhoiLuong.CheckedChanged += new EventHandler(this.chcChoPhepBuTruKhoiLuong_CheckedChanged);
      this.chcChoPhepTuDongXNCD.AutoSize = true;
      this.chcChoPhepTuDongXNCD.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chcChoPhepTuDongXNCD.Location = new Point(379, 287);
      this.chcChoPhepTuDongXNCD.Name = "chcChoPhepTuDongXNCD";
      this.chcChoPhepTuDongXNCD.RightToLeft = RightToLeft.Yes;
      this.chcChoPhepTuDongXNCD.Size = new Size(230, 20);
      this.chcChoPhepTuDongXNCD.TabIndex = 3;
      this.chcChoPhepTuDongXNCD.Text = "Cho phép tự động xác nhận cân dư";
      this.chcChoPhepTuDongXNCD.UseVisualStyleBackColor = true;
      this.chcChoPhepTuDongXNCD.Visible = false;
      this.chcChoPhepTuDongXNCD.CheckedChanged += new EventHandler(this.chcChoPhepTuDongXNCD_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.chcChoPhepTuDongXNCD);
      this.Controls.Add((Control) this.chcChoPhepBuTruKhoiLuong);
      this.Controls.Add((Control) this.panelControl1);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewSiloView);
      this.Size = new Size(686, 366);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.pnlKLCan.EndInit();
      this.pnlKLCan.ResumeLayout(false);
      this.pnlKLCan.PerformLayout();
      this.spnKLCanLonNhat.Properties.EndInit();
      this.spnKLCanNhoNhat.Properties.EndInit();
      this.pnlDoAm.EndInit();
      this.pnlDoAm.ResumeLayout(false);
      this.pnlDoAm.PerformLayout();
      this.spnDoHutNuoc.Properties.EndInit();
      this.spnDoAm.Properties.EndInit();
      this.spnKPulse.Properties.EndInit();
      this.spnTGKiemTraVatLieuRoi.Properties.EndInit();
      this.spnKLRoiTrongTGT3.Properties.EndInit();
      this.spnTGNhapNhaOff.Properties.EndInit();
      this.spnTGNhapNhaOn.Properties.EndInit();
      this.spnSaiSoTren.Properties.EndInit();
      this.spnSaiSoDuoi.Properties.EndInit();
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl2.PerformLayout();
      this.lueSiloNhomAgg.Properties.EndInit();
      this.chkActivated.Properties.EndInit();
      this.lueNhomSilo.Properties.EndInit();
      this.lueMaterial.Properties.EndInit();
      this.txtTenSilo.Properties.EndInit();
      this.txtMaSilo.Properties.EndInit();
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

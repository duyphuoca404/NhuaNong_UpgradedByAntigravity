// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewWeightView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

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
  public class NewWeightView : ControlViewBase, INewWeightView, IBase
  {
    private NewWeightDataPresenter _presenter;
    private bool _CanSuaTenSilo = true;
    private string _NewWeiCaption = "Thêm Cân";
    private string _EditWeiCaption = "Sửa Cân";
    private string _ViewWeiCaption = "Xem Cân";
    private ObjWeigh _wei;
    private BindingList<ObjWeigh> _blst = new BindingList<ObjWeigh>();
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl panelControl2;
    private PanelControl panelControl1;
    private LabelControl lblMaWei;
    private LabelControl lblTenWei;
    private LabelControl lblTON;
    private LabelControl lblTOFF;
    private LabelControl lblKLBaoCanRong;
    private LabelControl lblKLRungCan;
    private LabelControl lblTGOnDinhCan;
    private SpinEdit spnTGTreXa;
    private SpinEdit spnTGTreCan;
    private SpinEdit spnTGOnDinhCan;
    private SpinEdit spnKLRungCan;
    private SpinEdit spnKLBaoCanRong;
    private SpinEdit spnTOFF;
    private SpinEdit spnTON;
    private LabelControl lblTGTreCan;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private LabelControl lblTGTreDong;
    private SpinEdit spnTGTreDong;
    private LabelControl lblTGTreXa;
    private TextEdit txtMaWei;
    private TextEdit txtTenWei;
    private CheckBox chkGiuKL;

    private bool IsSaveClose { get; set; }

    public ObjWeigh Wei
    {
      set => this._wei = value;
    }

    public NewWeightView()
    {
      this.InitializeComponent();
      this._presenter = new NewWeightDataPresenter((INewWeightView) this);
    }

    public NewWeightView(ObjWeigh wei, Enums.FormAction action)
      : this()
    {
      this._wei = wei;
      this.FormAction = action;
      this.SetCaption();
    }

    protected override void SetupLayout() => this.DisableConstrol();

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public ObjWeigh Weight
    {
      set => this._wei = value;
    }

    protected override void PopulateData()
    {
      if (this.FormAction != Enums.FormAction.Edit)
        return;
      this._presenter.GetWeiByKey(this._wei.WeighID);
    }

    protected override void BindData()
    {
      this.txtMaWei.DataBindings.Clear();
      this.txtMaWei.DataBindings.Add("Text", (object) this._wei, "WeighCode");
      this.txtTenWei.DataBindings.Clear();
      this.txtTenWei.DataBindings.Add("Text", (object) this._wei, "WeighName");
      this.spnTON.DataBindings.Clear();
      this.spnTON.DataBindings.Add("EditValue", (object) this._wei, "TON");
      this.spnTOFF.DataBindings.Clear();
      this.spnTOFF.DataBindings.Add("EditValue", (object) this._wei, "TOFF");
      this.spnKLBaoCanRong.DataBindings.Clear();
      this.spnKLBaoCanRong.DataBindings.Add("EditValue", (object) this._wei, "KLEmpty");
      this.spnKLRungCan.DataBindings.Clear();
      this.spnKLRungCan.DataBindings.Add("EditValue", (object) this._wei, "WeiToVib");
      this.spnTGOnDinhCan.DataBindings.Clear();
      this.spnTGOnDinhCan.DataBindings.Add("EditValue", (object) this._wei, "TimeEmpty");
      this.spnTGTreCan.DataBindings.Clear();
      this.spnTGTreCan.DataBindings.Add("EditValue", (object) this._wei, "Zero");
      this.spnTGTreXa.DataBindings.Clear();
      this.spnTGTreXa.DataBindings.Add("EditValue", (object) this._wei, "Max");
      this.spnTGTreDong.DataBindings.Clear();
      this.spnTGTreDong.DataBindings.Add("EditValue", (object) this._wei, "Offset");
      this.chkGiuKL.DataBindings.Add("Checked", (object) this._wei, "GiuKLTC");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewWeiCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditWeiCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewWeiCaption;
          break;
      }
    }

    private bool ValidateData() => true;

    private void DisableConstrol()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          if (this._CanSuaTenSilo)
            break;
          this.txtMaWei.Properties.ReadOnly = true;
          this.txtTenWei.Properties.ReadOnly = true;
          break;
        case Enums.FormAction.Edit:
          if (this._CanSuaTenSilo)
            break;
          this.txtMaWei.Properties.ReadOnly = true;
          this.txtTenWei.Properties.ReadOnly = true;
          break;
        case Enums.FormAction.View:
          this.txtMaWei.Properties.ReadOnly = true;
          this.txtTenWei.Properties.ReadOnly = true;
          this.spnTON.ReadOnly = true;
          this.spnTOFF.ReadOnly = true;
          this.spnKLBaoCanRong.ReadOnly = true;
          this.spnKLRungCan.ReadOnly = true;
          this.spnTGTreCan.ReadOnly = true;
          this.spnTGOnDinhCan.ReadOnly = true;
          this.spnTGTreXa.ReadOnly = true;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjWeigh> btstWei = new BindingList<ObjWeigh>();
      btstWei.Add(this._wei);
      this._presenter.SaveWei(btstWei);
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessProceed);
      this._dlgRes = DialogResult.OK;
      if (this.IsSaveClose)
        this.Close();
      else
        this.BindData();
    }

    private void spnTON_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnTON);
      this._wei.TON = new Decimal?(this.spnTON.Value);
    }

    private void spnTOFF_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnTOFF);
      this._wei.TOFF = new Decimal?(this.spnTOFF.Value);
    }

    private void spnKLBaoCanRong_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnKLBaoCanRong);
      this._wei.KLEmpty = new Decimal?(this.spnKLBaoCanRong.Value);
    }

    private void spnKLRungCan_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnKLRungCan);
      this._wei.WeiToVib = new Decimal?(this.spnKLRungCan.Value);
    }

    private void spnTGTreCan_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnTGTreCan);
      this._wei.Zero = new Decimal?(this.spnTGTreCan.Value);
    }

    private void spnTGOnDinhCan_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnTGOnDinhCan);
      this._wei.TimeEmpty = new Decimal?(this.spnTGOnDinhCan.Value);
    }

    private void spnTGTreXa_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnTGTreXa);
      this._wei.Max = new Decimal?(this.spnTGTreXa.Value);
    }

    private void spnTGTreDong_EditValueChanged(object sender, EventArgs e)
    {
      Support.SetValueSpinZero(this.spnTGTreDong);
      this._wei.Offset = new Decimal?(this.spnTGTreDong.Value);
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = true;
      this.SaveData();
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    private void chkGiuKL_CheckedChanged(object sender, EventArgs e)
    {
      this._wei.GiuKLTC = new bool?(this.chkGiuKL.Checked);
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
      this.lblTGTreDong = new LabelControl();
      this.spnTGTreDong = new SpinEdit();
      this.lblTGTreXa = new LabelControl();
      this.spnTGTreXa = new SpinEdit();
      this.spnTGTreCan = new SpinEdit();
      this.spnTGOnDinhCan = new SpinEdit();
      this.spnKLRungCan = new SpinEdit();
      this.spnKLBaoCanRong = new SpinEdit();
      this.spnTOFF = new SpinEdit();
      this.spnTON = new SpinEdit();
      this.lblTGTreCan = new LabelControl();
      this.lblTGOnDinhCan = new LabelControl();
      this.lblKLRungCan = new LabelControl();
      this.lblKLBaoCanRong = new LabelControl();
      this.lblTOFF = new LabelControl();
      this.lblTON = new LabelControl();
      this.panelControl2 = new PanelControl();
      this.txtTenWei = new TextEdit();
      this.txtMaWei = new TextEdit();
      this.lblTenWei = new LabelControl();
      this.lblMaWei = new LabelControl();
      this.panelControl1 = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.chkGiuKL = new CheckBox();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.spnTGTreDong.Properties.BeginInit();
      this.spnTGTreXa.Properties.BeginInit();
      this.spnTGTreCan.Properties.BeginInit();
      this.spnTGOnDinhCan.Properties.BeginInit();
      this.spnKLRungCan.Properties.BeginInit();
      this.spnKLBaoCanRong.Properties.BeginInit();
      this.spnTOFF.Properties.BeginInit();
      this.spnTON.Properties.BeginInit();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.txtTenWei.Properties.BeginInit();
      this.txtMaWei.Properties.BeginInit();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.lblTGTreDong);
      this.pnlMain.Controls.Add((Control) this.spnTGTreDong);
      this.pnlMain.Controls.Add((Control) this.lblTGTreXa);
      this.pnlMain.Controls.Add((Control) this.spnTGTreXa);
      this.pnlMain.Controls.Add((Control) this.spnTGTreCan);
      this.pnlMain.Controls.Add((Control) this.spnTGOnDinhCan);
      this.pnlMain.Controls.Add((Control) this.spnKLRungCan);
      this.pnlMain.Controls.Add((Control) this.spnKLBaoCanRong);
      this.pnlMain.Controls.Add((Control) this.spnTOFF);
      this.pnlMain.Controls.Add((Control) this.spnTON);
      this.pnlMain.Controls.Add((Control) this.lblTGTreCan);
      this.pnlMain.Controls.Add((Control) this.lblTGOnDinhCan);
      this.pnlMain.Controls.Add((Control) this.lblKLRungCan);
      this.pnlMain.Controls.Add((Control) this.lblKLBaoCanRong);
      this.pnlMain.Controls.Add((Control) this.lblTOFF);
      this.pnlMain.Controls.Add((Control) this.lblTON);
      this.pnlMain.Controls.Add((Control) this.panelControl2);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(800, 401);
      this.pnlMain.TabIndex = 0;
      this.lblTGTreDong.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTGTreDong.Appearance.Options.UseFont = true;
      this.lblTGTreDong.Location = new Point(229, 193);
      this.lblTGTreDong.Margin = new Padding(2);
      this.lblTGTreDong.Name = "lblTGTreDong";
      this.lblTGTreDong.Size = new Size(94, 16);
      this.lblTGTreDong.TabIndex = 17;
      this.lblTGTreDong.Text = "TG Trễ Đóng [s]";
      this.spnTGTreDong.EditValue = (object) new Decimal(new int[4]);
      this.spnTGTreDong.Location = new Point(397, 190);
      this.spnTGTreDong.Margin = new Padding(2);
      this.spnTGTreDong.Name = "spnTGTreDong";
      this.spnTGTreDong.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnTGTreDong.Properties.Appearance.Options.UseFont = true;
      this.spnTGTreDong.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTGTreDong.Size = new Size(125, 22);
      this.spnTGTreDong.TabIndex = 7;
      this.spnTGTreDong.EditValueChanged += new EventHandler(this.spnTGTreDong_EditValueChanged);
      this.lblTGTreXa.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTGTreXa.Appearance.Options.UseFont = true;
      this.lblTGTreXa.Location = new Point(244, 163);
      this.lblTGTreXa.Margin = new Padding(2);
      this.lblTGTreXa.Name = "lblTGTreXa";
      this.lblTGTreXa.Size = new Size(79, 16);
      this.lblTGTreXa.TabIndex = 15;
      this.lblTGTreXa.Text = "TG Trễ Xả [s]";
      this.spnTGTreXa.EditValue = (object) new Decimal(new int[4]);
      this.spnTGTreXa.Location = new Point(397, 160);
      this.spnTGTreXa.Margin = new Padding(2);
      this.spnTGTreXa.Name = "spnTGTreXa";
      this.spnTGTreXa.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnTGTreXa.Properties.Appearance.Options.UseFont = true;
      this.spnTGTreXa.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTGTreXa.Size = new Size(125, 22);
      this.spnTGTreXa.TabIndex = 6;
      this.spnTGTreXa.EditValueChanged += new EventHandler(this.spnTGTreXa_EditValueChanged);
      this.spnTGTreCan.EditValue = (object) new Decimal(new int[4]);
      this.spnTGTreCan.Location = new Point(26, 178);
      this.spnTGTreCan.Margin = new Padding(2);
      this.spnTGTreCan.Name = "spnTGTreCan";
      this.spnTGTreCan.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTGTreCan.Size = new Size(125, 20);
      this.spnTGTreCan.TabIndex = 13;
      this.spnTGTreCan.Visible = false;
      this.spnTGTreCan.EditValueChanged += new EventHandler(this.spnTGTreCan_EditValueChanged);
      this.spnTGOnDinhCan.EditValue = (object) new Decimal(new int[4]);
      this.spnTGOnDinhCan.Location = new Point(397, 130);
      this.spnTGOnDinhCan.Margin = new Padding(2);
      this.spnTGOnDinhCan.Name = "spnTGOnDinhCan";
      this.spnTGOnDinhCan.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnTGOnDinhCan.Properties.Appearance.Options.UseFont = true;
      this.spnTGOnDinhCan.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTGOnDinhCan.Size = new Size(125, 22);
      this.spnTGOnDinhCan.TabIndex = 5;
      this.spnTGOnDinhCan.EditValueChanged += new EventHandler(this.spnTGOnDinhCan_EditValueChanged);
      this.spnKLRungCan.EditValue = (object) new Decimal(new int[4]);
      this.spnKLRungCan.Location = new Point(397, 220);
      this.spnKLRungCan.Margin = new Padding(2);
      this.spnKLRungCan.Name = "spnKLRungCan";
      this.spnKLRungCan.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLRungCan.Properties.Appearance.Options.UseFont = true;
      this.spnKLRungCan.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLRungCan.Size = new Size(125, 22);
      this.spnKLRungCan.TabIndex = 8;
      this.spnKLRungCan.EditValueChanged += new EventHandler(this.spnKLRungCan_EditValueChanged);
      this.spnKLBaoCanRong.EditValue = (object) new Decimal(new int[4]);
      this.spnKLBaoCanRong.Location = new Point(397, 100);
      this.spnKLBaoCanRong.Margin = new Padding(2);
      this.spnKLBaoCanRong.Name = "spnKLBaoCanRong";
      this.spnKLBaoCanRong.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLBaoCanRong.Properties.Appearance.Options.UseFont = true;
      this.spnKLBaoCanRong.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLBaoCanRong.Size = new Size(125, 22);
      this.spnKLBaoCanRong.TabIndex = 4;
      this.spnKLBaoCanRong.EditValueChanged += new EventHandler(this.spnKLBaoCanRong_EditValueChanged);
      this.spnTOFF.EditValue = (object) new Decimal(new int[4]);
      this.spnTOFF.Location = new Point(397, 280);
      this.spnTOFF.Margin = new Padding(2);
      this.spnTOFF.Name = "spnTOFF";
      this.spnTOFF.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnTOFF.Properties.Appearance.Options.UseFont = true;
      this.spnTOFF.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTOFF.Size = new Size(125, 22);
      this.spnTOFF.TabIndex = 10;
      this.spnTOFF.EditValueChanged += new EventHandler(this.spnTOFF_EditValueChanged);
      this.spnTON.EditValue = (object) new Decimal(new int[4]);
      this.spnTON.Location = new Point(397, 250);
      this.spnTON.Margin = new Padding(2);
      this.spnTON.Name = "spnTON";
      this.spnTON.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnTON.Properties.Appearance.Options.UseFont = true;
      this.spnTON.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTON.Properties.EditValueChangedDelay = 1;
      this.spnTON.Size = new Size(125, 22);
      this.spnTON.TabIndex = 9;
      this.spnTON.EditValueChanged += new EventHandler(this.spnTON_EditValueChanged);
      this.lblTGTreCan.Location = new Point(22, 156);
      this.lblTGTreCan.Margin = new Padding(2);
      this.lblTGTreCan.Name = "lblTGTreCan";
      this.lblTGTreCan.Size = new Size(54, 13);
      this.lblTGTreCan.TabIndex = 7;
      this.lblTGTreCan.Text = "TG Trễ Cân";
      this.lblTGTreCan.Visible = false;
      this.lblTGOnDinhCan.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTGOnDinhCan.Appearance.Options.UseFont = true;
      this.lblTGOnDinhCan.Location = new Point(237, 133);
      this.lblTGOnDinhCan.Margin = new Padding(2);
      this.lblTGOnDinhCan.Name = "lblTGOnDinhCan";
      this.lblTGOnDinhCan.Size = new Size(86, 16);
      this.lblTGOnDinhCan.TabIndex = 6;
      this.lblTGOnDinhCan.Text = "TG Trễ Cân [s]";
      this.lblKLRungCan.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLRungCan.Appearance.Options.UseFont = true;
      this.lblKLRungCan.Location = new Point(223, 223);
      this.lblKLRungCan.Margin = new Padding(2);
      this.lblKLRungCan.Name = "lblKLRungCan";
      this.lblKLRungCan.Size = new Size(100, 16);
      this.lblKLRungCan.TabIndex = 5;
      this.lblKLRungCan.Text = "KL Rung Cân [Kg]";
      this.lblKLBaoCanRong.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLBaoCanRong.Appearance.Options.UseFont = true;
      this.lblKLBaoCanRong.Location = new Point(198, 103);
      this.lblKLBaoCanRong.Margin = new Padding(2);
      this.lblKLBaoCanRong.Name = "lblKLBaoCanRong";
      this.lblKLBaoCanRong.Size = new Size(125, 16);
      this.lblKLBaoCanRong.TabIndex = 3;
      this.lblKLBaoCanRong.Text = "KL Báo Cân Rỗng [Kg]";
      this.lblTOFF.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTOFF.Appearance.Options.UseFont = true;
      this.lblTOFF.Location = new Point(268, 283);
      this.lblTOFF.Margin = new Padding(2);
      this.lblTOFF.Name = "lblTOFF";
      this.lblTOFF.Size = new Size(55, 16);
      this.lblTOFF.TabIndex = 2;
      this.lblTOFF.Text = "T OFF [s]";
      this.lblTON.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTON.Appearance.Options.UseFont = true;
      this.lblTON.Location = new Point(274, 253);
      this.lblTON.Margin = new Padding(2);
      this.lblTON.Name = "lblTON";
      this.lblTON.Size = new Size(49, 16);
      this.lblTON.TabIndex = 1;
      this.lblTON.Text = "T ON [s]";
      this.panelControl2.Controls.Add((Control) this.txtTenWei);
      this.panelControl2.Controls.Add((Control) this.txtMaWei);
      this.panelControl2.Controls.Add((Control) this.lblTenWei);
      this.panelControl2.Controls.Add((Control) this.lblMaWei);
      this.panelControl2.Dock = DockStyle.Top;
      this.panelControl2.Location = new Point(2, 2);
      this.panelControl2.Margin = new Padding(2);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(796, 80);
      this.panelControl2.TabIndex = 0;
      this.txtTenWei.Location = new Point(395, 29);
      this.txtTenWei.Margin = new Padding(2);
      this.txtTenWei.Name = "txtTenWei";
      this.txtTenWei.Properties.Appearance.BackColor = Color.White;
      this.txtTenWei.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenWei.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenWei.Properties.Appearance.Options.UseFont = true;
      this.txtTenWei.Size = new Size(175, 22);
      this.txtTenWei.TabIndex = 3;
      this.txtMaWei.Location = new Point(142, 29);
      this.txtMaWei.Margin = new Padding(2);
      this.txtMaWei.Name = "txtMaWei";
      this.txtMaWei.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaWei.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaWei.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaWei.Properties.Appearance.Options.UseFont = true;
      this.txtMaWei.Properties.ReadOnly = true;
      this.txtMaWei.Size = new Size(86, 22);
      this.txtMaWei.TabIndex = 2;
      this.txtMaWei.Visible = false;
      this.lblTenWei.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenWei.Appearance.Options.UseFont = true;
      this.lblTenWei.Location = new Point(263, 32);
      this.lblTenWei.Margin = new Padding(2);
      this.lblTenWei.Name = "lblTenWei";
      this.lblTenWei.Size = new Size(51, 16);
      this.lblTenWei.TabIndex = 28;
      this.lblTenWei.Text = "Tên Cân";
      this.lblMaWei.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaWei.Appearance.Options.UseFont = true;
      this.lblMaWei.Location = new Point(62, 32);
      this.lblMaWei.Margin = new Padding(2);
      this.lblMaWei.Name = "lblMaWei";
      this.lblMaWei.Size = new Size(46, 16);
      this.lblMaWei.TabIndex = 26;
      this.lblMaWei.Text = "Mã Cân";
      this.lblMaWei.Visible = false;
      this.panelControl1.Controls.Add((Control) this.btnClose);
      this.panelControl1.Controls.Add((Control) this.btnSave);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(0, 354);
      this.panelControl1.Margin = new Padding(2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(800, 47);
      this.panelControl1.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(349, 10);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(224, 10);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.chkGiuKL.AutoSize = true;
      this.chkGiuKL.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkGiuKL.Location = new Point(289, 318);
      this.chkGiuKL.Margin = new Padding(4, 3, 4, 3);
      this.chkGiuKL.Name = "chkGiuKL";
      this.chkGiuKL.RightToLeft = RightToLeft.Yes;
      this.chkGiuKL.Size = new Size(235, 20);
      this.chkGiuKL.TabIndex = 2;
      this.chkGiuKL.Text = "Cho Phép Giữ Khối Lượng Trên Cân";
      this.chkGiuKL.UseVisualStyleBackColor = true;
      this.chkGiuKL.Visible = false;
      this.chkGiuKL.CheckedChanged += new EventHandler(this.chkGiuKL_CheckedChanged);
      this.AutoScaleDimensions = new SizeF(7f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.chkGiuKL);
      this.Controls.Add((Control) this.panelControl1);
      this.Controls.Add((Control) this.pnlMain);
      this.Font = new Font("Symbol", 8.25f);
      this.Name = nameof (NewWeightView);
      this.Size = new Size(800, 401);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.spnTGTreDong.Properties.EndInit();
      this.spnTGTreXa.Properties.EndInit();
      this.spnTGTreCan.Properties.EndInit();
      this.spnTGOnDinhCan.Properties.EndInit();
      this.spnKLRungCan.Properties.EndInit();
      this.spnKLBaoCanRong.Properties.EndInit();
      this.spnTOFF.Properties.EndInit();
      this.spnTON.Properties.EndInit();
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.panelControl2.PerformLayout();
      this.txtTenWei.Properties.EndInit();
      this.txtMaWei.Properties.EndInit();
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

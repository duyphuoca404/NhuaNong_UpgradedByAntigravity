// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewMaterialView
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
  public class NewMaterialView : ControlViewBase, INewMaterialView, IBase
  {
    private NewMaterialDataPresenter _presenter;
    private string _NewMaterialCaption = "Thêm Vật liệu";
    private string _EditMaterialCaption = "Sửa Vật liệu";
    private string _ViewMaterialCaption = "Xem Vật liệu";
    private ObjMaterial _ct;
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl pnlCommand;
    private LabelControl lblActive;
    private CheckEdit chkActive;
    private TextEdit txtDescription;
    private TextEdit txtMaterialCode;
    private LabelControl lblDescritpion;
    private LabelControl lblMaVatTu;
    private TextEdit txtMaterialName;
    private LabelControl lblTenVatTu;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;
    private LabelControl lblDonGia;
    private LabelControl lblDonVi;
    private TextEdit txtNhaCungCap;
    private LabelControl lblNhaCungCap;
    private SpinEdit spnDonGia;
    private LookUpEdit lueDonVi;

    private bool IsSaveClose { get; set; }

    public NewMaterialView()
    {
      this.InitializeComponent();
      this._presenter = new NewMaterialDataPresenter((INewMaterialView) this);
    }

    public NewMaterialView(ObjMaterial ct, Enums.FormAction action)
      : this()
    {
      this._ct = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    public ObjMaterial Material
    {
      set => this._ct = value;
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
          this._presenter.BuildNewMaterial();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetMaterialByKey(this._ct.MaterialID);
          break;
      }
    }

    protected override void PopulateStaticData()
    {
      this.lueDonVi.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.Unit>(true);
    }

    protected override void BindData()
    {
      this.txtMaterialCode.DataBindings.Clear();
      this.txtMaterialCode.DataBindings.Add("Text", (object) this._ct, "MaterialCode");
      this.txtMaterialName.DataBindings.Clear();
      this.txtMaterialName.DataBindings.Add("Text", (object) this._ct, "MaterialName");
      this.txtNhaCungCap.DataBindings.Clear();
      this.txtNhaCungCap.DataBindings.Add("Text", (object) this._ct, "Supplier");
      this.lueDonVi.DataBindings.Clear();
      this.lueDonVi.DataBindings.Add("EditValue", (object) this._ct, "Unit");
      this.spnDonGia.DataBindings.Clear();
      this.spnDonGia.DataBindings.Add("EditValue", (object) this._ct, "Price");
      this.txtDescription.DataBindings.Clear();
      this.txtDescription.DataBindings.Add("Text", (object) this._ct, "Description");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._ct, "Activated");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewMaterialCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditMaterialCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewMaterialCaption;
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaterialCode.Text == string.Empty)
      {
        this.txtMaterialCode.ErrorText = GlobalValues.Messages.MaterialCodeIsRequired;
        flag = false;
      }
      if (this.txtMaterialName.Text == string.Empty)
      {
        this.txtMaterialName.ErrorText = GlobalValues.Messages.MaterialNameIsRequired;
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
          this.txtMaterialCode.Properties.ReadOnly = true;
          this.txtMaterialName.Properties.ReadOnly = true;
          this.txtDescription.Properties.ReadOnly = true;
          this.txtNhaCungCap.Properties.ReadOnly = true;
          this.lueDonVi.Properties.ReadOnly = true;
          this.spnDonGia.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjMaterial> blstCT = new BindingList<ObjMaterial>();
      blstCT.Add(this._ct);
      this._presenter.SaveMaterial(blstCT);
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
        this._presenter.BuildNewMaterial();
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

    private void lueDonVi_EditValueChanged(object sender, EventArgs e)
    {
      if (this.lueDonVi.EditValue == DBNull.Value)
        return;
      this._ct.Unit = new int?(Convert.ToInt32(this.lueDonVi.EditValue));
    }

    private void spnDonGia_EditValueChanged(object sender, EventArgs e)
    {
      this._ct.Price = new Decimal?(this.spnDonGia.Value);
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
      this.spnDonGia = new SpinEdit();
      this.lueDonVi = new LookUpEdit();
      this.lblDonGia = new LabelControl();
      this.lblDonVi = new LabelControl();
      this.txtNhaCungCap = new TextEdit();
      this.lblNhaCungCap = new LabelControl();
      this.txtMaterialName = new TextEdit();
      this.lblTenVatTu = new LabelControl();
      this.lblActive = new LabelControl();
      this.chkActive = new CheckEdit();
      this.txtDescription = new TextEdit();
      this.txtMaterialCode = new TextEdit();
      this.lblDescritpion = new LabelControl();
      this.lblMaVatTu = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain.BeginInit();
      this.spnDonGia.Properties.BeginInit();
      this.lueDonVi.Properties.BeginInit();
      this.txtNhaCungCap.Properties.BeginInit();
      this.txtMaterialName.Properties.BeginInit();
      this.chkActive.Properties.BeginInit();
      this.txtDescription.Properties.BeginInit();
      this.txtMaterialCode.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.spnDonGia);
      this.pnlMain.Controls.Add((Control) this.lueDonVi);
      this.pnlMain.Controls.Add((Control) this.lblDonGia);
      this.pnlMain.Controls.Add((Control) this.lblDonVi);
      this.pnlMain.Controls.Add((Control) this.txtNhaCungCap);
      this.pnlMain.Controls.Add((Control) this.lblNhaCungCap);
      this.pnlMain.Controls.Add((Control) this.txtMaterialName);
      this.pnlMain.Controls.Add((Control) this.lblTenVatTu);
      this.pnlMain.Controls.Add((Control) this.lblActive);
      this.pnlMain.Controls.Add((Control) this.chkActive);
      this.pnlMain.Controls.Add((Control) this.txtDescription);
      this.pnlMain.Controls.Add((Control) this.txtMaterialCode);
      this.pnlMain.Controls.Add((Control) this.lblDescritpion);
      this.pnlMain.Controls.Add((Control) this.lblMaVatTu);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(495, 245);
      this.pnlMain.TabIndex = 0;
      this.spnDonGia.EditValue = (object) new Decimal(new int[4]);
      this.spnDonGia.Location = new Point(200, 160);
      this.spnDonGia.Name = "spnDonGia";
      this.spnDonGia.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnDonGia.Properties.Appearance.Options.UseFont = true;
      this.spnDonGia.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnDonGia.Size = new Size(200, 22);
      this.spnDonGia.TabIndex = 39;
      this.spnDonGia.EditValueChanged += new EventHandler(this.spnDonGia_EditValueChanged);
      this.lueDonVi.Location = new Point(200, 130);
      this.lueDonVi.Name = "lueDonVi";
      this.lueDonVi.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueDonVi.Properties.Appearance.Options.UseFont = true;
      this.lueDonVi.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueDonVi.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("DisplayText", "Đơn vị")
      });
      this.lueDonVi.Properties.DisplayMember = "DisplayText";
      this.lueDonVi.Properties.NullText = "";
      this.lueDonVi.Properties.ValueMember = "ID";
      this.lueDonVi.Size = new Size(200, 22);
      this.lueDonVi.TabIndex = 38;
      this.lueDonVi.EditValueChanged += new EventHandler(this.lueDonVi_EditValueChanged);
      this.lblDonGia.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDonGia.Appearance.Options.UseFont = true;
      this.lblDonGia.Location = new Point(130, 163);
      this.lblDonGia.Margin = new Padding(2);
      this.lblDonGia.Name = "lblDonGia";
      this.lblDonGia.Size = new Size(46, 16);
      this.lblDonGia.TabIndex = 36;
      this.lblDonGia.Text = "Đơn giá";
      this.lblDonVi.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDonVi.Appearance.Options.UseFont = true;
      this.lblDonVi.Location = new Point(116, 133);
      this.lblDonVi.Margin = new Padding(2);
      this.lblDonVi.Name = "lblDonVi";
      this.lblDonVi.Size = new Size(60, 16);
      this.lblDonVi.TabIndex = 34;
      this.lblDonVi.Text = "Đơn vị tính";
      this.txtNhaCungCap.Location = new Point(200, 100);
      this.txtNhaCungCap.Margin = new Padding(2);
      this.txtNhaCungCap.Name = "txtNhaCungCap";
      this.txtNhaCungCap.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtNhaCungCap.Properties.Appearance.Options.UseFont = true;
      this.txtNhaCungCap.Size = new Size(200, 22);
      this.txtNhaCungCap.TabIndex = 33;
      this.lblNhaCungCap.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblNhaCungCap.Appearance.Options.UseFont = true;
      this.lblNhaCungCap.Location = new Point(93, 103);
      this.lblNhaCungCap.Margin = new Padding(2);
      this.lblNhaCungCap.Name = "lblNhaCungCap";
      this.lblNhaCungCap.Size = new Size(83, 16);
      this.lblNhaCungCap.TabIndex = 32;
      this.lblNhaCungCap.Text = "Nhà cung cấp";
      this.txtMaterialName.Location = new Point(200, 70);
      this.txtMaterialName.Margin = new Padding(2);
      this.txtMaterialName.Name = "txtMaterialName";
      this.txtMaterialName.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaterialName.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaterialName.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaterialName.Properties.Appearance.Options.UseFont = true;
      this.txtMaterialName.Size = new Size(200, 22);
      this.txtMaterialName.TabIndex = 31;
      this.lblTenVatTu.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenVatTu.Appearance.Options.UseFont = true;
      this.lblTenVatTu.Location = new Point(118, 73);
      this.lblTenVatTu.Margin = new Padding(2);
      this.lblTenVatTu.Name = "lblTenVatTu";
      this.lblTenVatTu.Size = new Size(58, 16);
      this.lblTenVatTu.TabIndex = 30;
      this.lblTenVatTu.Text = "Tên vật tư";
      this.lblActive.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblActive.Appearance.Options.UseFont = true;
      this.lblActive.Location = new Point(12, 70);
      this.lblActive.Margin = new Padding(2);
      this.lblActive.Name = "lblActive";
      this.lblActive.Size = new Size(54, 16);
      this.lblActive.TabIndex = 29;
      this.lblActive.Text = "Kích hoạt";
      this.lblActive.Visible = false;
      this.chkActive.Location = new Point(76, 68);
      this.chkActive.Margin = new Padding(2);
      this.chkActive.Name = "chkActive";
      this.chkActive.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkActive.Properties.Appearance.Options.UseFont = true;
      this.chkActive.Properties.Caption = "";
      this.chkActive.Size = new Size(33, 20);
      this.chkActive.TabIndex = 28;
      this.chkActive.Visible = false;
      this.txtDescription.Location = new Point(50, 38);
      this.txtDescription.Margin = new Padding(2);
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDescription.Properties.Appearance.Options.UseFont = true;
      this.txtDescription.Size = new Size(41, 22);
      this.txtDescription.TabIndex = 27;
      this.txtDescription.Visible = false;
      this.txtMaterialCode.Location = new Point(200, 40);
      this.txtMaterialCode.Margin = new Padding(2);
      this.txtMaterialCode.Name = "txtMaterialCode";
      this.txtMaterialCode.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaterialCode.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaterialCode.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaterialCode.Properties.Appearance.Options.UseFont = true;
      this.txtMaterialCode.Properties.ReadOnly = true;
      this.txtMaterialCode.Size = new Size(200, 22);
      this.txtMaterialCode.TabIndex = 25;
      this.lblDescritpion.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDescritpion.Appearance.Options.UseFont = true;
      this.lblDescritpion.Location = new Point(12, 41);
      this.lblDescritpion.Margin = new Padding(2);
      this.lblDescritpion.Name = "lblDescritpion";
      this.lblDescritpion.Size = new Size(33, 16);
      this.lblDescritpion.TabIndex = 24;
      this.lblDescritpion.Text = "Mô tả";
      this.lblDescritpion.Visible = false;
      this.lblMaVatTu.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaVatTu.Appearance.Options.UseFont = true;
      this.lblMaVatTu.Location = new Point(123, 43);
      this.lblMaVatTu.Margin = new Padding(2);
      this.lblMaVatTu.Name = "lblMaVatTu";
      this.lblMaVatTu.Size = new Size(53, 16);
      this.lblMaVatTu.TabIndex = 22;
      this.lblMaVatTu.Text = "Mã vật tư";
      this.pnlCommand.Controls.Add((Control) this.btnClose);
      this.pnlCommand.Controls.Add((Control) this.btnSave);
      this.pnlCommand.Controls.Add((Control) this.btnSaveNew);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 198);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(495, 47);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Location = new Point(312, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 8;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Location = new Point(207, 9);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Location = new Point(74, 9);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 6;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pnlCommand);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewMaterialView);
      this.Size = new Size(495, 245);
      this.pnlMain.EndInit();
      this.spnDonGia.Properties.EndInit();
      this.lueDonVi.Properties.EndInit();
      this.txtNhaCungCap.Properties.EndInit();
      this.txtMaterialName.Properties.EndInit();
      this.chkActive.Properties.EndInit();
      this.txtDescription.Properties.EndInit();
      this.txtMaterialCode.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.ResumeLayout(false);
    }
  }
}

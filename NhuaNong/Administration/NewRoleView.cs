// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.NewRoleView
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
namespace NhuaNong.Administration
{
  public class NewRoleView : ControlViewBase, INewRoleView, IBase
  {
    private NewRoleDataPresenter _presenter;
    private ObjSEC_Role _role;
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl pnlCommand;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private TextEdit txtDesc;
    private TextEdit txtRoleName;
    private LabelControl lblMoTa;
    private LabelControl lblTenVaiTro;

    private bool IsSaveClose { get; set; }

    public ObjSEC_Role Role
    {
      set => this._role = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public NewRoleView()
    {
      this.InitializeComponent();
      this._presenter = new NewRoleDataPresenter((INewRoleView) this);
    }

    public NewRoleView(ObjSEC_Role user, Enums.FormAction action)
      : this()
    {
      this._role = user;
      this.FormAction = action;
      this.SetCaption();
    }

    protected override void SetupLayout() => this.DisableConstrol();

    protected override void PopulateStaticData()
    {
    }

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewRole();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetRoleByKey(this._role.RoleID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtRoleName.DataBindings.Clear();
      this.txtRoleName.DataBindings.Add("Text", (object) this._role, "RoleName");
      this.txtDesc.DataBindings.Clear();
      this.txtDesc.DataBindings.Add("Text", (object) this._role, "Description");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = "Thêm Vai Trò";
          break;
        case Enums.FormAction.Edit:
          this.Caption = "Sửa Vai Trò";
          break;
        case Enums.FormAction.View:
          this.Caption = "Xem Vai Trò";
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtRoleName.Text == string.Empty)
      {
        this.txtRoleName.ErrorText = "Tên Vai Trò is required.";
        flag = false;
      }
      return flag;
    }

    private void DisableConstrol()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.Edit:
          this.btnSave.Visible = true;
          break;
        case Enums.FormAction.View:
          this.txtRoleName.Properties.ReadOnly = true;
          this.txtDesc.Properties.ReadOnly = true;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjSEC_Role> blstCT = new BindingList<ObjSEC_Role>();
      blstCT.Add(this._role);
      this._presenter.SaveRole(blstCT);
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
        this._presenter.BuildNewRole();
        this.BindData();
      }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = false;
      this.SaveData();
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlMain = new PanelControl();
      this.txtDesc = new TextEdit();
      this.txtRoleName = new TextEdit();
      this.lblMoTa = new LabelControl();
      this.lblTenVaiTro = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.txtDesc.Properties.BeginInit();
      this.txtRoleName.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.txtDesc);
      this.pnlMain.Controls.Add((Control) this.txtRoleName);
      this.pnlMain.Controls.Add((Control) this.lblMoTa);
      this.pnlMain.Controls.Add((Control) this.lblTenVaiTro);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(495, 245);
      this.pnlMain.TabIndex = 0;
      this.txtDesc.Location = new Point(200, 110);
      this.txtDesc.Margin = new Padding(2);
      this.txtDesc.Name = "txtDesc";
      this.txtDesc.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDesc.Properties.Appearance.Options.UseFont = true;
      this.txtDesc.Size = new Size(200, 22);
      this.txtDesc.TabIndex = 3;
      this.txtRoleName.Location = new Point(200, 80);
      this.txtRoleName.Margin = new Padding(2);
      this.txtRoleName.Name = "txtRoleName";
      this.txtRoleName.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtRoleName.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtRoleName.Properties.Appearance.Options.UseBackColor = true;
      this.txtRoleName.Properties.Appearance.Options.UseFont = true;
      this.txtRoleName.Size = new Size(200, 22);
      this.txtRoleName.TabIndex = 2;
      this.lblMoTa.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMoTa.Appearance.Options.UseFont = true;
      this.lblMoTa.Location = new Point(131, 113);
      this.lblMoTa.Margin = new Padding(2);
      this.lblMoTa.Name = "lblMoTa";
      this.lblMoTa.Size = new Size(32, 16);
      this.lblMoTa.TabIndex = 1;
      this.lblMoTa.Text = "Mô tả";
      this.lblTenVaiTro.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenVaiTro.Appearance.Options.UseFont = true;
      this.lblTenVaiTro.Location = new Point(99, 83);
      this.lblTenVaiTro.Margin = new Padding(2);
      this.lblTenVaiTro.Name = "lblTenVaiTro";
      this.lblTenVaiTro.Size = new Size(64, 16);
      this.lblTenVaiTro.TabIndex = 0;
      this.lblTenVaiTro.Text = "Tên Vai trò";
      this.pnlCommand.Controls.Add((Control) this.btnClose);
      this.pnlCommand.Controls.Add((Control) this.btnSave);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 198);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(495, 47);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(254, 7);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(147, 7);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pnlCommand);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewRoleView);
      this.Size = new Size(495, 245);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.txtDesc.Properties.EndInit();
      this.txtRoleName.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Administration.NewUserView
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
  public class NewUserView : ControlViewBase, IBase, INewUserView
  {
    private NewUserDataPresenter _presenter;
    private ObjSEC_User _user;
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl pnlCommand;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;
    private LabelControl lblKichHoat;
    private LabelControl lblPhone;
    private LabelControl lblEmail;
    private LabelControl lblHoTen;
    private LabelControl lblMatKhau;
    private LabelControl lblTenDangNhap;
    private TextEdit txtEmail;
    private TextEdit txtFullName;
    private TextEdit txtPass;
    private TextEdit txtUserName;
    private TextEdit txtPhone;
    private CheckEdit chkIsActive;

    private bool IsSaveClose { get; set; }

    public ObjSEC_User User
    {
      set => this._user = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public NewUserView()
    {
      this.InitializeComponent();
      this._presenter = new NewUserDataPresenter((INewUserView) this);
    }

    public NewUserView(ObjSEC_User user, Enums.FormAction action)
      : this()
    {
      this._user = user;
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
          this._presenter.BuildNewUser();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetUserByKey(this._user.UserID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtUserName.DataBindings.Clear();
      this.txtUserName.DataBindings.Add("Text", (object) this._user, "UserName");
      this.txtPass.DataBindings.Clear();
      this.txtPass.DataBindings.Add("Text", (object) this._user, "Password");
      this.txtFullName.DataBindings.Clear();
      this.txtFullName.DataBindings.Add("Text", (object) this._user, "FullName");
      this.txtEmail.DataBindings.Clear();
      this.txtEmail.DataBindings.Add("Text", (object) this._user, "Email");
      this.txtPhone.DataBindings.Clear();
      this.txtPhone.DataBindings.Add("Text", (object) this._user, "Phone");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = "THÊM NGƯỜI DÙNG";
          break;
        case Enums.FormAction.Edit:
          this.Caption = "CẬP NHẬT THÔNG TIN NGƯỜI DÙNG";
          break;
        case Enums.FormAction.View:
          this.Caption = "XEM THÔNG TIN NGƯỜI DÙNG";
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtUserName.Text == string.Empty)
      {
        this.txtUserName.ErrorText = "Tên Đăng Nhập is required.";
        flag = false;
      }
      if (this.txtPass.Text == string.Empty && this.txtPass.Text.Length > 30)
      {
        this.txtPass.ErrorText = "Mật Mã is required.";
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
          this.txtUserName.Properties.ReadOnly = true;
          this.txtPass.Properties.ReadOnly = true;
          this.txtFullName.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjSEC_User> blstCT = new BindingList<ObjSEC_User>();
      this._user.IsActived = new bool?(true);
      blstCT.Add(this._user);
      this._presenter.SaveUser(blstCT);
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
        this._presenter.BuildNewUser();
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

    private void chkIsActive_CheckedChanged(object sender, EventArgs e)
    {
      this._user.IsActived = new bool?(this.chkIsActive.Checked);
    }

    private void txtPass_EditValueChanged(object sender, EventArgs e)
    {
      if (this.txtPass.Text.Length <= 30)
        return;
      TramTromMessageBox.ShowWarningDialog("Mật khẩu vượt quá 30 ký tự!");
      this.txtPass.Text = string.Empty;
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
      this.chkIsActive = new CheckEdit();
      this.txtPhone = new TextEdit();
      this.txtEmail = new TextEdit();
      this.txtFullName = new TextEdit();
      this.txtPass = new TextEdit();
      this.txtUserName = new TextEdit();
      this.lblKichHoat = new LabelControl();
      this.lblPhone = new LabelControl();
      this.lblEmail = new LabelControl();
      this.lblHoTen = new LabelControl();
      this.lblMatKhau = new LabelControl();
      this.lblTenDangNhap = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.chkIsActive.Properties.BeginInit();
      this.txtPhone.Properties.BeginInit();
      this.txtEmail.Properties.BeginInit();
      this.txtFullName.Properties.BeginInit();
      this.txtPass.Properties.BeginInit();
      this.txtUserName.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.chkIsActive);
      this.pnlMain.Controls.Add((Control) this.txtPhone);
      this.pnlMain.Controls.Add((Control) this.txtEmail);
      this.pnlMain.Controls.Add((Control) this.txtFullName);
      this.pnlMain.Controls.Add((Control) this.txtPass);
      this.pnlMain.Controls.Add((Control) this.txtUserName);
      this.pnlMain.Controls.Add((Control) this.lblKichHoat);
      this.pnlMain.Controls.Add((Control) this.lblPhone);
      this.pnlMain.Controls.Add((Control) this.lblEmail);
      this.pnlMain.Controls.Add((Control) this.lblHoTen);
      this.pnlMain.Controls.Add((Control) this.lblMatKhau);
      this.pnlMain.Controls.Add((Control) this.lblTenDangNhap);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(495, 245);
      this.pnlMain.TabIndex = 0;
      this.chkIsActive.Location = new Point(17, 117);
      this.chkIsActive.Margin = new Padding(2);
      this.chkIsActive.Name = "chkIsActive";
      this.chkIsActive.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkIsActive.Properties.Appearance.Options.UseFont = true;
      this.chkIsActive.Properties.Caption = "";
      this.chkIsActive.Size = new Size(20, 20);
      this.chkIsActive.TabIndex = 11;
      this.chkIsActive.Visible = false;
      this.chkIsActive.CheckedChanged += new EventHandler(this.chkIsActive_CheckedChanged);
      this.txtPhone.Location = new Point(200, 150);
      this.txtPhone.Margin = new Padding(2);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPhone.Properties.Appearance.Options.UseFont = true;
      this.txtPhone.Size = new Size(200, 22);
      this.txtPhone.TabIndex = 10;
      this.txtEmail.Location = new Point(200, 120);
      this.txtEmail.Margin = new Padding(2);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtEmail.Properties.Appearance.Options.UseFont = true;
      this.txtEmail.Size = new Size(200, 22);
      this.txtEmail.TabIndex = 9;
      this.txtFullName.Location = new Point(200, 90);
      this.txtFullName.Margin = new Padding(2);
      this.txtFullName.Name = "txtFullName";
      this.txtFullName.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtFullName.Properties.Appearance.Options.UseFont = true;
      this.txtFullName.Size = new Size(200, 22);
      this.txtFullName.TabIndex = 8;
      this.txtPass.Location = new Point(200, 60);
      this.txtPass.Margin = new Padding(2);
      this.txtPass.Name = "txtPass";
      this.txtPass.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPass.Properties.Appearance.Options.UseFont = true;
      this.txtPass.Properties.PasswordChar = '*';
      this.txtPass.Size = new Size(200, 22);
      this.txtPass.TabIndex = 7;
      this.txtPass.EditValueChanged += new EventHandler(this.txtPass_EditValueChanged);
      this.txtUserName.Location = new Point(200, 30);
      this.txtUserName.Margin = new Padding(2);
      this.txtUserName.Name = "txtUserName";
      this.txtUserName.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtUserName.Properties.Appearance.Options.UseFont = true;
      this.txtUserName.Size = new Size(200, 22);
      this.txtUserName.TabIndex = 6;
      this.lblKichHoat.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKichHoat.Appearance.Options.UseFont = true;
      this.lblKichHoat.Location = new Point(17, 91);
      this.lblKichHoat.Margin = new Padding(2);
      this.lblKichHoat.Name = "lblKichHoat";
      this.lblKichHoat.Size = new Size(52, 16);
      this.lblKichHoat.TabIndex = 5;
      this.lblKichHoat.Text = "Kích hoạt";
      this.lblKichHoat.Visible = false;
      this.lblPhone.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Location = new Point(112, 153);
      this.lblPhone.Margin = new Padding(2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(58, 16);
      this.lblPhone.TabIndex = 4;
      this.lblPhone.Text = "Điện thoại";
      this.lblEmail.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblEmail.Appearance.Options.UseFont = true;
      this.lblEmail.Location = new Point(139, 123);
      this.lblEmail.Margin = new Padding(2);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new Size(31, 16);
      this.lblEmail.TabIndex = 3;
      this.lblEmail.Text = "Email";
      this.lblHoTen.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblHoTen.Appearance.Options.UseFont = true;
      this.lblHoTen.Location = new Point(133, 93);
      this.lblHoTen.Margin = new Padding(2);
      this.lblHoTen.Name = "lblHoTen";
      this.lblHoTen.Size = new Size(37, 16);
      this.lblHoTen.TabIndex = 2;
      this.lblHoTen.Text = "Họ tên";
      this.lblMatKhau.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMatKhau.Appearance.Options.UseFont = true;
      this.lblMatKhau.Location = new Point(118, 63);
      this.lblMatKhau.Margin = new Padding(2);
      this.lblMatKhau.Name = "lblMatKhau";
      this.lblMatKhau.Size = new Size(52, 16);
      this.lblMatKhau.TabIndex = 1;
      this.lblMatKhau.Text = "Mật khẩu";
      this.lblTenDangNhap.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenDangNhap.Appearance.Options.UseFont = true;
      this.lblTenDangNhap.Location = new Point(82, 33);
      this.lblTenDangNhap.Margin = new Padding(2);
      this.lblTenDangNhap.Name = "lblTenDangNhap";
      this.lblTenDangNhap.Size = new Size(88, 16);
      this.lblTenDangNhap.TabIndex = 0;
      this.lblTenDangNhap.Text = "Tên Đăng nhập";
      this.pnlCommand.Controls.Add((Control) this.btnClose);
      this.pnlCommand.Controls.Add((Control) this.btnSave);
      this.pnlCommand.Controls.Add((Control) this.btnSaveNew);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 198);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(495, 47);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(312, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 2;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(207, 9);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSaveNew.Appearance.Options.UseFont = true;
      this.btnSaveNew.Location = new Point(74, 9);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 0;
      this.btnSaveNew.Text = "Lưu và Thêm mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pnlCommand);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewUserView);
      this.Size = new Size(495, 245);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.chkIsActive.Properties.EndInit();
      this.txtPhone.Properties.EndInit();
      this.txtEmail.Properties.EndInit();
      this.txtFullName.Properties.EndInit();
      this.txtPass.Properties.EndInit();
      this.txtUserName.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

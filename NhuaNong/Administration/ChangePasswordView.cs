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
  public partial class ChangePasswordView : DialogViewBase, IChangePasswordView, IBase
  {
    private ChangePasswordDataPresenter _presenter;
    private ObjSEC_User _loginUser;
    private string enPassword;
    private string enPasswordNew;
    //private IContainer components;
    //private GroupBox txtConfirmPass;
    //private LabelControl lblConfirmNewPass;
    //private LabelControl lblNewPass;
    //private LabelControl lblOldPass;
    //private GroupBox grbCommand;
    //private SimpleButton btnCancel;
    //private SimpleButton btnOk;
    //private TextBox txtNewPass;
    //private TextBox txtOldPass;
    //private TextBox txtConfirmPass1;

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public ChangePasswordView()
    {
      this.InitializeComponent();
      this.Name = nameof(ChangePasswordView);
      this.Text = nameof(ChangePasswordView);
      this._presenter = new ChangePasswordDataPresenter((IChangePasswordView)this);
      this.Text = "Thay đổi mật khẩu";
    }

    public ChangePasswordView(ObjSEC_User loginUser)
      : this()
    {
      this._loginUser = loginUser;
    }

    protected override void AdjustCulture()
    {
    }

    private bool ValidateData()
    {
      this.enPassword = EncryptionHelper.Encrypt(this.txtOldPass.Text);
      if (this.enPassword != this._loginUser.Password)
      {
        TramTromMessageBox.ShowMessageDialog("Old Password is not correct.");
        return false;
      }
      if (!(this.txtNewPass.Text != this.txtConfirmPass1.Text))
        return true;
      TramTromMessageBox.ShowMessageDialog("New Password doesn't match the Confirmation Password.");
      return false;
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (isSuccess)
        this.Close();
      else
        TramTromMessageBox.ShowErrorDialog("Error in updating Password.");
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      if (!this.ValidateData())
        return;
      this.enPasswordNew = EncryptionHelper.Encrypt(this.txtNewPass.Text);
      this._loginUser.Password = this.enPasswordNew;
      BindingList<ObjSEC_User> blstUser = new BindingList<ObjSEC_User>();
      blstUser.Add(this._loginUser);
      this._presenter.SaveUser(blstUser);
    }

    private void btnCancel_Click(object sender, EventArgs e) => this.Close();

    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //}

    //private void InitializeComponent()
    //{
    //  this.txtConfirmPass = new GroupBox();
    //  this.txtConfirmPass1 = new TextBox();
    //  this.txtNewPass = new TextBox();
    //  this.txtOldPass = new TextBox();
    //  this.lblConfirmNewPass = new LabelControl();
    //  this.lblNewPass = new LabelControl();
    //  this.lblOldPass = new LabelControl();
    //  this.grbCommand = new GroupBox();
    //  this.btnCancel = new SimpleButton();
    //  this.btnOk = new SimpleButton();
    //  this.txtConfirmPass.SuspendLayout();
    //  this.grbCommand.SuspendLayout();
    //  this.SuspendLayout();
    //  this.txtConfirmPass.Controls.Add((Control) this.txtConfirmPass1);
    //  this.txtConfirmPass.Controls.Add((Control) this.txtNewPass);
    //  this.txtConfirmPass.Controls.Add((Control) this.txtOldPass);
    //  this.txtConfirmPass.Controls.Add((Control) this.lblConfirmNewPass);
    //  this.txtConfirmPass.Controls.Add((Control) this.lblNewPass);
    //  this.txtConfirmPass.Controls.Add((Control) this.lblOldPass);
    //  this.txtConfirmPass.Dock = DockStyle.Fill;
    //  this.txtConfirmPass.Location = new Point(0, 0);
    //  this.txtConfirmPass.Name = "txtConfirmPass";
    //  this.txtConfirmPass.Size = new Size(477, 221);
    //  this.txtConfirmPass.TabIndex = 0;
    //  this.txtConfirmPass.TabStop = false;
    //  this.txtConfirmPass1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.txtConfirmPass1.Location = new Point(188, 112);
    //  this.txtConfirmPass1.Name = "txtConfirmPass1";
    //  this.txtConfirmPass1.PasswordChar = '*';
    //  this.txtConfirmPass1.Size = new Size(200, 23);
    //  this.txtConfirmPass1.TabIndex = 5;
    //  this.txtNewPass.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.txtNewPass.Location = new Point(188, 77);
    //  this.txtNewPass.MaxLength = 30;
    //  this.txtNewPass.Name = "txtNewPass";
    //  this.txtNewPass.PasswordChar = '*';
    //  this.txtNewPass.Size = new Size(200, 23);
    //  this.txtNewPass.TabIndex = 4;
    //  this.txtOldPass.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.txtOldPass.Location = new Point(188, 48);
    //  this.txtOldPass.Name = "txtOldPass";
    //  this.txtOldPass.Size = new Size(200, 23);
    //  this.txtOldPass.TabIndex = 3;
    //  this.lblConfirmNewPass.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.lblConfirmNewPass.Appearance.Options.UseFont = true;
    //  this.lblConfirmNewPass.Location = new Point(49, 115);
    //  this.lblConfirmNewPass.Name = "lblConfirmNewPass";
    //  this.lblConfirmNewPass.Size = new Size(128, 16);
    //  this.lblConfirmNewPass.TabIndex = 2;
    //  this.lblConfirmNewPass.Text = "Nhập lại mật khẩu mới";
    //  this.lblNewPass.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.lblNewPass.Appearance.Options.UseFont = true;
    //  this.lblNewPass.Location = new Point(49, 80);
    //  this.lblNewPass.Name = "lblNewPass";
    //  this.lblNewPass.Size = new Size(111, 16);
    //  this.lblNewPass.TabIndex = 1;
    //  this.lblNewPass.Text = "Nhập mật khẩu mới";
    //  this.lblOldPass.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.lblOldPass.Appearance.Options.UseFont = true;
    //  this.lblOldPass.Location = new Point(49, 51);
    //  this.lblOldPass.Name = "lblOldPass";
    //  this.lblOldPass.Size = new Size(103, 16);
    //  this.lblOldPass.TabIndex = 0;
    //  this.lblOldPass.Text = "Nhập mật khẩu cũ";
    //  this.grbCommand.Controls.Add((Control) this.btnCancel);
    //  this.grbCommand.Controls.Add((Control) this.btnOk);
    //  this.grbCommand.Dock = DockStyle.Bottom;
    //  this.grbCommand.Location = new Point(0, 171);
    //  this.grbCommand.Name = "grbCommand";
    //  this.grbCommand.Size = new Size(477, 50);
    //  this.grbCommand.TabIndex = 1;
    //  this.grbCommand.TabStop = false;
    //  this.btnCancel.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.btnCancel.Appearance.Options.UseFont = true;
    //  this.btnCancel.Location = new Point(263, 14);
    //  this.btnCancel.Name = "btnCancel";
    //  this.btnCancel.Size = new Size(98, 30);
    //  this.btnCancel.TabIndex = 1;
    //  this.btnCancel.Text = "Huỷ Bỏ";
    //  this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    //  this.btnOk.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.btnOk.Appearance.Options.UseFont = true;
    //  this.btnOk.Location = new Point(141, 14);
    //  this.btnOk.Name = "btnOk";
    //  this.btnOk.Size = new Size(98, 30);
    //  this.btnOk.TabIndex = 0;
    //  this.btnOk.Text = "Đồng Ý";
    //  this.btnOk.Click += new EventHandler(this.btnOk_Click);
    //  this.AutoScaleDimensions = new SizeF(6f, 13f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(477, 221);
    //  this.Controls.Add((Control) this.grbCommand);
    //  this.Controls.Add((Control) this.txtConfirmPass);
    //  this.IconOptions.Image = (Image) ResourceNhua.logoV_64;
    //  this.Name = nameof (ChangePasswordView);
    //  this.Text = nameof (ChangePasswordView);
    //  this.txtConfirmPass.ResumeLayout(false);
    //  this.txtConfirmPass.PerformLayout();
    //  this.grbCommand.ResumeLayout(false);
    //  this.ResumeLayout(false);
    //}
  }
}

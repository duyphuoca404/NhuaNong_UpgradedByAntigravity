using DevExpress.Utils;
using DevExpress.XtraEditors;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.ServiceModel;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Administration
{
  public partial class LoginView : DialogViewBase, ILoginView, IBase
  {
    private LoginDataPresenter _presenter;
    private ObjSEC_User _loginUser;
    private string decryptedPassword;
    //private IContainer components;
    //private PanelControl pnlMain;
    //private LabelControl lblPassword;
    //private LabelControl lblUsername;
    //private PanelControl pnlCommand;
    //private SimpleButton btnLogin;
    //private TextEdit txtPassword;
    //private TextEdit txtUserName;
    //private SimpleButton btnCancel;

    public LoginView()
    {
      this.InitializeComponent();
      this.Name = nameof(LoginView);
      this.Text = nameof(LoginView);
      this._presenter = new LoginDataPresenter((ILoginView) this);
      this.Text = "Đăng nhập";
      if (!ConfigManager.TramTronConfig.DevEnv)
        return;
      this.txtUserName.Text = "manager";
      this.txtPassword.Text = "manager";
    }

    public ObjSEC_User LoginUser
    {
      get => this._loginUser;
      set => this._loginUser = value;
    }

    protected override void AdjustCulture()
    {
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      try
      {
        this._presenter.GetSEC_User_ByUsername_Pass(this.txtUserName.Text, this.txtPassword.Text);
        if (this._loginUser == null)
          TramTromMessageBox.ShowErrorDialog("Tên đăng nhập không tồn tại");
        else if (!this._loginUser.IsActived.Value)
        {
          TramTromMessageBox.ShowErrorDialog("Tên đăng nhập không chưa được cấp phép hoạt động");
        }
        else
        {
          GlobalValues.DisplayUser = this._loginUser.UserName;
          GlobalValues.DisplayRole = this._loginUser.NPOtherInfo;
          this.DialogResult = DialogResult.OK;
          this.Close();
          EventLogController.InsertEventLog(new int?(this._loginUser.UserID), this._loginUser.UserName, "LOG_IN", string.Empty, string.Empty, string.Empty);
        }
      }
      catch (WebException ex)
      {
        int num = (int) MessageBox.Show("Không thể kết nối");
      }
      catch (TimeoutException ex)
      {
        int num = (int) MessageBox.Show("Không thể kết nối");
      }
      catch (CommunicationException ex)
      {
        int num = (int) MessageBox.Show("Không thể kết nối");
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void btnOk_Enter(object sender, EventArgs e)
    {
    }

    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Return)
        return;
      e.Handled = true;
      e.SuppressKeyPress = true;
      try
      {
        this._presenter.GetSEC_User_ByUsername_Pass(this.txtUserName.Text, this.txtPassword.Text);
        if (this._loginUser == null)
          TramTromMessageBox.ShowErrorDialog("Tên đăng nhập không tồn tại");
        else if (!this._loginUser.IsActived.Value)
        {
          TramTromMessageBox.ShowErrorDialog("Tên đăng nhập không chưa được cấp phép hoạt động");
        }
        else
        {
          GlobalValues.DisplayUser = this._loginUser.UserName;
          GlobalValues.DisplayRole = this._loginUser.NPOtherInfo;
          this.DialogResult = DialogResult.OK;
          this.Close();
          EventLogController.InsertEventLog(new int?(this._loginUser.UserID), this._loginUser.UserName, "LOG_IN", string.Empty, string.Empty, string.Empty);
        }
      }
      catch (WebException ex)
      {
        TramTromMessageBox.ShowErrorDialog("Không thể kết nối");
      }
      catch (TimeoutException ex)
      {
        TramTromMessageBox.ShowErrorDialog("Không thể kết nối");
      }
      catch (CommunicationException ex)
      {
        TramTromMessageBox.ShowErrorDialog("Không thể kết nối");
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
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
    //  this.pnlMain = new PanelControl();
    //  this.lblPassword = new LabelControl();
    //  this.lblUsername = new LabelControl();
    //  this.pnlCommand = new PanelControl();
    //  this.btnCancel = new SimpleButton();
    //  this.btnLogin = new SimpleButton();
    //  this.txtPassword = new TextEdit();
    //  this.txtUserName = new TextEdit();
    //  this.pnlMain.BeginInit();
    //  this.pnlMain.SuspendLayout();
    //  this.pnlCommand.BeginInit();
    //  this.pnlCommand.SuspendLayout();
    //  this.txtPassword.Properties.BeginInit();
    //  this.txtUserName.Properties.BeginInit();
    //  this.SuspendLayout();
    //  this.pnlMain.Controls.Add((Control) this.txtPassword);
    //  this.pnlMain.Controls.Add((Control) this.txtUserName);
    //  this.pnlMain.Controls.Add((Control) this.lblPassword);
    //  this.pnlMain.Controls.Add((Control) this.lblUsername);
    //  this.pnlMain.Dock = DockStyle.Fill;
    //  this.pnlMain.Location = new Point(0, 0);
    //  this.pnlMain.Name = "pnlMain";
    //  this.pnlMain.Size = new Size(441, 174);
    //  this.pnlMain.TabIndex = 0;
    //  this.lblPassword.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.lblPassword.Appearance.Options.UseFont = true;
    //  this.lblPassword.Appearance.Options.UseTextOptions = true;
    //  this.lblPassword.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
    //  this.lblPassword.AutoSizeMode = LabelAutoSizeMode.None;
    //  this.lblPassword.Location = new Point(29, 72);
    //  this.lblPassword.Name = "lblPassword";
    //  this.lblPassword.Size = new Size(103, 16);
    //  this.lblPassword.TabIndex = 1;
    //  this.lblPassword.Text = "Mật khẩu";
    //  this.lblUsername.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.lblUsername.Appearance.Options.UseFont = true;
    //  this.lblUsername.Appearance.Options.UseTextOptions = true;
    //  this.lblUsername.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
    //  this.lblUsername.AutoSizeMode = LabelAutoSizeMode.None;
    //  this.lblUsername.Location = new Point(29, 36);
    //  this.lblUsername.Name = "lblUsername";
    //  this.lblUsername.Size = new Size(103, 16);
    //  this.lblUsername.TabIndex = 0;
    //  this.lblUsername.Text = "Tên đăng nhập";
    //  this.pnlCommand.Controls.Add((Control) this.btnCancel);
    //  this.pnlCommand.Controls.Add((Control) this.btnLogin);
    //  this.pnlCommand.Dock = DockStyle.Bottom;
    //  this.pnlCommand.Location = new Point(0, 122);
    //  this.pnlCommand.Name = "pnlCommand";
    //  this.pnlCommand.Size = new Size(441, 52);
    //  this.pnlCommand.TabIndex = 1;
    //  this.btnCancel.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.btnCancel.Appearance.Options.UseFont = true;
    //  this.btnCancel.Location = new Point(240, 11);
    //  this.btnCancel.Name = "btnCancel";
    //  this.btnCancel.Size = new Size(86, 30);
    //  this.btnCancel.TabIndex = 1;
    //  this.btnCancel.Text = "Thoát";
    //  this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
    //  this.btnLogin.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.btnLogin.Appearance.Options.UseFont = true;
    //  this.btnLogin.Location = new Point(97, 11);
    //  this.btnLogin.Name = "btnLogin";
    //  this.btnLogin.Size = new Size(111, 30);
    //  this.btnLogin.TabIndex = 0;
    //  this.btnLogin.Text = "Đăng nhập";
    //  this.btnLogin.Click += new EventHandler(this.btnOk_Click);
    //  this.btnLogin.Enter += new EventHandler(this.btnOk_Enter);
    //  this.txtPassword.Location = new Point(146, 69);
    //  this.txtPassword.Name = "txtPassword";
    //  this.txtPassword.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.txtPassword.Properties.Appearance.Options.UseFont = true;
    //  this.txtPassword.Properties.PasswordChar = '*';
    //  this.txtPassword.Size = new Size(200, 22);
    //  this.txtPassword.TabIndex = 3;
    //  this.txtPassword.KeyDown += new KeyEventHandler(this.txtPassword_KeyDown);
    //  this.txtUserName.Location = new Point(146, 33);
    //  this.txtUserName.Name = "txtUserName";
    //  this.txtUserName.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    //  this.txtUserName.Properties.Appearance.Options.UseFont = true;
    //  this.txtUserName.Size = new Size(200, 22);
    //  this.txtUserName.TabIndex = 2;
    //  this.AutoScaleDimensions = new SizeF(6f, 13f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(441, 174);
    //  this.Controls.Add((Control) this.pnlCommand);
    //  this.Controls.Add((Control) this.pnlMain);
    //  this.IconOptions.Image = (Image) ResourceNhua.logoV_64;
    //  this.Name = nameof (LoginView);
    //  this.Text = "Login View";
    //  this.pnlMain.EndInit();
    //  this.pnlMain.ResumeLayout(false);
    //  this.pnlCommand.EndInit();
    //  this.pnlCommand.ResumeLayout(false);
    //  this.txtPassword.Properties.EndInit();
    //  this.txtUserName.Properties.EndInit();
    //  this.ResumeLayout(false);
    //}
  }
}

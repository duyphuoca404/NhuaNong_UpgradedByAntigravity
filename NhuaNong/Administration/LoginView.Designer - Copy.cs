namespace NhuaNong.Administration
{
	// Token: 0x02000236 RID: 566
	public partial class LoginView : global::NhuaNong.DialogViewBase, global::NhuaNong.Administration.ILoginView, global::NhuaNong.IBase
	{
		// Token: 0x06003120 RID: 12576 RVA: 0x000FE46C File Offset: 0x000FC66C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000FE48C File Offset: 0x000FC68C
		private void InitializeComponent()
		{
			this.pnlMain = new global::DevExpress.XtraEditors.PanelControl();
			this.lblPassword = new global::DevExpress.XtraEditors.LabelControl();
			this.lblUsername = new global::DevExpress.XtraEditors.LabelControl();
			this.pnlCommand = new global::DevExpress.XtraEditors.PanelControl();
			this.btnCancel = new global::DevExpress.XtraEditors.SimpleButton();
			this.btnLogin = new global::DevExpress.XtraEditors.SimpleButton();
			this.txtPassword = new global::DevExpress.XtraEditors.TextEdit();
			this.txtUserName = new global::DevExpress.XtraEditors.TextEdit();
			((global::System.ComponentModel.ISupportInitialize)this.pnlMain).BeginInit();
			this.pnlMain.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pnlCommand).BeginInit();
			this.pnlCommand.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtPassword.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtUserName.Properties).BeginInit();
			base.SuspendLayout();
			this.pnlMain.Controls.Add(this.txtPassword);
			this.pnlMain.Controls.Add(this.txtUserName);
			this.pnlMain.Controls.Add(this.lblPassword);
			this.pnlMain.Controls.Add(this.lblUsername);
			this.pnlMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pnlMain.Location = new global::System.Drawing.Point(0, 0);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new global::System.Drawing.Size(441, 174);
			this.pnlMain.TabIndex = 0;
			this.lblPassword.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPassword.Appearance.Options.UseFont = true;
			this.lblPassword.Appearance.Options.UseTextOptions = true;
			this.lblPassword.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblPassword.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblPassword.Location = new global::System.Drawing.Point(29, 72);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new global::System.Drawing.Size(103, 16);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "Mật khẩu";
			this.lblUsername.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblUsername.Appearance.Options.UseFont = true;
			this.lblUsername.Appearance.Options.UseTextOptions = true;
			this.lblUsername.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblUsername.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblUsername.Location = new global::System.Drawing.Point(29, 36);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new global::System.Drawing.Size(103, 16);
			this.lblUsername.TabIndex = 0;
			this.lblUsername.Text = "Tên đăng nhập";
			this.pnlCommand.Controls.Add(this.btnCancel);
			this.pnlCommand.Controls.Add(this.btnLogin);
			this.pnlCommand.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.pnlCommand.Location = new global::System.Drawing.Point(0, 122);
			this.pnlCommand.Name = "pnlCommand";
			this.pnlCommand.Size = new global::System.Drawing.Size(441, 52);
			this.pnlCommand.TabIndex = 1;
			this.btnCancel.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.Appearance.Options.UseFont = true;
			this.btnCancel.Location = new global::System.Drawing.Point(240, 11);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(86, 30);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Thoát";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnLogin.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnLogin.Appearance.Options.UseFont = true;
			this.btnLogin.Location = new global::System.Drawing.Point(97, 11);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new global::System.Drawing.Size(111, 30);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.Click += new global::System.EventHandler(this.btnOk_Click);
			this.btnLogin.Enter += new global::System.EventHandler(this.btnOk_Enter);
			this.txtPassword.Location = new global::System.Drawing.Point(146, 69);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.Properties.Appearance.Options.UseFont = true;
			this.txtPassword.Properties.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(200, 22);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
			this.txtUserName.Location = new global::System.Drawing.Point(146, 33);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtUserName.Properties.Appearance.Options.UseFont = true;
			this.txtUserName.Size = new global::System.Drawing.Size(200, 22);
			this.txtUserName.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(441, 174);
			base.Controls.Add(this.pnlCommand);
			base.Controls.Add(this.pnlMain);
			base.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
			base.Name = "LoginView";
			this.Text = "Login View";
			((global::System.ComponentModel.ISupportInitialize)this.pnlMain).EndInit();
			this.pnlMain.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pnlCommand).EndInit();
			this.pnlCommand.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.txtPassword.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtUserName.Properties).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001E3B RID: 7739
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04001E3C RID: 7740
		private global::DevExpress.XtraEditors.PanelControl pnlMain;

		// Token: 0x04001E3D RID: 7741
		private global::DevExpress.XtraEditors.LabelControl lblPassword;

		// Token: 0x04001E3E RID: 7742
		private global::DevExpress.XtraEditors.LabelControl lblUsername;

		// Token: 0x04001E3F RID: 7743
		private global::DevExpress.XtraEditors.PanelControl pnlCommand;

		// Token: 0x04001E40 RID: 7744
		private global::DevExpress.XtraEditors.SimpleButton btnLogin;

		// Token: 0x04001E41 RID: 7745
		private global::DevExpress.XtraEditors.TextEdit txtPassword;

		// Token: 0x04001E42 RID: 7746
		private global::DevExpress.XtraEditors.TextEdit txtUserName;

		// Token: 0x04001E43 RID: 7747
		private global::DevExpress.XtraEditors.SimpleButton btnCancel;
	}
}

using DevExpress.XtraEditors;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace NhuaNong.Administration
{
  public partial class ChangePasswordView : DialogViewBase, IChangePasswordView, IBase
  {

    private IContainer components;
    private GroupBox txtConfirmPass;
    private LabelControl lblConfirmNewPass;
    private LabelControl lblNewPass;
    private LabelControl lblOldPass;
    private GroupBox grbCommand;
    private SimpleButton btnCancel;
    private SimpleButton btnOk;
    private TextBox txtNewPass;
    private TextBox txtOldPass;
    private TextBox txtConfirmPass1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.txtConfirmPass = new GroupBox();
      this.txtConfirmPass1 = new TextBox();
      this.txtNewPass = new TextBox();
      this.txtOldPass = new TextBox();
      this.lblConfirmNewPass = new LabelControl();
      this.lblNewPass = new LabelControl();
      this.lblOldPass = new LabelControl();
      this.grbCommand = new GroupBox();
      this.btnCancel = new SimpleButton();
      this.btnOk = new SimpleButton();
      this.txtConfirmPass.SuspendLayout();
      this.grbCommand.SuspendLayout();
      this.SuspendLayout();
      this.txtConfirmPass.Controls.Add((Control)this.txtConfirmPass1);
      this.txtConfirmPass.Controls.Add((Control)this.txtNewPass);
      this.txtConfirmPass.Controls.Add((Control)this.txtOldPass);
      this.txtConfirmPass.Controls.Add((Control)this.lblConfirmNewPass);
      this.txtConfirmPass.Controls.Add((Control)this.lblNewPass);
      this.txtConfirmPass.Controls.Add((Control)this.lblOldPass);
      this.txtConfirmPass.Dock = DockStyle.Fill;
      this.txtConfirmPass.Location = new Point(0, 0);
      this.txtConfirmPass.Name = "txtConfirmPass";
      this.txtConfirmPass.Size = new Size(477, 221);
      this.txtConfirmPass.TabIndex = 0;
      this.txtConfirmPass.TabStop = false;
      this.txtConfirmPass1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtConfirmPass1.Location = new Point(188, 112);
      this.txtConfirmPass1.Name = "txtConfirmPass1";
      this.txtConfirmPass1.PasswordChar = '*';
      this.txtConfirmPass1.Size = new Size(200, 23);
      this.txtConfirmPass1.TabIndex = 5;
      this.txtNewPass.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtNewPass.Location = new Point(188, 77);
      this.txtNewPass.MaxLength = 30;
      this.txtNewPass.Name = "txtNewPass";
      this.txtNewPass.PasswordChar = '*';
      this.txtNewPass.Size = new Size(200, 23);
      this.txtNewPass.TabIndex = 4;
      this.txtOldPass.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtOldPass.Location = new Point(188, 48);
      this.txtOldPass.Name = "txtOldPass";
      this.txtOldPass.Size = new Size(200, 23);
      this.txtOldPass.TabIndex = 3;
      this.lblConfirmNewPass.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblConfirmNewPass.Appearance.Options.UseFont = true;
      this.lblConfirmNewPass.Location = new Point(49, 115);
      this.lblConfirmNewPass.Name = "lblConfirmNewPass";
      this.lblConfirmNewPass.Size = new Size(128, 16);
      this.lblConfirmNewPass.TabIndex = 2;
      this.lblConfirmNewPass.Text = "Nhập lại mật khẩu mới";
      this.lblNewPass.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblNewPass.Appearance.Options.UseFont = true;
      this.lblNewPass.Location = new Point(49, 80);
      this.lblNewPass.Name = "lblNewPass";
      this.lblNewPass.Size = new Size(111, 16);
      this.lblNewPass.TabIndex = 1;
      this.lblNewPass.Text = "Nhập mật khẩu mới";
      this.lblOldPass.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblOldPass.Appearance.Options.UseFont = true;
      this.lblOldPass.Location = new Point(49, 51);
      this.lblOldPass.Name = "lblOldPass";
      this.lblOldPass.Size = new Size(103, 16);
      this.lblOldPass.TabIndex = 0;
      this.lblOldPass.Text = "Nhập mật khẩu cũ";
      this.grbCommand.Controls.Add((Control)this.btnCancel);
      this.grbCommand.Controls.Add((Control)this.btnOk);
      this.grbCommand.Dock = DockStyle.Bottom;
      this.grbCommand.Location = new Point(0, 171);
      this.grbCommand.Name = "grbCommand";
      this.grbCommand.Size = new Size(477, 50);
      this.grbCommand.TabIndex = 1;
      this.grbCommand.TabStop = false;
      this.btnCancel.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnCancel.Appearance.Options.UseFont = true;
      this.btnCancel.Location = new Point(263, 14);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(98, 30);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Huỷ Bỏ";
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnOk.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnOk.Appearance.Options.UseFont = true;
      this.btnOk.Location = new Point(141, 14);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new Size(98, 30);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "Đồng Ý";
      this.btnOk.Click += new EventHandler(this.btnOk_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(477, 221);
      this.Controls.Add((Control)this.grbCommand);
      this.Controls.Add((Control)this.txtConfirmPass);
      this.IconOptions.Image = (Image)ResourceNhua.logoV_64;
      this.Name = "ChangePasswordView";
      this.Text = "ChangePasswordView";
      this.txtConfirmPass.ResumeLayout(false);
      this.txtConfirmPass.PerformLayout();
      this.grbCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }




    //// Token: 0x060030B7 RID: 12471 RVA: 0x000FBB7F File Offset: 0x000F9D7F
    //protected override void Dispose(bool disposing)
    //{
    //	if (disposing && this.components != null)
    //	{
    //		this.components.Dispose();
    //	}
    //	base.Dispose(disposing);
    //}

    //// Token: 0x060030B8 RID: 12472 RVA: 0x000FBBA0 File Offset: 0x000F9DA0
    //private void InitializeComponent()
    //{
    //	this.txtConfirmPass = new global::System.Windows.Forms.GroupBox();
    //	this.txtConfirmPass1 = new global::System.Windows.Forms.TextBox();
    //	this.txtNewPass = new global::System.Windows.Forms.TextBox();
    //	this.txtOldPass = new global::System.Windows.Forms.TextBox();
    //	this.lblConfirmNewPass = new global::DevExpress.XtraEditors.LabelControl();
    //	this.lblNewPass = new global::DevExpress.XtraEditors.LabelControl();
    //	this.lblOldPass = new global::DevExpress.XtraEditors.LabelControl();
    //	this.grbCommand = new global::System.Windows.Forms.GroupBox();
    //	this.btnCancel = new global::DevExpress.XtraEditors.SimpleButton();
    //	this.btnOk = new global::DevExpress.XtraEditors.SimpleButton();
    //	this.txtConfirmPass.SuspendLayout();
    //	this.grbCommand.SuspendLayout();
    //	base.SuspendLayout();
    //	this.txtConfirmPass.Controls.Add(this.txtConfirmPass1);
    //	this.txtConfirmPass.Controls.Add(this.txtNewPass);
    //	this.txtConfirmPass.Controls.Add(this.txtOldPass);
    //	this.txtConfirmPass.Controls.Add(this.lblConfirmNewPass);
    //	this.txtConfirmPass.Controls.Add(this.lblNewPass);
    //	this.txtConfirmPass.Controls.Add(this.lblOldPass);
    //	this.txtConfirmPass.Dock = global::System.Windows.Forms.DockStyle.Fill;
    //	this.txtConfirmPass.Location = new global::System.Drawing.Point(0, 0);
    //	this.txtConfirmPass.Name = "txtConfirmPass";
    //	this.txtConfirmPass.Size = new global::System.Drawing.Size(477, 221);
    //	this.txtConfirmPass.TabIndex = 0;
    //	this.txtConfirmPass.TabStop = false;
    //	this.txtConfirmPass1.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
    //	this.txtConfirmPass1.Location = new global::System.Drawing.Point(188, 112);
    //	this.txtConfirmPass1.Name = "txtConfirmPass1";
    //	this.txtConfirmPass1.PasswordChar = '*';
    //	this.txtConfirmPass1.Size = new global::System.Drawing.Size(200, 23);
    //	this.txtConfirmPass1.TabIndex = 5;
    //	this.txtNewPass.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
    //	this.txtNewPass.Location = new global::System.Drawing.Point(188, 77);
    //	this.txtNewPass.MaxLength = 30;
    //	this.txtNewPass.Name = "txtNewPass";
    //	this.txtNewPass.PasswordChar = '*';
    //	this.txtNewPass.Size = new global::System.Drawing.Size(200, 23);
    //	this.txtNewPass.TabIndex = 4;
    //	this.txtOldPass.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
    //	this.txtOldPass.Location = new global::System.Drawing.Point(188, 48);
    //	this.txtOldPass.Name = "txtOldPass";
    //	this.txtOldPass.Size = new global::System.Drawing.Size(200, 23);
    //	this.txtOldPass.TabIndex = 3;
    //	this.lblConfirmNewPass.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
    //	this.lblConfirmNewPass.Appearance.Options.UseFont = true;
    //	this.lblConfirmNewPass.Location = new global::System.Drawing.Point(49, 115);
    //	this.lblConfirmNewPass.Name = "lblConfirmNewPass";
    //	this.lblConfirmNewPass.Size = new global::System.Drawing.Size(128, 16);
    //	this.lblConfirmNewPass.TabIndex = 2;
    //	this.lblConfirmNewPass.Text = "Nhập lại mật khẩu mới";
    //	this.lblNewPass.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
    //	this.lblNewPass.Appearance.Options.UseFont = true;
    //	this.lblNewPass.Location = new global::System.Drawing.Point(49, 80);
    //	this.lblNewPass.Name = "lblNewPass";
    //	this.lblNewPass.Size = new global::System.Drawing.Size(111, 16);
    //	this.lblNewPass.TabIndex = 1;
    //	this.lblNewPass.Text = "Nhập mật khẩu mới";
    //	this.lblOldPass.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
    //	this.lblOldPass.Appearance.Options.UseFont = true;
    //	this.lblOldPass.Location = new global::System.Drawing.Point(49, 51);
    //	this.lblOldPass.Name = "lblOldPass";
    //	this.lblOldPass.Size = new global::System.Drawing.Size(103, 16);
    //	this.lblOldPass.TabIndex = 0;
    //	this.lblOldPass.Text = "Nhập mật khẩu cũ";
    //	this.grbCommand.Controls.Add(this.btnCancel);
    //	this.grbCommand.Controls.Add(this.btnOk);
    //	this.grbCommand.Dock = global::System.Windows.Forms.DockStyle.Bottom;
    //	this.grbCommand.Location = new global::System.Drawing.Point(0, 171);
    //	this.grbCommand.Name = "grbCommand";
    //	this.grbCommand.Size = new global::System.Drawing.Size(477, 50);
    //	this.grbCommand.TabIndex = 1;
    //	this.grbCommand.TabStop = false;
    //	this.btnCancel.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
    //	this.btnCancel.Appearance.Options.UseFont = true;
    //	this.btnCancel.Location = new global::System.Drawing.Point(263, 14);
    //	this.btnCancel.Name = "btnCancel";
    //	this.btnCancel.Size = new global::System.Drawing.Size(98, 30);
    //	this.btnCancel.TabIndex = 1;
    //	this.btnCancel.Text = "Huỷ Bỏ";
    //	this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
    //	this.btnOk.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
    //	this.btnOk.Appearance.Options.UseFont = true;
    //	this.btnOk.Location = new global::System.Drawing.Point(141, 14);
    //	this.btnOk.Name = "btnOk";
    //	this.btnOk.Size = new global::System.Drawing.Size(98, 30);
    //	this.btnOk.TabIndex = 0;
    //	this.btnOk.Text = "Đồng Ý";
    //	this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
    //	base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
    //	base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
    //	base.ClientSize = new global::System.Drawing.Size(477, 221);
    //	base.Controls.Add(this.grbCommand);
    //	base.Controls.Add(this.txtConfirmPass);
    //	base.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
    //	base.Name = "ChangePasswordView";
    //	this.Text = "ChangePasswordView";
    //	this.txtConfirmPass.ResumeLayout(false);
    //	this.txtConfirmPass.PerformLayout();
    //	this.grbCommand.ResumeLayout(false);
    //	base.ResumeLayout(false);
    //}

    //// Token: 0x04001E01 RID: 7681
    //private global::System.ComponentModel.IContainer components;

    //// Token: 0x04001E02 RID: 7682
    //private global::System.Windows.Forms.GroupBox txtConfirmPass;

    //// Token: 0x04001E03 RID: 7683
    //private global::DevExpress.XtraEditors.LabelControl lblConfirmNewPass;

    //// Token: 0x04001E04 RID: 7684
    //private global::DevExpress.XtraEditors.LabelControl lblNewPass;

    //// Token: 0x04001E05 RID: 7685
    //private global::DevExpress.XtraEditors.LabelControl lblOldPass;

    //// Token: 0x04001E06 RID: 7686
    //private global::System.Windows.Forms.GroupBox grbCommand;

    //// Token: 0x04001E07 RID: 7687
    //private global::DevExpress.XtraEditors.SimpleButton btnCancel;

    //// Token: 0x04001E08 RID: 7688
    //private global::DevExpress.XtraEditors.SimpleButton btnOk;

    //// Token: 0x04001E09 RID: 7689
    //private global::System.Windows.Forms.TextBox txtNewPass;

    //// Token: 0x04001E0A RID: 7690
    //private global::System.Windows.Forms.TextBox txtOldPass;

    //// Token: 0x04001E0B RID: 7691
    //private global::System.Windows.Forms.TextBox txtConfirmPass1;
  }
}

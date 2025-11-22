namespace NhuaNong
{
	// Token: 0x02000017 RID: 23
	public partial class SettingProduct : global::NhuaNong.DialogViewBase
	{
		// Token: 0x06000159 RID: 345 RVA: 0x00010F81 File Offset: 0x0000F181
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00010FA0 File Offset: 0x0000F1A0
		private void InitializeComponent()
		{
			this.panelControl1 = new global::DevExpress.XtraEditors.PanelControl();
			this.txtGmailProduct = new global::DevExpress.XtraEditors.TextEdit();
			this.lblGmail = new global::DevExpress.XtraEditors.LabelControl();
			this.bteIconLogoPathProducer = new global::DevExpress.XtraEditors.ButtonEdit();
			this.labelControl3 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new global::DevExpress.XtraEditors.LabelControl();
			this.pictureEdit1 = new global::DevExpress.XtraEditors.PictureEdit();
			this.txtPhoneProduct = new global::DevExpress.XtraEditors.TextEdit();
			this.txtLocalProduct = new global::DevExpress.XtraEditors.TextEdit();
			this.txtNameProduct = new global::DevExpress.XtraEditors.TextEdit();
			this.lblPhone = new global::DevExpress.XtraEditors.LabelControl();
			this.lblAddress = new global::DevExpress.XtraEditors.LabelControl();
			this.lblCompanyName = new global::DevExpress.XtraEditors.LabelControl();
			this.panelControl2 = new global::DevExpress.XtraEditors.PanelControl();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.lblTime = new global::DevExpress.XtraEditors.LabelControl();
			this.btnCancel = new global::DevExpress.XtraEditors.SimpleButton();
			this.btnOk = new global::DevExpress.XtraEditors.SimpleButton();
			this.lblCheck = new global::DevExpress.XtraEditors.LabelControl();
			((global::System.ComponentModel.ISupportInitialize)this.panelControl1).BeginInit();
			this.panelControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtGmailProduct.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bteIconLogoPathProducer.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureEdit1.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtPhoneProduct.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtLocalProduct.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtNameProduct.Properties).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.panelControl2).BeginInit();
			this.panelControl2.SuspendLayout();
			base.SuspendLayout();
			this.panelControl1.Controls.Add(this.txtGmailProduct);
			this.panelControl1.Controls.Add(this.lblGmail);
			this.panelControl1.Controls.Add(this.bteIconLogoPathProducer);
			this.panelControl1.Controls.Add(this.labelControl3);
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.pictureEdit1);
			this.panelControl1.Controls.Add(this.txtPhoneProduct);
			this.panelControl1.Controls.Add(this.txtLocalProduct);
			this.panelControl1.Controls.Add(this.txtNameProduct);
			this.panelControl1.Controls.Add(this.lblPhone);
			this.panelControl1.Controls.Add(this.lblAddress);
			this.panelControl1.Controls.Add(this.lblCompanyName);
			this.panelControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new global::System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new global::System.Drawing.Size(621, 226);
			this.panelControl1.TabIndex = 0;
			this.txtGmailProduct.Location = new global::System.Drawing.Point(149, 125);
			this.txtGmailProduct.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGmailProduct.Name = "txtGmailProduct";
			this.txtGmailProduct.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtGmailProduct.Properties.Appearance.Options.UseFont = true;
			this.txtGmailProduct.Size = new global::System.Drawing.Size(304, 22);
			this.txtGmailProduct.TabIndex = 26;
			this.lblGmail.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblGmail.Appearance.Options.UseFont = true;
			this.lblGmail.Appearance.Options.UseTextOptions = true;
			this.lblGmail.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblGmail.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblGmail.Location = new global::System.Drawing.Point(31, 128);
			this.lblGmail.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblGmail.Name = "lblGmail";
			this.lblGmail.Size = new global::System.Drawing.Size(96, 16);
			this.lblGmail.TabIndex = 25;
			this.lblGmail.Text = "Gmail";
			this.bteIconLogoPathProducer.Location = new global::System.Drawing.Point(149, 153);
			this.bteIconLogoPathProducer.Name = "bteIconLogoPathProducer";
			this.bteIconLogoPathProducer.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton()
			});
			this.bteIconLogoPathProducer.Size = new global::System.Drawing.Size(304, 20);
			this.bteIconLogoPathProducer.TabIndex = 24;
			this.bteIconLogoPathProducer.Visible = false;
			this.bteIconLogoPathProducer.ButtonClick += new global::DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bteIconLogoPathProducer_ButtonClick);
			this.bteIconLogoPathProducer.EditValueChanged += new global::System.EventHandler(this.bteIconLogoPathProducer_EditValueChanged);
			this.labelControl3.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Appearance.Options.UseTextOptions = true;
			this.labelControl3.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.labelControl3.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl3.Location = new global::System.Drawing.Point(31, 154);
			this.labelControl3.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new global::System.Drawing.Size(96, 16);
			this.labelControl3.TabIndex = 23;
			this.labelControl3.Text = "Icon Logo Path";
			this.labelControl3.Visible = false;
			this.labelControl2.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new global::System.Drawing.Point(473, 144);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new global::System.Drawing.Size(110, 16);
			this.labelControl2.TabIndex = 21;
			this.labelControl2.Text = "Icon Logo Producer";
			this.labelControl2.Visible = false;
			this.pictureEdit1.Location = new global::System.Drawing.Point(480, 38);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.NullText = " ";
			this.pictureEdit1.Properties.ShowCameraMenuItem = global::DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Size = new global::System.Drawing.Size(100, 100);
			this.pictureEdit1.TabIndex = 19;
			this.pictureEdit1.Visible = false;
			this.txtPhoneProduct.Location = new global::System.Drawing.Point(149, 95);
			this.txtPhoneProduct.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPhoneProduct.Name = "txtPhoneProduct";
			this.txtPhoneProduct.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtPhoneProduct.Properties.Appearance.Options.UseFont = true;
			this.txtPhoneProduct.Size = new global::System.Drawing.Size(304, 22);
			this.txtPhoneProduct.TabIndex = 18;
			this.txtLocalProduct.Location = new global::System.Drawing.Point(149, 65);
			this.txtLocalProduct.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLocalProduct.Name = "txtLocalProduct";
			this.txtLocalProduct.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtLocalProduct.Properties.Appearance.Options.UseFont = true;
			this.txtLocalProduct.Size = new global::System.Drawing.Size(304, 22);
			this.txtLocalProduct.TabIndex = 17;
			this.txtNameProduct.Location = new global::System.Drawing.Point(149, 35);
			this.txtNameProduct.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNameProduct.Name = "txtNameProduct";
			this.txtNameProduct.Properties.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtNameProduct.Properties.Appearance.Options.UseFont = true;
			this.txtNameProduct.Size = new global::System.Drawing.Size(304, 22);
			this.txtNameProduct.TabIndex = 16;
			this.lblPhone.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblPhone.Appearance.Options.UseFont = true;
			this.lblPhone.Appearance.Options.UseTextOptions = true;
			this.lblPhone.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblPhone.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblPhone.Location = new global::System.Drawing.Point(31, 98);
			this.lblPhone.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblPhone.Name = "lblPhone";
			this.lblPhone.Size = new global::System.Drawing.Size(96, 16);
			this.lblPhone.TabIndex = 15;
			this.lblPhone.Text = "Phone";
			this.lblAddress.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblAddress.Appearance.Options.UseFont = true;
			this.lblAddress.Appearance.Options.UseTextOptions = true;
			this.lblAddress.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblAddress.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblAddress.Location = new global::System.Drawing.Point(31, 68);
			this.lblAddress.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblAddress.Name = "lblAddress";
			this.lblAddress.Size = new global::System.Drawing.Size(96, 16);
			this.lblAddress.TabIndex = 14;
			this.lblAddress.Text = "Dec";
			this.lblCompanyName.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblCompanyName.Appearance.Options.UseFont = true;
			this.lblCompanyName.Appearance.Options.UseTextOptions = true;
			this.lblCompanyName.Appearance.TextOptions.HAlignment = global::DevExpress.Utils.HorzAlignment.Far;
			this.lblCompanyName.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lblCompanyName.Location = new global::System.Drawing.Point(31, 38);
			this.lblCompanyName.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.lblCompanyName.Name = "lblCompanyName";
			this.lblCompanyName.Size = new global::System.Drawing.Size(96, 16);
			this.lblCompanyName.TabIndex = 13;
			this.lblCompanyName.Text = "Producer Name";
			this.panelControl2.Controls.Add(this.lblCheck);
			this.panelControl2.Controls.Add(this.button2);
			this.panelControl2.Controls.Add(this.button1);
			this.panelControl2.Controls.Add(this.lblTime);
			this.panelControl2.Controls.Add(this.btnCancel);
			this.panelControl2.Controls.Add(this.btnOk);
			this.panelControl2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelControl2.Location = new global::System.Drawing.Point(0, 181);
			this.panelControl2.Name = "panelControl2";
			this.panelControl2.Size = new global::System.Drawing.Size(621, 45);
			this.panelControl2.TabIndex = 1;
			this.button2.Location = new global::System.Drawing.Point(297, 7);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(119, 31);
			this.button2.TabIndex = 8;
			this.button2.Text = "Thoát";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.button1.Location = new global::System.Drawing.Point(172, 7);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(119, 31);
			this.button1.TabIndex = 7;
			this.button1.Text = "Lưu";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.btnOk_Click);
			this.lblTime.Location = new global::System.Drawing.Point(5, 27);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new global::System.Drawing.Size(63, 13);
			this.lblTime.TabIndex = 6;
			this.lblTime.Text = "labelControl1";
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.Appearance.Options.UseFont = true;
			this.btnCancel.Location = new global::System.Drawing.Point(747, 7);
			this.btnCancel.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(98, 30);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Huỷ Bỏ";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnOk.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnOk.Appearance.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnOk.Appearance.Options.UseFont = true;
			this.btnOk.Location = new global::System.Drawing.Point(633, 7);
			this.btnOk.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(98, 30);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "Lưu";
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.lblCheck.Location = new global::System.Drawing.Point(612, 27);
			this.lblCheck.Name = "lblCheck";
			this.lblCheck.Size = new global::System.Drawing.Size(4, 13);
			this.lblCheck.TabIndex = 9;
			this.lblCheck.Text = ".";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(621, 226);
			base.Controls.Add(this.panelControl2);
			base.Controls.Add(this.panelControl1);
			base.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
			base.KeyPreview = true;
			base.Name = "SettingProduct";
			this.Text = "SettingProduct";
			base.Load += new global::System.EventHandler(this.SettingProduct_Load);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.SettingProduct_KeyDown);
			((global::System.ComponentModel.ISupportInitialize)this.panelControl1).EndInit();
			this.panelControl1.ResumeLayout(false);
			this.panelControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.txtGmailProduct.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bteIconLogoPathProducer.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureEdit1.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtPhoneProduct.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtLocalProduct.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.txtNameProduct.Properties).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.panelControl2).EndInit();
			this.panelControl2.ResumeLayout(false);
			this.panelControl2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000115 RID: 277
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000116 RID: 278
		private global::DevExpress.XtraEditors.PanelControl panelControl1;

		// Token: 0x04000117 RID: 279
		private global::DevExpress.XtraEditors.PanelControl panelControl2;

		// Token: 0x04000118 RID: 280
		private global::DevExpress.XtraEditors.SimpleButton btnCancel;

		// Token: 0x04000119 RID: 281
		private global::DevExpress.XtraEditors.SimpleButton btnOk;

		// Token: 0x0400011A RID: 282
		private global::DevExpress.XtraEditors.ButtonEdit bteIconLogoPathProducer;

		// Token: 0x0400011B RID: 283
		private global::DevExpress.XtraEditors.LabelControl labelControl3;

		// Token: 0x0400011C RID: 284
		private global::DevExpress.XtraEditors.LabelControl labelControl2;

		// Token: 0x0400011D RID: 285
		private global::DevExpress.XtraEditors.PictureEdit pictureEdit1;

		// Token: 0x0400011E RID: 286
		private global::DevExpress.XtraEditors.TextEdit txtPhoneProduct;

		// Token: 0x0400011F RID: 287
		private global::DevExpress.XtraEditors.TextEdit txtLocalProduct;

		// Token: 0x04000120 RID: 288
		private global::DevExpress.XtraEditors.TextEdit txtNameProduct;

		// Token: 0x04000121 RID: 289
		private global::DevExpress.XtraEditors.LabelControl lblPhone;

		// Token: 0x04000122 RID: 290
		private global::DevExpress.XtraEditors.LabelControl lblAddress;

		// Token: 0x04000123 RID: 291
		private global::DevExpress.XtraEditors.LabelControl lblCompanyName;

		// Token: 0x04000124 RID: 292
		private global::DevExpress.XtraEditors.LabelControl lblTime;

		// Token: 0x04000125 RID: 293
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000126 RID: 294
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000127 RID: 295
		private global::DevExpress.XtraEditors.TextEdit txtGmailProduct;

		// Token: 0x04000128 RID: 296
		private global::DevExpress.XtraEditors.LabelControl lblGmail;

		// Token: 0x04000129 RID: 297
		private global::DevExpress.XtraEditors.LabelControl lblCheck;
	}
}

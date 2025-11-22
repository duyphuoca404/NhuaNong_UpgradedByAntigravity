namespace NhuaNong
{
	// Token: 0x0200000C RID: 12
	public partial class FrmRemind : global::NhuaNong.DialogViewBase
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00004BF4 File Offset: 0x00002DF4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004C14 File Offset: 0x00002E14
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NhuaNong.FrmRemind));
			this.panelControl1 = new global::DevExpress.XtraEditors.PanelControl();
			this.labelControl2 = new global::DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.pictureEdit1 = new global::DevExpress.XtraEditors.PictureEdit();
			((global::System.ComponentModel.ISupportInitialize)this.panelControl1).BeginInit();
			this.panelControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureEdit1.Properties).BeginInit();
			base.SuspendLayout();
			this.panelControl1.Controls.Add(this.labelControl2);
			this.panelControl1.Controls.Add(this.labelControl1);
			this.panelControl1.Controls.Add(this.pictureEdit1);
			this.panelControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelControl1.Location = new global::System.Drawing.Point(0, 0);
			this.panelControl1.Name = "panelControl1";
			this.panelControl1.Size = new global::System.Drawing.Size(833, 440);
			this.panelControl1.TabIndex = 0;
			this.labelControl2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.labelControl2.Appearance.BackColor = global::System.Drawing.Color.Transparent;
			this.labelControl2.Appearance.BackColor2 = global::System.Drawing.Color.Transparent;
			this.labelControl2.Appearance.Font = new global::System.Drawing.Font("Tahoma", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl2.Appearance.ForeColor = global::System.Drawing.Color.Red;
			this.labelControl2.Appearance.Options.UseBackColor = true;
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Appearance.Options.UseForeColor = true;
			this.labelControl2.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl2.Location = new global::System.Drawing.Point(2, 130);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new global::System.Drawing.Size(823, 55);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "   PHẦN MỀM SẼ CẬP NHẬT SAU 24H\r\n";
			this.labelControl2.Visible = false;
			this.labelControl1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.labelControl1.Appearance.BackColor = global::System.Drawing.Color.Orange;
			this.labelControl1.Appearance.BackColor2 = global::System.Drawing.Color.FromArgb(255, 128, 128);
			this.labelControl1.Appearance.Font = new global::System.Drawing.Font("Tahoma", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelControl1.Appearance.ForeColor = global::System.Drawing.Color.White;
			this.labelControl1.Appearance.Options.UseBackColor = true;
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Appearance.Options.UseForeColor = true;
			this.labelControl1.AutoSizeMode = global::DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.labelControl1.Location = new global::System.Drawing.Point(5, 205);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new global::System.Drawing.Size(823, 120);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = " VUI LÒNG LIÊN HỆ ĐỘI NGŨ PHÁT TRIỂN ĐỂ ĐƯỢC \r\n CẬP NHẬT PHIÊN BẢN MỚI NHẤT";
			this.labelControl1.Visible = false;
			this.pictureEdit1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureEdit1.BackgroundImage");
			this.pictureEdit1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.pictureEdit1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pictureEdit1.Location = new global::System.Drawing.Point(2, 2);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.NullText = " ";
			this.pictureEdit1.Properties.ShowCameraMenuItem = global::DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = global::DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new global::System.Drawing.Size(829, 436);
			this.pictureEdit1.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(833, 440);
			base.ControlBox = false;
			base.Controls.Add(this.panelControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.IconOptions.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FrmRemind.IconOptions.Image");
			base.Name = "FrmRemind";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmRemind";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FrmRemind_FormClosing);
			base.Load += new global::System.EventHandler(this.FrmRemind_Load);
			((global::System.ComponentModel.ISupportInitialize)this.panelControl1).EndInit();
			this.panelControl1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureEdit1.Properties).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400003D RID: 61
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400003E RID: 62
		private global::DevExpress.XtraEditors.PanelControl panelControl1;

		// Token: 0x0400003F RID: 63
		private global::DevExpress.XtraEditors.PictureEdit pictureEdit1;

		// Token: 0x04000040 RID: 64
		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		// Token: 0x04000041 RID: 65
		private global::DevExpress.XtraEditors.LabelControl labelControl2;
	}
}

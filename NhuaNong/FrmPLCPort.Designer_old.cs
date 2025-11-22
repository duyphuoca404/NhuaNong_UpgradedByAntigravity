namespace NhuaNong
{
	// Token: 0x02000011 RID: 17
	public partial class FrmPLCPort : global::NhuaNong.DialogViewBase
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x0000F4CF File Offset: 0x0000D6CF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		private void InitializeComponent()
		{
			this.groupControl1 = new global::DevExpress.XtraEditors.GroupControl();
			this.luePLCPort = new global::DevExpress.XtraEditors.LookUpEdit();
			this.labelControl1 = new global::DevExpress.XtraEditors.LabelControl();
			this.btnOk = new global::DevExpress.XtraEditors.SimpleButton();
			this.btnCancel = new global::DevExpress.XtraEditors.SimpleButton();
			((global::System.ComponentModel.ISupportInitialize)this.groupControl1).BeginInit();
			this.groupControl1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.luePLCPort.Properties).BeginInit();
			base.SuspendLayout();
			this.groupControl1.Controls.Add(this.luePLCPort);
			this.groupControl1.Controls.Add(this.labelControl1);
			this.groupControl1.Location = new global::System.Drawing.Point(1, 12);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.ShowCaption = false;
			this.groupControl1.Size = new global::System.Drawing.Size(425, 97);
			this.groupControl1.TabIndex = 0;
			this.groupControl1.Text = "groupControl1";
			this.luePLCPort.Location = new global::System.Drawing.Point(112, 41);
			this.luePLCPort.Name = "luePLCPort";
			this.luePLCPort.Properties.Buttons.AddRange(new global::DevExpress.XtraEditors.Controls.EditorButton[]
			{
				new global::DevExpress.XtraEditors.Controls.EditorButton(global::DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
			});
			this.luePLCPort.Properties.NullText = "";
			this.luePLCPort.Properties.ShowFooter = false;
			this.luePLCPort.Properties.ShowHeader = false;
			this.luePLCPort.Size = new global::System.Drawing.Size(189, 22);
			this.luePLCPort.TabIndex = 1;
			this.labelControl1.Location = new global::System.Drawing.Point(38, 44);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new global::System.Drawing.Size(48, 16);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "PLC Port";
			this.btnOk.Location = new global::System.Drawing.Point(183, 126);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new global::System.Drawing.Size(94, 29);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OK";
			this.btnOk.Click += new global::System.EventHandler(this.btnOk_Click);
			this.btnCancel.Location = new global::System.Drawing.Point(298, 126);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(94, 29);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(428, 186);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.btnOk);
			base.Controls.Add(this.groupControl1);
			base.Name = "FrmPLCPort";
			this.Text = "FrmPLCPort";
			((global::System.ComponentModel.ISupportInitialize)this.groupControl1).EndInit();
			this.groupControl1.ResumeLayout(false);
			this.groupControl1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.luePLCPort.Properties).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000FE RID: 254
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000FF RID: 255
		private global::DevExpress.XtraEditors.GroupControl groupControl1;

		// Token: 0x04000100 RID: 256
		private global::DevExpress.XtraEditors.LookUpEdit luePLCPort;

		// Token: 0x04000101 RID: 257
		private global::DevExpress.XtraEditors.LabelControl labelControl1;

		// Token: 0x04000102 RID: 258
		private global::DevExpress.XtraEditors.SimpleButton btnOk;

		// Token: 0x04000103 RID: 259
		private global::DevExpress.XtraEditors.SimpleButton btnCancel;
	}
}

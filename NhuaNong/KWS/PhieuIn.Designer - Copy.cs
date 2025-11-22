namespace NhuaNong.KWS
{
	// Token: 0x0200011A RID: 282
	public partial class PhieuIn : global::DevExpress.XtraEditors.XtraForm
	{
		// Token: 0x0600174C RID: 5964 RVA: 0x000C431F File Offset: 0x000C251F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x000C4340 File Offset: 0x000C2540
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1148, 713);
			base.IconOptions.Image = global::NhuaNong.ResourceNhua.logoV_64;
			base.IconOptions.LargeImage = global::NhuaNong.ResourceNhua.IIon;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "PhieuIn";
			this.Text = "Phiếu In";
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.PhieuIn_KeyDown);
			base.ResumeLayout(false);
		}

		// Token: 0x0400123D RID: 4669
		private global::System.ComponentModel.IContainer components;
	}
}

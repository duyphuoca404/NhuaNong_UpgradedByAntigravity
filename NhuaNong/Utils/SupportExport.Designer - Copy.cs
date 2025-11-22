namespace NhuaNong.Utils
{
	// Token: 0x02000028 RID: 40
	internal partial class SupportExport : global::System.Windows.Forms.Form
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00016BC0 File Offset: 0x00014DC0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00016BE0 File Offset: 0x00014DE0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NhuaNong.Utils.SupportExport));
			this.printingSystem = new global::DevExpress.XtraPrinting.PrintingSystem(this.components);
			this.printableComponentLink = new global::DevExpress.XtraPrinting.PrintableComponentLink(this.components);
			this.printDialog1 = new global::System.Windows.Forms.PrintDialog();
			((global::System.ComponentModel.ISupportInitialize)this.printingSystem).BeginInit();
			this.printableComponentLink.ImageCollection.BeginInit();
			base.SuspendLayout();
			this.printingSystem.Links.AddRange(new object[]
			{
				this.printableComponentLink
			});
			this.printableComponentLink.ImageCollection.ImageStream = (global::DevExpress.Utils.ImageCollectionStreamer)componentResourceManager.GetObject("printableComponentLink.ImageCollection.ImageStream");
			this.printableComponentLink.PaperKind = global::System.Drawing.Printing.PaperKind.A4;
			this.printableComponentLink.PrintingSystem = this.printingSystem;
			this.printableComponentLink.PrintingSystemBase = this.printingSystem;
			this.printDialog1.UseEXDialog = true;
			base.ClientSize = new global::System.Drawing.Size(1264, 692);
			base.Name = "SupportExport";
			((global::System.ComponentModel.ISupportInitialize)this.printingSystem).EndInit();
			this.printableComponentLink.ImageCollection.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000169 RID: 361
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400016A RID: 362
		private global::DevExpress.XtraPrinting.PrintingSystem printingSystem;

		// Token: 0x0400016B RID: 363
		protected global::DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink;

		// Token: 0x0400016C RID: 364
		private global::System.Windows.Forms.PrintDialog printDialog1;
	}
}

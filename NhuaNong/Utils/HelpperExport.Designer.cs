using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace NhuaNong.Utils
{
  public partial class HelpperExport :XtraForm
  {
    private IContainer components;
    private PrintingSystem printingSystem;
    protected PrintableComponentLink printableComponentLink;
    private PrintDialog printDialog1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
      this.printableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
      this.printDialog1 = new System.Windows.Forms.PrintDialog();
      ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
      this.SuspendLayout();
      // 
      // printingSystem
      // 
      this.printingSystem.Links.AddRange(new object[] {
            this.printableComponentLink});
      // 
      // printableComponentLink
      // 
      this.printableComponentLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
      this.printableComponentLink.PrintingSystemBase = this.printingSystem;
      // 
      // printDialog1
      // 
      this.printDialog1.UseEXDialog = true;
      // 
      // HelpperExport
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1264, 692);
      this.Name = "HelpperExport";
      this.Text = "HelpperExport";
      this.Load += new System.EventHandler(this.HelpperExport_Load);
      ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
      this.ResumeLayout(false);

    }


    //// Token: 0x060001AE RID: 430 RVA: 0x00014644 File Offset: 0x00012844
    //protected override void Dispose(bool disposing)
    //{
    //	if (disposing && this.components != null)
    //	{
    //		this.components.Dispose();
    //	}
    //	base.Dispose(disposing);
    //}

    //// Token: 0x060001AF RID: 431 RVA: 0x00014664 File Offset: 0x00012864
    //private void InitializeComponent()
    //{
    //	this.components = new global::System.ComponentModel.Container();
    //	//global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NhuaNong.Utils.HelpperExport));
    //	this.printingSystem = new global::DevExpress.XtraPrinting.PrintingSystem(this.components);
    //	this.printableComponentLink = new global::DevExpress.XtraPrinting.PrintableComponentLink(this.components);
    //	this.printDialog1 = new global::System.Windows.Forms.PrintDialog();
    //	((global::System.ComponentModel.ISupportInitialize)this.printingSystem).BeginInit();
    //	this.printableComponentLink.ImageCollection.BeginInit();
    //	base.SuspendLayout();
    //	this.printingSystem.Links.AddRange(new object[]
    //	{
    //		this.printableComponentLink
    //	});
    //	//this.printableComponentLink.ImageCollection.ImageStream = (global::DevExpress.Utils.ImageCollectionStreamer)componentResourceManager.GetObject("printableComponentLink.ImageCollection.ImageStream");
    //	this.printableComponentLink.PaperKind = global::System.Drawing.Printing.PaperKind.A4;
    //	this.printableComponentLink.PrintingSystem = this.printingSystem;
    //	this.printableComponentLink.PrintingSystemBase = this.printingSystem;
    //	this.printDialog1.UseEXDialog = true;
    //	base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
    //	base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
    //	base.ClientSize = new global::System.Drawing.Size(1264, 692);
    //	base.Name = "HelpperExport";
    //	this.Text = "HelpperExport";
    //	((global::System.ComponentModel.ISupportInitialize)this.printingSystem).EndInit();
    //	this.printableComponentLink.ImageCollection.EndInit();
    //	base.ResumeLayout(false);
    //}

    //// Token: 0x04000155 RID: 341
    //private global::System.ComponentModel.IContainer components;

    //// Token: 0x04000156 RID: 342
    //private global::DevExpress.XtraPrinting.PrintingSystem printingSystem;

    //// Token: 0x04000157 RID: 343
    //protected global::DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink;

    //// Token: 0x04000158 RID: 344
    //private global::System.Windows.Forms.PrintDialog printDialog1;
  }
}

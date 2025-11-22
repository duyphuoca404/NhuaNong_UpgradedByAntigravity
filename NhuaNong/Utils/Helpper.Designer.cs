using DevExpress.Drawing;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace NhuaNong.Utils
{
  public partial class Helpper : Form
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
      this.printingSystem = new PrintingSystem();
      this.printableComponentLink = new PrintableComponentLink();
      this.printDialog1 = new PrintDialog();
      ((ISupportInitialize)this.printingSystem).BeginInit();
      this.printableComponentLink.ImageCollection.BeginInit();
      this.SuspendLayout();
      this.printingSystem.Links.AddRange(new object[1]
      {
        (object) this.printableComponentLink
      });
      this.printableComponentLink.PaperKind = PaperKind.A4;
      this.printableComponentLink.PrintingSystem = this.printingSystem;
      this.printableComponentLink.PrintingSystemBase = (PrintingSystemBase)this.printingSystem;
      this.printDialog1.UseEXDialog = true;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(1264, 692);
      this.Name = "Helpper";
      this.Text = "Helpper";
      ((ISupportInitialize)this.printingSystem).EndInit();
      this.printableComponentLink.ImageCollection.EndInit();
      this.ResumeLayout(false);
    }



    //// Token: 0x060001AB RID: 427 RVA: 0x00014502 File Offset: 0x00012702
    //protected override void Dispose(bool disposing)
    //{
    //	if (disposing && this.components != null)
    //	{
    //		this.components.Dispose();
    //	}
    //	base.Dispose(disposing);
    //}

    //// Token: 0x060001AC RID: 428 RVA: 0x00014524 File Offset: 0x00012724
    //private void InitializeComponent()
    //{
    //	this.printingSystem = new global::DevExpress.XtraPrinting.PrintingSystem();
    //	this.printableComponentLink = new global::DevExpress.XtraPrinting.PrintableComponentLink();
    //	this.printDialog1 = new global::System.Windows.Forms.PrintDialog();
    //	((global::System.ComponentModel.ISupportInitialize)this.printingSystem).BeginInit();
    //	this.printableComponentLink.ImageCollection.BeginInit();
    //	base.SuspendLayout();
    //	this.printingSystem.Links.AddRange(new object[]
    //	{
    //		this.printableComponentLink
    //	});
    //	this.printableComponentLink.PaperKind = global::System.Drawing.Printing.PaperKind.A4;
    //	this.printableComponentLink.PrintingSystem = this.printingSystem;
    //	this.printableComponentLink.PrintingSystemBase = this.printingSystem;
    //	this.printDialog1.UseEXDialog = true;
    //	base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
    //	base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
    //	base.ClientSize = new global::System.Drawing.Size(1264, 692);
    //	base.Name = "Helpper";
    //	this.Text = "Helpper";
    //	((global::System.ComponentModel.ISupportInitialize)this.printingSystem).EndInit();
    //	this.printableComponentLink.ImageCollection.EndInit();
    //	base.ResumeLayout(false);
    //}

    //// Token: 0x04000150 RID: 336
    //private global::System.ComponentModel.IContainer components;

    //// Token: 0x04000151 RID: 337
    //private global::DevExpress.XtraPrinting.PrintingSystem printingSystem;

    //// Token: 0x04000152 RID: 338
    //protected global::DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink;

    //// Token: 0x04000153 RID: 339
    //private global::System.Windows.Forms.PrintDialog printDialog1;
  }
}

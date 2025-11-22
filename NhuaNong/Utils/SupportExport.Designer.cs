using DevExpress.Drawing;
using DevExpress.Utils;
using DevExpress.XtraGrid;
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
  internal partial class SupportExport : Form
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
      // SupportExport
      // 
      this.ClientSize = new System.Drawing.Size(1264, 692);
      this.Name = "SupportExport";
      this.Load += new System.EventHandler(this.SupportExport_Load);
      ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
      this.ResumeLayout(false);

    }




    // Code bên dưới đã được trình Designer tự động tạo ra, không cần chỉnh sửa thêm nữa (lấy nguồn từ DnSpy)
    //// Token: 0x060001D6 RID: 470 RVA: 0x00016BC0 File Offset: 0x00014DC0
    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //  {
    //    this.components.Dispose();
    //  }
    //  base.Dispose(disposing);
    //}

    //// Token: 0x060001D7 RID: 471 RVA: 0x00016BE0 File Offset: 0x00014DE0
    //private void InitializeComponent()
    //{
    //  this.components = new System.ComponentModel.Container();
    //  this.printingSystem = new DevExpress.XtraPrinting.PrintingSystem(this.components);
    //  this.printableComponentLink = new DevExpress.XtraPrinting.PrintableComponentLink(this.components);
    //  this.printDialog1 = new System.Windows.Forms.PrintDialog();
    //  ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).BeginInit();
    //  this.SuspendLayout();
    //  // 
    //  // printingSystem
    //  // 
    //  this.printingSystem.Links.AddRange(new object[] {
    //        this.printableComponentLink});
    //  // 
    //  // printableComponentLink
    //  // 
    //  this.printableComponentLink.PaperKind = System.Drawing.Printing.PaperKind.A4;
    //  this.printableComponentLink.PrintingSystemBase = this.printingSystem;
    //  // 
    //  // printDialog1
    //  // 
    //  this.printDialog1.UseEXDialog = true;
    //  // 
    //  // SupportExport
    //  // 
    //  this.ClientSize = new System.Drawing.Size(1264, 692);
    //  this.Name = "SupportExport";
    //  this.Load += new System.EventHandler(this.SupportExport_Load);
    //  ((System.ComponentModel.ISupportInitialize)(this.printingSystem)).EndInit();
    //  this.ResumeLayout(false);

    //}

    //// Token: 0x04000169 RID: 361
    //private global::System.ComponentModel.IContainer components;

    //// Token: 0x0400016A RID: 362
    //private global::DevExpress.XtraPrinting.PrintingSystem printingSystem;

    //// Token: 0x0400016B RID: 363
    //protected global::DevExpress.XtraPrinting.PrintableComponentLink printableComponentLink;

    //// Token: 0x0400016C RID: 364
    //private global::System.Windows.Forms.PrintDialog printDialog1;
  }
}

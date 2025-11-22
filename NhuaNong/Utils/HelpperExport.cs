// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.HelpperExport
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Utils
{
  public partial class HelpperExport : XtraForm
  {
    //private IContainer components;
    //private PrintingSystem printingSystem;
    //protected PrintableComponentLink printableComponentLink;
    //private PrintDialog printDialog1;

    public HelpperExport()
    {
      InitializeComponent();
      this.Name = nameof(HelpperExport);
      this.Text = nameof(HelpperExport);
      //this.Load += new System.EventHandler(this.HelpperExport_Load); // <-- Thêm dòng này
    }

    private void HelpperExport_Load(object sender, EventArgs e)
    {
      // Đã thực hiện các bước sau khi form được tải, nên không cần những dòng này nữa
      //// 1. Khai báo resource manager ở đây
      //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpperExport));

      //// 2. Dán dòng code tải tài nguyên đã xóa từ InitializeComponent vào đây
      //this.printableComponentLink.ImageCollection.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("printableComponentLink.ImageCollection.ImageStream");
    }

    //protected override void Dispose(bool disposing)
    //{
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //}

    //private void InitializeComponent()
    //{
    //  this.components = (IContainer) new System.ComponentModel.Container();
    //  ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (HelpperExport));
    //  this.printingSystem = new PrintingSystem(this.components);
    //  this.printableComponentLink = new PrintableComponentLink(this.components);
    //  this.printDialog1 = new PrintDialog();
    //  ((ISupportInitialize) this.printingSystem).BeginInit();
    //  this.printableComponentLink.ImageCollection.BeginInit();
    //  this.SuspendLayout();
    //  this.printingSystem.Links.AddRange(new object[1]
    //  {
    //    (object) this.printableComponentLink
    //  });
    //  this.printableComponentLink.ImageCollection.ImageStream = (ImageCollectionStreamer) componentResourceManager.GetObject("printableComponentLink.ImageCollection.ImageStream");
    //  this.printableComponentLink.PaperKind = PaperKind.A4;
    //  this.printableComponentLink.PrintingSystem = this.printingSystem;
    //  this.printableComponentLink.PrintingSystemBase = (PrintingSystemBase) this.printingSystem;
    //  this.printDialog1.UseEXDialog = true;
    //  this.AutoScaleDimensions = new SizeF(6f, 13f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(1264, 692);
    //  this.Name = nameof (HelpperExport);
    //  this.Text = nameof (HelpperExport);
    //  ((ISupportInitialize) this.printingSystem).EndInit();
    //  this.printableComponentLink.ImageCollection.EndInit();
    //  this.ResumeLayout(false);
    //}
  }
}

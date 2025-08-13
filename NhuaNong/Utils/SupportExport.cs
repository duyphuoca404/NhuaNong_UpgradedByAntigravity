// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.SupportExport
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

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

#nullable disable
namespace NhuaNong.Utils
{
  internal class SupportExport : Form
  {
    private bool _PrintTenCongTy;
    private bool _PrintDiaChiDienThoai;
    private string _Title = "";
    private List<string> _ListHeader = new List<string>();
    private string _Footer1 = "";
    private string _Footer2 = "";
    private int _NumberOfLineFooter = 1;
    private string _AlignFooter1 = "";
    private string _AlignFooter2 = "";
    private IContainer components;
    private PrintingSystem printingSystem;
    protected PrintableComponentLink printableComponentLink;
    private PrintDialog printDialog1;

    public SupportExport() => this.InitializeComponent();

    public void PrintWithHeader(
      bool useLandscapeView,
      IPrintable printableComponent,
      bool printTenCongTy,
      bool printDiaChiDienThoai,
      string title,
      List<string> lstHeader,
      bool inTrucTiep)
    {
      try
      {
        foreach (BandedGridView view in (ReadOnlyCollectionBase) (printableComponent as GridControl).Views)
          view.Columns["colDelete"].Visible = false;
      }
      catch (System.Exception ex)
      {
      }
      try
      {
        foreach (ColumnView view in (ReadOnlyCollectionBase) (printableComponent as GridControl).Views)
          view.Columns["colDelete"].Visible = false;
      }
      catch (System.Exception ex)
      {
      }
      this._PrintTenCongTy = printTenCongTy;
      this._PrintDiaChiDienThoai = printDiaChiDienThoai;
      this._Title = title;
      this._ListHeader = lstHeader;
      this.printableComponentLink.Component = (IBasePrintable) printableComponent;
      this.printableComponentLink.PaperKind = PaperKind.A4;
      this.printableComponentLink.Landscape = useLandscapeView;
      this.printableComponentLink.Margins.Bottom = 10f;
      this.printableComponentLink.Margins.Left = 10f;
      this.printableComponentLink.Margins.Right = 10f;
      this.printableComponentLink.Margins.Top = 10f;
      this.printingSystem.PageMargins.Bottom = 10f;
      this.printingSystem.PageMargins.Left = 10f;
      this.printingSystem.PageMargins.Right = 10f;
      this.printingSystem.PageMargins.Top = 10f;
      this.printableComponentLink.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_CreateReportHeaderArea);
      this.printableComponentLink.CreateDocument();
      if (inTrucTiep)
        this.printingSystem.Print();
      else
        this.printableComponentLink.ShowPreviewDialog();
    }

    public void ExportExcelWithHeader(
      bool useLandscapeView,
      IPrintable printableComponent,
      bool printTenCongTy,
      bool printDiaChiDienThoai,
      string title,
      List<string> lstHeader)
    {
      try
      {
        foreach (AdvBandedGridView view in (ReadOnlyCollectionBase) (printableComponent as GridControl).Views)
          ;
      }
      catch (System.Exception ex)
      {
      }
      try
      {
        foreach (GridView view in (ReadOnlyCollectionBase) (printableComponent as GridControl).Views)
          ;
      }
      catch (System.Exception ex)
      {
      }
      this._PrintTenCongTy = printTenCongTy;
      this._PrintDiaChiDienThoai = printDiaChiDienThoai;
      this._Title = title;
      this._ListHeader = lstHeader;
      this.printableComponentLink.Component = (IBasePrintable) printableComponent;
      this.printableComponentLink.PaperKind = PaperKind.A4;
      this.printableComponentLink.Landscape = useLandscapeView;
      this.printableComponentLink.Margins.Bottom = 10f;
      this.printableComponentLink.Margins.Left = 10f;
      this.printableComponentLink.Margins.Right = 10f;
      this.printableComponentLink.Margins.Top = 10f;
      this.printingSystem.PageMargins.Bottom = 10f;
      this.printingSystem.PageMargins.Left = 10f;
      this.printingSystem.PageMargins.Right = 10f;
      this.printingSystem.PageMargins.Top = 10f;
      this.printableComponentLink.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_CreateReportHeaderArea);
      this.printableComponentLink.CreateDocument();
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Excel file (*.xls)|*.xls";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      XlsExportOptions options = new XlsExportOptions();
      options.ShowGridLines = true;
      this.printableComponentLink.ExportToXls(saveFileDialog.FileName, options);
      try
      {
        new Process()
        {
          StartInfo = {
            FileName = saveFileDialog.FileName
          }
        }.Start();
      }
      catch (System.Exception ex)
      {
      }
    }

    public void ExportPDFWithHeader(
      bool useLandscapeView,
      IPrintable printableComponent,
      bool printTenCongTy,
      bool printDiaChiDienThoai,
      string title,
      List<string> lstHeader)
    {
      try
      {
        foreach (AdvBandedGridView view in (ReadOnlyCollectionBase) (printableComponent as GridControl).Views)
          ;
      }
      catch (System.Exception ex)
      {
      }
      try
      {
        foreach (GridView view in (ReadOnlyCollectionBase) (printableComponent as GridControl).Views)
          ;
      }
      catch (System.Exception ex)
      {
      }
      this._PrintTenCongTy = printTenCongTy;
      this._PrintDiaChiDienThoai = printDiaChiDienThoai;
      this._Title = title;
      this._ListHeader = lstHeader;
      this.printableComponentLink.Component = (IBasePrintable) printableComponent;
      this.printableComponentLink.PaperKind = PaperKind.A4;
      this.printableComponentLink.Landscape = useLandscapeView;
      this.printableComponentLink.Margins.Bottom = 10f;
      this.printableComponentLink.Margins.Left = 10f;
      this.printableComponentLink.Margins.Right = 10f;
      this.printableComponentLink.Margins.Top = 10f;
      this.printingSystem.PageMargins.Bottom = 10f;
      this.printingSystem.PageMargins.Left = 10f;
      this.printingSystem.PageMargins.Right = 10f;
      this.printingSystem.PageMargins.Top = 10f;
      this.printableComponentLink.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_CreateReportHeaderArea);
      this.printableComponentLink.CreateDocument();
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Pdf file (*.pdf)|*.pdf";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      PdfExportOptions options = new PdfExportOptions();
      this.printableComponentLink.ExportToPdf(saveFileDialog.FileName, options);
      try
      {
        new Process()
        {
          StartInfo = {
            FileName = saveFileDialog.FileName
          }
        }.Start();
      }
      catch (System.Exception ex)
      {
      }
    }

    public void PrintWithHeader(
      bool useLandscapeView,
      IPrintable printableComponent,
      bool printTenCongTy,
      bool printDiaChiDienThoai,
      bool printPageNumber,
      string title,
      List<string> lstHeader)
    {
      if (printPageNumber)
      {
        PageHeaderFooter pageHeaderFooter = this.printableComponentLink.PageHeaderFooter as PageHeaderFooter;
        pageHeaderFooter.Footer.Content.Clear();
        pageHeaderFooter.Footer.Content.AddRange(new string[3]
        {
          "",
          "",
          "Trang [Page #]"
        });
        pageHeaderFooter.Footer.LineAlignment = BrickAlignment.Center;
      }
      this._PrintTenCongTy = printTenCongTy;
      this._PrintDiaChiDienThoai = printDiaChiDienThoai;
      this._Title = title;
      this._ListHeader = lstHeader;
      this.printableComponentLink.Component = (IBasePrintable) printableComponent;
      this.printableComponentLink.PaperKind = PaperKind.A4;
      this.printableComponentLink.Landscape = useLandscapeView;
      this.printableComponentLink.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_CreateReportHeaderArea);
      this.printableComponentLink.CreateDocument();
      this.printableComponentLink.ShowPreview();
    }

    public void PrintWithHeaderAndFooter(
      bool useLandscapeView,
      IPrintable printableComponent,
      bool printTenCongTy,
      bool printDiaChiDienThoai,
      string title,
      List<string> lstHeader,
      string footer1,
      string footer2)
    {
      PageHeaderFooter pageHeaderFooter = this.printableComponentLink.PageHeaderFooter as PageHeaderFooter;
      pageHeaderFooter.Footer.Content.Clear();
      pageHeaderFooter.Footer.Content.AddRange(new string[3]
      {
        "",
        "",
        "Trang [Page #]"
      });
      pageHeaderFooter.Footer.LineAlignment = BrickAlignment.Center;
      this._PrintTenCongTy = printTenCongTy;
      this._PrintDiaChiDienThoai = printDiaChiDienThoai;
      this._Title = title;
      this._ListHeader = lstHeader;
      this._Footer1 = footer1;
      this._Footer2 = footer2;
      this.printableComponentLink.Component = (IBasePrintable) printableComponent;
      this.printableComponentLink.PaperKind = PaperKind.A4;
      this.printableComponentLink.Landscape = useLandscapeView;
      this.printableComponentLink.CreateReportHeaderArea += new CreateAreaEventHandler(this.printableComponentLink_CreateReportHeaderArea);
      this.printableComponentLink.CreateReportFooterArea += new CreateAreaEventHandler(this.printableComponentLink_CreateReportFooterArea);
      this.printableComponentLink.CreateDocument();
      this.printableComponentLink.ShowPreview();
    }

    private void printableComponentLink_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
    {
      try
      {
        int y = 0;
        string str1 = "";
        string str2 = "";
        try
        {
          str1 = ConfigManager.TramTronConfig.TenCty;
          str2 = ConfigManager.TramTronConfig.DiaChiCty;
        }
        catch (System.Exception ex)
        {
        }
        if (this._PrintTenCongTy)
        {
          string text = str1;
          e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Near);
          e.Graph.Font = (DXFont) new Font("Times New Roman", 12f, FontStyle.Regular);
          RectangleF rect = new RectangleF(0.0f, (float) y, e.Graph.ClientPageSize.Width, 20f);
          y += 20;
          e.Graph.DrawString(text, Color.Black, rect, BorderSide.None);
        }
        if (this._PrintDiaChiDienThoai)
        {
          string text = string.Format("Địa chỉ: {0}", (object) str2);
          e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Near);
          e.Graph.Font = (DXFont) new Font("Times New Roman", 12f, FontStyle.Regular);
          RectangleF rect = new RectangleF(0.0f, (float) y, e.Graph.ClientPageSize.Width, 30f);
          y += 30;
          e.Graph.DrawString(text, Color.Black, rect, BorderSide.None);
        }
        if (this._Title.Length > 0)
        {
          e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
          e.Graph.Font = (DXFont) new Font("Tahoma", 14f, FontStyle.Bold);
          RectangleF rect = new RectangleF(0.0f, (float) y, e.Graph.ClientPageSize.Width, 30f);
          y += 30;
          e.Graph.DrawString(this._Title, Color.Black, rect, BorderSide.None);
        }
        for (int index = 0; index < this._ListHeader.Count; ++index)
        {
          if (this._ListHeader[index].Length > 0)
          {
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Near);
            e.Graph.Font = (DXFont) new Font("Tahoma", 10f, FontStyle.Regular);
            RectangleF rect = new RectangleF(0.0f, (float) y, e.Graph.ClientPageSize.Width, 20f);
            y += 20;
            e.Graph.DrawString(this._ListHeader[index], Color.Black, rect, BorderSide.None);
          }
        }
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void printableComponentLink_CreateReportFooterArea(object sender, CreateAreaEventArgs e)
    {
      try
      {
        int y = 25;
        if (this._NumberOfLineFooter == 2)
        {
          e.Graph.BackColor = Color.White;
          RectangleF rect;
          if (this._Footer1.Length > 0)
          {
            e.Graph.StringFormat = !(this._AlignFooter1.ToUpper() == "CENTER") ? (!(this._AlignFooter1.ToUpper() == "RIGHT") ? new BrickStringFormat(StringAlignment.Near) : new BrickStringFormat(StringAlignment.Far)) : new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = (DXFont) new Font("Times New Roman", 12f, FontStyle.Regular);
            rect = new RectangleF(0.0f, (float) y, e.Graph.ClientPageSize.Width, 30f);
            y += 30;
            e.Graph.DrawString(this._Footer1, Color.Black, rect, BorderSide.None);
          }
          if (this._Footer2.Length <= 0)
            return;
          e.Graph.StringFormat = !(this._AlignFooter2.ToUpper() == "CENTER") ? (!(this._AlignFooter2.ToUpper() == "RIGHT") ? new BrickStringFormat(StringAlignment.Near) : new BrickStringFormat(StringAlignment.Far)) : new BrickStringFormat(StringAlignment.Center);
          e.Graph.Font = (DXFont) new Font("Times New Roman", 12f, FontStyle.Regular);
          rect = new RectangleF(0.0f, (float) y, e.Graph.ClientPageSize.Width, 90f);
          e.Graph.DrawString(this._Footer2, Color.Black, rect, BorderSide.None);
        }
        else
        {
          e.Graph.BackColor = Color.White;
          RectangleF rect;
          if (this._Footer1.Length > 0)
          {
            e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
            e.Graph.Font = (DXFont) new Font("Times New Roman", 12f, FontStyle.Regular);
            rect = new RectangleF(0.0f, 30f, 410f, 90f);
            e.Graph.DrawString(this._Footer1, Color.Black, rect, BorderSide.None);
          }
          if (this._Footer2.Length <= 0)
            return;
          e.Graph.StringFormat = new BrickStringFormat(StringAlignment.Center);
          e.Graph.Font = (DXFont) new Font("Times New Roman", 12f, FontStyle.Regular);
          rect = new RectangleF(600f, 30f, 300f, 90f);
          e.Graph.DrawString(this._Footer2, Color.Black, rect, BorderSide.None);
        }
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (SupportExport));
      this.printingSystem = new PrintingSystem(this.components);
      this.printableComponentLink = new PrintableComponentLink(this.components);
      this.printDialog1 = new PrintDialog();
      ((ISupportInitialize) this.printingSystem).BeginInit();
      this.printableComponentLink.ImageCollection.BeginInit();
      this.SuspendLayout();
      this.printingSystem.Links.AddRange(new object[1]
      {
        (object) this.printableComponentLink
      });
      this.printableComponentLink.ImageCollection.ImageStream = (ImageCollectionStreamer) componentResourceManager.GetObject("printableComponentLink.ImageCollection.ImageStream");
      this.printableComponentLink.PaperKind = PaperKind.A4;
      this.printableComponentLink.PrintingSystem = this.printingSystem;
      this.printableComponentLink.PrintingSystemBase = (PrintingSystemBase) this.printingSystem;
      this.printDialog1.UseEXDialog = true;
      this.ClientSize = new Size(1264, 692);
      this.Name = nameof (SupportExport);
      ((ISupportInitialize) this.printingSystem).EndInit();
      this.printableComponentLink.ImageCollection.EndInit();
      this.ResumeLayout(false);
    }
  }
}

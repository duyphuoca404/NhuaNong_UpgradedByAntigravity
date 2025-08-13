// Decompiled with JetBrains decompiler
// Type: NhuaNong.Utils.WriteInvoice
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Office.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;

#nullable disable
namespace NhuaNong.Utils
{
  public class WriteInvoice
  {
    public string folderPhieuThuc;
    public bool inTrucTiep;

    public bool WriteDetailInvoiceTPCP(
      string[] param,
      GridView gridView,
      int somauphieu,
      int sobanin)
    {
      try
      {
        string str = "MAUTPCP" + somauphieu.ToString() + ".docx";
        string fileName = Path.Combine(this.folderPhieuThuc, "MAUTPCP" + somauphieu.ToString() + ".pdf");
        using (RichEditDocumentServer richEdit = new RichEditDocumentServer())
        {
          richEdit.LoadDocument(str);
          for (int index = 0; index < param.Length; ++index)
          {
            string placeholder = "{" + index.ToString() + "}";
            this.ReplacePlaceholder(richEdit, placeholder, param[index]);
          }
          richEdit.ExportToPdf(fileName);
        }
        if (this.inTrucTiep)
        {
          int num = 0;
          while (num < sobanin)
            ++num;
        }
        else
          Process.Start(fileName);
        File.Delete(str);
        return true;
      }
      catch (System.Exception ex)
      {
        return false;
      }
    }

    private void ReplacePlaceholder(
      RichEditDocumentServer richEdit,
      string placeholder,
      string replacement)
    {
      Document document = richEdit.Document;
      string text = document.Text.Replace(placeholder, replacement);
      document.Delete(document.Range);
      document.AppendText(text);
    }

    private void CreateTableCP(Document doc, GridView gridView)
    {
      DataTable dataSource = (DataTable) gridView.GridControl.DataSource;
      List<string> stringList = new List<string>();
      int rowCount = 0;
      Table table = doc.Tables.Create(doc.Range.End, rowCount, 1);
      table.PreferredWidth = Units.InchesToDocumentsF(6f);
      TableRow row = table.Rows[0];
    }
  }
}

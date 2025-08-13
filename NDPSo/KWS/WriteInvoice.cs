// Decompiled with JetBrains decompiler
// Type: NDPSo.KWS.WriteInvoice
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

#nullable disable
namespace NDPSo.KWS
{
  public class WriteInvoice
  {
    public void WriteDetailInvoice()
    {
      WriteInvoice.UpdateTableColumns("path/to/your/document.docx", new List<Decimal>()
      {
        100M,
        200M,
        300M
      }, new List<string>()
      {
        "Header1",
        "Header2",
        "Header3"
      }, new DataTable(), 12345M, 0, 1, 2);
    }

    private static void UpdateTableColumns(
      string filePath,
      List<Decimal> totalTextList,
      List<string> headerTextList,
      DataTable dataTable,
      Decimal sumCP,
      params int[] targetColumnIndexes)
    {
      using (WordprocessingDocument wordprocessingDocument = WordprocessingDocument.Open(filePath, true))
      {
        Table table = wordprocessingDocument.MainDocumentPart.Document.Body.Descendants<Table>().FirstOrDefault<Table>();
        if (table != null)
        {
          table.RemoveAllChildren<TableRow>();
          WriteInvoice.AddRowToTable(table, headerTextList, true);
          foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
            WriteInvoice.AddRowToTable(table, ((IEnumerable<object>) row.ItemArray).Select<object, string>((System.Func<object, string>) (item => item.ToString())).ToList<string>(), false);
          WriteInvoice.AddRowToTable(table, totalTextList.Select<Decimal, string>((System.Func<Decimal, string>) (total => total.ToString())).ToList<string>(), false);
          WriteInvoice.AddRowToTable(table, new List<string>()
          {
            "Tổng cộng",
            sumCP.ToString()
          }, false);
        }
        wordprocessingDocument.MainDocumentPart.Document.Save();
      }
    }

    private static void AddRowToTable(Table table, List<string> cellValues, bool isHeader)
    {
      TableRow tableRow = new TableRow();
      foreach (string cellValue in cellValues)
      {
        TableCell tableCell1 = new TableCell(new OpenXmlElement[1]
        {
          (OpenXmlElement) new Paragraph(new OpenXmlElement[1]
          {
            (OpenXmlElement) new Run(new OpenXmlElement[1]
            {
              (OpenXmlElement) new Text(cellValue)
            })
          })
        });
        TableCellProperties tableCellProperties = new TableCellProperties();
        TableCellWidth tableCellWidth = new TableCellWidth();
        tableCellWidth.Type = (EnumValue<TableWidthUnitValues>) TableWidthUnitValues.Dxa;
        tableCellWidth.Width = (StringValue) "150";
        tableCellProperties.TableCellWidth = tableCellWidth;
        tableCell1.TableCellProperties = tableCellProperties;
        TableCell tableCell2 = tableCell1;
        if (isHeader)
          tableCell2.TableCellProperties = new TableCellProperties(new OpenXmlElement[1]
          {
            (OpenXmlElement) new TableCellBorders(new OpenXmlElement[4]
            {
              (OpenXmlElement) new TopBorder(),
              (OpenXmlElement) new BottomBorder(),
              (OpenXmlElement) new LeftBorder(),
              (OpenXmlElement) new RightBorder()
            })
          });
        tableRow.Append((OpenXmlElement) tableCell2);
      }
      table.Append((OpenXmlElement) tableRow);
    }
  }
}

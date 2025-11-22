using DevExpress.Drawing;
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

#nullable disable
namespace NhuaNong.KWS
{
  public partial class PhieuTronChiTietRP1 : XtraReport
  {
    

    public PhieuTronChiTietRP1(
      List<string> para,
      List<Decimal> totalTextList,
      List<string> headerTextList,
      DataTable table,
      Decimal sumCP,
      params int[] targetColumnIndexes)
    {
      this.InitializeComponent();
      this.LoadParam(para);
      this.UpdateTableColumns(totalTextList, headerTextList, table, sumCP, targetColumnIndexes);
    }

    private void LoadParam(List<string> para)
    {
      this.xrLblTenTram.Text = para[0];
      this.xrLblDate0.Text = para[1];
      this.xrLblCongTruong0.Text = para[2];
      this.xrLblMaPhieu.Text = para[16];
      this.xrLblKhachHang.Text = para[3];
      this.xrLblCongTruong.Text = para[2];
      this.xrLblDiaDiem.Text = para[15];
      this.xrLblMAC.Text = para[4];
      this.xrLblTheTichXe.Text = para[10];
      this.xrLblDate.Text = para[1];
      this.xrLblTime.Text = para[14];
      this.xrLblHangMuc.Text = para[18];
      this.xrLblBienSo.Text = para[13];
      this.xrLblLaiXe.Text = para[9];
      this.xrLblNhanVien.Text = "- Tạo bởi - " + GlobalValues.DisplayUser;
    }

    private void UpdateTableColumns(
      List<Decimal> totalTextList,
      List<string> headerTextList,
      DataTable dataTable,
      Decimal sumCP,
      params int[] targetColumnIndexes)
    {
      if (headerTextList.Count <= 0 || targetColumnIndexes.Length == 0)
        return;
      XRTableRow row1 = new XRTableRow();
      for (int index1 = 0; index1 < targetColumnIndexes.Length; ++index1)
      {
        int index2 = index1;
        if (index2 >= 0 && index2 < headerTextList.Count)
        {
          string headerText = headerTextList[index2];
          XRTableCell xrTableCell = new XRTableCell();
          xrTableCell.Text = headerText;
          xrTableCell.TextAlignment = TextAlignment.MiddleCenter;
          xrTableCell.Width = 150;
          XRTableCell cell = xrTableCell;
          cell.Font = (DXFont) new System.Drawing.Font(cell.Font.Name, 9f, FontStyle.Bold);
          row1.Cells.Add(cell);
        }
      }
      this.xrTable1.Rows.Add(row1);
      int num = 0;
      foreach (DataRow row2 in (InternalDataCollectionBase) dataTable.Rows)
      {
        XRTableRow row3 = new XRTableRow();
        for (int index = 0; index < targetColumnIndexes.Length; ++index)
        {
          int targetColumnIndex = targetColumnIndexes[index];
          if (targetColumnIndex >= 0 && targetColumnIndex < dataTable.Columns.Count)
          {
            string str = row2[targetColumnIndex].ToString();
            XRTableCell xrTableCell = new XRTableCell();
            xrTableCell.Text = str;
            xrTableCell.TextAlignment = TextAlignment.MiddleCenter;
            xrTableCell.Width = 150;
            XRTableCell cell = xrTableCell;
            if (index == 0)
              cell.Font = (DXFont) new System.Drawing.Font(cell.Font.Name, 9f, FontStyle.Bold);
            else
              cell.Font = (DXFont) new System.Drawing.Font(cell.Font.Name, 9f, FontStyle.Regular);
            row3.Cells.Add(cell);
          }
        }
        this.xrTable1.Rows.Add(row3);
        ++num;
        if (num == 3)
        {
          XRTableRow row4 = new XRTableRow();
          XRTableCell xrTableCell = new XRTableCell();
          xrTableCell.Text = "CHI TIẾT MẺ TRỘN(DETAIL)";
          xrTableCell.WidthF = 450f;
          xrTableCell.TextAlignment = TextAlignment.MiddleCenter;
          XRTableCell cell = xrTableCell;
          cell.Font = (DXFont) new System.Drawing.Font(cell.Font.Name, 8f, FontStyle.Bold);
          row4.Cells.Add(cell);
          this.xrTable1.Rows.Add(row4);
        }
      }
      XRTableRow row5 = new XRTableRow();
      for (int index3 = 0; index3 < targetColumnIndexes.Length; ++index3)
      {
        int index4 = index3;
        if (index4 == 0)
        {
          XRTableCell xrTableCell = new XRTableCell();
          xrTableCell.Text = "Tổng";
          xrTableCell.TextAlignment = TextAlignment.MiddleCenter;
          xrTableCell.Width = 150;
          XRTableCell cell = xrTableCell;
          cell.Font = (DXFont) new System.Drawing.Font(cell.Font.Name, 9f, FontStyle.Bold);
          row5.Cells.Add(cell);
        }
        if (index4 > 0 && index4 < totalTextList.Count)
        {
          string str = totalTextList[index4].ToString();
          XRTableCell xrTableCell = new XRTableCell();
          xrTableCell.Text = str;
          xrTableCell.TextAlignment = TextAlignment.MiddleCenter;
          xrTableCell.Width = 150;
          XRTableCell cell = xrTableCell;
          cell.Font = (DXFont) new System.Drawing.Font(cell.Font.Name, 9f, FontStyle.Regular);
          row5.Cells.Add(cell);
        }
      }
      this.xrTable1.Rows.Add(row5);
      XRTableRow row6 = new XRTableRow();
      XRTableCell xrTableCell1 = new XRTableCell();
      xrTableCell1.Text = sumCP.ToString();
      xrTableCell1.WidthF = 450f;
      xrTableCell1.TextAlignment = TextAlignment.MiddleCenter;
      XRTableCell cell1 = xrTableCell1;
      cell1.Font = (DXFont) new System.Drawing.Font(cell1.Font.Name, 9f, FontStyle.Bold);
      row6.Cells.Add(cell1);
      this.xrTable1.Rows.Add(row6);
    }

    
  }
}

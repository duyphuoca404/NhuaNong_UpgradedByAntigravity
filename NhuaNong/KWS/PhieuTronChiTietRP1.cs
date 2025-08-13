// Decompiled with JetBrains decompiler
// Type: NhuaNong.KWS.PhieuTronChiTietRP1
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

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
  public class PhieuTronChiTietRP1 : XtraReport
  {
    private IContainer components;
    private TopMarginBand TopMargin;
    private BottomMarginBand BottomMargin;
    private DetailBand Detail;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRLabel xrLabel1;
    private XRLabel xrLblKhachHang;
    private XRLabel xrLblCongTruong;
    private XRLabel xrLblDiaDiem;
    private XRLabel xrLblBienSo;
    private XRLabel xrLblHangMuc;
    private XRLabel xrLblTime;
    private XRLabel xrLblDate;
    private XRLabel xrLblLaiXe;
    private XRLabel xrLblMAC;
    private XRLabel xrLblTheTichXe;
    private XRLabel xrLabel7;
    private XRLabel xrLblMaPhieu;
    private XRLabel xrLblCongTruong0;
    private XRLabel xrLblDate0;
    private XRLabel xrLblTenTram;
    private XRLabel xrLblNhanVien;
    private XRLabel xrLabel3;
    private XRLabel xrLabel2;
    private XRLabel xrLabel15;
    private XRLabel xrLabel10;
    private XRLabel xrLabel13;
    private XRLabel xrLabel12;
    private XRLabel xrLabel11;
    private XRLabel xrLabel14;
    private XRLabel xrLabel9;
    private XRLabel xrLabel8;
    private XRLabel xrLabel6;
    private XRLabel xrLabel5;
    private XRLabel xrLabel4;
    private XRLabel xrLabel17;
    private XRLabel xrLabel16;

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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.TopMargin = new TopMarginBand();
      this.xrLblMaPhieu = new XRLabel();
      this.xrLblCongTruong0 = new XRLabel();
      this.xrLblDate0 = new XRLabel();
      this.xrLblTenTram = new XRLabel();
      this.xrLabel7 = new XRLabel();
      this.xrLblBienSo = new XRLabel();
      this.xrLblHangMuc = new XRLabel();
      this.xrLblTime = new XRLabel();
      this.xrLblDate = new XRLabel();
      this.xrLblLaiXe = new XRLabel();
      this.xrLblMAC = new XRLabel();
      this.xrLblTheTichXe = new XRLabel();
      this.xrLblDiaDiem = new XRLabel();
      this.xrLblCongTruong = new XRLabel();
      this.xrLblKhachHang = new XRLabel();
      this.xrLabel1 = new XRLabel();
      this.BottomMargin = new BottomMarginBand();
      this.xrLblNhanVien = new XRLabel();
      this.Detail = new DetailBand();
      this.xrLabel3 = new XRLabel();
      this.xrLabel2 = new XRLabel();
      this.xrTable1 = new XRTable();
      this.xrTableRow1 = new XRTableRow();
      this.xrTableCell1 = new XRTableCell();
      this.xrLabel4 = new XRLabel();
      this.xrLabel5 = new XRLabel();
      this.xrLabel6 = new XRLabel();
      this.xrLabel8 = new XRLabel();
      this.xrLabel9 = new XRLabel();
      this.xrLabel10 = new XRLabel();
      this.xrLabel11 = new XRLabel();
      this.xrLabel12 = new XRLabel();
      this.xrLabel13 = new XRLabel();
      this.xrLabel14 = new XRLabel();
      this.xrLabel15 = new XRLabel();
      this.xrLabel16 = new XRLabel();
      this.xrLabel17 = new XRLabel();
      this.xrTable1.BeginInit();
      this.BeginInit();
      this.TopMargin.Controls.AddRange(new XRControl[27]
      {
        (XRControl) this.xrLabel15,
        (XRControl) this.xrLabel10,
        (XRControl) this.xrLabel13,
        (XRControl) this.xrLabel12,
        (XRControl) this.xrLabel11,
        (XRControl) this.xrLabel14,
        (XRControl) this.xrLabel9,
        (XRControl) this.xrLabel8,
        (XRControl) this.xrLabel6,
        (XRControl) this.xrLabel5,
        (XRControl) this.xrLabel4,
        (XRControl) this.xrLblMaPhieu,
        (XRControl) this.xrLblCongTruong0,
        (XRControl) this.xrLblDate0,
        (XRControl) this.xrLblTenTram,
        (XRControl) this.xrLabel7,
        (XRControl) this.xrLblBienSo,
        (XRControl) this.xrLblHangMuc,
        (XRControl) this.xrLblTime,
        (XRControl) this.xrLblDate,
        (XRControl) this.xrLblLaiXe,
        (XRControl) this.xrLblMAC,
        (XRControl) this.xrLblTheTichXe,
        (XRControl) this.xrLblDiaDiem,
        (XRControl) this.xrLblCongTruong,
        (XRControl) this.xrLblKhachHang,
        (XRControl) this.xrLabel1
      });
      this.TopMargin.HeightF = 313.4668f;
      this.TopMargin.Name = "TopMargin";
      this.xrLblMaPhieu.AutoWidth = true;
      this.xrLblMaPhieu.CanShrink = true;
      this.xrLblMaPhieu.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblMaPhieu.LocationFloat = new PointFloat(606.7501f, 141.8788f);
      this.xrLblMaPhieu.Name = "xrLblMaPhieu";
      this.xrLblMaPhieu.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblMaPhieu.SizeF = new SizeF(127.2499f, 23f);
      this.xrLblMaPhieu.StylePriority.UseFont = false;
      this.xrLblMaPhieu.StylePriority.UseTextAlignment = false;
      this.xrLblMaPhieu.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblCongTruong0.AutoWidth = true;
      this.xrLblCongTruong0.CanShrink = true;
      this.xrLblCongTruong0.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblCongTruong0.LocationFloat = new PointFloat(0.0f, 60f);
      this.xrLblCongTruong0.Name = "xrLblCongTruong0";
      this.xrLblCongTruong0.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblCongTruong0.SizeF = new SizeF(399.9663f, 23f);
      this.xrLblCongTruong0.StylePriority.UseFont = false;
      this.xrLblCongTruong0.StylePriority.UseTextAlignment = false;
      this.xrLblCongTruong0.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblDate0.AutoWidth = true;
      this.xrLblDate0.CanShrink = true;
      this.xrLblDate0.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblDate0.LocationFloat = new PointFloat(0.0001059638f, 35f);
      this.xrLblDate0.Name = "xrLblDate0";
      this.xrLblDate0.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblDate0.SizeF = new SizeF(399.9662f, 23f);
      this.xrLblDate0.StylePriority.UseFont = false;
      this.xrLblDate0.StylePriority.UseTextAlignment = false;
      this.xrLblDate0.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblTenTram.AutoWidth = true;
      this.xrLblTenTram.CanShrink = true;
      this.xrLblTenTram.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblTenTram.LocationFloat = new PointFloat(0.0001059638f, 10.00001f);
      this.xrLblTenTram.Name = "xrLblTenTram";
      this.xrLblTenTram.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblTenTram.SizeF = new SizeF(399.9662f, 23f);
      this.xrLblTenTram.StylePriority.UseFont = false;
      this.xrLblTenTram.StylePriority.UseTextAlignment = false;
      this.xrLblTenTram.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel7.Font = new DXFont("Times New Roman", 12f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLabel7.LocationFloat = new PointFloat(199.2883f, 115f);
      this.xrLabel7.Multiline = true;
      this.xrLabel7.Name = "xrLabel7";
      this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel7.SizeF = new SizeF(352.0833f, 23f);
      this.xrLabel7.StylePriority.UseFont = false;
      this.xrLabel7.StylePriority.UseTextAlignment = false;
      this.xrLabel7.Text = "DELIVERY DETAIL";
      this.xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLblBienSo.AutoWidth = true;
      this.xrLblBienSo.CanShrink = true;
      this.xrLblBienSo.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblBienSo.LocationFloat = new PointFloat(606.7501f, 255.0001f);
      this.xrLblBienSo.Name = "xrLblBienSo";
      this.xrLblBienSo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblBienSo.SizeF = new SizeF(117.2499f, 22.99998f);
      this.xrLblBienSo.StylePriority.UseFont = false;
      this.xrLblBienSo.StylePriority.UseTextAlignment = false;
      this.xrLblBienSo.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblHangMuc.AutoWidth = true;
      this.xrLblHangMuc.CanShrink = true;
      this.xrLblHangMuc.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblHangMuc.LocationFloat = new PointFloat(606.7501f, 230f);
      this.xrLblHangMuc.Name = "xrLblHangMuc";
      this.xrLblHangMuc.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblHangMuc.SizeF = new SizeF(117.2499f, 23f);
      this.xrLblHangMuc.StylePriority.UseFont = false;
      this.xrLblHangMuc.StylePriority.UseTextAlignment = false;
      this.xrLblHangMuc.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblTime.AutoWidth = true;
      this.xrLblTime.CanShrink = true;
      this.xrLblTime.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblTime.LocationFloat = new PointFloat(606.7501f, 205f);
      this.xrLblTime.Name = "xrLblTime";
      this.xrLblTime.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblTime.SizeF = new SizeF(117.2499f, 22.99995f);
      this.xrLblTime.StylePriority.UseFont = false;
      this.xrLblTime.StylePriority.UseTextAlignment = false;
      this.xrLblTime.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblDate.AutoWidth = true;
      this.xrLblDate.CanShrink = true;
      this.xrLblDate.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblDate.LocationFloat = new PointFloat(606.7501f, 180f);
      this.xrLblDate.Name = "xrLblDate";
      this.xrLblDate.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblDate.SizeF = new SizeF(117.2499f, 23f);
      this.xrLblDate.StylePriority.UseFont = false;
      this.xrLblDate.StylePriority.UseTextAlignment = false;
      this.xrLblDate.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblLaiXe.AutoWidth = true;
      this.xrLblLaiXe.CanShrink = true;
      this.xrLblLaiXe.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblLaiXe.LocationFloat = new PointFloat(606.7501f, 280f);
      this.xrLblLaiXe.Name = "xrLblLaiXe";
      this.xrLblLaiXe.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblLaiXe.SizeF = new SizeF(117.2499f, 23f);
      this.xrLblLaiXe.StylePriority.UseFont = false;
      this.xrLblLaiXe.StylePriority.UseTextAlignment = false;
      this.xrLblLaiXe.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblMAC.AutoWidth = true;
      this.xrLblMAC.CanShrink = true;
      this.xrLblMAC.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblMAC.LocationFloat = new PointFloat(178f, (float) byte.MaxValue);
      this.xrLblMAC.Name = "xrLblMAC";
      this.xrLblMAC.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblMAC.SizeF = new SizeF(260f, 22.99997f);
      this.xrLblMAC.StylePriority.UseFont = false;
      this.xrLblMAC.StylePriority.UseTextAlignment = false;
      this.xrLblMAC.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblTheTichXe.AutoWidth = true;
      this.xrLblTheTichXe.CanShrink = true;
      this.xrLblTheTichXe.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblTheTichXe.LocationFloat = new PointFloat(178f, 280f);
      this.xrLblTheTichXe.Name = "xrLblTheTichXe";
      this.xrLblTheTichXe.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblTheTichXe.SizeF = new SizeF(260f, 23f);
      this.xrLblTheTichXe.StylePriority.UseFont = false;
      this.xrLblTheTichXe.StylePriority.UseTextAlignment = false;
      this.xrLblTheTichXe.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblDiaDiem.AutoWidth = true;
      this.xrLblDiaDiem.CanShrink = true;
      this.xrLblDiaDiem.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblDiaDiem.LocationFloat = new PointFloat(178f, 230f);
      this.xrLblDiaDiem.Name = "xrLblDiaDiem";
      this.xrLblDiaDiem.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblDiaDiem.SizeF = new SizeF(260f, 23f);
      this.xrLblDiaDiem.StylePriority.UseFont = false;
      this.xrLblDiaDiem.StylePriority.UseTextAlignment = false;
      this.xrLblDiaDiem.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblCongTruong.AutoWidth = true;
      this.xrLblCongTruong.CanShrink = true;
      this.xrLblCongTruong.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblCongTruong.LocationFloat = new PointFloat(178f, 205f);
      this.xrLblCongTruong.Name = "xrLblCongTruong";
      this.xrLblCongTruong.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblCongTruong.SizeF = new SizeF(260f, 22.99995f);
      this.xrLblCongTruong.StylePriority.UseFont = false;
      this.xrLblCongTruong.StylePriority.UseTextAlignment = false;
      this.xrLblCongTruong.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLblKhachHang.AutoWidth = true;
      this.xrLblKhachHang.CanShrink = true;
      this.xrLblKhachHang.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblKhachHang.LocationFloat = new PointFloat(178f, 180f);
      this.xrLblKhachHang.Name = "xrLblKhachHang";
      this.xrLblKhachHang.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblKhachHang.SizeF = new SizeF(260f, 23f);
      this.xrLblKhachHang.StylePriority.UseFont = false;
      this.xrLblKhachHang.StylePriority.UseTextAlignment = false;
      this.xrLblKhachHang.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel1.Font = new DXFont("Times New Roman", 15.75f, DXFontStyle.Bold, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLabel1.LocationFloat = new PointFloat(199.2916f, 86.625f);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel1.SizeF = new SizeF(352.0833f, 28.37499f);
      this.xrLabel1.StylePriority.UseFont = false;
      this.xrLabel1.StylePriority.UseTextAlignment = false;
      this.xrLabel1.Text = "PHIẾU XUẤT BÊ TÔNG CHI TIẾT";
      this.xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
      this.BottomMargin.Controls.AddRange(new XRControl[1]
      {
        (XRControl) this.xrLblNhanVien
      });
      this.BottomMargin.Name = "BottomMargin";
      this.xrLblNhanVien.Font = new DXFont("Times New Roman", 8.25f, DXFontStyle.Italic, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLblNhanVien.LocationFloat = new PointFloat(9.999998f, 22.91667f);
      this.xrLblNhanVien.Multiline = true;
      this.xrLblNhanVien.Name = "xrLblNhanVien";
      this.xrLblNhanVien.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLblNhanVien.SizeF = new SizeF(234.6666f, 23f);
      this.xrLblNhanVien.StylePriority.UseFont = false;
      this.Detail.Controls.AddRange(new XRControl[5]
      {
        (XRControl) this.xrLabel17,
        (XRControl) this.xrLabel16,
        (XRControl) this.xrLabel3,
        (XRControl) this.xrLabel2,
        (XRControl) this.xrTable1
      });
      this.Detail.HeightF = 220.3295f;
      this.Detail.Name = "Detail";
      this.xrLabel3.AutoWidth = true;
      this.xrLabel3.CanShrink = true;
      this.xrLabel3.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLabel3.LocationFloat = new PointFloat(100f, 65f);
      this.xrLabel3.Name = "xrLabel3";
      this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel3.SizeF = new SizeF(150.0358f, 23.00001f);
      this.xrLabel3.StylePriority.UseFont = false;
      this.xrLabel3.StylePriority.UseTextAlignment = false;
      this.xrLabel3.Text = "KHÁCH HÀNG";
      this.xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel2.AutoWidth = true;
      this.xrLabel2.CanShrink = true;
      this.xrLabel2.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLabel2.LocationFloat = new PointFloat(500f, 65f);
      this.xrLabel2.Name = "xrLabel2";
      this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel2.SizeF = new SizeF(150.0358f, 23f);
      this.xrLabel2.StylePriority.UseFont = false;
      this.xrLabel2.StylePriority.UseTextAlignment = false;
      this.xrLabel2.Text = "VẬN HÀNH";
      this.xrLabel2.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTable1.Borders = BorderSide.Left | BorderSide.Right | BorderSide.Bottom;
      this.xrTable1.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Regular, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrTable1.LocationFloat = new PointFloat(9.71335E-05f, 10.00002f);
      this.xrTable1.Name = "xrTable1";
      this.xrTable1.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrTable1.Rows.AddRange(new XRTableRow[1]
      {
        this.xrTableRow1
      });
      this.xrTable1.SizeF = new SizeF(733.9999f, 34.375f);
      this.xrTable1.StylePriority.UseBorders = false;
      this.xrTable1.StylePriority.UseFont = false;
      this.xrTable1.StylePriority.UseTextAlignment = false;
      this.xrTable1.TextAlignment = TextAlignment.MiddleCenter;
      this.xrTableRow1.Cells.AddRange(new XRTableCell[1]
      {
        this.xrTableCell1
      });
      this.xrTableRow1.Name = "xrTableRow1";
      this.xrTableRow1.Weight = 1.0;
      this.xrTableCell1.Multiline = true;
      this.xrTableCell1.Name = "xrTableCell1";
      this.xrTableCell1.Weight = 1.0;
      this.xrLabel4.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel4.LocationFloat = new PointFloat(0.0f, 180f);
      this.xrLabel4.Multiline = true;
      this.xrLabel4.Name = "xrLabel4";
      this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 96f);
      this.xrLabel4.SizeF = new SizeF(175.3299f, 23f);
      this.xrLabel4.StylePriority.UseFont = false;
      this.xrLabel4.StylePriority.UseTextAlignment = false;
      this.xrLabel4.Text = "Khách hàng(Customer):";
      this.xrLabel4.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel5.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel5.LocationFloat = new PointFloat(0.0f, 205f);
      this.xrLabel5.Multiline = true;
      this.xrLabel5.Name = "xrLabel5";
      this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel5.SizeF = new SizeF(175.3299f, 23f);
      this.xrLabel5.StylePriority.UseFont = false;
      this.xrLabel5.StylePriority.UseTextAlignment = false;
      this.xrLabel5.Text = "Công trường(Site):";
      this.xrLabel5.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel6.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel6.LocationFloat = new PointFloat(0.0f, 230f);
      this.xrLabel6.Multiline = true;
      this.xrLabel6.Name = "xrLabel6";
      this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel6.SizeF = new SizeF(175.3299f, 23f);
      this.xrLabel6.StylePriority.UseFont = false;
      this.xrLabel6.StylePriority.UseTextAlignment = false;
      this.xrLabel6.Text = "Địa điểm(Location):";
      this.xrLabel6.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel8.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel8.LocationFloat = new PointFloat(0.0f, (float) byte.MaxValue);
      this.xrLabel8.Multiline = true;
      this.xrLabel8.Name = "xrLabel8";
      this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel8.SizeF = new SizeF(175.3299f, 23f);
      this.xrLabel8.StylePriority.UseFont = false;
      this.xrLabel8.StylePriority.UseTextAlignment = false;
      this.xrLabel8.Text = "Mác(Grade):";
      this.xrLabel8.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel9.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel9.LocationFloat = new PointFloat(0.0001033147f, 280f);
      this.xrLabel9.Multiline = true;
      this.xrLabel9.Name = "xrLabel9";
      this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel9.SizeF = new SizeF(175.3299f, 23f);
      this.xrLabel9.StylePriority.UseFont = false;
      this.xrLabel9.StylePriority.UseTextAlignment = false;
      this.xrLabel9.Text = "Số khối(Quantity):";
      this.xrLabel9.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel10.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel10.LocationFloat = new PointFloat(442.9583f, 180f);
      this.xrLabel10.Multiline = true;
      this.xrLabel10.Name = "xrLabel10";
      this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel10.SizeF = new SizeF(162.8299f, 23f);
      this.xrLabel10.StylePriority.UseFont = false;
      this.xrLabel10.StylePriority.UseTextAlignment = false;
      this.xrLabel10.Text = "Ngày(Date):";
      this.xrLabel10.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel11.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel11.LocationFloat = new PointFloat(442.9583f, 205f);
      this.xrLabel11.Multiline = true;
      this.xrLabel11.Name = "xrLabel11";
      this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel11.SizeF = new SizeF(162.8299f, 23f);
      this.xrLabel11.StylePriority.UseFont = false;
      this.xrLabel11.StylePriority.UseTextAlignment = false;
      this.xrLabel11.Text = "Giờ(Time):";
      this.xrLabel11.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel12.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel12.LocationFloat = new PointFloat(442.9582f, 230f);
      this.xrLabel12.Multiline = true;
      this.xrLabel12.Name = "xrLabel12";
      this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel12.SizeF = new SizeF(162.8299f, 23f);
      this.xrLabel12.StylePriority.UseFont = false;
      this.xrLabel12.StylePriority.UseTextAlignment = false;
      this.xrLabel12.Text = "Hạng mục(Item):";
      this.xrLabel12.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel13.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel13.LocationFloat = new PointFloat(442.9581f, (float) byte.MaxValue);
      this.xrLabel13.Multiline = true;
      this.xrLabel13.Name = "xrLabel13";
      this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel13.SizeF = new SizeF(162.8299f, 23f);
      this.xrLabel13.StylePriority.UseFont = false;
      this.xrLabel13.StylePriority.UseTextAlignment = false;
      this.xrLabel13.Text = "Biển số(License plate):";
      this.xrLabel13.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel14.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel14.LocationFloat = new PointFloat(442.9583f, 280f);
      this.xrLabel14.Multiline = true;
      this.xrLabel14.Name = "xrLabel14";
      this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel14.SizeF = new SizeF(162.8299f, 23.00003f);
      this.xrLabel14.StylePriority.UseFont = false;
      this.xrLabel14.StylePriority.UseTextAlignment = false;
      this.xrLabel14.Text = "Lái xe(Driver):";
      this.xrLabel14.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel15.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold);
      this.xrLabel15.LocationFloat = new PointFloat(510.6667f, 141.8788f);
      this.xrLabel15.Multiline = true;
      this.xrLabel15.Name = "xrLabel15";
      this.xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel15.SizeF = new SizeF(95.12155f, 23f);
      this.xrLabel15.StylePriority.UseFont = false;
      this.xrLabel15.StylePriority.UseTextAlignment = false;
      this.xrLabel15.Text = "MÃ PHIẾU:";
      this.xrLabel15.TextAlignment = TextAlignment.MiddleLeft;
      this.xrLabel16.AutoWidth = true;
      this.xrLabel16.CanShrink = true;
      this.xrLabel16.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLabel16.LocationFloat = new PointFloat(100f, 90f);
      this.xrLabel16.Name = "xrLabel16";
      this.xrLabel16.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel16.SizeF = new SizeF(150.0358f, 22.99999f);
      this.xrLabel16.StylePriority.UseFont = false;
      this.xrLabel16.StylePriority.UseTextAlignment = false;
      this.xrLabel16.Text = "(CUSTOMER)";
      this.xrLabel16.TextAlignment = TextAlignment.MiddleCenter;
      this.xrLabel17.AutoWidth = true;
      this.xrLabel17.CanShrink = true;
      this.xrLabel17.Font = new DXFont("Times New Roman", 11.25f, DXFontStyle.Bold, DXGraphicsUnit.Point, new DXFontAdditionalProperty[1]
      {
        new DXFontAdditionalProperty("GdiCharSet", (object) (byte) 0)
      });
      this.xrLabel17.LocationFloat = new PointFloat(500f, 90f);
      this.xrLabel17.Name = "xrLabel17";
      this.xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
      this.xrLabel17.SizeF = new SizeF(150.0358f, 23f);
      this.xrLabel17.StylePriority.UseFont = false;
      this.xrLabel17.StylePriority.UseTextAlignment = false;
      this.xrLabel17.Text = "(OPERATION)";
      this.xrLabel17.TextAlignment = TextAlignment.MiddleCenter;
      this.Bands.AddRange(new Band[3]
      {
        (Band) this.TopMargin,
        (Band) this.BottomMargin,
        (Band) this.Detail
      });
      this.Font = new DXFont("Arial", 9.75f);
      this.Margins = new DXMargins(58f, 58f, 313f, 100f);
      this.Version = "19.2";
      this.xrTable1.EndInit();
      this.EndInit();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportChiTietChuyenXe
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Reports
{
  public partial class ReportChiTietChuyenXe : ControlViewBase
  {
    

    public ReportChiTietChuyenXe()
    {
      this.InitializeComponent();
      this.Name = nameof(ReportChiTietChuyenXe);
      this.Caption = "Chi tiết chuyến xe";
      GridControl ownerGrid = new GridControl();
      GridView gridView = new GridView(ownerGrid);
      ownerGrid.MainView = (BaseView) gridView;
      gridView.Columns.Add(new GridColumn()
      {
        Caption = "Biển số",
        FieldName = "ID",
        Visible = true
      });
      gridView.Columns.Add(new GridColumn()
      {
        Caption = "Tài xế",
        FieldName = "Name",
        Visible = true
      });
      gridView.Columns.Add(new GridColumn()
      {
        Caption = "Tổng khối lương",
        FieldName = "Name",
        Visible = true
      });
      gridView.Columns.Add(new GridColumn()
      {
        Caption = "Số chuyến",
        FieldName = "Name",
        Visible = true
      });
      this.grcDuLieu.Controls.Add((Control) ownerGrid);
      ownerGrid.Dock = DockStyle.Fill;
    }

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string title = "BÁO CÁO CHI TIẾT CHUYẾN XE";
        string str1 = string.Format("Từ ngày: {0} - đến ngày: {1}", (object) FormatToString.DateTimeToString(this.datFromDate.DateTime), (object) FormatToString.DateTimeToString(this.datToDate.DateTime));
        string str2 = string.Format("Biển số: {0}", (object) this.lueBienXe.Text);
        List<string> lstHeader = new List<string>();
        lstHeader.Add(str1);
        if (this.lueBienXe.EditValue != null)
          lstHeader.Add(str2);
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.grcChiTietChuyenXe, true, true, title, lstHeader);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
    }

    
  }
}

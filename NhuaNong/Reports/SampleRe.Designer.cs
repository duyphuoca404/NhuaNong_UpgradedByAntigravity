using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace NhuaNong.Reports
{
  public partial class SampleRe
  {
    private IContainer components;
    private PanelControl panelControl2;
    private GroupControl groupControl2;
    private GridControl gridControl1;
    private GridView gridView1;
    private GridColumn gcNgayMeTron;
    private GridColumn gcMaterialName;
    private GridColumn gcCapPhoi;
    private GridColumn gcThucCan;
    private GroupControl groupControl1;
    private GroupBox groupBox2;
    private LookUpEdit lueCheDo;
    private SimpleButton btnReset;
    private SimpleButton btnTimKiem;
    private LookUpEdit lueMaterial;
    private LabelControl labelControl3;
    private LabelControl labelControl2;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl labelControl1;
    private LabelControl lblFromDate;
    private GroupBox groupBox1;
    private SimpleButton btnExportExcel;
    private PanelControl panelControl1;
    private LabelControl labelControl4;
    private GridColumn gcManual;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.panelControl2 = new PanelControl();
      this.groupControl2 = new GroupControl();
      this.gridControl1 = new GridControl();
      this.gridView1 = new GridView();
      this.gcMaterialName = new GridColumn();
      this.gcCapPhoi = new GridColumn();
      this.gcThucCan = new GridColumn();
      this.gcNgayMeTron = new GridColumn();
      this.gcManual = new GridColumn();
      this.groupControl1 = new GroupControl();
      this.groupBox2 = new GroupBox();
      this.lueCheDo = new LookUpEdit();
      this.btnReset = new SimpleButton();
      this.btnTimKiem = new SimpleButton();
      this.lueMaterial = new LookUpEdit();
      this.labelControl3 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.labelControl1 = new LabelControl();
      this.lblFromDate = new LabelControl();
      this.groupBox1 = new GroupBox();
      this.btnExportExcel = new SimpleButton();
      this.panelControl1 = new PanelControl();
      this.labelControl4 = new LabelControl();
      this.panelControl2.BeginInit();
      this.panelControl2.SuspendLayout();
      this.groupControl2.BeginInit();
      this.groupControl2.SuspendLayout();
      this.gridControl1.BeginInit();
      this.gridView1.BeginInit();
      this.groupControl1.BeginInit();
      this.groupControl1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.lueCheDo.Properties.BeginInit();
      this.lueMaterial.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.groupBox1.SuspendLayout();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.SuspendLayout();
      this.panelControl2.Controls.Add((Control) this.groupControl2);
      this.panelControl2.Controls.Add((Control) this.groupControl1);
      this.panelControl2.Dock = DockStyle.Fill;
      this.panelControl2.Location = new Point(0, 50);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(883, 537);
      this.panelControl2.TabIndex = 5;
      this.groupControl2.Controls.Add((Control) this.gridControl1);
      this.groupControl2.Dock = DockStyle.Fill;
      this.groupControl2.Location = new Point(2, 2);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(599, 533);
      this.groupControl2.TabIndex = 1;
      this.groupControl2.Text = "Dữ liệu";
      this.gridControl1.Dock = DockStyle.Fill;
      this.gridControl1.Location = new Point(2, 23);
      this.gridControl1.MainView = (BaseView) this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new Size(595, 508);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.gridView1
      });
      this.gridView1.Columns.AddRange(new GridColumn[5]
      {
        this.gcMaterialName,
        this.gcCapPhoi,
        this.gcThucCan,
        this.gcNgayMeTron,
        this.gcManual
      });
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsView.ShowFooter = true;
      this.gcMaterialName.Caption = "Biển  số";
      this.gcMaterialName.FieldName = "BienSo";
      this.gcMaterialName.Name = "gcMaterialName";
      this.gcMaterialName.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Count, "BienSo", "{0}")
      });
      this.gcMaterialName.Visible = true;
      this.gcMaterialName.VisibleIndex = 0;
      this.gcCapPhoi.Caption = "Số chuyến";
      this.gcCapPhoi.FieldName = "Total_Tranfer";
      this.gcCapPhoi.Name = "gcCapPhoi";
      this.gcCapPhoi.Visible = true;
      this.gcCapPhoi.VisibleIndex = 1;
      this.gcThucCan.Caption = "Tổng KL";
      this.gcThucCan.FieldName = "Total_KL";
      this.gcThucCan.Name = "gcThucCan";
      this.gcThucCan.Visible = true;
      this.gcThucCan.VisibleIndex = 2;
      this.gcNgayMeTron.Caption = "Ngày trộn";
      this.gcNgayMeTron.DisplayFormat.FormatString = "d";
      this.gcNgayMeTron.DisplayFormat.FormatType = FormatType.DateTime;
      this.gcNgayMeTron.FieldName = "NgayMeTron";
      this.gcNgayMeTron.Name = "gcNgayMeTron";
      this.gcNgayMeTron.Visible = true;
      this.gcNgayMeTron.VisibleIndex = 3;
      this.gcManual.Caption = "Manual";
      this.gcManual.FieldName = "IsQueued";
      this.gcManual.Name = "gcManual";
      this.gcManual.Visible = true;
      this.gcManual.VisibleIndex = 4;
      this.groupControl1.Controls.Add((Control) this.groupBox2);
      this.groupControl1.Controls.Add((Control) this.groupBox1);
      this.groupControl1.Dock = DockStyle.Right;
      this.groupControl1.Location = new Point(601, 2);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(280, 533);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "Tác vụ";
      this.groupBox2.Controls.Add((Control) this.lueCheDo);
      this.groupBox2.Controls.Add((Control) this.btnReset);
      this.groupBox2.Controls.Add((Control) this.btnTimKiem);
      this.groupBox2.Controls.Add((Control) this.lueMaterial);
      this.groupBox2.Controls.Add((Control) this.labelControl3);
      this.groupBox2.Controls.Add((Control) this.labelControl2);
      this.groupBox2.Controls.Add((Control) this.datToDate);
      this.groupBox2.Controls.Add((Control) this.datFromDate);
      this.groupBox2.Controls.Add((Control) this.labelControl1);
      this.groupBox2.Controls.Add((Control) this.lblFromDate);
      this.groupBox2.Dock = DockStyle.Fill;
      this.groupBox2.Location = new Point(2, 23);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(276, 362);
      this.groupBox2.TabIndex = 75;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Bộ lọc";
      this.lueCheDo.Location = new Point(105, 130);
      this.lueCheDo.Name = "lueCheDo";
      this.lueCheDo.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueCheDo.Properties.Appearance.Options.UseFont = true;
      this.lueCheDo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueCheDo.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("ID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("DisplayText", "Chế độ")
      });
      this.lueCheDo.Properties.DisplayMember = "DisplayText";
      this.lueCheDo.Properties.NullText = "";
      this.lueCheDo.Properties.ValueMember = "ID";
      this.lueCheDo.Size = new Size(150, 22);
      this.lueCheDo.TabIndex = 72;
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(147, 185);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(108, 32);
      this.btnReset.TabIndex = 9;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.btnTimKiem.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnTimKiem.Appearance.Options.UseFont = true;
      this.btnTimKiem.Location = new Point(14, 185);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new Size(108, 32);
      this.btnTimKiem.TabIndex = 8;
      this.btnTimKiem.Text = "Tìm";
      this.btnTimKiem.Click += new EventHandler(this.btnTimKiem_Click);
      this.lueMaterial.Location = new Point(105, 95);
      this.lueMaterial.Name = "lueMaterial";
      this.lueMaterial.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueMaterial.Properties.Appearance.Options.UseFont = true;
      this.lueMaterial.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueMaterial.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("MaterialID", "MaterialID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaterialCode", "Mã Vật tư"),
        new LookUpColumnInfo("MaterialName", "Tên Vật tư")
      });
      this.lueMaterial.Properties.DisplayMember = "MaterialName";
      this.lueMaterial.Properties.NullText = "";
      this.lueMaterial.Properties.ValueMember = "MaterialID";
      this.lueMaterial.Size = new Size(150, 22);
      this.lueMaterial.TabIndex = 6;
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(41, 133);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(40, 16);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = "Chế độ";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(22, 98);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(61, 16);
      this.labelControl2.TabIndex = 4;
      this.labelControl2.Text = "Tên Vật tư";
      this.datToDate.EditValue = (object) null;
      this.datToDate.Location = new Point(105, 56);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datToDate.Properties.Appearance.Options.UseFont = true;
      this.datToDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Size = new Size(150, 22);
      this.datToDate.TabIndex = 3;
      this.datFromDate.EditValue = (object) null;
      this.datFromDate.Location = new Point(105, 18);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datFromDate.Properties.Appearance.Options.UseFont = true;
      this.datFromDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Size = new Size(150, 22);
      this.datFromDate.TabIndex = 2;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(27, 59);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Đến ngày";
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(12, 21);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(69, 16);
      this.lblFromDate.TabIndex = 0;
      this.lblFromDate.Text = "Tạo từ ngày";
      this.groupBox1.Controls.Add((Control) this.btnExportExcel);
      this.groupBox1.Dock = DockStyle.Bottom;
      this.groupBox1.Location = new Point(2, 385);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(276, 146);
      this.groupBox1.TabIndex = 74;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Xuất dữ liệu";
      this.btnExportExcel.AllowFocus = false;
      this.btnExportExcel.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.btnExportExcel.ImageOptions.Image = (Image) ResourceNhua.eexport_Excel;
      this.btnExportExcel.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.btnExportExcel.Location = new Point(80, 60);
      this.btnExportExcel.Name = "btnExportExcel";
      this.btnExportExcel.Size = new Size(102, 43);
      this.btnExportExcel.TabIndex = 74;
      this.btnExportExcel.Click += new EventHandler(this.btnExportExcel_Click);
      this.panelControl1.Controls.Add((Control) this.labelControl4);
      this.panelControl1.Dock = DockStyle.Top;
      this.panelControl1.Location = new Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(883, 50);
      this.panelControl1.TabIndex = 4;
      this.labelControl4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.labelControl4.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl4.Location = new Point(10, 2);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(903, 50);
      this.labelControl4.TabIndex = 0;
      this.labelControl4.Text = "BÁO CÁO TỔNG VẬT TƯ";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.panelControl2);
      this.Controls.Add((Control) this.panelControl1);
      this.Name = "SampleRe";
      this.Size = new Size(883, 587);
      this.panelControl2.EndInit();
      this.panelControl2.ResumeLayout(false);
      this.groupControl2.EndInit();
      this.groupControl2.ResumeLayout(false);
      this.gridControl1.EndInit();
      this.gridView1.EndInit();
      this.groupControl1.EndInit();
      this.groupControl1.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.lueCheDo.Properties.EndInit();
      this.lueMaterial.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

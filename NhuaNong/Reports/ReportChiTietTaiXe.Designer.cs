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
using NhuaNong.KWS;
using NhuaNong.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.Reports
{
  public partial class ReportChiTietTaiXe
  {
    private IContainer components;
    private PanelControl panelControl2;
    private GroupControl groupControl2;
    private GridControl grcChiTietTaiXe;
    private GridView grvChiTietTaiXe;
    private GridColumn gcMaTaiXe;
    private GridColumn gcTenTaiXe;
    private GridColumn gcTotal_Tranfer;
    private GridColumn gcTotal_KL;
    private GroupControl groupControl1;
    private GroupBox groupBox2;
    private LookUpEdit lueCheDo;
    private SimpleButton btnReset;
    private SimpleButton btnTimKiem;
    private LookUpEdit lueTaiXe;
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

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      GridGroupSummaryItem groupSummaryItem1 = new GridGroupSummaryItem();
      GridGroupSummaryItem groupSummaryItem2 = new GridGroupSummaryItem();
      this.gcTotal_Tranfer = new GridColumn();
      this.gcTotal_KL = new GridColumn();
      this.panelControl2 = new PanelControl();
      this.groupControl2 = new GroupControl();
      this.grcChiTietTaiXe = new GridControl();
      this.grvChiTietTaiXe = new GridView();
      this.gcMaTaiXe = new GridColumn();
      this.gcTenTaiXe = new GridColumn();
      this.groupControl1 = new GroupControl();
      this.groupBox2 = new GroupBox();
      this.lueCheDo = new LookUpEdit();
      this.btnReset = new SimpleButton();
      this.btnTimKiem = new SimpleButton();
      this.lueTaiXe = new LookUpEdit();
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
      this.groupControl2.BeginInit();
      this.grcChiTietTaiXe.BeginInit();
      this.grvChiTietTaiXe.BeginInit();
      this.groupControl1.BeginInit();
      this.groupBox2.SuspendLayout();
      this.lueCheDo.Properties.BeginInit();
      this.lueTaiXe.Properties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.groupBox1.SuspendLayout();
      this.panelControl1.BeginInit();
      this.SuspendLayout();
      this.gcTotal_Tranfer.Caption = "Tổng số chuyến";
      this.gcTotal_Tranfer.FieldName = "Total_Tranfer";
      this.gcTotal_Tranfer.GroupFormat.FormatString = "n2";
      this.gcTotal_Tranfer.GroupFormat.FormatType = FormatType.Numeric;
      this.gcTotal_Tranfer.Name = "gcTotal_Tranfer";
      this.gcTotal_Tranfer.OptionsColumn.AllowFocus = false;
      this.gcTotal_Tranfer.OptionsColumn.ReadOnly = true;
      this.gcTotal_Tranfer.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Total_Tranfer", "{0:0.##}")
      });
      this.gcTotal_Tranfer.Visible = true;
      this.gcTotal_Tranfer.VisibleIndex = 2;
      this.gcTotal_KL.Caption = "Tổng khối lượng";
      this.gcTotal_KL.FieldName = "Total_KL";
      this.gcTotal_KL.GroupFormat.FormatString = "n2";
      this.gcTotal_KL.GroupFormat.FormatType = FormatType.Numeric;
      this.gcTotal_KL.Name = "gcTotal_KL";
      this.gcTotal_KL.OptionsColumn.AllowFocus = false;
      this.gcTotal_KL.OptionsColumn.ReadOnly = true;
      this.gcTotal_KL.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Total_KL", "{0:0.##}")
      });
      this.gcTotal_KL.Visible = true;
      this.gcTotal_KL.VisibleIndex = 3;
      this.panelControl2.Controls.Add((Control)this.groupControl2);
      this.panelControl2.Controls.Add((Control)this.groupControl1);
      this.panelControl2.Dock = DockStyle.Fill;
      this.panelControl2.Location = new Point(0, 50);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(913, 466);
      this.panelControl2.TabIndex = 5;
      this.groupControl2.Controls.Add((Control)this.grcChiTietTaiXe);
      this.groupControl2.Dock = DockStyle.Fill;
      this.groupControl2.Location = new Point(2, 2);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(629, 462);
      this.groupControl2.TabIndex = 1;
      this.groupControl2.Text = "Dữ liệu";
      this.grcChiTietTaiXe.Dock = DockStyle.Fill;
      this.grcChiTietTaiXe.Location = new Point(2, 23);
      this.grcChiTietTaiXe.MainView = (BaseView)this.grvChiTietTaiXe;
      this.grcChiTietTaiXe.Name = "grcChiTietTaiXe";
      this.grcChiTietTaiXe.Size = new Size(625, 437);
      this.grcChiTietTaiXe.TabIndex = 0;
      this.grcChiTietTaiXe.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvChiTietTaiXe
      });
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.BackColor = Color.DodgerBlue;
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.ForeColor = Color.White;
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.Options.UseFont = true;
      this.grvChiTietTaiXe.AppearancePrint.HeaderPanel.Options.UseForeColor = true;
      this.grvChiTietTaiXe.Columns.AddRange(new GridColumn[3]
      {
        this.gcTenTaiXe,
        this.gcTotal_Tranfer,
        this.gcTotal_KL
      });
      this.grvChiTietTaiXe.GridControl = this.grcChiTietTaiXe;
      groupSummaryItem1.DisplayFormat = "Tổng CP:{0:0.##}";
      groupSummaryItem1.FieldName = "Sum_ValueCP";
      groupSummaryItem1.ShowInGroupColumnFooter = this.gcTotal_Tranfer;
      groupSummaryItem1.SummaryType = SummaryItemType.Sum;
      groupSummaryItem1.Tag = (object)"Sum_ValueCP";
      groupSummaryItem2.DisplayFormat = "Tổng Thực cân:{0:0.##}";
      groupSummaryItem2.FieldName = "Sum_ValueBat";
      groupSummaryItem2.ShowInGroupColumnFooter = this.gcTotal_KL;
      groupSummaryItem2.SummaryType = SummaryItemType.Sum;
      groupSummaryItem2.Tag = (object)"Sum_ValueBat";
      this.grvChiTietTaiXe.GroupSummary.AddRange(new GridSummaryItem[2]
      {
        (GridSummaryItem) groupSummaryItem1,
        (GridSummaryItem) groupSummaryItem2
      });
      this.grvChiTietTaiXe.Name = "grvChiTietTaiXe";
      this.grvChiTietTaiXe.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
      this.grvChiTietTaiXe.OptionsBehavior.AutoExpandAllGroups = true;
      this.grvChiTietTaiXe.OptionsMenu.ShowGroupSummaryEditorItem = true;
      this.grvChiTietTaiXe.OptionsView.ShowFooter = true;
      this.grvChiTietTaiXe.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gcTenTaiXe, ColumnSortOrder.Ascending)
      });
      this.gcMaTaiXe.Caption = "Mã Tài xế";
      this.gcMaTaiXe.FieldName = "MaTaiXe";
      this.gcMaTaiXe.Name = "gcMaTaiXe";
      this.gcMaTaiXe.OptionsColumn.AllowFocus = false;
      this.gcMaTaiXe.OptionsColumn.ReadOnly = true;
      this.gcMaTaiXe.Visible = true;
      this.gcMaTaiXe.VisibleIndex = 0;
      this.gcTenTaiXe.Caption = "Tên Tài xế";
      this.gcTenTaiXe.FieldName = "TenTaiXe";
      this.gcTenTaiXe.Name = "gcTenTaiXe";
      this.gcTenTaiXe.OptionsColumn.AllowFocus = false;
      this.gcTenTaiXe.OptionsColumn.ReadOnly = true;
      this.gcTenTaiXe.Visible = true;
      this.gcTenTaiXe.VisibleIndex = 1;
      this.groupControl1.Controls.Add((Control)this.groupBox2);
      this.groupControl1.Controls.Add((Control)this.groupBox1);
      this.groupControl1.Dock = DockStyle.Right;
      this.groupControl1.Location = new Point(631, 2);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(280, 462);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "Tác vụ";
      this.groupBox2.Controls.Add((Control)this.lueCheDo);
      this.groupBox2.Controls.Add((Control)this.btnReset);
      this.groupBox2.Controls.Add((Control)this.btnTimKiem);
      this.groupBox2.Controls.Add((Control)this.lueTaiXe);
      this.groupBox2.Controls.Add((Control)this.labelControl3);
      this.groupBox2.Controls.Add((Control)this.labelControl2);
      this.groupBox2.Controls.Add((Control)this.datToDate);
      this.groupBox2.Controls.Add((Control)this.datFromDate);
      this.groupBox2.Controls.Add((Control)this.labelControl1);
      this.groupBox2.Controls.Add((Control)this.lblFromDate);
      this.groupBox2.Dock = DockStyle.Fill;
      this.groupBox2.Location = new Point(2, 23);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(276, 291);
      this.groupBox2.TabIndex = 75;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Bộ lọc";
      this.lueCheDo.Location = new Point(112, 120);
      this.lueCheDo.Name = "lueCheDo";
      this.lueCheDo.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
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
      this.btnReset.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnReset.Appearance.Options.UseFont = true;
      this.btnReset.Location = new Point(22, 173);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(108, 32);
      this.btnReset.TabIndex = 9;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.btnTimKiem.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnTimKiem.Appearance.Options.UseFont = true;
      this.btnTimKiem.Location = new Point(154, 173);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new Size(108, 32);
      this.btnTimKiem.TabIndex = 8;
      this.btnTimKiem.Text = "Tìm";
      this.btnTimKiem.Click += new EventHandler(this.btnTimKiem_Click);
      this.lueTaiXe.Location = new Point(112, 90);
      this.lueTaiXe.Name = "lueTaiXe";
      this.lueTaiXe.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueTaiXe.Properties.Appearance.Options.UseFont = true;
      this.lueTaiXe.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueTaiXe.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("TaiXeID", "TaiXeID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("TenTaiXe", "Tên Tài xế")
      });
      this.lueTaiXe.Properties.DisplayMember = "TenTaiXe";
      this.lueTaiXe.Properties.NullText = "";
      this.lueTaiXe.Properties.ValueMember = "TaiXeID";
      this.lueTaiXe.Size = new Size(150, 22);
      this.lueTaiXe.TabIndex = 6;
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(22, 123);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(40, 16);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = "Chế độ";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(22, 93);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(61, 16);
      this.labelControl2.TabIndex = 4;
      this.labelControl2.Text = "Tên Tài xế";
      this.datToDate.EditValue = (object)new DateTime(2024, 5, 20, 0, 0, 0, 0);
      this.datToDate.Location = new Point(112, 60);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datToDate.Properties.Appearance.Options.UseFont = true;
      this.datToDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datToDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datToDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datToDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datToDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datToDate.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datToDate.Size = new Size(150, 22);
      this.datToDate.TabIndex = 3;
      this.datFromDate.EditValue = (object)new DateTime(2024, 5, 20, 0, 0, 0, 0);
      this.datFromDate.Location = new Point(112, 30);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datFromDate.Properties.Appearance.Options.UseFont = true;
      this.datFromDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datFromDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datFromDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datFromDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datFromDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datFromDate.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datFromDate.Size = new Size(150, 22);
      this.datFromDate.TabIndex = 2;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(22, 63);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Đến ngày";
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(22, 33);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(69, 16);
      this.lblFromDate.TabIndex = 0;
      this.lblFromDate.Text = "Tạo từ ngày";
      this.groupBox1.Controls.Add((Control)this.btnExportExcel);
      this.groupBox1.Dock = DockStyle.Bottom;
      this.groupBox1.Location = new Point(2, 314);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(276, 146);
      this.groupBox1.TabIndex = 74;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Xuất dữ liệu";
      this.btnExportExcel.AllowFocus = false;
      this.btnExportExcel.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.btnExportExcel.Appearance.Options.UseFont = true;
      this.btnExportExcel.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.btnExportExcel.ImageOptions.Image = (Image)ResourceNhua.eexport_Excel;
      this.btnExportExcel.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
      this.btnExportExcel.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.btnExportExcel.Location = new Point(80, 60);
      this.btnExportExcel.Name = "btnExportExcel";
      this.btnExportExcel.Size = new Size(120, 45);
      this.btnExportExcel.TabIndex = 74;
      this.btnExportExcel.Text = "Xuất Excel";
      this.btnExportExcel.Click += new EventHandler(this.btnExportExcel_Click);
      this.panelControl1.Controls.Add((Control)this.labelControl4);
      this.panelControl1.Dock = DockStyle.Top;
      this.panelControl1.Location = new Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(913, 50);
      this.panelControl1.TabIndex = 4;
      this.labelControl4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.labelControl4.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl4.Location = new Point(10, 2);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(903, 0);
      this.labelControl4.TabIndex = 0;
      this.labelControl4.Text = "BÁO CÁO CHI TIẾT TÀI XẾ";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.panelControl2);
      this.Controls.Add((Control)this.panelControl1);
      this.Name = "ReportChiTietTaiXe";
      this.Size = new Size(913, 516);
      this.panelControl2.EndInit();
      this.groupControl2.EndInit();
      this.grcChiTietTaiXe.EndInit();
      this.grvChiTietTaiXe.EndInit();
      this.groupControl1.EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.lueCheDo.Properties.EndInit();
      this.lueTaiXe.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.panelControl1.EndInit();
      this.ResumeLayout(false);
    }
  }
}

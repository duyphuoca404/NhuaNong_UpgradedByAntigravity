using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.Reports
{
  public partial class ReportChiTietChuyenXe
  {
    private IContainer components;
    private GroupControl groupControl1;
    private GroupControl grcDuLieu;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl labelControl1;
    private LabelControl lblFromDate;
    private LookUpEdit lueBienXe;
    private LabelControl labelControl3;
    private LabelControl labelControl2;
    private SimpleButton btnTimKiem;
    private LookUpEdit lueCheDo;
    private SimpleButton simpleButton1;
    private GridControl grcChiTietChuyenXe;
    private GridView grvChiTietChuyenXe;
    private GridColumn gcBienSo;
    private GridColumn gcTaiXe;
    private GridColumn gcTongKhoiLuong;
    private GridColumn gcSoChuyen;
    private BarManager barManager1;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarStaticItem barStaticItem1;
    private PanelControl panelControl1;
    private LabelControl labelControl4;
    private BarHeaderItem barHeaderItem1;
    private GroupBox groupBox2;
    private GroupBox groupBox1;
    private SimpleButton btnExportExcel;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer)new System.ComponentModel.Container();
      this.grcDuLieu = new GroupControl();
      this.grcChiTietChuyenXe = new GridControl();
      this.grvChiTietChuyenXe = new GridView();
      this.gcBienSo = new GridColumn();
      this.gcTaiXe = new GridColumn();
      this.gcTongKhoiLuong = new GridColumn();
      this.gcSoChuyen = new GridColumn();
      this.groupControl1 = new GroupControl();
      this.groupBox2 = new GroupBox();
      this.simpleButton1 = new SimpleButton();
      this.btnTimKiem = new SimpleButton();
      this.lueCheDo = new LookUpEdit();
      this.lueBienXe = new LookUpEdit();
      this.labelControl3 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.datToDate = new DateEdit();
      this.datFromDate = new DateEdit();
      this.labelControl1 = new LabelControl();
      this.lblFromDate = new LabelControl();
      this.groupBox1 = new GroupBox();
      this.btnExportExcel = new SimpleButton();
      this.barManager1 = new BarManager(this.components);
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.barStaticItem1 = new BarStaticItem();
      this.barHeaderItem1 = new BarHeaderItem();
      this.labelControl4 = new LabelControl();
      this.panelControl1 = new PanelControl();
      this.grcDuLieu.BeginInit();
      this.grcChiTietChuyenXe.BeginInit();
      this.grvChiTietChuyenXe.BeginInit();
      this.groupControl1.BeginInit();
      this.groupBox2.SuspendLayout();
      this.lueCheDo.Properties.BeginInit();
      this.lueBienXe.Properties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.groupBox1.SuspendLayout();
      this.barManager1.BeginInit();
      this.panelControl1.BeginInit();
      this.SuspendLayout();
      this.grcDuLieu.Controls.Add((Control)this.grcChiTietChuyenXe);
      this.grcDuLieu.Dock = DockStyle.Fill;
      this.grcDuLieu.Location = new Point(2, 2);
      this.grcDuLieu.Name = "grcDuLieu";
      this.grcDuLieu.Size = new Size(629, 462);
      this.grcDuLieu.TabIndex = 1;
      this.grcDuLieu.Text = "Dữ liệu";
      this.grcChiTietChuyenXe.Dock = DockStyle.Fill;
      this.grcChiTietChuyenXe.Location = new Point(2, 23);
      this.grcChiTietChuyenXe.MainView = (BaseView)this.grvChiTietChuyenXe;
      this.grcChiTietChuyenXe.Name = "grcChiTietChuyenXe";
      this.grcChiTietChuyenXe.Size = new Size(625, 437);
      this.grcChiTietChuyenXe.TabIndex = 0;
      this.grcChiTietChuyenXe.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvChiTietChuyenXe
      });
      this.grcChiTietChuyenXe.Visible = false;
      this.grvChiTietChuyenXe.AppearancePrint.HeaderPanel.BackColor = Color.DodgerBlue;
      this.grvChiTietChuyenXe.AppearancePrint.HeaderPanel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.grvChiTietChuyenXe.AppearancePrint.HeaderPanel.ForeColor = Color.White;
      this.grvChiTietChuyenXe.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.grvChiTietChuyenXe.AppearancePrint.HeaderPanel.Options.UseFont = true;
      this.grvChiTietChuyenXe.AppearancePrint.HeaderPanel.Options.UseForeColor = true;
      this.grvChiTietChuyenXe.Columns.AddRange(new GridColumn[4]
      {
        this.gcBienSo,
        this.gcTaiXe,
        this.gcTongKhoiLuong,
        this.gcSoChuyen
      });
      this.grvChiTietChuyenXe.GridControl = this.grcChiTietChuyenXe;
      this.grvChiTietChuyenXe.Name = "grvChiTietChuyenXe";
      this.grvChiTietChuyenXe.OptionsView.ShowFooter = true;
      this.gcBienSo.Caption = "Biển số";
      this.gcBienSo.Name = "gcBienSo";
      this.gcBienSo.Visible = true;
      this.gcBienSo.VisibleIndex = 0;
      this.gcTaiXe.Caption = "Tài xế";
      this.gcTaiXe.Name = "gcTaiXe";
      this.gcTaiXe.Visible = true;
      this.gcTaiXe.VisibleIndex = 1;
      this.gcTongKhoiLuong.Caption = "Tổng khối lượng";
      this.gcTongKhoiLuong.Name = "gcTongKhoiLuong";
      this.gcTongKhoiLuong.Visible = true;
      this.gcTongKhoiLuong.VisibleIndex = 2;
      this.gcSoChuyen.Caption = "Số chuyến";
      this.gcSoChuyen.Name = "gcSoChuyen";
      this.gcSoChuyen.Visible = true;
      this.gcSoChuyen.VisibleIndex = 3;
      this.groupControl1.Controls.Add((Control)this.groupBox2);
      this.groupControl1.Controls.Add((Control)this.groupBox1);
      this.groupControl1.Dock = DockStyle.Right;
      this.groupControl1.Location = new Point(631, 2);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(280, 462);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "Tác vụ";
      this.groupBox2.Controls.Add((Control)this.simpleButton1);
      this.groupBox2.Controls.Add((Control)this.btnTimKiem);
      this.groupBox2.Controls.Add((Control)this.lueCheDo);
      this.groupBox2.Controls.Add((Control)this.lueBienXe);
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
      this.groupBox2.TabIndex = 76;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Bộ lọc";
      this.simpleButton1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.Location = new Point(18, 170);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(108, 32);
      this.simpleButton1.TabIndex = 9;
      this.simpleButton1.Text = "Làm mới";
      this.btnTimKiem.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnTimKiem.Appearance.Options.UseFont = true;
      this.btnTimKiem.Location = new Point(154, 170);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new Size(108, 32);
      this.btnTimKiem.TabIndex = 8;
      this.btnTimKiem.Text = "Tìm";
      this.btnTimKiem.Click += new EventHandler(this.btnTimKiem_Click);
      this.lueCheDo.Location = new Point(112, 120);
      this.lueCheDo.Name = "lueCheDo";
      this.lueCheDo.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueCheDo.Properties.Appearance.Options.UseFont = true;
      this.lueCheDo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueCheDo.Properties.NullText = "";
      this.lueCheDo.Size = new Size(150, 22);
      this.lueCheDo.TabIndex = 7;
      this.lueBienXe.Location = new Point(112, 90);
      this.lueBienXe.Name = "lueBienXe";
      this.lueBienXe.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lueBienXe.Properties.Appearance.Options.UseFont = true;
      this.lueBienXe.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueBienXe.Properties.NullText = "";
      this.lueBienXe.Size = new Size(150, 22);
      this.lueBienXe.TabIndex = 6;
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(47, 136);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(40, 16);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = "Chế độ";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(46, 101);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(41, 16);
      this.labelControl2.TabIndex = 4;
      this.labelControl2.Text = "Biển xe";
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
      this.labelControl1.Location = new Point(33, 66);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Đến ngày";
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(18, 32);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(69, 16);
      this.lblFromDate.TabIndex = 0;
      this.lblFromDate.Text = "Tạo từ ngày";
      this.groupBox1.Controls.Add((Control)this.btnExportExcel);
      this.groupBox1.Dock = DockStyle.Bottom;
      this.groupBox1.Location = new Point(2, 314);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(276, 146);
      this.groupBox1.TabIndex = 75;
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
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control)this;
      this.barManager1.Items.AddRange(new BarItem[2]
      {
        (BarItem) this.barStaticItem1,
        (BarItem) this.barHeaderItem1
      });
      this.barManager1.MaxItemId = 2;
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new Size(913, 0);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 516);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new Size(913, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 0);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new Size(0, 516);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(913, 0);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new Size(0, 516);
      this.barStaticItem1.Caption = "Báo cáo chi tiết chuyến chuyến xe";
      this.barStaticItem1.Id = 0;
      this.barStaticItem1.ItemAppearance.Normal.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.barStaticItem1.ItemAppearance.Normal.Options.UseFont = true;
      this.barStaticItem1.Name = "barStaticItem1";
      this.barHeaderItem1.Caption = "BÁO CÁO CHI TIẾT CHUYẾN XE";
      this.barHeaderItem1.Id = 1;
      this.barHeaderItem1.Name = "barHeaderItem1";
      this.labelControl4.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl4.Dock = DockStyle.Top;
      this.labelControl4.Location = new Point(0, 0);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(913, 50);
      this.labelControl4.TabIndex = 6;
      this.labelControl4.Text = " BÁO CÁO CHI TIẾT CHUYẾN XE";
      this.panelControl1.Controls.Add((Control)this.grcDuLieu);
      this.panelControl1.Controls.Add((Control)this.groupControl1);
      this.panelControl1.Dock = DockStyle.Fill;
      this.panelControl1.Location = new Point(0, 50);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(913, 466);
      this.panelControl1.TabIndex = 7;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.panelControl1);
      this.Controls.Add((Control)this.labelControl4);
      this.Controls.Add((Control)this.barDockControlLeft);
      this.Controls.Add((Control)this.barDockControlRight);
      this.Controls.Add((Control)this.barDockControlBottom);
      this.Controls.Add((Control)this.barDockControlTop);
      this.Name = "ReportChiTietChuyenXe";
      this.Size = new Size(913, 516);
      this.grcDuLieu.EndInit();
      this.grcChiTietChuyenXe.EndInit();
      this.grvChiTietChuyenXe.EndInit();
      this.groupControl1.EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.lueCheDo.Properties.EndInit();
      this.lueBienXe.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.barManager1.EndInit();
      this.panelControl1.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

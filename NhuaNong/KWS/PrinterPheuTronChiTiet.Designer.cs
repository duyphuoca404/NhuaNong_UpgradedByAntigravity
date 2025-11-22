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
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using Microsoft.Office.Interop.Word;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.MasterData;
using NhuaNong.Utils;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace NhuaNong.KWS
{
  public partial class PrinterPheuTronChiTiet
  {
    private IContainer components;
    private GroupControl groupControl1;
    private SimpleButton btnLamMoi;
    private SimpleButton btnTimKiem;
    private LookUpEdit lookupEditPrinters;
    private DateEdit datDenNgay;
    private DateEdit datTuNgay;
    private LabelControl labelControl4;
    private LabelControl labelControl3;
    private GroupControl groupControl2;
    private GridControl grcPhieuTron;
    private GridView grvPhieuTron;
    private GridColumn gcMaPhieuTron;
    private GridColumn gcNgayPhieuTron;
    private GridColumn gcViewMaHopDong;
    private GridColumn gridColumn3;
    private GroupControl groupControl4;
    private TextEdit txtSoPhieu;
    private LabelControl labelControl20;
    private DateEdit datNgayTron;
    private TextEdit txtGioTron;
    private LabelControl labelControl11;
    private TextEdit txtXe;
    private TextEdit txtTaiXe;
    private LabelControl labelControl18;
    private LabelControl labelControl19;
    private TextEdit txtHangMuc;
    private LabelControl labelControl17;
    private TextEdit txtDiaDiem;
    private LabelControl labelControl16;
    private TextEdit txtLuyKe;
    private LabelControl labelControl15;
    private TextEdit txtKhoiLuongDatHang;
    private LabelControl labelControl7;
    private TextEdit txtTheTich;
    private LabelControl labelControl14;
    private TextEdit txtDoSut;
    private LabelControl labelControl13;
    private LabelControl labelControl12;
    private TextEdit txtTenMAC;
    private LabelControl lblTenMAC;
    private TextEdit txtNguoiTron;
    private TextEdit txtNiemChi;
    private TextEdit txtCuongDo;
    private TextEdit txtTenCongTruong;
    private TextEdit txtTenKhachHang;
    private TextEdit txtMaPhieuTron;
    private LabelControl labelControl9;
    private LabelControl labelControl8;
    private LabelControl labelControl6;
    private LabelControl labelControl5;
    private LabelControl labelControl2;
    private LabelControl labelControl1;
    private GroupControl grChiTietMeTron;
    private GridControl grcPhieuTronChiTiet;
    private AdvBandedGridView bandedGridView1;
    private BandedGridColumn gcNL;
    private BandedGridColumn gcTheTich;
    private BandedGridColumn gcPV_Agg_1;
    private BandedGridColumn gcPV_Agg1_Manual;
    private BandedGridColumn gcPV_Agg_2;
    private BandedGridColumn gcPV_Agg2_Manual;
    private BandedGridColumn gcPV_Agg_3;
    private BandedGridColumn gcPV_Agg3_Manual;
    private BandedGridColumn gcPV_Agg_4;
    private BandedGridColumn gcPV_Agg4_Manual;
    private BandedGridColumn gcPV_Agg_5;
    private BandedGridColumn gcPV_Agg5_Manual;
    private BandedGridColumn gcPV_Agg_6;
    private BandedGridColumn gcPV_Agg6_Manual;
    private BandedGridColumn gcPV_Ce_1;
    private BandedGridColumn gcPV_Ce_2;
    private BandedGridColumn gcPV_Ce_3;
    private BandedGridColumn gcPV_Ce_4;
    private BandedGridColumn gcPV_Ce_5;
    private BandedGridColumn gcPV_Ce1_Manual;
    private BandedGridColumn gcPV_Ce2_Manual;
    private BandedGridColumn gcPV_Ce3_Manual;
    private BandedGridColumn gcPV_Ce4_Manual;
    private BandedGridColumn gcPV_Ce5_Manual;
    private BandedGridColumn gcPV_Wa_1;
    private BandedGridColumn gcPV_Wa_2;
    private BandedGridColumn gcPV_Wa1_Manual;
    private BandedGridColumn gcPV_Wa2_Manual;
    private BandedGridColumn gcPV_ADD_1;
    private BandedGridColumn gcPV_ADD_2;
    private BandedGridColumn gcPV_ADD_3;
    private BandedGridColumn gcPV_Add1_Manual;
    private BandedGridColumn gcPV_Add2_Manual;
    private BandedGridColumn gcPV_Add3_Manual;
    private BandedGridColumn gcPV_ADD_4;
    private BandedGridColumn gcPV_Add4_Manual;
    private BandedGridColumn gcPV_ADD_5;
    private BandedGridColumn gcPV_Add5_Manual;
    private BandedGridColumn gcPV_ADD_6;
    private BandedGridColumn gcPV_Add6_Manual;
    private GridBand gridBand1;
    private GridBand gridBand2;
    private GridBand Agg1;
    private GridBand gridBand9;
    private GridBand gridBand10;
    private GridBand Agg2;
    private GridBand gridBand11;
    private GridBand gridBand13;
    private GridBand Agg3;
    private GridBand gridBand12;
    private GridBand gridBand15;
    private GridBand Agg4;
    private GridBand gridBand14;
    private GridBand gridBand16;
    private GridBand Agg5;
    private GridBand gridBand17;
    private GridBand gridBand18;
    private GridBand Agg6;
    private GridBand gridBand19;
    private GridBand gridBand20;
    private GridBand Ce1;
    private GridBand gridBand23;
    private GridBand gridBand22;
    private GridBand Ce2;
    private GridBand gridBand25;
    private GridBand gridBand26;
    private GridBand Ce3;
    private GridBand gridBand28;
    private GridBand gridBand30;
    private GridBand Ce4;
    private GridBand gridBand31;
    private GridBand gridBand32;
    private GridBand Ce5;
    private GridBand gridBand34;
    private GridBand gridBand35;
    private GridBand Wa1;
    private GridBand gridBand37;
    private GridBand gridBand38;
    private GridBand Wa2;
    private GridBand gridBand40;
    private GridBand gridBand41;
    private GridBand Add1;
    private GridBand gridBand43;
    private GridBand gridBand44;
    private GridBand Add2;
    private GridBand gridBand46;
    private GridBand gridBand47;
    private GridBand Add3;
    private GridBand gridBand49;
    private GridBand gridBand50;
    private GridBand Add4;
    private GridBand gridBand52;
    private GridBand gridBand53;
    private GridBand Add5;
    private GridBand gridBand55;
    private GridBand gridBand56;
    private GridBand Add6;
    private GridBand gridBand58;
    private GridBand gridBand59;
    private GroupControl groupControl3;
    private GroupControl groupControl5;
    private SimpleButton btnPrint;
    private GridControl grcTotalMaterial;
    private BandedGridView bandedGridView2;
    private BandedGridColumn gcTotal_Agg1;
    private BandedGridColumn gcTotal_Agg2;
    private BandedGridColumn gcTotal_Agg3;
    private BandedGridColumn gcTotal_Agg4;
    private BandedGridColumn gcTotal_Agg5;
    private BandedGridColumn gcTotal_Agg6;
    private BandedGridColumn gcTotal_Ce1;
    private BandedGridColumn gcTotal_Ce2;
    private BandedGridColumn gcTotal_Ce3;
    private BandedGridColumn gcTotal_Ce4;
    private BandedGridColumn gcTotal_Ce5;
    private BandedGridColumn gcTotal_Wa1;
    private BandedGridColumn gcTotal_Wa2;
    private BandedGridColumn gcTotal_Add1;
    private BandedGridColumn gcTotal_Add2;
    private BandedGridColumn gcTotal_Add3;
    private BandedGridColumn gcTotal_Add4;
    private BandedGridColumn gcTotal_Add5;
    private BandedGridColumn gcTotal_Add6;
    private GridBand Total_Agg1;
    private GridBand Total_Agg2;
    private GridBand Total_Agg3;
    private GridBand Total_Agg4;
    private GridBand Total_Agg5;
    private GridBand Total_Agg6;
    private GridBand Total_Ce1;
    private GridBand Total_Ce2;
    private GridBand Total_Ce3;
    private GridBand Total_Ce4;
    private GridBand Total_Ce5;
    private GridBand Total_Wa1;
    private GridBand Total_Wa2;
    private GridBand Total_Add1;
    private GridBand Total_Add2;
    private GridBand Total_Add3;
    private GridBand Total_Add4;
    private GridBand Total_Add5;
    private GridBand Total_Add6;
    private GridBand gridBand60;
    private SimpleButton btnInPCT;
    private TimeSpanEdit tseToTime;
    private TimeSpanEdit tseFromTime;
    private TextEdit txtGioKTTron;
    private LabelControl labelControl10;
    private SpinEdit spin_numberOfCopies;
    private Label label1;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupControl1 = new GroupControl();
      this.tseToTime = new TimeSpanEdit();
      this.tseFromTime = new TimeSpanEdit();
      this.btnLamMoi = new SimpleButton();
      this.lookupEditPrinters = new LookUpEdit();
      this.btnTimKiem = new SimpleButton();
      this.datDenNgay = new DateEdit();
      this.datTuNgay = new DateEdit();
      this.labelControl4 = new LabelControl();
      this.labelControl3 = new LabelControl();
      this.groupControl2 = new GroupControl();
      this.grcPhieuTron = new GridControl();
      this.grvPhieuTron = new GridView();
      this.groupControl4 = new GroupControl();
      this.txtGioKTTron = new TextEdit();
      this.labelControl10 = new LabelControl();
      this.txtSoPhieu = new TextEdit();
      this.labelControl20 = new LabelControl();
      this.datNgayTron = new DateEdit();
      this.txtGioTron = new TextEdit();
      this.labelControl11 = new LabelControl();
      this.txtXe = new TextEdit();
      this.txtTaiXe = new TextEdit();
      this.labelControl18 = new LabelControl();
      this.labelControl19 = new LabelControl();
      this.txtHangMuc = new TextEdit();
      this.labelControl17 = new LabelControl();
      this.txtDiaDiem = new TextEdit();
      this.labelControl16 = new LabelControl();
      this.txtLuyKe = new TextEdit();
      this.labelControl15 = new LabelControl();
      this.txtKhoiLuongDatHang = new TextEdit();
      this.labelControl7 = new LabelControl();
      this.txtTheTich = new TextEdit();
      this.labelControl14 = new LabelControl();
      this.txtDoSut = new TextEdit();
      this.labelControl13 = new LabelControl();
      this.labelControl12 = new LabelControl();
      this.txtTenMAC = new TextEdit();
      this.lblTenMAC = new LabelControl();
      this.txtNguoiTron = new TextEdit();
      this.txtNiemChi = new TextEdit();
      this.txtCuongDo = new TextEdit();
      this.txtTenCongTruong = new TextEdit();
      this.txtTenKhachHang = new TextEdit();
      this.txtMaPhieuTron = new TextEdit();
      this.labelControl9 = new LabelControl();
      this.labelControl8 = new LabelControl();
      this.labelControl6 = new LabelControl();
      this.labelControl5 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.labelControl1 = new LabelControl();
      this.grChiTietMeTron = new GroupControl();
      this.grcPhieuTronChiTiet = new GridControl();
      this.bandedGridView1 = new AdvBandedGridView();
      this.gridBand1 = new GridBand();
      this.gridBand2 = new GridBand();
      this.Agg1 = new GridBand();
      this.gridBand9 = new GridBand();
      this.gridBand10 = new GridBand();
      this.Agg2 = new GridBand();
      this.gridBand11 = new GridBand();
      this.gridBand13 = new GridBand();
      this.Agg3 = new GridBand();
      this.gridBand12 = new GridBand();
      this.gridBand15 = new GridBand();
      this.Agg4 = new GridBand();
      this.gridBand14 = new GridBand();
      this.gridBand16 = new GridBand();
      this.Agg5 = new GridBand();
      this.gridBand17 = new GridBand();
      this.gridBand18 = new GridBand();
      this.Agg6 = new GridBand();
      this.gridBand19 = new GridBand();
      this.gridBand20 = new GridBand();
      this.Ce1 = new GridBand();
      this.gridBand23 = new GridBand();
      this.gridBand22 = new GridBand();
      this.Ce2 = new GridBand();
      this.gridBand25 = new GridBand();
      this.gridBand26 = new GridBand();
      this.Ce3 = new GridBand();
      this.gridBand28 = new GridBand();
      this.gridBand30 = new GridBand();
      this.Ce4 = new GridBand();
      this.gridBand31 = new GridBand();
      this.gridBand32 = new GridBand();
      this.Ce5 = new GridBand();
      this.gridBand34 = new GridBand();
      this.gridBand35 = new GridBand();
      this.Wa1 = new GridBand();
      this.gridBand37 = new GridBand();
      this.gridBand38 = new GridBand();
      this.Wa2 = new GridBand();
      this.gridBand40 = new GridBand();
      this.gridBand41 = new GridBand();
      this.Add1 = new GridBand();
      this.gridBand43 = new GridBand();
      this.gridBand44 = new GridBand();
      this.Add2 = new GridBand();
      this.gridBand46 = new GridBand();
      this.gridBand47 = new GridBand();
      this.Add3 = new GridBand();
      this.gridBand49 = new GridBand();
      this.gridBand50 = new GridBand();
      this.Add4 = new GridBand();
      this.gridBand52 = new GridBand();
      this.gridBand53 = new GridBand();
      this.Add5 = new GridBand();
      this.gridBand55 = new GridBand();
      this.gridBand56 = new GridBand();
      this.Add6 = new GridBand();
      this.gridBand58 = new GridBand();
      this.gridBand59 = new GridBand();
      this.groupControl3 = new GroupControl();
      this.spin_numberOfCopies = new SpinEdit();
      this.label1 = new Label();
      this.btnInPCT = new SimpleButton();
      this.btnPrint = new SimpleButton();
      this.groupControl5 = new GroupControl();
      this.grcTotalMaterial = new GridControl();
      this.bandedGridView2 = new BandedGridView();
      this.Total_Agg1 = new GridBand();
      this.Total_Agg2 = new GridBand();
      this.Total_Agg3 = new GridBand();
      this.Total_Agg4 = new GridBand();
      this.Total_Agg5 = new GridBand();
      this.Total_Agg6 = new GridBand();
      this.Total_Ce1 = new GridBand();
      this.Total_Ce2 = new GridBand();
      this.Total_Ce3 = new GridBand();
      this.Total_Ce4 = new GridBand();
      this.Total_Ce5 = new GridBand();
      this.Total_Wa1 = new GridBand();
      this.Total_Wa2 = new GridBand();
      this.Total_Add1 = new GridBand();
      this.Total_Add2 = new GridBand();
      this.Total_Add3 = new GridBand();
      this.Total_Add4 = new GridBand();
      this.Total_Add5 = new GridBand();
      this.Total_Add6 = new GridBand();
      this.gridBand60 = new GridBand();
      this.gcTotal_Agg1 = new BandedGridColumn();
      this.gcTotal_Agg2 = new BandedGridColumn();
      this.gcTotal_Agg3 = new BandedGridColumn();
      this.gcTotal_Agg4 = new BandedGridColumn();
      this.gcTotal_Agg5 = new BandedGridColumn();
      this.gcTotal_Agg6 = new BandedGridColumn();
      this.gcTotal_Ce1 = new BandedGridColumn();
      this.gcTotal_Ce2 = new BandedGridColumn();
      this.gcTotal_Ce3 = new BandedGridColumn();
      this.gcTotal_Ce4 = new BandedGridColumn();
      this.gcTotal_Ce5 = new BandedGridColumn();
      this.gcTotal_Wa1 = new BandedGridColumn();
      this.gcTotal_Wa2 = new BandedGridColumn();
      this.gcTotal_Add1 = new BandedGridColumn();
      this.gcTotal_Add2 = new BandedGridColumn();
      this.gcTotal_Add3 = new BandedGridColumn();
      this.gcTotal_Add4 = new BandedGridColumn();
      this.gcTotal_Add5 = new BandedGridColumn();
      this.gcTotal_Add6 = new BandedGridColumn();
      this.gcNL = new BandedGridColumn();
      this.gcTheTich = new BandedGridColumn();
      this.gcPV_Agg_1 = new BandedGridColumn();
      this.gcPV_Agg1_Manual = new BandedGridColumn();
      this.gcPV_Agg_2 = new BandedGridColumn();
      this.gcPV_Agg2_Manual = new BandedGridColumn();
      this.gcPV_Agg_3 = new BandedGridColumn();
      this.gcPV_Agg3_Manual = new BandedGridColumn();
      this.gcPV_Agg_4 = new BandedGridColumn();
      this.gcPV_Agg4_Manual = new BandedGridColumn();
      this.gcPV_Agg_5 = new BandedGridColumn();
      this.gcPV_Agg5_Manual = new BandedGridColumn();
      this.gcPV_Agg_6 = new BandedGridColumn();
      this.gcPV_Agg6_Manual = new BandedGridColumn();
      this.gcPV_Ce_1 = new BandedGridColumn();
      this.gcPV_Ce1_Manual = new BandedGridColumn();
      this.gcPV_Ce_2 = new BandedGridColumn();
      this.gcPV_Ce2_Manual = new BandedGridColumn();
      this.gcPV_Ce_3 = new BandedGridColumn();
      this.gcPV_Ce3_Manual = new BandedGridColumn();
      this.gcPV_Ce_4 = new BandedGridColumn();
      this.gcPV_Ce4_Manual = new BandedGridColumn();
      this.gcPV_Ce_5 = new BandedGridColumn();
      this.gcPV_Ce5_Manual = new BandedGridColumn();
      this.gcPV_Wa_1 = new BandedGridColumn();
      this.gcPV_Wa1_Manual = new BandedGridColumn();
      this.gcPV_Wa_2 = new BandedGridColumn();
      this.gcPV_Wa2_Manual = new BandedGridColumn();
      this.gcPV_ADD_1 = new BandedGridColumn();
      this.gcPV_Add1_Manual = new BandedGridColumn();
      this.gcPV_ADD_2 = new BandedGridColumn();
      this.gcPV_Add2_Manual = new BandedGridColumn();
      this.gcPV_ADD_3 = new BandedGridColumn();
      this.gcPV_Add3_Manual = new BandedGridColumn();
      this.gcPV_ADD_4 = new BandedGridColumn();
      this.gcPV_Add4_Manual = new BandedGridColumn();
      this.gcPV_ADD_5 = new BandedGridColumn();
      this.gcPV_Add5_Manual = new BandedGridColumn();
      this.gcPV_ADD_6 = new BandedGridColumn();
      this.gcPV_Add6_Manual = new BandedGridColumn();
      this.gcMaPhieuTron = new GridColumn();
      this.gcNgayPhieuTron = new GridColumn();
      this.gcViewMaHopDong = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.groupControl1.BeginInit();
      this.tseToTime.Properties.BeginInit();
      this.tseFromTime.Properties.BeginInit();
      this.lookupEditPrinters.Properties.BeginInit();
      this.datDenNgay.Properties.BeginInit();
      this.datDenNgay.Properties.CalendarTimeProperties.BeginInit();
      this.datTuNgay.Properties.BeginInit();
      this.datTuNgay.Properties.CalendarTimeProperties.BeginInit();
      this.groupControl2.BeginInit();
      this.grcPhieuTron.BeginInit();
      this.grvPhieuTron.BeginInit();
      this.groupControl4.BeginInit();
      this.txtGioKTTron.Properties.BeginInit();
      this.txtSoPhieu.Properties.BeginInit();
      this.datNgayTron.Properties.BeginInit();
      this.datNgayTron.Properties.CalendarTimeProperties.BeginInit();
      this.txtGioTron.Properties.BeginInit();
      this.txtXe.Properties.BeginInit();
      this.txtTaiXe.Properties.BeginInit();
      this.txtHangMuc.Properties.BeginInit();
      this.txtDiaDiem.Properties.BeginInit();
      this.txtLuyKe.Properties.BeginInit();
      this.txtKhoiLuongDatHang.Properties.BeginInit();
      this.txtTheTich.Properties.BeginInit();
      this.txtDoSut.Properties.BeginInit();
      this.txtTenMAC.Properties.BeginInit();
      this.txtNguoiTron.Properties.BeginInit();
      this.txtNiemChi.Properties.BeginInit();
      this.txtCuongDo.Properties.BeginInit();
      this.txtTenCongTruong.Properties.BeginInit();
      this.txtTenKhachHang.Properties.BeginInit();
      this.txtMaPhieuTron.Properties.BeginInit();
      this.grChiTietMeTron.BeginInit();
      this.grcPhieuTronChiTiet.BeginInit();
      this.bandedGridView1.BeginInit();
      this.groupControl3.BeginInit();
      this.spin_numberOfCopies.Properties.BeginInit();
      this.groupControl5.BeginInit();
      this.grcTotalMaterial.BeginInit();
      this.bandedGridView2.BeginInit();
      this.SuspendLayout();
      this.groupControl1.Controls.Add((Control)this.tseToTime);
      this.groupControl1.Controls.Add((Control)this.tseFromTime);
      this.groupControl1.Controls.Add((Control)this.btnLamMoi);
      this.groupControl1.Controls.Add((Control)this.lookupEditPrinters);
      this.groupControl1.Controls.Add((Control)this.btnTimKiem);
      this.groupControl1.Controls.Add((Control)this.datDenNgay);
      this.groupControl1.Controls.Add((Control)this.datTuNgay);
      this.groupControl1.Controls.Add((Control)this.labelControl4);
      this.groupControl1.Controls.Add((Control)this.labelControl3);
      this.groupControl1.Location = new Point(3, 3);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(1138, 74);
      this.groupControl1.TabIndex = 5;
      this.groupControl1.Text = "Tìm kiếm";
      this.tseToTime.EditValue = (object)TimeSpan.Parse("00:00:00");
      this.tseToTime.Location = new Point(471, 37);
      this.tseToTime.Name = "tseToTime";
      this.tseToTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.tseToTime.Properties.Appearance.Options.UseFont = true;
      this.tseToTime.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tseToTime.Size = new Size(56, 22);
      this.tseToTime.TabIndex = 81;
      this.tseFromTime.EditValue = (object)TimeSpan.Parse("00:00:00");
      this.tseFromTime.Location = new Point(216, 37);
      this.tseFromTime.Name = "tseFromTime";
      this.tseFromTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.tseFromTime.Properties.Appearance.Options.UseFont = true;
      this.tseFromTime.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tseFromTime.Size = new Size(56, 22);
      this.tseFromTime.TabIndex = 80;
      this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnLamMoi.Appearance.Options.UseFont = true;
      this.btnLamMoi.Location = new Point(670, 30);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new Size(105, 35);
      this.btnLamMoi.TabIndex = 5;
      this.btnLamMoi.Text = "Làm mới";
      this.btnLamMoi.Click += new EventHandler(this.btnLamMoi_Click);
      this.lookupEditPrinters.Location = new Point(831, 39);
      this.lookupEditPrinters.Name = "lookupEditPrinters";
      this.lookupEditPrinters.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookupEditPrinters.Properties.NullText = "";
      this.lookupEditPrinters.Size = new Size(153, 20);
      this.lookupEditPrinters.TabIndex = 1;
      this.lookupEditPrinters.Visible = false;
      this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnTimKiem.Appearance.Options.UseFont = true;
      this.btnTimKiem.Location = new Point(550, 30);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new Size(105, 35);
      this.btnTimKiem.TabIndex = 4;
      this.btnTimKiem.Text = "Tìm";
      this.btnTimKiem.Click += new EventHandler(this.btnTimKiem_Click);
      this.datDenNgay.Location = new Point(365, 37);
      this.datDenNgay.Name = "datDenNgay";
      this.datDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datDenNgay.Properties.Appearance.Options.UseFont = true;
      this.datDenNgay.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datDenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datDenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datDenNgay.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datDenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datDenNgay.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datDenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datDenNgay.Size = new Size(100, 22);
      this.datDenNgay.TabIndex = 3;
      this.datTuNgay.Location = new Point(110, 37);
      this.datTuNgay.Name = "datTuNgay";
      this.datTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datTuNgay.Properties.Appearance.Options.UseFont = true;
      this.datTuNgay.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datTuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datTuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datTuNgay.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datTuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datTuNgay.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datTuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datTuNgay.Size = new Size(100, 22);
      this.datTuNgay.TabIndex = 2;
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new Point(300, 40);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(54, 16);
      this.labelControl4.TabIndex = 1;
      this.labelControl4.Text = "Đến ngày";
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(30, 40);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(69, 16);
      this.labelControl3.TabIndex = 0;
      this.labelControl3.Text = "Tạo từ ngày";
      this.groupControl2.Controls.Add((Control)this.grcPhieuTron);
      this.groupControl2.Location = new Point(3, 83);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(328, 501);
      this.groupControl2.TabIndex = 6;
      this.groupControl2.Text = "Danh sách phiếu trộn";
      this.grcPhieuTron.Dock = DockStyle.Fill;
      this.grcPhieuTron.Location = new Point(2, 23);
      this.grcPhieuTron.MainView = (BaseView)this.grvPhieuTron;
      this.grcPhieuTron.Name = "grcPhieuTron";
      this.grcPhieuTron.Size = new Size(324, 476);
      this.grcPhieuTron.TabIndex = 0;
      this.grcPhieuTron.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvPhieuTron
      });
      this.grvPhieuTron.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.grvPhieuTron.Appearance.Row.Options.UseFont = true;
      this.grvPhieuTron.Columns.AddRange(new GridColumn[4]
      {
        this.gcMaPhieuTron,
        this.gcNgayPhieuTron,
        this.gcViewMaHopDong,
        this.gridColumn3
      });
      this.grvPhieuTron.GridControl = this.grcPhieuTron;
      this.grvPhieuTron.Name = "grvPhieuTron";
      this.grvPhieuTron.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.grvPhieuTron.OptionsView.ShowFooter = true;
      this.grvPhieuTron.OptionsView.ShowGroupPanel = false;
      this.grvPhieuTron.FocusedRowChanged += new FocusedRowChangedEventHandler(this.grvPhieuTron_FocusedRowChanged);
      this.groupControl4.Controls.Add((Control)this.txtGioKTTron);
      this.groupControl4.Controls.Add((Control)this.labelControl10);
      this.groupControl4.Controls.Add((Control)this.txtSoPhieu);
      this.groupControl4.Controls.Add((Control)this.labelControl20);
      this.groupControl4.Controls.Add((Control)this.datNgayTron);
      this.groupControl4.Controls.Add((Control)this.txtGioTron);
      this.groupControl4.Controls.Add((Control)this.labelControl11);
      this.groupControl4.Controls.Add((Control)this.txtXe);
      this.groupControl4.Controls.Add((Control)this.txtTaiXe);
      this.groupControl4.Controls.Add((Control)this.labelControl18);
      this.groupControl4.Controls.Add((Control)this.labelControl19);
      this.groupControl4.Controls.Add((Control)this.txtHangMuc);
      this.groupControl4.Controls.Add((Control)this.labelControl17);
      this.groupControl4.Controls.Add((Control)this.txtDiaDiem);
      this.groupControl4.Controls.Add((Control)this.labelControl16);
      this.groupControl4.Controls.Add((Control)this.txtLuyKe);
      this.groupControl4.Controls.Add((Control)this.labelControl15);
      this.groupControl4.Controls.Add((Control)this.txtKhoiLuongDatHang);
      this.groupControl4.Controls.Add((Control)this.labelControl7);
      this.groupControl4.Controls.Add((Control)this.txtTheTich);
      this.groupControl4.Controls.Add((Control)this.labelControl14);
      this.groupControl4.Controls.Add((Control)this.txtDoSut);
      this.groupControl4.Controls.Add((Control)this.labelControl13);
      this.groupControl4.Controls.Add((Control)this.labelControl12);
      this.groupControl4.Controls.Add((Control)this.txtTenMAC);
      this.groupControl4.Controls.Add((Control)this.lblTenMAC);
      this.groupControl4.Controls.Add((Control)this.txtNguoiTron);
      this.groupControl4.Controls.Add((Control)this.txtNiemChi);
      this.groupControl4.Controls.Add((Control)this.txtCuongDo);
      this.groupControl4.Controls.Add((Control)this.txtTenCongTruong);
      this.groupControl4.Controls.Add((Control)this.txtTenKhachHang);
      this.groupControl4.Controls.Add((Control)this.txtMaPhieuTron);
      this.groupControl4.Controls.Add((Control)this.labelControl9);
      this.groupControl4.Controls.Add((Control)this.labelControl8);
      this.groupControl4.Controls.Add((Control)this.labelControl6);
      this.groupControl4.Controls.Add((Control)this.labelControl5);
      this.groupControl4.Controls.Add((Control)this.labelControl2);
      this.groupControl4.Controls.Add((Control)this.labelControl1);
      this.groupControl4.Location = new Point(337, 83);
      this.groupControl4.Name = "groupControl4";
      this.groupControl4.Size = new Size(804, 250);
      this.groupControl4.TabIndex = 8;
      this.groupControl4.Text = "Thông tin phiếu trộn";
      this.txtGioKTTron.Location = new Point(721, 57);
      this.txtGioKTTron.Name = "txtGioKTTron";
      this.txtGioKTTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtGioKTTron.Properties.Appearance.Options.UseFont = true;
      this.txtGioKTTron.Size = new Size(73, 20);
      this.txtGioKTTron.TabIndex = 46;
      this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl10.Appearance.Options.UseFont = true;
      this.labelControl10.Location = new Point(654, 60);
      this.labelControl10.Name = "labelControl10";
      this.labelControl10.Size = new Size(63, 14);
      this.labelControl10.TabIndex = 45;
      this.labelControl10.Text = "Giờ KT trộn";
      this.txtSoPhieu.Location = new Point(577, 111);
      this.txtSoPhieu.Name = "txtSoPhieu";
      this.txtSoPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtSoPhieu.Properties.Appearance.Options.UseFont = true;
      this.txtSoPhieu.Size = new Size(217, 20);
      this.txtSoPhieu.TabIndex = 44;
      this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl20.Appearance.Options.UseFont = true;
      this.labelControl20.Location = new Point(496, 114);
      this.labelControl20.Name = "labelControl20";
      this.labelControl20.TabIndex = 43;
      this.labelControl20.Text = "Số Phiếu trộn";
      this.datNgayTron.Location = new Point(577, 30);
      this.datNgayTron.Name = "datNgayTron";
      this.datNgayTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.datNgayTron.Properties.Appearance.Options.UseFont = true;
      this.datNgayTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayTron.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayTron.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datNgayTron.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datNgayTron.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datNgayTron.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datNgayTron.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datNgayTron.Size = new Size(217, 20);
      this.datNgayTron.TabIndex = 42;
      this.txtGioTron.Location = new Point(577, 57);
      this.txtGioTron.Name = "txtGioTron";
      this.txtGioTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtGioTron.Properties.Appearance.Options.UseFont = true;
      this.txtGioTron.Size = new Size(73, 20);
      this.txtGioTron.TabIndex = 40;
      this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl11.Appearance.Options.UseFont = true;
      this.labelControl11.Location = new Point(497, 60);
      this.labelControl11.Name = "labelControl11";
      this.labelControl11.Size = new Size(63, 14);
      this.labelControl11.TabIndex = 38;
      this.labelControl11.Text = "Giờ BĐ trộn";
      this.txtXe.Location = new Point(316, 165);
      this.txtXe.Name = "txtXe";
      this.txtXe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtXe.Properties.Appearance.Options.UseFont = true;
      this.txtXe.Size = new Size(160, 20);
      this.txtXe.TabIndex = 37;
      this.txtTaiXe.Location = new Point(90, 165);
      this.txtTaiXe.Name = "txtTaiXe";
      this.txtTaiXe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtTaiXe.Properties.Appearance.Options.UseFont = true;
      this.txtTaiXe.Size = new Size(160, 20);
      this.txtTaiXe.TabIndex = 36;
      this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl18.Appearance.Options.UseFont = true;
      this.labelControl18.Location = new Point(270, 168);
      this.labelControl18.Name = "labelControl18";
      this.labelControl18.Size = new Size(40, 14);
      this.labelControl18.TabIndex = 35;
      this.labelControl18.Text = "Biển xe";
      this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl19.Appearance.Options.UseFont = true;
      this.labelControl19.Location = new Point(15, 168);
      this.labelControl19.Name = "labelControl19";
      this.labelControl19.Size = new Size(33, 14);
      this.labelControl19.TabIndex = 34;
      this.labelControl19.Text = "Tài xế";
      this.txtHangMuc.Location = new Point(90, 84);
      this.txtHangMuc.Name = "txtHangMuc";
      this.txtHangMuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtHangMuc.Properties.Appearance.Options.UseFont = true;
      this.txtHangMuc.Size = new Size(386, 20);
      this.txtHangMuc.TabIndex = 33;
      this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl17.Appearance.Options.UseFont = true;
      this.labelControl17.Location = new Point(15, 86);
      this.labelControl17.Name = "labelControl17";
      this.labelControl17.Size = new Size(55, 14);
      this.labelControl17.TabIndex = 32;
      this.labelControl17.Text = "Hạng mục";
      this.txtDiaDiem.Location = new Point(90, 111);
      this.txtDiaDiem.Name = "txtDiaDiem";
      this.txtDiaDiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtDiaDiem.Properties.Appearance.Options.UseFont = true;
      this.txtDiaDiem.Size = new Size(386, 20);
      this.txtDiaDiem.TabIndex = 31;
      this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl16.Appearance.Options.UseFont = true;
      this.labelControl16.Location = new Point(15, 112);
      this.labelControl16.Name = "labelControl16";
      this.labelControl16.Size = new Size(46, 14);
      this.labelControl16.TabIndex = 30;
      this.labelControl16.Text = "Địa điểm";
      this.txtLuyKe.Location = new Point(577, 219);
      this.txtLuyKe.Name = "txtLuyKe";
      this.txtLuyKe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtLuyKe.Properties.Appearance.Options.UseFont = true;
      this.txtLuyKe.Size = new Size(217, 20);
      this.txtLuyKe.TabIndex = 29;
      this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl15.Appearance.Options.UseFont = true;
      this.labelControl15.Location = new Point(497, 222);
      this.labelControl15.Name = "labelControl15";
      this.labelControl15.Size = new Size(36, 14);
      this.labelControl15.TabIndex = 28;
      this.labelControl15.Text = "Luỹ kế";
      this.txtKhoiLuongDatHang.Location = new Point(577, 165);
      this.txtKhoiLuongDatHang.Name = "txtKhoiLuongDatHang";
      this.txtKhoiLuongDatHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtKhoiLuongDatHang.Properties.Appearance.Options.UseFont = true;
      this.txtKhoiLuongDatHang.Size = new Size(217, 20);
      this.txtKhoiLuongDatHang.TabIndex = 27;
      this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl7.Appearance.Options.UseFont = true;
      this.labelControl7.Location = new Point(497, 168);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new Size(50, 14);
      this.labelControl7.TabIndex = 26;
      this.labelControl7.Text = "Đặt hàng";
      this.txtTheTich.Location = new Point(577, 192);
      this.txtTheTich.Name = "txtTheTich";
      this.txtTheTich.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtTheTich.Properties.Appearance.Options.UseFont = true;
      this.txtTheTich.Size = new Size(217, 20);
      this.txtTheTich.TabIndex = 25;
      this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl14.Appearance.Options.UseFont = true;
      this.labelControl14.Location = new Point(497, 195);
      this.labelControl14.Name = "labelControl14";
      this.labelControl14.Size = new Size(46, 14);
      this.labelControl14.TabIndex = 24;
      this.labelControl14.Text = "Thể tích";
      this.txtDoSut.Location = new Point(316, 219);
      this.txtDoSut.Name = "txtDoSut";
      this.txtDoSut.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtDoSut.Properties.Appearance.Options.UseFont = true;
      this.txtDoSut.Size = new Size(160, 20);
      this.txtDoSut.TabIndex = 23;
      this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl13.Appearance.Options.UseFont = true;
      this.labelControl13.Location = new Point(274, 222);
      this.labelControl13.Name = "labelControl13";
      this.labelControl13.Size = new Size(36, 14);
      this.labelControl13.TabIndex = 22;
      this.labelControl13.Text = "Độ sụt";
      this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl12.Appearance.Options.UseFont = true;
      this.labelControl12.Location = new Point(497, 33);
      this.labelControl12.Name = "labelControl12";
      this.labelControl12.Size = new Size(54, 14);
      this.labelControl12.TabIndex = 20;
      this.labelControl12.Text = "Ngày trộn";
      this.txtTenMAC.Location = new Point(90, 192);
      this.txtTenMAC.Name = "txtTenMAC";
      this.txtTenMAC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtTenMAC.Properties.Appearance.Options.UseFont = true;
      this.txtTenMAC.Size = new Size(386, 20);
      this.txtTenMAC.TabIndex = 19;
      this.lblTenMAC.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblTenMAC.Appearance.Options.UseFont = true;
      this.lblTenMAC.Location = new Point(15, 195);
      this.lblTenMAC.Name = "lblTenMAC";
      this.lblTenMAC.Size = new Size(50, 14);
      this.lblTenMAC.TabIndex = 18;
      this.lblTenMAC.Text = "Tên MAC";
      this.txtNguoiTron.Location = new Point(90, 138);
      this.txtNguoiTron.Name = "txtNguoiTron";
      this.txtNguoiTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtNguoiTron.Properties.Appearance.Options.UseFont = true;
      this.txtNguoiTron.Size = new Size(386, 20);
      this.txtNguoiTron.TabIndex = 15;
      this.txtNiemChi.Location = new Point(577, 138);
      this.txtNiemChi.Name = "txtNiemChi";
      this.txtNiemChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtNiemChi.Properties.Appearance.Options.UseFont = true;
      this.txtNiemChi.Size = new Size(217, 20);
      this.txtNiemChi.TabIndex = 14;
      this.txtCuongDo.Location = new Point(90, 219);
      this.txtCuongDo.Name = "txtCuongDo";
      this.txtCuongDo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtCuongDo.Properties.Appearance.Options.UseFont = true;
      this.txtCuongDo.Size = new Size(160, 20);
      this.txtCuongDo.TabIndex = 12;
      this.txtTenCongTruong.Location = new Point(90, 57);
      this.txtTenCongTruong.Name = "txtTenCongTruong";
      this.txtTenCongTruong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtTenCongTruong.Properties.Appearance.Options.UseFont = true;
      this.txtTenCongTruong.Size = new Size(386, 20);
      this.txtTenCongTruong.TabIndex = 11;
      this.txtTenKhachHang.Location = new Point(90, 30);
      this.txtTenKhachHang.Name = "txtTenKhachHang";
      this.txtTenKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtTenKhachHang.Properties.Appearance.Options.UseFont = true;
      this.txtTenKhachHang.Size = new Size(386, 20);
      this.txtTenKhachHang.TabIndex = 10;
      this.txtMaPhieuTron.Location = new Point(577, 84);
      this.txtMaPhieuTron.Name = "txtMaPhieuTron";
      this.txtMaPhieuTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtMaPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.txtMaPhieuTron.Size = new Size(217, 20);
      this.txtMaPhieuTron.TabIndex = 9;
      this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Location = new Point(15, 141);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new Size(59, 14);
      this.labelControl9.TabIndex = 6;
      this.labelControl9.Text = "Người trộn";
      this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl8.Appearance.Options.UseFont = true;
      this.labelControl8.Location = new Point(497, 141);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new Size(63, 14);
      this.labelControl8.TabIndex = 5;
      this.labelControl8.Text = "Số niêm chì";
      this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl6.Appearance.Options.UseFont = true;
      this.labelControl6.Location = new Point(15, 222);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new Size(54, 14);
      this.labelControl6.TabIndex = 3;
      this.labelControl6.Text = "Cường độ";
      this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new Point(15, 60);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(70, 14);
      this.labelControl5.TabIndex = 2;
      this.labelControl5.Text = "Công trường";
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(15, 33);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(64, 14);
      this.labelControl2.TabIndex = 1;
      this.labelControl2.Text = "Khách hàng";
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(497, 87);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(76, 14);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Mã Phiếu trộn";
      this.grChiTietMeTron.Controls.Add((Control)this.grcPhieuTronChiTiet);
      this.grChiTietMeTron.Location = new Point(337, 339);
      this.grChiTietMeTron.Name = "grChiTietMeTron";
      this.grChiTietMeTron.Size = new Size(804, 243);
      this.grChiTietMeTron.TabIndex = 9;
      this.grChiTietMeTron.Text = "Chi tiết mẻ trộn";
      this.grcPhieuTronChiTiet.Dock = DockStyle.Fill;
      this.grcPhieuTronChiTiet.Location = new Point(2, 23);
      this.grcPhieuTronChiTiet.MainView = (BaseView)this.bandedGridView1;
      this.grcPhieuTronChiTiet.Name = "grcPhieuTronChiTiet";
      this.grcPhieuTronChiTiet.Size = new Size(800, 218);
      this.grcPhieuTronChiTiet.TabIndex = 0;
      this.grcPhieuTronChiTiet.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.bandedGridView1
      });
      this.bandedGridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.bandedGridView1.Appearance.Row.Options.UseFont = true;
      this.bandedGridView1.Bands.AddRange(new GridBand[21]
      {
        this.gridBand1,
        this.gridBand2,
        this.Agg1,
        this.Agg2,
        this.Agg3,
        this.Agg4,
        this.Agg5,
        this.Agg6,
        this.Ce1,
        this.Ce2,
        this.Ce3,
        this.Ce4,
        this.Ce5,
        this.Wa1,
        this.Wa2,
        this.Add1,
        this.Add2,
        this.Add3,
        this.Add4,
        this.Add5,
        this.Add6
      });
      this.bandedGridView1.Columns.AddRange(new BandedGridColumn[40]
      {
        this.gcNL,
        this.gcTheTich,
        this.gcPV_Agg_1,
        this.gcPV_Agg_2,
        this.gcPV_Agg_3,
        this.gcPV_Agg_4,
        this.gcPV_Agg_5,
        this.gcPV_Agg_6,
        this.gcPV_Agg1_Manual,
        this.gcPV_Agg2_Manual,
        this.gcPV_Agg3_Manual,
        this.gcPV_Agg4_Manual,
        this.gcPV_Agg5_Manual,
        this.gcPV_Agg6_Manual,
        this.gcPV_Ce_1,
        this.gcPV_Ce_2,
        this.gcPV_Ce_3,
        this.gcPV_Ce_4,
        this.gcPV_Ce_5,
        this.gcPV_Ce1_Manual,
        this.gcPV_Ce2_Manual,
        this.gcPV_Ce3_Manual,
        this.gcPV_Ce4_Manual,
        this.gcPV_Ce5_Manual,
        this.gcPV_Wa_1,
        this.gcPV_Wa_2,
        this.gcPV_Wa1_Manual,
        this.gcPV_Wa2_Manual,
        this.gcPV_ADD_1,
        this.gcPV_ADD_2,
        this.gcPV_ADD_3,
        this.gcPV_ADD_4,
        this.gcPV_ADD_5,
        this.gcPV_ADD_6,
        this.gcPV_Add1_Manual,
        this.gcPV_Add2_Manual,
        this.gcPV_Add3_Manual,
        this.gcPV_Add4_Manual,
        this.gcPV_Add5_Manual,
        this.gcPV_Add6_Manual
      });
      this.bandedGridView1.GridControl = this.grcPhieuTronChiTiet;
      this.bandedGridView1.Name = "bandedGridView1";
      this.bandedGridView1.OptionsView.ShowColumnHeaders = false;
      this.bandedGridView1.OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Never;
      this.bandedGridView1.OptionsView.ShowGroupPanel = false;
      this.bandedGridView1.RowStyle += new RowStyleEventHandler(this.bandedGridView1_RowStyle);
      this.gridBand1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gridBand1.AppearanceHeader.Options.UseFont = true;
      this.gridBand1.Caption = "N.L";
      this.gridBand1.Columns.Add(this.gcNL);
      this.gridBand1.Name = "gridBand1";
      this.gridBand1.VisibleIndex = 0;
      this.gridBand2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gridBand2.AppearanceHeader.Options.UseFont = true;
      this.gridBand2.Caption = "Thể tích";
      this.gridBand2.Columns.Add(this.gcTheTich);
      this.gridBand2.Name = "gridBand2";
      this.gridBand2.VisibleIndex = 1;
      this.Agg1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.Agg1.AppearanceHeader.Options.UseFont = true;
      this.Agg1.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg1.Caption = "AGG1";
      this.Agg1.Children.AddRange(new GridBand[2]
      {
        this.gridBand9,
        this.gridBand10
      });
      this.Agg1.Name = "Agg1";
      this.Agg1.VisibleIndex = 2;
      this.Agg1.Width = 150;
      this.gridBand9.Caption = "Thực cân";
      this.gridBand9.Columns.Add(this.gcPV_Agg_1);
      this.gridBand9.Name = "gridBand9";
      this.gridBand9.VisibleIndex = 0;
      this.gridBand9.Width = 75;
      this.gridBand10.Caption = "Thực cân tay";
      this.gridBand10.Columns.Add(this.gcPV_Agg1_Manual);
      this.gridBand10.Name = "gridBand10";
      this.gridBand10.VisibleIndex = 1;
      this.gridBand10.Width = 75;
      this.Agg2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Agg2.AppearanceHeader.Options.UseFont = true;
      this.Agg2.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg2.Caption = "AGG2";
      this.Agg2.Children.AddRange(new GridBand[2]
      {
        this.gridBand11,
        this.gridBand13
      });
      this.Agg2.Name = "Agg2";
      this.Agg2.VisibleIndex = 3;
      this.Agg2.Width = 150;
      this.gridBand11.Caption = "Thực cân";
      this.gridBand11.Columns.Add(this.gcPV_Agg_2);
      this.gridBand11.Name = "gridBand11";
      this.gridBand11.VisibleIndex = 0;
      this.gridBand11.Width = 75;
      this.gridBand13.Caption = "Thực cân tay";
      this.gridBand13.Columns.Add(this.gcPV_Agg2_Manual);
      this.gridBand13.Name = "gridBand13";
      this.gridBand13.VisibleIndex = 1;
      this.gridBand13.Width = 75;
      this.Agg3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Agg3.AppearanceHeader.Options.UseFont = true;
      this.Agg3.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg3.Caption = "AGG3";
      this.Agg3.Children.AddRange(new GridBand[2]
      {
        this.gridBand12,
        this.gridBand15
      });
      this.Agg3.Name = "Agg3";
      this.Agg3.VisibleIndex = 4;
      this.Agg3.Width = 150;
      this.gridBand12.Caption = "Thực cân";
      this.gridBand12.Columns.Add(this.gcPV_Agg_3);
      this.gridBand12.Name = "gridBand12";
      this.gridBand12.VisibleIndex = 0;
      this.gridBand12.Width = 75;
      this.gridBand15.Caption = "Thực cân tay";
      this.gridBand15.Columns.Add(this.gcPV_Agg3_Manual);
      this.gridBand15.Name = "gridBand15";
      this.gridBand15.VisibleIndex = 1;
      this.gridBand15.Width = 75;
      this.Agg4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Agg4.AppearanceHeader.Options.UseFont = true;
      this.Agg4.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg4.Caption = "AGG4";
      this.Agg4.Children.AddRange(new GridBand[2]
      {
        this.gridBand14,
        this.gridBand16
      });
      this.Agg4.Name = "Agg4";
      this.Agg4.VisibleIndex = 5;
      this.Agg4.Width = 150;
      this.gridBand14.Caption = "Thực cân";
      this.gridBand14.Columns.Add(this.gcPV_Agg_4);
      this.gridBand14.Name = "gridBand14";
      this.gridBand14.VisibleIndex = 0;
      this.gridBand14.Width = 75;
      this.gridBand16.Caption = "Thực cân tay";
      this.gridBand16.Columns.Add(this.gcPV_Agg4_Manual);
      this.gridBand16.Name = "gridBand16";
      this.gridBand16.VisibleIndex = 1;
      this.gridBand16.Width = 75;
      this.Agg5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Agg5.AppearanceHeader.Options.UseFont = true;
      this.Agg5.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg5.Caption = "AGG5";
      this.Agg5.Children.AddRange(new GridBand[2]
      {
        this.gridBand17,
        this.gridBand18
      });
      this.Agg5.Name = "Agg5";
      this.Agg5.VisibleIndex = 6;
      this.Agg5.Width = 150;
      this.gridBand17.Caption = "Thực cân";
      this.gridBand17.Columns.Add(this.gcPV_Agg_5);
      this.gridBand17.Name = "gridBand17";
      this.gridBand17.VisibleIndex = 0;
      this.gridBand17.Width = 75;
      this.gridBand18.Caption = "Thực cân tay";
      this.gridBand18.Columns.Add(this.gcPV_Agg5_Manual);
      this.gridBand18.Name = "gridBand18";
      this.gridBand18.VisibleIndex = 1;
      this.gridBand18.Width = 75;
      this.Agg6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Agg6.AppearanceHeader.Options.UseFont = true;
      this.Agg6.AppearanceHeader.Options.UseTextOptions = true;
      this.Agg6.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Agg6.Caption = "AGG6";
      this.Agg6.Children.AddRange(new GridBand[2]
      {
        this.gridBand19,
        this.gridBand20
      });
      this.Agg6.Name = "Agg6";
      this.Agg6.VisibleIndex = 7;
      this.Agg6.Width = 150;
      this.gridBand19.Caption = "Thực cân";
      this.gridBand19.Columns.Add(this.gcPV_Agg_6);
      this.gridBand19.Name = "gridBand19";
      this.gridBand19.VisibleIndex = 0;
      this.gridBand19.Width = 75;
      this.gridBand20.Caption = "Thực cân tay";
      this.gridBand20.Columns.Add(this.gcPV_Agg6_Manual);
      this.gridBand20.Name = "gridBand20";
      this.gridBand20.VisibleIndex = 1;
      this.gridBand20.Width = 75;
      this.Ce1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Ce1.AppearanceHeader.Options.UseFont = true;
      this.Ce1.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce1.Caption = "CE1";
      this.Ce1.Children.AddRange(new GridBand[2]
      {
        this.gridBand23,
        this.gridBand22
      });
      this.Ce1.Name = "Ce1";
      this.Ce1.VisibleIndex = 8;
      this.Ce1.Width = 150;
      this.gridBand23.Caption = "Thực cân";
      this.gridBand23.Columns.Add(this.gcPV_Ce_1);
      this.gridBand23.Name = "gridBand23";
      this.gridBand23.VisibleIndex = 0;
      this.gridBand23.Width = 75;
      this.gridBand22.Caption = "Thực cân tay";
      this.gridBand22.Columns.Add(this.gcPV_Ce1_Manual);
      this.gridBand22.Name = "gridBand22";
      this.gridBand22.VisibleIndex = 1;
      this.gridBand22.Width = 75;
      this.Ce2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Ce2.AppearanceHeader.Options.UseFont = true;
      this.Ce2.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce2.Caption = "CE2";
      this.Ce2.Children.AddRange(new GridBand[2]
      {
        this.gridBand25,
        this.gridBand26
      });
      this.Ce2.Name = "Ce2";
      this.Ce2.VisibleIndex = 9;
      this.Ce2.Width = 150;
      this.gridBand25.Caption = "Thực cân";
      this.gridBand25.Columns.Add(this.gcPV_Ce_2);
      this.gridBand25.Name = "gridBand25";
      this.gridBand25.VisibleIndex = 0;
      this.gridBand25.Width = 75;
      this.gridBand26.Caption = "Thực cân tay";
      this.gridBand26.Columns.Add(this.gcPV_Ce2_Manual);
      this.gridBand26.Name = "gridBand26";
      this.gridBand26.VisibleIndex = 1;
      this.gridBand26.Width = 75;
      this.Ce3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Ce3.AppearanceHeader.Options.UseFont = true;
      this.Ce3.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce3.Caption = "CE3";
      this.Ce3.Children.AddRange(new GridBand[2]
      {
        this.gridBand28,
        this.gridBand30
      });
      this.Ce3.Name = "Ce3";
      this.Ce3.VisibleIndex = 10;
      this.Ce3.Width = 150;
      this.gridBand28.Caption = "Thực cân";
      this.gridBand28.Columns.Add(this.gcPV_Ce_3);
      this.gridBand28.Name = "gridBand28";
      this.gridBand28.VisibleIndex = 0;
      this.gridBand28.Width = 75;
      this.gridBand30.Caption = "Thực cân tay";
      this.gridBand30.Columns.Add(this.gcPV_Ce3_Manual);
      this.gridBand30.Name = "gridBand30";
      this.gridBand30.VisibleIndex = 1;
      this.gridBand30.Width = 75;
      this.Ce4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Ce4.AppearanceHeader.Options.UseFont = true;
      this.Ce4.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce4.Caption = "CE4";
      this.Ce4.Children.AddRange(new GridBand[2]
      {
        this.gridBand31,
        this.gridBand32
      });
      this.Ce4.Name = "Ce4";
      this.Ce4.VisibleIndex = 11;
      this.Ce4.Width = 150;
      this.gridBand31.Caption = "Thực cân";
      this.gridBand31.Columns.Add(this.gcPV_Ce_4);
      this.gridBand31.Name = "gridBand31";
      this.gridBand31.VisibleIndex = 0;
      this.gridBand31.Width = 75;
      this.gridBand32.Caption = "Thực cân tay";
      this.gridBand32.Columns.Add(this.gcPV_Ce4_Manual);
      this.gridBand32.Name = "gridBand32";
      this.gridBand32.VisibleIndex = 1;
      this.gridBand32.Width = 75;
      this.Ce5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Ce5.AppearanceHeader.Options.UseFont = true;
      this.Ce5.AppearanceHeader.Options.UseTextOptions = true;
      this.Ce5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Ce5.Caption = "CE5";
      this.Ce5.Children.AddRange(new GridBand[2]
      {
        this.gridBand34,
        this.gridBand35
      });
      this.Ce5.Name = "Ce5";
      this.Ce5.VisibleIndex = 12;
      this.Ce5.Width = 150;
      this.gridBand34.Caption = "Thực cân";
      this.gridBand34.Columns.Add(this.gcPV_Ce_5);
      this.gridBand34.Name = "gridBand34";
      this.gridBand34.VisibleIndex = 0;
      this.gridBand34.Width = 75;
      this.gridBand35.Caption = "Thực cân tay";
      this.gridBand35.Columns.Add(this.gcPV_Ce5_Manual);
      this.gridBand35.Name = "gridBand35";
      this.gridBand35.VisibleIndex = 1;
      this.gridBand35.Width = 75;
      this.Wa1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Wa1.AppearanceHeader.Options.UseFont = true;
      this.Wa1.AppearanceHeader.Options.UseTextOptions = true;
      this.Wa1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Wa1.Caption = "WA1";
      this.Wa1.Children.AddRange(new GridBand[2]
      {
        this.gridBand37,
        this.gridBand38
      });
      this.Wa1.Name = "Wa1";
      this.Wa1.VisibleIndex = 13;
      this.Wa1.Width = 150;
      this.gridBand37.Caption = "Thực cân";
      this.gridBand37.Columns.Add(this.gcPV_Wa_1);
      this.gridBand37.Name = "gridBand37";
      this.gridBand37.VisibleIndex = 0;
      this.gridBand37.Width = 75;
      this.gridBand38.Caption = "Thực cân tay";
      this.gridBand38.Columns.Add(this.gcPV_Wa1_Manual);
      this.gridBand38.Name = "gridBand38";
      this.gridBand38.VisibleIndex = 1;
      this.gridBand38.Width = 75;
      this.Wa2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Wa2.AppearanceHeader.Options.UseFont = true;
      this.Wa2.AppearanceHeader.Options.UseTextOptions = true;
      this.Wa2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Wa2.Caption = "WA2";
      this.Wa2.Children.AddRange(new GridBand[2]
      {
        this.gridBand40,
        this.gridBand41
      });
      this.Wa2.Name = "Wa2";
      this.Wa2.VisibleIndex = 14;
      this.Wa2.Width = 150;
      this.gridBand40.Caption = "Thực cân";
      this.gridBand40.Columns.Add(this.gcPV_Wa_2);
      this.gridBand40.Name = "gridBand40";
      this.gridBand40.VisibleIndex = 0;
      this.gridBand40.Width = 75;
      this.gridBand41.Caption = "Thực cân tay";
      this.gridBand41.Columns.Add(this.gcPV_Wa2_Manual);
      this.gridBand41.Name = "gridBand41";
      this.gridBand41.VisibleIndex = 1;
      this.gridBand41.Width = 75;
      this.Add1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Add1.AppearanceHeader.Options.UseFont = true;
      this.Add1.AppearanceHeader.Options.UseTextOptions = true;
      this.Add1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add1.Caption = "ADD1";
      this.Add1.Children.AddRange(new GridBand[2]
      {
        this.gridBand43,
        this.gridBand44
      });
      this.Add1.Name = "Add1";
      this.Add1.VisibleIndex = 15;
      this.Add1.Width = 150;
      this.gridBand43.Caption = "Thực cân";
      this.gridBand43.Columns.Add(this.gcPV_ADD_1);
      this.gridBand43.Name = "gridBand43";
      this.gridBand43.VisibleIndex = 0;
      this.gridBand43.Width = 75;
      this.gridBand44.Caption = "Thực cân tay";
      this.gridBand44.Columns.Add(this.gcPV_Add1_Manual);
      this.gridBand44.Name = "gridBand44";
      this.gridBand44.VisibleIndex = 1;
      this.gridBand44.Width = 75;
      this.Add2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Add2.AppearanceHeader.Options.UseFont = true;
      this.Add2.AppearanceHeader.Options.UseTextOptions = true;
      this.Add2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add2.Caption = "ADD2";
      this.Add2.Children.AddRange(new GridBand[2]
      {
        this.gridBand46,
        this.gridBand47
      });
      this.Add2.Name = "Add2";
      this.Add2.VisibleIndex = 16;
      this.Add2.Width = 150;
      this.gridBand46.Caption = "Thực cân";
      this.gridBand46.Columns.Add(this.gcPV_ADD_2);
      this.gridBand46.Name = "gridBand46";
      this.gridBand46.VisibleIndex = 0;
      this.gridBand46.Width = 75;
      this.gridBand47.Caption = "Thực cân tay";
      this.gridBand47.Columns.Add(this.gcPV_Add2_Manual);
      this.gridBand47.Name = "gridBand47";
      this.gridBand47.VisibleIndex = 1;
      this.gridBand47.Width = 75;
      this.Add3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Add3.AppearanceHeader.Options.UseFont = true;
      this.Add3.AppearanceHeader.Options.UseTextOptions = true;
      this.Add3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add3.Caption = "ADD3";
      this.Add3.Children.AddRange(new GridBand[2]
      {
        this.gridBand49,
        this.gridBand50
      });
      this.Add3.Name = "Add3";
      this.Add3.VisibleIndex = 17;
      this.Add3.Width = 150;
      this.gridBand49.Caption = "Thực cân";
      this.gridBand49.Columns.Add(this.gcPV_ADD_3);
      this.gridBand49.Name = "gridBand49";
      this.gridBand49.VisibleIndex = 0;
      this.gridBand49.Width = 75;
      this.gridBand50.Caption = "Thực cân tay";
      this.gridBand50.Columns.Add(this.gcPV_Add3_Manual);
      this.gridBand50.Name = "gridBand50";
      this.gridBand50.VisibleIndex = 1;
      this.gridBand50.Width = 75;
      this.Add4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Add4.AppearanceHeader.Options.UseFont = true;
      this.Add4.AppearanceHeader.Options.UseTextOptions = true;
      this.Add4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add4.Caption = "ADD4";
      this.Add4.Children.AddRange(new GridBand[2]
      {
        this.gridBand52,
        this.gridBand53
      });
      this.Add4.Name = "Add4";
      this.Add4.VisibleIndex = 18;
      this.Add4.Width = 150;
      this.gridBand52.Caption = "Thực cân";
      this.gridBand52.Columns.Add(this.gcPV_ADD_4);
      this.gridBand52.Name = "gridBand52";
      this.gridBand52.VisibleIndex = 0;
      this.gridBand52.Width = 75;
      this.gridBand53.Caption = "Thực cân tay";
      this.gridBand53.Columns.Add(this.gcPV_Add4_Manual);
      this.gridBand53.Name = "gridBand53";
      this.gridBand53.VisibleIndex = 1;
      this.gridBand53.Width = 75;
      this.Add5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Add5.AppearanceHeader.Options.UseFont = true;
      this.Add5.AppearanceHeader.Options.UseTextOptions = true;
      this.Add5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add5.Caption = "ADD5";
      this.Add5.Children.AddRange(new GridBand[2]
      {
        this.gridBand55,
        this.gridBand56
      });
      this.Add5.Name = "Add5";
      this.Add5.VisibleIndex = 19;
      this.Add5.Width = 150;
      this.gridBand55.Caption = "Thực cân";
      this.gridBand55.Columns.Add(this.gcPV_ADD_5);
      this.gridBand55.Name = "gridBand55";
      this.gridBand55.VisibleIndex = 0;
      this.gridBand55.Width = 75;
      this.gridBand56.Caption = "Thực cân tay";
      this.gridBand56.Columns.Add(this.gcPV_Add5_Manual);
      this.gridBand56.Name = "gridBand56";
      this.gridBand56.VisibleIndex = 1;
      this.gridBand56.Width = 75;
      this.Add6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.Add6.AppearanceHeader.Options.UseFont = true;
      this.Add6.AppearanceHeader.Options.UseTextOptions = true;
      this.Add6.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.Add6.Caption = "ADD6";
      this.Add6.Children.AddRange(new GridBand[2]
      {
        this.gridBand58,
        this.gridBand59
      });
      this.Add6.Name = "Add6";
      this.Add6.VisibleIndex = 20;
      this.Add6.Width = 150;
      this.gridBand58.Caption = "Thực cân";
      this.gridBand58.Columns.Add(this.gcPV_ADD_6);
      this.gridBand58.Name = "gridBand58";
      this.gridBand58.VisibleIndex = 0;
      this.gridBand58.Width = 75;
      this.gridBand59.Caption = "Thực cân tay";
      this.gridBand59.Columns.Add(this.gcPV_Add6_Manual);
      this.gridBand59.Name = "gridBand59";
      this.gridBand59.VisibleIndex = 1;
      this.gridBand59.Width = 75;
      this.groupControl3.Controls.Add((Control)this.spin_numberOfCopies);
      this.groupControl3.Controls.Add((Control)this.label1);
      this.groupControl3.Controls.Add((Control)this.btnInPCT);
      this.groupControl3.Controls.Add((Control)this.btnPrint);
      this.groupControl3.Location = new Point(3, 590);
      this.groupControl3.Name = "groupControl3";
      this.groupControl3.Size = new Size(328, 125);
      this.groupControl3.TabIndex = 10;
      this.groupControl3.Text = "Tác vụ";
      this.spin_numberOfCopies.EditValue = (object)new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.spin_numberOfCopies.Location = new Point(114, 38);
      this.spin_numberOfCopies.Name = "spin_numberOfCopies";
      this.spin_numberOfCopies.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spin_numberOfCopies.Properties.Appearance.Options.UseFont = true;
      this.spin_numberOfCopies.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spin_numberOfCopies.Properties.DisplayFormat.FormatString = "n0";
      this.spin_numberOfCopies.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spin_numberOfCopies.Properties.EditFormat.FormatString = "n0";
      this.spin_numberOfCopies.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spin_numberOfCopies.Properties.Mask.EditMask = "n0";
      this.spin_numberOfCopies.Properties.MaxValue = new Decimal(new int[4]
      {
        5,
        0,
        0,
        0
      });
      this.spin_numberOfCopies.Properties.MinValue = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.spin_numberOfCopies.Size = new Size(184, 22);
      this.spin_numberOfCopies.TabIndex = 81;
      this.spin_numberOfCopies.EditValueChanged += new EventHandler(this.spin_numberOfCopies_EditValueChanged);
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.label1.Location = new Point(31, 41);
      this.label1.Name = "label1";
      this.label1.Size = new Size(66, 16);
      this.label1.TabIndex = 80;
      this.label1.Text = "Số bản in:";
      this.btnInPCT.AllowFocus = false;
      this.btnInPCT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.btnInPCT.Appearance.Options.UseFont = true;
      this.btnInPCT.BackgroundImageLayout = ImageLayout.None;
      this.btnInPCT.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.btnInPCT.ImageOptions.Image = (Image)ResourceNhua.printer;
      this.btnInPCT.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
      this.btnInPCT.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.btnInPCT.Location = new Point(108, 69);
      this.btnInPCT.Name = "btnInPCT";
      this.btnInPCT.Size = new Size(120, 45);
      this.btnInPCT.TabIndex = 75;
      this.btnInPCT.Text = "In Phiếu";
      this.btnInPCT.Click += new EventHandler(this.btnInPCT_Click);
      this.btnPrint.AllowFocus = false;
      this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.btnPrint.Appearance.Options.UseFont = true;
      this.btnPrint.BackgroundImageLayout = ImageLayout.None;
      this.btnPrint.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.btnPrint.ImageOptions.Image = (Image)ResourceNhua.printer;
      this.btnPrint.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
      this.btnPrint.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.btnPrint.Location = new Point(197, 69);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new Size(120, 45);
      this.btnPrint.TabIndex = 74;
      this.btnPrint.Text = "Phiếu PDF";
      this.btnPrint.Visible = false;
      this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
      this.groupControl5.Controls.Add((Control)this.grcTotalMaterial);
      this.groupControl5.Location = new Point(337, 590);
      this.groupControl5.Name = "groupControl5";
      this.groupControl5.Size = new Size(804, (int)sbyte.MaxValue);
      this.groupControl5.TabIndex = 11;
      this.groupControl5.Text = "Tổng vật tư xe trộn";
      this.grcTotalMaterial.Dock = DockStyle.Fill;
      this.grcTotalMaterial.Location = new Point(2, 23);
      this.grcTotalMaterial.MainView = (BaseView)this.bandedGridView2;
      this.grcTotalMaterial.Name = "grcTotalMaterial";
      this.grcTotalMaterial.Size = new Size(800, 102);
      this.grcTotalMaterial.TabIndex = 0;
      this.grcTotalMaterial.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.bandedGridView2
      });
      this.bandedGridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.bandedGridView2.Appearance.Row.Options.UseFont = true;
      this.bandedGridView2.Bands.AddRange(new GridBand[20]
      {
        this.Total_Agg1,
        this.Total_Agg2,
        this.Total_Agg3,
        this.Total_Agg4,
        this.Total_Agg5,
        this.Total_Agg6,
        this.Total_Ce1,
        this.Total_Ce2,
        this.Total_Ce3,
        this.Total_Ce4,
        this.Total_Ce5,
        this.Total_Wa1,
        this.Total_Wa2,
        this.Total_Add1,
        this.Total_Add2,
        this.Total_Add3,
        this.Total_Add4,
        this.Total_Add5,
        this.Total_Add6,
        this.gridBand60
      });
      this.bandedGridView2.Columns.AddRange(new BandedGridColumn[19]
      {
        this.gcTotal_Agg1,
        this.gcTotal_Agg2,
        this.gcTotal_Agg3,
        this.gcTotal_Agg4,
        this.gcTotal_Agg5,
        this.gcTotal_Agg6,
        this.gcTotal_Ce1,
        this.gcTotal_Ce2,
        this.gcTotal_Ce3,
        this.gcTotal_Ce4,
        this.gcTotal_Ce5,
        this.gcTotal_Wa1,
        this.gcTotal_Wa2,
        this.gcTotal_Add1,
        this.gcTotal_Add2,
        this.gcTotal_Add3,
        this.gcTotal_Add4,
        this.gcTotal_Add5,
        this.gcTotal_Add6
      });
      this.bandedGridView2.GridControl = this.grcTotalMaterial;
      this.bandedGridView2.Name = "bandedGridView2";
      this.bandedGridView2.OptionsBehavior.ReadOnly = true;
      this.bandedGridView2.OptionsCustomization.AllowColumnMoving = false;
      this.bandedGridView2.OptionsView.ShowColumnHeaders = false;
      this.bandedGridView2.OptionsView.ShowFooter = true;
      this.bandedGridView2.OptionsView.ShowGroupPanel = false;
      this.Total_Agg1.Caption = "AGG1";
      this.Total_Agg1.Columns.Add(this.gcTotal_Agg1);
      this.Total_Agg1.MinWidth = 80;
      this.Total_Agg1.Name = "Total_Agg1";
      this.Total_Agg1.VisibleIndex = 0;
      this.Total_Agg1.Width = 80;
      this.Total_Agg2.Caption = "AGG2";
      this.Total_Agg2.Columns.Add(this.gcTotal_Agg2);
      this.Total_Agg2.MinWidth = 80;
      this.Total_Agg2.Name = "Total_Agg2";
      this.Total_Agg2.VisibleIndex = 1;
      this.Total_Agg2.Width = 80;
      this.Total_Agg3.Caption = "AGG3";
      this.Total_Agg3.Columns.Add(this.gcTotal_Agg3);
      this.Total_Agg3.MinWidth = 80;
      this.Total_Agg3.Name = "Total_Agg3";
      this.Total_Agg3.VisibleIndex = 2;
      this.Total_Agg3.Width = 80;
      this.Total_Agg4.Caption = "AGG4";
      this.Total_Agg4.Columns.Add(this.gcTotal_Agg4);
      this.Total_Agg4.MinWidth = 80;
      this.Total_Agg4.Name = "Total_Agg4";
      this.Total_Agg4.VisibleIndex = 3;
      this.Total_Agg4.Width = 80;
      this.Total_Agg5.Caption = "AGG5";
      this.Total_Agg5.Columns.Add(this.gcTotal_Agg5);
      this.Total_Agg5.MinWidth = 80;
      this.Total_Agg5.Name = "Total_Agg5";
      this.Total_Agg5.VisibleIndex = 4;
      this.Total_Agg5.Width = 80;
      this.Total_Agg6.Caption = "AGG6";
      this.Total_Agg6.Columns.Add(this.gcTotal_Agg6);
      this.Total_Agg6.MinWidth = 80;
      this.Total_Agg6.Name = "Total_Agg6";
      this.Total_Agg6.VisibleIndex = 5;
      this.Total_Agg6.Width = 80;
      this.Total_Ce1.Caption = "CE1";
      this.Total_Ce1.Columns.Add(this.gcTotal_Ce1);
      this.Total_Ce1.MinWidth = 80;
      this.Total_Ce1.Name = "Total_Ce1";
      this.Total_Ce1.VisibleIndex = 6;
      this.Total_Ce1.Width = 80;
      this.Total_Ce2.Caption = "CE2";
      this.Total_Ce2.Columns.Add(this.gcTotal_Ce2);
      this.Total_Ce2.MinWidth = 80;
      this.Total_Ce2.Name = "Total_Ce2";
      this.Total_Ce2.VisibleIndex = 7;
      this.Total_Ce2.Width = 80;
      this.Total_Ce3.Caption = "CE3";
      this.Total_Ce3.Columns.Add(this.gcTotal_Ce3);
      this.Total_Ce3.MinWidth = 80;
      this.Total_Ce3.Name = "Total_Ce3";
      this.Total_Ce3.VisibleIndex = 8;
      this.Total_Ce3.Width = 80;
      this.Total_Ce4.Caption = "CE4";
      this.Total_Ce4.Columns.Add(this.gcTotal_Ce4);
      this.Total_Ce4.MinWidth = 80;
      this.Total_Ce4.Name = "Total_Ce4";
      this.Total_Ce4.VisibleIndex = 9;
      this.Total_Ce4.Width = 80;
      this.Total_Ce5.Caption = "CE5";
      this.Total_Ce5.Columns.Add(this.gcTotal_Ce5);
      this.Total_Ce5.MinWidth = 80;
      this.Total_Ce5.Name = "Total_Ce5";
      this.Total_Ce5.VisibleIndex = 10;
      this.Total_Ce5.Width = 80;
      this.Total_Wa1.Caption = "WA1";
      this.Total_Wa1.Columns.Add(this.gcTotal_Wa1);
      this.Total_Wa1.MinWidth = 80;
      this.Total_Wa1.Name = "Total_Wa1";
      this.Total_Wa1.VisibleIndex = 11;
      this.Total_Wa1.Width = 80;
      this.Total_Wa2.Caption = "WA2";
      this.Total_Wa2.Columns.Add(this.gcTotal_Wa2);
      this.Total_Wa2.MinWidth = 80;
      this.Total_Wa2.Name = "Total_Wa2";
      this.Total_Wa2.VisibleIndex = 12;
      this.Total_Wa2.Width = 80;
      this.Total_Add1.Caption = "ADD1";
      this.Total_Add1.Columns.Add(this.gcTotal_Add1);
      this.Total_Add1.MinWidth = 80;
      this.Total_Add1.Name = "Total_Add1";
      this.Total_Add1.VisibleIndex = 13;
      this.Total_Add1.Width = 80;
      this.Total_Add2.Caption = "ADD2";
      this.Total_Add2.Columns.Add(this.gcTotal_Add2);
      this.Total_Add2.MinWidth = 80;
      this.Total_Add2.Name = "Total_Add2";
      this.Total_Add2.VisibleIndex = 14;
      this.Total_Add2.Width = 80;
      this.Total_Add3.Caption = "ADD3";
      this.Total_Add3.Columns.Add(this.gcTotal_Add3);
      this.Total_Add3.MinWidth = 80;
      this.Total_Add3.Name = "Total_Add3";
      this.Total_Add3.VisibleIndex = 15;
      this.Total_Add3.Width = 80;
      this.Total_Add4.Caption = "ADD4";
      this.Total_Add4.Columns.Add(this.gcTotal_Add4);
      this.Total_Add4.MinWidth = 80;
      this.Total_Add4.Name = "Total_Add4";
      this.Total_Add4.VisibleIndex = 16;
      this.Total_Add4.Width = 80;
      this.Total_Add5.Caption = "ADD5";
      this.Total_Add5.Columns.Add(this.gcTotal_Add5);
      this.Total_Add5.MinWidth = 80;
      this.Total_Add5.Name = "Total_Add5";
      this.Total_Add5.VisibleIndex = 17;
      this.Total_Add5.Width = 80;
      this.Total_Add6.Caption = "ADD6";
      this.Total_Add6.Columns.Add(this.gcTotal_Add6);
      this.Total_Add6.MinWidth = 80;
      this.Total_Add6.Name = "Total_Add6";
      this.Total_Add6.VisibleIndex = 18;
      this.Total_Add6.Width = 80;
      this.gridBand60.Caption = "gridBand60";
      this.gridBand60.Name = "gridBand60";
      this.gridBand60.Visible = false;
      this.gridBand60.VisibleIndex = -1;
      this.gcTotal_Agg1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Agg1.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Agg1.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Agg1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Agg1.Caption = "Total_PV_Agg1";
      this.gcTotal_Agg1.FieldName = "Total_PV_Agg1";
      this.gcTotal_Agg1.MinWidth = 70;
      this.gcTotal_Agg1.Name = "gcTotal_Agg1";
      this.gcTotal_Agg1.OptionsColumn.AllowFocus = false;
      this.gcTotal_Agg1.OptionsColumn.AllowMove = false;
      this.gcTotal_Agg1.OptionsColumn.ReadOnly = true;
      this.gcTotal_Agg1.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Agg1.Visible = true;
      this.gcTotal_Agg2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Agg2.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Agg2.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Agg2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Agg2.Caption = "Total_PV_Agg2";
      this.gcTotal_Agg2.FieldName = "Total_PV_Agg2";
      this.gcTotal_Agg2.MinWidth = 70;
      this.gcTotal_Agg2.Name = "gcTotal_Agg2";
      this.gcTotal_Agg2.OptionsColumn.AllowFocus = false;
      this.gcTotal_Agg2.OptionsColumn.AllowMove = false;
      this.gcTotal_Agg2.OptionsColumn.ReadOnly = true;
      this.gcTotal_Agg2.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Agg2.Visible = true;
      this.gcTotal_Agg3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Agg3.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Agg3.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Agg3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Agg3.Caption = "Total_PV_Agg3";
      this.gcTotal_Agg3.FieldName = "Total_PV_Agg3";
      this.gcTotal_Agg3.MinWidth = 70;
      this.gcTotal_Agg3.Name = "gcTotal_Agg3";
      this.gcTotal_Agg3.OptionsColumn.AllowFocus = false;
      this.gcTotal_Agg3.OptionsColumn.AllowMove = false;
      this.gcTotal_Agg3.OptionsColumn.ReadOnly = true;
      this.gcTotal_Agg3.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Agg3.Visible = true;
      this.gcTotal_Agg4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Agg4.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Agg4.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Agg4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Agg4.Caption = "Total_PV_Agg4";
      this.gcTotal_Agg4.FieldName = "Total_PV_Agg4";
      this.gcTotal_Agg4.MinWidth = 70;
      this.gcTotal_Agg4.Name = "gcTotal_Agg4";
      this.gcTotal_Agg4.OptionsColumn.AllowFocus = false;
      this.gcTotal_Agg4.OptionsColumn.AllowMove = false;
      this.gcTotal_Agg4.OptionsColumn.ReadOnly = true;
      this.gcTotal_Agg4.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Agg4.Visible = true;
      this.gcTotal_Agg5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Agg5.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Agg5.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Agg5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Agg5.Caption = "Total_PV_Agg5";
      this.gcTotal_Agg5.FieldName = "Total_PV_Agg5";
      this.gcTotal_Agg5.MinWidth = 70;
      this.gcTotal_Agg5.Name = "gcTotal_Agg5";
      this.gcTotal_Agg5.OptionsColumn.AllowFocus = false;
      this.gcTotal_Agg5.OptionsColumn.AllowMove = false;
      this.gcTotal_Agg5.OptionsColumn.ReadOnly = true;
      this.gcTotal_Agg5.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Agg5.Visible = true;
      this.gcTotal_Agg6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Agg6.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Agg6.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Agg6.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Agg6.Caption = "Total_PV_Agg6";
      this.gcTotal_Agg6.FieldName = "Total_PV_Agg6";
      this.gcTotal_Agg6.MinWidth = 70;
      this.gcTotal_Agg6.Name = "gcTotal_Agg6";
      this.gcTotal_Agg6.OptionsColumn.AllowFocus = false;
      this.gcTotal_Agg6.OptionsColumn.AllowMove = false;
      this.gcTotal_Agg6.OptionsColumn.ReadOnly = true;
      this.gcTotal_Agg6.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Agg6.Visible = true;
      this.gcTotal_Ce1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Ce1.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Ce1.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Ce1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Ce1.Caption = "Total_PV_Ce1";
      this.gcTotal_Ce1.FieldName = "Total_PV_Ce1";
      this.gcTotal_Ce1.MinWidth = 70;
      this.gcTotal_Ce1.Name = "gcTotal_Ce1";
      this.gcTotal_Ce1.OptionsColumn.AllowFocus = false;
      this.gcTotal_Ce1.OptionsColumn.AllowMove = false;
      this.gcTotal_Ce1.OptionsColumn.ReadOnly = true;
      this.gcTotal_Ce1.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Ce1.Visible = true;
      this.gcTotal_Ce2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Ce2.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Ce2.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Ce2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Ce2.Caption = "Total_PV_Ce2";
      this.gcTotal_Ce2.FieldName = "Total_PV_Ce2";
      this.gcTotal_Ce2.MinWidth = 70;
      this.gcTotal_Ce2.Name = "gcTotal_Ce2";
      this.gcTotal_Ce2.OptionsColumn.AllowFocus = false;
      this.gcTotal_Ce2.OptionsColumn.AllowMove = false;
      this.gcTotal_Ce2.OptionsColumn.ReadOnly = true;
      this.gcTotal_Ce2.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Ce2.Visible = true;
      this.gcTotal_Ce3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Ce3.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Ce3.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Ce3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Ce3.Caption = "Total_PV_Ce3";
      this.gcTotal_Ce3.FieldName = "Total_PV_Ce3";
      this.gcTotal_Ce3.MinWidth = 70;
      this.gcTotal_Ce3.Name = "gcTotal_Ce3";
      this.gcTotal_Ce3.OptionsColumn.AllowFocus = false;
      this.gcTotal_Ce3.OptionsColumn.AllowMove = false;
      this.gcTotal_Ce3.OptionsColumn.ReadOnly = true;
      this.gcTotal_Ce3.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Ce3.Visible = true;
      this.gcTotal_Ce4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Ce4.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Ce4.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Ce4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Ce4.Caption = "Total_PV_Ce4";
      this.gcTotal_Ce4.FieldName = "Total_PV_Ce4";
      this.gcTotal_Ce4.MinWidth = 70;
      this.gcTotal_Ce4.Name = "gcTotal_Ce4";
      this.gcTotal_Ce4.OptionsColumn.AllowFocus = false;
      this.gcTotal_Ce4.OptionsColumn.AllowMove = false;
      this.gcTotal_Ce4.OptionsColumn.ReadOnly = true;
      this.gcTotal_Ce4.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Ce4.Visible = true;
      this.gcTotal_Ce5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Ce5.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Ce5.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Ce5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Ce5.Caption = "Total_PV_Ce5";
      this.gcTotal_Ce5.FieldName = "Total_PV_Ce5";
      this.gcTotal_Ce5.MinWidth = 70;
      this.gcTotal_Ce5.Name = "gcTotal_Ce5";
      this.gcTotal_Ce5.OptionsColumn.AllowFocus = false;
      this.gcTotal_Ce5.OptionsColumn.AllowMove = false;
      this.gcTotal_Ce5.OptionsColumn.ReadOnly = true;
      this.gcTotal_Ce5.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Ce5.Visible = true;
      this.gcTotal_Wa1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Wa1.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Wa1.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Wa1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Wa1.Caption = "Total_PV_Wa1";
      this.gcTotal_Wa1.FieldName = "Total_PV_Wa1";
      this.gcTotal_Wa1.MinWidth = 70;
      this.gcTotal_Wa1.Name = "gcTotal_Wa1";
      this.gcTotal_Wa1.OptionsColumn.AllowFocus = false;
      this.gcTotal_Wa1.OptionsColumn.AllowMove = false;
      this.gcTotal_Wa1.OptionsColumn.ReadOnly = true;
      this.gcTotal_Wa1.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Wa1.Visible = true;
      this.gcTotal_Wa2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Wa2.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Wa2.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Wa2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Wa2.Caption = "Total_PV_Wa2";
      this.gcTotal_Wa2.FieldName = "Total_PV_Wa2";
      this.gcTotal_Wa2.MinWidth = 70;
      this.gcTotal_Wa2.Name = "gcTotal_Wa2";
      this.gcTotal_Wa2.OptionsColumn.AllowFocus = false;
      this.gcTotal_Wa2.OptionsColumn.AllowMove = false;
      this.gcTotal_Wa2.OptionsColumn.ReadOnly = true;
      this.gcTotal_Wa2.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Wa2.Visible = true;
      this.gcTotal_Add1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Add1.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Add1.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Add1.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Add1.Caption = "Total_PV_Add1";
      this.gcTotal_Add1.FieldName = "Total_PV_Add1";
      this.gcTotal_Add1.MinWidth = 70;
      this.gcTotal_Add1.Name = "gcTotal_Add1";
      this.gcTotal_Add1.OptionsColumn.AllowFocus = false;
      this.gcTotal_Add1.OptionsColumn.AllowMove = false;
      this.gcTotal_Add1.OptionsColumn.ReadOnly = true;
      this.gcTotal_Add1.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Add1.Visible = true;
      this.gcTotal_Add2.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Add2.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Add2.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Add2.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Add2.Caption = "Total_PV_Add2";
      this.gcTotal_Add2.FieldName = "Total_PV_Add2";
      this.gcTotal_Add2.MinWidth = 70;
      this.gcTotal_Add2.Name = "gcTotal_Add2";
      this.gcTotal_Add2.OptionsColumn.AllowFocus = false;
      this.gcTotal_Add2.OptionsColumn.AllowMove = false;
      this.gcTotal_Add2.OptionsColumn.ReadOnly = true;
      this.gcTotal_Add2.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Add2.Visible = true;
      this.gcTotal_Add3.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Add3.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Add3.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Add3.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Add3.Caption = "Total_PV_Add3";
      this.gcTotal_Add3.FieldName = "Total_PV_Add3";
      this.gcTotal_Add3.MinWidth = 70;
      this.gcTotal_Add3.Name = "gcTotal_Add3";
      this.gcTotal_Add3.OptionsColumn.AllowFocus = false;
      this.gcTotal_Add3.OptionsColumn.AllowMove = false;
      this.gcTotal_Add3.OptionsColumn.ReadOnly = true;
      this.gcTotal_Add3.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Add3.Visible = true;
      this.gcTotal_Add4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Add4.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Add4.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Add4.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Add4.Caption = "Total_PV_Add4";
      this.gcTotal_Add4.FieldName = "Total_PV_Add4";
      this.gcTotal_Add4.MinWidth = 70;
      this.gcTotal_Add4.Name = "gcTotal_Add4";
      this.gcTotal_Add4.OptionsColumn.AllowFocus = false;
      this.gcTotal_Add4.OptionsColumn.AllowMove = false;
      this.gcTotal_Add4.OptionsColumn.ReadOnly = true;
      this.gcTotal_Add4.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Add4.Visible = true;
      this.gcTotal_Add5.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Add5.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Add5.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Add5.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Add5.Caption = "Total_PV_Add5";
      this.gcTotal_Add5.FieldName = "Total_PV_Add5";
      this.gcTotal_Add5.MinWidth = 70;
      this.gcTotal_Add5.Name = "gcTotal_Add5";
      this.gcTotal_Add5.OptionsColumn.AllowFocus = false;
      this.gcTotal_Add5.OptionsColumn.AllowMove = false;
      this.gcTotal_Add5.OptionsColumn.ReadOnly = true;
      this.gcTotal_Add5.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Add5.Visible = true;
      this.gcTotal_Add6.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold);
      this.gcTotal_Add6.AppearanceHeader.Options.UseFont = true;
      this.gcTotal_Add6.AppearanceHeader.Options.UseTextOptions = true;
      this.gcTotal_Add6.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
      this.gcTotal_Add6.Caption = "Total_PV_Add6";
      this.gcTotal_Add6.FieldName = "Total_PV_Add6";
      this.gcTotal_Add6.MinWidth = 70;
      this.gcTotal_Add6.Name = "gcTotal_Add6";
      this.gcTotal_Add6.OptionsColumn.AllowFocus = false;
      this.gcTotal_Add6.OptionsColumn.AllowMove = false;
      this.gcTotal_Add6.OptionsColumn.ReadOnly = true;
      this.gcTotal_Add6.OptionsFilter.AllowAutoFilter = false;
      this.gcTotal_Add6.Visible = true;
      this.gcNL.Caption = "N.L";
      this.gcNL.FieldName = "LnNo";
      this.gcNL.MinWidth = 40;
      this.gcNL.Name = "gcNL";
      this.gcNL.OptionsColumn.AllowFocus = false;
      this.gcNL.OptionsColumn.ReadOnly = true;
      this.gcNL.Visible = true;
      this.gcNL.Width = 70;
      this.gcTheTich.Caption = "Thể tích";
      this.gcTheTich.FieldName = "KLTungMe";
      this.gcTheTich.MinWidth = 40;
      this.gcTheTich.Name = "gcTheTich";
      this.gcTheTich.OptionsColumn.AllowFocus = false;
      this.gcTheTich.OptionsColumn.ReadOnly = true;
      this.gcTheTich.Visible = true;
      this.gcTheTich.Width = 70;
      this.gcPV_Agg_1.Caption = "PV_Agg1";
      this.gcPV_Agg_1.FieldName = "PV_Agg1";
      this.gcPV_Agg_1.MinWidth = 50;
      this.gcPV_Agg_1.Name = "gcPV_Agg_1";
      this.gcPV_Agg_1.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg_1.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg_1.Visible = true;
      this.gcPV_Agg1_Manual.Caption = "PV_Agg1_Manual";
      this.gcPV_Agg1_Manual.FieldName = "PV_Agg1_Manual";
      this.gcPV_Agg1_Manual.MinWidth = 50;
      this.gcPV_Agg1_Manual.Name = "gcPV_Agg1_Manual";
      this.gcPV_Agg1_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg1_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg1_Manual.Visible = true;
      this.gcPV_Agg_2.Caption = "PV_Agg2";
      this.gcPV_Agg_2.FieldName = "PV_Agg2";
      this.gcPV_Agg_2.MinWidth = 50;
      this.gcPV_Agg_2.Name = "gcPV_Agg_2";
      this.gcPV_Agg_2.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg_2.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg_2.Visible = true;
      this.gcPV_Agg2_Manual.Caption = "PV_Agg2_Manual";
      this.gcPV_Agg2_Manual.FieldName = "PV_Agg2_Manual";
      this.gcPV_Agg2_Manual.MinWidth = 50;
      this.gcPV_Agg2_Manual.Name = "gcPV_Agg2_Manual";
      this.gcPV_Agg2_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg2_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg2_Manual.Visible = true;
      this.gcPV_Agg_3.Caption = "PV_Agg3";
      this.gcPV_Agg_3.FieldName = "PV_Agg3";
      this.gcPV_Agg_3.MinWidth = 50;
      this.gcPV_Agg_3.Name = "gcPV_Agg_3";
      this.gcPV_Agg_3.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg_3.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg_3.Visible = true;
      this.gcPV_Agg3_Manual.Caption = "PV_Agg3_Manual";
      this.gcPV_Agg3_Manual.FieldName = "PV_Agg3_Manual";
      this.gcPV_Agg3_Manual.MinWidth = 50;
      this.gcPV_Agg3_Manual.Name = "gcPV_Agg3_Manual";
      this.gcPV_Agg3_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg3_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg3_Manual.Visible = true;
      this.gcPV_Agg_4.Caption = "PV_Agg4";
      this.gcPV_Agg_4.FieldName = "PV_Agg4";
      this.gcPV_Agg_4.MinWidth = 50;
      this.gcPV_Agg_4.Name = "gcPV_Agg_4";
      this.gcPV_Agg_4.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg_4.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg_4.Visible = true;
      this.gcPV_Agg4_Manual.Caption = "PV_Agg4_Manual";
      this.gcPV_Agg4_Manual.FieldName = "PV_Agg4_Manual";
      this.gcPV_Agg4_Manual.MinWidth = 50;
      this.gcPV_Agg4_Manual.Name = "gcPV_Agg4_Manual";
      this.gcPV_Agg4_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg4_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg4_Manual.Visible = true;
      this.gcPV_Agg_5.Caption = "PV_Agg5";
      this.gcPV_Agg_5.FieldName = "PV_Agg5";
      this.gcPV_Agg_5.MinWidth = 50;
      this.gcPV_Agg_5.Name = "gcPV_Agg_5";
      this.gcPV_Agg_5.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg_5.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg_5.Visible = true;
      this.gcPV_Agg5_Manual.Caption = "PV_Agg5_Manual";
      this.gcPV_Agg5_Manual.FieldName = "PV_Agg5_Manual";
      this.gcPV_Agg5_Manual.MinWidth = 50;
      this.gcPV_Agg5_Manual.Name = "gcPV_Agg5_Manual";
      this.gcPV_Agg5_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg5_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg5_Manual.Visible = true;
      this.gcPV_Agg_6.Caption = "PV_Agg6";
      this.gcPV_Agg_6.FieldName = "PV_Agg6";
      this.gcPV_Agg_6.MinWidth = 50;
      this.gcPV_Agg_6.Name = "gcPV_Agg_6";
      this.gcPV_Agg_6.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg_6.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg_6.Visible = true;
      this.gcPV_Agg6_Manual.Caption = "PV_Agg6_Manual";
      this.gcPV_Agg6_Manual.FieldName = "PV_Agg6_Manual";
      this.gcPV_Agg6_Manual.MinWidth = 50;
      this.gcPV_Agg6_Manual.Name = "gcPV_Agg6_Manual";
      this.gcPV_Agg6_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Agg6_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Agg6_Manual.Visible = true;
      this.gcPV_Ce_1.Caption = "PV_Ce1";
      this.gcPV_Ce_1.FieldName = "PV_Ce1";
      this.gcPV_Ce_1.MinWidth = 50;
      this.gcPV_Ce_1.Name = "gcPV_Ce_1";
      this.gcPV_Ce_1.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce_1.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce_1.Visible = true;
      this.gcPV_Ce1_Manual.Caption = "PV_Ce1_Manual";
      this.gcPV_Ce1_Manual.FieldName = "PV_Ce1_Manual";
      this.gcPV_Ce1_Manual.MinWidth = 50;
      this.gcPV_Ce1_Manual.Name = "gcPV_Ce1_Manual";
      this.gcPV_Ce1_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce1_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce1_Manual.Visible = true;
      this.gcPV_Ce_2.Caption = "PV_Ce2";
      this.gcPV_Ce_2.FieldName = "PV_Ce2";
      this.gcPV_Ce_2.MinWidth = 50;
      this.gcPV_Ce_2.Name = "gcPV_Ce_2";
      this.gcPV_Ce_2.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce_2.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce_2.Visible = true;
      this.gcPV_Ce2_Manual.Caption = "PV_Ce2_Manual";
      this.gcPV_Ce2_Manual.FieldName = "PV_Ce2_Manual";
      this.gcPV_Ce2_Manual.MinWidth = 50;
      this.gcPV_Ce2_Manual.Name = "gcPV_Ce2_Manual";
      this.gcPV_Ce2_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce2_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce2_Manual.Visible = true;
      this.gcPV_Ce_3.Caption = "PV_Ce3";
      this.gcPV_Ce_3.FieldName = "PV_Ce3";
      this.gcPV_Ce_3.MinWidth = 50;
      this.gcPV_Ce_3.Name = "gcPV_Ce_3";
      this.gcPV_Ce_3.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce_3.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce_3.Visible = true;
      this.gcPV_Ce3_Manual.Caption = "PV_Ce3_Manual";
      this.gcPV_Ce3_Manual.FieldName = "PV_Ce3_Manual";
      this.gcPV_Ce3_Manual.MinWidth = 50;
      this.gcPV_Ce3_Manual.Name = "gcPV_Ce3_Manual";
      this.gcPV_Ce3_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce3_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce3_Manual.Visible = true;
      this.gcPV_Ce_4.Caption = "PV_Ce4";
      this.gcPV_Ce_4.FieldName = "PV_Ce4";
      this.gcPV_Ce_4.MinWidth = 50;
      this.gcPV_Ce_4.Name = "gcPV_Ce_4";
      this.gcPV_Ce_4.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce_4.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce_4.Visible = true;
      this.gcPV_Ce4_Manual.Caption = "PV_Ce4_Manual";
      this.gcPV_Ce4_Manual.FieldName = "PV_Ce4_Manual";
      this.gcPV_Ce4_Manual.MinWidth = 50;
      this.gcPV_Ce4_Manual.Name = "gcPV_Ce4_Manual";
      this.gcPV_Ce4_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce4_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce4_Manual.Visible = true;
      this.gcPV_Ce_5.Caption = "PV_Ce5";
      this.gcPV_Ce_5.FieldName = "PV_Ce5";
      this.gcPV_Ce_5.MinWidth = 50;
      this.gcPV_Ce_5.Name = "gcPV_Ce_5";
      this.gcPV_Ce_5.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce_5.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce_5.Visible = true;
      this.gcPV_Ce5_Manual.Caption = "PV_Ce5_Manual";
      this.gcPV_Ce5_Manual.FieldName = "PV_Ce5_Manual";
      this.gcPV_Ce5_Manual.MinWidth = 50;
      this.gcPV_Ce5_Manual.Name = "gcPV_Ce5_Manual";
      this.gcPV_Ce5_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Ce5_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Ce5_Manual.Visible = true;
      this.gcPV_Wa_1.Caption = "PV_Wa1";
      this.gcPV_Wa_1.FieldName = "PV_Wa1";
      this.gcPV_Wa_1.MinWidth = 50;
      this.gcPV_Wa_1.Name = "gcPV_Wa_1";
      this.gcPV_Wa_1.OptionsColumn.AllowFocus = false;
      this.gcPV_Wa_1.OptionsColumn.ReadOnly = true;
      this.gcPV_Wa_1.Visible = true;
      this.gcPV_Wa1_Manual.Caption = "PV_Wa1_Manual";
      this.gcPV_Wa1_Manual.FieldName = "PV_Wa1_Manual";
      this.gcPV_Wa1_Manual.MinWidth = 50;
      this.gcPV_Wa1_Manual.Name = "gcPV_Wa1_Manual";
      this.gcPV_Wa1_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Wa1_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Wa1_Manual.Visible = true;
      this.gcPV_Wa_2.Caption = "PV_Wa2";
      this.gcPV_Wa_2.FieldName = "PV_Wa2";
      this.gcPV_Wa_2.MinWidth = 50;
      this.gcPV_Wa_2.Name = "gcPV_Wa_2";
      this.gcPV_Wa_2.OptionsColumn.AllowFocus = false;
      this.gcPV_Wa_2.OptionsColumn.ReadOnly = true;
      this.gcPV_Wa_2.Visible = true;
      this.gcPV_Wa2_Manual.Caption = "PV_Wa2_Manual";
      this.gcPV_Wa2_Manual.FieldName = "PV_Wa2_Manual";
      this.gcPV_Wa2_Manual.MinWidth = 50;
      this.gcPV_Wa2_Manual.Name = "gcPV_Wa2_Manual";
      this.gcPV_Wa2_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Wa2_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Wa2_Manual.Visible = true;
      this.gcPV_ADD_1.Caption = "PV_Add1";
      this.gcPV_ADD_1.FieldName = "PV_Add1";
      this.gcPV_ADD_1.MinWidth = 50;
      this.gcPV_ADD_1.Name = "gcPV_ADD_1";
      this.gcPV_ADD_1.OptionsColumn.AllowFocus = false;
      this.gcPV_ADD_1.OptionsColumn.ReadOnly = true;
      this.gcPV_ADD_1.Visible = true;
      this.gcPV_Add1_Manual.Caption = "PV_Add1_Manual";
      this.gcPV_Add1_Manual.FieldName = "PV_Add1_Manual";
      this.gcPV_Add1_Manual.MinWidth = 50;
      this.gcPV_Add1_Manual.Name = "gcPV_Add1_Manual";
      this.gcPV_Add1_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Add1_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Add1_Manual.Visible = true;
      this.gcPV_ADD_2.Caption = "PV_Add2";
      this.gcPV_ADD_2.FieldName = "PV_Add2";
      this.gcPV_ADD_2.MinWidth = 50;
      this.gcPV_ADD_2.Name = "gcPV_ADD_2";
      this.gcPV_ADD_2.OptionsColumn.AllowFocus = false;
      this.gcPV_ADD_2.OptionsColumn.ReadOnly = true;
      this.gcPV_ADD_2.Visible = true;
      this.gcPV_Add2_Manual.Caption = "PV_Add2_Manual";
      this.gcPV_Add2_Manual.FieldName = "PV_Add2_Manual";
      this.gcPV_Add2_Manual.MinWidth = 50;
      this.gcPV_Add2_Manual.Name = "gcPV_Add2_Manual";
      this.gcPV_Add2_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Add2_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Add2_Manual.Visible = true;
      this.gcPV_ADD_3.Caption = "PV_Add3";
      this.gcPV_ADD_3.FieldName = "PV_Add3";
      this.gcPV_ADD_3.MinWidth = 50;
      this.gcPV_ADD_3.Name = "gcPV_ADD_3";
      this.gcPV_ADD_3.OptionsColumn.AllowFocus = false;
      this.gcPV_ADD_3.OptionsColumn.ReadOnly = true;
      this.gcPV_ADD_3.Visible = true;
      this.gcPV_Add3_Manual.Caption = "PV_Add3_Manual";
      this.gcPV_Add3_Manual.FieldName = "PV_Add3_Manual";
      this.gcPV_Add3_Manual.MinWidth = 50;
      this.gcPV_Add3_Manual.Name = "gcPV_Add3_Manual";
      this.gcPV_Add3_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Add3_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Add3_Manual.Visible = true;
      this.gcPV_ADD_4.Caption = "PV_Add4";
      this.gcPV_ADD_4.FieldName = "PV_Add4";
      this.gcPV_ADD_4.MinWidth = 50;
      this.gcPV_ADD_4.Name = "gcPV_ADD_4";
      this.gcPV_ADD_4.OptionsColumn.AllowFocus = false;
      this.gcPV_ADD_4.OptionsColumn.ReadOnly = true;
      this.gcPV_ADD_4.Visible = true;
      this.gcPV_Add4_Manual.Caption = "PV_Add4_Manual";
      this.gcPV_Add4_Manual.FieldName = "PV_Add4_Manual";
      this.gcPV_Add4_Manual.MinWidth = 50;
      this.gcPV_Add4_Manual.Name = "gcPV_Add4_Manual";
      this.gcPV_Add4_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Add4_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Add4_Manual.Visible = true;
      this.gcPV_ADD_5.Caption = "PV_Add5";
      this.gcPV_ADD_5.FieldName = "PV_Add5";
      this.gcPV_ADD_5.MinWidth = 50;
      this.gcPV_ADD_5.Name = "gcPV_ADD_5";
      this.gcPV_ADD_5.OptionsColumn.AllowFocus = false;
      this.gcPV_ADD_5.OptionsColumn.ReadOnly = true;
      this.gcPV_ADD_5.Visible = true;
      this.gcPV_Add5_Manual.Caption = "PV_Add5_Manual";
      this.gcPV_Add5_Manual.FieldName = "PV_Add5_Manual";
      this.gcPV_Add5_Manual.MinWidth = 50;
      this.gcPV_Add5_Manual.Name = "gcPV_Add5_Manual";
      this.gcPV_Add5_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Add5_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Add5_Manual.Visible = true;
      this.gcPV_ADD_6.Caption = "PV_Add6";
      this.gcPV_ADD_6.FieldName = "PV_Add6";
      this.gcPV_ADD_6.MinWidth = 50;
      this.gcPV_ADD_6.Name = "gcPV_ADD_6";
      this.gcPV_ADD_6.OptionsColumn.AllowFocus = false;
      this.gcPV_ADD_6.OptionsColumn.ReadOnly = true;
      this.gcPV_ADD_6.Visible = true;
      this.gcPV_Add6_Manual.Caption = "PV_Add6_Manual";
      this.gcPV_Add6_Manual.FieldName = "PV_Add6_Manual";
      this.gcPV_Add6_Manual.MinWidth = 50;
      this.gcPV_Add6_Manual.Name = "gcPV_Add6_Manual";
      this.gcPV_Add6_Manual.OptionsColumn.AllowFocus = false;
      this.gcPV_Add6_Manual.OptionsColumn.ReadOnly = true;
      this.gcPV_Add6_Manual.Visible = true;
      this.gcMaPhieuTron.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.gcMaPhieuTron.AppearanceCell.Options.UseFont = true;
      this.gcMaPhieuTron.Caption = "Mã Phiếu";
      this.gcMaPhieuTron.FieldName = "MaPhieuTron";
      this.gcMaPhieuTron.Name = "gcMaPhieuTron";
      this.gcMaPhieuTron.OptionsColumn.AllowEdit = false;
      this.gcMaPhieuTron.OptionsColumn.AllowFocus = false;
      this.gcMaPhieuTron.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Count, "MaPhieuTron", "{0}")
      });
      this.gcMaPhieuTron.Visible = true;
      this.gcMaPhieuTron.VisibleIndex = 0;
      this.gcNgayPhieuTron.Caption = "Ngày Tạo Phiếu";
      this.gcNgayPhieuTron.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
      this.gcNgayPhieuTron.DisplayFormat.FormatType = FormatType.DateTime;
      this.gcNgayPhieuTron.FieldName = "NgayPhieuTron";
      this.gcNgayPhieuTron.Name = "gcNgayPhieuTron";
      this.gcNgayPhieuTron.OptionsColumn.AllowEdit = false;
      this.gcNgayPhieuTron.OptionsColumn.AllowFocus = false;
      this.gcNgayPhieuTron.Visible = true;
      this.gcNgayPhieuTron.VisibleIndex = 1;
      this.gcViewMaHopDong.Caption = "Mã Hợp Đồng";
      this.gcViewMaHopDong.FieldName = "HopDongID";
      this.gcViewMaHopDong.Name = "gcViewMaHopDong";
      this.gcViewMaHopDong.OptionsColumn.AllowEdit = false;
      this.gcViewMaHopDong.OptionsColumn.AllowFocus = false;
      this.gridColumn3.Caption = "Tên Khách hàng";
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.OptionsColumn.AllowEdit = false;
      this.gridColumn3.OptionsColumn.AllowFocus = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.groupControl5);
      this.Controls.Add((Control)this.groupControl3);
      this.Controls.Add((Control)this.grChiTietMeTron);
      this.Controls.Add((Control)this.groupControl4);
      this.Controls.Add((Control)this.groupControl2);
      this.Controls.Add((Control)this.groupControl1);
      this.Name = "PrinterPheuTronChiTiet";
      this.Size = new Size(1144, 720);
      this.groupControl1.EndInit();
      this.tseToTime.Properties.EndInit();
      this.tseFromTime.Properties.EndInit();
      this.lookupEditPrinters.Properties.EndInit();
      this.datDenNgay.Properties.CalendarTimeProperties.EndInit();
      this.datDenNgay.Properties.EndInit();
      this.datTuNgay.Properties.CalendarTimeProperties.EndInit();
      this.datTuNgay.Properties.EndInit();
      this.groupControl2.EndInit();
      this.grcPhieuTron.EndInit();
      this.grvPhieuTron.EndInit();
      this.groupControl4.EndInit();
      this.txtGioKTTron.Properties.EndInit();
      this.txtSoPhieu.Properties.EndInit();
      this.datNgayTron.Properties.CalendarTimeProperties.EndInit();
      this.datNgayTron.Properties.EndInit();
      this.txtGioTron.Properties.EndInit();
      this.txtXe.Properties.EndInit();
      this.txtTaiXe.Properties.EndInit();
      this.txtHangMuc.Properties.EndInit();
      this.txtDiaDiem.Properties.EndInit();
      this.txtLuyKe.Properties.EndInit();
      this.txtKhoiLuongDatHang.Properties.EndInit();
      this.txtTheTich.Properties.EndInit();
      this.txtDoSut.Properties.EndInit();
      this.txtTenMAC.Properties.EndInit();
      this.txtNguoiTron.Properties.EndInit();
      this.txtNiemChi.Properties.EndInit();
      this.txtCuongDo.Properties.EndInit();
      this.txtTenCongTruong.Properties.EndInit();
      this.txtTenKhachHang.Properties.EndInit();
      this.txtMaPhieuTron.Properties.EndInit();
      this.grChiTietMeTron.EndInit();
      this.grcPhieuTronChiTiet.EndInit();
      this.bandedGridView1.EndInit();
      this.groupControl3.EndInit();
      this.spin_numberOfCopies.Properties.EndInit();
      this.groupControl5.EndInit();
      this.grcTotalMaterial.EndInit();
      this.bandedGridView2.EndInit();
      this.ResumeLayout(false);
    }
  }
}

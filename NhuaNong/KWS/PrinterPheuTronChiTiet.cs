// Decompiled with JetBrains decompiler
// Type: NhuaNong.KWS.PrinterPheuTronChiTiet
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

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
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.KWS
{
  public class PrinterPheuTronChiTiet : ControlViewBase, IPhieuTronMngView, IBase, IPermission
  {
    private PhieuTronMngDataPresenter _presenter;
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private BindingList<ObjPhieuTron> _blstPhieuTron = new BindingList<ObjPhieuTron>();
    private BindingList<ObjHopDong> _blstHopDong = new BindingList<ObjHopDong>();
    private BindingList<ObjMeTron> _blstMeTron = new BindingList<ObjMeTron>();
    private BindingList<ObjMeTronChiTiet> _blstMeTronChiTiet = new BindingList<ObjMeTronChiTiet>();
    private BindingList<Objvw_DataMix> _lstDataMix = new BindingList<Objvw_DataMix>();
    private int num_silo_Agg;
    private int num_silo_Ce;
    private int num_silo_Wa;
    private int num_silo_Add;
    private bool _error;
    private int userID;
    private List<string> _paramListTong = new List<string>();
    private string printerName;
    private int numberOfCopies;
    private DataTable dataTableNameMaterial;
    private DataTable dataTableSumMaterial;
    private DataTable _tablePTCT = new DataTable();
    private DataTable dataTableMaterial = new DataTable();
    private string head_Agg1;
    private string head_Agg2;
    private string head_Agg3;
    private string head_Agg4;
    private string head_Agg5;
    private string head_Agg6;
    private string head_Ce1;
    private string head_Ce2;
    private string head_Ce3;
    private string head_Ce4;
    private string head_Ce5;
    private string head_Wa1;
    private string head_Wa2;
    private string head_Add1;
    private string head_Add2;
    private string head_Add3;
    private string head_Add4;
    private string head_Add5;
    private string head_Add6;
    private Decimal sum_Agg1;
    private Decimal sum_Agg2;
    private Decimal sum_Agg3;
    private Decimal sum_Agg4;
    private Decimal sum_Agg5;
    private Decimal sum_Agg6;
    private Decimal sum_Ce1;
    private Decimal sum_Ce2;
    private Decimal sum_Ce3;
    private Decimal sum_Ce4;
    private Decimal sum_Ce5;
    private Decimal sum_Wa1;
    private Decimal sum_Wa2;
    private Decimal sum_Add1;
    private Decimal sum_Add2;
    private Decimal sum_Add3;
    private Decimal sum_Add4;
    private Decimal sum_Add5;
    private Decimal sum_Add6;
    private Decimal sum_KL;
    private Decimal sum_CP;
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

    public BindingList<ObjPhieuTron> BLstPhieuTron
    {
      set
      {
        this._blstPhieuTron = value;
        this.grcPhieuTron.DataSource = (object) this._blstPhieuTron;
      }
    }

    public BindingList<ObjHopDong> BLstHopDong
    {
      set => this._blstHopDong = value;
    }

    public BindingList<ObjMeTron> BLstMeTron
    {
      set => this._blstMeTron = value;
    }

    public BindingList<ObjMeTronChiTiet> BLstMeTronChiTiet
    {
      set => this._blstMeTronChiTiet = value;
    }

    public bool IsSuccessfulSaved
    {
      set => throw new NotImplementedException();
    }

    public List<FieldCode> LstPhieuTronStatus
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjPhieuGiaoHang> BLstPhieuGiaoHang
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjMeTronChiTietGiaoHang> BLstMeTronChiTietGiaoHang
    {
      set => throw new NotImplementedException();
    }

    public PrinterPheuTronChiTiet()
    {
      this.InitializeComponent();
      this._presenter = new PhieuTronMngDataPresenter((IPhieuTronMngView) this);
      this.Caption = "Phiếu chi tiết xe trộn";
    }

    private void ClearDataPhieuTron()
    {
      this.datNgayTron.EditValue = (object) "";
      this.txtGioTron.Text = "";
      this.txtGioKTTron.Text = "";
      this.txtMaPhieuTron.Text = string.Empty;
      this.txtSoPhieu.Text = string.Empty;
      this.txtTenMAC.Text = string.Empty;
      this.txtCuongDo.Text = string.Empty;
      this.txtDoSut.Text = string.Empty;
      this.txtTheTich.Text = string.Empty;
      this.txtKhoiLuongDatHang.Text = string.Empty;
      this.txtLuyKe.Text = string.Empty;
      this.txtTenKhachHang.Text = string.Empty;
      this.txtTenCongTruong.Text = string.Empty;
      this.txtDiaDiem.Text = string.Empty;
      this.txtNiemChi.Text = string.Empty;
      this.txtNguoiTron.Text = string.Empty;
      this.txtTaiXe.Text = string.Empty;
      this.txtXe.Text = string.Empty;
    }

    protected override void PopulateStaticData()
    {
      this.LoadSearchDefaultValues();
      this.printerName = ConfigManager.TramTronConfig.MayInPICT;
      this.num_silo_Agg = ConfigManager.TramTronConfig.SL_Silo_AGG;
      if (this.num_silo_Agg == 0)
        this.num_silo_Agg = 1;
      this.num_silo_Ce = ConfigManager.TramTronConfig.SL_Silo_CE;
      if (this.num_silo_Ce == 0)
        this.num_silo_Ce = 1;
      this.num_silo_Wa = ConfigManager.TramTronConfig.SL_Silo_WA;
      if (this.num_silo_Wa == 0)
        this.num_silo_Wa = 1;
      this.num_silo_Add = ConfigManager.TramTronConfig.SL_Silo_ADD;
      if (this.num_silo_Add != 0)
        return;
      this.num_silo_Add = 0;
    }

    protected override void PopulateData() => this.LoadPhieuTron();

    private void LoadSearchDefaultValues()
    {
      this.datTuNgay.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestPhieuTronDays);
      this.datDenNgay.EditValue = (object) DateTime.Now;
      DateTime dateTime = DateTime.Now;
      dateTime = dateTime.Date;
      this.tseToTime.EditValue = (object) dateTime.Add(new TimeSpan(23, 59, 59)).TimeOfDay;
    }

    private void DoFocusPhieuTron()
    {
      this.ClearDataPhieuTron();
      if (!(this.grvPhieuTron.GetRow(this.grvPhieuTron.FocusedRowHandle) is ObjPhieuTron row1))
        return;
      int phieuTronId = row1.PhieuTronID;
      int? nullable1 = new int?(row1.PhieuTronID);
      int num1 = 0;
      if (nullable1.GetValueOrDefault() == num1 & nullable1.HasValue)
        return;
      ObjPhieuTron phieuTronByKey = this._presenter.GetPhieuTronByKey(row1.PhieuTronID);
      if (phieuTronByKey == null)
        return;
      int? nullable2 = phieuTronByKey.CreatedBy;
      if (nullable2.HasValue)
      {
        nullable2 = phieuTronByKey.CreatedBy;
        this.userID = nullable2.Value;
        this.txtNguoiTron.Text = this._ser.GetSEC_UserByKey(this.userID).FullName;
      }
      this.datNgayTron.EditValue = (object) phieuTronByKey.NgayPhieuTron;
      TextEdit txtGioTron = this.txtGioTron;
      DateTime? nullable3 = phieuTronByKey.NgayPhieuTron;
      DateTime dateTime = nullable3.Value;
      string str1 = dateTime.ToString("HH:mm:ss");
      txtGioTron.Text = str1;
      nullable3 = phieuTronByKey.LatestUpdateDate;
      if (nullable3.HasValue)
      {
        TextEdit txtGioKtTron = this.txtGioKTTron;
        nullable3 = phieuTronByKey.LatestUpdateDate;
        dateTime = nullable3.Value;
        string str2 = dateTime.ToString("HH:mm:ss");
        txtGioKtTron.Text = str2;
      }
      this.txtMaPhieuTron.Text = phieuTronByKey.MaPhieuTron;
      TextEdit txtSoPhieu = this.txtSoPhieu;
      nullable2 = phieuTronByKey.NoPhieu;
      string str3 = nullable2.ToString();
      txtSoPhieu.Text = str3;
      this.txtTenMAC.Text = phieuTronByKey.NPMACTenMAC;
      this.txtCuongDo.Text = phieuTronByKey.NPMACCuongDo;
      this.txtDoSut.Text = phieuTronByKey.NPMACDoSut;
      this.txtTenKhachHang.Text = phieuTronByKey.NPKhachHangTenKhachHang;
      this.txtTenCongTruong.Text = phieuTronByKey.NPCongTruongTenCongTruong;
      this.txtDiaDiem.Text = phieuTronByKey.NPCongTruongDiaChi;
      this.txtHangMuc.Text = phieuTronByKey.NPHangMucTenHangMuc;
      this.txtTaiXe.Text = phieuTronByKey.NPTaiXeTenTaiXe;
      this.txtXe.Text = phieuTronByKey.NPXeBienSo;
      this.txtNiemChi.Text = phieuTronByKey.MoTa;
      TextEdit txtTheTich = this.txtTheTich;
      Decimal? nullable4 = phieuTronByKey.KLDuTinh;
      string str4 = nullable4.ToString();
      txtTheTich.Text = str4;
      TextEdit txtLuyKe = this.txtLuyKe;
      nullable4 = phieuTronByKey.KLThuc;
      string str5 = nullable4.ToString();
      txtLuyKe.Text = str5;
      this.txtKhoiLuongDatHang.Text = phieuTronByKey.NPHopDongKLDatHang.ToString();
      this._blstMeTron = Converter.ConvertToBindingList<ObjMeTron>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListMeTronByPhieuTronID(phieuTronByKey.PhieuTronID) as List<ObjMeTron>);
      int count = this._blstMeTron.Count;
      this._blstMeTronChiTiet = Converter.ConvertToBindingList<ObjMeTronChiTiet>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListMeTronChiTietByPhieuTronID(phieuTronByKey.PhieuTronID) as List<ObjMeTronChiTiet>);
      BindingList<ObjMTCTFullPrinter> bindingList1 = new BindingList<ObjMTCTFullPrinter>();
      this.sum_KL = 0M;
      foreach (ObjMeTron objMeTron in (Collection<ObjMeTron>) this._blstMeTron)
      {
        Decimal sumKl = this.sum_KL;
        Decimal? nullable5 = objMeTron.KhoiLuong;
        Decimal num2 = nullable5.Value;
        this.sum_KL = sumKl + num2;
        ObjMTCTFullPrinter objMtctFullPrinter1 = new ObjMTCTFullPrinter();
        foreach (ObjMeTronChiTiet objMeTronChiTiet in (Collection<ObjMeTronChiTiet>) this._blstMeTronChiTiet)
        {
          if (objMeTron.MeTronID == objMeTronChiTiet.MeTronID)
          {
            ObjMTCTFullPrinter objMtctFullPrinter2 = objMtctFullPrinter1;
            nullable2 = objMeTron.LnNo;
            string str6 = nullable2.ToString();
            objMtctFullPrinter2.LnNo = str6;
            ObjMTCTFullPrinter objMtctFullPrinter3 = objMtctFullPrinter1;
            nullable5 = objMeTron.KhoiLuong;
            string str7 = nullable5.ToString();
            objMtctFullPrinter3.KLTungMe = str7;
            string maSilo = objMeTronChiTiet.MaSilo;
            if (maSilo != null)
            {
              switch (maSilo.Length)
              {
                case 3:
                  switch (maSilo[2])
                  {
                    case '1':
                      switch (maSilo)
                      {
                        case "Ce1":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter4 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num3 = nullable5.Value;
                          objMtctFullPrinter4.SiloValue_Ce1 = num3;
                          ObjMTCTFullPrinter objMtctFullPrinter5 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num4 = nullable5.Value;
                          objMtctFullPrinter5.CP_Ce1 = num4;
                          ObjMTCTFullPrinter objMtctFullPrinter6 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num5 = nullable5.Value;
                          objMtctFullPrinter6.PV_Ce1 = num5;
                          ObjMTCTFullPrinter objMtctFullPrinter7 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num6 = nullable5.Value;
                          objMtctFullPrinter7.PVM_Ce1 = num6;
                          ObjMTCTFullPrinter objMtctFullPrinter8 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num7 = nullable5.Value;
                          objMtctFullPrinter8.SaiSo_Ce1 = num7;
                          ObjMTCTFullPrinter objMtctFullPrinter9 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num8 = nullable5.Value;
                          objMtctFullPrinter9.PerSaiSo_Ce1 = num8;
                          objMtctFullPrinter1.MaterialName_Ce1 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Ce1";
                          continue;
                        case "Wa1":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter10 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num9 = nullable5.Value;
                          objMtctFullPrinter10.SiloValue_Wa1 = num9;
                          ObjMTCTFullPrinter objMtctFullPrinter11 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num10 = nullable5.Value;
                          objMtctFullPrinter11.CP_Wa1 = num10;
                          ObjMTCTFullPrinter objMtctFullPrinter12 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num11 = nullable5.Value;
                          objMtctFullPrinter12.PV_Wa1 = num11;
                          ObjMTCTFullPrinter objMtctFullPrinter13 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num12 = nullable5.Value;
                          objMtctFullPrinter13.PVM_Wa1 = num12;
                          ObjMTCTFullPrinter objMtctFullPrinter14 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num13 = nullable5.Value;
                          objMtctFullPrinter14.SaiSo_Wa1 = num13;
                          ObjMTCTFullPrinter objMtctFullPrinter15 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num14 = nullable5.Value;
                          objMtctFullPrinter15.PerSaiSo_Wa1 = num14;
                          objMtctFullPrinter1.MaterialName_Wa1 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Wa1";
                          continue;
                        default:
                          continue;
                      }
                    case '2':
                      switch (maSilo)
                      {
                        case "Ce2":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter16 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num15 = nullable5.Value;
                          objMtctFullPrinter16.SiloValue_Ce2 = num15;
                          ObjMTCTFullPrinter objMtctFullPrinter17 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num16 = nullable5.Value;
                          objMtctFullPrinter17.CP_Ce2 = num16;
                          ObjMTCTFullPrinter objMtctFullPrinter18 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num17 = nullable5.Value;
                          objMtctFullPrinter18.PV_Ce2 = num17;
                          ObjMTCTFullPrinter objMtctFullPrinter19 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num18 = nullable5.Value;
                          objMtctFullPrinter19.PVM_Ce2 = num18;
                          ObjMTCTFullPrinter objMtctFullPrinter20 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num19 = nullable5.Value;
                          objMtctFullPrinter20.SaiSo_Ce2 = num19;
                          ObjMTCTFullPrinter objMtctFullPrinter21 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num20 = nullable5.Value;
                          objMtctFullPrinter21.PerSaiSo_Ce2 = num20;
                          objMtctFullPrinter1.MaterialName_Ce2 = objMeTronChiTiet.MaterialName == null ? "Ce2" : objMeTronChiTiet.MaterialName;
                          continue;
                        case "Wa2":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter22 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num21 = nullable5.Value;
                          objMtctFullPrinter22.SiloValue_Wa2 = num21;
                          ObjMTCTFullPrinter objMtctFullPrinter23 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num22 = nullable5.Value;
                          objMtctFullPrinter23.CP_Wa2 = num22;
                          ObjMTCTFullPrinter objMtctFullPrinter24 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num23 = nullable5.Value;
                          objMtctFullPrinter24.PV_Wa2 = num23;
                          ObjMTCTFullPrinter objMtctFullPrinter25 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num24 = nullable5.Value;
                          objMtctFullPrinter25.PVM_Wa2 = num24;
                          ObjMTCTFullPrinter objMtctFullPrinter26 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num25 = nullable5.Value;
                          objMtctFullPrinter26.SaiSo_Wa2 = num25;
                          ObjMTCTFullPrinter objMtctFullPrinter27 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num26 = nullable5.Value;
                          objMtctFullPrinter27.PerSaiSo_Wa2 = num26;
                          objMtctFullPrinter1.MaterialName_Wa2 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Wa2";
                          continue;
                        default:
                          continue;
                      }
                    case '3':
                      if (maSilo == "Ce3")
                      {
                        nullable5 = objMeTronChiTiet.SiloValue;
                        if (!nullable5.HasValue)
                          objMeTronChiTiet.SiloValue = new Decimal?(0M);
                        ObjMTCTFullPrinter objMtctFullPrinter28 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.SiloValue;
                        Decimal num27 = nullable5.Value;
                        objMtctFullPrinter28.SiloValue_Ce3 = num27;
                        ObjMTCTFullPrinter objMtctFullPrinter29 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.Value;
                        Decimal num28 = nullable5.Value;
                        objMtctFullPrinter29.CP_Ce3 = num28;
                        ObjMTCTFullPrinter objMtctFullPrinter30 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValueBat;
                        Decimal num29 = nullable5.Value;
                        objMtctFullPrinter30.PV_Ce3 = num29;
                        ObjMTCTFullPrinter objMtctFullPrinter31 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValueBatMan;
                        Decimal num30 = nullable5.Value;
                        objMtctFullPrinter31.PVM_Ce3 = num30;
                        ObjMTCTFullPrinter objMtctFullPrinter32 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValueTol;
                        Decimal num31 = nullable5.Value;
                        objMtctFullPrinter32.SaiSo_Ce3 = num31;
                        ObjMTCTFullPrinter objMtctFullPrinter33 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValuePerTol;
                        Decimal num32 = nullable5.Value;
                        objMtctFullPrinter33.PerSaiSo_Ce3 = num32;
                        objMtctFullPrinter1.MaterialName_Ce3 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Ce3";
                        continue;
                      }
                      continue;
                    case '4':
                      if (maSilo == "Ce4")
                      {
                        nullable5 = objMeTronChiTiet.SiloValue;
                        if (!nullable5.HasValue)
                          objMeTronChiTiet.SiloValue = new Decimal?(0M);
                        ObjMTCTFullPrinter objMtctFullPrinter34 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.SiloValue;
                        Decimal num33 = nullable5.Value;
                        objMtctFullPrinter34.SiloValue_Ce4 = num33;
                        ObjMTCTFullPrinter objMtctFullPrinter35 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.Value;
                        Decimal num34 = nullable5.Value;
                        objMtctFullPrinter35.CP_Ce4 = num34;
                        ObjMTCTFullPrinter objMtctFullPrinter36 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValueBat;
                        Decimal num35 = nullable5.Value;
                        objMtctFullPrinter36.PV_Ce4 = num35;
                        ObjMTCTFullPrinter objMtctFullPrinter37 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValueBatMan;
                        Decimal num36 = nullable5.Value;
                        objMtctFullPrinter37.PVM_Ce4 = num36;
                        ObjMTCTFullPrinter objMtctFullPrinter38 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValueTol;
                        Decimal num37 = nullable5.Value;
                        objMtctFullPrinter38.SaiSo_Ce4 = num37;
                        ObjMTCTFullPrinter objMtctFullPrinter39 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValuePerTol;
                        Decimal num38 = nullable5.Value;
                        objMtctFullPrinter39.PerSaiSo_Ce4 = num38;
                        objMtctFullPrinter1.MaterialName_Ce4 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Ce4";
                        continue;
                      }
                      continue;
                    case '5':
                      if (maSilo == "Ce5")
                      {
                        nullable5 = objMeTronChiTiet.SiloValue;
                        if (!nullable5.HasValue)
                          objMeTronChiTiet.SiloValue = new Decimal?(0M);
                        ObjMTCTFullPrinter objMtctFullPrinter40 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.SiloValue;
                        Decimal num39 = nullable5.Value;
                        objMtctFullPrinter40.SiloValue_Ce5 = num39;
                        ObjMTCTFullPrinter objMtctFullPrinter41 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.Value;
                        Decimal num40 = nullable5.Value;
                        objMtctFullPrinter41.CP_Ce5 = num40;
                        ObjMTCTFullPrinter objMtctFullPrinter42 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValueBat;
                        Decimal num41 = nullable5.Value;
                        objMtctFullPrinter42.PV_Ce5 = num41;
                        ObjMTCTFullPrinter objMtctFullPrinter43 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValueBatMan;
                        Decimal num42 = nullable5.Value;
                        objMtctFullPrinter43.PVM_Ce5 = num42;
                        ObjMTCTFullPrinter objMtctFullPrinter44 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValueTol;
                        Decimal num43 = nullable5.Value;
                        objMtctFullPrinter44.SaiSo_Ce5 = num43;
                        ObjMTCTFullPrinter objMtctFullPrinter45 = objMtctFullPrinter1;
                        nullable5 = objMeTronChiTiet.ValuePerTol;
                        Decimal num44 = nullable5.Value;
                        objMtctFullPrinter45.PerSaiSo_Ce5 = num44;
                        objMtctFullPrinter1.MaterialName_Ce5 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Ce5";
                        continue;
                      }
                      continue;
                    default:
                      continue;
                  }
                case 4:
                  switch (maSilo[3])
                  {
                    case '1':
                      switch (maSilo)
                      {
                        case "Agg1":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter46 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num45 = nullable5.Value;
                          objMtctFullPrinter46.SiloValue_Agg1 = num45;
                          ObjMTCTFullPrinter objMtctFullPrinter47 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num46 = nullable5.Value;
                          objMtctFullPrinter47.CP_Agg1 = num46;
                          ObjMTCTFullPrinter objMtctFullPrinter48 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num47 = nullable5.Value;
                          objMtctFullPrinter48.PV_Agg1 = num47;
                          ObjMTCTFullPrinter objMtctFullPrinter49 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num48 = nullable5.Value;
                          objMtctFullPrinter49.PVM_Agg1 = num48;
                          ObjMTCTFullPrinter objMtctFullPrinter50 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num49 = nullable5.Value;
                          objMtctFullPrinter50.SaiSo_Agg1 = num49;
                          ObjMTCTFullPrinter objMtctFullPrinter51 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num50 = nullable5.Value;
                          objMtctFullPrinter51.PerSaiSo_Agg1 = num50;
                          ObjMTCTFullPrinter objMtctFullPrinter52 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                          Decimal num51 = nullable5.Value;
                          objMtctFullPrinter52.DoAm_Agg1 = num51;
                          objMtctFullPrinter1.MaterialName_Agg1 = objMeTronChiTiet.MaterialName == null ? "Agg1" : objMeTronChiTiet.MaterialName;
                          continue;
                        case "Add1":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter53 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num52 = nullable5.Value;
                          objMtctFullPrinter53.SiloValue_Add1 = num52;
                          ObjMTCTFullPrinter objMtctFullPrinter54 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num53 = nullable5.Value;
                          objMtctFullPrinter54.CP_Add1 = num53;
                          ObjMTCTFullPrinter objMtctFullPrinter55 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num54 = nullable5.Value;
                          objMtctFullPrinter55.PV_Add1 = num54;
                          ObjMTCTFullPrinter objMtctFullPrinter56 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num55 = nullable5.Value;
                          objMtctFullPrinter56.PVM_Add1 = num55;
                          ObjMTCTFullPrinter objMtctFullPrinter57 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num56 = nullable5.Value;
                          objMtctFullPrinter57.SaiSo_Add1 = num56;
                          ObjMTCTFullPrinter objMtctFullPrinter58 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num57 = nullable5.Value;
                          objMtctFullPrinter58.PerSaiSo_Add1 = num57;
                          objMtctFullPrinter1.MaterialName_Add1 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Add1";
                          continue;
                        default:
                          continue;
                      }
                    case '2':
                      switch (maSilo)
                      {
                        case "Agg2":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter59 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num58 = nullable5.Value;
                          objMtctFullPrinter59.SiloValue_Agg2 = num58;
                          ObjMTCTFullPrinter objMtctFullPrinter60 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num59 = nullable5.Value;
                          objMtctFullPrinter60.CP_Agg2 = num59;
                          ObjMTCTFullPrinter objMtctFullPrinter61 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num60 = nullable5.Value;
                          objMtctFullPrinter61.PV_Agg2 = num60;
                          ObjMTCTFullPrinter objMtctFullPrinter62 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num61 = nullable5.Value;
                          objMtctFullPrinter62.PVM_Agg2 = num61;
                          ObjMTCTFullPrinter objMtctFullPrinter63 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num62 = nullable5.Value;
                          objMtctFullPrinter63.SaiSo_Agg2 = num62;
                          ObjMTCTFullPrinter objMtctFullPrinter64 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num63 = nullable5.Value;
                          objMtctFullPrinter64.PerSaiSo_Agg2 = num63;
                          ObjMTCTFullPrinter objMtctFullPrinter65 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                          Decimal num64 = nullable5.Value;
                          objMtctFullPrinter65.DoAm_Agg2 = num64;
                          objMtctFullPrinter1.MaterialName_Agg2 = objMeTronChiTiet.MaterialName == null ? "Agg2" : objMeTronChiTiet.MaterialName;
                          continue;
                        case "Add2":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter66 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num65 = nullable5.Value;
                          objMtctFullPrinter66.SiloValue_Add2 = num65;
                          ObjMTCTFullPrinter objMtctFullPrinter67 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num66 = nullable5.Value;
                          objMtctFullPrinter67.CP_Add2 = num66;
                          ObjMTCTFullPrinter objMtctFullPrinter68 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num67 = nullable5.Value;
                          objMtctFullPrinter68.PV_Add2 = num67;
                          ObjMTCTFullPrinter objMtctFullPrinter69 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num68 = nullable5.Value;
                          objMtctFullPrinter69.PVM_Add2 = num68;
                          ObjMTCTFullPrinter objMtctFullPrinter70 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num69 = nullable5.Value;
                          objMtctFullPrinter70.SaiSo_Add2 = num69;
                          ObjMTCTFullPrinter objMtctFullPrinter71 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num70 = nullable5.Value;
                          objMtctFullPrinter71.PerSaiSo_Add2 = num70;
                          objMtctFullPrinter1.MaterialName_Add2 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Add2";
                          continue;
                        default:
                          continue;
                      }
                    case '3':
                      switch (maSilo)
                      {
                        case "Agg3":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter72 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num71 = nullable5.Value;
                          objMtctFullPrinter72.SiloValue_Agg3 = num71;
                          ObjMTCTFullPrinter objMtctFullPrinter73 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num72 = nullable5.Value;
                          objMtctFullPrinter73.CP_Agg3 = num72;
                          ObjMTCTFullPrinter objMtctFullPrinter74 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num73 = nullable5.Value;
                          objMtctFullPrinter74.PV_Agg3 = num73;
                          ObjMTCTFullPrinter objMtctFullPrinter75 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num74 = nullable5.Value;
                          objMtctFullPrinter75.PVM_Agg3 = num74;
                          ObjMTCTFullPrinter objMtctFullPrinter76 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num75 = nullable5.Value;
                          objMtctFullPrinter76.SaiSo_Agg3 = num75;
                          ObjMTCTFullPrinter objMtctFullPrinter77 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num76 = nullable5.Value;
                          objMtctFullPrinter77.PerSaiSo_Agg3 = num76;
                          ObjMTCTFullPrinter objMtctFullPrinter78 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                          Decimal num77 = nullable5.Value;
                          objMtctFullPrinter78.DoAm_Agg3 = num77;
                          objMtctFullPrinter1.MaterialName_Agg3 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Agg3";
                          continue;
                        case "Add3":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter79 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num78 = nullable5.Value;
                          objMtctFullPrinter79.SiloValue_Add3 = num78;
                          ObjMTCTFullPrinter objMtctFullPrinter80 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num79 = nullable5.Value;
                          objMtctFullPrinter80.CP_Add3 = num79;
                          ObjMTCTFullPrinter objMtctFullPrinter81 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num80 = nullable5.Value;
                          objMtctFullPrinter81.PV_Add3 = num80;
                          ObjMTCTFullPrinter objMtctFullPrinter82 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num81 = nullable5.Value;
                          objMtctFullPrinter82.PVM_Add3 = num81;
                          ObjMTCTFullPrinter objMtctFullPrinter83 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num82 = nullable5.Value;
                          objMtctFullPrinter83.SaiSo_Add3 = num82;
                          ObjMTCTFullPrinter objMtctFullPrinter84 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num83 = nullable5.Value;
                          objMtctFullPrinter84.PerSaiSo_Add3 = num83;
                          objMtctFullPrinter1.MaterialName_Add3 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Add3";
                          continue;
                        default:
                          continue;
                      }
                    case '4':
                      switch (maSilo)
                      {
                        case "Agg4":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter85 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num84 = nullable5.Value;
                          objMtctFullPrinter85.SiloValue_Agg4 = num84;
                          ObjMTCTFullPrinter objMtctFullPrinter86 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num85 = nullable5.Value;
                          objMtctFullPrinter86.CP_Agg4 = num85;
                          ObjMTCTFullPrinter objMtctFullPrinter87 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num86 = nullable5.Value;
                          objMtctFullPrinter87.PV_Agg4 = num86;
                          ObjMTCTFullPrinter objMtctFullPrinter88 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num87 = nullable5.Value;
                          objMtctFullPrinter88.PVM_Agg4 = num87;
                          ObjMTCTFullPrinter objMtctFullPrinter89 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num88 = nullable5.Value;
                          objMtctFullPrinter89.SaiSo_Agg4 = num88;
                          ObjMTCTFullPrinter objMtctFullPrinter90 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num89 = nullable5.Value;
                          objMtctFullPrinter90.PerSaiSo_Agg4 = num89;
                          ObjMTCTFullPrinter objMtctFullPrinter91 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                          Decimal num90 = nullable5.Value;
                          objMtctFullPrinter91.DoAm_Agg4 = num90;
                          objMtctFullPrinter1.MaterialName_Agg4 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Agg4";
                          continue;
                        case "Add4":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter92 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num91 = nullable5.Value;
                          objMtctFullPrinter92.SiloValue_Add4 = num91;
                          ObjMTCTFullPrinter objMtctFullPrinter93 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num92 = nullable5.Value;
                          objMtctFullPrinter93.CP_Add4 = num92;
                          ObjMTCTFullPrinter objMtctFullPrinter94 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num93 = nullable5.Value;
                          objMtctFullPrinter94.PV_Add4 = num93;
                          ObjMTCTFullPrinter objMtctFullPrinter95 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num94 = nullable5.Value;
                          objMtctFullPrinter95.PVM_Add4 = num94;
                          ObjMTCTFullPrinter objMtctFullPrinter96 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num95 = nullable5.Value;
                          objMtctFullPrinter96.SaiSo_Add4 = num95;
                          ObjMTCTFullPrinter objMtctFullPrinter97 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num96 = nullable5.Value;
                          objMtctFullPrinter97.PerSaiSo_Add4 = num96;
                          objMtctFullPrinter1.MaterialName_Add4 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Add4";
                          continue;
                        default:
                          continue;
                      }
                    case '5':
                      switch (maSilo)
                      {
                        case "Agg5":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter98 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num97 = nullable5.Value;
                          objMtctFullPrinter98.SiloValue_Agg5 = num97;
                          ObjMTCTFullPrinter objMtctFullPrinter99 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num98 = nullable5.Value;
                          objMtctFullPrinter99.CP_Agg5 = num98;
                          ObjMTCTFullPrinter objMtctFullPrinter100 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num99 = nullable5.Value;
                          objMtctFullPrinter100.PV_Agg5 = num99;
                          ObjMTCTFullPrinter objMtctFullPrinter101 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num100 = nullable5.Value;
                          objMtctFullPrinter101.PVM_Agg5 = num100;
                          ObjMTCTFullPrinter objMtctFullPrinter102 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num101 = nullable5.Value;
                          objMtctFullPrinter102.SaiSo_Agg5 = num101;
                          ObjMTCTFullPrinter objMtctFullPrinter103 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num102 = nullable5.Value;
                          objMtctFullPrinter103.PerSaiSo_Agg5 = num102;
                          ObjMTCTFullPrinter objMtctFullPrinter104 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                          Decimal num103 = nullable5.Value;
                          objMtctFullPrinter104.DoAm_Agg5 = num103;
                          objMtctFullPrinter1.MaterialName_Agg5 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Agg5";
                          continue;
                        case "Add5":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter105 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num104 = nullable5.Value;
                          objMtctFullPrinter105.SiloValue_Add5 = num104;
                          ObjMTCTFullPrinter objMtctFullPrinter106 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num105 = nullable5.Value;
                          objMtctFullPrinter106.CP_Add5 = num105;
                          ObjMTCTFullPrinter objMtctFullPrinter107 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num106 = nullable5.Value;
                          objMtctFullPrinter107.PV_Add5 = num106;
                          ObjMTCTFullPrinter objMtctFullPrinter108 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num107 = nullable5.Value;
                          objMtctFullPrinter108.PVM_Add5 = num107;
                          ObjMTCTFullPrinter objMtctFullPrinter109 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num108 = nullable5.Value;
                          objMtctFullPrinter109.SaiSo_Add5 = num108;
                          ObjMTCTFullPrinter objMtctFullPrinter110 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num109 = nullable5.Value;
                          objMtctFullPrinter110.PerSaiSo_Add5 = num109;
                          objMtctFullPrinter1.MaterialName_Add5 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Add5";
                          continue;
                        default:
                          continue;
                      }
                    case '6':
                      switch (maSilo)
                      {
                        case "Agg6":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter111 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num110 = nullable5.Value;
                          objMtctFullPrinter111.SiloValue_Agg6 = num110;
                          ObjMTCTFullPrinter objMtctFullPrinter112 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num111 = nullable5.Value;
                          objMtctFullPrinter112.CP_Agg6 = num111;
                          ObjMTCTFullPrinter objMtctFullPrinter113 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num112 = nullable5.Value;
                          objMtctFullPrinter113.PV_Agg6 = num112;
                          ObjMTCTFullPrinter objMtctFullPrinter114 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num113 = nullable5.Value;
                          objMtctFullPrinter114.PVM_Agg6 = num113;
                          ObjMTCTFullPrinter objMtctFullPrinter115 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num114 = nullable5.Value;
                          objMtctFullPrinter115.SaiSo_Agg6 = num114;
                          ObjMTCTFullPrinter objMtctFullPrinter116 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num115 = nullable5.Value;
                          objMtctFullPrinter116.PerSaiSo_Agg6 = num115;
                          ObjMTCTFullPrinter objMtctFullPrinter117 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                          Decimal num116 = nullable5.Value;
                          objMtctFullPrinter117.DoAm_Agg6 = num116;
                          objMtctFullPrinter1.MaterialName_Agg6 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Agg6";
                          continue;
                        case "Add6":
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter118 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num117 = nullable5.Value;
                          objMtctFullPrinter118.SiloValue_Add6 = num117;
                          ObjMTCTFullPrinter objMtctFullPrinter119 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num118 = nullable5.Value;
                          objMtctFullPrinter119.CP_Add6 = num118;
                          ObjMTCTFullPrinter objMtctFullPrinter120 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num119 = nullable5.Value;
                          objMtctFullPrinter120.PV_Add6 = num119;
                          ObjMTCTFullPrinter objMtctFullPrinter121 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num120 = nullable5.Value;
                          objMtctFullPrinter121.PVM_Add6 = num120;
                          ObjMTCTFullPrinter objMtctFullPrinter122 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num121 = nullable5.Value;
                          objMtctFullPrinter122.SaiSo_Add6 = num121;
                          ObjMTCTFullPrinter objMtctFullPrinter123 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num122 = nullable5.Value;
                          objMtctFullPrinter123.PerSaiSo_Add6 = num122;
                          objMtctFullPrinter1.MaterialName_Add6 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : "Add6";
                          continue;
                        default:
                          continue;
                      }
                    default:
                      continue;
                  }
                default:
                  continue;
              }
            }
          }
        }
        bindingList1.Add(objMtctFullPrinter1);
      }
      if (bindingList1.Count == 0)
        return;
      BindingList<ObjMTCTPrinter> bindingList2 = new BindingList<ObjMTCTPrinter>();
      this.CopyLstFullToLis(bindingList1, bindingList2);
      DataTable dataTable = PrinterPheuTronChiTiet.ToDataTable(bindingList2);
      DataRow row2 = dataTable.NewRow();
      row2["LnNo"] = (object) "KL 1m\u00B3";
      row2["KLTungMe"] = (object) "1";
      row2["PV_Agg1"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Agg1.ToString();
      row2["PV_Agg1_Manual"] = (object) "0";
      row2["PV_Agg2"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Agg2.ToString();
      row2["PV_Agg2_Manual"] = (object) "0";
      row2["PV_Agg3"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Agg3.ToString();
      row2["PV_Agg3_Manual"] = (object) "0";
      row2["PV_Agg4"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Agg4.ToString();
      row2["PV_Agg4_Manual"] = (object) "0";
      row2["PV_Agg5"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Agg5.ToString();
      row2["PV_Agg5_Manual"] = (object) "0";
      row2["PV_Agg6"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Agg6.ToString();
      row2["PV_Agg6_Manual"] = (object) "0";
      row2["PV_Ce1"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Ce1.ToString();
      row2["PV_Ce1_Manual"] = (object) "0";
      row2["PV_Ce2"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Ce2.ToString();
      row2["PV_Ce2_Manual"] = (object) "0";
      row2["PV_Ce3"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Ce3.ToString();
      row2["PV_Ce3_Manual"] = (object) "0";
      row2["PV_Ce4"] = (object) bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Ce4.ToString();
      row2["PV_Ce4_Manual"] = (object) "0";
      DataRow dataRow1 = row2;
      Decimal num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Ce5;
      string str8 = num123.ToString();
      dataRow1["PV_Ce5"] = (object) str8;
      row2["PV_Ce5_Manual"] = (object) "0";
      DataRow dataRow2 = row2;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Wa1;
      string str9 = num123.ToString();
      dataRow2["PV_Wa1"] = (object) str9;
      row2["PV_Wa1_Manual"] = (object) "0";
      DataRow dataRow3 = row2;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Wa2;
      string str10 = num123.ToString();
      dataRow3["PV_Wa2"] = (object) str10;
      row2["PV_Wa2_Manual"] = (object) "0";
      DataRow dataRow4 = row2;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Add1;
      string str11 = num123.ToString();
      dataRow4["PV_Add1"] = (object) str11;
      row2["PV_Add1_Manual"] = (object) "0";
      DataRow dataRow5 = row2;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Add2;
      string str12 = num123.ToString();
      dataRow5["PV_Add2"] = (object) str12;
      row2["PV_Add2_Manual"] = (object) "0";
      DataRow dataRow6 = row2;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Add3;
      string str13 = num123.ToString();
      dataRow6["PV_Add3"] = (object) str13;
      row2["PV_Add3_Manual"] = (object) "0";
      DataRow dataRow7 = row2;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Add4;
      string str14 = num123.ToString();
      dataRow7["PV_Add4"] = (object) str14;
      row2["PV_Add4_Manual"] = (object) "0";
      DataRow dataRow8 = row2;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Add5;
      string str15 = num123.ToString();
      dataRow8["PV_Add5"] = (object) str15;
      row2["PV_Add5_Manual"] = (object) "0";
      DataRow dataRow9 = row2;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().SiloValue_Add6;
      string str16 = num123.ToString();
      dataRow9["PV_Add6"] = (object) str16;
      row2["PV_Add6_Manual"] = (object) "0";
      dataTable.Rows.InsertAt(row2, 0);
      DataRow row3 = dataTable.NewRow();
      row3["LnNo"] = (object) "Độ ẩm";
      row3["KLTungMe"] = (object) "";
      DataRow dataRow10 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Agg1;
      string str17 = num123.ToString();
      dataRow10["PV_Agg1"] = (object) str17;
      row3["PV_Agg1_Manual"] = (object) "0";
      DataRow dataRow11 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Agg2;
      string str18 = num123.ToString();
      dataRow11["PV_Agg2"] = (object) str18;
      row3["PV_Agg2_Manual"] = (object) "0";
      DataRow dataRow12 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Agg3;
      string str19 = num123.ToString();
      dataRow12["PV_Agg3"] = (object) str19;
      row3["PV_Agg3_Manual"] = (object) "0";
      DataRow dataRow13 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Agg4;
      string str20 = num123.ToString();
      dataRow13["PV_Agg4"] = (object) str20;
      row3["PV_Agg4_Manual"] = (object) "0";
      DataRow dataRow14 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Agg5;
      string str21 = num123.ToString();
      dataRow14["PV_Agg5"] = (object) str21;
      row3["PV_Agg5_Manual"] = (object) "0";
      DataRow dataRow15 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Agg6;
      string str22 = num123.ToString();
      dataRow15["PV_Agg6"] = (object) str22;
      row3["PV_Agg6_Manual"] = (object) "0";
      DataRow dataRow16 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Ce1;
      string str23 = num123.ToString();
      dataRow16["PV_Ce1"] = (object) str23;
      row3["PV_Ce1_Manual"] = (object) "0";
      DataRow dataRow17 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Ce2;
      string str24 = num123.ToString();
      dataRow17["PV_Ce2"] = (object) str24;
      row3["PV_Ce2_Manual"] = (object) "0";
      DataRow dataRow18 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Ce3;
      string str25 = num123.ToString();
      dataRow18["PV_Ce3"] = (object) str25;
      row3["PV_Ce3_Manual"] = (object) "0";
      DataRow dataRow19 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Ce4;
      string str26 = num123.ToString();
      dataRow19["PV_Ce4"] = (object) str26;
      row3["PV_Ce4_Manual"] = (object) "0";
      DataRow dataRow20 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Ce5;
      string str27 = num123.ToString();
      dataRow20["PV_Ce5"] = (object) str27;
      row3["PV_Ce5_Manual"] = (object) "0";
      DataRow dataRow21 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Wa1;
      string str28 = num123.ToString();
      dataRow21["PV_Wa1"] = (object) str28;
      row3["PV_Wa1_Manual"] = (object) "0";
      DataRow dataRow22 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Wa2;
      string str29 = num123.ToString();
      dataRow22["PV_Wa2"] = (object) str29;
      row3["PV_Wa2_Manual"] = (object) "0";
      DataRow dataRow23 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Add1;
      string str30 = num123.ToString();
      dataRow23["PV_Add1"] = (object) str30;
      row3["PV_Add1_Manual"] = (object) "0";
      DataRow dataRow24 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Add2;
      string str31 = num123.ToString();
      dataRow24["PV_Add2"] = (object) str31;
      row3["PV_Add2_Manual"] = (object) "0";
      DataRow dataRow25 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Add3;
      string str32 = num123.ToString();
      dataRow25["PV_Add3"] = (object) str32;
      row3["PV_Add3_Manual"] = (object) "0";
      DataRow dataRow26 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Add4;
      string str33 = num123.ToString();
      dataRow26["PV_Add4"] = (object) str33;
      row3["PV_Add4_Manual"] = (object) "0";
      DataRow dataRow27 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Add5;
      string str34 = num123.ToString();
      dataRow27["PV_Add5"] = (object) str34;
      row3["PV_Add5_Manual"] = (object) "0";
      DataRow dataRow28 = row3;
      num123 = bindingList1.FirstOrDefault<ObjMTCTFullPrinter>().DoAm_Add6;
      string str35 = num123.ToString();
      dataRow28["PV_Add6"] = (object) str35;
      row3["PV_Add6_Manual"] = (object) "0";
      dataTable.Rows.InsertAt(row3, 1);
      DataRow row4 = dataTable.NewRow();
      row4["LnNo"] = (object) "Khối lượng";
      row4["KLTungMe"] = (object) bindingList1[0].KLTungMe.ToString();
      DataRow dataRow29 = row4;
      num123 = bindingList1[0].CP_Agg1;
      string str36 = num123.ToString();
      dataRow29["PV_Agg1"] = (object) str36;
      row4["PV_Agg1_Manual"] = (object) "0";
      DataRow dataRow30 = row4;
      num123 = bindingList1[0].CP_Agg2;
      string str37 = num123.ToString();
      dataRow30["PV_Agg2"] = (object) str37;
      row4["PV_Agg2_Manual"] = (object) "0";
      DataRow dataRow31 = row4;
      num123 = bindingList1[0].CP_Agg3;
      string str38 = num123.ToString();
      dataRow31["PV_Agg3"] = (object) str38;
      row4["PV_Agg3_Manual"] = (object) "0";
      DataRow dataRow32 = row4;
      num123 = bindingList1[0].CP_Agg4;
      string str39 = num123.ToString();
      dataRow32["PV_Agg4"] = (object) str39;
      row4["PV_Agg4_Manual"] = (object) "0";
      DataRow dataRow33 = row4;
      num123 = bindingList1[0].CP_Agg5;
      string str40 = num123.ToString();
      dataRow33["PV_Agg5"] = (object) str40;
      row4["PV_Agg5_Manual"] = (object) "0";
      DataRow dataRow34 = row4;
      num123 = bindingList1[0].CP_Agg6;
      string str41 = num123.ToString();
      dataRow34["PV_Agg6"] = (object) str41;
      row4["PV_Agg6_Manual"] = (object) "0";
      DataRow dataRow35 = row4;
      num123 = bindingList1[0].CP_Ce1;
      string str42 = num123.ToString();
      dataRow35["PV_Ce1"] = (object) str42;
      row4["PV_Ce1_Manual"] = (object) "0";
      DataRow dataRow36 = row4;
      num123 = bindingList1[0].CP_Ce2;
      string str43 = num123.ToString();
      dataRow36["PV_Ce2"] = (object) str43;
      row4["PV_Ce2_Manual"] = (object) "0";
      DataRow dataRow37 = row4;
      num123 = bindingList1[0].CP_Ce3;
      string str44 = num123.ToString();
      dataRow37["PV_Ce3"] = (object) str44;
      row4["PV_Ce3_Manual"] = (object) "0";
      DataRow dataRow38 = row4;
      num123 = bindingList1[0].CP_Ce4;
      string str45 = num123.ToString();
      dataRow38["PV_Ce4"] = (object) str45;
      row4["PV_Ce4_Manual"] = (object) "0";
      DataRow dataRow39 = row4;
      num123 = bindingList1[0].CP_Ce5;
      string str46 = num123.ToString();
      dataRow39["PV_Ce5"] = (object) str46;
      row4["PV_Ce5_Manual"] = (object) "0";
      DataRow dataRow40 = row4;
      num123 = bindingList1[0].CP_Wa1;
      string str47 = num123.ToString();
      dataRow40["PV_Wa1"] = (object) str47;
      row4["PV_Wa1_Manual"] = (object) "0";
      DataRow dataRow41 = row4;
      num123 = bindingList1[0].CP_Wa2;
      string str48 = num123.ToString();
      dataRow41["PV_Wa2"] = (object) str48;
      row4["PV_Wa2_Manual"] = (object) "0";
      DataRow dataRow42 = row4;
      num123 = bindingList1[0].CP_Add1;
      string str49 = num123.ToString();
      dataRow42["PV_Add1"] = (object) str49;
      row4["PV_Add1_Manual"] = (object) "0";
      DataRow dataRow43 = row4;
      num123 = bindingList1[0].CP_Add2;
      string str50 = num123.ToString();
      dataRow43["PV_Add2"] = (object) str50;
      row4["PV_Add2_Manual"] = (object) "0";
      DataRow dataRow44 = row4;
      num123 = bindingList1[0].CP_Add3;
      string str51 = num123.ToString();
      dataRow44["PV_Add3"] = (object) str51;
      row4["PV_Add3_Manual"] = (object) "0";
      DataRow dataRow45 = row4;
      num123 = bindingList1[0].CP_Add4;
      string str52 = num123.ToString();
      dataRow45["PV_Add4"] = (object) str52;
      row4["PV_Add4_Manual"] = (object) "0";
      DataRow dataRow46 = row4;
      num123 = bindingList1[0].CP_Add5;
      string str53 = num123.ToString();
      dataRow46["PV_Add5"] = (object) str53;
      row4["PV_Add5_Manual"] = (object) "0";
      DataRow dataRow47 = row4;
      num123 = bindingList1[0].CP_Add6;
      string str54 = num123.ToString();
      dataRow47["PV_Add6"] = (object) str54;
      row4["PV_Add6_Manual"] = (object) "0";
      dataTable.Rows.InsertAt(row4, 2);
      this.grcPhieuTronChiTiet.DataSource = (object) dataTable;
      this._tablePTCT = dataTable.Copy();
      this.CreateTaableData(this.num_silo_Agg, this.num_silo_Ce, this.num_silo_Wa, this.num_silo_Add, bindingList1);
      this.bandedGridView1.FocusedRowHandle = 3;
      BindingList<ObjTotalMaterialPrinter> bindingList3 = new BindingList<ObjTotalMaterialPrinter>();
      this.CopyLstFullToLstMaterial(bindingList1, bindingList3);
      this.sum_Agg1 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg1;
      this.sum_Agg2 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg2;
      this.sum_Agg3 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg3;
      this.sum_Ce1 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce1;
      this.sum_Ce2 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce2;
      this.sum_Ce3 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce3;
      this.sum_Ce4 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce4;
      this.sum_Ce5 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce5;
      this.sum_Wa1 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Wa1;
      this.sum_Wa2 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Wa2;
      this.sum_Add1 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add1;
      this.sum_Add2 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add2;
      this.sum_Add3 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add3;
      this.sum_Add4 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add4;
      this.sum_Add5 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add5;
      this.sum_Add6 = bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add6;
      this.dataTableMaterial = PrinterPheuTronChiTiet.ToDataTableMaterial(bindingList3);
      this.grcTotalMaterial.DataSource = (object) this.dataTableMaterial;
      this.CreateTableTotalMaterial(this.num_silo_Agg, this.num_silo_Ce, this.num_silo_Wa, this.num_silo_Add, bindingList1);
      Decimal num124 = bindingList3[0].Total_PV_Agg1 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg2 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg3 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg4 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg5 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg6 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce1 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce2 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce3 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce4 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce5 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Wa1 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Wa2 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add1 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add2 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add3 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add4 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add5 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add6;
      this.sum_CP = num124;
      this.gcTotal_Agg1.SummaryItem.SummaryType = SummaryItemType.Custom;
      this.gcTotal_Agg1.SummaryItem.DisplayFormat = string.Format("Tổng: {0}", (object) num124);
    }

    private void CreateTableTotalMaterial(
      int numAgg,
      int numCe,
      int numWa,
      int numAdd,
      BindingList<ObjMTCTFullPrinter> _lstFullPrinter)
    {
      this.bandedGridView2.Bands["Total_Agg1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg1;
      this.bandedGridView2.Bands["Total_Agg2"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg2;
      this.bandedGridView2.Bands["Total_Agg3"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg3;
      this.bandedGridView2.Bands["Total_Agg4"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg4;
      this.bandedGridView2.Bands["Total_Agg5"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg5;
      this.bandedGridView2.Bands["Total_Agg6"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg6;
      this.bandedGridView2.Bands["Total_Ce1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce1;
      this.bandedGridView2.Bands["Total_Ce2"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce2;
      this.bandedGridView2.Bands["Total_Ce3"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce3;
      this.bandedGridView2.Bands["Total_Ce4"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce4;
      this.bandedGridView2.Bands["Total_Ce5"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce5;
      this.bandedGridView2.Bands["Total_Wa1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Wa1;
      this.bandedGridView2.Bands["Total_Wa2"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Wa2;
      this.bandedGridView2.Bands["Total_Add1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add1;
      this.bandedGridView2.Bands["Total_Add2"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add2;
      this.bandedGridView2.Bands["Total_Add3"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add3;
      this.bandedGridView2.Bands["Total_Add4"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add4;
      this.bandedGridView2.Bands["Total_Add5"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add5;
      this.bandedGridView2.Bands["Total_Add6"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add6;
      List<GridBand> gridBandList1 = new List<GridBand>();
      gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg1"]);
      gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg2"]);
      gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg3"]);
      gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg4"]);
      gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg5"]);
      gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg6"]);
      foreach (GridBand gridBand in gridBandList1)
        gridBand.Visible = false;
      for (int index = 0; index < numAgg; ++index)
        gridBandList1[index].Visible = true;
      List<GridBand> gridBandList2 = new List<GridBand>();
      gridBandList2.Add(this.bandedGridView2.Bands["Total_Ce1"]);
      gridBandList2.Add(this.bandedGridView2.Bands["Total_Ce2"]);
      gridBandList2.Add(this.bandedGridView2.Bands["Total_Ce3"]);
      gridBandList2.Add(this.bandedGridView2.Bands["Total_Ce4"]);
      gridBandList2.Add(this.bandedGridView2.Bands["Total_Ce5"]);
      foreach (GridBand gridBand in gridBandList2)
        gridBand.Visible = false;
      for (int index = 0; index < numCe; ++index)
        gridBandList2[index].Visible = true;
      List<GridBand> gridBandList3 = new List<GridBand>();
      gridBandList3.Add(this.bandedGridView2.Bands["Total_Wa1"]);
      gridBandList3.Add(this.bandedGridView2.Bands["Total_Wa2"]);
      foreach (GridBand gridBand in gridBandList3)
        gridBand.Visible = false;
      for (int index = 0; index < numWa; ++index)
        gridBandList3[index].Visible = true;
      List<GridBand> gridBandList4 = new List<GridBand>();
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add1"]);
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add2"]);
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add3"]);
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add4"]);
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add5"]);
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add6"]);
      foreach (GridBand gridBand in gridBandList4)
        gridBand.Visible = false;
      for (int index = 0; index < numAdd; ++index)
        gridBandList4[index].Visible = true;
    }

    private void CopyLstFullToLis(
      BindingList<ObjMTCTFullPrinter> fromLst,
      BindingList<ObjMTCTPrinter> toLst)
    {
      foreach (ObjMTCTFullPrinter from in (Collection<ObjMTCTFullPrinter>) fromLst)
      {
        ObjMTCTPrinter to = new ObjMTCTPrinter();
        this.CopyFullMTCTToMTCT(from, to);
        toLst.Add(to);
      }
    }

    private void CopyFullMTCTToMTCT(ObjMTCTFullPrinter from, ObjMTCTPrinter to)
    {
      to.LnNo = from.LnNo;
      to.KLTungMe = from.KLTungMe;
      to.PV_Agg1 = from.PV_Agg1;
      to.PV_Agg1_Manual = from.PVM_Agg1;
      to.PV_Agg2 = from.PV_Agg2;
      to.PV_Agg2_Manual = from.PVM_Agg2;
      to.PV_Agg3 = from.PV_Agg3;
      to.PV_Agg3_Manual = from.PVM_Agg3;
      to.PV_Agg4 = from.PV_Agg4;
      to.PV_Agg4_Manual = from.PVM_Agg4;
      to.PV_Agg5 = from.PV_Agg5;
      to.PV_Agg5_Manual = from.PVM_Agg5;
      to.PV_Agg6 = from.PV_Agg6;
      to.PV_Agg6_Manual = from.PVM_Agg6;
      to.PV_Ce1 = from.PV_Ce1;
      to.PV_Ce1_Manual = from.PVM_Ce1;
      to.PV_Ce2 = from.PV_Ce2;
      to.PV_Ce2_Manual = from.PVM_Ce2;
      to.PV_Ce3 = from.PV_Ce3;
      to.PV_Ce3_Manual = from.PVM_Ce3;
      to.PV_Ce4 = from.PV_Ce4;
      to.PV_Ce4_Manual = from.PVM_Ce4;
      to.PV_Ce5 = from.PV_Ce5;
      to.PV_Ce5_Manual = from.PVM_Ce5;
      to.PV_Wa1 = from.PV_Wa1;
      to.PV_Wa1_Manual = from.PVM_Wa1;
      to.PV_Wa2 = from.PV_Wa2;
      to.PV_Wa2_Manual = from.PVM_Wa2;
      to.PV_Add1 = from.PV_Add1;
      to.PV_Add1_Manual = from.PVM_Add1;
      to.PV_Add2 = from.PV_Add2;
      to.PV_Add2_Manual = from.PVM_Add2;
      to.PV_Add3 = from.PV_Add3;
      to.PV_Add3_Manual = from.PVM_Add3;
      to.PV_Add4 = from.PV_Add4;
      to.PV_Add4_Manual = from.PVM_Add4;
      to.PV_Add5 = from.PV_Add5;
      to.PV_Add5_Manual = from.PVM_Add5;
      to.PV_Add6 = from.PV_Add6;
      to.PV_Add6_Manual = from.PVM_Add6;
    }

    private static DataTable ToDataTable(BindingList<ObjMTCTPrinter> objects)
    {
      DataTable dataTable = new DataTable();
      foreach (PropertyInfo property in typeof (ObjMTCTPrinter).GetProperties())
        dataTable.Columns.Add(property.Name, property.PropertyType);
      foreach (ObjMTCTPrinter objMtctPrinter in (Collection<ObjMTCTPrinter>) objects)
      {
        DataRow row = dataTable.NewRow();
        foreach (DataColumn column in (InternalDataCollectionBase) dataTable.Columns)
          row[column.ColumnName] = typeof (ObjMTCTPrinter).GetProperty(column.ColumnName).GetValue((object) objMtctPrinter);
        dataTable.Rows.Add(row);
      }
      return dataTable;
    }

    private static DataTable ToDataTableMaterial(BindingList<ObjTotalMaterialPrinter> objects)
    {
      DataTable dataTableMaterial = new DataTable();
      foreach (PropertyInfo property in typeof (ObjTotalMaterialPrinter).GetProperties())
        dataTableMaterial.Columns.Add(property.Name, property.PropertyType);
      foreach (ObjTotalMaterialPrinter totalMaterialPrinter in (Collection<ObjTotalMaterialPrinter>) objects)
      {
        DataRow row = dataTableMaterial.NewRow();
        foreach (DataColumn column in (InternalDataCollectionBase) dataTableMaterial.Columns)
          row[column.ColumnName] = typeof (ObjTotalMaterialPrinter).GetProperty(column.ColumnName).GetValue((object) totalMaterialPrinter);
        dataTableMaterial.Rows.Add(row);
      }
      return dataTableMaterial;
    }

    private void CopyLstFullToLstMaterial(
      BindingList<ObjMTCTFullPrinter> fromLst,
      BindingList<ObjTotalMaterialPrinter> toLst)
    {
      ObjTotalMaterialPrinter totalMaterialPrinter1 = new ObjTotalMaterialPrinter();
      ObjTotalMaterialPrinter totalMaterialPrinter2 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter3 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter4 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter5 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter6 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter7 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter8 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter9 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter10 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter11 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter12 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter13 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter14 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter15 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter16 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter17 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter18 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter19 = totalMaterialPrinter1;
      ObjTotalMaterialPrinter totalMaterialPrinter20 = totalMaterialPrinter1;
      Decimal num1 = 0M;
      Decimal num2 = num1;
      totalMaterialPrinter20.Total_PV_Add6 = num2;
      Decimal num3;
      Decimal num4 = num3 = num1;
      totalMaterialPrinter19.Total_PV_Add5 = num3;
      Decimal num5;
      Decimal num6 = num5 = num4;
      totalMaterialPrinter18.Total_PV_Add4 = num5;
      Decimal num7;
      Decimal num8 = num7 = num6;
      totalMaterialPrinter17.Total_PV_Add3 = num7;
      Decimal num9;
      Decimal num10 = num9 = num8;
      totalMaterialPrinter16.Total_PV_Add2 = num9;
      Decimal num11;
      Decimal num12 = num11 = num10;
      totalMaterialPrinter15.Total_PV_Add1 = num11;
      Decimal num13;
      Decimal num14 = num13 = num12;
      totalMaterialPrinter14.Total_PV_Wa2 = num13;
      Decimal num15;
      Decimal num16 = num15 = num14;
      totalMaterialPrinter13.Total_PV_Wa1 = num15;
      Decimal num17;
      Decimal num18 = num17 = num16;
      totalMaterialPrinter12.Total_PV_Ce5 = num17;
      Decimal num19;
      Decimal num20 = num19 = num18;
      totalMaterialPrinter11.Total_PV_Ce4 = num19;
      Decimal num21;
      Decimal num22 = num21 = num20;
      totalMaterialPrinter10.Total_PV_Ce3 = num21;
      Decimal num23;
      Decimal num24 = num23 = num22;
      totalMaterialPrinter9.Total_PV_Ce2 = num23;
      Decimal num25;
      Decimal num26 = num25 = num24;
      totalMaterialPrinter8.Total_PV_Ce1 = num25;
      Decimal num27;
      Decimal num28 = num27 = num26;
      totalMaterialPrinter7.Total_PV_Agg6 = num27;
      Decimal num29;
      Decimal num30 = num29 = num28;
      totalMaterialPrinter6.Total_PV_Agg5 = num29;
      Decimal num31;
      Decimal num32 = num31 = num30;
      totalMaterialPrinter5.Total_PV_Agg4 = num31;
      Decimal num33;
      Decimal num34 = num33 = num32;
      totalMaterialPrinter4.Total_PV_Agg3 = num33;
      Decimal num35;
      Decimal num36 = num35 = num34;
      totalMaterialPrinter3.Total_PV_Agg2 = num35;
      Decimal num37 = num36;
      totalMaterialPrinter2.Total_PV_Agg1 = num37;
      foreach (ObjMTCTFullPrinter objMtctFullPrinter in (Collection<ObjMTCTFullPrinter>) fromLst)
      {
        totalMaterialPrinter1.Total_PV_Agg1 += objMtctFullPrinter.PV_Agg1;
        totalMaterialPrinter1.Total_PV_Agg2 += objMtctFullPrinter.PV_Agg2;
        totalMaterialPrinter1.Total_PV_Agg3 += objMtctFullPrinter.PV_Agg3;
        totalMaterialPrinter1.Total_PV_Agg4 += objMtctFullPrinter.PV_Agg4;
        totalMaterialPrinter1.Total_PV_Agg5 += objMtctFullPrinter.PV_Agg5;
        totalMaterialPrinter1.Total_PV_Agg6 += objMtctFullPrinter.PV_Agg6;
        totalMaterialPrinter1.Total_PV_Ce1 += objMtctFullPrinter.PV_Ce1;
        totalMaterialPrinter1.Total_PV_Ce2 += objMtctFullPrinter.PV_Ce2;
        totalMaterialPrinter1.Total_PV_Ce3 += objMtctFullPrinter.PV_Ce3;
        totalMaterialPrinter1.Total_PV_Ce4 += objMtctFullPrinter.PV_Ce4;
        totalMaterialPrinter1.Total_PV_Ce5 += objMtctFullPrinter.PV_Ce5;
        totalMaterialPrinter1.Total_PV_Wa1 += objMtctFullPrinter.PV_Wa1;
        totalMaterialPrinter1.Total_PV_Wa2 += objMtctFullPrinter.PV_Wa2;
        totalMaterialPrinter1.Total_PV_Add1 += objMtctFullPrinter.PV_Add1;
        totalMaterialPrinter1.Total_PV_Add2 += objMtctFullPrinter.PV_Add2;
        totalMaterialPrinter1.Total_PV_Add3 += objMtctFullPrinter.PV_Add3;
        totalMaterialPrinter1.Total_PV_Add4 += objMtctFullPrinter.PV_Add4;
        totalMaterialPrinter1.Total_PV_Add5 += objMtctFullPrinter.PV_Add5;
        totalMaterialPrinter1.Total_PV_Add6 += objMtctFullPrinter.PV_Add6;
        totalMaterialPrinter1.Name_AGG1 = objMtctFullPrinter.MaterialName_Agg1;
        totalMaterialPrinter1.Name_AGG2 = objMtctFullPrinter.MaterialName_Agg2;
        totalMaterialPrinter1.Name_AGG3 = objMtctFullPrinter.MaterialName_Agg3;
        totalMaterialPrinter1.Name_AGG4 = objMtctFullPrinter.MaterialName_Agg4;
        totalMaterialPrinter1.Name_AGG5 = objMtctFullPrinter.MaterialName_Agg5;
        totalMaterialPrinter1.Name_AGG6 = objMtctFullPrinter.MaterialName_Agg6;
        totalMaterialPrinter1.Name_CE1 = objMtctFullPrinter.MaterialName_Ce1;
        totalMaterialPrinter1.Name_CE2 = objMtctFullPrinter.MaterialName_Ce2;
        totalMaterialPrinter1.Name_CE3 = objMtctFullPrinter.MaterialName_Ce3;
        totalMaterialPrinter1.Name_CE4 = objMtctFullPrinter.MaterialName_Ce4;
        totalMaterialPrinter1.Name_CE5 = objMtctFullPrinter.MaterialName_Ce5;
        totalMaterialPrinter1.Name_WA1 = objMtctFullPrinter.MaterialName_Wa1;
        totalMaterialPrinter1.Name_WA2 = objMtctFullPrinter.MaterialName_Wa2;
        totalMaterialPrinter1.Name_ADD1 = objMtctFullPrinter.MaterialName_Add1;
        totalMaterialPrinter1.Name_ADD2 = objMtctFullPrinter.MaterialName_Add2;
        totalMaterialPrinter1.Name_ADD3 = objMtctFullPrinter.MaterialName_Add3;
        totalMaterialPrinter1.Name_ADD4 = objMtctFullPrinter.MaterialName_Add4;
        totalMaterialPrinter1.Name_ADD5 = objMtctFullPrinter.MaterialName_Add5;
        totalMaterialPrinter1.Name_ADD6 = objMtctFullPrinter.MaterialName_Add6;
      }
      toLst.Add(totalMaterialPrinter1);
    }

    private void CreateTaableData(
      int numAgg,
      int numCe,
      int numWa,
      int numAdd,
      BindingList<ObjMTCTFullPrinter> _lstFullPrinter)
    {
      this.bandedGridView1.Bands["Agg1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg1;
      this.bandedGridView1.Bands["Agg2"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg2;
      this.bandedGridView1.Bands["Agg3"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg3;
      this.bandedGridView1.Bands["Agg4"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg4;
      this.bandedGridView1.Bands["Agg5"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg5;
      this.bandedGridView1.Bands["Agg6"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg6;
      this.bandedGridView1.Bands["Ce1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce1;
      this.bandedGridView1.Bands["Ce2"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce2;
      this.bandedGridView1.Bands["Ce3"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce3;
      this.bandedGridView1.Bands["Ce4"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce4;
      this.bandedGridView1.Bands["Ce5"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce5;
      this.bandedGridView1.Bands["Wa1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Wa1;
      this.bandedGridView1.Bands["Wa2"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Wa2;
      this.bandedGridView1.Bands["Add1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add1;
      this.bandedGridView1.Bands["Add2"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add2;
      this.bandedGridView1.Bands["Add3"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add3;
      this.bandedGridView1.Bands["Add4"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add4;
      this.bandedGridView1.Bands["Add5"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add5;
      this.bandedGridView1.Bands["Add6"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add6;
      this.head_Agg1 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg1;
      this.head_Agg2 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg2;
      this.head_Agg3 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg3;
      this.head_Agg4 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg4;
      this.head_Agg5 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg5;
      this.head_Agg6 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg6;
      this.head_Ce1 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce1;
      this.head_Ce2 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce2;
      this.head_Ce3 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce3;
      this.head_Ce4 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce4;
      this.head_Ce5 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce5;
      this.head_Wa1 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Wa1;
      this.head_Wa2 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Wa2;
      this.head_Add1 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add1;
      this.head_Add2 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add2;
      this.head_Add3 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add3;
      this.head_Add4 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add4;
      this.head_Add5 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add5;
      this.head_Add6 = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add6;
      List<GridBand> gridBandList1 = new List<GridBand>();
      gridBandList1.Add(this.bandedGridView1.Bands["Agg1"]);
      gridBandList1.Add(this.bandedGridView1.Bands["Agg2"]);
      gridBandList1.Add(this.bandedGridView1.Bands["Agg3"]);
      gridBandList1.Add(this.bandedGridView1.Bands["Agg4"]);
      gridBandList1.Add(this.bandedGridView1.Bands["Agg5"]);
      gridBandList1.Add(this.bandedGridView1.Bands["Agg6"]);
      foreach (GridBand gridBand in gridBandList1)
        gridBand.Visible = false;
      for (int index = 0; index < numAgg; ++index)
        gridBandList1[index].Visible = true;
      List<GridBand> gridBandList2 = new List<GridBand>();
      gridBandList2.Add(this.bandedGridView1.Bands["Ce1"]);
      gridBandList2.Add(this.bandedGridView1.Bands["Ce2"]);
      gridBandList2.Add(this.bandedGridView1.Bands["Ce3"]);
      gridBandList2.Add(this.bandedGridView1.Bands["Ce4"]);
      gridBandList2.Add(this.bandedGridView1.Bands["Ce5"]);
      foreach (GridBand gridBand in gridBandList2)
        gridBand.Visible = false;
      for (int index = 0; index < numCe; ++index)
        gridBandList2[index].Visible = true;
      List<GridBand> gridBandList3 = new List<GridBand>();
      gridBandList3.Add(this.bandedGridView1.Bands["Wa1"]);
      gridBandList3.Add(this.bandedGridView1.Bands["Wa2"]);
      foreach (GridBand gridBand in gridBandList3)
        gridBand.Visible = false;
      for (int index = 0; index < numWa; ++index)
        gridBandList3[index].Visible = true;
      List<GridBand> gridBandList4 = new List<GridBand>();
      gridBandList4.Add(this.bandedGridView1.Bands["Add1"]);
      gridBandList4.Add(this.bandedGridView1.Bands["Add2"]);
      gridBandList4.Add(this.bandedGridView1.Bands["Add3"]);
      gridBandList4.Add(this.bandedGridView1.Bands["Add4"]);
      gridBandList4.Add(this.bandedGridView1.Bands["Add5"]);
      gridBandList4.Add(this.bandedGridView1.Bands["Add6"]);
      foreach (GridBand gridBand in gridBandList4)
        gridBand.Visible = false;
      for (int index = 0; index < numAdd; ++index)
        gridBandList4[index].Visible = true;
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      this.ClearDataPhieuTron();
      this.LoadPhieuTron();
    }

    private void LoadPhieuTron()
    {
      this._presenter.ListPhieuTron(string.Empty, Searching.BuildNew_StartDateTime(this.datTuNgay.DateTime, this.tseFromTime.TimeSpan), Searching.BuildNew_EndDateTime(this.datDenNgay.DateTime, this.tseToTime.TimeSpan), new int?(-1), new bool?());
    }

    private void btnLamMoi_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void grvPhieuTron_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      this.DoFocusPhieuTron();
    }

    private void bandedGridView1_RowStyle(object sender, RowStyleEventArgs e)
    {
      if (e.RowHandle == 0)
      {
        e.Appearance.BackColor = Color.OrangeRed;
        e.Appearance.BackColor2 = Color.MistyRose;
      }
      if (e.RowHandle == 1)
      {
        e.Appearance.BackColor = Color.Orange;
        e.Appearance.BackColor2 = Color.SeaShell;
      }
      if (e.RowHandle != 2)
        return;
      e.Appearance.BackColor = Color.Yellow;
      e.Appearance.BackColor2 = Color.LightYellow;
    }

    private void grvTotalMaterial_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
    {
      if (e.SummaryProcess != CustomSummaryProcess.Finalize || !(e.Item is GridColumnSummaryItem columnSummaryItem) || !(columnSummaryItem.FieldName == "Total_PV_Agg2"))
        return;
      double num = 246.0;
      e.TotalValue = (object) num;
      e.TotalValueReady = true;
    }

    private void GetParam()
    {
      this._paramListTong.Clear();
      this._paramListTong.Add(ConfigManager.TramTronConfig.TenCty);
      this._paramListTong.Add(this.datNgayTron.Text);
      this._paramListTong.Add(this.txtTenCongTruong.Text);
      this._paramListTong.Add(this.txtTenKhachHang.Text);
      this._paramListTong.Add(this.txtTenMAC.Text);
      this._paramListTong.Add(this.txtCuongDo.Text);
      this._paramListTong.Add(this.txtSoPhieu.Text);
      this._paramListTong.Add("Max 200");
      this._paramListTong.Add(this.txtDoSut.Text);
      this._paramListTong.Add(this.txtTaiXe.Text);
      this._paramListTong.Add(this.txtTheTich.Text);
      this._paramListTong.Add(this.txtKhoiLuongDatHang.Text);
      this._paramListTong.Add(this.txtLuyKe.Text);
      this._paramListTong.Add(this.txtXe.Text);
      this._paramListTong.Add(this.txtGioTron.Text);
      this._paramListTong.Add(this.txtDiaDiem.Text);
      this._paramListTong.Add(this.txtMaPhieuTron.Text);
      this._paramListTong.Add("1.5");
      this._paramListTong.Add(this.txtHangMuc.Text);
      this._paramListTong.Add(this.txtNiemChi.Text);
      this._paramListTong.Add(this.txtNguoiTron.Text);
      this._paramListTong.Add(this.txtGioKTTron.Text);
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
      List<int> targetColumn = new List<int>();
      List<string> headerText = new List<string>();
      List<Decimal> numList1 = new List<Decimal>();
      this.GetParam();
      this.GetBandSiloActive(targetColumn, headerText, numList1);
      Array.Empty<int>();
      int[] array = targetColumn.ToArray();
      List<string> stringList = new List<string>();
      List<string> headerTextList = headerText;
      List<Decimal> numList2 = new List<Decimal>();
      PhieuTronChiTietRP1 phieuTronChiTietRp1 = new PhieuTronChiTietRP1(this._paramListTong, numList1, headerTextList, this._tablePTCT, this.sum_CP, array);
      PdfExportOptions pdf = phieuTronChiTietRp1.ExportOptions.Pdf;
      pdf.Compressed = false;
      pdf.ConvertImagesToJpeg = false;
      string str = Path.Combine(ConfigManager.TramTronConfig.ReportPath, "RptMTCT.pdf");
      if (!File.Exists(str))
      {
        phieuTronChiTietRp1.ExportToPdf(str);
        Process.Start(str);
      }
      else if (PrinterPheuTronChiTiet.IsFileOpen(str))
      {
        TramTromMessageBox.ShowWarningDialog(string.Format("{0} đang mở bởi một chương trình khác \n Vui lòng tắt {0} đang mở.", (object) str));
      }
      else
      {
        File.Delete(str);
        phieuTronChiTietRp1.ExportToPdf(str);
        Process.Start(str);
      }
    }

    private void GetBandSiloActive(
      List<int> targetColumn,
      List<string> headerText,
      List<Decimal> totalText)
    {
      targetColumn.Add(0);
      targetColumn.Add(1);
      headerText.Add("LnNo");
      headerText.Add("Thể tích");
      totalText.Add(0M);
      totalText.Add(this.sum_KL);
      if (this.bandedGridView1.Bands["Agg1"].ReallyVisible)
      {
        targetColumn.Add(2);
        headerText.Add(this.head_Agg1);
        totalText.Add(this.sum_Agg1);
      }
      if (this.bandedGridView1.Bands["Agg2"].ReallyVisible)
      {
        targetColumn.Add(4);
        headerText.Add(this.head_Agg2);
        totalText.Add(this.sum_Agg2);
      }
      if (this.bandedGridView1.Bands["Agg3"].ReallyVisible)
      {
        targetColumn.Add(6);
        headerText.Add(this.head_Agg3);
        totalText.Add(this.sum_Agg3);
      }
      if (this.bandedGridView1.Bands["Agg4"].ReallyVisible)
      {
        targetColumn.Add(8);
        headerText.Add(this.head_Agg4);
        totalText.Add(this.sum_Agg4);
      }
      if (this.bandedGridView1.Bands["Agg5"].ReallyVisible)
      {
        targetColumn.Add(10);
        headerText.Add(this.head_Agg5);
        totalText.Add(this.sum_Agg5);
      }
      if (this.bandedGridView1.Bands["Agg6"].ReallyVisible)
      {
        targetColumn.Add(12);
        headerText.Add(this.head_Agg6);
        totalText.Add(this.sum_Agg6);
      }
      if (this.bandedGridView1.Bands["Ce1"].ReallyVisible)
      {
        targetColumn.Add(14);
        headerText.Add(this.head_Ce1);
        totalText.Add(this.sum_Ce1);
      }
      if (this.bandedGridView1.Bands["Ce2"].ReallyVisible)
      {
        targetColumn.Add(16);
        headerText.Add(this.head_Ce2);
        totalText.Add(this.sum_Ce2);
      }
      if (this.bandedGridView1.Bands["Ce3"].ReallyVisible)
      {
        targetColumn.Add(18);
        headerText.Add(this.head_Ce3);
        totalText.Add(this.sum_Ce3);
      }
      if (this.bandedGridView1.Bands["Ce4"].ReallyVisible)
      {
        targetColumn.Add(20);
        headerText.Add(this.head_Ce4);
        totalText.Add(this.sum_Ce4);
      }
      if (this.bandedGridView1.Bands["Ce5"].ReallyVisible)
      {
        targetColumn.Add(22);
        headerText.Add(this.head_Ce5);
        totalText.Add(this.sum_Ce5);
      }
      if (this.bandedGridView1.Bands["Wa1"].ReallyVisible)
      {
        targetColumn.Add(24);
        headerText.Add(this.head_Wa1);
        totalText.Add(this.sum_Wa1);
      }
      if (this.bandedGridView1.Bands["Wa2"].ReallyVisible)
      {
        targetColumn.Add(26);
        headerText.Add(this.head_Wa2);
        totalText.Add(this.sum_Wa2);
      }
      if (this.bandedGridView1.Bands["Add1"].ReallyVisible)
      {
        targetColumn.Add(28);
        headerText.Add(this.head_Add1);
        totalText.Add(this.sum_Add1);
      }
      if (this.bandedGridView1.Bands["Add2"].ReallyVisible)
      {
        targetColumn.Add(30);
        headerText.Add(this.head_Add2);
        totalText.Add(this.sum_Add2);
      }
      if (this.bandedGridView1.Bands["Add3"].ReallyVisible)
      {
        targetColumn.Add(32);
        headerText.Add(this.head_Add3);
        totalText.Add(this.sum_Add3);
      }
      if (this.bandedGridView1.Bands["Add4"].ReallyVisible)
      {
        targetColumn.Add(34);
        headerText.Add(this.head_Add4);
        totalText.Add(this.sum_Add4);
      }
      if (this.bandedGridView1.Bands["Add5"].ReallyVisible)
      {
        targetColumn.Add(36);
        headerText.Add(this.head_Add5);
        totalText.Add(this.sum_Add5);
      }
      if (!this.bandedGridView1.Bands["Add6"].ReallyVisible)
        return;
      targetColumn.Add(38);
      headerText.Add(this.head_Add6);
      totalText.Add(this.sum_Add6);
    }

    private static bool IsFileOpen(string filePath)
    {
      try
      {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
          fileStream.Close();
        return false;
      }
      catch (IOException ex)
      {
        return true;
      }
    }

    private void DataTableToDataTable(DataTable fromTable, DataTable toTable)
    {
      toTable = new DataTable();
      foreach (DataColumn column in (InternalDataCollectionBase) fromTable.Columns)
        toTable.Columns.Add(new DataColumn(column.ColumnName, column.DataType));
      foreach (DataRow row1 in (InternalDataCollectionBase) fromTable.Rows)
      {
        DataRow row2 = toTable.NewRow();
        row2.ItemArray = row1.ItemArray;
        toTable.Rows.Add(row2);
      }
    }

    private void WriteDetailInvoice(
      List<string> param,
      DataTable dataTable,
      DataTable dataTable2,
      DataTable dataTable3)
    {
      try
      {
        if (!this.CopyTempFile() || this._error)
          return;
        string pictPath1 = ConfigManager.TramTronConfig.PICTPath;
        string path2 = "";
        string pictPath2 = ConfigManager.TramTronConfig.PICTPath;
        if (pictPath2 != string.Empty)
          path2 = Path.GetFileName(pictPath2);
        string str = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
        // ISSUE: variable of a compiler-generated type
        Documents documents = instance.Documents;
        object obj1 = (object) str;
        ref object local1 = ref obj1;
        object missing1 = Type.Missing;
        ref object local2 = ref missing1;
        object missing2 = Type.Missing;
        ref object local3 = ref missing2;
        object missing3 = Type.Missing;
        ref object local4 = ref missing3;
        object missing4 = Type.Missing;
        ref object local5 = ref missing4;
        object missing5 = Type.Missing;
        ref object local6 = ref missing5;
        object missing6 = Type.Missing;
        ref object local7 = ref missing6;
        object missing7 = Type.Missing;
        ref object local8 = ref missing7;
        object missing8 = Type.Missing;
        ref object local9 = ref missing8;
        object missing9 = Type.Missing;
        ref object local10 = ref missing9;
        object missing10 = Type.Missing;
        ref object local11 = ref missing10;
        object missing11 = Type.Missing;
        ref object local12 = ref missing11;
        object missing12 = Type.Missing;
        ref object local13 = ref missing12;
        object missing13 = Type.Missing;
        ref object local14 = ref missing13;
        object obj2 = Type.Missing;
        ref object local15 = ref obj2;
        object obj3 = Type.Missing;
        ref object local16 = ref obj3;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Document doc = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
        for (int index = 0; index < param.Count; ++index)
        {
          string searchText = "{" + index.ToString() + "}";
          this.ReplaceText(instance, searchText, param[index]);
        }
        this.CreateTablePICT(doc, dataTable, dataTable2, dataTable3);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Document activeDocument = instance.ActiveDocument;
        obj3 = (object) str;
        ref object local17 = ref obj3;
        obj2 = (object) 12;
        ref object local18 = ref obj2;
        missing13 = Type.Missing;
        ref object local19 = ref missing13;
        missing12 = Type.Missing;
        ref object local20 = ref missing12;
        missing11 = Type.Missing;
        ref object local21 = ref missing11;
        missing10 = Type.Missing;
        ref object local22 = ref missing10;
        missing9 = Type.Missing;
        ref object local23 = ref missing9;
        missing8 = Type.Missing;
        ref object local24 = ref missing8;
        missing7 = Type.Missing;
        ref object local25 = ref missing7;
        missing6 = Type.Missing;
        ref object local26 = ref missing6;
        object missing14 = Type.Missing;
        ref object local27 = ref missing14;
        object missing15 = Type.Missing;
        ref object local28 = ref missing15;
        object missing16 = Type.Missing;
        ref object local29 = ref missing16;
        object missing17 = Type.Missing;
        ref object local30 = ref missing17;
        object missing18 = Type.Missing;
        ref object local31 = ref missing18;
        object missing19 = Type.Missing;
        ref object local32 = ref missing19;
        // ISSUE: reference to a compiler-generated method
        activeDocument.SaveAs(ref local17, ref local18, ref local19, ref local20, ref local21, ref local22, ref local23, ref local24, ref local25, ref local26, ref local27, ref local28, ref local29, ref local30, ref local31, ref local32);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application application = instance;
        missing19 = Type.Missing;
        ref object local33 = ref missing19;
        missing18 = Type.Missing;
        ref object local34 = ref missing18;
        missing17 = Type.Missing;
        ref object local35 = ref missing17;
        // ISSUE: reference to a compiler-generated method
        application.Quit(ref local33, ref local34, ref local35);
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void ReplaceText(Microsoft.Office.Interop.Word.Application word, string searchText, string replacementText)
    {
      // ISSUE: variable of a compiler-generated type
      Find find = word.Selection.Find;
      // ISSUE: reference to a compiler-generated method
      find.ClearFormatting();
      find.Text = searchText;
      // ISSUE: variable of a compiler-generated type
      Replacement replacement = find.Replacement;
      // ISSUE: reference to a compiler-generated method
      replacement.ClearFormatting();
      replacement.Text = replacementText;
      object obj = (object) Missing.Value;
      object Replace = (object) WdReplace.wdReplaceAll;
      // ISSUE: reference to a compiler-generated method
      find.Execute(ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref obj, ref Replace, ref obj, ref obj, ref obj, ref obj);
    }

    private bool CopyTempFile()
    {
      string pictPath1 = ConfigManager.TramTronConfig.PICTPath;
      string path2 = "";
      string pictPath2 = ConfigManager.TramTronConfig.PICTPath;
      if (pictPath2 != string.Empty)
        path2 = Path.GetFileName(pictPath2);
      string str = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
      try
      {
        if (!File.Exists(str))
          File.Copy(pictPath1, str, true);
        this._error = false;
      }
      catch (System.Exception ex)
      {
        this._error = true;
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      return true;
    }

    private void btnInPCT_Click(object sender, EventArgs e) => this.PrintPTFromFile_NewTread();

    private DataTable CreateTableNameMaterial(DataTable yourSourceDataTable)
    {
      List<string> nameMaterialSumCol = this.GetNameMaterialSumCol();
      DataTable tableNameMaterial = new DataTable();
      tableNameMaterial.Columns.Add("LnNo", typeof (string));
      tableNameMaterial.Columns.Add("KLTungMe", typeof (string));
      foreach (string str in nameMaterialSumCol)
      {
        if (yourSourceDataTable.Columns.Contains(str))
          tableNameMaterial.Columns.Add(str, yourSourceDataTable.Columns[str].DataType);
        else
          tableNameMaterial.Columns.Add(str, typeof (string));
      }
      foreach (DataRow row1 in (InternalDataCollectionBase) yourSourceDataTable.Rows)
      {
        DataRow row2 = tableNameMaterial.NewRow();
        row2["LnNo"] = (object) "LnNo";
        row2["KLTungMe"] = (object) "Thể tích";
        foreach (string str in nameMaterialSumCol)
        {
          if (yourSourceDataTable.Columns.Contains(str))
          {
            int columnIndex = yourSourceDataTable.Columns.IndexOf(str);
            row2[str] = row1[columnIndex];
          }
          else
            row2[str] = (object) "N/A";
        }
        tableNameMaterial.Rows.Add(row2);
      }
      return tableNameMaterial;
    }

    private DataTable CreateTableSumMaterial(DataTable yourSourceDataTable)
    {
      List<string> sumMaterial = this.GetSumMaterial();
      DataTable tableSumMaterial = new DataTable();
      tableSumMaterial.Columns.Add("LnNo", typeof (string));
      tableSumMaterial.Columns.Add("KLTungMe", typeof (string));
      foreach (string str in sumMaterial)
      {
        if (yourSourceDataTable.Columns.Contains(str))
          tableSumMaterial.Columns.Add(str, yourSourceDataTable.Columns[str].DataType);
        else
          tableSumMaterial.Columns.Add(str, typeof (string));
      }
      foreach (DataRow row1 in (InternalDataCollectionBase) yourSourceDataTable.Rows)
      {
        DataRow row2 = tableSumMaterial.NewRow();
        row2["LnNo"] = (object) "N/A";
        row2["KLTungMe"] = (object) this.sum_KL;
        foreach (string str in sumMaterial)
        {
          if (yourSourceDataTable.Columns.Contains(str))
          {
            int columnIndex = yourSourceDataTable.Columns.IndexOf(str);
            row2[str] = row1[columnIndex];
          }
          else
            row2[str] = (object) "N/A";
        }
        tableSumMaterial.Rows.Add(row2);
      }
      return tableSumMaterial;
    }

    private List<string> GetNameMaterialSumCol()
    {
      string[] strArray1 = new string[6]
      {
        "Name_AGG1",
        "Name_AGG2",
        "Name_AGG3",
        "Name_AGG4",
        "Name_AGG5",
        "Name_AGG6"
      };
      string[] strArray2 = new string[5]
      {
        "Name_CE1",
        "Name_CE2",
        "Name_CE3",
        "Name_CE4",
        "Name_CE5"
      };
      string[] strArray3 = new string[2]
      {
        "Name_WA1",
        "Name_WA2"
      };
      string[] strArray4 = new string[6]
      {
        "Name_ADD1",
        "Name_ADD2",
        "Name_ADD3",
        "Name_ADD4",
        "Name_ADD5",
        "Name_ADD6"
      };
      List<string> nameMaterialSumCol = new List<string>();
      for (int index = 0; index < this.num_silo_Agg; ++index)
        nameMaterialSumCol.Add(strArray1[index]);
      for (int index = 0; index < this.num_silo_Ce; ++index)
        nameMaterialSumCol.Add(strArray2[index]);
      for (int index = 0; index < this.num_silo_Wa; ++index)
        nameMaterialSumCol.Add(strArray3[index]);
      for (int index = 0; index < this.num_silo_Add; ++index)
        nameMaterialSumCol.Add(strArray4[index]);
      return nameMaterialSumCol;
    }

    private List<string> GetSumMaterial()
    {
      string[] strArray1 = new string[6]
      {
        "Total_PV_Agg1",
        "Total_PV_Agg2",
        "Total_PV_Agg3",
        "Total_PV_Agg4",
        "Total_PV_Agg5",
        "Total_PV_Agg6"
      };
      string[] strArray2 = new string[5]
      {
        "Total_PV_Ce1",
        "Total_PV_Ce2",
        "Total_PV_Ce3",
        "Total_PV_Ce4",
        "Total_PV_Ce5"
      };
      string[] strArray3 = new string[2]
      {
        "Total_PV_Wa1",
        "Total_PV_Wa2"
      };
      string[] strArray4 = new string[6]
      {
        "Total_PV_Add1",
        "Total_PV_Add2",
        "Total_PV_Add3",
        "Total_PV_Add4",
        "Total_PV_Add5",
        "Total_PV_Add6"
      };
      List<string> sumMaterial = new List<string>();
      for (int index = 0; index < this.num_silo_Agg; ++index)
        sumMaterial.Add(strArray1[index]);
      for (int index = 0; index < this.num_silo_Ce; ++index)
        sumMaterial.Add(strArray2[index]);
      for (int index = 0; index < this.num_silo_Wa; ++index)
        sumMaterial.Add(strArray3[index]);
      for (int index = 0; index < this.num_silo_Add; ++index)
        sumMaterial.Add(strArray4[index]);
      return sumMaterial;
    }

    private void PrintPTFromFile_NewTread()
    {
      new Thread(new ThreadStart(this.PrintPTFromFile)).Start();
    }

    private void PrintPTFromFile()
    {
      this.dataTableNameMaterial = this.CreateTableNameMaterial(this.dataTableMaterial);
      this.dataTableSumMaterial = this.CreateTableSumMaterial(this.dataTableMaterial);
      this.GetParam();
      this.WriteDetailInvoice(this._paramListTong, this._tablePTCT, this.dataTableNameMaterial, this.dataTableSumMaterial);
      try
      {
        this.numberOfCopies = (int) this.spin_numberOfCopies.Value;
        string pictPath1 = ConfigManager.TramTronConfig.PICTPath;
        string path2 = "";
        string pictPath2 = ConfigManager.TramTronConfig.PICTPath;
        if (pictPath2 != string.Empty)
          path2 = Path.GetFileName(pictPath2);
        string path = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
        string pdfFilePath = Path.ChangeExtension(path, ".pdf");
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
        // ISSUE: variable of a compiler-generated type
        Documents documents = instance.Documents;
        object obj1 = (object) path;
        ref object local1 = ref obj1;
        object missing1 = Type.Missing;
        ref object local2 = ref missing1;
        object missing2 = Type.Missing;
        ref object local3 = ref missing2;
        object missing3 = Type.Missing;
        ref object local4 = ref missing3;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Document o = documents.Add(ref local1, ref local2, ref local3, ref local4);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Document activeDocument = instance.ActiveDocument;
        string OutputFileName = pdfFilePath;
        object missing4 = Type.Missing;
        ref object local5 = ref missing4;
        // ISSUE: reference to a compiler-generated method
        activeDocument.ExportAsFixedFormat(OutputFileName, WdExportFormat.wdExportFormatPDF, FixedFormatExtClassPtr: ref local5);
        object obj2 = (object) false;
        ref object local6 = ref obj2;
        object missing5 = Type.Missing;
        ref object local7 = ref missing5;
        object missing6 = Type.Missing;
        ref object local8 = ref missing6;
        // ISSUE: reference to a compiler-generated method
        o.Close(ref local6, ref local7, ref local8);
        Marshal.ReleaseComObject((object) o);
        if (File.Exists(path))
        {
          try
          {
            File.Delete(path);
            this.PrinterInvoke(pdfFilePath, this.numberOfCopies);
          }
          catch (System.Exception ex)
          {
            Console.WriteLine("Lỗi khi xóa tệp tin Word: " + ex.Message);
            TramTronLogger.WriteError(ex);
          }
        }
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application application = instance;
        missing6 = Type.Missing;
        ref object local9 = ref missing6;
        object missing7 = Type.Missing;
        ref object local10 = ref missing7;
        object missing8 = Type.Missing;
        ref object local11 = ref missing8;
        // ISSUE: reference to a compiler-generated method
        application.Quit(ref local9, ref local10, ref local11);
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    public bool PrinterInvoke(string pdfFilePath, int numberOfCopies)
    {
      try
      {
        Task[] taskArray = new Task[numberOfCopies];
        for (int index = 0; index < numberOfCopies; ++index)
          taskArray[index] = Task.Run((Action) (() => Support.PrintReport(pdfFilePath)));
        Task.WaitAll(taskArray);
        this.btnPrint.Enabled = true;
        return true;
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      return false;
    }

    private async void PrintPDF(string pdfFilePath, int numberOfCopies)
    {
      try
      {
        for (int i = 0; i < numberOfCopies; ++i)
        {
          ProcessStartInfo processStartInfo = new ProcessStartInfo()
          {
            Verb = "printto",
            FileName = pdfFilePath,
            UseShellExecute = true,
            Arguments = "\"" + this.printerName + "\""
          };
          using (Process process = new Process()
          {
            StartInfo = processStartInfo
          })
          {
            process.Start();
            while (!process.HasExited)
              await Task.Delay(100);
          }
        }
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("Lỗi khi in file PDF: " + ex.Message);
        TramTronLogger.WriteError(ex);
      }
    }

    private void LoadDataToTable(Microsoft.Office.Interop.Word.Application word, DataTable dataTable)
    {
      if (word.Documents.Count <= 0)
        return;
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Word.Document activeDocument = word.ActiveDocument;
      if (activeDocument.Tables.Count <= 0)
        return;
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Word.Table table = activeDocument.Tables[1];
      int count1 = dataTable.Rows.Count;
      int count2 = dataTable.Columns.Count;
      for (int index = 0; index < count1; ++index)
      {
        // ISSUE: variable of a compiler-generated type
        Rows rows = table.Rows;
        object missing = Type.Missing;
        ref object local = ref missing;
        // ISSUE: reference to a compiler-generated method
        rows.Add(ref local);
        int num = 0;
        while (num < count2)
          ++num;
      }
    }

    private void CreateTablePICT(
      Microsoft.Office.Interop.Word.Document doc,
      DataTable dataTable,
      DataTable dataTable2,
      DataTable dataTable3)
    {
      List<string> stringList = new List<string>();
      int Index = 0;
      for (int index = 0; index < dataTable.Columns.Count; ++index)
      {
        if (index < 2)
        {
          stringList.Add(dataTable.Columns[index].ColumnName);
          ++Index;
        }
        else if (Convert.ToDouble(dataTable.Rows[0][index]) != 0.0)
        {
          stringList.Add(dataTable.Columns[index].ColumnName);
          ++Index;
        }
      }
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Word.Table table = doc.Tables[2];
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Cell cell1 = table.Cell(1, 1);
      object obj1 = (object) 1;
      ref object local1 = ref obj1;
      object obj2 = (object) Index;
      ref object local2 = ref obj2;
      ref object local3 = ref local1;
      ref object local4 = ref local2;
      // ISSUE: reference to a compiler-generated method
      cell1.Split(ref local3, ref local4);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Cell cell2 = table.Cell(2, 1);
      object obj3 = (object) 1;
      ref object local5 = ref obj3;
      object obj4 = (object) Index;
      ref object local6 = ref obj4;
      ref object local7 = ref local5;
      ref object local8 = ref local6;
      // ISSUE: reference to a compiler-generated method
      cell2.Split(ref local7, ref local8);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Cell cell3 = table.Cell(3, 1);
      object obj5 = (object) 1;
      ref object local9 = ref obj5;
      object obj6 = (object) Index;
      ref object local10 = ref obj6;
      ref object local11 = ref local9;
      ref object local12 = ref local10;
      // ISSUE: reference to a compiler-generated method
      cell3.Split(ref local11, ref local12);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Cell cell4 = table.Cell(4, 1);
      object obj7 = (object) 1;
      ref object local13 = ref obj7;
      object obj8 = (object) Index;
      ref object local14 = ref obj8;
      ref object local15 = ref local13;
      ref object local16 = ref local14;
      // ISSUE: reference to a compiler-generated method
      cell4.Split(ref local15, ref local16);
      // ISSUE: reference to a compiler-generated method
      table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitFixed);
      table.Range.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
      table.Range.Font.Size = 9f;
      table.Range.Font.Name = "Times New Roman";
      object prop = (object) "Table Grid";
      object missing = Type.Missing;
      // ISSUE: reference to a compiler-generated method
      table.set_Style(ref prop);
      for (int index = 0; index < Index; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        table.Cell(1, index + 1).Range.Text = dataTable2.Rows[0][index].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(1, index + 1).Range.Bold = 1;
        // ISSUE: reference to a compiler-generated method
        table.Cell(2, index + 1).Range.Text = dataTable.Rows[0][stringList[index]].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(2, 1).Range.Bold = 1;
        // ISSUE: reference to a compiler-generated method
        table.Cell(3, index + 1).Range.Text = dataTable.Rows[1][stringList[index]].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(3, 1).Range.Bold = 1;
        // ISSUE: reference to a compiler-generated method
        table.Cell(4, index + 1).Range.Text = dataTable.Rows[2][stringList[index]].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(4, 1).Range.Bold = 1;
      }
      // ISSUE: reference to a compiler-generated method
      table.Rows.Add(ref missing);
      int num1 = 4 + 1;
      // ISSUE: reference to a compiler-generated method
      table.Rows.Add(ref missing);
      int Row = num1 + 1;
      for (int index1 = 3; index1 < dataTable.Rows.Count; ++index1)
      {
        for (int index2 = 0; index2 < Index; ++index2)
        {
          // ISSUE: reference to a compiler-generated method
          table.Cell(Row, index2 + 1).Range.Text = dataTable.Rows[index1][stringList[index2]].ToString();
        }
        // ISSUE: reference to a compiler-generated method
        table.Rows.Add(ref missing);
        ++Row;
      }
      dataTable.Rows.Remove(dataTable.Rows[0]);
      dataTable.Rows.Remove(dataTable.Rows[0]);
      dataTable.Rows.Remove(dataTable.Rows[0]);
      float num2 = 0.0f;
      for (int index = 1; index < Index; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        table.Cell(Row, index + 1).Range.Text = dataTable3.Rows[0][index].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(Row, index + 1).Range.Bold = 1;
        if (index > 1)
          num2 += Convert.ToSingle(dataTable.Compute("SUM([" + stringList[index] + "])", ""));
      }
      // ISSUE: reference to a compiler-generated method
      table.Cell(Row, 1).Range.Text = "Tổng";
      // ISSUE: reference to a compiler-generated method
      table.Rows.Add(ref missing);
      int num3 = Row + 1;
      // ISSUE: reference to a compiler-generated method
      table.Rows[num3].Cells[1].Merge(table.Rows[num3].Cells[Index]);
      // ISSUE: reference to a compiler-generated method
      table.Cell(num3, 1).Range.Text = num2.ToString();
      // ISSUE: reference to a compiler-generated method
      table.Cell(num3, 1).Range.Bold = 1;
      // ISSUE: reference to a compiler-generated method
      table.Cell(num3, 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
      // ISSUE: reference to a compiler-generated method
      table.Rows[5].Cells[1].Merge(table.Rows[5].Cells[Index]);
      // ISSUE: reference to a compiler-generated method
      table.Cell(5, 1).Range.Text = "CHI TIẾT MẺ TRỘN (DETAIL)";
      // ISSUE: reference to a compiler-generated method
      table.Cell(5, 1).Range.Bold = 1;
      // ISSUE: reference to a compiler-generated method
      table.Cell(5, 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
      table.Rows[5].Alignment = WdRowAlignment.wdAlignRowLeft;
    }

    private float ConvertToFloat(object value)
    {
      float result;
      return value == null || DBNull.Value.Equals(value) || !float.TryParse(value.ToString(), out result) ? 0.0f : result;
    }

    private void spin_numberOfCopies_EditValueChanged(object sender, EventArgs e)
    {
      this.numberOfCopies = (int) this.spin_numberOfCopies.Value;
    }

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
      this.groupControl1.Controls.Add((Control) this.tseToTime);
      this.groupControl1.Controls.Add((Control) this.tseFromTime);
      this.groupControl1.Controls.Add((Control) this.btnLamMoi);
      this.groupControl1.Controls.Add((Control) this.lookupEditPrinters);
      this.groupControl1.Controls.Add((Control) this.btnTimKiem);
      this.groupControl1.Controls.Add((Control) this.datDenNgay);
      this.groupControl1.Controls.Add((Control) this.datTuNgay);
      this.groupControl1.Controls.Add((Control) this.labelControl4);
      this.groupControl1.Controls.Add((Control) this.labelControl3);
      this.groupControl1.Location = new Point(3, 3);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(1138, 74);
      this.groupControl1.TabIndex = 5;
      this.groupControl1.Text = "Tìm kiếm";
      this.tseToTime.EditValue = (object) TimeSpan.Parse("00:00:00");
      this.tseToTime.Location = new Point(471, 37);
      this.tseToTime.Name = "tseToTime";
      this.tseToTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tseToTime.Properties.Appearance.Options.UseFont = true;
      this.tseToTime.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tseToTime.Size = new Size(56, 22);
      this.tseToTime.TabIndex = 81;
      this.tseFromTime.EditValue = (object) TimeSpan.Parse("00:00:00");
      this.tseFromTime.Location = new Point(216, 37);
      this.tseFromTime.Name = "tseFromTime";
      this.tseFromTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tseFromTime.Properties.Appearance.Options.UseFont = true;
      this.tseFromTime.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.tseFromTime.Size = new Size(56, 22);
      this.tseFromTime.TabIndex = 80;
      this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnTimKiem.Appearance.Options.UseFont = true;
      this.btnTimKiem.Location = new Point(550, 30);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new Size(105, 35);
      this.btnTimKiem.TabIndex = 4;
      this.btnTimKiem.Text = "Tìm";
      this.btnTimKiem.Click += new EventHandler(this.btnTimKiem_Click);
      this.datDenNgay.Location = new Point(365, 37);
      this.datDenNgay.Name = "datDenNgay";
      this.datDenNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.datTuNgay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.Location = new Point(300, 40);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(54, 16);
      this.labelControl4.TabIndex = 1;
      this.labelControl4.Text = "Đến ngày";
      this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(30, 40);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(69, 16);
      this.labelControl3.TabIndex = 0;
      this.labelControl3.Text = "Tạo từ ngày";
      this.groupControl2.Controls.Add((Control) this.grcPhieuTron);
      this.groupControl2.Location = new Point(3, 83);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(328, 501);
      this.groupControl2.TabIndex = 6;
      this.groupControl2.Text = "Danh sách phiếu trộn";
      this.grcPhieuTron.Dock = DockStyle.Fill;
      this.grcPhieuTron.Location = new Point(2, 23);
      this.grcPhieuTron.MainView = (BaseView) this.grvPhieuTron;
      this.grcPhieuTron.Name = "grcPhieuTron";
      this.grcPhieuTron.Size = new Size(324, 476);
      this.grcPhieuTron.TabIndex = 0;
      this.grcPhieuTron.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvPhieuTron
      });
      this.grvPhieuTron.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.groupControl4.Controls.Add((Control) this.txtGioKTTron);
      this.groupControl4.Controls.Add((Control) this.labelControl10);
      this.groupControl4.Controls.Add((Control) this.txtSoPhieu);
      this.groupControl4.Controls.Add((Control) this.labelControl20);
      this.groupControl4.Controls.Add((Control) this.datNgayTron);
      this.groupControl4.Controls.Add((Control) this.txtGioTron);
      this.groupControl4.Controls.Add((Control) this.labelControl11);
      this.groupControl4.Controls.Add((Control) this.txtXe);
      this.groupControl4.Controls.Add((Control) this.txtTaiXe);
      this.groupControl4.Controls.Add((Control) this.labelControl18);
      this.groupControl4.Controls.Add((Control) this.labelControl19);
      this.groupControl4.Controls.Add((Control) this.txtHangMuc);
      this.groupControl4.Controls.Add((Control) this.labelControl17);
      this.groupControl4.Controls.Add((Control) this.txtDiaDiem);
      this.groupControl4.Controls.Add((Control) this.labelControl16);
      this.groupControl4.Controls.Add((Control) this.txtLuyKe);
      this.groupControl4.Controls.Add((Control) this.labelControl15);
      this.groupControl4.Controls.Add((Control) this.txtKhoiLuongDatHang);
      this.groupControl4.Controls.Add((Control) this.labelControl7);
      this.groupControl4.Controls.Add((Control) this.txtTheTich);
      this.groupControl4.Controls.Add((Control) this.labelControl14);
      this.groupControl4.Controls.Add((Control) this.txtDoSut);
      this.groupControl4.Controls.Add((Control) this.labelControl13);
      this.groupControl4.Controls.Add((Control) this.labelControl12);
      this.groupControl4.Controls.Add((Control) this.txtTenMAC);
      this.groupControl4.Controls.Add((Control) this.lblTenMAC);
      this.groupControl4.Controls.Add((Control) this.txtNguoiTron);
      this.groupControl4.Controls.Add((Control) this.txtNiemChi);
      this.groupControl4.Controls.Add((Control) this.txtCuongDo);
      this.groupControl4.Controls.Add((Control) this.txtTenCongTruong);
      this.groupControl4.Controls.Add((Control) this.txtTenKhachHang);
      this.groupControl4.Controls.Add((Control) this.txtMaPhieuTron);
      this.groupControl4.Controls.Add((Control) this.labelControl9);
      this.groupControl4.Controls.Add((Control) this.labelControl8);
      this.groupControl4.Controls.Add((Control) this.labelControl6);
      this.groupControl4.Controls.Add((Control) this.labelControl5);
      this.groupControl4.Controls.Add((Control) this.labelControl2);
      this.groupControl4.Controls.Add((Control) this.labelControl1);
      this.groupControl4.Location = new Point(337, 83);
      this.groupControl4.Name = "groupControl4";
      this.groupControl4.Size = new Size(804, 250);
      this.groupControl4.TabIndex = 8;
      this.groupControl4.Text = "Thông tin phiếu trộn";
      this.txtGioKTTron.Location = new Point(721, 57);
      this.txtGioKTTron.Name = "txtGioKTTron";
      this.txtGioKTTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtGioKTTron.Properties.Appearance.Options.UseFont = true;
      this.txtGioKTTron.Size = new Size(73, 20);
      this.txtGioKTTron.TabIndex = 46;
      this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl10.Appearance.Options.UseFont = true;
      this.labelControl10.Location = new Point(654, 60);
      this.labelControl10.Name = "labelControl10";
      this.labelControl10.Size = new Size(63, 14);
      this.labelControl10.TabIndex = 45;
      this.labelControl10.Text = "Giờ KT trộn";
      this.txtSoPhieu.Location = new Point(577, 111);
      this.txtSoPhieu.Name = "txtSoPhieu";
      this.txtSoPhieu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtSoPhieu.Properties.Appearance.Options.UseFont = true;
      this.txtSoPhieu.Size = new Size(217, 20);
      this.txtSoPhieu.TabIndex = 44;
      this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl20.Appearance.Options.UseFont = true;
      this.labelControl20.Location = new Point(496, 114);
      this.labelControl20.Name = "labelControl20";
      this.labelControl20.TabIndex = 43;
      this.labelControl20.Text = "Số Phiếu trộn";
      this.datNgayTron.Location = new Point(577, 30);
      this.datNgayTron.Name = "datNgayTron";
      this.datNgayTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.txtGioTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtGioTron.Properties.Appearance.Options.UseFont = true;
      this.txtGioTron.Size = new Size(73, 20);
      this.txtGioTron.TabIndex = 40;
      this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl11.Appearance.Options.UseFont = true;
      this.labelControl11.Location = new Point(497, 60);
      this.labelControl11.Name = "labelControl11";
      this.labelControl11.Size = new Size(63, 14);
      this.labelControl11.TabIndex = 38;
      this.labelControl11.Text = "Giờ BĐ trộn";
      this.txtXe.Location = new Point(316, 165);
      this.txtXe.Name = "txtXe";
      this.txtXe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtXe.Properties.Appearance.Options.UseFont = true;
      this.txtXe.Size = new Size(160, 20);
      this.txtXe.TabIndex = 37;
      this.txtTaiXe.Location = new Point(90, 165);
      this.txtTaiXe.Name = "txtTaiXe";
      this.txtTaiXe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTaiXe.Properties.Appearance.Options.UseFont = true;
      this.txtTaiXe.Size = new Size(160, 20);
      this.txtTaiXe.TabIndex = 36;
      this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl18.Appearance.Options.UseFont = true;
      this.labelControl18.Location = new Point(270, 168);
      this.labelControl18.Name = "labelControl18";
      this.labelControl18.Size = new Size(40, 14);
      this.labelControl18.TabIndex = 35;
      this.labelControl18.Text = "Biển xe";
      this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl19.Appearance.Options.UseFont = true;
      this.labelControl19.Location = new Point(15, 168);
      this.labelControl19.Name = "labelControl19";
      this.labelControl19.Size = new Size(33, 14);
      this.labelControl19.TabIndex = 34;
      this.labelControl19.Text = "Tài xế";
      this.txtHangMuc.Location = new Point(90, 84);
      this.txtHangMuc.Name = "txtHangMuc";
      this.txtHangMuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtHangMuc.Properties.Appearance.Options.UseFont = true;
      this.txtHangMuc.Size = new Size(386, 20);
      this.txtHangMuc.TabIndex = 33;
      this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl17.Appearance.Options.UseFont = true;
      this.labelControl17.Location = new Point(15, 86);
      this.labelControl17.Name = "labelControl17";
      this.labelControl17.Size = new Size(55, 14);
      this.labelControl17.TabIndex = 32;
      this.labelControl17.Text = "Hạng mục";
      this.txtDiaDiem.Location = new Point(90, 111);
      this.txtDiaDiem.Name = "txtDiaDiem";
      this.txtDiaDiem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDiaDiem.Properties.Appearance.Options.UseFont = true;
      this.txtDiaDiem.Size = new Size(386, 20);
      this.txtDiaDiem.TabIndex = 31;
      this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl16.Appearance.Options.UseFont = true;
      this.labelControl16.Location = new Point(15, 112);
      this.labelControl16.Name = "labelControl16";
      this.labelControl16.Size = new Size(46, 14);
      this.labelControl16.TabIndex = 30;
      this.labelControl16.Text = "Địa điểm";
      this.txtLuyKe.Location = new Point(577, 219);
      this.txtLuyKe.Name = "txtLuyKe";
      this.txtLuyKe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtLuyKe.Properties.Appearance.Options.UseFont = true;
      this.txtLuyKe.Size = new Size(217, 20);
      this.txtLuyKe.TabIndex = 29;
      this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl15.Appearance.Options.UseFont = true;
      this.labelControl15.Location = new Point(497, 222);
      this.labelControl15.Name = "labelControl15";
      this.labelControl15.Size = new Size(36, 14);
      this.labelControl15.TabIndex = 28;
      this.labelControl15.Text = "Luỹ kế";
      this.txtKhoiLuongDatHang.Location = new Point(577, 165);
      this.txtKhoiLuongDatHang.Name = "txtKhoiLuongDatHang";
      this.txtKhoiLuongDatHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtKhoiLuongDatHang.Properties.Appearance.Options.UseFont = true;
      this.txtKhoiLuongDatHang.Size = new Size(217, 20);
      this.txtKhoiLuongDatHang.TabIndex = 27;
      this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl7.Appearance.Options.UseFont = true;
      this.labelControl7.Location = new Point(497, 168);
      this.labelControl7.Name = "labelControl7";
      this.labelControl7.Size = new Size(50, 14);
      this.labelControl7.TabIndex = 26;
      this.labelControl7.Text = "Đặt hàng";
      this.txtTheTich.Location = new Point(577, 192);
      this.txtTheTich.Name = "txtTheTich";
      this.txtTheTich.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTheTich.Properties.Appearance.Options.UseFont = true;
      this.txtTheTich.Size = new Size(217, 20);
      this.txtTheTich.TabIndex = 25;
      this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl14.Appearance.Options.UseFont = true;
      this.labelControl14.Location = new Point(497, 195);
      this.labelControl14.Name = "labelControl14";
      this.labelControl14.Size = new Size(46, 14);
      this.labelControl14.TabIndex = 24;
      this.labelControl14.Text = "Thể tích";
      this.txtDoSut.Location = new Point(316, 219);
      this.txtDoSut.Name = "txtDoSut";
      this.txtDoSut.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDoSut.Properties.Appearance.Options.UseFont = true;
      this.txtDoSut.Size = new Size(160, 20);
      this.txtDoSut.TabIndex = 23;
      this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl13.Appearance.Options.UseFont = true;
      this.labelControl13.Location = new Point(274, 222);
      this.labelControl13.Name = "labelControl13";
      this.labelControl13.Size = new Size(36, 14);
      this.labelControl13.TabIndex = 22;
      this.labelControl13.Text = "Độ sụt";
      this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl12.Appearance.Options.UseFont = true;
      this.labelControl12.Location = new Point(497, 33);
      this.labelControl12.Name = "labelControl12";
      this.labelControl12.Size = new Size(54, 14);
      this.labelControl12.TabIndex = 20;
      this.labelControl12.Text = "Ngày trộn";
      this.txtTenMAC.Location = new Point(90, 192);
      this.txtTenMAC.Name = "txtTenMAC";
      this.txtTenMAC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenMAC.Properties.Appearance.Options.UseFont = true;
      this.txtTenMAC.Size = new Size(386, 20);
      this.txtTenMAC.TabIndex = 19;
      this.lblTenMAC.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenMAC.Appearance.Options.UseFont = true;
      this.lblTenMAC.Location = new Point(15, 195);
      this.lblTenMAC.Name = "lblTenMAC";
      this.lblTenMAC.Size = new Size(50, 14);
      this.lblTenMAC.TabIndex = 18;
      this.lblTenMAC.Text = "Tên MAC";
      this.txtNguoiTron.Location = new Point(90, 138);
      this.txtNguoiTron.Name = "txtNguoiTron";
      this.txtNguoiTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtNguoiTron.Properties.Appearance.Options.UseFont = true;
      this.txtNguoiTron.Size = new Size(386, 20);
      this.txtNguoiTron.TabIndex = 15;
      this.txtNiemChi.Location = new Point(577, 138);
      this.txtNiemChi.Name = "txtNiemChi";
      this.txtNiemChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtNiemChi.Properties.Appearance.Options.UseFont = true;
      this.txtNiemChi.Size = new Size(217, 20);
      this.txtNiemChi.TabIndex = 14;
      this.txtCuongDo.Location = new Point(90, 219);
      this.txtCuongDo.Name = "txtCuongDo";
      this.txtCuongDo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtCuongDo.Properties.Appearance.Options.UseFont = true;
      this.txtCuongDo.Size = new Size(160, 20);
      this.txtCuongDo.TabIndex = 12;
      this.txtTenCongTruong.Location = new Point(90, 57);
      this.txtTenCongTruong.Name = "txtTenCongTruong";
      this.txtTenCongTruong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenCongTruong.Properties.Appearance.Options.UseFont = true;
      this.txtTenCongTruong.Size = new Size(386, 20);
      this.txtTenCongTruong.TabIndex = 11;
      this.txtTenKhachHang.Location = new Point(90, 30);
      this.txtTenKhachHang.Name = "txtTenKhachHang";
      this.txtTenKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenKhachHang.Properties.Appearance.Options.UseFont = true;
      this.txtTenKhachHang.Size = new Size(386, 20);
      this.txtTenKhachHang.TabIndex = 10;
      this.txtMaPhieuTron.Location = new Point(577, 84);
      this.txtMaPhieuTron.Name = "txtMaPhieuTron";
      this.txtMaPhieuTron.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaPhieuTron.Properties.Appearance.Options.UseFont = true;
      this.txtMaPhieuTron.Size = new Size(217, 20);
      this.txtMaPhieuTron.TabIndex = 9;
      this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl9.Appearance.Options.UseFont = true;
      this.labelControl9.Location = new Point(15, 141);
      this.labelControl9.Name = "labelControl9";
      this.labelControl9.Size = new Size(59, 14);
      this.labelControl9.TabIndex = 6;
      this.labelControl9.Text = "Người trộn";
      this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl8.Appearance.Options.UseFont = true;
      this.labelControl8.Location = new Point(497, 141);
      this.labelControl8.Name = "labelControl8";
      this.labelControl8.Size = new Size(63, 14);
      this.labelControl8.TabIndex = 5;
      this.labelControl8.Text = "Số niêm chì";
      this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl6.Appearance.Options.UseFont = true;
      this.labelControl6.Location = new Point(15, 222);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new Size(54, 14);
      this.labelControl6.TabIndex = 3;
      this.labelControl6.Text = "Cường độ";
      this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl5.Appearance.Options.UseFont = true;
      this.labelControl5.Location = new Point(15, 60);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(70, 14);
      this.labelControl5.TabIndex = 2;
      this.labelControl5.Text = "Công trường";
      this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(15, 33);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(64, 14);
      this.labelControl2.TabIndex = 1;
      this.labelControl2.Text = "Khách hàng";
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(497, 87);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(76, 14);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Mã Phiếu trộn";
      this.grChiTietMeTron.Controls.Add((Control) this.grcPhieuTronChiTiet);
      this.grChiTietMeTron.Location = new Point(337, 339);
      this.grChiTietMeTron.Name = "grChiTietMeTron";
      this.grChiTietMeTron.Size = new Size(804, 243);
      this.grChiTietMeTron.TabIndex = 9;
      this.grChiTietMeTron.Text = "Chi tiết mẻ trộn";
      this.grcPhieuTronChiTiet.Dock = DockStyle.Fill;
      this.grcPhieuTronChiTiet.Location = new Point(2, 23);
      this.grcPhieuTronChiTiet.MainView = (BaseView) this.bandedGridView1;
      this.grcPhieuTronChiTiet.Name = "grcPhieuTronChiTiet";
      this.grcPhieuTronChiTiet.Size = new Size(800, 218);
      this.grcPhieuTronChiTiet.TabIndex = 0;
      this.grcPhieuTronChiTiet.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.bandedGridView1
      });
      this.bandedGridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.Agg1.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
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
      this.groupControl3.Controls.Add((Control) this.spin_numberOfCopies);
      this.groupControl3.Controls.Add((Control) this.label1);
      this.groupControl3.Controls.Add((Control) this.btnInPCT);
      this.groupControl3.Controls.Add((Control) this.btnPrint);
      this.groupControl3.Location = new Point(3, 590);
      this.groupControl3.Name = "groupControl3";
      this.groupControl3.Size = new Size(328, 125);
      this.groupControl3.TabIndex = 10;
      this.groupControl3.Text = "Tác vụ";
      this.spin_numberOfCopies.EditValue = (object) new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.spin_numberOfCopies.Location = new Point(114, 38);
      this.spin_numberOfCopies.Name = "spin_numberOfCopies";
      this.spin_numberOfCopies.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.label1.Location = new Point(31, 41);
      this.label1.Name = "label1";
      this.label1.Size = new Size(66, 16);
      this.label1.TabIndex = 80;
      this.label1.Text = "Số bản in:";
      this.btnInPCT.AllowFocus = false;
      this.btnInPCT.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnInPCT.Appearance.Options.UseFont = true;
      this.btnInPCT.BackgroundImageLayout = ImageLayout.None;
      this.btnInPCT.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.btnInPCT.ImageOptions.Image = (Image) ResourceNhua.printer;
      this.btnInPCT.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
      this.btnInPCT.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.btnInPCT.Location = new Point(108, 69);
      this.btnInPCT.Name = "btnInPCT";
      this.btnInPCT.Size = new Size(120, 45);
      this.btnInPCT.TabIndex = 75;
      this.btnInPCT.Text = "In Phiếu";
      this.btnInPCT.Click += new EventHandler(this.btnInPCT_Click);
      this.btnPrint.AllowFocus = false;
      this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnPrint.Appearance.Options.UseFont = true;
      this.btnPrint.BackgroundImageLayout = ImageLayout.None;
      this.btnPrint.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.btnPrint.ImageOptions.Image = (Image) ResourceNhua.printer;
      this.btnPrint.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
      this.btnPrint.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.btnPrint.Location = new Point(197, 69);
      this.btnPrint.Name = "btnPrint";
      this.btnPrint.Size = new Size(120, 45);
      this.btnPrint.TabIndex = 74;
      this.btnPrint.Text = "Phiếu PDF";
      this.btnPrint.Visible = false;
      this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
      this.groupControl5.Controls.Add((Control) this.grcTotalMaterial);
      this.groupControl5.Location = new Point(337, 590);
      this.groupControl5.Name = "groupControl5";
      this.groupControl5.Size = new Size(804, (int) sbyte.MaxValue);
      this.groupControl5.TabIndex = 11;
      this.groupControl5.Text = "Tổng vật tư xe trộn";
      this.grcTotalMaterial.Dock = DockStyle.Fill;
      this.grcTotalMaterial.Location = new Point(2, 23);
      this.grcTotalMaterial.MainView = (BaseView) this.bandedGridView2;
      this.grcTotalMaterial.Name = "grcTotalMaterial";
      this.grcTotalMaterial.Size = new Size(800, 102);
      this.grcTotalMaterial.TabIndex = 0;
      this.grcTotalMaterial.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.bandedGridView2
      });
      this.bandedGridView2.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.gcMaPhieuTron.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.Controls.Add((Control) this.groupControl5);
      this.Controls.Add((Control) this.groupControl3);
      this.Controls.Add((Control) this.grChiTietMeTron);
      this.Controls.Add((Control) this.groupControl4);
      this.Controls.Add((Control) this.groupControl2);
      this.Controls.Add((Control) this.groupControl1);
      this.Name = nameof (PrinterPheuTronChiTiet);
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

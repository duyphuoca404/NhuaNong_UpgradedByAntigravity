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
using NhuaNong.ServiceLibrary;
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
using Task = System.Threading.Tasks.Task;

#nullable disable
namespace NhuaNong.KWS
{
  public partial class PrinterPheuTronChiTiet : ControlViewBase, IPhieuTronMngView, IBase, IPermission
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
    private System.Data.DataTable DataTableNameMaterial;
    private System.Data.DataTable DataTableSumMaterial;
    private System.Data.DataTable _tablePTCT = new System.Data.DataTable();
    private System.Data.DataTable DataTableMaterial = new System.Data.DataTable();
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
      this.Name = nameof(PrinterPheuTronChiTiet);
      this._presenter = new PhieuTronMngDataPresenter((IPhieuTronMngView) this);
      this.Caption = "Phi?u chi ti?t xe tr?n";
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
      System.Data.DataTable dataTable1 = PrinterPheuTronChiTiet.ToDataTable(bindingList2);
      DataRow row2 = dataTable1.NewRow();
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
      dataTable1.Rows.InsertAt(row2, 0);
      DataRow row3 = dataTable1.NewRow();
      row3["LnNo"] = (object) "Ð? ?m";
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
      dataTable1.Rows.InsertAt(row3, 1);
      DataRow row4 = dataTable1.NewRow();
      row4["LnNo"] = (object) "Kh?i lu?ng";
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
      dataTable1.Rows.InsertAt(row4, 2);
      this.grcPhieuTronChiTiet.DataSource = (object) dataTable1;
      this._tablePTCT = dataTable1.Copy();
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
      this.DataTableMaterial = PrinterPheuTronChiTiet.ToDataTableMaterial(bindingList3);
      this.grcTotalMaterial.DataSource = (object) this.DataTableMaterial;
      this.CreateTableTotalMaterial(this.num_silo_Agg, this.num_silo_Ce, this.num_silo_Wa, this.num_silo_Add, bindingList1);
      Decimal num124 = bindingList3[0].Total_PV_Agg1 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg2 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg3 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg4 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg5 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Agg6 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce1 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce2 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce3 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce4 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Ce5 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Wa1 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Wa2 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add1 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add2 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add3 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add4 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add5 + bindingList3.FirstOrDefault<ObjTotalMaterialPrinter>().Total_PV_Add6;
      this.sum_CP = num124;
      this.gcTotal_Agg1.SummaryItem.SummaryType = SummaryItemType.Custom;
      this.gcTotal_Agg1.SummaryItem.DisplayFormat = string.Format("T?ng: {0}", (object) num124);
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

    private static System.Data.DataTable ToDataTable(BindingList<ObjMTCTPrinter> objects)
    {
      System.Data.DataTable dataTable1 = new System.Data.DataTable();
      foreach (PropertyInfo property in typeof (ObjMTCTPrinter).GetProperties())
        dataTable1.Columns.Add(property.Name, property.PropertyType);
      foreach (ObjMTCTPrinter objMtctPrinter in (Collection<ObjMTCTPrinter>) objects)
      {
        DataRow row = dataTable1.NewRow();
        foreach (DataColumn column in (InternalDataCollectionBase) dataTable1.Columns)
          row[column.ColumnName] = typeof (ObjMTCTPrinter).GetProperty(column.ColumnName).GetValue((object) objMtctPrinter);
        dataTable1.Rows.Add(row);
      }
      return dataTable1;
    }

    private static System.Data.DataTable ToDataTableMaterial(BindingList<ObjTotalMaterialPrinter> objects)
    {
      System.Data.DataTable DataTableMaterial = new System.Data.DataTable();
      foreach (PropertyInfo property in typeof (ObjTotalMaterialPrinter).GetProperties())
        DataTableMaterial.Columns.Add(property.Name, property.PropertyType);
      foreach (ObjTotalMaterialPrinter totalMaterialPrinter in (Collection<ObjTotalMaterialPrinter>) objects)
      {
        DataRow row = DataTableMaterial.NewRow();
        foreach (DataColumn column in (InternalDataCollectionBase) DataTableMaterial.Columns)
          row[column.ColumnName] = typeof (ObjTotalMaterialPrinter).GetProperty(column.ColumnName).GetValue((object) totalMaterialPrinter);
        DataTableMaterial.Rows.Add(row);
      }
      return DataTableMaterial;
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
        TramTromMessageBox.ShowWarningDialog(string.Format("{0} dang m? b?i m?t chuong trình khác \n Vui lòng t?t {0} dang m?.", (object) str));
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
      headerText.Add("Th? tích");
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

    private void DataTableToDataTable(System.Data.DataTable fromTable, System.Data.DataTable toTable)
    {
      toTable = new System.Data.DataTable();
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
      System.Data.DataTable dataTable1,
      System.Data.DataTable DataTable2,
      System.Data.DataTable DataTable3)
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
        this.CreateTablePICT(doc, dataTable1, DataTable2, DataTable3);
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

    private System.Data.DataTable CreateTableNameMaterial(System.Data.DataTable yourSourceDataTable)
    {
      List<string> nameMaterialSumCol = this.GetNameMaterialSumCol();
      System.Data.DataTable tableNameMaterial = new System.Data.DataTable();
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
        row2["KLTungMe"] = (object) "Th? tích";
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

    private System.Data.DataTable CreateTableSumMaterial(System.Data.DataTable yourSourceDataTable)
    {
      List<string> sumMaterial = this.GetSumMaterial();
      System.Data.DataTable tableSumMaterial = new System.Data.DataTable();
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
      this.DataTableNameMaterial = this.CreateTableNameMaterial(this.DataTableMaterial);
      this.DataTableSumMaterial = this.CreateTableSumMaterial(this.DataTableMaterial);
      this.GetParam();
      this.WriteDetailInvoice(this._paramListTong, this._tablePTCT, this.DataTableNameMaterial, this.DataTableSumMaterial);
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
            Console.WriteLine("L?i khi xóa t?p tin Word: " + ex.Message);
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
        Console.WriteLine("L?i khi in file PDF: " + ex.Message);
        TramTronLogger.WriteError(ex);
      }
    }

    private void LoadDataToTable(Microsoft.Office.Interop.Word.Application word, System.Data.DataTable dataTable1)
    {
      if (word.Documents.Count <= 0)
        return;
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Word.Document activeDocument = word.ActiveDocument;
      if (activeDocument.Tables.Count <= 0)
        return;
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Word.Table table = activeDocument.Tables[1];
      int count1 = dataTable1.Rows.Count;
      int count2 = dataTable1.Columns.Count;
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
      System.Data.DataTable dataTable1,
      System.Data.DataTable DataTable2,
      System.Data.DataTable DataTable3)
    {
      List<string> stringList = new List<string>();
      int Index = 0;
      for (int index = 0; index < dataTable1.Columns.Count; ++index)
      {
        if (index < 2)
        {
          stringList.Add(dataTable1.Columns[index].ColumnName);
          ++Index;
        }
        else if (Convert.ToDouble(dataTable1.Rows[0][index]) != 0.0)
        {
          stringList.Add(dataTable1.Columns[index].ColumnName);
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
        table.Cell(1, index + 1).Range.Text = DataTable2.Rows[0][index].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(1, index + 1).Range.Bold = 1;
        // ISSUE: reference to a compiler-generated method
        table.Cell(2, index + 1).Range.Text = dataTable1.Rows[0][stringList[index]].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(2, 1).Range.Bold = 1;
        // ISSUE: reference to a compiler-generated method
        table.Cell(3, index + 1).Range.Text = dataTable1.Rows[1][stringList[index]].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(3, 1).Range.Bold = 1;
        // ISSUE: reference to a compiler-generated method
        table.Cell(4, index + 1).Range.Text = dataTable1.Rows[2][stringList[index]].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(4, 1).Range.Bold = 1;
      }
      // ISSUE: reference to a compiler-generated method
      table.Rows.Add(ref missing);
      int num1 = 4 + 1;
      // ISSUE: reference to a compiler-generated method
      table.Rows.Add(ref missing);
      int Row = num1 + 1;
      for (int index1 = 3; index1 < dataTable1.Rows.Count; ++index1)
      {
        for (int index2 = 0; index2 < Index; ++index2)
        {
          // ISSUE: reference to a compiler-generated method
          table.Cell(Row, index2 + 1).Range.Text = dataTable1.Rows[index1][stringList[index2]].ToString();
        }
        // ISSUE: reference to a compiler-generated method
        table.Rows.Add(ref missing);
        ++Row;
      }
      dataTable1.Rows.Remove(dataTable1.Rows[0]);
      dataTable1.Rows.Remove(dataTable1.Rows[0]);
      dataTable1.Rows.Remove(dataTable1.Rows[0]);
      float num2 = 0.0f;
      for (int index = 1; index < Index; ++index)
      {
        // ISSUE: reference to a compiler-generated method
        table.Cell(Row, index + 1).Range.Text = DataTable3.Rows[0][index].ToString();
        // ISSUE: reference to a compiler-generated method
        table.Cell(Row, index + 1).Range.Bold = 1;
        if (index > 1)
          num2 += Convert.ToSingle(dataTable1.Compute("SUM([" + stringList[index] + "])", ""));
      }
      // ISSUE: reference to a compiler-generated method
      table.Cell(Row, 1).Range.Text = "T?ng";
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
      table.Cell(5, 1).Range.Text = "CHI TI?T M? TR?N (DETAIL)";
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

    
  }
}

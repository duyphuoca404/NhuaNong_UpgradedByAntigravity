using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
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
using System.Drawing;
using System.Drawing.Printing;
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
  public partial class FormPhieuIn : ControlViewBase, IPhieuTronMngView, IBase, IPermission
  {
    private PhieuTronMngDataPresenter _presenter;
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private string printerName_GH;
    private string printerName_CT;
    private List<string> listPrinter_GH = new List<string>();
    private List<string> listPrinter_CT = new List<string>();
    private int numberOfCopies_GH;
    private int numberOfCopies_CT;
    private DateTime TGBatDauTron;
    private DateTime TGKetThutTron;
    private string sourceFileName = ConfigManager.TramTronConfig.PIPath;
    private string fileName = "";
    private string filePathMau = ConfigManager.TramTronConfig.PIPath;
    private string filePathMau_CT = ConfigManager.TramTronConfig.PICTPath;
    private string folderDesPhieuPath = ConfigManager.TramTronConfig.ReportPath;
    private bool _error;
    private bool isGiaoHang = true;
    private int userID;
    private Thread thread_GH;
    private Thread thread_CT;
    private List<string> lstParam = new List<string>();
    private List<string> lstParam_02 = new List<string>();
    private System.Data.DataTable _tablePTCT = new System.Data.DataTable();
    private System.Data.DataTable dataTableMaterial = new System.Data.DataTable();
    private System.Data.DataTable dataTableNameMaterial;
    private System.Data.DataTable dataTableSumMaterial;
    private int num_silo_Agg;
    private int num_silo_Ce;
    private int num_silo_Wa;
    private int num_silo_Add;
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
    private ObjPhieuGiaoHang _pgh;
    private BindingList<ObjPhieuTron> _blstPhieuTron = new BindingList<ObjPhieuTron>();
    private BindingList<ObjHopDong> _blstHopDong = new BindingList<ObjHopDong>();
    private BindingList<ObjMeTron> _blstMeTron = new BindingList<ObjMeTron>();
    private BindingList<ObjMeTron> _blstMeTron_02 = new BindingList<ObjMeTron>();
    private BindingList<ObjMeTronChiTiet> _blstMeTronChiTiet = new BindingList<ObjMeTronChiTiet>();
    

    public ObjPhieuGiaoHang PhieuGiaoHang
    {
      set => this._pgh = value;
    }

    public BindingList<ObjPhieuTron> BLstPhieuTron
    {
      set
      {
        this._blstPhieuTron = value;
        this.grcPhieuTron.DataSource = (object) this._blstPhieuTron;
        this.grcPhieuTron_02.DataSource = (object) this._blstPhieuTron;
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
      set => this.SuccessfullySave(value);
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
      set
      {
      }
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      this.grvPhieuTron.RefreshData();
    }

    public FormPhieuIn()
    {
      this.InitializeComponent();
      this.Name = nameof(FormPhieuIn);
      this._presenter = new PhieuTronMngDataPresenter((IPhieuTronMngView) this);
      this.SetCaption();
      this.LoadValuePrinter();
    }

    private void SetCaption() => this.Caption = "Phiếu in";

    private void LoadValuePrinter()
    {
      this.luePrinter_GH.EditValue = (object) ConfigManager.TramTronConfig.MayInPI;
      this.luePrinter_CT.EditValue = (object) ConfigManager.TramTronConfig.MayInPICT;
    }

    protected override void PopulateStaticData()
    {
      this.LoadSearchDefaultValues();
      this.LoadSearchDefaultValues_02();
      this.printerName_GH = ConfigManager.TramTronConfig.MayInPI;
      this.printerName_CT = ConfigManager.TramTronConfig.MayInPICT;
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

    protected override void PopulateData()
    {
      this.LoadPhieuTron();
      this.LoadPhieuTron_02();
    }

    private void LoadSearchDefaultValues()
    {
      this.datTuNgay.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestPhieuTronDays);
      this.datDenNgay.EditValue = (object) DateTime.Now;
      DateTime dateTime = DateTime.Now;
      dateTime = dateTime.Date;
      this.tseToTime.EditValue = (object) dateTime.Add(new TimeSpan(23, 59, 59)).TimeOfDay;
    }

    private void LoadSearchDefaultValues_02()
    {
      this.datTuNgay_02.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestPhieuTronDays);
      this.datDenNgay_02.EditValue = (object) DateTime.Now;
      DateTime dateTime = DateTime.Now;
      dateTime = dateTime.Date;
      this.tseToTime_02.EditValue = (object) dateTime.Add(new TimeSpan(23, 59, 59)).TimeOfDay;
    }

    private void LoadPhieuTron()
    {
      this._presenter.ListPhieuTron(string.Empty, Searching.BuildNew_StartDateTime(this.datTuNgay.DateTime, this.tseFromTime.TimeSpan), Searching.BuildNew_EndDateTime(this.datDenNgay.DateTime, this.tseToTime.TimeSpan), new int?(-1), new bool?());
    }

    private void LoadPhieuTron_02()
    {
      this._presenter.ListPhieuTron(string.Empty, Searching.BuildNew_StartDateTime(this.datTuNgay_02.DateTime, this.tseFromTime_02.TimeSpan), Searching.BuildNew_EndDateTime(this.datDenNgay_02.DateTime, this.tseToTime_02.TimeSpan), new int?(-1), new bool?());
    }

    private void bandedGridView1_RowStyle(object sender, RowStyleEventArgs e)
    {
    }

    private void ClearDataPhieuTron()
    {
      this.datNgayTron.EditValue = (object) "";
      this.txtGioTron.Text = "";
      this.txtGioKTTron.Text = "";
      this.txtMaPhieuTron.Text = string.Empty;
      this.txtSTTPhieuTron.Text = string.Empty;
      this.txtTenMAC.Text = string.Empty;
      this.txtCuongDo.Text = string.Empty;
      this.txtDoSut.Text = string.Empty;
      this.txtTheTich.Text = string.Empty;
      this.txtKhoiLuongDatHang.Text = string.Empty;
      this.txtLuyKe.Text = string.Empty;
      this.txtTenKhachHang.Text = string.Empty;
      this.txtTenCongTruong.Text = string.Empty;
      this.txtHangMuc.Text = string.Empty;
      this.txtDiaDiem.Text = string.Empty;
      this.txtNiemChi.Text = string.Empty;
      this.txtNguoiTron.Text = string.Empty;
      this.txtTaiXe.Text = string.Empty;
      this.txtXe.Text = string.Empty;
    }

    private void ClearDataPhieuTron_02()
    {
      this.datNgayTron_02.EditValue = (object) "";
      this.txtGioTron_02.Text = "";
      this.txtGioKTTron_02.Text = "";
      this.txtMaPhieuTron_02.Text = string.Empty;
      this.txtSTTPhieuTron_02.Text = string.Empty;
      this.txtTenMAC_02.Text = string.Empty;
      this.txtCuongDo_02.Text = string.Empty;
      this.txtDoSut_02.Text = string.Empty;
      this.txtTheTich_02.Text = string.Empty;
      this.txtKhoiLuongDatHang_02.Text = string.Empty;
      this.txtLuyKe_02.Text = string.Empty;
      this.txtTenKhachHang_02.Text = string.Empty;
      this.txtTenCongTruong_02.Text = string.Empty;
      this.txtHangMuc_02.Text = string.Empty;
      this.txtDiaDiem_02.Text = string.Empty;
      this.txtNiemChi_02.Text = string.Empty;
      this.txtNguoiTron_02.Text = string.Empty;
      this.txtTaiXe_02.Text = string.Empty;
      this.txtXe_02.Text = string.Empty;
    }

    private void DoFocusPhieuTron()
    {
      this.ClearDataPhieuTron();
      if (!(this.grvPhieuTron.GetRow(this.grvPhieuTron.FocusedRowHandle) is ObjPhieuTron row))
        return;
      int phieuTronId = row.PhieuTronID;
      int? nullable1 = new int?(row.PhieuTronID);
      int num = 0;
      if (nullable1.GetValueOrDefault() == num & nullable1.HasValue)
        return;
      ObjHopDong hopDongByKey = this._presenter.GetHopDongByKey(row.HopDongID.Value);
      ObjPhieuTron phieuTronByKey = this._presenter.GetPhieuTronByKey(row.PhieuTronID);
      if (phieuTronByKey == null)
        return;
      int? nullable2 = phieuTronByKey.CreatedBy;
      if (nullable2.HasValue)
      {
        nullable2 = phieuTronByKey.CreatedBy;
        this.userID = nullable2.Value;
        var user = this._ser.GetSEC_UserByKey(this.userID);
        this.txtNguoiTron.Text = user != null ? user.FullName : string.Empty;
      }
      this.txtMaHopDong.Text = phieuTronByKey.NPHopDongMaHopDong;
      this.datNgayTron.EditValue = (object) phieuTronByKey.NgayPhieuTron;
      this.txtGioTron.Text = phieuTronByKey.NgayPhieuTron.Value.ToString("HH:mm:ss");
      if (phieuTronByKey.LatestUpdateDate.HasValue)
        this.txtGioKTTron.Text = phieuTronByKey.LatestUpdateDate.Value.ToString("HH:mm:ss");
      this.txtMaPhieuTron.Text = phieuTronByKey.MaPhieuTron;
      TextEdit txtSttPhieuTron = this.txtSTTPhieuTron;
      nullable2 = phieuTronByKey.NoPhieu;
      string str1 = nullable2.ToString();
      txtSttPhieuTron.Text = str1;
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
      this.txtTheTich.Text = phieuTronByKey.KLDuTinh.ToString();
      Decimal? nullable3 = phieuTronByKey.KLThuc;
      if (!nullable3.HasValue)
      {
        TextEdit txtLuyKe = this.txtLuyKe;
        nullable3 = hopDongByKey.KLDaGiao;
        Decimal? klDuTinh = phieuTronByKey.KLDuTinh;
        string str2 = (nullable3.HasValue & klDuTinh.HasValue ? new Decimal?(nullable3.GetValueOrDefault() + klDuTinh.GetValueOrDefault()) : new Decimal?()).ToString();
        txtLuyKe.Text = str2;
      }
      else
      {
        TextEdit txtLuyKe = this.txtLuyKe;
        nullable3 = phieuTronByKey.SLMeHieuChinh;
        string str3 = nullable3.ToString();
        txtLuyKe.Text = str3;
      }
      TextEdit khoiLuongDatHang = this.txtKhoiLuongDatHang;
      nullable3 = phieuTronByKey.NPHopDongKLDatHang;
      string str4 = nullable3.ToString();
      khoiLuongDatHang.Text = str4;
    }

    private void DoFocusPhieuGiaoHang()
    {
      this.ClearDataPhieuTron();
      if (!(this.grvPhieuTron.GetRow(this.grvPhieuTron.FocusedRowHandle) is ObjPhieuTron row))
        return;
      int phieuTronId = row.PhieuTronID;
      int? nullable1 = new int?(row.PhieuTronID);
      int num = 0;
      if (nullable1.GetValueOrDefault() == num & nullable1.HasValue)
        return;
      ObjHopDong hopDongByKey = this._presenter.GetHopDongByKey(row.HopDongID.Value);
      ObjPhieuGiaoHang phieuGiaoHangByCode = this._presenter.GetPhieuGiaoHangByCode(row.MaPhieuTron);
      if (phieuGiaoHangByCode == null)
        return;
      int? nullable2 = phieuGiaoHangByCode.CreatedBy;
      if (nullable2.HasValue)
      {
        this._pgh = phieuGiaoHangByCode;
        this._presenter.GetPhieuGiaoHangByKey(this._pgh.PhieuTronID);
        nullable2 = phieuGiaoHangByCode.CreatedBy;
        this.userID = nullable2.Value;
        var user = this._ser.GetSEC_UserByKey(this.userID);
        this.txtNguoiTron.Text = user != null ? user.FullName : string.Empty;
      }
      this.txtMaHopDong.Text = this._pgh.MaHopDong;
      this.datNgayTron.EditValue = (object) this._pgh.NgayPhieuTron;
      this.txtGioTron.Text = this._pgh.GioBD;
      this.txtGioKTTron.Text = this._pgh.GioKT;
      this.txtMaPhieuTron.Text = this._pgh.MaPhieuTron;
      TextEdit txtSttPhieuTron = this.txtSTTPhieuTron;
      nullable2 = this._pgh.NoPhieu;
      string str1 = nullable2.ToString();
      txtSttPhieuTron.Text = str1;
      this.txtTenMAC.Text = this._pgh.TenMAC;
      this.txtTenKhachHang.Text = this._pgh.TenKhachHang;
      this.txtTenCongTruong.Text = this._pgh.TenCongTruong;
      if (this._pgh.CuongDo == null)
        this.txtCuongDo.Text = " ";
      else
        this.txtCuongDo.Text = this._pgh.CuongDo;
      if (this._pgh.DoSut == null)
        this.txtDoSut.Text = " ";
      else
        this.txtDoSut.Text = this._pgh.DoSut;
      if (this._pgh.DiaDiem == null)
        this.txtDiaDiem.Text = " ";
      else
        this.txtDiaDiem.Text = this._pgh.DiaDiem;
      if (this._pgh.TenHangMuc == null)
        this.txtHangMuc.Text = " ";
      else
        this.txtHangMuc.Text = this._pgh.TenHangMuc;
      if (this._pgh.TenTaiXe == null)
        this.txtTaiXe.Text = " ";
      else
        this.txtTaiXe.Text = this._pgh.TenTaiXe;
      if (this._pgh.BienSo == null)
        this.txtXe.Text = " ";
      else
        this.txtXe.Text = this._pgh.BienSo;
      if (this._pgh.NiemChi == null)
        this.txtXe.Text = " ";
      else
        this.txtNiemChi.Text = this._pgh.NiemChi;
      this.txtTheTich.Text = this._pgh.KLDuTinh.ToString();
      this.txtBom.Text = this._pgh.Temp1.ToString();
      Decimal? nullable3 = this._pgh.KLThuc;
      if (!nullable3.HasValue)
      {
        TextEdit txtLuyKe = this.txtLuyKe;
        nullable3 = hopDongByKey.KLDaGiao;
        Decimal? klDuTinh = this._pgh.KLDuTinh;
        string str2 = (nullable3.HasValue & klDuTinh.HasValue ? new Decimal?(nullable3.GetValueOrDefault() + klDuTinh.GetValueOrDefault()) : new Decimal?()).ToString();
        txtLuyKe.Text = str2;
      }
      else
      {
        TextEdit txtLuyKe = this.txtLuyKe;
        nullable3 = this._pgh.SLMeHieuChinh;
        string str3 = nullable3.ToString();
        txtLuyKe.Text = str3;
      }
      this.txtKhoiLuongDatHang.Text = this._pgh.Temp2;
    }

    private void EditPhieuGiaoHang()
    {
      this._pgh.IsNewObject = false;
      this._pgh.NgayPhieuTron = new DateTime?(this.datNgayTron.DateTime.Date);
      this._pgh.GioBD = this.txtGioTron.Text;
      this._pgh.GioKT = this.txtGioKTTron.Text;
      this._pgh.NoPhieu = new int?(int.Parse(this.txtSTTPhieuTron.Text));
      this._pgh.MaPhieuTron = this.txtMaPhieuTron.Text;
      this._pgh.TenMAC = this.txtTenMAC.Text;
      this._pgh.CuongDo = this.txtCuongDo.Text;
      this._pgh.DoSut = this.txtDoSut.Text;
      this._pgh.TenKhachHang = this.txtTenKhachHang.Text;
      this._pgh.TenCongTruong = this.txtTenCongTruong.Text;
      this._pgh.DiaDiem = this.txtDiaDiem.Text;
      this._pgh.TenHangMuc = this.txtHangMuc.Text;
      this._pgh.TenTaiXe = this.txtTaiXe.Text;
      this._pgh.BienSo = this.txtXe.Text;
      this._pgh.NiemChi = this.txtNiemChi.Text;
      this._pgh.SLMeHieuChinh = new Decimal?(Decimal.Parse(this.txtLuyKe.Text));
      this._pgh.KLDuTinh = new Decimal?(Decimal.Parse(this.txtTheTich.Text));
      this._pgh.LuyKe = new Decimal?(Decimal.Parse(this.txtLuyKe.Text));
      this._pgh.Temp1 = this.txtBom.Text;
      this._pgh.Temp2 = this.txtKhoiLuongDatHang.Text;
      BindingList<ObjPhieuGiaoHang> blstCT = new BindingList<ObjPhieuGiaoHang>();
      blstCT.Add(this._pgh);
      this._presenter.SavePhieuGiaoHang(blstCT);
    }

    private void DoFocusPhieuTron_02()
    {
      this.ClearDataPhieuTron_02();
      if (!(this.grvPhieuTron_02.GetRow(this.grvPhieuTron_02.FocusedRowHandle) is ObjPhieuTron row1))
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
        var user = this._ser.GetSEC_UserByKey(this.userID);
        this.txtNguoiTron_02.Text = user != null ? user.FullName : string.Empty;
      }
      this.datNgayTron_02.EditValue = (object) phieuTronByKey.NgayPhieuTron;
      TextEdit txtGioTron02 = this.txtGioTron_02;
      DateTime? nullable3 = phieuTronByKey.NgayPhieuTron;
      DateTime dateTime = nullable3.Value;
      string str1 = dateTime.ToString("HH:mm:ss");
      txtGioTron02.Text = str1;
      nullable3 = phieuTronByKey.LatestUpdateDate;
      if (nullable3.HasValue)
      {
        TextEdit txtGioKtTron02 = this.txtGioKTTron_02;
        nullable3 = phieuTronByKey.LatestUpdateDate;
        dateTime = nullable3.Value;
        string str2 = dateTime.ToString("HH:mm:ss");
        txtGioKtTron02.Text = str2;
      }
      this.txtMaPhieuTron_02.Text = phieuTronByKey.MaPhieuTron;
      TextEdit txtSttPhieuTron02 = this.txtSTTPhieuTron_02;
      nullable2 = phieuTronByKey.NoPhieu;
      string str3 = nullable2.ToString();
      txtSttPhieuTron02.Text = str3;
      this.txtTenMAC_02.Text = phieuTronByKey.NPMACTenMAC;
      this.txtCuongDo_02.Text = phieuTronByKey.NPMACCuongDo;
      this.txtDoSut_02.Text = phieuTronByKey.NPMACDoSut;
      this.txtTenKhachHang_02.Text = phieuTronByKey.NPKhachHangTenKhachHang;
      this.txtTenCongTruong_02.Text = phieuTronByKey.NPCongTruongTenCongTruong;
      this.txtDiaDiem_02.Text = phieuTronByKey.NPCongTruongDiaChi;
      this.txtHangMuc_02.Text = phieuTronByKey.NPHangMucTenHangMuc;
      this.txtTaiXe_02.Text = phieuTronByKey.NPTaiXeTenTaiXe;
      this.txtXe_02.Text = phieuTronByKey.NPXeBienSo;
      this.txtNiemChi_02.Text = phieuTronByKey.MoTa;
      TextEdit txtTheTich02 = this.txtTheTich_02;
      Decimal? nullable4 = phieuTronByKey.KLDuTinh;
      string str4 = nullable4.ToString();
      txtTheTich02.Text = str4;
      TextEdit txtLuyKe02 = this.txtLuyKe_02;
      nullable4 = phieuTronByKey.KLThuc;
      string str5 = nullable4.ToString();
      txtLuyKe02.Text = str5;
      this.txtKhoiLuongDatHang_02.Text = phieuTronByKey.NPHopDongKLDatHang.ToString();
      this._blstMeTron = Converter.ConvertToBindingList<ObjMeTron>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListMeTronByPhieuTronID(phieuTronByKey.PhieuTronID) as List<ObjMeTron>);
      int count = this._blstMeTron.Count;
      this._blstMeTronChiTiet = Converter.ConvertToBindingList<ObjMeTronChiTiet>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListMeTronChiTietByPhieuTronID(phieuTronByKey.PhieuTronID) as List<ObjMeTronChiTiet>);
      TramTronLogger.WriteInfo($"[DoFocusPhieuTron_02] PhieuTronID: {phieuTronByKey.PhieuTronID}, MeTron Count: {this._blstMeTron?.Count}, ChiTiet Count: {this._blstMeTronChiTiet?.Count}");
      int num2 = ConfigManager.TramTronConfig.IsCanFixPCT ? 1 : 0;
      BindingList<ObjMTCTFullPrinter> bindingList1 = new BindingList<ObjMTCTFullPrinter>();
      
      this.sum_KL = 0M;
      foreach (ObjMeTron objMeTron in (Collection<ObjMeTron>) this._blstMeTron)
      {
        Decimal sumKl = this.sum_KL;
        Decimal? nullable5 = objMeTron.KhoiLuong;
        Decimal num3 = nullable5.Value;
        this.sum_KL = sumKl + num3;
        ObjMTCTFullPrinter objMtctFullPrinter1 = new ObjMTCTFullPrinter();
        if (true)
        {
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
                    switch (maSilo[0])
                    {
                      case 'C':
                        if (maSilo == "Ce1")
                        {
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter4 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num4 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter4.SiloValue_Ce1 = num4;
                          ObjMTCTFullPrinter objMtctFullPrinter5 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num5 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter5.CP_Ce1 = num5;
                          ObjMTCTFullPrinter objMtctFullPrinter6 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num6 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter6.PV_Ce1 = num6;
                          ObjMTCTFullPrinter objMtctFullPrinter7 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num7 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter7.PVM_Ce1 = num7;
                          ObjMTCTFullPrinter objMtctFullPrinter8 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num8 = nullable5.Value;
                          objMtctFullPrinter8.SaiSo_Ce1 = num8;
                          ObjMTCTFullPrinter objMtctFullPrinter9 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num9 = nullable5.Value;
                          objMtctFullPrinter9.PerSaiSo_Ce1 = num9;
                          objMtctFullPrinter1.MaterialName_Ce1 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : null;
                          continue;
                        }
                        continue;
                      case 'W':
                        if (maSilo == "Wa1")
                        {
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter10 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num10 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter10.SiloValue_Wa1 = num10;
                          ObjMTCTFullPrinter objMtctFullPrinter11 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num11 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter11.CP_Wa1 = num11;
                          ObjMTCTFullPrinter objMtctFullPrinter12 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num12 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter12.PV_Wa1 = num12;
                          ObjMTCTFullPrinter objMtctFullPrinter13 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num13 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter13.PVM_Wa1 = num13;
                          ObjMTCTFullPrinter objMtctFullPrinter14 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num14 = nullable5.Value;
                          objMtctFullPrinter14.SaiSo_Wa1 = num14;
                          ObjMTCTFullPrinter objMtctFullPrinter15 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num15 = nullable5.Value;
                          objMtctFullPrinter15.PerSaiSo_Wa1 = num15;
                          objMtctFullPrinter1.MaterialName_Wa1 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : null;
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
                            ObjMTCTFullPrinter objMtctFullPrinter16 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.SiloValue;
                            Decimal num16 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter16.SiloValue_Agg1 = num16;
                            ObjMTCTFullPrinter objMtctFullPrinter17 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.Value;
                            Decimal num17 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter17.CP_Agg1 = num17;
                            ObjMTCTFullPrinter objMtctFullPrinter18 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBat;
                            Decimal num18 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter18.PV_Agg1 = num18;
                            ObjMTCTFullPrinter objMtctFullPrinter19 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBatMan;
                            Decimal num19 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter19.PVM_Agg1 = num19;
                            ObjMTCTFullPrinter objMtctFullPrinter20 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueTol;
                            Decimal num20 = nullable5.Value;
                            objMtctFullPrinter20.SaiSo_Agg1 = num20;
                            ObjMTCTFullPrinter objMtctFullPrinter21 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValuePerTol;
                            Decimal num21 = nullable5.Value;
                            objMtctFullPrinter21.PerSaiSo_Agg1 = num21;
                            ObjMTCTFullPrinter objMtctFullPrinter22 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                            Decimal num22 = nullable5.Value;
                            objMtctFullPrinter22.DoAm_Agg1 = num22;
                            objMtctFullPrinter1.MaterialName_Agg1 = objMeTronChiTiet.MaterialName == null ? null : objMeTronChiTiet.MaterialName;
                            continue;
                          case "Add1":
                            nullable5 = objMeTronChiTiet.SiloValue;
                            if (!nullable5.HasValue)
                              objMeTronChiTiet.SiloValue = new Decimal?(0M);
                            ObjMTCTFullPrinter objMtctFullPrinter23 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.SiloValue;
                            Decimal num23 = nullable5.Value;
                            objMtctFullPrinter23.SiloValue_Add1 = num23;
                            ObjMTCTFullPrinter objMtctFullPrinter24 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.Value;
                            Decimal num24 = nullable5.Value;
                            objMtctFullPrinter24.CP_Add1 = num24;
                            ObjMTCTFullPrinter objMtctFullPrinter25 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBat;
                            Decimal num25 = nullable5.Value;
                            objMtctFullPrinter25.PV_Add1 = num25;
                            ObjMTCTFullPrinter objMtctFullPrinter26 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBatMan;
                            Decimal num26 = nullable5.Value;
                            objMtctFullPrinter26.PVM_Add1 = num26;
                            ObjMTCTFullPrinter objMtctFullPrinter27 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueTol;
                            Decimal num27 = nullable5.Value;
                            objMtctFullPrinter27.SaiSo_Add1 = num27;
                            ObjMTCTFullPrinter objMtctFullPrinter28 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValuePerTol;
                            Decimal num28 = nullable5.Value;
                            objMtctFullPrinter28.PerSaiSo_Add1 = num28;
                            objMtctFullPrinter1.MaterialName_Add1 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : null;
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
                            ObjMTCTFullPrinter objMtctFullPrinter29 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.SiloValue;
                            Decimal num29 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter29.SiloValue_Agg2 = num29;
                            ObjMTCTFullPrinter objMtctFullPrinter30 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.Value;
                            Decimal num30 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter30.CP_Agg2 = num30;
                            ObjMTCTFullPrinter objMtctFullPrinter31 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBat;
                            Decimal num31 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter31.PV_Agg2 = num31;
                            ObjMTCTFullPrinter objMtctFullPrinter32 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBatMan;
                            Decimal num32 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter32.PVM_Agg2 = num32;
                            ObjMTCTFullPrinter objMtctFullPrinter33 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueTol;
                            Decimal num33 = nullable5.Value;
                            objMtctFullPrinter33.SaiSo_Agg2 = num33;
                            ObjMTCTFullPrinter objMtctFullPrinter34 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValuePerTol;
                            Decimal num34 = nullable5.Value;
                            objMtctFullPrinter34.PerSaiSo_Agg2 = num34;
                            ObjMTCTFullPrinter objMtctFullPrinter35 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                            Decimal num35 = nullable5.Value;
                            objMtctFullPrinter35.DoAm_Agg2 = num35;
                            objMtctFullPrinter1.MaterialName_Agg2 = objMeTronChiTiet.MaterialName == null ? null : objMeTronChiTiet.MaterialName;
                            continue;
                          case "Add2":
                            nullable5 = objMeTronChiTiet.SiloValue;
                            if (!nullable5.HasValue)
                              objMeTronChiTiet.SiloValue = new Decimal?(0M);
                            ObjMTCTFullPrinter objMtctFullPrinter36 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.SiloValue;
                            Decimal num36 = nullable5.Value;
                            objMtctFullPrinter36.SiloValue_Add2 = num36;
                            ObjMTCTFullPrinter objMtctFullPrinter37 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.Value;
                            Decimal num37 = nullable5.Value;
                            objMtctFullPrinter37.CP_Add2 = num37;
                            ObjMTCTFullPrinter objMtctFullPrinter38 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBat;
                            Decimal num38 = nullable5.Value;
                            objMtctFullPrinter38.PV_Add2 = num38;
                            ObjMTCTFullPrinter objMtctFullPrinter39 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBatMan;
                            Decimal num39 = nullable5.Value;
                            objMtctFullPrinter39.PVM_Add2 = num39;
                            ObjMTCTFullPrinter objMtctFullPrinter40 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueTol;
                            Decimal num40 = nullable5.Value;
                            objMtctFullPrinter40.SaiSo_Add2 = num40;
                            ObjMTCTFullPrinter objMtctFullPrinter41 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValuePerTol;
                            Decimal num41 = nullable5.Value;
                            objMtctFullPrinter41.PerSaiSo_Add2 = num41;
                            objMtctFullPrinter1.MaterialName_Add2 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : null;
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
                            ObjMTCTFullPrinter objMtctFullPrinter42 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.SiloValue;
                            Decimal num42 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter42.SiloValue_Agg3 = num42;
                            ObjMTCTFullPrinter objMtctFullPrinter43 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.Value;
                            Decimal num43 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter43.CP_Agg3 = num43;
                            ObjMTCTFullPrinter objMtctFullPrinter44 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBat;
                            Decimal num44 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter44.PV_Agg3 = num44;
                            ObjMTCTFullPrinter objMtctFullPrinter45 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBatMan;
                            Decimal num45 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter45.PVM_Agg3 = num45;
                            ObjMTCTFullPrinter objMtctFullPrinter46 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueTol;
                            Decimal num46 = nullable5.Value;
                            objMtctFullPrinter46.SaiSo_Agg3 = num46;
                            ObjMTCTFullPrinter objMtctFullPrinter47 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValuePerTol;
                            Decimal num47 = nullable5.Value;
                            objMtctFullPrinter47.PerSaiSo_Agg3 = num47;
                            ObjMTCTFullPrinter objMtctFullPrinter48 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                            Decimal num48 = nullable5.Value;
                            objMtctFullPrinter48.DoAm_Agg3 = num48;
                            objMtctFullPrinter1.MaterialName_Agg3 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : null;
                            continue;
                          case "Add3":
                            nullable5 = objMeTronChiTiet.SiloValue;
                            if (!nullable5.HasValue)
                              objMeTronChiTiet.SiloValue = new Decimal?(0M);
                            ObjMTCTFullPrinter objMtctFullPrinter49 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.SiloValue;
                            Decimal num49 = nullable5.Value;
                            objMtctFullPrinter49.SiloValue_Add3 = num49;
                            ObjMTCTFullPrinter objMtctFullPrinter50 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.Value;
                            Decimal num50 = nullable5.Value;
                            objMtctFullPrinter50.CP_Add3 = num50;
                            ObjMTCTFullPrinter objMtctFullPrinter51 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBat;
                            Decimal num51 = nullable5.Value;
                            objMtctFullPrinter51.PV_Add3 = num51;
                            ObjMTCTFullPrinter objMtctFullPrinter52 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBatMan;
                            Decimal num52 = nullable5.Value;
                            objMtctFullPrinter52.PVM_Add3 = num52;
                            ObjMTCTFullPrinter objMtctFullPrinter53 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueTol;
                            Decimal num53 = nullable5.Value;
                            objMtctFullPrinter53.SaiSo_Add3 = num53;
                            ObjMTCTFullPrinter objMtctFullPrinter54 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValuePerTol;
                            Decimal num54 = nullable5.Value;
                            objMtctFullPrinter54.PerSaiSo_Add3 = num54;
                            objMtctFullPrinter1.MaterialName_Add3 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : null;
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
                            ObjMTCTFullPrinter objMtctFullPrinter55 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.SiloValue;
                            Decimal num55 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter55.SiloValue_Agg4 = num55;
                            ObjMTCTFullPrinter objMtctFullPrinter56 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.Value;
                            Decimal num56 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter56.CP_Agg4 = num56;
                            ObjMTCTFullPrinter objMtctFullPrinter57 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBat;
                            Decimal num57 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter57.PV_Agg4 = num57;
                            ObjMTCTFullPrinter objMtctFullPrinter58 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBatMan;
                            Decimal num58 = (Decimal) (int) nullable5.Value;
                            objMtctFullPrinter58.PVM_Agg4 = num58;
                            ObjMTCTFullPrinter objMtctFullPrinter59 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueTol;
                            Decimal num59 = nullable5.Value;
                            objMtctFullPrinter59.SaiSo_Agg4 = num59;
                            ObjMTCTFullPrinter objMtctFullPrinter60 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValuePerTol;
                            Decimal num60 = nullable5.Value;
                            objMtctFullPrinter60.PerSaiSo_Agg4 = num60;
                            ObjMTCTFullPrinter objMtctFullPrinter61 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                            Decimal num61 = nullable5.Value;
                            objMtctFullPrinter61.DoAm_Agg4 = num61;
                            objMtctFullPrinter1.MaterialName_Agg4 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : null;
                            continue;
                          case "Add4":
                            nullable5 = objMeTronChiTiet.SiloValue;
                            if (!nullable5.HasValue)
                              objMeTronChiTiet.SiloValue = new Decimal?(0M);
                            ObjMTCTFullPrinter objMtctFullPrinter62 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.SiloValue;
                            Decimal num62 = nullable5.Value;
                            objMtctFullPrinter62.SiloValue_Add4 = num62;
                            ObjMTCTFullPrinter objMtctFullPrinter63 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.Value;
                            Decimal num63 = nullable5.Value;
                            objMtctFullPrinter63.CP_Add4 = num63;
                            ObjMTCTFullPrinter objMtctFullPrinter64 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBat;
                            Decimal num64 = nullable5.Value;
                            objMtctFullPrinter64.PV_Add4 = num64;
                            ObjMTCTFullPrinter objMtctFullPrinter65 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueBatMan;
                            Decimal num65 = nullable5.Value;
                            objMtctFullPrinter65.PVM_Add4 = num65;
                            ObjMTCTFullPrinter objMtctFullPrinter66 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValueTol;
                            Decimal num66 = nullable5.Value;
                            objMtctFullPrinter66.SaiSo_Add4 = num66;
                            ObjMTCTFullPrinter objMtctFullPrinter67 = objMtctFullPrinter1;
                            nullable5 = objMeTronChiTiet.ValuePerTol;
                            Decimal num67 = nullable5.Value;
                            objMtctFullPrinter67.PerSaiSo_Add4 = num67;
                            objMtctFullPrinter1.MaterialName_Add4 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : null;
                            continue;
                          default:
                            continue;
                        }
                      case '5':
                        if (maSilo == "Agg5")
                        {
                          nullable5 = objMeTronChiTiet.SiloValue;
                          if (!nullable5.HasValue)
                            objMeTronChiTiet.SiloValue = new Decimal?(0M);
                          ObjMTCTFullPrinter objMtctFullPrinter68 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.SiloValue;
                          Decimal num68 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter68.SiloValue_Agg5 = num68;
                          ObjMTCTFullPrinter objMtctFullPrinter69 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.Value;
                          Decimal num69 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter69.CP_Agg5 = num69;
                          ObjMTCTFullPrinter objMtctFullPrinter70 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBat;
                          Decimal num70 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter70.PV_Agg5 = num70;
                          ObjMTCTFullPrinter objMtctFullPrinter71 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueBatMan;
                          Decimal num71 = (Decimal) (int) nullable5.Value;
                          objMtctFullPrinter71.PVM_Agg5 = num71;
                          ObjMTCTFullPrinter objMtctFullPrinter72 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValueTol;
                          Decimal num72 = nullable5.Value;
                          objMtctFullPrinter72.SaiSo_Agg5 = num72;
                          ObjMTCTFullPrinter objMtctFullPrinter73 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.ValuePerTol;
                          Decimal num73 = nullable5.Value;
                          objMtctFullPrinter73.PerSaiSo_Agg5 = num73;
                          ObjMTCTFullPrinter objMtctFullPrinter74 = objMtctFullPrinter1;
                          nullable5 = objMeTronChiTiet.DoAm_NhomSlioAgg;
                          Decimal num74 = nullable5.Value;
                          objMtctFullPrinter74.DoAm_Agg5 = num74;
                          objMtctFullPrinter1.MaterialName_Agg5 = objMeTronChiTiet.MaterialName != null ? objMeTronChiTiet.MaterialName : null;
                          continue;
                        }
                        continue;
                      default:
                        continue;
                    }
                  default:
                    continue;
                }
              }
            }
          }
        }
        bindingList1.Add(objMtctFullPrinter1);
    }




    // Refactored: Logic moved OUTSIDE the loop to correctly process all batches
    
    // --- Step 1: Calculate and Inject Header Rows ---
    // Header 1: "KL 1 Tấn" (Design/Recipe Values)
    // We assume Recipe is constant, so we take SiloValues from the first data row (if available)
    // Note: iterating bindingList1 to find the first "Real" batch (ignoring our headers if we added them, but we haven't yet)
    var firstBatch = bindingList1.FirstOrDefault(); 
    ObjMTCTFullPrinter headerRow1 = new ObjMTCTFullPrinter();
    headerRow1.KLTungMe = "KL 1 Tấn";
    
    // Header 2: "Khối lượng" (Total Actual Sum)
    ObjMTCTFullPrinter headerRow2 = new ObjMTCTFullPrinter();
    headerRow2.KLTungMe = "Khối lượng";

    // Fix 1: Header Calculation Logic
    if (firstBatch != null)
    {
        // Get Batch Size (Default to 1 if missing/zero to avoid divide-by-zero)
        decimal batchSize = 1;
        if (decimal.TryParse(firstBatch.KLTungMe, out decimal parsedSize) && parsedSize > 0)
        {
            batchSize = parsedSize;
        }

        // Set Header Labels (Text goes in LnNo column per User Analysis)
        headerRow1.LnNo = "KL 1 Tấn";
        headerRow1.KLTungMe = "1"; // Normalized Unit

        headerRow2.LnNo = "Khối lượng";
        headerRow2.KLTungMe = batchSize.ToString("0.00"); // Shows specific batch size (e.g. 2.00)

        // Map Values
        // Row 2 (Target/CP) = FirstBatch.CP
        // Row 1 (Recipe) = CP / BatchSize

        // AGG
        headerRow2.PV_Agg1 = firstBatch.CP_Agg1; headerRow1.PV_Agg1 = headerRow2.PV_Agg1 / batchSize;
        headerRow2.PV_Agg2 = firstBatch.CP_Agg2; headerRow1.PV_Agg2 = headerRow2.PV_Agg2 / batchSize;
        headerRow2.PV_Agg3 = firstBatch.CP_Agg3; headerRow1.PV_Agg3 = headerRow2.PV_Agg3 / batchSize;
        headerRow2.PV_Agg4 = firstBatch.CP_Agg4; headerRow1.PV_Agg4 = headerRow2.PV_Agg4 / batchSize;
        headerRow2.PV_Agg5 = firstBatch.CP_Agg5; headerRow1.PV_Agg5 = headerRow2.PV_Agg5 / batchSize;
        headerRow2.PV_Agg6 = firstBatch.CP_Agg6; headerRow1.PV_Agg6 = headerRow2.PV_Agg6 / batchSize;

        // CE
        headerRow2.PV_Ce1 = firstBatch.CP_Ce1; headerRow1.PV_Ce1 = headerRow2.PV_Ce1 / batchSize;
        headerRow2.PV_Ce2 = firstBatch.CP_Ce2; headerRow1.PV_Ce2 = headerRow2.PV_Ce2 / batchSize;
        headerRow2.PV_Ce3 = firstBatch.CP_Ce3; headerRow1.PV_Ce3 = headerRow2.PV_Ce3 / batchSize;
        headerRow2.PV_Ce4 = firstBatch.CP_Ce4; headerRow1.PV_Ce4 = headerRow2.PV_Ce4 / batchSize;
        headerRow2.PV_Ce5 = firstBatch.CP_Ce5; headerRow1.PV_Ce5 = headerRow2.PV_Ce5 / batchSize;

        // WA
        headerRow2.PV_Wa1 = firstBatch.CP_Wa1; headerRow1.PV_Wa1 = headerRow2.PV_Wa1 / batchSize;
        headerRow2.PV_Wa2 = firstBatch.CP_Wa2; headerRow1.PV_Wa2 = headerRow2.PV_Wa2 / batchSize;

        // ADD
        headerRow2.PV_Add1 = firstBatch.CP_Add1; headerRow1.PV_Add1 = headerRow2.PV_Add1 / batchSize;
        headerRow2.PV_Add2 = firstBatch.CP_Add2; headerRow1.PV_Add2 = headerRow2.PV_Add2 / batchSize;
        headerRow2.PV_Add3 = firstBatch.CP_Add3; headerRow1.PV_Add3 = headerRow2.PV_Add3 / batchSize;
        headerRow2.PV_Add4 = firstBatch.CP_Add4; headerRow1.PV_Add4 = headerRow2.PV_Add4 / batchSize;
        headerRow2.PV_Add5 = firstBatch.CP_Add5; headerRow1.PV_Add5 = headerRow2.PV_Add5 / batchSize;
        headerRow2.PV_Add6 = firstBatch.CP_Add6; headerRow1.PV_Add6 = headerRow2.PV_Add6 / batchSize;
    }

    // Insert Headers at Top
    bindingList1.Insert(0, headerRow2); // Insert 2nd row (index 0) >> becomes index 1
    bindingList1.Insert(0, headerRow1); // Insert 1st row (index 0) >> becomes index 0

    // --- Step 2: Determine Column Names (First Non-Null Scan) ---
    this.head_Agg1 = bindingList1.Select(x => x.MaterialName_Agg1).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Agg2 = bindingList1.Select(x => x.MaterialName_Agg2).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Agg3 = bindingList1.Select(x => x.MaterialName_Agg3).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Agg4 = bindingList1.Select(x => x.MaterialName_Agg4).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Agg5 = bindingList1.Select(x => x.MaterialName_Agg5).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Agg6 = bindingList1.Select(x => x.MaterialName_Agg6).FirstOrDefault(x => !string.IsNullOrEmpty(x));

    this.head_Ce1 = bindingList1.Select(x => x.MaterialName_Ce1).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Ce2 = bindingList1.Select(x => x.MaterialName_Ce2).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Ce3 = bindingList1.Select(x => x.MaterialName_Ce3).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Ce4 = bindingList1.Select(x => x.MaterialName_Ce4).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Ce5 = bindingList1.Select(x => x.MaterialName_Ce5).FirstOrDefault(x => !string.IsNullOrEmpty(x));

    this.head_Wa1 = bindingList1.Select(x => x.MaterialName_Wa1).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Wa2 = bindingList1.Select(x => x.MaterialName_Wa2).FirstOrDefault(x => !string.IsNullOrEmpty(x));

    this.head_Add1 = bindingList1.Select(x => x.MaterialName_Add1).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Add2 = bindingList1.Select(x => x.MaterialName_Add2).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Add3 = bindingList1.Select(x => x.MaterialName_Add3).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Add4 = bindingList1.Select(x => x.MaterialName_Add4).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Add5 = bindingList1.Select(x => x.MaterialName_Add5).FirstOrDefault(x => !string.IsNullOrEmpty(x));
    this.head_Add6 = bindingList1.Select(x => x.MaterialName_Add6).FirstOrDefault(x => !string.IsNullOrEmpty(x));

    // Fallback: If Data Header is missing, try to retrieve from the Detail Grid's current caption
    // (User indicates Detail Grid has correct names like "Nhiệt độ", while Data might be missing them)
    if (string.IsNullOrEmpty(this.head_Agg1)) this.head_Agg1 = this.bandedGridView1.Bands["Agg1"].Caption;
    if (string.IsNullOrEmpty(this.head_Agg2)) this.head_Agg2 = this.bandedGridView1.Bands["Agg2"].Caption;
    if (string.IsNullOrEmpty(this.head_Agg3)) this.head_Agg3 = this.bandedGridView1.Bands["Agg3"].Caption;
    if (string.IsNullOrEmpty(this.head_Agg4)) this.head_Agg4 = this.bandedGridView1.Bands["Agg4"].Caption;
    if (string.IsNullOrEmpty(this.head_Agg5)) this.head_Agg5 = this.bandedGridView1.Bands["Agg5"].Caption;
    if (string.IsNullOrEmpty(this.head_Agg6)) this.head_Agg6 = this.bandedGridView1.Bands["Agg6"].Caption;

    if (string.IsNullOrEmpty(this.head_Ce1)) this.head_Ce1 = this.bandedGridView1.Bands["Ce1"].Caption;
    if (string.IsNullOrEmpty(this.head_Ce2)) this.head_Ce2 = this.bandedGridView1.Bands["Ce2"].Caption;
    if (string.IsNullOrEmpty(this.head_Ce3)) this.head_Ce3 = this.bandedGridView1.Bands["Ce3"].Caption;
    if (string.IsNullOrEmpty(this.head_Ce4)) this.head_Ce4 = this.bandedGridView1.Bands["Ce4"].Caption;
    if (string.IsNullOrEmpty(this.head_Ce5)) this.head_Ce5 = this.bandedGridView1.Bands["Ce5"].Caption;

    if (string.IsNullOrEmpty(this.head_Wa1)) this.head_Wa1 = this.bandedGridView1.Bands["Wa1"].Caption;
    if (string.IsNullOrEmpty(this.head_Wa2)) this.head_Wa2 = this.bandedGridView1.Bands["Wa2"].Caption;

    if (string.IsNullOrEmpty(this.head_Add1)) this.head_Add1 = this.bandedGridView1.Bands["Add1"].Caption;
    if (string.IsNullOrEmpty(this.head_Add2)) this.head_Add2 = this.bandedGridView1.Bands["Add2"].Caption;
    if (string.IsNullOrEmpty(this.head_Add3)) this.head_Add3 = this.bandedGridView1.Bands["Add3"].Caption;
    if (string.IsNullOrEmpty(this.head_Add4)) this.head_Add4 = this.bandedGridView1.Bands["Add4"].Caption;
    if (string.IsNullOrEmpty(this.head_Add5)) this.head_Add5 = this.bandedGridView1.Bands["Add5"].Caption;
    if (string.IsNullOrEmpty(this.head_Add6)) this.head_Add6 = this.bandedGridView1.Bands["Add6"].Caption;

    // --- Step 3: Dynamic Visibility (HasData Logic) ---
    // Update: Check for CP (Target) OR PV (Actual) OR SiloValue existence
    // This ensures we catch any data trace.
    Func<ObjMTCTFullPrinter, bool> hasDataAgg1 = x => x.PV_Agg1 != 0 || x.CP_Agg1 != 0 || x.SiloValue_Agg1 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAgg2 = x => x.PV_Agg2 != 0 || x.CP_Agg2 != 0 || x.SiloValue_Agg2 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAgg3 = x => x.PV_Agg3 != 0 || x.CP_Agg3 != 0 || x.SiloValue_Agg3 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAgg4 = x => x.PV_Agg4 != 0 || x.CP_Agg4 != 0 || x.SiloValue_Agg4 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAgg5 = x => x.PV_Agg5 != 0 || x.CP_Agg5 != 0 || x.SiloValue_Agg5 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAgg6 = x => x.PV_Agg6 != 0 || x.CP_Agg6 != 0 || x.SiloValue_Agg6 != 0;

    Func<ObjMTCTFullPrinter, bool> hasDataCe1 = x => x.PV_Ce1 != 0 || x.CP_Ce1 != 0 || x.SiloValue_Ce1 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataCe2 = x => x.PV_Ce2 != 0 || x.CP_Ce2 != 0 || x.SiloValue_Ce2 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataCe3 = x => x.PV_Ce3 != 0 || x.CP_Ce3 != 0 || x.SiloValue_Ce3 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataCe4 = x => x.PV_Ce4 != 0 || x.CP_Ce4 != 0 || x.SiloValue_Ce4 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataCe5 = x => x.PV_Ce5 != 0 || x.CP_Ce5 != 0 || x.SiloValue_Ce5 != 0;

    Func<ObjMTCTFullPrinter, bool> hasDataWa1 = x => x.PV_Wa1 != 0 || x.CP_Wa1 != 0 || x.SiloValue_Wa1 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataWa2 = x => x.PV_Wa2 != 0 || x.CP_Wa2 != 0 || x.SiloValue_Wa2 != 0;

    Func<ObjMTCTFullPrinter, bool> hasDataAdd1 = x => x.PV_Add1 != 0 || x.CP_Add1 != 0 || x.SiloValue_Add1 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAdd2 = x => x.PV_Add2 != 0 || x.CP_Add2 != 0 || x.SiloValue_Add2 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAdd3 = x => x.PV_Add3 != 0 || x.CP_Add3 != 0 || x.SiloValue_Add3 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAdd4 = x => x.PV_Add4 != 0 || x.CP_Add4 != 0 || x.SiloValue_Add4 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAdd5 = x => x.PV_Add5 != 0 || x.CP_Add5 != 0 || x.SiloValue_Add5 != 0;
    Func<ObjMTCTFullPrinter, bool> hasDataAdd6 = x => x.PV_Add6 != 0 || x.CP_Add6 != 0 || x.SiloValue_Add6 != 0;

    // Hybrid Visibility Logic: Show if (Index <= ConfiguredSilos AND Name is Valid) OR (HasData)
    // This ensures we show configured columns, but ONLY if they are actually used (have a name).
    // Unnamed columns (even if configured) will remain hidden unless they have data.

    bool show_Agg1 = ((1 <= this.num_silo_Agg) && !string.IsNullOrEmpty(this.head_Agg1)) || bindingList1.Any(hasDataAgg1);
    bool show_Agg2 = ((2 <= this.num_silo_Agg) && !string.IsNullOrEmpty(this.head_Agg2)) || bindingList1.Any(hasDataAgg2);
    bool show_Agg3 = ((3 <= this.num_silo_Agg) && !string.IsNullOrEmpty(this.head_Agg3)) || bindingList1.Any(hasDataAgg3);
    bool show_Agg4 = ((4 <= this.num_silo_Agg) && !string.IsNullOrEmpty(this.head_Agg4)) || bindingList1.Any(hasDataAgg4);
    bool show_Agg5 = ((5 <= this.num_silo_Agg) && !string.IsNullOrEmpty(this.head_Agg5)) || bindingList1.Any(hasDataAgg5);
    bool show_Agg6 = ((6 <= this.num_silo_Agg) && !string.IsNullOrEmpty(this.head_Agg6)) || bindingList1.Any(hasDataAgg6);

    bool show_Ce1 = ((1 <= this.num_silo_Ce) && !string.IsNullOrEmpty(this.head_Ce1)) || bindingList1.Any(hasDataCe1);
    bool show_Ce2 = ((2 <= this.num_silo_Ce) && !string.IsNullOrEmpty(this.head_Ce2)) || bindingList1.Any(hasDataCe2);
    bool show_Ce3 = ((3 <= this.num_silo_Ce) && !string.IsNullOrEmpty(this.head_Ce3)) || bindingList1.Any(hasDataCe3);
    bool show_Ce4 = ((4 <= this.num_silo_Ce) && !string.IsNullOrEmpty(this.head_Ce4)) || bindingList1.Any(hasDataCe4);
    bool show_Ce5 = ((5 <= this.num_silo_Ce) && !string.IsNullOrEmpty(this.head_Ce5)) || bindingList1.Any(hasDataCe5);

    bool show_Wa1 = ((1 <= this.num_silo_Wa) && !string.IsNullOrEmpty(this.head_Wa1)) || bindingList1.Any(hasDataWa1);
    bool show_Wa2 = ((2 <= this.num_silo_Wa) && !string.IsNullOrEmpty(this.head_Wa2)) || bindingList1.Any(hasDataWa2);

    bool show_Add1 = ((1 <= this.num_silo_Add) && !string.IsNullOrEmpty(this.head_Add1)) || bindingList1.Any(hasDataAdd1);
    bool show_Add2 = ((2 <= this.num_silo_Add) && !string.IsNullOrEmpty(this.head_Add2)) || bindingList1.Any(hasDataAdd2);
    bool show_Add3 = ((3 <= this.num_silo_Add) && !string.IsNullOrEmpty(this.head_Add3)) || bindingList1.Any(hasDataAdd3);
    bool show_Add4 = ((4 <= this.num_silo_Add) && !string.IsNullOrEmpty(this.head_Add4)) || bindingList1.Any(hasDataAdd4);
    bool show_Add5 = ((5 <= this.num_silo_Add) && !string.IsNullOrEmpty(this.head_Add5)) || bindingList1.Any(hasDataAdd5);
    bool show_Add6 = ((6 <= this.num_silo_Add) && !string.IsNullOrEmpty(this.head_Add6)) || bindingList1.Any(hasDataAdd6);

    // Apply Visibility to Detail Grid (bandedGridView1) AND Total Grid (bandedGridView2)
    // AGG
    SetBandVisibility(this.bandedGridView1, "Agg1", show_Agg1, this.head_Agg1);
    SetBandVisibility(this.bandedGridView2, "Total_Agg1", show_Agg1, this.head_Agg1);

    SetBandVisibility(this.bandedGridView1, "Agg2", show_Agg2, this.head_Agg2);
    SetBandVisibility(this.bandedGridView2, "Total_Agg2", show_Agg2, this.head_Agg2);

    SetBandVisibility(this.bandedGridView1, "Agg3", show_Agg3, this.head_Agg3);
    SetBandVisibility(this.bandedGridView2, "Total_Agg3", show_Agg3, this.head_Agg3);

    SetBandVisibility(this.bandedGridView1, "Agg4", show_Agg4, this.head_Agg4);
    SetBandVisibility(this.bandedGridView2, "Total_Agg4", show_Agg4, this.head_Agg4);

    SetBandVisibility(this.bandedGridView1, "Agg5", show_Agg5, this.head_Agg5);
    SetBandVisibility(this.bandedGridView2, "Total_Agg5", show_Agg5, this.head_Agg5);

    SetBandVisibility(this.bandedGridView1, "Agg6", show_Agg6, this.head_Agg6);
    SetBandVisibility(this.bandedGridView2, "Total_Agg6", show_Agg6, this.head_Agg6);

    // CE
    SetBandVisibility(this.bandedGridView1, "Ce1", show_Ce1, this.head_Ce1);
    SetBandVisibility(this.bandedGridView2, "Total_Ce1", show_Ce1, this.head_Ce1);

    SetBandVisibility(this.bandedGridView1, "Ce2", show_Ce2, this.head_Ce2);
    SetBandVisibility(this.bandedGridView2, "Total_Ce2", show_Ce2, this.head_Ce2);

    SetBandVisibility(this.bandedGridView1, "Ce3", show_Ce3, this.head_Ce3);
    SetBandVisibility(this.bandedGridView2, "Total_Ce3", show_Ce3, this.head_Ce3);

    SetBandVisibility(this.bandedGridView1, "Ce4", show_Ce4, this.head_Ce4);
    SetBandVisibility(this.bandedGridView2, "Total_Ce4", show_Ce4, this.head_Ce4);

    SetBandVisibility(this.bandedGridView1, "Ce5", show_Ce5, this.head_Ce5);
    SetBandVisibility(this.bandedGridView2, "Total_Ce5", show_Ce5, this.head_Ce5);

    // WA
    SetBandVisibility(this.bandedGridView1, "Wa1", show_Wa1, this.head_Wa1);
    SetBandVisibility(this.bandedGridView2, "Total_Wa1", show_Wa1, this.head_Wa1);

    SetBandVisibility(this.bandedGridView1, "Wa2", show_Wa2, this.head_Wa2);
    SetBandVisibility(this.bandedGridView2, "Total_Wa2", show_Wa2, this.head_Wa2);

    // ADD
    SetBandVisibility(this.bandedGridView1, "Add1", show_Add1, this.head_Add1);
    SetBandVisibility(this.bandedGridView2, "Total_Add1", show_Add1, this.head_Add1);

    SetBandVisibility(this.bandedGridView1, "Add2", show_Add2, this.head_Add2);
    SetBandVisibility(this.bandedGridView2, "Total_Add2", show_Add2, this.head_Add2);

    SetBandVisibility(this.bandedGridView1, "Add3", show_Add3, this.head_Add3);
    SetBandVisibility(this.bandedGridView2, "Total_Add3", show_Add3, this.head_Add3);

    SetBandVisibility(this.bandedGridView1, "Add4", show_Add4, this.head_Add4);
    SetBandVisibility(this.bandedGridView2, "Total_Add4", show_Add4, this.head_Add4);

    SetBandVisibility(this.bandedGridView1, "Add5", show_Add5, this.head_Add5);
    SetBandVisibility(this.bandedGridView2, "Total_Add5", show_Add5, this.head_Add5);

    SetBandVisibility(this.bandedGridView1, "Add6", show_Add6, this.head_Add6);
    SetBandVisibility(this.bandedGridView2, "Total_Add6", show_Add6, this.head_Add6);

    // Data Sources
    this.bandedGridView1.GridControl.DataSource = bindingList1;
    BindingList<ObjTotalMaterialPrinter> toLst = new BindingList<ObjTotalMaterialPrinter>();
    this.CopyLstFullToLstMaterial(bindingList1, toLst);
    this.bandedGridView2.GridControl.DataSource = toLst;

    // Call Helpers
    this.PopulateTablePTCT(bindingList1);
}

// Helper for cleaner code
private void SetBandVisibility(DevExpress.XtraGrid.Views.BandedGrid.BandedGridView view, string bandName, bool visible, string caption)
{
    if (view.Bands[bandName] != null)
    {
        view.Bands[bandName].Visible = visible;
        // Only update caption if provided. otherwise keep designer default
        if (!string.IsNullOrEmpty(caption))
        {
            view.Bands[bandName].Caption = caption;
        }
    }
}



    private void CreateTableTotalMaterial(
      int numAgg,
      int numCe,
      int numWa,
      int numAdd,
      BindingList<ObjMTCTFullPrinter> _lstFullPrinter)
    {
      if (_lstFullPrinter == null || _lstFullPrinter.Count == 0)
        return;
      this.bandedGridView2.Bands["Total_Agg1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg1;
      this.bandedGridView2.Bands["Total_Agg2"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg2;
      this.bandedGridView2.Bands["Total_Agg3"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg3;
      this.bandedGridView2.Bands["Total_Agg4"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg4;
      this.bandedGridView2.Bands["Total_Agg5"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg5;
      this.bandedGridView2.Bands["Total_Ce1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Ce1;
      this.bandedGridView2.Bands["Total_Wa1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Wa1;
      this.bandedGridView2.Bands["Total_Add1"].Caption = _lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Add1;
      this.bandedGridView2.Bands["Total_Add2"].Caption = "Nhiệt độ Tan sấy";
      this.bandedGridView2.Bands["Total_Add3"].Caption = "Nhiệt độ AGG";
      this.bandedGridView2.Bands["Total_Add4"].Caption = "Nhiệt độ Nhựa";
      List<GridBand> gridBandList1 = new List<GridBand>();
      if (_lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg1 != null)
        gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg1"]);
      if (_lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg2 != null)
        gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg2"]);
      if (_lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg3 != null)
        gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg3"]);
      if (_lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg4 != null)
        gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg4"]);
      if (_lstFullPrinter.FirstOrDefault<ObjMTCTFullPrinter>().MaterialName_Agg5 != null)
        gridBandList1.Add(this.bandedGridView2.Bands["Total_Agg5"]);
      foreach (GridBand gridBand in gridBandList1)
        gridBand.Visible = false;
      for (int index = 0; index < gridBandList1.Count; ++index)
        gridBandList1[index].Visible = true;
      List<GridBand> gridBandList2 = new List<GridBand>();
      gridBandList2.Add(this.bandedGridView2.Bands["Total_Ce1"]);
      foreach (GridBand gridBand in gridBandList2)
        gridBand.Visible = false;
      for (int index = 0; index < gridBandList2.Count; ++index)
        gridBandList2[index].Visible = true;
      List<GridBand> gridBandList3 = new List<GridBand>();
      gridBandList3.Add(this.bandedGridView2.Bands["Total_Wa1"]);
      foreach (GridBand gridBand in gridBandList3)
        gridBand.Visible = false;
      for (int index = 0; index < numWa; ++index)
        gridBandList3[index].Visible = true;
      List<GridBand> gridBandList4 = new List<GridBand>();
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add1"]);
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add2"]);
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add3"]);
      gridBandList4.Add(this.bandedGridView2.Bands["Total_Add4"]);
      foreach (GridBand gridBand in gridBandList4)
        gridBand.Visible = false;
      for (int index = 0; index < gridBandList4.Count; ++index)
        gridBandList4[index].Visible = true;
    }

    private void PopulateTablePTCT(BindingList<ObjMTCTFullPrinter> bindingList1)
    {
         if (bindingList1 != null && bindingList1.Count > 0)
         {
             this._tablePTCT = Converter.ToDataTable<ObjMTCTFullPrinter>(bindingList1.ToList());
         }
         else
         {
             this._tablePTCT = new System.Data.DataTable();
         }
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
        totalMaterialPrinter1.Total_PV_Ce1 += objMtctFullPrinter.PV_Ce1;
        totalMaterialPrinter1.Total_PV_Wa1 += objMtctFullPrinter.PV_Wa1;
        totalMaterialPrinter1.Total_PV_Add1 += objMtctFullPrinter.PV_Add1;
        totalMaterialPrinter1.Total_PV_Add2 = objMtctFullPrinter.PV_Add2;
        totalMaterialPrinter1.Total_PV_Add3 = objMtctFullPrinter.PV_Add3;
        totalMaterialPrinter1.Total_PV_Add4 = objMtctFullPrinter.PV_Add4;
        totalMaterialPrinter1.Name_AGG1 = objMtctFullPrinter.MaterialName_Agg1;
        totalMaterialPrinter1.Name_AGG2 = objMtctFullPrinter.MaterialName_Agg2;
        totalMaterialPrinter1.Name_AGG3 = objMtctFullPrinter.MaterialName_Agg3;
        totalMaterialPrinter1.Name_AGG4 = objMtctFullPrinter.MaterialName_Agg4;
        totalMaterialPrinter1.Name_AGG5 = objMtctFullPrinter.MaterialName_Agg5;
        totalMaterialPrinter1.Name_CE1 = objMtctFullPrinter.MaterialName_Ce1;
        totalMaterialPrinter1.Name_WA1 = objMtctFullPrinter.MaterialName_Wa1;
        totalMaterialPrinter1.Name_ADD1 = objMtctFullPrinter.MaterialName_Add1;
        totalMaterialPrinter1.Name_ADD2 = objMtctFullPrinter.MaterialName_Add2;
        totalMaterialPrinter1.Name_ADD3 = objMtctFullPrinter.MaterialName_Add3;
        totalMaterialPrinter1.Name_ADD4 = objMtctFullPrinter.MaterialName_Add4;
      }
      toLst.Add(totalMaterialPrinter1);
    }

    private void LoadPrinters()
    {
      try
      {
        foreach (string installedPrinter in PrinterSettings.InstalledPrinters)
        {
          this.listPrinter_GH.Add(installedPrinter);
          this.listPrinter_CT.Add(installedPrinter);
        }
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show("Error loading printers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      this.luePrinter_GH.Properties.DataSource = (object) this.listPrinter_GH;
      this.luePrinter_CT.Properties.DataSource = (object) this.listPrinter_CT;
    }

    private void FormPhieuIn_Load(object sender, EventArgs e)
    {
      this.LoadPrinters();
      this.LoadValuePrinter();
    }

    private void luePrinter_GH_EditValueChanged(object sender, EventArgs e)
    {
      ConfigManager.TramTronConfig.MayInPI = this.luePrinter_GH.EditValue.ToString();
    }

    private void luePrinter_CT_EditValueChanged(object sender, EventArgs e)
    {
      ConfigManager.TramTronConfig.MayInPICT = this.luePrinter_CT.EditValue.ToString();
    }

    private void grvPhieuTron_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      this.DoFocusPhieuTron();
    }

    private void grvPhieuTron_02_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
    {
      this.DoFocusPhieuTron_02();
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      this.ClearDataPhieuTron();
      this.LoadPhieuTron();
    }

    private void btnLamMoi_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnTimKiem_02_Click(object sender, EventArgs e)
    {
      this.ClearDataPhieuTron_02();
      this.LoadPhieuTron_02();
    }

    private void btnLamMoi_02_Click(object sender, EventArgs e)
    {
      this.LoadSearchDefaultValues_02();
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
      if (this.grvPhieuTron == null || this.grvPhieuTron.SelectedRowsCount == 0)
        return;
      this.btnPrint.Enabled = false;
      if (!ConfigManager.TramTronConfig.InPITuMau)
        return;
      this.PrintPTFromFile_NewTread();
    }

    private void PrintPTFromFile_NewTread()
    {
      this.thread_GH = new Thread(new ThreadStart(this.PrintPTFromFile));
      this.thread_GH.Start();
    }

    private void PrintPTFromFile()
    {
      try
      {
        this.PrintPTFromFile_SA();
        this.Invoke(new System.Action(() =>
    {
        this.numberOfCopies_GH = (int)this.spin_numberOfCopies.Value;
    }));
        if (this.filePathMau != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau);
        if (!this.PrinterInvoke(Path.Combine(this.folderDesPhieuPath, this.fileName), this.numberOfCopies_GH, ConfigManager.TramTronConfig.MayInPI))
          return;
        this.Invoke(new System.Action(() =>
    {
        this.btnPrint.Enabled = true;
    }));
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void PrintPTFromFile_SA()
    {
      if (this.InvokeRequired)
      {
          this.Invoke(new System.Action(() => this.GetParam()));
      }
      else
      {
          this.GetParam();
      }
      Support.CloseWordApplications();
      this.DeleteAllFilesInDirectory(this.folderDesPhieuPath);
      this.WriteDetailInvoice(this.lstParam, null, null, null);
      try
      {
        if (this.filePathMau != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau);
        Path.Combine(this.folderDesPhieuPath, this.fileName);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
        object missing1 = Type.Missing;
        ref object local1 = ref missing1;
        object missing2 = Type.Missing;
        ref object local2 = ref missing2;
        object missing3 = Type.Missing;
        ref object local3 = ref missing3;
        // ISSUE: reference to a compiler-generated method
        instance.Quit(ref local1, ref local2, ref local3);
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
      }
    }

    public async System.Threading.Tasks.Task DeleteAllFilesInDirectory(string directoryPath)
    {
      try
      {
        if (Directory.Exists(directoryPath))
        {
          string[] strArray = Directory.GetFiles(directoryPath);
          for (int index = 0; index < strArray.Length; ++index)
          {
            string file = strArray[index];
            await System.Threading.Tasks.Task.Run((Action) (() => File.Delete(file)));
          }
          strArray = (string[]) null;
          Console.WriteLine("All files in the directory have been deleted successfully.");
        }
        else
          Console.WriteLine("The directory does not exist.");
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("An error occurred while deleting files: " + ex.Message);
      }
    }

    private void GetParam()
    {
      this.lstParam.Clear();
      this.lstParam.Add(ConfigManager.TramTronConfig.TenCty);
      this.lstParam.Add(this.datNgayTron.DateTime.ToString("dd-MM-yyyy"));
      this.lstParam.Add(this.txtTenCongTruong.Text);
      this.lstParam.Add(this.txtTenKhachHang.Text);
      this.lstParam.Add(this.txtTenMAC.Text);
      this.lstParam.Add(this.txtCuongDo.Text);
      this.lstParam.Add(this.txtSTTPhieuTron.Text);
      this.lstParam.Add("200");
      this.lstParam.Add(this.txtDoSut.Text);
      this.lstParam.Add(this.txtTaiXe.Text);
      this.lstParam.Add(this.txtKhoiLuongDatHang.Text);
      this.lstParam.Add(this.txtTheTich.Text);
      this.lstParam.Add(this.txtLuyKe.Text);
      this.lstParam.Add(this.txtXe.Text);
      this.lstParam.Add(this.txtGioTron.Text);
      this.lstParam.Add(this.txtDiaDiem.Text);
      this.lstParam.Add(this.txtMaPhieuTron.Text);
      this.lstParam.Add("1");
      this.lstParam.Add(this.txtHangMuc.Text);
      this.lstParam.Add(this.txtNiemChi.Text);
      this.lstParam.Add(this.txtNguoiTron.Text);
      this.lstParam.Add(this.txtGioKTTron.Text);
      this.lstParam.Add(this.txtBom.Text);
    }

    private void GetParam_02()
    {
      this.lstParam_02.Clear();
      this.lstParam_02.Add(ConfigManager.TramTronConfig.TenCty);
      this.lstParam_02.Add(this.datNgayTron_02.DateTime.ToString("dd-MM-yyyy"));
      this.lstParam_02.Add(this.txtTenCongTruong_02.Text);
      this.lstParam_02.Add(this.txtTenKhachHang_02.Text);
      this.lstParam_02.Add(this.txtTenMAC_02.Text);
      this.lstParam_02.Add(this.txtCuongDo_02.Text);
      this.lstParam_02.Add(this.txtSTTPhieuTron_02.Text);
      this.lstParam_02.Add("200");
      this.lstParam_02.Add(this.txtDoSut_02.Text);
      this.lstParam_02.Add(this.txtTaiXe_02.Text);
      this.lstParam_02.Add(this.txtKhoiLuongDatHang_02.Text);
      this.lstParam_02.Add(this.txtTheTich_02.Text);
      this.lstParam_02.Add(this.txtLuyKe_02.Text);
      this.lstParam_02.Add(this.txtXe_02.Text);
      this.lstParam_02.Add(this.txtGioTron_02.Text);
      this.lstParam_02.Add(this.txtDiaDiem_02.Text);
      this.lstParam_02.Add(this.txtMaPhieuTron_02.Text);
      this.lstParam_02.Add("1");
      this.lstParam_02.Add(this.txtHangMuc_02.Text);
      this.lstParam_02.Add(this.txtNiemChi_02.Text);
      this.lstParam_02.Add(this.txtNguoiTron_02.Text);
      this.lstParam_02.Add(this.txtGioKTTron_02.Text);
    }

    private void WriteDetailInvoice(
      List<string> param,
      System.Data.DataTable dataTable1,
      System.Data.DataTable dataTable2,
      System.Data.DataTable dataTable3)
    {
      Microsoft.Office.Interop.Word.Application instance = null;
      try
      {
        if (!this.CopyTempFile() || this._error)
          return;
        if (this.filePathMau != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau);
        string str = Path.Combine(ConfigManager.TramTronConfig.ReportPath, this.fileName);
        // ISSUE: variable of a compiler-generated type
        instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
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
        documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
        for (int index = 0; index < param.Count; ++index)
        {
          string searchText = "{" + index.ToString() + "}";
          this.ReplaceText(instance, searchText, param[index]);
        }
        // ISSUE: variable of a compiler-generated type
        Document activeDocument = instance.ActiveDocument;
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
        missing5 = Type.Missing;
        ref object local27 = ref missing5;
        missing4 = Type.Missing;
        ref object local28 = ref missing4;
        object missing14 = Type.Missing;
        ref object local29 = ref missing14;
        object missing15 = Type.Missing;
        ref object local30 = ref missing15;
        object missing16 = Type.Missing;
        ref object local31 = ref missing16;
        object missing17 = Type.Missing;
        ref object local32 = ref missing17;
        // ISSUE: reference to a compiler-generated method
        activeDocument.SaveAs(ref local17, ref local18, ref local19, ref local20, ref local21, ref local22, ref local23, ref local24, ref local25, ref local26, ref local27, ref local28, ref local29, ref local30, ref local31, ref local32);
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
      }
      finally
      {
          if (instance != null)
          {
            object missing17 = Type.Missing;
            ref object local33 = ref missing17;
            object missing16 = Type.Missing;
            ref object local34 = ref missing16;
            object missing15 = Type.Missing;
            ref object local35 = ref missing15;
            // ISSUE: reference to a compiler-generated method
            instance.Quit(ref local33, ref local34, ref local35);
          }
      }
    }

    private bool CopyTempFile()
    {
      string piPath1 = ConfigManager.TramTronConfig.PIPath;
      string path2 = "";
      string piPath2 = ConfigManager.TramTronConfig.PIPath;
      if (piPath2 != string.Empty)
        path2 = Path.GetFileName(piPath2);
      string str = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
      try
      {
        if (!File.Exists(str))
          File.Copy(piPath1, str, true);
        this._error = false;
      }
      catch (System.Exception ex)
      {
        this._error = true;
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      return true;
    }

    private bool CopyTempFile_02()
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

    public bool PrinterInvoke(string pdfFilePath, int numberOfCopies, string printerName)
    {
      try
      {
        System.Threading.Tasks.Task[] taskArray = new System.Threading.Tasks.Task[numberOfCopies];
        for (int index = 0; index < numberOfCopies; ++index)
          taskArray[index] = System.Threading.Tasks.Task.Run((Action) (() => Support.PrintReportNEW(pdfFilePath, printerName)));
        System.Threading.Tasks.Task.WaitAll(taskArray);
        return true;
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      return false;
    }

    public bool PrinterInvokePDF(string pdfFilePath, int numberOfCopies, string printerName)
    {
      try
      {
        System.Threading.Tasks.Task[] taskArray = new System.Threading.Tasks.Task[numberOfCopies];
        for (int index = 0; index < numberOfCopies; ++index)
          taskArray[index] = System.Threading.Tasks.Task.Run((Action) (() => Support.PrintReportNEW(pdfFilePath, printerName)));
        System.Threading.Tasks.Task.WaitAll(taskArray);
        return true;
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      return false;
    }

    public bool PrinterInvokeWord(string pdfFilePath, int numberOfCopies, string printerName)
    {
      try
      {
        System.Threading.Tasks.Task[] taskArray = new System.Threading.Tasks.Task[numberOfCopies];
        for (int index = 0; index < numberOfCopies; ++index)
          taskArray[index] = System.Threading.Tasks.Task.Run((Action) (() => Support.PrintReportWord(pdfFilePath, printerName)));
        System.Threading.Tasks.Task.WaitAll(taskArray);
        return true;
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      return false;
    }

    private bool PrinterFileWordInvoke(string wordFilePath, int numberOfCopies)
    {
      // ISSUE: variable of a compiler-generated type
      Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
      // ISSUE: variable of a compiler-generated type
      Document o = (Document) null;
      try
      {
        // ISSUE: variable of a compiler-generated type
        Documents documents = instance.Documents;
        object obj1 = (object) wordFilePath;
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
        object missing14 = Type.Missing;
        ref object local15 = ref missing14;
        object missing15 = Type.Missing;
        ref object local16 = ref missing15;
        // ISSUE: reference to a compiler-generated method
        o = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
        for (int index = 0; index < numberOfCopies; ++index)
        {
          // ISSUE: variable of a compiler-generated type
          Document document = o;
          object missing16 = Type.Missing;
          ref object local17 = ref missing16;
          object missing17 = Type.Missing;
          ref object local18 = ref missing17;
          object missing18 = Type.Missing;
          ref object local19 = ref missing18;
          object missing19 = Type.Missing;
          ref object local20 = ref missing19;
          object missing20 = Type.Missing;
          ref object local21 = ref missing20;
          object missing21 = Type.Missing;
          ref object local22 = ref missing21;
          object missing22 = Type.Missing;
          ref object local23 = ref missing22;
          object missing23 = Type.Missing;
          ref object local24 = ref missing23;
          object missing24 = Type.Missing;
          ref object local25 = ref missing24;
          object missing25 = Type.Missing;
          ref object local26 = ref missing25;
          object missing26 = Type.Missing;
          ref object local27 = ref missing26;
          object missing27 = Type.Missing;
          ref object local28 = ref missing27;
          object missing28 = Type.Missing;
          ref object local29 = ref missing28;
          object missing29 = Type.Missing;
          ref object local30 = ref missing29;
          missing1 = Type.Missing;
          ref object local31 = ref missing1;
          object missing30 = Type.Missing;
          ref object local32 = ref missing30;
          object missing31 = Type.Missing;
          ref object local33 = ref missing31;
          object missing32 = Type.Missing;
          ref object local34 = ref missing32;
          // ISSUE: reference to a compiler-generated method
          document.PrintOut(ref local17, ref local18, ref local19, ref local20, ref local21, ref local22, ref local23, ref local24, ref local25, ref local26, ref local27, ref local28, ref local29, ref local30, ref local31, ref local32, ref local33, ref local34);
        }
        // ISSUE: variable of a compiler-generated type
        Document document1 = o;
        object obj2 = (object) WdSaveOptions.wdDoNotSaveChanges;
        ref object local35 = ref obj2;
        object missing33 = Type.Missing;
        ref object local36 = ref missing33;
        object missing34 = Type.Missing;
        ref object local37 = ref missing34;
        // ISSUE: reference to a compiler-generated method
        document1.Close(ref local35, ref local36, ref local37);
        return true;
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
        return false;
      }
      finally
      {
        if (o != null)
          Marshal.ReleaseComObject((object) o);
        if (instance != null)
        {
          // ISSUE: variable of a compiler-generated type
          Microsoft.Office.Interop.Word.Application application = instance;
          object missing35 = Type.Missing;
          ref object local38 = ref missing35;
          object missing36 = Type.Missing;
          ref object local39 = ref missing36;
          object missing37 = Type.Missing;
          ref object local40 = ref missing37;
          // ISSUE: reference to a compiler-generated method
          application.Quit(ref local38, ref local39, ref local40);
          Marshal.ReleaseComObject((object) instance);
        }
      }
    }

    private void btnInPCT_Click(object sender, EventArgs e)
    {
      if (this.grvPhieuTron_02 == null || this.grvPhieuTron_02.SelectedRowsCount == 0)
        return;
      this.btnInPCT.Enabled = false;
      this.PrintPTFromFile_02_NewTread();
    }

    private void PrintPTFromFile_02_NewTread()
    {
      this.thread_CT = new Thread(new ThreadStart(this.PrintPTFromFile_02));
      this.thread_CT.Start();
    }

    private void DeleteFileGH()
    {
      string path2 = "";
      string piPath = ConfigManager.TramTronConfig.PIPath;
      if (piPath != string.Empty)
        path2 = Path.GetFileName(piPath);
      string path = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
      if (!File.Exists(path))
        return;
      File.Delete(path);
    }

    private void DeleteFileCTMT()
    {
      string path2 = "";
      string pictPath = ConfigManager.TramTronConfig.PICTPath;
      if (pictPath != string.Empty)
        path2 = Path.GetFileName(pictPath);
      string path = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
      try
      {
        if (!File.Exists(path))
          return;
        File.Delete(path);
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("Error: " + ex.Message);
      }
    }
    private void PrintPTFromFile_02()
    {
      Support.CloseWordApplications();
      this.DeleteFileCTMT();
      this.dataTableNameMaterial = this.CreateTableNameMaterial(this._tablePTCT);
      this.dataTableSumMaterial = this.CreateTableSumMaterial(this._tablePTCT);
      this.GetParam_02();
      try {
          string debugPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "print_debug.txt");
          List<string> debugLines = new List<string>();
          debugLines.Add("DateTime: " + DateTime.Now.ToString());
          if (this._tablePTCT != null) {
              debugLines.Add("Table Rows: " + this._tablePTCT.Rows.Count);
              if (this._tablePTCT.Rows.Count > 0) {
                  debugLines.Add("First Row Data Preview:");
                  for(int i=0; i<this._tablePTCT.Columns.Count; i++) {
                      // Log only first few columns to avoid spam
                      if (i < 5 || this.IsColumnHasData(this._tablePTCT, i))
                          debugLines.Add(this._tablePTCT.Columns[i].ColumnName + ": " + this._tablePTCT.Rows[0][i].ToString());
                  }
              }
          } else {
              debugLines.Add("_tablePTCT is NULL");
          }
          File.WriteAllLines(debugPath, debugLines.ToArray());
      } catch (Exception ex) { Console.WriteLine("Debug log failed: " + ex.Message); }

      this.WriteDetailInvoice_02(this.lstParam_02, this._tablePTCT, this.dataTableNameMaterial, this.dataTableSumMaterial);
      try
      {
          this.Invoke(new Action(() => {
              this.numberOfCopies_CT = (int)this.spin_numberOfCopies_02.Value;
          }));
          
          string pictPath1 = ConfigManager.TramTronConfig.PICTPath;
          string path2 = "";
          string pictPath2 = ConfigManager.TramTronConfig.PICTPath;
          if (pictPath2 != string.Empty)
            path2 = Path.GetFileName(pictPath2);
          string str = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
          if (!File.Exists(str))
            return;
          try
          {
            if (!this.PrinterInvokeWord(str, this.numberOfCopies_CT, ConfigManager.TramTronConfig.MayInPICT))
              return;
          }
          catch (System.Exception ex)
          {
            Console.WriteLine("Lỗi khi xóa tệp tin Word: " + ex.Message);
            TramTronLogger.WriteInfo(ex.ToString());
          }
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      finally
      {
          this.Invoke(new Action(() => {
              this.btnInPCT.Enabled = true;
          }));
      }
    }

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
        row2["KLTungMe"] = (object) "Khối lượng";
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
      {
        switch (index)
        {
          case 0:
            if (this.head_Agg1 != null)
            {
              nameMaterialSumCol.Add(strArray1[index]);
              break;
            }
            break;
          case 1:
            if (this.head_Agg2 != null)
            {
              nameMaterialSumCol.Add(strArray1[index]);
              break;
            }
            break;
          case 2:
            if (this.head_Agg3 != null)
            {
              nameMaterialSumCol.Add(strArray1[index]);
              break;
            }
            break;
          case 3:
            if (this.head_Agg4 != null)
            {
              nameMaterialSumCol.Add(strArray1[index]);
              break;
            }
            break;
          case 4:
            if (this.head_Agg5 != null)
            {
              nameMaterialSumCol.Add(strArray1[index]);
              break;
            }
            break;
          case 5:
            if (this.head_Agg6 != null)
            {
              nameMaterialSumCol.Add(strArray1[index]);
              break;
            }
            break;
        }
      }
      for (int index = 0; index < this.num_silo_Ce; ++index)
      {
        switch (index)
        {
          case 0:
            if (this.head_Ce1 != null)
            {
              nameMaterialSumCol.Add(strArray2[index]);
              break;
            }
            break;
          case 1:
            if (this.head_Ce2 != null)
            {
              nameMaterialSumCol.Add(strArray2[index]);
              break;
            }
            break;
          case 2:
            if (this.head_Ce3 != null)
            {
              nameMaterialSumCol.Add(strArray2[index]);
              break;
            }
            break;
          case 3:
            if (this.head_Ce4 != null)
            {
              nameMaterialSumCol.Add(strArray2[index]);
              break;
            }
            break;
          case 4:
            if (this.head_Ce5 != null)
            {
              nameMaterialSumCol.Add(strArray2[index]);
              break;
            }
            break;
        }
      }
      for (int index = 0; index < this.num_silo_Wa; ++index)
      {
        switch (index)
        {
          case 0:
            if (this.head_Wa1 != null)
            {
              nameMaterialSumCol.Add(strArray3[index]);
              break;
            }
            break;
          case 1:
            if (this.head_Wa2 != null)
            {
              nameMaterialSumCol.Add(strArray3[index]);
              break;
            }
            break;
        }
      }
      for (int index = 0; index < 4; ++index)
      {
        switch (index)
        {
          case 0:
            if (this.head_Add1 != null)
            {
              nameMaterialSumCol.Add(strArray4[index]);
              break;
            }
            break;
          case 1:
            if (this.head_Add2 != null)
            {
              nameMaterialSumCol.Add(strArray4[index]);
              break;
            }
            break;
          case 2:
            if (this.head_Add3 != null)
            {
              nameMaterialSumCol.Add(strArray4[index]);
              break;
            }
            break;
          case 3:
            if (this.head_Add4 != null)
            {
              nameMaterialSumCol.Add(strArray4[index]);
              break;
            }
            break;
          case 4:
            if (this.head_Add5 != null)
            {
              nameMaterialSumCol.Add(strArray4[index]);
              break;
            }
            break;
          case 5:
            if (this.head_Add6 != null)
            {
              nameMaterialSumCol.Add(strArray4[index]);
              break;
            }
            break;
        }
      }
      return nameMaterialSumCol;
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
      {
        switch (index)
        {
          case 0:
            if (this.head_Agg1 != null)
            {
              sumMaterial.Add(strArray1[index]);
              break;
            }
            break;
          case 1:
            if (this.head_Agg2 != null)
            {
              sumMaterial.Add(strArray1[index]);
              break;
            }
            break;
          case 2:
            if (this.head_Agg3 != null)
            {
              sumMaterial.Add(strArray1[index]);
              break;
            }
            break;
          case 3:
            if (this.head_Agg4 != null)
            {
              sumMaterial.Add(strArray1[index]);
              break;
            }
            break;
          case 4:
            if (this.head_Agg5 != null)
            {
              sumMaterial.Add(strArray1[index]);
              break;
            }
            break;
          case 5:
            if (this.head_Agg6 != null)
            {
              sumMaterial.Add(strArray1[index]);
              break;
            }
            break;
        }
      }
      for (int index = 0; index < this.num_silo_Ce; ++index)
      {
        switch (index)
        {
          case 0:
            if (this.head_Ce1 != null)
            {
              sumMaterial.Add(strArray2[index]);
              break;
            }
            break;
          case 1:
            if (this.head_Ce2 != null)
            {
              sumMaterial.Add(strArray2[index]);
              break;
            }
            break;
          case 2:
            if (this.head_Ce3 != null)
            {
              sumMaterial.Add(strArray2[index]);
              break;
            }
            break;
          case 3:
            if (this.head_Ce4 != null)
            {
              sumMaterial.Add(strArray2[index]);
              break;
            }
            break;
          case 4:
            if (this.head_Ce5 != null)
            {
              sumMaterial.Add(strArray2[index]);
              break;
            }
            break;
        }
      }
      for (int index = 0; index < this.num_silo_Wa; ++index)
      {
        switch (index)
        {
          case 0:
            if (this.head_Wa1 != null)
            {
              sumMaterial.Add(strArray3[index]);
              break;
            }
            break;
          case 1:
            if (this.head_Wa2 != null)
            {
              sumMaterial.Add(strArray3[index]);
              break;
            }
            break;
        }
      }
      for (int index = 0; index < 4; ++index)
      {
        switch (index)
        {
          case 0:
            if (this.head_Add1 != null)
            {
              sumMaterial.Add(strArray4[index]);
              break;
            }
            break;
          case 1:
            if (this.head_Add2 != null)
            {
              sumMaterial.Add(strArray4[index]);
              break;
            }
            break;
          case 2:
            if (this.head_Add3 != null)
            {
              sumMaterial.Add(strArray4[index]);
              break;
            }
            break;
          case 3:
            if (this.head_Add4 != null)
            {
              sumMaterial.Add(strArray4[index]);
              break;
            }
            break;
          case 4:
            if (this.head_Add5 != null)
            {
              sumMaterial.Add(strArray4[index]);
              break;
            }
            break;
          case 5:
            if (this.head_Add6 != null)
            {
              sumMaterial.Add(strArray4[index]);
              break;
            }
            break;
        }
      }
      return sumMaterial;
    }

    private void WriteDetailInvoice_02(
      List<string> param,
      System.Data.DataTable dataTable1,
      System.Data.DataTable dataTable2,
      System.Data.DataTable dataTable3)
    {
      Microsoft.Office.Interop.Word.Application instance = null;
      try
      {
        if (!this.CopyTempFile_02() || this._error)
          return;
        string pictPath1 = ConfigManager.TramTronConfig.PICTPath;
        string path2 = "";
        string pictPath2 = ConfigManager.TramTronConfig.PICTPath;
        if (pictPath2 != string.Empty)
          path2 = Path.GetFileName(pictPath2);
        string str = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
        // ISSUE: variable of a compiler-generated type
        instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
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
        Document doc = documents.Open(ref local1, ref local2, ref local3, ref local4, ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16);
        for (int index = 0; index < param.Count; ++index)
        {
          string searchText = "{" + index.ToString() + "}";
          this.ReplaceText(instance, searchText, param[index]);
        }
        if (dataTable1 != null)
          this.CreateTablePICT(doc, dataTable1, dataTable2, dataTable3);
        // ISSUE: variable of a compiler-generated type
        Document activeDocument = instance.ActiveDocument;
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
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
      finally
      {
          if (instance != null)
          {
            object missing19 = Type.Missing;
            ref object local33 = ref missing19;
            object missing18 = Type.Missing;
            ref object local34 = ref missing18;
            object missing17 = Type.Missing;
            ref object local35 = ref missing17;
            // ISSUE: reference to a compiler-generated method
            instance.Quit(ref local33, ref local34, ref local35);
          }
      }
    }

    private void CreateTablePICT(
      Document doc,
      System.Data.DataTable dataTable1,
      System.Data.DataTable dataTable2,
      System.Data.DataTable dataTable3)
    {
      // 1. Build List of Columns to Export
      // Requirements:
      // - Standard Columns: "LnNo", "KLTungMe"
      // - Materials: "PV_..." (Exclude "PVM_" Manual)
      // - Filter: HasData OR IsTemperature (Always Show Temp)
      
      List<string> columnsToExport = new List<string>();
      List<string> headersToExport = new List<string>();

      // Helpers
      void AddCol(string colName, string headerName, bool isTemp = false)
      {
          if (!dataTable1.Columns.Contains(colName)) return;
          int colIndex = dataTable1.Columns.IndexOf(colName);
          
          bool hasData = this.IsColumnHasData(dataTable1, colIndex);
          // Force include temperature columns (even if value is 0)
          // Also include any column with data
          if (hasData || isTemp)
          {
              columnsToExport.Add(colName);
              headersToExport.Add(string.IsNullOrEmpty(headerName) ? colName : headerName);
          }
      }

      // Standard Columns
      if (dataTable1.Columns.Contains("LnNo")) { columnsToExport.Add("LnNo"); headersToExport.Add("LnNo"); }
      if (dataTable1.Columns.Contains("KLTungMe")) { columnsToExport.Add("KLTungMe"); headersToExport.Add("Khối lượng"); }

      // Agg
      AddCol("PV_Agg1", this.head_Agg1);
      AddCol("PV_Agg2", this.head_Agg2);
      AddCol("PV_Agg3", this.head_Agg3);
      AddCol("PV_Agg4", this.head_Agg4);
      AddCol("PV_Agg5", this.head_Agg5);
      AddCol("PV_Agg6", this.head_Agg6);

      // Ce
      AddCol("PV_Ce1", this.head_Ce1);
      AddCol("PV_Ce2", this.head_Ce2);
      AddCol("PV_Ce3", this.head_Ce3);
      AddCol("PV_Ce4", this.head_Ce4);
      AddCol("PV_Ce5", this.head_Ce5);

      // Wa
      AddCol("PV_Wa1", this.head_Wa1);
      AddCol("PV_Wa2", this.head_Wa2);

      // Add (Check for Temperature in Header Name)
      bool IsTemp(string name) => !string.IsNullOrEmpty(name) && (name.ToLower().Contains("nhiệt") || name.ToLower().Contains("temp"));
      
      AddCol("PV_Add1", this.head_Add1, IsTemp(this.head_Add1));
      AddCol("PV_Add2", this.head_Add2, IsTemp(this.head_Add2));
      AddCol("PV_Add3", this.head_Add3, IsTemp(this.head_Add3));
      AddCol("PV_Add4", this.head_Add4, IsTemp(this.head_Add4));
      AddCol("PV_Add5", this.head_Add5, IsTemp(this.head_Add5));
      AddCol("PV_Add6", this.head_Add6, IsTemp(this.head_Add6));

      // 2. Setup Word Table
      int colCount = columnsToExport.Count;
      if (colCount == 0 || doc.Tables.Count < 2) return;

      Microsoft.Office.Interop.Word.Table table = doc.Tables[2];
      
      // Reset Table Structure (Assuming 4 rows template? Or verify row count?)
      // Original code split cells. Simpler to just assume Table 2 exists and we are formatting it.
      // We need to ensure we have enough columns. 
      // NOTE: Original code used Split to create columns. We will try to rely on existing table or Split carefully.
      // To attempt to match original behavior of creating columns:
      
      // Row 1..4 Split
      for (int r = 1; r <= 4; r++)
      {
          // ISSUE: reference to a compiler-generated method
          Cell cell = table.Cell(r, 1);
          object obj1 = (object)1;
          object objCols = (object)colCount;
          cell.Split(ref obj1, ref objCols);
      }

      table.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitFixed);
      table.Range.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
      table.Range.Font.Size = 9f;
      table.Range.Font.Name = "Times New Roman";
      object prop = (object)"Table Grid";
      table.set_Style(ref prop);

      // 3. Write Headers (Row 1)
      for (int i = 0; i < colCount; i++)
      {
          table.Cell(1, i + 1).Range.Text = headersToExport[i];
          table.Cell(1, i + 1).Range.Bold = 1;
      }

      // Find header rows in dataTable1
      DataRow headerRow1 = null; // "KL 1 Tấn"
      DataRow headerRow2 = null; // "Khối lượng"
      foreach (DataRow row in dataTable1.Rows)
      {
          string lnNoValue = row["LnNo"]?.ToString() ?? "";
          if (lnNoValue == "KL 1 Tấn") headerRow1 = row;
          else if (lnNoValue == "Khối lượng") headerRow2 = row;
      }

      // 4. Write Header Data Rows (Rows 2-3)
      for (int i = 0; i < colCount; i++)
      {
          string colName = columnsToExport[i];
          
          // Row 2: KL 1 Tấn data
          if (headerRow1 != null)
          {
              table.Cell(2, i + 1).Range.Text = headerRow1[colName]?.ToString() ?? "";
              table.Cell(2, i + 1).Range.Bold = 1;
          }
          else if (colName == "LnNo")
          {
              table.Cell(2, i + 1).Range.Text = "KL 1 Tấn";
              table.Cell(2, i + 1).Range.Bold = 1;
          }
          
          // Row 3: Khối lượng data
          if (headerRow2 != null)
          {
              table.Cell(3, i + 1).Range.Text = headerRow2[colName]?.ToString() ?? "";
              table.Cell(3, i + 1).Range.Bold = 1;
          }
          else if (colName == "LnNo")
          {
              table.Cell(3, i + 1).Range.Text = "Khối lượng";
              table.Cell(3, i + 1).Range.Bold = 1;
          }
      }

      // 5. Row 4: "CHI TIẾT MẺ TRỘN" header
      object missing = Type.Missing;
      table.Rows.Add(ref missing);
      try {
        table.Rows[4].Cells[1].Merge(table.Rows[4].Cells[colCount]);
        table.Cell(4, 1).Range.Text = "CHI TIẾT MẺ TRỘN (DETAIL)";
        table.Cell(4, 1).Range.Bold = 1;
        table.Cell(4, 1).VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
      } catch {}

      // 6. Write Actual Data Rows (Skip header rows)
      int currentRow = 5;
      foreach (DataRow row in dataTable1.Rows)
      {
          string lnNoValue = row["LnNo"]?.ToString() ?? "";
          // Skip header rows - they are already written in rows 2-3
          if (lnNoValue == "KL 1 Tấn" || lnNoValue == "Khối lượng")
              continue;

          table.Rows.Add(ref missing);
          for (int i = 0; i < colCount; i++)
          {
              string colName = columnsToExport[i];
              table.Cell(currentRow, i + 1).Range.Text = row[colName]?.ToString() ?? "";
          }
          currentRow++;
      }

      // 7. Write Totals (Exclude header rows: KL 1 Tấn, Khối lượng)
      table.Rows.Add(ref missing);
      table.Cell(currentRow, 1).Range.Text = "Tổng";
      table.Cell(currentRow, 1).Range.Bold = 1;

      // Filter to exclude header rows from calculation
      string filterExpr = "LnNo <> 'KL 1 Tấn' AND LnNo <> 'Khối lượng'";

      for (int i = 0; i < colCount; i++)
      {
          string colName = columnsToExport[i];
          string headerName = headersToExport[i];
          
          // Skip LnNo and KLTungMe for Sums/Averages
          if (colName != "LnNo" && colName != "KLTungMe")
          {
              // Check if this is a temperature column (use AVERAGE instead of SUM)
              // Temperature columns: detected by header containing "nhiệt"/"temp" OR column name pattern PV_Add2-6
              bool isTemperatureByHeader = !string.IsNullOrEmpty(headerName) && 
                                   (headerName.ToLower().Contains("nhiệt") || headerName.ToLower().Contains("temp"));
              bool isTemperatureByColName = colName.StartsWith("PV_Add") && colName != "PV_Add1"; // Add2-6 are temperature
              bool isTemperature = isTemperatureByHeader || isTemperatureByColName;
              
              string computeFunction = isTemperature ? "AVG" : "SUM";
              
              try
              {
                  object result = dataTable1.Compute(computeFunction + "([" + colName + "])", filterExpr);
                  
                  if (result != DBNull.Value && result != null)
                  {
                       table.Cell(currentRow, i + 1).Range.Text = Convert.ToDouble(result).ToString("0.00");
                       table.Cell(currentRow, i + 1).Range.Bold = 1;
                  }
              }
              catch { /* Skip if column name has special characters */ }
          }
      }
      
      table.Rows[5].Alignment = WdRowAlignment.wdAlignRowLeft;
    }

    private void bttExportFile_Word_GH_Click(object sender, EventArgs e)
    {
      if (this.grvPhieuTron == null || this.grvPhieuTron.SelectedRowsCount == 0)
        return;
      this.ExportFileWord_GH();
    }

    private void ExportFileWord_GH()
    {
      this.GetParam();
      this.WriteDetailInvoice(this.lstParam, null, null, null);
      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Word File (*.docx)|*.docx";
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        string destFileName = Path.Combine(this.folderDesPhieuPath, saveFileDialog.FileName);
        if (this.filePathMau != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau);
        string str = Path.Combine(this.folderDesPhieuPath, this.fileName);
        File.Copy(str, destFileName, true);
        File.Delete(str);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
        // ISSUE: variable of a compiler-generated type
        Documents documents = instance.Documents;
        object obj1 = (object) destFileName;
        ref object local1 = ref obj1;
        object missing1 = Type.Missing;
        ref object local2 = ref missing1;
        object missing2 = Type.Missing;
        ref object local3 = ref missing2;
        object obj2 = Type.Missing;
        ref object local4 = ref obj2;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: variable of a compiler-generated type
        Document o = documents.Add(ref local1, ref local2, ref local3, ref local4);
        obj2 = (object) destFileName;
        ref object local5 = ref obj2;
        object missing3 = Type.Missing;
        ref object local6 = ref missing3;
        object missing4 = Type.Missing;
        ref object local7 = ref missing4;
        object missing5 = Type.Missing;
        ref object local8 = ref missing5;
        object missing6 = Type.Missing;
        ref object local9 = ref missing6;
        object missing7 = Type.Missing;
        ref object local10 = ref missing7;
        object missing8 = Type.Missing;
        ref object local11 = ref missing8;
        object missing9 = Type.Missing;
        ref object local12 = ref missing9;
        object missing10 = Type.Missing;
        ref object local13 = ref missing10;
        object missing11 = Type.Missing;
        ref object local14 = ref missing11;
        object missing12 = Type.Missing;
        ref object local15 = ref missing12;
        object missing13 = Type.Missing;
        ref object local16 = ref missing13;
        object missing14 = Type.Missing;
        ref object local17 = ref missing14;
        object missing15 = Type.Missing;
        ref object local18 = ref missing15;
        object missing16 = Type.Missing;
        ref object local19 = ref missing16;
        object obj3 = Type.Missing;
        ref object local20 = ref obj3;
        // ISSUE: reference to a compiler-generated method
        o.SaveAs(ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16, ref local17, ref local18, ref local19, ref local20);
        obj3 = (object) false;
        ref object local21 = ref obj3;
        missing16 = Type.Missing;
        ref object local22 = ref missing16;
        missing15 = Type.Missing;
        ref object local23 = ref missing15;
        // ISSUE: reference to a compiler-generated method
        o.Close(ref local21, ref local22, ref local23);
        Marshal.ReleaseComObject((object) o);
        missing15 = Type.Missing;
        ref object local24 = ref missing15;
        missing16 = Type.Missing;
        ref object local25 = ref missing16;
        obj3 = Type.Missing;
        ref object local26 = ref obj3;
        // ISSUE: reference to a compiler-generated method
        instance.Quit(ref local24, ref local25, ref local26);
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void ExportFileExcel_GH()
    {
      this.GetParam();
      this.WriteDetailInvoice(this.lstParam, null, null, null);
      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Excel File (*.xlsx)|*.xlsx";
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        string excelFile = Path.Combine(this.folderDesPhieuPath, saveFileDialog.FileName);
        if (this.filePathMau != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau);
        string str = Path.Combine(this.folderDesPhieuPath, this.fileName);
        Support.ReadTableFromWordAndWriteToExcel(str, excelFile);
        File.Delete(str);
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void bttExportFile_PDF_GH_Click(object sender, EventArgs e)
    {
      Support.CloseWordApplications();
      this.DeleteFileGH();
      this.ExportFilePDF();
    }

    private void ExportFilePDF()
    {
      this.GetParam();
      this.WriteDetailInvoice(this.lstParam, null, null, null);
      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        string str1 = Path.ChangeExtension(saveFileDialog.FileName, ".docx");
        string str2 = Path.Combine(this.folderDesPhieuPath, str1);
        if (this.filePathMau != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau);
        string sourceFileName = Path.Combine(this.folderDesPhieuPath, this.fileName);
        File.Copy(sourceFileName, str2, true);
        string str3 = Path.ChangeExtension(str2, ".pdf");
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
        // ISSUE: variable of a compiler-generated type
        Documents documents = instance.Documents;
        object obj1 = (object) sourceFileName;
        ref object local1 = ref obj1;
        object missing1 = Type.Missing;
        ref object local2 = ref missing1;
        object missing2 = Type.Missing;
        ref object local3 = ref missing2;
        object missing3 = Type.Missing;
        ref object local4 = ref missing3;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: variable of a compiler-generated type
        Document o = documents.Add(ref local1, ref local2, ref local3, ref local4);
        object obj2 = (object) str2;
        ref object local5 = ref obj2;
        missing2 = Type.Missing;
        ref object local6 = ref missing2;
        object missing4 = Type.Missing;
        ref object local7 = ref missing4;
        object missing5 = Type.Missing;
        ref object local8 = ref missing5;
        object missing6 = Type.Missing;
        ref object local9 = ref missing6;
        object missing7 = Type.Missing;
        ref object local10 = ref missing7;
        object missing8 = Type.Missing;
        ref object local11 = ref missing8;
        object missing9 = Type.Missing;
        ref object local12 = ref missing9;
        object missing10 = Type.Missing;
        ref object local13 = ref missing10;
        object missing11 = Type.Missing;
        ref object local14 = ref missing11;
        object missing12 = Type.Missing;
        ref object local15 = ref missing12;
        object missing13 = Type.Missing;
        ref object local16 = ref missing13;
        object missing14 = Type.Missing;
        ref object local17 = ref missing14;
        object missing15 = Type.Missing;
        ref object local18 = ref missing15;
        object missing16 = Type.Missing;
        ref object local19 = ref missing16;
        object obj3 = Type.Missing;
        ref object local20 = ref obj3;
        // ISSUE: reference to a compiler-generated method
        o.SaveAs(ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16, ref local17, ref local18, ref local19, ref local20);
        // ISSUE: variable of a compiler-generated type
        Document activeDocument = instance.ActiveDocument;
        string OutputFileName = str3;
        obj3 = Type.Missing;
        ref object local21 = ref obj3;
        // ISSUE: reference to a compiler-generated method
        activeDocument.ExportAsFixedFormat(OutputFileName, WdExportFormat.wdExportFormatPDF, FixedFormatExtClassPtr: ref local21);
        obj3 = (object) false;
        ref object local22 = ref obj3;
        missing16 = Type.Missing;
        ref object local23 = ref missing16;
        missing15 = Type.Missing;
        ref object local24 = ref missing15;
        // ISSUE: reference to a compiler-generated method
        o.Close(ref local22, ref local23, ref local24);
        Marshal.ReleaseComObject((object) o);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application application = instance;
        object missing17 = Type.Missing;
        ref object local25 = ref missing17;
        object missing18 = Type.Missing;
        ref object local26 = ref missing18;
        object missing19 = Type.Missing;
        ref object local27 = ref missing19;
        // ISSUE: reference to a compiler-generated method
        application.Quit(ref local25, ref local26, ref local27);
        Marshal.ReleaseComObject((object) o);
        if (!File.Exists(str1))
          return;
        File.Delete(str1);
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void CreateFilePDF_CT()
    {
      string path2 = "";
      string pictPath = ConfigManager.TramTronConfig.PICTPath;
      if (pictPath != string.Empty)
        path2 = Path.GetFileName(pictPath);
      string path = Path.Combine(ConfigManager.TramTronConfig.ReportPath, path2);
      string str = Path.ChangeExtension(path, ".pdf");
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
      object obj2 = Type.Missing;
      ref object local4 = ref obj2;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: variable of a compiler-generated type
      Document o = documents.Add(ref local1, ref local2, ref local3, ref local4);
      // ISSUE: variable of a compiler-generated type
      Document activeDocument = instance.ActiveDocument;
      string OutputFileName = str;
      obj2 = Type.Missing;
      ref object local5 = ref obj2;
      // ISSUE: reference to a compiler-generated method
      activeDocument.ExportAsFixedFormat(OutputFileName, WdExportFormat.wdExportFormatPDF, FixedFormatExtClassPtr: ref local5);
      obj2 = (object) false;
      ref object local6 = ref obj2;
      object missing3 = Type.Missing;
      ref object local7 = ref missing3;
      object missing4 = Type.Missing;
      ref object local8 = ref missing4;
      // ISSUE: reference to a compiler-generated method
      o.Close(ref local6, ref local7, ref local8);
      Marshal.ReleaseComObject((object) o);
      File.Delete(path);
    }

    private void bttExportFile_Word_CT_Click(object sender, EventArgs e)
    {
      Support.CloseWordApplications();
      this.DeleteFileCTMT();
      this.dataTableNameMaterial = this.CreateTableNameMaterial(this._tablePTCT);
      this.dataTableSumMaterial = this.CreateTableSumMaterial(this._tablePTCT);
      this.GetParam_02();
      this.WriteDetailInvoice_02(this.lstParam_02, this._tablePTCT, this.dataTableNameMaterial, this.dataTableSumMaterial);
      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Word File (*.docx)|*.docx";
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        string destFileName = Path.Combine(this.folderDesPhieuPath, saveFileDialog.FileName);
        if (this.filePathMau_CT != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau_CT);
        string str = Path.Combine(this.folderDesPhieuPath, this.fileName);
        File.Copy(str, destFileName, true);
        File.Delete(str);
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
        // ISSUE: reference to a compiler-generated method
        // ISSUE: variable of a compiler-generated type
        Document o = documents.Add(ref local1, ref local2, ref local3, ref local4);
        object obj2 = (object) destFileName;
        ref object local5 = ref obj2;
        object missing4 = Type.Missing;
        ref object local6 = ref missing4;
        object missing5 = Type.Missing;
        ref object local7 = ref missing5;
        object missing6 = Type.Missing;
        ref object local8 = ref missing6;
        object missing7 = Type.Missing;
        ref object local9 = ref missing7;
        object missing8 = Type.Missing;
        ref object local10 = ref missing8;
        object missing9 = Type.Missing;
        ref object local11 = ref missing9;
        object missing10 = Type.Missing;
        ref object local12 = ref missing10;
        object missing11 = Type.Missing;
        ref object local13 = ref missing11;
        object missing12 = Type.Missing;
        ref object local14 = ref missing12;
        object missing13 = Type.Missing;
        ref object local15 = ref missing13;
        object missing14 = Type.Missing;
        ref object local16 = ref missing14;
        object missing15 = Type.Missing;
        ref object local17 = ref missing15;
        object missing16 = Type.Missing;
        ref object local18 = ref missing16;
        object missing17 = Type.Missing;
        ref object local19 = ref missing17;
        object missing18 = Type.Missing;
        ref object local20 = ref missing18;
        // ISSUE: reference to a compiler-generated method
        o.SaveAs(ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16, ref local17, ref local18, ref local19, ref local20);
        object obj3 = (object) false;
        ref object local21 = ref obj3;
        object missing19 = Type.Missing;
        ref object local22 = ref missing19;
        object missing20 = Type.Missing;
        ref object local23 = ref missing20;
        // ISSUE: reference to a compiler-generated method
        o.Close(ref local21, ref local22, ref local23);
        Marshal.ReleaseComObject((object) o);
        missing20 = Type.Missing;
        ref object local24 = ref missing20;
        missing19 = Type.Missing;
        ref object local25 = ref missing19;
        obj3 = Type.Missing;
        ref object local26 = ref obj3;
        // ISSUE: reference to a compiler-generated method
        instance.Quit(ref local24, ref local25, ref local26);
      }
      catch (System.Exception ex)
      {
      }
    }

    private void bttExportFile_PDF_CT_Click(object sender, EventArgs e)
    {
      Support.CloseWordApplications();
      this.DeleteFileCTMT();
      this.dataTableNameMaterial = this.CreateTableNameMaterial(this._tablePTCT);
      this.dataTableSumMaterial = this.CreateTableSumMaterial(this._tablePTCT);
      this.GetParam_02();
      this.WriteDetailInvoice_02(this.lstParam_02, this._tablePTCT, this.dataTableNameMaterial, this.dataTableSumMaterial);
      try
      {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
        if (saveFileDialog.ShowDialog() != DialogResult.OK)
          return;
        string str1 = Path.ChangeExtension(saveFileDialog.FileName, ".docx");
        string str2 = Path.Combine(this.folderDesPhieuPath, str1);
        if (this.filePathMau_CT != string.Empty)
          this.fileName = Path.GetFileName(this.filePathMau_CT);
        string sourceFileName = Path.Combine(this.folderDesPhieuPath, this.fileName);
        File.Copy(sourceFileName, str2, true);
        string str3 = Path.ChangeExtension(str2, ".pdf");
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application) Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
        // ISSUE: variable of a compiler-generated type
        Documents documents = instance.Documents;
        object obj1 = (object) sourceFileName;
        ref object local1 = ref obj1;
        object missing1 = Type.Missing;
        ref object local2 = ref missing1;
        object missing2 = Type.Missing;
        ref object local3 = ref missing2;
        object missing3 = Type.Missing;
        ref object local4 = ref missing3;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: variable of a compiler-generated type
        Document o = documents.Add(ref local1, ref local2, ref local3, ref local4);
        object obj2 = (object) str2;
        ref object local5 = ref obj2;
        object missing4 = Type.Missing;
        ref object local6 = ref missing4;
        object missing5 = Type.Missing;
        ref object local7 = ref missing5;
        object missing6 = Type.Missing;
        ref object local8 = ref missing6;
        object missing7 = Type.Missing;
        ref object local9 = ref missing7;
        object missing8 = Type.Missing;
        ref object local10 = ref missing8;
        object missing9 = Type.Missing;
        ref object local11 = ref missing9;
        object missing10 = Type.Missing;
        ref object local12 = ref missing10;
        object missing11 = Type.Missing;
        ref object local13 = ref missing11;
        object missing12 = Type.Missing;
        ref object local14 = ref missing12;
        object missing13 = Type.Missing;
        ref object local15 = ref missing13;
        object missing14 = Type.Missing;
        ref object local16 = ref missing14;
        object missing15 = Type.Missing;
        ref object local17 = ref missing15;
        object missing16 = Type.Missing;
        ref object local18 = ref missing16;
        object missing17 = Type.Missing;
        ref object local19 = ref missing17;
        object missing18 = Type.Missing;
        ref object local20 = ref missing18;
        // ISSUE: reference to a compiler-generated method
        o.SaveAs(ref local5, ref local6, ref local7, ref local8, ref local9, ref local10, ref local11, ref local12, ref local13, ref local14, ref local15, ref local16, ref local17, ref local18, ref local19, ref local20);
        // ISSUE: variable of a compiler-generated type
        Document activeDocument = instance.ActiveDocument;
        string OutputFileName = str3;
        object obj3 = Type.Missing;
        ref object local21 = ref obj3;
        // ISSUE: reference to a compiler-generated method
        activeDocument.ExportAsFixedFormat(OutputFileName, WdExportFormat.wdExportFormatPDF, FixedFormatExtClassPtr: ref local21);
        obj3 = (object) false;
        ref object local22 = ref obj3;
        missing17 = Type.Missing;
        ref object local23 = ref missing17;
        missing16 = Type.Missing;
        ref object local24 = ref missing16;
        // ISSUE: reference to a compiler-generated method
        o.Close(ref local22, ref local23, ref local24);
        Marshal.ReleaseComObject((object) o);
        // ISSUE: variable of a compiler-generated type
        Microsoft.Office.Interop.Word.Application application = instance;
        missing16 = Type.Missing;
        ref object local25 = ref missing16;
        missing17 = Type.Missing;
        ref object local26 = ref missing17;
        obj3 = Type.Missing;
        ref object local27 = ref obj3;
        // ISSUE: reference to a compiler-generated method
        application.Quit(ref local25, ref local26, ref local27);
        Marshal.ReleaseComObject((object) o);
        if (!File.Exists(str1))
          return;
        File.Delete(str1);
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
    }

    private void txtSTTPhieuTron_02_EditValueChanged(object sender, EventArgs e)
    {
    }

    private void txtTenKhachHang_EditValueChanged(object sender, EventArgs e)
    {
    }

    public void HandleShortcutKeys(Keys key, bool shiftPressed)
    {
      if (!shiftPressed)
        ;
    }

    
    private bool IsColumnHasData(System.Data.DataTable table, int colIndex)
    {
        if (table == null || table.Rows.Count == 0) return false;
        foreach (DataRow row in table.Rows)
        {
             double val;
             if (row[colIndex] != DBNull.Value && double.TryParse(row[colIndex].ToString(), out val) && val != 0.0)
             {
                 return true;
             }
        }
        return false;
    }
  }
}

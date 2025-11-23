// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportChiTietKhoiLuongBeTong
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using NhuaNong.ServiceLibrary;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Reports
{
  public partial class ReportChiTietKhoiLuongBeTong : ControlViewBase, ISumWeightMngView, IBase, IPermission
  {
    private ReportChiTietKhoiLuongBeTongDataPresenter _presenter;
    public BindingList<Objvw_SumWeight> _blstSumWeight = new BindingList<Objvw_SumWeight>();
    public BindingList<ObjKhachHang> _blstKH = new BindingList<ObjKhachHang>();
    public BindingList<ObjCongTruong> _blstCT = new BindingList<ObjCongTruong>();
    public BindingList<ObjHangMuc> _blstHM = new BindingList<ObjHangMuc>();
    public BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    public BindingList<ObjXe> _blstXe = new BindingList<ObjXe>();
    public BindingList<ObjTaiXe> _blstTX = new BindingList<ObjTaiXe>();
    public BindingList<ObjNhanVien> _blstNV = new BindingList<ObjNhanVien>();
    

    public BindingList<Objvw_SumWeight> BLstSumWeight
    {
      set
      {
        this._blstSumWeight = value;
        this.grcChiTietKhoiLuongBeTong.DataSource = (object) this._blstSumWeight;
      }
    }

    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set
      {
        this._blstKH = value;
        this.lueKhachHang.Properties.DataSource = (object) this._blstKH;
      }
    }

    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set
      {
        this._blstCT = value;
        this.lueCongTruong.Properties.DataSource = (object) this._blstCT;
      }
    }

    public BindingList<ObjHangMuc> BLstHangMuc
    {
      set
      {
        this._blstHM = value;
        this.lueHangMuc.Properties.DataSource = (object) this._blstHM;
      }
    }

    public BindingList<ObjMAC> BLstMAC
    {
      set
      {
        this._blstMAC = value;
        this.lueMAC.Properties.DataSource = (object) this._blstMAC;
      }
    }

    public BindingList<ObjXe> BLstXe
    {
      set
      {
        this._blstXe = value;
        this.lueBienSo.Properties.DataSource = (object) this._blstXe;
      }
    }

    public BindingList<ObjTaiXe> BLstTaiXe
    {
      set
      {
        this._blstTX = value;
        this.lueTaiXe.Properties.DataSource = (object) this._blstTX;
      }
    }

    public BindingList<ObjNhanVien> BLstNhanVien
    {
      set => this._blstNV = value;
    }

    public ReportChiTietKhoiLuongBeTong()
    {
      this.InitializeComponent();
      this.Name = nameof(ReportChiTietKhoiLuongBeTong);
      this._presenter = new ReportChiTietKhoiLuongBeTongDataPresenter((ISumWeightMngView) this);
      this.Caption = "Chi tiết khối lượng bê tông";
      this._presenter.ListKhachHang();
      this._presenter.ListCongTruong();
      this._presenter.ListHangMuc();
      this._presenter.ListMAC();
      this._presenter.ListXe();
      this._presenter.ListTaiXe();
      this._presenter.ListNhanVien();
      this.lueNhanVien.Properties.DataSource = (object) Converter.ConvertToBindingList<ObjSEC_User>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_User() as List<ObjSEC_User>);
    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(true);
      int slSiloAgg = ConfigManager.TramTronConfig.SL_Silo_AGG;
      int slSiloCe = ConfigManager.TramTronConfig.SL_Silo_CE;
      int slSiloWa = ConfigManager.TramTronConfig.SL_Silo_WA;
      int slSiloAdd = ConfigManager.TramTronConfig.SL_Silo_ADD;
      this.LoadSearchDefaultValues();
    }

    private void LoadDataMix()
    {
      try
      {
        bool? moPhong = new bool?();
        if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
          moPhong = new bool?(false);
        else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
          moPhong = new bool?(true);
        this._blstSumWeight = this._presenter.ListSumWeight_ByCondition_re(new DateTime?(Searching.Build_StartDateTime(this.datFromDate.DateTime)), new DateTime?(Searching.Build_EndDateTime(this.datToDate.DateTime)), this.txtMaPhieuTron.Text, (int?) this.lueKhachHang.EditValue, (int?) this.lueCongTruong.EditValue, (int?) this.lueHangMuc.EditValue, (int?) this.lueMAC.EditValue, (int?) this.lueBienSo.EditValue, (int?) this.lueTaiXe.EditValue, (int?) this.lueNhanVien.EditValue, moPhong);
        this.Invoke((Delegate) (() => this.UpdateUI(this._blstSumWeight)));
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void UpdateUI(BindingList<Objvw_SumWeight> result)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.UpdateUI(result)));
      else
        this.grcChiTietKhoiLuongBeTong.DataSource = (object) result;
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestBaoCaoDays);
      this.datToDate.EditValue = (object) DateTime.Now;
      this.txtMaPhieuTron.Text = string.Empty;
      this.lueKhachHang.EditValue = (object) null;
      this.lueCongTruong.EditValue = (object) null;
      this.lueHangMuc.EditValue = (object) null;
      this.lueMAC.EditValue = (object) null;
      this.lueBienSo.EditValue = (object) null;
      this.lueTaiXe.EditValue = (object) null;
      this.lueNhanVien.EditValue = (object) null;
      this.lueCheDo.EditValue = (object) 2;
    }

    protected override void PopulateData() => Task.Run((Action) (() => this.LoadDataMix()));

    private void btnSearch_Click(object sender, EventArgs e)
    {
      Task.Run((Action) (() => this.LoadDataMix()));
    }

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string title = "BÁO CÁO CHI TIẾT KHỐI LƯỢNG BÊ TÔNG";
        string str1 = string.Format("Từ ngày: {0} - đến ngày: {1}", (object) FormatToString.DateTimeToString(this.datFromDate.DateTime), (object) FormatToString.DateTimeToString(this.datToDate.DateTime));
        string str2 = string.Format("Khách hàng: {0}", (object) this.lueKhachHang.Text);
        string str3 = string.Format("Công trường: {0}", (object) this.lueCongTruong.Text);
        string str4 = string.Format("Hạng mục: {0}", (object) this.lueHangMuc.Text);
        string str5 = string.Format("MAC: {0}", (object) this.lueMAC.Text);
        string str6 = string.Format("Tài xế: {0}", (object) this.lueTaiXe.Text);
        string str7 = string.Format("Biển số: {0}", (object) this.lueBienSo.Text);
        string str8 = string.Format("Nhân viên: {0}", (object) this.lueNhanVien.Text);
        List<string> lstHeader = new List<string>();
        lstHeader.Add(str1);
        if (this.lueKhachHang.EditValue != null)
          lstHeader.Add(str2);
        if (this.lueCongTruong.EditValue != null)
          lstHeader.Add(str3);
        if (this.lueHangMuc.EditValue != null)
          lstHeader.Add(str4);
        if (this.lueMAC.EditValue != null)
          lstHeader.Add(str5);
        if (this.lueTaiXe.EditValue != null)
          lstHeader.Add(str6);
        if (this.lueBienSo.EditValue != null)
          lstHeader.Add(str7);
        if (this.lueNhanVien.EditValue != null)
          lstHeader.Add(str8);
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.grcChiTietKhoiLuongBeTong, true, true, title, lstHeader);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    
  }
}

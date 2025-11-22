// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportChiTietMeTron
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraPrinting;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.MasterData;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Reports
{
  public partial class ReportChiTietMeTron : ControlViewBase, IDataMixMngView, IBase, IPermission
  {
    private DataMixMngDataPresenter _presenter;
    public BindingList<Objvw_DataMix> _blstDataMix = new BindingList<Objvw_DataMix>();
    public BindingList<ObjKhachHang> _blstKH = new BindingList<ObjKhachHang>();
    public BindingList<ObjCongTruong> _blstCT = new BindingList<ObjCongTruong>();
    public BindingList<ObjHangMuc> _blstHM = new BindingList<ObjHangMuc>();
    public BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    public BindingList<ObjSilo> _blstSilo = new BindingList<ObjSilo>();
    public BindingList<ObjXe> _blstXe = new BindingList<ObjXe>();
    public BindingList<ObjTaiXe> _blstTX = new BindingList<ObjTaiXe>();
    public BindingList<ObjNhanVien> _blstNV = new BindingList<ObjNhanVien>();
    public BindingList<ObjSEC_User> _blstUser = new BindingList<ObjSEC_User>();
    private List<FieldCode> _lstDataMixStatus = new List<FieldCode>();
    

    public BindingList<Objvw_DataMix> BLstDataMix
    {
      set => this._blstDataMix = value;
    }

    private void UpdateUI(BindingList<Objvw_DataMix> result)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.UpdateUI(result)));
      else
        this.gridControl1.DataSource = (object) result;
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

    public List<FieldCode> LstDataMixStatus
    {
      set
      {
        this._lstDataMixStatus = value;
        this.ilueDMStatus.DataSource = (object) this._lstDataMixStatus;
        this.iicbStatus.Items.Clear();
        this.iicbStatus.Items.Add(new ImageComboBoxItem(((DisplayAttribute) System.Attribute.GetCustomAttribute((MemberInfo) typeof (Enums.SimMode).GetField(Enums.SimMode.Normal.ToString()), typeof (DisplayAttribute)))?.Name, (object) true, 0));
        this.iicbStatus.Items.Add(new ImageComboBoxItem(((DisplayAttribute) System.Attribute.GetCustomAttribute((MemberInfo) typeof (Enums.SimMode).GetField(Enums.SimMode.Sim.ToString()), typeof (DisplayAttribute)))?.Name, (object) false, 1));
      }
    }

    public BindingList<ObjSilo> BLstSilo
    {
      set => this._blstSilo = value;
    }

    public ReportChiTietMeTron()
    {
      this.InitializeComponent();
      this.Name = nameof(ReportChiTietMeTron);
      this.Caption = "Chi tiết mẻ trộn";
      this._presenter = new DataMixMngDataPresenter((IDataMixMngView) this);
      this._presenter.ListKhachHang();
      this._presenter.ListCongTruong();
      this._presenter.ListHangMuc();
      this._presenter.ListMAC();
      this._presenter.ListSilo();
      this._presenter.ListXe();
      this._presenter.ListTaiXe();
      this._presenter.ListNhanVien();
      this._presenter.ListDataMixStatus();
      this.lueNhanVien.Properties.DataSource = (object) Converter.ConvertToBindingList<ObjSEC_User>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListSEC_User() as List<ObjSEC_User>);

    }

    private void ReportChiTietMeTron_Load(object sender, EventArgs e)
    {

    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(false);
      int numAgg = ConfigManager.TramTronConfig.SL_Silo_AGG;
      if (numAgg == 0)
        numAgg = 1;
      int numCe = ConfigManager.TramTronConfig.SL_Silo_CE;
      if (numCe == 0)
        numCe = 1;
      int numWa = ConfigManager.TramTronConfig.SL_Silo_WA;
      if (numWa == 0)
        numWa = 1;
      int numAdd = ConfigManager.TramTronConfig.SL_Silo_ADD;
      if (numAdd == 0)
        numAdd = 0;
      this.CreateTaableData(numAgg, numCe, numWa, numAdd);
      this.LoadSearchDefaultValues();
    }

    private void CreateTaableData(int numAgg, int numCe, int numWa, int numAdd)
    {
      try
      {
        foreach (ObjSilo objSilo in (Collection<ObjSilo>) this._blstSilo)
        {
          string maSilo = objSilo.MaSilo;
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
                        this.bandedGridView1.Bands["Ce1"].Caption = objSilo.MaterialName;
                        continue;
                      case "Wa1":
                        this.bandedGridView1.Bands["Wa1"].Caption = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '2':
                    switch (maSilo)
                    {
                      case "Ce2":
                        this.bandedGridView1.Bands["Ce2"].Caption = objSilo.MaterialName;
                        continue;
                      case "Wa2":
                        this.bandedGridView1.Bands["Wa2"].Caption = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '3':
                    if (maSilo == "Ce3")
                    {
                      this.bandedGridView1.Bands["Ce3"].Caption = objSilo.MaterialName;
                      continue;
                    }
                    continue;
                  case '4':
                    if (maSilo == "Ce4")
                    {
                      this.bandedGridView1.Bands["Ce4"].Caption = objSilo.MaterialName;
                      continue;
                    }
                    continue;
                  case '5':
                    if (maSilo == "Ce5")
                    {
                      this.bandedGridView1.Bands["Ce5"].Caption = objSilo.MaterialName;
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
                        this.bandedGridView1.Bands["Agg1"].Caption = objSilo.MaterialName;
                        continue;
                      case "Add1":
                        this.bandedGridView1.Bands["Add1"].Caption = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '2':
                    switch (maSilo)
                    {
                      case "Agg2":
                        this.bandedGridView1.Bands["Agg2"].Caption = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '3':
                    switch (maSilo)
                    {
                      case "Agg3":
                        this.bandedGridView1.Bands["Agg3"].Caption = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '4':
                    switch (maSilo)
                    {
                      case "Agg4":
                        this.bandedGridView1.Bands["Agg4"].Caption = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '5':
                    switch (maSilo)
                    {
                      case "Agg5":
                        this.bandedGridView1.Bands["Agg5"].Caption = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '6':
                    switch (maSilo)
                    {
                      case "Agg6":
                        this.bandedGridView1.Bands["Agg6"].Caption = objSilo.MaterialName;
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
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowErrorDialog(ex.ToString());
      }
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
      foreach (GridBand gridBand in gridBandList4)
        gridBand.Visible = false;
      for (int index = 0; index < numAdd; ++index)
        gridBandList4[0].Visible = true;
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
        this._blstDataMix = this._presenter.ListDataMix_ByCondition_re(new DateTime?(Searching.BuildNew_StartDateTime(this.datFromDate.DateTime, this.tseFromTime.TimeSpan)), new TimeSpan?(this.tseFromTime.TimeSpan), new DateTime?(Searching.BuildNew_EndDateTime(this.datToDate.DateTime, this.tseToTime.TimeSpan)), new TimeSpan?(this.tseToTime.TimeSpan), this.txtMaPhieuTron.Text, (int?) this.lueKhachHang.EditValue, (int?) this.lueCongTruong.EditValue, (int?) this.lueHangMuc.EditValue, (int?) this.lueMAC.EditValue, (int?) this.lueBienSo.EditValue, (int?) this.lueTaiXe.EditValue, (int?) this.lueNhanVien.EditValue, moPhong);
        this.Invoke((Delegate) (() => this.UpdateUI(this._blstDataMix)));
      }
      catch (System.Exception ex)
      {
        TramTromMessageBox.ShowMessageDialog(ex.Message);
      }
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestBaoCaoDays);
      this.datToDate.EditValue = (object) DateTime.Now;
      this.tseFromTime.EditValue = (object) TimeSpan.Zero;
      this.tseToTime.EditValue = (object) new TimeSpan(23, 59, 59);
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

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnSearch_Click(object sender, EventArgs e)
    {
      Task.Run((Action) (() => this.LoadDataMix()));
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      try
      {
        string title = "BÁO CÁO CHI TIẾT MẺ TRỘN";
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
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.gridControl1, true, true, title, lstHeader);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    private void bandedGridView1_DataSourceChanged(object sender, EventArgs e)
    {
    }
  }
}

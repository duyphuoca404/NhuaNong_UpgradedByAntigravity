// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportChiTietTaiXe
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
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.KWS;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Reports
{
  public partial class ReportChiTietTaiXe : ControlViewBase
  {
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private BindingList<Objvw_DriverDetailDayWithID> _blstTotalDriver = new BindingList<Objvw_DriverDetailDayWithID>();
    private BindingList<Objvw_DriverDetailDayWithID> _blstDriverDetailDay = new BindingList<Objvw_DriverDetailDayWithID>();
    private BindingList<Objvw_DriverDetailDayWithID> _blstDriverDetailDayID = new BindingList<Objvw_DriverDetailDayWithID>();
    private BindingList<ObjTaiXe> _blstTaiXe = new BindingList<ObjTaiXe>();
    private BindingList<ObjDriverSummary> _blstDriverSummary = new BindingList<ObjDriverSummary>();
    

    public ReportChiTietTaiXe()
    {
      this.InitializeComponent();
      this.Name = nameof(ReportChiTietTaiXe);
      this.Caption = "Chi tiết tài xế";
      this._blstTaiXe = Converter.ConvertToBindingList<ObjTaiXe>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListTaiXe() as List<ObjTaiXe>);
    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(true);
      this.lueTaiXe.Properties.DataSource = (object) this._blstTaiXe;
      this.LoadSearchDefaultValues();
    }

    protected override void PopulateData()
    {
      Task.Run((Action) (() => this.LoadData()));
      Task.Run((Action) (() => this.LoadData_DetailDay()));
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestBaoCaoDays);
      this.datToDate.EditValue = (object) DateTime.Now;
      this.lueTaiXe.EditValue = (object) null;
      this.lueCheDo.EditValue = (object) 2;
    }

    private void LoadData()
    {
      bool? isManual = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        isManual = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        isManual = new bool?(true);
      this._blstTotalDriver = Converter.ConvertToBindingList<Objvw_DriverDetailDayWithID>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListTotalDriver_ByCondition((int?) this.lueTaiXe.EditValue, isManual) as List<Objvw_DriverDetailDayWithID>);
    }

    private void LoadData_DetailDay()
    {
      this._blstDriverDetailDay.Clear();
      this._blstDriverDetailDayID.Clear();
      if (Convert.ToInt32(this.lueCheDo.EditValue) != 1)
        Convert.ToInt32(this.lueCheDo.EditValue);
      for (int index = 1; index <= this._blstTotalDriver.Count; ++index)
      {
        this._blstDriverDetailDay = Converter.ConvertToBindingList<Objvw_DriverDetailDayWithID>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListDriverDetailDay_ByCondition(new DateTime?(), new DateTime?(), new int?(index), new bool?()) as List<Objvw_DriverDetailDayWithID>);
        this._blstDriverDetailDayID.Add(this._blstDriverDetailDay[0]);
      }
      this.FilterData();
      BindingList<ObjDriverSummary> list = new BindingList<ObjDriverSummary>();
      list.Clear();
      list = Converter.ConvertToBindingList<ObjDriverSummary>(this.GroupAndSumDriverDetail(this._blstDriverDetailDayID));
      this.Invoke((Delegate) (() => this.UpdateUI_ID(list)));
    }

    public void FilterData()
    {
      bool? active = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        active = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        active = new bool?(true);
      int? taiXeID = new int?();
      if (Convert.ToInt32(this.lueTaiXe.EditValue) != 0)
        taiXeID = new int?(Convert.ToInt32(this.lueTaiXe.EditValue));
      DateTime startDate = Searching.Build_StartDateTime(this.datFromDate.DateTime.AddDays(-1.0));
      DateTime endDate = Searching.Build_EndDateTime(this.datToDate.DateTime.AddDays(-1.0));
      List<Objvw_DriverDetailDayWithID> list = this._blstDriverDetailDayID.Where<Objvw_DriverDetailDayWithID>((Func<Objvw_DriverDetailDayWithID, bool>) (item =>
      {
        DateTime? ngayMeTron1 = item.NgayMeTron;
        DateTime dateTime1 = startDate;
        if ((ngayMeTron1.HasValue ? (ngayMeTron1.GetValueOrDefault() >= dateTime1 ? 1 : 0) : 0) != 0)
        {
          DateTime? ngayMeTron2 = item.NgayMeTron;
          DateTime dateTime2 = endDate;
          if ((ngayMeTron2.HasValue ? (ngayMeTron2.GetValueOrDefault() <= dateTime2 ? 1 : 0) : 0) != 0)
          {
            if (active.HasValue)
            {
              bool? isManual = item.IsManual;
              bool? nullable = active;
              if (!(isManual.GetValueOrDefault() == nullable.GetValueOrDefault() & isManual.HasValue == nullable.HasValue))
                goto label_7;
            }
            if (!taiXeID.HasValue)
              return true;
            int taiXeId = item.TaiXeID;
            int? nullable1 = taiXeID;
            int valueOrDefault = nullable1.GetValueOrDefault();
            return taiXeId == valueOrDefault & nullable1.HasValue;
          }
        }
label_7:
        return false;
      })).ToList<Objvw_DriverDetailDayWithID>();
      this._blstDriverDetailDayID.Clear();
      foreach (Objvw_DriverDetailDayWithID driverDetailDayWithId in list)
        this._blstDriverDetailDayID.Add(driverDetailDayWithId);
    }

    public List<ObjDriverSummary> GroupAndSumDriverDetail(
      BindingList<Objvw_DriverDetailDayWithID> driverDetailDays)
    {
      return driverDetailDays.GroupBy<Objvw_DriverDetailDayWithID, int>((Func<Objvw_DriverDetailDayWithID, int>) (d => d.TaiXeID)).Select<IGrouping<int, Objvw_DriverDetailDayWithID>, ObjDriverSummary>((Func<IGrouping<int, Objvw_DriverDetailDayWithID>, ObjDriverSummary>) (g => new ObjDriverSummary()
      {
        TaiXeID = g.Key,
        TenTaiXe = g.First<Objvw_DriverDetailDayWithID>().TenTaiXe,
        Total_Tranfer = g.Sum<Objvw_DriverDetailDayWithID>((Func<Objvw_DriverDetailDayWithID, int?>) (x => x.Total_Tranfer)),
        Total_KL = new Decimal?(g.Sum<Objvw_DriverDetailDayWithID>((Func<Objvw_DriverDetailDayWithID, Decimal>) (x => x.Total_KL.Value)))
      })).ToList<ObjDriverSummary>();
    }

    private void UpdateUI(BindingList<Objvw_DriverDetailDayWithID> result)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.UpdateUI(result)));
      else
        this.grcChiTietTaiXe.DataSource = (object) result;
    }

    private void UpdateUI_ID(BindingList<ObjDriverSummary> result)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) (() => this.UpdateUI_ID(result)));
      }
      else
      {
        this.grcChiTietTaiXe.DataSource = (object) null;
        this.grcChiTietTaiXe.DataSource = (object) result;
      }
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      Task.Run((Action) (() => this.LoadData_DetailDay()));
    }

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string title = "BÁO CÁO CHI TIẾT TÀI XẾ";
        string str1 = string.Format("Từ ngày: {0} - đến ngày: {1}", (object) FormatToString.DateTimeToString(this.datFromDate.DateTime), (object) FormatToString.DateTimeToString(this.datToDate.DateTime));
        string str2 = string.Format("Tài xế: {0}", (object) this.lueTaiXe.Text);
        List<string> lstHeader = new List<string>();
        lstHeader.Add(str1);
        if (this.lueTaiXe.EditValue != null)
          lstHeader.Add(str2);
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.grcChiTietTaiXe, true, true, title, lstHeader);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    
  }
}

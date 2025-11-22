// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportTongChuyenXe
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
  public partial class ReportTongChuyenXe : ControlViewBase
  {
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private BindingList<Objvw_TranferDetailDayWithID> _blstTotalTranfer = new BindingList<Objvw_TranferDetailDayWithID>();
    private BindingList<Objvw_TranferDetailDayWithID> _blstTranferDetailDay = new BindingList<Objvw_TranferDetailDayWithID>();
    private BindingList<Objvw_TranferDetailDayWithID> _blstTranferDetailDayID = new BindingList<Objvw_TranferDetailDayWithID>();
    private BindingList<ObjXe> _blstXe = new BindingList<ObjXe>();
    private BindingList<ObjTranferSummary> _blstTranferSummary = new BindingList<ObjTranferSummary>();
    

    public ReportTongChuyenXe()
    {
      this.InitializeComponent();
      this.Name = nameof(ReportTongChuyenXe);
      this.Caption = "Tổng chuyến xe";
      this._blstXe = Converter.ConvertToBindingList<ObjXe>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListXe() as List<ObjXe>);
    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(true);
      this.lueBienSo.Properties.DataSource = (object) this._blstXe;
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
      this.lueBienSo.EditValue = (object) null;
      this.lueCheDo.EditValue = (object) 2;
    }

    private void LoadData()
    {
      bool? isManual = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        isManual = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        isManual = new bool?(true);
      this._blstTotalTranfer = Converter.ConvertToBindingList<Objvw_TranferDetailDayWithID>(this._ser.ListTotalTranfer_ByCondition((int?) this.lueBienSo.EditValue, isManual) as List<Objvw_TranferDetailDayWithID>);
    }

    private void LoadData_DetailDay()
    {
      this._blstTranferDetailDay.Clear();
      this._blstTranferDetailDayID.Clear();
      if (Convert.ToInt32(this.lueCheDo.EditValue) != 1)
        Convert.ToInt32(this.lueCheDo.EditValue);
      for (int index = 1; index <= this._blstTotalTranfer.Count; ++index)
      {
        this._blstTranferDetailDay = Converter.ConvertToBindingList<Objvw_TranferDetailDayWithID>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListTranferDetailDay_ByCondition(new DateTime?(), new DateTime?(), new int?(index), new bool?()) as List<Objvw_TranferDetailDayWithID>);
        this._blstTranferDetailDayID.Add(this._blstTranferDetailDay[0]);
      }
      this.FilterData();
      BindingList<ObjTranferSummary> list = new BindingList<ObjTranferSummary>();
      list.Clear();
      list = Converter.ConvertToBindingList<ObjTranferSummary>(this.GroupAndSumTranferDetail(this._blstTranferDetailDayID));
      this.Invoke((Delegate) (() => this.UpdateUI_ID(list)));
    }

    public void FilterData()
    {
      bool? active = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        active = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        active = new bool?(true);
      int? xeID = new int?();
      if (Convert.ToInt32(this.lueBienSo.EditValue) != 0)
        xeID = new int?(Convert.ToInt32(this.lueBienSo.EditValue));
      DateTime startDate = Searching.Build_StartDateTime(this.datFromDate.DateTime.AddDays(-1.0));
      DateTime endDate = Searching.Build_EndDateTime(this.datToDate.DateTime.AddDays(-1.0));
      List<Objvw_TranferDetailDayWithID> list = this._blstTranferDetailDayID.Where<Objvw_TranferDetailDayWithID>((Func<Objvw_TranferDetailDayWithID, bool>) (item =>
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
              bool? isQueued = item.IsQueued;
              bool? nullable = active;
              if (!(isQueued.GetValueOrDefault() == nullable.GetValueOrDefault() & isQueued.HasValue == nullable.HasValue))
                goto label_7;
            }
            if (!xeID.HasValue)
              return true;
            int xeId = item.XeID;
            int? nullable1 = xeID;
            int valueOrDefault = nullable1.GetValueOrDefault();
            return xeId == valueOrDefault & nullable1.HasValue;
          }
        }
label_7:
        return false;
      })).ToList<Objvw_TranferDetailDayWithID>();
      this._blstTranferDetailDayID.Clear();
      foreach (Objvw_TranferDetailDayWithID tranferDetailDayWithId in list)
        this._blstTranferDetailDayID.Add(tranferDetailDayWithId);
    }

    public List<ObjTranferSummary> GroupAndSumTranferDetail(
      BindingList<Objvw_TranferDetailDayWithID> tranferDetailDays)
    {
      return tranferDetailDays.GroupBy<Objvw_TranferDetailDayWithID, int>((Func<Objvw_TranferDetailDayWithID, int>) (d => d.XeID)).Select<IGrouping<int, Objvw_TranferDetailDayWithID>, ObjTranferSummary>((Func<IGrouping<int, Objvw_TranferDetailDayWithID>, ObjTranferSummary>) (g => new ObjTranferSummary()
      {
        XeID = g.Key,
        BienSo = g.First<Objvw_TranferDetailDayWithID>().BienSo,
        Total_Tranfer = g.Sum<Objvw_TranferDetailDayWithID>((Func<Objvw_TranferDetailDayWithID, int?>) (x => x.Total_Tranfer)),
        Total_KL = new Decimal?(g.Sum<Objvw_TranferDetailDayWithID>((Func<Objvw_TranferDetailDayWithID, Decimal>) (x => x.Total_KL.Value)))
      })).ToList<ObjTranferSummary>();
    }

    private void UpdateUI(BindingList<Objvw_TranferDetailDayWithID> result)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.UpdateUI(result)));
      else
        this.grcTongChuyenXe.DataSource = (object) result;
    }

    private void UpdateUI_ID(BindingList<ObjTranferSummary> result)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) (() => this.UpdateUI_ID(result)));
      }
      else
      {
        this.grcTongChuyenXe.DataSource = (object) null;
        this.grcTongChuyenXe.DataSource = (object) result;
      }
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      Task.Run((Action) (() => this.LoadData_DetailDay()));
    }

    private void simpleButton1_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string title = "BÁO CÁO TỔNG CHUYẾN XE";
        string str1 = string.Format("Từ ngày: {0} - đến ngày: {1}", (object) FormatToString.DateTimeToString(this.datFromDate.DateTime), (object) FormatToString.DateTimeToString(this.datToDate.DateTime));
        string str2 = string.Format("Biển số: {0}", (object) this.lueBienSo.Text);
        List<string> lstHeader = new List<string>();
        lstHeader.Add(str1);
        if (this.lueBienSo.EditValue != null)
          lstHeader.Add(str2);
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.grcTongChuyenXe, true, true, title, lstHeader);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    
  }
}

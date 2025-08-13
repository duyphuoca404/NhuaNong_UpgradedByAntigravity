// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.ReportTongVatTu
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
using NhuaNong.MasterData;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Reports
{
  public class ReportTongVatTu : ControlViewBase, IDataMixMngView, IBase, IPermission
  {
    private DataMixMngDataPresenter _presenter;
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private BindingList<Objvw_MaterialDetailDayWithID> _blstTotalMaterial = new BindingList<Objvw_MaterialDetailDayWithID>();
    private BindingList<ObjMaterial> _blstMaterial = new BindingList<ObjMaterial>();
    private BindingList<Objvw_MaterialDetailDayWithID> _blstMaterialDetailDay = new BindingList<Objvw_MaterialDetailDayWithID>();
    private BindingList<Objvw_MaterialDetailDayWithID> _blstMaterialDetailDayID = new BindingList<Objvw_MaterialDetailDayWithID>();
    private List<Objvw_MaterialDetailDayWithID> filteredList = new List<Objvw_MaterialDetailDayWithID>();
    private BindingList<ObjMaterialSummary> _blstMaterialSummary = new BindingList<ObjMaterialSummary>();
    private BindingList<ObjVatTu> danhSachDuLieu = new BindingList<ObjVatTu>();
    public BindingList<Objvw_DataMix> _blstDataMix = new BindingList<Objvw_DataMix>();
    public BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    public BindingList<ObjSilo> _blstSilo = new BindingList<ObjSilo>();
    private int num_silo_Agg;
    private int num_silo_Ce;
    private int num_silo_Wa;
    private int num_silo_Add;
    private IContainer components;
    private GroupControl groupControl1;
    private GroupControl groupControl2;
    private DateEdit datToDate;
    private DateEdit datFromDate;
    private LabelControl labelControl1;
    private LabelControl lblFromDate;
    private LookUpEdit lueMaterial;
    private LabelControl labelControl3;
    private LabelControl labelControl2;
    private SimpleButton btnTimKiem;
    private SimpleButton simpleButton1;
    private GridControl grcTongVatTu;
    private GridView grvTongVatTu;
    private PanelControl panelControl1;
    private LabelControl labelControl4;
    private PanelControl panelControl2;
    private LookUpEdit lueCheDo;
    private GridColumn gcTenVatTu;
    private GridColumn gcCapPhoi;
    private GridColumn gcThucCan;
    private GridColumn gcSaiSo;
    private GridColumn gcPerSaiSo;
    private GridColumn gcMaVatTu;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private SimpleButton btnExportExcel;
    private GridColumn gcNgayMeTron;

    public BindingList<Objvw_DataMix> BLstDataMix
    {
      set => this._blstDataMix = value;
    }

    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjHangMuc> BLstHangMuc
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjMAC> BLstMAC
    {
      set => this._blstMAC = value;
    }

    public BindingList<ObjSilo> BLstSilo
    {
      set => this._blstSilo = value;
    }

    public BindingList<ObjXe> BLstXe
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjTaiXe> BLstTaiXe
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjNhanVien> BLstNhanVien
    {
      set => throw new NotImplementedException();
    }

    public List<FieldCode> LstDataMixStatus
    {
      set => throw new NotImplementedException();
    }

    public ReportTongVatTu()
    {
      this.InitializeComponent();
      this.Caption = "Tổng vật tư";
      this._presenter = new DataMixMngDataPresenter((IDataMixMngView) this);
      this._presenter.ListSilo();
      this._blstMaterial = Converter.ConvertToBindingList<ObjMaterial>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListMaterial() as List<ObjMaterial>);
    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(true);
      this.lueMaterial.Properties.DataSource = (object) this._blstMaterial;
      this.LoadSearchDefaultValues();
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
      this.num_silo_Add = 1;
    }

    protected override void PopulateData()
    {
      this._blstTotalMaterial = Converter.ConvertToBindingList<Objvw_MaterialDetailDayWithID>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListTotalMaterial_ByCondition(new int?(), new bool?()) as List<Objvw_MaterialDetailDayWithID>);
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) DateTime.Now.AddDays(-(double) ConfigManager.TramTronConfig.LatestBaoCaoDays);
      this.datToDate.EditValue = (object) DateTime.Now;
      this.lueMaterial.EditValue = (object) null;
      this.lueCheDo.EditValue = (object) 2;
    }

    private void LoadData()
    {
      if (Convert.ToInt32(this.lueCheDo.EditValue) != 1)
        Convert.ToInt32(this.lueCheDo.EditValue);
      this._blstTotalMaterial = Converter.ConvertToBindingList<Objvw_MaterialDetailDayWithID>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListTotalMaterial_ByCondition(new int?(), new bool?()) as List<Objvw_MaterialDetailDayWithID>);
    }

    private async void LoadData_DetailDay()
    {
      this._blstMaterialDetailDay.Clear();
      this._blstMaterialDetailDayID.Clear();
      bool? active = GetActiveStatus(Convert.ToInt32(this.lueCheDo.EditValue));
      List<Task<List<Objvw_MaterialDetailDayWithID>>> taskList = new List<Task<List<Objvw_MaterialDetailDayWithID>>>();
      for (int index = 1; index <= this._blstTotalMaterial.Count; ++index)
      {
        int materialId = index;
        taskList.Add(Task.Run<List<Objvw_MaterialDetailDayWithID>>((Func<List<Objvw_MaterialDetailDayWithID>>) (() => ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListMaterialDetailDay_ByCondition(new DateTime?(Searching.Build_StartDateTime(this.datFromDate.DateTime)), new DateTime?(Searching.Build_EndDateTime(this.datToDate.DateTime)), new int?(materialId), active) as List<Objvw_MaterialDetailDayWithID>)));
      }
      foreach (List<Objvw_MaterialDetailDayWithID> materialDetailDayWithIdList in await Task.WhenAll<List<Objvw_MaterialDetailDayWithID>>((IEnumerable<Task<List<Objvw_MaterialDetailDayWithID>>>) taskList))
      {
        if (materialDetailDayWithIdList != null && materialDetailDayWithIdList.Count > 0)
          this._blstMaterialDetailDayID.Add(materialDetailDayWithIdList[0]);
      }
      this.grcTongVatTu.DataSource = (object) Converter.ConvertToBindingList<ObjMaterialSummary>(this.GroupAndSumMaterialDetail(this._blstMaterialDetailDayID));

      static bool? GetActiveStatus(int value)
      {
        if (value == 1)
          return new bool?(false);
        return value == 2 ? new bool?(true) : new bool?();
      }
    }

    public async Task FilterData(
      BindingList<Objvw_MaterialDetailDayWithID> blstMaterialDetailDayID)
    {
      bool? active = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        active = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        active = new bool?(true);
      int? materialID = new int?();
      if (Convert.ToInt32(this.lueMaterial.EditValue) != 0)
        materialID = new int?(Convert.ToInt32(this.lueMaterial.EditValue));
      if (Convert.ToInt32(this.lueCheDo.EditValue) != 1)
        Convert.ToInt32(this.lueCheDo.EditValue);
      DateTime dateTime1 = this.datFromDate.DateTime;
      DateTime startDate = Searching.Build_StartDateTime(dateTime1.AddDays(-1.0));
      dateTime1 = this.datToDate.DateTime;
      DateTime endDate = Searching.Build_EndDateTime(dateTime1.AddDays(-1.0));
      this.filteredList.Clear();
      this.filteredList = Converter.ConvertToList<Objvw_MaterialDetailDayWithID>(blstMaterialDetailDayID);
      this.filteredList.Where<Objvw_MaterialDetailDayWithID>((Func<Objvw_MaterialDetailDayWithID, bool>) (item =>
      {
        DateTime? ngayMeTron1 = item.NgayMeTron;
        DateTime dateTime2 = startDate;
        if ((ngayMeTron1.HasValue ? (ngayMeTron1.GetValueOrDefault() >= dateTime2 ? 1 : 0) : 0) != 0)
        {
          DateTime? ngayMeTron2 = item.NgayMeTron;
          DateTime dateTime3 = endDate;
          if ((ngayMeTron2.HasValue ? (ngayMeTron2.GetValueOrDefault() <= dateTime3 ? 1 : 0) : 0) != 0)
          {
            if (active.HasValue)
            {
              bool? isManual = item.IsManual;
              bool? nullable = active;
              if (!(isManual.GetValueOrDefault() == nullable.GetValueOrDefault() & isManual.HasValue == nullable.HasValue))
                goto label_7;
            }
            if (!materialID.HasValue)
              return true;
            int materialId = item.MaterialID;
            int? nullable1 = materialID;
            int valueOrDefault = nullable1.GetValueOrDefault();
            return materialId == valueOrDefault & nullable1.HasValue;
          }
        }
label_7:
        return false;
      })).ToList<Objvw_MaterialDetailDayWithID>();
      this._blstMaterialDetailDayID.Clear();
      foreach (Objvw_MaterialDetailDayWithID filtered in this.filteredList)
        this._blstMaterialDetailDayID.Add(filtered);
    }

    public List<ObjMaterialSummary> GroupAndSumMaterialDetail(
      BindingList<Objvw_MaterialDetailDayWithID> materialDetailDays)
    {
      return materialDetailDays.GroupBy<Objvw_MaterialDetailDayWithID, int>((Func<Objvw_MaterialDetailDayWithID, int>) (d => d.MaterialID)).Select<IGrouping<int, Objvw_MaterialDetailDayWithID>, ObjMaterialSummary>((Func<IGrouping<int, Objvw_MaterialDetailDayWithID>, ObjMaterialSummary>) (g => new ObjMaterialSummary()
      {
        MaterialID = g.Key,
        MaterialCode = g.First<Objvw_MaterialDetailDayWithID>().MaterialCode,
        MaterialName = g.First<Objvw_MaterialDetailDayWithID>().MaterialName,
        Sum_ValueBat = g.Sum<Objvw_MaterialDetailDayWithID>((Func<Objvw_MaterialDetailDayWithID, Decimal>) (x => x.Sum_ValueBat.Value)),
        Sum_ValueBatMan = g.Sum<Objvw_MaterialDetailDayWithID>((Func<Objvw_MaterialDetailDayWithID, Decimal>) (x => x.Sum_ValueBatMan.Value)),
        Sum_ValueCP = g.Sum<Objvw_MaterialDetailDayWithID>((Func<Objvw_MaterialDetailDayWithID, Decimal>) (x => x.Sum_ValueCP.Value)),
        SaiSo = g.Sum<Objvw_MaterialDetailDayWithID>((Func<Objvw_MaterialDetailDayWithID, Decimal>) (x => x.Sum_ValueCP.Value)) - g.Sum<Objvw_MaterialDetailDayWithID>((Func<Objvw_MaterialDetailDayWithID, Decimal>) (x => x.Sum_ValueBat.Value)),
        PerSaiSo = (g.Sum<Objvw_MaterialDetailDayWithID>((Func<Objvw_MaterialDetailDayWithID, Decimal>) (x => x.Sum_ValueCP.Value)) - g.Sum<Objvw_MaterialDetailDayWithID>((Func<Objvw_MaterialDetailDayWithID, Decimal>) (x => x.Sum_ValueBat.Value))) * 100M / g.Sum<Objvw_MaterialDetailDayWithID>((Func<Objvw_MaterialDetailDayWithID, Decimal>) (x => x.Sum_ValueCP.Value))
      })).ToList<ObjMaterialSummary>();
    }

    private void SearchDataByCondition()
    {
      bool? isManual = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        isManual = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        isManual = new bool?(true);
      this._blstTotalMaterial = Converter.ConvertToBindingList<Objvw_MaterialDetailDayWithID>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListTotalMaterial_ByCondition((int?) this.lueMaterial.EditValue, isManual) as List<Objvw_MaterialDetailDayWithID>);
      this.Invoke((Delegate) (() => this.UpdateUI(this._blstTotalMaterial)));
    }

    private void UpdateUI(BindingList<Objvw_MaterialDetailDayWithID> result)
    {
      if (this.InvokeRequired)
        this.Invoke((Delegate) (() => this.UpdateUI(result)));
      else
        this.grcTongVatTu.DataSource = (object) result;
    }

    private void UpdateUI_ID(BindingList<ObjMaterialSummary> result)
    {
      if (this.InvokeRequired)
      {
        this.Invoke((Delegate) (() => this.UpdateUI_ID(result)));
      }
      else
      {
        this.grcTongVatTu.DataSource = (object) null;
        this.grcTongVatTu.DataSource = (object) result;
      }
    }

    private void btnTimKiem_Click(object sender, EventArgs e)
    {
      bool? moPhong = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        moPhong = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        moPhong = new bool?(true);
      this._blstDataMix = this._presenter.ListDataMix_ByCondition_re(new DateTime?(Searching.BuildNew_StartDateTime(this.datFromDate.DateTime, TimeSpan.Zero)), new TimeSpan?(TimeSpan.Zero), new DateTime?(Searching.BuildNew_EndDateTime(this.datToDate.DateTime, new TimeSpan(23, 59, 59))), new TimeSpan?(new TimeSpan(23, 59, 59)), "", new int?(), new int?(), new int?(), new int?(), new int?(), new int?(), new int?(), moPhong);
      BindingList<Objvw_DataMix> blstDataMix = this._blstDataMix;
      ObjMaterialDetailSumary detailSummary1 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Agg1_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg1_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg1));
      ObjMaterialDetailSumary detailSummary2 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Agg2_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg2_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg2));
      ObjMaterialDetailSumary detailSummary3 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Agg3_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg3_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg3));
      ObjMaterialDetailSumary detailSummary4 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Agg4_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg4_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg4));
      ObjMaterialDetailSumary detailSummary5 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Agg5_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg5_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg5));
      ObjMaterialDetailSumary detailSummary6 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Agg6_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg6_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Agg6));
      ObjMaterialDetailSumary detailSummary7 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Ce1_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce1_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce1));
      ObjMaterialDetailSumary detailSummary8 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Ce2_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce2_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce2));
      ObjMaterialDetailSumary detailSummary9 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Ce3_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce3_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce3));
      ObjMaterialDetailSumary detailSummary10 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Ce4_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce4_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce4));
      ObjMaterialDetailSumary detailSummary11 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Ce5_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce5_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Ce5));
      ObjMaterialDetailSumary detailSummary12 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Wa1_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Wa1_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Wa1));
      ObjMaterialDetailSumary detailSummary13 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Wa2_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Wa2_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Wa2));
      ObjMaterialDetailSumary detailSummary14 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Add1_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Add1_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Add1));
      ObjMaterialDetailSumary detailSummary15 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Add2_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Add2_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Add2));
      ObjMaterialDetailSumary detailSummary16 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Add3_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Add3_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Add3));
      ObjMaterialDetailSumary detailSummary17 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Add4_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Add4_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Add4));
      ObjMaterialDetailSumary detailSummary18 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Add5_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Add5_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Add5));
      ObjMaterialDetailSumary detailSummary19 = this.SumMaterialDetail(blstDataMix, (Func<Objvw_DataMix, Decimal?>) (x => x.Add6_Bat), (Func<Objvw_DataMix, Decimal?>) (x => x.Add6_Man), (Func<Objvw_DataMix, Decimal?>) (x => x.Add6));
      Decimal perDecimal1 = !(detailSummary1.Sum_ValueCP == 0M) ? (detailSummary1.Sum_ValueCP - detailSummary1.Sum_ValueBat) * 100M / detailSummary1.Sum_ValueCP : 0M;
      Decimal perDecimal2 = !(detailSummary2.Sum_ValueCP == 0M) ? (detailSummary2.Sum_ValueCP - detailSummary2.Sum_ValueBat) * 100M / detailSummary2.Sum_ValueCP : 0M;
      Decimal perDecimal3 = !(detailSummary3.Sum_ValueCP == 0M) ? (detailSummary3.Sum_ValueCP - detailSummary3.Sum_ValueBat) * 100M / detailSummary3.Sum_ValueCP : 0M;
      Decimal perDecimal4 = !(detailSummary4.Sum_ValueCP == 0M) ? (detailSummary4.Sum_ValueCP - detailSummary4.Sum_ValueBat) * 100M / detailSummary4.Sum_ValueCP : 0M;
      Decimal perDecimal5 = !(detailSummary5.Sum_ValueCP == 0M) ? (detailSummary5.Sum_ValueCP - detailSummary5.Sum_ValueBat) * 100M / detailSummary5.Sum_ValueCP : 0M;
      Decimal perDecimal6 = !(detailSummary6.Sum_ValueCP == 0M) ? (detailSummary6.Sum_ValueCP - detailSummary6.Sum_ValueBat) * 100M / detailSummary6.Sum_ValueCP : 0M;
      Decimal perDecimal7 = !(detailSummary7.Sum_ValueCP == 0M) ? (detailSummary7.Sum_ValueCP - detailSummary7.Sum_ValueBat) * 100M / detailSummary7.Sum_ValueCP : 0M;
      Decimal perDecimal8 = !(detailSummary8.Sum_ValueCP == 0M) ? (detailSummary8.Sum_ValueCP - detailSummary8.Sum_ValueBat) * 100M / detailSummary8.Sum_ValueCP : 0M;
      Decimal perDecimal9 = !(detailSummary9.Sum_ValueCP == 0M) ? (detailSummary9.Sum_ValueCP - detailSummary9.Sum_ValueBat) * 100M / detailSummary9.Sum_ValueCP : 0M;
      Decimal perDecimal10 = !(detailSummary10.Sum_ValueCP == 0M) ? (detailSummary10.Sum_ValueCP - detailSummary10.Sum_ValueBat) * 100M / detailSummary10.Sum_ValueCP : 0M;
      Decimal perDecimal11 = !(detailSummary11.Sum_ValueCP == 0M) ? (detailSummary11.Sum_ValueCP - detailSummary11.Sum_ValueBat) * 100M / detailSummary11.Sum_ValueCP : 0M;
      Decimal perDecimal12 = !(detailSummary12.Sum_ValueCP == 0M) ? (detailSummary12.Sum_ValueCP - detailSummary12.Sum_ValueBat) * 100M / detailSummary12.Sum_ValueCP : 0M;
      Decimal perDecimal13 = !(detailSummary13.Sum_ValueCP == 0M) ? (detailSummary13.Sum_ValueCP - detailSummary13.Sum_ValueBat) * 100M / detailSummary13.Sum_ValueCP : 0M;
      Decimal perDecimal14 = !(detailSummary14.Sum_ValueCP == 0M) ? (detailSummary14.Sum_ValueCP - detailSummary14.Sum_ValueBat) * 100M / detailSummary14.Sum_ValueCP : 0M;
      Decimal perDecimal15 = !(detailSummary15.Sum_ValueCP == 0M) ? (detailSummary15.Sum_ValueCP - detailSummary15.Sum_ValueBat) * 100M / detailSummary15.Sum_ValueCP : 0M;
      Decimal perDecimal16 = !(detailSummary16.Sum_ValueCP == 0M) ? (detailSummary16.Sum_ValueCP - detailSummary16.Sum_ValueBat) * 100M / detailSummary16.Sum_ValueCP : 0M;
      Decimal perDecimal17 = !(detailSummary17.Sum_ValueCP == 0M) ? (detailSummary17.Sum_ValueCP - detailSummary17.Sum_ValueBat) * 100M / detailSummary17.Sum_ValueCP : 0M;
      Decimal perDecimal18 = !(detailSummary18.Sum_ValueCP == 0M) ? (detailSummary18.Sum_ValueCP - detailSummary18.Sum_ValueBat) * 100M / detailSummary18.Sum_ValueCP : 0M;
      Decimal perDecimal19 = !(detailSummary19.Sum_ValueCP == 0M) ? (detailSummary19.Sum_ValueCP - detailSummary19.Sum_ValueBat) * 100M / detailSummary19.Sum_ValueCP : 0M;
      List<ObjMaterialSummary> objMaterialSummaryList1 = new List<ObjMaterialSummary>();
      switch (this.num_silo_Agg)
      {
        case 1:
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(1, this.GetMaterialCode("Agg1"), this.GetMaterialName("Agg1"), detailSummary1, perDecimal1, false));
          break;
        case 2:
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(1, this.GetMaterialCode("Agg1"), this.GetMaterialName("Agg1"), detailSummary1, perDecimal1, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(2, this.GetMaterialCode("Agg2"), this.GetMaterialName("Agg2"), detailSummary2, perDecimal2, false));
          break;
        case 3:
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(1, this.GetMaterialCode("Agg1"), this.GetMaterialName("Agg1"), detailSummary1, perDecimal1, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(2, this.GetMaterialCode("Agg2"), this.GetMaterialName("Agg2"), detailSummary2, perDecimal2, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(3, this.GetMaterialCode("Agg3"), this.GetMaterialName("Agg3"), detailSummary3, perDecimal3, false));
          break;
        case 4:
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(1, this.GetMaterialCode("Agg1"), this.GetMaterialName("Agg1"), detailSummary1, perDecimal1, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(2, this.GetMaterialCode("Agg2"), this.GetMaterialName("Agg2"), detailSummary2, perDecimal2, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(3, this.GetMaterialCode("Agg3"), this.GetMaterialName("Agg3"), detailSummary3, perDecimal3, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(4, this.GetMaterialCode("Agg4"), this.GetMaterialName("Agg4"), detailSummary4, perDecimal4, false));
          break;
        case 5:
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(1, this.GetMaterialCode("Agg1"), this.GetMaterialName("Agg1"), detailSummary1, perDecimal1, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(2, this.GetMaterialCode("Agg2"), this.GetMaterialName("Agg2"), detailSummary2, perDecimal2, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(3, this.GetMaterialCode("Agg3"), this.GetMaterialName("Agg3"), detailSummary3, perDecimal3, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(4, this.GetMaterialCode("Agg4"), this.GetMaterialName("Agg4"), detailSummary4, perDecimal4, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(5, this.GetMaterialCode("Agg5"), this.GetMaterialName("Agg5"), detailSummary5, perDecimal5, false));
          break;
        case 6:
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(1, this.GetMaterialCode("Agg1"), this.GetMaterialName("Agg1"), detailSummary1, perDecimal1, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(2, this.GetMaterialCode("Agg2"), this.GetMaterialName("Agg2"), detailSummary2, perDecimal2, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(3, this.GetMaterialCode("Agg3"), this.GetMaterialName("Agg3"), detailSummary3, perDecimal3, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(4, this.GetMaterialCode("Agg4"), this.GetMaterialName("Agg4"), detailSummary4, perDecimal4, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(5, this.GetMaterialCode("Agg5"), this.GetMaterialName("Agg5"), detailSummary5, perDecimal5, false));
          objMaterialSummaryList1.Add(this.CreateMaterialSummary(6, this.GetMaterialCode("Agg6"), this.GetMaterialName("Agg6"), detailSummary6, perDecimal6, false));
          break;
      }
      List<ObjMaterialSummary> objMaterialSummaryList2 = new List<ObjMaterialSummary>();
      switch (this.num_silo_Ce)
      {
        case 1:
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(7, this.GetMaterialCode("Ce1"), this.GetMaterialName("Ce1"), detailSummary7, perDecimal7, false));
          break;
        case 2:
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(7, this.GetMaterialCode("Ce1"), this.GetMaterialName("Ce1"), detailSummary7, perDecimal7, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(8, this.GetMaterialCode("Ce2"), this.GetMaterialName("Ce2"), detailSummary8, perDecimal8, false));
          break;
        case 3:
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(7, this.GetMaterialCode("Ce1"), this.GetMaterialName("Ce1"), detailSummary7, perDecimal7, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(8, this.GetMaterialCode("Ce2"), this.GetMaterialName("Ce2"), detailSummary8, perDecimal8, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(9, this.GetMaterialCode("Ce3"), this.GetMaterialName("Ce3"), detailSummary9, perDecimal9, false));
          break;
        case 4:
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(7, this.GetMaterialCode("Ce1"), this.GetMaterialName("Ce1"), detailSummary7, perDecimal7, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(8, this.GetMaterialCode("Ce2"), this.GetMaterialName("Ce2"), detailSummary8, perDecimal8, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(9, this.GetMaterialCode("Ce3"), this.GetMaterialName("Ce3"), detailSummary9, perDecimal9, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(10, this.GetMaterialCode("Ce4"), this.GetMaterialName("Ce4"), detailSummary10, perDecimal10, false));
          break;
        case 5:
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(7, this.GetMaterialCode("Ce1"), this.GetMaterialName("Ce1"), detailSummary7, perDecimal7, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(8, this.GetMaterialCode("Ce2"), this.GetMaterialName("Ce2"), detailSummary8, perDecimal8, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(9, this.GetMaterialCode("Ce3"), this.GetMaterialName("Ce3"), detailSummary9, perDecimal9, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(10, this.GetMaterialCode("Ce4"), this.GetMaterialName("Ce4"), detailSummary10, perDecimal10, false));
          objMaterialSummaryList2.Add(this.CreateMaterialSummary(11, this.GetMaterialCode("Ce5"), this.GetMaterialName("Ce5"), detailSummary11, perDecimal11, false));
          break;
      }
      List<ObjMaterialSummary> objMaterialSummaryList3 = new List<ObjMaterialSummary>();
      switch (this.num_silo_Wa)
      {
        case 1:
          objMaterialSummaryList3.Add(this.CreateMaterialSummary(12, this.GetMaterialCode("Wa1"), this.GetMaterialName("Wa1"), detailSummary12, perDecimal12, false));
          break;
        case 2:
          objMaterialSummaryList3.Add(this.CreateMaterialSummary(12, this.GetMaterialCode("Wa1"), this.GetMaterialName("Wa1"), detailSummary12, perDecimal12, false));
          objMaterialSummaryList3.Add(this.CreateMaterialSummary(13, this.GetMaterialCode("Wa2"), this.GetMaterialName("Wa2"), detailSummary13, perDecimal13, false));
          break;
      }
      List<ObjMaterialSummary> objMaterialSummaryList4 = new List<ObjMaterialSummary>();
      switch (this.num_silo_Add)
      {
        case 1:
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(14, this.GetMaterialCode("Add1"), this.GetMaterialName("Add1"), detailSummary14, perDecimal14, false));
          break;
        case 2:
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(14, this.GetMaterialCode("Add1"), this.GetMaterialName("Add1"), detailSummary14, perDecimal14, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(15, this.GetMaterialCode("Add2"), this.GetMaterialName("Add2"), detailSummary15, perDecimal15, false));
          break;
        case 3:
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(14, this.GetMaterialCode("Add1"), this.GetMaterialName("Add1"), detailSummary14, perDecimal14, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(15, this.GetMaterialCode("Add2"), this.GetMaterialName("Add2"), detailSummary15, perDecimal15, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(16, this.GetMaterialCode("Add3"), this.GetMaterialName("Add3"), detailSummary16, perDecimal16, false));
          break;
        case 4:
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(14, this.GetMaterialCode("Add1"), this.GetMaterialName("Add1"), detailSummary14, perDecimal14, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(15, this.GetMaterialCode("Add2"), this.GetMaterialName("Add2"), detailSummary15, perDecimal15, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(16, this.GetMaterialCode("Add3"), this.GetMaterialName("Add3"), detailSummary16, perDecimal16, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(17, this.GetMaterialCode("Add4"), this.GetMaterialName("Add4"), detailSummary17, perDecimal17, false));
          break;
        case 5:
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(14, this.GetMaterialCode("Add1"), this.GetMaterialName("Add1"), detailSummary14, perDecimal14, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(15, this.GetMaterialCode("Add2"), this.GetMaterialName("Add2"), detailSummary15, perDecimal15, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(16, this.GetMaterialCode("Add3"), this.GetMaterialName("Add3"), detailSummary16, perDecimal16, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(17, this.GetMaterialCode("Add4"), this.GetMaterialName("Add4"), detailSummary17, perDecimal17, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(18, this.GetMaterialCode("Add5"), this.GetMaterialName("Add5"), detailSummary18, perDecimal18, false));
          break;
        case 6:
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(14, this.GetMaterialCode("Add1"), this.GetMaterialName("Add1"), detailSummary14, perDecimal14, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(15, this.GetMaterialCode("Add2"), this.GetMaterialName("Add2"), detailSummary15, perDecimal15, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(16, this.GetMaterialCode("Add3"), this.GetMaterialName("Add3"), detailSummary16, perDecimal16, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(17, this.GetMaterialCode("Add4"), this.GetMaterialName("Add4"), detailSummary17, perDecimal17, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(18, this.GetMaterialCode("Add5"), this.GetMaterialName("Add5"), detailSummary18, perDecimal18, false));
          objMaterialSummaryList4.Add(this.CreateMaterialSummary(19, this.GetMaterialCode("Add6"), this.GetMaterialName("Add6"), detailSummary19, perDecimal19, false));
          break;
      }
      List<ObjMaterialSummary> objMaterialSummaryList5 = new List<ObjMaterialSummary>();
      foreach (ObjMaterialSummary objMaterialSummary in objMaterialSummaryList1)
        objMaterialSummaryList5.Add(objMaterialSummary);
      foreach (ObjMaterialSummary objMaterialSummary in objMaterialSummaryList2)
        objMaterialSummaryList5.Add(objMaterialSummary);
      foreach (ObjMaterialSummary objMaterialSummary in objMaterialSummaryList3)
        objMaterialSummaryList5.Add(objMaterialSummary);
      foreach (ObjMaterialSummary objMaterialSummary in objMaterialSummaryList4)
        objMaterialSummaryList5.Add(objMaterialSummary);
      this.grcTongVatTu.DataSource = (object) objMaterialSummaryList5;
    }

    private string GetMaterialName(string maSilo)
    {
      string materialName = "";
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) this._blstSilo)
      {
        if (objSilo.MaSilo == maSilo)
        {
          string maSilo1 = objSilo.MaSilo;
          if (maSilo1 != null)
          {
            switch (maSilo1.Length)
            {
              case 3:
                switch (maSilo1[2])
                {
                  case '1':
                    switch (maSilo1)
                    {
                      case "Ce1":
                        materialName = objSilo.MaterialName;
                        continue;
                      case "Wa1":
                        materialName = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '2':
                    switch (maSilo1)
                    {
                      case "Ce2":
                        materialName = objSilo.MaterialName;
                        continue;
                      case "Wa2":
                        materialName = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '3':
                    if (maSilo1 == "Ce3")
                    {
                      materialName = objSilo.MaterialName;
                      continue;
                    }
                    continue;
                  case '4':
                    if (maSilo1 == "Ce4")
                    {
                      materialName = objSilo.MaterialName;
                      continue;
                    }
                    continue;
                  case '5':
                    if (maSilo1 == "Ce5")
                    {
                      materialName = objSilo.MaterialName;
                      continue;
                    }
                    continue;
                  default:
                    continue;
                }
              case 4:
                switch (maSilo1[3])
                {
                  case '1':
                    switch (maSilo1)
                    {
                      case "Agg1":
                        materialName = objSilo.MaterialName;
                        continue;
                      case "Add1":
                        materialName = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '2':
                    switch (maSilo1)
                    {
                      case "Agg2":
                        materialName = objSilo.MaterialName;
                        continue;
                      case "Add2":
                        materialName = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '3':
                    switch (maSilo1)
                    {
                      case "Agg3":
                        materialName = objSilo.MaterialName;
                        continue;
                      case "Add3":
                        materialName = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '4':
                    switch (maSilo1)
                    {
                      case "Agg4":
                        materialName = objSilo.MaterialName;
                        continue;
                      case "Add4":
                        materialName = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '5':
                    switch (maSilo1)
                    {
                      case "Agg5":
                        materialName = objSilo.MaterialName;
                        continue;
                      case "Add5":
                        materialName = objSilo.MaterialName;
                        continue;
                      default:
                        continue;
                    }
                  case '6':
                    switch (maSilo1)
                    {
                      case "Agg6":
                        materialName = objSilo.MaterialName;
                        continue;
                      case "Add6":
                        materialName = objSilo.MaterialName;
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
      return materialName;
    }

    private string GetMaterialCode(string maSilo)
    {
      string materialCode = "";
      foreach (ObjSilo objSilo in (Collection<ObjSilo>) this._blstSilo)
      {
        if (objSilo.MaSilo == maSilo)
        {
          string maSilo1 = objSilo.MaSilo;
          if (maSilo1 != null)
          {
            switch (maSilo1.Length)
            {
              case 3:
                switch (maSilo1[2])
                {
                  case '1':
                    switch (maSilo1)
                    {
                      case "Ce1":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      case "Wa1":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      default:
                        continue;
                    }
                  case '2':
                    switch (maSilo1)
                    {
                      case "Ce2":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      case "Wa2":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      default:
                        continue;
                    }
                  case '3':
                    if (maSilo1 == "Ce3")
                    {
                      materialCode = objSilo.MaterialCode;
                      continue;
                    }
                    continue;
                  case '4':
                    if (maSilo1 == "Ce4")
                    {
                      materialCode = objSilo.MaterialCode;
                      continue;
                    }
                    continue;
                  case '5':
                    if (maSilo1 == "Ce5")
                    {
                      materialCode = objSilo.MaterialCode;
                      continue;
                    }
                    continue;
                  default:
                    continue;
                }
              case 4:
                switch (maSilo1[3])
                {
                  case '1':
                    switch (maSilo1)
                    {
                      case "Agg1":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      case "Add1":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      default:
                        continue;
                    }
                  case '2':
                    switch (maSilo1)
                    {
                      case "Agg2":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      case "Add2":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      default:
                        continue;
                    }
                  case '3':
                    switch (maSilo1)
                    {
                      case "Agg3":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      case "Add3":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      default:
                        continue;
                    }
                  case '4':
                    switch (maSilo1)
                    {
                      case "Agg4":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      case "Add4":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      default:
                        continue;
                    }
                  case '5':
                    switch (maSilo1)
                    {
                      case "Agg5":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      case "Add5":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      default:
                        continue;
                    }
                  case '6':
                    switch (maSilo1)
                    {
                      case "Agg6":
                        materialCode = objSilo.MaterialCode;
                        continue;
                      case "Add6":
                        materialCode = objSilo.MaterialCode;
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
      return materialCode;
    }

    public ObjMaterialSummary CreateMaterialSummary(
      int materialID,
      string materialCode,
      string materialName,
      ObjMaterialDetailSumary detailSummary,
      Decimal perDecimal,
      bool isManual)
    {
      return new ObjMaterialSummary()
      {
        MaterialID = materialID,
        MaterialCode = materialCode,
        MaterialName = materialName,
        Sum_ValueCP = detailSummary.Sum_ValueCP,
        Sum_ValueBat = detailSummary.Sum_ValueBat,
        Sum_ValueBatMan = detailSummary.Sum_ValueBatMan,
        SaiSo = detailSummary.Sum_ValueCP - detailSummary.Sum_ValueBat,
        PerSaiSo = perDecimal,
        IsManual = isManual
      };
    }

    public ObjMaterialDetailSumary SumMaterialDetail(
      BindingList<Objvw_DataMix> dataMix,
      Func<Objvw_DataMix, Decimal?> valueBatSelector,
      Func<Objvw_DataMix, Decimal?> valueBatManSelector,
      Func<Objvw_DataMix, Decimal?> valueCPSelector)
    {
      return new ObjMaterialDetailSumary()
      {
        Sum_ValueBat = dataMix.Sum<Objvw_DataMix>((Func<Objvw_DataMix, Decimal>) (x => valueBatSelector(x).GetValueOrDefault())),
        Sum_ValueBatMan = dataMix.Sum<Objvw_DataMix>((Func<Objvw_DataMix, Decimal>) (x => valueBatManSelector(x).GetValueOrDefault())),
        Sum_ValueCP = dataMix.Sum<Objvw_DataMix>((Func<Objvw_DataMix, Decimal>) (x => valueCPSelector(x).GetValueOrDefault()))
      };
    }

    private void simpleButton1_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
      try
      {
        string title = "BÁO CÁO TỔNG VẬT TƯ";
        string str1 = string.Format("Từ ngày: {0} - đến ngày: {1}", (object) FormatToString.DateTimeToString(this.datFromDate.DateTime), (object) FormatToString.DateTimeToString(this.datToDate.DateTime));
        string str2 = string.Format("Vật tự: {0}", (object) this.lueMaterial.Text);
        List<string> lstHeader = new List<string>();
        lstHeader.Add(str1);
        if (this.lueMaterial.EditValue != null)
          lstHeader.Add(str2);
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.grcTongVatTu, true, true, title, lstHeader);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

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
      GridGroupSummaryItem groupSummaryItem3 = new GridGroupSummaryItem();
      this.gcCapPhoi = new GridColumn();
      this.gcThucCan = new GridColumn();
      this.gcSaiSo = new GridColumn();
      this.groupControl2 = new GroupControl();
      this.grcTongVatTu = new GridControl();
      this.grvTongVatTu = new GridView();
      this.gcMaVatTu = new GridColumn();
      this.gcNgayMeTron = new GridColumn();
      this.gcTenVatTu = new GridColumn();
      this.gcPerSaiSo = new GridColumn();
      this.groupControl1 = new GroupControl();
      this.groupBox2 = new GroupBox();
      this.lueCheDo = new LookUpEdit();
      this.simpleButton1 = new SimpleButton();
      this.btnTimKiem = new SimpleButton();
      this.lueMaterial = new LookUpEdit();
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
      this.panelControl2 = new PanelControl();
      this.groupControl2.BeginInit();
      this.grcTongVatTu.BeginInit();
      this.grvTongVatTu.BeginInit();
      this.groupControl1.BeginInit();
      this.groupBox2.SuspendLayout();
      this.lueCheDo.Properties.BeginInit();
      this.lueMaterial.Properties.BeginInit();
      this.datToDate.Properties.BeginInit();
      this.datToDate.Properties.CalendarTimeProperties.BeginInit();
      this.datFromDate.Properties.BeginInit();
      this.datFromDate.Properties.CalendarTimeProperties.BeginInit();
      this.groupBox1.SuspendLayout();
      this.panelControl1.BeginInit();
      this.panelControl2.BeginInit();
      this.SuspendLayout();
      this.gcCapPhoi.Caption = "Cấp phối";
      this.gcCapPhoi.FieldName = "Sum_ValueCP";
      this.gcCapPhoi.GroupFormat.FormatString = "n2";
      this.gcCapPhoi.GroupFormat.FormatType = FormatType.Numeric;
      this.gcCapPhoi.Name = "gcCapPhoi";
      this.gcCapPhoi.OptionsColumn.AllowFocus = false;
      this.gcCapPhoi.OptionsColumn.ReadOnly = true;
      this.gcCapPhoi.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Sum_ValueCP", "{0:0.##}")
      });
      this.gcCapPhoi.Visible = true;
      this.gcCapPhoi.VisibleIndex = 2;
      this.gcThucCan.Caption = "Thực cân";
      this.gcThucCan.FieldName = "Sum_ValueBat";
      this.gcThucCan.GroupFormat.FormatString = "n2";
      this.gcThucCan.GroupFormat.FormatType = FormatType.Numeric;
      this.gcThucCan.Name = "gcThucCan";
      this.gcThucCan.OptionsColumn.AllowFocus = false;
      this.gcThucCan.OptionsColumn.ReadOnly = true;
      this.gcThucCan.Summary.AddRange(new GridSummaryItem[1]
      {
        (GridSummaryItem) new GridColumnSummaryItem(SummaryItemType.Sum, "Sum_ValueBat", "{0:0.##}")
      });
      this.gcThucCan.Visible = true;
      this.gcThucCan.VisibleIndex = 3;
      this.gcSaiSo.Caption = "Sai số";
      this.gcSaiSo.FieldName = "SaiSo";
      this.gcSaiSo.GroupFormat.FormatString = "n2";
      this.gcSaiSo.GroupFormat.FormatType = FormatType.Numeric;
      this.gcSaiSo.Name = "gcSaiSo";
      this.gcSaiSo.OptionsColumn.AllowFocus = false;
      this.gcSaiSo.OptionsColumn.ReadOnly = true;
      this.gcSaiSo.Visible = true;
      this.gcSaiSo.VisibleIndex = 4;
      this.groupControl2.Controls.Add((Control) this.grcTongVatTu);
      this.groupControl2.Dock = DockStyle.Fill;
      this.groupControl2.Location = new Point(2, 2);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(629, 462);
      this.groupControl2.TabIndex = 1;
      this.groupControl2.Text = "Dữ liệu";
      this.grcTongVatTu.Dock = DockStyle.Fill;
      this.grcTongVatTu.Location = new Point(2, 23);
      this.grcTongVatTu.MainView = (BaseView) this.grvTongVatTu;
      this.grcTongVatTu.Name = "grcTongVatTu";
      this.grcTongVatTu.Size = new Size(625, 437);
      this.grcTongVatTu.TabIndex = 0;
      this.grcTongVatTu.ViewCollection.AddRange(new BaseView[1]
      {
        (BaseView) this.grvTongVatTu
      });
      this.grvTongVatTu.AppearancePrint.HeaderPanel.BackColor = Color.DodgerBlue;
      this.grvTongVatTu.AppearancePrint.HeaderPanel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grvTongVatTu.AppearancePrint.HeaderPanel.ForeColor = Color.White;
      this.grvTongVatTu.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
      this.grvTongVatTu.AppearancePrint.HeaderPanel.Options.UseFont = true;
      this.grvTongVatTu.AppearancePrint.HeaderPanel.Options.UseForeColor = true;
      this.grvTongVatTu.Columns.AddRange(new GridColumn[7]
      {
        this.gcMaVatTu,
        this.gcNgayMeTron,
        this.gcTenVatTu,
        this.gcCapPhoi,
        this.gcThucCan,
        this.gcSaiSo,
        this.gcPerSaiSo
      });
      this.grvTongVatTu.GridControl = this.grcTongVatTu;
      groupSummaryItem1.DisplayFormat = "Tổng CP:{0:0.##}";
      groupSummaryItem1.FieldName = "Sum_ValueCP";
      groupSummaryItem1.ShowInGroupColumnFooter = this.gcCapPhoi;
      groupSummaryItem1.SummaryType = SummaryItemType.Sum;
      groupSummaryItem1.Tag = (object) "Sum_ValueCP";
      groupSummaryItem2.DisplayFormat = "Tổng Thực cân:{0:0.##}";
      groupSummaryItem2.FieldName = "Sum_ValueBat";
      groupSummaryItem2.ShowInGroupColumnFooter = this.gcThucCan;
      groupSummaryItem2.SummaryType = SummaryItemType.Sum;
      groupSummaryItem2.Tag = (object) "Sum_ValueBat";
      groupSummaryItem3.DisplayFormat = "Sai số: {Sum_ValueCP} -{Sum_ValueBat}";
      groupSummaryItem3.ShowInGroupColumnFooter = this.gcSaiSo;
      groupSummaryItem3.SummaryType = SummaryItemType.Custom;
      this.grvTongVatTu.GroupSummary.AddRange(new GridSummaryItem[3]
      {
        (GridSummaryItem) groupSummaryItem1,
        (GridSummaryItem) groupSummaryItem2,
        (GridSummaryItem) groupSummaryItem3
      });
      this.grvTongVatTu.Name = "grvTongVatTu";
      this.grvTongVatTu.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
      this.grvTongVatTu.OptionsBehavior.AutoExpandAllGroups = true;
      this.grvTongVatTu.OptionsMenu.ShowGroupSummaryEditorItem = true;
      this.grvTongVatTu.OptionsView.ShowFooter = true;
      this.grvTongVatTu.SortInfo.AddRange(new GridColumnSortInfo[1]
      {
        new GridColumnSortInfo(this.gcTenVatTu, ColumnSortOrder.Ascending)
      });
      this.gcMaVatTu.Caption = "Mã Vật tư";
      this.gcMaVatTu.FieldName = "MaterialCode";
      this.gcMaVatTu.GroupFormat.FormatString = "d";
      this.gcMaVatTu.GroupFormat.FormatType = FormatType.Custom;
      this.gcMaVatTu.Name = "gcMaVatTu";
      this.gcMaVatTu.OptionsColumn.AllowFocus = false;
      this.gcMaVatTu.OptionsColumn.ReadOnly = true;
      this.gcMaVatTu.Visible = true;
      this.gcMaVatTu.VisibleIndex = 0;
      this.gcNgayMeTron.Caption = "Ngày trộn";
      this.gcNgayMeTron.FieldName = "NgayMeTron";
      this.gcNgayMeTron.Name = "gcNgayMeTron";
      this.gcNgayMeTron.OptionsColumn.AllowGroup = DefaultBoolean.True;
      this.gcTenVatTu.Caption = "Tên Vật tư";
      this.gcTenVatTu.FieldName = "MaterialName";
      this.gcTenVatTu.GroupFormat.FormatString = "d";
      this.gcTenVatTu.GroupFormat.FormatType = FormatType.Custom;
      this.gcTenVatTu.Name = "gcTenVatTu";
      this.gcTenVatTu.OptionsColumn.AllowFocus = false;
      this.gcTenVatTu.OptionsColumn.ReadOnly = true;
      this.gcTenVatTu.Visible = true;
      this.gcTenVatTu.VisibleIndex = 1;
      this.gcPerSaiSo.Caption = "% Sai số";
      this.gcPerSaiSo.DisplayFormat.FormatString = "n2";
      this.gcPerSaiSo.DisplayFormat.FormatType = FormatType.Numeric;
      this.gcPerSaiSo.FieldName = "PerSaiSo";
      this.gcPerSaiSo.GroupFormat.FormatString = "n2";
      this.gcPerSaiSo.GroupFormat.FormatType = FormatType.Numeric;
      this.gcPerSaiSo.Name = "gcPerSaiSo";
      this.gcPerSaiSo.OptionsColumn.AllowFocus = false;
      this.gcPerSaiSo.OptionsColumn.ReadOnly = true;
      this.gcPerSaiSo.Visible = true;
      this.gcPerSaiSo.VisibleIndex = 5;
      this.groupControl1.Controls.Add((Control) this.groupBox2);
      this.groupControl1.Controls.Add((Control) this.groupBox1);
      this.groupControl1.Dock = DockStyle.Right;
      this.groupControl1.Location = new Point(631, 2);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(280, 462);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "Tác vụ";
      this.groupBox2.Controls.Add((Control) this.lueCheDo);
      this.groupBox2.Controls.Add((Control) this.simpleButton1);
      this.groupBox2.Controls.Add((Control) this.btnTimKiem);
      this.groupBox2.Controls.Add((Control) this.lueMaterial);
      this.groupBox2.Controls.Add((Control) this.labelControl3);
      this.groupBox2.Controls.Add((Control) this.labelControl2);
      this.groupBox2.Controls.Add((Control) this.datToDate);
      this.groupBox2.Controls.Add((Control) this.datFromDate);
      this.groupBox2.Controls.Add((Control) this.labelControl1);
      this.groupBox2.Controls.Add((Control) this.lblFromDate);
      this.groupBox2.Dock = DockStyle.Fill;
      this.groupBox2.Location = new Point(2, 23);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(276, 291);
      this.groupBox2.TabIndex = 75;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Bộ lọc";
      this.lueCheDo.Location = new Point(112, 120);
      this.lueCheDo.Name = "lueCheDo";
      this.lueCheDo.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.simpleButton1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.simpleButton1.Appearance.Options.UseFont = true;
      this.simpleButton1.Location = new Point(21, 170);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(108, 32);
      this.simpleButton1.TabIndex = 9;
      this.simpleButton1.Text = "Làm mới";
      this.simpleButton1.Click += new EventHandler(this.simpleButton1_Click);
      this.btnTimKiem.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnTimKiem.Appearance.Options.UseFont = true;
      this.btnTimKiem.Location = new Point(154, 170);
      this.btnTimKiem.Name = "btnTimKiem";
      this.btnTimKiem.Size = new Size(108, 32);
      this.btnTimKiem.TabIndex = 8;
      this.btnTimKiem.Text = "Tìm";
      this.btnTimKiem.Click += new EventHandler(this.btnTimKiem_Click);
      this.lueMaterial.Location = new Point(112, 90);
      this.lueMaterial.Name = "lueMaterial";
      this.lueMaterial.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lueMaterial.Properties.Appearance.Options.UseFont = true;
      this.lueMaterial.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueMaterial.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("MaterialID", "MaterialID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaterialCode", "Mã Vật tư"),
        new LookUpColumnInfo("MaterialName", "Tên Vật tư")
      });
      this.lueMaterial.Properties.DisplayMember = "MaterialName";
      this.lueMaterial.Properties.NullText = "";
      this.lueMaterial.Properties.ValueMember = "MaterialID";
      this.lueMaterial.Size = new Size(150, 22);
      this.lueMaterial.TabIndex = 6;
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(21, 123);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(40, 16);
      this.labelControl3.TabIndex = 5;
      this.labelControl3.Text = "Chế độ";
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(21, 93);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(61, 16);
      this.labelControl2.TabIndex = 4;
      this.labelControl2.Text = "Tên Vật tư";
      this.datToDate.EditValue = (object) new DateTime(2024, 6, 12, 0, 0, 0, 0);
      this.datToDate.Location = new Point(112, 60);
      this.datToDate.Name = "datToDate";
      this.datToDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.datFromDate.EditValue = (object) new DateTime(2024, 6, 12, 0, 0, 0, 0);
      this.datFromDate.Location = new Point(112, 30);
      this.datFromDate.Name = "datFromDate";
      this.datFromDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
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
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(21, 63);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Đến ngày";
      this.lblFromDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblFromDate.Appearance.Options.UseFont = true;
      this.lblFromDate.Location = new Point(21, 33);
      this.lblFromDate.Name = "lblFromDate";
      this.lblFromDate.Size = new Size(69, 16);
      this.lblFromDate.TabIndex = 0;
      this.lblFromDate.Text = "Tạo từ ngày";
      this.groupBox1.Controls.Add((Control) this.btnExportExcel);
      this.groupBox1.Dock = DockStyle.Bottom;
      this.groupBox1.Location = new Point(2, 314);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(276, 146);
      this.groupBox1.TabIndex = 74;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Xuất dữ liệu";
      this.btnExportExcel.AllowFocus = false;
      this.btnExportExcel.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnExportExcel.Appearance.Options.UseFont = true;
      this.btnExportExcel.ImageOptions.AllowGlyphSkinning = DefaultBoolean.False;
      this.btnExportExcel.ImageOptions.Image = (Image) ResourceNhua.eexport_Excel;
      this.btnExportExcel.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter;
      this.btnExportExcel.ImageOptions.Location = ImageLocation.MiddleCenter;
      this.btnExportExcel.Location = new Point(80, 60);
      this.btnExportExcel.Name = "btnExportExcel";
      this.btnExportExcel.Size = new Size(120, 45);
      this.btnExportExcel.TabIndex = 74;
      this.btnExportExcel.Text = "Xuất Excel";
      this.btnExportExcel.Click += new EventHandler(this.btnExportExcel_Click);
      this.panelControl1.Controls.Add((Control) this.labelControl4);
      this.panelControl1.Dock = DockStyle.Top;
      this.panelControl1.Location = new Point(0, 0);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(913, 50);
      this.panelControl1.TabIndex = 2;
      this.labelControl4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
      this.labelControl4.Appearance.Font = new Font("Tahoma", 15.75f, FontStyle.Bold);
      this.labelControl4.Appearance.Options.UseFont = true;
      this.labelControl4.AutoSizeMode = LabelAutoSizeMode.None;
      this.labelControl4.Location = new Point(10, 2);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(903, 0);
      this.labelControl4.TabIndex = 0;
      this.labelControl4.Text = "BÁO CÁO TỔNG VẬT TƯ";
      this.panelControl2.Controls.Add((Control) this.groupControl2);
      this.panelControl2.Controls.Add((Control) this.groupControl1);
      this.panelControl2.Dock = DockStyle.Fill;
      this.panelControl2.Location = new Point(0, 50);
      this.panelControl2.Name = "panelControl2";
      this.panelControl2.Size = new Size(913, 466);
      this.panelControl2.TabIndex = 3;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.panelControl2);
      this.Controls.Add((Control) this.panelControl1);
      this.Name = nameof (ReportTongVatTu);
      this.Size = new Size(913, 516);
      this.groupControl2.EndInit();
      this.grcTongVatTu.EndInit();
      this.grvTongVatTu.EndInit();
      this.groupControl1.EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.lueCheDo.Properties.EndInit();
      this.lueMaterial.Properties.EndInit();
      this.datToDate.Properties.CalendarTimeProperties.EndInit();
      this.datToDate.Properties.EndInit();
      this.datFromDate.Properties.CalendarTimeProperties.EndInit();
      this.datFromDate.Properties.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.panelControl1.EndInit();
      this.panelControl2.EndInit();
      this.ResumeLayout(false);
    }
  }
}

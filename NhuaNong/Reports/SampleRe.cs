// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.SampleRe
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
using NhuaNong.EntityModel;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Reports
{
  public partial class SampleRe : ControlViewBase
  {
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private BindingList<Objvw_TranferDetailDay> _blstTotalMaterial = new BindingList<Objvw_TranferDetailDay>();
    private BindingList<ObjMaterial> _blstMaterial = new BindingList<ObjMaterial>();
    private BindingList<ObjVatTu> danhSachDuLieu = new BindingList<ObjVatTu>();
    

    public SampleRe()
    {
      this.InitializeComponent();
      this.Name = nameof(SampleRe);
      this.Caption = "Tổng vật tư";
      this._blstMaterial = Converter.ConvertToBindingList<ObjMaterial>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListMaterial() as List<ObjMaterial>);
    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(true);
      this.lueMaterial.Properties.DataSource = (object) this._blstMaterial;
      this.LoadSearchDefaultValues();
    }

    protected override void PopulateData() => this.LoadData();

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) string.Empty;
      this.datToDate.EditValue = (object) DateTime.Now;
      this.lueMaterial.EditValue = (object) null;
      this.lueCheDo.EditValue = (object) 2;
    }

    private void LoadData()
    {
      bool? isQueued = new bool?();
      if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
        isQueued = new bool?(false);
      else if (Convert.ToInt32(this.lueCheDo.EditValue) == 2)
        isQueued = new bool?(true);
      this._blstTotalMaterial = Converter.ConvertToBindingList<Objvw_TranferDetailDay>(ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode).ListTranferDetailDay_ByCondition(new DateTime?(Searching.Build_StartDateTime(this.datFromDate.DateTime)), new DateTime?(Searching.Build_EndDateTime(this.datToDate.DateTime)), (int?) this.lueMaterial.EditValue, isQueued) as List<Objvw_TranferDetailDay>);
      this.gridControl1.DataSource = (object) this._blstTotalMaterial;
    }

    private void GetData()
    {
      using (DEPTramTronEntities tramTronEntities = new DEPTramTronEntities(ConfigManager.ServiceConfig.ConnectionString))
      {
        List<DateTime?> list1 = tramTronEntities.vw_PvTranferDetailDay.Select<vw_PvTranferDetailDay, DateTime?>((Expression<Func<vw_PvTranferDetailDay, DateTime?>>) (x => x.NgayMeTron)).Distinct<DateTime?>().ToList<DateTime?>();
        List<string> list2 = tramTronEntities.vw_PvTranferDetailDay.Select<vw_PvTranferDetailDay, string>((Expression<Func<vw_PvTranferDetailDay, string>>) (x => x.BienSo)).Distinct<string>().ToList<string>();
        List<vw_PvTranferDetailDay> tranferDetailDayList = new List<vw_PvTranferDetailDay>();
        foreach (string str in list2)
        {
          string xeID = str;
          foreach (DateTime? nullable in list1)
          {
            DateTime? ngayMeTron = nullable;
            List<vw_PvTranferDetailDay> list3 = tramTronEntities.vw_PvTranferDetailDay.Where<vw_PvTranferDetailDay>((Expression<Func<vw_PvTranferDetailDay, bool>>) (y => DbFunctions.TruncateTime(y.NgayMeTron) == DbFunctions.TruncateTime(ngayMeTron) && y.BienSo.Contains(xeID))).ToList<vw_PvTranferDetailDay>();
            if (list3.Any<vw_PvTranferDetailDay>())
              tranferDetailDayList.AddRange((IEnumerable<vw_PvTranferDetailDay>) list3);
          }
        }
      }
    }

    private void btnTimKiem_Click(object sender, EventArgs e) => this.LoadData();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    private void btnExportExcel_Click(object sender, EventArgs e)
    {
      try
      {
        new Helpper().ExportExcelWithHeader(true, (IPrintable) this.gridControl1, true, true, "BÁO CÁO TỔNG VẬT TƯ", new List<string>()
        {
          string.Format("Từ ngày: {0} - đến ngày: {1}", (object) FormatToString.DateTimeToString(this.datFromDate.DateTime), (object) FormatToString.DateTimeToString(this.datToDate.DateTime))
        });
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.ToString());
      }
    }

    
  }
}

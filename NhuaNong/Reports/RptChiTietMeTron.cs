// Decompiled with JetBrains decompiler
// Type: NhuaNong.Reports.RptChiTietMeTron
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
using NhuaNong.ServiceLibrary;
using NhuaNong.Data;
using NhuaNong.MasterData;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.Reports
{
  public partial class RptChiTietMeTron : ControlViewBase, IDataMixMngView, IBase, IPermission
  {
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private DataMixMngDataPresenter _presenter;
    public BindingList<Objvw_DataMix> _blstDataMix = new BindingList<Objvw_DataMix>();
    public BindingList<ObjKhachHang> _blstKH = new BindingList<ObjKhachHang>();
    public BindingList<ObjCongTruong> _blstCT = new BindingList<ObjCongTruong>();
    public BindingList<ObjHangMuc> _blstHM = new BindingList<ObjHangMuc>();
    public BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    public BindingList<ObjXe> _blstXe = new BindingList<ObjXe>();
    public BindingList<ObjTaiXe> _blstTX = new BindingList<ObjTaiXe>();
    public BindingList<ObjNhanVien> _blstNV = new BindingList<ObjNhanVien>();
    

    public BindingList<Objvw_DataMix> BLstDataMix
    {
      set
      {
        this._blstDataMix = value;
        this.gridControl1.DataSource = (object) this._blstDataMix;
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
      set
      {
        this._blstNV = value;
        this.lueNhanVien.Properties.DataSource = (object) this._blstNV;
      }
    }

    public List<FieldCode> LstDataMixStatus
    {
      set => throw new NotImplementedException();
    }

    public BindingList<ObjSilo> BLstSilo
    {
      set => throw new NotImplementedException();
    }

    public RptChiTietMeTron()
    {
      this.InitializeComponent();
      this.Name = nameof(RptChiTietMeTron);
      this._presenter = new DataMixMngDataPresenter((IDataMixMngView) this);
      this.Caption = "Mẻ trộn chi tiết";
      this._presenter.ListKhachHang();
      this._presenter.ListCongTruong();
      this._presenter.ListHangMuc();
      this._presenter.ListMAC();
      this._presenter.ListXe();
      this._presenter.ListTaiXe();
      this._presenter.ListNhanVien();
    }

    protected override void PopulateStaticData()
    {
      this.lueCheDo.Properties.DataSource = (object) Converter.EnumToListFieldCode<Enums.SimMode>(true);
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

    private void LoadDataMix()
    {
      try
      {
        if (Convert.ToInt32(this.lueCheDo.EditValue) == 1)
          return;
        Convert.ToInt32(this.lueCheDo.EditValue);
      }
      catch (System.Exception ex)
      {
        int num = (int) MessageBox.Show(ex.Message);
      }
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) string.Empty;
      this.datToDate.EditValue = (object) DateTime.Now;
      this.txtMaPhieuTron.Text = string.Empty;
      this.lueKhachHang.EditValue = (object) null;
      this.lueCongTruong.EditValue = (object) null;
      this.lueHangMuc.EditValue = (object) null;
      this.lueMAC.EditValue = (object) null;
      this.lueBienSo.EditValue = (object) null;
      this.lueTaiXe.EditValue = (object) null;
      this.lueNhanVien.EditValue = (object) null;
      this.lueCheDo.EditValue = (object) -1;
    }

    protected override void PopulateData() => this.LoadDataMix();

    private void btnSearch_Click(object sender, EventArgs e) => this.LoadDataMix();

    private void btnReset_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();

    
  }
}

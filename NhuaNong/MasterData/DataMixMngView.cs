// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.DataMixMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.ServiceLibrary;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class DataMixMngView : ControlViewBase, IDataMixMngView, IBase, IPermission
  {
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    private DataMixMngDataPresenter _presenter;
    public BindingList<Objvw_DataMix> _blstDataMix = new BindingList<Objvw_DataMix>();
    

    public BindingList<Objvw_DataMix> BLstDataMix
    {
      set
      {
        this._blstDataMix = value;
        this.grcDataMix.DataSource = (object) this._ser.ListDataMix();
      }
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
      set => throw new NotImplementedException();
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

    public BindingList<ObjSilo> BLstSilo
    {
      set => throw new NotImplementedException();
    }

    public DataMixMngView()
    {
      this.InitializeComponent();
      //this._presenter = new DataMixMngDataPresenter((IDataMixMngView)this);
      //this._presenter.ListDataMix();
      //this.Caption = "Data Mix";
      //this.Load += new EventHandler(this.DataMixMngView_Load);
      this.Name = nameof(DataMixMngView);
    }

    private void DataMixMngView_Load(object sender, EventArgs e)
    {
      //// 1. Khai báo ComponentResourceManager ở đây
      //ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DataMixMngView));
      //// 2. Dán dòng code tải tài nguyên đã xóa từ InitializeComponent vào đây
      //this.simpleButton2.ImageOptions.Image = (Image)componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");
      // 3. Gọi phương thức khởi tạo của presenter và các thiết lập khác ở đây.
      // Không cần gọi lại trong InitializeComponent, vì lúc này đã được gọi trong constructor hoặc trong sự kiện Load như ở bên dưới (đã được Comment out).
      this._presenter = new DataMixMngDataPresenter((IDataMixMngView)this);
      this._presenter.ListDataMix();
      this.Caption = "Data Mix";
    }

    protected override void PopulateStaticData()
    {
      this.LoadSearchDefaultValues();
      this.gcMaPhieuTron.Visible = false;
    }

    protected override void PopulateData()
    {
    }

    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = (object) null;
      this.datToDate.EditValue = (object) Searching.Build_EndDateTime(DateTime.Now);
      this.txtMaPT.Text = string.Empty;
    }

    private void LoadDataMix()
    {
      this.grcDataMix.DataSource = (object) this._ser.ListDataMix_ByCondition(new DateTime?(Searching.Build_StartDateTime(this.datFromDate.DateTime)), new DateTime?(Searching.Build_StartDateTime(this.datToDate.DateTime)), this.txtMaPT.Text, "Nam Dai Phat", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
    }

    private void simpleButton1_Click_1(object sender, EventArgs e) => this.LoadDataMix();

    private void simpleButton3_Click(object sender, EventArgs e) => this.LoadSearchDefaultValues();
  }
}

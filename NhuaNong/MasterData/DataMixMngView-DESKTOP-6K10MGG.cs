using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.ClientSetting;
using NhuaNong.Data;
using NhuaNong.Utils;

namespace NhuaNong.MasterData
{
  // Token: 0x02000094 RID: 148
  public partial class DataMixMngView : ControlViewBase, IDataMixMngView, IBase, IPermission
  {
    // Token: 0x17000268 RID: 616
    // (set) Token: 0x060008D6 RID: 2262 RVA: 0x00052096 File Offset: 0x00050296
    public BindingList<Objvw_DataMix> BLstDataMix
    {
      set
      {
        this._blstDataMix = value;
        this.grcDataMix.DataSource = this._ser.ListDataMix();
      }
    }

    // Token: 0x17000269 RID: 617
    // (set) Token: 0x060008D7 RID: 2263 RVA: 0x000049F1 File Offset: 0x00002BF1
    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set
      {
        throw new NotImplementedException();
      }
    }

    // Token: 0x1700026A RID: 618
    // (set) Token: 0x060008D8 RID: 2264 RVA: 0x000049F1 File Offset: 0x00002BF1
    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set
      {
        throw new NotImplementedException();
      }
    }

    // Token: 0x1700026B RID: 619
    // (set) Token: 0x060008D9 RID: 2265 RVA: 0x000049F1 File Offset: 0x00002BF1
    public BindingList<ObjHangMuc> BLstHangMuc
    {
      set
      {
        throw new NotImplementedException();
      }
    }

    // Token: 0x1700026C RID: 620
    // (set) Token: 0x060008DA RID: 2266 RVA: 0x000049F1 File Offset: 0x00002BF1
    public BindingList<ObjMAC> BLstMAC
    {
      set
      {
        throw new NotImplementedException();
      }
    }

    // Token: 0x1700026D RID: 621
    // (set) Token: 0x060008DB RID: 2267 RVA: 0x000049F1 File Offset: 0x00002BF1
    public BindingList<ObjXe> BLstXe
    {
      set
      {
        throw new NotImplementedException();
      }
    }

    // Token: 0x1700026E RID: 622
    // (set) Token: 0x060008DC RID: 2268 RVA: 0x000049F1 File Offset: 0x00002BF1
    public BindingList<ObjTaiXe> BLstTaiXe
    {
      set
      {
        throw new NotImplementedException();
      }
    }

    // Token: 0x1700026F RID: 623
    // (set) Token: 0x060008DD RID: 2269 RVA: 0x000049F1 File Offset: 0x00002BF1
    public BindingList<ObjNhanVien> BLstNhanVien
    {
      set
      {
        throw new NotImplementedException();
      }
    }

    // Token: 0x17000270 RID: 624
    // (set) Token: 0x060008DE RID: 2270 RVA: 0x000049F1 File Offset: 0x00002BF1
    public List<FieldCode> LstDataMixStatus
    {
      set
      {
        throw new NotImplementedException();
      }
    }

    // Token: 0x17000271 RID: 625
    // (set) Token: 0x060008DF RID: 2271 RVA: 0x000049F1 File Offset: 0x00002BF1
    public BindingList<ObjSilo> BLstSilo
    {
      set
      {
        throw new NotImplementedException();
      }
    }

    // Token: 0x060008E0 RID: 2272 RVA: 0x000520B8 File Offset: 0x000502B8

    private void DataMixMngView_Load(object sender, EventArgs e)
    {
      // 1. Khai báo resource manager ở đây
      //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpperExport));
      //ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DataMixMngView));
      //global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::NhuaNong.MasterData.DataMixMngView));
      //System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(DataMixMngView));
      // 2. Dán dòng code tải tài nguyên đã xóa từ InitializeComponent vào đây
      //this.printableComponentLink.ImageCollection.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("printableComponentLink.ImageCollection.ImageStream");
      //this.simpleButton2.ImageOptions.Image = (Image)componentResourceManager.GetObject("simpleButton2.ImageOptions.Image");

      //this._ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
      this._presenter = new DataMixMngDataPresenter(this);
      this._presenter.ListDataMix();
      base.Caption = "Data Mix";
    }

    public DataMixMngView()
    {
      this.InitializeComponent();
      //this.Load += new System.EventHandler(this.DataMixMngView_Load); // <-- Thêm dòng này
      //this._presenter = new DataMixMngDataPresenter(this);
      //this._presenter.ListDataMix();
      //base.Caption = "Data Mix";
      // Chỉ chạy các đoạn code logic khi chương trình được thực thi,
      // không chạy khi đang mở bằng trình thiết kế của Visual Studio.
      //if (!this.DesignMode)
      //{
      //  // Di chuyển việc khởi tạo vào đây
      //  //this._ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
      //  this._presenter = new DataMixMngDataPresenter(this);
      //  this._presenter.ListDataMix();
      //  base.Caption = "Data Mix";
      //}
    }

    // Token: 0x060008E1 RID: 2273 RVA: 0x00052113 File Offset: 0x00050313
    protected override void PopulateStaticData()
    {
      this.LoadSearchDefaultValues();
      this.gcMaPhieuTron.Visible = false;
    }

    // Token: 0x060008E2 RID: 2274 RVA: 0x0000235E File Offset: 0x0000055E
    protected override void PopulateData()
    {
    }

    // Token: 0x060008E3 RID: 2275 RVA: 0x00052127 File Offset: 0x00050327
    private void LoadSearchDefaultValues()
    {
      this.datFromDate.EditValue = null;
      this.datToDate.EditValue = Searching.Build_EndDateTime(DateTime.Now);
      this.txtMaPT.Text = string.Empty;
    }

    // Token: 0x060008E4 RID: 2276 RVA: 0x00052160 File Offset: 0x00050360
    private void LoadDataMix()
    {
      DateTime? fromDate = new DateTime?(Searching.Build_StartDateTime(this.datFromDate.DateTime));
      DateTime? toDate = new DateTime?(Searching.Build_StartDateTime(this.datToDate.DateTime));
      this.grcDataMix.DataSource = this._ser.ListDataMix_ByCondition(fromDate, toDate, this.txtMaPT.Text, "Nam Dai Phat", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
    }

    // Token: 0x060008E5 RID: 2277 RVA: 0x000521E1 File Offset: 0x000503E1
    private void simpleButton1_Click_1(object sender, EventArgs e)
    {
      this.LoadDataMix();
    }

    // Token: 0x060008E6 RID: 2278 RVA: 0x000521E9 File Offset: 0x000503E9
    private void simpleButton3_Click(object sender, EventArgs e)
    {
      this.LoadSearchDefaultValues();
    }



    // Token: 0x04000683 RID: 1667
    private IServices _ser = ServiceFactories.GetFactory(ConfigManager.TramTronConfig.RunningMode);
    //private IServices _ser; // Chỉ khai báo, không khởi tạo ở đây

    // Token: 0x04000684 RID: 1668
    private DataMixMngDataPresenter _presenter;

    // Token: 0x04000685 RID: 1669
    public BindingList<Objvw_DataMix> _blstDataMix = new BindingList<Objvw_DataMix>();
  }
}

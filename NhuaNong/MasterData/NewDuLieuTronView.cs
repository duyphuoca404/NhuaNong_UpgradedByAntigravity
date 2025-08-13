// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewDuLieuTronView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewDuLieuTronView : ControlViewBase, INewHopDongView, IBase
  {
    private NewHopDongDataPresenter _presenter;
    private bool _editKLOnly;
    private bool _CanAddMAC;
    private bool _CanEditMAC;
    private bool _CanViewMAC;
    private string _NewDLTCaption = "Thêm Dữ liệu trộn";
    private string _EditDLTCaption = "Sửa Dữ liệu trộn";
    private string _ViewDLTCaption = "Xem Dữ liệu trộn";
    private ObjHopDong _hd;
    private BindingList<ObjKhachHang> _blstKhachHang = new BindingList<ObjKhachHang>();
    private BindingList<ObjCongTruong> _blstCongTruong = new BindingList<ObjCongTruong>();
    private BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    private BindingList<ObjHangMuc> _blstHangMuc = new BindingList<ObjHangMuc>();
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl pnlCommand;
    private LabelControl lblMAC;
    private LabelControl lblJobsite;
    private LabelControl lblCustomer;
    private LabelControl lblUpdateDate;
    private LabelControl lblCreationDate;
    private LabelControl lblMaDLT;
    private LabelControl lblKLTronLonNhat;
    private LabelControl lblKLTronNhoNhat;
    private LabelControl lblKLCanTron;
    private LabelControl lblDLT;
    private LabelControl labelControl1;
    private LabelControl lblKLMoiMe;
    private LabelControl lblSLMe;
    private LabelControl lblTongGiaTriSilo;
    private TextEdit txtMoTaDLT;
    private SpinEdit spnNoPhieu;
    private SpinEdit spnKLDTMeTron;
    private SpinEdit spnMACSUMSiloValueCalc;
    private SpinEdit spnKLDuTinh;
    private SpinEdit spnMTQty;
    private SpinEdit spnMaxKLTron;
    private SpinEdit spnMinKLTron;
    private GridLookUpEdit gluMAC;
    private GridView gridView2;
    private GridLookUpEdit gluCongTruong;
    private GridView gridView1;
    private DateEdit datLatestUpdateDate;
    private DateEdit datNgayDLT;
    private TextEdit txtMaDLT;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private GridLookUpEdit gluKhachHang;
    private GridView gridView3;
    private GridColumn gcMaKhachHang;
    private GridColumn gcTenKhachHang;
    private GridColumn gcCongTruongID;
    private GridColumn gcMaCongTruong;
    private GridColumn gcTenCongTruong;
    private GridColumn gcKhachHangID;
    private GridColumn gcMACID;
    private GridColumn gcMaMAC;
    private GridColumn gcTenMAC;
    private GridLookUpEdit gluHangMuc;
    private GridView gridView4;
    private GridColumn gridColumn1;
    private GridColumn gridColumn2;
    private GridColumn gridColumn3;
    private LabelControl lblHangMuc;

    private bool IsSaveClose { get; set; }

    public bool CanAddMAC
    {
      get => this._CanAddMAC;
      set => this._CanAddMAC = value;
    }

    public bool CanEditMAC
    {
      get => this._CanEditMAC;
      set => this._CanEditMAC = value;
    }

    public bool CanViewMAC
    {
      get => this._CanViewMAC;
      set => this._CanViewMAC = value;
    }

    public ObjHopDong HopDong
    {
      set => this._hd = value;
    }

    public BindingList<ObjKhachHang> BLstKhachHang
    {
      set
      {
        this._blstKhachHang = value;
        this.gluKhachHang.Properties.DataSource = (object) this._blstKhachHang;
      }
    }

    public BindingList<ObjCongTruong> BLstCongTruong
    {
      set
      {
        this._blstCongTruong = value;
        this.gluCongTruong.Properties.DataSource = (object) this._blstCongTruong;
      }
    }

    public BindingList<ObjMAC> BLstMAC
    {
      set
      {
        this._blstMAC = value;
        this.gluMAC.Properties.DataSource = (object) this._blstMAC;
      }
    }

    public BindingList<ObjHangMuc> BLstHangMuc
    {
      set
      {
        this._blstHangMuc = value;
        this.gluHangMuc.Properties.DataSource = (object) this._blstHangMuc;
      }
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public int SLMeDuTinh
    {
      set => this.spnMTQty.Value = (Decimal) value;
    }

    public Decimal KLDuTinhMeTron
    {
      set
      {
        this.spnKLDTMeTron.Value = value;
        Decimal? dltKlDuTinh = this._hd.DLT_KLDuTinh;
        Decimal num1 = Math.Round(this._hd.DLT_KLDuTinhCuaTungMe.Value, 2);
        Decimal? dltSlMeDuTinh = this._hd.DLT_SLMeDuTinh;
        Decimal? nullable = dltSlMeDuTinh.HasValue ? new Decimal?(num1 * dltSlMeDuTinh.GetValueOrDefault()) : new Decimal?();
        Decimal num2 = (dltKlDuTinh.HasValue & nullable.HasValue ? new Decimal?(dltKlDuTinh.GetValueOrDefault() - nullable.GetValueOrDefault()) : new Decimal?()).Value;
      }
    }

    public NewDuLieuTronView()
    {
      this.InitializeComponent();
      this._presenter = new NewHopDongDataPresenter((INewHopDongView) this);
    }

    public NewDuLieuTronView(ObjHopDong ct, Enums.FormAction action, bool editKLOnly = false)
      : this()
    {
      this._hd = ct;
      this._editKLOnly = editKLOnly;
      this.FormAction = action;
      this.SetCaption();
    }

    protected override void PopulateStaticData()
    {
      this._presenter.ListKhachHang();
      this._presenter.ListCongTruong();
      this._presenter.ListMAC();
      this._presenter.ListHangMuc();
    }

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewHopDong();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetHopDongByKey(this._hd.HopDongID);
          break;
        case Enums.FormAction.View:
          this.gluKhachHang.Properties.ReadOnly = true;
          this.gluCongTruong.Properties.ReadOnly = true;
          this.gluMAC.Properties.ReadOnly = true;
          this.gluHangMuc.Properties.ReadOnly = true;
          this.spnMaxKLTron.Properties.ReadOnly = true;
          this.spnKLDuTinh.Properties.ReadOnly = true;
          this.txtMoTaDLT.Properties.ReadOnly = true;
          this.spnNoPhieu.Properties.ReadOnly = true;
          this.btnSave.Enabled = false;
          this._presenter.GetHopDongByKey(this._hd.HopDongID);
          break;
      }
    }

    protected override void BindData()
    {
      try
      {
        this.txtMaDLT.DataBindings.Clear();
        this.txtMaDLT.DataBindings.Add("Text", (object) this._hd, "MaHopDong");
        this.txtMoTaDLT.DataBindings.Clear();
        this.txtMoTaDLT.DataBindings.Add("Text", (object) this._hd, "TenHopDong");
        this.datNgayDLT.DataBindings.Clear();
        this.datNgayDLT.DataBindings.Add("DateTime", (object) this._hd, "NgayHopDong");
        if (this._hd.HopDongID > 0)
        {
          if (!this._hd.LatestUpdateDate.HasValue)
          {
            this.datLatestUpdateDate.DataBindings.Clear();
            this.datLatestUpdateDate.EditValue = (object) DateTime.MinValue;
          }
          else
          {
            this.datLatestUpdateDate.DataBindings.Clear();
            this.datLatestUpdateDate.DataBindings.Add("DateTime", (object) this._hd, "LatestUpdateDate");
          }
        }
        this.gluKhachHang.DataBindings.Clear();
        this.gluKhachHang.DataBindings.Add("EditValue", (object) this._hd, "KhachHangID");
        this.gluCongTruong.DataBindings.Clear();
        this.gluCongTruong.DataBindings.Add("EditValue", (object) this._hd, "CongTruongID");
        this.gluMAC.DataBindings.Clear();
        this.gluMAC.DataBindings.Add("EditValue", (object) this._hd, "MACID");
        this.gluHangMuc.DataBindings.Clear();
        this.gluHangMuc.DataBindings.Add("EditValue", (object) this._hd, "HangMucID");
        this.spnKLDuTinh.DataBindings.Clear();
        this.spnKLDuTinh.DataBindings.Add("EditValue", (object) this._hd, "DLT_KLDuTinh");
        this.spnKLDTMeTron.DataBindings.Clear();
        this.spnKLDTMeTron.DataBindings.Add("EditValue", (object) this._hd, "DLT_KLDuTinhCuaTungMe");
        this.spnMTQty.DataBindings.Clear();
        this.spnMTQty.DataBindings.Add("EditValue", (object) this._hd, "DLT_SLMeDuTinh");
        this.spnMinKLTron.DataBindings.Clear();
        this.spnMinKLTron.DataBindings.Add("EditValue", (object) this._hd, "DLT_KLTronNhoNhat");
        this.spnMaxKLTron.DataBindings.Clear();
        this.spnMaxKLTron.DataBindings.Add("EditValue", (object) this._hd, "DLT_KLTronLonNhat");
        this.spnNoPhieu.DataBindings.Clear();
        this.spnNoPhieu.DataBindings.Add("EditValue", (object) this._hd, "NoPhieu");
        this.spnMACSUMSiloValueCalc.DataBindings.Clear();
        this.spnMACSUMSiloValueCalc.DataBindings.Add("EditValue", (object) this._hd, "DLT_MACSUMSiloValueCalc");
      }
      catch (System.Exception ex)
      {
        TramTronLogger.WriteError(ex);
        TramTromMessageBox.ShowDEPErrorDialog(ex);
      }
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewDLTCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditDLTCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewDLTCaption;
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaDLT.Text == string.Empty)
      {
        this.txtMaDLT.ErrorText = "Mã Hợp Đồng is required.";
        flag = false;
      }
      if (this.txtMoTaDLT.Text == string.Empty)
      {
        this.txtMoTaDLT.ErrorText = "Tên Hợp Đồng is required.";
        flag = false;
      }
      if (this.gluKhachHang.EditValue == DBNull.Value)
      {
        this.gluKhachHang.ErrorText = "Khách Hàng is required.";
        flag = false;
      }
      if (this.gluCongTruong.EditValue == DBNull.Value)
      {
        this.gluCongTruong.ErrorText = "Công Trường is required.";
        flag = false;
      }
      if (this.gluMAC.EditValue == DBNull.Value)
      {
        this.gluMAC.ErrorText = "MAC is required.";
        flag = false;
      }
      if (this.spnKLDuTinh.Value <= 0M)
      {
        this.spnKLDuTinh.ErrorText = "Nhập khối lượng cần trộn.";
        flag = false;
      }
      return flag;
    }

    private void DisableConstrol()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.btnSave.Visible = true;
          break;
        case Enums.FormAction.Edit:
          this.btnSave.Visible = true;
          break;
        case Enums.FormAction.View:
          this.gluKhachHang.Properties.ReadOnly = true;
          this.gluKhachHang.Properties.Buttons.Clear();
          this.gluCongTruong.Properties.ReadOnly = true;
          this.gluCongTruong.Properties.Buttons.Clear();
          this.gluMAC.Properties.ReadOnly = true;
          this.gluMAC.Properties.Buttons.Clear();
          this.gluHangMuc.Properties.ReadOnly = true;
          this.gluHangMuc.Properties.Buttons.Clear();
          this.spnMaxKLTron.Properties.ReadOnly = true;
          this.spnNoPhieu.Properties.ReadOnly = true;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      this._presenter.SaveHopDong(this._hd);
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      TramTromMessageBox.ShowMessageDialog(GlobalValues.Messages.SuccessProceed);
      this._dlgRes = DialogResult.OK;
      if (this.IsSaveClose)
      {
        this.Close();
      }
      else
      {
        this._presenter.BuildNewHopDong();
        this.BindData();
      }
    }

    private void GenerateDienGiai()
    {
      string str1 = " - ";
      string str2 = string.Empty;
      if (this._hd.KhachHangID.HasValue)
        str2 = str2 + str1 + this.gluKhachHang.Text;
      int? nullable = this._hd.CongTruongID;
      if (nullable.HasValue)
        str2 = str2 + str1 + this.gluCongTruong.Text;
      nullable = this._hd.MACID;
      if (nullable.HasValue)
        str2 = str2 + str1 + this.gluMAC.Text;
      nullable = this._hd.HangMucID;
      if (nullable.HasValue)
        str2 = str2 + str1 + this.gluHangMuc.Text;
      if (str2 != string.Empty)
        str2 = str2.Substring(str1.Length, str2.Length - str1.Length);
      this._hd.TenHopDong = this.txtMoTaDLT.Text = str2;
    }

    public ObjHopDong GetSavedHopDong() => this._hd;

    private void gluKhachHang_EditValueChanged(object sender, EventArgs e)
    {
      if (this.gluKhachHang.EditValue != DBNull.Value)
        this._hd.KhachHangID = new int?(Convert.ToInt32(this.gluKhachHang.EditValue));
      this.GenerateDienGiai();
    }

    private void gluCongTruong_EditValueChanged(object sender, EventArgs e)
    {
      if (this.gluCongTruong.EditValue != DBNull.Value)
        this._hd.CongTruongID = new int?(Convert.ToInt32(this.gluCongTruong.EditValue));
      this.GenerateDienGiai();
    }

    private void spnMaxKLTron_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.DLT_KLTronLonNhat = new Decimal?(this.spnMaxKLTron.Value);
      NewHopDongDataPresenter presenter1 = this._presenter;
      Decimal num1 = this._hd.DLT_KLDuTinh.Value;
      Decimal num2 = this._hd.DLT_KLTronLonNhat.Value;
      Decimal klDuTinh1 = num1;
      Decimal maxKLTron = num2;
      presenter1.GetSLMeDuTinh(klDuTinh1, maxKLTron);
      NewHopDongDataPresenter presenter2 = this._presenter;
      Decimal num3 = this._hd.DLT_KLDuTinh.Value;
      int num4 = (int) this._hd.DLT_SLMeDuTinh.Value;
      Decimal klDuTinh2 = num3;
      int slMeDuTinh = num4;
      presenter2.GetKLDuTinhMeTron(klDuTinh2, slMeDuTinh);
    }

    private void spnKLDuTinh_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.DLT_KLDuTinh = new Decimal?(this.spnKLDuTinh.Value);
      NewHopDongDataPresenter presenter1 = this._presenter;
      Decimal num1 = this._hd.DLT_KLDuTinh.Value;
      Decimal num2 = this._hd.DLT_KLTronLonNhat.Value;
      Decimal klDuTinh1 = num1;
      Decimal maxKLTron = num2;
      presenter1.GetSLMeDuTinh(klDuTinh1, maxKLTron);
      NewHopDongDataPresenter presenter2 = this._presenter;
      Decimal num3 = this._hd.DLT_KLDuTinh.Value;
      int num4 = (int) this._hd.DLT_SLMeDuTinh.Value;
      Decimal klDuTinh2 = num3;
      int slMeDuTinh = num4;
      presenter2.GetKLDuTinhMeTron(klDuTinh2, slMeDuTinh);
      this.CalcMACSUMSiloValue();
    }

    private void CalcMACSUMSiloValue()
    {
      ObjMAC objMac = this._blstMAC.Where<ObjMAC>((Func<ObjMAC, bool>) (o =>
      {
        int macid1 = o.MACID;
        int? macid2 = this._hd.MACID;
        int valueOrDefault = macid2.GetValueOrDefault();
        return macid1 == valueOrDefault & macid2.HasValue;
      })).FirstOrDefault<ObjMAC>();
      if (objMac != null)
      {
        this._hd.DLT_MACSUMSiloValue = objMac.NPSUMSiloValue;
        ObjHopDong hd = this._hd;
        Decimal? dltKlDuTinh = this._hd.DLT_KLDuTinh;
        Decimal? npsumSiloValue = objMac.NPSUMSiloValue;
        Decimal? nullable = dltKlDuTinh.HasValue & npsumSiloValue.HasValue ? new Decimal?(dltKlDuTinh.GetValueOrDefault() * npsumSiloValue.GetValueOrDefault()) : new Decimal?();
        hd.DLT_MACSUMSiloValueCalc = nullable;
        this.spnMACSUMSiloValueCalc.EditValue = (object) this._hd.DLT_MACSUMSiloValueCalc;
      }
      else
      {
        this._hd.DLT_MACSUMSiloValue = new Decimal?(0M);
        this._hd.DLT_MACSUMSiloValueCalc = new Decimal?(0M);
        this.spnMACSUMSiloValueCalc.EditValue = (object) 0;
      }
    }

    private void spnMTQty_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.DLT_SLMeDuTinh = new Decimal?(this.spnMTQty.Value);
    }

    private void spnKLDTMeTron_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.DLT_KLDuTinhCuaTungMe = new Decimal?(this.spnKLDTMeTron.Value);
    }

    private void spnKLBuTru_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.DLT_KLBuTruMeCuoi = new Decimal?(this.spnNoPhieu.Value);
    }

    private void gluMAC_EditValueChanged(object sender, EventArgs e)
    {
      if (this.gluMAC.EditValue != DBNull.Value)
        this._hd.MACID = new int?(Convert.ToInt32(this.gluMAC.EditValue));
      this.GenerateDienGiai();
      this.CalcMACSUMSiloValue();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = true;
      this.SaveData();
      TramTronLogger.WriteInfo(sender.ToString());
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    private void gluKhachHang_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Kind == ButtonPredefines.Plus)
      {
        NewKhachHangView ctrView = new NewKhachHangView((ObjKhachHang) null, Enums.FormAction.New);
        ViewManager.ShowViewDialog((ControlViewBase) ctrView);
        if (ctrView.GetDialogResult() == DialogResult.OK)
        {
          this._presenter.ListKhachHang();
          this.gluKhachHang.EditValue = (object) null;
        }
      }
      if (e.Button.Kind != ButtonPredefines.Ellipsis || this.gluKhachHang.EditValue == DBNull.Value)
        return;
      NewKhachHangView ctrView1 = new NewKhachHangView(this._presenter.GetKhachHangByKey(Convert.ToInt32(this.gluKhachHang.EditValue)), Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView1);
      if (ctrView1.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListKhachHang();
    }

    private void gluCongTruong_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Kind == ButtonPredefines.Plus)
      {
        NewCongTruongView ctrView = new NewCongTruongView((ObjCongTruong) null, Enums.FormAction.New);
        ViewManager.ShowViewDialog((ControlViewBase) ctrView);
        if (ctrView.GetDialogResult() == DialogResult.OK)
        {
          this._presenter.ListCongTruong();
          this.gluCongTruong.EditValue = (object) null;
        }
      }
      if (e.Button.Kind != ButtonPredefines.Ellipsis || this.gluCongTruong.EditValue == DBNull.Value)
        return;
      NewCongTruongView ctrView1 = new NewCongTruongView(this._presenter.GetCongTruongByKey(Convert.ToInt32(this.gluCongTruong.EditValue)), Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView1);
      if (ctrView1.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListCongTruong();
    }

    private void gluMAC_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Kind == ButtonPredefines.Plus)
      {
        NewMACView ctrView = new NewMACView((ObjMAC) null, Enums.FormAction.New);
        ViewManager.ShowViewDialog((ControlViewBase) ctrView);
        if (ctrView.GetDialogResult() == DialogResult.OK)
        {
          this._presenter.ListMAC();
          this.gluMAC.EditValue = (object) null;
        }
      }
      if (e.Button.Kind != ButtonPredefines.Ellipsis || this.gluMAC.EditValue == DBNull.Value)
        return;
      NewMACView ctrView1 = new NewMACView(this._presenter.GetMACByKey(Convert.ToInt32(this.gluMAC.EditValue)), Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView1);
      if (ctrView1.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListMAC();
    }

    private void gluHangMuc_EditValueChanged(object sender, EventArgs e)
    {
      if (this.gluHangMuc.EditValue != DBNull.Value)
        this._hd.HangMucID = new int?(Convert.ToInt32(this.gluHangMuc.EditValue));
      this.GenerateDienGiai();
    }

    private void gluHangMuc_ButtonPressed(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Kind == ButtonPredefines.Plus)
      {
        NewHangMucView ctrView = new NewHangMucView((ObjHangMuc) null, Enums.FormAction.New);
        ViewManager.ShowViewDialog((ControlViewBase) ctrView);
        if (ctrView.GetDialogResult() == DialogResult.OK)
        {
          this._presenter.ListHangMuc();
          this.gluHangMuc.EditValue = (object) null;
        }
      }
      if (e.Button.Kind != ButtonPredefines.Ellipsis || this.gluHangMuc.EditValue == DBNull.Value)
        return;
      NewHangMucView ctrView1 = new NewHangMucView(this._presenter.GetHangMucByKey(Convert.ToInt32(this.gluHangMuc.EditValue)), Enums.FormAction.Edit);
      ViewManager.ShowViewDialog((ControlViewBase) ctrView1);
      if (ctrView1.GetDialogResult() != DialogResult.OK)
        return;
      this._presenter.ListHangMuc();
    }

    private void spnNoPhieu_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.TongPhieu = new int?((int) this.spnNoPhieu.Value);
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      EditorButtonImageOptions imageOptions = new EditorButtonImageOptions();
      SerializableAppearanceObject appearance = new SerializableAppearanceObject();
      SerializableAppearanceObject appearanceHovered = new SerializableAppearanceObject();
      SerializableAppearanceObject appearancePressed = new SerializableAppearanceObject();
      SerializableAppearanceObject appearanceDisabled = new SerializableAppearanceObject();
      this.pnlMain = new PanelControl();
      this.gluHangMuc = new GridLookUpEdit();
      this.gridView4 = new GridView();
      this.gridColumn1 = new GridColumn();
      this.gridColumn2 = new GridColumn();
      this.gridColumn3 = new GridColumn();
      this.lblHangMuc = new LabelControl();
      this.gluKhachHang = new GridLookUpEdit();
      this.gridView3 = new GridView();
      this.gcKhachHangID = new GridColumn();
      this.gcMaKhachHang = new GridColumn();
      this.gcTenKhachHang = new GridColumn();
      this.txtMoTaDLT = new TextEdit();
      this.spnNoPhieu = new SpinEdit();
      this.spnKLDTMeTron = new SpinEdit();
      this.spnMACSUMSiloValueCalc = new SpinEdit();
      this.spnKLDuTinh = new SpinEdit();
      this.spnMTQty = new SpinEdit();
      this.spnMaxKLTron = new SpinEdit();
      this.spnMinKLTron = new SpinEdit();
      this.gluMAC = new GridLookUpEdit();
      this.gridView2 = new GridView();
      this.gcMACID = new GridColumn();
      this.gcMaMAC = new GridColumn();
      this.gcTenMAC = new GridColumn();
      this.gluCongTruong = new GridLookUpEdit();
      this.gridView1 = new GridView();
      this.gcCongTruongID = new GridColumn();
      this.gcMaCongTruong = new GridColumn();
      this.gcTenCongTruong = new GridColumn();
      this.datLatestUpdateDate = new DateEdit();
      this.datNgayDLT = new DateEdit();
      this.txtMaDLT = new TextEdit();
      this.lblDLT = new LabelControl();
      this.labelControl1 = new LabelControl();
      this.lblKLMoiMe = new LabelControl();
      this.lblSLMe = new LabelControl();
      this.lblTongGiaTriSilo = new LabelControl();
      this.lblKLCanTron = new LabelControl();
      this.lblKLTronLonNhat = new LabelControl();
      this.lblKLTronNhoNhat = new LabelControl();
      this.lblMAC = new LabelControl();
      this.lblJobsite = new LabelControl();
      this.lblCustomer = new LabelControl();
      this.lblUpdateDate = new LabelControl();
      this.lblCreationDate = new LabelControl();
      this.lblMaDLT = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.gluHangMuc.Properties.BeginInit();
      this.gridView4.BeginInit();
      this.gluKhachHang.Properties.BeginInit();
      this.gridView3.BeginInit();
      this.txtMoTaDLT.Properties.BeginInit();
      this.spnNoPhieu.Properties.BeginInit();
      this.spnKLDTMeTron.Properties.BeginInit();
      this.spnMACSUMSiloValueCalc.Properties.BeginInit();
      this.spnKLDuTinh.Properties.BeginInit();
      this.spnMTQty.Properties.BeginInit();
      this.spnMaxKLTron.Properties.BeginInit();
      this.spnMinKLTron.Properties.BeginInit();
      this.gluMAC.Properties.BeginInit();
      this.gridView2.BeginInit();
      this.gluCongTruong.Properties.BeginInit();
      this.gridView1.BeginInit();
      this.datLatestUpdateDate.Properties.CalendarTimeProperties.BeginInit();
      this.datLatestUpdateDate.Properties.BeginInit();
      this.datNgayDLT.Properties.CalendarTimeProperties.BeginInit();
      this.datNgayDLT.Properties.BeginInit();
      this.txtMaDLT.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.gluHangMuc);
      this.pnlMain.Controls.Add((Control) this.lblHangMuc);
      this.pnlMain.Controls.Add((Control) this.gluKhachHang);
      this.pnlMain.Controls.Add((Control) this.txtMoTaDLT);
      this.pnlMain.Controls.Add((Control) this.spnNoPhieu);
      this.pnlMain.Controls.Add((Control) this.spnKLDTMeTron);
      this.pnlMain.Controls.Add((Control) this.spnMACSUMSiloValueCalc);
      this.pnlMain.Controls.Add((Control) this.spnKLDuTinh);
      this.pnlMain.Controls.Add((Control) this.spnMTQty);
      this.pnlMain.Controls.Add((Control) this.spnMaxKLTron);
      this.pnlMain.Controls.Add((Control) this.spnMinKLTron);
      this.pnlMain.Controls.Add((Control) this.gluMAC);
      this.pnlMain.Controls.Add((Control) this.gluCongTruong);
      this.pnlMain.Controls.Add((Control) this.datLatestUpdateDate);
      this.pnlMain.Controls.Add((Control) this.datNgayDLT);
      this.pnlMain.Controls.Add((Control) this.txtMaDLT);
      this.pnlMain.Controls.Add((Control) this.lblDLT);
      this.pnlMain.Controls.Add((Control) this.labelControl1);
      this.pnlMain.Controls.Add((Control) this.lblKLMoiMe);
      this.pnlMain.Controls.Add((Control) this.lblSLMe);
      this.pnlMain.Controls.Add((Control) this.lblTongGiaTriSilo);
      this.pnlMain.Controls.Add((Control) this.lblKLCanTron);
      this.pnlMain.Controls.Add((Control) this.lblKLTronLonNhat);
      this.pnlMain.Controls.Add((Control) this.lblKLTronNhoNhat);
      this.pnlMain.Controls.Add((Control) this.lblMAC);
      this.pnlMain.Controls.Add((Control) this.lblJobsite);
      this.pnlMain.Controls.Add((Control) this.lblCustomer);
      this.pnlMain.Controls.Add((Control) this.lblUpdateDate);
      this.pnlMain.Controls.Add((Control) this.lblCreationDate);
      this.pnlMain.Controls.Add((Control) this.lblMaDLT);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(770, 272);
      this.pnlMain.TabIndex = 0;
      this.gluHangMuc.Location = new Point(488, 86);
      this.gluHangMuc.Margin = new Padding(2);
      this.gluHangMuc.Name = "gluHangMuc";
      this.gluHangMuc.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gluHangMuc.Properties.Appearance.Options.UseFont = true;
      this.gluHangMuc.Properties.Buttons.AddRange(new EditorButton[3]
      {
        new EditorButton(ButtonPredefines.Combo),
        new EditorButton(ButtonPredefines.Plus),
        new EditorButton()
      });
      this.gluHangMuc.Properties.DisplayMember = "TenHangMuc";
      this.gluHangMuc.Properties.ImmediatePopup = true;
      this.gluHangMuc.Properties.NullText = " ";
      this.gluHangMuc.Properties.PopupFilterMode = PopupFilterMode.Contains;
      this.gluHangMuc.Properties.PopupView = (ColumnView) this.gridView4;
      this.gluHangMuc.Properties.ShowFooter = false;
      this.gluHangMuc.Properties.TextEditStyle = TextEditStyles.Standard;
      this.gluHangMuc.Properties.ValueMember = "HangMucID";
      this.gluHangMuc.Size = new Size(260, 22);
      this.gluHangMuc.TabIndex = 31;
      this.gluHangMuc.ButtonPressed += new ButtonPressedEventHandler(this.gluHangMuc_ButtonPressed);
      this.gluHangMuc.EditValueChanged += new EventHandler(this.gluHangMuc_EditValueChanged);
      this.gridView4.Columns.AddRange(new GridColumn[3]
      {
        this.gridColumn1,
        this.gridColumn2,
        this.gridColumn3
      });
      this.gridView4.DetailHeight = 284;
      this.gridView4.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView4.Name = "gridView4";
      this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView4.OptionsView.ShowGroupPanel = false;
      this.gridColumn1.Caption = "HangMucID";
      this.gridColumn1.FieldName = "HangMucID";
      this.gridColumn1.MinWidth = 15;
      this.gridColumn1.Name = "gridColumn1";
      this.gridColumn1.Width = 56;
      this.gridColumn2.Caption = "Mã Hạng mục";
      this.gridColumn2.FieldName = "MaHangMuc";
      this.gridColumn2.MinWidth = 15;
      this.gridColumn2.Name = "gridColumn2";
      this.gridColumn2.Width = 56;
      this.gridColumn3.Caption = "Tên Hạng mục";
      this.gridColumn3.FieldName = "TenHangMuc";
      this.gridColumn3.MinWidth = 15;
      this.gridColumn3.Name = "gridColumn3";
      this.gridColumn3.Visible = true;
      this.gridColumn3.VisibleIndex = 0;
      this.gridColumn3.Width = 56;
      this.lblHangMuc.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblHangMuc.Appearance.Options.UseFont = true;
      this.lblHangMuc.Location = new Point(422, 89);
      this.lblHangMuc.Margin = new Padding(2);
      this.lblHangMuc.Name = "lblHangMuc";
      this.lblHangMuc.Size = new Size(57, 16);
      this.lblHangMuc.TabIndex = 30;
      this.lblHangMuc.Text = "Hạng mục";
      this.gluKhachHang.Location = new Point(129, 55);
      this.gluKhachHang.Margin = new Padding(2);
      this.gluKhachHang.Name = "gluKhachHang";
      this.gluKhachHang.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gluKhachHang.Properties.Appearance.Options.UseFont = true;
      this.gluKhachHang.Properties.Buttons.AddRange(new EditorButton[3]
      {
        new EditorButton(ButtonPredefines.Combo),
        new EditorButton(ButtonPredefines.Plus),
        new EditorButton()
      });
      this.gluKhachHang.Properties.ButtonsStyle = BorderStyles.NoBorder;
      this.gluKhachHang.Properties.DisplayMember = "TenKhachHang";
      this.gluKhachHang.Properties.ImmediatePopup = true;
      this.gluKhachHang.Properties.NullText = " ";
      this.gluKhachHang.Properties.PopupFilterMode = PopupFilterMode.Contains;
      this.gluKhachHang.Properties.PopupView = (ColumnView) this.gridView3;
      this.gluKhachHang.Properties.ShowFooter = false;
      this.gluKhachHang.Properties.TextEditStyle = TextEditStyles.Standard;
      this.gluKhachHang.Properties.ValueMember = "KhachHangID";
      this.gluKhachHang.Size = new Size(260, 22);
      this.gluKhachHang.TabIndex = 29;
      this.gluKhachHang.ButtonPressed += new ButtonPressedEventHandler(this.gluKhachHang_ButtonPressed);
      this.gluKhachHang.EditValueChanged += new EventHandler(this.gluKhachHang_EditValueChanged);
      this.gridView3.Columns.AddRange(new GridColumn[3]
      {
        this.gcKhachHangID,
        this.gcMaKhachHang,
        this.gcTenKhachHang
      });
      this.gridView3.DetailHeight = 284;
      this.gridView3.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView3.Name = "gridView3";
      this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView3.OptionsView.ShowGroupPanel = false;
      this.gcKhachHangID.Caption = "KhahcHangID";
      this.gcKhachHangID.FieldName = "KhachHangID";
      this.gcKhachHangID.MinWidth = 15;
      this.gcKhachHangID.Name = "gcKhachHangID";
      this.gcKhachHangID.Width = 56;
      this.gcMaKhachHang.Caption = "Mã Khách hàng";
      this.gcMaKhachHang.FieldName = "MaKhachHang";
      this.gcMaKhachHang.MinWidth = 15;
      this.gcMaKhachHang.Name = "gcMaKhachHang";
      this.gcMaKhachHang.Width = 56;
      this.gcTenKhachHang.Caption = "Tên Khách hàng";
      this.gcTenKhachHang.FieldName = "TenKhachHang";
      this.gcTenKhachHang.MinWidth = 15;
      this.gcTenKhachHang.Name = "gcTenKhachHang";
      this.gcTenKhachHang.Visible = true;
      this.gcTenKhachHang.VisibleIndex = 0;
      this.gcTenKhachHang.Width = 56;
      this.txtMoTaDLT.Location = new Point(129, 185);
      this.txtMoTaDLT.Margin = new Padding(2);
      this.txtMoTaDLT.Name = "txtMoTaDLT";
      this.txtMoTaDLT.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMoTaDLT.Properties.Appearance.Options.UseFont = true;
      this.txtMoTaDLT.Size = new Size(377, 22);
      this.txtMoTaDLT.TabIndex = 27;
      this.spnNoPhieu.EditValue = (object) new Decimal(new int[4]);
      this.spnNoPhieu.Location = new Point(628, 185);
      this.spnNoPhieu.Margin = new Padding(2);
      this.spnNoPhieu.Name = "spnNoPhieu";
      this.spnNoPhieu.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnNoPhieu.Properties.Appearance.Options.UseFont = true;
      this.spnNoPhieu.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnNoPhieu.Properties.DisplayFormat.FormatString = "n0";
      this.spnNoPhieu.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnNoPhieu.Properties.EditFormat.FormatString = "n0";
      this.spnNoPhieu.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnNoPhieu.Properties.Mask.EditMask = "n0";
      this.spnNoPhieu.Size = new Size(120, 22);
      this.spnNoPhieu.TabIndex = 26;
      this.spnNoPhieu.Visible = false;
      this.spnNoPhieu.EditValueChanged += new EventHandler(this.spnNoPhieu_EditValueChanged);
      this.spnKLDTMeTron.EditValue = (object) new Decimal(new int[4]);
      this.spnKLDTMeTron.Location = new Point(628, 152);
      this.spnKLDTMeTron.Margin = new Padding(2);
      this.spnKLDTMeTron.Name = "spnKLDTMeTron";
      this.spnKLDTMeTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLDTMeTron.Properties.Appearance.Options.UseFont = true;
      this.spnKLDTMeTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLDTMeTron.Properties.DisplayFormat.FormatString = "n2";
      this.spnKLDTMeTron.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnKLDTMeTron.Properties.EditFormat.FormatString = "n2";
      this.spnKLDTMeTron.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnKLDTMeTron.Properties.Mask.EditMask = "n2";
      this.spnKLDTMeTron.Properties.ReadOnly = true;
      this.spnKLDTMeTron.Size = new Size(120, 22);
      this.spnKLDTMeTron.TabIndex = 25;
      this.spnKLDTMeTron.EditValueChanged += new EventHandler(this.spnKLDTMeTron_EditValueChanged);
      this.spnMACSUMSiloValueCalc.EditValue = (object) new Decimal(new int[4]);
      this.spnMACSUMSiloValueCalc.Location = new Point(386, 152);
      this.spnMACSUMSiloValueCalc.Margin = new Padding(2);
      this.spnMACSUMSiloValueCalc.Name = "spnMACSUMSiloValueCalc";
      this.spnMACSUMSiloValueCalc.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnMACSUMSiloValueCalc.Properties.Appearance.Options.UseFont = true;
      this.spnMACSUMSiloValueCalc.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMACSUMSiloValueCalc.Properties.DisplayFormat.FormatString = "n2";
      this.spnMACSUMSiloValueCalc.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnMACSUMSiloValueCalc.Properties.EditFormat.FormatString = "n2";
      this.spnMACSUMSiloValueCalc.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnMACSUMSiloValueCalc.Properties.Mask.EditMask = "n2";
      this.spnMACSUMSiloValueCalc.Properties.ReadOnly = true;
      this.spnMACSUMSiloValueCalc.Size = new Size(120, 22);
      this.spnMACSUMSiloValueCalc.TabIndex = 24;
      this.spnKLDuTinh.EditValue = (object) new Decimal(new int[4]);
      this.spnKLDuTinh.Location = new Point(129, 152);
      this.spnKLDuTinh.Margin = new Padding(2);
      this.spnKLDuTinh.Name = "spnKLDuTinh";
      this.spnKLDuTinh.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.spnKLDuTinh.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLDuTinh.Properties.Appearance.Options.UseBackColor = true;
      this.spnKLDuTinh.Properties.Appearance.Options.UseFont = true;
      this.spnKLDuTinh.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLDuTinh.Properties.DisplayFormat.FormatString = "n2";
      this.spnKLDuTinh.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnKLDuTinh.Properties.EditFormat.FormatString = "n2";
      this.spnKLDuTinh.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnKLDuTinh.Properties.Mask.EditMask = "n2";
      this.spnKLDuTinh.Size = new Size(120, 22);
      this.spnKLDuTinh.TabIndex = 23;
      this.spnKLDuTinh.EditValueChanged += new EventHandler(this.spnKLDuTinh_EditValueChanged);
      this.spnMTQty.EditValue = (object) new Decimal(new int[4]);
      this.spnMTQty.Location = new Point(628, 120);
      this.spnMTQty.Margin = new Padding(2);
      this.spnMTQty.Name = "spnMTQty";
      this.spnMTQty.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnMTQty.Properties.Appearance.Options.UseFont = true;
      this.spnMTQty.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMTQty.Properties.DisplayFormat.FormatString = "n0";
      this.spnMTQty.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnMTQty.Properties.EditFormat.FormatString = "n0";
      this.spnMTQty.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnMTQty.Properties.Mask.EditMask = "n0";
      this.spnMTQty.Properties.ReadOnly = true;
      this.spnMTQty.Size = new Size(120, 22);
      this.spnMTQty.TabIndex = 22;
      this.spnMTQty.EditValueChanged += new EventHandler(this.spnMTQty_EditValueChanged);
      this.spnMaxKLTron.EditValue = (object) new Decimal(new int[4]);
      this.spnMaxKLTron.Location = new Point(386, 120);
      this.spnMaxKLTron.Margin = new Padding(2);
      this.spnMaxKLTron.Name = "spnMaxKLTron";
      this.spnMaxKLTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnMaxKLTron.Properties.Appearance.Options.UseFont = true;
      this.spnMaxKLTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMaxKLTron.Properties.DisplayFormat.FormatString = "n1";
      this.spnMaxKLTron.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnMaxKLTron.Properties.EditFormat.FormatString = "n1";
      this.spnMaxKLTron.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnMaxKLTron.Properties.Mask.EditMask = "n1";
      this.spnMaxKLTron.Size = new Size(120, 22);
      this.spnMaxKLTron.TabIndex = 21;
      this.spnMaxKLTron.EditValueChanged += new EventHandler(this.spnMaxKLTron_EditValueChanged);
      this.spnMinKLTron.EditValue = (object) new Decimal(new int[4]);
      this.spnMinKLTron.Location = new Point(129, 120);
      this.spnMinKLTron.Margin = new Padding(2);
      this.spnMinKLTron.Name = "spnMinKLTron";
      this.spnMinKLTron.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnMinKLTron.Properties.Appearance.Options.UseFont = true;
      this.spnMinKLTron.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnMinKLTron.Properties.DisplayFormat.FormatString = "n1";
      this.spnMinKLTron.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnMinKLTron.Properties.EditFormat.FormatString = "n1";
      this.spnMinKLTron.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnMinKLTron.Properties.Mask.EditMask = "n1";
      this.spnMinKLTron.Properties.ReadOnly = true;
      this.spnMinKLTron.Size = new Size(120, 22);
      this.spnMinKLTron.TabIndex = 20;
      this.gluMAC.Location = new Point(129, 87);
      this.gluMAC.Margin = new Padding(2);
      this.gluMAC.Name = "gluMAC";
      this.gluMAC.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gluMAC.Properties.Appearance.Options.UseFont = true;
      this.gluMAC.Properties.Buttons.AddRange(new EditorButton[3]
      {
        new EditorButton(ButtonPredefines.Combo),
        new EditorButton(ButtonPredefines.Plus, "AddMAC", -1, true, true, false, imageOptions, new KeyShortcut(Keys.None), (AppearanceObject) appearance, (AppearanceObject) appearanceHovered, (AppearanceObject) appearancePressed, (AppearanceObject) appearanceDisabled, "", (object) null, (SuperToolTip) null, ToolTipAnchor.Default),
        new EditorButton()
      });
      this.gluMAC.Properties.DisplayMember = "TenMAC";
      this.gluMAC.Properties.ImmediatePopup = true;
      this.gluMAC.Properties.NullText = " ";
      this.gluMAC.Properties.PopupFilterMode = PopupFilterMode.Contains;
      this.gluMAC.Properties.PopupView = (ColumnView) this.gridView2;
      this.gluMAC.Properties.ShowFooter = false;
      this.gluMAC.Properties.TextEditStyle = TextEditStyles.Standard;
      this.gluMAC.Properties.ValueMember = "MACID";
      this.gluMAC.Size = new Size(260, 22);
      this.gluMAC.TabIndex = 19;
      this.gluMAC.ButtonPressed += new ButtonPressedEventHandler(this.gluMAC_ButtonPressed);
      this.gluMAC.EditValueChanged += new EventHandler(this.gluMAC_EditValueChanged);
      this.gridView2.Columns.AddRange(new GridColumn[3]
      {
        this.gcMACID,
        this.gcMaMAC,
        this.gcTenMAC
      });
      this.gridView2.DetailHeight = 284;
      this.gridView2.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView2.Name = "gridView2";
      this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView2.OptionsView.ShowGroupPanel = false;
      this.gcMACID.Caption = "MACID";
      this.gcMACID.FieldName = "MACID";
      this.gcMACID.MinWidth = 15;
      this.gcMACID.Name = "gcMACID";
      this.gcMACID.Width = 56;
      this.gcMaMAC.Caption = "Mã MAC";
      this.gcMaMAC.FieldName = "MaMAC";
      this.gcMaMAC.MinWidth = 15;
      this.gcMaMAC.Name = "gcMaMAC";
      this.gcMaMAC.Width = 56;
      this.gcTenMAC.Caption = "Tên MAC";
      this.gcTenMAC.FieldName = "TenMAC";
      this.gcTenMAC.MinWidth = 15;
      this.gcTenMAC.Name = "gcTenMAC";
      this.gcTenMAC.Visible = true;
      this.gcTenMAC.VisibleIndex = 0;
      this.gcTenMAC.Width = 56;
      this.gluCongTruong.Location = new Point(488, 54);
      this.gluCongTruong.Margin = new Padding(2);
      this.gluCongTruong.Name = "gluCongTruong";
      this.gluCongTruong.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.gluCongTruong.Properties.Appearance.Options.UseFont = true;
      this.gluCongTruong.Properties.Buttons.AddRange(new EditorButton[3]
      {
        new EditorButton(ButtonPredefines.Combo),
        new EditorButton(ButtonPredefines.Plus),
        new EditorButton()
      });
      this.gluCongTruong.Properties.DisplayMember = "TenCongTruong";
      this.gluCongTruong.Properties.ImmediatePopup = true;
      this.gluCongTruong.Properties.NullText = " ";
      this.gluCongTruong.Properties.PopupFilterMode = PopupFilterMode.Contains;
      this.gluCongTruong.Properties.PopupView = (ColumnView) this.gridView1;
      this.gluCongTruong.Properties.ShowFooter = false;
      this.gluCongTruong.Properties.TextEditStyle = TextEditStyles.Standard;
      this.gluCongTruong.Properties.ValueMember = "CongTruongID";
      this.gluCongTruong.Size = new Size(260, 22);
      this.gluCongTruong.TabIndex = 18;
      this.gluCongTruong.ButtonPressed += new ButtonPressedEventHandler(this.gluCongTruong_ButtonPressed);
      this.gluCongTruong.EditValueChanged += new EventHandler(this.gluCongTruong_EditValueChanged);
      this.gridView1.Columns.AddRange(new GridColumn[3]
      {
        this.gcCongTruongID,
        this.gcMaCongTruong,
        this.gcTenCongTruong
      });
      this.gridView1.DetailHeight = 284;
      this.gridView1.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gcCongTruongID.Caption = "CongTruongID";
      this.gcCongTruongID.FieldName = "CongTruongID";
      this.gcCongTruongID.MinWidth = 15;
      this.gcCongTruongID.Name = "gcCongTruongID";
      this.gcCongTruongID.Width = 56;
      this.gcMaCongTruong.Caption = "Mã Công trường";
      this.gcMaCongTruong.FieldName = "MaCongTruong";
      this.gcMaCongTruong.MinWidth = 15;
      this.gcMaCongTruong.Name = "gcMaCongTruong";
      this.gcMaCongTruong.Width = 56;
      this.gcTenCongTruong.Caption = "Tên Công trường";
      this.gcTenCongTruong.FieldName = "TenCongTruong";
      this.gcTenCongTruong.MinWidth = 15;
      this.gcTenCongTruong.Name = "gcTenCongTruong";
      this.gcTenCongTruong.Visible = true;
      this.gcTenCongTruong.VisibleIndex = 0;
      this.gcTenCongTruong.Width = 56;
      this.datLatestUpdateDate.EditValue = (object) null;
      this.datLatestUpdateDate.Location = new Point(588, 25);
      this.datLatestUpdateDate.Margin = new Padding(2);
      this.datLatestUpdateDate.Name = "datLatestUpdateDate";
      this.datLatestUpdateDate.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datLatestUpdateDate.Properties.Appearance.Options.UseFont = true;
      this.datLatestUpdateDate.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datLatestUpdateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datLatestUpdateDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
      this.datLatestUpdateDate.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datLatestUpdateDate.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
      this.datLatestUpdateDate.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datLatestUpdateDate.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
      this.datLatestUpdateDate.Size = new Size(160, 22);
      this.datLatestUpdateDate.TabIndex = 16;
      this.datNgayDLT.EditValue = (object) null;
      this.datNgayDLT.Location = new Point(316, 26);
      this.datNgayDLT.Margin = new Padding(2);
      this.datNgayDLT.Name = "datNgayDLT";
      this.datNgayDLT.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datNgayDLT.Properties.Appearance.Options.UseFont = true;
      this.datNgayDLT.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayDLT.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayDLT.Properties.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
      this.datNgayDLT.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datNgayDLT.Properties.EditFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
      this.datNgayDLT.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datNgayDLT.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
      this.datNgayDLT.Size = new Size(160, 22);
      this.datNgayDLT.TabIndex = 15;
      this.txtMaDLT.Location = new Point(129, 26);
      this.txtMaDLT.Margin = new Padding(2);
      this.txtMaDLT.Name = "txtMaDLT";
      this.txtMaDLT.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaDLT.Properties.Appearance.Options.UseFont = true;
      this.txtMaDLT.Properties.ReadOnly = true;
      this.txtMaDLT.Size = new Size(107, 22);
      this.txtMaDLT.TabIndex = 14;
      this.lblDLT.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblDLT.Appearance.Options.UseFont = true;
      this.lblDLT.Location = new Point(25, 188);
      this.lblDLT.Margin = new Padding(2);
      this.lblDLT.Name = "lblDLT";
      this.lblDLT.Size = new Size(93, 16);
      this.lblDLT.TabIndex = 13;
      this.lblDLT.Text = "Tên Dữ liệu trộn";
      this.labelControl1.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(537, 188);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(85, 16);
      this.labelControl1.TabIndex = 12;
      this.labelControl1.Text = "Tổng số  phiếu";
      this.labelControl1.Visible = false;
      this.lblKLMoiMe.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLMoiMe.Appearance.Options.UseFont = true;
      this.lblKLMoiMe.Location = new Point(537, 155);
      this.lblKLMoiMe.Margin = new Padding(2);
      this.lblKLMoiMe.Name = "lblKLMoiMe";
      this.lblKLMoiMe.Size = new Size(59, 16);
      this.lblKLMoiMe.TabIndex = 11;
      this.lblKLMoiMe.Text = "KL Mỗi mẻ";
      this.lblSLMe.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblSLMe.Appearance.Options.UseFont = true;
      this.lblSLMe.Location = new Point(537, 123);
      this.lblSLMe.Margin = new Padding(2);
      this.lblSLMe.Name = "lblSLMe";
      this.lblSLMe.Size = new Size(73, 16);
      this.lblSLMe.TabIndex = 10;
      this.lblSLMe.Text = "Số lượng mẻ";
      this.lblTongGiaTriSilo.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTongGiaTriSilo.Appearance.Options.UseFont = true;
      this.lblTongGiaTriSilo.Location = new Point(283, 155);
      this.lblTongGiaTriSilo.Margin = new Padding(2);
      this.lblTongGiaTriSilo.Name = "lblTongGiaTriSilo";
      this.lblTongGiaTriSilo.Size = new Size(91, 16);
      this.lblTongGiaTriSilo.TabIndex = 9;
      this.lblTongGiaTriSilo.Text = "Tổng giá trị Silo";
      this.lblKLCanTron.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLCanTron.Appearance.Options.UseFont = true;
      this.lblKLCanTron.Location = new Point(47, 155);
      this.lblKLCanTron.Margin = new Padding(2);
      this.lblKLCanTron.Name = "lblKLCanTron";
      this.lblKLCanTron.Size = new Size(66, 16);
      this.lblKLCanTron.TabIndex = 8;
      this.lblKLCanTron.Text = "KL Cần trộn";
      this.lblKLTronLonNhat.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLTronLonNhat.Appearance.Options.UseFont = true;
      this.lblKLTronLonNhat.Location = new Point(283, 123);
      this.lblKLTronLonNhat.Margin = new Padding(2);
      this.lblKLTronLonNhat.Name = "lblKLTronLonNhat";
      this.lblKLTronLonNhat.Size = new Size(94, 16);
      this.lblKLTronLonNhat.TabIndex = 7;
      this.lblKLTronLonNhat.Text = "KL Trộn lớn nhất";
      this.lblKLTronNhoNhat.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLTronNhoNhat.Appearance.Options.UseFont = true;
      this.lblKLTronNhoNhat.Location = new Point(17, 123);
      this.lblKLTronNhoNhat.Margin = new Padding(2);
      this.lblKLTronNhoNhat.Name = "lblKLTronNhoNhat";
      this.lblKLTronNhoNhat.Size = new Size(98, 16);
      this.lblKLTronNhoNhat.TabIndex = 6;
      this.lblKLTronNhoNhat.Text = "KL Trộn nhỏ nhất";
      this.lblMAC.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMAC.Appearance.Options.UseFont = true;
      this.lblMAC.Location = new Point(87, 89);
      this.lblMAC.Margin = new Padding(2);
      this.lblMAC.Name = "lblMAC";
      this.lblMAC.Size = new Size(26, 16);
      this.lblMAC.TabIndex = 5;
      this.lblMAC.Text = "MAC";
      this.lblJobsite.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblJobsite.Appearance.Options.UseFont = true;
      this.lblJobsite.Location = new Point(408, 57);
      this.lblJobsite.Margin = new Padding(2);
      this.lblJobsite.Name = "lblJobsite";
      this.lblJobsite.Size = new Size(71, 16);
      this.lblJobsite.TabIndex = 4;
      this.lblJobsite.Text = "Công trường";
      this.lblCustomer.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblCustomer.Appearance.Options.UseFont = true;
      this.lblCustomer.Location = new Point(53, 58);
      this.lblCustomer.Margin = new Padding(2);
      this.lblCustomer.Name = "lblCustomer";
      this.lblCustomer.Size = new Size(66, 16);
      this.lblCustomer.TabIndex = 3;
      this.lblCustomer.Text = "Khách hàng";
      this.lblUpdateDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblUpdateDate.Appearance.Options.UseFont = true;
      this.lblUpdateDate.Location = new Point(498, 28);
      this.lblUpdateDate.Margin = new Padding(2);
      this.lblUpdateDate.Name = "lblUpdateDate";
      this.lblUpdateDate.Size = new Size(81, 16);
      this.lblUpdateDate.TabIndex = 2;
      this.lblUpdateDate.Text = "Ngày cập nhật";
      this.lblCreationDate.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblCreationDate.Appearance.Options.UseFont = true;
      this.lblCreationDate.Location = new Point(257, 29);
      this.lblCreationDate.Margin = new Padding(2);
      this.lblCreationDate.Name = "lblCreationDate";
      this.lblCreationDate.Size = new Size(50, 16);
      this.lblCreationDate.TabIndex = 1;
      this.lblCreationDate.Text = "Ngày tạo";
      this.lblMaDLT.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaDLT.Appearance.Options.UseFont = true;
      this.lblMaDLT.Location = new Point(30, 28);
      this.lblMaDLT.Margin = new Padding(2);
      this.lblMaDLT.Name = "lblMaDLT";
      this.lblMaDLT.Size = new Size(88, 16);
      this.lblMaDLT.TabIndex = 0;
      this.lblMaDLT.Text = "Mã Dữ liệu trộn";
      this.pnlCommand.Controls.Add((Control) this.btnClose);
      this.pnlCommand.Controls.Add((Control) this.btnSave);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 231);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(770, 41);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(392, 6);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(280, 6);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 0;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pnlCommand);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewDuLieuTronView);
      this.Size = new Size(770, 272);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.gluHangMuc.Properties.EndInit();
      this.gridView4.EndInit();
      this.gluKhachHang.Properties.EndInit();
      this.gridView3.EndInit();
      this.txtMoTaDLT.Properties.EndInit();
      this.spnNoPhieu.Properties.EndInit();
      this.spnKLDTMeTron.Properties.EndInit();
      this.spnMACSUMSiloValueCalc.Properties.EndInit();
      this.spnKLDuTinh.Properties.EndInit();
      this.spnMTQty.Properties.EndInit();
      this.spnMaxKLTron.Properties.EndInit();
      this.spnMinKLTron.Properties.EndInit();
      this.gluMAC.Properties.EndInit();
      this.gridView2.EndInit();
      this.gluCongTruong.Properties.EndInit();
      this.gridView1.EndInit();
      this.datLatestUpdateDate.Properties.CalendarTimeProperties.EndInit();
      this.datLatestUpdateDate.Properties.EndInit();
      this.datNgayDLT.Properties.CalendarTimeProperties.EndInit();
      this.datNgayDLT.Properties.EndInit();
      this.txtMaDLT.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

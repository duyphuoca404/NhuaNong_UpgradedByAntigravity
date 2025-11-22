// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewHopDongView
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
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public partial class NewHopDongView : ControlViewBase, INewHopDongView, IBase
  {
    private NewHopDongDataPresenter _presenter;
    private string _NewHopDongCaption = "Thêm Hợp đồng";
    private string _EditHopDongCaption = "Sửa Hợp đồng";
    private string _ViewHopDongCaption = "Xem Hợp đồng";
    private ObjHopDong _hd;
    private BindingList<ObjKhachHang> _blstKhachHang = new BindingList<ObjKhachHang>();
    private BindingList<ObjCongTruong> _blstCongTruong = new BindingList<ObjCongTruong>();
    private BindingList<ObjMAC> _blstMAC = new BindingList<ObjMAC>();
    private BindingList<ObjHangMuc> _blstHangMuc = new BindingList<ObjHangMuc>();
    

    private bool IsSaveClose { get; set; }

    public NewHopDongView()
    {
      this.InitializeComponent();
      this.Name = nameof(NewHopDongView);
      this._presenter = new NewHopDongDataPresenter((INewHopDongView) this);
    }

    public NewHopDongView(ObjHopDong ct, Enums.FormAction action)
      : this()
    {
      this._hd = ct;
      this.FormAction = action;
      this.SetCaption();
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

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public int SLMeDuTinh
    {
      set
      {
      }
    }

    public Decimal KLDuTinhMeTron
    {
      set
      {
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

    public ObjHopDong GetSavedHopDong() => this._hd;

    protected override void SetupLayout() => this.DisableConstrol();

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
      }
    }

    protected override void BindData()
    {
      try
      {
        this.txtMaHopDong.DataBindings.Clear();
        this.txtMaHopDong.DataBindings.Add("Text", (object) this._hd, "MaHopDong");
        this.txtTenHopDong.DataBindings.Clear();
        this.txtTenHopDong.DataBindings.Add("Text", (object) this._hd, "TenHopDong");
        this.datNgayHopDong.DataBindings.Clear();
        this.datNgayHopDong.DataBindings.Add("DateTime", (object) this._hd, "NgayHopDong");
        this.gluKhachHang.DataBindings.Clear();
        this.gluKhachHang.DataBindings.Add("EditValue", (object) this._hd, "KhachHangID");
        this.gluCongTruong.DataBindings.Clear();
        this.gluCongTruong.DataBindings.Add("EditValue", (object) this._hd, "CongTruongID");
        this.gluMAC.DataBindings.Clear();
        this.gluMAC.DataBindings.Add("EditValue", (object) this._hd, "MACID");
        this.gluHangMuc.DataBindings.Clear();
        this.gluHangMuc.DataBindings.Add("EditValue", (object) this._hd, "HangMucID");
        this.txtMoTa.DataBindings.Clear();
        this.txtMoTa.DataBindings.Add("Text", (object) this._hd, "MoTa");
        this.spnTongPhieu.DataBindings.Clear();
        this.spnTongPhieu.DataBindings.Add("EditValue", (object) this._hd, "TongPhieu");
        this.spnKLDH.DataBindings.Clear();
        this.spnKLDH.DataBindings.Add("EditValue", (object) this._hd, "KLDatHang");
        this.spnKLDG.DataBindings.Clear();
        this.spnKLDG.DataBindings.Add("EditValue", (object) this._hd, "KLDaGiao");
        this.spnKLCL.DataBindings.Clear();
        this.spnKLCL.DataBindings.Add("EditValue", (object) this._hd, "KLConLai");
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
          this.Caption = this._NewHopDongCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditHopDongCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewHopDongCaption;
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaHopDong.Text == string.Empty)
      {
        this.txtMaHopDong.ErrorText = GlobalValues.Messages.MaHopDongIsRequired;
        flag = false;
      }
      if (this.txtTenHopDong.Text == string.Empty)
      {
        this.txtTenHopDong.ErrorText = GlobalValues.Messages.TenHopDongIsRequired;
        flag = false;
      }
      if (this.gluKhachHang.EditValue == DBNull.Value)
      {
        this.gluKhachHang.ErrorText = GlobalValues.Messages.KhachHangIsRequired;
        flag = false;
      }
      if (this.gluCongTruong.EditValue == DBNull.Value)
      {
        this.gluCongTruong.ErrorText = GlobalValues.Messages.CongTruongIsRequired;
        flag = false;
      }
      if (this.gluMAC.EditValue == DBNull.Value)
      {
        this.gluMAC.ErrorText = GlobalValues.Messages.MACIsRequired;
        flag = false;
      }
      if (this.spnKLDH.Value <= 0M)
      {
        this.spnKLDH.ErrorText = GlobalValues.Messages.KLDatHangLonHon0;
        flag = false;
      }
      return flag;
    }

    private void DisableConstrol()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.Edit:
          this.btnSaveNew.Visible = false;
          break;
        case Enums.FormAction.View:
          this.txtMaHopDong.Properties.ReadOnly = true;
          this.txtTenHopDong.Properties.ReadOnly = true;
          this.datNgayHopDong.Properties.ReadOnly = true;
          this.gluKhachHang.Properties.ReadOnly = true;
          this.gluCongTruong.Properties.ReadOnly = true;
          this.gluMAC.Properties.ReadOnly = true;
          this.gluHangMuc.Properties.ReadOnly = true;
          this.txtMoTa.Properties.ReadOnly = true;
          this.spnTongPhieu.Properties.ReadOnly = true;
          this.spnKLDH.Properties.ReadOnly = true;
          this.spnKLDG.Properties.ReadOnly = true;
          this.spnKLCL.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjHopDong> blstCT = new BindingList<ObjHopDong>();
      blstCT.Add(this._hd);
      this._presenter.SaveHopDong(blstCT);
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
      if (this.txtMoTa.Text.Length > 0)
        str2 = str2 + str1 + this.txtMoTa.Text;
      if (str2 != string.Empty)
        str2 = str2.Substring(str1.Length, str2.Length - str1.Length);
      this._hd.TenHopDong = this.txtTenHopDong.Text = str2;
    }

    private void spnKLDH_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.KLDatHang = new Decimal?(this.spnKLDH.Value);
    }

    private void spnKLDG_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.KLDaGiao = new Decimal?(this.spnKLDG.Value);
    }

    private void spnKLCL_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.KLConLai = new Decimal?(this.spnKLCL.Value);
    }

    private void btnSaveNew_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = false;
      this.SaveData();
      TramTronLogger.WriteInfo(sender.ToString());
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = true;
      this.SaveData();
      TramTronLogger.WriteInfo(sender.ToString());
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

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

    private void gluMAC_EditValueChanged(object sender, EventArgs e)
    {
      if (this.gluMAC.EditValue != DBNull.Value)
        this._hd.MACID = new int?(Convert.ToInt32(this.gluMAC.EditValue));
      this.GenerateDienGiai();
    }

    private void gluHangMuc_EditValueChanged(object sender, EventArgs e)
    {
      if (this.gluHangMuc.EditValue != DBNull.Value)
        this._hd.HangMucID = new int?(Convert.ToInt32(this.gluHangMuc.EditValue));
      this.GenerateDienGiai();
    }

    private void txtMoTa_EditValueChanged(object sender, EventArgs e)
    {
      if (this.txtMoTa.Text != string.Empty)
        this._hd.MoTa = this.txtMoTa.Text;
      this.GenerateDienGiai();
    }

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

    private void spnTongPhieu_EditValueChanged(object sender, EventArgs e)
    {
      this._hd.TongPhieu = new int?((int) this.spnTongPhieu.Value);
    }

    
  }
}

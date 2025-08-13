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
  public class NewHopDongView : ControlViewBase, INewHopDongView, IBase
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
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl pnlCommand;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;
    private SpinEdit spnKLDH;
    private LabelControl lblKLDatHang;
    private TextEdit txtTenHopDong;
    private TextEdit txtMaHopDong;
    private LabelControl lblTenHopDong;
    private LabelControl lblMaHopDong;
    private SpinEdit spnKLCL;
    private LabelControl lblKLConLai;
    private SpinEdit spnKLDG;
    private LabelControl lblKLDaGiao;
    private TextEdit txtMoTa;
    private LabelControl lblNote;
    private LabelControl lblMAC;
    private LabelControl lblCongTruong;
    private LabelControl lblKhachHang;
    private DateEdit datNgayHopDong;
    private LabelControl lblNgayHopDong;
    private LabelControl labelControl1;
    private GridLookUpEdit gluKhachHang;
    private GridView gridView3;
    private GridColumn gcKhachHangID;
    private GridColumn gcMaKhachHang;
    private GridColumn gcTenKhachHang;
    private GridLookUpEdit gluCongTruong;
    private GridView gridView1;
    private GridColumn gcCongTruongID;
    private GridColumn gcMaCongTruong;
    private GridColumn gcTenCongTruong;
    private GridLookUpEdit gluMAC;
    private GridView gridView2;
    private GridColumn gcMACID;
    private GridColumn gcMaMAC;
    private GridColumn gcTenMAC;
    private GridLookUpEdit gluHangMuc;
    private GridView gridView5;
    private GridColumn gridColumn4;
    private GridColumn gridColumn5;
    private GridColumn gridColumn6;
    private LabelControl labelControl2;
    private SpinEdit spnTongPhieu;
    private LabelControl labelControl3;

    private bool IsSaveClose { get; set; }

    public NewHopDongView()
    {
      this.InitializeComponent();
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
      this.gridView5 = new GridView();
      this.gridColumn4 = new GridColumn();
      this.gridColumn5 = new GridColumn();
      this.gridColumn6 = new GridColumn();
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
      this.gluKhachHang = new GridLookUpEdit();
      this.gridView3 = new GridView();
      this.gcKhachHangID = new GridColumn();
      this.gcMaKhachHang = new GridColumn();
      this.gcTenKhachHang = new GridColumn();
      this.spnKLCL = new SpinEdit();
      this.lblKLConLai = new LabelControl();
      this.spnKLDG = new SpinEdit();
      this.labelControl1 = new LabelControl();
      this.lblKLDaGiao = new LabelControl();
      this.spnKLDH = new SpinEdit();
      this.txtMoTa = new TextEdit();
      this.lblKLDatHang = new LabelControl();
      this.lblNote = new LabelControl();
      this.lblMAC = new LabelControl();
      this.lblCongTruong = new LabelControl();
      this.lblKhachHang = new LabelControl();
      this.datNgayHopDong = new DateEdit();
      this.lblNgayHopDong = new LabelControl();
      this.txtTenHopDong = new TextEdit();
      this.txtMaHopDong = new TextEdit();
      this.lblTenHopDong = new LabelControl();
      this.lblMaHopDong = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.labelControl2 = new LabelControl();
      this.spnTongPhieu = new SpinEdit();
      this.labelControl3 = new LabelControl();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.gluHangMuc.Properties.BeginInit();
      this.gridView5.BeginInit();
      this.gluMAC.Properties.BeginInit();
      this.gridView2.BeginInit();
      this.gluCongTruong.Properties.BeginInit();
      this.gridView1.BeginInit();
      this.gluKhachHang.Properties.BeginInit();
      this.gridView3.BeginInit();
      this.spnKLCL.Properties.BeginInit();
      this.spnKLDG.Properties.BeginInit();
      this.spnKLDH.Properties.BeginInit();
      this.txtMoTa.Properties.BeginInit();
      this.datNgayHopDong.Properties.CalendarTimeProperties.BeginInit();
      this.datNgayHopDong.Properties.BeginInit();
      this.txtTenHopDong.Properties.BeginInit();
      this.txtMaHopDong.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.spnTongPhieu.Properties.BeginInit();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.labelControl2);
      this.pnlMain.Controls.Add((Control) this.spnTongPhieu);
      this.pnlMain.Controls.Add((Control) this.labelControl3);
      this.pnlMain.Controls.Add((Control) this.gluHangMuc);
      this.pnlMain.Controls.Add((Control) this.gluMAC);
      this.pnlMain.Controls.Add((Control) this.gluCongTruong);
      this.pnlMain.Controls.Add((Control) this.gluKhachHang);
      this.pnlMain.Controls.Add((Control) this.spnKLCL);
      this.pnlMain.Controls.Add((Control) this.lblKLConLai);
      this.pnlMain.Controls.Add((Control) this.spnKLDG);
      this.pnlMain.Controls.Add((Control) this.labelControl1);
      this.pnlMain.Controls.Add((Control) this.lblKLDaGiao);
      this.pnlMain.Controls.Add((Control) this.spnKLDH);
      this.pnlMain.Controls.Add((Control) this.txtMoTa);
      this.pnlMain.Controls.Add((Control) this.lblKLDatHang);
      this.pnlMain.Controls.Add((Control) this.lblNote);
      this.pnlMain.Controls.Add((Control) this.lblMAC);
      this.pnlMain.Controls.Add((Control) this.lblCongTruong);
      this.pnlMain.Controls.Add((Control) this.lblKhachHang);
      this.pnlMain.Controls.Add((Control) this.datNgayHopDong);
      this.pnlMain.Controls.Add((Control) this.lblNgayHopDong);
      this.pnlMain.Controls.Add((Control) this.txtTenHopDong);
      this.pnlMain.Controls.Add((Control) this.txtMaHopDong);
      this.pnlMain.Controls.Add((Control) this.lblTenHopDong);
      this.pnlMain.Controls.Add((Control) this.lblMaHopDong);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(742, 264);
      this.pnlMain.TabIndex = 0;
      this.gluHangMuc.Location = new Point(501, 120);
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
      this.gluHangMuc.Properties.PopupView = (ColumnView) this.gridView5;
      this.gluHangMuc.Properties.ShowFooter = false;
      this.gluHangMuc.Properties.TextEditStyle = TextEditStyles.Standard;
      this.gluHangMuc.Properties.ValueMember = "HangMucID";
      this.gluHangMuc.Size = new Size(200, 22);
      this.gluHangMuc.TabIndex = 33;
      this.gluHangMuc.ButtonPressed += new ButtonPressedEventHandler(this.gluHangMuc_ButtonPressed);
      this.gluHangMuc.EditValueChanged += new EventHandler(this.gluHangMuc_EditValueChanged);
      this.gridView5.Columns.AddRange(new GridColumn[3]
      {
        this.gridColumn4,
        this.gridColumn5,
        this.gridColumn6
      });
      this.gridView5.DetailHeight = 284;
      this.gridView5.FocusRectStyle = DrawFocusRectStyle.RowFocus;
      this.gridView5.Name = "gridView5";
      this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridView5.OptionsView.ShowGroupPanel = false;
      this.gridColumn4.Caption = "HangMucID";
      this.gridColumn4.FieldName = "HangMucID";
      this.gridColumn4.MinWidth = 15;
      this.gridColumn4.Name = "gridColumn4";
      this.gridColumn4.Width = 56;
      this.gridColumn5.Caption = "Mã Hạng mục";
      this.gridColumn5.FieldName = "MaHangMuc";
      this.gridColumn5.MinWidth = 15;
      this.gridColumn5.Name = "gridColumn5";
      this.gridColumn5.Width = 56;
      this.gridColumn6.Caption = "Tên Hạng mục";
      this.gridColumn6.FieldName = "TenHangMuc";
      this.gridColumn6.MinWidth = 15;
      this.gridColumn6.Name = "gridColumn6";
      this.gridColumn6.Visible = true;
      this.gridColumn6.VisibleIndex = 0;
      this.gridColumn6.Width = 56;
      this.gluMAC.Location = new Point(160, 120);
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
      this.gluMAC.Size = new Size(200, 22);
      this.gluMAC.TabIndex = 32;
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
      this.gluCongTruong.Location = new Point(501, 90);
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
      this.gluCongTruong.Size = new Size(200, 22);
      this.gluCongTruong.TabIndex = 31;
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
      this.gluKhachHang.Location = new Point(160, 90);
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
      this.gluKhachHang.Size = new Size(200, 22);
      this.gluKhachHang.TabIndex = 30;
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
      this.spnKLCL.EditValue = (object) new Decimal(new int[4]);
      this.spnKLCL.Location = new Point(595, 180);
      this.spnKLCL.Margin = new Padding(2);
      this.spnKLCL.Name = "spnKLCL";
      this.spnKLCL.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLCL.Properties.Appearance.Options.UseFont = true;
      this.spnKLCL.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLCL.Properties.DisplayFormat.FormatString = "n2";
      this.spnKLCL.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnKLCL.Properties.EditFormat.FormatString = "n2";
      this.spnKLCL.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnKLCL.Properties.MaxValue = new Decimal(new int[4]
      {
        9999,
        0,
        0,
        0
      });
      this.spnKLCL.Properties.ReadOnly = true;
      this.spnKLCL.Size = new Size(106, 22);
      this.spnKLCL.TabIndex = 5;
      this.lblKLConLai.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLConLai.Appearance.Options.UseFont = true;
      this.lblKLConLai.Location = new Point(517, 183);
      this.lblKLConLai.Margin = new Padding(2);
      this.lblKLConLai.Name = "lblKLConLai";
      this.lblKLConLai.Size = new Size(54, 16);
      this.lblKLConLai.TabIndex = 4;
      this.lblKLConLai.Text = "KL còn lại";
      this.spnKLDG.EditValue = (object) new Decimal(new int[4]);
      this.spnKLDG.Location = new Point(377, 180);
      this.spnKLDG.Margin = new Padding(2);
      this.spnKLDG.Name = "spnKLDG";
      this.spnKLDG.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLDG.Properties.Appearance.Options.UseFont = true;
      this.spnKLDG.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLDG.Properties.DisplayFormat.FormatString = "n2";
      this.spnKLDG.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnKLDG.Properties.EditFormat.FormatString = "n2";
      this.spnKLDG.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnKLDG.Properties.MaxValue = new Decimal(new int[4]
      {
        9999,
        0,
        0,
        0
      });
      this.spnKLDG.Size = new Size(106, 22);
      this.spnKLDG.TabIndex = 3;
      this.spnKLDG.EditValueChanged += new EventHandler(this.spnKLDG_EditValueChanged);
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(395, 123);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(61, 16);
      this.labelControl1.TabIndex = 25;
      this.labelControl1.Text = "Hạng mục";
      this.lblKLDaGiao.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLDaGiao.Appearance.Options.UseFont = true;
      this.lblKLDaGiao.Location = new Point(299, 183);
      this.lblKLDaGiao.Margin = new Padding(2);
      this.lblKLDaGiao.Name = "lblKLDaGiao";
      this.lblKLDaGiao.Size = new Size(59, 16);
      this.lblKLDaGiao.TabIndex = 2;
      this.lblKLDaGiao.Text = "KL đã giao";
      this.spnKLDH.EditValue = (object) new Decimal(new int[4]);
      this.spnKLDH.Location = new Point(160, 180);
      this.spnKLDH.Margin = new Padding(2);
      this.spnKLDH.Name = "spnKLDH";
      this.spnKLDH.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnKLDH.Properties.Appearance.Options.UseFont = true;
      this.spnKLDH.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKLDH.Properties.DisplayFormat.FormatString = "n2";
      this.spnKLDH.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnKLDH.Properties.EditFormat.FormatString = "n2";
      this.spnKLDH.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnKLDH.Properties.MaxValue = new Decimal(new int[4]
      {
        9999,
        0,
        0,
        0
      });
      this.spnKLDH.Size = new Size(106, 22);
      this.spnKLDH.TabIndex = 1;
      this.spnKLDH.EditValueChanged += new EventHandler(this.spnKLDH_EditValueChanged);
      this.txtMoTa.Location = new Point(160, 150);
      this.txtMoTa.Margin = new Padding(2);
      this.txtMoTa.Name = "txtMoTa";
      this.txtMoTa.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMoTa.Properties.Appearance.Options.UseFont = true;
      this.txtMoTa.Size = new Size(323, 22);
      this.txtMoTa.TabIndex = 23;
      this.txtMoTa.EditValueChanged += new EventHandler(this.txtMoTa_EditValueChanged);
      this.lblKLDatHang.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKLDatHang.Appearance.Options.UseFont = true;
      this.lblKLDatHang.Location = new Point(32, 183);
      this.lblKLDatHang.Margin = new Padding(2);
      this.lblKLDatHang.Name = "lblKLDatHang";
      this.lblKLDatHang.Size = new Size(67, 16);
      this.lblKLDatHang.TabIndex = 0;
      this.lblKLDatHang.Text = "KL đặt hàng";
      this.lblNote.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblNote.Appearance.Options.UseFont = true;
      this.lblNote.Location = new Point(32, 153);
      this.lblNote.Margin = new Padding(2);
      this.lblNote.Name = "lblNote";
      this.lblNote.Size = new Size(33, 16);
      this.lblNote.TabIndex = 22;
      this.lblNote.Text = "Mô tả";
      this.lblMAC.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMAC.Appearance.Options.UseFont = true;
      this.lblMAC.Location = new Point(32, 123);
      this.lblMAC.Margin = new Padding(2);
      this.lblMAC.Name = "lblMAC";
      this.lblMAC.Size = new Size(29, 16);
      this.lblMAC.TabIndex = 20;
      this.lblMAC.Text = "MAC";
      this.lblCongTruong.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblCongTruong.Appearance.Options.UseFont = true;
      this.lblCongTruong.Location = new Point(395, 93);
      this.lblCongTruong.Margin = new Padding(2);
      this.lblCongTruong.Name = "lblCongTruong";
      this.lblCongTruong.Size = new Size(72, 16);
      this.lblCongTruong.TabIndex = 19;
      this.lblCongTruong.Text = "Công trường";
      this.lblKhachHang.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblKhachHang.Appearance.Options.UseFont = true;
      this.lblKhachHang.Location = new Point(32, 93);
      this.lblKhachHang.Margin = new Padding(2);
      this.lblKhachHang.Name = "lblKhachHang";
      this.lblKhachHang.Size = new Size(70, 16);
      this.lblKhachHang.TabIndex = 16;
      this.lblKhachHang.Text = "Khách hàng";
      this.datNgayHopDong.EditValue = (object) null;
      this.datNgayHopDong.Location = new Point(501, 30);
      this.datNgayHopDong.Margin = new Padding(2);
      this.datNgayHopDong.Name = "datNgayHopDong";
      this.datNgayHopDong.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.datNgayHopDong.Properties.Appearance.Options.UseFont = true;
      this.datNgayHopDong.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayHopDong.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayHopDong.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
      this.datNgayHopDong.Properties.DisplayFormat.FormatType = FormatType.DateTime;
      this.datNgayHopDong.Properties.EditFormat.FormatString = "dd/MM/yyyy";
      this.datNgayHopDong.Properties.EditFormat.FormatType = FormatType.DateTime;
      this.datNgayHopDong.Properties.Mask.EditMask = "dd/MM/yyyy";
      this.datNgayHopDong.Size = new Size(200, 22);
      this.datNgayHopDong.TabIndex = 15;
      this.lblNgayHopDong.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblNgayHopDong.Appearance.Options.UseFont = true;
      this.lblNgayHopDong.Location = new Point(395, 33);
      this.lblNgayHopDong.Margin = new Padding(2);
      this.lblNgayHopDong.Name = "lblNgayHopDong";
      this.lblNgayHopDong.Size = new Size(55, 16);
      this.lblNgayHopDong.TabIndex = 14;
      this.lblNgayHopDong.Text = "Ngày tạo";
      this.txtTenHopDong.Location = new Point(160, 60);
      this.txtTenHopDong.Margin = new Padding(2);
      this.txtTenHopDong.Name = "txtTenHopDong";
      this.txtTenHopDong.Properties.Appearance.BackColor = Color.White;
      this.txtTenHopDong.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenHopDong.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenHopDong.Properties.Appearance.Options.UseFont = true;
      this.txtTenHopDong.Size = new Size(541, 22);
      this.txtTenHopDong.TabIndex = 12;
      this.txtMaHopDong.Location = new Point(160, 30);
      this.txtMaHopDong.Margin = new Padding(2);
      this.txtMaHopDong.Name = "txtMaHopDong";
      this.txtMaHopDong.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaHopDong.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaHopDong.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaHopDong.Properties.Appearance.Options.UseFont = true;
      this.txtMaHopDong.Properties.ReadOnly = true;
      this.txtMaHopDong.Size = new Size(200, 22);
      this.txtMaHopDong.TabIndex = 11;
      this.lblTenHopDong.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenHopDong.Appearance.Options.UseFont = true;
      this.lblTenHopDong.Location = new Point(32, 63);
      this.lblTenHopDong.Margin = new Padding(2);
      this.lblTenHopDong.Name = "lblTenHopDong";
      this.lblTenHopDong.Size = new Size(84, 16);
      this.lblTenHopDong.TabIndex = 10;
      this.lblTenHopDong.Text = "Tên hợp đồng";
      this.lblMaHopDong.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaHopDong.Appearance.Options.UseFont = true;
      this.lblMaHopDong.Location = new Point(32, 33);
      this.lblMaHopDong.Margin = new Padding(2);
      this.lblMaHopDong.Name = "lblMaHopDong";
      this.lblMaHopDong.Size = new Size(82, 16);
      this.lblMaHopDong.TabIndex = 9;
      this.lblMaHopDong.Text = "Mã Hợp đồng";
      this.pnlCommand.Controls.Add((Control) this.btnClose);
      this.pnlCommand.Controls.Add((Control) this.btnSave);
      this.pnlCommand.Controls.Add((Control) this.btnSaveNew);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 223);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(742, 41);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(442, 7);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(330, 6);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSaveNew.Appearance.Options.UseFont = true;
      this.btnSaveNew.Location = new Point(190, 6);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 3;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.labelControl2.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl2.Appearance.Options.UseFont = true;
      this.labelControl2.Location = new Point(558, 153);
      this.labelControl2.Margin = new Padding(2);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(0, 16);
      this.labelControl2.TabIndex = 36;
      this.spnTongPhieu.EditValue = (object) new Decimal(new int[4]);
      this.spnTongPhieu.Location = new Point(595, 150);
      this.spnTongPhieu.Margin = new Padding(2);
      this.spnTongPhieu.Name = "spnTongPhieu";
      this.spnTongPhieu.Properties.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.spnTongPhieu.Properties.Appearance.Options.UseFont = true;
      this.spnTongPhieu.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnTongPhieu.Properties.DisplayFormat.FormatString = "n0";
      this.spnTongPhieu.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnTongPhieu.Properties.EditFormat.FormatString = "n0";
      this.spnTongPhieu.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnTongPhieu.Properties.Mask.EditMask = "n0";
      this.spnTongPhieu.Properties.MaxValue = new Decimal(new int[4]
      {
        9999,
        0,
        0,
        0
      });
      this.spnTongPhieu.Size = new Size(106, 22);
      this.spnTongPhieu.TabIndex = 35;
      this.spnTongPhieu.EditValueChanged += new EventHandler(this.spnTongPhieu_EditValueChanged);
      this.labelControl3.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl3.Appearance.Options.UseFont = true;
      this.labelControl3.Location = new Point(501, 153);
      this.labelControl3.Margin = new Padding(2);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(81, 16);
      this.labelControl3.TabIndex = 34;
      this.labelControl3.Text = "Tổng số phiếu";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pnlCommand);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewHopDongView);
      this.Size = new Size(742, 264);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.gluHangMuc.Properties.EndInit();
      this.gridView5.EndInit();
      this.gluMAC.Properties.EndInit();
      this.gridView2.EndInit();
      this.gluCongTruong.Properties.EndInit();
      this.gridView1.EndInit();
      this.gluKhachHang.Properties.EndInit();
      this.gridView3.EndInit();
      this.spnKLCL.Properties.EndInit();
      this.spnKLDG.Properties.EndInit();
      this.spnKLDH.Properties.EndInit();
      this.txtMoTa.Properties.EndInit();
      this.datNgayHopDong.Properties.CalendarTimeProperties.EndInit();
      this.datNgayHopDong.Properties.EndInit();
      this.txtTenHopDong.Properties.EndInit();
      this.txtMaHopDong.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.spnTongPhieu.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}

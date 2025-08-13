// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewNhanVienView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using NhuaNong.Data;
using NhuaNong.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class NewNhanVienView : ControlViewBase, INewNhanVienView, IBase
  {
    private NewNhanVienDataPresenter _presenter;
    private string _NewTaiXeCaption = "Thêm Nhân viên";
    private string _EditTaiXeCaption = "Sửa Nhân viên";
    private string _ViewTaiXeCaption = "Xem Nhân viên";
    private ObjNhanVien _nv;
    private IContainer components;
    private PanelControl pnlMain;
    private LabelControl labelControl1;
    private CheckEdit chkActive;
    private TextEdit txtPhone;
    private TextEdit txtTenNhanVien;
    private TextEdit txtMaNhanVien;
    private LabelControl lblPhone;
    private LabelControl lblTenNhanVien;
    private LabelControl lblMaNhanVien;
    private PanelControl panelControl1;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;

    private bool IsSaveClose { get; set; }

    public NewNhanVienView()
    {
      this.InitializeComponent();
      this._presenter = new NewNhanVienDataPresenter((INewNhanVienView) this);
    }

    public NewNhanVienView(ObjNhanVien ct, Enums.FormAction action)
      : this()
    {
      this._nv = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    public ObjNhanVien NhanVien
    {
      set => this._nv = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    protected override void SetupLayout() => this.DisableConstrol();

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewNhanVien();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetNhanVienByKey(this._nv.NhanVienID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaNhanVien.DataBindings.Clear();
      this.txtMaNhanVien.DataBindings.Add("Text", (object) this._nv, "MaNhanVien");
      this.txtTenNhanVien.DataBindings.Clear();
      this.txtTenNhanVien.DataBindings.Add("Text", (object) this._nv, "TenNhanVien");
      this.txtPhone.DataBindings.Clear();
      this.txtPhone.DataBindings.Add("Text", (object) this._nv, "Phone");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._nv, "Activated");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewTaiXeCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditTaiXeCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewTaiXeCaption;
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaNhanVien.Text == string.Empty)
      {
        this.txtMaNhanVien.ErrorText = GlobalValues.Messages.MaNhanVienIsRequired;
        flag = false;
      }
      if (this.txtTenNhanVien.Text == string.Empty)
      {
        this.txtTenNhanVien.ErrorText = GlobalValues.Messages.TenNhanVienIsRequired;
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
          this.txtMaNhanVien.Properties.ReadOnly = true;
          this.txtTenNhanVien.Properties.ReadOnly = true;
          this.txtPhone.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjNhanVien> blstCT = new BindingList<ObjNhanVien>();
      blstCT.Add(this._nv);
      this._presenter.SaveNhanVien(blstCT);
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
        this._presenter.BuildNewNhanVien();
        this.BindData();
      }
    }

    private void btnSaveNew_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = false;
      this.SaveData();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = true;
      this.SaveData();
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlMain = new PanelControl();
      this.labelControl1 = new LabelControl();
      this.chkActive = new CheckEdit();
      this.txtPhone = new TextEdit();
      this.txtTenNhanVien = new TextEdit();
      this.txtMaNhanVien = new TextEdit();
      this.lblPhone = new LabelControl();
      this.lblTenNhanVien = new LabelControl();
      this.lblMaNhanVien = new LabelControl();
      this.panelControl1 = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.chkActive.Properties.BeginInit();
      this.txtPhone.Properties.BeginInit();
      this.txtTenNhanVien.Properties.BeginInit();
      this.txtMaNhanVien.Properties.BeginInit();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.labelControl1);
      this.pnlMain.Controls.Add((Control) this.chkActive);
      this.pnlMain.Controls.Add((Control) this.txtPhone);
      this.pnlMain.Controls.Add((Control) this.txtTenNhanVien);
      this.pnlMain.Controls.Add((Control) this.txtMaNhanVien);
      this.pnlMain.Controls.Add((Control) this.lblPhone);
      this.pnlMain.Controls.Add((Control) this.lblTenNhanVien);
      this.pnlMain.Controls.Add((Control) this.lblMaNhanVien);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(437, 197);
      this.pnlMain.TabIndex = 2;
      this.labelControl1.Appearance.Font = new Font("Tahoma", 7.8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(101, 116);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(44, 13);
      this.labelControl1.TabIndex = 21;
      this.labelControl1.Text = "Kích hoạt";
      this.labelControl1.Visible = false;
      this.chkActive.Location = new Point(176, 113);
      this.chkActive.Margin = new Padding(2);
      this.chkActive.Name = "chkActive";
      this.chkActive.Properties.Caption = "";
      this.chkActive.Size = new Size(104, 20);
      this.chkActive.TabIndex = 20;
      this.chkActive.Visible = false;
      this.txtPhone.Location = new Point(176, 90);
      this.txtPhone.Margin = new Padding(2);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Size = new Size(238, 20);
      this.txtPhone.TabIndex = 19;
      this.txtTenNhanVien.Location = new Point(175, 67);
      this.txtTenNhanVien.Margin = new Padding(2);
      this.txtTenNhanVien.Name = "txtTenNhanVien";
      this.txtTenNhanVien.Properties.Appearance.BackColor = Color.White;
      this.txtTenNhanVien.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenNhanVien.Size = new Size(238, 20);
      this.txtTenNhanVien.TabIndex = 18;
      this.txtMaNhanVien.Location = new Point(176, 45);
      this.txtMaNhanVien.Margin = new Padding(2);
      this.txtMaNhanVien.Name = "txtMaNhanVien";
      this.txtMaNhanVien.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaNhanVien.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaNhanVien.Properties.ReadOnly = true;
      this.txtMaNhanVien.Size = new Size(238, 20);
      this.txtMaNhanVien.TabIndex = 17;
      this.lblPhone.Appearance.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Location = new Point(108, 93);
      this.lblPhone.Margin = new Padding(2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(35, 14);
      this.lblPhone.TabIndex = 16;
      this.lblPhone.Text = "Phone";
      this.lblTenNhanVien.Appearance.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenNhanVien.Appearance.Options.UseFont = true;
      this.lblTenNhanVien.Location = new Point(65, 72);
      this.lblTenNhanVien.Margin = new Padding(2);
      this.lblTenNhanVien.Name = "lblTenNhanVien";
      this.lblTenNhanVien.Size = new Size(79, 14);
      this.lblTenNhanVien.TabIndex = 15;
      this.lblTenNhanVien.Text = "Tên nhân viên";
      this.lblMaNhanVien.Appearance.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaNhanVien.Appearance.Options.UseFont = true;
      this.lblMaNhanVien.Location = new Point(76, 47);
      this.lblMaNhanVien.Margin = new Padding(2);
      this.lblMaNhanVien.Name = "lblMaNhanVien";
      this.lblMaNhanVien.Size = new Size(72, 14);
      this.lblMaNhanVien.TabIndex = 14;
      this.lblMaNhanVien.Text = "Mã nhân viên";
      this.panelControl1.Controls.Add((Control) this.btnClose);
      this.panelControl1.Controls.Add((Control) this.btnSave);
      this.panelControl1.Controls.Add((Control) this.btnSaveNew);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(0, 197);
      this.panelControl1.Margin = new Padding(2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(437, 47);
      this.panelControl1.TabIndex = 3;
      this.btnClose.Location = new Point(315, 11);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 24);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Location = new Point(211, 11);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 24);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Location = new Point(78, 11);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 24);
      this.btnSaveNew.TabIndex = 3;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pnlMain);
      this.Controls.Add((Control) this.panelControl1);
      this.Name = nameof (NewNhanVienView);
      this.Size = new Size(437, 244);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.chkActive.Properties.EndInit();
      this.txtPhone.Properties.EndInit();
      this.txtTenNhanVien.Properties.EndInit();
      this.txtMaNhanVien.Properties.EndInit();
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

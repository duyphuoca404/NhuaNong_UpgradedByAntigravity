// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewKhachHangView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.Utils;
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
  public class NewKhachHangView : ControlViewBase, INewKhachHangView, IBase
  {
    private NewKhachHangDataPresenter _presenter;
    private string _NewKhachHangCaption = "Thêm Khách hàng";
    private string _EditKhachHangCaption = "Sửa Khách hàng";
    private string _ViewKhachHangCaption = "Xem Khách hàng";
    private ObjKhachHang _ct;
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl pnlCommand;
    private TextEdit txtDiaChi;
    private TextEdit txtTenKhachHang;
    private TextEdit txtMaKhachHang;
    private LabelControl lblPhone;
    private LabelControl lblEmail;
    private LabelControl lblAddress;
    private LabelControl lblTenKhachHang;
    private LabelControl lblMaKhachHang;
    private SimpleButton btnSaveNew;
    private CheckEdit chkActive;
    private TextEdit txtPhone;
    private TextEdit txtEmail;
    private LabelControl labelControl1;
    private SimpleButton btnClose;
    private SimpleButton btnSave;

    protected bool IsSaveClose { get; set; }

    public ObjKhachHang KhachHang
    {
      set => this._ct = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    private void SuccessfullySave(bool isSuccess)
    {
      if (!isSuccess)
        return;
      int num = (int) MessageBox.Show(GlobalValues.Messages.SuccessProceed);
      this._dlgRes = DialogResult.OK;
      if (this.IsSaveClose)
      {
        this.Close();
      }
      else
      {
        this._presenter.BuildNewKhachHang();
        this.BindData();
      }
    }

    public NewKhachHangView()
    {
      this.InitializeComponent();
      this._presenter = new NewKhachHangDataPresenter((INewKhachHangView) this);
    }

    public NewKhachHangView(ObjKhachHang ct, Enums.FormAction action)
      : this()
    {
      this._ct = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewKhachHangCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditKhachHangCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewKhachHangCaption;
          break;
      }
    }

    protected override void SetupLayout() => this.DisableConstrol();

    private void DisableConstrol()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.Edit:
          this.btnSaveNew.Visible = false;
          break;
        case Enums.FormAction.View:
          this.txtMaKhachHang.Properties.ReadOnly = true;
          this.txtTenKhachHang.Properties.ReadOnly = true;
          this.txtDiaChi.Properties.ReadOnly = true;
          this.txtPhone.Properties.ReadOnly = true;
          this.txtEmail.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewKhachHang();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetKhachHangByKey(this._ct.KhachHangID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaKhachHang.DataBindings.Clear();
      this.txtMaKhachHang.DataBindings.Add("Text", (object) this._ct, "MaKhachHang");
      this.txtTenKhachHang.DataBindings.Clear();
      this.txtTenKhachHang.DataBindings.Add("Text", (object) this._ct, "TenKhachHang");
      this.txtDiaChi.DataBindings.Clear();
      this.txtDiaChi.DataBindings.Add("Text", (object) this._ct, "DiaChi");
      this.txtPhone.DataBindings.Clear();
      this.txtPhone.DataBindings.Add("Text", (object) this._ct, "Phone");
      this.txtEmail.DataBindings.Clear();
      this.txtEmail.DataBindings.Add("Text", (object) this._ct, "Email");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._ct, "Activated");
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjKhachHang> blstCT = new BindingList<ObjKhachHang>();
      blstCT.Add(this._ct);
      this._presenter.SaveKhachHang(blstCT);
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaKhachHang.Text == string.Empty)
      {
        this.txtMaKhachHang.ErrorText = GlobalValues.Messages.MaKhachHangIsRequired;
        flag = false;
      }
      if (this.txtTenKhachHang.Text == string.Empty)
      {
        this.txtTenKhachHang.ErrorText = "Nhập lại tên khách hàng";
        flag = false;
      }
      return flag;
    }

    private void btnClose_Click(object sender, EventArgs e) => this.Close();

    private void btnSave_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = true;
      this.SaveData();
      TramTronLogger.WriteInfo(sender.ToString());
    }

    private void btnSaveNew_Click(object sender, EventArgs e)
    {
      this.IsSaveClose = false;
      this.SaveData();
      TramTronLogger.WriteInfo(sender.ToString());
    }

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
      this.txtEmail = new TextEdit();
      this.txtDiaChi = new TextEdit();
      this.txtTenKhachHang = new TextEdit();
      this.txtMaKhachHang = new TextEdit();
      this.lblPhone = new LabelControl();
      this.lblEmail = new LabelControl();
      this.lblAddress = new LabelControl();
      this.lblTenKhachHang = new LabelControl();
      this.lblMaKhachHang = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.chkActive.Properties.BeginInit();
      this.txtPhone.Properties.BeginInit();
      this.txtEmail.Properties.BeginInit();
      this.txtDiaChi.Properties.BeginInit();
      this.txtTenKhachHang.Properties.BeginInit();
      this.txtMaKhachHang.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.labelControl1);
      this.pnlMain.Controls.Add((Control) this.chkActive);
      this.pnlMain.Controls.Add((Control) this.txtPhone);
      this.pnlMain.Controls.Add((Control) this.txtEmail);
      this.pnlMain.Controls.Add((Control) this.txtDiaChi);
      this.pnlMain.Controls.Add((Control) this.txtTenKhachHang);
      this.pnlMain.Controls.Add((Control) this.txtMaKhachHang);
      this.pnlMain.Controls.Add((Control) this.lblPhone);
      this.pnlMain.Controls.Add((Control) this.lblEmail);
      this.pnlMain.Controls.Add((Control) this.lblAddress);
      this.pnlMain.Controls.Add((Control) this.lblTenKhachHang);
      this.pnlMain.Controls.Add((Control) this.lblMaKhachHang);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(560, 245);
      this.pnlMain.TabIndex = 0;
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(87, 178);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 13;
      this.labelControl1.Text = "Kích hoạt";
      this.labelControl1.Visible = false;
      this.chkActive.Location = new Point(200, 176);
      this.chkActive.Margin = new Padding(2);
      this.chkActive.Name = "chkActive";
      this.chkActive.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkActive.Properties.Appearance.Options.UseFont = true;
      this.chkActive.Properties.Caption = "";
      this.chkActive.Size = new Size(80, 20);
      this.chkActive.TabIndex = 12;
      this.chkActive.Visible = false;
      this.txtPhone.Location = new Point(200, 150);
      this.txtPhone.Margin = new Padding(2);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPhone.Properties.Appearance.Options.UseFont = true;
      this.txtPhone.Size = new Size(290, 22);
      this.txtPhone.TabIndex = 11;
      this.txtEmail.Location = new Point(200, 120);
      this.txtEmail.Margin = new Padding(2);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtEmail.Properties.Appearance.Options.UseFont = true;
      this.txtEmail.Size = new Size(290, 22);
      this.txtEmail.TabIndex = 10;
      this.txtDiaChi.Location = new Point(200, 90);
      this.txtDiaChi.Margin = new Padding(2);
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
      this.txtDiaChi.Size = new Size(290, 22);
      this.txtDiaChi.TabIndex = 9;
      this.txtTenKhachHang.Location = new Point(200, 60);
      this.txtTenKhachHang.Margin = new Padding(2);
      this.txtTenKhachHang.Name = "txtTenKhachHang";
      this.txtTenKhachHang.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtTenKhachHang.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenKhachHang.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenKhachHang.Properties.Appearance.Options.UseFont = true;
      this.txtTenKhachHang.Properties.Appearance.Options.UseTextOptions = true;
      this.txtTenKhachHang.Properties.Appearance.TextOptions.WordWrap = WordWrap.Wrap;
      this.txtTenKhachHang.Size = new Size(290, 22);
      this.txtTenKhachHang.TabIndex = 8;
      this.txtMaKhachHang.Location = new Point(200, 30);
      this.txtMaKhachHang.Margin = new Padding(2);
      this.txtMaKhachHang.Name = "txtMaKhachHang";
      this.txtMaKhachHang.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaKhachHang.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaKhachHang.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaKhachHang.Properties.Appearance.Options.UseFont = true;
      this.txtMaKhachHang.Properties.ReadOnly = true;
      this.txtMaKhachHang.Size = new Size(290, 22);
      this.txtMaKhachHang.TabIndex = 6;
      this.lblPhone.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Location = new Point(87, 153);
      this.lblPhone.Margin = new Padding(2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(39, 16);
      this.lblPhone.TabIndex = 4;
      this.lblPhone.Text = "Phone";
      this.lblEmail.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblEmail.Appearance.Options.UseFont = true;
      this.lblEmail.Location = new Point(87, 123);
      this.lblEmail.Margin = new Padding(2);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new Size(34, 16);
      this.lblEmail.TabIndex = 3;
      this.lblEmail.Text = "Email";
      this.lblAddress.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblAddress.Appearance.Options.UseFont = true;
      this.lblAddress.Location = new Point(87, 93);
      this.lblAddress.Margin = new Padding(2);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new Size(40, 16);
      this.lblAddress.TabIndex = 2;
      this.lblAddress.Text = "Địa chỉ";
      this.lblTenKhachHang.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenKhachHang.Appearance.Options.UseFont = true;
      this.lblTenKhachHang.Location = new Point(87, 63);
      this.lblTenKhachHang.Margin = new Padding(2);
      this.lblTenKhachHang.Name = "lblTenKhachHang";
      this.lblTenKhachHang.Size = new Size(96, 16);
      this.lblTenKhachHang.TabIndex = 1;
      this.lblTenKhachHang.Text = "Tên khách hàng";
      this.lblMaKhachHang.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaKhachHang.Appearance.Options.UseFont = true;
      this.lblMaKhachHang.Location = new Point(87, 33);
      this.lblMaKhachHang.Margin = new Padding(2);
      this.lblMaKhachHang.Name = "lblMaKhachHang";
      this.lblMaKhachHang.Size = new Size(91, 16);
      this.lblMaKhachHang.TabIndex = 0;
      this.lblMaKhachHang.Text = "Mã khách hàng";
      this.pnlCommand.Controls.Add((Control) this.btnClose);
      this.pnlCommand.Controls.Add((Control) this.btnSave);
      this.pnlCommand.Controls.Add((Control) this.btnSaveNew);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 198);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(560, 47);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(353, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 2;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(248, 9);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSaveNew.Appearance.Options.UseFont = true;
      this.btnSaveNew.Location = new Point(115, 9);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 0;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pnlCommand);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewKhachHangView);
      this.Size = new Size(560, 245);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.chkActive.Properties.EndInit();
      this.txtPhone.Properties.EndInit();
      this.txtEmail.Properties.EndInit();
      this.txtDiaChi.Properties.EndInit();
      this.txtTenKhachHang.Properties.EndInit();
      this.txtMaKhachHang.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

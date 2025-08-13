// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewCongTruongView
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
  public class NewCongTruongView : ControlViewBase, INewCongTruongView, IBase
  {
    private NewCongTruongDataPresenter _presenter;
    private string _NewCongTruongCaption = "Thêm Công trường";
    private string _EditCongTruongCaption = "Sửa Công trường";
    private string _ViewCongTruongCaption = "Xem Công trường";
    private ObjCongTruong _ct;
    private IContainer components;
    private PanelControl pnlMain;
    private LabelControl labelControl1;
    private CheckEdit chkActive;
    private TextEdit txtPhone;
    private TextEdit txtDiaChi;
    private TextEdit txtTenCongTruong;
    private TextEdit txtMaCongTruong;
    private LabelControl lblPhone;
    private LabelControl lblAddress;
    private LabelControl lblTenCongTruong;
    private LabelControl lblMaCongTruong;
    private PanelControl pnlCommand;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;

    private bool IsSaveClose { get; set; }

    public ObjCongTruong CongTruong
    {
      set => this._ct = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public NewCongTruongView()
    {
      this.InitializeComponent();
      this._presenter = new NewCongTruongDataPresenter((INewCongTruongView) this);
    }

    public NewCongTruongView(ObjCongTruong ct, Enums.FormAction action)
      : this()
    {
      this._ct = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    protected override void SetupLayout() => this.DisableConstrol();

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewCongTruong();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetCongTruongByKey(this._ct.CongTruongID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaCongTruong.DataBindings.Clear();
      this.txtMaCongTruong.DataBindings.Add("Text", (object) this._ct, "MaCongTruong");
      this.txtTenCongTruong.DataBindings.Clear();
      this.txtTenCongTruong.DataBindings.Add("Text", (object) this._ct, "TenCongTruong");
      this.txtDiaChi.DataBindings.Clear();
      this.txtDiaChi.DataBindings.Add("Text", (object) this._ct, "DiaChi");
      this.txtPhone.DataBindings.Clear();
      this.txtPhone.DataBindings.Add("Text", (object) this._ct, "Phone");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._ct, "Activated");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = this._NewCongTruongCaption;
          break;
        case Enums.FormAction.Edit:
          this.Caption = this._EditCongTruongCaption;
          break;
        case Enums.FormAction.View:
          this.Caption = this._ViewCongTruongCaption;
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaCongTruong.Text == string.Empty)
      {
        this.txtMaCongTruong.ErrorText = GlobalValues.Messages.MaCongTruongIsRequired;
        flag = false;
      }
      if (this.txtTenCongTruong.Text == string.Empty)
      {
        this.txtTenCongTruong.ErrorText = GlobalValues.Messages.TenCongTruongIsRequired;
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
          this.txtMaCongTruong.Properties.ReadOnly = true;
          this.txtTenCongTruong.Properties.ReadOnly = true;
          this.txtDiaChi.Properties.ReadOnly = true;
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
      BindingList<ObjCongTruong> blstCT = new BindingList<ObjCongTruong>();
      blstCT.Add(this._ct);
      this._presenter.SaveCongTruong(blstCT);
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
        this._presenter.BuildNewCongTruong();
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
      TramTronLogger.WriteInfo(sender.ToString());
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
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.labelControl1 = new LabelControl();
      this.chkActive = new CheckEdit();
      this.txtPhone = new TextEdit();
      this.txtDiaChi = new TextEdit();
      this.txtTenCongTruong = new TextEdit();
      this.txtMaCongTruong = new TextEdit();
      this.lblPhone = new LabelControl();
      this.lblAddress = new LabelControl();
      this.lblTenCongTruong = new LabelControl();
      this.lblMaCongTruong = new LabelControl();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.chkActive.Properties.BeginInit();
      this.txtPhone.Properties.BeginInit();
      this.txtDiaChi.Properties.BeginInit();
      this.txtTenCongTruong.Properties.BeginInit();
      this.txtMaCongTruong.Properties.BeginInit();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.pnlCommand);
      this.pnlMain.Controls.Add((Control) this.labelControl1);
      this.pnlMain.Controls.Add((Control) this.chkActive);
      this.pnlMain.Controls.Add((Control) this.txtPhone);
      this.pnlMain.Controls.Add((Control) this.txtDiaChi);
      this.pnlMain.Controls.Add((Control) this.txtTenCongTruong);
      this.pnlMain.Controls.Add((Control) this.txtMaCongTruong);
      this.pnlMain.Controls.Add((Control) this.lblPhone);
      this.pnlMain.Controls.Add((Control) this.lblAddress);
      this.pnlMain.Controls.Add((Control) this.lblTenCongTruong);
      this.pnlMain.Controls.Add((Control) this.lblMaCongTruong);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(495, 245);
      this.pnlMain.TabIndex = 1;
      this.pnlCommand.Controls.Add((Control) this.btnClose);
      this.pnlCommand.Controls.Add((Control) this.btnSave);
      this.pnlCommand.Controls.Add((Control) this.btnSaveNew);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(2, 198);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(491, 45);
      this.pnlCommand.TabIndex = 14;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(312, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 2;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(207, 9);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSaveNew.Appearance.Options.UseFont = true;
      this.btnSaveNew.Location = new Point(74, 9);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 0;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(85, 162);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 13;
      this.labelControl1.Text = "Kích hoạt";
      this.labelControl1.Visible = false;
      this.chkActive.Location = new Point(200, 160);
      this.chkActive.Margin = new Padding(2);
      this.chkActive.Name = "chkActive";
      this.chkActive.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkActive.Properties.Appearance.Options.UseFont = true;
      this.chkActive.Properties.Caption = "";
      this.chkActive.Size = new Size(92, 20);
      this.chkActive.TabIndex = 12;
      this.chkActive.Visible = false;
      this.txtPhone.Location = new Point(200, 130);
      this.txtPhone.Margin = new Padding(2);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPhone.Properties.Appearance.Options.UseFont = true;
      this.txtPhone.Size = new Size(200, 22);
      this.txtPhone.TabIndex = 10;
      this.txtDiaChi.Location = new Point(200, 100);
      this.txtDiaChi.Margin = new Padding(2);
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtDiaChi.Properties.Appearance.Options.UseFont = true;
      this.txtDiaChi.Size = new Size(200, 22);
      this.txtDiaChi.TabIndex = 9;
      this.txtTenCongTruong.Location = new Point(200, 70);
      this.txtTenCongTruong.Margin = new Padding(2);
      this.txtTenCongTruong.Name = "txtTenCongTruong";
      this.txtTenCongTruong.Properties.Appearance.BackColor = Color.White;
      this.txtTenCongTruong.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenCongTruong.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenCongTruong.Properties.Appearance.Options.UseFont = true;
      this.txtTenCongTruong.Size = new Size(200, 22);
      this.txtTenCongTruong.TabIndex = 8;
      this.txtMaCongTruong.Location = new Point(200, 40);
      this.txtMaCongTruong.Margin = new Padding(2);
      this.txtMaCongTruong.Name = "txtMaCongTruong";
      this.txtMaCongTruong.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaCongTruong.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaCongTruong.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaCongTruong.Properties.Appearance.Options.UseFont = true;
      this.txtMaCongTruong.Properties.ReadOnly = true;
      this.txtMaCongTruong.Size = new Size(200, 22);
      this.txtMaCongTruong.TabIndex = 6;
      this.lblPhone.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Location = new Point(85, 133);
      this.lblPhone.Margin = new Padding(2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(39, 16);
      this.lblPhone.TabIndex = 3;
      this.lblPhone.Text = "Phone";
      this.lblAddress.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblAddress.Appearance.Options.UseFont = true;
      this.lblAddress.Location = new Point(85, 103);
      this.lblAddress.Margin = new Padding(2);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new Size(40, 16);
      this.lblAddress.TabIndex = 2;
      this.lblAddress.Text = "Địa chỉ";
      this.lblTenCongTruong.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenCongTruong.Appearance.Options.UseFont = true;
      this.lblTenCongTruong.Location = new Point(85, 73);
      this.lblTenCongTruong.Margin = new Padding(2);
      this.lblTenCongTruong.Name = "lblTenCongTruong";
      this.lblTenCongTruong.Size = new Size(97, 16);
      this.lblTenCongTruong.TabIndex = 1;
      this.lblTenCongTruong.Text = "Tên công trường";
      this.lblMaCongTruong.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaCongTruong.Appearance.Options.UseFont = true;
      this.lblMaCongTruong.Location = new Point(85, 43);
      this.lblMaCongTruong.Margin = new Padding(2);
      this.lblMaCongTruong.Name = "lblMaCongTruong";
      this.lblMaCongTruong.Size = new Size(92, 16);
      this.lblMaCongTruong.TabIndex = 0;
      this.lblMaCongTruong.Text = "Mã công trường";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewCongTruongView);
      this.Size = new Size(495, 245);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.chkActive.Properties.EndInit();
      this.txtPhone.Properties.EndInit();
      this.txtDiaChi.Properties.EndInit();
      this.txtTenCongTruong.Properties.EndInit();
      this.txtMaCongTruong.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}

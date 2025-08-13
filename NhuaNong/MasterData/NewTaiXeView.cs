// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewTaiXeView
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
  public class NewTaiXeView : ControlViewBase, INewTaiXeView, IBase
  {
    private NewTaiXeDataPresenter _presenter;
    private string _NewTaiXeCaption = "Thêm Tài xế";
    private string _EditTaiXeCaption = "Sửa Tài xế";
    private string _ViewTaiXeCaption = "Xem Tài xế";
    private ObjTaiXe _tx;
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl panelControl1;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;
    private LabelControl labelControl1;
    private CheckEdit chkActive;
    private TextEdit txtPhone;
    private TextEdit txtTenTaiXe;
    private TextEdit txtMaTaiXe;
    private LabelControl lblPhone;
    private LabelControl lblTenTaiXe;
    private LabelControl lblMaTaiXe;

    private bool IsSaveClose { get; set; }

    public NewTaiXeView()
    {
      this.InitializeComponent();
      this._presenter = new NewTaiXeDataPresenter((INewTaiXeView) this);
    }

    public NewTaiXeView(ObjTaiXe ct, Enums.FormAction action)
      : this()
    {
      this._tx = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    public ObjTaiXe TaiXe
    {
      set => this._tx = value;
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
          this._presenter.BuildNewTaiXe();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetTaiXeByKey(this._tx.TaiXeID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaTaiXe.DataBindings.Clear();
      this.txtMaTaiXe.DataBindings.Add("Text", (object) this._tx, "MaTaiXe");
      this.txtTenTaiXe.DataBindings.Clear();
      this.txtTenTaiXe.DataBindings.Add("Text", (object) this._tx, "TenTaiXe");
      this.txtPhone.DataBindings.Clear();
      this.txtPhone.DataBindings.Add("Text", (object) this._tx, "Phone");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._tx, "Activated");
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
      if (this.txtMaTaiXe.Text == string.Empty)
      {
        this.txtMaTaiXe.ErrorText = GlobalValues.Messages.MaTaiXeIsRequired;
        flag = false;
      }
      if (this.txtTenTaiXe.Text == string.Empty)
      {
        this.txtTenTaiXe.ErrorText = GlobalValues.Messages.TenTaiXeIsRequired;
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
          this.txtMaTaiXe.Properties.ReadOnly = true;
          this.txtTenTaiXe.Properties.ReadOnly = true;
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
      BindingList<ObjTaiXe> blstCT = new BindingList<ObjTaiXe>();
      blstCT.Add(this._tx);
      this._presenter.SaveTaiXe(blstCT);
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
        this._presenter.BuildNewTaiXe();
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
      this.txtTenTaiXe = new TextEdit();
      this.txtMaTaiXe = new TextEdit();
      this.lblPhone = new LabelControl();
      this.lblTenTaiXe = new LabelControl();
      this.lblMaTaiXe = new LabelControl();
      this.panelControl1 = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.chkActive.Properties.BeginInit();
      this.txtPhone.Properties.BeginInit();
      this.txtTenTaiXe.Properties.BeginInit();
      this.txtMaTaiXe.Properties.BeginInit();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.labelControl1);
      this.pnlMain.Controls.Add((Control) this.chkActive);
      this.pnlMain.Controls.Add((Control) this.txtPhone);
      this.pnlMain.Controls.Add((Control) this.txtTenTaiXe);
      this.pnlMain.Controls.Add((Control) this.txtMaTaiXe);
      this.pnlMain.Controls.Add((Control) this.lblPhone);
      this.pnlMain.Controls.Add((Control) this.lblTenTaiXe);
      this.pnlMain.Controls.Add((Control) this.lblMaTaiXe);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(495, 245);
      this.pnlMain.TabIndex = 0;
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(119, 152);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 21;
      this.labelControl1.Text = "Kích hoạt";
      this.labelControl1.Visible = false;
      this.chkActive.Location = new Point(200, 150);
      this.chkActive.Margin = new Padding(2);
      this.chkActive.Name = "chkActive";
      this.chkActive.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkActive.Properties.Appearance.Options.UseFont = true;
      this.chkActive.Properties.Caption = "";
      this.chkActive.Size = new Size(104, 20);
      this.chkActive.TabIndex = 20;
      this.chkActive.Visible = false;
      this.txtPhone.Location = new Point(200, 120);
      this.txtPhone.Margin = new Padding(2);
      this.txtPhone.Name = "txtPhone";
      this.txtPhone.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtPhone.Properties.Appearance.Options.UseFont = true;
      this.txtPhone.Size = new Size(200, 22);
      this.txtPhone.TabIndex = 19;
      this.txtTenTaiXe.Location = new Point(200, 90);
      this.txtTenTaiXe.Margin = new Padding(2);
      this.txtTenTaiXe.Name = "txtTenTaiXe";
      this.txtTenTaiXe.Properties.Appearance.BackColor = Color.White;
      this.txtTenTaiXe.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenTaiXe.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenTaiXe.Properties.Appearance.Options.UseFont = true;
      this.txtTenTaiXe.Size = new Size(200, 22);
      this.txtTenTaiXe.TabIndex = 18;
      this.txtMaTaiXe.Location = new Point(200, 60);
      this.txtMaTaiXe.Margin = new Padding(2);
      this.txtMaTaiXe.Name = "txtMaTaiXe";
      this.txtMaTaiXe.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaTaiXe.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaTaiXe.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaTaiXe.Properties.Appearance.Options.UseFont = true;
      this.txtMaTaiXe.Properties.ReadOnly = true;
      this.txtMaTaiXe.Size = new Size(200, 22);
      this.txtMaTaiXe.TabIndex = 17;
      this.lblPhone.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblPhone.Appearance.Options.UseFont = true;
      this.lblPhone.Location = new Point(120, 123);
      this.lblPhone.Margin = new Padding(2);
      this.lblPhone.Name = "lblPhone";
      this.lblPhone.Size = new Size(39, 16);
      this.lblPhone.TabIndex = 16;
      this.lblPhone.Text = "Phone";
      this.lblTenTaiXe.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenTaiXe.Appearance.Options.UseFont = true;
      this.lblTenTaiXe.Location = new Point(120, 93);
      this.lblTenTaiXe.Margin = new Padding(2);
      this.lblTenTaiXe.Name = "lblTenTaiXe";
      this.lblTenTaiXe.Size = new Size(58, 16);
      this.lblTenTaiXe.TabIndex = 15;
      this.lblTenTaiXe.Text = "Tên tài xế";
      this.lblMaTaiXe.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaTaiXe.Appearance.Options.UseFont = true;
      this.lblMaTaiXe.Location = new Point(120, 63);
      this.lblMaTaiXe.Margin = new Padding(2);
      this.lblMaTaiXe.Name = "lblMaTaiXe";
      this.lblMaTaiXe.Size = new Size(53, 16);
      this.lblMaTaiXe.TabIndex = 14;
      this.lblMaTaiXe.Text = "Mã tài xế";
      this.panelControl1.Controls.Add((Control) this.btnClose);
      this.panelControl1.Controls.Add((Control) this.btnSave);
      this.panelControl1.Controls.Add((Control) this.btnSaveNew);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(0, 198);
      this.panelControl1.Margin = new Padding(2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(495, 47);
      this.panelControl1.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(312, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(207, 9);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSaveNew.Appearance.Options.UseFont = true;
      this.btnSaveNew.Location = new Point(74, 9);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 3;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.panelControl1);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewTaiXeView);
      this.Size = new Size(495, 245);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.chkActive.Properties.EndInit();
      this.txtPhone.Properties.EndInit();
      this.txtTenTaiXe.Properties.EndInit();
      this.txtMaTaiXe.Properties.EndInit();
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

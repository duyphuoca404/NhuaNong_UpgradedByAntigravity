// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewHangMucView
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
  public class NewHangMucView : ControlViewBase, INewHangMucView, IBase
  {
    private NewHangMucDataPresenter _presenter;
    private string _NewTaiXeCaption = "Thêm Hạng mục";
    private string _EditTaiXeCaption = "Sửa Hạng mục";
    private string _ViewTaiXeCaption = "Xem Hạng mục";
    private ObjHangMuc _hm;
    private IContainer components;
    private PanelControl pnlMain;
    private LabelControl labelControl1;
    private CheckEdit chkActive;
    private TextEdit txtTenHangMuc;
    private TextEdit txtMaHangMuc;
    private LabelControl lblTenHangMuc;
    private LabelControl lblMaHangMuc;
    private PanelControl panelControl1;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;

    private bool IsSaveClose { get; set; }

    public NewHangMucView()
    {
      this.InitializeComponent();
      this._presenter = new NewHangMucDataPresenter((INewHangMucView) this);
    }

    public NewHangMucView(ObjHangMuc ct, Enums.FormAction action)
      : this()
    {
      this._hm = ct;
      this.FormAction = action;
      this.SetCaption();
    }

    public ObjHangMuc HangMuc
    {
      set => this._hm = value;
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
          this._presenter.BuildNewHangMuc();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetHangMucByKey(this._hm.HangMucID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaHangMuc.DataBindings.Clear();
      this.txtMaHangMuc.DataBindings.Add("Text", (object) this._hm, "MaHangMuc");
      this.txtTenHangMuc.DataBindings.Clear();
      this.txtTenHangMuc.DataBindings.Add("Text", (object) this._hm, "TenHangMuc");
      this.chkActive.DataBindings.Clear();
      this.chkActive.DataBindings.Add("Checked", (object) this._hm, "Activated");
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
      if (this.txtMaHangMuc.Text == string.Empty)
      {
        this.txtMaHangMuc.ErrorText = GlobalValues.Messages.MaHangMucIsRequired;
        flag = false;
      }
      if (this.txtTenHangMuc.Text == string.Empty)
      {
        this.txtTenHangMuc.ErrorText = GlobalValues.Messages.TenHangMucIsRequired;
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
          this.txtMaHangMuc.Properties.ReadOnly = true;
          this.txtTenHangMuc.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjHangMuc> blstCT = new BindingList<ObjHangMuc>();
      blstCT.Add(this._hm);
      this._presenter.SaveHangMuc(blstCT);
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
        this._presenter.BuildNewHangMuc();
        this.BindData();
      }
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
      this.txtTenHangMuc = new TextEdit();
      this.txtMaHangMuc = new TextEdit();
      this.lblTenHangMuc = new LabelControl();
      this.lblMaHangMuc = new LabelControl();
      this.panelControl1 = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.chkActive.Properties.BeginInit();
      this.txtTenHangMuc.Properties.BeginInit();
      this.txtMaHangMuc.Properties.BeginInit();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.labelControl1);
      this.pnlMain.Controls.Add((Control) this.chkActive);
      this.pnlMain.Controls.Add((Control) this.txtTenHangMuc);
      this.pnlMain.Controls.Add((Control) this.txtMaHangMuc);
      this.pnlMain.Controls.Add((Control) this.lblTenHangMuc);
      this.pnlMain.Controls.Add((Control) this.lblMaHangMuc);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(495, 200);
      this.pnlMain.TabIndex = 4;
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(92, 122);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 21;
      this.labelControl1.Text = "Kích hoạt";
      this.labelControl1.Visible = false;
      this.chkActive.Location = new Point(200, 120);
      this.chkActive.Margin = new Padding(2);
      this.chkActive.Name = "chkActive";
      this.chkActive.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chkActive.Properties.Appearance.Options.UseFont = true;
      this.chkActive.Properties.Caption = "";
      this.chkActive.Size = new Size(66, 20);
      this.chkActive.TabIndex = 20;
      this.chkActive.Visible = false;
      this.txtTenHangMuc.Location = new Point(200, 90);
      this.txtTenHangMuc.Margin = new Padding(2);
      this.txtTenHangMuc.Name = "txtTenHangMuc";
      this.txtTenHangMuc.Properties.Appearance.BackColor = Color.White;
      this.txtTenHangMuc.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenHangMuc.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenHangMuc.Properties.Appearance.Options.UseFont = true;
      this.txtTenHangMuc.Size = new Size(200, 22);
      this.txtTenHangMuc.TabIndex = 18;
      this.txtMaHangMuc.Location = new Point(200, 60);
      this.txtMaHangMuc.Margin = new Padding(2);
      this.txtMaHangMuc.Name = "txtMaHangMuc";
      this.txtMaHangMuc.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaHangMuc.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaHangMuc.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaHangMuc.Properties.Appearance.Options.UseFont = true;
      this.txtMaHangMuc.Properties.ReadOnly = true;
      this.txtMaHangMuc.Size = new Size(200, 22);
      this.txtMaHangMuc.TabIndex = 17;
      this.lblTenHangMuc.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenHangMuc.Appearance.Options.UseFont = true;
      this.lblTenHangMuc.Location = new Point(92, 94);
      this.lblTenHangMuc.Margin = new Padding(2);
      this.lblTenHangMuc.Name = "lblTenHangMuc";
      this.lblTenHangMuc.Size = new Size(85, 16);
      this.lblTenHangMuc.TabIndex = 15;
      this.lblTenHangMuc.Text = "Tên hạng mục";
      this.lblMaHangMuc.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaHangMuc.Appearance.Options.UseFont = true;
      this.lblMaHangMuc.Location = new Point(92, 64);
      this.lblMaHangMuc.Margin = new Padding(2);
      this.lblMaHangMuc.Name = "lblMaHangMuc";
      this.lblMaHangMuc.Size = new Size(80, 16);
      this.lblMaHangMuc.TabIndex = 14;
      this.lblMaHangMuc.Text = "Mã hạng mục";
      this.panelControl1.Controls.Add((Control) this.btnClose);
      this.panelControl1.Controls.Add((Control) this.btnSave);
      this.panelControl1.Controls.Add((Control) this.btnSaveNew);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(0, 200);
      this.panelControl1.Margin = new Padding(2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(495, 45);
      this.panelControl1.TabIndex = 5;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(310, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 5;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(206, 9);
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
      this.Controls.Add((Control) this.pnlMain);
      this.Controls.Add((Control) this.panelControl1);
      this.Name = nameof (NewHangMucView);
      this.Size = new Size(495, 245);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.chkActive.Properties.EndInit();
      this.txtTenHangMuc.Properties.EndInit();
      this.txtMaHangMuc.Properties.EndInit();
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

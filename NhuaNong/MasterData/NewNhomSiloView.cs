// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.NewNhomSiloView
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
  public class NewNhomSiloView : ControlViewBase, INewNhomSiloView, IBase
  {
    private NewNhomSiloDataPresenter _presenter;
    private ObjNhomSilo _nhomSl;
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl pnlCommand;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;
    private TextEdit txtTenNhomSilo;
    private LabelControl lblTenNhomSilo;
    private TextEdit txtGhiChu;
    private TextEdit txtMaNhomSilo;
    private LabelControl lblGhiChu;
    private LabelControl lblMaNhomSilo;

    private bool IsSaveClose { get; set; }

    public ObjNhomSilo NhomSilo
    {
      set => this._nhomSl = value;
    }

    public bool IsSuccessfulSaved
    {
      set => this.SuccessfullySave(value);
    }

    public NewNhomSiloView()
    {
      this.InitializeComponent();
      this._presenter = new NewNhomSiloDataPresenter((INewNhomSiloView) this);
    }

    public NewNhomSiloView(ObjNhomSilo nhomSl, Enums.FormAction action)
      : this()
    {
      this._nhomSl = nhomSl;
      this.FormAction = action;
      this.SetCaption();
    }

    protected override void SetupLayout() => this.DisableConstrol();

    protected override void PopulateData()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this._presenter.BuildNewNhomSilo();
          break;
        case Enums.FormAction.Edit:
          this._presenter.GetNhomSiloByKey(this._nhomSl.NhomSiloID);
          break;
      }
    }

    protected override void BindData()
    {
      this.txtMaNhomSilo.DataBindings.Clear();
      this.txtMaNhomSilo.DataBindings.Add("Text", (object) this._nhomSl, "MaNhomSilo");
      this.txtTenNhomSilo.DataBindings.Clear();
      this.txtTenNhomSilo.DataBindings.Add("Text", (object) this._nhomSl, "TenNhomSilo");
      this.txtGhiChu.DataBindings.Clear();
      this.txtGhiChu.DataBindings.Add("Text", (object) this._nhomSl, "GhiChu");
    }

    private void SetCaption()
    {
      switch (this.FormAction)
      {
        case Enums.FormAction.New:
          this.Caption = "Thêm Nhóm Silo";
          break;
        case Enums.FormAction.Edit:
          this.Caption = "Sửa Nhóm Silo";
          break;
        case Enums.FormAction.View:
          this.Caption = "Xem Nhóm Silo";
          break;
      }
    }

    private bool ValidateData()
    {
      bool flag = true;
      if (this.txtMaNhomSilo.Text == string.Empty)
      {
        this.txtMaNhomSilo.ErrorText = "Mã Nhóm Silo is required.";
        flag = false;
      }
      if (this.txtTenNhomSilo.Text == string.Empty)
      {
        this.txtTenNhomSilo.ErrorText = "Tên Nhóm Silo is required.";
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
          this.txtMaNhomSilo.Properties.ReadOnly = true;
          this.txtTenNhomSilo.Properties.ReadOnly = true;
          this.txtGhiChu.Properties.ReadOnly = true;
          this.btnSaveNew.Visible = false;
          this.btnSave.Visible = false;
          break;
      }
    }

    private void SaveData()
    {
      if (!this.ValidateData())
        return;
      BindingList<ObjNhomSilo> blstCT = new BindingList<ObjNhomSilo>();
      blstCT.Add(this._nhomSl);
      this._presenter.SaveNhomSilo(blstCT);
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
        this._presenter.BuildNewNhomSilo();
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
      this.txtTenNhomSilo = new TextEdit();
      this.lblTenNhomSilo = new LabelControl();
      this.txtGhiChu = new TextEdit();
      this.txtMaNhomSilo = new TextEdit();
      this.lblGhiChu = new LabelControl();
      this.lblMaNhomSilo = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.txtTenNhomSilo.Properties.BeginInit();
      this.txtGhiChu.Properties.BeginInit();
      this.txtMaNhomSilo.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control) this.txtTenNhomSilo);
      this.pnlMain.Controls.Add((Control) this.lblTenNhomSilo);
      this.pnlMain.Controls.Add((Control) this.txtGhiChu);
      this.pnlMain.Controls.Add((Control) this.txtMaNhomSilo);
      this.pnlMain.Controls.Add((Control) this.lblGhiChu);
      this.pnlMain.Controls.Add((Control) this.lblMaNhomSilo);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2, 2, 2, 2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(495, 245);
      this.pnlMain.TabIndex = 0;
      this.txtTenNhomSilo.Location = new Point(200, 95);
      this.txtTenNhomSilo.Margin = new Padding(2, 2, 2, 2);
      this.txtTenNhomSilo.Name = "txtTenNhomSilo";
      this.txtTenNhomSilo.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtTenNhomSilo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtTenNhomSilo.Properties.Appearance.Options.UseBackColor = true;
      this.txtTenNhomSilo.Properties.Appearance.Options.UseFont = true;
      this.txtTenNhomSilo.Size = new Size(200, 22);
      this.txtTenNhomSilo.TabIndex = 27;
      this.lblTenNhomSilo.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblTenNhomSilo.Appearance.Options.UseFont = true;
      this.lblTenNhomSilo.Location = new Point(91, 98);
      this.lblTenNhomSilo.Margin = new Padding(2, 2, 2, 2);
      this.lblTenNhomSilo.Name = "lblTenNhomSilo";
      this.lblTenNhomSilo.Size = new Size(89, 16);
      this.lblTenNhomSilo.TabIndex = 26;
      this.lblTenNhomSilo.Text = "Tên Nhóm Silo";
      this.txtGhiChu.Location = new Point(200, 125);
      this.txtGhiChu.Margin = new Padding(2, 2, 2, 2);
      this.txtGhiChu.Name = "txtGhiChu";
      this.txtGhiChu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtGhiChu.Properties.Appearance.Options.UseFont = true;
      this.txtGhiChu.Size = new Size(200, 22);
      this.txtGhiChu.TabIndex = 25;
      this.txtMaNhomSilo.Location = new Point(200, 65);
      this.txtMaNhomSilo.Margin = new Padding(2, 2, 2, 2);
      this.txtMaNhomSilo.Name = "txtMaNhomSilo";
      this.txtMaNhomSilo.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaNhomSilo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.txtMaNhomSilo.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaNhomSilo.Properties.Appearance.Options.UseFont = true;
      this.txtMaNhomSilo.Size = new Size(200, 22);
      this.txtMaNhomSilo.TabIndex = 23;
      this.lblGhiChu.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblGhiChu.Appearance.Options.UseFont = true;
      this.lblGhiChu.Location = new Point(91, 128);
      this.lblGhiChu.Margin = new Padding(2, 2, 2, 2);
      this.lblGhiChu.Name = "lblGhiChu";
      this.lblGhiChu.Size = new Size(44, 16);
      this.lblGhiChu.TabIndex = 22;
      this.lblGhiChu.Text = "Ghi chú";
      this.lblMaNhomSilo.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.lblMaNhomSilo.Appearance.Options.UseFont = true;
      this.lblMaNhomSilo.Location = new Point(91, 68);
      this.lblMaNhomSilo.Margin = new Padding(2, 2, 2, 2);
      this.lblMaNhomSilo.Name = "lblMaNhomSilo";
      this.lblMaNhomSilo.Size = new Size(84, 16);
      this.lblMaNhomSilo.TabIndex = 20;
      this.lblMaNhomSilo.Text = "Mã Nhóm Silo";
      this.pnlCommand.Controls.Add((Control) this.btnClose);
      this.pnlCommand.Controls.Add((Control) this.btnSave);
      this.pnlCommand.Controls.Add((Control) this.btnSaveNew);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 198);
      this.pnlCommand.Margin = new Padding(2, 2, 2, 2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(495, 47);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(312, 9);
      this.btnClose.Margin = new Padding(2, 2, 2, 2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 8;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(207, 9);
      this.btnSave.Margin = new Padding(2, 2, 2, 2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.btnSaveNew.Appearance.Options.UseFont = true;
      this.btnSaveNew.Location = new Point(74, 9);
      this.btnSaveNew.Margin = new Padding(2, 2, 2, 2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 6;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.pnlCommand);
      this.Controls.Add((Control) this.pnlMain);
      this.Name = nameof (NewNhomSiloView);
      this.Size = new Size(495, 245);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.txtTenNhomSilo.Properties.EndInit();
      this.txtGhiChu.Properties.EndInit();
      this.txtMaNhomSilo.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

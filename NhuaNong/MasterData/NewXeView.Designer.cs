using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using NhuaNong.Data;
using NhuaNong.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace NhuaNong.MasterData
{
  public partial class NewXeView
  {
    private IContainer components;
    private PanelControl pnlMain;
    private PanelControl pnlCommand;
    private LabelControl labelControl1;
    private CheckEdit chkActive;
    private TextEdit txtBienSo;
    private LabelControl lblGhiChu;
    private LabelControl lblBienSo;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;
    private LabelControl lblTrongTaiXe;
    private SpinEdit spnKhoiLuong;
    private MemoEdit memGhiChu;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlMain = new PanelControl();
      this.memGhiChu = new MemoEdit();
      this.spnKhoiLuong = new SpinEdit();
      this.lblTrongTaiXe = new LabelControl();
      this.labelControl1 = new LabelControl();
      this.chkActive = new CheckEdit();
      this.txtBienSo = new TextEdit();
      this.lblGhiChu = new LabelControl();
      this.lblBienSo = new LabelControl();
      this.pnlCommand = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.memGhiChu.Properties.BeginInit();
      this.spnKhoiLuong.Properties.BeginInit();
      this.chkActive.Properties.BeginInit();
      this.txtBienSo.Properties.BeginInit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.SuspendLayout();
      this.pnlMain.Controls.Add((Control)this.memGhiChu);
      this.pnlMain.Controls.Add((Control)this.spnKhoiLuong);
      this.pnlMain.Controls.Add((Control)this.lblTrongTaiXe);
      this.pnlMain.Controls.Add((Control)this.labelControl1);
      this.pnlMain.Controls.Add((Control)this.chkActive);
      this.pnlMain.Controls.Add((Control)this.txtBienSo);
      this.pnlMain.Controls.Add((Control)this.lblGhiChu);
      this.pnlMain.Controls.Add((Control)this.lblBienSo);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Margin = new Padding(2);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(495, 245);
      this.pnlMain.TabIndex = 0;
      this.memGhiChu.Location = new Point(200, 100);
      this.memGhiChu.Margin = new Padding(2);
      this.memGhiChu.Name = "memGhiChu";
      this.memGhiChu.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.memGhiChu.Properties.Appearance.Options.UseFont = true;
      this.memGhiChu.Properties.Appearance.Options.UseTextOptions = true;
      this.memGhiChu.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
      this.memGhiChu.Size = new Size(200, 49);
      this.memGhiChu.TabIndex = 30;
      this.spnKhoiLuong.EditValue = (object)new Decimal(new int[4]);
      this.spnKhoiLuong.Location = new Point(200, 70);
      this.spnKhoiLuong.Margin = new Padding(2);
      this.spnKhoiLuong.Name = "spnKhoiLuong";
      this.spnKhoiLuong.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.spnKhoiLuong.Properties.Appearance.Options.UseFont = true;
      this.spnKhoiLuong.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnKhoiLuong.Size = new Size(107, 22);
      this.spnKhoiLuong.TabIndex = 29;
      this.spnKhoiLuong.EditValueChanged += new EventHandler(this.spnKhoiLuong_EditValueChanged);
      this.lblTrongTaiXe.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblTrongTaiXe.Appearance.Options.UseFont = true;
      this.lblTrongTaiXe.Location = new Point(100, 73);
      this.lblTrongTaiXe.Margin = new Padding(2);
      this.lblTrongTaiXe.Name = "lblTrongTaiXe";
      this.lblTrongTaiXe.Size = new Size(70, 16);
      this.lblTrongTaiXe.TabIndex = 28;
      this.lblTrongTaiXe.Text = "Trọng tải xe";
      this.labelControl1.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.labelControl1.Appearance.Options.UseFont = true;
      this.labelControl1.Location = new Point(116, 161);
      this.labelControl1.Margin = new Padding(2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(54, 16);
      this.labelControl1.TabIndex = 27;
      this.labelControl1.Text = "Kích hoạt";
      this.labelControl1.Visible = false;
      this.chkActive.Location = new Point(200, 159);
      this.chkActive.Margin = new Padding(2);
      this.chkActive.Name = "chkActive";
      this.chkActive.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.chkActive.Properties.Appearance.Options.UseFont = true;
      this.chkActive.Properties.Caption = "";
      this.chkActive.Size = new Size(119, 20);
      this.chkActive.TabIndex = 26;
      this.chkActive.Visible = false;
      this.txtBienSo.Location = new Point(200, 40);
      this.txtBienSo.Margin = new Padding(2);
      this.txtBienSo.Name = "txtBienSo";
      this.txtBienSo.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtBienSo.Properties.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.txtBienSo.Properties.Appearance.Options.UseBackColor = true;
      this.txtBienSo.Properties.Appearance.Options.UseFont = true;
      this.txtBienSo.Size = new Size(200, 22);
      this.txtBienSo.TabIndex = 24;
      this.lblGhiChu.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblGhiChu.Appearance.Options.UseFont = true;
      this.lblGhiChu.Location = new Point(126, 102);
      this.lblGhiChu.Margin = new Padding(2);
      this.lblGhiChu.Name = "lblGhiChu";
      this.lblGhiChu.Size = new Size(44, 16);
      this.lblGhiChu.TabIndex = 23;
      this.lblGhiChu.Text = "Ghi chú";
      this.lblBienSo.Appearance.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.lblBienSo.Appearance.Options.UseFont = true;
      this.lblBienSo.Location = new Point(125, 43);
      this.lblBienSo.Margin = new Padding(2);
      this.lblBienSo.Name = "lblBienSo";
      this.lblBienSo.Size = new Size(45, 16);
      this.lblBienSo.TabIndex = 22;
      this.lblBienSo.Text = "Biển số";
      this.pnlCommand.Controls.Add((Control)this.btnClose);
      this.pnlCommand.Controls.Add((Control)this.btnSave);
      this.pnlCommand.Controls.Add((Control)this.btnSaveNew);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 198);
      this.pnlCommand.Margin = new Padding(2);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(495, 47);
      this.pnlCommand.TabIndex = 1;
      this.btnClose.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnClose.Appearance.Options.UseFont = true;
      this.btnClose.Location = new Point(313, 9);
      this.btnClose.Margin = new Padding(2);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(98, 30);
      this.btnClose.TabIndex = 8;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSave.Appearance.Options.UseFont = true;
      this.btnSave.Location = new Point(208, 9);
      this.btnSave.Margin = new Padding(2);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(98, 30);
      this.btnSave.TabIndex = 7;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Appearance.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
      this.btnSaveNew.Appearance.Options.UseFont = true;
      this.btnSaveNew.Location = new Point(74, 9);
      this.btnSaveNew.Margin = new Padding(2);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(126, 30);
      this.btnSaveNew.TabIndex = 6;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.pnlCommand);
      this.Controls.Add((Control)this.pnlMain);
      this.Name = "NewXeView";
      this.Size = new Size(495, 245);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.pnlMain.PerformLayout();
      this.memGhiChu.Properties.EndInit();
      this.spnKhoiLuong.Properties.EndInit();
      this.chkActive.Properties.EndInit();
      this.txtBienSo.Properties.EndInit();
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

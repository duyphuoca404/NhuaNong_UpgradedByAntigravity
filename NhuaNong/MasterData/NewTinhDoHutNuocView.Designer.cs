using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
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
  public partial class NewTinhDoHutNuocView
  {
    private IContainer components;
    private PanelControl pnlCommand;
    private PanelControl panelControl1;
    private SimpleButton btnClose;
    private SimpleButton btnSave;
    private SimpleButton btnSaveNew;
    private PanelControl pnlMain;
    private GroupControl grcThongSoSang;
    private GroupControl grcDoHutNuoc;
    private LabelControl labelControl2;
    private LabelControl labelControl1;
    private LabelControl labelControl6;
    private LabelControl labelControl5;
    private LabelControl labelControl4;
    private LabelControl labelControl3;
    private TextEdit txtMaTinhDoHutNuoc;
    private TextEdit txtDesc;
    private SpinEdit spnDHN;
    private DateEdit datNgayTinhDoHut;
    private LookUpEdit lueNhomSilo;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlCommand = new PanelControl();
      this.panelControl1 = new PanelControl();
      this.btnClose = new SimpleButton();
      this.btnSave = new SimpleButton();
      this.btnSaveNew = new SimpleButton();
      this.pnlMain = new PanelControl();
      this.grcThongSoSang = new GroupControl();
      this.grcDoHutNuoc = new GroupControl();
      this.labelControl1 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.labelControl3 = new LabelControl();
      this.labelControl4 = new LabelControl();
      this.labelControl5 = new LabelControl();
      this.labelControl6 = new LabelControl();
      this.txtMaTinhDoHutNuoc = new TextEdit();
      this.txtDesc = new TextEdit();
      this.datNgayTinhDoHut = new DateEdit();
      this.spnDHN = new SpinEdit();
      this.lueNhomSilo = new LookUpEdit();
      this.pnlCommand.BeginInit();
      this.pnlCommand.SuspendLayout();
      this.panelControl1.BeginInit();
      this.panelControl1.SuspendLayout();
      this.pnlMain.BeginInit();
      this.pnlMain.SuspendLayout();
      this.grcThongSoSang.BeginInit();
      this.grcDoHutNuoc.BeginInit();
      this.grcDoHutNuoc.SuspendLayout();
      this.txtMaTinhDoHutNuoc.Properties.BeginInit();
      this.txtDesc.Properties.BeginInit();
      this.datNgayTinhDoHut.Properties.CalendarTimeProperties.BeginInit();
      this.datNgayTinhDoHut.Properties.BeginInit();
      this.spnDHN.Properties.BeginInit();
      this.lueNhomSilo.Properties.BeginInit();
      this.SuspendLayout();
      this.pnlCommand.Controls.Add((Control)this.panelControl1);
      this.pnlCommand.Dock = DockStyle.Bottom;
      this.pnlCommand.Location = new Point(0, 442);
      this.pnlCommand.Name = "pnlCommand";
      this.pnlCommand.Size = new Size(900, 58);
      this.pnlCommand.TabIndex = 2;
      this.panelControl1.Controls.Add((Control)this.btnClose);
      this.panelControl1.Controls.Add((Control)this.btnSave);
      this.panelControl1.Controls.Add((Control)this.btnSaveNew);
      this.panelControl1.Dock = DockStyle.Bottom;
      this.panelControl1.Location = new Point(2, -2);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new Size(896, 58);
      this.panelControl1.TabIndex = 15;
      this.btnClose.Location = new Point(723, 19);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new Size(131, 29);
      this.btnClose.TabIndex = 2;
      this.btnClose.Text = "Đóng";
      this.btnClose.Click += new EventHandler(this.btnClose_Click);
      this.btnSave.Location = new Point(583, 19);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new Size(131, 29);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Lưu";
      this.btnSave.Click += new EventHandler(this.btnSave_Click);
      this.btnSaveNew.Location = new Point(406, 19);
      this.btnSaveNew.Name = "btnSaveNew";
      this.btnSaveNew.Size = new Size(168, 29);
      this.btnSaveNew.TabIndex = 0;
      this.btnSaveNew.Text = "Lưu và Thêm Mới";
      this.btnSaveNew.Click += new EventHandler(this.btnSaveNew_Click);
      this.pnlMain.Controls.Add((Control)this.grcThongSoSang);
      this.pnlMain.Controls.Add((Control)this.grcDoHutNuoc);
      this.pnlMain.Dock = DockStyle.Fill;
      this.pnlMain.Location = new Point(0, 0);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new Size(900, 442);
      this.pnlMain.TabIndex = 3;
      this.grcThongSoSang.Dock = DockStyle.Fill;
      this.grcThongSoSang.Location = new Point(2, 162);
      this.grcThongSoSang.Name = "grcThongSoSang";
      this.grcThongSoSang.Size = new Size(896, 278);
      this.grcThongSoSang.TabIndex = 1;
      this.grcThongSoSang.Text = "Thông số sàng";
      this.grcDoHutNuoc.Controls.Add((Control)this.lueNhomSilo);
      this.grcDoHutNuoc.Controls.Add((Control)this.spnDHN);
      this.grcDoHutNuoc.Controls.Add((Control)this.datNgayTinhDoHut);
      this.grcDoHutNuoc.Controls.Add((Control)this.txtDesc);
      this.grcDoHutNuoc.Controls.Add((Control)this.txtMaTinhDoHutNuoc);
      this.grcDoHutNuoc.Controls.Add((Control)this.labelControl6);
      this.grcDoHutNuoc.Controls.Add((Control)this.labelControl5);
      this.grcDoHutNuoc.Controls.Add((Control)this.labelControl4);
      this.grcDoHutNuoc.Controls.Add((Control)this.labelControl3);
      this.grcDoHutNuoc.Controls.Add((Control)this.labelControl2);
      this.grcDoHutNuoc.Controls.Add((Control)this.labelControl1);
      this.grcDoHutNuoc.Dock = DockStyle.Top;
      this.grcDoHutNuoc.Location = new Point(2, 2);
      this.grcDoHutNuoc.Name = "grcDoHutNuoc";
      this.grcDoHutNuoc.Size = new Size(896, 160);
      this.grcDoHutNuoc.TabIndex = 0;
      this.grcDoHutNuoc.Text = "Độ Hút Nước";
      this.labelControl1.Location = new Point(68, 51);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(98, 17);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "Mã độ hút nước";
      this.labelControl2.Location = new Point(82, 99);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(84, 17);
      this.labelControl2.TabIndex = 1;
      this.labelControl2.Text = "Nhóm vật liệu";
      this.labelControl3.Location = new Point(376, 51);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(56, 17);
      this.labelControl3.TabIndex = 2;
      this.labelControl3.Text = "Ngày tạo";
      this.labelControl4.Location = new Point(382, 99);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(50, 17);
      this.labelControl4.TabIndex = 3;
      this.labelControl4.Text = "Diễn giải";
      this.labelControl5.Location = new Point(647, 99);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(79, 17);
      this.labelControl5.TabIndex = 4;
      this.labelControl5.Text = "Độ hút nước";
      this.labelControl6.Location = new Point(124, 136);
      this.labelControl6.Name = "labelControl6";
      this.labelControl6.Size = new Size(42, 16);
      this.labelControl6.TabIndex = 5;
      this.labelControl6.Text = "Ghi chú";
      this.txtMaTinhDoHutNuoc.Location = new Point(175, 48);
      this.txtMaTinhDoHutNuoc.Name = "txtMaTinhDoHutNuoc";
      this.txtMaTinhDoHutNuoc.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtMaTinhDoHutNuoc.Properties.Appearance.Options.UseBackColor = true;
      this.txtMaTinhDoHutNuoc.Properties.ReadOnly = true;
      this.txtMaTinhDoHutNuoc.Size = new Size(179, 22);
      this.txtMaTinhDoHutNuoc.TabIndex = 7;
      this.txtDesc.Location = new Point(445, 96);
      this.txtDesc.Name = "txtDesc";
      this.txtDesc.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.txtDesc.Properties.Appearance.Options.UseBackColor = true;
      this.txtDesc.Properties.ReadOnly = true;
      this.txtDesc.Size = new Size(179, 22);
      this.txtDesc.TabIndex = 8;
      this.datNgayTinhDoHut.EditValue = (object)null;
      this.datNgayTinhDoHut.Location = new Point(445, 48);
      this.datNgayTinhDoHut.Name = "datNgayTinhDoHut";
      this.datNgayTinhDoHut.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.datNgayTinhDoHut.Properties.Appearance.Options.UseBackColor = true;
      this.datNgayTinhDoHut.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayTinhDoHut.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.datNgayTinhDoHut.Size = new Size(179, 22);
      this.datNgayTinhDoHut.TabIndex = 9;
      this.spnDHN.EditValue = (object)new Decimal(new int[4]);
      this.spnDHN.Location = new Point(743, 95);
      this.spnDHN.Name = "spnDHN";
      this.spnDHN.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.spnDHN.Properties.Appearance.Options.UseBackColor = true;
      this.spnDHN.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.spnDHN.Properties.DisplayFormat.FormatString = "n2";
      this.spnDHN.Properties.DisplayFormat.FormatType = FormatType.Numeric;
      this.spnDHN.Properties.EditFormat.FormatString = "n2";
      this.spnDHN.Properties.EditFormat.FormatType = FormatType.Numeric;
      this.spnDHN.Size = new Size(132, 24);
      this.spnDHN.TabIndex = 10;
      this.lueNhomSilo.Location = new Point(175, 97);
      this.lueNhomSilo.Name = "lueNhomSilo";
      this.lueNhomSilo.Properties.Appearance.BackColor = Color.FromArgb(220, 233, 252);
      this.lueNhomSilo.Properties.Appearance.Options.UseBackColor = true;
      this.lueNhomSilo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueNhomSilo.Properties.Columns.AddRange(new LookUpColumnInfo[3]
      {
        new LookUpColumnInfo("NhomSiloID", "ID", 20, FormatType.None, "", false, HorzAlignment.Default, ColumnSortOrder.None, DefaultBoolean.Default),
        new LookUpColumnInfo("MaNhomSilo", "Mã Nhóm Silo"),
        new LookUpColumnInfo("TenNhomSilo", "Tên Nhóm Silo")
      });
      this.lueNhomSilo.Properties.DisplayMember = "TenNhomSilo";
      this.lueNhomSilo.Properties.NullText = "";
      this.lueNhomSilo.Properties.ValueMember = "NhomSiloID";
      this.lueNhomSilo.Size = new Size(179, 22);
      this.lueNhomSilo.TabIndex = 11;
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.pnlMain);
      this.Controls.Add((Control)this.pnlCommand);
      this.Name = "NewTinhDoHutNuocView";
      this.Size = new Size(900, 500);
      this.pnlCommand.EndInit();
      this.pnlCommand.ResumeLayout(false);
      this.panelControl1.EndInit();
      this.panelControl1.ResumeLayout(false);
      this.pnlMain.EndInit();
      this.pnlMain.ResumeLayout(false);
      this.grcThongSoSang.EndInit();
      this.grcDoHutNuoc.EndInit();
      this.grcDoHutNuoc.ResumeLayout(false);
      this.grcDoHutNuoc.PerformLayout();
      this.txtMaTinhDoHutNuoc.Properties.EndInit();
      this.txtDesc.Properties.EndInit();
      this.datNgayTinhDoHut.Properties.CalendarTimeProperties.EndInit();
      this.datNgayTinhDoHut.Properties.EndInit();
      this.spnDHN.Properties.EndInit();
      this.lueNhomSilo.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}

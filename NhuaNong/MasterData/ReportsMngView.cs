// Decompiled with JetBrains decompiler
// Type: NhuaNong.MasterData.ReportsMngView
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong.MasterData
{
  public class ReportsMngView : ControlViewBase, IBase, IPermission
  {
    private IContainer components;
    private DateEdit dateEdit1;
    private LabelControl labelControl1;
    private LabelControl labelControl2;
    private DateEdit dateEdit2;
    private LabelControl labelControl3;
    private GroupBox groupBox1;
    private LookUpEdit lookUpEdit2;
    private LabelControl labelControl4;
    private LookUpEdit lookUpEdit1;
    private GroupBox groupBox2;
    private SimpleButton simpleButton2;
    private SimpleButton simpleButton1;
    private LookUpEdit lookUpEdit3;
    private LabelControl labelControl5;

    public ReportsMngView() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.dateEdit1 = new DateEdit();
      this.labelControl1 = new LabelControl();
      this.labelControl2 = new LabelControl();
      this.dateEdit2 = new DateEdit();
      this.labelControl3 = new LabelControl();
      this.groupBox1 = new GroupBox();
      this.simpleButton2 = new SimpleButton();
      this.simpleButton1 = new SimpleButton();
      this.lookUpEdit3 = new LookUpEdit();
      this.labelControl5 = new LabelControl();
      this.lookUpEdit2 = new LookUpEdit();
      this.labelControl4 = new LabelControl();
      this.lookUpEdit1 = new LookUpEdit();
      this.groupBox2 = new GroupBox();
      this.dateEdit1.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit1.Properties.BeginInit();
      this.dateEdit2.Properties.CalendarTimeProperties.BeginInit();
      this.dateEdit2.Properties.BeginInit();
      this.groupBox1.SuspendLayout();
      this.lookUpEdit3.Properties.BeginInit();
      this.lookUpEdit2.Properties.BeginInit();
      this.lookUpEdit1.Properties.BeginInit();
      this.SuspendLayout();
      this.dateEdit1.EditValue = (object) null;
      this.dateEdit1.Location = new Point(87, 28);
      this.dateEdit1.Name = "dateEdit1";
      this.dateEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit1.Size = new Size(124, 20);
      this.dateEdit1.TabIndex = 0;
      this.labelControl1.Location = new Point(22, 31);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(59, 13);
      this.labelControl1.TabIndex = 1;
      this.labelControl1.Text = "Tạo từ ngày";
      this.labelControl2.Location = new Point(34, 59);
      this.labelControl2.Name = "labelControl2";
      this.labelControl2.Size = new Size(47, 13);
      this.labelControl2.TabIndex = 2;
      this.labelControl2.Text = "Đến ngày";
      this.dateEdit2.EditValue = (object) null;
      this.dateEdit2.Location = new Point(87, 56);
      this.dateEdit2.Name = "dateEdit2";
      this.dateEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.dateEdit2.Size = new Size(124, 20);
      this.dateEdit2.TabIndex = 3;
      this.labelControl3.Location = new Point(25, 88);
      this.labelControl3.Name = "labelControl3";
      this.labelControl3.Size = new Size(56, 13);
      this.labelControl3.TabIndex = 4;
      this.labelControl3.Text = "Khách hàng";
      this.groupBox1.Controls.Add((Control) this.simpleButton2);
      this.groupBox1.Controls.Add((Control) this.simpleButton1);
      this.groupBox1.Controls.Add((Control) this.lookUpEdit3);
      this.groupBox1.Controls.Add((Control) this.labelControl5);
      this.groupBox1.Controls.Add((Control) this.lookUpEdit2);
      this.groupBox1.Controls.Add((Control) this.labelControl4);
      this.groupBox1.Controls.Add((Control) this.lookUpEdit1);
      this.groupBox1.Controls.Add((Control) this.labelControl3);
      this.groupBox1.Controls.Add((Control) this.dateEdit2);
      this.groupBox1.Controls.Add((Control) this.labelControl2);
      this.groupBox1.Controls.Add((Control) this.labelControl1);
      this.groupBox1.Controls.Add((Control) this.dateEdit1);
      this.groupBox1.Location = new Point(3, 48);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(230, 282);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Lọc phếu trộn";
      this.simpleButton2.Location = new Point(34, 182);
      this.simpleButton2.Name = "simpleButton2";
      this.simpleButton2.Size = new Size(82, 23);
      this.simpleButton2.TabIndex = 11;
      this.simpleButton2.Text = "Làm mới";
      this.simpleButton1.Location = new Point(129, 182);
      this.simpleButton1.Name = "simpleButton1";
      this.simpleButton1.Size = new Size(82, 23);
      this.simpleButton1.TabIndex = 10;
      this.simpleButton1.Text = "Tìm kiếm";
      this.lookUpEdit3.Location = new Point(87, 140);
      this.lookUpEdit3.Name = "lookUpEdit3";
      this.lookUpEdit3.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit3.Properties.NullText = "";
      this.lookUpEdit3.Size = new Size(124, 20);
      this.lookUpEdit3.TabIndex = 9;
      this.labelControl5.Location = new Point(69, 143);
      this.labelControl5.Name = "labelControl5";
      this.labelControl5.Size = new Size(12, 13);
      this.labelControl5.TabIndex = 8;
      this.labelControl5.Text = "Xe";
      this.lookUpEdit2.Location = new Point(87, 114);
      this.lookUpEdit2.Name = "lookUpEdit2";
      this.lookUpEdit2.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit2.Properties.NullText = "";
      this.lookUpEdit2.Size = new Size(124, 20);
      this.lookUpEdit2.TabIndex = 7;
      this.labelControl4.Location = new Point(59, 117);
      this.labelControl4.Name = "labelControl4";
      this.labelControl4.Size = new Size(22, 13);
      this.labelControl4.TabIndex = 6;
      this.labelControl4.Text = "MAC";
      this.lookUpEdit1.Location = new Point(87, 85);
      this.lookUpEdit1.Name = "lookUpEdit1";
      this.lookUpEdit1.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lookUpEdit1.Properties.NullText = "";
      this.lookUpEdit1.Size = new Size(124, 20);
      this.lookUpEdit1.TabIndex = 5;
      this.groupBox2.Location = new Point(238, 48);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(567, 282);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Báo cáo";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.Name = nameof (ReportsMngView);
      this.Size = new Size(833, 369);
      this.dateEdit1.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit1.Properties.EndInit();
      this.dateEdit2.Properties.CalendarTimeProperties.EndInit();
      this.dateEdit2.Properties.EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.lookUpEdit3.Properties.EndInit();
      this.lookUpEdit2.Properties.EndInit();
      this.lookUpEdit1.Properties.EndInit();
      this.ResumeLayout(false);
    }
  }
}

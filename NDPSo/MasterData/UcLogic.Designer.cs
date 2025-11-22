using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPSo.MasterData
{
  public partial class UcLogic
  {
    private IContainer components;
    private LabelControl labelControl1;
    private LookUpEdit lueFrom;
    private LookUpEdit lueTo;
    private SimpleButton btnSend;
    private SimpleButton btnReset;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.labelControl1 = new LabelControl();
      this.lueFrom = new LookUpEdit();
      this.lueTo = new LookUpEdit();
      this.btnSend = new SimpleButton();
      this.btnReset = new SimpleButton();
      this.lueFrom.Properties.BeginInit();
      this.lueTo.Properties.BeginInit();
      this.SuspendLayout();
      this.labelControl1.Location = new Point(374, 9);
      this.labelControl1.Margin = new Padding(2, 2, 2, 2);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new Size(4, 13);
      this.labelControl1.TabIndex = 0;
      this.labelControl1.Text = "/";
      this.lueFrom.Location = new Point(9, 6);
      this.lueFrom.Margin = new Padding(2, 2, 2, 2);
      this.lueFrom.Name = "lueFrom";
      this.lueFrom.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueFrom.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("MaSilo", "Mã"),
        new LookUpColumnInfo("TenSilo", "Tên")
      });
      this.lueFrom.Properties.DisplayMember = "MaSilo";
      this.lueFrom.Properties.NullText = "";
      this.lueFrom.Properties.ValueMember = "MaSilo";
      this.lueFrom.Size = new Size(94, 20);
      this.lueFrom.TabIndex = 1;
      this.lueTo.Location = new Point(112, 6);
      this.lueTo.Margin = new Padding(2, 2, 2, 2);
      this.lueTo.Name = "lueTo";
      this.lueTo.Properties.Buttons.AddRange(new EditorButton[1]
      {
        new EditorButton(ButtonPredefines.Combo)
      });
      this.lueTo.Properties.Columns.AddRange(new LookUpColumnInfo[2]
      {
        new LookUpColumnInfo("MaSilo", "Mã"),
        new LookUpColumnInfo("TenSilo", "Tên")
      });
      this.lueTo.Properties.DisplayMember = "MaSilo";
      this.lueTo.Properties.NullText = "";
      this.lueTo.Properties.ValueMember = "MaSilo";
      this.lueTo.Size = new Size(94, 20);
      this.lueTo.TabIndex = 2;
      this.btnSend.Location = new Point(217, 4);
      this.btnSend.Margin = new Padding(2, 2, 2, 2);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new Size(70, 24);
      this.btnSend.TabIndex = 3;
      this.btnSend.Text = "Thiết lập";
      this.btnSend.Click += new EventHandler(this.btnSend_Click);
      this.btnReset.Location = new Point(292, 3);
      this.btnReset.Margin = new Padding(2, 2, 2, 2);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new Size(70, 24);
      this.btnReset.TabIndex = 4;
      this.btnReset.Text = "Làm mới";
      this.btnReset.Click += new EventHandler(this.btnReset_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.btnReset);
      this.Controls.Add((Control)this.btnSend);
      this.Controls.Add((Control)this.lueTo);
      this.Controls.Add((Control)this.lueFrom);
      this.Controls.Add((Control)this.labelControl1);
      this.Margin = new Padding(2, 2, 2, 2);
      this.Name = "UcLogic";
      this.Size = new Size(505, 30);
      this.lueFrom.Properties.EndInit();
      this.lueTo.Properties.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhuaNong
{
  public partial class UcSearchBase
  {
    private IContainer components;
    private PanelControl pnlContainer;
    private GroupControl groupControl1;
    private SimpleButton btnSelect;
    private SimpleButton btnCancel;
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.pnlContainer = new PanelControl();
      this.groupControl1 = new GroupControl();
      this.btnCancel = new SimpleButton();
      this.btnSelect = new SimpleButton();
      this.pnlContainer.BeginInit();
      this.groupControl1.BeginInit();
      this.groupControl1.SuspendLayout();
      this.SuspendLayout();
      this.pnlContainer.Dock = DockStyle.Fill;
      this.pnlContainer.Location = new Point(0, 0);
      this.pnlContainer.Margin = new Padding(2);
      this.pnlContainer.Name = "pnlContainer";
      this.pnlContainer.Size = new Size(902, 544);
      this.pnlContainer.TabIndex = 0;
      this.groupControl1.Controls.Add((Control)this.btnCancel);
      this.groupControl1.Controls.Add((Control)this.btnSelect);
      this.groupControl1.Dock = DockStyle.Bottom;
      this.groupControl1.Location = new Point(0, 497);
      this.groupControl1.Margin = new Padding(2);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.ShowCaption = false;
      this.groupControl1.Size = new Size(902, 47);
      this.groupControl1.TabIndex = 1;
      this.groupControl1.Text = "groupControl1";
      this.btnCancel.Location = new Point(734, 14);
      this.btnCancel.Margin = new Padding(2);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(80, 24);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Huỷ";
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnSelect.Location = new Point(635, 14);
      this.btnSelect.Margin = new Padding(2);
      this.btnSelect.Name = "btnSelect";
      this.btnSelect.Size = new Size(80, 24);
      this.btnSelect.TabIndex = 0;
      this.btnSelect.Text = "Chọn";
      this.btnSelect.Click += new EventHandler(this.btnSelect_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control)this.groupControl1);
      this.Controls.Add((Control)this.pnlContainer);
      this.Name = "UcSearchBase";
      this.Size = new Size(902, 544);
      this.pnlContainer.EndInit();
      this.groupControl1.EndInit();
      this.groupControl1.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}

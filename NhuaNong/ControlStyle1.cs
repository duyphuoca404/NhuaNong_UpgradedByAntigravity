// Decompiled with JetBrains decompiler
// Type: NhuaNong.ControlStyle1
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public class ControlStyle1 : ControlViewBase
  {
    protected GroupControl groupControl1;
    protected GroupControl groupControl2;
    protected GroupControl grpCommand;
    protected GroupControl grpStatus;
    private IContainer components;

    public ControlStyle1() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.groupControl1 = new GroupControl();
      this.groupControl2 = new GroupControl();
      this.grpCommand = new GroupControl();
      this.grpStatus = new GroupControl();
      this.groupControl1.BeginInit();
      this.groupControl2.BeginInit();
      this.grpCommand.BeginInit();
      this.grpStatus.BeginInit();
      this.SuspendLayout();
      this.groupControl1.Dock = DockStyle.Top;
      this.groupControl1.Location = new Point(0, 0);
      this.groupControl1.Name = "groupControl1";
      this.groupControl1.Size = new Size(700, 100);
      this.groupControl1.TabIndex = 0;
      this.groupControl1.Text = "grpMaster";
      this.groupControl2.Dock = DockStyle.Fill;
      this.groupControl2.Location = new Point(0, 100);
      this.groupControl2.Name = "groupControl2";
      this.groupControl2.Size = new Size(700, 326);
      this.groupControl2.TabIndex = 1;
      this.groupControl2.Text = "grpDetails";
      this.grpCommand.Dock = DockStyle.Bottom;
      this.grpCommand.Location = new Point(0, 426);
      this.grpCommand.Name = "grpCommand";
      this.grpCommand.ShowCaption = false;
      this.grpCommand.Size = new Size(700, 47);
      this.grpCommand.TabIndex = 2;
      this.grpCommand.Text = "grpCommand";
      this.grpStatus.Dock = DockStyle.Bottom;
      this.grpStatus.Location = new Point(0, 473);
      this.grpStatus.Name = "grpStatus";
      this.grpStatus.ShowCaption = false;
      this.grpStatus.Size = new Size(700, 27);
      this.grpStatus.TabIndex = 3;
      this.grpStatus.Text = "groupControl3";
      this.grpStatus.Visible = false;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.Controls.Add((Control) this.groupControl2);
      this.Controls.Add((Control) this.grpCommand);
      this.Controls.Add((Control) this.groupControl1);
      this.Controls.Add((Control) this.grpStatus);
      this.Name = nameof (ControlStyle1);
      this.Size = new Size(700, 500);
      this.groupControl1.EndInit();
      this.groupControl2.EndInit();
      this.grpCommand.EndInit();
      this.grpStatus.EndInit();
      this.ResumeLayout(false);
    }
  }
}

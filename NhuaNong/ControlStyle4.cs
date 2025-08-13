// Decompiled with JetBrains decompiler
// Type: NhuaNong.ControlStyle4
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public class ControlStyle4 : ControlViewBase
  {
    private IContainer components;
    private BarManager barManager1;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private GroupControl grpMaster;
    private GroupControl grpStatus;
    private GroupControl grpSearch;

    public ControlStyle4() => this.InitializeComponent();

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = (IContainer) new System.ComponentModel.Container();
      this.barManager1 = new BarManager(this.components);
      this.barDockControlTop = new BarDockControl();
      this.barDockControlBottom = new BarDockControl();
      this.barDockControlLeft = new BarDockControl();
      this.barDockControlRight = new BarDockControl();
      this.grpSearch = new GroupControl();
      this.grpStatus = new GroupControl();
      this.grpMaster = new GroupControl();
      this.barManager1.BeginInit();
      this.grpSearch.BeginInit();
      this.grpStatus.BeginInit();
      this.grpMaster.BeginInit();
      this.SuspendLayout();
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = (Control) this;
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = DockStyle.Top;
      this.barDockControlTop.Location = new Point(0, 0);
      this.barDockControlTop.Manager = this.barManager1;
      this.barDockControlTop.Size = new Size(1019, 0);
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = DockStyle.Bottom;
      this.barDockControlBottom.Location = new Point(0, 534);
      this.barDockControlBottom.Manager = this.barManager1;
      this.barDockControlBottom.Size = new Size(1019, 0);
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = DockStyle.Left;
      this.barDockControlLeft.Location = new Point(0, 0);
      this.barDockControlLeft.Manager = this.barManager1;
      this.barDockControlLeft.Size = new Size(0, 534);
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = DockStyle.Right;
      this.barDockControlRight.Location = new Point(1019, 0);
      this.barDockControlRight.Manager = this.barManager1;
      this.barDockControlRight.Size = new Size(0, 534);
      this.grpSearch.AllowDrop = true;
      this.grpSearch.AllowTouchScroll = true;
      this.grpSearch.Dock = DockStyle.Top;
      this.grpSearch.Location = new Point(0, 0);
      this.grpSearch.Name = "grpSearch";
      this.grpSearch.Size = new Size(1019, 186);
      this.grpSearch.TabIndex = 4;
      this.grpSearch.Text = "Search";
      this.grpStatus.AllowDrop = true;
      this.grpStatus.Dock = DockStyle.Bottom;
      this.grpStatus.Location = new Point(0, 463);
      this.grpStatus.Name = "grpStatus";
      this.grpStatus.Size = new Size(1019, 71);
      this.grpStatus.TabIndex = 5;
      this.grpStatus.Text = "groupControl1";
      this.grpMaster.AllowDrop = true;
      this.grpMaster.AllowTouchScroll = true;
      this.grpMaster.Appearance.Options.UseFont = true;
      this.grpMaster.AppearanceCaption.Options.UseFont = true;
      this.grpMaster.Dock = DockStyle.Fill;
      this.grpMaster.Location = new Point(0, 186);
      this.grpMaster.Name = "grpMaster";
      this.grpMaster.Size = new Size(1019, 277);
      this.grpMaster.TabIndex = 6;
      this.grpMaster.Text = "Master Infos";
      this.AllowDrop = true;
      this.AutoScaleDimensions = new SizeF(8f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoValidate = AutoValidate.EnableAllowFocusChange;
      this.Controls.Add((Control) this.grpMaster);
      this.Controls.Add((Control) this.grpStatus);
      this.Controls.Add((Control) this.grpSearch);
      this.Controls.Add((Control) this.barDockControlLeft);
      this.Controls.Add((Control) this.barDockControlRight);
      this.Controls.Add((Control) this.barDockControlBottom);
      this.Controls.Add((Control) this.barDockControlTop);
      this.Name = nameof (ControlStyle4);
      this.Size = new Size(1019, 534);
      this.barManager1.EndInit();
      this.grpSearch.EndInit();
      this.grpStatus.EndInit();
      this.grpMaster.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }
  }
}

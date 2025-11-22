// Decompiled with JetBrains decompiler
// Type: NhuaNong.From
// Assembly: NhuaNong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 864E41B2-15EB-48AE-BEF5-3E9E35B58E35
// Assembly location: C:\Users\phuoc\OneDrive\Desktop\Desktop\Reverse VACM_Be tong nhua nong\Extract .msi to .dll\SourceDir\NhuaNong.exe

using DevExpress.XtraBars;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace NhuaNong
{
  public partial class From : TabForm
  {
    private static int OpenFormCount = 1;
    //private IContainer components;
    //private TabFormControl tabFormControl1;
    //private TabFormDefaultManager tabFormDefaultManager1;
    //private BarDockControl barDockControlTop;
    //private BarDockControl barDockControlBottom;
    //private BarDockControl barDockControlLeft;
    //private BarDockControl barDockControlRight;
    //private BarSubItem bsiSystem;
    //private BarSubItem barSubItem1;
    //private BarSubItem barSubItem2;
    //private BarSubItem barSubItem3;
    //private BarSubItem barSubItem4;
    //private BarSubItem barSubItem5;
    //private BarSubItem barSubItem6;

    public From()
    {
      InitializeComponent();
      this.Name = nameof(From);
      this.Text = nameof(From);
    }

    public void EnabledCloseAllDocs()
    {
    }

    //protected override void Dispose(bool disposing)
    //{
    //  bool designMode = this.DesignMode;
    //  if (disposing && this.components != null)
    //    this.components.Dispose();
    //  base.Dispose(disposing);
    //  if (--From.OpenFormCount != 0 || designMode)
    //    return;
    //  Application.Exit();
    //}

    //private void InitializeComponent()
    //{
    //  this.tabFormControl1 = new TabFormControl();
    //  this.bsiSystem = new BarSubItem();
    //  this.barSubItem1 = new BarSubItem();
    //  this.barSubItem2 = new BarSubItem();
    //  this.barSubItem3 = new BarSubItem();
    //  this.barSubItem4 = new BarSubItem();
    //  this.barSubItem5 = new BarSubItem();
    //  this.barSubItem6 = new BarSubItem();
    //  this.tabFormDefaultManager1 = new TabFormDefaultManager();
    //  this.barDockControlTop = new BarDockControl();
    //  this.barDockControlBottom = new BarDockControl();
    //  this.barDockControlLeft = new BarDockControl();
    //  this.barDockControlRight = new BarDockControl();
    //  this.tabFormControl1.BeginInit();
    //  this.tabFormDefaultManager1.BeginInit();
    //  this.SuspendLayout();
    //  this.tabFormControl1.Items.AddRange(new BarItem[7]
    //  {
    //    (BarItem) this.bsiSystem,
    //    (BarItem) this.barSubItem1,
    //    (BarItem) this.barSubItem2,
    //    (BarItem) this.barSubItem3,
    //    (BarItem) this.barSubItem4,
    //    (BarItem) this.barSubItem5,
    //    (BarItem) this.barSubItem6
    //  });
    //  this.tabFormControl1.Location = new Point(0, 0);
    //  this.tabFormControl1.Manager = (BarManager) this.tabFormDefaultManager1;
    //  this.tabFormControl1.Margin = new Padding(3, 4, 3, 4);
    //  this.tabFormControl1.Name = "tabFormControl1";
    //  this.tabFormControl1.Size = new Size(730, 88);
    //  this.tabFormControl1.TabForm = (TabForm) this;
    //  this.tabFormControl1.TabIndex = 0;
    //  this.tabFormControl1.TabLeftItemLinks.Add((BarItem) this.bsiSystem);
    //  this.tabFormControl1.TabLeftItemLinks.Add((BarItem) this.barSubItem1);
    //  this.tabFormControl1.TabLeftItemLinks.Add((BarItem) this.barSubItem2);
    //  this.tabFormControl1.TabLeftItemLinks.Add((BarItem) this.barSubItem3);
    //  this.tabFormControl1.TabLeftItemLinks.Add((BarItem) this.barSubItem4);
    //  this.tabFormControl1.TabLeftItemLinks.Add((BarItem) this.barSubItem5);
    //  this.tabFormControl1.TabLeftItemLinks.Add((BarItem) this.barSubItem6);
    //  this.tabFormControl1.TabStop = false;
    //  this.bsiSystem.Caption = "Hệ Thống";
    //  this.bsiSystem.Id = 0;
    //  this.bsiSystem.Name = "bsiSystem";
    //  this.barSubItem1.Caption = "Quản Lý";
    //  this.barSubItem1.Id = 1;
    //  this.barSubItem1.Name = "barSubItem1";
    //  this.barSubItem2.Caption = "Thông Số";
    //  this.barSubItem2.Id = 2;
    //  this.barSubItem2.Name = "barSubItem2";
    //  this.barSubItem3.Caption = "Danh Mục";
    //  this.barSubItem3.Id = 3;
    //  this.barSubItem3.Name = "barSubItem3";
    //  this.barSubItem4.Caption = "Vận Hành";
    //  this.barSubItem4.Id = 4;
    //  this.barSubItem4.Name = "barSubItem4";
    //  this.barSubItem5.Caption = "Phân Quyền";
    //  this.barSubItem5.Id = 5;
    //  this.barSubItem5.Name = "barSubItem5";
    //  this.barSubItem6.Caption = "Trợ Giúp";
    //  this.barSubItem6.Id = 6;
    //  this.barSubItem6.Name = "barSubItem6";
    //  this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
    //  this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
    //  this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
    //  this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
    //  this.tabFormDefaultManager1.DockingEnabled = false;
    //  this.tabFormDefaultManager1.Form = (Control) this;
    //  this.tabFormDefaultManager1.Items.AddRange(new BarItem[7]
    //  {
    //    (BarItem) this.bsiSystem,
    //    (BarItem) this.barSubItem1,
    //    (BarItem) this.barSubItem2,
    //    (BarItem) this.barSubItem3,
    //    (BarItem) this.barSubItem4,
    //    (BarItem) this.barSubItem5,
    //    (BarItem) this.barSubItem6
    //  });
    //  this.tabFormDefaultManager1.MaxItemId = 7;
    //  this.barDockControlTop.CausesValidation = false;
    //  this.barDockControlTop.Dock = DockStyle.Top;
    //  this.barDockControlTop.Location = new Point(0, 88);
    //  this.barDockControlTop.Manager = (BarManager) null;
    //  this.barDockControlTop.Margin = new Padding(3, 4, 3, 4);
    //  this.barDockControlTop.Size = new Size(730, 0);
    //  this.barDockControlBottom.CausesValidation = false;
    //  this.barDockControlBottom.Dock = DockStyle.Bottom;
    //  this.barDockControlBottom.Location = new Point(0, 429);
    //  this.barDockControlBottom.Manager = (BarManager) null;
    //  this.barDockControlBottom.Margin = new Padding(3, 4, 3, 4);
    //  this.barDockControlBottom.Size = new Size(730, 0);
    //  this.barDockControlLeft.CausesValidation = false;
    //  this.barDockControlLeft.Dock = DockStyle.Left;
    //  this.barDockControlLeft.Location = new Point(0, 88);
    //  this.barDockControlLeft.Manager = (BarManager) null;
    //  this.barDockControlLeft.Margin = new Padding(3, 4, 3, 4);
    //  this.barDockControlLeft.Size = new Size(0, 341);
    //  this.barDockControlRight.CausesValidation = false;
    //  this.barDockControlRight.Dock = DockStyle.Right;
    //  this.barDockControlRight.Location = new Point(730, 88);
    //  this.barDockControlRight.Manager = (BarManager) null;
    //  this.barDockControlRight.Margin = new Padding(3, 4, 3, 4);
    //  this.barDockControlRight.Size = new Size(0, 341);
    //  this.AutoScaleDimensions = new SizeF(7f, 16f);
    //  this.AutoScaleMode = AutoScaleMode.Font;
    //  this.ClientSize = new Size(730, 429);
    //  this.Controls.Add((Control) this.barDockControlLeft);
    //  this.Controls.Add((Control) this.barDockControlRight);
    //  this.Controls.Add((Control) this.barDockControlBottom);
    //  this.Controls.Add((Control) this.barDockControlTop);
    //  this.Controls.Add((Control) this.tabFormControl1);
    //  this.Margin = new Padding(3, 4, 3, 4);
    //  this.Name = nameof (From);
    //  this.TabFormControl = this.tabFormControl1;
    //  this.Text = "Form1";
    //  this.tabFormControl1.EndInit();
    //  this.tabFormDefaultManager1.EndInit();
    //  this.ResumeLayout(false);
    //  this.PerformLayout();
    //}
  }
}

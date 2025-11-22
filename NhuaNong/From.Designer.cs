using DevExpress.XtraBars;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong
{
  public partial class From : TabForm
  {
    private IContainer components;
    private TabFormControl tabFormControl1;
    private TabFormDefaultManager tabFormDefaultManager1;
    private BarDockControl barDockControlTop;
    private BarDockControl barDockControlBottom;
    private BarDockControl barDockControlLeft;
    private BarDockControl barDockControlRight;
    private BarSubItem bsiSystem;
    private BarSubItem barSubItem1;
    private BarSubItem barSubItem2;
    private BarSubItem barSubItem3;
    private BarSubItem barSubItem4;
    private BarSubItem barSubItem5;
    private BarSubItem barSubItem6;


    protected override void Dispose(bool disposing)
    {
      bool designMode = this.DesignMode;
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
      if (--From.OpenFormCount != 0 || designMode)
        return;
      Application.Exit();
    }

    private void InitializeComponent()
    {
      this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
      this.bsiSystem = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
      this.barSubItem6 = new DevExpress.XtraBars.BarSubItem();
      this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // tabFormControl1
      // 
      this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiSystem,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barSubItem5,
            this.barSubItem6});
      this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
      this.tabFormControl1.Manager = this.tabFormDefaultManager1;
      this.tabFormControl1.Name = "tabFormControl1";
      this.tabFormControl1.Size = new System.Drawing.Size(626, 71);
      this.tabFormControl1.TabForm = this;
      this.tabFormControl1.TabIndex = 0;
      this.tabFormControl1.TabLeftItemLinks.Add(this.bsiSystem);
      this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem1);
      this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem2);
      this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem3);
      this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem4);
      this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem5);
      this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem6);
      this.tabFormControl1.TabStop = false;
      // 
      // bsiSystem
      // 
      this.bsiSystem.Caption = "Hệ Thống";
      this.bsiSystem.Id = 0;
      this.bsiSystem.Name = "bsiSystem";
      // 
      // barSubItem1
      // 
      this.barSubItem1.Caption = "Quản Lý";
      this.barSubItem1.Id = 1;
      this.barSubItem1.Name = "barSubItem1";
      // 
      // barSubItem2
      // 
      this.barSubItem2.Caption = "Thông Số";
      this.barSubItem2.Id = 2;
      this.barSubItem2.Name = "barSubItem2";
      // 
      // barSubItem3
      // 
      this.barSubItem3.Caption = "Danh Mục";
      this.barSubItem3.Id = 3;
      this.barSubItem3.Name = "barSubItem3";
      // 
      // barSubItem4
      // 
      this.barSubItem4.Caption = "Vận Hành";
      this.barSubItem4.Id = 4;
      this.barSubItem4.Name = "barSubItem4";
      // 
      // barSubItem5
      // 
      this.barSubItem5.Caption = "Phân Quyền";
      this.barSubItem5.Id = 5;
      this.barSubItem5.Name = "barSubItem5";
      // 
      // barSubItem6
      // 
      this.barSubItem6.Caption = "Trợ Giúp";
      this.barSubItem6.Id = 6;
      this.barSubItem6.Name = "barSubItem6";
      // 
      // tabFormDefaultManager1
      // 
      this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
      this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
      this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
      this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
      this.tabFormDefaultManager1.DockingEnabled = false;
      this.tabFormDefaultManager1.Form = this;
      this.tabFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bsiSystem,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barSubItem5,
            this.barSubItem6});
      this.tabFormDefaultManager1.MaxItemId = 7;
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 71);
      this.barDockControlTop.Manager = null;
      this.barDockControlTop.Size = new System.Drawing.Size(626, 0);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 349);
      this.barDockControlBottom.Manager = null;
      this.barDockControlBottom.Size = new System.Drawing.Size(626, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 71);
      this.barDockControlLeft.Manager = null;
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 278);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(626, 71);
      this.barDockControlRight.Manager = null;
      this.barDockControlRight.Size = new System.Drawing.Size(0, 278);
      // 
      // From
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(626, 349);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Controls.Add(this.tabFormControl1);
      this.Name = "From";
      this.TabFormControl = this.tabFormControl1;
      this.Text = "Form";
      ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }




    //// Token: 0x060000CA RID: 202 RVA: 0x0000F884 File Offset: 0x0000DA84
    //protected override void Dispose(bool disposing)
    //{
    //	bool designMode = base.DesignMode;
    //	if (disposing && this.components != null)
    //	{
    //		this.components.Dispose();
    //	}
    //	base.Dispose(disposing);
    //	if (--global::NhuaNong.From.OpenFormCount == 0 && !designMode)
    //	{
    //		global::System.Windows.Forms.Application.Exit();
    //	}
    //}

    //// Token: 0x060000CB RID: 203 RVA: 0x0000F8CC File Offset: 0x0000DACC
    //private void InitializeComponent()
    //{
    //	this.tabFormControl1 = new global::DevExpress.XtraBars.TabFormControl();
    //	this.bsiSystem = new global::DevExpress.XtraBars.BarSubItem();
    //	this.barSubItem1 = new global::DevExpress.XtraBars.BarSubItem();
    //	this.barSubItem2 = new global::DevExpress.XtraBars.BarSubItem();
    //	this.barSubItem3 = new global::DevExpress.XtraBars.BarSubItem();
    //	this.barSubItem4 = new global::DevExpress.XtraBars.BarSubItem();
    //	this.barSubItem5 = new global::DevExpress.XtraBars.BarSubItem();
    //	this.barSubItem6 = new global::DevExpress.XtraBars.BarSubItem();
    //	this.tabFormDefaultManager1 = new global::DevExpress.XtraBars.TabFormDefaultManager();
    //	this.barDockControlTop = new global::DevExpress.XtraBars.BarDockControl();
    //	this.barDockControlBottom = new global::DevExpress.XtraBars.BarDockControl();
    //	this.barDockControlLeft = new global::DevExpress.XtraBars.BarDockControl();
    //	this.barDockControlRight = new global::DevExpress.XtraBars.BarDockControl();
    //	((global::System.ComponentModel.ISupportInitialize)this.tabFormControl1).BeginInit();
    //	((global::System.ComponentModel.ISupportInitialize)this.tabFormDefaultManager1).BeginInit();
    //	base.SuspendLayout();
    //	this.tabFormControl1.Items.AddRange(new global::DevExpress.XtraBars.BarItem[]
    //	{
    //		this.bsiSystem,
    //		this.barSubItem1,
    //		this.barSubItem2,
    //		this.barSubItem3,
    //		this.barSubItem4,
    //		this.barSubItem5,
    //		this.barSubItem6
    //	});
    //	this.tabFormControl1.Location = new global::System.Drawing.Point(0, 0);
    //	this.tabFormControl1.Manager = this.tabFormDefaultManager1;
    //	this.tabFormControl1.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
    //	this.tabFormControl1.Name = "tabFormControl1";
    //	this.tabFormControl1.Size = new global::System.Drawing.Size(730, 88);
    //	this.tabFormControl1.TabForm = this;
    //	this.tabFormControl1.TabIndex = 0;
    //	this.tabFormControl1.TabLeftItemLinks.Add(this.bsiSystem);
    //	this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem1);
    //	this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem2);
    //	this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem3);
    //	this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem4);
    //	this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem5);
    //	this.tabFormControl1.TabLeftItemLinks.Add(this.barSubItem6);
    //	this.tabFormControl1.TabStop = false;
    //	this.bsiSystem.Caption = "Hệ Thống";
    //	this.bsiSystem.Id = 0;
    //	this.bsiSystem.Name = "bsiSystem";
    //	this.barSubItem1.Caption = "Quản Lý";
    //	this.barSubItem1.Id = 1;
    //	this.barSubItem1.Name = "barSubItem1";
    //	this.barSubItem2.Caption = "Thông Số";
    //	this.barSubItem2.Id = 2;
    //	this.barSubItem2.Name = "barSubItem2";
    //	this.barSubItem3.Caption = "Danh Mục";
    //	this.barSubItem3.Id = 3;
    //	this.barSubItem3.Name = "barSubItem3";
    //	this.barSubItem4.Caption = "Vận Hành";
    //	this.barSubItem4.Id = 4;
    //	this.barSubItem4.Name = "barSubItem4";
    //	this.barSubItem5.Caption = "Phân Quyền";
    //	this.barSubItem5.Id = 5;
    //	this.barSubItem5.Name = "barSubItem5";
    //	this.barSubItem6.Caption = "Trợ Giúp";
    //	this.barSubItem6.Id = 6;
    //	this.barSubItem6.Name = "barSubItem6";
    //	this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
    //	this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
    //	this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
    //	this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
    //	this.tabFormDefaultManager1.DockingEnabled = false;
    //	this.tabFormDefaultManager1.Form = this;
    //	this.tabFormDefaultManager1.Items.AddRange(new global::DevExpress.XtraBars.BarItem[]
    //	{
    //		this.bsiSystem,
    //		this.barSubItem1,
    //		this.barSubItem2,
    //		this.barSubItem3,
    //		this.barSubItem4,
    //		this.barSubItem5,
    //		this.barSubItem6
    //	});
    //	this.tabFormDefaultManager1.MaxItemId = 7;
    //	this.barDockControlTop.CausesValidation = false;
    //	this.barDockControlTop.Dock = global::System.Windows.Forms.DockStyle.Top;
    //	this.barDockControlTop.Location = new global::System.Drawing.Point(0, 88);
    //	this.barDockControlTop.Manager = null;
    //	this.barDockControlTop.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
    //	this.barDockControlTop.Size = new global::System.Drawing.Size(730, 0);
    //	this.barDockControlBottom.CausesValidation = false;
    //	this.barDockControlBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
    //	this.barDockControlBottom.Location = new global::System.Drawing.Point(0, 429);
    //	this.barDockControlBottom.Manager = null;
    //	this.barDockControlBottom.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
    //	this.barDockControlBottom.Size = new global::System.Drawing.Size(730, 0);
    //	this.barDockControlLeft.CausesValidation = false;
    //	this.barDockControlLeft.Dock = global::System.Windows.Forms.DockStyle.Left;
    //	this.barDockControlLeft.Location = new global::System.Drawing.Point(0, 88);
    //	this.barDockControlLeft.Manager = null;
    //	this.barDockControlLeft.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
    //	this.barDockControlLeft.Size = new global::System.Drawing.Size(0, 341);
    //	this.barDockControlRight.CausesValidation = false;
    //	this.barDockControlRight.Dock = global::System.Windows.Forms.DockStyle.Right;
    //	this.barDockControlRight.Location = new global::System.Drawing.Point(730, 88);
    //	this.barDockControlRight.Manager = null;
    //	this.barDockControlRight.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
    //	this.barDockControlRight.Size = new global::System.Drawing.Size(0, 341);
    //	base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
    //	base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
    //	base.ClientSize = new global::System.Drawing.Size(730, 429);
    //	base.Controls.Add(this.barDockControlLeft);
    //	base.Controls.Add(this.barDockControlRight);
    //	base.Controls.Add(this.barDockControlBottom);
    //	base.Controls.Add(this.barDockControlTop);
    //	base.Controls.Add(this.tabFormControl1);
    //	base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
    //	base.Name = "From";
    //	base.TabFormControl = this.tabFormControl1;
    //	this.Text = "Form1";
    //	((global::System.ComponentModel.ISupportInitialize)this.tabFormControl1).EndInit();
    //	((global::System.ComponentModel.ISupportInitialize)this.tabFormDefaultManager1).EndInit();
    //	base.ResumeLayout(false);
    //	base.PerformLayout();
    //}

    //// Token: 0x04000104 RID: 260
    //private static int OpenFormCount = 1;

    //// Token: 0x04000105 RID: 261
    //private global::System.ComponentModel.IContainer components;

    //// Token: 0x04000106 RID: 262
    //private global::DevExpress.XtraBars.TabFormControl tabFormControl1;

    //// Token: 0x04000107 RID: 263
    //private global::DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;

    //// Token: 0x04000108 RID: 264
    //private global::DevExpress.XtraBars.BarDockControl barDockControlTop;

    //// Token: 0x04000109 RID: 265
    //private global::DevExpress.XtraBars.BarDockControl barDockControlBottom;

    //// Token: 0x0400010A RID: 266
    //private global::DevExpress.XtraBars.BarDockControl barDockControlLeft;

    //// Token: 0x0400010B RID: 267
    //private global::DevExpress.XtraBars.BarDockControl barDockControlRight;

    //// Token: 0x0400010C RID: 268
    //private global::DevExpress.XtraBars.BarSubItem bsiSystem;

    //// Token: 0x0400010D RID: 269
    //private global::DevExpress.XtraBars.BarSubItem barSubItem1;

    //// Token: 0x0400010E RID: 270
    //private global::DevExpress.XtraBars.BarSubItem barSubItem2;

    //// Token: 0x0400010F RID: 271
    //private global::DevExpress.XtraBars.BarSubItem barSubItem3;

    //// Token: 0x04000110 RID: 272
    //private global::DevExpress.XtraBars.BarSubItem barSubItem4;

    //// Token: 0x04000111 RID: 273
    //private global::DevExpress.XtraBars.BarSubItem barSubItem5;

    //// Token: 0x04000112 RID: 274
    //private global::DevExpress.XtraBars.BarSubItem barSubItem6;
  }
}

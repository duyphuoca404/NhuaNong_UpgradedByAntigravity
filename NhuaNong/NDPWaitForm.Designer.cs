using DevExpress.Utils.Animation;
using DevExpress.XtraWaitForm;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace NhuaNong
{
  public partial class NDPWaitForm : WaitForm
  {
    private IContainer components;
    private ProgressPanel progressPanel1;
    private TableLayoutPanel tableLayoutPanel1;


    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.progressPanel1 = new ProgressPanel();
      this.tableLayoutPanel1 = new TableLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      this.progressPanel1.Appearance.BackColor = Color.Transparent;
      this.progressPanel1.Appearance.Options.UseBackColor = true;
      this.progressPanel1.AppearanceCaption.Font = new Font("Microsoft Sans Serif", 12f);
      this.progressPanel1.AppearanceCaption.Options.UseFont = true;
      this.progressPanel1.AppearanceDescription.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.progressPanel1.AppearanceDescription.Options.UseFont = true;
      this.progressPanel1.Caption = "Vui lòng đợi giây lát";
      this.progressPanel1.Cursor = Cursors.Default;
      this.progressPanel1.Description = "Đang tải dữ liệu ...";
      this.progressPanel1.Dock = DockStyle.Fill;
      this.progressPanel1.ImageHorzOffset = 20;
      this.progressPanel1.Location = new Point(0, 17);
      this.progressPanel1.Margin = new Padding(0, 3, 0, 3);
      this.progressPanel1.Name = "progressPanel1";
      this.progressPanel1.Size = new Size(246, 39);
      this.progressPanel1.TabIndex = 0;
      this.progressPanel1.Text = "progressPanel1";
      this.progressPanel1.WaitAnimationType = WaitingAnimatorType.Ring;
      this.tableLayoutPanel1.AutoSize = true;
      this.tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel1.BackColor = Color.Transparent;
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel1.Controls.Add((Control)this.progressPanel1, 0, 0);
      this.tableLayoutPanel1.Dock = DockStyle.Fill;
      this.tableLayoutPanel1.Location = new Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.Padding = new Padding(0, 14, 0, 14);
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
      this.tableLayoutPanel1.Size = new Size(246, 73);
      this.tableLayoutPanel1.TabIndex = 1;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoSize = true;
      this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      this.ClientSize = new Size(246, 73);
      this.Controls.Add((Control)this.tableLayoutPanel1);
      this.DoubleBuffered = true;
      this.Name = "NDPWaitForm";
      this.StartPosition = FormStartPosition.Manual;
      this.Text = "Form1";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }





    //// Token: 0x06000057 RID: 87 RVA: 0x0000517F File Offset: 0x0000337F
    //protected override void Dispose(bool disposing)
    //{
    //	if (disposing && this.components != null)
    //	{
    //		this.components.Dispose();
    //	}
    //	base.Dispose(disposing);
    //}

    //// Token: 0x06000058 RID: 88 RVA: 0x000051A0 File Offset: 0x000033A0
    //private void InitializeComponent()
    //{
    //	this.progressPanel1 = new global::DevExpress.XtraWaitForm.ProgressPanel();
    //	this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
    //	this.tableLayoutPanel1.SuspendLayout();
    //	base.SuspendLayout();
    //	this.progressPanel1.Appearance.BackColor = global::System.Drawing.Color.Transparent;
    //	this.progressPanel1.Appearance.Options.UseBackColor = true;
    //	this.progressPanel1.AppearanceCaption.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
    //	this.progressPanel1.AppearanceCaption.Options.UseFont = true;
    //	this.progressPanel1.AppearanceDescription.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
    //	this.progressPanel1.AppearanceDescription.Options.UseFont = true;
    //	this.progressPanel1.Caption = "Vui lòng đợi giây lát";
    //	this.progressPanel1.Cursor = global::System.Windows.Forms.Cursors.Default;
    //	this.progressPanel1.Description = "Đang tải dữ liệu ...";
    //	this.progressPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
    //	this.progressPanel1.ImageHorzOffset = 20;
    //	this.progressPanel1.Location = new global::System.Drawing.Point(0, 17);
    //	this.progressPanel1.Margin = new global::System.Windows.Forms.Padding(0, 3, 0, 3);
    //	this.progressPanel1.Name = "progressPanel1";
    //	this.progressPanel1.Size = new global::System.Drawing.Size(246, 39);
    //	this.progressPanel1.TabIndex = 0;
    //	this.progressPanel1.Text = "progressPanel1";
    //	this.progressPanel1.WaitAnimationType = global::DevExpress.Utils.Animation.WaitingAnimatorType.Ring;
    //	this.tableLayoutPanel1.AutoSize = true;
    //	this.tableLayoutPanel1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    //	this.tableLayoutPanel1.BackColor = global::System.Drawing.Color.Transparent;
    //	this.tableLayoutPanel1.ColumnCount = 1;
    //	this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
    //	this.tableLayoutPanel1.Controls.Add(this.progressPanel1, 0, 0);
    //	this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
    //	this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
    //	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
    //	this.tableLayoutPanel1.Padding = new global::System.Windows.Forms.Padding(0, 14, 0, 14);
    //	this.tableLayoutPanel1.RowCount = 1;
    //	this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
    //	this.tableLayoutPanel1.Size = new global::System.Drawing.Size(246, 73);
    //	this.tableLayoutPanel1.TabIndex = 1;
    //	base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
    //	base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
    //	this.AutoSize = true;
    //	base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    //	base.ClientSize = new global::System.Drawing.Size(246, 73);
    //	base.Controls.Add(this.tableLayoutPanel1);
    //	this.DoubleBuffered = true;
    //	base.Name = "NDPWaitForm";
    //	base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
    //	this.Text = "Form1";
    //	this.tableLayoutPanel1.ResumeLayout(false);
    //	base.ResumeLayout(false);
    //	base.PerformLayout();
    //}

    //// Token: 0x04000042 RID: 66
    //private global::System.ComponentModel.IContainer components;

    //// Token: 0x04000043 RID: 67
    //private global::DevExpress.XtraWaitForm.ProgressPanel progressPanel1;

    //// Token: 0x04000044 RID: 68
    //private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
  }
}

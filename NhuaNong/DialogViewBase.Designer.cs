using System.ComponentModel;
using DevExpress.XtraEditors;
using NhuaNong.Utils;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong
{
  public partial class DialogViewBase : XtraForm
  {
    private IContainer components;
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(7f, 16f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(507, 260);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DialogViewBase";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "DialogViewBase";
      this.ResumeLayout(false);
    }



    //// Token: 0x0600004C RID: 76 RVA: 0x00004B38 File Offset: 0x00002D38
    //protected override void Dispose(bool disposing)
    //{
    //	if (disposing && this.components != null)
    //	{
    //		this.components.Dispose();
    //	}
    //	base.Dispose(disposing);
    //}

    //// Token: 0x0600004D RID: 77 RVA: 0x00004B58 File Offset: 0x00002D58
    //private void InitializeComponent()
    //{
    //	base.SuspendLayout();
    //	base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
    //	base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
    //	base.ClientSize = new global::System.Drawing.Size(507, 260);
    //	base.MaximizeBox = false;
    //	base.MinimizeBox = false;
    //	this.Name = "DialogViewBase";
    //	base.ShowInTaskbar = false;
    //	base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
    //	this.Text = "DialogViewBase";
    //	base.ResumeLayout(false);
    //}

    //// Token: 0x0400003C RID: 60
    //private global::System.ComponentModel.IContainer components;
  }
}

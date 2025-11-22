using System.ComponentModel;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.Utils
{
  public partial class FrmErrorMessage : XtraForm
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
      this.ClientSize = new Size(346, 260);
      this.Name = "FrmErrorMessage";
      this.ResumeLayout(false);
    }



    //// Token: 0x06000414 RID: 1044 RVA: 0x0001A173 File Offset: 0x00018373
    //protected override void Dispose(bool disposing)
    //{
    //	if (disposing && this.components != null)
    //	{
    //		this.components.Dispose();
    //	}
    //	base.Dispose(disposing);
    //}

    //// Token: 0x06000415 RID: 1045 RVA: 0x0001A192 File Offset: 0x00018392
    //private void InitializeComponent()
    //{
    //	base.SuspendLayout();
    //	base.ClientSize = new global::System.Drawing.Size(346, 260);
    //	base.Name = "FrmErrorMessage";
    //	base.ResumeLayout(false);
    //}

    //// Token: 0x040001EC RID: 492
    //private global::System.ComponentModel.IContainer components;
  }
}

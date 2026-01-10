using System.ComponentModel;
using System.Windows.Forms;

namespace NhuaNong.UserControls
{
  partial class ucThanhGom
  {
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && components != null)
        components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      // 
      // ucThanhGom
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Transparent;
      this.Name = "ucThanhGom";
      this.Size = new System.Drawing.Size(400, 25);
      this.ResumeLayout(false);
    }
  }
}

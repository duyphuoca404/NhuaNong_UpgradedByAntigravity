using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using NhuaNong.Utils;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong
{
  public partial class ControlViewBase
  {
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      // 
      // ControlViewBase
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "ControlViewBase";
      this.Size = new System.Drawing.Size(743, 382);
      this.ResumeLayout(false);

    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhuaNong.UserControls
{
  public partial class ucBtnXaCan
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
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.DarkGray;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.Name = "ucBtnXaCan";
      this.Size = new Size(51, 22);
      this.Click += new EventHandler(this.ucBtnXaCan_Click);
      this.ResumeLayout(false);
    }
  }
}

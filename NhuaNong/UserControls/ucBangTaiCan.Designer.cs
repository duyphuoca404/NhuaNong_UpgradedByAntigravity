using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NhuaNong.UserControls
{
  public partial class ucBangTaiCan
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
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image)ResourceNhua._btc;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = "ucBangTaiCan";
      this.Size = new Size(360, 30);
      this.Click += new EventHandler(this.ucBangTaiCan_Click);
      this.MouseDown += new MouseEventHandler(this.ucBangTaiCan_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBangTaiCan_MouseUp);
      this.ResumeLayout(false);
    }
  }
}

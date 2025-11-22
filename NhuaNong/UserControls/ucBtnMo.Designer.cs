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
  public partial class ucBtnMo
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
      this.BackgroundImage = (Image)ResourceNhua._btnMo;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = "ucBtnMo";
      this.Size = new Size(100, 40);
      this.Click += new EventHandler(this.ucBtnMo_Click);
      this.MouseDown += new MouseEventHandler(this.ucBtnMo_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBtnMo_MouseUp);
      this.ResumeLayout(false);
    }
  }
}

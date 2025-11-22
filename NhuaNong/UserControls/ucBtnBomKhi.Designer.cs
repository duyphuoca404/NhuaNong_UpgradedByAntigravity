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
  public partial class ucBtnBomKhi
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
      this.BackgroundImage = (Image)ResourceNhua._tinhieu_BomKhi;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = "ucBtnBomKhi";
      this.Size = new Size(32, 24);
      this.Click += new EventHandler(this.ucBtnBomKhi_Click);
      this.MouseDown += new MouseEventHandler(this.ucBtnBomKhi_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBtnBomKhi_MouseUp);
      this.ResumeLayout(false);
    }
  }
}

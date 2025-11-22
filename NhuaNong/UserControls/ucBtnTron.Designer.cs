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
  public partial class ucBtnTron
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
      this.BackColor = Color.Silver;
      this.BackgroundImage = (Image)ResourceNhua._btnTron;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.DoubleBuffered = true;
      this.Name = "ucBtnTron";
      this.Size = new Size(20, 20);
      this.Click += new EventHandler(this.ucBtnTron_Click);
      this.MouseDown += new MouseEventHandler(this.ucBtnTron_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBtnTron_MouseUp);
      this.ResumeLayout(false);
    }
  }
}

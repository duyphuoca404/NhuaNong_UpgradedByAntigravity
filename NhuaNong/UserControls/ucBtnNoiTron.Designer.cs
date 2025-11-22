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
  public partial class ucBtnNoiTron
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
      this.BackColor = Color.White;
      this.BackgroundImage = (Image)ResourceNhua._btnNoiTron;
      this.Name = "ucBtnNoiTron";
      this.Size = new Size(32, 32);
      this.Click += new EventHandler(this.ucBtnNoiTron_Click);
      this.MouseDown += new MouseEventHandler(this.ucBtnNoiTron_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucBtnNoiTron_MouseUp);
      this.ResumeLayout(false);
    }
  }
}

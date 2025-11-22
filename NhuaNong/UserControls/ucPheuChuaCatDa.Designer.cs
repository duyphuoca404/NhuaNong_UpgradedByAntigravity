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
  public partial class ucPheuChuaCatDa
  {
    private IContainer components;
    private Label lblName;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblName = new Label();
      this.SuspendLayout();
      this.lblName.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
      this.lblName.Location = new Point(3, 21);
      this.lblName.Name = "lblName";
      this.lblName.Size = new Size(69, 21);
      this.lblName.TabIndex = 0;
      this.lblName.Text = "AGG1";
      this.lblName.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.Transparent;
      this.BackgroundImage = (Image)ResourceNhua._pheu_chua_catda;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.Controls.Add((Control)this.lblName);
      this.DoubleBuffered = true;
      this.Name = "ucPheuChuaCatDa";
      this.Size = new Size(75, 75);
      this.ResumeLayout(false);
    }
  }
}

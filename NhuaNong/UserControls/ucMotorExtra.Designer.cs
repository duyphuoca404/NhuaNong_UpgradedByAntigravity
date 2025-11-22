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
  public partial class ucMotorExtra
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
      this.BackgroundImage = (Image)ResourceNhua._motor_extra;
      this.BackgroundImageLayout = ImageLayout.Center;
      this.DoubleBuffered = true;
      this.Name = "ucMotorExtra";
      this.Size = new Size(120, 102);
      this.Click += new EventHandler(this.ucMotorExtra_Click);
      this.MouseDown += new MouseEventHandler(this.ucMotorExtra_MouseDown);
      this.MouseUp += new MouseEventHandler(this.ucMotorExtra_MouseUp);
      this.ResumeLayout(false);
    }
  }
}
